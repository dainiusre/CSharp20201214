
namespace _20210113_KortuZaidimas
{
    partial class KortuStalas
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
            this.Zaidejas1RankaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Zaidejas2RankaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ZaidimoZonaPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Zaidejas1RankaPanel
            // 
            this.Zaidejas1RankaPanel.AutoScroll = true;
            this.Zaidejas1RankaPanel.Location = new System.Drawing.Point(12, 291);
            this.Zaidejas1RankaPanel.Name = "Zaidejas1RankaPanel";
            this.Zaidejas1RankaPanel.Size = new System.Drawing.Size(776, 124);
            this.Zaidejas1RankaPanel.TabIndex = 0;
            // 
            // Zaidejas2RankaPanel
            // 
            this.Zaidejas2RankaPanel.AutoScroll = true;
            this.Zaidejas2RankaPanel.Location = new System.Drawing.Point(12, 12);
            this.Zaidejas2RankaPanel.Name = "Zaidejas2RankaPanel";
            this.Zaidejas2RankaPanel.Size = new System.Drawing.Size(776, 118);
            this.Zaidejas2RankaPanel.TabIndex = 1;
            // 
            // ZaidimoZonaPanel
            // 
            this.ZaidimoZonaPanel.Location = new System.Drawing.Point(287, 136);
            this.ZaidimoZonaPanel.Name = "ZaidimoZonaPanel";
            this.ZaidimoZonaPanel.Size = new System.Drawing.Size(222, 149);
            this.ZaidimoZonaPanel.TabIndex = 2;
            // 
            // KortuStalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZaidimoZonaPanel);
            this.Controls.Add(this.Zaidejas2RankaPanel);
            this.Controls.Add(this.Zaidejas1RankaPanel);
            this.Name = "KortuStalas";
            this.Text = "Kortu Stalas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Zaidejas1RankaPanel;
        private System.Windows.Forms.FlowLayoutPanel Zaidejas2RankaPanel;
        private System.Windows.Forms.Panel ZaidimoZonaPanel;
    }
}

