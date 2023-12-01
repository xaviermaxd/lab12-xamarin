﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab12.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejercicio : ContentPage
    {
        public Ejercicio()
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.EjercicioViewModel();
        }
    }
}