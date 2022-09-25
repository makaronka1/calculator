using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace App4
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string str, str2, third, resultString, fuck;
        string smena = "1";
        double first, second, result;

        public MainPage()
        {
            this.InitializeComponent();

        }

        

        public void _1_Click(object sender, RoutedEventArgs e)
        {
            /*content = Convert.ToInt32(Button.);*/
            Button button = sender as Button;
            str += button.Content;
            
            /*Button MyButton = (Button)sender;*/


            /*napisaniye(buttonValue);*/
            /*switch (smena)
            {
                case "1":
                    str = str + 1;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 1;
                    pole2.Text = str2;
                    break;
            }*/
        }

        public void _2_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            /* napisaniye(button);*/
            /*switch (smena)
            {
                case "1":
                    str = str + 2;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 2;
                    pole2.Text = str2;
                    break;
            }*/
        }

        public void _3_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + 3;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 3;
                    pole2.Text = str2;
                    break;
            }
        }

        public void _4_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + 4;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 4;
                    pole2.Text = str2;
                    break;
            }
        }

        public void _5_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + 5;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 5;
                    pole2.Text = str2;
                    break;
            }
        }

        public void _6_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + 6;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 6;
                    pole2.Text = str2;
                    break;
            }
        }

        public void _7_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + 7;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 7;
                    pole2.Text = str2;
                    break;
            }
        }


        public void _8_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + 8;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 8;
                    pole2.Text = str2;
                    break;
            }
        }

        public void _9_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + 9;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 9;
                    pole2.Text = str2;
                    break;
            }
        }

        public void _0_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + 0;
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + 0;
                    pole2.Text = str2;
                    break;
            }
        }

        public void _zap_Click(object sender, RoutedEventArgs e)
        {

            switch (smena)
            {
                case "1":
                    str = str + ",";
                    pole1.Text = str;
                    break;
                case "2":
                    str2 = str2 + ",";
                    pole2.Text = str2;
                    break;
            }
        }

        public void _plus_Click(object sender, RoutedEventArgs e)
        {


            znak.Text = "+";
            smena = "2";
        }

        public void _minus_Click(object sender, RoutedEventArgs e)
        {


            znak.Text = "-";
            smena = "2";
        }

        public void _delit_Click(object sender, RoutedEventArgs e)
        {


            znak.Text = "/";
            smena = "2";
        }

        public void _ymnoj_Click(object sender, RoutedEventArgs e)
        {


            znak.Text = "*";
            smena = "2";
        }

        public void _ravno_Click(object sender, RoutedEventArgs e)
        {
            first = Convert.ToDouble(str);
            second = Convert.ToDouble(str2);
            third = znak.Text;
            smena = "1";
            znak.Text = "";
            pole1.Text = "";
            pole2.Text = "";
            str = "";
            str2 = "";

            if (third == "+")
            {
                result = first + second;
            }
            else if (third == "-")
            {
                result = first - second;
            }
            else if (third == "/")
            {
                result = (first / second);
            }
            else
            {
                result = (first * second);
            }
            resultString = Convert.ToString(result);
            otvet.Text = resultString;
        }
    }
}
