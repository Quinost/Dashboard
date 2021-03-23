using Dashboard.Client.Components.Modals;
using Dashboard.Client.Services;
using Dashboard.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dashboard.Client.Pages
{
    public partial class Bugs
    {
        [Inject]
        public BugsService bugService { get; set; }

        private async ValueTask<ItemsProviderResult<BugModel>> LoadBugs(ItemsProviderRequest request)
        {
            var bugsList = await bugService.GetPaginatedBugs(request.StartIndex, request.Count);
            return new ItemsProviderResult<BugModel>(bugsList, 500);
        }

        private void ShowModal(int Id)
        {
        }
    }
}
