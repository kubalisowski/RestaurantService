using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AppService
    {
        public void Help()
        {
            foreach (var command in commands)
            {
                Console.WriteLine(command);
            }
            Console.WriteLine();
        }

        public string[] commands = new string[5]
        {
            "display => Show whole menu.",
            "add => Add item to your order",
            "help => Show help.",
            "pay => Pay your order and show cash balance after operation.",
            "quit => Exit application."
        };
    }
}
