using Avalonia.ReactiveUI;
using Avalonia.Web.Blazor;

namespace HelloAvaloniaNdc.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        
        WebAppBuilder.Configure<HelloAvaloniaNdc.App>()
            .UseReactiveUI()
            .SetupWithSingleViewLifetime();
    }
}