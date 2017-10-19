﻿using System;

namespace TEST.Migrations
{
    partial class MyModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity("TEST.Managers.Chat", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int>("AuthorId")
                    .ValueGeneratedOnAdd();

                b.Property<string>("CreatedBy")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("suser_sname()")
                    .HasMaxLength(100);

                b.Property<DateTime>("CreatedDate")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("sysdatetime()");

                //b.Property<string>("DisplayName")
                //    .ValueGeneratedOnAddOrUpdate()
                //    .HasComputedColumnSql("[Message]");

                b.Property<string>("LastUpdatedBy")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("suser_sname()")
                    .HasMaxLength(100);

                b.Property<DateTime>("LastUpdatedDate")
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("sysdatetime()");

                b.Property<int?>("Rating");

                b.Property<string>("RatedUsers");

                b.HasKey("Id");

                b.HasIndex("AuthorId");

                b.ToTable("Chat", "kpi");
            });
        }
    }
}