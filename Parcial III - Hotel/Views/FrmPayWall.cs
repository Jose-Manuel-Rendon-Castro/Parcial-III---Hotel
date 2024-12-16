using Parcial_III___Hotel.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_III___Hotel.Views
{
    public partial class FrmPayWall : Form
    {
        private PayWallController _payWallController;
        public FrmPayWall()
        {
            InitializeComponent();
            _payWallController = new PayWallController(this);
        }

    }
}
