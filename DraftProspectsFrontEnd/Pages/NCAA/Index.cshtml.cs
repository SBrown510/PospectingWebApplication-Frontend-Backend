using DraftProspectsFrontEnd.DataTypes;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DraftProspectsFrontEnd.Pages.NCAA
{
    public class NCAAPPGModel : PageModel
    {
        private readonly ApiService _apiService;
        private readonly Logger<NCAAPPGModel> logger;

        public NCAAPPGModel(ApiService apiService)
        {
            _apiService = apiService;
        }

        public IEnumerable<NCAAHockeyStats> GetNCAAPPGAvg { get; private set; }

        public async Task OnGetAsync()
        {
            GetNCAAPPGAvg = await _apiService.GetNCAAPPGAvg();

            if (GetNCAAPPGAvg == null)
            {
                logger.LogError("FUCKKK");
            }
        }
    }
}
