﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Spravoshnic_HSR
{

    
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            //Фон
            pictureBox1.Load("../../Pictures/BackHelp.png");
        }
    }
}

