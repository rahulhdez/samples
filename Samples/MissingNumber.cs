
// int lim_min = 10;
// int lim_max = 20;
int[] nums =  { 10, 11, 12, 13, 15, 16, 17, 19, 20};

int missing = 0;

int i = 10;
foreach (var num in nums)
{
    if( num != i )
        {
            missing = i;
            break;
        }
    i++;
}

if(i < 20)
Console.WriteLine($"The missing number is: {missing}");
else
Console.WriteLine("There is no missing number");