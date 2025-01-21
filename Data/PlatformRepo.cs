using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        public PlatformRepo()
        {
        }
        public void createPlatform(Platform platform)
        {
            throw new NotImplementedException();
        }

        public Platform GetPlatformById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Platform> GetPlatforms()
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}