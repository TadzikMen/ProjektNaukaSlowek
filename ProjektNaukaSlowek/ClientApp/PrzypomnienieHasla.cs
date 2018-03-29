using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace ClientApp
{
    public partial class PrzypomnienieHasla : Form
    {
		int losuj;
        public PrzypomnienieHasla()
        {
            InitializeComponent();
        }

        private void Wroc_Click(object sender, EventArgs e)
        {
			Owner.Show();
			Hide();
        }
		
        private void PrzeslijKod_Click(object sender, EventArgs e)
        {
            Random kod = new Random();
            losuj = kod.Next(1000, 9999);
            SmtpClient smtpClient = new SmtpClient(); //tworzymy klienta smtp
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            MailMessage message = new MailMessage();//tworzymy wiadomość
            MailAddress from = new MailAddress("naukaslowek.adm@gmail.com", "Nauka Słówek");//adres nadawcy i nazwa nadawcy
            message.From = from;
            message.To.Add(tbxEmail.Text);//adres odbiorcy
            message.Subject = "Zmiana hasła";//temat wiadomości
			message.Body = "Witamy, \n\nTen adres e - mail jest właśnie używany do odzyskiwania konta w aplikacji Nauka Słówek. " +
							"Jeśli to Ty próbujesz odzyskać konto, wpisz numeryczny kod weryfikacyjny widoczny poniżej. " +
							"Jeśli nie wiesz nic o tej próbie odzyskiwania, ale masz konto w aplikacji Nauka Słówek powiązane z tym adresem e-mail, może to oznaczać, " +
							"że ktoś chce uzyskać dostęp do Twojego konta. Nie przekazuj ani nie podawaj nikomu tego kodu.Wejdź na stronę ustawień logowania i zabezpieczeń, " +
							"by upewnić się, że Twoje konto jest bezpieczne.\n\n\t\t"
							+ losuj + "\n\n Pozdrawiamy, \nZespół aplikacji Nauka Słówek. ";

            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Credentials = new System.Net.NetworkCredential("naukaslowek.adm@gmail.com", "diagrama");
            try
            {
                smtpClient.SendAsync(message, tbxEmail.Text);//nazwa odbiorcy, wysyłamy wiadomość
            }
            catch (SmtpException ex)
            {
                throw new ApplicationException("Klient SMTP wywołał wyjątek. Sprawdź połączenie z internetem." + ex.Message);
            }
            MessageBox.Show("Kod został wysłany na podany adres email. \nSprawdź skrzynkę pocztową.", "Weryfikacja Kodu");
			tbxEmail.Text = null;
        }

        private void WeryfikujKod_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbxKodWeryfikacyjny.Text) == losuj)
            {
				Owner.Show();
				Hide();
            }
            else
            {
                MessageBox.Show("Niepoprawny kod weryfikacyjny");
            }
        }
    }
}
