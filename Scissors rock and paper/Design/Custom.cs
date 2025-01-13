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
            Say.Animate("--------------------------------------------------------------------------->", 1);
        }
        public static void Natenadze()
        {
            Console.WriteLine();
            Console.WriteLine(" ██████╗  ██████╗  ██████╗██╗  ██╗     ██████╗  █████╗ ███╗   ███╗███████╗\r\n ██╔══██╗██╔═══██╗██╔════╝██║ ██╔╝    ██╔════╝ ██╔══██╗████╗ ████║██╔════╝\r\n ██████╔╝██║   ██║██║     █████╔╝     ██║  ███╗███████║██╔████╔██║█████╗  \r\n ██╔══██╗██║   ██║██║     ██╔═██╗     ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝  \r\n ██║  ██║╚██████╔╝╚██████╗██║  ██╗    ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗\r\n ╚═╝  ╚═╝ ╚═════╝  ╚═════╝╚═╝  ╚═╝     ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝");
        }

    }
}
