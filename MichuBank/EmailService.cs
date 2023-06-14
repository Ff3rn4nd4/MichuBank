using MailKit.Net.Smtp;
using MimeKit;

namespace MichuBank;
public static class EmailService
{
    public static void SendEmail()
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress ("Fernanda Guerra", "mtmrphases@gmail.com"));
        message.To.Add(new MailboxAddress ("Admin", "grfernanda13@gmail.com"));
        message.Subject = "MichuBank: Usuarios Nuevos";

        message.Body = new TextPart("plain")
        {
            Text = GetEmailText()
        };

        using (var client = new SmtpClient()){
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("mtmrphases@gmail.com", "nkopscheadzgasqb");
            client.Send(message);
            client.Disconnect(true);
        }
    }

    private static string GetEmailText()
    {
        List<User> NewUsers = Storage.GetNewUsers();

        if(NewUsers.Count == 0)
            return "No hay usuarios registrados por el momento.";

        string emailText = "Usuarios agregados hoy: \n";

        foreach (User user in NewUsers)
            emailText += "\t+" + user.ShowData() + "\n";
        
        return emailText;
    }
}