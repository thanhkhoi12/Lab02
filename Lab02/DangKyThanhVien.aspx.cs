﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class DangKyThanhVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlNgay.Items.Add(new ListItem("--Ngày--", ""));
                for (int i = 1; i <= 31; i++)
                {
                    ddlNgay.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                ddlThang.Items.Add(new ListItem("--Tháng--", ""));
                for (int i = 1; i <= 31; i++)
                {
                    ddlThang.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }

                ddlNam.Items.Add(new ListItem("--Năm--", ""));
                for (int i = 1; i <= 2010; i++)
                {
                    ddlNam.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
            }
        }

        protected void btDangKy_Click(object sender, EventArgs e)
        {
            //b1 thu thập thông tin
            string kq = "<ul>";
            kq += $"<li> Họ Tên khách hàng: {txtHoTen.Text} </li>";
            kq += $"<li> Tên đăng nhập: {txtTenDN.Text} </li>";
            kq += $"<li> Mật khẩu: {txtMatKhau.Text} </li>";
            kq += $"<li> Ngày sinh: {ddlNgay.SelectedValue}/{ddlThang.SelectedValue}/{ddlNam.SelectedValue}</li>";
            kq += $"<li> Email: {txtEmail.Text} </li>";
            kq += "</ul>";

            //b2. tra ket qua ve client
            lbKetQua.Text = kq;
        }
    }
}