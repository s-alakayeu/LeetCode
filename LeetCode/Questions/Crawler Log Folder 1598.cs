namespace LeetCode.Questions;

public static class Crawler_Log_Folder_1598
{
    public static int MinOperations(string[] logs)
    {
        var deep = 0;
        
        foreach (var log in logs)
        {
            switch (log)
            {
                case "../":
                    deep = deep > 0 ? --deep : 0;
                    break;
                case "./":
                    continue;
                default:
                    deep++;
                    break;
            }
        }

        return deep;
    }
}