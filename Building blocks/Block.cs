namespace Building_blocks
{
    public class Block
    {
        private readonly int width;

        private readonly int length;

        private readonly int height;

        public Block(int[] array)
        {
            width = array[0];
            length = array[1];
            height = array[2];
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetVolume()
        {
            return height * width * length;
        }

        public int GetSurfaceArea()
        {
            return 2 * (width * length + width * height + length * height);
        }

    }
}
