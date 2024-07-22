using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myExpenses
{
    public class ExpnsesServis
    {
        public string GenerateNewPassword()
        {
            Random rnd = new Random();
            string Rand = Convert.ToString(rnd.Next());

            return Rand;

        }

        public void Exception(string InPut)
        {
            if (string.IsNullOrEmpty(InPut))
            {
                MessageBox.Show(" !فید هارا پرنماید");
                
            }
            
        }
    }
    
}
