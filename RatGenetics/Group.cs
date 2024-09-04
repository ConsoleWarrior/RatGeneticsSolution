using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGenetics
{
    public class Group
    {
        public double percent = 0;
        public Lokus[] genotype = new Lokus[7];
        public Group(double percent, Lokus[] genotype)
        {
            this.percent = percent;
            this.genotype = genotype;
        }
        public override string ToString()
        {
            return $"{percent}: {genotype[0]} / {genotype[1]} / {genotype[2]} / {genotype[3]} / {genotype[4]} / {genotype[5]} / {genotype[6]}\n";
        }
    }
}
