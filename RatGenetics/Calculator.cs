using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGenetics
{
    public class Calculator
    {
        //public string Calculate(Lokus mother, Lokus father)
        //{
        //    switch(mother)
        //    {
        //        case Lokus.h: switch(father)
        //            {
        //                case Lokus.h: return "100% homo";
        //                case Lokus.g: return "50% homo, 50% getero";
        //                case Lokus.hr: return "100% getero";
        //            } break;
        //        case Lokus.g:
        //            switch (father)
        //            {
        //                case Lokus.h: return "50% homo, 50% getero";
        //                case Lokus.g: return "25% homo, 50% getero, 25% homoR";
        //                case Lokus.hr: return "50% getero, 50% homoR";
        //            }
        //            break;
        //        case Lokus.hr:
        //            switch (father)
        //            {
        //                case Lokus.h: return "100% getero";
        //                case Lokus.g: return "50% getero, 50% homoR";
        //                case Lokus.hr: return "100% homoR";
        //            }
        //            break;
        //    }
        //    return "error";
        //}
        public List<Group> groups = new List<Group>();

        public void Calculate(Rat mother, Rat father)
        {
            groups.Add(new Group(100, new Lokus[7]));
            for (int i = 0; i < 7; i++)
            {
                if (mother.genotype[i] == Lokus.no || father.genotype[i] == Lokus.no) continue;
                List<Group> tempGroups = new List<Group>();
                foreach (var item in groups)
                {
                    tempGroups.AddRange(ChildGensGroup(mother, father, item, i));
                }
                groups = tempGroups;
            }
        }

        public double[] CalculateLokus(Lokus mother, Lokus father)
        {
            double[] percent = new double[4];
            switch (mother)
            {
                case Lokus.h:
                    switch (father)
                    {
                        case Lokus.h: percent[1] = 100; break; //"100% homo";
                        case Lokus.g: percent[1] = 50; percent[2] = 50; break; //"50% homo, 50% getero";
                        case Lokus.hr: percent[2] = 100; break; //return "100% getero";
                    }
                    break;
                case Lokus.g:
                    switch (father)
                    {
                        case Lokus.h: percent[1] = 50; percent[2] = 50; break; // return "50% homo, 50% getero";
                        case Lokus.g: percent[1] = 25; percent[2] = 50; percent[3] = 25; break; // return "25% homo, 50% getero, 25% homoR";
                        case Lokus.hr: percent[2] = 50; percent[3] = 50; break; // return "50% getero, 50% homoR";
                    }
                    break;
                case Lokus.hr:
                    switch (father)
                    {
                        case Lokus.h: percent[2] = 100; break; // return "100% getero";
                        case Lokus.g: percent[2] = 50; percent[3] = 50; break; // return "50% getero, 50% homoR";
                        case Lokus.hr: percent[3] = 100; break; // return "100% homoR";
                    }
                    break;
            }
            return percent;
        }

        public List<Group> ChildGensGroup(Rat mother, Rat father, Group group, int i)
        {
            double[] temp = CalculateLokus(mother.genotype[i], father.genotype[i]);
            var tempGroups = new List<Group>();
            if (temp[1] > 0)
            {
                group.genotype[i] = Lokus.h;
                tempGroups.Add(new Group(temp[1], group.genotype));
            }
            if (temp[2] > 0)
            {
                group.genotype[i] = Lokus.g;
                tempGroups.Add(new Group(temp[2], group.genotype));
            }
            if (temp[3] > 0)
            {
                group.genotype[i] = Lokus.hr;
                tempGroups.Add(new Group(temp[3], group.genotype));
            }
            return tempGroups;
        }
    }
}
