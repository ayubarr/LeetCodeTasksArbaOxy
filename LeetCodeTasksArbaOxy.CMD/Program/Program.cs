using LeetCodeTasksArbaOxy.Data.Tasks.EasyTasks;
using LeetCodeTasksArbaOxy.Data.Tasks.HardTasks;

int[] nums = { 2, 7, 11, 15 };
int target = 9;
int[] result = TwoSumTask.TwoSum(nums, target);
Console.WriteLine(string.Join(",", result)); // Output: 0,1