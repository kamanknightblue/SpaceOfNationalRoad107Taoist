using SpaceOfNationalRoad107Taoist.Samples;
using Xunit;

namespace SpaceOfNationalRoad107Taoist.MongoDB.Samples;

[Collection(MongoTestCollection.Name)]
public class SampleRepository_Tests : SampleRepository_Tests<SpaceOfNationalRoad107TaoistMongoDbTestModule>
{
    /* Don't write custom repository tests here, instead write to
     * the base class.
     * One exception can be some specific tests related to MongoDB.
     */
}
