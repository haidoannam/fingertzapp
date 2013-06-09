// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FingertzAppContext.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the FingertzAppContext type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FingertzApp.Model
{
    using System.Data.Entity;

    using FingertzApp.Model.Models;
    using FingertzApp.Model.Models.Mapping;

    /// <summary>
    /// The fingertz app context.
    /// </summary>
    public partial class FingertzAppContext : DbContext
    {
        /// <summary>
        /// Initializes static members of the <see cref="FingertzAppContext"/> class.
        /// </summary>
        static FingertzAppContext()
        {
            Database.SetInitializer<FingertzAppContext>(null);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FingertzAppContext"/> class.
        /// </summary>
        public FingertzAppContext()
            : base("Name=FingertzAppContext")
        {
        }

        /// <summary>
        /// The commit.
        /// </summary>
        public virtual void Commit()
        {
            base.SaveChanges();
        }

        /// <summary>
        /// Gets or sets the domain requests.
        /// </summary>
        public DbSet<DomainRequest> DomainRequests { get; set; }

        /// <summary>
        /// Gets or sets the domains.
        /// </summary>
        public DbSet<Domain> Domains { get; set; }

        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        public DbSet<Email> Emails { get; set; }

        /// <summary>
        /// Gets or sets the invoices.
        /// </summary>
        public DbSet<Invoice> Invoices { get; set; }

        /// <summary>
        /// Gets or sets the keyword histories.
        /// </summary>
        public DbSet<KeywordHistory> KeywordHistories { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        public DbSet<Keyword> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the phrase managements.
        /// </summary>
        public DbSet<PhraseManagement> PhraseManagements { get; set; }

        /// <summary>
        /// Gets or sets the project 2 user.
        /// </summary>
        public DbSet<Project2User> Project2User { get; set; }

        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// Gets or sets the search engines.
        /// </summary>
        public DbSet<SearchEngine> SearchEngines { get; set; }

        /// <summary>
        /// Gets or sets the seeding managements.
        /// </summary>
        public DbSet<SeedingManagement> SeedingManagements { get; set; }

        /// <summary>
        /// Gets or sets the subscriptions.
        /// </summary>
        public DbSet<Subscription> Subscriptions { get; set; }

        /// <summary>
        /// Gets or sets the tasks.
        /// </summary>
        public DbSet<Task> Tasks { get; set; }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Gets or sets the web accounts.
        /// </summary>
        public DbSet<WebAccount> WebAccounts { get; set; }

        /// <summary>
        /// Gets or sets the while labels.
        /// </summary>
        public DbSet<WhileLabel> WhileLabels { get; set; }

        /// <summary>
        /// The on model creating.
        /// </summary>
        /// <param name="modelBuilder">
        /// The model builder.
        /// </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DomainRequestMap());
            modelBuilder.Configurations.Add(new DomainMap());
            modelBuilder.Configurations.Add(new EmailMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new KeywordHistoryMap());
            modelBuilder.Configurations.Add(new KeywordMap());
            modelBuilder.Configurations.Add(new PhraseManagementMap());
            modelBuilder.Configurations.Add(new Project2UserMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new SearchEngineMap());
            modelBuilder.Configurations.Add(new SeedingManagementMap());
            modelBuilder.Configurations.Add(new SubscriptionMap());
            modelBuilder.Configurations.Add(new TaskMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new WebAccountMap());
            modelBuilder.Configurations.Add(new WhileLabelMap());
        }
    }
}
