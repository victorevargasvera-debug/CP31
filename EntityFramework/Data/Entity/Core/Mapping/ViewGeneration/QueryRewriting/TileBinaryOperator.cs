using System;
using System.Globalization;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x0200058F RID: 1423
	internal class TileBinaryOperator<T_Query> : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> where T_Query : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.ITileQuery
	{
		// Token: 0x060044FE RID: 17662 RVA: 0x000F33E9 File Offset: 0x000F15E9
		public TileBinaryOperator(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg1, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> arg2, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind opKind, T_Query query) : base(opKind, query)
		{
			this.m_arg1 = arg1;
			this.m_arg2 = arg2;
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x060044FF RID: 17663 RVA: 0x000F3402 File Offset: 0x000F1602
		public override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Arg1
		{
			get
			{
				return this.m_arg1;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06004500 RID: 17664 RVA: 0x000F340A File Offset: 0x000F160A
		public override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Arg2
		{
			get
			{
				return this.m_arg2;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06004501 RID: 17665 RVA: 0x000F3414 File Offset: 0x000F1614
		public override string Description
		{
			get
			{
				string format = null;
				switch (base.OpKind)
				{
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Union:
					format = "({0} | {1})";
					break;
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join:
					format = "({0} & {1})";
					break;
				case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.AntiSemiJoin:
					format = "({0} - {1})";
					break;
				}
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, format, new object[]
				{
					this.Arg1.Description,
					this.Arg2.Description
				});
			}
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x000F3484 File Offset: 0x000F1684
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Replace(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> oldTile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> newTile)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> tile = this.Arg1.Replace(oldTile, newTile);
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> tile2 = this.Arg2.Replace(oldTile, newTile);
			if (tile != this.Arg1 || tile2 != this.Arg2)
			{
				return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileBinaryOperator<T_Query>(tile, tile2, base.OpKind, base.Query);
			}
			return this;
		}

		// Token: 0x040018D3 RID: 6355
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> m_arg1;

		// Token: 0x040018D4 RID: 6356
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> m_arg2;
	}
}
