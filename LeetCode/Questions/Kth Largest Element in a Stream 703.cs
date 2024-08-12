namespace LeetCode.Questions;

public static class Kth_Largest_Element_in_a_Stream_703
{
    public static void Run()
    {
        KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
        kthLargest.Add(3);   // return 4
        kthLargest.Add(5);   // return 5
        kthLargest.Add(10);  // return 5
        kthLargest.Add(9);   // return 8
        kthLargest.Add(4);   // return 8
    }
}

public class KthLargest
{
    private readonly int _kLargest;
    private readonly List<int> _nums;
    
    public KthLargest(int k, int[] nums)
    {
        _kLargest = k;
        _nums = nums.ToList();
    }
    
    public int Add(int val) 
    {
        _nums.Add(val);
        _nums.Sort();
        
        return _nums[^_kLargest];
    }
}