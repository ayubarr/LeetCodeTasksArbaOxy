namespace LeetCodeTasksArbaOxy.Data.Tasks.EasyTasks
{
    public static class PalindromeNumberTask
    {
        public static Predicate<int> IsPalindrome = x =>
        {
            string s = x.ToString();
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j]) return false;
                    
            return true;
        };
    }
}
