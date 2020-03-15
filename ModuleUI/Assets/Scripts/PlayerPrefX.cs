// ArrayPrefs2 v 1.4

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class PlayerPrefsX
{
    static private int endianDiff1;
    static private int endianDiff2;
    static private int idx;
    static private byte[] byteBlock;

    enum ArrayType { String }
    private static void Initialize()
    {
        if (System.BitConverter.IsLittleEndian)
        {
            endianDiff1 = 0;
            endianDiff2 = 0;
        }
        else
        {
            endianDiff1 = 3;
            endianDiff2 = 1;
        }
        if (byteBlock == null)
        {
            byteBlock = new byte[4];
        }
        idx = 1;
    }
    public static bool SetStringArray(String key, String[] stringArray)
    {
        var bytes = new byte[stringArray.Length + 1];
        bytes[0] = System.Convert.ToByte(ArrayType.String); // Identifier
        Initialize();

        // Store the length of each string that's in stringArray, so we can extract the correct strings in GetStringArray
        for (var i = 0; i < stringArray.Length; i++)
        {
            if (stringArray[i] == null)
            {
                Debug.LogError("Can't save null entries in the string array when setting " + key);
                return false;
            }
            if (stringArray[i].Length > 255)
            {
                Debug.LogError("Strings cannot be longer than 255 characters when setting " + key);
                return false;
            }
            bytes[idx++] = (byte)stringArray[i].Length;
        }

        try
        {
            PlayerPrefs.SetString(key, System.Convert.ToBase64String(bytes) + "|" + String.Join("", stringArray));
        }
        catch
        {
            return false;
        }
        return true;
    }

    public static String[] GetStringArray(String key)
    {
        if (PlayerPrefs.HasKey(key))
        {
            var completeString = PlayerPrefs.GetString(key);
            var separatorIndex = completeString.IndexOf("|"[0]);
            if (separatorIndex < 4)
            {
                Debug.LogError("Corrupt preference file for " + key);
                return new String[0];
            }
            var bytes = System.Convert.FromBase64String(completeString.Substring(0, separatorIndex));
            if ((ArrayType)bytes[0] != ArrayType.String)
            {
                Debug.LogError(key + " is not a string array");
                return new String[0];
            }
            Initialize();

            var numberOfEntries = bytes.Length - 1;
            var stringArray = new String[numberOfEntries];
            var stringIndex = separatorIndex + 1;
            for (var i = 0; i < numberOfEntries; i++)
            {
                int stringLength = bytes[idx++];
                if (stringIndex + stringLength > completeString.Length)
                {
                    Debug.LogError("Corrupt preference file for " + key);
                    return new String[0];
                }
                stringArray[i] = completeString.Substring(stringIndex, stringLength);
                stringIndex += stringLength;
            }

            return stringArray;
        }
        return new String[0];
    }

}