using DraftProspectsFrontEnd.DataTypes;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DraftProspectsFrontEnd.Pages.Weather
{
    public class WeatherPageModel : PageModel
    {
        private readonly ApiService _apiService;
        private readonly Logger<WeatherPageModel> logger;

        public WeatherPageModel(ApiService apiService)
        {
            _apiService = apiService;
        }

        public IEnumerable<WeatherForecast> Forecasts { get; private set; }

        public async Task OnGetAsync() 
        {
            Forecasts = await _apiService.GetWeatherForecast();
            if (Forecasts == null)
            {
                logger.LogError("ITS FUCKING NULL");
            }
        }

    }
}
