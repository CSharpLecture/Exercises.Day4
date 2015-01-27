namespace CsharpSolutions.Exercises.Task19
{
    partial class LinqQueries
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.min = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.odd = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.hulk = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(257, 329);
            this.listBox.TabIndex = 0;
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.Location = new System.Drawing.Point(275, 12);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(133, 36);
            this.min.TabIndex = 1;
            this.min.Text = "Minimum";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.Location = new System.Drawing.Point(275, 54);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(133, 36);
            this.max.TabIndex = 1;
            this.max.Text = "Maximum";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // order
            // 
            this.order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.order.Location = new System.Drawing.Point(275, 96);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(133, 36);
            this.order.TabIndex = 1;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // odd
            // 
            this.odd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.odd.Location = new System.Drawing.Point(275, 138);
            this.odd.Name = "odd";
            this.odd.Size = new System.Drawing.Size(133, 36);
            this.odd.TabIndex = 1;
            this.odd.Text = "Odd";
            this.odd.UseVisualStyleBackColor = true;
            this.odd.Click += new System.EventHandler(this.odd_Click);
            // 
            // last
            // 
            this.last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.last.Location = new System.Drawing.Point(275, 180);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(133, 36);
            this.last.TabIndex = 1;
            this.last.Text = "Last 10 of 25";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // hulk
            // 
            this.hulk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hulk.Location = new System.Drawing.Point(275, 222);
            this.hulk.Name = "hulk";
            this.hulk.Size = new System.Drawing.Size(133, 36);
            this.hulk.TabIndex = 1;
            this.hulk.Text = "Hulk";
            this.hulk.UseVisualStyleBackColor = true;
            this.hulk.Click += new System.EventHandler(this.hulk_Click);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.Location = new System.Drawing.Point(275, 264);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 36);
            this.reset.TabIndex = 1;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // LinqQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 354);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.hulk);
            this.Controls.Add(this.last);
            this.Controls.Add(this.odd);
            this.Controls.Add(this.order);
            this.Controls.Add(this.max);
            this.Controls.Add(this.min);
            this.Controls.Add(this.listBox);
            this.Name = "LinqQueries";
            this.Text = "LinqQueries";
            this.Load += new System.EventHandler(this.LinqQueries_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button odd;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.Button hulk;
        private System.Windows.Forms.Button reset;
    }
}