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

namespace Ejercicio4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {

            
            InitializeComponent();
            
            
                
                //caja.IsReadOnly
                 //caja.Text.Length
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           //:)
            
            if (caja.Text.Length == 140)
            {
                caja.IsReadOnly=true;
            }
            
            numero.Text =caja.Text.Length+"/140";
        }
    }
}
