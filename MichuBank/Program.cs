using System.Text.RegularExpressions;
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
    Console.Clear();
    Console.WriteLine("---------------------------------- Michu Bank ----------------------------------");
    Console.WriteLine("Ambas opcines solo estan disponibles para usuarios de este banco");
    Console.WriteLine("1. Crear un usuario nuevo");
    Console.WriteLine("2. Eliminar un usuario existente");
    Console.WriteLine("3. Salir del programa");
    Console.WriteLine("\tIngrese una opcion:");
    
    //Manera diferente de hacer un menu
    int option = 0;
    do{
        string input = Console.ReadLine();

        if(!int.TryParse(input, out option))
            Console.WriteLine ("Ingresa una opcion de las anteriores: ");
        else if(option > 3)
            Console.WriteLine("Oops! esa opcion no existe, ingresa una invalida");

    }while(option == 0 || option > 3);

    switch(option)
    {
         case 1:
            CreateNewUser();
            break;

         case 2:
            DeleteUser();
            break;

         case 3:
            Environment.Exit(0);
            break;
    }
}

void CreateNewUser()
{
    Console.Clear();
    Console.WriteLine("Ingrese la informacion del nuevo usuario");
    Console.Write("Id: ");
    int Id = int.Parse(Console.ReadLine());

    do{
        if(Storage.IsIdExist(Id))
        {
            Console.WriteLine("Este Id ya existe!");
            Console.WriteLine("\t Intentalo de nuevo: ");
            Console.Write("Id: ");
            Id = int.Parse(Console.ReadLine());
        }else if (Id < 0)
            {
                Console.WriteLine("Este Id es invalido!, solo aceptamos Id's positivos");
                Console.WriteLine("\t Intentalo de nuevo: ");
                Console.Write("Id: ");
                Id = int.Parse(Console.ReadLine());
            }
    }while(Storage.IsIdExist(Id)! && Id > 0);
    

    Console.Write("Nombre: ");
    string Name = Console.ReadLine();
    Console.Write("Email:");
    string Email = Console.ReadLine();
        if(ValidacionEmail(Email))
        {
            Console.WriteLine("\tEl email es válido!\n");
        }else
            {
                Console.WriteLine("\nEl email no es válido, vuelve a intentarlo!");
                Console.WriteLine("\tIntentalo de nuevo!");
                Console.Write("Email:");
                Email = Console.ReadLine();
            }

    Console.Write("Balance:");
    decimal Balance = Decimal.Parse(Console.ReadLine());
        if(Balance < 0)
        {
            Console.WriteLine("\nLo siento! no puedes ingresar movimientos de menos de $0.0");
            Console.WriteLine("\tIntentalo de nuevo!");
            Console.Write("Balance:");
            Balance = Decimal.Parse(Console.ReadLine());
        }
    Console.WriteLine("\nPara brindarte un mejor servicio, indicanos que papel desempenias!");
    Console.WriteLine("Si eres cliente, ingresa 'c'");
    Console.WriteLine("Si eres Empleado, ingresa 'e'");
    Console.Write("Comentanos cual es tu papel como usuario:");
    char userType = char.Parse(Console.ReadLine());
        
        User newUser;

        if(userType.Equals('c'))
        {
            Console.Write("Su regimen fiscal es: ");
            char TaxRegime = char.Parse(Console.ReadLine());

            newUser = new Client(Id, Name, Email, Balance, TaxRegime);
        }else 
            {
                Console.Write("Indicanos a que departamento perteneces: ");
                string Department = Console.ReadLine();

                newUser = new Employe(Id, Name, Email, Balance, Department);
            }

    Storage.AddUser(newUser);
    Console.WriteLine("El usuario se a agregado de manera correcta!");
    //Deteniendo la ejecucion 2s
    Thread.Sleep(2000);
    showMenu();
        
}

void DeleteUser()
{

}
static bool ValidacionEmail(string Email)
{
    return Email != null && Regex.IsMatch(Email, "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@(([a-zA-Z]+[\\w-]+\\.){1,2}[a-zA-Z]{2,4})$");
}