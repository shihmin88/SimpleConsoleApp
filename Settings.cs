using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsoleApp
{
    internal class Settings
    {
        public string? AppName { get; set; }
        public string? ProviderName { get; set; }
        public ConnectionStrings? ConnectionStrings { get; set; }
    }
}

public class ConnectionStrings
{
    public string? DbBox { get; set; }
}
