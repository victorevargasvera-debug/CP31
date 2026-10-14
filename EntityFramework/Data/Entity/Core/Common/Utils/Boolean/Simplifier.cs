using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200061E RID: 1566
	internal class Simplifier<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<T_Identifier>
	{
		// Token: 0x06004BE1 RID: 19425 RVA: 0x0010A936 File Offset: 0x00108B36
		protected Simplifier()
		{
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x0010A940 File Offset: 0x00108B40
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier> expression)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr = expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(this);
			switch (boolExpr.ExprType)
			{
			case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Not:
				return ((global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier>)boolExpr).Child;
			case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.True:
				return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>.Value;
			case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.False:
				return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>.Value;
			}
			return base.VisitNot(expression);
		}

		// Token: 0x06004BE3 RID: 19427 RVA: 0x0010A99E File Offset: 0x00108B9E
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier> expression)
		{
			return this.SimplifyTree(expression);
		}

		// Token: 0x06004BE4 RID: 19428 RVA: 0x0010A9A7 File Offset: 0x00108BA7
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier> expression)
		{
			return this.SimplifyTree(expression);
		}

		// Token: 0x06004BE5 RID: 19429 RVA: 0x0010A9B0 File Offset: 0x00108BB0
		private global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> SimplifyTree(global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier> tree)
		{
			bool flag = tree.ExprType == global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.And;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(tree.Children.Count);
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr in tree.Children)
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr2 = boolExpr.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(this);
				if (boolExpr2.ExprType == tree.ExprType)
				{
					list.AddRange(((global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier>)boolExpr2).Children);
				}
				else
				{
					list.Add(boolExpr2);
				}
			}
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>, bool> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>, bool>(tree.Children.Count);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(tree.Children.Count);
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr3 in list)
			{
				switch (boolExpr3.ExprType)
				{
				case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Not:
					dictionary[((global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier>)boolExpr3).Child] = true;
					continue;
				case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.True:
					if (!flag)
					{
						return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>.Value;
					}
					continue;
				case global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.False:
					if (flag)
					{
						return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>.Value;
					}
					continue;
				}
				list2.Add(boolExpr3);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>();
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr4 in list2)
			{
				if (dictionary.ContainsKey(boolExpr4))
				{
					if (flag)
					{
						return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>.Value;
					}
					return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>.Value;
				}
				else
				{
					list3.Add(boolExpr4);
				}
			}
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> boolExpr5 in dictionary.Keys)
			{
				list3.Add(boolExpr5.MakeNegated());
			}
			if (list3.Count == 0)
			{
				if (flag)
				{
					return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier>.Value;
				}
				return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier>.Value;
			}
			else
			{
				if (1 == list3.Count)
				{
					return list3[0];
				}
				global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<T_Identifier> result;
				if (flag)
				{
					result = new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier>(list3);
				}
				else
				{
					result = new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier>(list3);
				}
				return result;
			}
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> result2;
			return result2;
		}

		// Token: 0x04001A82 RID: 6786
		internal static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Simplifier<T_Identifier> Instance = new global::System.Data.Entity.Core.Common.Utils.Boolean.Simplifier<T_Identifier>();
	}
}
