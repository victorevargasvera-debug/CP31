using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x0200058D RID: 1421
	internal class RewritingSimplifier<T_Tile> where T_Tile : class
	{
		// Token: 0x060044EB RID: 17643 RVA: 0x000F2FA8 File Offset: 0x000F11A8
		private RewritingSimplifier(T_Tile originalRewriting, T_Tile toAvoid, global::System.Collections.Generic.Dictionary<T_Tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind> usedViews, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> qp)
		{
			this.m_originalRewriting = originalRewriting;
			this.m_toAvoid = toAvoid;
			this.m_qp = qp;
			this.m_usedViews = usedViews;
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x000F2FD8 File Offset: 0x000F11D8
		private RewritingSimplifier(T_Tile rewriting, T_Tile toFill, T_Tile toAvoid, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> qp)
		{
			this.m_originalRewriting = toFill;
			this.m_toAvoid = toAvoid;
			this.m_qp = qp;
			this.m_usedViews = new global::System.Collections.Generic.Dictionary<T_Tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind>();
			this.GatherUnionedSubqueriesInUsedViews(rewriting);
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x000F3014 File Offset: 0x000F1214
		internal static bool TrySimplifyUnionRewriting(ref T_Tile rewriting, T_Tile toFill, T_Tile toAvoid, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> qp)
		{
			T_Tile t_Tile;
			if (new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingSimplifier<T_Tile>(rewriting, toFill, toAvoid, qp).SimplifyRewriting(out t_Tile))
			{
				rewriting = t_Tile;
				return true;
			}
			return false;
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x000F3044 File Offset: 0x000F1244
		internal static bool TrySimplifyJoinRewriting(ref T_Tile rewriting, T_Tile toAvoid, global::System.Collections.Generic.Dictionary<T_Tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind> usedViews, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> qp)
		{
			T_Tile t_Tile;
			if (new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingSimplifier<T_Tile>(rewriting, toAvoid, usedViews, qp).SimplifyRewriting(out t_Tile))
			{
				rewriting = t_Tile;
				return true;
			}
			return false;
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x000F3074 File Offset: 0x000F1274
		private void GatherUnionedSubqueriesInUsedViews(T_Tile query)
		{
			if (query != null)
			{
				if (this.m_qp.GetOpKind(query) != global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Union)
				{
					this.m_usedViews[query] = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Union;
					return;
				}
				this.GatherUnionedSubqueriesInUsedViews(this.m_qp.GetArg1(query));
				this.GatherUnionedSubqueriesInUsedViews(this.m_qp.GetArg2(query));
			}
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x000F30CC File Offset: 0x000F12CC
		private bool SimplifyRewriting(out T_Tile simplifiedRewriting)
		{
			bool result = false;
			simplifiedRewriting = default(T_Tile);
			T_Tile t_Tile;
			while (this.SimplifyRewritingOnce(out t_Tile))
			{
				result = true;
				simplifiedRewriting = t_Tile;
			}
			return result;
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x000F30F8 File Offset: 0x000F12F8
		private bool SimplifyRewritingOnce(out T_Tile simplifiedRewriting)
		{
			global::System.Collections.Generic.HashSet<T_Tile> hashSet = new global::System.Collections.Generic.HashSet<T_Tile>(this.m_usedViews.Keys);
			foreach (T_Tile t_Tile in this.m_usedViews.Keys)
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind tileOpKind = this.m_usedViews[t_Tile];
				if (tileOpKind <= global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join)
				{
					hashSet.Remove(t_Tile);
					if (this.SimplifyRewritingOnce(t_Tile, hashSet, out simplifiedRewriting))
					{
						return true;
					}
					hashSet.Add(t_Tile);
				}
			}
			simplifiedRewriting = default(T_Tile);
			return false;
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x000F3198 File Offset: 0x000F1398
		private bool SimplifyRewritingOnce(T_Tile newRewriting, global::System.Collections.Generic.HashSet<T_Tile> remainingViews, out T_Tile simplifiedRewriting)
		{
			simplifiedRewriting = default(T_Tile);
			if (remainingViews.Count == 0)
			{
				return false;
			}
			if (remainingViews.Count != 1)
			{
				int num = remainingViews.Count / 2;
				int num2 = 0;
				T_Tile t_Tile = newRewriting;
				T_Tile t_Tile2 = newRewriting;
				global::System.Collections.Generic.HashSet<T_Tile> hashSet = new global::System.Collections.Generic.HashSet<T_Tile>();
				global::System.Collections.Generic.HashSet<T_Tile> hashSet2 = new global::System.Collections.Generic.HashSet<T_Tile>();
				foreach (T_Tile t_Tile3 in remainingViews)
				{
					global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind viewKind = this.m_usedViews[t_Tile3];
					if (num2++ < num)
					{
						hashSet.Add(t_Tile3);
						t_Tile = this.GetRewritingHalf(t_Tile, t_Tile3, viewKind);
					}
					else
					{
						hashSet2.Add(t_Tile3);
						t_Tile2 = this.GetRewritingHalf(t_Tile2, t_Tile3, viewKind);
					}
				}
				return this.SimplifyRewritingOnce(t_Tile, hashSet2, out simplifiedRewriting) || this.SimplifyRewritingOnce(t_Tile2, hashSet, out simplifiedRewriting);
			}
			T_Tile key = remainingViews.First<T_Tile>();
			bool flag;
			if (this.m_usedViews[key] == global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Union)
			{
				flag = this.m_qp.IsContainedIn(this.m_originalRewriting, newRewriting);
			}
			else
			{
				flag = (this.m_qp.IsContainedIn(this.m_originalRewriting, newRewriting) && this.m_qp.IsDisjointFrom(this.m_toAvoid, newRewriting));
			}
			if (flag)
			{
				simplifiedRewriting = newRewriting;
				this.m_usedViews.Remove(key);
				return true;
			}
			return false;
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x000F32F0 File Offset: 0x000F14F0
		private T_Tile GetRewritingHalf(T_Tile halfRewriting, T_Tile remainingView, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind viewKind)
		{
			switch (viewKind)
			{
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Union:
				halfRewriting = this.m_qp.Union(halfRewriting, remainingView);
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join:
				halfRewriting = this.m_qp.Join(halfRewriting, remainingView);
				break;
			case global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.AntiSemiJoin:
				halfRewriting = this.m_qp.AntiSemiJoin(halfRewriting, remainingView);
				break;
			}
			return halfRewriting;
		}

		// Token: 0x040018CD RID: 6349
		private readonly T_Tile m_originalRewriting;

		// Token: 0x040018CE RID: 6350
		private readonly T_Tile m_toAvoid;

		// Token: 0x040018CF RID: 6351
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> m_qp;

		// Token: 0x040018D0 RID: 6352
		private readonly global::System.Collections.Generic.Dictionary<T_Tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind> m_usedViews = new global::System.Collections.Generic.Dictionary<T_Tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind>();
	}
}
