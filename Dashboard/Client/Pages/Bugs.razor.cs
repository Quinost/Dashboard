using Dashboard.Shared;
using Microsoft.AspNetCore.Components;
using Dashboard.Client.Services.Interfaces;
using MudBlazor;

namespace Dashboard.Client.Pages;

public partial class Bugs
{
    [Inject] public IBugsService BugService { get; set; }

    private bool _loading = true;
    private IEnumerable<BugModel> BugList = new List<BugModel>();
    private MudTable<BugModel> table;
    private int totalItems;

    private string search;

    private async Task<TableData<BugModel>> ServerReload(TableState state)
    {
        _loading = true;

        var data = await BugService.GetPaginatedBugs(state.Page * state.PageSize, state.PageSize);
        totalItems = data.TotalCount;
        BugList = data.Bugs.ToList();

        if (!string.IsNullOrWhiteSpace(search))
            BugList = BugList.Where(x => x.Message.Contains(search) ||
                                         x.System.Contains(search) ||
                                         x.Id.Equals(search));

        Console.WriteLine(state.SortLabel);
        Console.WriteLine(state.SortDirection);

        if (!string.IsNullOrEmpty(state.SortLabel))
        {
            switch (state.SortDirection)
            {
                case SortDirection.Ascending:
                    BugList = BugList.OrderBy(orderBy[state.SortLabel]);
                    break;
                case SortDirection.Descending:
                    BugList = BugList.OrderByDescending(orderBy[state.SortLabel]);
                    break;
            }
        }

        _loading = false;
        return new TableData<BugModel>() { TotalItems = totalItems, Items = BugList };
    }

    public void OnSearch(string val)
    {
        search = val;
        table.ReloadServerData();
    }

    private Dictionary<string, Func<BugModel, dynamic>> orderBy = new Dictionary<string, Func<BugModel, dynamic>>
    {
        {nameof(BugModel.Id), x => x.Id},
        {nameof(BugModel.System), x => x.System},
        {nameof(BugModel.Message), x => x.Message},
        {nameof(BugModel.Date), x => x.Date},
    };
}
