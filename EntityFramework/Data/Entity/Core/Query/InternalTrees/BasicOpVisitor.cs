using System;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200037F RID: 895
	internal abstract class BasicOpVisitor
	{
		// Token: 0x06002B18 RID: 11032 RVA: 0x0008C7B4 File Offset: 0x0008A9B4
		protected virtual void VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				this.VisitNode(n2);
			}
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0008C808 File Offset: 0x0008AA08
		protected virtual void VisitChildrenReverse(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			for (int i = n.Children.Count - 1; i >= 0; i--)
			{
				this.VisitNode(n.Children[i]);
			}
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x0008C83F File Offset: 0x0008AA3F
		internal virtual void VisitNode(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			n.Op.Accept(this, n);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x0008C84E File Offset: 0x0008AA4E
		protected virtual void VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0008C857 File Offset: 0x0008AA57
		protected virtual void VisitConstantOp(global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x0008C861 File Offset: 0x0008AA61
		protected virtual void VisitTableOp(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x0008C86B File Offset: 0x0008AA6B
		protected virtual void VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x0008C875 File Offset: 0x0008AA75
		protected virtual void VisitApplyOp(global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x0008C87F File Offset: 0x0008AA7F
		protected virtual void VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x0008C889 File Offset: 0x0008AA89
		protected virtual void VisitSortOp(global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x0008C893 File Offset: 0x0008AA93
		protected virtual void VisitGroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x0008C89D File Offset: 0x0008AA9D
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Iqt_General_UnsupportedOp(op.GetType().FullName));
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x0008C8B4 File Offset: 0x0008AAB4
		protected virtual void VisitScalarOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitDefault(n);
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x0008C8BD File Offset: 0x0008AABD
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitConstantOp(op, n);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x0008C8C7 File Offset: 0x0008AAC7
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitConstantOp(op, n);
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x0008C8D1 File Offset: 0x0008AAD1
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitConstantOp(op, n);
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x0008C8DB File Offset: 0x0008AADB
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitConstantOp(op, n);
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x0008C8E5 File Offset: 0x0008AAE5
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitConstantOp(op, n);
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x0008C8EF File Offset: 0x0008AAEF
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0008C8F9 File Offset: 0x0008AAF9
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x0008C903 File Offset: 0x0008AB03
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x0008C90D File Offset: 0x0008AB0D
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x0008C917 File Offset: 0x0008AB17
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B2F RID: 11055 RVA: 0x0008C921 File Offset: 0x0008AB21
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.LikeOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x0008C92B File Offset: 0x0008AB2B
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x0008C935 File Offset: 0x0008AB35
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x0008C93F File Offset: 0x0008AB3F
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x0008C949 File Offset: 0x0008AB49
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x0008C953 File Offset: 0x0008AB53
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x0008C95D File Offset: 0x0008AB5D
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x0008C967 File Offset: 0x0008AB67
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x0008C971 File Offset: 0x0008AB71
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x0008C97B File Offset: 0x0008AB7B
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x0008C985 File Offset: 0x0008AB85
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ArithmeticOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x0008C98F File Offset: 0x0008AB8F
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.TreatOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x0008C999 File Offset: 0x0008AB99
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x0008C9A3 File Offset: 0x0008ABA3
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x0008C9AD File Offset: 0x0008ABAD
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x0008C9B7 File Offset: 0x0008ABB7
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x0008C9C1 File Offset: 0x0008ABC1
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ElementOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0008C9CB File Offset: 0x0008ABCB
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x0008C9D5 File Offset: 0x0008ABD5
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x0008C9DF File Offset: 0x0008ABDF
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x0008C9E9 File Offset: 0x0008ABE9
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DerefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x0008C9F3 File Offset: 0x0008ABF3
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0008C9FD File Offset: 0x0008ABFD
		protected virtual void VisitAncillaryOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.AncillaryOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitDefault(n);
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x0008CA06 File Offset: 0x0008AC06
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitAncillaryOpDefault(op, n);
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x0008CA10 File Offset: 0x0008AC10
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitAncillaryOpDefault(op, n);
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x0008CA1A File Offset: 0x0008AC1A
		protected virtual void VisitRelOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.RelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitDefault(n);
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x0008CA23 File Offset: 0x0008AC23
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitTableOp(op, n);
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x0008CA2D File Offset: 0x0008AC2D
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitTableOp(op, n);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x0008CA37 File Offset: 0x0008AC37
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x0008CA41 File Offset: 0x0008AC41
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x0008CA4B File Offset: 0x0008AC4B
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x0008CA55 File Offset: 0x0008AC55
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitSortOp(op, n);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x0008CA5F File Offset: 0x0008AC5F
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitSortOp(op, n);
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x0008CA69 File Offset: 0x0008AC69
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitGroupByOp(op, n);
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x0008CA73 File Offset: 0x0008AC73
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitGroupByOp(op, n);
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x0008CA7D File Offset: 0x0008AC7D
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitJoinOp(op, n);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x0008CA87 File Offset: 0x0008AC87
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitJoinOp(op, n);
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x0008CA91 File Offset: 0x0008AC91
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitJoinOp(op, n);
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x0008CA9B File Offset: 0x0008AC9B
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitJoinOp(op, n);
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x0008CAA5 File Offset: 0x0008ACA5
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitApplyOp(op, n);
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x0008CAAF File Offset: 0x0008ACAF
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitApplyOp(op, n);
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x0008CAB9 File Offset: 0x0008ACB9
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitSetOp(op, n);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x0008CAC3 File Offset: 0x0008ACC3
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitSetOp(op, n);
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x0008CACD File Offset: 0x0008ACCD
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitSetOp(op, n);
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x0008CAD7 File Offset: 0x0008ACD7
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x0008CAE1 File Offset: 0x0008ACE1
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x0008CAEB File Offset: 0x0008ACEB
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x0008CAF5 File Offset: 0x0008ACF5
		protected virtual void VisitPhysicalOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitDefault(n);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x0008CAFE File Offset: 0x0008ACFE
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitPhysicalOpDefault(op, n);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x0008CB08 File Offset: 0x0008AD08
		protected virtual void VisitNestOp(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitPhysicalOpDefault(op, n);
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0008CB12 File Offset: 0x0008AD12
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNestOp(op, n);
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x0008CB1C File Offset: 0x0008AD1C
		public virtual void Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNestOp(op, n);
		}
	}
}
