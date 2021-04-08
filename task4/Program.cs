using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
			Tree tree = new Tree();
			var array = new int[] { 1, 1, 2, 3, 1, 2, 4, 5, 6, 7, 4 };
			int count;
            for (int index = 0; index < array.Length; index++)
            {
                tree.AddTreeElement(array[index]);
            }

            for (int index = 0; index < array.Length; index++)
            {
                Console.WriteLine($"Элемент {array[index]} Найден? {tree.FindElement(array[index], out count)} Количество - {count}");
            }
            Console.WriteLine("------------------");
            Console.WriteLine($"Элемент {10} Найден? {tree.FindElement(10, out count)} Количество - {count}");
            Console.WriteLine($"Элемент {15} Найден? {tree.FindElement(15, out count)} Количество - {count}");
            Console.WriteLine($"Элемент {20} Найден? {tree.FindElement(20, out count)} Количество - {count}");
        }
	}
}
