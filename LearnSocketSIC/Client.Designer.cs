
namespace LearnSocketSIC
{
    partial class Client
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
            this.btnAccess = new System.Windows.Forms.Button();
            this.lsvChat = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccess
            // 
            this.btnAccess.Location = new System.Drawing.Point(271, 12);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(125, 62);
            this.btnAccess.TabIndex = 0;
            this.btnAccess.Text = "アクセス";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // lsvChat
            // 
            this.lsvChat.HideSelection = false;
            this.lsvChat.Location = new System.Drawing.Point(12, 93);
            this.lsvChat.Name = "lsvChat";
            this.lsvChat.Size = new System.Drawing.Size(384, 257);
            this.lsvChat.TabIndex = 1;
            this.lsvChat.UseCompatibleStateImageBehavior = false;
            this.lsvChat.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "名前";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(92, 368);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(199, 26);
            this.txbName.TabIndex = 3;
            // 
            // txbContent
            // 
            this.txbContent.Location = new System.Drawing.Point(92, 422);
            this.txbContent.Name = "txbContent";
            this.txbContent.Size = new System.Drawing.Size(199, 26);
            this.txbContent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "内容";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(297, 371);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 73);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "送信";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 460);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvChat);
            this.Controls.Add(this.btnAccess);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Client";
            this.Text = "クライエント";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.ListView lsvChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
    }
}