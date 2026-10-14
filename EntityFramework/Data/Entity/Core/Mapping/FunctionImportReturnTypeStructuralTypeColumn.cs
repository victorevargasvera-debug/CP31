using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000540 RID: 1344
	internal sealed class FunctionImportReturnTypeStructuralTypeColumn
	{
		// Token: 0x0600420F RID: 16911 RVA: 0x000DEC4D File Offset: 0x000DCE4D
		internal FunctionImportReturnTypeStructuralTypeColumn(string columnName, global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, bool isTypeOf, global::System.Data.Entity.Core.Mapping.LineInfo lineInfo)
		{
			this.ColumnName = columnName;
			this.IsTypeOf = isTypeOf;
			this.Type = type;
			this.LineInfo = lineInfo;
		}

		// Token: 0x040016E6 RID: 5862
		internal readonly global::System.Data.Entity.Core.Metadata.Edm.StructuralType Type;

		// Token: 0x040016E7 RID: 5863
		internal readonly bool IsTypeOf;

		// Token: 0x040016E8 RID: 5864
		internal readonly string ColumnName;

		// Token: 0x040016E9 RID: 5865
		internal readonly global::System.Data.Entity.Core.Mapping.LineInfo LineInfo;
	}
}
