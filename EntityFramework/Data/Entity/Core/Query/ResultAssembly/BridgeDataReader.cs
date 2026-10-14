using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Internal.Materialization;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.PlanCompiler;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Query.ResultAssembly
{
	// Token: 0x02000328 RID: 808
	internal class BridgeDataReader : global::System.Data.Common.DbDataReader, global::System.Data.Entity.Core.IExtendedDataRecord, global::System.Data.IDataRecord
	{
		// Token: 0x0600266F RID: 9839 RVA: 0x0006DD90 File Offset: 0x0006BF90
		internal BridgeDataReader(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> coordinatorFactory, int depth, global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>>> nextResultShaperInfos)
		{
			global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader <>4__this = this;
			this._nextResultShaperInfoEnumerator = nextResultShaperInfos;
			this._initialize = delegate()
			{
				<>4__this.SetShaper(shaper, coordinatorFactory, depth);
			};
			this._initializeAsync = ((global::System.Threading.CancellationToken ct) => <>4__this.SetShaperAsync(shaper, coordinatorFactory, depth, ct));
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x0006DDF1 File Offset: 0x0006BFF1
		protected virtual void EnsureInitialized()
		{
			if (global::System.Threading.Interlocked.CompareExchange(ref this._initialized, 1, 0) == 0)
			{
				this._initialize();
			}
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x0006DE0D File Offset: 0x0006C00D
		protected virtual global::System.Threading.Tasks.Task EnsureInitializedAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (global::System.Threading.Interlocked.CompareExchange(ref this._initialized, 1, 0) != 0)
			{
				return global::System.Threading.Tasks.Task.FromResult<object>(null);
			}
			return this._initializeAsync(cancellationToken);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x0006DE38 File Offset: 0x0006C038
		private void SetShaper(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> coordinatorFactory, int depth)
		{
			this._shaper = shaper;
			this._coordinatorFactory = coordinatorFactory;
			this._dataRecord = new global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord(shaper, depth);
			if (!this._shaper.DataWaiting)
			{
				this._shaper.DataWaiting = this._shaper.RootEnumerator.MoveNext();
			}
			this.InitializeHasRows();
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x0006DE90 File Offset: 0x0006C090
		private async global::System.Threading.Tasks.Task SetShaperAsync(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> coordinatorFactory, int depth, global::System.Threading.CancellationToken cancellationToken)
		{
			this._shaper = shaper;
			this._coordinatorFactory = coordinatorFactory;
			this._dataRecord = new global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord(shaper, depth);
			if (!this._shaper.DataWaiting)
			{
				global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper2 = this._shaper;
				bool dataWaiting = await this._shaper.RootEnumerator.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>();
				shaper2.DataWaiting = dataWaiting;
				shaper2 = null;
			}
			this.InitializeHasRows();
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x0006DEF8 File Offset: 0x0006C0F8
		private void InitializeHasRows()
		{
			this._hasRows = false;
			if (this._shaper.DataWaiting)
			{
				global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState recordState = this._shaper.RootEnumerator.Current;
				if (recordState != null)
				{
					this._hasRows = (recordState.CoordinatorFactory == this._coordinatorFactory);
				}
			}
			this._defaultRecordState = this._coordinatorFactory.GetDefaultRecordState(this._shaper);
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0006DF58 File Offset: 0x0006C158
		private void AssertReaderIsOpen(string methodName)
		{
			if (this.IsClosed)
			{
				if (this._dataRecord.IsImplicitlyClosed)
				{
					throw global::System.Data.Entity.Resources.Error.ADP_ImplicitlyClosedDataReaderError();
				}
				if (this._dataRecord.IsExplicitlyClosed)
				{
					throw global::System.Data.Entity.Resources.Error.ADP_DataReaderClosed(methodName);
				}
			}
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x0006DF89 File Offset: 0x0006C189
		internal void CloseImplicitly()
		{
			this.EnsureInitialized();
			this.Consume();
			this._dataRecord.CloseImplicitly();
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x0006DFA4 File Offset: 0x0006C1A4
		internal async global::System.Threading.Tasks.Task CloseImplicitlyAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			await this.EnsureInitializedAsync(cancellationToken).WithCurrentCulture();
			await this.ConsumeAsync(cancellationToken).WithCurrentCulture();
			await this._dataRecord.CloseImplicitlyAsync(cancellationToken).WithCurrentCulture();
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x0006DFF1 File Offset: 0x0006C1F1
		private void Consume()
		{
			while (this.ReadInternal())
			{
			}
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0006DFFC File Offset: 0x0006C1FC
		private async global::System.Threading.Tasks.Task ConsumeAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter;
			do
			{
				cultureAwaiter = this.ReadInternalAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
			}
			while (cultureAwaiter.GetResult());
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x0006E04C File Offset: 0x0006C24C
		internal static global::System.Type GetClrTypeFromTypeMetadata(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			global::System.Type result;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(typeUsage, out primitiveType))
			{
				result = primitiveType.ClrEquivalentType;
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(typeUsage))
			{
				result = typeof(global::System.Data.Entity.Core.EntityKey);
			}
			else if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(typeUsage))
			{
				result = typeof(global::System.Data.Common.DbDataRecord);
			}
			else if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(typeUsage))
			{
				result = typeof(global::System.Data.Common.DbDataReader);
			}
			else if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsEnumerationType(typeUsage))
			{
				result = ((global::System.Data.Entity.Core.Metadata.Edm.EnumType)typeUsage.EdmType).UnderlyingType.ClrEquivalentType;
			}
			else
			{
				result = typeof(object);
			}
			return result;
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x0006E0D7 File Offset: 0x0006C2D7
		public override int Depth
		{
			get
			{
				this.EnsureInitialized();
				this.AssertReaderIsOpen("Depth");
				return this._dataRecord.Depth;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x0006E0F5 File Offset: 0x0006C2F5
		public override bool HasRows
		{
			get
			{
				this.EnsureInitialized();
				this.AssertReaderIsOpen("HasRows");
				return this._hasRows;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x0006E10E File Offset: 0x0006C30E
		public override bool IsClosed
		{
			get
			{
				this.EnsureInitialized();
				return this._isClosed || this._dataRecord.IsClosed;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x0006E12C File Offset: 0x0006C32C
		public override int RecordsAffected
		{
			get
			{
				this.EnsureInitialized();
				int result = -1;
				if (this._dataRecord.Depth == 0)
				{
					result = this._shaper.Reader.RecordsAffected;
				}
				return result;
			}
		}

		// Token: 0x0600267F RID: 9855 RVA: 0x0006E160 File Offset: 0x0006C360
		public override void Close()
		{
			this.EnsureInitialized();
			this._dataRecord.CloseExplicitly();
			if (!this._isClosed)
			{
				this._isClosed = true;
				if (this._dataRecord.Depth == 0)
				{
					this._shaper.Reader.Close();
				}
				else
				{
					this.Consume();
				}
			}
			if (this._nextResultShaperInfoEnumerator != null)
			{
				this._nextResultShaperInfoEnumerator.Dispose();
				this._nextResultShaperInfoEnumerator = null;
			}
		}

		// Token: 0x06002680 RID: 9856 RVA: 0x0006E1CC File Offset: 0x0006C3CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::System.Data.Common.DbEnumerator(this, true);
		}

		// Token: 0x06002681 RID: 9857 RVA: 0x0006E1D5 File Offset: 0x0006C3D5
		public override global::System.Data.DataTable GetSchemaTable()
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ADP_GetSchemaTableIsNotSupported);
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x0006E1E4 File Offset: 0x0006C3E4
		public override bool NextResult()
		{
			this.EnsureInitialized();
			this.AssertReaderIsOpen("NextResult");
			if (this._nextResultShaperInfoEnumerator != null && this._shaper.Reader.NextResult() && this._nextResultShaperInfoEnumerator.MoveNext())
			{
				global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>> keyValuePair = this._nextResultShaperInfoEnumerator.Current;
				this._dataRecord.CloseImplicitly();
				this.SetShaper(keyValuePair.Key, keyValuePair.Value, 0);
				return true;
			}
			if (this._dataRecord.Depth == 0)
			{
				global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReader(this._shaper.Reader);
			}
			else
			{
				this.Consume();
			}
			this.CloseImplicitly();
			this._dataRecord.SetRecordSource(null, false);
			return false;
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x0006E290 File Offset: 0x0006C490
		public override async global::System.Threading.Tasks.Task<bool> NextResultAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			await this.EnsureInitializedAsync(cancellationToken).WithCurrentCulture();
			this.AssertReaderIsOpen("NextResult");
			bool flag = this._nextResultShaperInfoEnumerator != null;
			if (flag)
			{
				flag = await this._shaper.Reader.NextResultAsync(cancellationToken).WithCurrentCulture<bool>();
			}
			bool result;
			if (flag && this._nextResultShaperInfoEnumerator.MoveNext())
			{
				global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>> nextResultShaperInfo = this._nextResultShaperInfoEnumerator.Current;
				await this._dataRecord.CloseImplicitlyAsync(cancellationToken).WithCurrentCulture();
				this.SetShaper(nextResultShaperInfo.Key, nextResultShaperInfo.Value, 0);
				result = true;
			}
			else
			{
				if (this._dataRecord.Depth == 0)
				{
					await global::System.Data.Entity.Core.Common.Utils.CommandHelper.ConsumeReaderAsync(this._shaper.Reader, cancellationToken).WithCurrentCulture();
				}
				else
				{
					await this.ConsumeAsync(cancellationToken).WithCurrentCulture();
				}
				await this.CloseImplicitlyAsync(cancellationToken).WithCurrentCulture();
				this._dataRecord.SetRecordSource(null, false);
				result = false;
			}
			return result;
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x0006E2E0 File Offset: 0x0006C4E0
		public override bool Read()
		{
			this.EnsureInitialized();
			this.AssertReaderIsOpen("Read");
			this._dataRecord.CloseImplicitly();
			bool flag = this.ReadInternal();
			this._dataRecord.SetRecordSource(this._shaper.RootEnumerator.Current, flag);
			return flag;
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x0006E330 File Offset: 0x0006C530
		public override async global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			await this.EnsureInitializedAsync(cancellationToken).WithCurrentCulture();
			this.AssertReaderIsOpen("Read");
			await this._dataRecord.CloseImplicitlyAsync(cancellationToken).WithCurrentCulture();
			bool flag = await this.ReadInternalAsync(cancellationToken).WithCurrentCulture<bool>();
			this._dataRecord.SetRecordSource(this._shaper.RootEnumerator.Current, flag);
			return flag;
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x0006E380 File Offset: 0x0006C580
		private bool ReadInternal()
		{
			bool result = false;
			if (!this._shaper.DataWaiting)
			{
				this._shaper.DataWaiting = this._shaper.RootEnumerator.MoveNext();
			}
			while (this._shaper.DataWaiting && this._shaper.RootEnumerator.Current.CoordinatorFactory != this._coordinatorFactory && this._shaper.RootEnumerator.Current.CoordinatorFactory.Depth > this._coordinatorFactory.Depth)
			{
				this._shaper.DataWaiting = this._shaper.RootEnumerator.MoveNext();
			}
			if (this._shaper.DataWaiting && this._shaper.RootEnumerator.Current.CoordinatorFactory == this._coordinatorFactory)
			{
				this._shaper.DataWaiting = false;
				this._shaper.RootEnumerator.Current.AcceptPendingValues();
				result = true;
			}
			return result;
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x0006E474 File Offset: 0x0006C674
		private async global::System.Threading.Tasks.Task<bool> ReadInternalAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			bool result = false;
			if (!this._shaper.DataWaiting)
			{
				global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper = this._shaper;
				bool dataWaiting = await this._shaper.RootEnumerator.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>();
				shaper.DataWaiting = dataWaiting;
				shaper = null;
			}
			while (this._shaper.DataWaiting && this._shaper.RootEnumerator.Current.CoordinatorFactory != this._coordinatorFactory && this._shaper.RootEnumerator.Current.CoordinatorFactory.Depth > this._coordinatorFactory.Depth)
			{
				global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper = this._shaper;
				bool dataWaiting = await this._shaper.RootEnumerator.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>();
				shaper.DataWaiting = dataWaiting;
				shaper = null;
			}
			if (this._shaper.DataWaiting && this._shaper.RootEnumerator.Current.CoordinatorFactory == this._coordinatorFactory)
			{
				this._shaper.DataWaiting = false;
				this._shaper.RootEnumerator.Current.AcceptPendingValues();
				result = true;
			}
			return result;
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0006E4C1 File Offset: 0x0006C6C1
		public override int FieldCount
		{
			get
			{
				this.EnsureInitialized();
				this.AssertReaderIsOpen("FieldCount");
				return this._defaultRecordState.ColumnCount;
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x0006E4E0 File Offset: 0x0006C6E0
		public override string GetDataTypeName(int ordinal)
		{
			this.EnsureInitialized();
			this.AssertReaderIsOpen("GetDataTypeName");
			string result;
			if (this._dataRecord.HasData)
			{
				result = this._dataRecord.GetDataTypeName(ordinal);
			}
			else
			{
				result = this._defaultRecordState.GetTypeUsage(ordinal).ToString();
			}
			return result;
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x0006E530 File Offset: 0x0006C730
		public override global::System.Type GetFieldType(int ordinal)
		{
			this.EnsureInitialized();
			this.AssertReaderIsOpen("GetFieldType");
			global::System.Type result;
			if (this._dataRecord.HasData)
			{
				result = this._dataRecord.GetFieldType(ordinal);
			}
			else
			{
				result = global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader.GetClrTypeFromTypeMetadata(this._defaultRecordState.GetTypeUsage(ordinal));
			}
			return result;
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x0006E580 File Offset: 0x0006C780
		public override string GetName(int ordinal)
		{
			this.EnsureInitialized();
			this.AssertReaderIsOpen("GetName");
			string name;
			if (this._dataRecord.HasData)
			{
				name = this._dataRecord.GetName(ordinal);
			}
			else
			{
				name = this._defaultRecordState.GetName(ordinal);
			}
			return name;
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x0006E5C8 File Offset: 0x0006C7C8
		public override int GetOrdinal(string name)
		{
			this.EnsureInitialized();
			this.AssertReaderIsOpen("GetOrdinal");
			int ordinal;
			if (this._dataRecord.HasData)
			{
				ordinal = this._dataRecord.GetOrdinal(name);
			}
			else
			{
				ordinal = this._defaultRecordState.GetOrdinal(name);
			}
			return ordinal;
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x0006E610 File Offset: 0x0006C810
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::System.Type GetProviderSpecificFieldType(int ordinal)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000829 RID: 2089
		public override object this[int ordinal]
		{
			get
			{
				this.EnsureInitialized();
				return this._dataRecord[ordinal];
			}
		}

		// Token: 0x1700082A RID: 2090
		public override object this[string name]
		{
			get
			{
				this.EnsureInitialized();
				int ordinal = this.GetOrdinal(name);
				return this._dataRecord[ordinal];
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x0006E653 File Offset: 0x0006C853
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override object GetProviderSpecificValue(int ordinal)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0006E65A File Offset: 0x0006C85A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetProviderSpecificValues(object[] values)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0006E661 File Offset: 0x0006C861
		public override object GetValue(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetValue(ordinal);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x0006E678 File Offset: 0x0006C878
		public override async global::System.Threading.Tasks.Task<T> GetFieldValueAsync<T>(int ordinal, global::System.Threading.CancellationToken cancellationToken)
		{
			await this.EnsureInitializedAsync(cancellationToken).WithCurrentCulture();
			return await base.GetFieldValueAsync<T>(ordinal, cancellationToken).WithCurrentCulture<T>();
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x0006E6CD File Offset: 0x0006C8CD
		public override int GetValues(object[] values)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetValues(values);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x0006E6E1 File Offset: 0x0006C8E1
		public override bool GetBoolean(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetBoolean(ordinal);
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x0006E6F5 File Offset: 0x0006C8F5
		public override byte GetByte(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetByte(ordinal);
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x0006E709 File Offset: 0x0006C909
		public override char GetChar(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetChar(ordinal);
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x0006E71D File Offset: 0x0006C91D
		public override global::System.DateTime GetDateTime(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetDateTime(ordinal);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x0006E731 File Offset: 0x0006C931
		public override decimal GetDecimal(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetDecimal(ordinal);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x0006E745 File Offset: 0x0006C945
		public override double GetDouble(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetDouble(ordinal);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x0006E759 File Offset: 0x0006C959
		public override float GetFloat(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetFloat(ordinal);
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x0006E76D File Offset: 0x0006C96D
		public override global::System.Guid GetGuid(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetGuid(ordinal);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x0006E781 File Offset: 0x0006C981
		public override short GetInt16(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetInt16(ordinal);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x0006E795 File Offset: 0x0006C995
		public override int GetInt32(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetInt32(ordinal);
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x0006E7A9 File Offset: 0x0006C9A9
		public override long GetInt64(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetInt64(ordinal);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x0006E7BD File Offset: 0x0006C9BD
		public override string GetString(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetString(ordinal);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x0006E7D1 File Offset: 0x0006C9D1
		public override bool IsDBNull(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.IsDBNull(ordinal);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x0006E7E5 File Offset: 0x0006C9E5
		public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetBytes(ordinal, dataOffset, buffer, bufferOffset, length);
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x0006E7FF File Offset: 0x0006C9FF
		public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetChars(ordinal, dataOffset, buffer, bufferOffset, length);
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x0006E819 File Offset: 0x0006CA19
		protected override global::System.Data.Common.DbDataReader GetDbDataReader(int ordinal)
		{
			this.EnsureInitialized();
			return (global::System.Data.Common.DbDataReader)this._dataRecord.GetData(ordinal);
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x0006E834 File Offset: 0x0006CA34
		public global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo
		{
			get
			{
				this.EnsureInitialized();
				this.AssertReaderIsOpen("DataRecordInfo");
				global::System.Data.Entity.Core.Common.DataRecordInfo dataRecordInfo;
				if (this._dataRecord.HasData)
				{
					dataRecordInfo = this._dataRecord.DataRecordInfo;
				}
				else
				{
					dataRecordInfo = this._defaultRecordState.DataRecordInfo;
				}
				return dataRecordInfo;
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x0006E87A File Offset: 0x0006CA7A
		public global::System.Data.Common.DbDataRecord GetDataRecord(int ordinal)
		{
			this.EnsureInitialized();
			return this._dataRecord.GetDataRecord(ordinal);
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x0006E88E File Offset: 0x0006CA8E
		public global::System.Data.Common.DbDataReader GetDataReader(int ordinal)
		{
			this.EnsureInitialized();
			return this.GetDbDataReader(ordinal);
		}

		// Token: 0x04000D70 RID: 3440
		private global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> _shaper;

		// Token: 0x04000D71 RID: 3441
		private global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>>> _nextResultShaperInfoEnumerator;

		// Token: 0x04000D72 RID: 3442
		private global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> _coordinatorFactory;

		// Token: 0x04000D73 RID: 3443
		private global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState _defaultRecordState;

		// Token: 0x04000D74 RID: 3444
		private global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataRecord _dataRecord;

		// Token: 0x04000D75 RID: 3445
		private bool _hasRows;

		// Token: 0x04000D76 RID: 3446
		private bool _isClosed;

		// Token: 0x04000D77 RID: 3447
		private int _initialized;

		// Token: 0x04000D78 RID: 3448
		private readonly global::System.Action _initialize;

		// Token: 0x04000D79 RID: 3449
		private readonly global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task> _initializeAsync;
	}
}
