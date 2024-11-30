using Microsoft.EntityFrameworkCore;

namespace ReviewerSuperBugWebApi.Data;

public class BugContext: DbContext
{
    public virtual DbSet<Bug> Bugs { get; set; }
}