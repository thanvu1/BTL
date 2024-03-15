using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fn = new Form1();
            fn.Show();
            this.Close();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRoom amr = new AddNewRoom();
            amr.Show();
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            newStudent.Show();
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UpdateStudent us = new UpdateStudent();
            us.Show();
        }

        private void btnStudentFee_Click(object sender, EventArgs e)
        {
            PayRoom pr = new PayRoom();
            pr.Show();
        }

        private void btnLeavedStudent_Click(object sender, EventArgs e)
        {
            LeavedStudent lv = new LeavedStudent();
            lv.Show();
        }

        private void btnStudentLiving_Click(object sender, EventArgs e)
        {
            StudentStatus status = new StudentStatus();
            status.Show();
        }

        private void NewEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee2 ne = new AddEmployee2();
            ne.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateEmployee ue = new UpdateEmployee();
            ue.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AllEmployee all = new AllEmployee();
            all.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            EmployeeRetired er = new EmployeeRetired();
            er.Show();
        }
    }
}
