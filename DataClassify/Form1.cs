using DevExpress.Data.Helpers;
using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static DevExpress.Utils.HashCodeHelper;

namespace DataClassify
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<string> 행정보 = new List<string>();
        Microsoft.Office.Interop.Excel.Application excelApp = null;
        Microsoft.Office.Interop.Excel.Workbook excelWorkbook = null;
        List<최종정보> c최종정보;
        int indexNumber = 0;
        int productCount = 0;

        public Form1()
        {
            InitializeComponent();
            c최종정보 = new List<최종정보>();
        }

        private void b파일열기_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lb상태확인.Text = "엑셀파일 읽는중...";
                tb파일경로.Text = ofd.FileName;
                엑셀데이터불러오기(tb파일경로.Text);
            }
            lb상태확인.Text = "파일 불러오기 완료.";
        }

        private void 엑셀데이터불러오기(string 경로)
        {
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelWorkbook = excelApp.Workbooks.Open(경로);

            Microsoft.Office.Interop.Excel.Worksheet worksheet = excelWorkbook.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range usedRange = worksheet.UsedRange;
            int rowCount = usedRange.Rows.Count; //24
            int colCount = usedRange.Columns.Count; //1
            productCount = rowCount / 3;

            lb제품개수.Text = $"제품개수 : {productCount}";

            worksheet = excelWorkbook.Worksheets[1];
            for (int row = 1; row <= rowCount; row++)
            {
                object cellValue = usedRange.Cells[row, 1].Value;
                행정보.Add(cellValue.ToString());
            }

            for (int lop = 0; lop < rowCount / 3; lop++)
            {
                c최종정보.Add(new 최종정보 { });
            }
            excelWorkbook.Close();
            excelApp.Quit();
        }

        private void b파일변환_Click(object sender, EventArgs e)
        {
            for (int lop = 0; lop < 행정보.Count; lop++)
            {
                string[] spliteText = 행정보[lop].Split(';');
                if (lop % 3 == 0)
                {
                    if (lop > 2) indexNumber++;

                    DateTime 시간 = ConvertToDateTime(spliteText[1]);
                    c최종정보[indexNumber].첫번째바코드 = 행정보[lop];
                    c최종정보[indexNumber].일자 = 시간.ToString("yyyy-MM-dd");
                    c최종정보[indexNumber].시간 = 시간.ToString("HH:mm:ss");
                    c최종정보[indexNumber].CSC코드 = $"{spliteText[2]}-{spliteText[3]}";
                    c최종정보[indexNumber].ADDRESS = $"{spliteText[4]}-{spliteText[5]}-{spliteText[6]}-{spliteText[7]}";
                }
                else
                {
                    if (spliteText[0].StartsWith("^R"))
                    {
                        c최종정보[indexNumber].FFCRR = $"{spliteText[0].Substring(1)};{spliteText[1]};";
                    }
                    else
                    {
                        c최종정보[indexNumber].FFCFR = $"{spliteText[0].Substring(1)};{spliteText[1]};";
                    }
                }
            }
            중복항목제거();
            lb상태확인.Text = "데이터 변환완료.";
        }

        public void 중복항목제거()
        {
            var duplicateIds = c최종정보
          .GroupBy(item => item.첫번째바코드)
          .Where(group => group.Count() > 1)
          .Select(group => group.Key)
          .ToList();

            c최종정보.RemoveAll(item => duplicateIds.Contains(item.첫번째바코드));

            var check = c최종정보;
        }

        static DateTime ConvertToDateTime(string inputString)
        {
            string datePart = inputString.Substring(0, 6); // "230801"
            string timePart = inputString.Substring(6, 4); // "0048"
            string zonePart = inputString.Substring(10, 1); // "B"

            int year = int.Parse(datePart.Substring(0, 2)) + 2000;
            int month = int.Parse(datePart.Substring(2, 2));
            int day = int.Parse(datePart.Substring(4, 2));
            Random random = new Random();
            int hour = random.Next(0, 24);
            int minute = random.Next(0, 60);
            int randomNumber = random.Next(0, 60);

            DateTime dateTime = new DateTime(year, month, day, hour, minute, randomNumber);

            return dateTime;
        }

        private void b파일저장_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tb저장경로.Text = fbd.SelectedPath;
                string Root = tb저장경로.Text;
                StreamWriter Writer;
                if (!Directory.Exists(Root))
                {
                    Directory.CreateDirectory(Root);
                }
                Root += $@"\ConvertData.csv";
                Writer = new StreamWriter(Root, true, Encoding.UTF8);
                Writer.WriteLine($"설비명,일자,시간,모델,CSC 코드,ADDRESS,FFC FR,FFC RR");

                for (int lop = 0; lop < c최종정보.Count(); lop++)
                {
                    Writer.WriteLine($"{c최종정보[lop].설비명},{c최종정보[lop].일자},{c최종정보[lop].시간},{c최종정보[lop].모델},{c최종정보[lop].CSC코드},{c최종정보[lop].ADDRESS},{c최종정보[lop].FFCFR},{c최종정보[lop].FFCRR},");
                }

                Writer.Close();

                lb상태확인.Text = "파일 저장완료.";
            }
        }
    }
}
