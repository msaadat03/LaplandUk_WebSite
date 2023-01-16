using Back_end.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Logo> Logos { get; set; }
        public DbSet<HomeWorld> HomeWorlds { get; set; }
        public DbSet<HomeInvitation> HomeInvitations { get; set; }
        public DbSet<HomeAdventure> HomeAdventures { get; set; }
        public DbSet<JourneySlider> JourneySliders { get; set; }
        public DbSet<HomeGallery> HomeGalleries { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<SliderContent> SliderContents { get; set; }
        public DbSet<SliderGallery> SliderGalleries { get; set; }
        public DbSet<HomeMeet> HomeMeets { get; set; }
        public DbSet<OurStoryTitle> OurStoryTitles { get; set; }
        public DbSet<RedBook> RedBooks { get; set; }
        public DbSet<RedBookimg> RedBookimgs { get; set; }
        public DbSet<RedBookPage> RedBookPages { get; set; }
        public DbSet<RedBookApp> RedBookApps { get; set; }
        public DbSet<LocationTitle> LocationTitles { get; set; }
        public DbSet<TicketsTitle> TicketsTitles { get; set; }
        public DbSet<CompasContent> CompasContents { get; set; }
        public DbSet<GoldeBell> GoldeBells { get; set; }
        public DbSet<Compass> Compasses { get; set; }
        public DbSet<GoldenContents> GoldenContents { get; set; }
        public DbSet<TicketAbout> TicketAbouts { get; set; }
        public DbSet<Faqs> Faqsses { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategory { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Login_Register> Login_Registers { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
    }
}
