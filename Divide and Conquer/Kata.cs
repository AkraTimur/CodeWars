namespace Divide_and_Conquer
{
    public class Kata
    {
        public static int DivCon(Object[] objArray)
        {
            int sumOfInt = 0;
            int sumOfString = 0;

            foreach (Object obj in objArray) 
            {
                if (obj.GetType() == typeof(int))
                {
                    var num = (int)obj;
                    sumOfInt += num;
                }
                else if (obj.GetType() == typeof(string))
                {
                    var numStr = obj.ToString();
                    sumOfString += Convert.ToInt32(numStr);
                }
            
            }
            return sumOfInt - sumOfString;
        }
    }
}
