using MichuBank;

//Creando un usuario de manera manual 
User Fernanda = new User();
Fernanda.Id=1;
Fernanda.Name="Fernanda";
Fernanda.Email="gr_fer@gmail.com";
Fernanda.Balance= 50000;
Fernanda.RegisterDate= DateTime.Now;

Console.WriteLine(Fernanda.ShowData());