using MichuBank;
public class Employe : User
{
    public string Department { get; set;}
    public Employe(int Id, string Name, string Email, decimal Balance, string Department) : base(Id, Name, Email, Balance)
    {
        this.Department = Department;
    }

       public override void SetBalance(decimal amount)
    {
        base.SetBalance(amount);

        if(!string.IsNullOrEmpty(Department))
        {
            if(Department.Equals("IT"))
                Balance += (amount * 0.05m);
        }
    }

    public override string ShowData()
    {
        return base.ShowData() + $",  Departamento: {this.Department}";
    }
}