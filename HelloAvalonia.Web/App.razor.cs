using Avalonia.Web.Blazor;

namespace HelloAvalonia.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        WebAppBuilder.Configure<HelloAvalonia.App>()
            .SetupWithSingleViewLifetime();

        base.OnParametersSet();
    }
}
