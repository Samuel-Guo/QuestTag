using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestTag
{
    public static class Db_struct
    {
        public struct Tag_group_def
        {
           public int id  ;
           public string caption;
           public int unique;
        }
        public struct Tag_def
        {
            public int id;
            public string caption;
            public int group_id;
        }


    }
}
