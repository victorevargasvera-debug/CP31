using System;
using System.Linq;

namespace System.Data.Entity.Core.Common.Utils.Boolean
{
	// Token: 0x0200060B RID: 1547
	internal sealed class Converter<T_Identifier>
	{
		// Token: 0x06004B89 RID: 19337 RVA: 0x00109D3A File Offset: 0x00107F3A
		internal Converter(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<T_Identifier> expr, global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> context)
		{
			this._context = (context ?? global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<T_Identifier>.Instance.CreateConversionContext());
			this._vertex = global::System.Data.Entity.Core.Common.Utils.Boolean.ToDecisionDiagramConverter<T_Identifier>.TranslateToRobdd(expr, this._context);
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06004B8A RID: 19338 RVA: 0x00109D69 File Offset: 0x00107F69
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex Vertex
		{
			get
			{
				return this._vertex;
			}
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06004B8B RID: 19339 RVA: 0x00109D71 File Offset: 0x00107F71
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.DnfSentence<T_Identifier> Dnf
		{
			get
			{
				this.InitializeNormalForms();
				return this._dnf;
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06004B8C RID: 19340 RVA: 0x00109D7F File Offset: 0x00107F7F
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.CnfSentence<T_Identifier> Cnf
		{
			get
			{
				this.InitializeNormalForms();
				return this._cnf;
			}
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x00109D90 File Offset: 0x00107F90
		private void InitializeNormalForms()
		{
			if (this._cnf == null)
			{
				if (this._vertex.IsOne())
				{
					this._cnf = new global::System.Data.Entity.Core.Common.Utils.Boolean.CnfSentence<T_Identifier>(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>>.Empty);
					global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier> element = new global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>>.Empty);
					this._dnf = new global::System.Data.Entity.Core.Common.Utils.Boolean.DnfSentence<T_Identifier>(new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>>
					{
						element
					}.MakeReadOnly());
					return;
				}
				if (this._vertex.IsZero())
				{
					global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier> element2 = new global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>>.Empty);
					this._cnf = new global::System.Data.Entity.Core.Common.Utils.Boolean.CnfSentence<T_Identifier>(new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>>
					{
						element2
					}.MakeReadOnly());
					this._dnf = new global::System.Data.Entity.Core.Common.Utils.Boolean.DnfSentence<T_Identifier>(global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>>.Empty);
					return;
				}
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>>();
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>>();
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>> path = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>>();
				this.FindAllPaths(this._vertex, set2, set, path);
				this._cnf = new global::System.Data.Entity.Core.Common.Utils.Boolean.CnfSentence<T_Identifier>(set2.MakeReadOnly());
				this._dnf = new global::System.Data.Entity.Core.Common.Utils.Boolean.DnfSentence<T_Identifier>(set.MakeReadOnly());
			}
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00109E84 File Offset: 0x00108084
		private void FindAllPaths(global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex vertex, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>> cnfClauses, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>> dnfClauses, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>> path)
		{
			if (vertex.IsOne())
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier> element = new global::System.Data.Entity.Core.Common.Utils.Boolean.DnfClause<T_Identifier>(path);
				dnfClauses.Add(element);
				return;
			}
			if (vertex.IsZero())
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier> element2 = new global::System.Data.Entity.Core.Common.Utils.Boolean.CnfClause<T_Identifier>(new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.Literal<T_Identifier>>(from l in path
				select l.MakeNegated()));
				cnfClauses.Add(element2);
				return;
			}
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.LiteralVertexPair<T_Identifier> literalVertexPair in this._context.GetSuccessors(vertex))
			{
				path.Add(literalVertexPair.Literal);
				this.FindAllPaths(literalVertexPair.Vertex, cnfClauses, dnfClauses, path);
				path.Remove(literalVertexPair.Literal);
			}
		}

		// Token: 0x04001A60 RID: 6752
		private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.Vertex _vertex;

		// Token: 0x04001A61 RID: 6753
		private readonly global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<T_Identifier> _context;

		// Token: 0x04001A62 RID: 6754
		private global::System.Data.Entity.Core.Common.Utils.Boolean.DnfSentence<T_Identifier> _dnf;

		// Token: 0x04001A63 RID: 6755
		private global::System.Data.Entity.Core.Common.Utils.Boolean.CnfSentence<T_Identifier> _cnf;
	}
}
