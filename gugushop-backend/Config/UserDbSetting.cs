using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gugushop_backend.Config
{
    public class UserDbSetting : IUserDbSetting
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string UserCollectionName { get; set; }
    }

    public interface IUserDbSetting
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
        string UserCollectionName { get; set; }

    }
}
