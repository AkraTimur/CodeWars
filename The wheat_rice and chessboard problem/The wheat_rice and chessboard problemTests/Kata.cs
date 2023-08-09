namespace The_wheat_rice_and_chessboard_problemTests
{
    public class Kata
    {
        public static int SquaresNeeded(long grains)
        {
            return grains == 0 ? 0 : (int)Math.Ceiling(Math.Log(grains + 1, 2));
        }
    }
}
