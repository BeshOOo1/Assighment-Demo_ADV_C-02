using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assighment_ADV_C_02
{
    internal static class Helper
    {
        #region Question 1
        public static int CountGreaterThanX(int[] arr, int x)
        {

            int count = 0;
            foreach (var num in arr)
                if (num > x) count++;
            return count;
        }
        #endregion

        #region Question 2
        public static bool IsPalindrome(int[] arr)
        {
            int i = 0, j = arr.Length - 1;
            while (i < j)
            {
                if (arr[i] != arr[j])
                    return false;
                i++; j--;
            }
            return true;
        }
        #endregion


        #region Question 3
        public static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while (queue.Count > 0)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());
        }
        #endregion


        #region Question 4

        #endregion

        #region Question 5
        public static int[] RemoveDublicate(int[] arr)
        {
            return arr.Distinct().ToArray();
        }

        #endregion

        #region Question 6
        public static void RemoveOddNumbers(ArrayList list)
        {
            for(int i = 0; i <= list.Count -1; i++)
            {
                if ((int)list[i] % 2 != 0)
                    list.RemoveAt(i);
            }
        }
        #endregion

        #region Question 8

        public static void SearchStack(Stack<int> stack, int target)
        {
            int count = 0;
            foreach(var i in stack)
            {
                count++;
                if (i == target)
                {
                    Console.WriteLine($"Target was found and the Count  = {count}");
                    return;
                }
            }
            Console.WriteLine("Target not Found");
        }
        #endregion

        #region Question 9

        #endregion

        #region Question 10
        public static List<int> FindSublist(List<int> list , int target)
        {
            int start = 0;
            int sum = 0;

            for(int i = 0; i < list.Count; i++)
            {
                sum += list[i];
                while(sum > target)
                {
                    sum -= list[start];
                    start++;
                }
                if (sum == target)
                    return list.GetRange(start, i - start + 1);
            }
            return null;
        }

        #endregion
        #region Question 11


        #endregion


    }
}
