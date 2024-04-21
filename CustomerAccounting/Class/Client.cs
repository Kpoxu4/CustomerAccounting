
namespace CustomerAccounting.Class
{
    public class Client
    {
     
        public string? Name { get;  set; }

        public string? Telephone { get; set; }

        public string? Address { get; set; }
        public DateTime DataTime { get;  set;}

        public string? OrderName { get; set; }

        public Client(string name, string telephone, string address, string orderName) 
        {
            Name = name;
            Telephone = telephone;
            Address = address;
            OrderName = orderName;
            DataTime = DateTime.Now;
            var point = new Point();
           
        }
        public override string ToString()
        {
            return $"{Name}\n{Telephone}\n{Address}\nИзделие: {OrderName}\nДата взятия: {DataTime}\nДата сдачи: {DataTime.AddMonths(1)}\n";
        }

    }
}
