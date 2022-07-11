using System;

namespace LibraryMIS.database
{
	/// <summary>
	/// dbConnection 的摘要说明。
	/// </summary>
	public class dbConnection
	{
		public dbConnection()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public static string connection
		{
			get
			{
                //return "server=ZZTI-SOFTTECH\\SQL2005;database=libraryMIS;uid=sa;pwd=123";
                return @"Data Source=.;Initial Catalog=shiyan7;Integrated Security=True";
            }
		}
	}
}
