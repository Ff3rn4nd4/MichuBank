namespace MichuBank;

public abstract class Person
{
    //Metodos abstractos solo se definen 
     public abstract string GetName();

     public string GetCountry()
     {
        return "Mexico";
     }
}

public interface IPerson
{
    string GetName();
    string GetCountry();
}