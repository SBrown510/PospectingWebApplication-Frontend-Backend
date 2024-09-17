using DraftProspectsFrontEnd.DataTypes;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("AppClient");
    }

    public async Task<string> GetSomeDataAsync()
    {
        var response = await _httpClient.GetAsync("api/data");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<IEnumerable<WeatherForecast>> GetWeatherForecast()
    {

        return await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("WeatherForecast");
    }

    public async Task<List<NCAAHockeyStats>> GetNCAAPPGAvg()
    {
        return await _httpClient.GetFromJsonAsync<List<NCAAHockeyStats>>("NCAA");
    }
}