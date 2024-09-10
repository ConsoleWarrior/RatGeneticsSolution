using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatGenetics
{
    public class Analyzer
    {
        public double percent_aa = 0;
        public double percent_bb = 0;
        public double percent_B = 0;
        public double percent_cc = 0;
        public double percent_gg = 0;
        public double percent_pp = 0;
        public double percent_rr = 0;
        public double percent_mm = 0;

        public double Unknown = 0;
        public double Albino = 0;
        public double Black = 0;
        public double Blue = 0;
        public double Chocolate = 0;
        public double Cream = 0;
        public double Champagne = 0;
        public double Coffee = 0;
        public double Beige = 0;
        public double Mink = 0;
        public double Silver = 0;
        public double Agouti = 0;
        public double AgoutiBlue = 0;
        public double Fawn = 0;
        public double Cinnamon = 0;
        public double Amber = 0;

        public void Analyzation(List<Group> groups)
        {
            foreach (Group group in groups)
            {
                if (group.genotype[0] == Lokus.hr && group.genotype[0] != Lokus.no) percent_aa += group.percent;
            }
            foreach (Group group in groups)
            {
                if (group.genotype[1] == Lokus.hr && group.genotype[2] != Lokus.hr) percent_bb += group.percent;
            }
            foreach (Group group in groups)
            {
                if (group.genotype[1] != Lokus.hr && group.genotype[2] != Lokus.hr && group.genotype[1] != Lokus.no) percent_B += group.percent;
            }
            foreach (Group group in groups)
            {
                if (group.genotype[2] == Lokus.hr) percent_cc += group.percent;
            }
            foreach (Group group in groups)
            {
                if (group.genotype[3] == Lokus.hr && group.genotype[2] != Lokus.hr) percent_gg += group.percent;
            }
            foreach (Group group in groups)
            {
                if (group.genotype[4] == Lokus.hr && group.genotype[2] != Lokus.hr) percent_pp += group.percent;
            }
            foreach (Group group in groups)
            {
                if (group.genotype[5] == Lokus.hr && group.genotype[2] != Lokus.hr) percent_rr += group.percent;
            }
            foreach (Group group in groups)
            {
                if (group.genotype[6] == Lokus.hr && group.genotype[2] != Lokus.hr) percent_mm += group.percent;
            }
        }

        public override string ToString()
        {
            return $"\nГРУППЫ ПО ОСНОВНЫМ ПРИЗНАКАМ: \n Альбиносов - {percent_cc}\n Тикированных - {100 - percent_aa}(100 -возможно не указан ген родителя)\n Однотонных - {percent_aa}\n" +
                $"Черных - {percent_B}\n Коричневых - {percent_bb}\n Осветленных по gg(серо-голубых) - {percent_gg}\n  Красноглазых не белых(pp/rr) - {percent_pp + percent_rr}\n";

        }

        public string ColorType(Group group)
        {
            if (group.genotype[2] == Lokus.hr) { Albino += group.percent; return " - Albino"; }
            if (group.genotype[0] == Lokus.hr)  // aa
            {
                if ((group.genotype[1] == Lokus.g || group.genotype[1] == Lokus.h) &&
                     group.genotype[3] != Lokus.hr &&
                     group.genotype[4] != Lokus.hr &&
                     group.genotype[5] != Lokus.hr &&
                     group.genotype[6] != Lokus.hr) { Black += group.percent; return " - Black"; }
                if ((group.genotype[1] == Lokus.g || group.genotype[1] == Lokus.h) &&
                     group.genotype[3] == Lokus.hr &&
                     group.genotype[4] != Lokus.hr &&
                     group.genotype[5] != Lokus.hr &&
                     group.genotype[6] != Lokus.hr)
                {
                    Blue += group.percent; return " - Blue";
                }
                if (group.genotype[1] == Lokus.hr &&
                     group.genotype[3] != Lokus.hr &&
                     group.genotype[4] != Lokus.hr &&
                     group.genotype[5] != Lokus.hr &&
                     group.genotype[6] != Lokus.hr)
                {
                    Chocolate += group.percent; return " - Chocolate"; }
                if (group.genotype[1] == Lokus.hr &&
                     group.genotype[3] != Lokus.hr &&
                     group.genotype[4] == Lokus.hr &&
                     group.genotype[5] != Lokus.hr &&
                     group.genotype[6] != Lokus.hr)
                {
                    Cream += group.percent; return " - Cream"; }
                if (group.genotype[1] != Lokus.hr &&
                     group.genotype[3] != Lokus.hr &&
                     group.genotype[4] == Lokus.hr &&
                     group.genotype[5] != Lokus.hr &&
                     group.genotype[6] != Lokus.hr)
                {
                    Champagne += group.percent; return " - Champagne"; }
                if (group.genotype[1] == Lokus.hr &&
                     group.genotype[3] != Lokus.hr &&
                     group.genotype[4] != Lokus.hr &&
                     group.genotype[5] == Lokus.hr &&
                     group.genotype[6] != Lokus.hr)
                {
                    Coffee += group.percent; return " - Dark Eyed Cream(Coffee)"; }
                if (group.genotype[1] != Lokus.hr &&
                     group.genotype[3] != Lokus.hr &&
                     group.genotype[4] != Lokus.hr &&
                     group.genotype[5] == Lokus.hr &&
                     group.genotype[6] != Lokus.hr)
                {
                    Beige += group.percent; return " - Beige (Buff)"; }
                if (group.genotype[1] != Lokus.hr &&
                     group.genotype[3] != Lokus.hr &&
                     group.genotype[4] != Lokus.hr &&
                     group.genotype[5] != Lokus.hr &&
                     group.genotype[6] == Lokus.hr)
                {
                    Mink += group.percent; return " - Mink"; }
                if (group.genotype[1] != Lokus.hr &&
                     group.genotype[3] == Lokus.hr &&
                     group.genotype[4] == Lokus.hr &&
                     group.genotype[5] != Lokus.hr &&
                     group.genotype[6] != Lokus.hr)
                {
                    Silver += group.percent; return " - Silver";
                }
            }
            else if(group.genotype[0] == Lokus.g || group.genotype[0] == Lokus.h)   // A
            {
                if (group.genotype[1] != Lokus.hr &&
                    group.genotype[3] != Lokus.hr &&
                    group.genotype[4] != Lokus.hr &&
                    group.genotype[5] != Lokus.hr &&
                    group.genotype[6] != Lokus.hr)
                {
                    Agouti += group.percent; return " - Agouti"; }
                if (group.genotype[1] != Lokus.hr &&
                    group.genotype[3] == Lokus.hr &&
                    group.genotype[4] != Lokus.hr &&
                    group.genotype[5] != Lokus.hr &&
                    group.genotype[6] != Lokus.hr)
                {
                    AgoutiBlue += group.percent; return " - Agouti Blue";
                }
                if (group.genotype[1] != Lokus.hr &&
                    group.genotype[3] != Lokus.hr &&
                    group.genotype[4] != Lokus.hr &&
                    group.genotype[5] == Lokus.hr &&
                    group.genotype[6] != Lokus.hr)
                {
                    Fawn += group.percent; return " - Fawn(Topaz)";
                }
                if (group.genotype[1] != Lokus.hr &&
                    group.genotype[3] != Lokus.hr &&
                    group.genotype[4] != Lokus.hr &&
                    group.genotype[5] != Lokus.hr &&
                    group.genotype[6] == Lokus.hr)
                {
                    Cinnamon += group.percent; return " - Cinnamon";
                }
                if (group.genotype[1] != Lokus.hr &&
                    group.genotype[3] != Lokus.hr &&
                    group.genotype[4] == Lokus.hr &&
                    group.genotype[5] != Lokus.hr &&
                    group.genotype[6] != Lokus.hr)
                {
                    Amber += group.percent; return " - Amber";
                }
            }
            Unknown += group.percent;
            return "";
        }
        public string GroupPercent()
        {
            return $"\nUnknown = {Math.Round(Unknown,2)}%\nAlbino = {Albino}%\nBlack = {Black}%\nBlue = {Blue}%\nChocolate = {Chocolate}%\nCream = {Cream}%\n" +
                $"Champagne = {Champagne}%\nCoffee = {Coffee}%\nBeige = {Beige}%\nMink = {Mink}%\nSilver = {Silver}%\nAgouti = {Agouti}%\n" +
                $"AgoutiBlue = {AgoutiBlue}%\nFawn = {Fawn}%\nCinnamon = {Cinnamon}%\nAmber = {Amber}%\n";
        }
    }
}
