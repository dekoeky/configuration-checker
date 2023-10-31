using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace Dekoeky.ConfigurationVisualization.Helpers;

public class ConfigurationHelper
{
    private readonly ImmutableSortedDictionary<string, string?> _dictionary;

    //private readonly IConfiguration _configuration;

    public ConfigurationHelper(IConfiguration configuration)
    {
        //_configuration = configuration;
        _dictionary = configuration.AsEnumerable().OrderBy(kv => kv.Key).ToImmutableSortedDictionary();
    }

    public ReadOnlyDictionary<string, string?> GetDictionary() => _dictionary.AsReadOnly();
}