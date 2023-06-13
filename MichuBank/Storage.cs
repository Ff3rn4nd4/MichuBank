using Newtonsoft.Json;
namespace MichuBank;

public static class Storage
{
    static string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\users.json";

    public static void AddUser(User user)
    {
        string json = "", usersInFile = "";


        if(File.Exists(filePath))
            usersInFile = File.ReadAllText(filePath);

        //Consultando los datos del json
        var ListUsers = JsonConvert.DeserializeObject<List<User>>(usersInFile);

        if(ListUsers == null)
            ListUsers = new List<User>();

        ListUsers.Add(user);

        //Guardar en el json
        json = JsonConvert.SerializeObject(ListUsers);
        File.WriteAllText(filePath, json);

    }
}