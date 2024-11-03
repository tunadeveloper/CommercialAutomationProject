using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace CommercialAutomationProject
{
	class SqlConnectionManager
	{
		public SqlConnection connection()
		{
			SqlConnection connect = new SqlConnection("Data Source=TUNA\\SQLEXPRESS;Initial Catalog=CommercialAutomationDbo;Integrated Security=True");
			connect.Open();
			return connect;
		}
	}
}
