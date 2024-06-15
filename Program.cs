using System.Numerics;

namespace MCNPV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Surface uraniumRegion = Surface.MakeSphere(Vector3.Zero, 5f);

            Cell uraniumSphere = new Cell((pos) => !uraniumRegion.Solve(pos));
            Cell outsideSphere = new Cell((pos) => uraniumRegion.Solve(pos));


        }
    }
}