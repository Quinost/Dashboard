using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using Dashboard.Shared.Validations;
using FluentValidation;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Dashboard.Client.Pages;

public partial class Configuration
{
    [Inject] public IConfigurationService configurationService { get; set; }

    [Inject] private ISnackbar service { get; set; }

    private MudForm form;

    ConfigurationValidator configurationValidator = new ConfigurationValidator();

    private ConfigurationModel configurationModelTemp;

    private ConfigurationModel model = new ConfigurationModel();


    protected override void OnInitialized()
    {
        DownloadData();
    }

    private async void DownloadData()
    {
        configurationModelTemp = await configurationService.GetConfiguration();
        model = configurationModelTemp;
        StateHasChanged();
    }

    protected async Task OnSubmit()
    {
        await form.Validate();

        if (!form.IsValid)
            return;

        await configurationService.UpdateConfiguration(model);
        service.Add("Configuration updated successfully", MudBlazor.Severity.Success);
        configurationModelTemp = await configurationService.GetConfiguration();
        DownloadData();
    }

    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = configurationValidator.Validate(ValidationContext<ConfigurationModel>.CreateWithOptions((ConfigurationModel)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}
