
namespace LearnSocketSIC
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.lsvChat = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 64);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "スタート";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(282, 12);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(132, 64);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "＋クライエント";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // lsvChat
            // 
            this.lsvChat.HideSelection = false;
            this.lsvChat.Location = new System.Drawing.Point(12, 97);
            this.lsvChat.Name = "lsvChat";
            this.lsvChat.Size = new System.Drawing.Size(402, 357);
            this.lsvChat.TabIndex = 2;
            this.lsvChat.UseCompatibleStateImageBehavior = false;
            this.lsvChat.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 466);
            this.Controls.Add(this.lsvChat);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "サーバ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.ListView lsvChat;
    }
}

