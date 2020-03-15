[System.Serializable]
public class Stat
{
    public double value;
  //  public TypeOfResource Type;

    public Stat(double value)
    {
        this.value = value;
       // this.Type = Type;
    }

    public bool AddValue(double value)
    {
        if (value > 0)
        {
            this.value += value;
            return true;
        }
        return false;
    }
    public bool ReduceValue(double value)
    {
        if (value > 0 && this.value - value >= 0)
        {
            this.value -= value;
            if (this.value < 0) this.value = 0;
            return true;
        }
        return false;
    }
}
