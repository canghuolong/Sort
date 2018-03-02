/**
 * @Description 选择排序 
 * @Author  SunShubin
 * @Time    2018-03-01
 */

public class SelectSort {
    public static void Sort(int[] array)
    {
        if(array == null || array.Length == 0)
        {
            return;
        }
        int minIndex = 0;
        for(int i = 0;i < array.Length - 1; i++)
        {
            minIndex = i;
            for(int j = i + 1; j < array.Length; j++)
            {
                if(array[minIndex] > array[j])
                {
                    minIndex = j;
                }
            }
            if(minIndex != i)
            {
                var tempVal = array[i];
                array[i] = array[minIndex];
                array[minIndex] = tempVal;
            }
        }
    }
}
