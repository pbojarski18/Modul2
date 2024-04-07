using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;

namespace FirstProgram
{

    public class Program
    {
        public static void Main(string[] args)
        {


            //for (int a = 0; a < 10; a++)
            //{
            //    if (a == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("A equals: " + a);
            //}

            //int[] cyfry = new int[10] { 9, 5, 3, 1, 2, 4, 6, 8, 7, 0 };

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Aktualny elemnt tablicy to: " + cyfry[i]);
            //}

            //Array.Sort(cyfry);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Aktualny elemnt tablicy to: " + cyfry[i]);
            //}


            //int wielkoscTablicy = cyfry.Length;

            //int ostatni = cyfry[cyfry.Length - 1];

            //int indexOfFive = Array.IndexOf(cyfry, 5);


            //int[,] cyfry = new int[3, 4] { { 1, 3, 5, 7 }, { 2, 4, 6, 8 }, { 1, 2, 3, 4 } };

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine($"Wartosc z wiersza {i} i kolumny {j} ma wartosc: {cyfry[i, j]}");
            //    }
            //}

            //int[] cyfry = new int[3] { 1, 3, 5 };

            //Array.Clear(cyfry, 1, 2);

            //List<int> list = new List<int>();

            //list.Add(5);

            //list.AddRange(new List<int>() { 1, 2, 3, 4 });

            //List<Item> listOfItems = new List<Item>();


            //HomeworkLoops.Exercise7();

            //Person person = new Person();
            //person.Power = 100;
            //person.Sex = "Male";
            //person.Height = 180;
            //person.Weight = 95;

            //Console.WriteLine(person.Power);

            //ItemService itemService = new ItemService();

            //itemService.AddNewItem();

            //List<Item> result = itemService.GetAllItems();

            //foreach(var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //ItemService itemService = new ItemService();

            //itemService.AddNewItem(2, "Strawberry");

            //var id = itemService.AddNewItem(2, "Strawberry");

            //itemService.AddNewItem(name: "Watermelon", id: 3);


            //string name;
            //itemService.Method(1, out name);

            //string operation = Console.ReadLine();
            //int chosenOperation;
            //Int32.TryParse(operation, out chosenOperation);



            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //Dictionary<int, Item> dictionary = new Dictionary<int, Item>();
            //dictionary.Add(1, new Item(1, "Apple", ItemType.Food));
            //dictionary.Add(2, new Item(2, "Strawberry", ItemType.Food));
            //Item item;

            //dictionary.TryGetValue(1, out item);


            //SortedList<int, Item> sortedList = new SortedList<int, Item>();

            //sortedList.Add(2, new Item(1, "Apple", ItemType.Food));
            //sortedList.Add(1, new Item(2, "Strawberry", ItemType.Food));

            //Queue<Item> queue = new Queue<Item>(); //FIFO -> first in first out
            //queue.Enqueue(new Item(1, "Apple", ItemType.Food));
            //queue.Enqueue(new Item(2, "Strawberry", ItemType.Food));

            //queue.Dequeue(); // pierwszy wytypowany z kolejki do uzycia i usuniecia

            //var queueItem = queue.Dequeue();
            //var peekedItem = queue.Peek(); // podejrzenie pierwszego elementu i zwrocenie bez usuwania

            //Stack<Item> stack = new Stack<Item>(); // LIFO -> last in first out
            //stack.Push(new Item(1, "Apple", ItemType.Food));
            //stack.Push(new Item(2, "Strawberry", ItemType.Food));

            //var stackItem = stack.Pop(); // o samo co queue
            //var peekedStackItem = stack.Peek(); // to samo co queue
            //HomeworkLoops.Exercise3();

            //Can you find the needle in the haystack?

            //Write a function findNeedle() that takes an array full of junk but containing one "needle"

            //After your function finds the needle it should return a message(as a string) that says:

            //"found the needle at position " plus the index it found the needle, so:

            //var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
            //FindNeedle(haystack_1);
            //static string FindNeedle(object[] haystack)
            //{
            //    for (int i = 0; i < haystack.Length; i++)
            //    {
            //        if (haystack[i] == "needle")
            //        {
            //            Console.WriteLine($"needle at position {i}");
            //        }

            //    }
            //    return "needle not found";


            //}
            HomeworkLoops.Exercise4();
        }
    }
}




