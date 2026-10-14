using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200045B RID: 1115
	internal sealed class SpanIndex
	{
		// Token: 0x060036E2 RID: 14050 RVA: 0x000B04A0 File Offset: 0x000AE6A0
		internal void AddSpannedRowType(global::System.Data.Entity.Core.Metadata.Edm.RowType spannedRowType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage originalRowType)
		{
			if (this._rowMap == null)
			{
				this._rowMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.RowType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(global::System.Data.Entity.Core.Objects.Internal.SpanIndex.RowTypeEqualityComparer.Instance);
			}
			this._rowMap[spannedRowType] = originalRowType;
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x000B04C8 File Offset: 0x000AE6C8
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetSpannedRowType(global::System.Data.Entity.Core.Metadata.Edm.RowType spannedRowType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
			if (this._rowMap != null && this._rowMap.TryGetValue(spannedRowType, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x000B04F0 File Offset: 0x000AE6F0
		internal bool HasSpanMap(global::System.Data.Entity.Core.Metadata.Edm.RowType spanRowType)
		{
			return this._spanMap != null && this._spanMap.ContainsKey(spanRowType);
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x000B0508 File Offset: 0x000AE708
		internal void AddSpanMap(global::System.Data.Entity.Core.Metadata.Edm.RowType rowType, global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> columnMap)
		{
			if (this._spanMap == null)
			{
				this._spanMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.RowType, global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>>(global::System.Data.Entity.Core.Objects.Internal.SpanIndex.RowTypeEqualityComparer.Instance);
			}
			this._spanMap[rowType] = columnMap;
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x000B0530 File Offset: 0x000AE730
		internal global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> GetSpanMap(global::System.Data.Entity.Core.Metadata.Edm.RowType rowType)
		{
			global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember> result = null;
			if (this._spanMap != null && this._spanMap.TryGetValue(rowType, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x040011CB RID: 4555
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.RowType, global::System.Collections.Generic.Dictionary<int, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember>> _spanMap;

		// Token: 0x040011CC RID: 4556
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.RowType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> _rowMap;

		// Token: 0x02000A6E RID: 2670
		private sealed class RowTypeEqualityComparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Metadata.Edm.RowType>
		{
			// Token: 0x060061FB RID: 25083 RVA: 0x0015302E File Offset: 0x0015122E
			private RowTypeEqualityComparer()
			{
			}

			// Token: 0x060061FC RID: 25084 RVA: 0x00153036 File Offset: 0x00151236
			public bool Equals(global::System.Data.Entity.Core.Metadata.Edm.RowType x, global::System.Data.Entity.Core.Metadata.Edm.RowType y)
			{
				return x != null && y != null && x.EdmEquals(y);
			}

			// Token: 0x060061FD RID: 25085 RVA: 0x00153047 File Offset: 0x00151247
			public int GetHashCode(global::System.Data.Entity.Core.Metadata.Edm.RowType obj)
			{
				return obj.Identity.GetHashCode();
			}

			// Token: 0x04002B22 RID: 11042
			internal static readonly global::System.Data.Entity.Core.Objects.Internal.SpanIndex.RowTypeEqualityComparer Instance = new global::System.Data.Entity.Core.Objects.Internal.SpanIndex.RowTypeEqualityComparer();
		}
	}
}
