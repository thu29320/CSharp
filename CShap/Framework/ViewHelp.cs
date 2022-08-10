

namespace Book.Framework
{
    using System;
    using static System.Console;
    public static class ViewHelp
    {
        public static void ShowColor(string message, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            ForegroundColor = color;
            WriteLine(message);
            if (resetColor)
                ResetColor();
        }
        public static void Show_Color(string message, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            ForegroundColor = color;
            Write(message);
            if (resetColor)
                ResetColor();
        }
        public static bool InputBool(string label, ConsoleColor labelColor = ConsoleColor.Blue, ConsoleColor valueColor = ConsoleColor.White)
        {
            Show_Color($"{label} [y/n]: ", labelColor);
            ConsoleKeyInfo key = ReadKey();
            Console.WriteLine();
            bool @char = key.KeyChar == 'y' || key.KeyChar == 'Y' ?
                true : false;
            return @char;
        }
        //in ra thong bao tiep nhan chuoi thong tin nguoi dung nhap=>chuyen sang bool
        public static int InputInt(string label, ConsoleColor labelColor = ConsoleColor.Blue, ConsoleColor valueColor = ConsoleColor.White)
        {
            while (true)
            {
                var str = InputString(label, labelColor, valueColor);
                var result = int.TryParse(str, out int i);
                if (result == true)
                {
                    return i;
                }
            }
        }
        public static string InputString(string label, ConsoleColor labelColor = ConsoleColor.Blue, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            Show_Color($"{label}: ", labelColor);//show_color=Console.Write
            ForegroundColor = valueColor;
            string value = ReadLine();
            ResetColor();
            return value;
        }
        public static string InputString(string label,string oldValue, ConsoleColor labelColor = ConsoleColor.Blue, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            Show_Color($"{label}: ", labelColor);//show_color=Console.Write, viet dong thong bao de nguoi dung  nhap du lieu
            ShowColor(oldValue, ConsoleColor.DarkYellow);                  //neu ng dung nhap 1 xau ki tu se ddc tra ve xau do, 
                                                                           //neu an Enter thi se lay gia tri cu(tham so oldVcalue)
            Show_Color("new value>>", ConsoleColor.Green);
            ForegroundColor = valueColor;
            string newValue = ReadLine();
            return string.IsNullOrEmpty(newValue.Trim()) ? oldValue : newValue;
        }
        public static int InputInt(string label, int oldValue, ConsoleColor labelColor = ConsoleColor.Blue, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            Show_Color($"{label}: ", labelColor);//show_color=Console.Write, viet dong thong bao de nguoi dung  nhap du lieu
            ShowColor($"{oldValue}", ConsoleColor.DarkYellow);                  //neu ng dung nhap 1 xau ki tu se ddc tra ve xau do, 
                                                                           //neu an Enter thi se lay gia tri cu(tham so oldVcalue)
            Show_Color("new value>>", ConsoleColor.Green);
            ForegroundColor = valueColor;
            string str = ReadLine();
            if( string.IsNullOrEmpty(str)) return oldValue;
            if (str.ToInt(out int i)) return i;//su dung phuong thuc mo rong ToInt
            return oldValue;
        }
        public static bool InputBool(string label, bool oldValue, ConsoleColor labelColor = ConsoleColor.Blue, ConsoleColor valueColor = ConsoleColor.Blue)
        {
            Show_Color($"{label}: ", labelColor);//show_color=Console.Write, viet dong thong bao de nguoi dung  nhap du lieu
            ShowColor($"{oldValue}", ConsoleColor.DarkYellow);             //neu an Enter thi se lay gia tri cu(tham so oldVcalue)
            Show_Color("new value>>", ConsoleColor.Green);
            ForegroundColor = valueColor;
            string str = ReadLine();
            if (string.IsNullOrEmpty(str)) return oldValue;
            return str.ToBool();
        }
    }
}
