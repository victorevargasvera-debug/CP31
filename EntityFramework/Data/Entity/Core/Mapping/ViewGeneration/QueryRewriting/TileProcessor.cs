using System;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x02000592 RID: 1426
	internal abstract class TileProcessor<T_Tile>
	{
		// Token: 0x0600450A RID: 17674
		internal abstract bool IsEmpty(T_Tile tile);

		// Token: 0x0600450B RID: 17675
		internal abstract T_Tile Union(T_Tile a, T_Tile b);

		// Token: 0x0600450C RID: 17676
		internal abstract T_Tile Join(T_Tile a, T_Tile b);

		// Token: 0x0600450D RID: 17677
		internal abstract T_Tile AntiSemiJoin(T_Tile a, T_Tile b);

		// Token: 0x0600450E RID: 17678
		internal abstract T_Tile GetArg1(T_Tile tile);

		// Token: 0x0600450F RID: 17679
		internal abstract T_Tile GetArg2(T_Tile tile);

		// Token: 0x06004510 RID: 17680
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind GetOpKind(T_Tile tile);
	}
}
