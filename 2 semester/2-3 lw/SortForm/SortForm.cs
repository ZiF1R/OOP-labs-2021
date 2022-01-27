﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_lw.SortForm
{
    public partial class SortForm : Form
    {
        public SortBy Sort { get; set; }
        public enum SortBy
        {
            AccountNumber,
            FullName,
            Balance,
            DepositType
        }

        public SortForm()
        {
            InitializeComponent();
        }

        public SortForm(SortBy sort)
        {
            this.Sort = sort;
            InitializeComponent();
            SortInputLabel.Text = $"Enter {this.Sort}:";
        }
    }
}
