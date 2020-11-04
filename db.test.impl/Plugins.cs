using System;
using System.Linq;

namespace db.test.impl
{
    public class Plugins : IPluginFactory
    {
        private static readonly Plugins Instance = new Plugins();
        private readonly IPlugin[] _plugins = 
        {
            new Sum(), new Subtraction(), new Multiplication(), new Division(),
            new Remnant(), new Root(), new And(), new Or(),
            new Average(), new Max(), new Min(), new Log(),
            new Power()
        };

        public static Plugins GetPlugins()
        {
            return Instance;
        }

        public int PluginsCount => _plugins.GetLength(0);
        public string[] GetPluginNames => _plugins.Select(x => x.PluginName).ToArray();

        public IPlugin GetPlugin(string pluginName) => Array.Find(_plugins, x => x.PluginName == pluginName);
    }
}
