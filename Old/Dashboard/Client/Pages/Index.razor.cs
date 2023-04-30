using Dashboard.Client.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Dashboard.Client.Pages;

public partial class Index
{
    [Inject] private ISnackbar service { get; set; }
    public void Show()
    {
        service.Add($"Normal notification", Severity.Normal);
        service.Add($"Info notification", Severity.Info);
        service.Add($"Success notification", Severity.Success);
        service.Add($"Warning notification", Severity.Warning);
        service.Add($"Error notification", Severity.Error);
    }
}
