using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Đồ_án_cuối_kì
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DateTime start, end;
            //TimeSpan space;
            //do
            //{
            //    start = DateTime.Now;
            //    do
            //    {
            //        end = DateTime.Now;
            //        space = end.Subtract(start);
            //    } while (space.Minutes < 1);
            //    if (MessageBox.Show("sdfsfds", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //        Application.Exit();
            //} while (TSMTroll.Checked == true);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "sin(";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "cos(";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "tan(";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "7";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "8";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "9";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnMoNgoac_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "(";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnDongNgoac_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += ")";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "4";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "5";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "6";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            if (txtOutput.Text == "")
                txtInput.Text = "Ans";
            txtInput.Text += "x";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            if (txtOutput.Text == "")
                txtInput.Text = "Ans";
            txtInput.Text += "/";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "1";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "2";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "3";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            if (txtOutput.Text == "")
                txtInput.Text = "Ans";
            txtInput.Text += "+";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            if (txtOutput.Text == "")
                txtInput.Text = "Ans";
            txtInput.Text += "-";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "0";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += ".";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnNhan10_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "x10";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text != "" && txtOutput.Text != " ")
            {
                txtInput.Text = "";
                txtOutput.Text = "";
            }
            txtInput.Text += "Ans";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //xử lý Copy = Ctrl + C ; Paste = Ctrl + V ; Select All = Ctrl + A
            if (e.Control && e.KeyCode == Keys.C)
                TSMCopy.PerformClick();
            else
                if (e.Control && e.KeyCode == Keys.V)
                    TSMPaste.PerformClick();
                else
                    if (e.Control && e.KeyCode == Keys.A)
                        TSMSelectAll.PerformClick();
                    else
                        //Thiết lập nhấn phím + và * - xử lý riêng vì phải ấn Shift
                        if (e.Shift && e.KeyCode == Keys.D8)
                            btnNhan.PerformClick();
                        else
                            if (e.Shift && e.KeyCode == Keys.Oemplus)
                                btnCong.PerformClick();
                            else
                                if (e.Shift && e.KeyCode == Keys.D9)
                                    btnMoNgoac.PerformClick();
                                else
                                    if (e.Shift && e.KeyCode == Keys.D0)
                                        btnDongNgoac.PerformClick();
                                    else
                                        switch (e.KeyCode)
                                        {
                                            //0-9
                                            case Keys.D0:
                                                { btn0.PerformClick(); }
                                                break;
                                            case Keys.D1:
                                                { btn1.PerformClick(); }
                                                break;
                                            case Keys.D2:
                                                { btn2.PerformClick(); }
                                                break;
                                            case Keys.D3:
                                                { btn3.PerformClick(); }
                                                break;
                                            case Keys.D4:
                                                { btn4.PerformClick(); }
                                                break;
                                            case Keys.D5:
                                                { btn5.PerformClick(); }
                                                break;
                                            case Keys.D6:
                                                { btn6.PerformClick(); }
                                                break;
                                            case Keys.D7:
                                                { btn7.PerformClick(); }
                                                break;
                                            case Keys.D8:
                                                { btn8.PerformClick(); }
                                                break;
                                            case Keys.D9:
                                                { btn9.PerformClick(); }
                                                break;
                                            //sin-cos-tan
                                            case Keys.S:
                                                { btnSin.PerformClick(); }
                                                break;
                                            case Keys.C:
                                                { btnCos.PerformClick(); }
                                                break;
                                            case Keys.T:
                                                { btnTan.PerformClick(); }
                                                break;
                                            //dấu -
                                            case Keys.OemMinus:
                                                { btnTru.PerformClick(); }
                                                break;
                                            //dấu /
                                            case Keys.OemQuestion:
                                                { btnChia.PerformClick(); }
                                                break;
                                            //x10
                                            case Keys.X:
                                                { btnNhan10.PerformClick(); }
                                                break;
                                            //dấu .
                                            case Keys.OemPeriod:
                                                { btnCham.PerformClick(); }
                                                break;
                                            //Ans
                                            case Keys.A:
                                                { btnAns.PerformClick(); }
                                                break;
                                            //Delete = AC
                                            case Keys.Delete:
                                                { btnAC.PerformClick(); }
                                                break;
                                            //Backspace = DEL
                                            case Keys.Back:
                                                { btnDEL.PerformClick(); }
                                                break;
                                        }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = " ";
            this.ActiveControl = this.btnBang;
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            //nếu không có phần tử nào thì return
            if (txtInput.Text.Length == 0)
                return;
            //xử lí xóa các toán tử sin( - cos( - tan( - x10 - Ans
            if (txtInput.Text.Length >= 3)
                if (string.Compare(txtInput.Text.Substring(txtInput.Text.Length - 3), "x10", true) == 0
                    ||
                    string.Compare(txtInput.Text.Substring(txtInput.Text.Length - 3), "Ans", true) == 0)
                {
                    txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 3);
                    return;
                }
            if (txtInput.Text.Length >= 4)
                if (string.Compare(txtInput.Text.Substring(txtInput.Text.Length - 4), "sin(", true) == 0
                    ||
                    string.Compare(txtInput.Text.Substring(txtInput.Text.Length - 4), "cos(", true) == 0
                    ||
                    string.Compare(txtInput.Text.Substring(txtInput.Text.Length - 4), "tan(", true) == 0)
                {
                    txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 4);
                    return;
                }
            //xử lí xóa cho các toán tử và toán hạng còn lại
            txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1);
        }

        /*******************************************************/
        //tách toán tử và toán hạng
        string Ans = "0";
        //set thứ tự ưu tiên cho các toán tử
        int getPriority(char ope)
        {
            if (ope == 's' || ope == 'c' || ope == 't' || ope == 'a') return 3;
            else if (ope == 'x' || ope == '/') return 2;
            else if (ope == '+' || ope == '-') return 1;
            else return 0;
        }
        //kiểm tra xem là toán tử, toán hạng hay dấu ngoặc
        int isOperator(char ope)
        {
            if (getPriority(ope) == 0) //không phải toán tử
            {
                if (ope != '(' && ope != ')') return 0; //là toán hạng
                else return 1; //là ngoặc
            }
            return 2; //là toán tử
        }
        //Chuyển biểu thức sang hậu tố - kí pháp ba lan
        string ConvertToPostfix(string exp)
        {
            string Stack = "";
            string Result = "";
            // Do có những toán hạng lớn hơn 10, hoặc số thập phân => Có nhiều hơn 1 ký tự
            // Ta cần phải add toàn bộ các kí tự số đó vào chuỗi number
            string number = "";
            for (int i = 0; i < exp.Length; i++)
            {
                char s = exp[i];
                if (isOperator(s) == 0) number += s;
                else
                {
                    // Push toán hạng vào Result
                    if (number.Length > 0)
                    {
                        Result += number + " ";
                        number = "";
                    }
                    if (isOperator(s) == 1) //1. Là ngoặc
                    {
                        if (s == '(') Stack += '(';
                        else if (s == ')')
                        {
                            char pop = Stack[Stack.Length - 1]; //gán pop bằng kí tự cuối trong Stack
                            while (pop != '(')
                            {
                                Result += pop + " ";
                                Stack = Stack.Remove(Stack.Length - 1);
                                pop = Stack[Stack.Length - 1];
                            }
                            //pop kí tự "(" ra khỏi Stack
                            Stack = Stack.Remove(Stack.Length - 1);
                        }
                    }
                    else //là toán tử
                    {
                        //xét thứ tự ưu tiên cho toán tử
                        while (!(Stack == "") && getPriority(Stack[Stack.Length - 1]) >= getPriority(s))
                        {
                            Result += Stack[Stack.Length - 1] + " ";
                            Stack = Stack.Remove(Stack.Length - 1);
                        }
                        Stack += s;
                    }
                }
            }
            // Trường hợp còn sót lại toán hạng cuối cùng
            if (number.Length > 0)
            {
                Result += number + " ";
                number = "";
            }
            while (!(Stack == ""))
            {
                Result += Stack[Stack.Length - 1] + " "; //push toàn bộ Stack vào Result
                Stack = Stack.Remove(Stack.Length - 1);
            }
            Result = Result.Remove(Result.Length - 1); //xóa khoảng trắng cuối cùng
            return Result;
        }
        /*******************************************************/
        public class bignum
        {
            public int dau = 1;
            public int cham;
            public string nguyen, tphan;
            //đọc bignum - chuyển từ string sang bignum
            public void getBigNum(string s)
            {
                if (s[0] == '-')
                {
                    this.dau = 0;
                    s = s.Remove(0, 1);
                }
                else
                    this.dau = 1;
                this.cham = s.IndexOf('.');
                if (cham != -1)
                {
                    this.nguyen = s.Substring(0, cham);
                    this.tphan = s.Substring(cham + 1);
                }
                else
                {
                    this.nguyen = s;
                    this.cham = this.nguyen.Length;
                    this.tphan = "0";
                }
                xoaSo0_dau(ref this.nguyen);    //chuẩn hóa bignum: xóa số 0 đầu và cuối
                xoaSo0(ref this.tphan);
                this.cham = this.nguyen.Length;
            }
            //bignum to String
            public override string ToString()
            {
                if (this.dau == -1)
                    return "Math ERROR";
                else
                    if (this.tphan == "0")
                        if (this.dau == 0)
                            return "-" + this.nguyen;
                        else
                            return this.nguyen;
                    else
                        if (this.dau == 0)
                            return "-" + this.nguyen + "." + this.tphan;
                        else
                            return this.nguyen + "." + this.tphan;
            }
            //dao chuoi string
            public static void Reverse(ref string s)
            {
                char[] arr = s.ToCharArray(); // chuỗi thành mảng ký tự
                Array.Reverse(arr); // đảo ngược mảng
                s = new string(arr); // trả về chuỗi mới sau khi đảo mảng
            }
            public static bool operator ==(bignum a, bignum b)
            {
                if (String.Compare(a.nguyen, b.nguyen, true) != 0
                    || String.Compare(a.tphan, b.tphan, true) != 0
                    || a.dau != b.dau)
                    return false;
                return true;
            }
            public static bool operator !=(bignum a, bignum b)
            {
                return !(a == b);
            }
            public static bool operator >(bignum a, bignum b)
            {
                if (a == b)
                    return false;
                //TH hai số khác dấu ==> so sánh dấu
                if (a.dau < b.dau)
                    return false;
                if (a.dau > b.dau)
                    return true;
                if (a.dau + b.dau == 2) //TH cả hai số dương
                {
                    //So sánh số chữ số phần nguyên
                    if (a.nguyen.Length < b.nguyen.Length)
                        return false;
                    if (a.nguyen.Length > b.nguyen.Length)
                        return true;
                    //Số chữ số phần nguyên bằng nhau nên so sánh giá trị
                    for (int i = 0; i < a.nguyen.Length; i++)
                    {
                        if (a.nguyen[i] < b.nguyen[i])
                            return false;
                        if (a.nguyen[i] > b.nguyen[i])
                            return true;
                    }
                    //Phần nguyên giống nhau => so sánh phần thập phân
                    if (a.tphan.Length > b.tphan.Length)
                    {
                        for (int i = 0; i < b.tphan.Length; i++)
                        {
                            if (a.tphan[i] < b.tphan[i])
                                return false;
                            if (a.tphan[i] > b.tphan[i])
                                return true;
                        }
                        return true;
                    }
                    else
                    {
                        for (int i = 0; i < a.tphan.Length; i++)
                        {
                            if (b.tphan[i] < a.tphan[i])
                                return true;
                            if (b.tphan[i] > a.tphan[i])
                                return false;
                        }
                        return false;
                    }
                }
                else //TH cả hai số âm
                {
                    a.dau = 1; b.dau = 1;
                    if (a > b)
                        return false;
                    else
                        return true;
                }
            }
            public static bool operator <(bignum a, bignum b)
            {
                return !(a == b || a > b);
            }
            public static bignum operator +(bignum a, bignum b)
            {
                bignum kq = new bignum();
                kq.dau = 1;
                kq.nguyen = null;
                kq.tphan = null;
                kq.cham = 1;
                /*****************************/
                if (a.dau != b.dau) //TH a, b trái dấu
                    if (a.dau == 1) //a dương ==> a + (-b) = a - b
                    {
                        b.dau = 1;
                        kq = a - b;
                        return kq;
                    }
                    else            //b dương ==> (-a) + b = b - a
                    {
                        a.dau = 1;
                        kq = b - a;
                        return kq;
                    }
                if (a.dau == 0 && b.dau == 0) //a, b đều âm ==> (-a) + (-b) = -(a + b)
                {
                    a.dau = 1;
                    b.dau = 1;
                    kq = a + b;
                    kq.dau = 0;
                    return kq;
                }
                int nho = 0;
                int i;
                //--------------xu li tphan------
                if (a.tphan.Length >= b.tphan.Length)
                {
                    for (i = b.tphan.Length; i < a.tphan.Length; i++)
                        b.tphan += 0;
                }
                else
                {
                    for (i = a.tphan.Length; i < b.tphan.Length; i++)
                        a.tphan += 0;

                }
                //cong
                for (i = a.tphan.Length - 1; i >= 0; i--)
                {
                    kq.tphan += cong2so(a.tphan[i], b.tphan[i], ref nho);
                }
                Reverse(ref kq.tphan);
                xoaSo0(ref kq.tphan);   //xoa so 0 du o phan tphan vd: 12300->123
                //-----------xu li nguyen
                Reverse(ref a.nguyen);
                Reverse(ref b.nguyen);
                if (a.nguyen.Length >= b.nguyen.Length)
                {
                    for (i = b.nguyen.Length; i < a.nguyen.Length; i++)
                        b.nguyen += 0;

                }
                else
                {
                    for (i = a.nguyen.Length; i < b.nguyen.Length; i++)
                        a.nguyen += 0;

                }
                for (i = 0; i < a.nguyen.Length; i++)
                {
                    kq.nguyen += cong2so(a.nguyen[i], b.nguyen[i], ref nho);
                }
                if (nho > 0)
                    kq.nguyen += nho.ToString();
                Reverse(ref kq.nguyen);
                kq.cham = a.nguyen.Length;
                return kq;
            }
            public static string cong2so(char a, char b, ref int nho)
            {
                int tam = 0;
                //int so1 = Convert.ToInt32(a);
                //int so2 = Convert.ToInt32(b);
                tam = a - 48 + b - 48 + nho;
                if (tam >= 10)
                    nho = tam / 10;
                else
                    nho = 0;
                //return Convert.ToChar(tam);
                tam = tam % 10;
                return tam.ToString();
            }
            public static void xoaSo0(ref string a)
            {
                if (a[0] == '0' && a.Length == 1)
                    return;
                while (a[a.Length - 1] == '0' && a.Length != 1)
                {
                    a = a.Remove(a.Length - 1);
                }
            }
            public static void xoaSo0_dau(ref string a)
            {
                if (a[0] == '0' && a.Length == 1)
                    return;
                while (a[0] == '0' && a.Length != 1)
                    a = a.Remove(0, 1);
            }
            public static bignum operator -(bignum a, bignum b)
            {
                bignum kq = new bignum();
                kq.dau = 1;
                kq.nguyen = null;
                kq.tphan = null;
                kq.cham = 1;
                /********************************/
                if (a.dau != b.dau) //2 số trái dấu trừ nhau => chuyển qua cộng
                {                   // (-a) - b = (-a) + (-b)
                    b.dau = a.dau;  // a - (-b) = a + b
                    kq = a + b;
                    return kq;
                }
                if (a.dau == 0) //2 số cùng âm trừ nhau
                {               // (-a) - (-b) = b - a
                    a.dau = 1;
                    b.dau = 1;
                    kq = b - a;
                    return kq;
                }
                if (b > a) //2 số cùng dương nhưng b > a ==> a - b = - (b - a)
                {
                    kq = b - a;
                    kq.dau = 0;
                    return kq;
                }
                int i;
                int nho = 0;
                //------------tphan-------------
                //them so 0
                if (a.tphan.Length > b.tphan.Length)
                {
                    for (i = b.tphan.Length; i < a.tphan.Length; i++)
                        b.tphan += "0";
                }
                else
                {
                    for (i = a.tphan.Length; i < b.tphan.Length; i++)
                        a.tphan += "0";

                }
                //------tru-------
                for (i = a.tphan.Length - 1; i >= 0; i--)
                {
                    kq.tphan += tru2so(a.tphan[i], b.tphan[i], ref nho);
                }
                Reverse(ref kq.tphan);
                xoaSo0(ref kq.tphan);
                //----------nguyen----------
                Reverse(ref a.nguyen);
                Reverse(ref b.nguyen);
                //them so 0
                if (a.nguyen.Length >= a.nguyen.Length)
                {
                    for (i = b.nguyen.Length; i < a.nguyen.Length; i++)
                        b.nguyen += 0;

                }
                else
                {
                    for (i = a.nguyen.Length; i < b.nguyen.Length; i++)
                        a.nguyen += 0;

                }
                for (i = 0; i < a.nguyen.Length; i++)
                {
                    kq.nguyen += tru2so(a.nguyen[i], b.nguyen[i], ref nho);
                }
                if (nho > 0)
                    kq.nguyen += nho.ToString();
                xoaSo0(ref kq.nguyen);
                Reverse(ref kq.nguyen);
                kq.cham = a.nguyen.Length;
                return kq;
            }
            public static string tru2so(char a, char b, ref int nho)
            {
                int tam, so1, so2;
                so1 = a - 48;
                so2 = b - 48;
                if ((so1 - so2 - nho) < 0)
                {
                    tam = so1 + 10 - so2 - nho;
                    nho = 1;
                }
                else
                {
                    tam = so1 - so2 - nho;
                    nho = 0;
                }
                return tam.ToString();
            }
            public static void xoaViTrik(char[] a, int k)
            {
                for (int i = k; i <= a.Length; i++)
                    a[i] = a[i + 1];
            }
            public static int timX(char[] a, char x)
            {
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == x)
                        return i;
                return 0;
            }
            public static bignum operator *(bignum a, bignum b)
            {
                int i = 0;
                //--------lam cho 2 phan tphan co cung chu so--------
                //---------them so 0 vao cuoi------------
                if (a.tphan.Length >= b.tphan.Length)
                {
                    for (i = b.tphan.Length; i < a.tphan.Length; i++)
                        b.tphan += 0;
                }
                else
                {
                    for (i = a.tphan.Length; i < b.tphan.Length; i++)
                        a.tphan += 0;
                }
                //----------------noi phan nguyen va tphan lai----------------
                string v1 = a.nguyen + a.tphan;
                string v2 = b.nguyen + b.tphan;
                Reverse(ref v1);
                Reverse(ref v2);
                //----------------nhan v1 voi v2------------------------------
                bignum kq = new bignum();   //mac dinh gia tri la 0.0
                kq.nguyen = "0";
                kq.tphan = "0";
                kq.dau = 1;
                kq.cham = 1;
                bignum c = new bignum();
                c.nguyen = null;
                c.tphan = null;
                c.dau = 1;
                c.cham = 1;

                //-----------bat dau nhan tung ptu cua v1 cho v2 ---------


                for (i = 0; i < v1.Length; i++)
                {
                    //c.tphan = "0";
                    int nho = 0, tam, j = 0;
                    //nhan v2 va v1[i]
                    for (j = 0; j < b.tphan.Length; j++)
                    {
                        tam = (v1[i] - 48) * (v2[j] - 48) + nho;
                        c.tphan += (tam % 10).ToString();
                        nho = tam / 10;
                    }
                    for (j = b.tphan.Length; j < v2.Length; j++)
                    {
                        tam = (v1[i] - 48) * (v2[j] - 48) + nho;
                        c.nguyen += (tam % 10).ToString();
                        nho = tam / 10;
                    }
                    if (nho > 0)
                        c.nguyen += nho.ToString();
                    Reverse(ref c.tphan);
                    Reverse(ref c.nguyen);
                    for (j = 0; j < i; j++) //moi lan nhan tang len gap 10 lan
                    {
                        c.tphan += "0";
                        c.nguyen += c.tphan[0];
                        c.tphan = c.tphan.Remove(0, 1);
                    }
                    xoaSo0(ref c.tphan);        //xoa so 0 phan tphan
                    c.cham = c.nguyen.Length;
                    kq = kq + c;        //cong hai bignum
                    c.nguyen = null;     //tra c ve null
                    c.tphan = null;  //tra c ve null

                }

                // chia a.tphan lan kq cho 10 vi a nhan vao la so nguyen
                for (i = 0; i < a.tphan.Length; i++) //moi lan nhan tang len gap 10 lan
                {
                    //dao chuoi-them so vao phia sau-dao chuoi
                    Reverse(ref kq.tphan);
                    kq.tphan += kq.nguyen[kq.nguyen.Length - 1];
                    Reverse(ref kq.tphan);
                    //dao chuoi--them so 0 phia sau--xoa ptu dau tien--xoa so 0--dao chuoi
                    Reverse(ref kq.nguyen);
                    kq.nguyen += '0';
                    kq.nguyen = kq.nguyen.Remove(0, 1);
                    xoaSo0(ref kq.nguyen);
                    Reverse(ref kq.nguyen);
                }
                xoaSo0(ref kq.tphan);
                if (a.dau - b.dau == 0)
                    kq.dau = 1;
                else
                    kq.dau = 0;

                return kq;
            }
            public static void themZeroVaoDau(ref string A)
            {
                Reverse(ref A);
                A += "0";
                Reverse(ref A);
            }
            public static int chiaNguyen(string a, string b)
            {
                int tam2;
                BigInteger big1 = new BigInteger();
                BigInteger big2 = new BigInteger();
                //BigInteger big3 = new BigInteger();
                Reverse(ref a);
                Reverse(ref b);
                BigInteger.TryParse(a, out big1);
                BigInteger.TryParse(b, out big2);
                tam2 = Convert.ToInt32(BigInteger.Divide(big1, big2).ToString());
                return tam2;
            }
            public static string chiaDu(string a, string b)
            {
                string tam2;
                BigInteger big1 = new BigInteger(); //so bi chia
                BigInteger big2 = new BigInteger(); //so chia
                BigInteger big3 = new BigInteger(); //dư
                Reverse(ref a);
                Reverse(ref b);
                BigInteger.TryParse(a, out big1);
                BigInteger.TryParse(b, out big2);
                BigInteger.DivRem(big1, big2, out big3);
                tam2 = big3.ToString();
                Reverse(ref tam2);
                return tam2;
            }
            public static bignum operator /(bignum a, bignum b)
            {

                int i;
                bignum kq = new bignum();
                kq.dau = 1;
                kq.nguyen = "";
                kq.tphan = "";
                kq.cham = 1;
                //xử lý th chia cho số 0
                if (b.nguyen == "0" && b.tphan == "0")
                {
                    kq.dau = -1;
                    kq.nguyen = "0";
                    kq.cham = 1;
                    kq.tphan = "0";
                    return kq;
                }
                if (a.tphan.Length >= b.tphan.Length)
                //them so 0 vao phan thap phan ngan hon
                {
                    for (i = b.tphan.Length; i < a.tphan.Length; i++)
                        b.tphan += '0';
                }
                else
                {
                    for (i = a.tphan.Length; i < b.tphan.Length; i++)
                        a.tphan += '0';
                }
                //----------------noi phan nguyen va tphan lai----------------
                string v1 = a.nguyen + a.tphan;
                string v2 = b.nguyen + b.tphan;
                Reverse(ref v1);
                Reverse(ref v2);
                //----------------chia 2 vector v1 & v2----------------
                string carry = "0";
                int nho = 0;
                while (v1.Length > 0)      //duyet het v1
                {
                    if (carry.Length == 1)     //neu carry chua co' gi`
                    //if (carry == "0")
                    {
                        //neu v2 > carry
                        while (compare(carry, v2) == 1 && v1.Length > 0)
                        //tach carry tu` v1 cho den khi carry>v2
                        {
                            i = v1.Length - 1;
                            insert_begin(ref carry, v1[i]);
                            //v1[i] = '\0';
                            v1 = v1.Remove(i);
                        }
                    }
                    else
                    {
                        i = v1.Length - 1;
                        insert_begin(ref carry, v1[i]);
                        //v1[i] = '\0';
                        v1 = v1.Remove(i);
                    }
                    xoaSo0(ref carry);
                    if (carry.Length > v2.Length)
                    //them 1 so 0 vao duoi v2 neu carry > v2
                    {
                        v2 += '0';
                        //i = v2.Length;
                        //v2[i] = '0';
                        //v2[i + 1] = '\0';
                    }
                    int dem = 0;
                    //string tam2 = null;
                    //int a1, b1;
                    //while (compare(carry, v2) != 1)
                    //chia carry & v2, dem la ket qua, carry la dư
                    //{
                    //    dem++;
                    //    tam2 = tru(carry, v2);
                    //    carry = tam2;
                    //}
                    dem = chiaNguyen(carry, v2);
                    carry = chiaDu(carry, v2);

                    xoaSo0(ref v2);
                    xoaSo0(ref carry);
                    //gan vao kq.nguyen
                    insert_begin(ref kq.nguyen, Convert.ToChar(dem + 48));
                }
                xoaSo0(ref kq.nguyen);
                Reverse(ref kq.nguyen);
                //----------------chia tiep phan tphan neu carry > 0----------------
                int chuSo = 0;
                nho = 0;
                //while (strcmp(carry, "0") != 0 && chuSo <= 250)
                //chia cho toi khi carry=0 hoac so chu so =250
                while (!carry.Equals("0") && chuSo <= 250)
                {
                    themZeroVaoDau(ref carry);
                    xoaSo0(ref carry);
                    if (carry.Length > v2.Length)
                    //them 1 so 0 vao duoi v2 neu carry > v2
                    {
                        v2 += '0';
                        //i = v2.Length;
                        //v2[i] = '0';
                        //v2[i + 1] = '\0';
                    }
                    int dem = 0;
                    //string tam2 = null;
                    //int a2, b2;
                    //while (compare(carry, v2) != 1)
                    ////chia carry & v2, dem la ket qua
                    //{
                    //    dem++;
                    //    tam2 = tru(carry, v2);
                    //    carry = tam2;
                    //}
                    dem = chiaNguyen(carry, v2);
                    carry = chiaDu(carry, v2);
                    xoaSo0(ref v2);
                    xoaSo0(ref carry);
                    //gan vao kq.tphan
                    insert_begin(ref kq.tphan, Convert.ToChar(dem + 48));
                    chuSo++;
                }
                //xoaSo0(ref kq.tphan);
                if (kq.tphan == "")
                    kq.tphan = "0";
                Reverse(ref kq.tphan);
                kq.cham = kq.nguyen.Length;
                if (a.dau == b.dau)
                    kq.dau = 1;
                else
                    kq.dau = 0;
                return kq;
            }
            //so sanh v1 va v2-----v1>v2 -> -1 ------ v1<v2 -> 1 --- v1=v2->0
            public static int compare(string v1, string v2)
            {
                if (v1.Length > v2.Length)
                    return -1;
                if (v1.Length < v2.Length)
                    return 1;
                for (int i = v1.Length - 1; i >= 0; i--)
                {
                    if (v1[i] > v2[i])
                        return -1;
                    if (v1[i] < v2[i])
                        return 1;
                }
                return 0;
            }
            //chèn k vao đầu chuỗi
            public static void insert_begin(ref string A, char k)
            {
                Reverse(ref A);
                A += k;
                Reverse(ref A);

                //for (int i = A.Length + 1; i > 0; i--)
                //    A[i] = A[i - 1];
                //A[0] = k;

                //A =A.Replace()
            }
            public static bignum sinBignum(bignum a)
            {
                int sign = a.dau;
                //so pi
                string PI = Math.PI.ToString();
                bignum soPi = new bignum();
                soPi.getBigNum(PI);
                //180
                string so180 = "180";
                bignum motTamMuoi = new bignum();
                motTamMuoi.getBigNum(so180);
                //khai bao 360
                string baSau = "360";
                //khai bao biến kq
                bignum kq = new bignum();
                a = a * soPi / motTamMuoi;
                //giảm phần nguyên lại s cho < 360
                string v1 = a.nguyen;
                Reverse(ref v1);
                Reverse(ref baSau);
                a.nguyen = chiaDu(v1, baSau);
                Reverse(ref v1);
                Reverse(ref baSau);
                //giam phan tphan lai
                if (a.tphan.Length > 30)
                    a.tphan = a.tphan.Remove(30);
                //lấy sin của a và gán kq vào chuỗi
                string tam = null;
                if (sign == 1)
                    tam = a.nguyen + "." + a.tphan;
                else
                    tam = "-" + a.nguyen + "." + a.tphan;
                double ketQua = Convert.ToDouble(tam);
                string chuoi = Math.Sin(ketQua).ToString();
                if (chuoi.IndexOf('E') != -1)
                    chuoi = "0";
                kq.getBigNum(chuoi);
                return kq;
            }
            public static bignum cosBignum(bignum a)
            {
                //so pi
                string PI = Math.PI.ToString();
                bignum soPi = new bignum();
                soPi.getBigNum(PI);
                //180
                string so180 = "180";
                bignum motTamMuoi = new bignum();
                motTamMuoi.getBigNum(so180);
                //khai bao 360
                string baSau = "360";
                //khai bao biến kq
                bignum kq = new bignum();
                a = a * soPi / motTamMuoi;
                //giảm phần nguyên lại s cho < 360
                string v1 = a.nguyen;
                Reverse(ref v1);
                Reverse(ref baSau);
                a.nguyen = chiaDu(v1, baSau);
                Reverse(ref v1);
                Reverse(ref baSau);
                //giam phan tphan lai
                if (a.tphan.Length > 30)
                    a.tphan = a.tphan.Remove(30);
                //lấy sin của a và gán kq vào chuỗi
                string tam = a.nguyen + "." + a.tphan;
                double ketQua = Convert.ToDouble(tam);
                string chuoi = Math.Cos(ketQua).ToString();
                if (chuoi.IndexOf('E') != -1)
                    chuoi = "0";
                kq.getBigNum(chuoi);
                return kq;
            }
            public static bignum tanBignum(bignum a)
            {
                int sign = a.dau;
                //90
                string so90 = "90";
                bignum chinMuoi = new bignum();
                chinMuoi.getBigNum(so90);
                //so pi
                string PI = Math.PI.ToString();
                bignum soPi = new bignum();
                soPi.getBigNum(PI);
                //180
                string so180 = "180";
                bignum motTamMuoi = new bignum();
                motTamMuoi.getBigNum(so180);
                //khai bao 360
                string baSau = "360";
                //khai bao biến kq
                bignum kq = new bignum();
                bignum tam2 = new bignum();
                //tam2 = a / chinMuoi;
                if ((a / chinMuoi).tphan == "0")
                    if ((a / motTamMuoi).tphan != "0")
                    {
                        a.dau = -1;
                        return a;
                    }
                a = a * soPi / motTamMuoi;
                //giảm phần nguyên lại s cho < 360
                string v1 = a.nguyen;
                Reverse(ref v1);
                Reverse(ref baSau);
                a.nguyen = chiaDu(v1, baSau);
                Reverse(ref v1);
                Reverse(ref baSau);
                //giam phan tphan lai
                if (a.tphan.Length > 30)
                    a.tphan = a.tphan.Remove(30);
                //lấy sin của a và gán kq vào chuỗi
                string tam = null;
                if (sign == 1)
                    tam = a.nguyen + "." + a.tphan;
                else
                    tam = "-" + a.nguyen + "." + a.tphan;
                double ketQua = Convert.ToDouble(tam);
                string chuoi = Math.Tan(ketQua).ToString();
                if (chuoi.IndexOf('E') != -1)
                    chuoi = "0";
                kq.getBigNum(chuoi);

                return kq;
            }
        }
        /*******************************************************/
        //Tính toán biểu thức sau khi đã chuyển qua hậu tố
        bignum Calc(string inp)
        {
            int StackLength = 0;
            bignum[] Stack = new bignum[50];
            for (int i = 0; i < 50; i++)
                Stack[i] = new bignum();
            string[] Input = inp.Split(' '); //tách toán tử và toán hạng trong chuỗi ra 
            for (int i = 0; i < Input.Length; i++)
            {
                if (isOperator(Input[i][0]) == 0)
                {
                    if (Input[i] == "A")
                        Input[i] = Ans;
                    if (Input[i].IndexOf(".") != Input[i].LastIndexOf("."))
                    {
                        bignum tam = new bignum();
                        tam.dau = -1;
                        tam.cham = 1;
                        tam.nguyen = "0";
                        tam.tphan = "0";
                        return tam;
                    }
                    Stack[StackLength++].getBigNum(Input[i]); //chuyển string qua bignum và push vào Stack
                }
                else
                {
                    //xử lý toán tử 2 ngôi
                    if (getPriority(Input[i][0]) != 3)
                    {
                        // Do ta cần quan tâm đến thứ tự các toán hạng
                        // Nên ta phải Pop vế sau trước, sau đó vế trước mới Pop sau
                        bignum a, b;
                        b = Stack[--StackLength];
                        a = Stack[--StackLength];
                        if (Input[i][0] == '+') Stack[StackLength++] = a + b;
                        else if (Input[i][0] == '-') Stack[StackLength++] = a - b;
                        else if (Input[i][0] == 'x') Stack[StackLength++] = a * b;
                        else if (Input[i][0] == '/')
                        {
                            bignum tam = new bignum();
                            tam = a / b;
                            if (tam.dau != -1)
                                Stack[StackLength++] = tam;
                            else return tam; //nếu chia cho 0 thì kết thúc
                        }
                    }
                    else
                    //xử lý toán tử một ngôi
                    {
                        bignum a = Stack[--StackLength];
                        if (Input[i][0] == 'a')
                        {
                            Stack[StackLength++] = a;
                            if (a.dau == 0)
                                a.dau = 1;
                            else
                                a.dau = 0;
                        }
                        else
                        {
                            if (Input[i][0] == 's') Stack[StackLength++] = bignum.sinBignum(a);
                            else if (Input[i][0] == 'c') Stack[StackLength++] = bignum.cosBignum(a);
                            else if (Input[i][0] == 't')
                            {
                                bignum tam = new bignum();
                                tam = bignum.tanBignum(a);
                                if (tam.dau != -1)
                                    Stack[StackLength++] = tam;
                                else return tam;
                            }
                        }
                    }
                }
            }
            return Stack[0];
        }
        //thay dấu âm bằng chữ a
        string ThayDauAm(string inp, int vt)
        {
            inp = inp.Insert(vt, "a");
            return inp.Remove(vt + 1, 1);
        }
        //kiểm tra biểu thức hợp lệ và chuẩn hóa dữ liệu đầu vào
        bool KiemTraInput(ref string inp)
        {
            //nếu bắt đầu là dấu + x / => không hợp lệ
            if (inp[0] == '+' || inp[0] == 'x' || inp[0] == '/') return false;
            //nêu kết thúc là toán tử hoặc dấu mở ngoặc => không hợp lệ
            if (inp[0] == '-') inp = ThayDauAm(inp, 0);
            //chuẩn hóa các phép toán sin cos tan và biến Ans
            inp = inp.Replace("sin", "s");
            inp = inp.Replace("cos", "c");
            inp = inp.Replace("tan", "t");
            inp = inp.Replace("Ans", "A");
            if (isOperator(inp[inp.Length - 1]) == 2 || inp[inp.Length - 1] == '(') return false;
            int demngoac = 0;
            if (inp[0] == '(') demngoac++;
            for (int i = 1; i < inp.Length - 1; i++)
            {
                //kiểm tra 2 toán tử liền nhau
                if (isOperator(inp[i]) == 2 && isOperator(inp[i + 1]) == 2)
                {
                    if ((inp[i + 1] == '+' || inp[i + 1] == 'x' || inp[i + 1] == '/')) return false;
                    if (inp[i + 1] == '-')
                        //nếu sau dấu - không phải là toán tử thì dấu - hợp lệ
                        if (isOperator(inp[i + 2]) != 2)
                            inp = ThayDauAm(inp, i + 1);
                        else return false; //nếu 2,3 toán tử liền nhau => không hợp lệ
                }
                if (inp[i] == '(')
                    if (inp[i + 1] == '-')
                        //nếu sau dấu - không phải là toán tử thì dấu - hợp lệ
                        if (isOperator(inp[i + 2]) != 2)
                        {
                            inp = ThayDauAm(inp, i + 1);
                            demngoac++;
                        }
                        else return false;
                    else
                        //trước ngoặc ( là số "123(" hoặc trong ngoặc rỗng "()" => không hợp lệ
                        if ((isOperator(inp[i - 1]) == 0 || inp[i + 1] == ')') && i < inp.Length) return false;
                        else demngoac++;
                if (inp[i] == ')')
                    //trước ngoặc ) là toán tử "+)" hoặc giữa 2 ngoặc không có toán tử ")(" => không hợp lệ
                    if ((isOperator(inp[i - 1]) == 2 || inp[i + 1] == '(') && i < inp.Length) return false;
                    else demngoac--;
                if (demngoac < 0) return false; //mở ngoặc trước => không hợp lệ
            }
            if (inp[inp.Length - 1] == ')') demngoac--;
            if (demngoac != 0) return false; //mở ngoặc nhiều nhưng không đóng ngoặc => không hợp lệ
            return true;
        }
        private void btnBang_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "") return;
            string Input = txtInput.Text;
            if (KiemTraInput(ref Input))
            {
                Input = ConvertToPostfix(Input);
                txtOutput.Text = Calc(Input).ToString();
                Ans = txtOutput.Text;
            }
            else MessageBox.Show("Biểu thức không hợp lệ! Xin kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //bignum a = new bignum();
            //bignum b = new bignum();
            //bignum c = new bignum();
            //bignum d = new bignum();
            //bignum kq = new bignum();
            //a.getBigNum("-123.456");
            //b.getBigNum("-314512");
            //c.getBigNum("1");
            //d.getBigNum("3");
            //kq = bignum.tanBignum(a);
            //txtOutput.Text = kq.ToString();
        }

        private void tipExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TSMTroll.Checked == true)
                if (MessageBox.Show("Thầy sẽ cho nhóm em 10 điểm chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
        }

        private void TSMCopy_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText != "")
                Clipboard.SetText(txtInput.SelectedText);
            else
                if (txtOutput.SelectedText != "")
                    Clipboard.SetText(txtOutput.SelectedText);
        }

        private void TSMPaste_Click(object sender, EventArgs e)
        {
            txtInput.Text += Clipboard.GetText();
        }

        private void tipAbout_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.troll = TSMTroll.Checked;
            dlg.Show();
        }

        private void TSMSelectAll_Click(object sender, EventArgs e)
        {
            if (txtInput.SelectedText != "")
                txtInput.Select(0, txtInput.Text.Length);
            else
                if (txtOutput.SelectedText != "")
                    txtOutput.Select(0, txtOutput.Text.Length);
        }

    }
}