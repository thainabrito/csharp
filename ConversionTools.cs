namespace conversion_tools;

public class ConversionTools
{

    public string? strVariable;
    public int? intVariable;
    public double? doubleVariable;

    public void ConvertStrToInt(string entry)
    {
        strVariable = entry;
        intVariable = Convert.ToInt32(strVariable);
    }

    public void ConvertStrToDouble(string entry)
    {
        strVariable = entry;
        doubleVariable = Convert.ToDouble(strVariable);
    }

    public void ConvertIntToStr(int entry)
    {
        intVariable = entry;
        strVariable = Convert.ToString(intVariable);
    }

    public void ConvertDoubleToStr(double entry)
    {
        doubleVariable = entry;
        strVariable = Convert.ToString(doubleVariable);
    }

}
