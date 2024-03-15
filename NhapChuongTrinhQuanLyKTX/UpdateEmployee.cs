using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapChuongTrinhQuanLyKTX
{
    public partial class UpdateEmployee : Form
    {
        function fn = new function();
        String query;
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(470, 125);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void clearAll()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtFather.Clear();
            txtid.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtMother.Clear();
            txtWorking.SelectedIndex = -1;
            txtStatus.SelectedIndex = -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM newEmployee WHERE emobile = " + txtMobile.Text + "";
            DataSet ds = fn.GetData(query);//Lấy dữ liệu từ database của bảng newEmployee

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtFather.Text = ds.Tables[0].Rows[0][3].ToString();
                txtMother.Text = ds.Tables[0].Rows[0][4].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][6].ToString();
                txtid.Text = ds.Tables[0].Rows[0][7].ToString();
                txtWorking.Text = ds.Tables[0].Rows[0][8].ToString();
                txtStatus.Text = ds.Tables[0].Rows[0][9].ToString();
            }
            else
            {
                MessageBox.Show("Hồ sơ này không tồn tại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);//chuyển kiểu dữ liệu Int64
            String name = txtName.Text;
            String father = txtFather.Text;
            String mother = txtMother.Text;
            String email = txtEmail.Text;
            String address = txtAddress.Text;
            String status = txtStatus.Text;
            String working = txtWorking.Text;
            String id = txtid.Text;

            query = "Update newEmployee set ename = '" + name + "', efname = '" + father + "' , emname = '" + mother + "', eemail = '" + email + "', epaddress = '" + address + "', eidproof = '" + id + "' , edesignation = '" + working + "', working = '" + status + "' where emobile = " + mobile + "";
            fn.setData(query, "Cập nhật dữ liệu thành công");//lấy dữ liệu từ câu truy vấn trên để cập nhật lại bảng newEmployee
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //Truy vấn sql xóa dữ liệu sinh viên
                query = "delete from newEmployee where emobile= " + txtMobile.Text + "";
                fn.setData(query, "Đã xóa thông tin nhân viên!");/*truyền câu truy vấn vào hàm để xóa dữ liệu*/
                clearAll();
            }
        }
    }
}
