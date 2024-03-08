using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class DonDatHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //khoi tao du lieu cho ddlBanh 
                ddlBanh.Items.Add(new ListItem("Bánh bao", "01"));
                ddlBanh.Items.Add(new ListItem("Bánh cam", "02"));
                ddlBanh.Items.Add(new ListItem("Bánh mì", "03"));
            }
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            bool checkExist = false;
            char[] delim = { '(', ')' };
            int soluong;
            //b1.kiem tra ton tai
            for (int i = 0; i < lstBanh.Items.Count; i++)
            {
                string itemText = lstBanh.Items[i].Text;
                if (itemText.Contains(ddlBanh.SelectedItem.Text)) {
                    //xu lyy cong don so luong
                    string[] arr = itemText.Split(delim);
                    soluong = int.Parse(txtSoLuong.Text) + int.Parse(arr[1]);
                    lstBanh.Items[i].Text = $"{ddlBanh.SelectedItem.Text} ({soluong})";
                    checkExist = true;
                    break;
                }
            }
            //b2.
            if (!checkExist)
            {
                string data = $"{ddlBanh.SelectedItem.Text} ({txtSoLuong.Text})";
                lstBanh.Items.Add(data);
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            //int index = lstBanh.SelectedIndex;
            //lstBanh.Items.RemoveAt(index);
            for (int i = lstBanh.Items.Count -1; i >= 0; i--)
            {
                if (lstBanh.Items[i].Selected)
                {
                    lstBanh.Items.RemoveAt(i);  
                }
            }
        }

        protected void btnIn_Click(object sender, EventArgs e)
        {
            string kq = "";
            //b1.thu thap thong tin
            kq += "<h2 class='text-center'> HÓA ĐƠN ĐẶT HÀNG </h2>";
            kq += "<div class='border border-primary'>";
            kq += "Khách hàng: <i>" + txtKH.Text + "</i><br>";
            kq += "Địa chỉ: <i>" + txtDiaChi.Text + "</i><br>";
            kq += "Mã Số Thuế: <i>" + txtMST.Text + "</i><br><br>";

            kq += "<b>Đặt các loại bánh sau: </br>";
            foreach (ListItem item in lstBanh.Items)
            {
                kq += "<br>" + item.Text;
            }

            kq += "</div>";
            kq += "</div>";

            //b2.gui thong tin ve client
            lbKetQua.Text = kq;
        }
    }
}