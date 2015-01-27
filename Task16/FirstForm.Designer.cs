namespace CsharpSolutions.Exercises.Task16
{
    partial class FirstForm
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
            this.modalSelection = new System.Windows.Forms.ComboBox();
            this.open = new System.Windows.Forms.Button();
            this.target = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modalSelection
            // 
            this.modalSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modalSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modalSelection.FormattingEnabled = true;
            this.modalSelection.Items.AddRange(new object[] {
            "Blocking",
            "Non-Blocking"});
            this.modalSelection.Location = new System.Drawing.Point(12, 12);
            this.modalSelection.Name = "modalSelection";
            this.modalSelection.Size = new System.Drawing.Size(260, 21);
            this.modalSelection.TabIndex = 0;
            // 
            // open
            // 
            this.open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.open.Location = new System.Drawing.Point(12, 39);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(260, 36);
            this.open.TabIndex = 1;
            this.open.Text = "Open second form";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // target
            // 
            this.target.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.target.Location = new System.Drawing.Point(12, 78);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(260, 175);
            this.target.TabIndex = 2;
            this.target.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.target);
            this.Controls.Add(this.open);
            this.Controls.Add(this.modalSelection);
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox modalSelection;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Label target;
    }
}