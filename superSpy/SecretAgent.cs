using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superSpy
{
    class SecretAgent
    {
        public string Alias = "Dash Martin";
        private string RealName = "Herb Jones";
        private string Password = "the crow flies at midnight";

        public string AgentGreeting (string input)
        {
            if (input == Password)
            {
                return RealName;
            }
            else
            {
                return Alias;
            }
        }

    }
}
