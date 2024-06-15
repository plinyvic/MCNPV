using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCNPV
{
    public struct Material
    {
        public float[] Energies { get; }
        public float[] CrossSections { get; }

        public Material(string energiesPath, string crossSectionsPath)
        {
            JsonConvert.DeserializeObject<float[]>(File.ReadAllText(energiesPath));
            JsonConvert.DeserializeObject<float[]>(File.ReadAllText(crossSectionsPath));
        }

        /// <summary>
        /// nearest neighbor metropolis method
        /// </summary>
        /// <param name="energy"></param>
        /// <returns></returns>
        public float GetCrossSection(float energy)
        {
            int index = 0;
            float min = float.MaxValue;
            float tempMin = 0;
            for(int i = 0; i < Energies.Length; i++)
            {
                tempMin = Math.Abs(Energies[i] - energy);
                if (min > tempMin)
                {
                    index = i;
                    min = tempMin;
                }
            }
            return CrossSections[index];
        }
    }
}
