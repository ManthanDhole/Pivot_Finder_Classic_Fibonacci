using Pivot_Point_Finder.Pivot_Point.Classic;
using Pivot_Point_Finder.Pivot_Point.Fibonacci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pivot_Point_Finder.Pivot_Point
{
    public partial class PivotPoint : Form
    {
        public PivotPoint()
        {
            InitializeComponent();
        }

        private void btn_Classic_Click(object sender, EventArgs e)
        {
            if(panel_Pivot.Controls.Count > 0)
            {
                panel_Pivot.Controls.RemoveAt(0);
            }
            ClassicPivot cPivot = new ClassicPivot();
            cPivot.TopLevel = false;
            panel_Pivot.Controls.Add(cPivot);
            cPivot.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cPivot.Dock = DockStyle.Fill;
            cPivot.Show();
        }

        private void btn_Fibonacci_Click(object sender, EventArgs e)
        {
            if (panel_Pivot.Controls.Count > 0)
            {
                panel_Pivot.Controls.RemoveAt(0);
            }
            FibonacciPivot fibPivot = new FibonacciPivot();
            fibPivot.TopLevel = false;
            panel_Pivot.Controls.Add(fibPivot);
            fibPivot.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fibPivot.Dock = DockStyle.Fill;
            fibPivot.Show();
        }
    }
}
