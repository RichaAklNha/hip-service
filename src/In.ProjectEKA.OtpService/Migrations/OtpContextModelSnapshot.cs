﻿// <auto-generated />
using In.ProjectEKA.OtpService.Otp.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace In.ProjectEKA.OtpService.Migrations
{
    [DbContext(typeof(OtpContext))]
    partial class OtpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("In.ProjectEKA.OtpService.Otp.Model.OtpRequest", b =>
                {
                    b.Property<string>("SessionId")
                        .HasColumnType("text");

                    b.Property<string>("DateTimeStamp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OtpToken")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SessionId");

                    b.ToTable("OtpRequests");
                });
#pragma warning restore 612, 618
        }
    }
}