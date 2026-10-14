using System;
using System.Collections;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x02000021 RID: 33
	internal class SqlDataReaderWrapper : global::System.MarshalByRefObject
	{
		// Token: 0x06000377 RID: 887 RVA: 0x0000EB93 File Offset: 0x0000CD93
		protected SqlDataReaderWrapper()
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000EB9B File Offset: 0x0000CD9B
		public SqlDataReaderWrapper(global::System.Data.SqlClient.SqlDataReader sqlDataReader)
		{
			this._sqlDataReader = sqlDataReader;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000EBAA File Offset: 0x0000CDAA
		public virtual global::System.Data.IDataReader GetData(int i)
		{
			return ((global::System.Data.IDataRecord)this._sqlDataReader).GetData(i);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		public virtual void Dispose()
		{
			this._sqlDataReader.Dispose();
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000EBC5 File Offset: 0x0000CDC5
		public virtual global::System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal)
		{
			return this._sqlDataReader.GetFieldValueAsync<T>(ordinal);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000EBD3 File Offset: 0x0000CDD3
		public virtual global::System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal)
		{
			return this._sqlDataReader.IsDBNullAsync(ordinal);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000EBE1 File Offset: 0x0000CDE1
		public virtual global::System.Threading.Tasks.Task<bool> ReadAsync()
		{
			return this._sqlDataReader.ReadAsync();
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000EBEE File Offset: 0x0000CDEE
		public virtual global::System.Threading.Tasks.Task<bool> NextResultAsync()
		{
			return this._sqlDataReader.NextResultAsync();
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000EBFB File Offset: 0x0000CDFB
		public virtual void Close()
		{
			this._sqlDataReader.Close();
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000EC08 File Offset: 0x0000CE08
		public virtual string GetDataTypeName(int i)
		{
			return this._sqlDataReader.GetDataTypeName(i);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000EC16 File Offset: 0x0000CE16
		public virtual global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._sqlDataReader.GetEnumerator();
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000EC23 File Offset: 0x0000CE23
		public virtual global::System.Type GetFieldType(int i)
		{
			return this._sqlDataReader.GetFieldType(i);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000EC31 File Offset: 0x0000CE31
		public virtual string GetName(int i)
		{
			return this._sqlDataReader.GetName(i);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000EC3F File Offset: 0x0000CE3F
		public virtual global::System.Type GetProviderSpecificFieldType(int i)
		{
			return this._sqlDataReader.GetProviderSpecificFieldType(i);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000EC4D File Offset: 0x0000CE4D
		public virtual int GetOrdinal(string name)
		{
			return this._sqlDataReader.GetOrdinal(name);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000EC5B File Offset: 0x0000CE5B
		public virtual object GetProviderSpecificValue(int i)
		{
			return this._sqlDataReader.GetProviderSpecificValue(i);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000EC69 File Offset: 0x0000CE69
		public virtual int GetProviderSpecificValues(object[] values)
		{
			return this._sqlDataReader.GetProviderSpecificValues(values);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000EC77 File Offset: 0x0000CE77
		public virtual global::System.Data.DataTable GetSchemaTable()
		{
			return this._sqlDataReader.GetSchemaTable();
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000EC84 File Offset: 0x0000CE84
		public virtual bool GetBoolean(int i)
		{
			return this._sqlDataReader.GetBoolean(i);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000EC92 File Offset: 0x0000CE92
		public virtual global::System.Xml.XmlReader GetXmlReader(int i)
		{
			return this._sqlDataReader.GetXmlReader(i);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		public virtual global::System.IO.Stream GetStream(int i)
		{
			return this._sqlDataReader.GetStream(i);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000ECAE File Offset: 0x0000CEAE
		public virtual byte GetByte(int i)
		{
			return this._sqlDataReader.GetByte(i);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		public virtual long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length)
		{
			return this._sqlDataReader.GetBytes(i, dataIndex, buffer, bufferIndex, length);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		public virtual global::System.IO.TextReader GetTextReader(int i)
		{
			return this._sqlDataReader.GetTextReader(i);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000ECDE File Offset: 0x0000CEDE
		public virtual char GetChar(int i)
		{
			return this._sqlDataReader.GetChar(i);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		public virtual long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length)
		{
			return this._sqlDataReader.GetChars(i, dataIndex, buffer, bufferIndex, length);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000ED00 File Offset: 0x0000CF00
		public virtual global::System.DateTime GetDateTime(int i)
		{
			return this._sqlDataReader.GetDateTime(i);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000ED0E File Offset: 0x0000CF0E
		public virtual decimal GetDecimal(int i)
		{
			return this._sqlDataReader.GetDecimal(i);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000ED1C File Offset: 0x0000CF1C
		public virtual double GetDouble(int i)
		{
			return this._sqlDataReader.GetDouble(i);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000ED2A File Offset: 0x0000CF2A
		public virtual float GetFloat(int i)
		{
			return this._sqlDataReader.GetFloat(i);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000ED38 File Offset: 0x0000CF38
		public virtual global::System.Guid GetGuid(int i)
		{
			return this._sqlDataReader.GetGuid(i);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000ED46 File Offset: 0x0000CF46
		public virtual short GetInt16(int i)
		{
			return this._sqlDataReader.GetInt16(i);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000ED54 File Offset: 0x0000CF54
		public virtual int GetInt32(int i)
		{
			return this._sqlDataReader.GetInt32(i);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000ED62 File Offset: 0x0000CF62
		public virtual long GetInt64(int i)
		{
			return this._sqlDataReader.GetInt64(i);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000ED70 File Offset: 0x0000CF70
		public virtual global::System.Data.SqlTypes.SqlBoolean GetSqlBoolean(int i)
		{
			return this._sqlDataReader.GetSqlBoolean(i);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000ED7E File Offset: 0x0000CF7E
		public virtual global::System.Data.SqlTypes.SqlBinary GetSqlBinary(int i)
		{
			return this._sqlDataReader.GetSqlBinary(i);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000ED8C File Offset: 0x0000CF8C
		public virtual global::System.Data.SqlTypes.SqlByte GetSqlByte(int i)
		{
			return this._sqlDataReader.GetSqlByte(i);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000ED9A File Offset: 0x0000CF9A
		public virtual global::System.Data.SqlTypes.SqlBytes GetSqlBytes(int i)
		{
			return this._sqlDataReader.GetSqlBytes(i);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		public virtual global::System.Data.SqlTypes.SqlChars GetSqlChars(int i)
		{
			return this._sqlDataReader.GetSqlChars(i);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000EDB6 File Offset: 0x0000CFB6
		public virtual global::System.Data.SqlTypes.SqlDateTime GetSqlDateTime(int i)
		{
			return this._sqlDataReader.GetSqlDateTime(i);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
		public virtual global::System.Data.SqlTypes.SqlDecimal GetSqlDecimal(int i)
		{
			return this._sqlDataReader.GetSqlDecimal(i);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000EDD2 File Offset: 0x0000CFD2
		public virtual global::System.Data.SqlTypes.SqlGuid GetSqlGuid(int i)
		{
			return this._sqlDataReader.GetSqlGuid(i);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		public virtual global::System.Data.SqlTypes.SqlDouble GetSqlDouble(int i)
		{
			return this._sqlDataReader.GetSqlDouble(i);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000EDEE File Offset: 0x0000CFEE
		public virtual global::System.Data.SqlTypes.SqlInt16 GetSqlInt16(int i)
		{
			return this._sqlDataReader.GetSqlInt16(i);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000EDFC File Offset: 0x0000CFFC
		public virtual global::System.Data.SqlTypes.SqlInt32 GetSqlInt32(int i)
		{
			return this._sqlDataReader.GetSqlInt32(i);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000EE0A File Offset: 0x0000D00A
		public virtual global::System.Data.SqlTypes.SqlInt64 GetSqlInt64(int i)
		{
			return this._sqlDataReader.GetSqlInt64(i);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000EE18 File Offset: 0x0000D018
		public virtual global::System.Data.SqlTypes.SqlMoney GetSqlMoney(int i)
		{
			return this._sqlDataReader.GetSqlMoney(i);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000EE26 File Offset: 0x0000D026
		public virtual global::System.Data.SqlTypes.SqlSingle GetSqlSingle(int i)
		{
			return this._sqlDataReader.GetSqlSingle(i);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000EE34 File Offset: 0x0000D034
		public virtual global::System.Data.SqlTypes.SqlString GetSqlString(int i)
		{
			return this._sqlDataReader.GetSqlString(i);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000EE42 File Offset: 0x0000D042
		public virtual global::System.Data.SqlTypes.SqlXml GetSqlXml(int i)
		{
			return this._sqlDataReader.GetSqlXml(i);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000EE50 File Offset: 0x0000D050
		public virtual object GetSqlValue(int i)
		{
			return this._sqlDataReader.GetSqlValue(i);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000EE5E File Offset: 0x0000D05E
		public virtual int GetSqlValues(object[] values)
		{
			return this._sqlDataReader.GetSqlValues(values);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000EE6C File Offset: 0x0000D06C
		public virtual string GetString(int i)
		{
			return this._sqlDataReader.GetString(i);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000EE7A File Offset: 0x0000D07A
		public virtual T GetFieldValue<T>(int i)
		{
			return this._sqlDataReader.GetFieldValue<T>(i);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000EE88 File Offset: 0x0000D088
		public virtual object GetValue(int i)
		{
			return this._sqlDataReader.GetValue(i);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000EE96 File Offset: 0x0000D096
		public virtual global::System.TimeSpan GetTimeSpan(int i)
		{
			return this._sqlDataReader.GetTimeSpan(i);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		public virtual global::System.DateTimeOffset GetDateTimeOffset(int i)
		{
			return this._sqlDataReader.GetDateTimeOffset(i);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000EEB2 File Offset: 0x0000D0B2
		public virtual int GetValues(object[] values)
		{
			return this._sqlDataReader.GetValues(values);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
		public virtual bool IsDBNull(int i)
		{
			return this._sqlDataReader.IsDBNull(i);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000EECE File Offset: 0x0000D0CE
		public virtual bool NextResult()
		{
			return this._sqlDataReader.NextResult();
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000EEDB File Offset: 0x0000D0DB
		public virtual bool Read()
		{
			return this._sqlDataReader.Read();
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000EEE8 File Offset: 0x0000D0E8
		public virtual global::System.Threading.Tasks.Task<bool> NextResultAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			return this._sqlDataReader.NextResultAsync(cancellationToken);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000EEFD File Offset: 0x0000D0FD
		public virtual global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			return this._sqlDataReader.ReadAsync(cancellationToken);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000EF12 File Offset: 0x0000D112
		public virtual global::System.Threading.Tasks.Task<bool> IsDBNullAsync(int i, global::System.Threading.CancellationToken cancellationToken)
		{
			return this._sqlDataReader.IsDBNullAsync(i, cancellationToken);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000EF21 File Offset: 0x0000D121
		public virtual global::System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int i, global::System.Threading.CancellationToken cancellationToken)
		{
			return this._sqlDataReader.GetFieldValueAsync<T>(i, cancellationToken);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000EF30 File Offset: 0x0000D130
		public virtual int Depth
		{
			get
			{
				return this._sqlDataReader.Depth;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x0000EF3D File Offset: 0x0000D13D
		public virtual int FieldCount
		{
			get
			{
				return this._sqlDataReader.FieldCount;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000EF4A File Offset: 0x0000D14A
		public virtual bool HasRows
		{
			get
			{
				return this._sqlDataReader.HasRows;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0000EF57 File Offset: 0x0000D157
		public virtual bool IsClosed
		{
			get
			{
				return this._sqlDataReader.IsClosed;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0000EF64 File Offset: 0x0000D164
		public virtual int RecordsAffected
		{
			get
			{
				return this._sqlDataReader.RecordsAffected;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000EF71 File Offset: 0x0000D171
		public virtual int VisibleFieldCount
		{
			get
			{
				return this._sqlDataReader.VisibleFieldCount;
			}
		}

		// Token: 0x1700009F RID: 159
		public virtual object this[int i]
		{
			get
			{
				return this._sqlDataReader[i];
			}
		}

		// Token: 0x170000A0 RID: 160
		public virtual object this[string name]
		{
			get
			{
				return this._sqlDataReader[name];
			}
		}

		// Token: 0x040000CC RID: 204
		private readonly global::System.Data.SqlClient.SqlDataReader _sqlDataReader;
	}
}
