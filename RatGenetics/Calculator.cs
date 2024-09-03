using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGenetics
{
    public class Calculator
    {
        public string Calculate(Lokus mother, Lokus father)
        {
            switch(mother)
            {
                case Lokus.homo: switch(father)
                    {
                        case Lokus.homo: return "100% homo";
                        case Lokus.getero: return "50% homo, 50% getero";
                        case Lokus.homoR: return "100% getero";
                    } break;
                case Lokus.getero:
                    switch (father)
                    {
                        case Lokus.homo: return "50% homo, 50% getero";
                        case Lokus.getero: return "25% homo, 50% getero, 25% homoR";
                        case Lokus.homoR: return "50% getero, 50% homoR";
                    }
                    break;
                case Lokus.homoR:
                    switch (father)
                    {
                        case Lokus.homo: return "100% getero";
                        case Lokus.getero: return "50% getero, 50% homoR";
                        case Lokus.homoR: return "100% homoR";
                    }
                    break;
            }
            return "error";
        }
    }
}
