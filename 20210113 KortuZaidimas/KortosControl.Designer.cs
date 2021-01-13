
namespace _20210113_KortuZaidimas
{
    partial class KortosControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZymejimasLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZymejimasLbl
            // 
            this.ZymejimasLbl.AutoSize = true;
            this.ZymejimasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ZymejimasLbl.Location = new System.Drawing.Point(33, 10);
            this.ZymejimasLbl.Name = "ZymejimasLbl";
            this.ZymejimasLbl.Size = new System.Drawing.Size(0, 20);
            this.ZymejimasLbl.TabIndex = 0;
            // 
            // KortosControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ZymejimasLbl);
            this.Name = "KortosControl";
            this.Size = new System.Drawing.Size(78, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ZymejimasLbl;
    }
}
