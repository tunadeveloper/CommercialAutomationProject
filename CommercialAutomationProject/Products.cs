using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommercialAutomationProject
{
	public partial class Products : Form
	{
		public Products()
		{
			InitializeComponent();
		}

		SqlConnectionManager sqlManager = new SqlConnectionManager();

		void List()
		{
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter("Select * From Products", sqlManager.connection());
			da.Fill(dt);
			gridControl1.DataSource = dt;
		}
		private void Products_Load(object sender, EventArgs e)
		{
			List();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName, Brand, Model, Year, Total, Buying, Sales, Detail) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sqlManager.connection());

			cmd.Parameters.AddWithValue("@p1", name.Text);
			cmd.Parameters.AddWithValue("@p2", brand.Text);
			cmd.Parameters.AddWithValue("@p3", model.Text);
			cmd.Parameters.AddWithValue("@p4", year.Text);
			cmd.Parameters.AddWithValue("@p5", int.Parse(total.Text));
			cmd.Parameters.AddWithValue("@p6", decimal.Parse(buying.Text));
			cmd.Parameters.AddWithValue("@p7", decimal.Parse(sales.Text));
			cmd.Parameters.AddWithValue("@p8", detail.Text);

			cmd.ExecuteNonQuery();
			sqlManager.connection().Close();

			MessageBox.Show("Ürün sisteme başarıyla eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
			List();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("Delete From Products where ID = @p1", sqlManager.connection());
			cmd.Parameters.AddWithValue("@p1", id.Text);
			cmd.ExecuteNonQuery();
			sqlManager.connection().Close();
			MessageBox.Show("Ürün başarıyla silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
			List();
		}
		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
			id.Text = dr["ID"].ToString();
			name.Text = dr["ProductName"].ToString();
			brand.Text = dr["Brand"].ToString();
			model.Text = dr["Model"].ToString();
			year.Text = dr["Year"].ToString();
			total.Text = dr["Total"].ToString();
			buying.Text = dr["Buying"].ToString();
			sales.Text = dr["Sales"].ToString();
			detail.Text = dr["Detail"].ToString();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = new SqlCommand("update Products set ProductName = @p1, Brand = @p2,Model = @p4, Year = @p3, Total = @p5, Buying = @p6, Sales = @p7,  Detail = @p8 where ID=@p9 ", sqlManager.connection());
			cmd.Parameters.AddWithValue("@p1", name.Text);
			cmd.Parameters.AddWithValue("@p2", brand.Text);
			cmd.Parameters.AddWithValue("@p3", model.Text);
			cmd.Parameters.AddWithValue("@p4", year.Text);
			cmd.Parameters.AddWithValue("@p5", int.Parse(total.Text));
			cmd.Parameters.AddWithValue("@p6", decimal.Parse(buying.Text));
			cmd.Parameters.AddWithValue("@p7", decimal.Parse(sales.Text));
			cmd.Parameters.AddWithValue("@p8", detail.Text);
			cmd.Parameters.AddWithValue("@p9", id.Text);

			cmd.ExecuteNonQuery();
			sqlManager.connection().Close();
			MessageBox.Show("Ürün başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
			List();
		}
	}
}
