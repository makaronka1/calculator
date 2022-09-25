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
        string str,str2,resultString, ChangeSymbol;
        string changeString = "1";
        double firstMeaning, secondMeaning,result;

        public MainPage()
        {
            this.InitializeComponent();
           
        }

        public void NumberButtonClick(object sender, RoutedEventArgs e)
        {
            if (changeString == "1") 
            {
                Button button = sender as Button;
                str += button.Content;
                pole1.Text = str;
            }
            else
            {
                Button button = sender as Button;
                str += button.Content;
                pole1.Text = str;
                str2 +=button.Content;
                secondMeaning=Convert.ToDouble(str2);
            }
            otvet.Text = "";
        }

        public void SymbolButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            firstMeaning = Convert.ToDouble(pole1.Text);
            str += button.Content;
            ChangeSymbol = (string)button.Content;
            pole1.Text = str;
            changeString = "2";
        }
        public void _ravno_Click(object sender, RoutedEventArgs e)
        {
            if (ChangeSymbol == "+")
            {
                result = firstMeaning + secondMeaning;
            }
            else if(ChangeSymbol == "-")    
            {
                result = firstMeaning - secondMeaning;
            }
            else if( ChangeSymbol == "*")
            {
                result = firstMeaning * secondMeaning;
            }
            else
            {
                result = firstMeaning / secondMeaning;
            }

            resultString = Convert.ToString(result);
            otvet.Text = resultString;
            
            result = 0;
            ChangeSymbol = "";
             pole1.Text = "" ;
             pole2.Text = "";
             str = "";
            str2 = "";
            changeString = "1";
        }
        public void _zap_Click(object sender, RoutedEventArgs e)
        {
            if (changeString == "1")
            {
                Button button = sender as Button;
                str += button.Content;
                pole1.Text = str;
            }
            else
            {
                Button button = sender as Button;
                str += button.Content;
                str2 += button.Content;
                pole1.Text = str;
            }
        }  
    }
}
