using Microsoft.EntityFrameworkCore;


namespace PaymentAPI.Models
{
    public class PaymentDetailContext : DbContext 
    {
        public PaymentDetailContext(DbContextOptions options) : base(options) //constructor 

        {

        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }

    }
}
