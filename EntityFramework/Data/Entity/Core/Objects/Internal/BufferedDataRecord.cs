using System;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000438 RID: 1080
	internal abstract class BufferedDataRecord
	{
		// Token: 0x060034BF RID: 13503 RVA: 0x000A8CAC File Offset: 0x000A6EAC
		protected virtual void ReadMetadata(string providerManifestToken, global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Data.Common.DbDataReader reader)
		{
			int fieldCount = reader.FieldCount;
			string[] array = new string[fieldCount];
			global::System.Type[] array2 = new global::System.Type[fieldCount];
			string[] columnNames = new string[fieldCount];
			for (int i = 0; i < fieldCount; i++)
			{
				array[i] = reader.GetDataTypeName(i);
				array2[i] = reader.GetFieldType(i);
				columnNames[i] = reader.GetName(i);
			}
			this._dataTypeNames = array;
			this._fieldTypes = array2;
			this._columnNames = columnNames;
			this._fieldNameLookup = new global::System.Lazy<global::System.Data.Entity.Core.FieldNameLookup>(() => new global::System.Data.Entity.Core.FieldNameLookup(new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(columnNames)), false);
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x000A8D4B File Offset: 0x000A6F4B
		// (set) Token: 0x060034C1 RID: 13505 RVA: 0x000A8D53 File Offset: 0x000A6F53
		public bool IsDataReady { get; protected set; }

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x000A8D5C File Offset: 0x000A6F5C
		public bool HasRows
		{
			get
			{
				return this._rowCount > 0;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x000A8D67 File Offset: 0x000A6F67
		public int FieldCount
		{
			get
			{
				return this._dataTypeNames.Length;
			}
		}

		// Token: 0x060034C4 RID: 13508
		public abstract bool GetBoolean(int ordinal);

		// Token: 0x060034C5 RID: 13509
		public abstract byte GetByte(int ordinal);

		// Token: 0x060034C6 RID: 13510
		public abstract char GetChar(int ordinal);

		// Token: 0x060034C7 RID: 13511
		public abstract global::System.DateTime GetDateTime(int ordinal);

		// Token: 0x060034C8 RID: 13512
		public abstract decimal GetDecimal(int ordinal);

		// Token: 0x060034C9 RID: 13513
		public abstract double GetDouble(int ordinal);

		// Token: 0x060034CA RID: 13514
		public abstract float GetFloat(int ordinal);

		// Token: 0x060034CB RID: 13515
		public abstract global::System.Guid GetGuid(int ordinal);

		// Token: 0x060034CC RID: 13516
		public abstract short GetInt16(int ordinal);

		// Token: 0x060034CD RID: 13517
		public abstract int GetInt32(int ordinal);

		// Token: 0x060034CE RID: 13518
		public abstract long GetInt64(int ordinal);

		// Token: 0x060034CF RID: 13519
		public abstract string GetString(int ordinal);

		// Token: 0x060034D0 RID: 13520
		public abstract T GetFieldValue<T>(int ordinal);

		// Token: 0x060034D1 RID: 13521
		public abstract global::System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x060034D2 RID: 13522
		public abstract object GetValue(int ordinal);

		// Token: 0x060034D3 RID: 13523
		public abstract int GetValues(object[] values);

		// Token: 0x060034D4 RID: 13524
		public abstract bool IsDBNull(int ordinal);

		// Token: 0x060034D5 RID: 13525
		public abstract global::System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x060034D6 RID: 13526 RVA: 0x000A8D71 File Offset: 0x000A6F71
		public string GetDataTypeName(int ordinal)
		{
			return this._dataTypeNames[ordinal];
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x000A8D7B File Offset: 0x000A6F7B
		public global::System.Type GetFieldType(int ordinal)
		{
			return this._fieldTypes[ordinal];
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x000A8D85 File Offset: 0x000A6F85
		public string GetName(int ordinal)
		{
			return this._columnNames[ordinal];
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x000A8D8F File Offset: 0x000A6F8F
		public int GetOrdinal(string name)
		{
			return this._fieldNameLookup.Value.GetOrdinal(name);
		}

		// Token: 0x060034DA RID: 13530
		public abstract bool Read();

		// Token: 0x060034DB RID: 13531
		public abstract global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x040010FC RID: 4348
		protected int _currentRowNumber = -1;

		// Token: 0x040010FD RID: 4349
		protected int _rowCount;

		// Token: 0x040010FE RID: 4350
		private string[] _dataTypeNames;

		// Token: 0x040010FF RID: 4351
		private global::System.Type[] _fieldTypes;

		// Token: 0x04001100 RID: 4352
		private string[] _columnNames;

		// Token: 0x04001101 RID: 4353
		private global::System.Lazy<global::System.Data.Entity.Core.FieldNameLookup> _fieldNameLookup;
	}
}
