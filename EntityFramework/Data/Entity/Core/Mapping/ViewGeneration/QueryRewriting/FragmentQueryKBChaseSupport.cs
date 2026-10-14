using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Common.Utils.Boolean;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;
using System.Linq;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting
{
	// Token: 0x02000587 RID: 1415
	internal class FragmentQueryKBChaseSupport : global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKB
	{
		// Token: 0x0600447A RID: 17530 RVA: 0x000F007C File Offset: 0x000EE27C
		internal FragmentQueryKBChaseSupport()
		{
			this._chase = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.AtomicConditionRuleChase(this);
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x0600447B RID: 17531 RVA: 0x000F00A4 File Offset: 0x000EE2A4
		internal global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> Implications
		{
			get
			{
				if (this._implications == null)
				{
					this._implications = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>();
					foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> fact in base.Facts)
					{
						this.CacheFact(fact);
					}
				}
				return this._implications;
			}
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x000F010C File Offset: 0x000EE30C
		internal override void AddFact(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> fact)
		{
			base.AddFact(fact);
			this._kbSize += fact.CountTerms();
			if (this._implications != null)
			{
				this.CacheFact(fact);
			}
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x000F0138 File Offset: 0x000EE338
		private void CacheFact(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> fact)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Implication implication = fact as global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Implication;
			global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Equivalence equivalence = fact as global::System.Data.Entity.Core.Common.Utils.Boolean.KnowledgeBase<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Equivalence;
			if (implication != null)
			{
				this.CacheImplication(implication.Condition, implication.Implies);
				return;
			}
			if (equivalence != null)
			{
				this.CacheImplication(equivalence.Left, equivalence.Right);
				this.CacheImplication(equivalence.Right, equivalence.Left);
				return;
			}
			this.CacheResidualFact(fact);
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x000F0198 File Offset: 0x000EE398
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> ResidueInternal
		{
			get
			{
				if (this._residueSize < 0 && this._residualFacts.Count > 0)
				{
					this.PrepareResidue();
				}
				return this._residualFacts;
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x000F01BD File Offset: 0x000EE3BD
		private int ResidueSize
		{
			get
			{
				if (this._residueSize < 0)
				{
					this.PrepareResidue();
				}
				return this._residueSize;
			}
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x000F01D4 File Offset: 0x000EE3D4
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> Chase(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr;
			this.Implications.TryGetValue(expression, out boolExpr);
			return new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
			{
				expression,
				boolExpr ?? global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Value
			});
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x000F020C File Offset: 0x000EE40C
		internal bool IsSatisfiable(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.ConversionContext<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> context = global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Instance.CreateConversionContext();
			global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> converter = new global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(expression, context);
			if (converter.Vertex.IsZero())
			{
				return false;
			}
			if (base.KbExpression.ExprType == global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.True)
			{
				return true;
			}
			int num = expression.CountTerms() + this._kbSize;
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr = converter.Dnf.Expr;
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr2 = (global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.EstimateNnfAndSplitTermCount(expr) > global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.EstimateNnfAndSplitTermCount(expression)) ? expression : expr;
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr = this._chase.Chase(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.ToNnfAndSplitRange(expr2));
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr3;
			if (boolExpr.CountTerms() + this.ResidueSize > num)
			{
				expr3 = new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
				{
					base.KbExpression,
					expression
				});
			}
			else
			{
				expr3 = new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(this.ResidueInternal)
				{
					boolExpr
				});
				context = global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Instance.CreateConversionContext();
			}
			return !new global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(expr3, context).Vertex.IsZero();
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x000F02F4 File Offset: 0x000EE4F4
		internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> Chase(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
		{
			if (this.Implications.Count != 0)
			{
				return this._chase.Chase(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.ToNnfAndSplitRange(expression));
			}
			return expression;
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x000F0318 File Offset: 0x000EE518
		private void CacheImplication(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> condition, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> implies)
		{
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.ToDnf(condition, false);
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> implies2 = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.ToNnfAndSplitRange(implies);
			global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType exprType = boolExpr.ExprType;
			if (exprType != global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Or)
			{
				if (exprType != global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Term)
				{
					this.CacheResidualFact(new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
					{
						new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(condition),
						implies
					}));
					return;
				}
			}
			else
			{
				using (global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>.Enumerator enumerator = ((global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>)boolExpr).Children.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr2 = enumerator.Current;
						if (boolExpr2.ExprType != global::System.Data.Entity.Core.Common.Utils.Boolean.ExprType.Term)
						{
							this.CacheResidualFact(new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
							{
								new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(boolExpr2),
								implies
							}));
						}
						else
						{
							this.CacheNormalizedImplication((global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>)boolExpr2, implies2);
						}
					}
					return;
				}
			}
			this.CacheNormalizedImplication((global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>)boolExpr, implies2);
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x000F03F0 File Offset: 0x000EE5F0
		private void CacheNormalizedImplication(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> condition, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> implies)
		{
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> termExpr in this.Implications.Keys)
			{
				if (termExpr.Identifier.Variable.Equals(condition.Identifier.Variable) && !termExpr.Identifier.Range.SetEquals(condition.Identifier.Range))
				{
					this.CacheResidualFact(new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
					{
						new global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(condition),
						implies
					}));
					return;
				}
			}
			global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr = new global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(this.Chase(implies), global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Instance.CreateConversionContext()).Dnf.Expr;
			global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport fragmentQueryKBChaseSupport = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport();
			fragmentQueryKBChaseSupport.Implications[condition] = expr;
			bool flag = true;
			foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> termExpr2 in new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(this.Implications.Keys))
			{
				global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr = fragmentQueryKBChaseSupport.Chase(this.Implications[termExpr2]);
				if (termExpr2.Equals(condition))
				{
					flag = false;
					boolExpr = new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
					{
						boolExpr,
						expr
					});
				}
				this.Implications[termExpr2] = new global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(boolExpr, global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Instance.CreateConversionContext()).Dnf.Expr;
			}
			if (flag)
			{
				this.Implications[condition] = expr;
			}
			this._residueSize = -1;
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x000F0594 File Offset: 0x000EE794
		private void CacheResidualFact(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> fact)
		{
			this._residualFacts.Add(fact);
			this._residueSize = -1;
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x000F05AC File Offset: 0x000EE7AC
		private void PrepareResidue()
		{
			int num = 0;
			if (this.Implications.Count > 0 && this._residualFacts.Count > 0)
			{
				global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>();
				foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression in this._residualFacts)
				{
					global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr = new global::System.Data.Entity.Core.Common.Utils.Boolean.Converter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(this.Chase(expression), global::System.Data.Entity.Core.Common.Utils.Boolean.IdentifierService<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Instance.CreateConversionContext()).Dnf.Expr;
					set.Add(expr);
					num += expr.CountTerms();
					this._residueSize = num;
				}
				this._residualFacts = set;
			}
			this._residueSize = num;
		}

		// Token: 0x040018A5 RID: 6309
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> _implications;

		// Token: 0x040018A6 RID: 6310
		private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.AtomicConditionRuleChase _chase;

		// Token: 0x040018A7 RID: 6311
		private global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> _residualFacts = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>();

		// Token: 0x040018A8 RID: 6312
		private int _kbSize;

		// Token: 0x040018A9 RID: 6313
		private int _residueSize = -1;

		// Token: 0x02000B91 RID: 2961
		private static class Normalizer
		{
			// Token: 0x060066C7 RID: 26311 RVA: 0x0015F883 File Offset: 0x0015DA83
			internal static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> ToNnfAndSplitRange(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr)
			{
				return expr.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NonNegatedTreeVisitor.Instance);
			}

			// Token: 0x060066C8 RID: 26312 RVA: 0x0015F890 File Offset: 0x0015DA90
			internal static int EstimateNnfAndSplitTermCount(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr)
			{
				return expr.Accept<int>(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NonNegatedNnfSplitCounter.Instance);
			}

			// Token: 0x060066C9 RID: 26313 RVA: 0x0015F89D File Offset: 0x0015DA9D
			internal static global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> ToDnf(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr, bool isNnf)
			{
				if (!isNnf)
				{
					expr = global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.ToNnfAndSplitRange(expr);
				}
				return expr.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.DnfTreeVisitor.Instance);
			}

			// Token: 0x02000D7C RID: 3452
			private class NonNegatedTreeVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
			{
				// Token: 0x06006F35 RID: 28469 RVA: 0x0017C4FB File Offset: 0x0017A6FB
				private NonNegatedTreeVisitor()
				{
				}

				// Token: 0x06006F36 RID: 28470 RVA: 0x0017C503 File Offset: 0x0017A703
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr)
				{
					return expr.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NegatedTreeVisitor.Instance);
				}

				// Token: 0x06006F37 RID: 28471 RVA: 0x0017C518 File Offset: 0x0017A718
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					int count = expression.Identifier.Range.Count;
					if (count == 0)
					{
						return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Value;
					}
					if (count != 1)
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>();
						global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> variable = expression.Identifier.Variable;
						foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in expression.Identifier.Range)
						{
							list.Add(new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(variable, new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
							{
								constant
							}, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer)));
						}
						return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(list);
					}
					return expression;
				}

				// Token: 0x04003338 RID: 13112
				internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NonNegatedTreeVisitor Instance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NonNegatedTreeVisitor();
			}

			// Token: 0x02000D7D RID: 3453
			private class NegatedTreeVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.Visitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>, global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>
			{
				// Token: 0x06006F39 RID: 28473 RVA: 0x0017C5D8 File Offset: 0x0017A7D8
				private NegatedTreeVisitor()
				{
				}

				// Token: 0x06006F3A RID: 28474 RVA: 0x0017C5E0 File Offset: 0x0017A7E0
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitTrue(global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Value;
				}

				// Token: 0x06006F3B RID: 28475 RVA: 0x0017C5E7 File Offset: 0x0017A7E7
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitFalse(global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return global::System.Data.Entity.Core.Common.Utils.Boolean.TrueExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Value;
				}

				// Token: 0x06006F3C RID: 28476 RVA: 0x0017C5EE File Offset: 0x0017A7EE
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return expression.Child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NonNegatedTreeVisitor.Instance);
				}

				// Token: 0x06006F3D RID: 28477 RVA: 0x0017C600 File Offset: 0x0017A800
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(from child in expression.Children
					select child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(this));
				}

				// Token: 0x06006F3E RID: 28478 RVA: 0x0017C61E File Offset: 0x0017A81E
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitOr(global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(from child in expression.Children
					select child.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(this));
				}

				// Token: 0x06006F3F RID: 28479 RVA: 0x0017C63C File Offset: 0x0017A83C
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> domainConstraint = expression.Identifier.InvertDomainConstraint();
					if (domainConstraint.Range.Count == 0)
					{
						return global::System.Data.Entity.Core.Common.Utils.Boolean.FalseExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>.Value;
					}
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>();
					global::System.Data.Entity.Core.Common.Utils.Boolean.DomainVariable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant> variable = domainConstraint.Variable;
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant constant in domainConstraint.Range)
					{
						list.Add(new global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(variable, new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>(new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant[]
						{
							constant
						}, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant.EqualityComparer)));
					}
					return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(list);
				}

				// Token: 0x04003339 RID: 13113
				internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NegatedTreeVisitor Instance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NegatedTreeVisitor();
			}

			// Token: 0x02000D7E RID: 3454
			private class NonNegatedNnfSplitCounter : global::System.Data.Entity.Core.Common.Utils.Boolean.TermCounter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
			{
				// Token: 0x06006F43 RID: 28483 RVA: 0x0017C702 File Offset: 0x0017A902
				private NonNegatedNnfSplitCounter()
				{
				}

				// Token: 0x06006F44 RID: 28484 RVA: 0x0017C70A File Offset: 0x0017A90A
				internal override int VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expr)
				{
					return expr.Child.Accept<int>(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NegatedNnfSplitCountEstimator.Instance);
				}

				// Token: 0x06006F45 RID: 28485 RVA: 0x0017C71C File Offset: 0x0017A91C
				internal override int VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return expression.Identifier.Range.Count;
				}

				// Token: 0x0400333A RID: 13114
				internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NonNegatedNnfSplitCounter Instance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NonNegatedNnfSplitCounter();
			}

			// Token: 0x02000D7F RID: 3455
			private class NegatedNnfSplitCountEstimator : global::System.Data.Entity.Core.Common.Utils.Boolean.TermCounter<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
			{
				// Token: 0x06006F47 RID: 28487 RVA: 0x0017C73A File Offset: 0x0017A93A
				private NegatedNnfSplitCountEstimator()
				{
				}

				// Token: 0x06006F48 RID: 28488 RVA: 0x0017C742 File Offset: 0x0017A942
				internal override int VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return expression.Child.Accept<int>(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NonNegatedNnfSplitCounter.Instance);
				}

				// Token: 0x06006F49 RID: 28489 RVA: 0x0017C754 File Offset: 0x0017A954
				internal override int VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return expression.Identifier.Variable.Domain.Count - expression.Identifier.Range.Count;
				}

				// Token: 0x0400333B RID: 13115
				internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NegatedNnfSplitCountEstimator Instance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.NegatedNnfSplitCountEstimator();
			}

			// Token: 0x02000D80 RID: 3456
			private class DnfTreeVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
			{
				// Token: 0x06006F4B RID: 28491 RVA: 0x0017C788 File Offset: 0x0017A988
				private DnfTreeVisitor()
				{
				}

				// Token: 0x06006F4C RID: 28492 RVA: 0x0017C790 File Offset: 0x0017A990
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return expression;
				}

				// Token: 0x06006F4D RID: 28493 RVA: 0x0017C794 File Offset: 0x0017A994
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitAnd(global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr = base.VisitAnd(expression);
					global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> treeExpr = boolExpr as global::System.Data.Entity.Core.Common.Utils.Boolean.TreeExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>;
					if (treeExpr == null)
					{
						return boolExpr;
					}
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> set = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>();
					global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>> set2 = new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>>();
					foreach (global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> boolExpr2 in treeExpr.Children)
					{
						global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> orExpr = boolExpr2 as global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>;
						if (orExpr != null)
						{
							set2.Add(new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(orExpr.Children));
						}
						else
						{
							set.Add(boolExpr2);
						}
					}
					set2.Add(new global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
					{
						new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(set)
					}));
					global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>> seed = new global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>[]
					{
						global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>()
					};
					global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>> enumerable = set2.Aggregate(seed, (global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>> accumulator, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> bucket) => from accseq in accumulator
					from item in bucket
					select accseq.Concat(new global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>[]
					{
						item
					}));
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>();
					foreach (global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>> children in enumerable)
					{
						list.Add(new global::System.Data.Entity.Core.Common.Utils.Boolean.AndExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(children));
					}
					return new global::System.Data.Entity.Core.Common.Utils.Boolean.OrExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>(list);
				}

				// Token: 0x0400333C RID: 13116
				internal static readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.DnfTreeVisitor Instance = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.Normalizer.DnfTreeVisitor();
			}
		}

		// Token: 0x02000B92 RID: 2962
		private class AtomicConditionRuleChase
		{
			// Token: 0x060066CA RID: 26314 RVA: 0x0015F8B5 File Offset: 0x0015DAB5
			internal AtomicConditionRuleChase(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport kb)
			{
				this._visitor = new global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.AtomicConditionRuleChase.NonNegatedDomainConstraintTreeVisitor(kb);
			}

			// Token: 0x060066CB RID: 26315 RVA: 0x0015F8C9 File Offset: 0x0015DAC9
			internal global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> Chase(global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
			{
				return expression.Accept<global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>>(this._visitor);
			}

			// Token: 0x04002E24 RID: 11812
			private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport.AtomicConditionRuleChase.NonNegatedDomainConstraintTreeVisitor _visitor;

			// Token: 0x02000D81 RID: 3457
			private class NonNegatedDomainConstraintTreeVisitor : global::System.Data.Entity.Core.Common.Utils.Boolean.BasicVisitor<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>>
			{
				// Token: 0x06006F4F RID: 28495 RVA: 0x0017C8DC File Offset: 0x0017AADC
				internal NonNegatedDomainConstraintTreeVisitor(global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport kb)
				{
					this._kb = kb;
				}

				// Token: 0x06006F50 RID: 28496 RVA: 0x0017C8EB File Offset: 0x0017AAEB
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitTerm(global::System.Data.Entity.Core.Common.Utils.Boolean.TermExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return this._kb.Chase(expression);
				}

				// Token: 0x06006F51 RID: 28497 RVA: 0x0017C8F9 File Offset: 0x0017AAF9
				internal override global::System.Data.Entity.Core.Common.Utils.Boolean.BoolExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> VisitNot(global::System.Data.Entity.Core.Common.Utils.Boolean.NotExpr<global::System.Data.Entity.Core.Common.Utils.Boolean.DomainConstraint<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.BoolLiteral, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.Constant>> expression)
				{
					return base.VisitNot(expression);
				}

				// Token: 0x0400333D RID: 13117
				private readonly global::System.Data.Entity.Core.Mapping.ViewGeneration.QueryRewriting.FragmentQueryKBChaseSupport _kb;
			}
		}
	}
}
