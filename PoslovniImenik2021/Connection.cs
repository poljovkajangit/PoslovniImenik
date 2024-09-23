using System.Windows.Forms;

namespace PoslovniImenik
{
    public class Connection
    {
        public static string ConnectionString
        {
            get
            {
                return ("Provider=Microsoft.ACE.OLEDB.12.0; User Id=; Password=; Data Source=" + Application.StartupPath + @"\PoslovniImenikDB.mdb");
            }
        }
    }
}