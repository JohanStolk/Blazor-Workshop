using Microsoft.AspNetCore.Components;

namespace BlazorKnowledge.Client.Code;

/// <summary>
/// the base class used by the razor file, must be derived from ComponentBase
/// note the different syntax for [Inject] (attribute)
/// be aware: [Inject] can only be used on classes derived from ComponentBase!
/// in other classes just use the usual ctor injection approach
///
/// The sole reason for the existence of the InjectAttribute is to use the @inject tag in Razor pages.
/// When you use the @inject tag, Blazor will generate a public property on your Blazor Component that is marked with [Inject]
/// </summary>
public class Step06InheritAndInjectInCodeBase : ComponentBase
{
    [Inject] protected NavigationManager NavigationManager { get; set; } = null!;

    protected void Callback(string url)
    {
        NavigationManager.NavigateTo(url);
        Console.WriteLine($"the button was clicked at {DateTime.Now}");
    }
}
