using MichuBank;

/*Creando un usuario de manera manual 
Client Francisco = new Client(1,"Francisco", "fran@gmail.com", 4000, 'M');
Employe Fernanda = new Employe(2,"Fernanda", "fer@gmail.com", 4000, "IT");
Storage.AddUser(Francisco);
Storage.AddUser(Fernanda);*/

if(args.Length == 0)
    EmailService.SendEmail();
else showMenu();

void showMenu()
{

}