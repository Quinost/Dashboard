namespace Dashboard.Functions.Functions.Bugs.Queries.GetBugsList;
public class GetBugsListQuery : IRequest<BugsWithCountRead>
{
    public GetBugsListQuery(int startIndex, int count)
    {
        StartIndex = startIndex;
        Count = count;
    }

    public int StartIndex { get; }

    public int Count { get; }
}
