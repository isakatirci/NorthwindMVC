/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:26:30
**************************************************************/

using System.Data;

namespace NorthwindTest.DataObjects
{
	public class CtSqlParameter
	{
		public static System.Data.SqlClient.SqlParameter Get(
			string parameterName, 
			SqlDbType dbType, 
			int size, 
			ParameterDirection direction, 
			bool isNullable,
			byte precision, 
			byte scale, 
			string sourceColumn, 
			DataRowVersion sourceVersion,
			object value
			)
		{
		return new System.Data.SqlClient.SqlParameter(
			parameterName,
			dbType,
			size,
			direction,
			precision,
			scale,
			sourceColumn,
			sourceVersion,
			isNullable,
			value,
			null,
			null,
			null);
		}
	}
}
