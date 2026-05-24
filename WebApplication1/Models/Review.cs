namespace WebApplication1.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Comment { get; set; }

        public int Rating { get; set; }

        public bool IsApproved { get; set; }
        
        public int ProductId { get; set; }

        public Product Product { get; set; }

    }
}
