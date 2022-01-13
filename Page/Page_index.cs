using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
namespace 移动互联学习系统.Page
{
    public partial class Page_index : UIPage
    {
        public Page_index()
        {
            InitializeComponent();
           
        }

        private void Page_index_Load(object sender, EventArgs e)
        {
            var option = new UIDoughnutOption();

            //设置Title
            option.Title = new UITitle();
            option.Title.Text = "SunnyUI";
            option.Title.SubText = "Star";
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;

            option.Legend.AddData("正确率");
            option.Legend.AddData("错误率");

            //设置Series
            var series = new UIDoughnutSeries();
            series.Name = "";
            series.Center = new UICenter(50, 55);
            series.Radius.Inner = 40;
            series.Radius.Outer = 70;
            series.Label.Show = true;
            series.Label.Position = UIPieSeriesLabelPosition.Center;

            //增加数据
            series.AddData("正确率", 38);
            series.AddData("错误率", 62);

            //增加Series
            option.Series.Add(series);

            //设置Option
            uiDoughnutChart1.SetOption(option);
            uiDoughnutChart1.FillColor = Color.FromArgb(56, 56, 56);
            uiDoughnutChart1.RectColor = Color.Transparent;
           
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void uiMarkLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
