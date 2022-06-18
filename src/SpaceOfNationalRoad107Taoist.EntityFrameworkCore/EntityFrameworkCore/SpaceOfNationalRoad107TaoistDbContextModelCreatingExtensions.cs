using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace SpaceOfNationalRoad107Taoist.EntityFrameworkCore;

public static class SpaceOfNationalRoad107TaoistDbContextModelCreatingExtensions
{
    public static void ConfigureSpaceOfNationalRoad107Taoist(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(SpaceOfNationalRoad107TaoistDbProperties.DbTablePrefix + "Questions", SpaceOfNationalRoad107TaoistDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */
    }
}
