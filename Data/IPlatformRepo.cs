using PlatformService.Models;

namespace PlatformService.Data
{
  class IPlatformRepo
  {
    bool SaveChanges();

    IEnumerable<Platform> GetPlatforms();
    Platform GetPlatformById(int id);
    void createPlatform(Platform platform);
  }
}