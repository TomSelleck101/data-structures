﻿using DataStructures.Core.LinkedList.SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataStructures.Core.Implementation.Tree;
using DataStructures.Core.Interface.Tree;
using DataStructures.Core.LinkedList.SingleLinkedList.Implementation;

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

        public static void MergeSort(int[] array)
        {
            MergeSort(array, new int[array.Length], 0, array.Length - 1);
        }

        private static void MergeSort(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
            {
                return;
            }

            int middle = (leftStart + rightEnd) / 2;

            MergeSort(array, temp, leftStart, middle);
            MergeSort(array, temp, middle + 1, rightEnd);

            MergeHalves(array, temp, leftStart, rightEnd);
        }

        private static void MergeHalves(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while (left <= leftEnd && right <= rightEnd)
            {
                if (array[left] <= array[right])
                {
                    temp[index] = array[left];
                    left++;
                }
                else
                {
                    temp[index] = array[right];
                    right++;
                }

                index++;
            }

            Array.Copy(array, left, temp, index, leftEnd - left + 1);
            Array.Copy(array, right, temp, index, rightEnd - right + 1);
            Array.Copy(temp, leftStart, array, leftStart, size);

        }

        static int Count(int n)
        {
            if (n == 0) return 0;

            return 1  + Count(n / 10);
        }

        static int MethodG(int n)
        {
            return (n != 0) ? n % 10 + MethodG(n / 10) : 0;
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int lowestIndex = i;
                for (int y = i + 1; y < array.Length; y++)
                {
                    if (array[y] < array[lowestIndex])
                    {
                        lowestIndex = y;
                    }
                }

                if (lowestIndex != i)
                {
                    var temp = array[i];
                    array[i] = array[lowestIndex];
                    array[lowestIndex] = temp;
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            var unSortedIndex = 1;

            //Go to unsorted array and get first element
            //When you find the element it is bigger than, insert
            //Increase unsorted index size

            for (int i = 1; i < array.Length; i++)
            {
                var element = array[i];

                for (int y = i - 1; y >= 0; y--)
                {
                    //Do nothing and just increase sorted array
                    if (array[y] < element)
                    {
                        break;
                    }
                    else
                    {
                        int tmp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = tmp;
                    }
                }


            }
        }

        static void Main(string[] args)
        {

            var arr = new int[] {1, 56, 25, 11, 75, 35};

            InsertionSort(arr);

            SelectionSort(arr);

            IBinaryTree bt = new BinaryTree(); 

            bt.CreateSampleTree();

            bt.Display();

            bt.PreOrderTraversal();

            bt.InOrderTraversal();

            bt.PostOrderTraversal();

            bt.LevelOrderTraversal();

            var x1 = bt.Height();


            var y = MethodG(21345);

            var x = Count(235653892);

            var array = new int[]{101,6,23,3,98,8,13,5,97,103};

            MergeSort(array);
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
