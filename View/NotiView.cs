﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.View
{
    public partial class NotiView : Form, INotiView
    {
        private Form previous;
        public Form form => this;
       
        public NotiView(Form previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

    }
}