using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        var ListUsers = JsonConvert.DeserializeObject<List<object>>(usersInFile);

        if(ListUsers == null)
            ListUsers = new List<object>();

        ListUsers.Add(user);

        JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented };

        //Guardar en el json
        json = JsonConvert.SerializeObject(ListUsers, settings);
        File.WriteAllText(filePath, json);
    }

    public static List<User> GetNewUsers()
    {
        string usersInFile = "";
        var ListUsers = new List<User>();

        if(File.Exists(filePath))
            usersInFile = File.ReadAllText(filePath);

        //Consultando los datos del json
        var ListObjects = JsonConvert.DeserializeObject<List<object>>(usersInFile);

        if(ListObjects == null)
            return ListUsers;

        foreach(object obj in ListObjects)
        {
            User NewUser;
            JObject user = (JObject)obj;

            if(user.ContainsKey("TaxRegime"))
                NewUser = user.ToObject<Client>();
            else 
                NewUser = user.ToObject<Employe>();

            ListUsers.Add(NewUser);
        }

        var NewUserList = ListUsers.Where(user => user.GetRegisterDate().Date.Equals(DateTime.Today)).ToList();
        return NewUserList;
    }
}