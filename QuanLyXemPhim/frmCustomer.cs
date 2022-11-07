﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyXemPhim
{
    public partial class frmCustomer : Form
    {
        public static string phoneNumber = "";
        private frmTheatre frmTheatre;
        public frmCustomer(frmTheatre frm)
        {
            InitializeComponent();
            this.frmTheatre = frm;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            phoneNumber = txtCustomerPhone.Text;
            byte test = CustomerBUS.Instance.isMember(phoneNumber.Trim());
            if ( test == 1)
            {
                // forward to theatre form
                this.Hide();
                frmTheatre.loadDataCustomer();
            }
            else if (test == 0)
            {
                MessageBox.Show("Không tồn tại thành viên");
            }
            else
            {
                MessageBox.Show("Lỗi");
                
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog();
        }

    }
}
