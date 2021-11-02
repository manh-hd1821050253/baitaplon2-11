using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace QuanLySinhVien.Controllers.XuLySinhMaIDTuDong
{
    public class RadomIDstring
    {
        //MSV001 => PHẦN CHỮ MSV => PHẦN SỐ 001 -> msv002 
        public static string SinhMAID(string studentID)
        {
            string NEWID = "", phanchu, phanso;
            phanso = Regex.Match(studentID, @"\d+").Value;
            phanchu = Regex.Match(studentID, @"\D+").Value;
            var phansomoi = Int32.Parse(phanso) + 1;
            NEWID = phanchu +"00"+phansomoi;
            return NEWID; 
        }
    }
}