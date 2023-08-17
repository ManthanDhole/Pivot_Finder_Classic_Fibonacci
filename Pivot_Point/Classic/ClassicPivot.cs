using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pivot_Point_Finder.Pivot_Point.Classic
{
    public partial class ClassicPivot : Form
    {
        public ClassicPivot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int high = Convert.ToInt32(txt_High.Text);
            int close = Convert.ToInt32(txt_Close.Text);
            int low = Convert.ToInt32(txt_Low.Text);

            //Calculate Pivot
            int pivot = (high + close + low) / 3;
            lbl_PivotValue.Text = pivot.ToString();

            //Calculate Support S1, S2 and S3
            int s1 = (2 * pivot) - high;
            int s2 = pivot - (high - low);
            int s3 = low - (2 * (high - pivot));

            lbl_S1.Text = s1.ToString();
            lbl_S2.Text = s2.ToString();
            lbl_S3.Text = s3.ToString();

            //Calculate Resistance R1, R2 and R3
            int r1 = (2 * pivot) - low;
            int r2 = pivot + (high - low);
            int r3 = high + (2 * (pivot - low));

            lbl_R1.Text = r1.ToString();
            lbl_R2.Text = r2.ToString();
            lbl_R3.Text = r3.ToString();
        }
    }
}
