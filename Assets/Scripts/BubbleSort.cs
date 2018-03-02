/**
 * @Description:<p>冒泡排序</p>
 * @Author SunShubin
 * @Time  2018-02-27
 */

public class BubbleSort  {
    public static void Sort(int[] array)
    {
        if(array == null || array.Length == 0)
        {
            return;
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = array.Length - 1; j > i; j--)
            {
                if (array[j] < array[j - 1])
                {
                    var tempVal = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = tempVal;
                }
            }
        }
    }
}
