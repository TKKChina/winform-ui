namespace Tlw.ZPG.Domain.Mapping
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;

    using Tlw.ZPG.Domain.Models;
    using Tlw.ZPG.Domain.Models.ApplyAccount;

    internal partial class AccountVerifyMap : EntityTypeConfiguration<AccountVerify>
    {
        public AccountVerifyMap()
        {
            this.HasKey(t => t.ID);
            this.ToTable("A_AccountVerify");
            this.Property(t => t.ID).HasColumnName("VerifyId");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.VerifyAccountId).HasColumnName("VerifyAccountId");
            this.Property(t => t.VerifyAccount).HasColumnName("VerifyAccount").IsRequired().HasMaxLength(50);
            this.Property(t => t.Content).HasColumnName("Content").IsRequired().HasMaxLength(500);
            this.Property(t => t.IsAdmin).HasColumnName("IsAdmin");
        }
    }
}
