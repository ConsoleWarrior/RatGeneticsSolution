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
                case Lokus.h: switch(father)
                    {
                        case Lokus.h: return "100% homo";
                        case Lokus.g: return "50% homo, 50% getero";
                        case Lokus.hr: return "100% getero";
                    } break;
                case Lokus.g:
                    switch (father)
                    {
                        case Lokus.h: return "50% homo, 50% getero";
                        case Lokus.g: return "25% homo, 50% getero, 25% homoR";
                        case Lokus.hr: return "50% getero, 50% homoR";
                    }
                    break;
                case Lokus.hr:
                    switch (father)
                    {
                        case Lokus.h: return "100% getero";
                        case Lokus.g: return "50% getero, 50% homoR";
                        case Lokus.hr: return "100% homoR";
                    }
                    break;
            }
            return "error";
        }
    }
}
