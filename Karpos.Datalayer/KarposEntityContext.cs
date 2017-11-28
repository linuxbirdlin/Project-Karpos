using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karpos.Datalayer
{
    public static class KarposEntityContext
    {
        private static KarposEntities _dbContext = null;
        public static KarposEntities Instance
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new KarposEntities();
                    _dbContext.Configuration.ProxyCreationEnabled = true;
                    _dbContext.Configuration.LazyLoadingEnabled = true;
                    //_dbContext.Set<ReportEngineReport>().AsNoTracking();
                    //_dbContext.Set<ReportEngineTemplate>().AsNoTracking();

                    //var csb = new SqlConnectionStringBuilder(ARIConfiguration.Instance.AridbConnectionString);
                    //Log.Instance.Debug("Environment connection string: {0}", csb);
                    //_dbContext.ChangeDatabase(csb.InitialCatalog, csb.DataSource, csb.UserID, csb.Password, false);
                    //Log.Instance.Debug("ARIEntities using connection:  {0}", _dbContext.Database.Connection.ConnectionString);
                }
                return _dbContext;
            }
        }
    }
}
