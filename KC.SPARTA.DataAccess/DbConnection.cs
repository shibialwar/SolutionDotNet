using KC.SPARTA.Common;
using KC.SPARTA.Common.Constants;
using KC.SPARTA.DataAccess;

namespace KC.SPARTA.DataAccess
{
    public class DbConnection
    {
        private string _conStr;

        public sampleEntities Db
        {
            get
            {
                return new sampleEntities(_conStr);
            }
        }
        public DbConnection(string ConStr)
        {
            _conStr = ConStr;


            //Optimization parameters for Entity Framework
            Db.Configuration.LazyLoadingEnabled = false;
            Db.Configuration.AutoDetectChangesEnabled = false;
        }
    }
}
      




    public class ApacDbConnection : DbConnection
    {
        public ApacDbConnection() : base(Utils.GetConnectionString(AppConstants.DbApacKey))
        {
        }
    }

    public class EmeaDbConnection : DbConnection
    {
        public EmeaDbConnection() : base(Utils.GetConnectionString(AppConstants.DbEmeaKey))
        {
        }
    }

