using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Array_Questions
{
    //public class Merge_two_sorted_Array
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] nums1 = { 1, 3, 5, 0, 0, 0 }; // Example sorted array 1
    //        int m = 3; // Length of nums1 array
    //        int[] nums2 = { 2, 4, 6 }; // Example sorted array 2
    //        int n = 3; // Length of nums2 array

    //        Merge(nums1, m, nums2, n);

    //        Console.WriteLine("Merged Sorted Array:");
    //        foreach (int num in nums1)
    //        {
    //            Console.Write(num + " ");
    //        }
    //    }

    //    static void Merge(int[] nums1, int m, int[] nums2, int n)
    //    {
    //        int index1 = m - 1; // Last index of nums1 array
    //        int index2 = n - 1; // Last index of nums2 array
    //        int mergedIndex = m + n - 1; // Last index of merged array

    //        // Merge from the end of the arrays
    //        while (index1 >= 0 && index2 >= 0)
    //        {
    //            if (nums1[index1] > nums2[index2])
    //            {
    //                nums1[mergedIndex] = nums1[index1];
    //                index1--;
    //            }
    //            else
    //            {
    //                nums1[mergedIndex] = nums2[index2];
    //                index2--;
    //            }
    //            mergedIndex--;
    //        }

    //        // Copy remaining elements from nums2 if any
    //        while (index2 >= 0)
    //        {
    //            nums1[mergedIndex] = nums2[index2];
    //            index2--;
    //            mergedIndex--;
    //        }
    //    }
    //}
}
