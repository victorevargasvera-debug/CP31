using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000437 RID: 1079
	internal class BufferedDataReader : global::System.Data.Common.DbDataReader
	{
		// Token: 0x06003492 RID: 13458 RVA: 0x000A882C File Offset: 0x000A6A2C
		public BufferedDataReader(global::System.Data.Common.DbDataReader reader)
		{
			this._underlyingReader = reader;
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x000A8846 File Offset: 0x000A6A46
		public override int RecordsAffected
		{
			get
			{
				return this._recordsAffected;
			}
		}

		// Token: 0x17000A33 RID: 2611
		public override object this[string name]
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000A34 RID: 2612
		public override object this[int ordinal]
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x000A885C File Offset: 0x000A6A5C
		public override int Depth
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x000A8863 File Offset: 0x000A6A63
		public override int FieldCount
		{
			get
			{
				this.AssertReaderIsOpen();
				return this._currentResultSet.FieldCount;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x000A8876 File Offset: 0x000A6A76
		public override bool HasRows
		{
			get
			{
				this.AssertReaderIsOpen();
				return this._currentResultSet.HasRows;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x000A8889 File Offset: 0x000A6A89
		public override bool IsClosed
		{
			get
			{
				return this._isClosed;
			}
		}

		// Token: 0x0600349A RID: 13466 RVA: 0x000A8891 File Offset: 0x000A6A91
		private void AssertReaderIsOpen()
		{
			if (this._isClosed)
			{
				throw global::System.Data.Entity.Resources.Error.ADP_ClosedDataReaderError();
			}
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x000A88A1 File Offset: 0x000A6AA1
		private void AssertReaderIsOpenWithData()
		{
			if (this._isClosed)
			{
				throw global::System.Data.Entity.Resources.Error.ADP_ClosedDataReaderError();
			}
			if (!this._currentResultSet.IsDataReady)
			{
				throw global::System.Data.Entity.Resources.Error.ADP_NoData();
			}
		}

		// Token: 0x0600349C RID: 13468 RVA: 0x000A88C4 File Offset: 0x000A6AC4
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void AssertFieldIsReady(int ordinal)
		{
			if (this._isClosed)
			{
				throw global::System.Data.Entity.Resources.Error.ADP_ClosedDataReaderError();
			}
			if (!this._currentResultSet.IsDataReady)
			{
				throw global::System.Data.Entity.Resources.Error.ADP_NoData();
			}
			if (0 > ordinal || ordinal > this._currentResultSet.FieldCount)
			{
				throw new global::System.IndexOutOfRangeException();
			}
		}

		// Token: 0x0600349D RID: 13469 RVA: 0x000A8900 File Offset: 0x000A6B00
		internal void Initialize(string providerManifestToken, global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Type[] columnTypes, bool[] nullableColumns)
		{
			global::System.Data.Common.DbDataReader underlyingReader = this._underlyingReader;
			if (underlyingReader == null)
			{
				return;
			}
			this._underlyingReader = null;
			try
			{
				if (columnTypes != null && underlyingReader.GetType().Name != "SqlDataReader")
				{
					this._bufferedDataRecords.Add(global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.Initialize(providerManifestToken, providerServices, underlyingReader, columnTypes, nullableColumns));
				}
				else
				{
					this._bufferedDataRecords.Add(global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord.Initialize(providerManifestToken, providerServices, underlyingReader));
				}
				while (underlyingReader.NextResult())
				{
					this._bufferedDataRecords.Add(global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord.Initialize(providerManifestToken, providerServices, underlyingReader));
				}
				this._recordsAffected = underlyingReader.RecordsAffected;
				this._currentResultSet = this._bufferedDataRecords[this._currentResultSetNumber];
			}
			finally
			{
				underlyingReader.Dispose();
			}
		}

		// Token: 0x0600349E RID: 13470 RVA: 0x000A89C0 File Offset: 0x000A6BC0
		internal async global::System.Threading.Tasks.Task InitializeAsync(string providerManifestToken, global::System.Data.Entity.Core.Common.DbProviderServices providerServices, global::System.Type[] columnTypes, bool[] nullableColumns, global::System.Threading.CancellationToken cancellationToken)
		{
			if (this._underlyingReader != null)
			{
				cancellationToken.ThrowIfCancellationRequested();
				global::System.Data.Common.DbDataReader reader = this._underlyingReader;
				this._underlyingReader = null;
				try
				{
					if (columnTypes != null && reader.GetType().Name != "SqlDataReader")
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord> list = this._bufferedDataRecords;
						global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord item = await global::System.Data.Entity.Core.Objects.Internal.ShapedBufferedDataRecord.InitializeAsync(providerManifestToken, providerServices, reader, columnTypes, nullableColumns, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord>();
						list.Add(item);
						list = null;
					}
					else
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord> list = this._bufferedDataRecords;
						list.Add(await global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord.InitializeAsync(providerManifestToken, providerServices, reader, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord>());
						list = null;
					}
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = reader.NextResultAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord> list = this._bufferedDataRecords;
						list.Add(await global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord.InitializeAsync(providerManifestToken, providerServices, reader, cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.Internal.ShapelessBufferedDataRecord>());
						list = null;
					}
					this._recordsAffected = reader.RecordsAffected;
					this._currentResultSet = this._bufferedDataRecords[this._currentResultSetNumber];
				}
				finally
				{
					reader.Dispose();
				}
			}
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x000A8A30 File Offset: 0x000A6C30
		public override void Close()
		{
			this._bufferedDataRecords = null;
			this._isClosed = true;
			global::System.Data.Common.DbDataReader underlyingReader = this._underlyingReader;
			if (underlyingReader != null)
			{
				this._underlyingReader = null;
				underlyingReader.Dispose();
			}
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000A8A62 File Offset: 0x000A6C62
		protected override void Dispose(bool disposing)
		{
			if (!this._disposed && disposing && !this.IsClosed)
			{
				this.Close();
			}
			this._disposed = true;
			base.Dispose(disposing);
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x000A8A8D File Offset: 0x000A6C8D
		public override bool GetBoolean(int ordinal)
		{
			return this._currentResultSet.GetBoolean(ordinal);
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x000A8A9B File Offset: 0x000A6C9B
		public override byte GetByte(int ordinal)
		{
			return this._currentResultSet.GetByte(ordinal);
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x000A8AA9 File Offset: 0x000A6CA9
		public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x000A8AB0 File Offset: 0x000A6CB0
		public override char GetChar(int ordinal)
		{
			return this._currentResultSet.GetChar(ordinal);
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x000A8ABE File Offset: 0x000A6CBE
		public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x000A8AC5 File Offset: 0x000A6CC5
		public override global::System.DateTime GetDateTime(int ordinal)
		{
			return this._currentResultSet.GetDateTime(ordinal);
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x000A8AD3 File Offset: 0x000A6CD3
		public override decimal GetDecimal(int ordinal)
		{
			return this._currentResultSet.GetDecimal(ordinal);
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x000A8AE1 File Offset: 0x000A6CE1
		public override double GetDouble(int ordinal)
		{
			return this._currentResultSet.GetDouble(ordinal);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x000A8AEF File Offset: 0x000A6CEF
		public override float GetFloat(int ordinal)
		{
			return this._currentResultSet.GetFloat(ordinal);
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000A8AFD File Offset: 0x000A6CFD
		public override global::System.Guid GetGuid(int ordinal)
		{
			return this._currentResultSet.GetGuid(ordinal);
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x000A8B0B File Offset: 0x000A6D0B
		public override short GetInt16(int ordinal)
		{
			return this._currentResultSet.GetInt16(ordinal);
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x000A8B19 File Offset: 0x000A6D19
		public override int GetInt32(int ordinal)
		{
			return this._currentResultSet.GetInt32(ordinal);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x000A8B27 File Offset: 0x000A6D27
		public override long GetInt64(int ordinal)
		{
			return this._currentResultSet.GetInt64(ordinal);
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x000A8B35 File Offset: 0x000A6D35
		public override string GetString(int ordinal)
		{
			return this._currentResultSet.GetString(ordinal);
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x000A8B43 File Offset: 0x000A6D43
		public override T GetFieldValue<T>(int ordinal)
		{
			return this._currentResultSet.GetFieldValue<T>(ordinal);
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x000A8B51 File Offset: 0x000A6D51
		public override global::System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			return this._currentResultSet.GetFieldValueAsync<T>(ordinal, cancellationToken);
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x000A8B60 File Offset: 0x000A6D60
		public override object GetValue(int ordinal)
		{
			return this._currentResultSet.GetValue(ordinal);
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x000A8B6E File Offset: 0x000A6D6E
		public override int GetValues(object[] values)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(values, "values");
			this.AssertReaderIsOpenWithData();
			return this._currentResultSet.GetValues(values);
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x000A8B8E File Offset: 0x000A6D8E
		public override string GetDataTypeName(int ordinal)
		{
			this.AssertReaderIsOpen();
			return this._currentResultSet.GetDataTypeName(ordinal);
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x000A8BA2 File Offset: 0x000A6DA2
		public override global::System.Type GetFieldType(int ordinal)
		{
			this.AssertReaderIsOpen();
			return this._currentResultSet.GetFieldType(ordinal);
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x000A8BB6 File Offset: 0x000A6DB6
		public override string GetName(int ordinal)
		{
			this.AssertReaderIsOpen();
			return this._currentResultSet.GetName(ordinal);
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x000A8BCA File Offset: 0x000A6DCA
		public override int GetOrdinal(string name)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			this.AssertReaderIsOpen();
			return this._currentResultSet.GetOrdinal(name);
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x000A8BEA File Offset: 0x000A6DEA
		public override bool IsDBNull(int ordinal)
		{
			return this._currentResultSet.IsDBNull(ordinal);
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x000A8BF8 File Offset: 0x000A6DF8
		public override global::System.Threading.Tasks.Task<bool> IsDBNullAsync(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			return this._currentResultSet.IsDBNullAsync(ordinal, cancellationToken);
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x000A8C07 File Offset: 0x000A6E07
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::System.Data.Common.DbEnumerator(this);
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x000A8C0F File Offset: 0x000A6E0F
		public override global::System.Data.DataTable GetSchemaTable()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x000A8C18 File Offset: 0x000A6E18
		public override bool NextResult()
		{
			this.AssertReaderIsOpen();
			int num = this._currentResultSetNumber + 1;
			this._currentResultSetNumber = num;
			if (num < this._bufferedDataRecords.Count)
			{
				this._currentResultSet = this._bufferedDataRecords[this._currentResultSetNumber];
				return true;
			}
			this._currentResultSet = null;
			return false;
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x000A8C6A File Offset: 0x000A6E6A
		public override global::System.Threading.Tasks.Task<bool> NextResultAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			return global::System.Threading.Tasks.Task.FromResult<bool>(this.NextResult());
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x000A8C7E File Offset: 0x000A6E7E
		public override bool Read()
		{
			this.AssertReaderIsOpen();
			return this._currentResultSet.Read();
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x000A8C91 File Offset: 0x000A6E91
		public override global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			this.AssertReaderIsOpen();
			return this._currentResultSet.ReadAsync(cancellationToken);
		}

		// Token: 0x040010F5 RID: 4341
		private global::System.Data.Common.DbDataReader _underlyingReader;

		// Token: 0x040010F6 RID: 4342
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord> _bufferedDataRecords = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord>();

		// Token: 0x040010F7 RID: 4343
		private global::System.Data.Entity.Core.Objects.Internal.BufferedDataRecord _currentResultSet;

		// Token: 0x040010F8 RID: 4344
		private int _currentResultSetNumber;

		// Token: 0x040010F9 RID: 4345
		private int _recordsAffected;

		// Token: 0x040010FA RID: 4346
		private bool _disposed;

		// Token: 0x040010FB RID: 4347
		private bool _isClosed;
	}
}
