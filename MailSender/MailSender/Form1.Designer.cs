namespace MailSender
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
            this.SenderID_txt = new System.Windows.Forms.Label();
            this.SenderID = new System.Windows.Forms.TextBox();
            this.SenderPW = new System.Windows.Forms.TextBox();
            this.SenderPW_txt = new System.Windows.Forms.Label();
            this.bt_Send = new System.Windows.Forms.Button();
            this.GetterMailAdd = new System.Windows.Forms.TextBox();
            this.GetterMailAdd_txt = new System.Windows.Forms.Label();
            this.SendToMe = new System.Windows.Forms.CheckBox();
            this.MailTitle = new System.Windows.Forms.TextBox();
            this.MailTitle_txt = new System.Windows.Forms.Label();
            this.MailText = new System.Windows.Forms.TextBox();
            this.MailText_txt = new System.Windows.Forms.Label();
            this.FileList = new System.Windows.Forms.TextBox();
            this.FileList_txt = new System.Windows.Forms.Label();
            this.AddFile = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // SenderID_txt
            // 
            this.SenderID_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderID_txt.AutoSize = true;
            this.SenderID_txt.Location = new System.Drawing.Point(12, 16);
            this.SenderID_txt.Name = "SenderID_txt";
            this.SenderID_txt.Size = new System.Drawing.Size(105, 15);
            this.SenderID_txt.TabIndex = 0;
            this.SenderID_txt.Text = "보내는 사람 ID";
            // 
            // SenderID
            // 
            this.SenderID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderID.Location = new System.Drawing.Point(137, 13);
            this.SenderID.Name = "SenderID";
            this.SenderID.Size = new System.Drawing.Size(397, 25);
            this.SenderID.TabIndex = 1;
            this.SenderID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // SenderPW
            // 
            this.SenderPW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderPW.Location = new System.Drawing.Point(137, 44);
            this.SenderPW.Name = "SenderPW";
            this.SenderPW.PasswordChar = '콩';
            this.SenderPW.Size = new System.Drawing.Size(397, 25);
            this.SenderPW.TabIndex = 2;
            this.SenderPW.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // SenderPW_txt
            // 
            this.SenderPW_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SenderPW_txt.AutoSize = true;
            this.SenderPW_txt.Location = new System.Drawing.Point(12, 47);
            this.SenderPW_txt.Name = "SenderPW_txt";
            this.SenderPW_txt.Size = new System.Drawing.Size(116, 15);
            this.SenderPW_txt.TabIndex = 3;
            this.SenderPW_txt.Text = "보내는 사람 PW";
            // 
            // bt_Send
            // 
            this.bt_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Send.Location = new System.Drawing.Point(541, 14);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(125, 55);
            this.bt_Send.TabIndex = 4;
            this.bt_Send.Text = "전송";
            this.bt_Send.UseVisualStyleBackColor = true;
            this.bt_Send.Click += new System.EventHandler(this.bt_Send_Click);
            this.bt_Send.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // GetterMailAdd
            // 
            this.GetterMailAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetterMailAdd.Location = new System.Drawing.Point(137, 76);
            this.GetterMailAdd.Name = "GetterMailAdd";
            this.GetterMailAdd.Size = new System.Drawing.Size(397, 25);
            this.GetterMailAdd.TabIndex = 5;
            this.GetterMailAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // GetterMailAdd_txt
            // 
            this.GetterMailAdd_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetterMailAdd_txt.AutoSize = true;
            this.GetterMailAdd_txt.Location = new System.Drawing.Point(12, 79);
            this.GetterMailAdd_txt.Name = "GetterMailAdd_txt";
            this.GetterMailAdd_txt.Size = new System.Drawing.Size(107, 15);
            this.GetterMailAdd_txt.TabIndex = 6;
            this.GetterMailAdd_txt.Text = "받는 사람 주소";
            // 
            // SendToMe
            // 
            this.SendToMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendToMe.AutoSize = true;
            this.SendToMe.Location = new System.Drawing.Point(542, 82);
            this.SendToMe.Name = "SendToMe";
            this.SendToMe.Size = new System.Drawing.Size(124, 19);
            this.SendToMe.TabIndex = 7;
            this.SendToMe.Text = "나에게 보내기";
            this.SendToMe.UseVisualStyleBackColor = true;
            this.SendToMe.CheckedChanged += new System.EventHandler(this.SendToMe_CheckedChanged);
            this.SendToMe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // MailTitle
            // 
            this.MailTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailTitle.Location = new System.Drawing.Point(137, 108);
            this.MailTitle.Name = "MailTitle";
            this.MailTitle.Size = new System.Drawing.Size(529, 25);
            this.MailTitle.TabIndex = 8;
            this.MailTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // MailTitle_txt
            // 
            this.MailTitle_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailTitle_txt.AutoSize = true;
            this.MailTitle_txt.Location = new System.Drawing.Point(12, 111);
            this.MailTitle_txt.Name = "MailTitle_txt";
            this.MailTitle_txt.Size = new System.Drawing.Size(37, 15);
            this.MailTitle_txt.TabIndex = 9;
            this.MailTitle_txt.Text = "제목";
            // 
            // MailText
            // 
            this.MailText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailText.Location = new System.Drawing.Point(137, 140);
            this.MailText.Multiline = true;
            this.MailText.Name = "MailText";
            this.MailText.Size = new System.Drawing.Size(529, 361);
            this.MailText.TabIndex = 10;
            this.MailText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // MailText_txt
            // 
            this.MailText_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailText_txt.AutoSize = true;
            this.MailText_txt.Location = new System.Drawing.Point(12, 143);
            this.MailText_txt.Name = "MailText_txt";
            this.MailText_txt.Size = new System.Drawing.Size(37, 15);
            this.MailText_txt.TabIndex = 11;
            this.MailText_txt.Text = "본문";
            // 
            // FileList
            // 
            this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileList.Location = new System.Drawing.Point(137, 508);
            this.FileList.Name = "FileList";
            this.FileList.ReadOnly = true;
            this.FileList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FileList.Size = new System.Drawing.Size(529, 25);
            this.FileList.TabIndex = 12;
            this.FileList.TextChanged += new System.EventHandler(this.FileList_TextChanged);
            // 
            // FileList_txt
            // 
            this.FileList_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileList_txt.AutoSize = true;
            this.FileList_txt.Location = new System.Drawing.Point(44, 511);
            this.FileList_txt.Name = "FileList_txt";
            this.FileList_txt.Size = new System.Drawing.Size(87, 15);
            this.FileList_txt.TabIndex = 13;
            this.FileList_txt.Text = "첨부된 파일";
            // 
            // AddFile
            // 
            this.AddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFile.Location = new System.Drawing.Point(15, 478);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(113, 23);
            this.AddFile.TabIndex = 14;
            this.AddFile.Text = "파일 첨부하기";
            this.AddFile.UseVisualStyleBackColor = true;
            this.AddFile.Click += new System.EventHandler(this.AddFile_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "*.*";
            this.OFD.Filter = "압축 파일|*.zip, *.rar, *.7z|텍스트 파일|*.txt, *.ee|모든 파일|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 545);
            this.Controls.Add(this.AddFile);
            this.Controls.Add(this.FileList_txt);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.MailText_txt);
            this.Controls.Add(this.MailText);
            this.Controls.Add(this.MailTitle_txt);
            this.Controls.Add(this.MailTitle);
            this.Controls.Add(this.SendToMe);
            this.Controls.Add(this.GetterMailAdd_txt);
            this.Controls.Add(this.GetterMailAdd);
            this.Controls.Add(this.bt_Send);
            this.Controls.Add(this.SenderPW_txt);
            this.Controls.Add(this.SenderPW);
            this.Controls.Add(this.SenderID);
            this.Controls.Add(this.SenderID_txt);
            this.Name = "Form1";
            this.Text = "GMAIL 발송기 (도움말 : F1)";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SenderID_txt;
        private System.Windows.Forms.TextBox SenderID;
        private System.Windows.Forms.TextBox SenderPW;
        private System.Windows.Forms.Label SenderPW_txt;
        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.TextBox GetterMailAdd;
        private System.Windows.Forms.Label GetterMailAdd_txt;
        private System.Windows.Forms.CheckBox SendToMe;
        private System.Windows.Forms.TextBox MailTitle;
        private System.Windows.Forms.Label MailTitle_txt;
        private System.Windows.Forms.TextBox MailText;
        private System.Windows.Forms.Label MailText_txt;
        private System.Windows.Forms.TextBox FileList;
        private System.Windows.Forms.Label FileList_txt;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

