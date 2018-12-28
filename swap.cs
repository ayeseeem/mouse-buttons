// ayeseeem@gmail.com 2011-11-08
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

class SwapMouse
{
    [DllImport("user32.dll")]
    static extern Int32 SwapMouseButton(Int32 bSwap);

    static void Main(string[] args)
    {
        if (args.Length == 0) 
        {
            SwapButtons();
        }
        else if (args.Length > 0 && String.Compare(args[0], "/R", true) == 0)
            // set for right-handed
            SetButtonsNormal();
        else if (args.Length > 0 && String.Compare(args[0], "/L", true) == 0)
            // set for left-handed
            SetButtonsSwapped();
        else
        {
            // Help
            Console.WriteLine("swaps the mouse buttons");
            Console.WriteLine(" no args - toggles left and right");
            Console.WriteLine(" /R - set for normal Right-handed use");
            Console.WriteLine(" /L - set for normal Left-handed use");
        }
    }

    static void SwapButtons()
    {
        // try to toggle
        bool swapped = SystemInformation.MouseButtonsSwapped;
        if (swapped)
        {
            SetButtonsNormal();
        }
        else
        {
            SetButtonsSwapped();
        }
    }

    static void SetButtonsNormal()
    {
        SwapMouseButton(0);
    }

    static void SetButtonsSwapped()
    {
        SwapMouseButton(1);
    }

}
