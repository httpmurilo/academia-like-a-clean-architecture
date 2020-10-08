namespace Academia.Application.Commands.Employee.AddEmployee
{
    public class AddEmployeeViewModel
    {
        public AddEmployeeViewModel(string name)
        {
            Name = name;
        }

        public string Name { get;  set; }
    }
}