namespace LeetCode.Questions;

public static class Minimum_Number_of_Moves_to_Seat_Everyone_2037
{
    public static int MinMovesToSeat(int[] seats, int[] students)
    {
        Array.Sort(seats);
        Array.Sort(students);

        var result = 0;

        for (var i = 0; i < students.Length; i++)
        {
            result += Math.Abs(students[i] - seats[i]);
        }

        return result;
    }
}