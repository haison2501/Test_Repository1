using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using hsLibrary;
using System.Text;
using System.Net;
using System.Xml;
public partial class benhnhan_ajax : NormalPage
{
    //_______________________________________________________________________________________________________
    protected DataProcess s_benhnhan()
    {
        benhnhan.data("idbenhnhan", Codec.DecryptAES(Request.QueryString["idkhoachinh"]));
        benhnhan.data("mabenhnhan", Request.QueryString["mabenhnhan"]);
        benhnhan.data("tenbenhnhan", Request.QueryString["tenbenhnhan"]);
        benhnhan.data("idloaiuutien", Request.QueryString["idloaiuutien"]);
        benhnhan.data("diachi", Request.QueryString["diachi"]);
        benhnhan.data("dienthoai", Request.QueryString["dienthoai"]);
        benhnhan.data("gioitinh", Request.QueryString["gioitinh"]);
        benhnhan.data("ngaysinh", Request.QueryString["ngaysinh"]);
        benhnhan.data("loai", Request.QueryString["loai"]);
        benhnhan.data("nghenghiep", Request.QueryString["nghenghiep"]);
        benhnhan.data("noicongtac", Request.QueryString["noicongtac"]);
        benhnhan.data("ngaytiepnhan", Request.QueryString["ngaytiepnhan"]);
        benhnhan.data("SoTuoi", Request.QueryString["SoTuoi"]);
        benhnhan.data("SoThang", Request.QueryString["SoThang"]);
        benhnhan.data("nghenghiep", Request.QueryString["nghenghiep"]);
        benhnhan.data("quoctich", Request.QueryString["quoctich"]);
        benhnhan.data("dantoc", Request.QueryString["dantoc"]);
        benhnhan.data("noicongtac", Request.QueryString["noicongtac"]);
        benhnhan.data("chungminhthu", Request.QueryString["chungminhthu"]);
        benhnhan.data("lidovaovien", "");
        benhnhan.data("tinhid", Request.QueryString["tinhid"]);
        benhnhan.data("quanhuyenid", Request.QueryString["quanhuyenid"]);
        benhnhan.data("phuongxaid", Request.QueryString["phuongxaid"]);
        benhnhan.data("sonha", Request.QueryString["sonha"]);
        benhnhan.data("SLBN", Request.QueryString["SLBN"]);
        benhnhan.data("NguoiGiamHo", Request.QueryString["NguoiGiamHo"]);
        benhnhan.data("IdCapBac", Request.QueryString["IdCapBac"]);
        benhnhan.data("idcongty", Request.QueryString["idcongty"]);
        benhnhan.data("UserName_AD", Request.QueryString["UserName_AD"]);
        benhnhan.data("UserName", Request.QueryString["UserName"]);
        benhnhan.data("matkhau", Request.QueryString["matkhau"]);

        benhnhan.data("email", Request.QueryString["email"]);

        return benhnhan;
    }
    //_______________________________________________________________________________________________________
    protected DataProcess s_sinhhieu()
    {
        DataProcess kb_sinhhieu = new DataProcess("sinhhieu");
        kb_sinhhieu.data("idsinhhieu", Request.QueryString["idsinhhieu"]);
        kb_sinhhieu.data("mach", Request.QueryString["mach"]);
        kb_sinhhieu.data("nhietdo", Request.QueryString["nhietdo"]);
        kb_sinhhieu.data("huyetap1", Request.QueryString["huyetap1"]);
        kb_sinhhieu.data("huyetap2", Request.QueryString["huyetap2"]);
        kb_sinhhieu.data("nhiptho", Request.QueryString["nhiptho"]);
        kb_sinhhieu.data("chieucao", Request.QueryString["chieucao"]);
        kb_sinhhieu.data("cannang", Request.QueryString["cannang"]);
        kb_sinhhieu.data("BMI", Request.QueryString["BMI"]);
        kb_sinhhieu.data("glucose", Request.QueryString["glucose"]);
        return kb_sinhhieu;
    }
    //_______________________________________________________________________________________________________

