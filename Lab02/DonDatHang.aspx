<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DonDatHang.aspx.cs" Inherits="Lab02.DonDatHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.rtl.min.css" rel="stylesheet" />
</head>
<body>
           <form id="form1" runat="server">
        <div class="w-50 m-auto " >
            <div class="col-md-12">
                 <div class="row">
                     <div class="col-md-12 text-center bg-success">
                         ĐƠN ĐẶT HÀNG
             </div>
           </div>
         </div>
     

            <div class="row mb-2">
                <div class="col-3">
                    Khách hàng:
                </div>
            <div class="col-9">
                <asp:TextBox runat="server" CssClass="form-control" ID="txtKH"></asp:TextBox>
        </div>
    </div>
            <div class="row mb-2">
                <div class="col-3">
                    Địa chỉ:
                </div>
            <div class="col-9">
                <asp:TextBox ID="txtDiaChi" runat="server" CssClass="form-control"></asp:TextBox>
                
        </div>
    </div>
            <div class="row mb-2">
                <div class="col-3">
                    Mã số thuế:
                </div>
            <div class="col-9">
                <asp:TextBox ID="txtMST" runat="server" CssClass="form-control"></asp:TextBox>
                
        </div>
    </div>
                       <div class="row mb-2">
            <div class="col-md-6">
               <h5><p class="text-success">Chọn các loại bánh sau:</p></h5>

                <br />
                <asp:DropDownList ID="ddlBanh" runat="server"></asp:DropDownList>

                <br />
                 Số lượng:<asp:TextBox ID="txtSoLuong" runat="server" CssClass="form-control"></asp:TextBox>cái
                <asp:RequiredFieldValidator ID="rfvSoLuong" runat="server" ErrorMessage="Chưa nhập số " ControlToValidate="txtSoLuong" Text="(*)" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvSoLuong" runat="server" ErrorMessage="Số lượng không hợp lệ" ControlToValidate="txtSoLuong" Text="(*)" Operator="GreaterThan" Type="Double" ForeColor="Red"></asp:CompareValidator>

                <br />
                <asp:Button ID="btnThem" runat="server" OnClick="btnThem_Click" Text=">" Width="37px" />

                </div>
            <div class="col-md-6 border-top border-right border-bottom border-primary">
                    Danh sách bánh được đặt:

                <br />
                <asp:ListBox ID="lstBanh" SelectionMode="Multiple" runat="server" Width="70%"></asp:ListBox>
                <asp:ImageButton ID="btnXoa" ImageUrl="~/img/11-49-05-185__340.png" OnClick="btnXoa_Click" runat="server" Height="36px" Width="55px" />
    </div>
</div>
       <div class="row mb-2">
        <div class="col-md-12 text-center">
            <asp:Button ID="btnIn" runat="server" Text="In Đơn Đặt Hàng" OnClick="btnIn_Click"/>
    </div>
           <asp:ValidationSummary ID="vsThongBaoLoi" runat="server" />
</div>
            <asp:Label ID="lbKetQua" runat="server" Text="Kết Qủa"></asp:Label>
     </div>
         
           
    </form>
</body>
</html>