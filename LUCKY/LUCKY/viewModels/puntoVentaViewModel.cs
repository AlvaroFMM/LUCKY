using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using LUCKY.Models;
using LUCKY.Views;
using Xamarin.Forms;

namespace LUCKY.viewModels
{
    public class puntoVentaViewModel
    {
        public ObservableCollection <ClasVentas> ventas { get; set; }
        public puntoVentaViewModel()
        {
            ventas = new ObservableCollection<ClasVentas>
            {
              new ClasVentas
              {
                  nombrePuntoV = "Bodega Paquita ",
                  direccion = "AV. Peru# 1350 ",
                  distrito = "San Martin de Porres",
                  image = "maps.png",
                  latitud = 19.4343942,
                  longitud = -99.1330824,
                  
                  
              },
              new ClasVentas
              {
                  nombrePuntoV = "Metro Yzaguirre",
                  direccion = "AV. Peru# 2660",
                  distrito = "San Martin de Porres",
                  image = "maps.png",
                   latitud = 19.4343942,
                  longitud = -99.1330824,
              },
              new ClasVentas
              {
                  nombrePuntoV = "Ernesto Tito Galvez / Mrdo. Las Frutas",
                  direccion = "AV. Peru#1360",
                  distrito = "San Martin de Porres",
                  image = "maps.png",
                   latitud = 19.4343942,
                  longitud = -99.1330824,

              },
              new ClasVentas
              {
                  nombrePuntoV = "Ferreteria Carsina SAC",
                  direccion = "AV. Peru# 1741",
                  distrito = "San Martin de Porres",
                  image = "maps.png",
                   latitud = 19.4343942,
                  longitud = -99.1330824,
              },
                new ClasVentas
              {
                  nombrePuntoV = "Ferreteria Carsina SAC",
                  direccion = "AV. Peru# 1741",
                  distrito = "San Martin de Porres",
                  image = "maps.png",
                   latitud = 19.4343942,
                  longitud = -99.1330824,
              }

            };
         
        }
 

    }



}
