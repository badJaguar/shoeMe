using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoeMeDear.DataAccess.Common.Cotexts;

namespace ShoeMeDear.DataAccess.Contexts
{
    //TODO: Setup this class
    public class Database : IDatabase
    {
        private IDatabase _databaseImplementation;
        public void Dispose()
        {
            _databaseImplementation.Dispose();
        }

        public bool IsExists => _databaseImplementation.IsExists;

        public bool IsCompatibleWithModel => _databaseImplementation.IsCompatibleWithModel;

        public void Initialize()
        {
            _databaseImplementation.Initialize();
        }

        public void Delete()
        {
            _databaseImplementation.Delete();
        }
    }
}
