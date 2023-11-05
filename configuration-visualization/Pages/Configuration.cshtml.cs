using System.Collections.ObjectModel;
using Dekoeky.ConfigurationVisualization.Helpers;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dekoeky.ConfigurationVisualization.Pages
{
    public class ConfigurationModel : PageModel
    {
        private readonly ConfigurationHelper _helper;

        public ConfigurationModel(ConfigurationHelper helper)
        {
            _helper = helper;
        }

        public ReadOnlyDictionary<string, string?> KeyValues { get; set; } = null!;

        public void OnGet()
        {
            KeyValues = _helper.GetDictionary();
        }
    }
}
