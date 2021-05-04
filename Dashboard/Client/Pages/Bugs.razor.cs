using Dashboard.Client.Services;
using Dashboard.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Dashboard.Client.Services.Interfaces;

namespace Dashboard.Client.Pages
{
    public partial class Bugs
    {
        [Inject]
        public IBugsService bugService { get; set; }

        public List<string> SystemList { get; set; } = new List<string>();
        private List<BugModel> BugsList { get; set; } = new List<BugModel>();
        private List<string> FiltrList { get; set; } = new List<string>();

        private Virtualize<BugModel> Virtualize { get; set; }

        private int TotalCount = 0;

        private async ValueTask<ItemsProviderResult<BugModel>> LoadBugs(ItemsProviderRequest request)
        {
            var req = request.StartIndex + request.Count;
            if(req > BugsList.Count())
                await LoadMoreBugs();

            var list = FiltrList.Count == 0 ? BugsList : BugsList.Where(v => FiltrList.Contains(v.System)).ToList(); 
            var totalCount = FiltrList.Count == 0 ? TotalCount : list.Count;

            var bugs = list.Skip(request.StartIndex).Take(request.Count);
            return new ItemsProviderResult<BugModel>(bugs, totalCount);
        }

        private async Task LoadMoreBugs()
        {
            var bugs = await bugService.GetPaginatedBugs(BugsList.Count(), 200);
            BugsList.AddRange(bugs.Bugs);
            TotalCount = bugs.TotalCount;
            BugsList = BugsList.Distinct().ToList();
            SystemList.AddRange(BugsList.Select(v => v.System));
            StateHasChanged();
        }

        private void ShowModal(int Id)
        {
        }

        public async void FilterSelected(List<string> param)
        {
            FiltrList = param;
            await Virtualize.RefreshDataAsync();
        }
    }
}
