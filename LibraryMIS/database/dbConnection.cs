using System;

namespace LibraryMIS.database
{
	/// <summary>
	/// dbConnection ��ժҪ˵����
	/// </summary>
	public class dbConnection
	{
		public dbConnection()
		{
			//
			// TODO: �ڴ˴����ӹ��캯���߼�
			//
		}
		public static string connection
		{
			get
			{
                //return "server=ZZTI-SOFTTECH\\SQL2005;database=libraryMIS;uid=sa;pwd=123";
                return @"Data Source=.\sqlexpress;Initial Catalog=LibraryMIS;Integrated Security=True";
            }
		}
	}
}