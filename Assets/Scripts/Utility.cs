/**
 * @Description:<p>工具类</p>
 * @author SunShubin
 * @time  2018-02-27
 */
public sealed  class Utility  {
    /// <summary>
    /// 加法交换
    /// </summary>
    public static void Swap(int[] array,int first,int second)
    {
        array[first] = array[first] + array[second];
        array[second] = array[first] - array[second];
        array[first] = array[first] - array[second];
    }

}
