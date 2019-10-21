using LibraryMIS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryMIS.BLL
{
    class LibraryService
    {
        private SqlConnection oleConnection1 = null;
        DataSet ds;

        public LibraryService()
        {
            this.oleConnection1 = new SqlConnection(LibraryMIS.database.dbConnection.connection);
        }

        public DataTable getBookTable()
        {
            oleConnection1.Open();
            string sql = "select BID as 图书编号,BName as 图书名,BWriter as 作者,BPublish as 出版社,BDate as 出版日期,BPrice as 价格," +
                "BNum as 数量,type as 类型,BRemark as 备注 from book";
            SqlDataAdapter adp = new SqlDataAdapter(sql, oleConnection1);
            ds = new DataSet();
            ds.Clear();
            adp.Fill(ds, "book");
            DataTable bookDataTable = ds.Tables["book"];
            oleConnection1.Close();
            return bookDataTable;
        }

        public void AddBook(BookModel book)
        {
            if (book.BID == "" || book.BName == "" || book.BNum == "" || book.BWriter == "")
            //MessageBox.Show("请填写完整信息", "提示");
            {
                throw new Exception("请填写完整信息");
            }
            else
            {
                oleConnection1.Open();
                string sql = "select * from book where BID='" + book.BID + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                if (null != cmd.ExecuteScalar())
                //MessageBox.Show("图书编号重复", "提示");
                {
                    throw new Exception("图书编号重复");
                }
                else
                {
                    sql = "insert into book values ('" + book.BID + "','" + book.BName + "','" + book.BWriter + "'," +
                        "'" + book.BPublish + "','" + book.BDate + "','" + book.BPrice + "','" + book.BNum + "'," +
                        "'" + book.Type + "','" + book.BRemark + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("添加成功", "提示");
                }
                oleConnection1.Close();
            }
        }

        public void UpdateBook(BookModel book)
        {
            if (book.BName == "" || book.BWriter == "" || book.BNum == "")
            //MessageBox.Show("请填写完整信息", "提示");
            {
                throw new Exception("请填写完整信息");
            }
            else
            {
                oleConnection1.Open();
                string sql = "update book set BName='" + book.BName + "',BWriter='" + book.BWriter + "',BPublish='" + book.BPublish + "'," +
                    "BDate='" + book.BDate + "',BNum='" + book.BNum + "',BPrice='" + book.BPrice + "',BRemark='" + book.BRemark + "'" +
                    " where BID='" + book.BID + "'";
                SqlCommand cmd = new SqlCommand(sql, oleConnection1);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("修改成功", "提示");
                //this.Close();
                oleConnection1.Close();
            }
        }




    }
}
