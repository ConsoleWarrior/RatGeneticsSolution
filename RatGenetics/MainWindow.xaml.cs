﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RatGenetics
{

    public partial class MainWindow : Window
    {
        public Rat mother = new Rat();
        public Rat father = new Rat();

        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var calculator = new Calculator();
            var analyzer = new Analyzer();
            StringBuilder sb = new StringBuilder();
            int count = 1;

            calculator.Calculate(mother, father);
            foreach (var item in calculator.groups)
            {
                sb.Append("№" + count + " " + item.ToString() + analyzer.ColorType(item)+"\n");
                count++;
            }
            analyzer.Analyzation(calculator.groups);
            sb.Append(analyzer.ToString());
            sb.Append(analyzer.GroupPercent());
            TextBox1.Text = sb.ToString();
        }


        private void RadioButton_Checked0(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "A": mother.genotype[0] = Lokus.no; break;
                case "B": mother.genotype[1] = Lokus.no; break;
                case "C": mother.genotype[2] = Lokus.no; break;
                case "G": mother.genotype[3] = Lokus.no; break;
                case "P": mother.genotype[4] = Lokus.no; break;
                case "R": mother.genotype[5] = Lokus.no; break;
                case "M": mother.genotype[6] = Lokus.no; break;
            }
        }
        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "A": mother.genotype[0] = Lokus.h; break;
                case "B": mother.genotype[1] = Lokus.h; break;
                case "C": mother.genotype[2] = Lokus.h; break;
                case "G": mother.genotype[3] = Lokus.h; break;
                case "P": mother.genotype[4] = Lokus.h; break;
                case "R": mother.genotype[5] = Lokus.h; break;
                case "M": mother.genotype[6] = Lokus.h; break;
            }
        }
        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "A": mother.genotype[0] = Lokus.g; break;
                case "B": mother.genotype[1] = Lokus.g; break;
                case "C": mother.genotype[2] = Lokus.g; break;
                case "G": mother.genotype[3] = Lokus.g; break;
                case "P": mother.genotype[4] = Lokus.g; break;
                case "R": mother.genotype[5] = Lokus.g; break;
                case "M": mother.genotype[6] = Lokus.g; break;
            }
        }
        private void RadioButton_Checked3(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "A": mother.genotype[0] = Lokus.hr; break;
                case "B": mother.genotype[1] = Lokus.hr; break;
                case "C": mother.genotype[2] = Lokus.hr; break;
                case "G": mother.genotype[3] = Lokus.hr; break;
                case "P": mother.genotype[4] = Lokus.hr; break;
                case "R": mother.genotype[5] = Lokus.hr; break;
                case "M": mother.genotype[6] = Lokus.hr; break;
            }
        }


        private void RadioButton_Checked0f(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "Af": father.genotype[0] = Lokus.no; break;
                case "Bf": father.genotype[1] = Lokus.no; break;
                case "Cf": father.genotype[2] = Lokus.no; break;
                case "Gf": father.genotype[3] = Lokus.no; break;
                case "Pf": father.genotype[4] = Lokus.no; break;
                case "Rf": father.genotype[5] = Lokus.no; break;
                case "Mf": father.genotype[6] = Lokus.no; break;
            }
        }
        private void RadioButton_Checked1f(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "Af": father.genotype[0] = Lokus.h; break;
                case "Bf": father.genotype[1] = Lokus.h; break;
                case "Cf": father.genotype[2] = Lokus.h; break;
                case "Gf": father.genotype[3] = Lokus.h; break;
                case "Pf": father.genotype[4] = Lokus.h; break;
                case "Rf": father.genotype[5] = Lokus.h; break;
                case "Mf": father.genotype[6] = Lokus.h; break;
            }
        }
        private void RadioButton_Checked2f(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "Af": father.genotype[0] = Lokus.g; break;
                case "Bf": father.genotype[1] = Lokus.g; break;
                case "Cf": father.genotype[2] = Lokus.g; break;
                case "Gf": father.genotype[3] = Lokus.g; break;
                case "Pf": father.genotype[4] = Lokus.g; break;
                case "Rf": father.genotype[5] = Lokus.g; break;
                case "Mf": father.genotype[6] = Lokus.g; break;
            }
        }
        private void RadioButton_Checked3f(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "Af": father.genotype[0] = Lokus.hr; break;
                case "Bf": father.genotype[1] = Lokus.hr; break;
                case "Cf": father.genotype[2] = Lokus.hr; break;
                case "Gf": father.genotype[3] = Lokus.hr; break;
                case "Pf": father.genotype[4] = Lokus.hr; break;
                case "Rf": father.genotype[5] = Lokus.hr; break;
                case "Mf": father.genotype[6] = Lokus.hr; break;
            }
        }
    }
}
