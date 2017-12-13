using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 認識Lmabda
{
    public partial class Form1 : Form
    {
        public delegate double AreaDelegate(double r);//委派
        public delegate double AreaDelegate2(double w, double l);//委派

        public Form1()
        {
            InitializeComponent();
        }


        double AreaCircle(double r)//呼叫方法
        {
            return r * r * Math.PI;
        }


        double CustomCircleArea(double r,AreaDelegate ad)//呼叫方法
        {
            return ad(r);
        }

        private void btnCircleArea_Click(object sender, EventArgs e)//lambda運算式
        {
            AreaDelegate CircleArea = r => r * r * Math.PI;

            MessageBox.Show($"圓面積：{CircleArea(5)}");
            MessageBox.Show($"圓面積：{AreaCircle(10)}");

            MessageBox.Show($"圓面積：{CustomCircleArea(5, r => r * r * Math.PI)}");
            MessageBox.Show($"圓面積：{CustomCircleArea(5, r => (r-0.1) * (r-0.1) * Math.PI)}");


            //AreaDelegate SqyareArea = s => s * s;
            //MessageBox.Show($"正方形面積：{SqyareArea(5)}");


            //AreaDelegate2 RectangleArea = (w, l) => w * l;
            //MessageBox.Show($"正方形面積：{RectangleArea(5,10)}");
        }

        private void btnDownload_Click(object sender, EventArgs e)//lambda 檔案下載
        {
            WebClient obj = new WebClient();//NEW一個WebClient物件要 NameSpace
            //DownloadFileCompleted檔案下載完成時事件
            obj.DownloadFileCompleted += ( dssender,de)=>
            {
                MessageBox.Show("檔案下載完成!");
            };


            obj.DownloadFileAsync(new Uri("http://localhost/iisstart.png"), "image9.png");
            //DownloadFileAsync下載資料
            //(new Uri("http://localhost/iisstart.png"), "image9.png");
            //新增一個路徑/ 下載後檔案的名稱
        }

        private void btnodd_Click(object sender, EventArgs e)
        {
            int[] arr = { 11, 24, 65, 43, 112 };
            int OddCount = arr.Count(n => n % 2 == 1);
            MessageBox.Show($"{OddCount} 個奇數");
        }

        private void btnCreateButton_Click(object sender, EventArgs e)
        {
            Button btn = new Button();//新增按金
            btn.Text = "MSIT117";
            btn.Click += (dssender, de)=>
            {
                MessageBox.Show("hello MSIT117 !");
            };
            Controls.Add(btn);
        }

        
    }
}
