using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DevAge.Data
{
	// Token: 0x020002AD RID: 685
	internal class DataSetHelper
	{
		// Token: 0x060021FD RID: 8701 RVA: 0x00078420 File Offset: 0x00076620
		public static string ExpressionFormat(global::System.DateTime p_Date)
		{
			return "#" + p_Date.ToString("MM/dd/yyyy") + "#";
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00078440 File Offset: 0x00076640
		public static string ExpressionFormat(int p_data)
		{
			return p_data.ToString(global::System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x00078454 File Offset: 0x00076654
		public static string ExpressionFormat(long p_data)
		{
			return p_data.ToString(global::System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x00078468 File Offset: 0x00076668
		public static string ExpressionFormat(float p_data)
		{
			return p_data.ToString(global::System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0007847C File Offset: 0x0007667C
		public static string ExpressionFormat(double p_data)
		{
			return p_data.ToString(global::System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x00078490 File Offset: 0x00076690
		public static string ExpressionFormat(decimal p_data)
		{
			return p_data.ToString(global::System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x000784A4 File Offset: 0x000766A4
		public static string ExpressionFormat(bool p_data)
		{
			return p_data.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x000784B4 File Offset: 0x000766B4
		public static string ExpressionFormat(string p_data)
		{
			p_data = p_data.Replace("'", "''");
			return "'" + p_data + "'";
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000784D8 File Offset: 0x000766D8
		public static string ExpressionFormat(char p_data)
		{
			return global::DevAge.Data.DataSetHelper.ExpressionFormat(p_data.ToString());
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x000784E8 File Offset: 0x000766E8
		public static string ExpressionFormat(global::System.DBNull p_data)
		{
			return "NULL";
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x000784F0 File Offset: 0x000766F0
		public static string ExpressionFormat(object p_data)
		{
			if (p_data is global::System.DateTime)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((global::System.DateTime)p_data);
			}
			if (p_data is int)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((int)p_data);
			}
			if (p_data is long)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((long)p_data);
			}
			if (p_data is float)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((float)p_data);
			}
			if (p_data is double)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((double)p_data);
			}
			if (p_data is decimal)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((decimal)p_data);
			}
			if (p_data is bool)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((bool)p_data);
			}
			if (p_data is string)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((string)p_data);
			}
			if (p_data is char)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((char)p_data);
			}
			if (p_data is global::System.DBNull)
			{
				return global::DevAge.Data.DataSetHelper.ExpressionFormat((global::System.DBNull)p_data);
			}
			throw new global::DevAge.DevAgeApplicationException("Type not supported for expression");
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000785F4 File Offset: 0x000767F4
		public static string LikeExpression(string pFieldName, string pFieldValue)
		{
			string p_data = "%" + pFieldValue + "%";
			return pFieldName + " LIKE " + global::DevAge.Data.DataSetHelper.ExpressionFormat(p_data);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00078628 File Offset: 0x00076828
		public static string StartWithExpression(string pFieldName, string pFieldValue)
		{
			string p_data = pFieldValue + "%";
			return pFieldName + " LIKE " + global::DevAge.Data.DataSetHelper.ExpressionFormat(p_data);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00078658 File Offset: 0x00076858
		public static string EqualExpression(string pFieldName, object pFieldValue)
		{
			return pFieldName + " = " + global::DevAge.Data.DataSetHelper.ExpressionFormat(pFieldValue);
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0007866C File Offset: 0x0007686C
		public static string NotEqualExpression(string pFieldName, object pFieldValue)
		{
			return pFieldName + " <> " + global::DevAge.Data.DataSetHelper.ExpressionFormat(pFieldValue);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00078680 File Offset: 0x00076880
		public static bool ValEquals(object A, object B)
		{
			return (A == global::System.DBNull.Value && B == global::System.DBNull.Value) || (A != global::System.DBNull.Value && B != global::System.DBNull.Value && A.Equals(B));
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000786BC File Offset: 0x000768BC
		public static global::System.Data.DataTable SelectDistinct(global::System.Data.DataTable SourceTable, string FieldName, bool pAddEmptyValue, object EmptyValue)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable();
			dataTable.Columns.Add(FieldName, SourceTable.Columns[FieldName].DataType);
			if (pAddEmptyValue)
			{
				dataTable.Rows.Add(new object[]
				{
					EmptyValue
				});
			}
			object obj = EmptyValue;
			foreach (global::System.Data.DataRow dataRow in SourceTable.Select("", FieldName))
			{
				if (obj == null || !global::DevAge.Data.DataSetHelper.ValEquals(obj, dataRow[FieldName]))
				{
					obj = dataRow[FieldName];
					dataTable.Rows.Add(new object[]
					{
						obj
					});
				}
			}
			return dataTable;
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x0007877C File Offset: 0x0007697C
		public static global::System.Data.DataTable SampleDataByInterval(global::System.Data.DataView sourceView, string[] columns, string samplingField, int intervalValue, global::DevAge.Data.DateTimeInterval intervalType)
		{
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable();
			for (int i = 0; i < columns.Length; i++)
			{
				dataTable.Columns.Add(new global::System.Data.DataColumn(columns[i], sourceView.Table.Columns[columns[i]].DataType));
			}
			if (sourceView.Count > 0)
			{
				global::System.DateTime dateB = (global::System.DateTime)sourceView[0][samplingField];
				global::System.Data.DataRow dataRow = dataTable.NewRow();
				for (int j = 0; j < columns.Length; j++)
				{
					dataRow[columns[j]] = sourceView[0][columns[j]];
				}
				dataTable.Rows.Add(dataRow);
				for (int k = 1; k < sourceView.Count; k++)
				{
					global::System.Data.DataRow row = sourceView[k].Row;
					global::System.DateTime dateA = (global::System.DateTime)row[samplingField];
					if (intervalType != global::DevAge.Data.DateTimeInterval.Months)
					{
						throw new global::System.ApplicationException("Interval not supported");
					}
					int num = global::DevAge.DateTimeHelper.MonthsDifference(dateA, dateB);
					if (num >= intervalValue || k + 1 == sourceView.Count)
					{
						if (intervalType != global::DevAge.Data.DateTimeInterval.Months)
						{
							throw new global::System.ApplicationException("Interval not supported");
						}
						dateB = dateB.AddMonths(intervalValue);
						dataRow = dataTable.NewRow();
						for (int l = 0; l < columns.Length; l++)
						{
							dataRow[columns[l]] = row[columns[l]];
						}
						dataTable.Rows.Add(dataRow);
					}
				}
			}
			return dataTable;
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00078918 File Offset: 0x00076B18
		private static global::System.Data.DataTable EmptyDataTable
		{
			get
			{
				if (global::DevAge.Data.DataSetHelper.tEmptyDataTable == null)
				{
					global::DevAge.Data.DataSetHelper.tEmptyDataTable = new global::System.Data.DataTable();
				}
				return global::DevAge.Data.DataSetHelper.tEmptyDataTable;
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00078934 File Offset: 0x00076B34
		public static object Eval(string expression, params object[] parameters)
		{
			object[] array = null;
			if (parameters != null)
			{
				array = new string[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					array[i] = global::DevAge.Data.DataSetHelper.ExpressionFormat(parameters[i]);
				}
			}
			string expression2;
			if (array != null)
			{
				expression2 = string.Format(expression, array);
			}
			else
			{
				expression2 = expression;
			}
			return global::DevAge.Data.DataSetHelper.EmptyDataTable.Compute(expression2, string.Empty);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00078998 File Offset: 0x00076B98
		public static object EvalRowExpression(global::System.Data.DataRow row, string expression)
		{
			string text = expression;
			for (int i = 0; i < row.Table.Columns.Count; i++)
			{
				string pattern = global::System.Text.RegularExpressions.Regex.Escape("[" + row.Table.Columns[i].ColumnName + "]");
				if (global::System.Text.RegularExpressions.Regex.IsMatch(text, pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase))
				{
					text = global::System.Text.RegularExpressions.Regex.Replace(text, pattern, global::DevAge.Data.DataSetHelper.ExpressionFormat(row[i]), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
				}
				pattern = "\\b" + global::System.Text.RegularExpressions.Regex.Escape(row.Table.Columns[i].ColumnName) + "\\b";
				if (global::System.Text.RegularExpressions.Regex.IsMatch(text, pattern, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase))
				{
					text = global::System.Text.RegularExpressions.Regex.Replace(text, pattern, global::DevAge.Data.DataSetHelper.ExpressionFormat(row[i]), global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
				}
			}
			return global::DevAge.Data.DataSetHelper.Eval(text, null);
		}

		// Token: 0x04000C59 RID: 3161
		[global::System.ThreadStatic]
		private static global::System.Data.DataTable tEmptyDataTable;
	}
}
