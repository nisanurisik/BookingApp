using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.Entities
{
    public class BaseEntitiy
    {
        //public BaseEntitiy()
        //{
        //    CreatedDate = DateTime.Now;
        //}
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
    public abstract class BseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntitiy
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasQueryFilter(x => x.IsDeleted == false);
            builder.Property(x => x.ModifiedDate).IsRequired();
        }
    }
}
