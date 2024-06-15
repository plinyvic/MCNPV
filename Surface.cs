using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MCNPV
{
    public struct Surface
    {
        /// <summary>
        /// ax^2
        /// </summary>
        public float a = 0;

        /// <summary>
        /// bxy
        /// </summary>
        public float b = 0; 

        /// <summary>
        /// cy^2
        /// </summary>
        public float c = 0;

        /// <summary>
        /// dyz
        /// </summary>
        public float d = 0;

        /// <summary>
        /// ez^2
        /// </summary>
        public float e = 0;

        /// <summary>
        /// fxz
        /// </summary>
        public float f = 0;

        /// <summary>
        /// gx
        /// </summary>
        public float g = 0;

        /// <summary>
        /// hy
        /// </summary>
        public float h = 0;

        /// <summary>
        /// iz
        /// </summary>
        public float i = 0;

        /// <summary>
        /// j
        /// </summary>
        public float j = 0;

        private Surface(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h = h;
            this.i = i;
            this.j = j;
        }

        public Surface()
        {

        }

        public bool Solve(Vector3 position)
        {
            return ((a * position.X * position.X)
                + (b * position.X * position.Y)
                + (c * position.Y * position.Y)
                + (d * position.Y * position.Z)
                + (e * position.Z * position.Z)
                + (f * position.Z * position.X)
                + (g * position.X)
                + (h * position.Y)
                + (i * position.Z)
                + j) > 0;
        }

        public static Surface MakeSphere(Vector3 center, float radius)
        {
            return new Surface()
            {
                a = 1,
                b = 0,
                c = 1,
                d = 0,
                e = 1,
                f = 0,
                g = -2 * center.X,
                h = -2 * center.Y,
                i = -2 * center.X,
                j = (center.X + center.Y + center.Z -(radius * radius))
            };
        }
    }
}
