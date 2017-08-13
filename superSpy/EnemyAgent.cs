using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superSpy
{
    class EnemyAgent

    {

        public string Borscht = "KGB Agent";
        private string Vodka = "Russian Standard";

        SecretAgent FakeAgent = new SecretAgent();
        //string FakeAgentRealName = FakeAgent.RealName;
        //Cannot access this property even by instanciating an object from this class
        //As the Propety is set to private

        /* public string GetPassword () {

            string ThePassword = FakeAgent.Password;
            return The Password;
        } */
        //Nice try!
    }
}
