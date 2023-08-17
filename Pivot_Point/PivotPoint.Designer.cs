namespace Pivot_Point_Finder.Pivot_Point
{
    partial class PivotPoint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Classic = new System.Windows.Forms.Button();
            this.btn_Fibonacci = new System.Windows.Forms.Button();
            this.panel_Pivot = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_Classic
            // 
            this.btn_Classic.Location = new System.Drawing.Point(246, 45);
            this.btn_Classic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Classic.Name = "btn_Classic";
            this.btn_Classic.Size = new System.Drawing.Size(194, 38);
            this.btn_Classic.TabIndex = 0;
            this.btn_Classic.Text = "Classic Pivot";
            this.btn_Classic.UseVisualStyleBackColor = true;
            this.btn_Classic.Click += new System.EventHandler(this.btn_Classic_Click);
            // 
            // btn_Fibonacci
            // 
            this.btn_Fibonacci.Location = new System.Drawing.Point(529, 45);
            this.btn_Fibonacci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Fibonacci.Name = "btn_Fibonacci";
            this.btn_Fibonacci.Size = new System.Drawing.Size(224, 38);
            this.btn_Fibonacci.TabIndex = 1;
            this.btn_Fibonacci.Text = "Fibonacci Pivot";
            this.btn_Fibonacci.UseVisualStyleBackColor = true;
            this.btn_Fibonacci.Click += new System.EventHandler(this.btn_Fibonacci_Click);
            // 
            // panel_Pivot
            // 
            this.panel_Pivot.Location = new System.Drawing.Point(17, 93);
            this.panel_Pivot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_Pivot.Name = "panel_Pivot";
            this.panel_Pivot.Size = new System.Drawing.Size(941, 385);
            this.panel_Pivot.TabIndex = 2;
            // 
            // PivotPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 548);
            this.Controls.Add(this.panel_Pivot);
            this.Controls.Add(this.btn_Fibonacci);
            this.Controls.Add(this.btn_Classic);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PivotPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PivotPoint";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Classic;
        private Button btn_Fibonacci;
        private Panel panel_Pivot;
    }
}