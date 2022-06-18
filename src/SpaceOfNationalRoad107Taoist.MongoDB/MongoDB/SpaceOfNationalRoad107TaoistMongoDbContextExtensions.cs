using Volo.Abp;
using Volo.Abp.MongoDB;

namespace SpaceOfNationalRoad107Taoist.MongoDB;

public static class SpaceOfNationalRoad107TaoistMongoDbContextExtensions
{
    public static void ConfigureSpaceOfNationalRoad107Taoist(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
