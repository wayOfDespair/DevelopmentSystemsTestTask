namespace db.test.impl
{
    public abstract class Plugin : IPlugin
    {
        public string PluginName { get; }
        public string Version { get; }
        public System.Drawing.Image Image { get; }
        public string Description { get; }

        public virtual int Run(int input1, int input2)
        {
            return 0;
        }

        protected Plugin(string pluginName, string version, System.Drawing.Image image, string description)
        {
            PluginName = pluginName;
            Version = version;
            Image = image;
            Description = description;
        }
    }
}
