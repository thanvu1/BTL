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
    public partial class AddEmployee2 : Form
    {
        function fn = new function();
        String query;
        public AddEmployee2()
        {
            InitializeComponent();
        }
        public void clearAll()
        {
            txtAddress.Clear();
            txtChucVu.SelectedIndex = -1;
            txtMobile.Clear();
            txtid.Clear();
            txtEmail.Clear();
            txtMother.Clear();
            txtFather.Clear();
            txtName.Clear();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployee2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(470, 125);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtid.Text != "" && txtAddress.Text != "" && txtChucVu.SelectedIndex != -1 && txtEmail.Text != "")
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String name = txtName.Text;
                String father = txtFather.Text;
                String mother = txtMother.Text;
                String address = txtAddress.Text;
                String email = txtEmail.Text;
                String id = txtid.Text;
                String cv = txtChucVu.Text;

                query = "insert into newEmployee(emobile, ename, efname, emname, eemail, epaddress, eidproof, edesignation) values (" + mobile + ", '" + name + "', '" + father + "' , '" + mother + "', '" + address + "', '" + email + "', '" + id + "', '" + cv + "')";
                fn.setData(query, "Đã thêm nhân viên mới thành công!");
                clearAll();
            } else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information );

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
