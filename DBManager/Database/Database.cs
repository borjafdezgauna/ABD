using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager
{
    public class Database
    {
        List<Table> Tables = new List<Table>();
        public Database()
        { }

        public bool Load(string databaseFilename, string username, string password)
        {
            //TODO
            return true;
        }

        public bool Save(string databaseFilename)
        {
            //TODO
            return true;
        }

        public string Select(string table, List<string> columns)
        {
            //TODO
            return null;
        }
        public string Insert(string table, List<string> columns, List<string> values)
        {
            //TODO
            return null;
        }

        public string ExecuteMiniSQLQuery(string query)
        {
            //Parse the query
            MiniSQLQuery miniSQLQuery = MiniSQLParser.Parse(query);

            if (miniSQLQuery == null)
                return "Error";

            return miniSQLQuery.Execute(this);
        }
    }
}
