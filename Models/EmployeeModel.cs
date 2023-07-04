namespace MyWebsiteMVC.Models
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Jabatan { get; set; }

        public EmployeeModel(string name, string jabatan)
        {
            Id = Guid.NewGuid();
            Name = name;
            Jabatan = jabatan;
        }
    }
}
