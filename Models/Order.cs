namespace ConsoleApp2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public int ReaderID { get; set; }
        public Reader Reader { get; set; } = null!;
    }
}