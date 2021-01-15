using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WordLibrary.Entities.Concrete;

namespace WordLibrary.DataAccess.Concrete.EF.Mappings
{
    public class WordMap : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.ToTable(@"Word",@"dbo");
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
        }
    }
}
