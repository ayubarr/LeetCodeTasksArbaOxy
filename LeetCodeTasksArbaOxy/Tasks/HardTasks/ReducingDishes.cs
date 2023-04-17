using System.Linq;

namespace LeetCodeTasksArbaOxy.Data.Tasks.HardTasks
{
    public static class ReducingDishes
    {

        public static Func<int[], int> MaxSatisfaction = satisfaction =>
        {
            int minValue = satisfaction.Min();
            int maxSatisfactionValue = 0;
            if (satisfaction.Min() < 0) minValue = satisfaction.Min();
            if (satisfaction.Average() < 0) minValue = satisfaction.Min();
            if (satisfaction.Min() < -5) minValue = -4;

            minValue = satisfaction.Min() + 1;

            var sortedSatisfaction = satisfaction
            .Where(x => x >= minValue)
            .OrderBy(x => x)
            .ToArray();

            for (int i = 0; i < sortedSatisfaction.Length; i++)
                maxSatisfactionValue += sortedSatisfaction[i] * (i + 1);

            if (maxSatisfactionValue < 0) return 0;
            return maxSatisfactionValue;
        };
    }
}
