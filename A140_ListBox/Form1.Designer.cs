namespace A140_ListBox
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSIndex1 = new System.Windows.Forms.TextBox();
            this.txtSItem1 = new System.Windows.Forms.TextBox();
            this.txtSIndex2 = new System.Windows.Forms.TextBox();
            this.txtSItem2 = new System.Windows.Forms.TextBox();
            this.txtSIndex3 = new System.Windows.Forms.TextBox();
            this.txtSItem3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "중국",
            "영국",
            "독일",
            "프랑스",
            "일본",
            "이스라엘",
            "사우디아라비아",
            "UAE",
            "한국"});
            this.listBox1.Location = new System.Drawing.Point(135, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 214);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(381, 104);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(179, 214);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(607, 104);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(179, 214);
            this.listBox3.TabIndex = 2;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "GDP 순위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "살기좋은 도시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "행복한 나라";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SelectedIndex :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "SelectedItem :";
            // 
            // txtSIndex1
            // 
            this.txtSIndex1.Location = new System.Drawing.Point(141, 341);
            this.txtSIndex1.Name = "txtSIndex1";
            this.txtSIndex1.Size = new System.Drawing.Size(172, 25);
            this.txtSIndex1.TabIndex = 8;
            // 
            // txtSItem1
            // 
            this.txtSItem1.Location = new System.Drawing.Point(142, 380);
            this.txtSItem1.Name = "txtSItem1";
            this.txtSItem1.Size = new System.Drawing.Size(172, 25);
            this.txtSItem1.TabIndex = 9;
            // 
            // txtSIndex2
            // 
            this.txtSIndex2.Location = new System.Drawing.Point(381, 342);
            this.txtSIndex2.Name = "txtSIndex2";
            this.txtSIndex2.Size = new System.Drawing.Size(172, 25);
            this.txtSIndex2.TabIndex = 10;
            // 
            // txtSItem2
            // 
            this.txtSItem2.Location = new System.Drawing.Point(381, 380);
            this.txtSItem2.Name = "txtSItem2";
            this.txtSItem2.Size = new System.Drawing.Size(172, 25);
            this.txtSItem2.TabIndex = 11;
            // 
            // txtSIndex3
            // 
            this.txtSIndex3.Location = new System.Drawing.Point(607, 341);
            this.txtSIndex3.Name = "txtSIndex3";
            this.txtSIndex3.Size = new System.Drawing.Size(172, 25);
            this.txtSIndex3.TabIndex = 12;
            // 
            // txtSItem3
            // 
            this.txtSItem3.Location = new System.Drawing.Point(607, 380);
            this.txtSItem3.Name = "txtSItem3";
            this.txtSItem3.Size = new System.Drawing.Size(172, 25);
            this.txtSItem3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.txtSItem3);
            this.Controls.Add(this.txtSIndex3);
            this.Controls.Add(this.txtSItem2);
            this.Controls.Add(this.txtSIndex2);
            this.Controls.Add(this.txtSItem1);
            this.Controls.Add(this.txtSIndex1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSIndex1;
        private System.Windows.Forms.TextBox txtSItem1;
        private System.Windows.Forms.TextBox txtSIndex2;
        private System.Windows.Forms.TextBox txtSItem2;
        private System.Windows.Forms.TextBox txtSIndex3;
        private System.Windows.Forms.TextBox txtSItem3;
    }
}

