using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scissors_rock_and_paper.Design
{
    internal class Custom
    {
        public static bool YesNo()
        {
            Console.Write(" [Y/N]: ");
            string readline = Console.ReadLine();
            if (readline.ToLower() == "y")
            {
                return true;
            }
            return false;
        }
        public static void Line()
        {
            Say.Animate("---------------------------------------------------------------------->", 1);
        }
        public static void Natenadze()
        {
            Console.WriteLine("  ____       _                                         _                                   \r\n / ___|  ___(_)___ ___  ___  _ __ ___   _ __ ___   ___| | __   _ __   __ _ _ __   ___ _ __ \r\n \\___ \\ / __| / __/ __|/ _ \\| '__/ __| | '__/ _ \\ / __| |/ /  | '_ \\ / _` | '_ \\ / _ \\ '__|\r\n  ___) | (__| \\__ \\__ \\ (_) | |  \\__ \\ | | | (_) | (__|   <   | |_) | (_| | |_) |  __/ |   \r\n |____/ \\___|_|___/___/\\___/|_|  |___/ |_|  \\___/ \\___|_|\\_\\  | .__/ \\__,_| .__/ \\___|_|   \r\n                                                              |_|         |_|              ");
        }

    }
}
