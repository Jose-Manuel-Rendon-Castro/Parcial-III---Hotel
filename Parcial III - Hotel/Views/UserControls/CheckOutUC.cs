using Parcial_III___Hotel.Controllers.ControllersUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_III___Hotel.Views.UserControls
{
    public partial class CheckOutUC : UserControl
    {
        private CheckOutController _checkOutController;
        public CheckOutUC()
        {
            InitializeComponent();
            _checkOutController = new CheckOutController(this);
        }
    }
}
