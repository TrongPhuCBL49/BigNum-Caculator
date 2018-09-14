using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_2
{
    public class bignum
    {
        public int dau;
        public int cham;
        public string nguyen, tphan;
        //dao chuoi string
        public static void Reverse(ref string s)
        {
            char[] arr = s.ToCharArray(); // chuỗi thành mảng ký tự
            Array.Reverse(arr); // đảo ngược mảng
            s = new string(arr); // trả về chuỗi mới sau khi đảo mảng
        }

        public static bignum operator +(bignum a, bignum b)
        {
            int nho = 0;
            int i;
            bignum kq = new bignum();
            kq.dau = 1;
            kq.nguyen = null;
            kq.tphan = null;
            kq.cham = 1;
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


        public static bignum operator -(bignum a, bignum b)
        {
            int i;
            int nho = 0;
            bignum kq = new bignum();
            kq.dau = 1;
            kq.nguyen = null;
            kq.tphan = null;
            kq.cham = 1;
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
            //---------tham so 0 vao cuoi------------
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
            return kq;
        }
        public static void themZeroVaoDau(ref string A)
        {
            A.Reverse();
            A += "0";
            A.Reverse();
        }


        //chia chua sua
        public static bignum operator /(bignum a, bignum b)
        {
            int i;
            bignum kq = null;
            kq.dau = 1;
            kq.nguyen = "0";
            kq.tphan = "0";
            kq.cham = 1;
            //----------------noi phan nguyen va tphan lai----------------
            if (a.tphan.Length >= b.tphan.Length) //them so 0 vao phan thap phan ngan hon
            {
                for (i = b.tphan.Length; i < a.tphan.Length; i++)
                    b.tphan += '0';
            }
            else
            {
                for (i = a.tphan.Length; i < b.tphan.Length; i++)
                    a.tphan += '0';
            }
            char[] v1, v2;        //vector
            string t1, t2;
            t1 = a.nguyen.ToString() + a.tphan.ToString();
            t2 = b.nguyen.ToString() + b.tphan.ToString();
            v1 = t1.ToCharArray();
            v2 = t1.ToCharArray();
            v1.Reverse();
            v2.Reverse();
            //----------------chia 2 vector v1 & v2----------------
            char[] carry = null;
            carry[0] = '\0';
            int nho = 0;
            while (v1.Length > 0)      //duyet het v1
            {
                if (carry.Length == 0)     //neu carry chua co' gi`
                {
                    while (compare(carry, v2) == 1 && v1.Length > 0)       //tach carry tu` v1 cho den khi carry>v2
                    {
                        i = v1.Length - 1;
                        insert_begin(carry, v1[i]);
                        v1[i] = '\0';
                    }
                }
                else
                {
                    i = v1.Length - 1;
                    insert_begin(carry, v1[i]);
                    v1[i] = '\0';
                }
                xoaSo0(carry);
                if (carry.Length > v2.Length)     //them 1 so 0 vao duoi v2 neu carry > v2
                {
                    i = v2.Length;
                    v2[i] = '0';
                    v2[i + 1] = '\0';
                }
                int dem = 0;
                char[] tam2 = null;
                int a1, b1;
                while (compare(carry, v2) != 1)     //chia carry & v2, dem la ket qua
                {
                    dem++;
                    //su dung phep tru
                    for (i = 0; i < carry.Length; i++)
                    {
                        a1 = Convert.ToInt32(carry[i]);
                        b1 = Convert.ToInt32(v2[i]);
                        if (a1 < b1 + nho)        //so bi tru < so tru
                        {
                            tam2[i] = Convert.ToChar(a1 - b1 - nho + 10);
                            nho = 1;
                        }
                        else            //so bi tru > so tru
                        {
                            tam2[i] = Convert.ToChar(a1 - b1 - nho);
                            nho = 0;
                        }
                    }
                    tam2[i] = '\0';
                    //strcpy(carry, tam2);
                    for (i = 0; i <= tam2.Length; i++)
                        carry[i] = tam2[i];
                }
                xoaSo0(v2);
                xoaSo0(carry);
                //gan vao kq.nguyen
                insert_begin(kq.nguyen, Convert.ToChar(dem));
            }
            kq.nguyen.Reverse();
            //----------------chia tiep phan tphan neu carry > 0----------------
            int chuSo = 0;
            nho = 0;
            //while (strcmp(carry, "0") != 0 && chuSo <= 250)     //chia cho toi khi carry=0 hoac so chu so =250
            while (!carry.Equals("0") && chuSo <= 250)
            {
                themZeroVaoDau(carry);
                xoaSo0(carry);
                if (carry.Length > v2.Length)     //them 1 so 0 vao duoi v2 neu carry > v2
                {
                    i = v2.Length;
                    v2[i] = '0';
                    v2[i + 1] = '\0';
                }
                int dem = 0;
                char[] tam2 = null;
                int a2, b2;
                while (compare(carry, v2) != 1)     //chia carry & v2, dem la ket qua
                {
                    dem++;
                    //su dung phep tru
                    for (i = 0; i < carry.Length; i++)
                    {
                        a2 = Convert.ToInt32(carry[i]);
                        b2 = Convert.ToInt32(v2[i]);
                        if (a2 < b2 + nho)        //so bi tru < so tru
                        {
                            tam2[i] = Convert.ToChar(a2 - b2 - nho + 10);
                            nho = 1;
                        }
                        else            //so bi tru > so tru
                        {
                            tam2[i] = Convert.ToChar(a2 - b2 - nho);
                            nho = 0;
                        }
                    }
                    tam2[i] = '\0';
                    //strcpy(carry, tam2);
                    for (i = 0; i <= tam2.Length; i++)
                        carry[i] = tam2[i];
                }
                xoaSo0(v2);
                xoaSo0(carry);
                //gan vao kq.tphan
                insert_begin(kq.tphan, Convert.ToChar(dem));
                chuSo++;
            }
            kq.tphan.Reverse();
            xoaSo0(kq.tphan);
            return kq;
        }

        public static int compare(char[] v1, char[] v2)
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
        public static void insert_begin(char[] A, char k)
        {
            for (int i = A.Length + 1; i > 0; i--)
                A[i] = A[i - 1];
            A[0] = k;
        }


    }
}


//back up 16:09 7/6/2017
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Calculator_2
//{
//    public class bignum
//    {
//        public int dau;
//        public int cham;
//        public char[] nguyen, tphan;
//        public int nho = 0;

//        public static bignum operator +(bignum a, bignum b)
//        {
//            int nho = 0;
//            int i;
//            bignum kq = new bignum();
//            kq.dau = 1;
//            kq.nguyen = new char[10000];
//            kq.tphan = new char[10000];
//            kq.cham = 1;
//            //--------------xu li tphan------
//            if (a.tphan.Length >= b.tphan.Length)
//            {
//                for (i = b.tphan.Length; i < a.tphan.Length; i++)
//                    b.tphan[i] = '0';
//                b.tphan[i] = '\0';
//            }
//            else
//            {
//                for (i = a.tphan.Length; i < b.tphan.Length; i++)
//                    a.tphan[i] = '0';
//                a.tphan[i] = '\0';
//            }
//            for (i = a.tphan.Length - 1; i >= 0; i--)
//            {
//                kq.tphan[i] = cong2so(a.tphan[i], b.tphan[i], ref nho);
//            }
//            kq.tphan[a.tphan.Length] = '\0';
//            xoaSo0(kq.tphan);
//            //-----------xu li nguyen----------
//            a.nguyen.Reverse();
//            b.nguyen.Reverse();
//            if (a.nguyen.Length >= b.nguyen.Length)
//            {
//                for (i = b.nguyen.Length; i < a.nguyen.Length; i++)
//                    b.nguyen[i] = '0';
//                b.nguyen[i] = '\0';
//            }
//            else
//            {
//                for (i = a.nguyen.Length; i < b.nguyen.Length; i++)
//                    a.nguyen[i] = '0';
//                a.nguyen[i] = '\0';
//            }
//            for (i = 0; i < a.nguyen.Length; i++)
//            {
//                kq.nguyen[i] = cong2so(a.nguyen[i], b.nguyen[i], ref nho);
//            }
//            if (nho > 0)
//                kq.nguyen[i++] = Convert.ToChar(nho);
//            kq.nguyen[i] = '\0';
//            kq.nguyen.Reverse();
//            kq.cham = a.nguyen.Length;
//            return kq;
//        }
//        public static char cong2so(char a, char b, ref int nho)
//        {
//            int tam;
//            int so1 = Convert.ToInt32(a);
//            int so2 = Convert.ToInt32(b);
//            tam = a + b + nho;
//            if (tam >= 10)
//                nho = tam / 10;
//            else
//                nho = 0;
//            return Convert.ToChar(tam);
//        }
//        public static void xoaSo0(char[] a)
//        {
//            int n = a.Length - 1;
//            while (a[n] == '0')
//            {
//                a[n] = '\0';
//                n--;
//            }
//        }

//        public static bignum operator -(bignum a, bignum b)
//        {
//            int i;
//            int nho = 0;
//            bignum kq = null;
//            kq.dau = 1;
//            kq.nguyen = null;
//            kq.tphan = null;
//            kq.cham = 1;
//            //------------tphan-------------
//            //them so 0
//            if (a.tphan.Length > b.tphan.Length)
//            {
//                for (i = b.tphan.Length; i < a.tphan.Length; i++)
//                    b.tphan[i] = '0';
//                b.tphan[i] = '\0';
//            }
//            else
//            {
//                for (i = a.tphan.Length; i < b.tphan.Length; i++)
//                    a.tphan[i] = '0';
//                a.tphan[i] = '\0';
//            }
//            //------tru-------

//            for (i = a.tphan.Length - 1; i >= 0; i--)
//            {
//                kq.tphan[i] = tru2so(a.tphan[i], b.tphan[i], ref nho);
//            }
//            kq.tphan[a.tphan.Length] = '\0';
//            xoaSo0(kq.tphan);
//            //----------nguyen----------
//            a.nguyen.Reverse();
//            b.nguyen.Reverse();
//            //them so 0
//            if (a.nguyen.Length >= a.nguyen.Length)
//            {
//                for (i = b.nguyen.Length; i < a.nguyen.Length; i++)
//                    b.nguyen[i] = '0';
//                b.nguyen[i] = '\0';
//            }
//            else
//            {
//                for (i = a.nguyen.Length; i < b.nguyen.Length; i++)
//                    a.nguyen[i] = '0';
//                a.nguyen[i] = '\0';
//            }
//            for (i = 0; i < a.nguyen.Length; i++)
//            {
//                kq.nguyen[i] = tru2so(a.nguyen[i], b.nguyen[i], ref nho);
//            }
//            if (nho > 0)
//                kq.nguyen[i++] = Convert.ToChar(nho);
//            kq.nguyen[i] = '\0';
//            kq.nguyen.Reverse();
//            kq.cham = a.nguyen.Length;
//            return kq;
//        }
//        public static char tru2so(char a, char b, ref int nho)
//        {
//            int tam, so1, so2;
//            so1 = a - 48;
//            so2 = b - 48;
//            if ((so1 - so2 - nho) < 0)
//            {
//                tam = so1 + 10 - so2 - nho;
//                nho = 1;
//            }
//            else
//            {
//                tam = so1 - so2 - nho;
//                nho = 0;
//            }
//            return Convert.ToChar(tam);
//        }
//        public static void xoaViTrik(char[] a, int k)     //123456
//        {
//            for (int i = k; i <= a.Length; i++)
//                a[i] = a[i + 1];
//        }
//        public static int timX(char[] a, char x)
//        {
//            for (int i = 0; i < a.Length; i++)
//                if (a[i] == x)
//                    return i;
//            return 0;
//        }

//        public static bignum operator *(bignum a, bignum b)
//        {
//            //----------------noi phan nguyen va tphan lai----------------
//            char[] v1, v2;        //vector
//            //strcpy(v1, a.nguyen);
//            //strcat(v1, a.tphan);
//            //strcpy(v2, b.nguyen);
//            //strcat(v2, b.tphan);
//            string t1, t2;
//            t1 = a.nguyen.ToString() + a.tphan.ToString();
//            t2 = b.nguyen.ToString() + b.tphan.ToString();
//            v1 = t1.ToCharArray();
//            v2 = t1.ToCharArray();
//            v1.Reverse();
//            v2.Reverse();
//            //----------------nhan t1 voi t2------------------------------
//            bignum kq = null;
//            kq.nguyen[0] = '1';
//            kq.tphan[0] = '1';
//            int i = 0;
//            for (i = 0; i < v1.Length; i++)
//            {
//                bignum c = null;
//                //strcpy(c.tphan, "0");
//                c.tphan[0] = '0';
//                int nho = 0, tam, j = 0;
//                //nhan t1[i] vs ca t2
//                for (j = 0; j < v2.Length; j++)
//                {
//                    tam = (v1[i] - 48) * (v2[j] - 48) + nho;
//                    c.nguyen[j] = Convert.ToChar(tam % 10 + 48);
//                    nho = tam / 10;
//                }
//                if (nho > 0)
//                    c.nguyen[j++] = Convert.ToChar(nho);
//                c.nguyen[j] = '\0';
//                //gan i so 0 o dau`
//                for (j = 0; j < i; j++)
//                    themZeroVaoDau(c.nguyen);
//                //daoChuoi(c.nguyen);     //vi c.nguyen dang la vector
//                c.nguyen.Reverse();
//                kq = c + kq;        //cong hai bignum
//            }
//            //----------------tach phan nguyen va tphan ra----------------
//            int tp1 = a.tphan.Length,
//                tp2 = b.tphan.Length,
//                tp = tp1 + tp2;
//            int k = 0,
//                start = kq.nguyen.Length - tp,
//                end = kq.nguyen.Length;        //phan tphan lay tu` start -> end
//            for (i = start; i < end; i++)
//            {
//                kq.tphan[k++] = kq.nguyen[i];
//                kq.tphan[k] = '\0';
//            }
//            kq.nguyen[start] = '\0';
//            kq.cham = kq.nguyen.Length;
//            return kq;
//        }
//        public static void themZeroVaoDau(char[] A)
//        {
//            int n = A.Length;
//            for (int i = n; i >= 0; i--)
//                A[i + 1] = A[i];
//            A[0] = '0';
//        }

//        public static bignum operator /(bignum a, bignum b)
//        {
//            int i;
//            bignum kq = null;
//            kq.dau = 1;
//            //strcpy(kq.nguyen, "");
//            //strcpy(kq.tphan, "");
//            kq.nguyen[0] = '\0';
//            kq.tphan[0] = '\0';
//            kq.cham = 1;
//            //----------------noi phan nguyen va tphan lai----------------
//            if (a.tphan.Length >= b.tphan.Length) //them so 0 vao phan thap phan ngan hon
//            {
//                for (i = b.tphan.Length; i < a.tphan.Length; i++)
//                    b.tphan[i] = '0';
//                b.tphan[i] = '\0';
//            }
//            else
//            {
//                for (i = a.tphan.Length; i < b.tphan.Length; i++)
//                    a.tphan[i] = '0';
//                a.tphan[i] = '\0';
//            }
//            char[] v1, v2;        //vector
//            string t1, t2;
//            t1 = a.nguyen.ToString() + a.tphan.ToString();
//            t2 = b.nguyen.ToString() + b.tphan.ToString();
//            v1 = t1.ToCharArray();
//            v2 = t1.ToCharArray();
//            v1.Reverse();
//            v2.Reverse();
//            //----------------chia 2 vector v1 & v2----------------
//            char[] carry = null;
//            carry[0] = '\0';
//            int nho = 0;
//            while (v1.Length > 0)      //duyet het v1
//            {
//                if (carry.Length == 0)     //neu carry chua co' gi`
//                {
//                    while (compare(carry, v2) == 1 && v1.Length > 0)       //tach carry tu` v1 cho den khi carry>v2
//                    {
//                        i = v1.Length - 1;
//                        insert_begin(carry, v1[i]);
//                        v1[i] = '\0';
//                    }
//                }
//                else
//                {
//                    i = v1.Length - 1;
//                    insert_begin(carry, v1[i]);
//                    v1[i] = '\0';
//                }
//                xoaSo0(carry);
//                if (carry.Length > v2.Length)     //them 1 so 0 vao duoi v2 neu carry > v2
//                {
//                    i = v2.Length;
//                    v2[i] = '0';
//                    v2[i + 1] = '\0';
//                }
//                int dem = 0;
//                char[] tam2 = null;
//                int a1, b1;
//                while (compare(carry, v2) != 1)     //chia carry & v2, dem la ket qua
//                {
//                    dem++;
//                    //su dung phep tru
//                    for (i = 0; i < carry.Length; i++)
//                    {
//                        a1 = Convert.ToInt32(carry[i]);
//                        b1 = Convert.ToInt32(v2[i]);
//                        if (a1 < b1 + nho)        //so bi tru < so tru
//                        {
//                            tam2[i] = Convert.ToChar(a1 - b1 - nho + 10);
//                            nho = 1;
//                        }
//                        else            //so bi tru > so tru
//                        {
//                            tam2[i] = Convert.ToChar(a1 - b1 - nho);
//                            nho = 0;
//                        }
//                    }
//                    tam2[i] = '\0';
//                    //strcpy(carry, tam2);
//                    for (i = 0; i <= tam2.Length; i++)
//                        carry[i] = tam2[i];
//                }
//                xoaSo0(v2);
//                xoaSo0(carry);
//                //gan vao kq.nguyen
//                insert_begin(kq.nguyen, Convert.ToChar(dem));
//            }
//            kq.nguyen.Reverse();
//            //----------------chia tiep phan tphan neu carry > 0----------------
//            int chuSo = 0;
//            nho = 0;
//            //while (strcmp(carry, "0") != 0 && chuSo <= 250)     //chia cho toi khi carry=0 hoac so chu so =250
//            while (!carry.Equals("0") && chuSo <= 250)
//            {
//                themZeroVaoDau(carry);
//                xoaSo0(carry);
//                if (carry.Length > v2.Length)     //them 1 so 0 vao duoi v2 neu carry > v2
//                {
//                    i = v2.Length;
//                    v2[i] = '0';
//                    v2[i + 1] = '\0';
//                }
//                int dem = 0;
//                char[] tam2 = null;
//                int a2, b2;
//                while (compare(carry, v2) != 1)     //chia carry & v2, dem la ket qua
//                {
//                    dem++;
//                    //su dung phep tru
//                    for (i = 0; i < carry.Length; i++)
//                    {
//                        a2 = Convert.ToInt32(carry[i]);
//                        b2 = Convert.ToInt32(v2[i]);
//                        if (a2 < b2 + nho)        //so bi tru < so tru
//                        {
//                            tam2[i] = Convert.ToChar(a2 - b2 - nho + 10);
//                            nho = 1;
//                        }
//                        else            //so bi tru > so tru
//                        {
//                            tam2[i] = Convert.ToChar(a2 - b2 - nho);
//                            nho = 0;
//                        }
//                    }
//                    tam2[i] = '\0';
//                    //strcpy(carry, tam2);
//                    for (i = 0; i <= tam2.Length; i++)
//                        carry[i] = tam2[i];
//                }
//                xoaSo0(v2);
//                xoaSo0(carry);
//                //gan vao kq.tphan
//                insert_begin(kq.tphan, Convert.ToChar(dem));
//                chuSo++;
//            }
//            kq.tphan.Reverse();
//            xoaSo0(kq.tphan);
//            return kq;
//        }

//        public static int compare(char[] v1, char[] v2)
//        {
//            if (v1.Length > v2.Length)
//                return -1;
//            if (v1.Length < v2.Length)
//                return 1;
//            for (int i = v1.Length - 1; i >= 0; i--)
//            {
//                if (v1[i] > v2[i])
//                    return -1;
//                if (v1[i] < v2[i])
//                    return 1;
//            }
//            return 0;
//        }
//        public static void insert_begin(char[] A, char k)
//        {
//            for (int i = A.Length + 1; i > 0; i--)
//                A[i] = A[i - 1];
//            A[0] = k;
//        }


//    }
//}
