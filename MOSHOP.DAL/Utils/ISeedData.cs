

namespace MOSHOP.DAL.Utils
{
    public interface ISeedData
    {
        Task DataSeedingAsync();
        Task IdentityDataSeedingAsync();
    }
}
