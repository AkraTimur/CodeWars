namespace Building_Spheres
{
    public class Sphere
    {
        const double Pi = 3.14159;

        private int Radius { get; set; }

        private int Mass { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="mass"></param>
        public Sphere(int radius, int mass)
        {
            Radius = radius;

            Mass = mass;
        }

        /// <summary>
        /// radius of the Sphere
        /// </summary>
        /// <returns></returns>
        public int GetRadius()
        {
            return Radius;
        }

        /// <summary>
        /// mass of the Sphere
        /// </summary>
        /// <returns></returns>
        public int GetMass()
        {
            return Mass;
        }

        /// <summary>
        /// volume of the Sphere (a double rounded to 5 place after the decimal)
        /// </summary>
        /// <returns></returns>
        public double GetVolume()
        {
            var volume = (4.0 / 3.0) * Pi * Math.Pow(Radius, 3);
            return Math.Round(volume,5);
        }

        /// <summary>
        /// surface area of the Sphere (a double rounded to 5 place after the decimal)
        /// </summary>
        /// <returns></returns>
        public double GetSurfaceArea()
        {
            var area = 4.0 * Pi * Math.Pow(Radius, 2);
            return Math.Round(area, 5);
        }

        public double GetDensity()
        {
            var density = GetMass() / GetVolume();
            return Math.Round(density, 5);
        }
    }
}
