﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3951_Lab5_WillOtterbein_dotnet
{
    public partial class ConfirmClose : Form
    {
        public ConfirmClose()
        {
            InitializeComponent();
        }

        public DialogResult getRestult()
        {
            return this.DialogResult;
        }

        private void ConfirmClose_Load(object sender, EventArgs e)
        {

        }
    }
}
