﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapChuongTrinhQuanLyKTX
{
    public partial class AllEmployee : Form
    {
        function fn = new function();
        String query;
        public AllEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(470, 125);
            query = "SELECT  * FROM newEmployee WHERE working = 'Yes' ";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
    }
}
