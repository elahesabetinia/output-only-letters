using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" enter only letters and for exist press 'Q'.");

        while (true)
        {
            // خواندن کلید از کاربر
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // intercept: true از نمایش خودکار جلوگیری می‌کند

            // بررسی کلید وارد شده برای خروج
            if (keyInfo.Key == ConsoleKey.Q)
            {
                Console.WriteLine("\n EXIST from code.");
                break;
            }

            // بررسی اینکه آیا کلید وارد شده یک حرف است
            if (char.IsLetter(keyInfo.KeyChar))
            {
                // نمایش حرف در خروجی
                Console.Write(keyInfo.KeyChar);
            }
        }
    }
}
