﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Core.Models;

namespace ToDoList.Persistence.Configuration;
public class TargetConfiguration : IEntityTypeConfiguration<Target>
{
    public void Configure(EntityTypeBuilder<Target> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Name)
                .IsRequired();

        builder.Property(t => t.Description)
            .IsRequired();
    }
}
