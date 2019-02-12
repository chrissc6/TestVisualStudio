using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVisualStudio
{
    class Program
    {
        static string Name => "Chris";

        static void Main(string[] args)
        {
            var total = 0;
            foreach (var i in new int[] { 1, 2, 3, 4, 5 })
            {
                total += i;
            }
        }

        #region you can put a message here "ctors"
        public Program()
        {
            
        }
        public Program(int i)
        {

        }
        public Program(string message)
        {

        }
        #endregion
    }
}

//assemblyinfo.cs can change metadata, under properties