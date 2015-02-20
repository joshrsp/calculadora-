using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace calculadora
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
        public void calculadora(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            if (textNumero.Text.Equals("0"))
            {
                textNumero.Text = "";
            }
            if (b.Content.Equals("="))
            {

                int num = 0, numero1 = 0, ultimo = 0, primera = 0, salir = 0;
                String numero = "";
                float total = 0;
                while (num < textNumero.Text.Length)
                {

                    if (textNumero.Text.Substring(num, 1).Equals("+") && primera == 0)
                    {
                        while (salir == 0)
                        {
                            num = num + 1;
                            if (num >= textNumero.Text.Length)
                            {
                                salir = 1;
                            }
                            else
                            {

                                if (textNumero.Text.Substring(num,  1).Equals("+") || textNumero.Text.Substring(num, 1).Equals("-") || textNumero.Text.Substring(num,  1).Equals("*") || textNumero.Text.Substring(num, 1).Equals("/"))
                                {
                                    salir = 1;
                                }
                                else
                                {
                                    numero = numero + textNumero.Text.Substring(num, 1);
                                }
                            }

                        }
                        total = total + float.Parse(numero);
                        numero = "";
                        primera = 1;
                    }
                    else
                    {
                        if (textNumero.Text.Substring(num, 1).Equals("-") && primera == 0)
                        {
                            while (salir == 0)
                            {
                                num = num + 1;
                                if (num >= textNumero.Text.Length)
                                {
                                    salir = 1;
                                }
                                else
                                {

                                    if (textNumero.Text.Substring(num, 1).Equals("+") || textNumero.Text.Substring(num, 1).Equals("-") || textNumero.Text.Substring(num, 1).Equals("*") || textNumero.Text.Substring(num, 1).Equals("/"))
                                    {
                                        salir = 1;
                                    }
                                    else
                                    {
                                        numero = numero + textNumero.Text.Substring(num, 1);
                                    }
                                }

                            }
                            total = total - float.Parse(numero);
                            numero = "";
                            primera = 1;
                        }
                        else
                        {
                            if (textNumero.Text.Substring(num, 1).Equals("*") && primera == 0)
                            {
                                while (salir == 0)
                                {
                                    num = num + 1;
                                    if (num >= textNumero.Text.Length)
                                    {
                                        salir = 1;
                                    }
                                    else
                                    {

                                        if (textNumero.Text.Substring(num, 1).Equals("+") || textNumero.Text.Substring(num, 1).Equals("-") || textNumero.Text.Substring(num, 1).Equals("*") || textNumero.Text.Substring(num, 1).Equals("/"))
                                        {
                                            salir = 1;
                                        }
                                        else
                                        {
                                            numero = numero + textNumero.Text.Substring(num, 1);
                                        }
                                    }

                                }
                                total = 0;
                                numero = "";
                                primera = 1;
                            }
                            else
                            {
                                if (textNumero.Text.Substring(num, 1).Equals("/") && primera == 0)
                                {
                                    while (salir == 0)
                                    {
                                        num = num + 1;
                                        if (num >= textNumero.Text.Length)
                                        {
                                            salir = 1;
                                        }
                                        else
                                        {

                                            if (textNumero.Text.Substring(num, 1).Equals("+") || textNumero.Text.Substring(num, 1).Equals("-") || textNumero.Text.Substring(num, 1).Equals("*") || textNumero.Text.Substring(num, 1).Equals("/"))
                                            {
                                                salir = 1;
                                            }
                                            else
                                            {
                                                numero = numero + textNumero.Text.Substring(num, 1);
                                            }
                                        }

                                    }
                                    total = 0;
                                    numero = "";
                                    primera = 1;
                                }
                                else
                                {

                                    if (primera == 0)
                                    {
                                        while (salir == 0)
                                        {

                                            if (num >= textNumero.Text.Length)
                                            {
                                                salir = 1;
                                            }
                                            else
                                            {
                                                
                                                if (textNumero.Text.Substring(num, 1 ).Equals("+") || textNumero.Text.Substring(num, 1).Equals("-") || textNumero.Text.Substring(num, 1).Equals("*") || textNumero.Text.Substring(num, 1 ).Equals("/"))
                                                {
                                                    salir = 1;
                                                }
                                                else
                                                {
                                                    numero = numero + textNumero.Text.Substring(num, 1);
                                                }
                                            }
                                            num = num + 1;
                                        }
                                        num = num - 1;
                                        total = total + float.Parse(numero);
                                        numero = "";
                                        primera = 1;
                                    }
                                }
                            }

                        }

                    }
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    salir = 0;
                    if (num < textNumero.Text.Length)
                    {
                        if (textNumero.Text.Substring(num, 1).Equals("+") && primera == 1)
                        {

                            while (salir == 0)
                            {
                                num = num + 1;
                                if (num >= textNumero.Text.Length)
                                {
                                    salir = 1;
                                }
                                else
                                {

                                    if (textNumero.Text.Substring(num, 1).Equals("+") || textNumero.Text.Substring(num,1).Equals("-") || textNumero.Text.Substring(num, 1).Equals("*") || textNumero.Text.Substring(num, 1).Equals("/"))
                                    {
                                        salir = 1;
                                    }
                                    else
                                    {
                                        numero = numero + textNumero.Text.Substring(num, 1);
                                    }
                                }

                            }
                            total = total + float.Parse(numero);
                            numero = "";
                            num = num - 1;
                        }
                        else
                        {
                            if (textNumero.Text.Substring(num, 1).Equals("-") && primera == 1)
                            {
                                while (salir == 0)
                                {
                                    num = num + 1;
                                    if (num >= textNumero.Text.Length)
                                    {
                                        salir = 1;
                                    }
                                    else
                                    {

                                        if (textNumero.Text.Substring(num, 1).Equals("+") || textNumero.Text.Substring(num, 1).Equals("-") || textNumero.Text.Substring(num, 1).Equals("*") || textNumero.Text.Substring(num, 1).Equals("/"))
                                        {
                                            salir = 1;
                                        }
                                        else
                                        {
                                            numero = numero + textNumero.Text.Substring(num, 1);
                                        }
                                    }

                                }
                                total = total - float.Parse(numero);
                                numero = "";
                                num = num - 1;

                            }
                            else
                            {
                                if (textNumero.Text.Substring(num, 1).Equals("*") && primera == 1)
                                {
                                    while (salir == 0)
                                    {
                                        num = num + 1;
                                        if (num >= textNumero.Text.Length)
                                        {
                                            salir = 1;
                                        }
                                        else
                                        {

                                            if (textNumero.Text.Substring(num, 1).Equals("+") || textNumero.Text.Substring(num, 1).Equals("-") || textNumero.Text.Substring(num,  1).Equals("*") || textNumero.Text.Substring(num, 1).Equals("/"))
                                            {
                                                salir = 1;
                                            }
                                            else
                                            {
                                                numero = numero + textNumero.Text.Substring(num, 1);
                                            }
                                        }

                                    }
                                    total = total * float.Parse(numero);
                                    numero = "";
                                    num = num - 1;

                                }
                                else
                                {
                                    if (textNumero.Text.Substring(num, 1).Equals("/") && primera == 1)
                                    {
                                        while (salir == 0)
                                        {
                                            num = num + 1;
                                            if (num >= textNumero.Text.Length)
                                            {
                                                salir = 1;
                                            }
                                            else
                                            {

                                                if (textNumero.Text.Substring(num, 1).Equals("+") || textNumero.Text.Substring(num, 1).Equals("-") || textNumero.Text.Substring(num, 1).Equals("*") || textNumero.Text.Substring(num,1).Equals("/"))
                                                {
                                                    salir = 1;
                                                }
                                                else
                                                {
                                                    numero = numero + textNumero.Text.Substring(num, 1);
                                                }
                                            }

                                        }
                                        total = total / float.Parse(numero);
                                        numero = "";
                                        num = num - 1;
                                    }
                                }
                            }
                        }
                    }

                    num = num + 1;

                }

                textNumero.Text="" + total;
            }
            else
            {
                if (b.Content.Equals("AC"))
                {
                    if (textNumero.Text.Length> 1)
                    {
                        textNumero.Text = textNumero.Text.Substring(0, textNumero.Text.Length - 1);
                    }
                    else
                    {
                        textNumero.Text = "0";
                    }

                }
                else
                {
                    textNumero.Text = textNumero.Text + b.Content;
                }
            }
        }
    }
}