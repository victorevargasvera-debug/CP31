using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C7 RID: 967
	internal class OpCopier : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x06002E39 RID: 11833 RVA: 0x00092DE4 File Offset: 0x00090FE4
		internal static global::System.Data.Entity.Core.Query.InternalTrees.Node Copy(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap;
			return global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(cmd, n, out varMap);
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x00092DFC File Offset: 0x00090FFC
		internal static global::System.Data.Entity.Core.Query.InternalTrees.Node Copy(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.VarList varList, out global::System.Data.Entity.Core.Query.InternalTrees.VarList newVarList)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap;
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(cmd, node, out varMap);
			newVarList = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var key in varList)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var item = varMap[key];
				newVarList.Add(item);
			}
			return result;
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x00092E68 File Offset: 0x00091068
		internal static global::System.Data.Entity.Core.Query.InternalTrees.Node Copy(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Data.Entity.Core.Query.InternalTrees.Node n, out global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.OpCopier opCopier = new global::System.Data.Entity.Core.Query.InternalTrees.OpCopier(cmd);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = opCopier.CopyNode(n);
			varMap = opCopier.m_varMap;
			return result;
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00092E8B File Offset: 0x0009108B
		internal static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> Copy(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.OpCopier(cmd).Copy(sortKeys);
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x00092E99 File Offset: 0x00091099
		protected OpCopier(global::System.Data.Entity.Core.Query.InternalTrees.Command cmd) : this(cmd, cmd)
		{
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x00092EA3 File Offset: 0x000910A3
		private OpCopier(global::System.Data.Entity.Core.Query.InternalTrees.Command destCommand, global::System.Data.Entity.Core.Query.InternalTrees.Command sourceCommand)
		{
			this.m_srcCmd = sourceCommand;
			this.m_destCmd = destCommand;
			this.m_varMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x00092EC4 File Offset: 0x000910C4
		private global::System.Data.Entity.Core.Query.InternalTrees.Var GetMappedVar(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var result;
			if (this.m_varMap.TryGetValue(v, out result))
			{
				return result;
			}
			if (this.m_destCmd != this.m_srcCmd)
			{
				throw global::System.Data.Entity.Core.EntityUtil.InternalError(global::System.Data.Entity.Core.EntityUtil.InternalErrorCode.UnknownVar, 6, null);
			}
			return v;
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x00092EFF File Offset: 0x000910FF
		private void SetMappedVar(global::System.Data.Entity.Core.Query.InternalTrees.Var v, global::System.Data.Entity.Core.Query.InternalTrees.Var mappedVar)
		{
			this.m_varMap.Add(v, mappedVar);
		}

		// Token: 0x06002E41 RID: 11841 RVA: 0x00092F10 File Offset: 0x00091110
		private void MapTable(global::System.Data.Entity.Core.Query.InternalTrees.Table newTable, global::System.Data.Entity.Core.Query.InternalTrees.Table oldTable)
		{
			for (int i = 0; i < oldTable.Columns.Count; i++)
			{
				this.SetMappedVar(oldTable.Columns[i], newTable.Columns[i]);
			}
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x00092F51 File Offset: 0x00091151
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> MapVars(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> vars)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in vars)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var mappedVar = this.GetMappedVar(v);
				yield return mappedVar;
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x00092F68 File Offset: 0x00091168
		private global::System.Data.Entity.Core.Query.InternalTrees.VarVec Copy(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars)
		{
			return this.m_destCmd.CreateVarVec(this.MapVars(vars));
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x00092F7C File Offset: 0x0009117C
		private global::System.Data.Entity.Core.Query.InternalTrees.VarList Copy(global::System.Data.Entity.Core.Query.InternalTrees.VarList varList)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList(this.MapVars(varList));
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00092F8A File Offset: 0x0009118A
		private global::System.Data.Entity.Core.Query.InternalTrees.SortKey Copy(global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(this.GetMappedVar(sortKey.Var), sortKey.AscendingSort, sortKey.Collation);
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x00092FAC File Offset: 0x000911AC
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> Copy(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in sortKeys)
			{
				list.Add(this.Copy(sortKey));
			}
			return list;
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x00093008 File Offset: 0x00091208
		protected global::System.Data.Entity.Core.Query.InternalTrees.Node CopyNode(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return n.Op.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Node>(this, n);
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x00093018 File Offset: 0x00091218
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> ProcessChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				list.Add(this.CopyNode(n2));
			}
			return list;
		}

		// Token: 0x06002E49 RID: 11849 RVA: 0x00093078 File Offset: 0x00091278
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CopyDefault(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node original)
		{
			return this.m_destCmd.CreateNode(op, this.ProcessChildren(original));
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x0009308D File Offset: 0x0009128D
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.Iqt_General_UnsupportedOp(op.GetType().FullName));
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000930A4 File Offset: 0x000912A4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op2 = this.m_destCmd.CreateConstantOp(op.Type, op.Value);
			return this.m_destCmd.CreateNode(op2);
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x000930D5 File Offset: 0x000912D5
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.m_destCmd.CreateNode(this.m_destCmd.CreateNullOp(op.Type));
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x000930F3 File Offset: 0x000912F3
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.m_destCmd.CreateNode(this.m_destCmd.CreateConstantPredicateOp(op.Value));
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00093114 File Offset: 0x00091314
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp op2 = this.m_destCmd.CreateInternalConstantOp(op.Type, op.Value);
			return this.m_destCmd.CreateNode(op2);
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x00093148 File Offset: 0x00091348
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp op2 = this.m_destCmd.CreateNullSentinelOp();
			return this.m_destCmd.CreateNode(op2);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x0009316D File Offset: 0x0009136D
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateFunctionOp(op.Function), n);
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x00093187 File Offset: 0x00091387
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreatePropertyOp(op.PropertyInfo), n);
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x000931A1 File Offset: 0x000913A1
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateRelPropertyOp(op.PropertyInfo), n);
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x000931BB File Offset: 0x000913BB
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateCaseOp(op.Type), n);
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x000931D5 File Offset: 0x000913D5
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateComparisonOp(op.OpType, op.UseDatabaseNullSemantics), n);
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000931F5 File Offset: 0x000913F5
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.LikeOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateLikeOp(), n);
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00093209 File Offset: 0x00091409
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateAggregateOp(op.AggFunc, op.IsDistinctAggregate), n);
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00093229 File Offset: 0x00091429
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateNewInstanceOp(op.Type), n);
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00093244 File Offset: 0x00091444
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp op2;
			if (op.Scoped)
			{
				op2 = this.m_destCmd.CreateScopedNewEntityOp(op.Type, op.RelationshipProperties, op.EntitySet);
			}
			else
			{
				op2 = this.m_destCmd.CreateNewEntityOp(op.Type, op.RelationshipProperties);
			}
			return this.CopyDefault(op2, n);
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00093299 File Offset: 0x00091499
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateDiscriminatedNewEntityOp(op.Type, op.DiscriminatorMap, op.EntitySet, op.RelationshipProperties), n);
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x000932C5 File Offset: 0x000914C5
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateNewMultisetOp(op.Type), n);
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x000932DF File Offset: 0x000914DF
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateNewRecordOp(op.Type), n);
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000932F9 File Offset: 0x000914F9
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateRefOp(op.EntitySet, op.Type), n);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x0009331C File Offset: 0x0009151C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var var;
			if (!this.m_varMap.TryGetValue(op.Var, out var))
			{
				var = op.Var;
			}
			return this.m_destCmd.CreateNode(this.m_destCmd.CreateVarRefOp(var));
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x0009335C File Offset: 0x0009155C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateConditionalOp(op.OpType), n);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00093376 File Offset: 0x00091576
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ArithmeticOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateArithmeticOp(op.OpType, op.Type), n);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00093398 File Offset: 0x00091598
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.TreatOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.TreatOp op2 = op.IsFakeTreat ? this.m_destCmd.CreateFakeTreatOp(op.Type) : this.m_destCmd.CreateTreatOp(op.Type);
			return this.CopyDefault(op2, n);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000933DA File Offset: 0x000915DA
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateCastOp(op.Type), n);
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000933F4 File Offset: 0x000915F4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateSoftCastOp(op.Type), n);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x0009340E File Offset: 0x0009160E
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DerefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateDerefOp(op.Type), n);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00093428 File Offset: 0x00091628
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateNavigateOp(op.Type, op.RelProperty), n);
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00093448 File Offset: 0x00091648
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.IsOfOnly)
			{
				return this.CopyDefault(this.m_destCmd.CreateIsOfOnlyOp(op.IsOfType), n);
			}
			return this.CopyDefault(this.m_destCmd.CreateIsOfOp(op.IsOfType), n);
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00093483 File Offset: 0x00091683
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateExistsOp(), n);
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00093497 File Offset: 0x00091697
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ElementOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateElementOp(op.Type), n);
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000934B1 File Offset: 0x000916B1
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateGetRefKeyOp(op.Type), n);
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x000934CB File Offset: 0x000916CB
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateGetEntityRefOp(op.Type), n);
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000934E5 File Offset: 0x000916E5
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateCollectOp(op.Type), n);
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00093500 File Offset: 0x00091700
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = this.m_destCmd.CreateScanTableOp(op.Table.TableMetadata);
			this.MapTable(scanTableOp.Table, op.Table);
			return this.m_destCmd.CreateNode(scanTableOp);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x00093544 File Offset: 0x00091744
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp scanViewOp = this.m_destCmd.CreateScanViewOp(op.Table.TableMetadata);
			this.MapTable(scanViewOp.Table, op.Table);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			return this.m_destCmd.CreateNode(scanViewOp, args);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00093590 File Offset: 0x00091790
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var mappedVar = this.GetMappedVar(op.Var);
			global::System.Data.Entity.Core.Query.InternalTrees.Table t = this.m_destCmd.CreateTableInstance(op.Table.TableMetadata);
			global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp unnestOp = this.m_destCmd.CreateUnnestOp(mappedVar, t);
			this.MapTable(unnestOp.Table, op.Table);
			return this.m_destCmd.CreateNode(unnestOp, args);
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000935F8 File Offset: 0x000917F8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars = this.Copy(op.Outputs);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op2 = this.m_destCmd.CreateProjectOp(vars);
			return this.m_destCmd.CreateNode(op2, args);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00093634 File Offset: 0x00091834
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.FilterOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateFilterOp(), n);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00093648 File Offset: 0x00091848
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys = this.Copy(op.Keys);
			global::System.Data.Entity.Core.Query.InternalTrees.SortOp op2 = this.m_destCmd.CreateSortOp(sortKeys);
			return this.m_destCmd.CreateNode(op2, args);
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00093684 File Offset: 0x00091884
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys = this.Copy(op.Keys);
			global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op2 = this.m_destCmd.CreateConstrainedSortOp(sortKeys, op.WithTies);
			return this.m_destCmd.CreateNode(op2, args);
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000936C8 File Offset: 0x000918C8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op2 = this.m_destCmd.CreateGroupByOp(this.Copy(op.Keys), this.Copy(op.Outputs));
			return this.m_destCmd.CreateNode(op2, args);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00093710 File Offset: 0x00091910
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op2 = this.m_destCmd.CreateGroupByIntoOp(this.Copy(op.Keys), this.Copy(op.Inputs), this.Copy(op.Outputs));
			return this.m_destCmd.CreateNode(op2, args);
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x00093762 File Offset: 0x00091962
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateCrossJoinOp(), n);
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00093776 File Offset: 0x00091976
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateInnerJoinOp(), n);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x0009378A File Offset: 0x0009198A
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateLeftOuterJoinOp(), n);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x0009379E File Offset: 0x0009199E
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateFullOuterJoinOp(), n);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000937B2 File Offset: 0x000919B2
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateCrossApplyOp(), n);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000937C6 File Offset: 0x000919C6
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateOuterApplyOp(), n);
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000937DC File Offset: 0x000919DC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CopySetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap2 = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in op.VarMap[0])
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = this.m_destCmd.CreateSetOpVar(keyValuePair.Key.Type);
				this.SetMappedVar(keyValuePair.Key, var);
				varMap.Add(var, this.GetMappedVar(keyValuePair.Value));
				varMap2.Add(var, this.GetMappedVar(op.VarMap[1][keyValuePair.Key]));
			}
			global::System.Data.Entity.Core.Query.InternalTrees.SetOp op2 = null;
			switch (op.OpType)
			{
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll:
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var var2 = ((global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp)op).BranchDiscriminator;
				if (var2 != null)
				{
					var2 = this.GetMappedVar(var2);
				}
				op2 = this.m_destCmd.CreateUnionAllOp(varMap, varMap2, var2);
				break;
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect:
				op2 = this.m_destCmd.CreateIntersectOp(varMap, varMap2);
				break;
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except:
				op2 = this.m_destCmd.CreateExceptOp(varMap, varMap2);
				break;
			}
			return this.m_destCmd.CreateNode(op2, args);
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00093918 File Offset: 0x00091B18
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopySetOp(op, n);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x00093922 File Offset: 0x00091B22
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopySetOp(op, n);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x0009392C File Offset: 0x00091B2C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopySetOp(op, n);
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00093938 File Offset: 0x00091B38
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVars = this.Copy(op.Keys);
			global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op2 = this.m_destCmd.CreateDistinctOp(keyVars);
			return this.m_destCmd.CreateNode(op2, args);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00093974 File Offset: 0x00091B74
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateSingleRowOp(), n);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00093988 File Offset: 0x00091B88
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateSingleRowTableOp(), n);
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x0009399C File Offset: 0x00091B9C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = this.m_destCmd.CreateComputedVar(op.Var.Type);
			this.SetMappedVar(op.Var, var);
			return this.m_destCmd.CreateNode(this.m_destCmd.CreateVarDefOp(var), args);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000939ED File Offset: 0x00091BED
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.CopyDefault(this.m_destCmd.CreateVarDefListOp(), n);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00093A01 File Offset: 0x00091C01
		private global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap Copy(global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.ColumnMapCopier.Copy(columnMap, this.m_varMap);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00093A10 File Offset: 0x00091C10
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarList outputVars = this.Copy(op.Outputs);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap = this.Copy(op.ColumnMap) as global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap;
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op2 = this.m_destCmd.CreatePhysicalProjectOp(outputVars, columnMap);
			return this.m_destCmd.CreateNode(op2, args);
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00093A60 File Offset: 0x00091C60
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitNestOp(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp nestBaseOp = n.Op as global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp;
			global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp singleStreamNestOp = nestBaseOp as global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args = this.ProcessChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var discriminatorVar = null;
			if (singleStreamNestOp != null)
			{
				discriminatorVar = this.GetMappedVar(singleStreamNestOp.Discriminator);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo collectionInfo in nestBaseOp.CollectionInfo)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap = this.Copy(collectionInfo.ColumnMap);
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = this.m_destCmd.CreateComputedVar(collectionInfo.CollectionVar.Type);
				this.SetMappedVar(collectionInfo.CollectionVar, var);
				global::System.Data.Entity.Core.Query.InternalTrees.VarList flattenedElementVars = this.Copy(collectionInfo.FlattenedElementVars);
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys = this.Copy(collectionInfo.Keys);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys = this.Copy(collectionInfo.SortKeys);
				global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo item = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateCollectionInfo(var, columnMap, flattenedElementVars, keys, sortKeys, collectionInfo.DiscriminatorValue);
				list.Add(item);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVars = this.Copy(nestBaseOp.Outputs);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> prefixSortKeys = this.Copy(nestBaseOp.PrefixSortKeys);
			global::System.Data.Entity.Core.Query.InternalTrees.NestBaseOp op;
			if (singleStreamNestOp != null)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys2 = this.Copy(singleStreamNestOp.Keys);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> postfixSortKeys = this.Copy(singleStreamNestOp.PostfixSortKeys);
				op = this.m_destCmd.CreateSingleStreamNestOp(keys2, prefixSortKeys, postfixSortKeys, outputVars, list, discriminatorVar);
			}
			else
			{
				op = this.m_destCmd.CreateMultiStreamNestOp(prefixSortKeys, outputVars, list);
			}
			return this.m_destCmd.CreateNode(op, args);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00093BE8 File Offset: 0x00091DE8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitNestOp(n);
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x00093BF1 File Offset: 0x00091DF1
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitNestOp(n);
		}

		// Token: 0x04000F65 RID: 3941
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_srcCmd;

		// Token: 0x04000F66 RID: 3942
		protected global::System.Data.Entity.Core.Query.InternalTrees.Command m_destCmd;

		// Token: 0x04000F67 RID: 3943
		protected global::System.Data.Entity.Core.Query.InternalTrees.VarMap m_varMap;
	}
}
