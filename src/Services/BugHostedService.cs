using ReviewerSuperBugWebApi.Data;

namespace ReviewerSuperBugWebApi.Services;

public class BugHostedService(ILogger<BugHostedService> logger): IHostedService
{
    IList<int> list = new List<int>();
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        return default;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return default;
    }

    private int? NullableIntegerValue;

    public int? GetNullableInteger()
    {
        return NullableIntegerValue.HasValue ? NullableIntegerValue.Value * 100 : null;
    }

    public List<string?> GetNullableStrings()
    {
        return ["abc", "bcd", null];
    }
    
    public List<string>? GetNullableCollection()
    {
        return null;
    }

    public string GetInterpolatedStrings()
    {
        var insertion = NullableIntegerValue.ToString();
        var interpStr = "abc"
                        + insertion
                        + "bcd"
                        + "cde";

        return interpStr;
    }

    public void GetLogDuplication()
    {
        try
        {

        }
        catch (Exception e)
        {
            logger.LogInformation(e, e.Message);
        }
    }

    public void Calculate()
    {
        var value = 2000d;
        int netWeight = Convert.ToInt32(value) / 1000;
        int netWeight2 = (int)(value / 1000);
    }

    public void CheckNullableArgs(string str)
    {
        
    }

    public string? ReturnNull()
    {
        return null;
    }

    public void ChunkLinq()
    {
        var strs = new List<string>
        {
            "1", "2", "3"
        };

        var splitted = strs.Chunk(10).ToList();
    }
}