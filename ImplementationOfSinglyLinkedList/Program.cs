using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationOfSinglyLinkedList
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();

            int i = Convert.ToInt32(Console.ReadLine()); // начальное число элементов
            int[] array = new int[i];
            LinkedList<int> secondList = new LinkedList<int>();


            for (int j = 0; j < array.Length; j++)
            {
                array[j] = j;
                Console.Write(array[j] + " ");

            }
            Console.Write("\n");

            array = array.OrderBy(n => rnd.Next()).ToArray(); // перешивание элементов массива

            foreach (int t in array)
            {
                Console.Write(t + " ");
            }
            LinkedList<int> linkedList = new LinkedList<int>(array);

            Console.Write("\n");
            if (linkedList.First.Value != 1)
            {
                LinkedListNode<int> current = linkedList.Find(1);
                linkedList.AddFirst(current.Value);
                linkedList.Remove(current);
            }

            foreach (var v in linkedList)
            {
                Console.Write(v + " ");
            }

            //присваиваем переменной индекс, который равен значению первого элемента
            var c = linkedList.ElementAt(linkedList.First.Value);
            secondList.AddLast(c);


            for (int x = 1; x < linkedList.Count - 1; x++)
            {
                ////присваиваем переменной индекс, который равен значению текущего элемента
                if (c == linkedList.Max())
                {
                    c = linkedList.Last.Value;
                    c = linkedList.ElementAt(c);
                    secondList.AddLast(c);
                }
                else
                {
                    c = linkedList.ElementAt(c);
                    secondList.AddLast(c);
                }

            }



            Console.Write("\n");

            foreach (var v in secondList)
            {
                Console.Write(v + " ");
            }

            //Console.WriteLine(linkedList.ElementAt(0));

            Console.ReadLine();

        }
    }
}
//в процессе