using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
			Tree tree = new Tree();
			var array = new int[] { 1, 1, 1, 1, 1, 2, 4, 5, 6, 7, 4 };
			for (int index = 0; array.Length > index; index++)
			{
				tree.AddTreeElement(array[index]);
			}


		}
	}
}
