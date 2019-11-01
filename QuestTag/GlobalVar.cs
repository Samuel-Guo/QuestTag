using SamuelSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestTag
{
    static class GlobalVar
    {
        public static MysqlConnector globalDB;
        public static List<Db_struct.Tag_group_def> tag_group_list = new List<Db_struct.Tag_group_def>();
        public static List<Db_struct.Tag_def> tag_list = new List<Db_struct.Tag_def>();

    }
}
