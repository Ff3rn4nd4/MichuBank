using MichuBank;
public class Employe : User, IPerson
{
    public string Department { get; set;}
    public Employe(){}
    public Employe(int Id, string Name, string Email, decimal Balance, string Department) : base(Id, Name, Email, Balance)
    {
        this.Department = Department;
        SetBalance(Balance);
    }

       public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);
            
        if(Department.Equals("IT"))
            Balance += (amount * 0.05m);
    }

    public override string ShowData()
    {
        return base.ShowData() + $",  Departamento: {this.Department}";
    }

    public string GetName()
    {
        throw new NotImplementedException();
    }

    public string GetCountry()
    {
        throw new NotImplementedException();
    }
}