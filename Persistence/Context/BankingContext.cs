using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence.Context;

public partial class BankingContext : DbContext
{
    public BankingContext()
    {
    }

    public BankingContext(DbContextOptions<BankingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kyc> Kycs { get; set; }

    public virtual DbSet<PersonalDetail> PersonalDetails { get; set; }

    public virtual DbSet<SecurityQuestion> SecurityQuestions { get; set; }

    public virtual DbSet<UserKycdetail> UserKycdetails { get; set; }

    public virtual DbSet<UserSecurityQuestion> UserSecurityQuestions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();

                var connectionstring = configuration.GetConnectionString("connectionDab");
                optionsBuilder.UseSqlServer(connectionstring);
            }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kyc>(entity =>
        {
            entity.HasKey(e => e.KycId).HasName("PK__KYC__58CB43CEC850FD3E");

            entity.ToTable("KYC");

            entity.Property(e => e.KycId).ValueGeneratedNever();
            entity.Property(e => e.ProofType).HasMaxLength(50);
        });

        modelBuilder.Entity<PersonalDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Personal__1788CC4C9807360B");

            entity.Property(e => e.UserId).ValueGeneratedNever();
            entity.Property(e => e.Aadharcard)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("DOB");
            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Pancard)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SecurityQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionId).HasName("PK__Security__0DC06FACF7F39BD4");

            entity.ToTable("SecurityQuestion");

            entity.Property(e => e.QuestionId).ValueGeneratedNever();
        });

        modelBuilder.Entity<UserKycdetail>(entity =>
        {
            entity.HasKey(e => e.UserKycid).HasName("PK__UserKYCD__9EFA7662F0B8055D");

            entity.ToTable("UserKYCDetails");

            entity.Property(e => e.UserKycid)
                .ValueGeneratedNever()
                .HasColumnName("UserKYCId");

            entity.HasOne(d => d.Kyc).WithMany(p => p.UserKycdetails)
                .HasForeignKey(d => d.KycId)
                .HasConstraintName("FK__UserKYCDe__KycId__45F365D3");

            entity.HasOne(d => d.User).WithMany(p => p.UserKycdetails)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserKYCDe__UserI__44FF419A");
        });

        modelBuilder.Entity<UserSecurityQuestion>(entity =>
        {
            entity.HasKey(e => e.UserQuestionId).HasName("PK__UserSecu__225F9E1330AC8A6B");

            entity.ToTable("UserSecurityQuestion");

            entity.Property(e => e.UserQuestionId).ValueGeneratedNever();

            entity.HasOne(d => d.Question).WithMany(p => p.UserSecurityQuestions)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__UserSecur__Quest__412EB0B6");

            entity.HasOne(d => d.User).WithMany(p => p.UserSecurityQuestions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__UserSecur__UserI__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
