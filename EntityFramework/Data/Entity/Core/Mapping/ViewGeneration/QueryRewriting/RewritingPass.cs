using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x0200058B RID: 1419
	internal class RewritingPass<T_Tile> where T_Tile : class
	{
		// Token: 0x060044C8 RID: 17608 RVA: 0x000F273A File Offset: 0x000F093A
		public RewritingPass(T_Tile toFill, T_Tile toAvoid, global::System.Collections.Generic.List<T_Tile> views, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> qp)
		{
			this.m_toFill = toFill;
			this.m_toAvoid = toAvoid;
			this.m_views = views;
			this.m_qp = qp;
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x000F276A File Offset: 0x000F096A
		public static bool RewriteQuery(T_Tile toFill, T_Tile toAvoid, out T_Tile rewriting, global::System.Collections.Generic.List<T_Tile> views, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> qp)
		{
			if (new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingPass<T_Tile>(toFill, toAvoid, views, qp).RewriteQuery(out rewriting))
			{
				global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingSimplifier<T_Tile>.TrySimplifyUnionRewriting(ref rewriting, toFill, toAvoid, qp);
				return true;
			}
			return false;
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x000F278C File Offset: 0x000F098C
		private static bool RewriteQueryInternal(T_Tile toFill, T_Tile toAvoid, out T_Tile rewriting, global::System.Collections.Generic.List<T_Tile> views, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> qp)
		{
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingPass<T_Tile>(toFill, toAvoid, views, qp).RewriteQuery(out rewriting);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x000F27A0 File Offset: 0x000F09A0
		private bool RewriteQuery(out T_Tile rewriting)
		{
			rewriting = this.m_toFill;
			T_Tile t_Tile;
			if (!this.FindRewritingByIncludedAndDisjoint(out t_Tile) && !this.FindContributingView(out t_Tile))
			{
				return false;
			}
			bool flag = !this.m_qp.IsDisjointFrom(t_Tile, this.m_toAvoid);
			if (flag)
			{
				foreach (T_Tile view in this.AvailableViews)
				{
					if (this.TryJoin(view, ref t_Tile))
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				foreach (T_Tile view2 in this.AvailableViews)
				{
					if (this.TryAntiSemiJoin(view2, ref t_Tile))
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				return false;
			}
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingSimplifier<T_Tile>.TrySimplifyJoinRewriting(ref t_Tile, this.m_toAvoid, this.m_usedViews, this.m_qp);
			T_Tile t_Tile2 = this.m_qp.AntiSemiJoin(this.m_toFill, t_Tile);
			if (!this.m_qp.IsEmpty(t_Tile2))
			{
				T_Tile t_Tile3;
				if (!global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingPass<T_Tile>.RewriteQueryInternal(t_Tile2, this.m_toAvoid, out t_Tile3, this.m_views, this.m_qp))
				{
					rewriting = t_Tile3;
					return false;
				}
				if (this.m_qp.IsContainedIn(t_Tile, t_Tile3))
				{
					t_Tile = t_Tile3;
				}
				else
				{
					t_Tile = this.m_qp.Union(t_Tile, t_Tile3);
				}
			}
			rewriting = t_Tile;
			return true;
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x000F2910 File Offset: 0x000F0B10
		private bool TryJoin(T_Tile view, ref T_Tile rewriting)
		{
			T_Tile t_Tile = this.m_qp.Join(rewriting, view);
			if (!this.m_qp.IsEmpty(t_Tile))
			{
				this.m_usedViews[view] = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join;
				rewriting = t_Tile;
				return this.m_qp.IsDisjointFrom(rewriting, this.m_toAvoid);
			}
			return false;
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x000F296C File Offset: 0x000F0B6C
		private bool TryAntiSemiJoin(T_Tile view, ref T_Tile rewriting)
		{
			T_Tile t_Tile = this.m_qp.AntiSemiJoin(rewriting, view);
			if (!this.m_qp.IsEmpty(t_Tile))
			{
				this.m_usedViews[view] = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.AntiSemiJoin;
				rewriting = t_Tile;
				return this.m_qp.IsDisjointFrom(rewriting, this.m_toAvoid);
			}
			return false;
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x000F29C8 File Offset: 0x000F0BC8
		private bool FindRewritingByIncludedAndDisjoint(out T_Tile rewritingSoFar)
		{
			rewritingSoFar = default(T_Tile);
			foreach (T_Tile t_Tile in this.AvailableViews)
			{
				if (this.m_qp.IsContainedIn(this.m_toFill, t_Tile))
				{
					if (rewritingSoFar == null)
					{
						rewritingSoFar = t_Tile;
						this.m_usedViews[t_Tile] = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join;
					}
					else
					{
						T_Tile t_Tile2 = this.m_qp.Join(rewritingSoFar, t_Tile);
						if (this.m_qp.IsContainedIn(rewritingSoFar, t_Tile2))
						{
							continue;
						}
						rewritingSoFar = t_Tile2;
						this.m_usedViews[t_Tile] = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join;
					}
					if (this.m_qp.IsContainedIn(rewritingSoFar, this.m_toFill))
					{
						return true;
					}
				}
			}
			if (rewritingSoFar != null)
			{
				foreach (T_Tile t_Tile3 in this.AvailableViews)
				{
					if (this.m_qp.IsDisjointFrom(this.m_toFill, t_Tile3) && !this.m_qp.IsDisjointFrom(rewritingSoFar, t_Tile3))
					{
						rewritingSoFar = this.m_qp.AntiSemiJoin(rewritingSoFar, t_Tile3);
						this.m_usedViews[t_Tile3] = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.AntiSemiJoin;
						if (this.m_qp.IsContainedIn(rewritingSoFar, this.m_toFill))
						{
							return true;
						}
					}
				}
			}
			return rewritingSoFar != null;
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x000F2B74 File Offset: 0x000F0D74
		private bool FindContributingView(out T_Tile rewriting)
		{
			foreach (T_Tile t_Tile in this.AvailableViews)
			{
				if (!this.m_qp.IsDisjointFrom(t_Tile, this.m_toFill))
				{
					rewriting = t_Tile;
					this.m_usedViews[t_Tile] = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Join;
					return true;
				}
			}
			rewriting = default(T_Tile);
			return false;
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x060044D0 RID: 17616 RVA: 0x000F2BF0 File Offset: 0x000F0DF0
		private global::System.Collections.Generic.IEnumerable<T_Tile> AvailableViews
		{
			get
			{
				return from view in this.m_views
				where !this.m_usedViews.ContainsKey(view)
				select view;
			}
		}

		// Token: 0x040018BE RID: 6334
		private readonly T_Tile m_toFill;

		// Token: 0x040018BF RID: 6335
		private readonly T_Tile m_toAvoid;

		// Token: 0x040018C0 RID: 6336
		private readonly global::System.Collections.Generic.List<T_Tile> m_views;

		// Token: 0x040018C1 RID: 6337
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile> m_qp;

		// Token: 0x040018C2 RID: 6338
		private readonly global::System.Collections.Generic.Dictionary<T_Tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind> m_usedViews = new global::System.Collections.Generic.Dictionary<T_Tile, global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind>();
	}
}
