using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Ports;

namespace barcode_printer
{
    public class printer_dev
    {
        private DateTime _now = DateTime.Now;//��ǰ����
        private string _tmplate_path = "";
        private SerialPort _port = new SerialPort();
        private string code_temple = "";
        //���캯��
        public printer_dev(string code_tmple)
        {
            this.code_temple = code_tmple;
            //_tmplate_path = tmplate_path;
        }
        //���캯��
        public printer_dev()
        {
        }
        //
        //����ģ��·��
        //
        public string Template
        {
            set
            {
                code_temple = value;
            }
            get
            {
                return code_temple;
            }
        }
        
        private char[] code_array = new char[] { 
            '0','1','2','3','4','5','6','7','8','9','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };

        private char[] dd_code_array = new char[] {
             '0','1','2','3','4','5','6','7','8','9','A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y'
        };
        private string calc_timetable0() {
            string r = "M";
            int n = DateTime.Now.Hour;
            if (n >= 7 && n <= 15) {
                r = "M";
            } else if (n >= 15 && n <= 23) {
                r = "L";
            } else if ((n >= 23 && n<= 24) || (n>=0 && n <= 7)) {
                r = "N";
            }
            return r;
        }
        private string calc_timetable1() {
            string r = "M";
            int n = DateTime.Now.Hour;
            if (n >= 7 && n <= 19) {
                r = "M";
            } else/* if (n >= 19 && n <= 7) */{
                r = "N";
            } 
            return r;
        }
        private string true_sn = "";
        private string print_content = "";
        //��ȡ����ӡ��sn
        public string TrueSN {
            get {
                return true_sn;
            }
        }
        //��ȡ���滻�Ĵ�ӡ������
        public string PrintContent {
            get {
                return print_content;
            }
        }
        //�ж������sn�Ƿ���ȷ
        private bool assert_code_is_ok(int len, int sn) {
            bool r = true;
            string sn_code = sn.ToString();
            //û�г���һ��
            if (sn_code.Length > len &&
                (DateTime.Now.Year == _now.Year && 
                DateTime.Now.Month == _now.Month &&
                DateTime.Now.Day == _now.Day)) {
                r = false;
            }             
            return r;
        }

        private string  get_yy_code()
        {
            int year = DateTime.Now.Year;
            Dictionary<int, string> yy_map = new Dictionary<int, string>();
            int start_year = 1990;
            yy_map.Add(start_year++, "A");
            yy_map.Add(start_year++, "B");
            yy_map.Add(start_year++, "C");
            yy_map.Add(start_year++, "D");
            yy_map.Add(start_year++, "E");
            yy_map.Add(start_year++, "F");
            yy_map.Add(start_year++, "G");
            yy_map.Add(start_year++, "H");
            yy_map.Add(start_year++, "J");
            yy_map.Add(start_year++, "K");
            yy_map.Add(start_year++, "L");
            yy_map.Add(start_year++, "M");
            yy_map.Add(start_year++, "N");
            yy_map.Add(start_year++, "P");
            yy_map.Add(start_year++, "R");
            yy_map.Add(start_year++, "S");
            yy_map.Add(start_year++, "T");
            yy_map.Add(start_year++, "U");
            yy_map.Add(start_year++, "V");
            yy_map.Add(start_year++, "W");
            yy_map.Add(start_year++, "X");

            yy_map.Add(start_year++, "1");
            yy_map.Add(start_year++, "2");
            yy_map.Add(start_year++, "3");
            yy_map.Add(start_year++, "4");
            yy_map.Add(start_year++, "5");
            yy_map.Add(start_year++, "6");
            yy_map.Add(start_year++, "7");
            yy_map.Add(start_year++, "8");
            yy_map.Add(start_year++, "9");

            yy_map.Add(start_year++, "A");
            yy_map.Add(start_year++, "B");
            yy_map.Add(start_year++, "C");
            yy_map.Add(start_year++, "D");
            yy_map.Add(start_year++, "E");
            yy_map.Add(start_year++, "F");
            yy_map.Add(start_year++, "G");
            yy_map.Add(start_year++, "H");
            yy_map.Add(start_year++, "J");
            yy_map.Add(start_year++, "K");
            yy_map.Add(start_year++, "L");
            yy_map.Add(start_year++, "M");
            yy_map.Add(start_year++, "N");
            yy_map.Add(start_year++, "P");
            yy_map.Add(start_year++, "R");
            yy_map.Add(start_year++, "S");
            yy_map.Add(start_year++, "T");
            yy_map.Add(start_year++, "U");
            yy_map.Add(start_year++, "V");
            yy_map.Add(start_year++, "W");
            yy_map.Add(start_year++, "X");

            yy_map.Add(start_year++, "1");
            yy_map.Add(start_year++, "2");
            yy_map.Add(start_year++, "3");
            yy_map.Add(start_year++, "4");
            yy_map.Add(start_year++, "5");
            yy_map.Add(start_year++, "6");
            yy_map.Add(start_year++, "7");
            yy_map.Add(start_year++, "8");
            yy_map.Add(start_year++, "9");

            return yy_map[year];
        }

        private string  get_mm_code()
        {
            int month = DateTime.Now.Month;
            Dictionary<int, string> mm_map = new Dictionary<int, string >();
            for (int i= 1; i<=9; i++){
                mm_map.Add(i, i.ToString());
            }
            mm_map.Add(10, "X");
            mm_map.Add(11, "Y");
            mm_map.Add(12, "Z");
            return mm_map[month];
        }


        private string  get_dd_code()
        {
            int day = DateTime.Now.Day;
            return dd_code_array[day].ToString();
        }

        public bool parase_key_code(string sn)
        {
            //�����б仯
            if (DateTime.Now.Year != _now.Year || DateTime.Now.Month != _now.Month || DateTime.Now.Day != _now.Day) {
                _now = DateTime.Now;//����ʱ��
            }
            bool ret = true;//Ĭ��Ϊtrue
            int inter_content = int.Parse(sn);
            //del by shen
            //FileStream fs = new FileStream(Template, FileMode.Open);
            //StreamReader r = new StreamReader(fs);
            //��ȡ��ǰʱ�������
            DateTime now = DateTime.Now;
            //��
            string year_char;
            int tmp = now.Year - 2000;
            year_char = code_array[tmp].ToString();
            string y4 = now.Year.ToString();
            string y2 = y4.Substring(2, 2);
            //��
            string month_char;
            tmp = now.Month;
            month_char = tmp.ToString("X");
            string month_digit;
            month_digit = now.Month.ToString("D2");
            //string month_digit1;
            //month_digit1 = code_array[now.Month].ToString();
            //��
            string day_char;
            tmp = now.Day;
            day_char = code_array[tmp].ToString();
            string day_digit = now.Day.ToString("D2");
            //string day_digit1 = code_array[now.Day].ToString() ;
            //��
            string day_of_year = "";
            day_of_year = now.DayOfYear.ToString("D3");
            //��
            System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar();
            string week_of_year = gc.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday).ToString("D2");
            //ʱ
            string hour = now.Hour.ToString("D2");
            string hour1 =code_array[ now.Hour+10].ToString();
            //��
            string min = now.Minute.ToString("D2");
            //��
            string sec = now.Second.ToString("D2");
            //string tmp_content = r.ReadToEnd();
            string tmp_content = code_temple;
            Regex reg = new Regex(@"@[1,2]h+|@2f+|@2s+|@[1,2,4]y+|@[1,2]d+|@[1,2]m+|@[3,4,5,6]n+|@3t+|@2w+|@3g+|@2g+|@yy+|@mm+|@dd+");
            Match mc = reg.Match(tmp_content, 0);
            while (mc.Success) {
                string v = mc.Value;
                int idx = mc.Index;
                switch (v) {
                    //��
                    case "@1y":
                        tmp_content = tmp_content.Replace("@1y", year_char);
                        break;
                    //��
                    case "@1m":
                        tmp_content = tmp_content.Replace("@1m", month_char);
                        break;
                    //��
                    case "@1d":
                        tmp_content = tmp_content.Replace("@1d", day_char);
                        break;
                    //��
                    case "@2d":
                        tmp_content = tmp_content.Replace("@2d", day_digit);
                        break;
                    //��
                    case "@2m":
                        tmp_content = tmp_content.Replace("@2m", month_digit);
                        break;
                    case "@2h":
                        tmp_content = tmp_content.Replace("@2h", hour);
                        break;
                    case "@1h":
                        tmp_content = tmp_content.Replace("@1h", hour1);
                        break;
                    case "@2f":
                        tmp_content = tmp_content.Replace("@2f", min);
                        break;
                    case "@2s":
                        tmp_content = tmp_content.Replace("@2s", sec);
                        break;
                    case "@2y":
                        tmp_content = tmp_content.Replace("@2y", y2);
                        break;
                    case "@4y":
                        tmp_content = tmp_content.Replace("@4y", y4);
                        break;
                    case "@3t":
                        tmp_content = tmp_content.Replace("@3t", day_of_year);
                        break;
                    case "@2w":
                        tmp_content = tmp_content.Replace("@2w", week_of_year);
                        break;
                    case "@3n":
                        if (!assert_code_is_ok(3, inter_content)) {
                            ret = false;
                            return ret;
                        }
                        tmp_content = tmp_content.Replace("@3n", inter_content.ToString("D3"));
                        break;
                    case "@4n":
                        if (!assert_code_is_ok(4, inter_content)) {
                            ret = false;
                            return ret;
                        }
                        tmp_content = tmp_content.Replace("@4n", inter_content.ToString("D4"));
                        break;
                    case "@5n":
                        if (!assert_code_is_ok(5, inter_content)) {
                            ret = false;
                            return ret;
                        }
                        tmp_content = tmp_content.Replace("@5n", inter_content.ToString("D5"));
                        break;
                    case "@6n":
                        if (!assert_code_is_ok(6, inter_content)) {
                            ret = false;
                            return ret;
                        }
                        tmp_content = tmp_content.Replace("@6n", inter_content.ToString("D6"));
                        break;
                    case "@2g":
                        tmp_content = tmp_content.Replace("@2g", calc_timetable1());
                        break;
                    case "@3g":
                        tmp_content = tmp_content.Replace("@3g", calc_timetable0());
                        break;
                    case "@yy":
                        tmp_content = tmp_content.Replace("@yy", get_yy_code());
                        break;
                    case "@mm":
                        tmp_content = tmp_content.Replace("@mm", get_mm_code());
                        break;
                    case "@dd":
                        tmp_content = tmp_content.Replace("@dd", get_dd_code());
                        break;
                    default:
                        break;
                }
                mc = mc.NextMatch();
            }
            Regex reg1 = new Regex(@"\[[^\[]+\]");
            Match mc1 = reg1.Match(tmp_content, 0);
            if (mc1.Success) {
                true_sn = mc1.Value;
                true_sn = true_sn.Replace("[", "");
                true_sn = true_sn.Replace("]", "");
                true_sn = true_sn.Replace("<", "");
                true_sn = true_sn.Replace(">", "");
                tmp_content = tmp_content.Replace("[", "");
                tmp_content = tmp_content.Replace("]", "");
            }
            //fs.Close();
            print_content = tmp_content;
            return ret;
        }
        /*
        //�����滻�ؼ��ַ�
        public bool parase_key_code(string sn)
        {
            //�����б仯
            if (DateTime.Now.Year != _now.Year || DateTime.Now.Month != _now.Month || DateTime.Now.Day != _now.Day) {
                _now = DateTime.Now;//����ʱ��
            }
            bool ret = true;//Ĭ��Ϊtrue
            int inter_content = int.Parse(sn);
            FileStream fs = new FileStream(Template, FileMode.Open);
            StreamReader r = new StreamReader(fs);
            //��ȡ��ǰʱ�������
            DateTime now = DateTime.Now;
            //��
            string year_char;
            int tmp = now.Year - 2000;
            year_char = code_array[tmp].ToString();
            string y4 = now.Year.ToString();
            string y2 = y4.Substring(2, 2);
            //��
            string month_char ;
            tmp = now.Month;
            month_char = tmp.ToString("X");
            string month_digit;
            month_digit = now.Month.ToString("D2");
            //��
            string day_char;
            tmp = now.Day;
            day_char = code_array[tmp].ToString();
            string day_digit = now.Day.ToString("D2");
            //��
            string day_of_year = "";
            day_of_year = now.DayOfYear.ToString("D3");
            //��
            System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar(); 
            string week_of_year = gc.GetWeekOfYear(DateTime.Now, System.Globalization.CalendarWeekRule.FirstDay,DayOfWeek.Monday).ToString("D2"); 
            //ʱ
            string hour = now.Hour.ToString("D2");
            //��
            string min = now.Minute.ToString("D2");
            //��
            string sec = now.Second.ToString("D2");
            string tmp_content = r.ReadToEnd();
            Regex reg = new Regex(@"#[a-z]+|@[3-6]+|#[2,4]y+|\$[2,3]g+|@s+");
            Match mc = reg.Match(tmp_content, 0);
            while (mc.Success)
            {
                string v = mc.Value;
                int idx = mc.Index;
                switch (v)
                {
                        //��
                    case "#a":
                        tmp_content = tmp_content.Replace("#a", year_char);
                        break;
                        //��
                    case "#b":
                        tmp_content = tmp_content.Replace("#b", month_char);
                        break;
                        //��
                    case "#c":
                        tmp_content = tmp_content.Replace("#c", day_char);
                        break;
                        //��
                    case "#d":
                        tmp_content = tmp_content.Replace("#d", day_digit);
                        break;
                        //��
                    case "#m":
                        tmp_content = tmp_content.Replace("#m", month_digit);
                        break;
                    case "#h":
                        tmp_content = tmp_content.Replace("#h", hour);
                        break;
                    case "#f":
                        tmp_content = tmp_content.Replace("#f", min);
                        break;
                    case "#s":
                        tmp_content = tmp_content.Replace("#s", sec);
                        break;
                    case "#2y":
                        tmp_content = tmp_content.Replace("#2y", y2);
                        break;
                    case "#4y":
                        tmp_content = tmp_content.Replace("#4y", y4);
                        break;
                    case "#t":
                        tmp_content = tmp_content.Replace("#t", day_of_year);
                        break;
                    case "#w":
                        tmp_content = tmp_content.Replace("#w", week_of_year);
                        break;
                    case "@3":
                        if (!assert_code_is_ok(3, inter_content)){
                            ret = false;
                            return ret;
                        }
                        tmp_content = tmp_content.Replace("@3", inter_content.ToString("D3"));
                        break;
                    case "@4":
                        if (!assert_code_is_ok(4, inter_content)){
                            ret = false;
                            return ret;
                        }
                        tmp_content = tmp_content.Replace("@4", inter_content.ToString("D4"));
                        break;
                    case "@5":
                        if (!assert_code_is_ok(5, inter_content)){
                            ret = false;
                            return ret;
                        }
                        tmp_content = tmp_content.Replace("@5", inter_content.ToString("D5"));
                        break;
                    case "@6":
                        if (!assert_code_is_ok(6, inter_content)){
                            ret = false;
                            return ret;
                        }
                        tmp_content = tmp_content.Replace("@6", inter_content.ToString("D6"));
                        break;
                    case "$2g":
                        tmp_content = tmp_content.Replace("$2g", calc_timetable1());
                        break;
                    case "$3g":
                        tmp_content = tmp_content.Replace("$3g", calc_timetable0());
                        break;
                    default:
                        break;
                }
                mc = mc.NextMatch();
            }
            Regex reg1 = new Regex(@"\[[^\[]+\]");
            Match mc1 = reg1.Match(tmp_content, 0);
            if (mc1.Success) {
                true_sn = mc1.Value;
                true_sn = true_sn.Replace("[", "");
                true_sn = true_sn.Replace("]", "");
                true_sn = true_sn.Replace("<", "");
                true_sn = true_sn.Replace(">", "");
                tmp_content = tmp_content.Replace("[", "");
                tmp_content = tmp_content.Replace("]","");
            }
            fs.Close();
            print_content = tmp_content;
            return ret;
        }
         * */
    }
}
