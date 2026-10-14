using System;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x02000590 RID: 1424
	internal class TileNamed<T_Query> : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> where T_Query : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.ITileQuery
	{
		// Token: 0x06004503 RID: 17667 RVA: 0x000F34D4 File Offset: 0x000F16D4
		public TileNamed(T_Query namedQuery) : base(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Named, namedQuery)
		{
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06004504 RID: 17668 RVA: 0x000F34DE File Offset: 0x000F16DE
		public T_Query NamedQuery
		{
			get
			{
				return base.Query;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06004505 RID: 17669 RVA: 0x000F34E6 File Offset: 0x000F16E6
		public override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Arg1
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06004506 RID: 17670 RVA: 0x000F34E9 File Offset: 0x000F16E9
		public override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Arg2
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x000F34EC File Offset: 0x000F16EC
		public override string Description
		{
			get
			{
				T_Query query = base.Query;
				return query.Description;
			}
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x000F3510 File Offset: 0x000F1710
		public override string ToString()
		{
			T_Query query = base.Query;
			return query.ToString();
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x000F3531 File Offset: 0x000F1731
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Replace(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> oldTile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> newTile)
		{
			if (this != oldTile)
			{
				return this;
			}
			return newTile;
		}
	}
}
