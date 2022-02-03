
using System.Text;

namespace Lesson3 {
    
    class L3 
    {
        static String ReadPassword(char replaceChar = '*') {
            var sb = new StringBuilder();
            ConsoleKeyInfo k = Console.ReadKey(true);
            while(k.Key != ConsoleKey.Enter) 
            {
                sb.Append(k.KeyChar);
                Console.Write(replaceChar);
                k = Console.ReadKey(true);
            }
            return sb.ToString();
        }
        static int ReadInt() {
             var sb = new StringBuilder();
            ConsoleKeyInfo k = Console.ReadKey(true);
            Console.WriteLine();
            while(k.Key!= ConsoleKey.Enter && sb.Length < 9) 
            {
                if(k.KeyChar >= '0' && k.KeyChar <= '9'
                    || k.KeyChar == '-' && sb.Length == 0) {
                        Console.WriteLine($"char : {k.KeyChar}, key : {k.Key}");
                        sb.Append(k.KeyChar);
                }
                else if(k.Key == ConsoleKey.Backspace && sb.Length > 0) {
                    sb.Remove(sb.Length-1,1);
                    Console.Write(k.KeyChar);
                    Console.WriteLine();
                    Console.Write(k.Key);
                }
                k = Console.ReadKey(true);
            }
            return Convert.ToInt32(sb.ToString());
        }

        static void Main(string[] args) 
        {
            //Console.Clear();
            Console.WriteLine("Приветствие!");
            Console.WriteLine();
            Console.Write("Введите пароль:");
            String str = ReadPassword();
            Console.Write($"\nВы введи: {str}");
            //int x;
            //try {
            //    x = ReadInt();
            //} catch {
            //    Console.WriteLine("Ошибка преобразования числа");
            //    return;
            //}
            //Console.WriteLine($"вы ввели '{x}'");


            //string str = Console.ReadLine();
            //Console.WriteLine("Вы ввели: '{0}'", str);
            //Console.WriteLine($"Вы ввели: '{str}'");
        }
    }
}