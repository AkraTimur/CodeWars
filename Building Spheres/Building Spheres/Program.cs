namespace Building_Spheres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sphere = new Sphere(2, 50);

            Console.WriteLine(sphere.GetRadius());
            Console.WriteLine(sphere.GetMass());
            Console.WriteLine(sphere.GetVolume());
            Console.WriteLine(sphere.GetSurfaceArea());
            Console.WriteLine(sphere.GetDensity());
            
        }
    }
}