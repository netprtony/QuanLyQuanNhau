using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanNhau
{
    public class ReadMoney
    {
        int number;
        string doc(int a)
        {
            string s = "";
            switch (a)
            {
                case 1:
                    s = " một";
                    break;
                case 2:
                    s = " hai";
                    break;
                case 3:
                    s = " ba";
                    break;
                case 4:
                    s = " bốn";
                    break;
                case 5:
                    s = " năm";
                    break;
                case 6:
                    s = " sáu";
                    break;
                case 7:
                    s = " bảy";
                    break;
                case 8:
                    s = " tám";
                    break;
                case 9:
                    s = " chín";
                    break;


            }
            return s;
        }

        public string docHang(int hang)
        {
            switch (hang)
            {
                case 1: return "";
                case 2: return "nghìn";
                case 3: return "triệu";
                case 4: return "tỷ";
                default: return "";
            }


        }
        public string docBaChuSo(int so)
        {
            string s = null;
            int n = number;
            int donvi = so % 10;
            int chuc = so / 10 % 10;
            int tram = so / 100 % 10;

            if (tram != 0)
            {
                s += doc(tram) + " trăm";
                if (chuc != 0)
                {
                    if (chuc == 1)
                    {
                        s += " mười";
                        //if (donvi == 1)
                        //    s += doc(donvi);
                    }
                    else
                    {
                        //if (donvi == 1)
                        //    s += "mốt";
                        s += " " + doc(chuc) + " mươi";
                    }


                    if (donvi == 5)
                    {
                        s += " lăm ";
                    }
                    else if (chuc != 1 && donvi == 1)
                    {
                        s += " mốt";
                    }
                    else s += doc(donvi);



                }

                else if (donvi != 0)
                {
                    s += " lẻ " + doc(donvi);
                }


            }
            else if (chuc != 0)
            {
                if (chuc == 1)
                {
                    s += " mười ";
                }
                else
                    s += doc(chuc) + " mươi ";
                if (donvi == 5)
                {
                    s += " lăm";
                }
                if (chuc != 1)
                {
                    if (donvi == 1)
                        s += "mốt";
                }
                else s += doc(donvi);

            }
            else if (donvi != 0)
            {
                s += doc(donvi);
            }
            return s;
        }
        public string docSoThanhChu(long so)
        {

            if (so == 0) { return "không"; }
            int hang = 1;

            StringBuilder result = new StringBuilder();
            while (so > 0)
            {
                int nho = (int)(so % 1000);
                if (nho > 0)
                {
                    result.Insert(0, docHang(hang) + " ");
                }
                result.Insert(0, docBaChuSo(nho) + " ");
                so /= 1000;
                hang++;
            }
            return result.ToString().Trim();
        }
    }
}
