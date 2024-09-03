using System;
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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Rat mother = new Rat();
        public Rat father = new Rat();
        private Calculator calculator = new Calculator();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "A: "+calculator.Calculate(mother.A, father.A)+"\n B: "+ calculator.Calculate(mother.B, father.B)+"\n C: "+ calculator.Calculate(mother.C, father.C);
            //TextBox1.Text = mother.A.ToString()+"\n" + mother.B.ToString()+ "\n"+ mother.C.ToString()+ "\n\n"+ father.A.ToString() + "\n" + father.B.ToString() + "\n" + father.C.ToString();
        }


        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch(pressed.GroupName)
            {
                case "A": mother.A = Lokus.homo; break;
                case "B": mother.B = Lokus.homo; break;
                case "C": mother.C = Lokus.homo; break;
            }
        }
        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "A": mother.A = Lokus.getero; break;
                case "B": mother.B = Lokus.getero; break;
                case "C": mother.C = Lokus.getero; break;
            }
        }
        private void RadioButton_Checked3(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "A": mother.A = Lokus.homoR; break;
                case "B": mother.B = Lokus.homoR; break;
                case "C": mother.C = Lokus.homoR; break;
            }
        }


        private void RadioButton_CheckedFather1(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "fA": father.A = Lokus.homo; break;
                case "fB": father.B = Lokus.homo; break;
                case "fC": father.C = Lokus.homo; break;
            }
        }
        private void RadioButton_CheckedFather2(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "fA": father.A = Lokus.getero; break;
                case "fB": father.B = Lokus.getero; break;
                case "fC": father.C = Lokus.getero; break;
            }
        }
        private void RadioButton_CheckedFather3(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            switch (pressed.GroupName)
            {
                case "fA": father.A = Lokus.homoR; break;
                case "fB": father.B = Lokus.homoR; break;
                case "fC": father.C = Lokus.homoR; break;
            }
        }
    }
}
