public class FizzBuzz
{
    public static int[] CalculateFizzBuzz(int[] numbers)
    {
        int[] result = new int[numbers.Length];

        for(int i = 0; i < numbers.Length; i++)
        {
            
            if ((numbers[i] % 3 == 0) && (numbers[i] % 5 == 0))
            {
                result[i] = 0;
            }
            else if(numbers[i] % 3 == 0 || numbers[i] % 5 == 0)
            {
                if (numbers[i] % 3 == 0)
                {
                    result[i] = 3;
                }
                else if (numbers[i] % 5 == 0)
                {
                    result[i] = 5;
                }
            }
            else
            {
                result[i] = numbers[i];
            }
        }
        return result;
    }
}
