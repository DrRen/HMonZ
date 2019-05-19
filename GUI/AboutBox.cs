using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HMonZ.GUI
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            this.Font = SystemFonts.MessageBoxFont;
            this.label3.Text = "Version " +
              System.Windows.Forms.Application.ProductVersion;
        }
    }
}