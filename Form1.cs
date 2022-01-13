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
using 移动互联学习系统.Page;

namespace 移动互联学习系统
{
    public partial class Form1 : UIHeaderAsideMainFrame
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            int pageIndex = 1000;
            Aside.CreateNode(AddPage(new Page_index()), 61641,18);
           
           TreeNode parent_xx = Aside.CreateNode("学习", 61641, 18, pageIndex);
            Aside.CreateChildNode(parent_xx, 61819, 18,AddPage(new Page_learn(),++pageIndex));

            TreeNode parent_sc = Aside.CreateNode("手册", 61641, 18, pageIndex);
            TreeNode parent_gy = Aside.CreateNode("关于", 61641, 18, pageIndex);
            Aside.SelectFirst();
        }
    }
}
