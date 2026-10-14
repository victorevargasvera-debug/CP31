using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x0200058C RID: 1420
	internal class RewritingProcessor<T_Tile> : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileProcessor<T_Tile> where T_Tile : class
	{
		// Token: 0x060044D2 RID: 17618 RVA: 0x000F2C1A File Offset: 0x000F0E1A
		public RewritingProcessor(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileProcessor<T_Tile> tileProcessor)
		{
			this.m_tileProcessor = tileProcessor;
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x060044D3 RID: 17619 RVA: 0x000F2C29 File Offset: 0x000F0E29
		internal global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileProcessor<T_Tile> TileProcessor
		{
			get
			{
				return this.m_tileProcessor;
			}
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x000F2C31 File Offset: 0x000F0E31
		public void GetStatistics(out int numSATChecks, out int numIntersection, out int numUnion, out int numDifference, out int numErrors)
		{
			numSATChecks = this.m_numSATChecks;
			numIntersection = this.m_numIntersection;
			numUnion = this.m_numUnion;
			numDifference = this.m_numDifference;
			numErrors = this.m_numErrors;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x000F2C5D File Offset: 0x000F0E5D
		internal override T_Tile GetArg1(T_Tile tile)
		{
			return this.m_tileProcessor.GetArg1(tile);
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x000F2C6B File Offset: 0x000F0E6B
		internal override T_Tile GetArg2(T_Tile tile)
		{
			return this.m_tileProcessor.GetArg2(tile);
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x000F2C79 File Offset: 0x000F0E79
		internal override global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind GetOpKind(T_Tile tile)
		{
			return this.m_tileProcessor.GetOpKind(tile);
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x000F2C87 File Offset: 0x000F0E87
		internal override bool IsEmpty(T_Tile a)
		{
			this.m_numSATChecks++;
			return this.m_tileProcessor.IsEmpty(a);
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x000F2CA3 File Offset: 0x000F0EA3
		public bool IsDisjointFrom(T_Tile a, T_Tile b)
		{
			return this.m_tileProcessor.IsEmpty(this.Join(a, b));
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x000F2CB8 File Offset: 0x000F0EB8
		internal bool IsContainedIn(T_Tile a, T_Tile b)
		{
			T_Tile tile = this.AntiSemiJoin(a, b);
			return this.IsEmpty(tile);
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x000F2CD8 File Offset: 0x000F0ED8
		internal bool IsEquivalentTo(T_Tile a, T_Tile b)
		{
			bool flag = this.IsContainedIn(a, b);
			bool flag2 = this.IsContainedIn(b, a);
			return flag && flag2;
		}

		// Token: 0x060044DC RID: 17628 RVA: 0x000F2CF8 File Offset: 0x000F0EF8
		internal override T_Tile Union(T_Tile a, T_Tile b)
		{
			this.m_numUnion++;
			return this.m_tileProcessor.Union(a, b);
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x000F2D15 File Offset: 0x000F0F15
		internal override T_Tile Join(T_Tile a, T_Tile b)
		{
			if (a == null)
			{
				return b;
			}
			this.m_numIntersection++;
			return this.m_tileProcessor.Join(a, b);
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x000F2D3C File Offset: 0x000F0F3C
		internal override T_Tile AntiSemiJoin(T_Tile a, T_Tile b)
		{
			this.m_numDifference++;
			return this.m_tileProcessor.AntiSemiJoin(a, b);
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x000F2D59 File Offset: 0x000F0F59
		public void AddError()
		{
			this.m_numErrors++;
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x000F2D6C File Offset: 0x000F0F6C
		public int CountOperators(T_Tile query)
		{
			int num = 0;
			if (query != null && this.GetOpKind(query) != global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Named)
			{
				num++;
				num += this.CountOperators(this.GetArg1(query));
				num += this.CountOperators(this.GetArg2(query));
			}
			return num;
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x000F2DB4 File Offset: 0x000F0FB4
		public int CountViews(T_Tile query)
		{
			global::System.Collections.Generic.HashSet<T_Tile> hashSet = new global::System.Collections.Generic.HashSet<T_Tile>();
			this.GatherViews(query, hashSet);
			return hashSet.Count;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x000F2DD5 File Offset: 0x000F0FD5
		public void GatherViews(T_Tile rewriting, global::System.Collections.Generic.HashSet<T_Tile> views)
		{
			if (rewriting != null)
			{
				if (this.GetOpKind(rewriting) == global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileOpKind.Named)
				{
					views.Add(rewriting);
					return;
				}
				this.GatherViews(this.GetArg1(rewriting), views);
				this.GatherViews(this.GetArg2(rewriting), views);
			}
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x000F2E0E File Offset: 0x000F100E
		public static global::System.Collections.Generic.IEnumerable<T> AllButOne<T>(global::System.Collections.Generic.IEnumerable<T> list, int toSkipPosition)
		{
			int valuePosition = 0;
			foreach (T t in list)
			{
				int num = valuePosition;
				valuePosition = num + 1;
				if (num != toSkipPosition)
				{
					yield return t;
				}
			}
			global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x000F2E25 File Offset: 0x000F1025
		public static global::System.Collections.Generic.IEnumerable<T> Concat<T>(T value, global::System.Collections.Generic.IEnumerable<T> rest)
		{
			yield return value;
			foreach (T t in rest)
			{
				yield return t;
			}
			global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x000F2E3C File Offset: 0x000F103C
		public static global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>> Permute<T>(global::System.Collections.Generic.IEnumerable<T> list)
		{
			global::System.Collections.Generic.IEnumerable<T> rest = null;
			int valuePosition = 0;
			foreach (T value in list)
			{
				int num = valuePosition;
				valuePosition = num + 1;
				rest = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile>.AllButOne<T>(list, num);
				foreach (global::System.Collections.Generic.IEnumerable<T> rest2 in global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile>.Permute<T>(rest))
				{
					yield return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile>.Concat<T>(value, rest2);
				}
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IEnumerable<T>> enumerator2 = null;
				value = default(T);
			}
			global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			if (rest == null)
			{
				yield return list;
			}
			yield break;
			yield break;
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x000F2E4C File Offset: 0x000F104C
		public static global::System.Collections.Generic.List<T> RandomPermutation<T>(global::System.Collections.Generic.IEnumerable<T> input)
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>(input);
			for (int i = 0; i < list.Count; i++)
			{
				int index = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile>.rnd.Next(list.Count);
				T value = list[i];
				list[i] = list[index];
				list[index] = value;
			}
			return list;
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x000F2EA1 File Offset: 0x000F10A1
		public static global::System.Collections.Generic.IEnumerable<T> Reverse<T>(global::System.Collections.Generic.IEnumerable<T> input, global::System.Collections.Generic.HashSet<T> filter)
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>(input);
			list.Reverse();
			foreach (T t in list)
			{
				if (filter.Contains(t))
				{
					yield return t;
				}
			}
			global::System.Collections.Generic.List<T>.Enumerator enumerator = default(global::System.Collections.Generic.List<T>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060044E8 RID: 17640 RVA: 0x000F2EB8 File Offset: 0x000F10B8
		public bool RewriteQuery(T_Tile toFill, T_Tile toAvoid, global::System.Collections.Generic.IEnumerable<T_Tile> views, out T_Tile rewriting)
		{
			if (this.RewriteQueryOnce(toFill, toAvoid, views, out rewriting))
			{
				global::System.Collections.Generic.HashSet<T_Tile> hashSet = new global::System.Collections.Generic.HashSet<T_Tile>();
				this.GatherViews(rewriting, hashSet);
				int num = this.CountOperators(rewriting);
				int num2 = 0;
				int num3 = global::System.Math.Min(0, global::System.Math.Max(0, (int)((double)hashSet.Count * 0.0)));
				while (num2++ < num3)
				{
					global::System.Collections.Generic.IEnumerable<T_Tile> views2;
					if (num2 == 1)
					{
						views2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile>.Reverse<T_Tile>(views, hashSet);
					}
					else
					{
						views2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingProcessor<T_Tile>.RandomPermutation<T_Tile>(hashSet);
					}
					T_Tile t_Tile;
					this.RewriteQueryOnce(toFill, toAvoid, views2, out t_Tile);
					int num4 = this.CountOperators(t_Tile);
					if (num4 < num)
					{
						num = num4;
						rewriting = t_Tile;
					}
					global::System.Collections.Generic.HashSet<T_Tile> hashSet2 = new global::System.Collections.Generic.HashSet<T_Tile>();
					this.GatherViews(t_Tile, hashSet2);
					hashSet = hashSet2;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060044E9 RID: 17641 RVA: 0x000F2F78 File Offset: 0x000F1178
		public bool RewriteQueryOnce(T_Tile toFill, T_Tile toAvoid, global::System.Collections.Generic.IEnumerable<T_Tile> views, out T_Tile rewriting)
		{
			global::System.Collections.Generic.List<T_Tile> views2 = new global::System.Collections.Generic.List<T_Tile>(views);
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.RewritingPass<T_Tile>.RewriteQuery(toFill, toAvoid, out rewriting, views2, this);
		}

		// Token: 0x040018C3 RID: 6339
		public const double PermuteFraction = 0.0;

		// Token: 0x040018C4 RID: 6340
		public const int MinPermutations = 0;

		// Token: 0x040018C5 RID: 6341
		public const int MaxPermutations = 0;

		// Token: 0x040018C6 RID: 6342
		private int m_numSATChecks;

		// Token: 0x040018C7 RID: 6343
		private int m_numIntersection;

		// Token: 0x040018C8 RID: 6344
		private int m_numDifference;

		// Token: 0x040018C9 RID: 6345
		private int m_numUnion;

		// Token: 0x040018CA RID: 6346
		private int m_numErrors;

		// Token: 0x040018CB RID: 6347
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.TileProcessor<T_Tile> m_tileProcessor;

		// Token: 0x040018CC RID: 6348
		private static global::System.Random rnd = new global::System.Random(1507);
	}
}
