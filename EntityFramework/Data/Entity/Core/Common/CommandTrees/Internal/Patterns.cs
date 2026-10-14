using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006F3 RID: 1779
	internal static class Patterns
	{
		// Token: 0x060052C6 RID: 21190 RVA: 0x001283AB File Offset: 0x001265AB
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> And(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern1, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern2)
		{
			return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => pattern1(e) && pattern2(e);
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x001283CB File Offset: 0x001265CB
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> And(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern1, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern2, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern3)
		{
			return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => pattern1(e) && pattern2(e) && pattern3(e);
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x001283F2 File Offset: 0x001265F2
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> Or(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern1, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern2)
		{
			return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => pattern1(e) || pattern2(e);
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00128412 File Offset: 0x00126612
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> Or(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern1, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern2, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> pattern3)
		{
			return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => pattern1(e) || pattern2(e) || pattern3(e);
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x060052CA RID: 21194 RVA: 0x00128439 File Offset: 0x00126639
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> AnyExpression
		{
			get
			{
				return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => true;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x060052CB RID: 21195 RVA: 0x0012845A File Offset: 0x0012665A
		internal static global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, bool> AnyExpressions
		{
			get
			{
				return (global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> elems) => true;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x060052CC RID: 21196 RVA: 0x0012847B File Offset: 0x0012667B
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchComplexType
		{
			get
			{
				return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(e.ResultType);
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x060052CD RID: 21197 RVA: 0x0012849C File Offset: 0x0012669C
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchEntityType
		{
			get
			{
				return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(e.ResultType);
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x060052CE RID: 21198 RVA: 0x001284BD File Offset: 0x001266BD
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchRowType
		{
			get
			{
				return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(e.ResultType);
			}
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x001284DE File Offset: 0x001266DE
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchKind(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kindToMatch)
		{
			return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => e.ExpressionKind == kindToMatch;
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x001284F7 File Offset: 0x001266F7
		internal static global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, bool> MatchForAll(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> elementPattern)
		{
			global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> <>9__1;
			return delegate(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> elems)
			{
				global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> predicate;
				if ((predicate = <>9__1) == null)
				{
					predicate = (<>9__1 = ((global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => !elementPattern(e)));
				}
				return elems.FirstOrDefault(predicate) == null;
			};
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00128510 File Offset: 0x00126710
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchBinary()
		{
			return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => e is global::System.Data.Entity.Core.Common.CommandTrees.DbBinaryExpression;
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00128531 File Offset: 0x00126731
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchFilter(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> inputPattern, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> predicatePattern)
		{
			return delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
			{
				if (e.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Filter)
				{
					return false;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression dbFilterExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbFilterExpression)e;
				return inputPattern(dbFilterExpression.Input.Expression) && predicatePattern(dbFilterExpression.Predicate);
			};
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00128551 File Offset: 0x00126751
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchProject(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> inputPattern, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> projectionPattern)
		{
			return delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
			{
				if (e.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Project)
				{
					return false;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression dbProjectExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbProjectExpression)e;
				return inputPattern(dbProjectExpression.Input.Expression) && projectionPattern(dbProjectExpression.Projection);
			};
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00128571 File Offset: 0x00126771
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchCase(global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, bool> whenPattern, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, bool> thenPattern, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> elsePattern)
		{
			return delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
			{
				if (e.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.Case)
				{
					return false;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression dbCaseExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbCaseExpression)e;
				return whenPattern(dbCaseExpression.When) && thenPattern(dbCaseExpression.Then) && elsePattern(dbCaseExpression.Else);
			};
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00128598 File Offset: 0x00126798
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchNewInstance()
		{
			return (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e) => e.ExpressionKind == global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance;
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x001285B9 File Offset: 0x001267B9
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> MatchNewInstance(global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>, bool> argumentsPattern)
		{
			return delegate(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression e)
			{
				if (e.ExpressionKind != global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind.NewInstance)
				{
					return false;
				}
				global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression dbNewInstanceExpression = (global::System.Data.Entity.Core.Common.CommandTrees.DbNewInstanceExpression)e;
				return argumentsPattern(dbNewInstanceExpression.Arguments);
			};
		}
	}
}
