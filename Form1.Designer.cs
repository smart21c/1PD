namespace _1PD
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.textBox_PD = new System.Windows.Forms.TextBox();
            this.textBox_HR = new System.Windows.Forms.TextBox();
            this.btn_HRtoPD = new System.Windows.Forms.Button();
            this.btn_PDtoHR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_PD
            // 
            this.textBox_PD.Location = new System.Drawing.Point(93, 36);
            this.textBox_PD.Name = "textBox_PD";
            this.textBox_PD.Size = new System.Drawing.Size(75, 21);
            this.textBox_PD.TabIndex = 1;
            this.textBox_PD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PDtoHR_KeyDown);
            // 
            // textBox_HR
            // 
            this.textBox_HR.Location = new System.Drawing.Point(11, 36);
            this.textBox_HR.Name = "textBox_HR";
            this.textBox_HR.Size = new System.Drawing.Size(76, 21);
            this.textBox_HR.TabIndex = 0;
            this.textBox_HR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HRtoPD_KeyDown);
            // 
            // btn_HRtoPD
            // 
            this.btn_HRtoPD.Location = new System.Drawing.Point(12, 64);
            this.btn_HRtoPD.Name = "btn_HRtoPD";
            this.btn_HRtoPD.Size = new System.Drawing.Size(75, 23);
            this.btn_HRtoPD.TabIndex = 2;
            this.btn_HRtoPD.Text = "시간 -> PD";
            this.btn_HRtoPD.UseVisualStyleBackColor = true;
            this.btn_HRtoPD.Click += new System.EventHandler(this.btn_HRtoPD_Click);
            // 
            // btn_PDtoHR
            // 
            this.btn_PDtoHR.Location = new System.Drawing.Point(93, 63);
            this.btn_PDtoHR.Name = "btn_PDtoHR";
            this.btn_PDtoHR.Size = new System.Drawing.Size(75, 23);
            this.btn_PDtoHR.TabIndex = 3;
            this.btn_PDtoHR.Text = "PD -> 시간";
            this.btn_PDtoHR.UseVisualStyleBackColor = true;
            this.btn_PDtoHR.Click += new System.EventHandler(this.btn_PDtoHR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(113, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "시간";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(13, 94);
            this.TimeBox.Multiline = true;
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(155, 72);
            this.TimeBox.TabIndex = 6;
            this.TimeBox.Text = " 10분 : 0.16\r\n 20분 : 0.33\r\n 30분 : 0.5\r\n 40분 : 0.66\r\n 50분 : 0.83";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(181, 178);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PDtoHR);
            this.Controls.Add(this.btn_HRtoPD);
            this.Controls.Add(this.textBox_HR);
            this.Controls.Add(this.textBox_PD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "1PD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_PD;
        private System.Windows.Forms.TextBox textBox_HR;
        private System.Windows.Forms.Button btn_HRtoPD;
        private System.Windows.Forms.Button btn_PDtoHR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeBox;
    }
}

