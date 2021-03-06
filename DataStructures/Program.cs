﻿using DataStructures.Core.LinkedList.SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        private static int _choice, _data, _k, _x;

        private static string _input;

        public static void BubbleSort(int[] array)
        {
            int count = array.Length;

            for (int x = count - 2; x >= 0; x--)
            {
                var swap = false;
                for (int j = 0; j <= x; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];

                        array[j] = array[j + 1];

                        array[j + 1] = temp;

                        swap = true;
                    }
                }

                if (swap == false)
                {
                    break;
                }
            }
        }

        static void Main(string[] args)
        {

            var array = new int[]{101,6,23,3,98,8,13,5,97,103};

            BubbleSort(array);

            var list = new SingleLinkedList<string>();

            PopulateList(list);

            list.PrintList();

            while (true)
            {
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count List");
                Console.WriteLine("3. Search List");
                Console.WriteLine("4. Insert at beginning of list");
                Console.WriteLine("5. Insert at end of list");


                Console.WriteLine("Enter your choice:");
                _choice = Convert.ToInt32(Console.ReadLine());

                switch (_choice)
                {
                    case 1:
                        list.PrintList();
                        break;
                    case 2:
                        Console.WriteLine($"Elements in list: {list.Count()}");
                        break;
                    case 3:
                        Console.WriteLine("Enter the element to be searched:");
                        _input = Console.ReadLine();

                        var found = list.Contains(_input);

                        Console.WriteLine($"Element found: {found}");
                        break;
                    case 4:
                        Console.WriteLine("Enter the element to insert at front of list:");

                        _input = Console.ReadLine();

                        list.AddFirst(_input);

                        list.PrintList();
                        break;

                    case 5:
                        Console.WriteLine("Enter the element to insert at end of list:");

                        _input = Console.ReadLine();

                        list.AddLast(_input);

                        list.PrintList();
                        break;
                }
            }
        }

        public static void PopulateList(SingleLinkedList<string> list)
        {
            Console.WriteLine("Enter elements to add to list followed by an empty line when finished:");

            var x = "";
            while ((x = Console.ReadLine()) != "")
            {
                list.AddLast(x);
            }
        }
    }
}
