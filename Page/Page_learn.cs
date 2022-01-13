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
    public partial class Page_learn : UIPage
    {
        public Page_learn()
        {
            InitializeComponent();
        }

        private void Page_learn_Load(object sender, EventArgs e)
        {
            for(int n=1;n<100;n++)
            {

            uiListBox1.Items.Add("控件布局与控件绑定");
            }
        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {

           
           UIStatusForm.ActiveForm.BackColor = Color.FromArgb(56, 56, 56);
       
            UIStatusFormService.ShowStatusForm(); 
           
          
         
        }
    }
}
