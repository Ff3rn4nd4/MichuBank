using Newtonsoft.Json;
namespace MichuBank;

//nivel de acceso - tipo - nombre 
public class User
{
    [JsonProperty]
    protected int Id { get; set; }
    [JsonProperty]
    protected string Name { get; set; }
    [JsonProperty]
    protected string Email { get; set; }
    [JsonProperty]
    protected decimal Balance { get; set; }
    [JsonProperty]
    protected DateTime RegisterDate { get; set; }

    //Metodos
    public User(int Id, string Name, string Email, decimal Balance)
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
        this.Balance = Balance;
        this.RegisterDate = DateTime.Now;
    }

    public virtual void SetBalance(decimal amount)
    {
        decimal quantity = 0;

        if (amount < 0)
        {
            quantity = 0;
        }else quantity = amount;

        this.Balance += quantity;
    }
    public virtual string ShowData()
    {
        return $"Nombre: {this.Name}, Correo: {this.Email}, Saldo: {this.Balance}, Fecha Registro: {this.RegisterDate.ToShortDateString()}";
    }

}