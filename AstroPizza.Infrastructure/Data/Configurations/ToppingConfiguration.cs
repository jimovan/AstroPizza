using AstroPizza.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AstroPizza.Infrastructure.Data.Configurations
{
    public class ToppingConfiguration : IEntityTypeConfiguration<Topping>
    {
        public void Configure(EntityTypeBuilder<Topping> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(25);

            builder.HasData(
                new Topping { Id = 1, Name = "Pepperoni", IsVegetarian = false, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 2, Name = "Ham", IsVegetarian = false, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 3, Name = "Chicken", IsVegetarian = false, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 4, Name = "Spicy Beef", IsVegetarian = false, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 5, Name = "Bacon", IsVegetarian = false, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 6, Name = "Mexican Chicken", IsVegetarian = false, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },

                new Topping { Id = 7, Name = "Peppers", IsVegetarian = true, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 8, Name = "Sweetcorn", IsVegetarian = true, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 9, Name = "Mushrooms", IsVegetarian = true, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 10, Name = "Olives", IsVegetarian = true, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 11, Name = "Pineapple", IsVegetarian = true, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 12, Name = "Jalapenos", IsVegetarian = true, DateCreated = DateTime.Now, DateLastModified = DateTime.Now },
                new Topping { Id = 13, Name = "Onions", IsVegetarian = true, DateCreated = DateTime.Now, DateLastModified = DateTime.Now }
                );
        }
    }
}
