using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200036B RID: 875
	internal class StructuredTypeNullabilityAnalyzer : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapVisitor<global::System.Collections.Generic.HashSet<string>>
	{
		// Token: 0x06002A7E RID: 10878 RVA: 0x0008A879 File Offset: 0x00088A79
		internal override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap columnMap, global::System.Collections.Generic.HashSet<string> typesNeedingNullSentinel)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeNullabilityAnalyzer.AddTypeNeedingNullSentinel(typesNeedingNullSentinel, columnMap.Type);
			base.Visit(columnMap, typesNeedingNullSentinel);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x0008A890 File Offset: 0x00088A90
		private static void AddTypeNeedingNullSentinel(global::System.Collections.Generic.HashSet<string> typesNeedingNullSentinel, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(typeUsage))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeNullabilityAnalyzer.AddTypeNeedingNullSentinel(typesNeedingNullSentinel, global::System.Data.Entity.Core.Common.TypeHelpers.GetElementTypeUsage(typeUsage));
				return;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(typeUsage) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(typeUsage))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeNullabilityAnalyzer.MarkAsNeedingNullSentinel(typesNeedingNullSentinel, typeUsage);
			}
			foreach (object obj in global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(typeUsage))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeNullabilityAnalyzer.AddTypeNeedingNullSentinel(typesNeedingNullSentinel, edmMember.TypeUsage);
			}
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x0008A91C File Offset: 0x00088B1C
		internal static void MarkAsNeedingNullSentinel(global::System.Collections.Generic.HashSet<string> typesNeedingNullSentinel, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage)
		{
			typesNeedingNullSentinel.Add(typeUsage.EdmType.Identity);
		}

		// Token: 0x04000EA5 RID: 3749
		internal static global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeNullabilityAnalyzer Instance = new global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeNullabilityAnalyzer();
	}
}
