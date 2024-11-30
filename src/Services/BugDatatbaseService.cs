using Microsoft.EntityFrameworkCore;
using ReviewerSuperBugWebApi.Data;

namespace ReviewerSuperBugWebApi.Services;

public class BugDatatbaseService
{
    private BugContext _context;

    public async Task SaveChangesALot()
    {
        _context.Bugs.FirstOrDefault().Name = "test";
        await _context.SaveChangesAsync();

        _context.Bugs.FirstOrDefault().Id = 1;
        await _context.SaveChangesAsync();
    }
    
    public async Task ExtraRemove()
    {
        var toRemove = await _context.Bugs.Where(x => x.Name == "name").ToListAsync();
        _context.Bugs.RemoveRange(toRemove);

        foreach (var toRemoveItem in toRemove)
        {
            _context.Bugs.Remove(toRemoveItem);
        }
    }

    public async Task AddNotAsync()
    {
        var newBug = new Bug
        {
            Name = "another bug"
        };

        _context.Bugs.Add(newBug);
    }

    public async Task<List<Bug>> FilterOnBaseAndAddToList()
    {
        var bugs = await _context.Bugs.AsNoTracking().ToListAsync();

        return bugs.Where(x => x.Name == "another bug").ToList(); // лишний ToList()
    }

    public async Task<IEnumerable<Bug>> UnionDistinct()
    {
        var bugs = _context.Bugs.Union(_context.Bugs).Distinct();

        return bugs.ToArray();
    }
}