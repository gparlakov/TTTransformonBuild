using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class EnsureOtherProjectsGetBuildBeforeThisOne
    {
        public static void Main()
        {
            var te1 = Nom1.EnumFu.te1;

            var mu1 = Nomenclature.EnumMu.Mu1;

            Console.WriteLine(te1);
            Console.WriteLine(mu1);
        }
    }
}
