using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using LibraryMIS.BLL;
using LibraryMIS.Models;

namespace LibraryMIS
{
	/// <summary>
	/// Book 的摘要说明。
	/// </summary>
	public class frmBook : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btClose;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Button btModify;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SqlConnection oleConnection1 = null;
        LibraryService serv = new LibraryService();


		public frmBook()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.btAdd = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(472, 64);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 24;
            this.btAdd.Text = "添加";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClose
            // 
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(472, 256);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 23;
            this.btClose.Text = "退出";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btDel
            // 
            this.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDel.ForeColor = System.Drawing.Color.Black;
            this.btDel.Location = new System.Drawing.Point(472, 192);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 22;
            this.btDel.Text = "删除";
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btModify
            // 
            this.btModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModify.ForeColor = System.Drawing.Color.Black;
            this.btModify.Location = new System.Drawing.Point(472, 128);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(75, 23);
            this.btModify.TabIndex = 21;
            this.btModify.Text = "修改";
            this.btModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowSorting = false;
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.White;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Verdana", 10F);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
            this.dataGrid1.Location = new System.Drawing.Point(8, 48);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(448, 246);
            this.dataGrid1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(152, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "图 书 书 目";
            // 
            // Book
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(560, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btModify);
            this.Controls.Add(this.dataGrid1);
            this.Name = "Book";
            this.Text = "图书";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		DataSet ds;
        DataTable bookDataTable;

        private void Book_Load(object sender, System.EventArgs e)
        {
            bookDataTable = serv.getBookTable();

            dataGrid1.DataSource = bookDataTable.DefaultView;
            dataGrid1.CaptionText = "共有" + bookDataTable.Rows.Count + "条记录";
        }

        frmAddBook addBook;
		private void btAdd_Click(object sender, System.EventArgs e)
		{
			addBook = new frmAddBook();
			addBook.ShowDialog();
		}

		frmModifyBook modifyBook;
		private void btModify_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.DataSource!=null || dataGrid1[dataGrid1.CurrentCell]!=null)
			{
                BookModel book = new BookModel();
                book.BID = bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim();
                book.BName = bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim();
                book.BWriter = bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][2].ToString().Trim();
                book.BPublish = bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][3].ToString().Trim();
                book.BDate = Convert.ToDateTime(bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][4].ToString().Trim());
                book.BPrice = bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][5].ToString().Trim();
                book.BNum = bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][6].ToString().Trim();
                book.Type = bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][7].ToString().Trim();
                book.BRemark = bookDataTable.Rows[dataGrid1.CurrentCell.RowNumber][8].ToString().Trim();

                modifyBook = new frmModifyBook();
				modifyBook.textID.Text = book.BID;
				modifyBook.textName.Text = book.BName;
				modifyBook.textWriter.Text = book.BWriter;
				modifyBook.textPublish.Text = book.BPublish;
                modifyBook.date1.Text = book.BDate.ToString();
                modifyBook.textPrice.Text = book.BPrice;
                modifyBook.textNum.Text = book.BNum;
				modifyBook.textType.Text = book.Type;
                modifyBook.textRemark.Text = book.BRemark;
				modifyBook.Show();
			} 
			else
				MessageBox.Show("没有指定图书信息！","提示");
		}

		private void btDel_Click(object sender, System.EventArgs e)
		{
			if (dataGrid1.CurrentRowIndex>=0&&dataGrid1.DataSource!=null&&dataGrid1[dataGrid1.CurrentCell]!=null)
			{
				oleConnection1.Open();
				string sql="select * from bookOut where BID='"+ds.Tables["book"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
				SqlCommand cmd = new SqlCommand(sql,oleConnection1);
				SqlDataReader dr;
				dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					MessageBox.Show("删除图书'"+ds.Tables["book"].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim()+"'失败，该图书正在流通中！","提示");
					dr.Close();
				} 
				else
				{
					dr.Close();
					sql = "delete from book where BID not in(select distinct BID from bookOut) and BID "+
						"= '"+ds.Tables["book"].Rows[dataGrid1.CurrentCell.RowNumber][0].ToString().Trim()+"'";
					cmd.CommandText = sql;
					cmd.ExecuteNonQuery();
					MessageBox.Show("删除图书'"+ds.Tables[0].Rows[dataGrid1.CurrentCell.RowNumber][1].ToString().Trim()+"'成功","提示");
				}
				oleConnection1.Close();
			} 
			else
				return;
		}

		private void btClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
