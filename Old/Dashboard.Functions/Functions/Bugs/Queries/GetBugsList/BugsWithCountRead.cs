namespace Dashboard.Functions.Functions.Bugs.Queries.GetBugsList;
public class BugsWithCountRead
{
    public int TotalCount { get; set; }
    public IEnumerable<BugRead> Bugs { get; set; }
}
