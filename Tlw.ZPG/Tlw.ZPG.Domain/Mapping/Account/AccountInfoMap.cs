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

    internal partial class AccountInfoMap : EntityTypeConfiguration<AccountInfo>
    {
        public AccountInfoMap()
        {
            this.HasKey(t => t.ID);
            this.ToTable("A_AccountInfo");
            this.Property(t => t.ID).HasColumnName("AccountInfoId");
            this.Property(t => t.RandomNumber).HasColumnName("RandomNumber").IsRequired().HasMaxLength(50);
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.TradeId).HasColumnName("TradeId");
            this.Property(t => t.ApplyType).HasColumnName("ApplyType");
            this.Property(t => t.ContactId).HasColumnName("ContactId");
            this.Property(t => t.AgentId).HasColumnName("AgentId");
            this.Property(t => t.CorporationId).HasColumnName("CorporationId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.HasRequired(t => t.Agent).WithRequiredPrincipal();
            this.HasRequired(t => t.Contact).WithRequiredPrincipal();
            this.HasRequired(t => t.Corporation).WithRequiredPrincipal();
            this.HasRequired(t => t.Trade).WithMany();
            this.HasMany(t => t.UnionBidPersons).WithRequired();
            this.HasMany(t => t.AccountVerifies).WithRequired();
        }
    }
}