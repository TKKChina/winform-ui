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

    internal partial class ButtonMap : EntityTypeConfiguration<Button>
    {
        public ButtonMap()
        {
            this.HasKey(t => t.ID);
            this.ToTable("U_Button");
            this.Property(t => t.ID).HasColumnName("ButtonId");
            this.Property(t => t.ButtonName).HasColumnName("ButtonName").IsRequired().HasMaxLength(50);
            this.Property(t => t.ButtonIcon).HasColumnName("ButtonIcon").HasMaxLength(200);
            this.Property(t => t.ButtonCode).HasColumnName("ButtonCode").HasMaxLength(50);
            this.Property(t => t.ButtonEvent).HasColumnName("ButtonEvent").HasMaxLength(100);
            this.Property(t => t.ButtonPosition).HasColumnName("ButtonPosition");
            this.Property(t => t.OrderNo).HasColumnName("OrderNo");
            this.Property(t => t.Remark).HasColumnName("Remark").HasMaxLength(200);
        }
    }
}
