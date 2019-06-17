namespace LiveChartsWinFormCSharp
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.image = new System.Windows.Forms.PictureBox();
            this.btnFileSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(360, 12);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(428, 426);
            this.chart.TabIndex = 1;
            // 
            // image
            // 
            this.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.image.Location = new System.Drawing.Point(12, 52);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(325, 371);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.White;
            this.btnFileSelect.Location = new System.Drawing.Point(12, 12);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(84, 32);
            this.btnFileSelect.TabIndex = 3;
            this.btnFileSelect.Text = "File Select...";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.OnClickBtnFileSelect);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.image);
            this.Controls.Add(this.chart);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button btnFileSelect;
    }
}

