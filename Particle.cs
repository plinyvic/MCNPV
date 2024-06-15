using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MCNPV
{
    public struct Particle
    {
        Vector3 position;
        Vector3 velocity;
        float mass;

        public Particle(Vector3 position, Vector3 velocity, float mass)
        {
            this.position = position;
            this.velocity = velocity;
            this.mass = mass;
        }
    }
}
