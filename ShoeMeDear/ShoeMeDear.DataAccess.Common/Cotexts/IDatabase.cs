using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeMeDear.DataAccess.Common.Cotexts
{
    public interface IDatabase : IDisposable
    {
        /// <summary>
        /// Checks whether or not the database exists on the server.
        /// </summary>
        /// <returns> True if the database exists; false otherwise. </returns>
        bool IsExists { get; }

        /// <summary>
        /// Checks whether or not the database is compatible with the the current Code First model.
        /// </summary>
        /// <returns> True if the model hash in the context and the database match; false otherwise. </returns>
        bool IsCompatibleWithModel { get; }

        /// <summary>
        /// Runs the the registered <see cref="T:System.Data.Entity.IDatabaseInitializer`1" /> on this context.
        /// If "force" is set to true, then the initializer is run regardless of whether or not it
        /// has been run before.  This can be useful if a database is deleted while an app is running
        /// and needs to be reinitialized.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Deletes the database on the database server if it exists, otherwise does nothing.
        /// Calling this method from outside of an initializer will mark the database as having
        /// not been initialized. This means that if an attempt is made to use the database again
        /// after it has been deleted, then any initializer set will run again and, usually, will
        /// try to create the database again automatically.
        /// </summary>
        void Delete();
    }
}
