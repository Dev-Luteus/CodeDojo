using System;

namespace MiniKata5
{
    class Program
    {
        static void Main(string[] args)
        {
            Attack(15);
            Heal(10);
        }
        static void Attack(int damage)
        {
            Console.WriteLine($"You dealt {damage} damage!");
        }
        static void Heal(int healAmount)
        {
            Console.WriteLine($"You restored {healAmount} health!");
        }
    }
}
