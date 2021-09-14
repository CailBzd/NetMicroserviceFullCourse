using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.AccessControl;
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();

        Platform GetPlatformById(int id);

        void CreatePlaform(Platform plat);
    }
}
