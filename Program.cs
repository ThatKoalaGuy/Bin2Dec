namespace Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your binary number: ");

            //Take the user input and save each number in a list
            var input = Console.ReadLine();
            var inputList = input.ToCharArray().ToList();

            //Check the number of digits in the list and save it in an variable
            var inputListCount = inputList.Count;

            //Create a loop that loops as many times as the value of inputListCount
            //and save the result of the calculation in a variable
            var result = 0;
            for (var i = 0; i < inputListCount; i++)
            {
                var binary = int.Parse(inputList[i].ToString());
                var exponent = inputListCount - 1 - i;
                result += binary * (int)Math.Pow(2, exponent);
            }

            //Print the result
            Console.WriteLine(result);
        }
    }
}