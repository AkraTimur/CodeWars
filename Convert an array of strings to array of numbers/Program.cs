namespace Convert_an_array_of_strings_to_array_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = stringArrayMethods.ToDoubleArray(new string[] { "1.1", "2.2", "3.3" });
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
//Convert an array of strings to array of numbers
//Oh no!
//Some really funny web dev gave you a sequence of numbers from his API response as an sequence of strings!

//You need to cast the whole array to the correct type.

//Create the function that takes as a parameter a sequence of numbers represented as strings and outputs a sequence of numbers.

//ie:["1", "2", "3"] to[1, 2, 3]

//Note that you can receive floats as well.
