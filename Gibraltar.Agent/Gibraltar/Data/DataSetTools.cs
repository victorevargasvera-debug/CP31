using System;
using System.Data;

namespace Gibraltar.Data
{
	// Token: 0x020000D7 RID: 215
	internal static class DataSetTools
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00013818 File Offset: 0x00011A18
		public static bool ColumnEqual(object a, object b)
		{
			if (a == null && b == null)
			{
				return true;
			}
			if (a == global::System.DBNull.Value && b == global::System.DBNull.Value)
			{
				return true;
			}
			if (a is string || b is string)
			{
				string value = (a == global::System.DBNull.Value) ? null : ((string)a);
				string value2 = (b == global::System.DBNull.Value) ? null : ((string)b);
				return (string.IsNullOrEmpty(value) && string.IsNullOrEmpty(value2)) || (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(value2) && ((string)a).Equals((string)b, global::System.StringComparison.InvariantCultureIgnoreCase));
			}
			return a != global::System.DBNull.Value && b != global::System.DBNull.Value && a != null && b != null && a.Equals(b);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00013908 File Offset: 0x00011B08
		public static global::System.Data.DataSet FilterDataSet(global::System.Data.DataSet sourceData, string filter)
		{
			return global::Gibraltar.Data.DataSetTools.FilterDataSet(sourceData, filter, null);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00013914 File Offset: 0x00011B14
		public static global::System.Data.DataSet FilterDataSet(global::System.Data.DataSet sourceData, string filter, string sortOrder)
		{
			if (sourceData == null)
			{
				throw new global::System.ArgumentNullException("sourceData");
			}
			if (string.IsNullOrEmpty(filter))
			{
				return sourceData.Copy();
			}
			global::System.Data.DataSet dataSet = sourceData.Copy();
			dataSet.Clear();
			if (string.IsNullOrEmpty(sortOrder))
			{
				dataSet.Merge(sourceData.Tables[0].Select(filter));
			}
			else
			{
				dataSet.Merge(sourceData.Tables[0].Select(filter, sortOrder));
			}
			return dataSet;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00013998 File Offset: 0x00011B98
		public static global::System.Data.DataTable SelectDistinctValues(string tableName, global::System.Data.DataTable sourceTable, string valueColumnName, string captionColumnName, bool includeAll, bool includeNull = true)
		{
			if (string.IsNullOrEmpty(tableName))
			{
				throw new global::System.ArgumentNullException("tableName");
			}
			if (sourceTable == null)
			{
				throw new global::System.ArgumentNullException("sourceTable");
			}
			if (string.IsNullOrEmpty(valueColumnName))
			{
				throw new global::System.ArgumentNullException("valueColumnName");
			}
			if (string.IsNullOrEmpty(captionColumnName))
			{
				throw new global::System.ArgumentNullException("captionColumnName");
			}
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable(tableName);
			global::System.Data.DataColumn dataColumn = sourceTable.Columns[valueColumnName];
			global::System.Data.DataColumn dataColumn2 = sourceTable.Columns[captionColumnName];
			if (dataColumn == null)
			{
				throw new global::System.ArgumentException("No column could be found with the name " + valueColumnName, "valueColumnName");
			}
			if (dataColumn2 == null)
			{
				throw new global::System.ArgumentException("No column could be found with the name " + captionColumnName, "captionColumnName");
			}
			dataTable.Columns.Add("Value", dataColumn.DataType);
			dataTable.Columns.Add("Caption", dataColumn2.DataType);
			if (includeAll)
			{
				dataTable.Rows.Add(new object[]
				{
					null,
					"(All)"
				});
			}
			object obj = null;
			string filterExpression = includeNull ? string.Empty : (valueColumnName + " IS NOT NULL");
			foreach (global::System.Data.DataRow dataRow in sourceTable.Select(filterExpression, valueColumnName))
			{
				object obj2 = dataRow[dataColumn];
				if ((obj == null && includeNull) || !global::Gibraltar.Data.DataSetTools.ColumnEqual(obj, obj2))
				{
					obj = obj2;
					object obj3 = dataRow[dataColumn2];
					if (obj3 is string)
					{
						obj3 = (string.IsNullOrEmpty((string)obj3) ? null : obj3);
					}
					if (obj3 == null || obj3 == global::System.DBNull.Value)
					{
						obj3 = "(None)";
					}
					dataTable.Rows.Add(new object[]
					{
						obj,
						obj3
					});
				}
			}
			return dataTable;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00013B80 File Offset: 0x00011D80
		public static global::System.Data.DataView SelectTop(global::System.Data.DataView sourceView, int rows, string keyColumnName)
		{
			if (sourceView == null)
			{
				throw new global::System.ArgumentNullException("sourceView");
			}
			global::System.Data.DataTable dataTable = sourceView.ToTable();
			global::System.Data.DataTable dataTable2 = dataTable.Clone();
			bool flag = false;
			if (!string.IsNullOrEmpty(keyColumnName))
			{
				dataTable2.PrimaryKey = new global::System.Data.DataColumn[]
				{
					dataTable2.Columns[keyColumnName]
				};
				flag = true;
			}
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				global::System.Data.DataRow dataRow = dataTable.Rows[i];
				if (!flag || dataTable2.Rows.Find(dataRow[keyColumnName]) == null)
				{
					dataTable2.ImportRow(dataTable.Rows[i]);
				}
				if (dataTable2.Rows.Count == rows)
				{
					break;
				}
			}
			return new global::System.Data.DataView(dataTable2);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00013C48 File Offset: 0x00011E48
		public static global::System.Data.DataTable Join(global::System.Data.DataTable firstTable, global::System.Data.DataTable secondTable, global::System.Data.DataColumn[] firstJoinColumnArray, global::System.Data.DataColumn[] secondJoinColumnArray)
		{
			if (firstTable == null)
			{
				throw new global::System.ArgumentNullException("firstTable");
			}
			if (secondTable == null)
			{
				throw new global::System.ArgumentNullException("secondTable");
			}
			if (firstJoinColumnArray == null)
			{
				throw new global::System.ArgumentNullException("firstJoinColumnArray");
			}
			if (secondJoinColumnArray == null)
			{
				throw new global::System.ArgumentNullException("secondJoinColumnArray");
			}
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable("Join");
			using (global::System.Data.DataSet dataSet = new global::System.Data.DataSet())
			{
				dataSet.Tables.AddRange(new global::System.Data.DataTable[]
				{
					firstTable.Copy(),
					secondTable.Copy()
				});
				global::System.Data.DataColumn[] array = new global::System.Data.DataColumn[firstJoinColumnArray.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = dataSet.Tables[0].Columns[firstJoinColumnArray[i].ColumnName];
				}
				global::System.Data.DataColumn[] array2 = new global::System.Data.DataColumn[secondJoinColumnArray.Length];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = dataSet.Tables[1].Columns[secondJoinColumnArray[j].ColumnName];
				}
				global::System.Data.DataRelation relation = new global::System.Data.DataRelation(string.Empty, array, array2, false);
				dataSet.Relations.Add(relation);
				for (int k = 0; k < firstTable.Columns.Count; k++)
				{
					dataTable.Columns.Add(firstTable.Columns[k].ColumnName, firstTable.Columns[k].DataType);
				}
				for (int l = 0; l < secondTable.Columns.Count; l++)
				{
					if (!dataTable.Columns.Contains(secondTable.Columns[l].ColumnName))
					{
						dataTable.Columns.Add(secondTable.Columns[l].ColumnName, secondTable.Columns[l].DataType);
					}
					else
					{
						dataTable.Columns.Add(secondTable.Columns[l].ColumnName + "_Second", secondTable.Columns[l].DataType);
					}
				}
				dataTable.BeginLoadData();
				foreach (object obj in dataSet.Tables[0].Rows)
				{
					global::System.Data.DataRow dataRow = (global::System.Data.DataRow)obj;
					global::System.Data.DataRow[] childRows = dataRow.GetChildRows(relation);
					if (childRows != null && childRows.Length != 0)
					{
						object[] itemArray = dataRow.ItemArray;
						global::System.Data.DataRow[] array3 = childRows;
						for (int m = 0; m < array3.Length; m++)
						{
							object[] itemArray2 = array3[m].ItemArray;
							object[] array4 = new object[itemArray.Length + itemArray2.Length];
							global::System.Array.Copy(itemArray, 0, array4, 0, itemArray.Length);
							global::System.Array.Copy(itemArray2, 0, array4, itemArray.Length, itemArray2.Length);
							dataTable.LoadDataRow(array4, true);
						}
					}
				}
				dataTable.EndLoadData();
			}
			return dataTable;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00013FA8 File Offset: 0x000121A8
		public static global::System.Data.DataTable Join(global::System.Data.DataTable first, global::System.Data.DataTable second, global::System.Data.DataColumn firstJoinColumn, global::System.Data.DataColumn secondJoinColumn)
		{
			return global::Gibraltar.Data.DataSetTools.Join(first, second, new global::System.Data.DataColumn[]
			{
				firstJoinColumn
			}, new global::System.Data.DataColumn[]
			{
				secondJoinColumn
			});
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00013FC8 File Offset: 0x000121C8
		public static global::System.Data.DataTable Join(global::System.Data.DataTable first, global::System.Data.DataTable second, string firstJoinColumn, string secondJoinColumn)
		{
			return global::Gibraltar.Data.DataSetTools.Join(first, second, new global::System.Data.DataColumn[]
			{
				first.Columns[firstJoinColumn]
			}, new global::System.Data.DataColumn[]
			{
				first.Columns[secondJoinColumn]
			});
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x0001400C File Offset: 0x0001220C
		public static T ReadNullableObject<T>(object adoColumnValue) where T : class
		{
			if (adoColumnValue == global::System.DBNull.Value)
			{
				return default(T);
			}
			return (T)((object)adoColumnValue);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00014038 File Offset: 0x00012238
		public static T? ReadNullableValue<T>(object adoColumnValue) where T : struct
		{
			if (adoColumnValue == global::System.DBNull.Value)
			{
				return null;
			}
			return new T?((T)((object)adoColumnValue));
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0001406C File Offset: 0x0001226C
		public static object ReadDbNullValue(object adoColumnValue)
		{
			if (adoColumnValue == global::System.DBNull.Value)
			{
				return null;
			}
			return adoColumnValue;
		}
	}
}
