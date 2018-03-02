/**
 * @Description 归并排序
 * @Author  SunShubin
 * @Time    2018-03-01
 */

public class MergeSort  {

    public static void Sort(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            return;
        }

        Sort(array, 0, array.Length - 1);
       
    }

    static void Sort(int[] array,int left,int right)
    {
        if (left == right)
        {
            return;
        }

        int mid = (left + right) / 2;
        Sort(array, left, mid);
        Sort(array, mid + 1, right);
        MergeArray(array, left, mid, right);

    }

    static void MergeArray(int[] array,int left,int mid,int right)
    {
        int i = left, j = mid + 1;

        int[] temp = new int[right - left + 1];
        int tempIndex = 0;
        while(i <= mid && j <= right)
        {
            if(array[i] <= array[j])
            {
                temp[tempIndex++] = array[i++];
            }
            else
            {
                temp[tempIndex++] = array[j++];
            }
        }
        while (i <= mid)
        {
            temp[tempIndex++] = array[i++];
        }
        while(j <= right)
        {
            temp[tempIndex++] = array[j++];
        }
        for(int iii = 0; iii < temp.Length; iii++)
        {
            array[left + iii] = temp[iii];
        }
    }
}
