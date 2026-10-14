using System;
using System.Data.Entity.Core.Query.PlanCompiler;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000381 RID: 897
	internal abstract class BasicOpVisitorOfT<TResultType>
	{
		// Token: 0x06002B6C RID: 11116 RVA: 0x0008CBF0 File Offset: 0x0008ADF0
		protected virtual void VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			for (int i = 0; i < n.Children.Count; i++)
			{
				this.VisitNode(n.Children[i]);
			}
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x0008CC28 File Offset: 0x0008AE28
		protected virtual void VisitChildrenReverse(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			for (int i = n.Children.Count - 1; i >= 0; i--)
			{
				this.VisitNode(n.Children[i]);
			}
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0008CC60 File Offset: 0x0008AE60
		internal TResultType VisitNode(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return n.Op.Accept<TResultType>(this, n);
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x0008CC70 File Offset: 0x0008AE70
		protected virtual TResultType VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			return default(TResultType);
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x0008CC90 File Offset: 0x0008AE90
		internal virtual TResultType Unimplemented(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Not implemented op type");
			return default(TResultType);
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x0008CCB1 File Offset: 0x0008AEB1
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.Unimplemented(n);
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x0008CCBA File Offset: 0x0008AEBA
		protected virtual TResultType VisitAncillaryOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.AncillaryOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitDefault(n);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0008CCC3 File Offset: 0x0008AEC3
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitAncillaryOpDefault(op, n);
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x0008CCCD File Offset: 0x0008AECD
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitAncillaryOpDefault(op, n);
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x0008CCD7 File Offset: 0x0008AED7
		protected virtual TResultType VisitPhysicalOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitDefault(n);
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x0008CCE0 File Offset: 0x0008AEE0
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitPhysicalOpDefault(op, n);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x0008CCEA File Offset: 0x0008AEEA
		protected virtual TResultType VisitNestOp(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitPhysicalOpDefault(op, n);
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x0008CCF4 File Offset: 0x0008AEF4
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitNestOp(op, n);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x0008CCFE File Offset: 0x0008AEFE
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitNestOp(op, n);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x0008CD08 File Offset: 0x0008AF08
		protected virtual TResultType VisitRelOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.RelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitDefault(n);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x0008CD11 File Offset: 0x0008AF11
		protected virtual TResultType VisitApplyOp(global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x0008CD1B File Offset: 0x0008AF1B
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitApplyOp(op, n);
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x0008CD25 File Offset: 0x0008AF25
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitApplyOp(op, n);
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x0008CD2F File Offset: 0x0008AF2F
		protected virtual TResultType VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x0008CD39 File Offset: 0x0008AF39
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitJoinOp(op, n);
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x0008CD43 File Offset: 0x0008AF43
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitJoinOp(op, n);
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0008CD4D File Offset: 0x0008AF4D
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitJoinOp(op, n);
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x0008CD57 File Offset: 0x0008AF57
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitJoinOp(op, n);
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x0008CD61 File Offset: 0x0008AF61
		protected virtual TResultType VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x0008CD6B File Offset: 0x0008AF6B
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitSetOp(op, n);
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x0008CD75 File Offset: 0x0008AF75
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitSetOp(op, n);
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x0008CD7F File Offset: 0x0008AF7F
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitSetOp(op, n);
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x0008CD89 File Offset: 0x0008AF89
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x0008CD93 File Offset: 0x0008AF93
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x0008CD9D File Offset: 0x0008AF9D
		protected virtual TResultType VisitGroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x0008CDA7 File Offset: 0x0008AFA7
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitGroupByOp(op, n);
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x0008CDB1 File Offset: 0x0008AFB1
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitGroupByOp(op, n);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x0008CDBB File Offset: 0x0008AFBB
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x0008CDC5 File Offset: 0x0008AFC5
		protected virtual TResultType VisitTableOp(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x0008CDCF File Offset: 0x0008AFCF
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitTableOp(op, n);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x0008CDD9 File Offset: 0x0008AFD9
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitTableOp(op, n);
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x0008CDE3 File Offset: 0x0008AFE3
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x0008CDED File Offset: 0x0008AFED
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x0008CDF7 File Offset: 0x0008AFF7
		protected virtual TResultType VisitSortOp(global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x0008CE01 File Offset: 0x0008B001
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitSortOp(op, n);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x0008CE0B File Offset: 0x0008B00B
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitSortOp(op, n);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x0008CE15 File Offset: 0x0008B015
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0008CE1F File Offset: 0x0008B01F
		protected virtual TResultType VisitScalarOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitDefault(n);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x0008CE28 File Offset: 0x0008B028
		protected virtual TResultType VisitConstantOp(global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0008CE32 File Offset: 0x0008B032
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x0008CE3C File Offset: 0x0008B03C
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ArithmeticOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x0008CE46 File Offset: 0x0008B046
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x0008CE50 File Offset: 0x0008B050
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.CastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x0008CE5A File Offset: 0x0008B05A
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x0008CE64 File Offset: 0x0008B064
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x0008CE6E File Offset: 0x0008B06E
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x0008CE78 File Offset: 0x0008B078
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x0008CE82 File Offset: 0x0008B082
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitConstantOp(op, n);
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x0008CE8C File Offset: 0x0008B08C
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitConstantOp(op, n);
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x0008CE96 File Offset: 0x0008B096
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ElementOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x0008CEA0 File Offset: 0x0008B0A0
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x0008CEAA File Offset: 0x0008B0AA
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x0008CEB4 File Offset: 0x0008B0B4
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x0008CEBE File Offset: 0x0008B0BE
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x0008CEC8 File Offset: 0x0008B0C8
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitConstantOp(op, n);
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x0008CED2 File Offset: 0x0008B0D2
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x0008CEDC File Offset: 0x0008B0DC
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.LikeOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x0008CEE6 File Offset: 0x0008B0E6
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x0008CEF0 File Offset: 0x0008B0F0
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x0008CEFA File Offset: 0x0008B0FA
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x0008CF04 File Offset: 0x0008B104
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x0008CF0E File Offset: 0x0008B10E
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x0008CF18 File Offset: 0x0008B118
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitConstantOp(op, n);
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x0008CF22 File Offset: 0x0008B122
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitConstantOp(op, n);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x0008CF2C File Offset: 0x0008B12C
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x0008CF36 File Offset: 0x0008B136
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x0008CF40 File Offset: 0x0008B140
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x0008CF4A File Offset: 0x0008B14A
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.TreatOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x0008CF54 File Offset: 0x0008B154
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x0008CF5E File Offset: 0x0008B15E
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.DerefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x0008CF68 File Offset: 0x0008B168
		public virtual TResultType Visit(global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitScalarOpDefault(op, n);
		}
	}
}