    protected void Page_Load(object sender, EventArgs e)
    {
        string action = Request.QueryString["do"];
        switch (action)
        {
            case "Luu": Savebenhnhan(); break;
            case "TimKiem": TimKiem(); break;
            case "setTimKiem": setTimKiem(); break;
            case "xoa": Xoabenhnhan(); break;
            case "idloaiuutienSearch": idloaiuutienSearch(); break;
            case "loaiSearch": loaiSearch(); break;
            case "IdCapBacSearch": IdCapBacSearch(); break;
            case "idphongkhambenhSearch": idphongkhambenhSearch(); break;
            case "idphongkhambenhSearch2": idphongkhambenhSearch2(); break;
            case "idkhoasearch": idkhoasearch(); break;
            case "dangkykhambenh": dangkykhambenh(); break;
            case "loadSTT": loadSTT(); break;
            case "ktramabh": ktramabh(); break;
            case "idChuyenKhoaSearch": idChuyenKhoaSearch(); break;
            case "tinhidSearch": tinhidSearch(); break;
            case "quanhuyenidSearch": quanhuyenidSearch(); break;
            case "phuongxaidSearch": phuongxaidSearch(); break;
            case "loadDSDangkykham": loadDSDangkykham(); break;
            case "TimDiaChi": TimDiaChi(); break;
            case "getTileBHYT": getTileBHYT(); break;
            case "TinhTuoiBenhNhan": TinhTuoiBenhNhan(); break;
            case "TinhNamSinh_TheoTuoi": TinhNamSinh_TheoTuoi(); break;
            case "TinhNamSinh_TheoThang": TinhNamSinh_TheoThang(); break;
            case "GetList_DangKyCapGiayKSK": GetList_DangKyCapGiayKSK(); break;
            case "GetLastMaPhieuCLS": GetLastMaPhieuCLS(); break;
            case "checkBN": checkBN(); break;
            case "idbacsisearch": idbacsisearch(); break;
            case "LoadChanDoanMoTaICD": LoadChanDoanMoTaICD(); break;
            case "LoadChanDoanMaICD": LoadChanDoanMaICD(); break;
            case "idkhoa_noitru_search": idkhoa_noitru_search(); break;
            case "chonbhkhac": chonbhkhac(); break;
            case "chonthongtinbh": chonthongtinbh(); break;
            case "loadmanghenghiep": loadmanghenghiep(); break;
            case "loadtennghenghiep": loadtennghenghiep(); break;
            case "loadmaquoctich": loadmaquoctich(); break;
            case "loadtenquoctich": loadtenquoctich(); break;
            case "loadmadantoc": loadmadantoc(); break;
            case "loadtendantoc": loadtendantoc(); break;
            case "idnghenghiepsearch": idnghenghiepsearch(); break;
            case "iddantocsearch": iddantocsearch(); break;
            case "idquoctichsearch": idquoctichsearch(); break;
            case "loadmadangky": loadmadangky(); break;
            case "loadnoidangky": loadnoidangky(); break;
            case "setdefault": setdefault(); break;
            case "check_chungminhthu": check_chungminhthu(); break;
            case "get_last_thongtin_bh": get_last_thongtin_bh(); break;
            case "check_thuphi": check_thuphi(); break;
            case "TinhLaiTien": TinhLaiTien(); break;
            case "CheckIsKhamSucKhoe": CheckIsKhamSucKhoe(); break;
            case "MaPhieu_new": MaPhieu_new(); break;
            case "getidchitietdkkham": getidchitietdkkham(); break;
            case "LayIDChiTietDangKyKham": LayIDChiTietDangKyKham(); break;
            case "IsPrintMaVach": IsPrintMaVach(); break;
            case "KiemTraBenhNhanTheoSoBHYT": KiemTraBenhNhanTheoSoBHYT(); break;
            case "LayThongTinMaCode": LayThongTinMaCode(); break;
            case "loadmadangky_bh": loadmadangky_bh(); break;
            case "LayThongTinDangKy": LayThongTinDangKy(); break;
            case "LayIDBenhNhanTheoMaBN": LayIDBenhNhanTheoMaBN(); break;
            case "SetControlDKKOnline": SetControlDKKOnline(); break;
            case "TenBN_Search": TenBN_Search(); break;
            case "CheckBaoHiemYTe": CheckBaoHiemYTe(); break;
            case "CheckExitsSoBHYT": CheckExitsSoBHYT(); break;
            case "IntelName": IntelName(); break;
            case "XoaBenhNhan": XoaBenhNhan(); break;
            case "GiaHanTheBHYT": GiaHanTheBHYT(); break;
            case "KhamBenhTheoHen": KhamBenhTheoHen(); break;
            case "GetLastIdKhamBenh": GetLastIdKhamBenh(); break;
            case "Xoadangkykham": Xoadangkykham(); break;
            case "View_DangKyKham": View_DangKyKham(); break;
            case "ViewTinhTrangPhong": ViewTinhTrangPhong(); break;
            case "check_EmplCode": check_EmplCode(); break;
            case "RestPassBN": RestPassBN(); break;
            case "CheckUserNameAjax": CheckUserNameAjax(); break;
            case "SendMessage_Just_DangKyKhamBenh": SendMessage_Just_DangKyKhamBenh(); break;
            case "idchucvuSeach": idchucvuSeach(); break;
            case "find_by_dien_thoai": find_by_dien_thoai(); break;
            case "find_By_Ma_Dat_Lich_KCB": find_By_Ma_Dat_Lich_KCB(); break;
            case "show_mobile_account": show_mobile_account(); break;    
        }
    }
    //_______________________________________________________________________________________________________
    private void find_By_Ma_Dat_Lich_KCB()
    {
        Response.Clear();
        string ma_dat_lich_kcb = Request.QueryString["ma_dat_lich_kcb"];
        string sqlSelect = @"
                              select  *,a.ngay_hen as ngay_dang_ky,PHONG_ID=c.ID,c.*
                                from lich_hen_kham_benh a
                                left join loai_kham b on a.loai_kham_id=b.id
								LEFT JOIN PHONG C ON A.PHONG_ID=C.ID
								left join nguoi_benh d on a.nguoi_benh_id=d.id
                                where replace(ma_phieu_kham,'-','_')='" + ma_dat_lich_kcb.Replace("-", "_") + @"'";
        DataTable dt = DataAces_Postgre.Connect.GetTable(sqlSelect);
        if (dt == null || dt.Rows.Count == 0) return;
        string sqlCheck_xac_nhan = "select * from dangkykham where lich_hen_kham_benh_id =" + dt.Rows[0]["ID"].ToString();
        DataTable dt_check_xac_nhan = DataAcess.Connect.GetTable(sqlCheck_xac_nhan);
        Response.Write( dt.Rows[0]["id_benh_nhan"].ToString() +"|" + dt_check_xac_nhan.Rows.Count.ToString());
    }
    //_______________________________________________________________________________________________________
    private void find_by_dien_thoai()
    {
        Response.Clear();
        string sqlSelect = "select idbenhnhan from benhnhan where dienthoai=N'" + Request.QueryString["dienthoai"] + "'";
        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        if (dt == null || dt.Rows.Count == 0) return;
        Response.Write(dt.Rows[0][0].ToString());
    }
    //_______________________________________________________________________________________________________
    private void show_mobile_account()
    {
        string idbenhnhan = Request.QueryString["idbenhnhan"];
        if (idbenhnhan == null || idbenhnhan == "") return;
        if (idbenhnhan.Length > 0) idbenhnhan = Codec.DecryptAES(idbenhnhan);
        string sqlSelect = "SELECT nguoi_benh_id,pass_init  FROM benhnhan WHERE idbenhnhan=" + idbenhnhan;
        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        if (dt == null || dt.Rows.Count == 0) return;
        string sql_Nguoi_Benh = "SELECT * FROM NGUOI_BENH WHERE id=" + dt.Rows[0]["nguoi_benh_id"].ToString();
        DataTable dt2 = DataAces_Postgre.Connect.GetTable(sql_Nguoi_Benh);
        if (dt2 == null || dt2.Rows.Count == 0) return;
        string html = "";
        html += "<table class='jtable' id=\"gridTable_account\">";
        html += "<tr>";
        html += "<td>Tài khoản</td>";
        html += "<td>" +Codec.DecryptAES( dt2.Rows[0]["user_name"].ToString()) + "</td>";
        html += "</tr>";
        html += "<tr>";
        html += "<td>Mật khẩu khởi tạo</td>";
        html += "<td>" + dt.Rows[0]["pass_init"].ToString() + "</td>";
        html += "</tr>";
        Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void GiaHanTheBHYT()
    {
        string ngaybatdau = Request.QueryString["ngaybatdau"];
        string ngayhethan = Request.QueryString["ngayhethan"];
        if (ngaybatdau == null || ngaybatdau == "") return;
        if (ngayhethan == null || ngayhethan == "") return;

        ngaybatdau = StaticData.CheckDate(ngaybatdau);
        ngayhethan = StaticData.CheckDate(ngayhethan);
        DateTime d1 = DateTime.Parse(ngaybatdau);
        DateTime d2 = DateTime.Parse(ngayhethan);
        TimeSpan t = (TimeSpan)(d2 - d1);
        double songay = t.TotalDays;
        d1 = d2.AddDays(1);
        d2 = d1.AddDays(songay - 1);
        string ngaybatdau_new = d1.ToString("dd/MM/yyyy");
        string ngayhethan_new = d2.ToString("dd/MM/yyyy");
        Response.Clear();
        Response.Write(ngaybatdau_new + ";" + ngayhethan_new);
    }
    //_______________________________________________________________________________________________________
    private void IntelName()
    {
        Response.Clear();
        string sValue = Request.QueryString["sValue"];
        if (sValue == null || sValue == "")
        {
            Response.Write("");
            return;
        }
        sValue = StaticData.IntelName(sValue);
        Response.Write(sValue);
    }
    //_______________________________________________________________________________________________________
    private void getidchitietdkkham()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        string iddkkham = Request.QueryString["iddangkykham"];
        string sql = @"select idchitietdangkykham from chitietdangkykham where iddangkykham ='" + iddkkham + "'";
        string idchitietdkkham = DataAcess.Connect.GetTable(sql).Rows[0][0].ToString();
        Response.Clear();
        Response.Write(idchitietdkkham);
    }
    //_______________________________________________________________________________________________________
    private void CheckIsKhamSucKhoe()
    {
        string value = "0";
        string idphong = Request.QueryString["idphong"];
        if (!string.IsNullOrEmpty(idphong))
        {
            string sql = "select * from kb_phong p inner join banggiadichvu bg on bg.idbanggiadichvu =p.DichVuKCB where p.Id='" + idphong + "'and bg.isKhamSucKhoe=1";
            DataTable dt = DataAcess.Connect.GetTable(sql);
            if (dt != null && dt.Rows.Count > 0)
                value = "1";
        }
        Response.Clear();
        Response.Write(value);
    }
    //_______________________________________________________________________________________________________
    private void MaPhieu_new()
    {
        string maphieu = StaticData.MaPhieu_new();
        Response.Clear();
        Response.Write(maphieu);

    }
    //_______________________________________________________________________________________________________
    private void check_thuphi()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        string idbenhnhan_bh = Request.QueryString["idbenhnhan_bh"];
        string sqlSelect = @"SELECT DATHU 
                             FROM DANGKYKHAM  
                        WHERE IDBENHNHAN='" + idbenhnhan + "'" + " AND IDBENHNHAN_BH='" + idbenhnhan_bh + "'";
        DataTable dtCheck = DataAcess.Connect.GetTable(sqlSelect);
        if (dtCheck == null || dtCheck.Rows.Count == 0) return;
        Response.Write("Không thể sửa số BHYT khi đã thu phí rồi. Cảm ơn.");

    }
    //_______________________________________________________________________________________________________
    private void Set_ThongTinBaoHiem(string IdBenhNhan, string IdBenhNhan_BH)
    {
        string sql = @"SELECT TOP 1 * FROM BENHNHAN_BHYT WHERE " + (IdBenhNhan_BH != null && IdBenhNhan_BH != "" ? "  IdBenhNhan_BH=" + IdBenhNhan_BH : "  IDBENHNHAN='" + IdBenhNhan + "'") + " ORDER BY IDBENHNHAN_BH DESC";
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        html += "<root>";
        if (table != null && table.Rows.Count > 0)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string sqlSelect = @"SELECT * FROM KB_NOIDANGKYKB WHERE IDNOIDANGKY='" + table.Rows[i]["IdNoiDangKyBH"].ToString() + "'";
                DataTable dtKBNoiDangKy = DataAcess.Connect.GetTable(sqlSelect);
                html += "<data id=\"mvk_MADANGKY\">" + ((dtKBNoiDangKy != null && dtKBNoiDangKy.Rows.Count > 0) ? dtKBNoiDangKy.Rows[0]["MADANGKY"].ToString() : "") + "</data>";
                html += "<data id=\"mkv_TENNOIDANGKY\">" + ((dtKBNoiDangKy != null && dtKBNoiDangKy.Rows.Count > 0) ? dtKBNoiDangKy.Rows[0]["TENNOIDANGKY"].ToString() : "") + "</data>";
                string sqlSelect2 = @"SELECT * FROM KB_NOIDANGKYKB WHERE IDNOIDANGKY='" + table.Rows[i]["IdNoiGioiThieu"].ToString() + "'";
                DataTable dtKBNoiDangKy2 = DataAcess.Connect.GetTable(sqlSelect2);
                html += "<data id=\"idNoiGioiThieu\">" + ((dtKBNoiDangKy2 != null && dtKBNoiDangKy2.Rows.Count > 0) ? table.Rows[i]["IdNoiGioiThieu"].ToString() : "") + "</data>";
                html += "<data id=\"mkv_ma_noigioithieu\">" + ((dtKBNoiDangKy2 != null && dtKBNoiDangKy2.Rows.Count > 0) ? dtKBNoiDangKy2.Rows[0]["MADANGKY"].ToString() : "") + "</data>";
                html += "<data id=\"mkv_idNoiGioiThieu\">" + ((dtKBNoiDangKy2 != null && dtKBNoiDangKy2.Rows.Count > 0) ? dtKBNoiDangKy2.Rows[0]["TENNOIDANGKY"].ToString() : "") + "</data>";
                html += "<data id=\"TraiTuyen\">" + (table.Rows[i]["DungTuyen"].ToString() == "Y" ? "False" : "True") + "</data>";
                html += Environment.NewLine;
                for (int y = 0; y < table.Columns.Count; y++)
                {
                    try
                    {
                        html += "<data id='" + table.Columns[y].ToString() + "'>" + DateTime.Parse(table.Rows[0][y].ToString()).ToString("dd/MM/yyyy") + "</data>";
                    }
                    catch (Exception)
                    {
                        html += "<data id='" + table.Columns[y].ToString() + "'>" + table.Rows[0][y].ToString() + "</data>";
                    }
                    html += Environment.NewLine;
                }
                html += "<data id=\"dungtuyen\">" + (table.Rows[i]["DungTuyen"].ToString() == "Y" ? "True" : "False") + "</data>";
            }
        }
        html += "</root>";
        Response.Clear();
        Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void get_last_thongtin_bh()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        Set_ThongTinBaoHiem(idbenhnhan, null);
    }
    //_______________________________________________________________________________________________________
    private void check_chungminhthu()
    {
        string socmnd = Request.QueryString["chungminhthu"];
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        if (socmnd == null && socmnd == "") return;
        string sqlSelect = @"SELECT CHUNGMINHTHU FROM BENHNHAN WHERE CHUNGMINHTHU='" + socmnd + "'";
        if (idbenhnhan != null && idbenhnhan != "")
            sqlSelect += " AND IDBENHNHAN<>" + idbenhnhan;
        DataTable dtCheck = DataAcess.Connect.GetTable(sqlSelect);
        if (dtCheck != null && dtCheck.Rows.Count > 0)
        {
            Response.Write("Số chứng minh thư này đã có người khác dùng rồi ! \n Vui lòng chọn số khác");
            return;
        }
    }
    //_______________________________________________________________________________________________________
    private void setdefault()
    {
        string html = "";
        html += "<root>";
        DateTime now = DateTime.Now;
        html += "<data id=\"ngaytiepnhan\">" + string.Format("{0:dd/MM/yyyy}", now) + "</data>";
        html += "<data id=\"gio\">" + string.Format("{0:HH}", now) + "</data>";
        html += "<data id=\"phut\">" + string.Format("{0:mm}", now) + "</data>";
        html += "<data id=\"giodk\">" + string.Format("{0:HH}", now) + "</data>";
        html += "<data id=\"phutdk\">" + string.Format("{0:mm}", now) + "</data>";
        html += "<data id=\"ngaydangky\">" + string.Format("{0:dd/MM/yyyy}", now) + "</data>";

        html += "</root>";
        Response.Clear();
        Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    public void idquoctichsearch()
    {
        string sql1 = "select * from quoctich where tenquoctich like N'" + Request.QueryString["q"] + "%'";
        DataTable table = DataAcess.Connect.GetTable(sql1);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i]["tenquoctich"].ToString() + "|" + table.Rows[i]["idquoctich"].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    public void idchucvuSeach()
    {
        string sql1 = "select * from chucvu where tenchucvu like N'" + Request.QueryString["q"] + "%'";
        sql1 += " ORDER BY tenchucvu";


        DataTable table = DataAcess.Connect.GetTable(sql1);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i]["TENCHUCVU"].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    public void idnghenghiepsearch()
    {
        string sql1 = "select * from nghenghiep where tennghenghiep like N'" + Request.QueryString["q"] + "%'";
        DataTable table = DataAcess.Connect.GetTable(sql1);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][2].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    public void iddantocsearch()
    {
        string sql1 = "select * from dantoc where tendantoc like N'" + Request.QueryString["q"] + "%'";
        DataTable table = DataAcess.Connect.GetTable(sql1);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][1].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadmadantoc()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and madantoc like N'" + Request.QueryString["q"] + "%'";
        }

        string sql = @"select top 10 * from dantoc where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}",
                                     "<div style=\"width:100%;height:20px\">"
                                             + "<div style=\"width:35%;float:left;height:20px\" >" + row["madantoc"] + "</div>"
                         + "<div style=\"width:55%;float:left;height:20px\" >" + row["tendantoc"] + "</div>"
                                     + "</div>", row["madantoc"], row["tendantoc"], row["id"], Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadtendantoc()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and tendantoc like N'" + Request.QueryString["q"] + "%'";
        }

        string sql = @"select top 10 * from dantoc where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}",
                                     "<div style=\"width:100%;height:20px\">"
                                         + "<div style=\"width:35%;float:left;height:20px\" >" + row["madantoc"] + "</div>"
                         + "<div style=\"width:55%;float:left;height:20px\" >" + row["tendantoc"] + "</div>"
                                     + "</div>", row["madantoc"], row["tendantoc"], row["id"], Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadmaquoctich()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and maquoctich like N'" + Request.QueryString["q"] + "%'";
        }

        string sql = @"select * from quoctich where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}",
                                     "<div style=\"width:100%;height:20px\">"
                                         + "<div style=\"width:35%;float:left;height:20px\" >" + row["maquoctich"] + "</div>"
                         + "<div style=\"width:55%;float:left;height:20px\" >" + row["tenquoctich"] + "</div>"
                                     + "</div>", row["maquoctich"], row["tenquoctich"], row["idquoctich"], Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadtenquoctich()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and tenquoctich like N'" + Request.QueryString["q"] + "%'";
        }

        string sql = @"select top 10 * from quoctich where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}",
                                     "<div style=\"width:100%;height:20px\">"
                                         + "<div style=\"width:35%;float:left;height:20px\" >" + row["maquoctich"] + "</div>"
                         + "<div style=\"width:55%;float:left;height:20px\" >" + row["tenquoctich"] + "</div>"
                                     + "</div>", row["maquoctich"], row["tenquoctich"], row["idquoctich"], Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadmanghenghiep()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and manghenghiep like N'" + Request.QueryString["q"] + "%'";
        }

        string sql = @"select top 10 * from nghenghiep where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}",
                                     "<div style=\"width:100%;height:20px\">"
                                         + "<div style=\"width:35%;float:left;height:20px\" >" + row["manghenghiep"] + "</div>"
                         + "<div style=\"width:55%;float:left;height:20px\" >" + row["tennghenghiep"] + "</div>"
                                     + "</div>", row["manghenghiep"], row["tennghenghiep"], row["idnghenghiep"], Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadtennghenghiep()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and tennghenghiep like N'" + Request.QueryString["q"] + "%'";
        }

        string sql = @"select top 10 * from nghenghiep where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}",
                                     "<div style=\"width:100%;height:20px\">"
                                         + "<div style=\"width:35%;float:left;height:20px\" >" + row["manghenghiep"] + "</div>"
                         + "<div style=\"width:55%;float:left;height:20px\" >" + row["tennghenghiep"] + "</div>"
                                     + "</div>", row["manghenghiep"], row["tennghenghiep"], row["idnghenghiep"], Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadmadangky()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and MADANGKY like N'%" + Request.QueryString["q"] + "%'";
        }

        string sql = @"select top 10 * from kb_noidangkykb where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}|{5}",
                                     "<div style=\"width:100%;height:20px\">"
                                         + "<div style=\"width:20%;float:left;height:20px; padding-left:10px;\" >" + row["MADANGKY"] + "</div>"
                                         + "<div style=\"width:60%;float:left;height:20px\" >" + row["TENNOIDANGKY"] + "</div>"
                                         + "<div style=\"width:20%;float:left;height:20px\" >" + (StaticData.IsCheck(row["DUNGTUYEN"].ToString()) ? "Đúng tuyến" : "Trái tuyến") + "</div>"
                                     + "</div>", row["MADANGKY"], row["TENNOIDANGKY"], row["IDNOIDANGKY"], (StaticData.IsCheck(row["DUNGTUYEN"].ToString()) ? "Đúng tuyến" : "Trái tuyến"), Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadnoidangky()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and TENNOIDANGKY like N'%" + Request.QueryString["q"] + "%'";
        }

        string sql = @"select * from kb_noidangkykb where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}|{5}",
                                     "<div style=\"width:100%;height:20px\">"
                                         + "<div style=\"width:20%;float:left;height:20px; padding-left:10px;\" >" + row["MADANGKY"] + "</div>"
                                         + "<div style=\"width:60%;float:left;height:20px\" >" + row["TENNOIDANGKY"] + "</div>"
                                         + "<div style=\"width:20%;float:left;height:20px\" >" + (StaticData.IsCheck(row["DUNGTUYEN"].ToString()) ? "Đúng tuyến" : "Trái tuyến") + "</div>"
                                     + "</div>", row["MADANGKY"], row["TENNOIDANGKY"], row["IDNOIDANGKY"], (StaticData.IsCheck(row["DUNGTUYEN"].ToString()) ? "Đúng tuyến" : "Trái tuyến"), Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void chonthongtinbh()
    {
        Set_ThongTinBaoHiem(null, Request.QueryString["idbenhnhan_bh"]);

    }
    //_______________________________________________________________________________________________________
    private void chonbhkhac()
    {
        string sql = @"SELECT A.*,B.MaBenhNhan 
                        ,NOIGT=NGT.TENNOIDANGKY
                        ,NOIDANGKYKB=NDK.TENNOIDANGKY
                        ,MADANGKYKB=NDK.MADANGKY
                        FROM BENHNHAN_BHYT A 
                        LEFT JOIN BENHNHAN B ON A.IDBENHNHAN=B.IDBENHNHAN 
                        LEFT JOIN KB_NOIDANGKYKB NDK ON A.IDNOIDANGKYBH=NDK.IDNOIDANGKY
                        LEFT JOIN KB_NOIDANGKYKB NGT ON A.IDNOIGIOITHIEU=NGT.IDNOIDANGKY  
                        WHERE 1=1";
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        if (idbenhnhan != null && idbenhnhan != "")
        {
            sql += " AND A.IDBENHNHAN=" + idbenhnhan;
        }
        DataTable dt = DataAcess.Connect.GetTable(sql);
        string html = "";
        html += "<table class='jtable' id=\"gridTable\">";
        html += "<tr>";
        html += "<th>" + hsLibrary.clDictionaryDB.sGetValueLanguage("Mã bệnh nhân") + "</th>";
        html += "<th>" + hsLibrary.clDictionaryDB.sGetValueLanguage("Số BHYT") + "</th>";
        html += "<th>" + hsLibrary.clDictionaryDB.sGetValueLanguage("Ngày bắt đầu") + "</th>";
        html += "<th>" + hsLibrary.clDictionaryDB.sGetValueLanguage("Ngày hết hạn") + "</th>";
        html += "<th>" + hsLibrary.clDictionaryDB.sGetValueLanguage("Nơi giới thiệu") + "</th>";
        html += "<th>" + hsLibrary.clDictionaryDB.sGetValueLanguage("Nơi ĐK.KCB") + "</th>";
        html += "<th>" + hsLibrary.clDictionaryDB.sGetValueLanguage("Mã nơi ĐK.KCB") + "</th>";
        html += "</tr>";
        if (dt != null && dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                html += "<tr style='cursor:pointer' onclick=\"javascript:chonthongtinbh(" + dt.Rows[i]["IDBENHNHAN_BH"] + ",'" + string.Format("{0:dd/MM/yyyy}", dt.Rows[i]["ngayhethan"]) + "');\" >";
                html += "<td>" + dt.Rows[i]["mabenhnhan"].ToString() + "</td>";
                html += "<td>" + dt.Rows[i]["sobhyt"].ToString() + "</td>";
                html += "<td>" + string.Format("{0:dd/MM/yyyy}", dt.Rows[i]["ngaybatdau"]) + "</td>";
                html += "<td>" + string.Format("{0:dd/MM/yyyy}", dt.Rows[i]["ngayhethan"]) + "</td>";
                html += "<td>" + dt.Rows[i]["NOIGT"] + "</td>";
                html += "<td>" + dt.Rows[i]["NOIDANGKYKB"] + "</td>";
                html += "<td>" + dt.Rows[i]["MADANGKYKB"] + " </td>";
                html += "</tr>";
            }
        }
        else
        {
            Response.Clear();
            Response.Write("");
            return;
        }
        html += "</table>";
        Response.Clear();
        Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void LoadChanDoanMaICD()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and maicd like N'" + Request.QueryString["q"] + "%'";
        }

        string sql = @"SELECT top 20 * FROM chandoanicd where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}",
                                     "<div style=\"width:100%;height:20px\">"
                                         + "<div style=\"width:15%;float:left;height:20px\" >" + row["maicd"] + "</div>"
                         + "<div style=\"width:85%;float:left;height:20px\" >" + row["mota"] + "</div>"
                                     + "</div>", row["maicd"], row["mota"], row["idicd"], Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void LoadChanDoanMoTaICD()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and mota like N'" + Request.QueryString["q"] + "%'";
        }

        string sql = @"SELECT top 20 * FROM chandoanicd where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    html += string.Format("{0}|{1}|{2}|{3}|{4}",
                                     "<div style=\"width:100%;height:30px\">"
                                         + "<div style=\"width:15%;float:left;height:30px\" >" + row["maicd"] + "</div>"
                         + "<div style=\"width:85%;float:left;height:30px\" >" + row["mota"] + "</div>"
                                     + "</div>", row["maicd"], row["mota"], row["idicd"], Environment.NewLine);

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void idbacsisearch()
    {
        string TenBS = Request.QueryString["q"].ToString();
        string idkhoa = Request.QueryString["idkhoa"].ToString().Trim();
        string sqlBS = @"SELECT 
            A.IDBACSI AS IDBACSI
            ,A.TENBACSI AS TENBACSI
            FROM BACSI A
            WHERE tenbacsi like N'%" + TenBS + "%'";

        if (idkhoa != null && idkhoa != "")
        {
            sqlBS += "   and idphongkhambenh = '" + Request.QueryString["idkhoa"] + "'";
        }
        DataTable table = DataAcess.Connect.GetTable(sqlBS);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][1].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void checkBN()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        string tenBN = Request.QueryString["tenbenhnhan"];
        string swhere = "";
        if (tenBN != null && tenBN != "")
        {
            swhere += " and (tenbenhnhan like N'" + tenBN + "' or NameNotSign like N'" + StaticData.s_GetNameNotSign(tenBN) + "')";
        }

        string ngaysinh = Request.QueryString["ngaysinh"];
        if (ngaysinh != null && ngaysinh != "")
        {
            swhere += "  and ngaysinh='" + ngaysinh + "'";
        }
        if (idbenhnhan != null && idbenhnhan != "")
            swhere += " AND IDBENHNHAN<>" + idbenhnhan;

        string sqlCheck = @"SELECT TOP 5 STT=ROW_NUMBER() OVER (ORDER BY T.IDBENHNHAN) ,T.IDBENHNHAN,
                                     T.TENBENHNHAN,T.MABENHNHAN,T.DIACHI,T.NGAYSINH,T.NGAYTIEPNHAN
                                    ,A.TenLoai,TenLoaiBN = B.TenLoai
                            FROM BENHNHAN T
                                  LEFT JOIN KB_LoaiUutien  A on T.idloaiuutien=A.Id
                                  LEFT JOIN KB_LoaiBN  B on T.loai=B.Id
                            WHERE 1=1 " + swhere;
        sqlCheck += " order by ngaytiepnhan desc";
        DataTable table = DataAcess.Connect.GetTable(sqlCheck);
        string html = "";
        html += "<table class='jtable' id=\"gridTable\">";
        html += "<tr>";
        html += "<th>Mã bệnh nhân</th>";
        html += "<th>Tên bệnh nhân</th>";
        html += "<th>Loại ưu tiên</th>";
        html += "<th>Địa chỉ</th>";
        html += "<th>Ngày sinh</th>";
        html += "<th>Loại khám</th>";
        html += "<th>Ngày tiếp nhận</th>";
        html += "</tr>";
        if (table != null && table.Rows.Count > 0)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                html += "<tr style='cursor:pointer' onclick=\"setControlFind('" + Codec.EncryptAES(table.Rows[i]["idbenhnhan"].ToString()) + "')\">";
                html += "<td>" + table.Rows[i]["mabenhnhan"].ToString() + "</td>";
                html += "<td>" + table.Rows[i]["tenbenhnhan"].ToString() + "</td>";
                html += "<td>" + table.Rows[i]["TenLoai"].ToString() + "</td>";
                html += "<td>" + table.Rows[i]["diachi"].ToString() + "</td>";
                html += "<td>" + table.Rows[i]["ngaysinh"].ToString() + "</td>";
                html += "<td>" + table.Rows[i]["TenLoaiBN"].ToString() + "</td>";
                if (table.Rows[i]["ngaytiepnhan"].ToString() != "")
                {
                    html += "<td>" + DateTime.Parse(table.Rows[i]["ngaytiepnhan"].ToString()).ToString("dd/MM/yyyy HH:mm") + "</td>";
                }
                else { html += "<td>" + table.Rows[i]["ngaytiepnhan"].ToString() + "</td>"; }
                html += "</tr>";
            }
            html += "</table>";
            Response.Clear(); Response.Write(html);
            return;
        }
        else
        {
            Response.Clear();
            Response.Write("");
            return;
        }
    }
    //_______________________________________________________________________________________________________
    private void TinhTuoiBenhNhan()
    {
        string NgaySinh = Request.QueryString["NgaySinh"];
        if (NgaySinh == "" || NgaySinh.Length < 4)
        {
            Response.Clear();
            Response.Write("");
            return;
        }
        int TuoiBN = 0;
        DateTime Now = DateTime.Now;
        if (NgaySinh.Length == 4)
        {
            TuoiBN = Now.Year - int.Parse(NgaySinh);
            if (TuoiBN == 0) TuoiBN = 1;
            Response.Clear();
            Response.Write(TuoiBN.ToString() + ";0");
            return;
        }
        if (NgaySinh.Length >= "19/07/2012".Length)
        {
            DateTime dNgaySinh = DateTime.Parse(StaticData.CheckDate(NgaySinh));
            TuoiBN = Now.Year - dNgaySinh.Year;
            if (TuoiBN == 0) TuoiBN = 1;
            Response.Clear();
            Response.Write(TuoiBN.ToString() + ";" + "0");
            return;
        }
        return;
    }
    //_______________________________________________________________________________________________________
    private void TinhNamSinh_TheoTuoi()
    {
        string Tuoi = Request.QueryString["Tuoi"];
        if (Tuoi == null || Tuoi == "" || Tuoi == "0")
        {
            Response.Clear();
            Response.Write("-1");
            return;
        }
        DateTime dNgayHienTai = DateTime.Now;
        int n = dNgayHienTai.Year - int.Parse(Tuoi);
        if (n == 0) n = dNgayHienTai.Year;
        Response.Clear();
        Response.Write(n.ToString());
    }
    //_______________________________________________________________________________________________________
    private void TinhNamSinh_TheoThang()
    {
        string Thang = Request.QueryString["Thang"];
        if (Thang == null || Thang == "" || Thang == "0")
        {
            Response.Clear();
            Response.Write("-1");
            return;
        }
        Response.Clear();
        Response.Write(DateTime.Now.Year.ToString());
    }
    //_______________________________________________________________________________________________________
    private void idkhoasearch()
    {
        string idphongkhambenh = Userlogin_new.IdChiNhanh(this);
        string sqlSelect = @"
                     DECLARE @COSO_KCB AS NVARCHAR(400)
                     SELECT TOP 1 @COSO_KCB=COSO_KCB FROM PHONGKHAMBENH WHERE IDPHONGKHAMBENH=" + idphongkhambenh + @"
                     SELECT * FROM PHONGKHAMBENH WHERE COSO_KCB=@COSO_KCB AND ISNULL(isactive,1)=1 AND ISNULL(ISNOITRU,0)=0
                     ORDER BY ISNULL(ISNOITRU,0),TenPhongKhamBenh
            ";
        DataTable table = DataAcess.Connect.GetTable(sqlSelect);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i]["TenPhongKhamBenh"].ToString() + "|" + table.Rows[i]["IDPHONGKHAMBENH"].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void idkhoa_noitru_search()
    {
        DataTable table = StaticData.dtKhoa(this);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i]["TenPhongKhamBenh"].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void getTileBHYT()
    {
        string istraituyen = Request.QueryString["istraituyen"];
        string iscapcuu = Request.QueryString["iscapcuu"];
        string ngaydangky = Request.QueryString["ngaydangky"];
        if (ngaydangky == null || ngaydangky == "")
            ngaydangky = DateTime.Now.ToString("yyyy-MM-dd");
        else ngaydangky = StaticData.CheckDate(ngaydangky);
        string sobh1 = Request.QueryString["bh1"];
        string sobh2 = Request.QueryString["bh2"];

        if (sobh1 != null && sobh2 != null && istraituyen != null)
        {
            string sqlSelect = @"SELECT MUCHUONG=DBO.hs_Get_Muc_Huong(NULL,'" + ngaydangky + "','" + (!StaticData.IsCheck(istraituyen) ? "Y" : "N") + "','" + sobh1 + "','" + sobh2 + "'," + (StaticData.IsCheck(iscapcuu) ? "1" : "0") + ")";
            DataTable dtMucHuong = DataAcess.Connect.GetTable(sqlSelect);
            string value = "";
            if (dtMucHuong != null && dtMucHuong.Rows.Count > 0)
                value = dtMucHuong.Rows[0][0].ToString() + ";" + dtMucHuong.Rows[0][0].ToString();
            Response.Write(value);
        }
    }
    //_______________________________________________________________________________________________________
    public void tinhidSearch()
    {
        string sql1 = @"select tinhid,case when matinh IS NULL  OR matinh='' then tinhname else
                isnull(matinh,'')+'_'+tinhname end as tinhname from tinh where 1=1 ";

        string matinh = Request.QueryString["q"].Split('_')[0];
        if (matinh != null && matinh != "")
        {
            sql1 += " and ( tinhid like N'%" + matinh + "%' OR  matinh like N'%" + matinh + "%' OR TINHNAME LIKE N'%" + Request.QueryString["q"] + "%')";
        }
        sql1 += "order by matinh+'_'+tinhname ";
        DataTable table = DataAcess.Connect.GetTable(sql1);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][1].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________

    public void quanhuyenidSearch()
    {
        string sql1 = "select * from quanhuyen where tinhid='" + Request.QueryString["tinhid"] + "'";
        sql1 += " AND (MAQUANHUYEN LIKE N'%" + Request.QueryString["q"] + "%' OR QUANHUYENNAME LIKE N'%" + Request.QueryString["q"] + "%')";
        DataTable table = DataAcess.Connect.GetTable(sql1);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][2].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    public void phuongxaidSearch()
    {
        string sql1 = "select * from phuongxa";
        if (Request.QueryString["quanhuyenid"] != null && Request.QueryString["quanhuyenid"] != "")
        {
            sql1 += " where quanhuyenid='" + Request.QueryString["quanhuyenid"] + "'";
        }
        sql1 += " AND (maphuongxa LIKE N'%" + Request.QueryString["q"] + "%' OR tenphuongxa LIKE N'%" + Request.QueryString["q"] + "%')";
        DataTable table = DataAcess.Connect.GetTable(sql1);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][2].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void ktramabh()
    {
        string SQL_SELECT = string.Format(@"SELECT DUNGTUYEN FROM KB_NOIDANGKYKB WHERE IDNOIDANGKY={0}", Request.QueryString["IDNOIDANGKY"]);
        DataTable table = DataAcess.Connect.GetTable(SQL_SELECT);
        string html = "";
        if (table.Rows.Count > 0)
        {
            html += table.Rows[0][0].ToString();
        }
        Response.Clear();
        Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void idloaiuutienSearch()
    {
        DataTable table = DataAcess.Connect.GetTable("select * from kb_loaiuutien");
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][1].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loadSTT()
    {
        string ngay = "";
        if (Request.QueryString["ngaydk"].ToString() == "") ngay = DateTime.Now.ToString("dd/MM/yyyy");
        else
            ngay = Request.QueryString["ngaydk"].ToString();
        string NgayDKK = StaticData.CheckDate(ngay);
        DateTime dNgayDKK = DateTime.Parse(NgayDKK);
        string PhongId = Request.QueryString["idphongkhambenh"];
        string stt = "1";// StaticData_HS.GetSoThuTuDangKyKhamMoi(PhongId, NgayDKK, false);
        string slbncho = "";
        string slbnkham = "";
        Response.Clear();
        Response.Write(stt + "@" + slbncho + "@" + slbnkham);
    }
    //_______________________________________________________________________________________________________
    private void idphongkhambenhSearch()
    {
        string idkhoa = Request.QueryString["idkhoa"];
        DataTable table = null;
        if (idkhoa != null && idkhoa != "")
        {
            table = StaticData.dtPhong_NgoaiTru_ByKhoa(idkhoa, this);

        }
        else
        {
            table = StaticData.dtPhong_NgoaiTru_ByKhoa("1", this);
        }

        string html = "";

        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string s = table.Rows[i]["TenPhongFull"].ToString();
                    html += s + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void idphongkhambenhSearch2()
    {
        string idkhoa = Request.QueryString["idkhoa"];
        string idloaikham = Request.QueryString["idloaikham"];
        DataTable table = null;
        if (idkhoa != null && idkhoa != "")
        {
            table = StaticData.dtPhong_NgoaiTru_ByKhoa_LoaiKham(idkhoa, idloaikham, this);

        }
        else
        {
            table = StaticData.dtPhong_NgoaiTru_ByKhoa_LoaiKham("1", idloaikham, this);
        }

        string html = "";

        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string s = table.Rows[i]["TenPhongFull"].ToString();
                    html += s + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void idChuyenKhoaSearch()
    {
        string sql = "";
        if (Request.QueryString["ngaydk"].ToString() == "") sql = DateTime.Now.ToString("dd/MM/yyyy");
        else
            sql = Request.QueryString["ngaydk"].ToString();
        string NgayDKK = StaticData.CheckDate(sql);
        DateTime dNgayDKK = DateTime.Parse(NgayDKK);
        string PhongId = Request.QueryString["phongid"].ToString();
        string sqlChuyenKhoa = "select IdBangGiaDichVu,TenDichVu from BangGiaDichVu A left join phongkhambenh B On A.IdPHongKhamBenh=B.IdPhongKhamBenh where loaiphong=0 ";
        DataTable dtAllChuyenKhoa = DataAcess.Connect.GetTable(sqlChuyenKhoa);

        if (PhongId != null && PhongId != "" && PhongId != "0")
        {
            sqlChuyenKhoa = @"select IdBangGiaDichVu
		                            ,TenDichVu
                             from BangGiaDichVu A
                                  left join phongkhambenh B On A.IdPHongKhamBenh=B.IdPhongKhamBenh
                             where loaiphong=0 
			                        and idbanggiadichvu in (    select IdChuyenKhoa 
									                            from KB_PhanCaBacSi 
									                            where phongid=" + PhongId + @" 
											                            and year(ngaykham)=" + dNgayDKK.Year.ToString() + @"
											                            and month(ngaykham)=" + dNgayDKK.Month.ToString() + @"
											                            and day(ngaykham)=" + dNgayDKK.Day.ToString() + @"
								                               )";
        }
        DataTable dtbChuyenKhoa = DataAcess.Connect.GetTable(sqlChuyenKhoa);
        if (dtbChuyenKhoa == null || dtbChuyenKhoa.Rows.Count == 0) dtbChuyenKhoa = dtAllChuyenKhoa;
        string html = "";
        if (dtbChuyenKhoa != null)
        {
            if (dtbChuyenKhoa.Rows.Count > 0)
            {
                for (int i = 0; i < dtbChuyenKhoa.Rows.Count; i++)
                {

                    html += dtbChuyenKhoa.Rows[i][1].ToString() + "|" + dtbChuyenKhoa.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void loaiSearch()
    {
        DataTable table = DataAcess.Connect.GetTable("select * from kb_loaibn where STATUS=1 AND ISNULL(ISKHAMSUCKHOE,0)=0   order by TTUT");
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][1].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void IdCapBacSearch()
    {
        DataTable table = DataAcess.Connect.GetTable("select IdCapBac,TenCapBac from CapBacQuanNhan where IsNull(status,1)=1");
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html += table.Rows[i][1].ToString() + "|" + table.Rows[i][0].ToString() + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void Xoabenhnhan()
    {
        try
        {
            DataProcess process = s_benhnhan();
            #region Check Key Off BV
            string idbenhnhan = process.getData("idbenhnhan");
            if (idbenhnhan.Length > 20) idbenhnhan = Codec.DecryptAES(idbenhnhan);
            string sqlCheckHS = "select top 1 ID from HS_BENHNHANBHDONGTIEN where idbenhnhan=" + idbenhnhan + @" and isbhyt=1 and ischeck_all=1";
            DataTable dtHS = DataAcess.Connect.GetTable(sqlCheckHS);
            if (dtHS != null && dtHS.Rows.Count > 0)
            {
                Response.Write("Tồn tại hồ sơ đã kết xuất XML BHYT nên không thể xóa bệnh nhân này được");
                Response.StatusCode = 502;
                return;
            }
            #endregion
            bool ok = process.Delete();
            if (ok)
            {
                Response.Clear(); Response.Write(process.getData("idbenhnhan"));
                return;
            }
        }
        catch
        {
        }
        Response.StatusCode = 502;
    }
    //_______________________________________________________________________________________________________
    private System.Text.StringBuilder dtHistory(string IdBenhNhan)
    {
        string sqlDangKyKham = @"SELECT DISTINCT
                    DK.IDDANGKYKHAM
                    ,DK.NGAYDANGKY
                    ,TinhTrang=( CASE WHEN KB.IDKHAMBENH IS NULL THEN N'Chờ khám' ELSE  (CASE WHEN KB.IsChoVeKT =1 THEN N'Cho về KT' ELSE (CASE WHEN KB.IsChuyenVien=1 THEN N'Chuyển viện'
                            ELSE (  
                                    CASE WHEN KB.ISHAVETHUOC=1 OR KB.ISHAVETHUOCBH=1 THEN N'Cho toa thuốc' ELSE (CASE WHEN KB.IsHaveCLS=1 THEN N'Chờ kết luận' ELSE N'Khác' END ) END
                                ) 
                        END) END)
                        END)
                    ,KHOAPHONG=KHOA.TENPHONGKHAMBENH +'('+PHONG.TENPHONG+')'
                    ,strNGAYDANGKY=CONVERT(VARCHAR(10),DK.NGAYDANGKY,103)+' '+CONVERT(VARCHAR(8),DK.NGAYDANGKY,108)
                    ,LOAIKHAM=LBN.TENLOAI
                    ,strNGAYXUATVIEN=''
                    ,DK.IDCHINHANH
                    ,kb.IsKhamSucKhoe
                    ,kb.idkhambenh
                    ,DK.IDBENHBHDONGTIEN
                    ,ngaydangky103=convert(varchar,dk.ngaydangky,103)
                    ,idphong=ct.phongid
                    ,NgayTinhBH_Thuc=convert(varchar,hs.NgayTinhBH_Thuc,103)
                    ,hs.ISCHECK_ALL
                    ,DK.LoaiKhamID
                    ,DK.lich_hen_kham_benh_id
            FROM DANGKYKHAM DK
            INNER JOIN KB_LOAIBN LBN ON LBN.ID= DK.LOAIKHAMID
            LEFT JOIN HS_BenhNhanBHDongTien HS ON DK.IdBenhBHDongTien=HS.ID
            left join khambenh kb on kb.IDKHAMBENH=HS.IDKHAMBENH_LAST
            left join chitietdangkykham CT ON DK.IDDANGKYKHAM=CT.IDDANGKYKHAM
            LEFT JOIN PHONGKHAMBENH KHOA ON KHOA.IDPHONGKHAMBENH=CT.idkhoa
            LEFT JOIN KB_PHONG PHONG ON PHONG.ID=CT.phongid
        WHERE ISNULL(LBN.ISKHAMSUCKHOE,0)=0 AND   ISNULL( DK.dahuy ,0)=0 
                AND DK.IDBENHNHAN='" + IdBenhNhan + "' order by dk.ngaydangky";

        DataTable dtDKK = DataAcess.Connect.GetTable(sqlDangKyKham);
        string sqlKhamBenh = @"select idkhambenh
                                    ,kb.iddangkykham
                                    ,khoa=case when p.idphongkhambenh<>1 then P.tenphongkhambenh else DBO.HS_TenPhong(kb.PhongID) end
                                    ,ngaykham=CONVERT(VARCHAR(10),kb.ngaykham,103)+' '+CONVERT(VARCHAR(8),kb.ngaykham,108)
                                    ,HuongDieuTri=( CASE WHEN  KB.ISKHONGKHAM=1 THEN N'Không khám' ELSE   ( case when p2.tenphongkhambenh is not null  
				                        then N'Chuyển '
						                        + ( CASE WHEN KB.HUONGDIEUTRI=1 THEN N'KTP :' ELSE ': ' END )
						                        + ( CASE WHEN p2.idphongkhambenh = p.idphongkhambenh THEN ISNULL(' -'+ DBO.HS_TENPHONG(KB.IDCHUYENPK),'') ELSE P2.TENPHONGKHAMBENH END)  
				                        else hdt.tenhuongdieutri end) END)
			                        ,bs.TenBacSi
                                    ,TenBenh=kb.MoTaCD_edit
                                     ,ngayhentaikham=KB.ngayhentaikham
                                     ,SONGAY=CONVERT(INT, CONVERT(DATETIME, CONVERT(NVARCHAR(20), NGAYHENTAIKHAM,111))- CONVERT(DATETIME, CONVERT(NVARCHAR(20),  GETDATE(),111))   )
                                    ,kb.IsKhamSucKhoe
        from khambenh kb 
            left join phongkhambenh p on p.idphongkhambenh =kb.idphongkhambenh
            left join bacsi bs on bs.idbacsi =kb.idbacsi
            left join kb_huongdieutri hdt on hdt.HuongDieuTriId =kb.huongdieutri
			left join phongkhambenh p2 on p2.idphongkhambenh =isnull(kb.idkhoachuyen,phongkhamchuyenden)
        where kb.idbenhnhan ='" + IdBenhNhan + @"'
                ORDER BY IDDANGKYKHAM,NGAYKHAM";
        DataTable dtKhamBenh = DataAcess.Connect.GetTable(sqlKhamBenh);
        DataView dv = new DataView(dtKhamBenh);

        DataProcess pro = new DataProcess("benhnhan");
        pro.Page = Request.QueryString["page"];
        System.Text.StringBuilder html = new System.Text.StringBuilder();
        html.Append("<table class='jtable' id='TableDKKFather'>");
        html.Append("<tr>");
        html.Append("<th style='padding: 0px 0px 0px 10px;'>Lần ĐK</th>");
        html.Append("<th>Ngày đăng ký</th>");
        html.Append("<th>Khoa/Phòng</th>");
        html.Append("<th>Trình trạng</th>");
        html.Append("<th>Loại khám</th>");
        html.Append("<th></th>");
        html.Append("<th></th>");
        html.Append("<th></th>");
        if (StaticData.IsActive_MobileApp == "1")
            html.Append("<th></th>");
        else
            html.Append("<th></th>");

        html.Append("<th>QR đặt lịch</th>");

        html.Append("</tr>");
        if (dtDKK != null && dtDKK.Rows.Count > 0)//&& dtKhamBenh != null && dtKhamBenh.Rows.Count > 0)
        {

            for (int i = dtDKK.Rows.Count - 1; i >= 0; i--)
            {
                string IdDangKyKham = dtDKK.Rows[i]["IdDangKyKham"].ToString();
                string qr_dat_lich = "";
                string lich_hen_kham_benh_id = dtDKK.Rows[i]["lich_hen_kham_benh_id"].ToString();
                if (lich_hen_kham_benh_id != "")
                {
                    DataTable dtDatLich = DataAces_Postgre.Connect.GetTable("select ma_phieu_kham from lich_hen_kham_benh  where id='"+lich_hen_kham_benh_id+"'");
                    if (dtDatLich != null && dtDatLich.Rows.Count > 0)
                    {
                        qr_dat_lich = dtDatLich.Rows[0]["ma_phieu_kham"].ToString();
                    }
                }
                bool isShow = false;
                if (i == dtDKK.Rows.Count - 1)
                    isShow = true;
                dv.RowFilter = "IDDANGKYKHAM=" + IdDangKyKham;
                html.Append("<tr>");
                html.Append("<td  style='padding: 0px 0px 0px 10px;text-align: left;'>" + (i < 9 ? "0" : "") + (i + 1) + (dv.Count > 0 ? "<a onclick=\"displayChildTable(this,'childTable" + i + "');\" style='font-size: 17px;font-weight: bold;color: Blue;padding-left:15px;'>" + (isShow ? "-" : "+") + "</a>" : "") + "</td>");
                html.Append("<td style='text-align: left;'>" + dtDKK.Rows[i]["strNGAYDANGKY"].ToString() + "</td>");
                html.Append("<td style='text-align: left;'>" + dtDKK.Rows[i]["KHOAPHONG"].ToString() + "</td>");
                html.Append(@"<td style='text-align: left;'>
                                    <input type='hidden' id='NgayTinhBH_Thuc' value='" + dtDKK.Rows[i]["NgayTinhBH_Thuc"].ToString() + @"' />
                                    <input type='hidden' id='ISCHECK_ALL' value='" + (StaticData.IsCheck(dtDKK.Rows[i]["ISCHECK_ALL"].ToString()) ? "1" : "0") + @"' />
                                    <input type='hidden' id='ngaydangky103' value='" + dtDKK.Rows[i]["ngaydangky103"].ToString() + @"' />
                                    <input type='hidden' id='idphong' value='" + dtDKK.Rows[i]["idphong"].ToString() + @"' />  
                                    <input type='hidden' id='LoaiKhamID' value='" + dtDKK.Rows[i]["LoaiKhamID"].ToString() + @"' />  
                                   " + dtDKK.Rows[i]["TinhTrang"].ToString()
                              + "</td>");
                html.Append("<td style='text-align: left;'>" + dtDKK.Rows[i]["LOAIKHAM"].ToString() + "</td>");
                html.Append("<td><a onclick=\"setDangkykham('" + dtDKK.Rows[i]["iddangkykham"].ToString() + "','" + (dtDKK.Rows[i]["ngaydangky"].ToString() != "" ? DateTime.Parse(dtDKK.Rows[i]["ngaydangky"].ToString()).ToString("dd/MM/yyyy HH:mm:ss") : "") + "','" + dtDKK.Rows[i]["IDCHINHANH"].ToString() + "')\">Chi tiết</a></td>");
                html.Append("<td><a onclick=\"window.open('../VIENPHI_BH/frm_rpt_chiphikhambenh.aspx?idphieutt=" + Codec.EncryptAES(dtDKK.Rows[i]["IDBENHBHDONGTIEN"].ToString()) + "')\">In BV</a></td>");
                html.Append("<td><a onclick=\"window.open('../SieuAm/TienSu_theo_dkk.aspx?iddangkykham=" + Codec.EncryptAES(dtDKK.Rows[i]["iddangkykham"].ToString()) + "&dkmenu=iVjMo4//vFZqvjRdk1ZNoA==')\">Tiền sử</a></td>");
                if (StaticData.IsActive_MobileApp == "1")
                    html.Append("<td><a onclick=\"SendMessage_Just_DangKyKhamBenh('" + Codec.EncryptAES(dtDKK.Rows[i]["iddangkykham"].ToString()) + "')\">" + (DateTime.Parse(dtDKK.Rows[i]["ngaydangky"].ToString()).ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy") ? "Thông báo" : "") + "</a></td>");
                else
                    html.Append("<td>Not Active</td>");
                html.Append("<td>"+qr_dat_lich+"</td>");

                html.Append("</tr>");

                if (dv != null && dv.Count > 0)
                {
                    html.Append("<tr id='childTable" + i + "' " + (isShow ? "" : "style='display:none;'") + " >");
                    html.Append("<td></td>");
                    html.Append("<td colspan='5'>");
                    html.Append("<table class='jtable' >");
                    for (int j = 0; j < dv.Count; j++)
                    {
                        html.Append("<tr " + (j == 0 ? "style='border-top: 2px solid blue;'" : "") + ">");
                        html.Append("<td style='text-align: left;'>" + dv[j]["khoa"].ToString() + "</td>");
                        html.Append("<td style='text-align: left;'>" + dv[j]["NgayKham"].ToString() + "</td>");
                        html.Append("<td style='text-align: left;'>" + dv[j]["HuongDieuTri"].ToString() + "</td>");
                        html.Append("<td style='text-align: left;'>" + dv[j]["TenBacSi"].ToString() + "</td>");
                        html.Append("<td style='text-align: left;'>" + dv[j]["TenBenh"].ToString() + "</td>");
                        html.Append("<td style='text-align: left;'>" + (dv[j]["ngayhentaikham"].ToString() != "" ? (Convert.ToInt32(dv[j]["SONGAY"].ToString()) > -7 ? ("Ngày hẹn tái khám: " + DateTime.Parse(dv[j]["ngayhentaikham"].ToString()).ToString("dd/MM/yyyy") + "( Còn " + dv[j]["SONGAY"].ToString() + " ngày)") : "") : "") + "</td>");
                        html.Append("<td style='text-align: left;'>" + "<a style='color:red;font-weight:bold' onclick=\"PrintPhieuChiDinh('" + dv[j]["idkhambenh"].ToString() + "')\">In phiếu CĐ </a>" + "</td>");
                        html.Append("<td style='text-align: left;'>" + "<a style='color:red;font-weight:bold' onclick=\"window.open('../KhamBenh_TH/KhamBenh.aspx#idkhoachinh=" + Codec.EncryptAES(dv[j]["idkhambenh"].ToString()) + "')\">Phiếu khám </a>" + "</td>");
                        html.Append("</tr>");
                    }
                    html.Append("</table>");
                    html.Append("</td>");
                    html.Append("</tr>");
                }
            }
        }
        html.Append("</table>");
        html.Append(pro.Paging("Dangkykham"));
        html.Append("<input type='hidden' id='da_dangky' value='" + (dtDKK.Rows.Count > 0 ? "1" : "0") + "' />");



        return html;
    }
    //_______________________________________________________________________________________________________
    private void loadDSDangkykham()
    {
        string IdBenhNhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        string MaBenhNhan = Request.QueryString["mabenhnhan"];
        Response.Clear();
        Response.Write(dtHistory(IdBenhNhan));
    }
    //_______________________________________________________________________________________________________
    private void setTimKiem()
    {
        string idkhoachinh = Codec.DecryptAES(Request.QueryString["idkhoachinh"].ToString());
        string sqlSelect = @"SELECT top 1
                         SoTuoi=DBO.KB_Tuoi(C.NGAYSINH)
                        ,C.*
                        ,thoigian=convert(char(8),c.ngaytiepnhan,114)
                        ,mkv_maquoctich=QT.MAQUOCTICH
                        ,mkv_tenquoctich=QT.TENQUOCTICH
                        ,mkv_madantoc=DT.MADANTOC
                        ,mkv_tendantoc=DT.TENDANTOC
                        ,mkv_manghenghiep=NN.MANGHENGHIEP
                        ,mkv_tennghenghiep=NN.TENNGHENGHIEP
                        ,mkv_tinhid=tinh.matinh + '_' + tinh.tinhname
                        ,mkv_quanhuyenid=qh.quanhuyenname
                        ,mkv_phuongxaid=px.tenphuongxa
                        ,mkv_idcongty= cty.tencty
                        ,SH.idsinhhieu
                        ,SH.mach
                        ,SH.nhietdo
                        ,SH.huyetap1
                        ,SH.huyetap2
                        ,SH.chieucao
                        ,SH.cannang
                        ,SH.BMI
                        ,SH.glucose
                        ,SH.DangDieuTriTimMach
                        
                        from BENHNHAN C 
                        LEFT JOIN QUOCTICH QT ON C.QUOCTICH=QT.IDQUOCTICH
                        LEFT JOIN DANTOC DT ON C.DANTOC=DT.ID
                        LEFT JOIN NGHENGHIEP NN ON C.NGHENGHIEP=NN.IDNGHENGHIEP
                        LEFT JOIN tinh ON c.tinhid=tinh.tinhID
                        LEFT JOIN quanhuyen qh ON C.quanhuyenid=qh.quanhuyenid
                        LEFT JOIN phuongxa px ON C.phuongxaid=px.phuongxaid
                        LEFT JOIN KB_CongTy cty ON cty.idcongty=C.idcongty
                        LEFT JOIN SINHHIEU SH ON SH.IDSINHHIEU=(SELECT TOP 1 IDSINHHIEU FROM SINHHIEU WHERE IDBENHNHAN=C.IDBENHNHAN ORDER BY NGAYDO DESC)
                        WHERE 
                        C.idbenhnhan = '" + idkhoachinh + "'";

        DataTable table = DataAcess.Connect.GetTable(sqlSelect);
        string html = "";
        html += "<root>";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                if (table.Rows[0]["chungminhthu"].ToString() == "" && table.Rows[0]["CMND"].ToString() != "")
                    table.Rows[0]["chungminhthu"] = table.Rows[0]["CMND"].ToString();




                string[] thoigian = table.Rows[0]["thoigian"].ToString().Split(':');
                html += "<data id=\"gio\">" + thoigian[0].ToString() + "</data>";
                html += "<data id=\"phut\">" + thoigian[1].ToString() + "</data>";
                html += "<data id=\"idkhoachinh\">" + Codec.EncryptAES(idkhoachinh) + "</data>";
                DataTable loai = DataAcess.Connect.GetTable("SELECT * FROM  KB_LoaiBN WHERE  Id='" + table.Rows[0]["loai"] + "'");
                html += "<data id=\"mkv_loai\">" + ((loai.Rows.Count > 0) ? loai.Rows[0][1] : "") + "</data>";
                html += "<data id=\"ngaydangky\">" + string.Format("{0:dd/MM/yyyy}", DateTime.Now) + "</data>";
                string havead = StaticData.GetParaValueDB("HaveActiveDirectory");
                html += "<data id=\"havead\">" + havead + "</data>";


                html += Environment.NewLine;
                for (int y = 0; y < table.Columns.Count; y++)
                {
                    try
                    {
                        if (table.Columns[y].DataType == DateTime.Now.GetType())
                            html += "<data id='" + table.Columns[y].ToString() + "'>" + DateTime.Parse(table.Rows[0][y].ToString()).ToString("dd/MM/yyyy") + "</data>";
                        else
                        {
                            if (table.Columns[y].ColumnName.ToLower() != "loai")
                                html += "<data id='" + table.Columns[y].ToString() + "'>" + HttpUtility.HtmlEncode(table.Rows[0][y].ToString()) + "</data>";

                        }
                    }
                    catch (Exception)
                    {
                        html += "<data id='" + table.Columns[y].ToString() + "'>" + table.Rows[0][y].ToString() + "</data>";
                    }
                    html += Environment.NewLine;
                }

            }
        }
        html += "</root>";
        Response.Clear();
        Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private string FixValue(object RequestValue)
    {
        if (RequestValue == null || RequestValue.ToString() == "" || RequestValue == "" || RequestValue == "null")
            return "";
        return RequestValue.ToString().Trim();
    }
    //_______________________________________________________________________________________________________
    private void TimKiem()
    {
        //  if (IsHack) return;
        DataProcess process = s_benhnhan();
        string swhere = "";
        string mabenhnhan = Request.QueryString["mabenhnhan"];
        if (mabenhnhan != null && mabenhnhan != "")
        {
            swhere += "  AND	REPLACE( REPLACE( mabenhnhan,'-',''),'BN','') =REPLACE( REPLACE( '" + mabenhnhan.Trim() + @"','-',''),'BN','') ";
        }
        string tenbenhnhan = Request.QueryString["tenbenhnhan"];
        if (tenbenhnhan != null && tenbenhnhan != "")
        {
            swhere += " and (T.tenbenhnhan like N'%" + tenbenhnhan + "%' or T.NAMENOTSIGN like N'%" + StaticData.s_GetNameNotSign(tenbenhnhan) + "%')";
        }
        string sodt = Request.QueryString["dienthoai"];
        if (sodt != null && sodt != "")
        {
            swhere += " AND t.dienthoai like'%" + sodt + "%'";
        }
        string sobhyt = Request.QueryString["sobh1"] + Request.QueryString["sobh2"] + Request.QueryString["sobh3"] + FixValue(Request.QueryString["sobh7"]);
        if (sobhyt != null && sobhyt != "")
        {
            swhere += " AND t.sobhyt='" + sobhyt + "'";
        }
        process.Page = Request.QueryString["page"];
        string sqlSelect = @"select top 20 STT=ROW_NUMBER() OVER (ORDER BY T.IDBENHNHAN) , T.*" + "\r\n"
                  + " ,A.TenLoai " + "\r\n"
                  + " ,TenLoaiBN = B.TenLoai" + "\r\n"
                    + "           from benhnhan T" + "\r\n"
                    + "left join KB_LoaiUutien  A on T.idloaiuutien=A.Id" + "\r\n"
                    + "left join KB_LoaiBN  B on T.loai=B.Id" + "\r\n"
                    + "where 1=1 " + swhere;
        sqlSelect += " order by ngaytiepnhan desc";
        DataTable table = DataAcess.Connect.GetTable(sqlSelect);
        string html = "";
        html += "<table class='jtable' id=\"gridTable\">";
        html += "<tr>";
        html += "<th>Mã bệnh nhân</th>";
        html += "<th>Tên bệnh nhân</th>";
        html += "<th>Loại ưu tiên</th>";
        html += "<th>Địa chỉ</th>";
        html += "<th>Ngày sinh</th>";
        html += "<th>Loại khám</th>";
        html += "<th>Ngày tiếp nhận</th>";
        html += "</tr>";
        if (table != null && table.Rows.Count > 0)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                html += "<tr style='cursor:pointer' onclick=\"setControlFind('" + Codec.EncryptAES(table.Rows[i]["idbenhnhan"].ToString()) + "')\">";
                html += "<td>" + table.Rows[i]["mabenhnhan"].ToString() + "</td>";
                html += "<td style='text-align:left;'>" + table.Rows[i]["tenbenhnhan"].ToString() + "</td>";
                html += "<td>" + table.Rows[i]["TenLoai"].ToString() + "</td>";
                html += "<td style='text-align:left;'>" + table.Rows[i]["diachi"].ToString() + "</td>";
                html += "<td>" + table.Rows[i]["ngaysinh"].ToString() + "</td>";
                html += "<td>" + table.Rows[i]["TenLoaiBN"].ToString() + "</td>";
                if (table.Rows[i]["ngaytiepnhan"].ToString() != "")
                {
                    html += "<td>" + DateTime.Parse(table.Rows[i]["ngaytiepnhan"].ToString()).ToString("dd/MM/yyyy HH:mm") + "</td>";
                }
                else { html += "<td>" + table.Rows[i]["ngaytiepnhan"].ToString() + "</td>"; }
                html += "</tr>";
            }
            html += "</table>";
            html += process.Paging();
            Response.Clear(); Response.Write(html);
            return;
        }
        else
        {
            Response.StatusCode = 502;
        }

    }
    //_______________________________________________________________________________________________________
    private void Savebenhnhan()
    {
        try
        {
            DataProcess process = s_benhnhan();
            string IsCapNhatDKK = Request.QueryString["IsCapNhatDKK"];
            #region Check Key Off BV
            if (process.getData("idbenhnhan") != null && process.getData("idbenhnhan") != "")
            {
                string idbenhnhan_check = process.getData("idbenhnhan");
                if (idbenhnhan_check.Length > 20) idbenhnhan_check = Codec.DecryptAES(idbenhnhan_check);
                string sqlCheckHS = "select sl=count(ID) from HS_BENHNHANBHDONGTIEN where idbenhnhan=" + idbenhnhan_check + @" and isbhyt=1 and ischeck_all=1";
                DataTable dtHS = DataAcess.Connect.GetTable(sqlCheckHS);
                if (dtHS != null && dtHS.Rows.Count > 0 && dtHS.Rows[0]["sl"].ToString() != "0")
                {
                    #region Check thông tin hành chính bệnh nhân
                    string sqlCheckBN = "SELECT  mabenhnhan,tenbenhnhan,gioitinh FROM BENHNHAN WHERE IDBENHNHAN=" + idbenhnhan_check;
                    DataTable dtOldInfor = DataAcess.Connect.GetTable(sqlCheckBN);
                    for (int i = 0; i < dtOldInfor.Columns.Count; i++)
                    {
                        bool Equar = true;
                        if (dtOldInfor.Columns[i].DataType.ToString().IndexOf("Boolean") != -1)
                        {
                            if (StaticData.IsCheck(dtOldInfor.Rows[0][dtOldInfor.Columns[i].ColumnName].ToString()) != StaticData.IsCheck(Request.QueryString[dtOldInfor.Columns[i].ColumnName]))
                                Equar = false;
                        }
                        else
                            if (Request.QueryString[dtOldInfor.Columns[i].ColumnName] != null && dtOldInfor.Rows[0][dtOldInfor.Columns[i].ColumnName].ToString().ToLower() != Request.QueryString[dtOldInfor.Columns[i].ColumnName].ToLower())
                            {
                                Equar = false;
                            }
                        if (Equar == false)
                        {
                            Response.Clear();
                            Response.Write("Không thể thay đổi thông tin hành chính : mã, tên, tuổi, giới, ngày sinh, địa chỉ (column name:" + dtOldInfor.Columns[i].ColumnName + ") vì đã tồn tại  " + dtHS.Rows[0]["sl"].ToString() + " hồ sơ đã khóa");
                            Response.StatusCode = 502;
                            return;
                        }
                    }
                    #endregion
                    #region Kiếm tra thông tin thẻ
                    string IDBENHNHAN_BH_check = Request.QueryString["IDBENHNHAN_BH"];
                    if (IDBENHNHAN_BH_check != null && IDBENHNHAN_BH_check != "" && IDBENHNHAN_BH_check != null)
                    {
                        string sqlCheckHS2 = "select sl=count(ID) from HS_BENHNHANBHDONGTIEN where idbenhnhan=" + idbenhnhan_check + @" and isbhyt=1 and ischeck_all=1 AND IDBENHNHAN_BH=" + IDBENHNHAN_BH_check;
                        DataTable dtHS2 = DataAcess.Connect.GetTable(sqlCheckHS2);
                        if (dtHS2 != null && dtHS2.Rows.Count > 0 && dtHS2.Rows[0]["sl"].ToString() != "0")
                        {
                            string sqlCheckBN2 = @"
                                                    SELECT  sobh1,sobh2,sobh3,sobh7,ngaybatdau=CONVERT(VARCHAR,NGAYBATDAU,103),ngayhethan=CONVERT(VARCHAR,NGAYHETHAN,103)
                                                    ,mvk_MADANGKY=b.MADANGKY,dungtuyen=A.IsDungTuyen 
                                                     FROM BENHNHAN_BHYT a
                                                     LEFT JOIN KB_NOIDANGKYKB B ON A.IDNOIDANGKYBH=B.IDNOIDANGKY
                                                     WHERE   A.IDBENHNHAN=" + idbenhnhan_check + " AND A.IDBENHNHAN_BH=" + IDBENHNHAN_BH_check;
                            DataTable dtOldInfor2 = DataAcess.Connect.GetTable(sqlCheckBN2);
                            for (int i = 0; i < dtOldInfor2.Columns.Count; i++)
                            {
                                bool Equar = true;
                                if (dtOldInfor2.Columns[i].DataType.ToString().IndexOf("Boolean") != -1)
                                {
                                    if (StaticData.IsCheck(dtOldInfor2.Rows[0][dtOldInfor2.Columns[i].ColumnName].ToString()) != StaticData.IsCheck(Request.QueryString[dtOldInfor2.Columns[i].ColumnName]))
                                        Equar = false;
                                }
                                else
                                    if (Request.QueryString[dtOldInfor2.Columns[i].ColumnName] != null && dtOldInfor2.Rows[0][dtOldInfor2.Columns[i].ColumnName].ToString().ToLower() != Request.QueryString[dtOldInfor2.Columns[i].ColumnName].ToLower())
                                    {
                                        Equar = false;
                                    }
                                if (Equar == false)
                                {
                                    Response.Clear();
                                    Response.Write("Không thể thay đổi thông tin của thẻ BHYT(column name:" + dtOldInfor2.Columns[i].ColumnName + ") vì đã tồn tại  " + dtHS2.Rows[0]["sl"].ToString() + " hồ sơ đã khóa");
                                    Response.StatusCode = 502;
                                    return;
                                }
                            }
                        }
                    }
                    #endregion
                    #region Kiểm tra thông tin đăng ký khám
                    if (StaticData.IsCheck(IsCapNhatDKK))
                    {
                        string iddangkykhambn_check = Request.QueryString["iddangkykhambn"];
                        if (iddangkykhambn_check != null && iddangkykhambn_check != "" && iddangkykhambn_check != null)
                        {
                            string sqlCheckHS3 = @"select sl=count(ID)
                                        from HS_BENHNHANBHDONGTIEN a
                                        INNER JOIN DANGKYKHAM B ON A.ID=B.IDBENHBHDONGTIEN
                                         where a.idbenhnhan=" + idbenhnhan_check + "  and isbhyt=1 and ischeck_all=1 AND B.IDDANGKYKHAM=" + iddangkykhambn_check;

                            DataTable dtHS3 = DataAcess.Connect.GetTable(sqlCheckHS3);
                            if (dtHS3 != null && dtHS3.Rows.Count > 0 && dtHS3.Rows[0]["sl"].ToString() != "0")
                            {
                                string sqlCheckBN3 = @"
                                                    select  
                                                             IsThongTuyen=B.ThongTuyen,
                                                             IsCapCuu=B.iscapcuudk,
                                                             ngaydangky_edit=CONVERT(VARCHAR, B.ngaydangky,103),
                                                            loai=A.LOAIKHAMID
                                                     from HS_BENHNHANBHDONGTIEN a
                                                    INNER JOIN DANGKYKHAM B ON A.ID=B.IDBENHBHDONGTIEN
                                                    inner join chitietdangkykham C ON B.IDDANGKYKHAM=C.IDDANGKYKHAM
                                                where a.idbenhnhan=" + idbenhnhan_check + @"  and A.isbhyt=1 and A.ischeck_all=1 AND B.IDDANGKYKHAM=" + iddangkykhambn_check;

                                DataTable dtOldInfor3 = DataAcess.Connect.GetTable(sqlCheckBN3);
                                for (int i = 0; i < dtOldInfor3.Columns.Count; i++)
                                {
                                    bool Equar = true;
                                    if (dtOldInfor3.Columns[i].DataType.ToString().IndexOf("Boolean") != -1)
                                    {
                                        if (StaticData.IsCheck(dtOldInfor3.Rows[0][dtOldInfor3.Columns[i].ColumnName].ToString()) != StaticData.IsCheck(Request.QueryString[dtOldInfor3.Columns[i].ColumnName]))
                                            Equar = false;
                                    }
                                    else
                                        if (Request.QueryString[dtOldInfor3.Columns[i].ColumnName] != null && dtOldInfor3.Rows[0][dtOldInfor3.Columns[i].ColumnName].ToString().ToLower() != Request.QueryString[dtOldInfor3.Columns[i].ColumnName].ToLower())
                                        {
                                            Equar = false;
                                        }
                                    if (Equar == false)
                                    {
                                        Response.Clear();
                                        Response.Write("Không thể thay đổi thông tin đăng ký khám như : ngày đăng ký, tình trạng miễn phí khám, là thông tuyến, cấp cứu (column name:" + dtOldInfor3.Columns[i].ColumnName + ") vì đã tồn tại  " + dtHS3.Rows[0]["sl"].ToString() + " hồ sơ đã khóa");
                                        Response.StatusCode = 502;
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    #endregion

                }
            }
            #endregion
            string ngayTN = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            string benhnhan_bhyt = "";
            string Result = "";
            string da_dang_ky = "";
            if (process.getData("mabenhnhan") == null || process.getData("mabenhnhan") == "")
            {
                string SLBN = "0";
                string NewMaBN = NewMaBenhNhan(StaticData.CheckDate(ngayTN), ref SLBN);
                process.data("mabenhnhan", NewMaBN);
                process.data("SLBN", SLBN);
            }
            else
            {
                string Input_MaBN = process.getData("mabenhnhan");
                string sqlCheckMaBN = @"SELECT IDBENHNHAN,TENBENHNHAN,NGAYSINH,DIACHI FROM BENHNHAN WHERE MABENHNHAN='" + Input_MaBN + "'";
                if (process.getData("idbenhnhan") != null && process.getData("idbenhnhan") != "")
                    sqlCheckMaBN += " AND IDBENHNHAN<>" + process.getData("idbenhnhan");
                DataTable dtCheckMaBN = DataAcess.Connect.GetTable(sqlCheckMaBN);
                if (dtCheckMaBN != null && dtCheckMaBN.Rows.Count > 0)
                {
                    Response.Clear();
                    Response.Write("Đã tồn tại bệnh nhân : " + dtCheckMaBN.Rows[0]["TENBENHNHAN"].ToString() + " (" + dtCheckMaBN.Rows[0]["NGAYSINH"].ToString() + "), Địa chỉ : " + dtCheckMaBN.Rows[0]["DIACHI"].ToString() + " ,đã trùng mã " + Input_MaBN + " , vui lòng để trống Mã BN hoặc nhập mã khác");
                    Response.StatusCode = 502;
                    return;
                }
            }
            string email = process.getData("email");
            string UserName = process.getData("UserName");
            if (UserName == null || UserName == "" || UserName == "null")
            {
                if (email != null && email != "" && email != "null")
                {
                    int nEmail = email.ToUpper().IndexOf("@SAIGONNEWPORT");
                    if (nEmail != -1)
                    {
                        UserName = email.Substring(0, nEmail);
                        process.data("UserName_AD", UserName);
                    }
                    else
                    {
                        UserName = email;
                        process.data("UserName_AD", "");
                    }
                    process.data("UserName", UserName);
                }
            }
            else
            {
                string ErroCheckUserName = null;
                bool okCheckUserName = CheckUserName(UserName, process.getData("idbenhnhan"), ref ErroCheckUserName);
                if (!okCheckUserName)
                {
                    Response.Clear();
                    Response.Write(ErroCheckUserName);
                    Response.StatusCode = 502;
                    return;
                }
            }

            bool IsUpdateDangKyKham = false;
            string iddangkykham = Request.QueryString["iddangkykhambn"];
            if (process.getData("idbenhnhan") != null && process.getData("idbenhnhan") != "")
            {

                bool ok = process.Update();
                if (!ok)
                {
                    Response.StatusCode = 502;
                    return;
                }
                else
                {
                    if (iddangkykham != null && iddangkykham != "" && IsCapNhatDKK == "1")
                    {
                        IsUpdateDangKyKham = true;

                    }
                }
            }
            else
            {
                string tenbenhnhan = process.getData("tenbenhnhan");
                tenbenhnhan = StaticData.IntelName(tenbenhnhan);

                tenbenhnhan = System.Text.Encoding.UTF8.GetString(System.Text.Encoding.UTF8.GetBytes(tenbenhnhan));
                process.data("tenbenhnhan", tenbenhnhan);


                process.data("ngaytiepnhan", DateTime.Now.ToString("dd/MM/yyyy"));
                bool ok = process.Insert();
                da_dang_ky = "0";
                if (!ok)
                {
                    Response.StatusCode = 502;
                    return;
                }
            }
            if (process.getData("loai") == "1" || process.getData("loai") == "12")
            {
                #region Kiểm tra xem có khoá dữ liệu trong khoảng thời gian đăng ký hay không
                string ngaydangky_save = StaticData.CheckDate(Request.QueryString["ngaydangky_edit"]) + "";
                DataTable dtKhoaSoLieu = StaticData.dt_HS_KhoaDuLieu;
                int n_temp = StaticData.int_Search(dtKhoaSoLieu, "LoaiKhamID=" + Request.QueryString["loai"] + " and '" + ngaydangky_save + "'>=TUNGAY AND '" + ngaydangky_save + "'<=DENNGAY");
                if (n_temp != -1)
                {
                    Response.Clear();
                    Response.StatusCode = 502;
                    Response.Write("Đã khoá số liệu trong khoảng thời gian: " + (dtKhoaSoLieu.Rows[n_temp]["tungay"].ToString() != "" ? DateTime.Parse(dtKhoaSoLieu.Rows[n_temp]["tungay"].ToString()).ToString("dd/MM/yyyy") : "") + " đến ngày: " + (dtKhoaSoLieu.Rows[n_temp]["denngay"].ToString() != "" ? DateTime.Parse(dtKhoaSoLieu.Rows[n_temp]["denngay"].ToString()).ToString("dd/MM/yyyy") : ""));
                    return;
                }
                #endregion

                string sobh1 = Request.QueryString["sobh1"];
                string sobh2 = Request.QueryString["sobh2"];
                string sobh3 = Request.QueryString["sobh3"];
                string sobh4 = FixValue(Request.QueryString["sobh4"]);
                string sobh5 = FixValue(Request.QueryString["sobh5"]);
                string sobh6 = FixValue(Request.QueryString["sobh6"]);
                string sobh7 = FixValue(Request.QueryString["sobh7"]);
                string sobhyt = sobh1 + sobh2 + sobh3 + sobh7;
                sobhyt = sobhyt.Replace(" ", "");
                bool IsTraiTuyen = StaticData.IsCheck(Request.QueryString["TraiTuyen"]);
                benhnhan_bhyt = Luu_BenhNhan_BHYT(process.getData("idbenhnhan"), sobhyt, Request.QueryString["ngaybatdau"],
                                      Request.QueryString["ngayhethan"],
                                     (Request.QueryString["TraiTuyen"] != null && !IsTraiTuyen ? "Y" : "N"),
                                      Request.QueryString["isgiaychuyen"],
                                      Request.QueryString["IsCapCuu"],
                                     (!IsTraiTuyen ? "1" : "0")
                                     , sobh1, sobh2, sobh3, sobh4, sobh5, sobh6, sobh7
                                     , Request.QueryString["IdNoiDangKyBH"]
                                     , Request.QueryString["idNoiGioiThieu"]
                                     , Request.QueryString["tilebhyt"]
                                    );
            }
            if (IsUpdateDangKyKham)
            {
                string ngaydangky_edit = Request.QueryString["ngaydangky_edit"];
                string giodangky_edit = Request.QueryString["giodangky_edit"];
                string phutdangky_edit = Request.QueryString["phutdangky_edit"];
                string loai = Request.QueryString["loai"];
                string idphong = Request.QueryString["idphongkhambenh"];
                string idkhoa = Request.QueryString["idkhoa"];
                string IDBENHNHAN_BH = Request.QueryString["IDBENHNHAN_BH"];
                DataProcess dangkykham = new DataProcess("dangkykham", true);
                dangkykham.data("idbenhnhan", process.getData("idbenhnhan"));
                dangkykham.data("iddangkykham", iddangkykham);
                dangkykham.data("ngaydangky", ngaydangky_edit + " " + giodangky_edit + ":" + phutdangky_edit);
                dangkykham.data("LoaiKhamID", loai);
                dangkykham.data("IsMienDongChiTra", Request.QueryString["IsMienDongChiTra"]);
                dangkykham.data("idchucvu", Request.QueryString["idchucvu"]);
                dangkykham.data("idcongty", Request.QueryString["idcongty"]);
                dangkykham.data("IdCapBac", Request.QueryString["IdCapBac"]);
                dangkykham.data("IsCapCuuDK", Request.QueryString["IsCapCuu"]);
                dangkykham.data("ThongTuyen", Request.QueryString["IsThongTuyen"]);
                dangkykham.data("No_Send_Message", Request.QueryString["No_Send_Message"]);
                dangkykham.data("idloaiuutien", Request.QueryString["idloaiuutien"]);
                dangkykham.data("IDBENHNHAN_BH", IDBENHNHAN_BH);
                string isNotThuPhiCapCuu = Request.QueryString["isNotThuPhiCapCuu"];
                bool ok_Save_DangKyKham = dangkykham.Update();
                if (1==1)
                {
                    string sqlUpdate_Hoso1 = @"
                                                    UPDATE CHITIETDANGKYKHAM SET PHONGID=" + idphong + ",isNotThuPhiCapCuu=" + (StaticData.IsCheck(isNotThuPhiCapCuu) ? "1" : "0") + @" WHERE IDDANGKYKHAM=" + iddangkykham ;
                    bool OK_UpdateHoSo1=DataAcess.Connect.ExecSQL(sqlUpdate_Hoso1);
                    string sqlUpdate_Hoso2 = @"                                UPDATE HS_BENHNHANBHDONGTIEN SET LOAIKHAMID=A.LOAIKHAMID
                                                                                ,ISBHYT=(CASE WHEN A.LOAIKHAMID=1 THEN 1 ELSE 0 END)
                                                                               " +(IDBENHNHAN_BH!=null && IDBENHNHAN_BH!=""?" ,IDBENHNHAN_BH=" + IDBENHNHAN_BH :"")+@"
                                                                                ,NGAYTINHBH=A.NGAYDANGKY
                                                 FROM DANGKYKHAM A
                                                    INNER JOIN HS_BENHNHANBHDONGTIEN B ON A.IDBENHBHDONGTIEN=B.ID
                                                WHERE A.IDDANGKYKHAM=" + iddangkykham;
                    bool OK_UpdateHoSo2 = DataAcess.Connect.ExecSQL(sqlUpdate_Hoso2);

                    DataProcess sinhhieu = s_sinhhieu();
                    string idsinhhieu = Request.QueryString["idsinhhieu"];
                    bool ok_SH = false;
                    if (idsinhhieu != null && idsinhhieu != "")
                    {
                        sinhhieu.data("idsinhhieu", idsinhhieu);
                        ok_SH = sinhhieu.Update();
                    }
                    else
                    {
                        sinhhieu.data("iddangkykham", iddangkykham);
                        sinhhieu.Insert();
                    }



                    StaticData.TinhLaiTien_ByIdDangKyKham(iddangkykham);
                }
            }

            Response.Clear();
            Result = Codec.EncryptAES(process.getData("idbenhnhan")) + "@" + process.getData("mabenhnhan");
            Result += "@" + benhnhan_bhyt + "@" + da_dang_ky;
            Response.Write(Result);

        }
        catch
        {
            Response.StatusCode = 502;
        }

    }
    //_______________________________________________________________________________________________________
    private void SaveNewBenhNhan()
    {

    }
    //_______________________________________________________________________________________________________
    private string Luu_BenhNhan_BHYT(string idbenhnhan, string sobhyt
                                        , string ngaybatdau, string ngayhethan,
                                        string dungtuyen, string isgiaychuyen,
                                        string iscapcuu, string isdungtuyen
                                        , string sobh1, string sobh2, string sobh3, string sobh4,
                                        string sobh5, string sobh6, string sobh7, string IdNoiDangKyBH
                                        , string IdNoiGioiThieu, string tilebhyt)
    {
        DataProcess s_benhnhan_bhyt = new DataProcess("benhnhan_bhyt");
        s_benhnhan_bhyt.data("IDBENHNHAN_BH", Request.QueryString["IDBENHNHAN_BH"]);
        s_benhnhan_bhyt.data("IDBENHNHAN", idbenhnhan);
        s_benhnhan_bhyt.data("sobhyt", sobhyt.ToUpper());
        s_benhnhan_bhyt.data("ngaybatdau", ngaybatdau);
        if (ngayhethan != null && ngayhethan != "" && ngayhethan != null && ngayhethan != "-" && ngayhethan != "_")
            s_benhnhan_bhyt.data("ngayhethan", ngayhethan);
        else
            s_benhnhan_bhyt.data("ngayhethan", "");

        dungtuyen = (dungtuyen.ToUpper() != "Y" && dungtuyen.ToUpper() != "TRUE" && dungtuyen != "1" ? "N" : "Y");

        s_benhnhan_bhyt.data("DungTuyen", dungtuyen);
        s_benhnhan_bhyt.data("isgiaychuyen", isgiaychuyen);
        s_benhnhan_bhyt.data("IsCapCuu", iscapcuu);
        s_benhnhan_bhyt.data("IsDungTuyen", isdungtuyen);
        s_benhnhan_bhyt.data("sobh1", sobh1.ToUpper());
        s_benhnhan_bhyt.data("sobh2", sobh2);
        s_benhnhan_bhyt.data("sobh3", sobh3);
        if ((sobh4 == null || sobh4 == "") && sobh7 != null && sobh7 != "")
        {
            sobh4 = sobh7.Substring(0, 2);
            sobh5 = sobh7.Substring(2, 3);
            sobh6 = sobh7.Substring(5, 5);
        }
        s_benhnhan_bhyt.data("sobh4", sobh4);
        s_benhnhan_bhyt.data("sobh5", sobh5);
        s_benhnhan_bhyt.data("sobh6", sobh6);
        s_benhnhan_bhyt.data("sobh7", sobh7);
        s_benhnhan_bhyt.data("IdNoiDangKyBH", IdNoiDangKyBH);
        s_benhnhan_bhyt.data("IdNoiGioiThieu", IdNoiGioiThieu);
        s_benhnhan_bhyt.data("tilebhyt", tilebhyt);


        s_benhnhan_bhyt.data("ngaybdmiendct", Request.QueryString["ngaybdmiendct"]);
        s_benhnhan_bhyt.data("ngaydu_5namlientuc", Request.QueryString["ngaydu_5namlientuc"]);
        s_benhnhan_bhyt.data("MA_KHUVUC", Request.QueryString["MA_KHUVUC"]);


        DataTable dt = s_benhnhan_bhyt.Search_Object("IDBENHNHAN_BH");
        string bn_bhyt = "";
        if (dt != null && dt.Rows.Count > 0)
        {
            if (s_benhnhan_bhyt.Update())
            {
                bn_bhyt = s_benhnhan_bhyt.getData("IDBENHNHAN_BH");
            }
        }
        else
        {

            if (s_benhnhan_bhyt.Insert())
            {
                bn_bhyt = s_benhnhan_bhyt.getData("IDBENHNHAN_BH");

            }
        }
        return bn_bhyt;
    }

    private void dangkykhambenh()
    {
        #region kiểm tra thông tin
        string IsSave_BHYT_Auto = Request.QueryString["IsSave_BHYT_Auto"];
        string xung_danh = "Bệnh nhân";
        if (IsSave_BHYT_Auto == "1") xung_danh = "Ông/bà";

        string LoaiKhamID = Request.QueryString["loai"];
        if (LoaiKhamID.IndexOf(",") != -1)
            LoaiKhamID = LoaiKhamID.Split(',')[0];

        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"].ToString());
        string idphong = Request.QueryString["idphongkhambenh"];
        #region Nếu là đăng ký khám tự động
        if (Request.QueryString["IsSave_BHYT_Auto"] == "1" && StaticData.IsActive_MobileApp == "1")
        {
            DataTable dtPhong_Mobile = MobileApp.dt_Phong;
            if (dtPhong_Mobile != null && dtPhong_Mobile.Rows.Count > 0)
            {
                int n_temp0 = StaticData.int_Search(dtPhong_Mobile, "id=" + idphong);
                if (n_temp0 != -1)
                {
                    string ma_phong = dtPhong_Mobile.Rows[n_temp0]["ma_so"].ToString();
                    string sqlSelectPhong = "SELECT * FROM KB_PHONG WHERE MASO=N'" + ma_phong + "'";
                    DataTable dtPhong = DataAcess.Connect.GetTable(sqlSelectPhong);
                    if (dtPhong != null && dtPhong.Rows.Count > 0)
                    {
                        idphong = dtPhong.Rows[0][0].ToString();
                    }
                }
            }
        }
        #endregion
        string da_dangky = Request.QueryString["da_dangky"];
        string idkhoa = Request.QueryString["idkhoa"];

        string ismuaso = "0";
        string isNotThuPhiCapCuu = Request.QueryString["isNotThuPhiCapCuu"];
        if (StaticData.IsCheck(isNotThuPhiCapCuu) == false)
            isNotThuPhiCapCuu = "0";
        else
            isNotThuPhiCapCuu = "1";


        string giodk = Request.QueryString["giodk"];
        string phutdk = Request.QueryString["phutdk"];
        string NgayDangKy = DataProcess.sGetValidDate(giodk, phutdk, Request.QueryString["ngaydangky"]);
        string NgayDangKy_KB = NgayDangKy;
        if (NgayDangKy.Substring(0, 5).IndexOf(":") != -1)
        {
            NgayDangKy_KB = StaticData.CheckDate(NgayDangKy.Substring(6, "29/11/2012".Length)) + " " + NgayDangKy.Substring(0, 5) + ":00";
        }

        string ngaydangky_new = StaticData.CheckDate(Request.QueryString["ngaydangky"]) + " " + (giodk != "" ? giodk : DateTime.Now.ToString("HH")) + ":" + (phutdk != "" ? phutdk : DateTime.Now.ToString("mm")) + ":00";

        #endregion
        #region Kiểm tra xem có khoá dữ liệu trong khoảng thời gian đăng ký hay không
        string ngaydangky_save = StaticData.CheckDate(Request.QueryString["ngaydangky"]) + "";
        DataTable dtKhoaSoLieu = StaticData.dt_HS_KhoaDuLieu;
        int n_temp = StaticData.int_Search(dtKhoaSoLieu, "LoaiKhamID=" + LoaiKhamID + " and '" + ngaydangky_save + "'>=TUNGAY AND '" + ngaydangky_save + "'<=DENNGAY");
        if (n_temp != -1)
        {
            Response.Clear();
            Response.StatusCode = 502;
            Response.Write((IsSave_BHYT_Auto == "1" ? "0|" : "") + "Đã khoá số liệu trong khoảng thời gian: " + (dtKhoaSoLieu.Rows[n_temp]["tungay"].ToString() != "" ? DateTime.Parse(dtKhoaSoLieu.Rows[n_temp]["tungay"].ToString()).ToString("dd/MM/yyyy") : "") + " đến ngày: " + (dtKhoaSoLieu.Rows[n_temp]["denngay"].ToString() != "" ? DateTime.Parse(dtKhoaSoLieu.Rows[n_temp]["denngay"].ToString()).ToString("dd/MM/yyyy") : ""));
            return;
        }
        #endregion
        #region Kiểm tra đã có BV hoàn tất trong ngày  hay không , trường hợp chưa kiểm tra ở javascript
        string IsNoCheckBV = Request.QueryString["IsNoCheckBV"];
        if (IsNoCheckBV != "1")
        {
            bool IsHaveCheckBV = true;
            if (IsHaveCheckBV)
            {
                string sqlCheckBV = @"
                        select top 1  a.*
                        from hs_benhnhanbhdongtien a
                        where a.idbenhnhan=" + idbenhnhan + @"
                        and a.ischeck_all=1
                        and a.ngaytinhbh_thuc>='" + ngaydangky_save + @"'
                        and a.ngaytinhbh_thuc<='" + ngaydangky_save + @" 23:59:59'
                        ";
                DataTable dtCheckBV = DataAcess.Connect.GetTable(sqlCheckBV);
                if (dtCheckBV != null && dtCheckBV.Rows.Count > 0)
                {
                    Response.Clear();
                    Response.StatusCode = 502;
                    Response.Write((IsSave_BHYT_Auto == "1" ? "0|" : "") + "Tồn tại 1 BV trong ngày đã hoàn tất ,nên không thể đăng ký khám trong hôm nay được");
                    return;
                }
            }
        }
        #endregion
        #region Lưu đăng ký khám
        string UserID = SysParameter.UserLogin.UserID(this);
        DataProcess DKK = new DataProcess("dangkykham");

        string lich_hen_kham_benh_id = Request.QueryString["lich_hen_kham_benh_id"];
        if (lich_hen_kham_benh_id != null && lich_hen_kham_benh_id != "" && lich_hen_kham_benh_id != null && lich_hen_kham_benh_id != "undefined")
            DKK.data("lich_hen_kham_benh_id", lich_hen_kham_benh_id);
        DKK.data("idbenhnhan", idbenhnhan);
        DKK.data("ngaydangky", NgayDangKy);
        DKK.data("dathu", "0");
        DKK.data("ngayxacnhan", NgayDangKy);
        DKK.data("IsNguoiNuocNgoai", Request.QueryString["IsNguoiNuocNgoai"]);
        DKK.data("idcongty", Request.QueryString["idcongty"]);
        DKK.data("dahuy", "0");
        DKK.data("loaitainanid", Request.QueryString["idloaitainan"]);
        DKK.data("IsMienDongChiTra", Request.QueryString["IsMienDongChiTra"]);
        DKK.data("ThongTuyen", Request.QueryString["IsThongTuyen"]);
        DKK.data("IsCapCuuDK", Request.QueryString["IsCapCuu"]);
        DKK.data("idchucvu", Request.QueryString["idchucvu"]);
        DKK.data("No_Send_Message", Request.QueryString["No_Send_Message"]);
        DKK.data("idloaiuutien", Request.QueryString["idloaiuutien"]);
        DKK.data("LoaiKhamID", LoaiKhamID);
        DKK.data("IdNguoiDung", UserID);
        if (LoaiKhamID != "1" && LoaiKhamID != "12")
        {
            DKK.data("IDBENHNHAN_BH", "null");
        }
        else
        {
            string IDBENHNHAN_BH = (Request.QueryString["IDBENHNHAN_BH"] == null || Request.QueryString["IDBENHNHAN_BH"] == "") ? "" : Request.QueryString["IDBENHNHAN_BH"].ToString();
            if ((IDBENHNHAN_BH == null || IDBENHNHAN_BH == "" || IDBENHNHAN_BH == "null") && LoaiKhamID == "1" && Request.QueryString["sobhyt"] != null && Request.QueryString["sobhyt"] != "" && IsSave_BHYT_Auto == "1")
            {
                IDBENHNHAN_BH = Luu_BenhNhan_BHYT(idbenhnhan, Request.QueryString["sobhyt"], Request.QueryString["ngaydangky"], Request.QueryString["ngayhethan"], Request.QueryString["dungtuyen"], "0", "0"
                       , (Request.QueryString["dungtuyen"] == "Y" || StaticData.IsCheck(Request.QueryString["dungtuyen"]) ? "1" : "0")
                       , Request.QueryString["sobh1"], Request.QueryString["sobh2"], Request.QueryString["sobh3"], null, null, null, Request.QueryString["sobh7"], Request.QueryString["IdNoiDangKyBH"], null, Request.QueryString["tilebhyt"]);
            }
            DKK.data("IDBENHNHAN_BH", IDBENHNHAN_BH);
        }
        DKK.data("IdChiNhanh", (string.IsNullOrEmpty(idkhoa) ? Userlogin_new.IdChiNhanh(this) : idkhoa));

        DKK.data("KhongThuPhi", Request.QueryString["KhongThuPhi"]);

        #region hinh_dai_dien
        string hinh_dai_dien = Request.Form["hinh_dai_dien"];
        if (hinh_dai_dien != null && hinh_dai_dien != "" && hinh_dai_dien != "null")
        {
            hinh_dai_dien = hinh_dai_dien.Replace("data:image/png;base64,", "");

            byte[] newBytes = Convert.FromBase64String(hinh_dai_dien);
            string path_anh_dai_dien = Server.MapPath("~/Hinh_Dai_Dien_Dang_Ky_Kham");
            if (System.IO.Directory.Exists(path_anh_dai_dien) == false)
            {
                System.IO.Directory.CreateDirectory(path_anh_dai_dien);
            }
            string filename_anh_dai_dien = idbenhnhan + "_" + NgayDangKy.Replace("/", "").Replace(":", "").Replace(" ", "") + ".jpg";
            StaticData.b_WriteFile(path_anh_dai_dien + "\\" + filename_anh_dai_dien, newBytes);
            DKK.data("hinh_dai_dien ", filename_anh_dai_dien);
        }

        #endregion

        bool saveDKK = DKK.Insert();
        string iddangkykham = "";
        if (!saveDKK)
        {
            Response.Clear();
            Response.StatusCode = 502;
            Response.Write("Không lưu được đăng ký khám !");
            return;
        }
        else
        {
            iddangkykham = DKK.getData("iddangkykham");
        }
        #endregion
        #region  Lưu Chi tiết đăng ký khám
        DataProcess ctdkkham = new DataProcess("chitietdangkykham");
        bool isKhamSK = false;
        string idchitietdangkykham = null;
        if (idphong != null && idphong != "")
        {
            string sDvDk = @"
                                SELECT			DichVuKCB
				                                ,DonGiaDV= isnull( (SELECT top 1 GiaDV FROM HS_BangGiaVienPhi WHERE IdDichVu=DichVuKCB  order by TuNgay desc ),0)
			                                    ,isKhamSucKhoe=CONVERT(int,isnull(bg.isKhamSucKhoe,0))
                                FROM KB_Phong p 
                                left join banggiadichvu bg on bg.idbanggiadichvu =p.DichVuKCB 
                                WHERE  p.Id=" + idphong;

            DataTable dtb = DataAcess.Connect.GetTable(sDvDk);
            if (dtb == null || dtb.Rows.Count == 0)
            {
                Response.Clear();
                Response.StatusCode = 502;
                Response.Write("Không có id phòng khám , vui lòng liên hệ Admin");
                return;
            }
            string IdPhong = idphong;
            string DichVuKCB = dtb.Rows[0][0].ToString();
            isKhamSK = StaticData.IsCheck(dtb.Rows[0]["isKhamSucKhoe"].ToString());
            string SoTT = "1";
            string SLBNCho = "0";
            string SLBNDaKham = "0";
            ctdkkham.data("iddangkykham", DKK.getData("iddangkykham"));
            ctdkkham.data("idbanggiadichvu", DichVuKCB);
            ctdkkham.data("soluong", "1");
            ctdkkham.data("dahuy", "0");
            ctdkkham.data("dakham", "0");
            ctdkkham.data("IdNguoiDung", UserID);
            ctdkkham.data("SoTT", SoTT);
            ctdkkham.data("phongid", IdPhong);
            ctdkkham.data("SLBNCho", SLBNCho);
            ctdkkham.data("SLBNDK", SLBNDaKham);
            ctdkkham.data("IsDaThu", "0");
            ctdkkham.data("isbndatra", "0");
            ctdkkham.data("isNotThuPhiCapCuu", isNotThuPhiCapCuu);
            ctdkkham.data("idkhoa", idkhoa);
            ctdkkham.data("DonGiaDV", dtb.Rows[0]["DonGiaDV"].ToString());

            if (!ctdkkham.Insert())
            {
                Response.Clear();
                Response.StatusCode = 502;
                Response.Write("Đăng ký khám thất bại");
                return;
            }
            else idchitietdangkykham = ctdkkham.getData("idchitietdangkykham");


        }
        #endregion
        #region TinhLaiTien_ByIdDangKyKham
        StaticData.TinhLaiTienKham(DKK.getData("iddangkykham"));

        #endregion
        #region Lưu sinh hiệu nếu có
        string mach = Request.QueryString["mach"];
        string huyetap1 = Request.QueryString["huyetap1"];
        string huyetap2 = Request.QueryString["huyetap2"];
        string chieucao = Request.QueryString["chieucao"];
        string cannang = Request.QueryString["cannang"];
        if ((mach != null && mach != "") || (huyetap1 != null && huyetap1 != "") || (huyetap2 != null && huyetap2 != "") || (chieucao != null && chieucao != "") || (cannang != null && cannang != ""))
        {
            DataProcess sinhhieu = s_sinhhieu();
            string idsinhhieu = sinhhieu.getData("idsinhhieu");
            sinhhieu.data("idbenhnhan", idbenhnhan);
            sinhhieu.data("ngaydo", NgayDangKy);
            sinhhieu.data("Iddangkykham", iddangkykham);
            sinhhieu.data("idchitietdangkykham", ctdkkham.getData("idchitietdangkykham"));
            sinhhieu.data("DangDieuTriTimMach", Request.QueryString["DangDieuTriTimMach"]);
            bool ok_sinhhieu = false;
            ok_sinhhieu = sinhhieu.Insert();
        }
        #endregion
        #region finall
        Response.Clear();
        try
        {
            #region Update Email
            if (IsSave_BHYT_Auto == "1" && Request.QueryString["email"] != null && Request.QueryString["email"] != "")
            {
                string sqlUpdate_Email_BN = "UPDATE BENHNHAN SET email=N'" + Request.QueryString["email"] + "' where idbenhnhan=" + idbenhnhan;
                bool ok_udpate_email_bn = DataAcess.Connect.ExecSQL(sqlUpdate_Email_BN);
            }
            #endregion
            #region Update_LichHen
            if (lich_hen_kham_benh_id != null && lich_hen_kham_benh_id != "" && lich_hen_kham_benh_id != null && lich_hen_kham_benh_id != "undefined")
            {
                string sqlUpdate_LichHen = @"
                                    UPDATE public.lich_hen_kham_benh
	                                    SET  da_kham='1', ngay_da_kham='" + ngaydangky_save + @"'
	                                    WHERE id=" + lich_hen_kham_benh_id;
                bool ok_update_lich_hen = DataAces_Postgre.Connect.ExecSQL(sqlUpdate_LichHen);
            }
            #endregion
            if (StaticData.IsActive_MobileApp == "1")
            {
                string No_Send_Message = Request.QueryString["No_Send_Message"];
                if (StaticData.IsCheck(No_Send_Message) != true)
                {
                    MobileApp.SendMessage_Just_DangKyKhamBenh(iddangkykham);
                    MobileApp.Insert_SoThuThu_KhamBenh(idchitietdangkykham);
                }
            }



        }
        catch (Exception E) { }

        Response.Write(iddangkykham);
        #endregion
    }
    //_______________________________________________________________________________________________________
    private bool KiemTraNgayRaToa(string idbenhnhan, string phongid)
    {
        return true;
        int idbnTT = 0;
        idbnTT = StaticData.ParseInt(idbenhnhan);
        string hetThuoc = @"select convert(datetime,dateadd(day,max(ct.ngayuong),max(ngayratoa)),111) as HetThuoc 
                        from benhnhantoathuoc bntt
                        left join chitietbenhnhantoathuoc ct on ct.idbenhnhantoathuoc=bntt.idbenhnhantoathuoc
                        inner join khambenh kb on kb.idkhambenh=bntt.idkhambenh
                        inner join chitietdangkykham ctdk on ctdk.idchitietdangkykham=kb.idchitietdangkykham
                        where bntt.idbenhnhan=" + idbnTT + " and ctdk.phongid='" + phongid + @"'
                        group by ngayratoa";
        DataTable dtHetThuoc = DataAcess.Connect.GetTable(hetThuoc);
        if (dtHetThuoc == null) return true;
        if (dtHetThuoc.Rows.Count <= 0) return true;
        if (dtHetThuoc.Rows[0]["HetThuoc"].ToString() == "")
            return true;
        DateTime hetThuocDung = DateTime.Parse(dtHetThuoc.Rows[0]["HetThuoc"].ToString());
        DateTime currenDay = DateTime.Parse(System.DateTime.Now.ToString("yyyy/MM/dd"));
        if (currenDay <= hetThuocDung)
        {
            return false;
        }
        else
            return true;
    }
    //_______________________________________________________________________________________________________
    private void TimDiaChi()
    {
        string sqlSelect = @"SELECT  A.KYHIEU,A.PHUONGXAID,A.QUANHUYENID,B.TINHID,
                            A.TENPHUONGXA + ',' + B.QUANHUYENNAME + ',' + C.TINHNAME AS DIACHI,
                           A.TENPHUONGXA,B.QUANHUYENNAME,C.MATINH + '_' + C.TINHNAME AS TENTINH
                            FROM PHUONGXA A LEFT JOIN QUANHUYEN B ON A.QUANHUYENID=B.QUANHUYENID
                            LEFT JOIN TINH C ON B.TINHID=C.TINHID
                            WHERE A.KYHIEU LIKE N'" + Request.QueryString["q"] + "%' ORDER BY C.TINHNAME";
        string html = "";
        DataTable table = DataAcess.Connect.GetTable(sqlSelect);
        if (table != null && table.Rows.Count > 0)
        {
            foreach (DataRow row in table.Rows)
            {
                html += string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}", "<div>"
                      + "<div style=\"width:15%; float:left; padding-left:10px; font-size:13px;\">" + row["KYHIEU"] + "</div>"
                      + "<div style=\"width:80%; float:left; font-size:13px;\">" + row["DIACHI"] + "</div>"
                      + "</div>", row["KYHIEU"], row["DIACHI"], row["PHUONGXAID"], row["QUANHUYENID"], row["TINHID"], row["TENPHUONGXA"], row["QUANHUYENNAME"], row["TENTINH"], Environment.NewLine
                    );
            }
        }
        Response.Clear();
        Response.Write(html);

    }
    //_______________________________________________________________________________________________________
    private void GetList_DangKyCapGiayKSK()
    {
        Response.Clear();
        string ISCAPGIAY = Request.QueryString["ISCAPGIAY"];
        if (StaticData.IsCheck(ISCAPGIAY)) ISCAPGIAY = "1";
        else ISCAPGIAY = "0";

        string IdBenhNhan = Codec.DecryptAES(Request.QueryString["IdBenhNhan"]);
        if (IdBenhNhan == null || IdBenhNhan == "")
        {
            Response.Write("-1|0");
            return;
        }

        string sqlSelect = @"SELECT top 10 A.IdDangKyCLS,A.MAPHIEUCLS,NGAYTHU=CONVERT(NVARCHAR(20),A.NGAYTHU,103)
                                    FROM KHAMBENHCANLAMSAN A
                                   WHERE ISNULL(A.IDKHAMBENH,0)=0 AND A.IDBENHNHAN=" + IdBenhNhan + @"
                                    AND ISNULL(A.ISCAPGIAY,0)=" + ISCAPGIAY;


        DataTable dtCheck = DataAcess.Connect.GetTable(sqlSelect);
        if (dtCheck == null)
        {
            Response.Write("0|0");
            return;
        }

        string html = "1|";
        html += "<table class=\"print t1\" border='1px'  style='width:100%;font-size:10pt;font-family:Times New Roman;border-collapse: collapse;background-color: white;' cellspacing='10'>";
        for (int i = 0; i < dtCheck.Rows.Count; i++)
        {
            html += @"
                <tr>
                        <td>" + dtCheck.Rows[i]["NGAYTHU"].ToString() + @" </td>
                        <td>" + dtCheck.Rows[i]["MAPHIEUCLS"].ToString() + @" </td>
                        <td>" + "<a style='font-weight:bold;color:blue'  onclick=\"viewDetailDangKyCapGiay('" + dtCheck.Rows[i]["IdDangKyCLS"].ToString() + "')\">  Chi tiết </a></td>" + @"
                </tr>
               ";
        }

        html += @"
                <tr>
                        <td colspan='3' >" + "<a  style='font-weight:bold;color:blue' onclick=\"NewDangKyCapGiay()\">  Đăng ký mới </a> </td>" + @"
                </tr>
               ";

        html += "</table";
        Response.Clear();
        Response.Write(html);
        return;
    }
    //────────────────────────────────────────────────────────────────────────────────────────── 
    private void GetLastMaPhieuCLS()
    {
        string IdBenhNhan = Codec.DecryptAES(Request.QueryString["IdBenhNhan"]);
        if (IdBenhNhan == null || IdBenhNhan == "")
        {
            Response.Write("");
            return;
        }

        string sqlSelect = @"SELECT DISTINCT IDBENHNHAN,MAPHIEUCLS,NGAYTHU,IdNguoiDung
                                    FROM KHAMBENHCANLAMSAN
                                   WHERE ISNULL(IDKHAMBENH,0)=0 AND IDBENHNHAN=" + IdBenhNhan;
        DataTable dtCheck = DataAcess.Connect.GetTable(sqlSelect);
        if (dtCheck == null || dtCheck.Rows.Count == 0)
        {
            Response.Write("not");
            return;
        }
        sqlSelect = "SELECT TOP 1 * FROM HS_DANGKYCLS WHERE IDBENHNHAN=" + IdBenhNhan + @" AND EXISTS (SELECT 1 FROM KHAMBENHCANLAMSAN WHERE IDDANGKYCLS=HS_DANGKYCLS.IDDANGKYCLS) ORDER BY NGAYDK DESC ,IdDangKyCLS DESC";

        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        if (dt == null || dt.Rows.Count == 0)
        {
            return;
        }
        Response.Clear();
        Response.Write(dt.Rows[0]["IdDangKyCLS"].ToString() + "|" + dt.Rows[0]["MaPhieuCLS"].ToString());
        return;
    }
    //────────────────────────────────────────────────────────────────────────────────────────── 
    public static string NewSTT(string NgayTiepNhan)
    {
        string SLBN = "0";
        DateTime dNgayTiepNhan = DateTime.Parse(NgayTiepNhan);
        string sqlSelect = @"SELECT count(idbenhnhan) 
                                FROM BENHNHAN
                                WHERE YEAR(NGAYTIEPNHAN)=" + dNgayTiepNhan.Year.ToString()
                                    + " AND MONTH(NGAYTIEPNHAN)=" + dNgayTiepNhan.Month.ToString()
                                    + " AND DAY(NGAYTIEPNHAN)=" + dNgayTiepNhan.Day.ToString();
        DataTable dtBenhNhan = DataAcess.Connect.GetTable(sqlSelect);
        if (dtBenhNhan == null) return "";
        SLBN = "0";
        if (dtBenhNhan.Rows.Count > 0) SLBN = dtBenhNhan.Rows[0][0].ToString();
        if (SLBN == "") SLBN = "0";
        SLBN = (int.Parse(SLBN) + 1).ToString();
        return SLBN;

    }
    //────────────────────────────────────────────────────────────────────────────────────────── 
    public static string NewMaBenhNhan(string NgayTiepNhan, ref string SLBN)
    {
        string s = "";
        while (true)
        {
            DateTime dNgayTiepNhan = DateTime.Parse(NgayTiepNhan);
            string sqlSelect = @"SELECT MAX(SLBN) 
                                FROM HS_MaBenhNhanSave
                                WHERE YEAR(sysdate)=" + dNgayTiepNhan.Year.ToString()
                                        + " AND MONTH(sysdate)=" + dNgayTiepNhan.Month.ToString()
                                        + " AND DAY(sysdate)=" + dNgayTiepNhan.Day.ToString();
            DataTable dtBenhNhan = DataAcess.Connect.GetTable(sqlSelect);
            if (dtBenhNhan == null) return "";
            SLBN = "0";
            if (dtBenhNhan.Rows.Count > 0) SLBN = dtBenhNhan.Rows[0][0].ToString();
            if (SLBN == "") SLBN = "0";
            string temp = "00000";


            SLBN = (int.Parse(SLBN) + 1).ToString();
            SLBN = temp.Substring(0, 3 - SLBN.Length) + SLBN;
            s = "BN-" + dNgayTiepNhan.ToString("ddMMyyyy") + "-" + SLBN;

            bool OK = DataAcess.Connect.ExecSQL(@"insert into HS_MaBenhNhanSave (sysdate,slbn,mabenhnhan)
                                    values('" + NgayTiepNhan + "','" + SLBN + "','" + s + "')");
            if (OK == false) return null;
            string sqlTest = "SELECT TOP 1 IDBENHNHAN FROM BENHNHAN WHERE MABENHNHAN=N'" + s + "'";
            DataTable dtTest = DataAcess.Connect.GetTable(sqlTest);
            if (dtTest == null) return null;
            if (dtTest.Rows.Count == 0) break;

        }
        return s;

    }
    //────────────────────────────────────────────────────────────────────────────────────────── 
    private void TinhLaiTien()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        if (idbenhnhan == null || idbenhnhan == "") return;
        bool OK = StaticData.TinhLaiTien_ByIdBenhNhan(idbenhnhan);
        if (OK)
            Response.Write("Tính tiền lại thành công");
        else
            Response.Write("Tính tiền lại thất bại");
    }
    //────────────────────────────────────────────────────────────────────────────────────────── 
    private void LayIDChiTietDangKyKham()
    {
        string idkhoachinh = Codec.DecryptAES(Request.QueryString["idkhoachinh"]);
        string sqlSelect = "select top 1 idchitietdangkykham from chitietdangkykham where IDBENHNHAN_CHITIET=" + idkhoachinh + " order by NGAYDANGKY_CHITIET desc";
        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        Response.Clear();
        Response.Write(dt.Rows[0]["idchitietdangkykham"].ToString());
    }
    //_______________________________________________________________________________________________________
    private void IsPrintMaVach()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        if (idbenhnhan == null || idbenhnhan == "") return;
        string sqlSave = @"UPDATE db_owner.zHS_IsPrint SET IDBENHNHAN=" + idbenhnhan;
        bool ok = DataAcess.Connect.ExecSQL(sqlSave);

    }
    //_______________________________________________________________________________________________________
    private void KiemTraBenhNhanTheoSoBHYT()
    {
        string sobhyt = Request.QueryString["sobhyt"];
        if (sobhyt != null && sobhyt != "") sobhyt = sobhyt.Replace(" ", "");
        string sqlSelect = @"select top 1 idbenhnhan from BENHNHAN_BHYT where sobhyt='" + sobhyt + "'";
        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        if (dt != null && dt.Rows.Count > 0)
        {
            Response.Clear();
            Response.Write(dt.Rows[0][0].ToString());
        }
        else
        {
            return;
        }
    }
    //_______________________________________________________________________________________________________
    private void LayThongTinMaCode()
    {
        string chuoitext = ConvertHexToUTF8(Request.QueryString["chuoitext"].ToString());
        Response.Clear();
        Response.Write(chuoitext);
    }
    //_______________________________________________________________________________________________________
    private string ConvertHexToUTF8(string hex)
    {
        int length = hex.Length;
        byte[] bytes = new byte[length / 2];

        for (int i = 0; i < length; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        }
        return Encoding.UTF8.GetString(bytes);
    }
    //_______________________________________________________________________________________________________
    private void loadmadangky_bh()
    {
        string where = "";
        if (Request.QueryString["q"] != null && Request.QueryString["q"] != "")
        {

            where = " and MADANGKY=N'" + Request.QueryString["q"] + "'";
        }

        string sql = @"select top 1 * from kb_noidangkykb where 1=1" + where;
        DataTable table = DataAcess.Connect.GetTable(sql);
        string html = "";
        if (table != null)
        {
            if (table.Rows.Count > 0)
            {
                string check = "";

                if (bool.Parse(table.Rows[0]["DUNGTUYEN"].ToString()) == true)
                {
                    check = "1";
                }
                else
                {
                    check = "0";
                }

                html += table.Rows[0]["MADANGKY"] + "|" + table.Rows[0]["TENNOIDANGKY"] + "|" + table.Rows[0]["IDNOIDANGKY"] + "|" + check;
            }
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void LayThongTinDangKy()
    {
        string html = "";
        string madk = Request.QueryString["madk"].ToString();
        string sqlSelect = @"Select top 1 * from dangkykham_online where madangky='" + madk + "' order by iddangky desc";
        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        if (dt != null && dt.Rows.Count > 0)
        {
            html += dt.Rows[0]["madangky"] + "|" + dt.Rows[0]["hoten"] + "|" + dt.Rows[0]["chuyenkhoa"] + "|" + dt.Rows[0]["bacsi"] + "|" + dt.Rows[0]["ngaykham"] + "|" + dt.Rows[0]["namsinh"] + "|" + dt.Rows[0]["gioitinh"] + "|" + dt.Rows[0]["mabenhnhan"] + "|" + dt.Rows[0]["lydo"];
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    private void LayIDBenhNhanTheoMaBN()
    {
        string html = "";
        string mabenhnhan = Request.QueryString["mabenhnhan"].ToString();
        string sqlSelect = @"Select top 1 idbenhnhan from benhnhan where mabenhnhan='" + mabenhnhan + "'";
        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        if (dt != null && dt.Rows.Count > 0)
        {
            html += dt.Rows[0][0];
        }
        Response.Clear(); Response.Write(html);
    }
    //_______________________________________________________________________________________________________
    public void SetControlDKKOnline()
    {
        string html = "";
        string SqlOption = @"select dangkyonline=isnull((SELECT ParaValue FROM KB_Parameter WHERE ParaName='dangkyonline' ),0)";
        DataTable dtOption = DataAcess.Connect.GetTable(SqlOption);
        if (dtOption != null && dtOption.Rows.Count > 0)
        {
            html = dtOption.Rows[0][0].ToString();
        }
        Response.Clear();
        Response.Write(html);
    }
    //-----------------------------------------------------------------------
    private void TenBN_Search()
    {
        if (Request.QueryString["q"] == null) return;
        string sql = @"select TOP 1000  IDBENHNHAN
                                ,TENBENHNHAN
                                ,MABENHNHAN
                                ,NGAYSINH
                                ,GIOITINH
                                ,TENGIOITINH=(CASE WHEN GIOITINH=1 THEN N'Nữ' ELSE N'Nam' END)
                                ,DIACHI=DIACHI
                                ,NOICONGTAC=B.TENCTY
                                ,A.EMPL_ID
                                ,A.EMPLCODE
                                FROM BENHNHAN A
                                LEFT JOIN KB_CONGTY B ON A.IDCONGTY=B.IDCONGTY
                        WHERE ( A.TENBENHNHAN LIKE N'%" + Request.QueryString["q"].ToString() + @"%' or A.NameNotSign like N'%" + StaticData.s_GetNameNotSign(Request.QueryString["q"].ToString()) + @"%')
                                AND ISNULL(A.MABENHNHAN,'')<>''   AND ISNULL(A.DIACHI,'')<>''

                        ORDER BY (CASE WHEN A.TENBENHNHAN=N'" + Request.QueryString["q"].ToString() + @"' THEN 1 ELSE 2 END ), A.TENBENHNHAN
                            ";



        DataTable table = DataAcess.Connect.GetTable(sql);


        string html = "";
        if (table != null)
        {
            DataRow R = table.NewRow();
            R["TENBENHNHAN"] = Request.QueryString["q"];
            table.Rows.Add(R);

            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {

                    html +=
                            table.Rows[i]["TENBENHNHAN"].ToString()//0
                            + "|" + table.Rows[i]["NGAYSINH"].ToString()//1
                            + "|" + table.Rows[i]["TENGIOITINH"].ToString()//2
                            + "|" + table.Rows[i]["DIACHI"].ToString()//3
                            + "|" + table.Rows[i]["GIOITINH"].ToString()//4
                            + "|" + table.Rows[i]["IDBENHNHAN"].ToString() //5
                            + "|" + table.Rows[i]["MABENHNHAN"].ToString() //6
                            + "|" + table.Rows[i]["NOICONGTAC"].ToString() //7
                            + "|" + table.Rows[i]["EMPL_ID"].ToString() //8
                            + "|" + table.Rows[i]["EMPLCODE"].ToString() //9
                        + Environment.NewLine;

                }
            }
        }
        Response.Clear(); Response.Write(html);
    }//end void
    //_______________________________________________________________________________________________________
    private void CheckBaoHiemYTe()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"].ToString());
        string AlertCheck = "";
        #region Check Ngày hết hạn
        bool IsCheckNgayHetHanBH = StaticData.IsCheck(StaticData.GetParaValueDB("IsCheckNgayHetHanBH"));
        string s_SoNgayGanHetHanBaoHiem = StaticData.GetParaValueDB("SoNgayGanHetHanBaoHiem");
        int SoNgayGanHetHanBaoHiem = 5;
        if (s_SoNgayGanHetHanBaoHiem != "") SoNgayGanHetHanBaoHiem = int.Parse(s_SoNgayGanHetHanBaoHiem);
        if (IsCheckNgayHetHanBH)
        {
            string sqlSelect = @"SELECT TOP 1 * FROM BENHNHAN_BHYT WHERE IDBENHNHAN=" + idbenhnhan + " ORDER BY NGAYHETHAN DESC";
            DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
            Response.Clear();
            if (dt != null && dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["NgayHetHan"].ToString() != "")
                {
                    DateTime dNgayHetHan = DateTime.Parse(DateTime.Parse(dt.Rows[0]["NgayHetHan"].ToString()).ToString("yyyy-MM-dd"));
                    DateTime Now = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    if (dNgayHetHan == Now)
                    {
                        AlertCheck += "\r\n" + "Bảo hiểm của bệnh nhân vừa hết hạn vào ngày hôm này :" + dNgayHetHan.ToString("dd/MM/yyyy");
                    }
                    else if (dNgayHetHan < Now)
                    {
                        AlertCheck += "\r\n" + "Bảo hiểm của bệnh nhân đã hết hạn rồi (ngày hết hạn là :" + dNgayHetHan.ToString("dd/MM/yyyy") + " )";
                    }
                    else if (Now.AddDays(SoNgayGanHetHanBaoHiem) > dNgayHetHan)
                    {
                        TimeSpan songay_Spane = (TimeSpan)(dNgayHetHan - Now);
                        AlertCheck += "\r\n" + "Bảo hiểm của bệnh nhân chỉ còn :" + songay_Spane.Days.ToString() + " ngày (ngày hết hạn là :" + dNgayHetHan.ToString("dd/MM/yyyy") + " )";
                    }
                }
            }

        }
        #endregion
        #region Check ngày hết thuốc
        bool IsCheckNgayRaToa = StaticData.IsCheck(StaticData.GetParaValueDB("IsCheckNgayRaToa"));
        if (IsCheckNgayRaToa)
        {
            string sqlSectCheckNgayRaToa = @"SELECT TOP 1 A.NGAYKHAM, A.SoNgayRaToa,TENBACSI=C.TENBACSI,CHƯYENKHOA=D.TENDICHVU
                                                    FROM KHAMBENH A
                                                        INNER JOIN DANGKYKHAM B ON A.IDDANGKYKHAM=B.IDDANGKYKHAM
                                                        INNER JOIN BACSI C ON ISNULL(A.IDBACSI2,A.IDBACSI)=C.IDBACSI
                                                        INNER JOIN BANGGIADICHVU D ON A.DICHVUKCBID=D.IDBANGGIADICHVU    
                                                    WHERE A.IDBENHNHAN=" + idbenhnhan + @"
                                                          AND B.LOAIKHAMID=1
                                                     ORDER BY A.NGAYKHAM DESC                
                                                 ";
            DataTable dtKhamBenh = DataAcess.Connect.GetTable(sqlSectCheckNgayRaToa);
            if (dtKhamBenh != null && dtKhamBenh.Rows.Count > 0)
            {
                DateTime dNgayKham = DateTime.Parse(dtKhamBenh.Rows[0]["NgayKham"].ToString());
                string sSoNgayRaToa = dtKhamBenh.Rows[0]["SoNgayRaToa"].ToString();
                if (sSoNgayRaToa == "") sSoNgayRaToa = "0";
                if (StaticData.IsNumber(sSoNgayRaToa) == false) sSoNgayRaToa = "0";
                if (sSoNgayRaToa != "0")
                {
                    int SoNgayRaToa = int.Parse(sSoNgayRaToa);
                    DateTime dNgayHetThuoc = dNgayKham.AddDays(SoNgayRaToa);
                    dNgayHetThuoc = new DateTime(dNgayHetThuoc.Year, dNgayHetThuoc.Month, dNgayHetThuoc.Day);
                    DateTime CurrentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    if (dNgayHetThuoc > CurrentDate)
                        AlertCheck += "\r\n" + " Chưa đến ngày hết thuốc ( Vào ngày :" + dNgayKham.ToString("dd/MM/yyyy") + ", " + dtKhamBenh.Rows[0]["TENBACSI"].ToString() + " đã cho thuốc trong " + sSoNgayRaToa + " ngày  " + "( Chuyên khoa: " + dtKhamBenh.Rows[0]["CHƯYENKHOA"].ToString() + ", tất nhiên ngày hết thuốc phải là : " + dNgayHetThuoc.ToString("dd/MM/yyyy") + @") )";
                }
                else
                    AlertCheck += "\r\n" + "Vào ngày :" + dNgayKham.ToString("dd/MM/yyyy") + ", " + dtKhamBenh.Rows[0]["TENBACSI"].ToString() + " đã khám chuyên khoa" + dtKhamBenh.Rows[0]["CHƯYENKHOA"].ToString() + "(Khám BHYT) , không có ghi số ngày hết thuốc ,nên hệ thống không thể kiểm tra được";

            }
        }
        #endregion
        Response.Write(AlertCheck);
    }
    //_______________________________________________________________________________________________________
    private void CheckExitsSoBHYT()
    {
        Response.Clear();
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        string sobh1 = Request.QueryString["sobh1"];
        string sobh2 = Request.QueryString["sobh2"];
        string sobh3 = Request.QueryString["sobh3"];
        string sobh4 = FixValue(Request.QueryString["sobh4"]);
        string sobh5 = FixValue(Request.QueryString["sobh5"]);
        string sobh6 = FixValue(Request.QueryString["sobh6"]);
        string sobh7 = FixValue(Request.QueryString["sobh7"]);
        if (sobh1 != null && sobh1 != "" && sobh2 != null && sobh2 != "" && sobh3 != null && sobh3 != "" && ((sobh4 != null && sobh4 != "" && sobh5 != null && sobh5 != "" && sobh6 != null && sobh6 != "") || (sobh7 != null && sobh7 != "")))
        {
            if (sobh6 != null && sobh6 != "" && sobh6 != "null")
            {
                if (sobh6.Length != 5)
                {
                    Response.Write("0|Ô bảo hiểm cuối cùng,chiều dài phải bằng 5");
                    return;
                }
            }
            else
            {
                if (sobh7.Length != 12 && sobh7.Length != 10)
                {
                    Response.Write("0|Ô bảo hiểm cuối cùng,chiều dài phải bằng 10 hoặc 12");
                    return;
                }
            }

            string sqlSelect = @"SELECT A.*,B.TENBENHNHAN,B.NGAYSINH,diachi=ISNULL(B.NOICONGTAC,B.DIACHI)
                                        FROM BENHNHAN_BHYT A 
                                            LEFT JOIN BENHNHAN B ON A.IDBENHNHAN=B.IDBENHNHAN
                                    WHERE 1=1 "
                                                      + " and A.sobh1=N'" + sobh1 + "'"
                                                      + " and A.sobh2=N'" + sobh2 + "'"
                                                      + " and A.sobh3=N'" + sobh3 + "'"
                                                      + " and ISNULL(A.sobh4,'')=N'" + sobh4 + "'"
                                                      + " and ISNULL(A.sobh5,'')=N'" + sobh5 + "'"
                                                      + " and ISNULL(A.sobh6,'')=N'" + sobh6 + "'"
                                                      + " and ISNULL(A.sobh7,'')=N'" + sobh7 + "'"
                                                      ;
            if (idbenhnhan != null && idbenhnhan != "")
                sqlSelect += " AND A.IDBENHNHAN<>" + idbenhnhan;
            DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
            if (dt != null && dt.Rows.Count > 0)
            {
                Response.Write("2|Đã tồn tại bệnh nhân có số bảo hiểm này rồi: (BN:" + dt.Rows[0]["tenbenhnhan"].ToString() + " ,ngày sinh: " + dt.Rows[0]["ngaysinh"].ToString() + "," + dt.Rows[0]["diachi"] + " )" + "|" + dt.Rows[0]["idbenhnhan"].ToString());
                return;
            }
            if (dt == null)
            {
                Response.Write("0|không kiểm tra được tình trạng trùng thể");
                return;
            }
            Response.Write("1");
        }
        else
        {

            Response.Write("1");
        }
    }
    //___________________________________________________________________________________
    private void XoaBenhNhan()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        #region Check Key Off BV
        string sqlCheckHS = "select top 1 ID from HS_BENHNHANBHDONGTIEN where idbenhnhan=" + idbenhnhan + @" and isbhyt=1 and ischeck_all=1";
        DataTable dtHS = DataAcess.Connect.GetTable(sqlCheckHS);
        if (dtHS != null && dtHS.Rows.Count > 0)
        {
            Response.Write("Tồn tại hồ sơ đã kết xuất XML BHYT nên không thể xóa bệnh nhân này được");
            Response.StatusCode = 502;
            return;
        }
        #endregion
     

        string sqlSave = @"
                                    declare @idbenhnhan as bigint
                                    select @idbenhnhan=" + idbenhnhan + @"

                                    delete khambenhcanlamsan where idbenhnhan=@idbenhnhan
                                    delete chitietphieuxuatkho where idkhambenh1 in (select idkhambenh from khambenh where idbenhnhan=@idbenhnhan)
                                    delete phieuxuatkho where idkhambenh1 in (select idkhambenh from khambenh where idbenhnhan=@idbenhnhan)
                                    delete chitietbenhnhantoathuoc where idkhambenh in (select idkhambenh from khambenh where idbenhnhan=@idbenhnhan)
                                    DELETE HS_ToaThuoc_ViewDetail WHERE IdKhamBenh IN (SELECT IdKhamBenh from khambenh where idbenhnhan=@idbenhnhan)
                                    DELETE HS_TOATHUOC_View WHERE IdBenhNhan=@idbenhnhan
                                    delete from khambenh where idbenhnhan=@idbenhnhan
                                    delete chitietdangkykham where iddangkykham in (select iddangkykham from dangkykham where idbenhnhan=@idbenhnhan)
                                    delete from dangkykham where idbenhnhan=@idbenhnhan
                                    delete hs_benhnhanbhdongtien where idbenhnhan=@idbenhnhan 
                                    delete hs_dsdathu where idbenhnhan=@idbenhnhan 
                                    DELETE KhamSucKhoeCatLai  where IdBenhNhan=@idbenhnhan  
                                    DELETE HS_KetQuaSieuAmNoiDung WHERE HS_KetQuaSieuAmNoiDung.KetquaSieuAmChitietID IN (SELECT KetquaSieuAmChitietID FROM HS_KetQuaSieuAmChitiet WHERE KetQuaSieuAmID IN (SELECT KetQuaSieuAmID FROM HS_KetQuaSieuAm WHERE idbenhnhan=@idbenhnhan ))
                                    DELETE HS_KetQuaSieuAmChitiet WHERE KetQuaSieuAmID IN (SELECT KetQuaSieuAmID FROM HS_KetQuaSieuAm WHERE idbenhnhan=@idbenhnhan )
                                    DELETE HS_KetQuaSieuAm WHERE idbenhnhan=@idbenhnhan 
                                    DELETE HS_DANGKYCLS WHERE IDBENHNHAN=@idbenhnhan
                                    DELETE BENHNHAN_BHYT WHERE IDBENHNHAN=@idbenhnhan 
                                    delete benhnhan where idbenhnhan=@idbenhnhan 
                    ";
        bool ok = DataAcess.Connect.ExecSQL(sqlSave);
        if (ok)
            Response.Write("1");
        else Response.Write("0");
    }
    //___________________________________________________________________________________
    private void KhamBenhTheoHen()
    {
        string idbenhnhan = Codec.DecryptAES(Request.QueryString["idbenhnhan"]);
        string sqlSelect = @"
                        select 
                               TOP 1
                            STT=1
                            ,ngayhen_save=convert(varchar,isnull(t.ngayhen,getdate()),111)
                            ,ngaykham_view=convert(varchar,a.ngaykham,103)
                            ,t.idkhambenh
                            ,loaikham.iskhamsuckhoe
                            ,idtaikham=T.idtaikham
                            ,idkhambenh_dathuchien=ISNULL(kb.idkhambenh,0)
                            ,ngaythuchien_view=convert(varchar,kb.ngaykham,103)
                            ,A.*
                               from DBO.khambenh_taikham T
                               left join khambenh a on t.idkhambenh=a.idkhambenh
                              left join bacsi b on isnull(a.idbacsi2,a.idbacsi)=b.idbacsi
                               left join banggiadichvu d ON T.IDCANLAMSAN=D.IDBANGGIADICHVU
                                left join benhnhan bn on a.idbenhnhan=bn.idbenhnhan
                                left join dangkykham dk on a.iddangkykham=dk.iddangkykham
                                left join kb_loaibn loaikham on dk.loaikhamid=loaikham.id
                                left join khamsuckhoecatlai ksk on ksk.iddangkykham=dk.iddangkykham
                                left join khambenh kb on kb.idkhambenh=(SELECT top  1 a0.idkhambenh FROM KHAMBENHCANLAMSAN A0
                                                                                                        INNER JOIN KHAMBENH B0 ON A0.IDKHAMBENH=B0.IDKHAMBENH 
                                                                                                        INNER JOIN BANGGIADICHVU C0 ON A0.IDCANLAMSAN=C0.IDBANGGIADICHVU
                                                                                                WHERE A0.NGAYTHU>=A.NGAYKHAM
                                                                                                            AND A0.IDBENHNHAN=A.IDBENHNHAN
                                                                                                            AND C0.TENNHOM=D.TENNHOM 
                                                                                                            AND ISNULL(B0.IsKhamSucKhoe,0)=0)
                             where a.idbenhnhan=" + idbenhnhan + " ORDER BY T.ngayhen desc";



        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        DataTable dt_prev = dt.Copy();
        dt.DefaultView.RowFilter = "idkhambenh_dathuchien=0";
        dt.DefaultView.Sort = "ngayhen_save,idtaikham";
        dt = dt.DefaultView.ToTable();
        Response.Clear();
        if (dt.Rows.Count == 0)
        {
            if (dt_prev.Rows.Count > 0)
            {
                Response.Write("Ngày " + dt_prev.Rows[dt_prev.Rows.Count - 1]["ngaykham_view"].ToString() + " bác sĩ có hẹn ,nhưng bệnh nhân đã tới vào ngày " + dt_prev.Rows[dt_prev.Rows.Count - 1]["ngaythuchien_view"].ToString());
            }
            else
            {
                Response.Write("Không tồn tại một lịch hẹn nào cả");
            }
            return;
        }
        bool IsKhamSucKhoe = StaticData.IsCheck(dt.Rows[0]["IsKhamSucKhoe"].ToString());

        string idtaikham = dt.Rows[0]["idtaikham"].ToString();
        string LoaiKhamID = Request.QueryString["LoaiKhamID"];
        string IDBENHNHAN_BH = Request.QueryString["IDBENHNHAN_BH"];
        string BranchID = Userlogin_new.IdChiNhanh(this);
        string IdKhoa = "1";
        string DichVuKCBID = dt.Rows[0]["DichVuKCBID"].ToString();
        string IdPhong = dt.Rows[0]["IdPhong"].ToString();
        if (IsKhamSucKhoe)
        {
            IdPhong = "211";
            DichVuKCBID = "1703";
        }

        #region dangkykham
        DataProcess dangkykham = new DataProcess("dangkykham");
        string ngaydangky = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        dangkykham.data("idbenhnhan", idbenhnhan);
        dangkykham.data("IDBENHNHAN_BH", IDBENHNHAN_BH);
        dangkykham.data("ngaydangky", ngaydangky);
        dangkykham.data("LoaiKhamID", LoaiKhamID);
        dangkykham.data("IDKHOADK", IdKhoa);
        dangkykham.data("IdChiNhanh", BranchID);
        bool ok_dangkykham = dangkykham.Insert();
        if (ok_dangkykham == false)
        {
            return;
        }

        #endregion
        string iddangkykham = dangkykham.getData("iddangkykham");
        #region Chi tiết đăng ký khám
        DataProcess chitietdangkykham = new DataProcess("chitietdangkykham");
        chitietdangkykham.data("iddangkykham", iddangkykham);
        chitietdangkykham.data("idbanggiadichvu", DichVuKCBID);
        chitietdangkykham.data("PhongID", IdPhong);
        chitietdangkykham.data("IDKHOA", IdKhoa);
        chitietdangkykham.data("NGAYDANGKY_CHITIET", ngaydangky);
        chitietdangkykham.data("IDBENHNHAN_CHITIET", idbenhnhan);
        bool ok_chitietdangkykham = chitietdangkykham.Insert();
        if (!ok_chitietdangkykham)
        {
            return;
        }
        string idchitietdangkykham = chitietdangkykham.getData("idchitietdangkykham");
        #endregion

        #region Khám bệnh
        DataProcess khambenh = new DataProcess("khambenh");
        khambenh.data("iddangkykham", iddangkykham);
        khambenh.data("idchitietdangkykham", idchitietdangkykham);
        khambenh.data("idbenhnhan", idbenhnhan);
        khambenh.data("IsKhamSucKhoe", "0");
        khambenh.data("ngaykham", ngaydangky);
        khambenh.data("idphongkhambenh", IdKhoa);
        khambenh.data("IdKhoa", IdKhoa);
        khambenh.data("DichVuKCBID", DichVuKCBID);
        khambenh.data("PhongID", IdPhong);
        khambenh.data("IdPhong", IdPhong);
        khambenh.data("trieuchung", dt.Rows[0]["trieuchung"].ToString());
        khambenh.data("benhsu", dt.Rows[0]["benhsu"].ToString());
        khambenh.data("chandoanbandau", dt.Rows[0]["chandoanbandau"].ToString());
        khambenh.data("ketluan", dt.Rows[0]["ketluan"].ToString());
        khambenh.data("ketluan1", dt.Rows[0]["ketluan1"].ToString());
        khambenh.data("ketluan2", dt.Rows[0]["ketluan2"].ToString());
        khambenh.data("huongdieutri", dt.Rows[0]["huongdieutri"].ToString());
        khambenh.data("MoTaCD_edit", dt.Rows[0]["MoTaCD_edit"].ToString());
        khambenh.data("idchandoan", dt.Rows[0]["idchandoan"].ToString());
        khambenh.data("IsHaveCLS", "1");
        khambenh.data("HUONGDIEUTRI", "10");
        khambenh.data("iddieuduong", SysParameter.UserLogin.UserID(this));
        bool ok_khambenh = khambenh.Insert();
        if (!ok_khambenh) return;

        string idkhambenh = khambenh.getData("idkhambenh");
        #endregion

        #region khambenhcanlamsan
        string sqlSelect_DVKT = @"SELECT A.*,ISBHYT=B.IsSuDungChoBH
                                    FROM DBO.khambenh_taikham A INNER JOIN BANGGIADICHVU B ON A.IDCANLAMSAN=B.IDBANGGIADICHVU
                                WHERE idkhambenh=" + dt.Rows[0]["idkhambenh"].ToString();
        DataTable dtDVKT = DataAcess.Connect.GetTable(sqlSelect_DVKT);
        if (dtDVKT == null || dtDVKT.Rows.Count == 0)
            return;
        string sqlSaveKhamBenhCanLamSan = "";
        string MaPhieuCLS = StaticData_HS.MaPhieuCLS_new();
        string NgayThu = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        for (int i = 0; i < dtDVKT.Rows.Count; i++)
        {
            string idcanlamsan = dtDVKT.Rows[i]["idcanlamsan"].ToString();
            string IsBHYT = dtDVKT.Rows[i]["IsBHYT"].ToString();
            if (StaticData.IsCheck(IsBHYT) && LoaiKhamID == "1") IsBHYT = "1";
            else IsBHYT = "0";

            sqlSaveKhamBenhCanLamSan += @"
                                    INSERT INTO KHAMBENHCANLAMSAN(IDBENHNHAN, IDKHAMBENH,IDCANLAMSAN,SOLUONG,NGAYTHU,MaPhieuCLS,DATHU,IsBHYT_SAVE) SELECT IDBENHNHAN=" + idbenhnhan + @", IDKHAMBENH=" + idkhambenh + ",IDCANLAMSAN=" + idcanlamsan + ",SOLUONG=1,NGAYTHU='" + NgayThu + "' ,MaPhieuCLS='" + MaPhieuCLS + "',DATHU=0,IsBHYT_Save=" + IsBHYT;
        }
        bool ok_khambenhcanlamsan = DataAcess.Connect.ExecSQL(sqlSaveKhamBenhCanLamSan);


        #endregion
        #region Chẩn đoán phối hợp
        string sqlSaveChanDoanPhoiHop = @" INSERT INTO CHANDOANPHOIHOP(idkhambenh,idicd,maicd,MoTaCD_edit) SELECT idkhambenh=" + idkhambenh + @",idicd,maicd,MoTaCD_edit from CHANDOANPHOIHOP where idkhambenh=" + dt.Rows[0]["IDKHAMBENH"].ToString();
        bool ok_chandoanphoihop = DataAcess.Connect.ExecSQL(sqlSaveChanDoanPhoiHop);
        #endregion
        StaticData.TinhLaiTien_ByIdDangKyKham(iddangkykham);
        Response.Write("1;" + idkhambenh);


    }
    //___________________________________________________________________________________
    private void GetLastIdKhamBenh()
    {
        string sqlSelect = @"
                                SELECT TOP 1 B.IDCHITIETDANGKYKHAM,A.IDDANGKYKHAM
		                                ,IDKHAMBENH=(SELECT TOP 1 IDKHAMBENH FROM KHAMBENH WHERE IDDANGKYKHAM=A.IDDANGKYKHAM AND IDCHITIETDANGKYKHAM=B.IDCHITIETDANGKYKHAM ORDER BY IDKHAMBENH DESC)
                                        ,LOAIKHAMID=A.LOAIKHAMID
                                FROM DANGKYKHAM A
                                INNER JOIN CHITIETDANGKYKHAM B ON A.IDDANGKYKHAM=B.IDDANGKYKHAM
                                WHERE A.IDBENHNHAN=" + Codec.DecryptAES(Request.QueryString["idbenhnhan"]) + @"
                                ORDER BY A.NGAYDANGKY DESC,A.IDDANGKYKHAM DESC";
        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        Response.Clear();
        if (dt == null || dt.Rows.Count == 0) return;
        string s = dt.Rows[0]["IDCHITIETDANGKYKHAM"].ToString() + "|" + dt.Rows[0]["IDDANGKYKHAM"].ToString() + "|" + dt.Rows[0]["IDKHAMBENH"].ToString() + "|" + dt.Rows[0]["LOAIKHAMID"].ToString();
        Response.Write(s);
    }
    //___________________________________________________________________________________
    private void ShowDetail_DangKyKham(string iddangkykham)
    {
        string IsAuto = Request.QueryString["IsAuto"];
        string html = "";
        html += "<root>";


        string sqlDangKyKham = @"SELECT      loai=a.loaikhamid
		                                    ,idphongkhambenh=" + (IsAuto == "1" ? " null " : "b.phongid") + @"
		                                    ,KhongThuPhi=a.KhongThuPhi
		                                    ,isNotThuPhiCapCuu=B.isNotThuPhiCapCuu
		                                    ,IsNguoiNuocNgoai=A.IsNguoiNuocNgoai
		                                    ,IsMienDongChiTra=A.IsMienDongChiTra
		                                    ,ngaybdmiendct=f.ngaybdmiendct
                                            ,ngaydu_5namlientuc=f.ngaydu_5namlientuc
                                            ,IsThongTuyen=IsNull(A.ThongTuyen,0)
                                            ,IsCapCuu=IsNull(A.iscapcuudk,F.IsCapCuu)
                                            ,dungtuyen=F.dungtuyen
                                            ,MA_KHUVUC=f.MA_KHUVUC
		                                    ,IdCapBac=(CASE WHEN ISNULL(C.EMPL_ID,0)<>0 THEN C.IDCAPBAC ELSE   A.IdCapBac  END)
		                                    ,idcongty=D.idcongty
                                            ,idcongty_view=d.idcongty
		                                    ,mkv_idcongty=D.TENCTY
		                                    ,DangDieuTriTimMach=E.DangDieuTriTimMach
		                                    ,ngaydangky_edit=CONVERT(NVARCHAR,A.NGAYDANGKY,103)
                                            ,giodangky_edit=left(CONVERT(NVARCHAR,A.NGAYDANGKY,108),2)
                                            ,phutdangky_edit=right(left(CONVERT(NVARCHAR,A.NGAYDANGKY,108),5),2)
                                            ,iddangkykhambn=A.iddangkykham
                                            ,E.huyetap1
                                            ,E.huyetap2
                                            ,E.mach
                                            ,E.nhietdo
                                            ,E.chieucao
                                            ,E.cannang
                                            ,E.BMI
                                            ,E.glucose
                                            ,E.idsinhhieu
                                            ,IdNoiDangKyBH=F.IdNoiDangKyBH
                                            ,mvk_MADANGKY=G.MADANGKY
                                            ,mkv_TENNOIDANGKY=G.TENNOIDANGKY
                                            ,idNoiGioiThieu=F.IdNoiGioiThieu
                                            ,mkv_ma_noigioithieu=H.MADANGKY
                                            ,mkv_idNoiGioiThieu=H.TENNOIDANGKY  
                                            ,tilebhyt=ISNULL(F.tilebhyt,DBO.hs_Get_Muc_Huong(F.IDBENHNHAN_BH,A.NGAYDANGKY,NULL,NULL,NULL,NULL))     
                                            ,F.*
		                                    ,mkv_idchucvu=I.TENCHUCVU
                                            ,NgayTinhBH_Thuc=CONVERT(VARCHAR, isnull( isnull(HS.NgayTinhBH_Thuc,HS.NgayTinhBH),a.ngaydangky),111)
                                            ,HS.ISCHECK_ALL
                                            ,a.No_Send_Message
                                            ,a.idloaiuutien
                                            ,HS.ISCHECK_ALL
                                     FROM DANGKYKHAM a
                                     left join chitietdangkykham b on a.iddangkykham=b.iddangkykham
                                     LEFT JOIN BENHNHAN C ON A.IDBENHNHAN=C.IDBENHNHAN
                                     LEFT JOIN KB_CONGTY D ON  ISNULL(A.IDCONGTY,C.IDCONGTY)=D.IDCONGTY
                                     LEFT JOIN SINHHIEU E ON E.IDSINHHIEU=(SELECT TOP 1 IDSINHHIEU FROM SINHHIEU SH0 WHERE SH0.IDDANGKYKHAM=A.IDDANGKYKHAM AND SH0.HUYETAP1 IS NOT NULL ORDER BY IDSINHHIEU DESC)
                                     LEFT JOIN BENHNHAN_BHYT F ON A.IDBENHNHAN_BH=F.IDBENHNHAN_BH
                                     LEFT JOIN KB_NOIDANGKYKB G ON F.IdNoiDangKyBH=G.IDNOIDANGKY
                                     LEFT JOIN KB_NOIDANGKYKB H ON F.IdNoiGioiThieu=H.IDNOIDANGKY
                                      LEFT JOIN CHUCVU I ON  ISNULL(A.IDCHUCVU,C.IDCHUCVU)=I.IDCHUCVU 
                                    LEFT JOIN HS_BENHNHANBHDONGTIEN HS ON A.IDBENHBHDONGTIEN=HS.ID  
                                     WHERE a.IDDANGKYKHAM= " + iddangkykham;

        DataTable dtDangKyKham = DataAcess.Connect.GetTable(sqlDangKyKham);
        for (int y = 0; y < dtDangKyKham.Columns.Count; y++)
        {
            try
            {
                if (dtDangKyKham.Columns[y].ColumnName.ToLower() != "traituyen" && dtDangKyKham.Columns[y].ColumnName.ToLower() != "dungtuyen")
                {
                    if (dtDangKyKham.Columns[y].DataType.ToString().IndexOf("DateTime") != -1)
                        html += "<data id='" + dtDangKyKham.Columns[y].ToString() + "'>" + DateTime.Parse(dtDangKyKham.Rows[0][y].ToString()).ToString("dd/MM/yyyy") + "</data>";
                    else
                        html += "<data id='" + dtDangKyKham.Columns[y].ToString() + "'>" + dtDangKyKham.Rows[0][y].ToString() + "</data>";
                }
            }
            catch (Exception)
            {
                html += "<data id='" + dtDangKyKham.Columns[y].ToString() + "'>" + dtDangKyKham.Rows[0][y].ToString() + "</data>";
            }
            html += "<data id=\"TraiTuyen\">" + (dtDangKyKham.Rows[0]["DungTuyen"].ToString().ToUpper() == "Y" ? "False" : "True") + "</data>";
            html += "<data id=\"dungtuyen\">" + (dtDangKyKham.Rows[0]["DungTuyen"].ToString().ToUpper() == "Y" ? "True" : "False") + "</data>";
            html += Environment.NewLine;
        }

        html += "</root>";
        Response.Clear();
        Response.Write(html);
    }
    //___________________________________________________________________________________
    private void View_DangKyKham()
    {
        string iddangkykham = Request.QueryString["iddangkykham"];
        this.ShowDetail_DangKyKham(iddangkykham);
    }
    //___________________________________________________________________________________
    private void Xoadangkykham()
    {
        try
        {
            DataProcess process = new DataProcess("dangkykham");
            string IdDangKyKham = process.getData("iddangkykham");
            DataTable dtPhong = DataAcess.Connect.GetTable(@"
                                                                select MaSo_Phong=b.MaSo from chitietdangkykham a
                                                                inner join kb_phong b on a.phongid=b.id
                                                                where a.iddangkykham=" + IdDangKyKham + @"
                                                                ");

            #region Kiểm tra xem có khoá dữ liệu trong khoảng thời gian đăng ký hay không
            string sqlDangkyKham_old = "SELECT TOP 1 * FROM DANGKYKHAM WHERE IDDANGKYKHAM=" + IdDangKyKham;
            DataTable dtDangkykham_old = DataAcess.Connect.GetTable(sqlDangkyKham_old);
            string LoaiKhamID_ = dtDangkykham_old.Rows[0]["LoaiKhamID"].ToString();
            string ngaydangky_save = DateTime.Parse(dtDangkykham_old.Rows[0]["ngaydangky"].ToString()).ToString("yyyy/MM/dd") + "";
            DataTable dtKhoaSoLieu = StaticData.dt_HS_KhoaDuLieu;
            int n_temp = StaticData.int_Search(dtKhoaSoLieu, "LoaiKhamID=" + LoaiKhamID_ + " and '" + ngaydangky_save + "'>=TUNGAY AND '" + ngaydangky_save + "'<=DENNGAY");
            if (n_temp != -1)
            {
                Response.Clear();
                Response.Write("Đã khoá số liệu trong khoảng thời gian: " + (dtKhoaSoLieu.Rows[n_temp]["tungay"].ToString() != "" ? DateTime.Parse(dtKhoaSoLieu.Rows[n_temp]["tungay"].ToString()).ToString("dd/MM/yyyy") : "") + " đến ngày: " + (dtKhoaSoLieu.Rows[n_temp]["denngay"].ToString() != "" ? DateTime.Parse(dtKhoaSoLieu.Rows[n_temp]["denngay"].ToString()).ToString("dd/MM/yyyy") : ""));
                return;
            }
            #endregion
            #region Check Key Off BV
            string sqlCheckHS = @"
                                select top 1 ID=A.ID from HS_BENHNHANBHDONGTIEN A
                                INNER JOIN DANGKYKHAM B ON A.ID=B.IDBENHBHDONGTIEN
                                 where A.isbhyt=1 and A.ischeck_all=1 AND B.IDDANGKYKHAM="+IdDangKyKham+@"
                                ";
            DataTable dtHS = DataAcess.Connect.GetTable(sqlCheckHS);
            if (dtHS != null && dtHS.Rows.Count > 0)
            {
                Response.Write("Hồ sơ đã kết xuất XML BHYT nên không thể xóa đăng ký khám này được");
                return;
            }
            #endregion


            string sqlSelect2 = "SELECT COUNT(*) FROM CHITIETDANGKYKHAM WHERE  IDDANGKYKHAM=" + IdDangKyKham + " AND EXISTS  (SELECT TOP 1 1 FROM KHAMBENH WHERE IDCHITIETDANGKYKHAM =CHITIETDANGKYKHAM.IDCHITIETDANGKYKHAM)   ";
            DataTable dtTest2 = DataAcess.Connect.GetTable(sqlSelect2);
            if (dtTest2 != null && dtTest2.Rows.Count != 0 && dtTest2.Rows[0][0].ToString() != "0")
            {
                Response.Clear();
                Response.Write("Đã tồn tại một chuyên khoa đã khám nên không xóa toàn bộ phiếu đăng ký được");
                return;
            }
            sqlSelect2 = "SELECT 1 FROM DANGKYKHAM A INNER JOIN HS_BENHNHANBHDONGTIEN B ON A.IDBENHBHDONGTIEN=B.ID INNER JOIN HS_DSDATHU C ON B.ID=C.IdBenhNhanBHDongTien WHERE ISNULL(C.IsDaHuy,0)=0 AND A.IDDANGKYKHAM=" + IdDangKyKham;

            dtTest2 = DataAcess.Connect.GetTable(sqlSelect2);
            if (dtTest2 != null && dtTest2.Rows.Count != 0 && dtTest2.Rows[0][0].ToString() != "0")
            {
                Response.Clear();
                Response.Write("Đã tồn tại phiếu thu , vui lòng hủy phiếu thu trước");
                return;
            }

            string Prev_IdDangKyKham = null;
            string sqlSelectIdBenhBHDongTien = @"SELECT IDBENHBHDONGTIEN FROM DANGKYKHAM WHERE IDDANGKYKHAM=" + IdDangKyKham;
            string idbenhbhdongtien = null;
            DataTable dtBenhBHDongTien = DataAcess.Connect.GetTable(sqlSelectIdBenhBHDongTien);
            if (dtBenhBHDongTien != null && dtBenhBHDongTien.Rows.Count > 0)
            {
                idbenhbhdongtien = dtBenhBHDongTien.Rows[0][0].ToString();
                string sqlGetPrevIdDangKyKham = @"SELECT IDDANGKYKHAM FROM DANGKYKHAM WHERE IDBENHBHDONGTIEN=" + idbenhbhdongtien + " AND IDDANGKYKHAM<>" + IdDangKyKham;
                DataTable dtDangKyKhamOther = DataAcess.Connect.GetTable(sqlGetPrevIdDangKyKham);
                if (dtDangKyKhamOther != null && dtDangKyKhamOther.Rows.Count > 0)
                {
                    Prev_IdDangKyKham = dtDangKyKhamOther.Rows[0][0].ToString();
                }
            }
            bool ok_deleteChitiet = DataAcess.Connect.ExecSQL(@"DELETE  from chitietdangkykham where iddangkykham=" + IdDangKyKham + @"
                                                                DELETE  from chitietdangkykham_HS where iddangkykham=" + IdDangKyKham
                                                              );

            string LoaiKhamID = process.getData("LoaiKhamID");
            if (LoaiKhamID == null || LoaiKhamID == "") LoaiKhamID = "NULL";
            if (LoaiKhamID != "2")
            {
                string sqlSave = " EXEC zHS_DeleteDangKyKham  " + IdDangKyKham + "," + LoaiKhamID;
                bool ok2 = DataAcess.Connect.ExecSQL(sqlSave);
            }



            bool ok = process.Delete();
            if (ok)
            {
                if (Prev_IdDangKyKham != null && Prev_IdDangKyKham != "")
                    StaticData.TinhLaiTien_ByIdDangKyKham(Prev_IdDangKyKham);
                else if (idbenhbhdongtien != null && idbenhbhdongtien != "")
                {
                    string sqlDeleteHoSo = @"
                                    DELETE HS_BENHNHANBHDONGTIEN WHERE ID=" + idbenhbhdongtien;
                    bool OK_DeleteHoSo = DataAcess.Connect.ExecSQL(sqlDeleteHoSo);

                }
                #region Xóa 1 dòng trong Thứ tự phòng khám
                MobileApp.Delete_SoThuThu_Phong(MobileApp.get_nguoi_benh_id_from_idbenhnhan(dtDangkykham_old.Rows[0]["idbenhnhan"].ToString()), dtPhong.Rows[0]["MaSo_Phong"].ToString(), ngaydangky_save);
                #endregion
                Response.Clear(); Response.Write("1");
                return;
            }
        }
        catch
        {
        }
        Response.StatusCode = 500;
    }
    //_______________________________________________________________________________________________________
    private void ViewTinhTrangPhong()
    {
        string sqlSelect = @"
                                SELECT A.ID,A.TENPHONG
	                                  ,SLBNCHO=(
				                                SELECT COUNT(1)
					                                FROM CHITIETDANGKYKHAM A0
					                                INNER JOIN DANGKYKHAM B0 ON A0.IDDANGKYKHAM=B0.IDDANGKYKHAM
					                                WHERE A0.PHONGID=A.ID
					                                AND YEAR(B0.NGAYDANGKY)=YEAR(GETDATE())
					                                AND MONTH (B0.NGAYDANGKY)=MONTH(GETDATE())
					                                AND DAY(B0.NGAYDANGKY)=DAY(GETDATE())
					                                AND ISNULL(A0.DAKHAM,0)=0
		                                )
		                                ,SLBNDAKHAM=(
				                                SELECT COUNT(1)
					                                FROM CHITIETDANGKYKHAM A0
					                                INNER JOIN DANGKYKHAM B0 ON A0.IDDANGKYKHAM=B0.IDDANGKYKHAM
					                                WHERE A0.PHONGID=A.ID
					                                AND YEAR(B0.NGAYDANGKY)=YEAR(GETDATE())
					                                AND MONTH (B0.NGAYDANGKY)=MONTH(GETDATE())
					                                AND DAY(B0.NGAYDANGKY)=DAY(GETDATE())
					                                AND ISNULL(A0.DAKHAM,0)=1
		                                )
                                FROM KB_PHONG A
                                WHERE ISNULL(A.STATUS,1)=1
                                AND A.IDPHONGKHAMBENH=" + Request.QueryString["idkhoa"] + @"
                                AND ISNULL(A.ISKHAMSUCKHOE,0)=0
                                AND ISNULL(A.ISACTIVE,1)=1
                                AND ISNULL(A.ISPHONGNOITRU,0)=0
                                ORDER BY A.SOTT,A.TENPHONG
";
        DataTable dt = DataAcess.Connect.GetTable(sqlSelect);
        if (dt == null) return;
        dt.DefaultView.Sort = "SLBNCHO";
        dt = dt.DefaultView.ToTable();

        string html = "";
        html += "<table class='jtable' id=\"gridTable_ListTinhTrangPhong\">";
        html += "<tr>";
        html += "<th>Tên phòng</th>";
        html += "<th>SL BN chờ</th>";
        html += "<th>SL BN đã khám</th>";
        html += "<th></th>";
        html += "</tr>";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            html += @"<tr>
                            <td style='text-align:left' > " + dt.Rows[i]["TENPHONG"].ToString() + @" </td>
                             <td > " + dt.Rows[i]["SLBNCHO"].ToString() + @" </td>
                             <td > " + dt.Rows[i]["SLBNDAKHAM"].ToString() + @" </td>
                             <td > <a style='text-decoration:underline;color:Blue' onclick='ChonPhong(" + dt.Rows[i]["ID"].ToString() + ")'> Chọn </a> </td>" + @"
                        </tr>
                        ";
        }
        html += "</table>";
        Response.Write(html);

    }
    //_______________________________________________________________________________________________________
    void check_EmplCode()
    {
        Response.Clear();
        string EmplCode = Request.QueryString["EmplCode"];
        if (1 == 2)
        {
            #region lấy từ Webservice
            HttpWebRequest RQ = (HttpWebRequest)HttpWebRequest.Create(@"http://172.16.31.40:8081/HrmBusinesscv.asmx/HRM0602");
            RQ.Headers.Add("EmplCode", EmplCode);
            RQ.ContentType = "xml; charset=UTF-8";

            HttpWebResponse RP = (HttpWebResponse)RQ.GetResponse();
            XmlTextReader reader = new XmlTextReader(RP.GetResponseStream());
            System.Data.DataSet ds = new System.Data.DataSet();
            ds.ReadXml(reader);
            DataTable dt = ds.Tables[ds.Tables.Count - 1];

            if (dt == null || dt.Rows.Count == 0)
            {
                Response.Write("");
                return;
            }

            string[] arrColumn = new string[]{
                                            "id",
                                            "EMPLOYEE_CODE",
                                            "NAME_VN",
                                            "NAME_EN",
                                            "EMAIL",
                                            "BIRTH_DATE",
                                            "NGAY_VAO_CANG",
                                            "NGAY_CHUYEN_DVI",
                                            "TITLE_ID",
                                            "TITLE_JOB_ID",
                                            "ORG_ID",
                                            "LEADOBJ_ID",
                                            "ID_BIENCHE",
                                            "ID_QUANHAM",
                                            "TER_EFFECT_DATE",
                                            "GENDER",
                                            "WORK_STATUS",
                                            "REMARK",
                                            "JOIN_DATE_STATE"
                                        };
            #region fix data ngày tháng năm
            int i = 0;

            for (int j = 0; j < arrColumn.Length; j++)
            {
                string svalue = dt.Rows[i][arrColumn[j]].ToString();
                if (arrColumn[j] == "BIRTH_DATE"
                    || arrColumn[j] == "NGAY_VAO_CANG"
                    || arrColumn[j] == "NGAY_CHUYEN_DVI"
                    || arrColumn[j] == "JOIN_DATE_STATE"
                    )
                {
                    if (svalue != "" && svalue.IndexOf("/") != -1)
                    {
                        string[] tempDate = svalue.Split('/');
                        if (tempDate.Length >= 3)
                        {
                            svalue = tempDate[2].Substring(0, 4) + "/" + tempDate[0] + "/" + tempDate[1];
                            dt.Rows[i][arrColumn[j]] = svalue;
                        }
                    }
                }
            }
            #endregion
            for (int j = 0; i < arrColumn.Length; j++)
            {
                Response.Write(dt.Rows[0][arrColumn[j]].ToString() + "|");
            }
            #endregion
        }
        else
        {
            #region lấy từ database HRM
            string sqlSelectData = @"
                          SELECT 
	                                 EMPL_ID=A.ID
	                                ,EMPL_NAME=A.NAME_VN
	                                ,EMPL_NGAYSINH=A.BIRTH_DATE
	                                ,EMPL_GIOITINH=A.GENDER
	                                ,EMPL_EMAIL=A.EMAIL

	                                ,CODE_QUANHAM=B.CODE
	                                ,TEN_QUANHAM=B.NAME_VN
	                                ,ID_QUANHAM=G.IdCapBac

	                                ,CODE_BIENCHE=C.CODE
	                                ,TEN_BIENCHE=C.NAME_VN
	                                ,ID_BIENCHE= A.ID_BIENCHE
	
	                                ,CODE_DONVI=ISNULL(D0.CODE,D.CODE)
	                                ,TEN_DONVI=ISNULL(D0.NAME_VN,D.NAME_VN)
	                                ,ID_DONVI=H.idcongty
	
	                                ,CODE_CHUCDANH=E.CODE
	                                ,NAME_CHUCDANH=E.NAME_VN
	                                ,ID_CHUCDANH=E.ID
	
	                                ,CODE_CHUCVU=F.CODE
	                                ,NAME_CHUCVU=F.NAME_VN
	                                ,ID_CHUCVU=F.ID
                                    ,IDBENHNHAN=I.IDBENHNHAN
	
                                 FROM NHANVIEN_TB A
                                LEFT JOIN QUANHAM_TB B ON A.ID_QUANHAM=B.ID
                                LEFT JOIN BIENCHE_TB C ON A.ID_BIENCHE=C.ID
                                LEFT JOIN SODOTOCHUC_TB D ON A.ORG_ID=D.ID
                                LEFT JOIN SODOTOCHUC_TB D0 ON D0.ID=D.PARENT_ID
                                LEFT JOIN CHUCDANH_TB E ON A.TITLE_JOB_ID=E.ID
                                LEFT JOIN CHUCVU_TB F ON A.TITLE_ID=F.ID
                                LEFT JOIN CapBacQuanNhan G ON B.ID=G.IdQuanHam_HRM
                                LEFT JOIN KB_CONGTY H ON ISNULL(D0.ID, D.ID)=H.IdDonVi_HRM
                                LEFT JOIN BENHNHAN I ON I.EMPL_ID=A.ID
                                WHERE A.EMPLOYEE_CODE=N'" + EmplCode + @"'";
            DataTable dtData = DataAcess.Connect.GetTable(sqlSelectData);
            if (dtData == null || dtData.Rows.Count == 0) return;
            for (int j = 0; j < dtData.Columns.Count; j++)
            {
                string svalue = dtData.Rows[0][j].ToString();
                if (dtData.Columns[j].ColumnName == "EMPL_NGAYSINH")
                {
                    if (svalue != "" && svalue.IndexOf("/") != -1)
                    {
                        string[] tempDate = svalue.Split('/');
                        if (tempDate.Length >= 3)
                            svalue = (tempDate[2].Trim().Length == 1 ? "0" : "") + tempDate[2].Trim() + "/" + (tempDate[1].Trim().Length == 1 ? "0" : "") + tempDate[1].Trim() + "/" + tempDate[0];
                    }
                }

                Response.Write(svalue + "|");
            }
            #endregion

        }

    }
    //_______________________________________________________________________________________________________
    void RestPassBN()
    {
        Response.Clear();
        string idbenhnhan = Request.QueryString["idbenhnhan"];
        string username = Request.QueryString["username"];
        if (idbenhnhan.Length > 20) idbenhnhan = Codec.DecryptAES(idbenhnhan);
        username = username.ToLower();
        string Pass = HashPassWord.sGetHashPass(username, username);

        string Erro = "";
        bool IsCheck = this.CheckUserName(username, idbenhnhan, ref Erro);
        if (!IsCheck)
        {
            Response.Write(Erro);
            return;
        }

        string sqlUpdate = @"UpDate BenhNhan set matkhau=N'" + Pass + "',UserName=N'" + username + "' where idbenhnhan=" + idbenhnhan;
        bool ok = DataAcess.Connect.ExecSQL(sqlUpdate);
        if (ok == false)
        {
            Response.Write("Không Reset được mật khẩu");
            return;
        }
        Response.Write("1");
    }
    //_______________________________________________________________________________________________________
    private bool CheckUserName(string UserName, string idbenhnhan, ref string Erro)
    {
        string sqlCheckOther = "SELECT * FROM BENHNHAN WHERE UserName=N'" + UserName + "'";
        if (idbenhnhan != null && idbenhnhan != "") sqlCheckOther += @" and idbenhnhan<>" + idbenhnhan;
        DataTable dtCheck = DataAcess.Connect.GetTable(sqlCheckOther);
        if (dtCheck != null && dtCheck.Rows.Count > 0)
        {
            Erro = "Đã tồn tại bệnh nhân khác có tên :" + dtCheck.Rows[0]["tenbenhnhan"].ToString() + ", Mã BN:" + dtCheck.Rows[0]["mabenhnhan"].ToString() + " trùng tài khoản nói trên";
            return false;
        }
        Erro = null;
        return true;
    }
    //_______________________________________________________________________________________________________
    private void CheckUserNameAjax()
    {
        Response.Clear();
        string idbenhnhan = Request.QueryString["idbenhnhan"];
        string username = Request.QueryString["username"];
        if (idbenhnhan.Length > 20) idbenhnhan = Codec.DecryptAES(idbenhnhan);
        if (username == "" || username.Trim() == "")
        {
            Response.Write("1");
        }
        username = username.ToLower();
        string Erro = "";
        bool IsCheck = this.CheckUserName(username, idbenhnhan, ref Erro);
        if (!IsCheck)
        {
            Response.Write(Erro);
            return;
        }
    }
    //_______________________________________________________________________________________________________
    private void SendMessage_Just_DangKyKhamBenh()
    {
        string iddangkykham = Request.QueryString["iddangkykham"];
        if (iddangkykham.Length > 10) iddangkykham = Codec.DecryptAES(iddangkykham);
        MobileApp.SendMessage_Just_DangKyKhamBenh(iddangkykham);
    }
    //_______________________________________________________________________________________________________
}//end class


