namespace MichuBank;

//Clase hija de Users
public class Client : User,IPerson
{
    public char TaxRegime{ get ; set; }
    public Client() {}
    public Client(int Id, string Name, string Email, decimal Balance, char TaxRegime) : base(Id, Name, Email, Balance)
    {
        this.TaxRegime = TaxRegime;
        SetBalance(Balance);
    }

    //Sobre escribiendo metodos
    public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);

        if(TaxRegime.Equals('M'))
            Balance += (amount * 0.02m);
    }

    public override string ShowData()
    {
        return base.ShowData() + $", Regimen fisca: {this.TaxRegime}";
    }

    public string GetName()
    {
        return Name;
    }

    public string GetCountry()
    {
        return "Mexico";
    }
}