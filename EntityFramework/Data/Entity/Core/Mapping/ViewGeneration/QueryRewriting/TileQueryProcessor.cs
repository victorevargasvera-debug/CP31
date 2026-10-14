using System;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x02000593 RID: 1427
	internal abstract class TileQueryProcessor<T_Query> where T_Query : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.ITileQuery
	{
		// Token: 0x06004512 RID: 17682
		internal abstract T_Query Intersect(T_Query arg1, T_Query arg2);

		// Token: 0x06004513 RID: 17683
		internal abstract T_Query Difference(T_Query arg1, T_Query arg2);

		// Token: 0x06004514 RID: 17684
		internal abstract T_Query Union(T_Query arg1, T_Query arg2);

		// Token: 0x06004515 RID: 17685
		internal abstract bool IsSatisfiable(T_Query query);

		// Token: 0x06004516 RID: 17686
		internal abstract T_Query CreateDerivedViewBySelectingConstantAttributes(T_Query query);
	}
}
