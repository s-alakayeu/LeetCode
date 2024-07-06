namespace LeetCode.Questions;

public static class Pass_the_Pillow_2582
{
    public static int PassThePillow(int n, int time)
    {
        var times = time / (n - 1);
        var index = time % (n - 1);

        return times % 2 == 0 ? index + 1 : n - index;
    }
}