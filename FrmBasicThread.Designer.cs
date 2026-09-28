namespace BasicThreading
{
    partial class FrmBasicThread
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnRun = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRun.Location = new Point(117, 173);
            btnRun.Margin = new Padding(4, 3, 4, 3);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(117, 40);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(62, 84);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(233, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "-Before starting thread-";
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 288);
            Controls.Add(lblStatus);
            Controls.Add(btnRun);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBasicThread";
            Text = "BasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblStatus;
    }
}