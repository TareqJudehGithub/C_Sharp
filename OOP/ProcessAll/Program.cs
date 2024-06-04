Console.WriteLine("Exercise: Process All Words\n");


List<string> races = ["Human", "Orcish hordes", "Night Elves", "Taurens Braves"];


StringsProcessor stringsProcess = new StringsProcessor();
StringsUppercaseProcessor stringsUpper = new StringsUppercaseProcessor();
StringsTrimmingProcessor stringsTrimm = new StringsTrimmingProcessor();

List<StringsProcessor> stringsProcessors = new List<StringsProcessor>
{
    stringsUpper,
    stringsTrimm
};

List<string> result = new List<string>();

foreach (StringsProcessor stringsProcessor in stringsProcessors)
{
    result = stringsProcessor.Process(races);
}

foreach (string word in result)
{
    Console.WriteLine(word);
}


public class StringsProcessor
{
    public virtual List<string> Process(List<string> words)
    {
        List<string> result = new List<string>();
        return result;
    }
}
public class StringsUppercaseProcessor : StringsProcessor
{
    public override List<string> Process(List<string> words)
    {
        List<string> result = new List<string>();
        foreach (string word in words)
        {
            result.Add(word.ToUpper());
        }
        return result;
    }
}

public class StringsTrimmingProcessor : StringsProcessor
{
    public override List<string> Process(List<string> words)
    {
        List<string> result = new List<string>();

        foreach (string word in words)
        {
            result.Add(word.Substring(0, word.Length / 2));
        }
        return result;
    }
}
