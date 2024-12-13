using Parcial_III___Hotel.DataAccessObject.DataAccessObjectUC;
using Parcial_III___Hotel.Views;
using Parcial_III___Hotel.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_III___Hotel.Controllers.ControllersUC
{
    internal class ReservacionController
    {
        private ReservacionUC _reservacion1;


         public ReservacionController(ReservacionUC reservacion1) 
         {
            _reservacion1 = reservacion1;
           _reservacion1.btnMostrar.Click += BtnMostrar_Click;
             _reservacion1.calendario1.Click += Calendario1_Click;
            _reservacion1.calendario2.Click += Calendario2_Click;
            _reservacion1.calendario1.DoubleClick += Calendario1_DoubleClick;
            _reservacion1.calendario2.DoubleClick += Calendario2_DoubleClick;
            
            


         }

        private void Calendario2_DoubleClick(object? sender, EventArgs e)
        {
            _reservacion1.dateTimePicker2.Visible = false;
        }

        private void Calendario1_DoubleClick(object? sender, EventArgs e)
        {
            _reservacion1.dateTimePicker1.Visible = false;
        }

        private void Calendario2_Click(object? sender, EventArgs e)
         {
             _reservacion1.dateTimePicker2.Visible = true;
         }

         private void Calendario1_Click(object? sender, EventArgs e)
         {
             _reservacion1.dateTimePicker1.Visible = true;
         }

         private void BtnMostrar_Click(object? sender, EventArgs e)
         {
             ReservacionUCDAO.MostrarTabla(_reservacion1.dataGridViewHabitaciones);
         } 
     } 
    }
