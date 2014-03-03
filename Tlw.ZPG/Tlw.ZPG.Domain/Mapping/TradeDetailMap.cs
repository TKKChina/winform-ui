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

    internal partial class TradeDetailMap : EntityTypeConfiguration<TradeDetail>
    {
        public TradeDetailMap()
        {
            this.HasKey(t => t.ID);
            this.ToTable("Z_TradeDetail");
            this.Property(t => t.ID).HasColumnName("DetailId");
            this.Property(t => t.TradeId).HasColumnName("TradeId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.PrevPrice).HasColumnName("PrevPrice");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(50);
            this.Property(t => t.Remark).HasColumnName("Remark").HasMaxLength(200);
            this.HasRequired(t => t.Trade).WithMany();
        }
    }
}
