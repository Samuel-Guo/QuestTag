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
        //   public int is_valid;
        }
        public const string tag_group_def_field = " id,caption,unique ";

        public struct Tag_def
        {
            public int id;
            public string caption;
            public int group_id;
        }
        public const string tag_def_field = " id,caption,group_id ";

        public struct Quest_def
        {
            public int id;
            public string caption;
            public string file_path;
            public string detail;
        }
        public const string quest_def_field = " id,caption,file_path,detail ";


        public struct Quest_tag_map
        {
           public int quest_id;
           public int tag_id;
        }
        public const string quest_tag_map_field = " quest_id,tag_id ";

    }
}
