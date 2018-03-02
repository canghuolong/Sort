/**
 * @Description 插入排序
 * @Author  SunShubin
 * @Time    2018-03-01
 */
public class InsertSort {

    public static void Sort(int[] array)
    {
        if(array == null || array.Length == 0)
        {
            return;
        }

        for(int i = 1; i < array.Length; i++)
        {
            int j = i;
            int target = array[i];
            while(j > 0 && target < array[j - 1])
            {
                array[j] = array[j - 1];
                j--;
            }
            array[j] = target;
        }
    }
}
