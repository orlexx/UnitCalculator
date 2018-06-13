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

namespace UnitCalculator
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool kgTbx_Focused;
        bool lbTbx_Focused;
        bool pudTbx_Focused;
        bool stTbx_Focused;
        bool ozTbx_Focused;
        bool lbRuTbx_Focused;

        bool mtTbx_Focused;
        bool miTbx_Focused;
        bool ftTbx_Focused;
        bool lyTbx_Focused;


        public MainWindow()
        {
            InitializeComponent();
        }

        #region masses
        private void kg_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (Double.TryParse(kg_tbx.Text, out value) && kgTbx_Focused)
            {
                double pounds = value * 2.20462;
                double stones = pounds / 14;
                double ounces = pounds * 16;
                double puds = value / 16.380496;
                double lbRu = puds * 40;

                lb_tbx.Text = String.Format("{0:0.00}", pounds);
                st_tbx.Text = String.Format("{0:0.00}", stones);
                oz_tbx.Text = String.Format("{0:0.00}", ounces);
                pud_tbx.Text = String.Format("{0:0.00}", puds);
                lbRu_tbx.Text = String.Format("{0:0.00}", lbRu);
            }
            if (kg_tbx.Text == "")
            {
                resetTextboxes();
            }
        }

        private void lb_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (Double.TryParse(lb_tbx.Text, out value) && lbTbx_Focused)
            {
                double kilos = value * 0.453592;
                double stones = value / 14;
                double ounces = value * 16;
                double puds = kilos / 16.380496; 
                double lbRu = puds * 40;

                kg_tbx.Text = String.Format("{0:0.00}", kilos);
                st_tbx.Text = String.Format("{0:0.00}", stones);
                oz_tbx.Text = String.Format("{0:0.00}", ounces);
                pud_tbx.Text = String.Format("{0:0.00}", puds);
                lbRu_tbx.Text = String.Format("{0:0.00}", lbRu);
            }
            if (lb_tbx.Text == "")
            {
                resetTextboxes();
            }
        }

        private void st_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (Double.TryParse(st_tbx.Text, out value) && stTbx_Focused)
            {
                double kilos = value * 6.35029318;
                double pounds = value * 14;
                double ounces = pounds * 16;
                double puds = kilos / 16.380496; 
                double lbRu = puds * 40;

                kg_tbx.Text = String.Format("{0:0.00}", kilos);
                lb_tbx.Text = String.Format("{0:0.00}", pounds);
                oz_tbx.Text = String.Format("{0:0.00}", ounces);
                pud_tbx.Text = String.Format("{0:0.00}", puds);
                lbRu_tbx.Text = String.Format("{0:0.00}", lbRu);
            }
            if (st_tbx.Text == "")
            {
                resetTextboxes();
            }
        }

        private void oz_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (Double.TryParse(oz_tbx.Text, out value) && ozTbx_Focused)
            {
                
                double pounds = value / 16; 
                double kilos = pounds * 0.453592;
                double puds = kilos / 16.380496;
                double lbRu = puds * 40;
                double stones = pounds / 14;

                kg_tbx.Text = String.Format("{0:0.00}", kilos);
                lb_tbx.Text = String.Format("{0:0.00}", pounds);
                st_tbx.Text = String.Format("{0:0.00}", stones);
                pud_tbx.Text = String.Format("{0:0.00}", puds);
                lbRu_tbx.Text = String.Format("{0:0.00}", lbRu);
            }
            if (oz_tbx.Text == "")
            {
                resetTextboxes();
            }
        }

        private void lbRu_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (Double.TryParse(lbRu_tbx.Text, out value) && lbRuTbx_Focused)
            {
                double puds = value / 40;
                double kilos = value / 2.441933;
                double pounds = kilos / 0.453592;
                double stones = pounds / 14;
                double ounces = pounds * 16;

                kg_tbx.Text = String.Format("{0:0.00}", kilos);
                lb_tbx.Text = String.Format("{0:0.00}", pounds);
                st_tbx.Text = String.Format("{0:0.00}", stones);
                pud_tbx.Text = String.Format("{0:0.00}", puds);
                oz_tbx.Text = String.Format("{0:0.00}", ounces);
            }
            if (lbRu_tbx.Text == "")
            {
                resetTextboxes();
            }
        }

        private void pud_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (Double.TryParse(pud_tbx.Text, out value) && pudTbx_Focused)
            {
                double lbRu = value * 40;
                double kilos = value * 16.3804964;
                double pounds = kilos / 0.453592;
                double stones = pounds / 14;
                double ounces = pounds * 16;
                
                kg_tbx.Text = String.Format("{0:0.00}", kilos);
                lb_tbx.Text = String.Format("{0:0.00}", pounds);
                st_tbx.Text = String.Format("{0:0.00}", stones);
                lbRu_tbx.Text = String.Format("{0:0.00}", lbRu);
                oz_tbx.Text = String.Format("{0:0.00}", ounces);
            }
            if (pud_tbx.Text == "")
            {
                resetTextboxes();
            }
        }

        private void kg_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            kgTbx_Focused = true;
        }

        private void kg_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            kgTbx_Focused = false;
        }

        private void lb_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            lbTbx_Focused = true;
        }

        private void lb_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            lbTbx_Focused = false;
        }

        private void st_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            stTbx_Focused = true;
        }

        private void st_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            stTbx_Focused = false;
        }

        private void oz_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            ozTbx_Focused = true;
        }

        private void oz_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            ozTbx_Focused = false;
        }

        private void pud_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            pudTbx_Focused = true;
        }

        private void pud_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            pudTbx_Focused = false;
        }

        private void lbRu_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            lbRuTbx_Focused = true;
        }

        private void lbRu_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            lbRuTbx_Focused = false;
        }
        #endregion

        private void resetTextboxes()
        {
            kg_tbx.Text = "";
            st_tbx.Text = "";
            oz_tbx.Text = "";
            pud_tbx.Text = "";
            lbRu_tbx.Text = "";
            lb_tbx.Text = "";
            mt_tbx.Text = "";
            mi_tbx.Text = "";
            ft_tbx.Text = "";
        }

        private void mt_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            if (Double.TryParse(mt_tbx.Text, out value) && mtTbx_Focused)
            {
                double miles = value * 0.000621371;                 // calculating miles
                mi_tbx.Text = (Math.Round(miles, 3)).ToString();    //

                int inches = (int)Math.Round(value * 39.3701);              // Calculating feet / inches
                int ft = (inches - (inches % 12)) / 12;                     //
                inches %= 12;                                               //
                if (inches != 0)                                            //
                    ft_tbx.Text = String.Format("{0}'{1}''", ft, inches);   //
                else
                    ft_tbx.Text = ft.ToString();            
            }
            if (mt_tbx.Text == "")
                resetTextboxes();
        }

        private void mt_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            mtTbx_Focused = true;
        }

        private void mt_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            mtTbx_Focused = false;
        }

        private void mi_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
                       
        }

        private void mi_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            miTbx_Focused = true;
        }

        private void mi_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            miTbx_Focused = false;
        }

        private void ft_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ft_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            ftTbx_Focused = true;
        }

        private void ft_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            ftTbx_Focused = false;
        }

        private void ly_tbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            double ly;
            double m = 0;
            if (lyTbx_Focused)
            {
                if (Double.TryParse(ly_tbx.Text, out ly))
                {
                    m = ly * 9460730472580800;                    
                    mt_tbx.Text = convertToStandard(m);
                    ft_tbx.Text = metresToFeetAndInches(m);
                    mi_tbx.Text = convertToStandard(metresToMiles(m));
                }
                else
                    resetTextboxes();
            }
        }

        private double metresToMiles(double input)
        {
            return input * 0.000621371;     
        }

        private string convertToStandard(double input)
        {
            string result;
            if (input > 1000)
            {
                int p = 0;
                double input_p = input;
                while (input_p > 10)
                {
                    input_p /= 10;
                    p++;
                }
                string ps = p.ToString();
                string psu = "";
                foreach (char c in ps)
                {
                    switch (int.Parse(c.ToString()))
                    {
                        case 1:
                            psu += '\xB9';
                            break;
                        case 2:
                            psu += '\xB2';
                            break;
                        case 3:
                            psu += "\xB3";
                            break;
                        case 4:
                            psu += "\u2074";
                            break;
                        case 5:
                            psu += '\u2075';
                            break;
                        case 6:
                            psu += "\u2076";
                            break;
                        case 7:
                            psu += "\u2077";
                            break;
                        case 8:
                            psu += "\u2078";
                            break;
                        case 9:
                            psu += "\u2079";
                            break;
                        case 0:
                            psu += "\u2070";
                            break;

                    }
                }
                result = String.Format("{0} * 10{1}", Math.Round(input_p, 3), psu);
            }
            else
                result = Math.Round(input, 3).ToString();
            return result;

        }

        private double milesToMetres(double input)
        {
            return input / 0.000621371;
        }

        private string metresToFeetAndInches(double input)
        {
            string result;
            double inches = Math.Round(input * 39.3701);           
            
            double ft = (inches - (inches % 12)) / 12;                     
            inches %= 12;                                               
            if (inches != 0)                                            
                result = String.Format("{0} ft {1} in''", convertToStandard(ft).ToString(), inches);   
            else
                result = convertToStandard(ft).ToString();
            //MessageBox.Show(String.Format("{0} and {1}", convertToStandard(ft).ToString(), inches));
            return result;
            
        }

        private void ly_tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            lyTbx_Focused = true;
        }

        private void ly_tbx_LostFocus(object sender, RoutedEventArgs e)
        {
            lyTbx_Focused = false;
        }
    }
}
