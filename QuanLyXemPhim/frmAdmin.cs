﻿using QuanLyXemPhim.frmAdminUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXemPhim
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }


        private void btnRevenueUC_Click(object sender, EventArgs e)
        {
        }

        private void btnDataUC_Click(object sender, EventArgs e)
        {
            FeatureViewUC featureViewUC = new FeatureViewUC();
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(featureViewUC);
        }

        private void btnStaffUC_Click(object sender, EventArgs e)
        {
            StaffUC staffUC = new StaffUC();
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(staffUC);
        }

        private void btnCustomerUC_Click(object sender, EventArgs e)
        {
            CustomerUC customerUC = new CustomerUC();   
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(customerUC);
        }

        private void btnAccountUC_Click(object sender, EventArgs e)
        {
            AccountUC accountUC = new AccountUC();
            pnAdmin.Controls.Clear();
            pnAdmin.Controls.Add(accountUC);
        }

        private void pnAdmin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
