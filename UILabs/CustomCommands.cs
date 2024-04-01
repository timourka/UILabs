using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UILabs
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand command = new RoutedUICommand("command", "command", typeof(CustomCommands));
        public static readonly RoutedUICommand zero = new RoutedUICommand("zero", "zero", typeof(CustomCommands));
    }
}
