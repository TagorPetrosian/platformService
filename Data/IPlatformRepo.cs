using PlatformService.Models;

namespace PlatformService.Data
{
  interface IPlatformRepo
  {
    public bool SaveChanges();
    public IEnumerable<Platform> GetPlatforms();
    public Platform GetPlatformById(int id);
    public void createPlatform(Platform platform);
  }
}