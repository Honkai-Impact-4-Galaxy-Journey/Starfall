using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginAPI.Core.Attributes;

namespace Starinfall
{
    public class MainConfig
    {
        [Description("MySQL连接字符串")]
        public string ConnectionString { get; set; } = "server=127.0.0.1;database=scp;user=root;password=123456;charset=utf-8";
    }
    public class PluginMain
    {
        [PluginConfig] public MainConfig Config;
        public static PluginMain Instance { get; private set; }
        [PluginEntryPoint("Starinfall","1.0.0","-","Honkai Impact 4: Galaxy Journey Team")]
        public void OnEnabled()
        {
            Instance = this;
        }
    }
}
