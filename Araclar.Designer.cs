namespace bitirme_bilgen
{
    partial class Araclar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblAraclar = new System.Windows.Forms.Label();
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAraclar
            // 
            this.lblAraclar.AutoSize = true;
            this.lblAraclar.Location = new System.Drawing.Point(163, 18);
            this.lblAraclar.Name = "lblAraclar";
            this.lblAraclar.Size = new System.Drawing.Size(63, 13);
            this.lblAraclar.TabIndex = 1;
            this.lblAraclar.Text = "ARAÇLAR :";
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.AllowUserToAddRows = false;
            this.dgvAraclar.AllowUserToDeleteRows = false;
            this.dgvAraclar.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(166, 45);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.ReadOnly = true;
            this.dgvAraclar.Size = new System.Drawing.Size(243, 150);
            this.dgvAraclar.TabIndex = 2;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(39, 201);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sonuc";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(492, 246);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Araclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 484);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvAraclar);
            this.Controls.Add(this.lblAraclar);
            this.Name = "Araclar";
            this.Text = "ARAÇLAR";
            this.Load += new System.EventHandler(this.Araclar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAraclar;
        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}