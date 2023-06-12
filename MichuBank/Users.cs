namespace MichuBank;

//nivel de acceso - tipo - nombre 
public class User
{
    public int Id {get;set;}
    public string Name {get;set;}
    public string Email { get; set; }
    public decimal Balance { get; set; }
    public DateTime RegisterDate { get; set; }

    //Metodos
    public string ShowData()
    {
        return $"Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha Registro: {this.RegisterDate}";
    }
}