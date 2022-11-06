namespace Weather_Report_Limassol
{
    partial class Form1
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
            this.mainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.weatherPicDayThree = new System.Windows.Forms.PictureBox();
            this.weatherPicDayTwo = new System.Windows.Forms.PictureBox();
            this.weatherPicDayOne = new System.Windows.Forms.PictureBox();
            this.textReportDayOne = new System.Windows.Forms.TextBox();
            this.textReportDayTwo = new System.Windows.Forms.TextBox();
            this.textReportDayThree = new System.Windows.Forms.TextBox();
            this.textDateDayThree = new System.Windows.Forms.TextBox();
            this.textDateDayOne = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicDayThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicDayTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicDayOne)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGrid
            // 
            this.mainGrid.ColumnCount = 3;
            this.mainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainGrid.Controls.Add(this.textBox1, 0, 2);
            this.mainGrid.Controls.Add(this.textDateDayOne, 0, 2);
            this.mainGrid.Controls.Add(this.textDateDayThree, 0, 2);
            this.mainGrid.Controls.Add(this.textReportDayThree, 2, 1);
            this.mainGrid.Controls.Add(this.textReportDayTwo, 1, 1);
            this.mainGrid.Controls.Add(this.weatherPicDayThree, 2, 0);
            this.mainGrid.Controls.Add(this.weatherPicDayTwo, 1, 0);
            this.mainGrid.Controls.Add(this.weatherPicDayOne, 0, 0);
            this.mainGrid.Controls.Add(this.textReportDayOne, 0, 1);
            this.mainGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGrid.Location = new System.Drawing.Point(0, 0);
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowCount = 3;
            this.mainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.mainGrid.Size = new System.Drawing.Size(1024, 717);
            this.mainGrid.TabIndex = 0;
            // 
            // weatherPicDayThree
            // 
            this.weatherPicDayThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weatherPicDayThree.Location = new System.Drawing.Point(692, 10);
            this.weatherPicDayThree.Margin = new System.Windows.Forms.Padding(10);
            this.weatherPicDayThree.Name = "weatherPicDayThree";
            this.weatherPicDayThree.Size = new System.Drawing.Size(322, 266);
            this.weatherPicDayThree.TabIndex = 3;
            this.weatherPicDayThree.TabStop = false;
            // 
            // weatherPicDayTwo
            // 
            this.weatherPicDayTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weatherPicDayTwo.Location = new System.Drawing.Point(351, 10);
            this.weatherPicDayTwo.Margin = new System.Windows.Forms.Padding(10);
            this.weatherPicDayTwo.Name = "weatherPicDayTwo";
            this.weatherPicDayTwo.Size = new System.Drawing.Size(321, 266);
            this.weatherPicDayTwo.TabIndex = 2;
            this.weatherPicDayTwo.TabStop = false;
            // 
            // weatherPicDayOne
            // 
            this.weatherPicDayOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weatherPicDayOne.Location = new System.Drawing.Point(10, 10);
            this.weatherPicDayOne.Margin = new System.Windows.Forms.Padding(10);
            this.weatherPicDayOne.Name = "weatherPicDayOne";
            this.weatherPicDayOne.Size = new System.Drawing.Size(321, 266);
            this.weatherPicDayOne.TabIndex = 1;
            this.weatherPicDayOne.TabStop = false;
            // 
            // textReportDayOne
            // 
            this.textReportDayOne.BackColor = System.Drawing.SystemColors.GrayText;
            this.textReportDayOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textReportDayOne.Location = new System.Drawing.Point(10, 296);
            this.textReportDayOne.Margin = new System.Windows.Forms.Padding(10);
            this.textReportDayOne.Multiline = true;
            this.textReportDayOne.Name = "textReportDayOne";
            this.textReportDayOne.ReadOnly = true;
            this.textReportDayOne.Size = new System.Drawing.Size(321, 266);
            this.textReportDayOne.TabIndex = 4;
            this.textReportDayOne.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textReportDayTwo
            // 
            this.textReportDayTwo.BackColor = System.Drawing.SystemColors.GrayText;
            this.textReportDayTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textReportDayTwo.Location = new System.Drawing.Point(351, 296);
            this.textReportDayTwo.Margin = new System.Windows.Forms.Padding(10);
            this.textReportDayTwo.Multiline = true;
            this.textReportDayTwo.Name = "textReportDayTwo";
            this.textReportDayTwo.ReadOnly = true;
            this.textReportDayTwo.Size = new System.Drawing.Size(321, 266);
            this.textReportDayTwo.TabIndex = 5;
            // 
            // textReportDayThree
            // 
            this.textReportDayThree.BackColor = System.Drawing.SystemColors.GrayText;
            this.textReportDayThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textReportDayThree.Location = new System.Drawing.Point(692, 296);
            this.textReportDayThree.Margin = new System.Windows.Forms.Padding(10);
            this.textReportDayThree.Multiline = true;
            this.textReportDayThree.Name = "textReportDayThree";
            this.textReportDayThree.ReadOnly = true;
            this.textReportDayThree.Size = new System.Drawing.Size(322, 266);
            this.textReportDayThree.TabIndex = 6;
            // 
            // textDateDayThree
            // 
            this.textDateDayThree.BackColor = System.Drawing.SystemColors.GrayText;
            this.textDateDayThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDateDayThree.Location = new System.Drawing.Point(692, 582);
            this.textDateDayThree.Margin = new System.Windows.Forms.Padding(10);
            this.textDateDayThree.Multiline = true;
            this.textDateDayThree.Name = "textDateDayThree";
            this.textDateDayThree.ReadOnly = true;
            this.textDateDayThree.Size = new System.Drawing.Size(322, 125);
            this.textDateDayThree.TabIndex = 7;
            // 
            // textDateDayOne
            // 
            this.textDateDayOne.BackColor = System.Drawing.SystemColors.GrayText;
            this.textDateDayOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDateDayOne.Location = new System.Drawing.Point(351, 582);
            this.textDateDayOne.Margin = new System.Windows.Forms.Padding(10);
            this.textDateDayOne.Multiline = true;
            this.textDateDayOne.Name = "textDateDayOne";
            this.textDateDayOne.ReadOnly = true;
            this.textDateDayOne.Size = new System.Drawing.Size(321, 125);
            this.textDateDayOne.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(10, 582);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(321, 125);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1024, 717);
            this.Controls.Add(this.mainGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Weather Report Limassol";
            this.mainGrid.ResumeLayout(false);
            this.mainGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicDayThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicDayTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPicDayOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainGrid;
        private System.Windows.Forms.PictureBox weatherPicDayThree;
        private System.Windows.Forms.PictureBox weatherPicDayTwo;
        private System.Windows.Forms.PictureBox weatherPicDayOne;
        private System.Windows.Forms.TextBox textReportDayOne;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textDateDayOne;
        private System.Windows.Forms.TextBox textDateDayThree;
        private System.Windows.Forms.TextBox textReportDayThree;
        private System.Windows.Forms.TextBox textReportDayTwo;
    }
}

