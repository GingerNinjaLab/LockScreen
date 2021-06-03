using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace LockScreen
{
    class Program
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool LockWorkStation();

        static void Main(string[] args)
        {
            if (!LockWorkStation())
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }
        }
    }
}
