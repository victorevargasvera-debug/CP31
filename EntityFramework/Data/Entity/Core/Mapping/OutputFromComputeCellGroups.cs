using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Data.Entity.Core.Mapping.ViewGeneration.Validation;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200052B RID: 1323
	internal struct OutputFromComputeCellGroups
	{
		// Token: 0x040016A8 RID: 5800
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell> Cells;

		// Token: 0x040016A9 RID: 5801
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers Identifiers;

		// Token: 0x040016AA RID: 5802
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Cell>> CellGroups;

		// Token: 0x040016AB RID: 5803
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Validation.ForeignConstraint> ForeignKeyConstraints;

		// Token: 0x040016AC RID: 5804
		internal bool Success;
	}
}
