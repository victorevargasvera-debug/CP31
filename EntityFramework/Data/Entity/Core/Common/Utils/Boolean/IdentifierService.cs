using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000614 RID: 1556
	internal abstract class IdentifierService<T_Identifier>
	{
		// Token: 0x06004BB0 RID: 19376 RVA: 0x0010A464 File Offset: 0x00108664
		private static global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier> GetIdentifierService()
		{
			global::System.Type typeFromHandle = typeof(T_Identifier);
			if (typeFromHandle.IsGenericType() && typeFromHandle.GetGenericTypeDefinition() == typeof(global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<, >))
			{
				global::System.Type[] genericArguments = typeFromHandle.GetGenericArguments();
				global::System.Type type = genericArguments[0];
				global::System.Type type2 = genericArguments[1];
				return (global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>)global::System.Activator.CreateInstance(typeof(global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<>.DomainConstraintIdentifierService<, >).MakeGenericType(new global::System.Type[]
				{
					typeFromHandle,
					type,
					type2
				}));
			}
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>.GenericIdentifierService();
		}

		// Token: 0x06004BB1 RID: 19377 RVA: 0x0010A4D9 File Offset: 0x001086D9
		private IdentifierService()
		{
		}

		// Token: 0x06004BB2 RID: 19378
		internal abstract global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> NegateLiteral(global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> literal);

		// Token: 0x06004BB3 RID: 19379
		internal abstract global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> CreateConversionContext();

		// Token: 0x06004BB4 RID: 19380
		internal abstract global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> LocalSimplify(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> expression);

		// Token: 0x04001A77 RID: 6775
		internal static readonly global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier> Instance = global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>.GetIdentifierService();

		// Token: 0x02000C50 RID: 3152
		private class GenericIdentifierService : global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>
		{
			// Token: 0x06006AA3 RID: 27299 RVA: 0x0016BAB7 File Offset: 0x00169CB7
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> NegateLiteral(global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier> literal)
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>(literal.Term, !literal.IsTermPositive);
			}

			// Token: 0x06006AA4 RID: 27300 RVA: 0x0016BACD File Offset: 0x00169CCD
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> CreateConversionContext()
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.GenericConversionContext<T_Identifier>();
			}

			// Token: 0x06006AA5 RID: 27301 RVA: 0x0016BAD4 File Offset: 0x00169CD4
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> LocalSimplify(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> expression)
			{
				return expression.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier>>(global::System.Data.Entity.Core.Common.Utils.Boolean.Simplifier<T_Identifier>.Instance);
			}
		}

		// Token: 0x02000C51 RID: 3153
		private class DomainConstraintIdentifierService<T_Variable, T_Element> : global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>
		{
			// Token: 0x06006AA7 RID: 27303 RVA: 0x0016BAE9 File Offset: 0x00169CE9
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> NegateLiteral(global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> literal)
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>(literal.Term.Identifier.InvertDomainConstraint()), literal.IsTermPositive);
			}

			// Token: 0x06006AA8 RID: 27304 RVA: 0x0016BB0B File Offset: 0x00169D0B
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> CreateConversionContext()
			{
				return new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraintConversionContext<T_Variable, T_Element>();
			}

			// Token: 0x06006AA9 RID: 27305 RVA: 0x0016BB12 File Offset: 0x00169D12
			internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> LocalSimplify(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>> expression)
			{
				expression = global::System.Data.Entity.Core.Common.Utils.Boolean.NegationPusher.EliminateNot<T_Variable, T_Element>(expression);
				return expression.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>>(global::System.Data.Entity.Core.Common.Utils.Boolean.Simplifier<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<T_Variable, T_Element>>.Instance);
			}
		}
	}
}
