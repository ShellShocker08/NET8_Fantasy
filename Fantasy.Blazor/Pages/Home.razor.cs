using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Fantasy.Blazor.Pages;

public partial class Home
{
    [Inject] private IStringLocalizer<Literals> Localizer { get; set; } = null!;
}