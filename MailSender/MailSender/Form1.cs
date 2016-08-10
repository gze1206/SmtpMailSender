using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace MailSender
{
    public partial class Form1 : Form
    {
        //전역 변수 선언
        const string GMAIL_SMTP = "smtp.gmail.com";             //Gmail SMTP의 주소입니다.
        const int GMAIL_PORT = 25;                              //Gmail SMTP의 SSL용 포트입니다.
        const int MAX_FILE_COUNT = 10;                          //최대로 첨부할 수 있는 파일의 갯수입니다.
        string[] FileListArray = new string[MAX_FILE_COUNT];    //첨부 파일들의 전체 경로를 담은 배열입니다.
        int FileCount = 0;                                      //첨부된 파일의 갯수입니다.

        const string GMAIL_MAIL = "@gmail.com";                 //Gmail의 계정명 뒤에 붙는 메일 주소입니다.

        //폼 생성자
        public Form1()
        {
            InitializeComponent();                              //아무 것도 없습니다.
        }

        //'나에게 보내기' 체크박스의 체크 상태가 바뀌면 호출됩니다.
        private void SendToMe_CheckedChanged(object sender, EventArgs e)
        {
            if (SendToMe.Checked)                                   //만약, 체크가 되었다면
                GetterMailAdd.Text = SenderID.Text + GMAIL_MAIL;    //받는 사람의 메일 주소를 보내는 사람의 계정명 + 메일 주소로 변경합니다.
            else                                                    //체크가 풀렸다면
                GetterMailAdd.Text = "";                            //받는 사람의 메일 주소를 비웁니다.
            GetterMailAdd.ReadOnly = SendToMe.Checked;              //받는 사람의 메일 주소 입력란의 읽기 전용은 이 체크박스의 체크 상태와 같습니다. (체크 - 읽기 전용, 체크 해제 - 읽기/쓰기 가능)
        }

        //전송 버튼을 눌렀을 때 호출됩니다.
        private void bt_Send_Click(object sender, EventArgs e)
        {
            MailAddress mailFrom = new MailAddress(SenderID.Text + GMAIL_MAIL, SenderID.Text, Encoding.UTF8);       //보내는 사람의 메일 주소 정보입니다. (메일주소, 계정명, 인코딩)
            MailAddress mailTo = new MailAddress(GetterMailAdd.Text);                                               //받는 사람의 메일 주소 정보입니다. (메일주소)

            SmtpClient SMTPclient = new SmtpClient(GMAIL_SMTP, GMAIL_PORT);                                         //SMTP 클라이언트를 설정합니다.

            MailMessage message = new MailMessage(mailFrom, mailTo);                                                //메일의 정보입니다. (보내는 사람, 받는 사람)

            message.Subject = MailTitle.Text;                                                                       //메일의 제목을 설정합니다.
            message.Body = MailText.Text;                                                                           //메일의 본문을 설정합니다.
            message.BodyEncoding = Encoding.UTF8;                                                                   //메일 본문의 인코딩을 설정합니다.
            message.SubjectEncoding = Encoding.UTF8;                                                                //메일 제목의 인코딩을 설정합니다.

            Attachment attach;                                                                                      //첨부파일의 설정을 시작합니다.
            for (int i = 0; i<FileCount; i++)                                                                       //첨부된 파일의 갯수만큼 반복됩니다.
            {
                attach = new Attachment(FileListArray[i]);                                                          //미리 만들어둔 변수와 파일의 전체 경로를 이용해 첨부파일을 설정합니다.
                message.Attachments.Add(attach);                                                                    //메일에 파일을 추가합니다.
            }

            SMTPclient.EnableSsl = true;                                                                            //SSL을 설정합니다. Google은 SSL을 사용해야 SMTP에 연결 가능합니다.
            SMTPclient.DeliveryMethod = SmtpDeliveryMethod.Network;                                                 //SMTP의 전송 방법을 설정합니다.
            SMTPclient.Credentials = new System.Net.NetworkCredential(SenderID.Text + GMAIL_MAIL, SenderPW.Text);   //SMTP 서버에 인증을 받습니다.
            SMTPclient.Send(message);                                                                               //메일을 보냅니다.
        }

        //파일 추가 버튼을 눌렀을 때 호출됩니다.
        private void AddFile_Click(object sender, EventArgs e)
        {
            if (FileCount < MAX_FILE_COUNT)                                     //현재 파일 갯수가 최대 갯수를 넘기지 않았으면,
            {
                if (OFD.ShowDialog() == DialogResult.OK)                        //파일 선택창을 열고, 확인버튼을 누르길 기다립니다.
                {
                    FileListArray[FileCount++] = OFD.FileName;                  //파일 전체 경로를 변수에 저장합니다.
                    FileList.Text += Path.GetFileName(OFD.FileName) + "    ";   //파일의 이름과 확장자를 읽어 텍스트박스에 표기합니다.
                }
            }
        }

        //파일 리스트가 변경되었을 때 호출되는 디버그용 함수입니다.
        private void FileList_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(FileListArray[0]);                    //첫 번째 첨부파일의 전체 경로를 출력합니다.
        }

        //키 입력이 이루어졌을 때 호출되는 함수입니다.
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)                               //입력된 키가 F1이라면
            {
                new Help().ShowDialog();                            //도움말을 띄웁니다.
            }
        }
    }
}
