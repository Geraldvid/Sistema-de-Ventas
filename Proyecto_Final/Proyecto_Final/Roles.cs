﻿using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Roles : Form
    {
        public Roles()
        {
            InitializeComponent();
        }

        Operaciones Oope = new Operaciones();
        private void Roles_Load(object sender, EventArgs e)
        {
            dgvroles.DataSource = Oope.mostrarRoles();
        }
    }
}
