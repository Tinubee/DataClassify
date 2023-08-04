namespace DataClassify
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
            this.tb파일경로 = new System.Windows.Forms.TextBox();
            this.b파일열기 = new System.Windows.Forms.Button();
            this.b파일변환 = new System.Windows.Forms.Button();
            this.b파일저장 = new System.Windows.Forms.Button();
            this.lb제품개수 = new System.Windows.Forms.Label();
            this.lb상태확인 = new System.Windows.Forms.Label();
            this.tb저장경로 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb파일경로
            // 
            this.tb파일경로.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb파일경로.Location = new System.Drawing.Point(12, 74);
            this.tb파일경로.Name = "tb파일경로";
            this.tb파일경로.Size = new System.Drawing.Size(468, 43);
            this.tb파일경로.TabIndex = 0;
            // 
            // b파일열기
            // 
            this.b파일열기.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b파일열기.Location = new System.Drawing.Point(486, 74);
            this.b파일열기.Name = "b파일열기";
            this.b파일열기.Size = new System.Drawing.Size(206, 43);
            this.b파일열기.TabIndex = 1;
            this.b파일열기.Text = "파일열기";
            this.b파일열기.UseVisualStyleBackColor = true;
            this.b파일열기.Click += new System.EventHandler(this.b파일열기_Click);
            // 
            // b파일변환
            // 
            this.b파일변환.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b파일변환.Location = new System.Drawing.Point(486, 155);
            this.b파일변환.Name = "b파일변환";
            this.b파일변환.Size = new System.Drawing.Size(206, 43);
            this.b파일변환.TabIndex = 2;
            this.b파일변환.Text = "변환";
            this.b파일변환.UseVisualStyleBackColor = true;
            this.b파일변환.Click += new System.EventHandler(this.b파일변환_Click);
            // 
            // b파일저장
            // 
            this.b파일저장.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b파일저장.Location = new System.Drawing.Point(486, 243);
            this.b파일저장.Name = "b파일저장";
            this.b파일저장.Size = new System.Drawing.Size(206, 43);
            this.b파일저장.TabIndex = 3;
            this.b파일저장.Text = "저장";
            this.b파일저장.UseVisualStyleBackColor = true;
            this.b파일저장.Click += new System.EventHandler(this.b파일저장_Click);
            // 
            // lb제품개수
            // 
            this.lb제품개수.AutoSize = true;
            this.lb제품개수.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb제품개수.Location = new System.Drawing.Point(314, 18);
            this.lb제품개수.Name = "lb제품개수";
            this.lb제품개수.Size = new System.Drawing.Size(166, 37);
            this.lb제품개수.TabIndex = 4;
            this.lb제품개수.Text = "제품개수 : 0";
            // 
            // lb상태확인
            // 
            this.lb상태확인.AutoSize = true;
            this.lb상태확인.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb상태확인.Location = new System.Drawing.Point(23, 155);
            this.lb상태확인.Name = "lb상태확인";
            this.lb상태확인.Size = new System.Drawing.Size(148, 45);
            this.lb상태확인.TabIndex = 5;
            this.lb상태확인.Text = "상태확인";
            // 
            // tb저장경로
            // 
            this.tb저장경로.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb저장경로.Location = new System.Drawing.Point(12, 243);
            this.tb저장경로.Name = "tb저장경로";
            this.tb저장경로.Size = new System.Drawing.Size(468, 43);
            this.tb저장경로.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 354);
            this.Controls.Add(this.tb저장경로);
            this.Controls.Add(this.lb상태확인);
            this.Controls.Add(this.lb제품개수);
            this.Controls.Add(this.b파일저장);
            this.Controls.Add(this.b파일변환);
            this.Controls.Add(this.b파일열기);
            this.Controls.Add(this.tb파일경로);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb파일경로;
        private System.Windows.Forms.Button b파일열기;
        private System.Windows.Forms.Button b파일변환;
        private System.Windows.Forms.Button b파일저장;
        private System.Windows.Forms.Label lb제품개수;
        private System.Windows.Forms.Label lb상태확인;
        private System.Windows.Forms.TextBox tb저장경로;
    }
}

