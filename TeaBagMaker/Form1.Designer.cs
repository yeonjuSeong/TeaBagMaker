namespace TeaBagMaker
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
            this.components = new System.ComponentModel.Container();
            this.tea = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tea
            // 
            this.tea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tea.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tea.FormattingEnabled = true;
            this.tea.Location = new System.Drawing.Point(32, 50);
            this.tea.Name = "tea";
            this.tea.Size = new System.Drawing.Size(275, 22);
            this.tea.TabIndex = 0;
            this.tea.SelectedIndexChanged += new System.EventHandler(this.Tea_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(8, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(330, 21);
            this.label.TabIndex = 1;
            this.label.Text = "티백을 고르고, 차 우리기를 시작하세요.";
            this.label.Click += new System.EventHandler(this.Label1_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start.Location = new System.Drawing.Point(209, 89);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(98, 39);
            this.start.TabIndex = 2;
            this.start.Text = "차 우리기";
            this.start.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("나눔고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox.Location = new System.Drawing.Point(32, 89);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(171, 39);
            this.textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 140);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tea time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tea;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox;
    }
}

