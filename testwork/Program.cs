int[] nums = {3, 2, 4};
int target = 6;

int[] TwoSum(int[] nums, int target)
{
    

    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int needed = target - nums[i];

        if (map.ContainsKey(needed))
        {
            return new int[] { map[needed], i };
        }
        map[nums[i]] = i;
    }

    return new int[] { };
}
int[] result = TwoSum(nums, target);

Console.WriteLine($"[{result[0]}, {result[1]}]");