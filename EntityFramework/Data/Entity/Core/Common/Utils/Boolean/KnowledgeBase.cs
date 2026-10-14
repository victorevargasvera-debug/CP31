using System;
using System.Collections.Generic;
using System.Text;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000615 RID: 1557
	internal class KnowledgeBase<T_Identifier>
	{
		// Token: 0x06004BB6 RID: 19382 RVA: 0x0010A4ED File Offset: 0x001086ED
		internal KnowledgeBase()
		{
			this._facts = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>();
			this._knowledge = global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One;
			this._context = global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>.Instance.CreateConversionContext();
		}

		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06004BB7 RID: 19383 RVA: 0x0010A51B File Offset: 0x0010871B
		protected global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> Facts
		{
			get
			{
				return this._facts;
			}
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x0010A524 File Offset: 0x00108724
		internal void AddKnowledgeBase(global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<T_Identifier> kb)
		{
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> fact in kb._facts)
			{
				this.AddFact(fact);
			}
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x0010A578 File Offset: 0x00108778
		internal virtual void AddFact(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> fact)
		{
			this._facts.Add(fact);
			global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex = new global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<T_Identifier>(fact, this._context).Vertex;
			this._knowledge = this._context.Solver.And(this._knowledge, vertex);
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x0010A5C0 File Offset: 0x001087C0
		internal void AddImplication(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> condition, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> implies)
		{
			this.AddFact(new global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<T_Identifier>.Implication(condition, implies));
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x0010A5CF File Offset: 0x001087CF
		internal void AddEquivalence(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> left, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> right)
		{
			this.AddFact(new global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<T_Identifier>.Equivalence(left, right));
		}

		// Token: 0x06004BBC RID: 19388 RVA: 0x0010A5E0 File Offset: 0x001087E0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine("Facts:");
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr in this._facts)
			{
				stringBuilder.Append("\t").AppendLine(boolExpr.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04001A78 RID: 6776
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> _facts;

		// Token: 0x04001A79 RID: 6777
		private global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex _knowledge;

		// Token: 0x04001A7A RID: 6778
		private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> _context;

		// Token: 0x02000C52 RID: 3154
		protected class Implication : global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier>
		{
			// Token: 0x1700117E RID: 4478
			// (get) Token: 0x06006AAB RID: 27307 RVA: 0x0016BB2F File Offset: 0x00169D2F
			internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> Condition
			{
				get
				{
					return this._condition;
				}
			}

			// Token: 0x1700117F RID: 4479
			// (get) Token: 0x06006AAC RID: 27308 RVA: 0x0016BB37 File Offset: 0x00169D37
			internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> Implies
			{
				get
				{
					return this._implies;
				}
			}

			// Token: 0x06006AAD RID: 27309 RVA: 0x0016BB3F File Offset: 0x00169D3F
			internal Implication(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> condition, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> implies) : base(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>[]
			{
				condition.MakeNegated(),
				implies
			})
			{
				this._condition = condition;
				this._implies = implies;
			}

			// Token: 0x06006AAE RID: 27310 RVA: 0x0016BB68 File Offset: 0x00169D68
			public override string ToString()
			{
				return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0} --> {1}", new object[]
				{
					this._condition,
					this._implies
				});
			}

			// Token: 0x040030DA RID: 12506
			private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> _condition;

			// Token: 0x040030DB RID: 12507
			private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> _implies;
		}

		// Token: 0x02000C53 RID: 3155
		protected class Equivalence : global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier>
		{
			// Token: 0x17001180 RID: 4480
			// (get) Token: 0x06006AAF RID: 27311 RVA: 0x0016BB8C File Offset: 0x00169D8C
			internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> Left
			{
				get
				{
					return this._left;
				}
			}

			// Token: 0x17001181 RID: 4481
			// (get) Token: 0x06006AB0 RID: 27312 RVA: 0x0016BB94 File Offset: 0x00169D94
			internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> Right
			{
				get
				{
					return this._right;
				}
			}

			// Token: 0x06006AB1 RID: 27313 RVA: 0x0016BB9C File Offset: 0x00169D9C
			internal Equivalence(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> left, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> right) : base(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>[]
			{
				new global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<T_Identifier>.Implication(left, right),
				new global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<T_Identifier>.Implication(right, left)
			})
			{
				this._left = left;
				this._right = right;
			}

			// Token: 0x06006AB2 RID: 27314 RVA: 0x0016BBCC File Offset: 0x00169DCC
			public override string ToString()
			{
				return global::System.Data.Entity.Core.Common.Utils.StringUtil.FormatInvariant("{0} <--> {1}", new object[]
				{
					this._left,
					this._right
				});
			}

			// Token: 0x040030DC RID: 12508
			private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> _left;

			// Token: 0x040030DD RID: 12509
			private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> _right;
		}
	}
}
