using System;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x02000623 RID: 1571
	internal class ToDecisionDiagramConverter<T_Identifier> : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<T_Identifier, global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>
	{
		// Token: 0x06004C10 RID: 19472 RVA: 0x0010B180 File Offset: 0x00109380
		private ToDecisionDiagramConverter(global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> context)
		{
			this._context = context;
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x0010B190 File Offset: 0x00109390
		internal static global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex TranslateToRobdd(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> expr, global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> context)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.ToDecisionDiagramConverter<T_Identifier> visitor = new global::System.Data.Entity.Core.Common.Utils.Boolean.ToDecisionDiagramConverter<T_Identifier>(context);
			return expr.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>(visitor);
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x0010B1AB File Offset: 0x001093AB
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<T_Identifier> expression)
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.One;
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x0010B1B2 File Offset: 0x001093B2
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<T_Identifier> expression)
		{
			return global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex.Zero;
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x0010B1B9 File Offset: 0x001093B9
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<T_Identifier> expression)
		{
			return this._context.TranslateTermToVertex(expression);
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x0010B1C7 File Offset: 0x001093C7
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<T_Identifier> expression)
		{
			return this._context.Solver.Not(expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>(this));
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x0010B1E5 File Offset: 0x001093E5
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<T_Identifier> expression)
		{
			return this._context.Solver.And(from child in expression.Children
			select child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>(this));
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x0010B20E File Offset: 0x0010940E
		internal override global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<T_Identifier> expression)
		{
			return this._context.Solver.Or(from child in expression.Children
			select child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex>(this));
		}

		// Token: 0x04001A8D RID: 6797
		private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> _context;
	}
}
