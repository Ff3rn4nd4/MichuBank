using MichuBank;

        Client Francisco = new Client(2, "Francisco", "fran@gmail.com", 3000, 'M');
        Francisco.SetBalance(2000);
        Console.WriteLine(Francisco.ShowData());

        Employe Fernanda = new Employe(3, "Fernanda", "fer@gmail.com", 3000, "IT");
        Fernanda.SetBalance(2000);
        Console.WriteLine(Fernanda.ShowData());

/*Creando un usuario de manera manual 
User Fernanda = new User();
Fernanda.Id=1;
Fernanda.Name="Fernanda";
Fernanda.Email="gr_fer@gmail.com";
Fernanda.Balance= 50000;
Fernanda.RegisterDate= DateTime.Now;

Console.WriteLine(Fernanda.ShowData());*/
/*bool volverAlMenu = true;

do{
    //Console.Clear();
    Console.WriteLine("---------------------------------- Michu Bank ----------------------------------");
    Console.WriteLine("Este programa esta dirigido tanto a clientes como personal de este banco");
    Console.WriteLine("1. Crear un nuevo usuario");
    Console.WriteLine("2. Eliminar un usuario Existente");
    Console.Write("\tIngresar opcion: ");
    string opcion = Console.ReadLine();

    switch(opcion)
    {
        case "1":
        Console.Clear();
        Client Francisco = new Client(2, "Francisco", "fran@gmail.com", 1000, 'M');
        Francisco.SetBalance(5000);
        Console.WriteLine(Francisco.ShowData());
        Storage.AddUser(Francisco);

        Employe Fernanda = new Employe(3, "Fernanda", "fer@gmail.com", 3000, "IT");
        Fernanda.SetBalance(2000);
        Console.WriteLine(Fernanda.ShowData());
        Storage.AddUser(Fernanda);
        #region VolverAlMenu
            Console.Write("\n¿Deseas volver al menú principal? (S/N): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToUpper() != "S")
            {
                volverAlMenu = false;
            }
        #endregion
        break;

        case "2":
        Console.Clear();
        Console.WriteLine("Los usuarios ingresados son:");
        

        #region VolverAlMenu
            Console.Write("\n¿Deseas volver al menú principal? (S/N): ");
            respuesta = Console.ReadLine();

            if (respuesta.ToUpper() != "S")
            {
                volverAlMenu = false;
            }
        #endregion
        break;

        default:
            Console.Clear();
            Console.WriteLine("Ups! esa opcion no existe");
            #region VolverAlMenu
            Console.Write("\n¿Deseas volver al menú principal? (S/N): ");
            respuesta = Console.ReadLine();

            if (respuesta.ToUpper() != "S")
            {
                volverAlMenu = false;
            }
            #endregion
        break;

    }

}while(volverAlMenu);*/