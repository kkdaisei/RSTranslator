using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Microsoft.VisualBasic;

namespace HellowWpfApp
{
    public static class Utility
    {
        public static String telephone(string s1, string s2, string s3)
        {
            return s1 + "-" + s2 + "-" + s3;
        }

        public static String rakutenRecieverTelephone(RakutenCSV r)
        {
            return telephone(r.receiverTelephone1, r.receiverTelephone2, r.receiverTelephone3);
        }
        public static String rakutenClientTelephone(RakutenCSV r)
        {
            return telephone(r.orderTelephone1, r.orderTelephone2, r.orderTelephone3);
        }

        public static String Mid(this string s1, int start, int length)
        {
            var endPos = start + length;
            if (s1.Length <= start)
            {
                return "";
            }

            length = Math.Min(s1.Length - start, length);

            return s1.Substring(start, length);
        }

        public static String first16Note(this string s1)
        {
            return s1.Mid(0, 16);
        }
        public static String second16Note(this string s1)
        {
            return s1.Mid(16, 16);
        }
        public static String third16Note(this string s1)
        {
            return s1.Mid(32, 16);
        }
        public static String fourth16Note(this string s1)
        {
            return s1.Mid(48, 16);
        }
        public static String fifth16Note(this string s1)
        {
            return s1.Mid(64, 16);
        }

        public static String first32Note(this string s1)
        {
            return s1.Mid(0, 32);
        }
        public static String second32Note(this string s1)
        {
            return s1.Mid(32, 32);
        }
        public static String third32Note(this string s1)
        {
            return s1.Mid(64, 32);
        }
        public static String fourth32Note(this string s1)
        {
            return s1.Mid(96, 32);
        }
        public static String fifth32Note(this string s1)
        {
            return s1.Mid(128, 32);
        }

        public static String RemoveIgnoreWords(this string my)
        {
            var s1 = my.Replace("<br>", " ");
            var re = new Regex("【[^】]*?】");
            s1 = re.Replace(s1, "");

            return s1;
        }

        public static String toWide( this string my)
        {
            return Strings.StrConv(my, VbStrConv.Wide, 0x0411);
        }
    }
}
