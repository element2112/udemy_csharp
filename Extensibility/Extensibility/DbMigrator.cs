using System;

namespace Extensibility
{
    public partial class DbMigrator
    {

        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }
        public void Migrate()
        {
            logger.LogInfo("Migration started at " + DateTime.Now);

            // Details of migrating the db

            logger.LogInfo("Migration ended at " + DateTime.Now);
        }
    }
}
