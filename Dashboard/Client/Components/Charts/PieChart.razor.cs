using ChartJs.Blazor;
using ChartJs.Blazor.Common;
using ChartJs.Blazor.PieChart;
using ChartJs.Blazor.Util;

namespace Dashboard.Client.Components.Charts;

public partial class PieChart
{
    private PieConfig _config;
    private Chart _chart;

    protected override void OnInitialized()
    {
        _config = new PieConfig
        {
            Options = new PieOptions
            {
                Responsive = true,
                Title = new OptionsTitle
                {
                    Display = false,
                    Text = "ChartJs.Blazor Pie Chart"
                }
            }
        };

        foreach (string color in new[] { "Red", "Yellow", "Green", "Blue" })
        {
            _config.Data.Labels.Add(color);
        }

        PieDataset<int> dataset = new PieDataset<int>(new[] { 6, 5, 3, 7 })
        {
            BackgroundColor = new[]
            {
            ColorUtil.ColorHexString(255, 99, 132), // Slice 1 aka "Red"
            ColorUtil.ColorHexString(255, 205, 86), // Slice 2 aka "Yellow"
            ColorUtil.ColorHexString(75, 192, 192), // Slice 3 aka "Green"
            ColorUtil.ColorHexString(54, 162, 235), // Slice 4 aka "Blue"
        }
        };

        _config.Data.Datasets.Add(dataset);
    }
}
