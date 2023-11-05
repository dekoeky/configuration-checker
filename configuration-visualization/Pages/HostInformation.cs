using System.Collections.ObjectModel;
using Dekoeky.ConfigurationVisualization.Helpers;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dekoeky.ConfigurationVisualization.Pages;

public class HostInformationModel : PageModel
{

    public HostInformationModel()
    {
        ProcessBits = Environment.Is64BitProcess ? "64 Bits" : "32 Bits";
        OSBits = Environment.Is64BitOperatingSystem ? "64 Bits" : "32 Bits";
        MachineName = Environment.MachineName;
        OSVersion = Environment.OSVersion.ToString();
        ProcessorCount = $"{Environment.ProcessorCount} CPUs";
        CurrentLocalTime = DateTime.Now;
        Version = Environment.Version.ToString();
        UserName = Environment.UserName;
    }

    public string ProcessBits { get; }
    public string OSBits { get; }
    public string MachineName { get; }
    public string OSVersion { get; }
    public string ProcessorCount { get; }
    public DateTime CurrentLocalTime { get; }
    public string UserName { get; }
    public string Version { get; }

    public void OnGet()
    {
    }
}
