using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ3
{

    class PalindromeChecker
    {
        public static bool IsPalindrome(string input)
        {
            // Перетворюємо введене слово у нижній регістр і видаляємо символи розділення
            string cleanedInput = input.ToLower().Replace(" ", "");

            // Перевіряємо, чи слово залишається незмінним при зворотньому читанні
            for (int i = 0; i < cleanedInput.Length / 2; i++)
            {
                if (cleanedInput[i] != cleanedInput[cleanedInput.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть слово для перевірки на паліндромність:");
            string input = Console.ReadLine();

            try
            {
                bool isPalindrome = PalindromeChecker.IsPalindrome(input);

                if (isPalindrome)
                {
                    Console.WriteLine($"{input} є паліндромом.");
                }
                else
                {
                    Console.WriteLine($"{input} не є паліндромом.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}