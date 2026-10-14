using System;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x02000584 RID: 1412
	internal class DefaultTileProcessor<T_Query> : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileProcessor<global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query>> where T_Query : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.ITileQuery
	{
		// Token: 0x0600445B RID: 17499 RVA: 0x000EF780 File Offset: 0x000ED980
		internal DefaultTileProcessor(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileQueryProcessor<T_Query> tileQueryProcessor)
		{
			this._tileQueryProcessor = tileQueryProcessor;
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600445C RID: 17500 RVA: 0x000EF78F File Offset: 0x000ED98F
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileQueryProcessor<T_Query> QueryProcessor
		{
			get
			{
				return this._tileQueryProcessor;
			}
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x000EF797 File Offset: 0x000ED997
		internal override bool IsEmpty(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> tile)
		{
			return !this._tileQueryProcessor.IsSatisfiable(tile.Query);
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x000EF7AD File Offset: 0x000ED9AD
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Union(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg2)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileBinaryOperator<T_Query>(arg1, arg2, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Union, this._tileQueryProcessor.Union(arg1.Query, arg2.Query));
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x000EF7CE File Offset: 0x000ED9CE
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Join(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg2)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileBinaryOperator<T_Query>(arg1, arg2, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join, this._tileQueryProcessor.Intersect(arg1.Query, arg2.Query));
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x000EF7EF File Offset: 0x000ED9EF
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> AntiSemiJoin(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg2)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileBinaryOperator<T_Query>(arg1, arg2, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.AntiSemiJoin, this._tileQueryProcessor.Difference(arg1.Query, arg2.Query));
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x000EF810 File Offset: 0x000EDA10
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> GetArg1(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> tile)
		{
			return tile.Arg1;
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x000EF818 File Offset: 0x000EDA18
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> GetArg2(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> tile)
		{
			return tile.Arg2;
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x000EF820 File Offset: 0x000EDA20
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind GetOpKind(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> tile)
		{
			return tile.OpKind;
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x000EF828 File Offset: 0x000EDA28
		internal bool IsContainedIn(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg2)
		{
			return this.IsEmpty(this.AntiSemiJoin(arg1, arg2));
		}

		// Token: 0x06004465 RID: 17509 RVA: 0x000EF838 File Offset: 0x000EDA38
		internal bool IsEquivalentTo(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg2)
		{
			return this.IsContainedIn(arg1, arg2) && this.IsContainedIn(arg2, arg1);
		}

		// Token: 0x0400189F RID: 6303
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileQueryProcessor<T_Query> _tileQueryProcessor;
	}
}
