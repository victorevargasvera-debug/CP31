using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x0200037A RID: 890
	internal class VarRemapper : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitor
	{
		// Token: 0x06002AF1 RID: 10993 RVA: 0x0008C290 File Offset: 0x0008A490
		internal VarRemapper(global::System.Data.Entity.Core.Query.InternalTrees.Command command) : this(command, new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var>())
		{
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0008C29E File Offset: 0x0008A49E
		internal VarRemapper(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap)
		{
			this.m_command = command;
			this.m_varMap = varMap;
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x0008C2B4 File Offset: 0x0008A4B4
		internal void AddMapping(global::System.Data.Entity.Core.Query.InternalTrees.Var oldVar, global::System.Data.Entity.Core.Query.InternalTrees.Var newVar)
		{
			this.m_varMap[oldVar] = newVar;
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x0008C2C3 File Offset: 0x0008A4C3
		internal virtual void RemapNode(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			if (this.m_varMap.Count == 0)
			{
				return;
			}
			this.VisitNode(node);
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x0008C2DC File Offset: 0x0008A4DC
		internal virtual void RemapSubtree(global::System.Data.Entity.Core.Query.InternalTrees.Node subTree)
		{
			if (this.m_varMap.Count == 0)
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node subTree2 in subTree.Children)
			{
				this.RemapSubtree(subTree2);
			}
			this.RemapNode(subTree);
			this.m_command.RecomputeNodeInfo(subTree);
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0008C350 File Offset: 0x0008A550
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarList RemapVarList(global::System.Data.Entity.Core.Query.InternalTrees.VarList varList)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList(this.MapVars(varList));
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0008C35E File Offset: 0x0008A55E
		internal static global::System.Data.Entity.Core.Query.InternalTrees.VarList RemapVarList(global::System.Data.Entity.Core.Query.InternalTrees.Command command, global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> varMap, global::System.Data.Entity.Core.Query.InternalTrees.VarList varList)
		{
			return new global::System.Data.Entity.Core.Query.PlanCompiler.VarRemapper(command, varMap).RemapVarList(varList);
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x0008C370 File Offset: 0x0008A570
		private global::System.Data.Entity.Core.Query.InternalTrees.Var Map(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			while (this.m_varMap.TryGetValue(v, out var))
			{
				v = var;
			}
			return v;
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x0008C393 File Offset: 0x0008A593
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> MapVars(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> vars)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in vars)
			{
				yield return this.Map(v);
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x0008C3AC File Offset: 0x0008A5AC
		private void Map(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vec)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec other = this.m_command.CreateVarVec(this.MapVars(vec));
			vec.InitFrom(other);
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x0008C3D4 File Offset: 0x0008A5D4
		private void Map(global::System.Data.Entity.Core.Query.InternalTrees.VarList varList)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarList collection = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList(this.MapVars(varList));
			varList.Clear();
			varList.AddRange(collection);
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x0008C3FC File Offset: 0x0008A5FC
		private void Map(global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap2 = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in varMap)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var value = this.Map(keyValuePair.Value);
				varMap2.Add(keyValuePair.Key, value);
			}
			varMap.Clear();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair2 in varMap2)
			{
				varMap.Add(keyValuePair2.Key, keyValuePair2.Value);
			}
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x0008C4AC File Offset: 0x0008A6AC
		private void Map(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec();
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in sortKeys)
			{
				sortKey.Var = this.Map(sortKey.Var);
				if (varVec.IsSet(sortKey.Var))
				{
					flag = true;
				}
				varVec.Set(sortKey.Var);
			}
			if (flag)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>(sortKeys);
				sortKeys.Clear();
				varVec.Clear();
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey2 in list)
				{
					if (!varVec.IsSet(sortKey2.Var))
					{
						sortKeys.Add(sortKey2);
					}
					varVec.Set(sortKey2.Var);
				}
			}
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x0008C5A0 File Offset: 0x0008A7A0
		protected override void VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x0008C5A4 File Offset: 0x0008A7A4
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitScalarOpDefault(op, n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = this.Map(op.Var);
			if (var != op.Var)
			{
				n.Op = this.m_command.CreateVarRefOp(var);
			}
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x0008C5E1 File Offset: 0x0008A7E1
		protected override void VisitNestOp(global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x0008C5E8 File Offset: 0x0008A7E8
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitPhysicalOpDefault(op, n);
			this.Map(op.Outputs);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap = (global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap)global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.Translate(op.ColumnMap, this.m_varMap);
			n.Op = this.m_command.CreatePhysicalProjectOp(op.Outputs, columnMap);
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x0008C638 File Offset: 0x0008A838
		protected override void VisitGroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.GroupByBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
			this.Map(op.Outputs);
			this.Map(op.Keys);
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0008C65A File Offset: 0x0008A85A
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitGroupByOp(op, n);
			this.Map(op.Inputs);
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0008C670 File Offset: 0x0008A870
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
			this.Map(op.Keys);
		}

		// Token: 0x06002B05 RID: 11013 RVA: 0x0008C686 File Offset: 0x0008A886
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
			this.Map(op.Outputs);
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x0008C69C File Offset: 0x0008A89C
		public override void Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = this.Map(op.Var);
			if (var != op.Var)
			{
				n.Op = this.m_command.CreateUnnestOp(var, op.Table);
			}
		}

		// Token: 0x06002B07 RID: 11015 RVA: 0x0008C6DF File Offset: 0x0008A8DF
		protected override void VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
			this.Map(op.VarMap[0]);
			this.Map(op.VarMap[1]);
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x0008C705 File Offset: 0x0008A905
		protected override void VisitSortOp(global::System.Data.Entity.Core.Query.InternalTrees.SortBaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitRelOpDefault(op, n);
			this.Map(op.Keys);
		}

		// Token: 0x04000ED8 RID: 3800
		private readonly global::System.Collections.Generic.IDictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> m_varMap;

		// Token: 0x04000ED9 RID: 3801
		protected readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;
	}
}
