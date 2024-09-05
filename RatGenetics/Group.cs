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
            string[] letters = new string[7];
            for (int i = 0; i < 7; i++)
            {
                if(i==0)
                switch (genotype[i])
                {
                    case Lokus.no: letters[i] = "0"; break;
                    case Lokus.h: letters[i] = "AA"; break;
                    case Lokus.g: letters[i] = "Aa"; break;
                    case Lokus.hr: letters[i] = "aa"; break;
                };
                if (i == 1)
                    switch (genotype[i])
                    {
                        case Lokus.no: letters[i] = "0"; break;
                        case Lokus.h: letters[i] = "BB"; break;
                        case Lokus.g: letters[i] = "Bb"; break;
                        case Lokus.hr: letters[i] = "bb"; break;
                    };
                if (i == 2)
                    switch (genotype[i])
                    {
                        case Lokus.no: letters[i] = "0"; break;
                        case Lokus.h: letters[i] = "CC"; break;
                        case Lokus.g: letters[i] = "Cc"; break;
                        case Lokus.hr: letters[i] = "cc"; break;
                    };
                if (i == 3)
                    switch (genotype[i])
                    {
                        case Lokus.no: letters[i] = "0"; break;
                        case Lokus.h: letters[i] = "GG"; break;
                        case Lokus.g: letters[i] = "Gg"; break;
                        case Lokus.hr: letters[i] = "gg"; break;
                    };
                if (i == 4)
                    switch (genotype[i])
                    {
                        case Lokus.no: letters[i] = "0"; break;
                        case Lokus.h: letters[i] = "PP"; break;
                        case Lokus.g: letters[i] = "Pp"; break;
                        case Lokus.hr: letters[i] = "pp"; break;
                    };
                if (i == 5)
                    switch (genotype[i])
                    {
                        case Lokus.no: letters[i] = "0"; break;
                        case Lokus.h: letters[i] = "RR"; break;
                        case Lokus.g: letters[i] = "Rr"; break;
                        case Lokus.hr: letters[i] = "rr"; break;
                    };
                if (i == 6)
                    switch (genotype[i])
                    {
                        case Lokus.no: letters[i] = "0"; break;
                        case Lokus.h: letters[i] = "MM"; break;
                        case Lokus.g: letters[i] = "Mm"; break;
                        case Lokus.hr: letters[i] = "mm"; break;
                    };
            }
            return $"{percent}%: {letters[0]} / {letters[1]} / {letters[2]} / {letters[3]} / {letters[4]} / {letters[5]} / {letters[6]}\n";
        }
    }
}
