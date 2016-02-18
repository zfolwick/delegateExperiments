using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
   public class Native
   {
        [StructLayout(LayoutKind.Sequential)]
        public struct MI_ApplicationFT
        {
            public UpperCaseFirstDelegate UpperCaseFirst;
            public UpperCaseLastDelegate UpperCaseLast;
        }

        public delegate string UpperCaseFirstDelegate(string input);

        public delegate string UpperCaseLastDelegate(string input);

        [DllImport("./case.so", CharSet=CharSet.Ansi)]
        public static extern int initializeFT(out MI_ApplicationFT managedAppFT);

       // public static string UpperCaseFirst(string input, int i)
       // {
       //     char[] buf = input.ToCharArray();
       //     buf[0] = char.ToUpper(buf[0]);
       //     Console.WriteLine(++i);
       //     return new string(buf);
       // }

       // public static string UpperCaseLast(string input, int i)
       // {
       //     char[] buf = input.ToCharArray();
       //     buf[buf.Length - 1] = char.ToUpper(buf[buf.Length - 1]);
       //     Console.WriteLine(i+10);
       //     return new string(buf);
       // }

       // public static void WriteOut(string input, MI_ApplicationFT.UpperCaseDelegate del, int i)
       // {
       //     Console.WriteLine("String Before : {0}", input);
       //     Console.WriteLine("String After : {0}", del(input, i));
       // }
   }

    public class Program
    {
        public static void Main(string[] args)
        {
           string testStr = "tester";

           Native.MI_ApplicationFT ft;
           Native.initializeFT(out ft);

           Console.WriteLine("Back From C layer");
           Native.UpperCaseFirstDelegate ucf = ft.UpperCaseFirst;
           Console.WriteLine("delegate assigned");
           string x = ucf(testStr);
           Console.WriteLine("Worked!  result : {0}", x);

           // // C# way of delegates- no p/invokes
           // Console.WriteLine("Hello World!");
           // Native.MI_ApplicationFT.UpperCaseDelegate ucf = new Native.MI_ApplicationFT.UpperCaseDelegate(Native.UpperCaseFirst);
           // Native.WriteOut("derp", ucf, 10);
           // Native.MI_ApplicationFT.UpperCaseDelegate ucl = new Native.MI_ApplicationFT.UpperCaseDelegate(Native.UpperCaseLast);
           // Native.WriteOut("derp", ucl, 10);
           // //Native.WriteOut("derp", new Native.MI_ApplicationFT.UpperCaseDelegate(Native.UpperCaseLast));
        }
    }
}
