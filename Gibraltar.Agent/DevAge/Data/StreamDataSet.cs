using System;
using System.Data;
using System.IO;
using DevAge.IO;

namespace DevAge.Data
{
	// Token: 0x0200028E RID: 654
	internal static class StreamDataSet
	{
		// Token: 0x0600217A RID: 8570 RVA: 0x00077298 File Offset: 0x00075498
		public static void Write(global::System.IO.Stream destination, global::System.Data.DataSet source, global::DevAge.Data.StreamDataSetFormat format)
		{
			switch (format)
			{
			case global::DevAge.Data.StreamDataSetFormat.XML:
				source.WriteXml(destination, global::System.Data.XmlWriteMode.WriteSchema);
				return;
			case global::DevAge.Data.StreamDataSetFormat.Binary:
				global::DevAge.Data.StreamDataSet.BinWriteDataSetToStream(destination, source);
				return;
			default:
				throw new global::System.ApplicationException("StreamDataSet Format not supported");
			}
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000772DC File Offset: 0x000754DC
		public static void Read(global::System.IO.Stream source, global::System.Data.DataSet destination, global::DevAge.Data.StreamDataSetFormat format, bool mergeSchema)
		{
			bool enforceConstraints = destination.EnforceConstraints;
			destination.EnforceConstraints = false;
			try
			{
				switch (format)
				{
				case global::DevAge.Data.StreamDataSetFormat.XML:
					if (mergeSchema)
					{
						destination.ReadXml(source, global::System.Data.XmlReadMode.ReadSchema);
					}
					else
					{
						destination.ReadXml(source, global::System.Data.XmlReadMode.IgnoreSchema);
					}
					break;
				case global::DevAge.Data.StreamDataSetFormat.Binary:
					global::DevAge.Data.StreamDataSet.BinReadDataSetFromStream(source, destination, mergeSchema);
					break;
				default:
					throw new global::System.ApplicationException("StreamDataSet Format not supported");
				}
			}
			finally
			{
				destination.EnforceConstraints = enforceConstraints;
			}
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00077368 File Offset: 0x00075568
		private static void BinWriteDataSetToStream(global::System.IO.Stream stream, global::System.Data.DataSet ds)
		{
			global::DevAge.IO.StreamPersistence.Write(stream, 1);
			byte[] p_Bytes;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				ds.WriteXmlSchema(memoryStream);
				memoryStream.Flush();
				memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				p_Bytes = memoryStream.ToArray();
			}
			global::DevAge.IO.StreamPersistence.Write(stream, p_Bytes);
			for (int i = 0; i < ds.Tables.Count; i++)
			{
				global::System.Data.DataTable dataTable = ds.Tables[i];
				global::System.Data.DataRow[] array = dataTable.Select(null, null, global::System.Data.DataViewRowState.CurrentRows);
				global::DevAge.IO.StreamPersistence.Write(stream, array.Length);
				for (int j = 0; j < array.Length; j++)
				{
					for (int k = 0; k < dataTable.Columns.Count; k++)
					{
						global::DevAge.Data.StreamDataSet.BinWriteFieldToStream(stream, array[j][k], dataTable.Columns[k].DataType);
					}
				}
			}
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00077464 File Offset: 0x00075664
		private static void BinReadDataSetFromStream(global::System.IO.Stream stream, global::System.Data.DataSet ds, bool mergeSchema)
		{
			int num = global::DevAge.IO.StreamPersistence.ReadInt32(stream);
			if (num != 1)
			{
				throw new global::DevAge.Data.BinaryDataSetVersionException();
			}
			byte[] buffer = global::DevAge.IO.StreamPersistence.ReadByteArray(stream);
			global::System.Data.DataSet dataSet;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer))
			{
				if (mergeSchema)
				{
					ds.ReadXmlSchema(memoryStream);
					dataSet = ds;
				}
				else
				{
					dataSet = new global::System.Data.DataSet();
					dataSet.ReadXmlSchema(memoryStream);
				}
			}
			for (int i = 0; i < dataSet.Tables.Count; i++)
			{
				global::System.Data.DataTable dataTable = dataSet.Tables[i];
				if (ds.Tables.Contains(dataTable.TableName))
				{
					global::System.Data.DataTable dataTable2 = ds.Tables[dataTable.TableName];
					int num2 = global::DevAge.IO.StreamPersistence.ReadInt32(stream);
					for (int j = 0; j < num2; j++)
					{
						global::System.Data.DataRow dataRow = dataTable2.NewRow();
						for (int k = 0; k < dataTable.Columns.Count; k++)
						{
							string columnName = dataTable.Columns[k].ColumnName;
							object value = global::DevAge.Data.StreamDataSet.BinReadFieldFromStream(stream, dataTable.Columns[k].DataType);
							if (dataTable2.Columns.Contains(columnName))
							{
								dataRow[columnName] = value;
							}
						}
						dataTable2.Rows.Add(dataRow);
					}
				}
				else
				{
					int num3 = global::DevAge.IO.StreamPersistence.ReadInt32(stream);
					for (int l = 0; l < num3; l++)
					{
						for (int m = 0; m < dataTable.Columns.Count; m++)
						{
							global::DevAge.Data.StreamDataSet.BinReadFieldFromStream(stream, dataTable.Columns[m].DataType);
						}
					}
				}
			}
			ds.AcceptChanges();
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00077634 File Offset: 0x00075834
		private static void BinWriteFieldToStream(global::System.IO.Stream stream, object val, global::System.Type columnType)
		{
			if (val == null)
			{
				global::DevAge.IO.StreamPersistence.Write(stream, 0);
				return;
			}
			if (val == global::System.DBNull.Value)
			{
				global::DevAge.IO.StreamPersistence.Write(stream, 1);
				return;
			}
			global::DevAge.IO.StreamPersistence.Write(stream, 2);
			global::DevAge.IO.StreamPersistence.Write(stream, columnType, val);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00077668 File Offset: 0x00075868
		private static object BinReadFieldFromStream(global::System.IO.Stream stream, global::System.Type columnType)
		{
			byte b = global::DevAge.IO.StreamPersistence.ReadByte(stream);
			if (b == 0)
			{
				return null;
			}
			if (b == 1)
			{
				return global::System.DBNull.Value;
			}
			if (b == 2)
			{
				return global::DevAge.IO.StreamPersistence.Read(stream, columnType);
			}
			throw new global::DevAge.Data.BinaryDataSetInvalidException();
		}

		// Token: 0x04000C37 RID: 3127
		private const int c_BinaryVersion = 1;
	}
}
