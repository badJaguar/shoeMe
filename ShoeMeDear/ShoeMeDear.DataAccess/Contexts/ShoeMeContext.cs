using System.Data.Entity;
using ShoeMeDear.DataAccess.Contexts.Config;

namespace ShoeMeDear.DataAccess.Contexts
{
    [DbConfigurationType(typeof(MsSqlConfiguration))]
    public class ShoeMeContext
    {
    }
}