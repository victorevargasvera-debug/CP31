using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200053B RID: 1339
	internal sealed class FunctionImportNormalizedEntityTypeMapping
	{
		// Token: 0x060041FC RID: 16892 RVA: 0x000DE99C File Offset: 0x000DCB9C
		internal FunctionImportNormalizedEntityTypeMapping(global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMappingKB parent, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> columnConditions, global::System.Collections.BitArray impliedEntityTypes)
		{
			this.ColumnConditions = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition>(columnConditions.ToList<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition>());
			this.ImpliedEntityTypes = impliedEntityTypes;
			this.ComplementImpliedEntityTypes = new global::System.Collections.BitArray(this.ImpliedEntityTypes).Not();
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x000DE9D2 File Offset: 0x000DCBD2
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Values={0}, Types={1}", new object[]
			{
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(this.ColumnConditions),
				global::System.Data.Entity.Core.Common.Utils.StringUtil.ToCommaSeparatedString(this.ImpliedEntityTypes)
			});
		}

		// Token: 0x040016DE RID: 5854
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> ColumnConditions;

		// Token: 0x040016DF RID: 5855
		internal readonly global::System.Collections.BitArray ImpliedEntityTypes;

		// Token: 0x040016E0 RID: 5856
		internal readonly global::System.Collections.BitArray ComplementImpliedEntityTypes;
	}
}
