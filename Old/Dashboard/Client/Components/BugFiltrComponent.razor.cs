using Microsoft.AspNetCore.Components;

namespace Dashboard.Client.Components;

public partial class BugFiltrComponent
{
    [Parameter]
    public List<string> Input { get; set; }

    [Parameter]
    public EventCallback<List<string>> Output { get; set; }

    internal List<FiltrModel> FilteringList { get; set; } = new List<FiltrModel>();

    public List<string> GetFilteredList() => FilteringList.Where(v => v.Value).Select(v => v.Key).ToList();

    public bool HasItems => GetFilteredList().Count != 0;

    private bool showDropdown = false;
    public string CssClass => showDropdown ? "show" : null;

    protected override void OnParametersSet()
    {
        var distinctList = Input.Distinct().Except(FilteringList.Select(v => v.Key)).ToList();
        if (distinctList.Count != 0)
        {
            int inputCount = FilteringList.LastOrDefault() is not null ? FilteringList.LastOrDefault().Id : 0;
            distinctList.ForEach(v =>
            {
                var model = new FiltrModel { Id = inputCount, Key = v, Value = false };
                FilteringList.Add(model);
                inputCount++;
            });
        }
    }

    private void ToggleDropdown()
    {
        showDropdown = !showDropdown;
        StateHasChanged();
    }

    public async void FiltrSubmit()
    {
        showDropdown = false;
        await Output.InvokeAsync(GetFilteredList());
    }
}

internal class FiltrModel
{
    public int Id { get; set; }
    public string Key { get; set; }
    public bool Value { get; set; }
}
