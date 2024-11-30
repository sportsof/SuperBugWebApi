namespace ReviewerSuperBugWebApi.Models;

public class NullReferenceBugObj
{
    public string Name { get; set; }

    public List<string> Names { get; set; }
    
    public NullReferenceBugObj BugObj { get; set; }
}