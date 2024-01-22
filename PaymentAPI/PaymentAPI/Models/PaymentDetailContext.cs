using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext : DbContext
    {
        public  PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {

        }

        //Pour dire au DbContext qu'on veut la table specifique si on veut la modifier
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}

