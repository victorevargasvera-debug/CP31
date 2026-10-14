using System;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000641 RID: 1601
	internal class ShaperFactory<T> : global::System.Data.Entity.Core.Common.Internal.Materialization.ShaperFactory
	{
		// Token: 0x06004D2E RID: 19758 RVA: 0x0010FB38 File Offset: 0x0010DD38
		internal ShaperFactory(int stateCount, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<T> rootCoordinatorFactory, global::System.Type[] columnTypes, bool[] nullableColumns, global::System.Data.Entity.Core.Objects.MergeOption mergeOption)
		{
			this._stateCount = stateCount;
			this._rootCoordinatorFactory = rootCoordinatorFactory;
			this.ColumnTypes = columnTypes;
			this.NullableColumns = nullableColumns;
			this._mergeOption = mergeOption;
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06004D2F RID: 19759 RVA: 0x0010FB65 File Offset: 0x0010DD65
		// (set) Token: 0x06004D30 RID: 19760 RVA: 0x0010FB6D File Offset: 0x0010DD6D
		public global::System.Type[] ColumnTypes { get; private set; }

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06004D31 RID: 19761 RVA: 0x0010FB76 File Offset: 0x0010DD76
		// (set) Token: 0x06004D32 RID: 19762 RVA: 0x0010FB7E File Offset: 0x0010DD7E
		public bool[] NullableColumns { get; private set; }

		// Token: 0x06004D33 RID: 19763 RVA: 0x0010FB87 File Offset: 0x0010DD87
		internal global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> Create(global::System.Data.Common.DbDataReader reader, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, bool readerOwned, bool streaming)
		{
			return new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>(reader, context, workspace, mergeOption, this._stateCount, this._rootCoordinatorFactory, readerOwned, streaming);
		}

		// Token: 0x04001B64 RID: 7012
		private readonly int _stateCount;

		// Token: 0x04001B65 RID: 7013
		private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<T> _rootCoordinatorFactory;

		// Token: 0x04001B66 RID: 7014
		private readonly global::System.Data.Entity.Core.Objects.MergeOption _mergeOption;
	}
}
