using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200035E RID: 862
	internal class PropertyPushdownHelper : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor
	{
		// Token: 0x060029E7 RID: 10727 RVA: 0x000878AE File Offset: 0x00085AAE
		private PropertyPushdownHelper()
		{
			this.m_varPropertyRefMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList>();
			this.m_nodePropertyRefMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList>();
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000878CC File Offset: 0x00085ACC
		internal static void Process(global::System.Data.Entity.Core.Query.InternalTrees.Command itree, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> varPropertyRefs, out global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> nodePropertyRefs)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyPushdownHelper propertyPushdownHelper = new global::System.Data.Entity.Core.Query.PlanCompiler.PropertyPushdownHelper();
			propertyPushdownHelper.Process(itree.Root);
			varPropertyRefs = propertyPushdownHelper.m_varPropertyRefMap;
			nodePropertyRefs = propertyPushdownHelper.m_nodePropertyRefMap;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x000878FB File Offset: 0x00085AFB
		private void Process(global::System.Data.Entity.Core.Query.InternalTrees.Node rootNode)
		{
			rootNode.Op.Accept(this, rootNode);
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x0008790C File Offset: 0x00085B0C
		private global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList GetPropertyRefList(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList;
			if (!this.m_nodePropertyRefMap.TryGetValue(node, out propertyRefList))
			{
				propertyRefList = new global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList();
				this.m_nodePropertyRefMap[node] = propertyRefList;
			}
			return propertyRefList;
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x0008793D File Offset: 0x00085B3D
		private void AddPropertyRefs(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefs)
		{
			this.GetPropertyRefList(node).Append(propertyRefs);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x0008794C File Offset: 0x00085B4C
		private global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList GetPropertyRefList(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList;
			if (!this.m_varPropertyRefMap.TryGetValue(v, out propertyRefList))
			{
				propertyRefList = new global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList();
				this.m_varPropertyRefMap[v] = propertyRefList;
			}
			return propertyRefList;
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x0008797D File Offset: 0x00085B7D
		private void AddPropertyRefs(global::System.Data.Entity.Core.Query.InternalTrees.Var v, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefs)
		{
			this.GetPropertyRefList(v).Append(propertyRefs);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x0008798C File Offset: 0x00085B8C
		private static global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList GetIdentityProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType type)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList keyProperties = global::System.Data.Entity.Core.Query.PlanCompiler.PropertyPushdownHelper.GetKeyProperties(type);
			keyProperties.Add(global::System.Data.Entity.Core.Query.PlanCompiler.EntitySetIdPropertyRef.Instance);
			return keyProperties;
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000879A0 File Offset: 0x00085BA0
		private static global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList GetKeyProperties(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = new global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in entityType.KeyMembers)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = edmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(edmProperty != null, "EntityType had non-EdmProperty key member?");
				global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef property = new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(edmProperty);
				propertyRefList.Add(property);
			}
			return propertyRefList;
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00087A14 File Offset: 0x00085C14
		protected override void VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp scalarOp = node.Op as global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp;
				if (scalarOp != null && global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(scalarOp.Type))
				{
					this.AddPropertyRefs(node, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList.All);
				}
			}
			this.VisitChildren(n);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00087A90 File Offset: 0x00085C90
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = null;
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(op.Type))
			{
				propertyRefList = global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList.All;
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNominalType(op.Type))
			{
				propertyRefList = this.m_nodePropertyRefMap[n].Clone();
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(op.Type))
			{
				propertyRefList = global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList.All;
			}
			if (propertyRefList != null)
			{
				this.AddPropertyRefs(n.Child0, propertyRefList);
			}
			this.VisitChildren(n);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00087B00 File Offset: 0x00085D00
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.GetPropertyRefList(n);
			for (int i = 1; i < n.Children.Count - 1; i += 2)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefs = propertyRefList.Clone();
				this.AddPropertyRefs(n.Children[i], propertyRefs);
			}
			this.AddPropertyRefs(n.Children[n.Children.Count - 1], propertyRefList.Clone());
			this.VisitChildren(n);
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x00087B72 File Offset: 0x00085D72
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x00087B7C File Offset: 0x00085D7C
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = (n.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp).Type;
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				this.VisitChildren(n);
				return;
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(type))
			{
				this.VisitDefault(n);
				return;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEntityType(type), "unexpected childOpType?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList identityProperties = global::System.Data.Entity.Core.Query.PlanCompiler.PropertyPushdownHelper.GetIdentityProperties(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(type));
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				this.AddPropertyRefs(node, identityProperties);
			}
			this.VisitChildren(n);
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x00087C34 File Offset: 0x00085E34
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ElementOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00087C3C File Offset: 0x00085E3C
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp scalarOp = n.Child0.Op as global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(scalarOp != null, "input to GetEntityRefOp is not a ScalarOp?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList identityProperties = global::System.Data.Entity.Core.Query.PlanCompiler.PropertyPushdownHelper.GetIdentityProperties(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(scalarOp.Type));
			this.AddPropertyRefs(n.Child0, identityProperties);
			this.VisitNode(n.Child0);
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x00087C90 File Offset: 0x00085E90
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = new global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList();
			propertyRefList.Add(global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdPropertyRef.Instance);
			this.AddPropertyRefs(n.Child0, propertyRefList);
			this.VisitChildren(n);
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x00087CC4 File Offset: 0x00085EC4
		private void VisitPropertyOp(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = new global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList();
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(op.Type))
			{
				propertyRefList.Add(propertyRef);
			}
			else
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList2 = this.GetPropertyRefList(n);
				if (propertyRefList2.AllProperties)
				{
					propertyRefList = propertyRefList2;
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef2 in propertyRefList2.Properties)
					{
						propertyRefList.Add(propertyRef2.CreateNestedPropertyRef(propertyRef));
					}
				}
			}
			this.AddPropertyRefs(n.Child0, propertyRefList);
			this.VisitChildren(n);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x00087D5C File Offset: 0x00085F5C
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitPropertyOp(op, n, new global::System.Data.Entity.Core.Query.PlanCompiler.RelPropertyRef(op.PropertyInfo));
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00087D71 File Offset: 0x00085F71
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitPropertyOp(op, n, new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(op.PropertyInfo));
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00087D88 File Offset: 0x00085F88
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.TreatOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.GetPropertyRefList(n).Clone();
			propertyRefList.Add(global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdPropertyRef.Instance);
			this.AddPropertyRefs(n.Child0, propertyRefList);
			this.VisitChildren(n);
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x00087DC4 File Offset: 0x00085FC4
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(op.Var.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.GetPropertyRefList(n);
				this.AddPropertyRefs(op.Var, propertyRefList);
			}
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x00087DF8 File Offset: 0x00085FF8
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(op.Var.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.GetPropertyRefList(op.Var);
				this.AddPropertyRefs(n.Child0, propertyRefList);
			}
			this.VisitChildren(n);
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00087E38 File Offset: 0x00086038
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x00087E41 File Offset: 0x00086041
		protected override void VisitApplyOp(global::System.Data.Entity.Core.Query.InternalTrees.ApplyBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNode(n.Child1);
			this.VisitNode(n.Child0);
		}

		// Token: 0x06002A00 RID: 10752 RVA: 0x00087E5C File Offset: 0x0008605C
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in op.Keys)
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(var.Type))
				{
					this.AddPropertyRefs(var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList.All);
				}
			}
			this.VisitChildren(n);
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x00087EC4 File Offset: 0x000860C4
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNode(n.Child1);
			this.VisitNode(n.Child0);
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x00087EE0 File Offset: 0x000860E0
		protected override void VisitGroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in op.Keys)
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(var.Type))
				{
					this.AddPropertyRefs(var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList.All);
				}
			}
			this.VisitChildrenReverse(n);
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00087F48 File Offset: 0x00086148
		protected override void VisitJoinOp(global::System.Data.Entity.Core.Query.InternalTrees.JoinBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (n.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.CrossJoin)
			{
				this.VisitChildren(n);
				return;
			}
			this.VisitNode(n.Child2);
			this.VisitNode(n.Child0);
			this.VisitNode(n.Child1);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00087F85 File Offset: 0x00086185
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitNode(n.Child1);
			this.VisitNode(n.Child0);
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x00087F9F File Offset: 0x0008619F
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!n.HasChild0, "scanTableOp with an input?");
		}

		// Token: 0x06002A06 RID: 10758 RVA: 0x00087FB4 File Offset: 0x000861B4
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.Table.Columns.Count == 1, "ScanViewOp with multiple columns?");
			global::System.Data.Entity.Core.Query.InternalTrees.Var v = op.Table.Columns[0];
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.GetPropertyRefList(v);
			global::System.Data.Entity.Core.Query.InternalTrees.Var singletonVar = global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.GetSingletonVar(n.Child0);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(singletonVar != null, "cannot determine single Var from ScanViewOp's input");
			this.AddPropertyRefs(singletonVar, propertyRefList.Clone());
			this.VisitChildren(n);
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x00088028 File Offset: 0x00086228
		protected override void VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap[] varMap = op.VarMap;
			for (int i = 0; i < varMap.Length; i++)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in varMap[i])
				{
					if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(keyValuePair.Key.Type))
					{
						global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.GetPropertyRefList(keyValuePair.Key);
						if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except)
						{
							propertyRefList = global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList.All;
							this.AddPropertyRefs(keyValuePair.Key, propertyRefList);
						}
						else
						{
							propertyRefList = propertyRefList.Clone();
						}
						this.AddPropertyRefs(keyValuePair.Value, propertyRefList);
					}
				}
			}
			this.VisitChildren(n);
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x000880F4 File Offset: 0x000862F4
		protected override void VisitSortOp(global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in op.Keys)
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(sortKey.Var.Type))
				{
					this.AddPropertyRefs(sortKey.Var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList.All);
				}
			}
			if (n.HasChild1)
			{
				this.VisitNode(n.Child1);
			}
			this.VisitNode(n.Child0);
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x00088184 File Offset: 0x00086384
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x00088190 File Offset: 0x00086390
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in op.Outputs)
			{
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(var.Type))
				{
					this.AddPropertyRefs(var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList.All);
				}
			}
			this.VisitChildren(n);
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000881FC File Offset: 0x000863FC
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x00088203 File Offset: 0x00086403
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x04000E6D RID: 3693
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> m_nodePropertyRefMap;

		// Token: 0x04000E6E RID: 3694
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> m_varPropertyRefMap;
	}
}
