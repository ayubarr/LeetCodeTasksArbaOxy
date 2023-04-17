using System.Linq;

namespace LeetCodeTasksArbaOxy.Data.Tasks.EasyTasks
{
    public static class TwoSumTask
    {
        public static int[] TwoSum(int[] nums, int target)
        {
      
                return nums.SelectMany((x, i) =>
              nums.Skip(i + 1)
              .Select((y, j) => new { i, j = j + i + 1, sum = x + y })
              .Where(z => z.sum == target))
              .Select(z => new[] { z.i, z.j })
              .First();
        }
    }
}
