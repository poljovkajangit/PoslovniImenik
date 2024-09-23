using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace PoslovniImenik
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OleDbConnection connection = new OleDbConnection(Connection.ConnectionString);
            using (connection)
            {
                connection.Open();
                string[] strArray2 = new string[4];
                strArray2[2] = "Kontakt";
                string[] restrictionValues = strArray2;
                if (connection.GetSchema("Columns", restrictionValues).Rows.Count < 15)
                {
                    OleDbCommand command = new OleDbCommand
                    {
                        CommandText = "ALTER TABLE Kontakt ADD FolderLocation VARCHAR(255) ",
                        Connection = connection
                    };
                    using (command)
                    {
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exception)
                        {
                            throw exception;
                        }
                    }

                }


                //if (connection.GetSchema("Columns", restrictionValues).Rows.Count < 15)
                //{
                //    OleDbCommand command = new OleDbCommand
                //    {
                //        CommandText = "ALTER TABLE Kontakt ADD FolderLocation VARCHAR(255) ",
                //        Connection = connection
                //    };
                //    using (command)
                //    {
                //        try
                //        {
                //            command.ExecuteNonQuery();
                //        }
                //        catch (Exception exception)
                //        {
                //            throw exception;
                //        }
                //    }

                //}


                Application.Run(new FrmMain());
            }
        }
    }
}