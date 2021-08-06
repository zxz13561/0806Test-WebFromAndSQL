using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFunction
{
    class DBHelper
    {
        /// <summary> 取得SQL連線字串 </summary>
        /// <returns> Web.Config中的連線設定 </returns>
        public static string GetConnectionString()
        {
            string val = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return val;
        }

        /// <summary> 新增一筆DB紀錄 </summary>
        /// <param name="baseNumber"> 基數 </param>
        /// <param name="CoefficientNumber"> 係數 </param>
        public static void CreateData(int baseNumber, int CoefficientNumber)
        {

            string connStr = DBHelper.GetConnectionString();
            string dbCommand =
                @"INSERT INTO [dbo].[TestTable]
                        ([BaseNumber],
                         [CoefficientNumber],
                         [CreateDate])
                    VALUES
                        (@baseNumber,
                        @CoefficoentNumber,
                        @createDate)
                ";

            List<SqlParameter> parmList = new List<SqlParameter>();
            parmList.Add(new SqlParameter("@baseNumber", baseNumber));
            parmList.Add(new SqlParameter("@CoefficoentNumber", CoefficientNumber));
            parmList.Add(new SqlParameter("@createDate", DateTime.Now));

            try
            {
                DBHelper.ModifyDatas(connStr, dbCommand, parmList);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary> 編輯資料表中的資料 </summary>
        /// <param name="connStr">連線字串</param>
        /// <param name="dbCommand">SQL語法</param>
        /// <param name="parmList">輸入的Values List</param>
        /// <returns> 受影響的的資料列數量 </returns>
        public static int ModifyDatas(string connStr, string dbCommand, List<SqlParameter> parmList)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand comm = new SqlCommand(dbCommand, conn))
                {
                    comm.Parameters.AddRange(parmList.ToArray());
                    conn.Open();
                    int effectRowsCount = comm.ExecuteNonQuery();
                    return effectRowsCount;
                }
            }
        }
    }
}
