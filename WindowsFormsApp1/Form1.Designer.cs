namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnReSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnter
            // 
            this.txtEnter.Location = new System.Drawing.Point(209, 75);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(100, 22);
            this.txtEnter.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblMsg.Location = new System.Drawing.Point(73, 78);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(130, 12);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "請輸入4位數子(不重複):";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(205, 115);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "開始";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(116, 163);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(164, 104);
            this.txtResult.TabIndex = 3;
            // 
            // btnReSet
            // 
            this.btnReSet.Location = new System.Drawing.Point(116, 115);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(75, 23);
            this.btnReSet.TabIndex = 4;
            this.btnReSet.Text = "重新開始";
            this.btnReSet.UseVisualStyleBackColor = true;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 317);
            this.Controls.Add(this.btnReSet);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnReSet;
    }
}

