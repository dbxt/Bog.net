﻿namespace Bog.Data.EntityFramework.Configuration
{
    using System.Data.Entity.ModelConfiguration;

    using Bog.Data.Entities;

    /// <summary>
    ///     The donation configuration.
    /// </summary>
    public class DonationConfiguration : EntityTypeConfiguration<DonationData>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DonationConfiguration" /> class.
        /// </summary>
        public DonationConfiguration()
        {
            // this.Property(p => p.StreetAddress)
            // .IsRequired().HasMaxLength(100);

            // this.Property(p => p.StreetAddress2)
            // .IsOptional().HasMaxLength(100);

            // this.Property(p => p.City)
            // .IsRequired().HasMaxLength(50);

            // this.Property(p => p.ZipCode)
            // .IsRequired();

            // this.Property(p => p.ImageName)
            // .HasMaxLength(100);

            // this.Property(p => p.CreatedOn)
            // .IsRequired().HasColumnType("datetime");

            // this.Property(p => p.ModifiedOn)
            // .IsRequired().HasColumnType("datetime");

            // DONATIONS
            this.ToTable("Donations").HasKey(e => e.DonationId);

            // Tags
            this.HasMany(e => e.Tags).WithMany().Map(
                m =>
                    {
                        m.ToTable("DonationTags");
                        m.MapLeftKey("DonationID");
                        m.MapRightKey("TagID");
                    });
        }

        #endregion
    }
}