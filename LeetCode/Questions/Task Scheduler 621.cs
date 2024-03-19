namespace LeetCode.Questions;

public static class Task_Scheduler_621
{
    public static int LeastInterval(char[] tasks, int n) {
        if (tasks == null || tasks.Length == 0)
            return 0;

        var taskFrequency = new Dictionary<char, int>();
        foreach (var task in tasks)
        {
            if (taskFrequency.TryGetValue(task, out var value))
                taskFrequency[task] = ++value;
            else
                taskFrequency[task] = 1;
        }

        var maxFrequency = taskFrequency.Values.Max();
        var maxCount = taskFrequency.Values.Count(f => f == maxFrequency);
        
        return Math.Max(tasks.Length, (maxFrequency - 1) * (n + 1) + maxCount);
    }
}