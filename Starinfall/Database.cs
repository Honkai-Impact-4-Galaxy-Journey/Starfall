using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starinfall
{
    public class PlayerInfo
    {
        public string Steamid { get; set; } // 不会变动，需要初始化
        public string LastNickName { get; set; }
        public string BadgeText { get; set; } // 不会变动
        public string BadgeColor { get; set; } // 不会变动
        public DateTime LastJoinTime { get; set; }
        public bool ReserveSlotEnabled { get; set; } // 不会变动
        public string LastIP { get; set; }
        public int Id { get; set; } // 不会变动
        public string JoinMessage { get; set; } // 不会变动
        public int Exp { get; set; }
        public int Level { get; set; }
        public string AdminRank { get; set; } // 不会变动
        public bool Cover { get; set; } // 不会变动
        public bool Banned { get; set; }
        public bool Modified = false;
    }
    public class Database
    {

    }
    public class ConnectionPool
    {
        private static Queue<MySqlConnection> mySqls = new Queue<MySqlConnection>();
        public const int InitCounts = 3;
        public static void InitConnectionPool()
        {
            for(int i = 0; i < InitCounts; ++i)
            {
                MySqlConnection mySqlConnection = new MySqlConnection(PluginMain.Instance.Config.ConnectionString);
                mySqlConnection.Open();
                mySqls.Enqueue(mySqlConnection);
            }
        }
        public static MySqlConnection GetConnection()
        {
            
        }
    }
}
