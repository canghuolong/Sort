/**
 *@Description  快速排序 
 *@Author   SunShubin
 *@Time 2018-02-28
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort  {
    public static void Sort(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            return;
        }
        
        int left = 0;
        int right = array.Length - 1;

        Sort(array, left, right);
        
    }

    static void Sort(int[] array,int left,int right)
    {
        if(left < right)
        {
            int i = left, j = right, x = array[left];

            while (i < j)
            {
                while (i < j && x <= array[j])
                {
                    j--;
                }
                array[i] = array[j];
                while(i<j && array[i] <= x)
                {
                    i++;
                }
                array[j] = array[i];
            }
            array[i] = x;
            Sort(array, left, i - 1);
            Sort(array, i + 1, right);
        }
    }

}
