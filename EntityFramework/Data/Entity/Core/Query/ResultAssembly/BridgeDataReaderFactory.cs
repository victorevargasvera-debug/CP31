using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.Internal.Materialization;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Linq;

namespace System.Data.Entity.Core.Query.ResultAssembly
{
	// Token: 0x02000329 RID: 809
	internal class BridgeDataReaderFactory
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x0006E8A7 File Offset: 0x0006CAA7
		public BridgeDataReaderFactory(global::System.Data.Entity.Core.Common.Internal.Materialization.Translator translator = null)
		{
			this._translator = (translator ?? new global::System.Data.Entity.Core.Common.Internal.Materialization.Translator());
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x0006E8C0 File Offset: 0x0006CAC0
		public virtual global::System.Data.Common.DbDataReader Create(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> nextResultColumnMaps)
		{
			global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>> keyValuePair = this.CreateShaperInfo(storeDataReader, columnMap, workspace);
			return new global::System.Data.Entity.Core.Query.ResultAssembly.BridgeDataReader(keyValuePair.Key, keyValuePair.Value, 0, this.GetNextResultShaperInfo(storeDataReader, workspace, nextResultColumnMaps).GetEnumerator());
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x0006E8FA File Offset: 0x0006CAFA
		private global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>> CreateShaperInfo(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState> shaper = this._translator.TranslateColumnMap<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>(columnMap, workspace, null, global::System.Data.Entity.Core.Objects.MergeOption.NoTracking, true, true).Create(storeDataReader, null, workspace, global::System.Data.Entity.Core.Objects.MergeOption.NoTracking, true, true);
			return new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>>(shaper, shaper.RootCoordinator.TypedCoordinatorFactory);
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x0006E928 File Offset: 0x0006CB28
		private global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>>> GetNextResultShaperInfo(global::System.Data.Common.DbDataReader storeDataReader, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap> nextResultColumnMaps)
		{
			return from nextResultColumnMap in nextResultColumnMaps
			select this.CreateShaperInfo(storeDataReader, nextResultColumnMap, workspace);
		}

		// Token: 0x04000D7A RID: 3450
		private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Translator _translator;
	}
}
