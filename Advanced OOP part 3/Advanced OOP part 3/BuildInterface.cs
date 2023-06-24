using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_part_3
{
    internal class BuildInterface : IEquatable<BuildInterface>
    {



        public int trainLength { get; set; }

        public BuildInterface(int trainLength)
        {
            this.trainLength = trainLength;
        }

        public bool Equals(BuildInterface? other)
        {
            return trainLength == other?.trainLength;
        }
    }
}
