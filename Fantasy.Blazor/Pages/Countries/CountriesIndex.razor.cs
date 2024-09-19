
using Fantasy.Common.Entities;
using Microsoft.AspNetCore.Components;

namespace Fantasy.Blazor.Pages.Countries;

public partial class CountriesIndex
{
    [Inject]
    private IApiService _api { get; set; } = null!;

    private List<Country>? Countries { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var responseHttp = await _api.GetAsync<List<Country>>("api/Countries");
        Countries = responseHttp.Response;
    }
}
