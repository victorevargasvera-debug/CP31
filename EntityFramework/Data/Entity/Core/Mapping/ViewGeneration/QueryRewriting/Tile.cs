using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x0200058E RID: 1422
	internal abstract class Tile<T_Query> where T_Query : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.ITileQuery
	{
		// Token: 0x060044F4 RID: 17652 RVA: 0x000F3343 File Offset: 0x000F1543
		protected Tile(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind opKind, T_Query query)
		{
			this.m_opKind = opKind;
			this.m_query = query;
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x000F3359 File Offset: 0x000F1559
		public T_Query Query
		{
			get
			{
				return this.m_query;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x060044F6 RID: 17654
		public abstract string Description { get; }

		// Token: 0x060044F7 RID: 17655 RVA: 0x000F3361 File Offset: 0x000F1561
		public global::System.Collections.Generic.IEnumerable<T_Query> GetNamedQueries()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query>.GetNamedQueries(this);
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x000F3369 File Offset: 0x000F1569
		private static global::System.Collections.Generic.IEnumerable<T_Query> GetNamedQueries(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> rewriting)
		{
			if (rewriting != null)
			{
				if (rewriting.OpKind == global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Named)
				{
					yield return ((global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileNamed<T_Query>)rewriting).NamedQuery;
				}
				else
				{
					foreach (T_Query t_Query in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query>.GetNamedQueries(rewriting.Arg1))
					{
						yield return t_Query;
					}
					global::System.Collections.Generic.IEnumerator<T_Query> enumerator = null;
					foreach (T_Query t_Query2 in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query>.GetNamedQueries(rewriting.Arg2))
					{
						yield return t_Query2;
					}
					enumerator = null;
				}
			}
			yield break;
			yield break;
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x000F337C File Offset: 0x000F157C
		public override string ToString()
		{
			if (this.Description != null)
			{
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}: [{1}]", new object[]
				{
					this.Description,
					this.Query
				});
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "[{0}]", new object[]
			{
				this.Query
			});
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x060044FA RID: 17658
		public abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Arg1 { get; }

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x060044FB RID: 17659
		public abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Arg2 { get; }

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x000F33E1 File Offset: 0x000F15E1
		public global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind OpKind
		{
			get
			{
				return this.m_opKind;
			}
		}

		// Token: 0x060044FD RID: 17661
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> Replace(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> oldTile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.Tile<T_Query> newTile);

		// Token: 0x040018D1 RID: 6353
		private readonly T_Query m_query;

		// Token: 0x040018D2 RID: 6354
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind m_opKind;
	}
}
