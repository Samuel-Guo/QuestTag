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
        public static void UpdateDBList()
        {
            ReadTagList();
            ReadTagGroupList();
        }

        private static void ReadTagList()
        {
            string sqlcmd = string.Format("SELECT * FROM edu.tag_def where is_valid = 1;");
            var tags = globalDB.ExeQuery(sqlcmd,false);
            while (tags.Read())
            {
                Db_struct.Tag_def tag = new Db_struct.Tag_def();
                tag.id = Convert.ToInt32(tags.GetString(0));
                tag.caption = tags.GetString(1);
                tag_list.Add(tag);
                // ListBoxTagGroup.
            }
        }

        private static void ReadTagGroupList()
        {


            var tag_group_list = GlobalVar.tag_group_list;
            string sqlcmd = "SELECT * FROM tag_group_def where is_valid = 1 ; ";

            tag_group_list = globalDB.ReadDB<Db_struct.Tag_group_def>(sqlcmd);

            //foreach (var item in groupTags)
            //{
            //    tag_Group.id = item.id;
            //}
            //var tagGroup = globalDB.ExeQuery(sqlcmd);
            //while (tagGroup.Read())
            //{
            //    tag_Group.id = Convert.ToInt32(tagGroup.GetString(0));
            //    tag_Group.caption = tagGroup.GetString(1);
            //    tag_Group.unique = Convert.ToInt32(tagGroup.GetString(2));
            //   // tag_Group.is_valid = Convert.ToInt32(tagGroup.GetString(3));
            //    tag_group_list.Add(tag_Group);
            //}
        }

    }
}
