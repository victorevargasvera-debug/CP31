using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.PlanCompiler;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200038E RID: 910
	internal class Command
	{
		// Token: 0x06002C20 RID: 11296 RVA: 0x0008E178 File Offset: 0x0008C378
		internal Command(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace)
		{
			this.m_parameterMap = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar>();
			this.m_vars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			this.m_tables = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Table>();
			this.m_metadataWorkspace = metadataWorkspace;
			if (!global::System.Data.Entity.Core.Query.InternalTrees.Command.TryGetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, out this.m_boolType))
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.Cqt_General_NoProviderBooleanType);
			}
			if (!global::System.Data.Entity.Core.Query.InternalTrees.Command.TryGetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32, out this.m_intType))
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.Cqt_General_NoProviderIntegerType);
			}
			if (!global::System.Data.Entity.Core.Query.InternalTrees.Command.TryGetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, out this.m_stringType))
			{
				throw new global::System.Data.Entity.Core.ProviderIncompatibleException(global::System.Data.Entity.Resources.Strings.Cqt_General_NoProviderStringType);
			}
			this.m_trueOp = new global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp(this.m_boolType, true);
			this.m_falseOp = new global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp(this.m_boolType, false);
			this.m_nodeInfoVisitor = new global::System.Data.Entity.Core.Query.InternalTrees.NodeInfoVisitor(this);
			this.m_keyPullupVisitor = new global::System.Data.Entity.Core.Query.PlanCompiler.KeyPullup(this);
			this.m_freeVarVecEnumerators = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.InternalTrees.VarVec.VarVecEnumerator>();
			this.m_freeVarVecs = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.InternalTrees.VarVec>();
			this.m_referencedRelProperties = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty>();
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x0008E268 File Offset: 0x0008C468
		internal Command()
		{
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002C22 RID: 11298 RVA: 0x0008E27B File Offset: 0x0008C47B
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace MetadataWorkspace
		{
			get
			{
				return this.m_metadataWorkspace;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x0008E283 File Offset: 0x0008C483
		// (set) Token: 0x06002C24 RID: 11300 RVA: 0x0008E28B File Offset: 0x0008C48B
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node Root { get; set; }

		// Token: 0x06002C25 RID: 11301 RVA: 0x0008E294 File Offset: 0x0008C494
		internal virtual void DisableVarVecEnumCaching()
		{
			this.m_disableVarVecEnumCaching = true;
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002C26 RID: 11302 RVA: 0x0008E2A0 File Offset: 0x0008C4A0
		internal virtual int NextBranchDiscriminatorValue
		{
			get
			{
				int nextBranchDiscriminatorValue = this.m_nextBranchDiscriminatorValue;
				this.m_nextBranchDiscriminatorValue = nextBranchDiscriminatorValue + 1;
				return nextBranchDiscriminatorValue;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x0008E2BE File Offset: 0x0008C4BE
		internal virtual int NextNodeId
		{
			get
			{
				return this.m_nextNodeId;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002C28 RID: 11304 RVA: 0x0008E2C6 File Offset: 0x0008C4C6
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage BooleanType
		{
			get
			{
				return this.m_boolType;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002C29 RID: 11305 RVA: 0x0008E2CE File Offset: 0x0008C4CE
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage IntegerType
		{
			get
			{
				return this.m_intType;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002C2A RID: 11306 RVA: 0x0008E2D6 File Offset: 0x0008C4D6
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage StringType
		{
			get
			{
				return this.m_stringType;
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x0008E2DE File Offset: 0x0008C4DE
		private static bool TryGetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind modelType, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			type = null;
			if (modelType == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String)
			{
				type = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.CreateStringTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace.GetModelPrimitiveType(modelType), false, false);
			}
			else
			{
				type = global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace.GetCanonicalModelTypeUsage(modelType);
			}
			return type != null;
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0008E308 File Offset: 0x0008C508
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.VarVec CreateVarVec()
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec;
			if (this.m_freeVarVecs.Count == 0)
			{
				varVec = new global::System.Data.Entity.Core.Query.InternalTrees.VarVec(this);
			}
			else
			{
				varVec = this.m_freeVarVecs.Pop();
				varVec.Clear();
			}
			return varVec;
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x0008E33E File Offset: 0x0008C53E
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.VarVec CreateVarVec(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.CreateVarVec();
			varVec.Set(v);
			return varVec;
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x0008E34D File Offset: 0x0008C54D
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.VarVec CreateVarVec(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> v)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.CreateVarVec();
			varVec.InitFrom(v);
			return varVec;
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x0008E35C File Offset: 0x0008C55C
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.VarVec CreateVarVec(global::System.Data.Entity.Core.Query.InternalTrees.VarVec v)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.CreateVarVec();
			varVec.InitFrom(v);
			return varVec;
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x0008E36B File Offset: 0x0008C56B
		internal virtual void ReleaseVarVec(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vec)
		{
			this.m_freeVarVecs.Push(vec);
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x0008E37C File Offset: 0x0008C57C
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.VarVec.VarVecEnumerator GetVarVecEnumerator(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vec)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec.VarVecEnumerator varVecEnumerator;
			if (this.m_disableVarVecEnumCaching || this.m_freeVarVecEnumerators.Count == 0)
			{
				varVecEnumerator = new global::System.Data.Entity.Core.Query.InternalTrees.VarVec.VarVecEnumerator(vec);
			}
			else
			{
				varVecEnumerator = this.m_freeVarVecEnumerators.Pop();
				varVecEnumerator.Init(vec);
			}
			return varVecEnumerator;
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x0008E3BB File Offset: 0x0008C5BB
		internal virtual void ReleaseVarVecEnumerator(global::System.Data.Entity.Core.Query.InternalTrees.VarVec.VarVecEnumerator enumerator)
		{
			if (!this.m_disableVarVecEnumCaching)
			{
				this.m_freeVarVecEnumerators.Push(enumerator);
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x0008E3D1 File Offset: 0x0008C5D1
		internal static global::System.Data.Entity.Core.Query.InternalTrees.VarList CreateVarList()
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.VarList();
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x0008E3D8 File Offset: 0x0008C5D8
		internal static global::System.Data.Entity.Core.Query.InternalTrees.VarList CreateVarList(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> vars)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.VarList(vars);
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x0008E3E0 File Offset: 0x0008C5E0
		private int NewTableId()
		{
			return this.m_tables.Count;
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x0008E3ED File Offset: 0x0008C5ED
		internal static global::System.Data.Entity.Core.Query.InternalTrees.TableMD CreateTableDefinition(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementType)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.TableMD(elementType, null);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x0008E3F6 File Offset: 0x0008C5F6
		internal static global::System.Data.Entity.Core.Query.InternalTrees.TableMD CreateTableDefinition(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.TableMD(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(extent.ElementType), extent);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x0008E409 File Offset: 0x0008C609
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.TableMD CreateFlatTableDefinition(global::System.Data.Entity.Core.Metadata.Edm.RowType type)
		{
			return this.CreateFlatTableDefinition(type.Properties, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(), null);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x0008E41D File Offset: 0x0008C61D
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.TableMD CreateFlatTableDefinition(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> keyMembers, global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySet)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.TableMD(properties, keyMembers, entitySet);
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x0008E428 File Offset: 0x0008C628
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Table CreateTableInstance(global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Table table = new global::System.Data.Entity.Core.Query.InternalTrees.Table(this, tableMetadata, this.NewTableId());
			this.m_tables.Add(table);
			return table;
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x0008E450 File Offset: 0x0008C650
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> Vars
		{
			get
			{
				return from v in this.m_vars
				where v.VarType != global::System.Data.Entity.Core.Query.InternalTrees.VarType.NotValid
				select v;
			}
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x0008E47C File Offset: 0x0008C67C
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Var GetVar(int id)
		{
			return this.m_vars[id];
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x0008E48A File Offset: 0x0008C68A
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar GetParameter(string paramName)
		{
			return this.m_parameterMap[paramName];
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x0008E498 File Offset: 0x0008C698
		private int NewVarId()
		{
			return this.m_vars.Count;
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x0008E4A8 File Offset: 0x0008C6A8
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar CreateParameterVar(string parameterName, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage parameterType)
		{
			if (this.m_parameterMap.ContainsKey(parameterName))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DuplicateParameterName(parameterName));
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar parameterVar = new global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar(this.NewVarId(), parameterType, parameterName);
			this.m_vars.Add(parameterVar);
			this.m_parameterMap[parameterName] = parameterVar;
			return parameterVar;
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x0008E4F8 File Offset: 0x0008C6F8
		private global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar ReplaceParameterVar(global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar oldVar, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> generateReplacementType)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar parameterVar = new global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar(this.NewVarId(), generateReplacementType(oldVar.Type), oldVar.ParameterName);
			this.m_parameterMap[oldVar.ParameterName] = parameterVar;
			this.m_vars.Add(parameterVar);
			return parameterVar;
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x0008E542 File Offset: 0x0008C742
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar ReplaceEnumParameterVar(global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar oldVar)
		{
			return this.ReplaceParameterVar(oldVar, (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage t) => global::System.Data.Entity.Core.Common.TypeHelpers.CreateEnumUnderlyingTypeUsage(t));
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x0008E56A File Offset: 0x0008C76A
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar ReplaceStrongSpatialParameterVar(global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar oldVar)
		{
			return this.ReplaceParameterVar(oldVar, (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage t) => global::System.Data.Entity.Core.Common.TypeHelpers.CreateSpatialUnionTypeUsage(t));
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x0008E594 File Offset: 0x0008C794
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar CreateColumnVar(global::System.Data.Entity.Core.Query.InternalTrees.Table table, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMD columnMD)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar columnVar = new global::System.Data.Entity.Core.Query.InternalTrees.ColumnVar(this.NewVarId(), table, columnMD);
			table.Columns.Add(columnVar);
			this.m_vars.Add(columnVar);
			return columnVar;
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x0008E5C8 File Offset: 0x0008C7C8
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar CreateComputedVar(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar computedVar = new global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar(this.NewVarId(), type);
			this.m_vars.Add(computedVar);
			return computedVar;
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x0008E5F0 File Offset: 0x0008C7F0
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.SetOpVar CreateSetOpVar(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SetOpVar setOpVar = new global::System.Data.Entity.Core.Query.InternalTrees.SetOpVar(this.NewVarId(), type);
			this.m_vars.Add(setOpVar);
			return setOpVar;
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x0008E617 File Offset: 0x0008C817
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNode(global::System.Data.Entity.Core.Query.InternalTrees.Op op)
		{
			return this.CreateNode(op, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>());
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x0008E628 File Offset: 0x0008C828
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNode(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node arg1)
		{
			return this.CreateNode(op, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>
			{
				arg1
			});
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x0008E64C File Offset: 0x0008C84C
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNode(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node arg1, global::System.Data.Entity.Core.Query.InternalTrees.Node arg2)
		{
			return this.CreateNode(op, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>
			{
				arg1,
				arg2
			});
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x0008E678 File Offset: 0x0008C878
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNode(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node arg1, global::System.Data.Entity.Core.Query.InternalTrees.Node arg2, global::System.Data.Entity.Core.Query.InternalTrees.Node arg3)
		{
			return this.CreateNode(op, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>
			{
				arg1,
				arg2,
				arg3
			});
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x0008E6AC File Offset: 0x0008C8AC
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNode(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> args)
		{
			int nextNodeId = this.m_nextNodeId;
			this.m_nextNodeId = nextNodeId + 1;
			return new global::System.Data.Entity.Core.Query.InternalTrees.Node(nextNodeId, op, new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(args));
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x0008E6D8 File Offset: 0x0008C8D8
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNode(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> args)
		{
			int nextNodeId = this.m_nextNodeId;
			this.m_nextNodeId = nextNodeId + 1;
			return new global::System.Data.Entity.Core.Query.InternalTrees.Node(nextNodeId, op, args);
		}

		// Token: 0x06002C4C RID: 11340 RVA: 0x0008E6FD File Offset: 0x0008C8FD
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp CreateConstantOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, object value)
		{
			if (value == null)
			{
				return new global::System.Data.Entity.Core.Query.InternalTrees.NullOp(type);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsBooleanType(type))
			{
				return new global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp(type, value);
			}
			return new global::System.Data.Entity.Core.Query.InternalTrees.ConstantOp(type, value);
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x0008E720 File Offset: 0x0008C920
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp CreateInternalConstantOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, object value)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp(type, value);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0008E729 File Offset: 0x0008C929
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp CreateNullSentinelOp()
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp(this.IntegerType, 1);
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x0008E73C File Offset: 0x0008C93C
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NullOp CreateNullOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NullOp(type);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x0008E744 File Offset: 0x0008C944
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp CreateConstantPredicateOp(bool value)
		{
			if (!value)
			{
				return this.m_falseOp;
			}
			return this.m_trueOp;
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x0008E756 File Offset: 0x0008C956
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp CreateTrueOp()
		{
			return this.m_trueOp;
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x0008E75E File Offset: 0x0008C95E
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp CreateFalseOp()
		{
			return this.m_falseOp;
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0008E766 File Offset: 0x0008C966
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp CreateFunctionOp(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp(function);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x0008E76E File Offset: 0x0008C96E
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.TreatOp CreateTreatOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.TreatOp(type, false);
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x0008E777 File Offset: 0x0008C977
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.TreatOp CreateFakeTreatOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.TreatOp(type, true);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x0008E780 File Offset: 0x0008C980
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp CreateIsOfOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage isOfType)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp(isOfType, false, this.m_boolType);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x0008E78F File Offset: 0x0008C98F
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp CreateIsOfOnlyOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage isOfType)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp(isOfType, true, this.m_boolType);
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x0008E79E File Offset: 0x0008C99E
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.CastOp CreateCastOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.CastOp(type);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x0008E7A6 File Offset: 0x0008C9A6
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp CreateSoftCastOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp(type);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x0008E7AE File Offset: 0x0008C9AE
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, bool useDatabaseNullSemantics = false)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp(opType, this.BooleanType)
			{
				UseDatabaseNullSemantics = useDatabaseNullSemantics
			};
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x0008E7C3 File Offset: 0x0008C9C3
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.LikeOp CreateLikeOp()
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.LikeOp(this.BooleanType);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x0008E7D0 File Offset: 0x0008C9D0
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp(opType, this.BooleanType);
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x0008E7DE File Offset: 0x0008C9DE
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.CaseOp CreateCaseOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.CaseOp(type);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x0008E7E6 File Offset: 0x0008C9E6
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp CreateAggregateOp(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction aggFunc, bool distinctAgg)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.AggregateOp(aggFunc, distinctAgg);
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x0008E7EF File Offset: 0x0008C9EF
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp CreateNewInstanceOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp(type);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x0008E7F7 File Offset: 0x0008C9F7
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp CreateScopedNewEntityOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> relProperties, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp(type, relProperties, true, entitySet);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0008E802 File Offset: 0x0008CA02
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp CreateNewEntityOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> relProperties)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp(type, relProperties, false, null);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x0008E80D File Offset: 0x0008CA0D
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp CreateDiscriminatedNewEntityOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.InternalTrees.ExplicitDiscriminatorMap discriminatorMap, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> relProperties)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp(type, discriminatorMap, entitySet, relProperties);
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0008E819 File Offset: 0x0008CA19
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp CreateNewMultisetOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NewMultisetOp(type);
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x0008E821 File Offset: 0x0008CA21
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp CreateNewRecordOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp(type);
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x0008E829 File Offset: 0x0008CA29
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp CreateNewRecordOp(global::System.Data.Entity.Core.Metadata.Edm.RowType type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(type));
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x0008E836 File Offset: 0x0008CA36
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp CreateNewRecordOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> fields)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp(type, fields);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x0008E83F File Offset: 0x0008CA3F
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp CreateVarRefOp(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp(v);
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x0008E847 File Offset: 0x0008CA47
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ArithmeticOp CreateArithmeticOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ArithmeticOp(opType, type);
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x0008E850 File Offset: 0x0008CA50
		internal global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp CreatePropertyOp(global::System.Data.Entity.Core.Metadata.Edm.EdmMember prop)
		{
			global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = prop as global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty;
			if (navigationProperty != null)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty = new global::System.Data.Entity.Core.Query.InternalTrees.RelProperty(navigationProperty.RelationshipType, navigationProperty.FromEndMember, navigationProperty.ToEndMember);
				this.AddRelPropertyReference(relProperty);
				global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty2 = new global::System.Data.Entity.Core.Query.InternalTrees.RelProperty(navigationProperty.RelationshipType, navigationProperty.ToEndMember, navigationProperty.FromEndMember);
				this.AddRelPropertyReference(relProperty2);
			}
			return new global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(prop), prop);
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x0008E8B1 File Offset: 0x0008CAB1
		internal global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp CreateRelPropertyOp(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty prop)
		{
			this.AddRelPropertyReference(prop);
			return new global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp(prop.ToEnd.TypeUsage, prop);
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x0008E8CB File Offset: 0x0008CACB
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.RefOp CreateRefOp(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.RefOp(entitySet, type);
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0008E8D4 File Offset: 0x0008CAD4
		internal global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp CreateExistsOp()
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ExistsOp(this.BooleanType);
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x0008E8E1 File Offset: 0x0008CAE1
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ElementOp CreateElementOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ElementOp(type);
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x0008E8E9 File Offset: 0x0008CAE9
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp CreateGetEntityRefOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp(type);
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x0008E8F1 File Offset: 0x0008CAF1
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp CreateGetRefKeyOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp(type);
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x0008E8F9 File Offset: 0x0008CAF9
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.CollectOp CreateCollectOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.CollectOp(type);
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x0008E901 File Offset: 0x0008CB01
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.DerefOp CreateDerefOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.DerefOp(type);
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x0008E909 File Offset: 0x0008CB09
		internal global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp CreateNavigateOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty)
		{
			this.AddRelPropertyReference(relProperty);
			return new global::System.Data.Entity.Core.Query.InternalTrees.NavigateOp(type, relProperty);
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x0008E919 File Offset: 0x0008CB19
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp CreateVarDefListOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp.Instance;
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x0008E920 File Offset: 0x0008CB20
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp CreateVarDefOp(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp(v);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x0008E928 File Offset: 0x0008CB28
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node CreateVarDefNode(global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr, out global::System.Data.Entity.Core.Query.InternalTrees.Var computedVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp scalarOp = definingExpr.Op as global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp;
			computedVar = this.CreateComputedVar(scalarOp.Type);
			global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op = this.CreateVarDefOp(computedVar);
			return this.CreateNode(op, definingExpr);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x0008E960 File Offset: 0x0008CB60
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node CreateVarDefListNode(global::System.Data.Entity.Core.Query.InternalTrees.Node definingExpr, out global::System.Data.Entity.Core.Query.InternalTrees.Var computedVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.CreateVarDefNode(definingExpr, out computedVar);
			global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op = this.CreateVarDefListOp();
			return this.CreateNode(op, arg);
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x0008E988 File Offset: 0x0008CB88
		internal global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp CreateScanTableOp(global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Table table = this.CreateTableInstance(tableMetadata);
			return this.CreateScanTableOp(table);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x0008E9A4 File Offset: 0x0008CBA4
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp CreateScanTableOp(global::System.Data.Entity.Core.Query.InternalTrees.Table table)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp(table);
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x0008E9AC File Offset: 0x0008CBAC
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp CreateScanViewOp(global::System.Data.Entity.Core.Query.InternalTrees.Table table)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp(table);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x0008E9B4 File Offset: 0x0008CBB4
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp CreateScanViewOp(global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Table table = this.CreateTableInstance(tableMetadata);
			return this.CreateScanViewOp(table);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x0008E9D0 File Offset: 0x0008CBD0
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp CreateUnnestOp(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Table t = this.CreateTableInstance(global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateTableDefinition(global::System.Data.Entity.Core.Common.TypeHelpers.GetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(v.Type).TypeUsage));
			return this.CreateUnnestOp(v, t);
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0008EA01 File Offset: 0x0008CC01
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp CreateUnnestOp(global::System.Data.Entity.Core.Query.InternalTrees.Var v, global::System.Data.Entity.Core.Query.InternalTrees.Table t)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp(v, t);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x0008EA0A File Offset: 0x0008CC0A
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.FilterOp CreateFilterOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.FilterOp.Instance;
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x0008EA11 File Offset: 0x0008CC11
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp CreateProjectOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec vars)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp(vars);
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x0008EA19 File Offset: 0x0008CC19
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp CreateProjectOp(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.CreateVarVec();
			varVec.Set(v);
			return new global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp(varVec);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x0008EA2D File Offset: 0x0008CC2D
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp CreateInnerJoinOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.InnerJoinOp.Instance;
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x0008EA34 File Offset: 0x0008CC34
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp CreateLeftOuterJoinOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.LeftOuterJoinOp.Instance;
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x0008EA3B File Offset: 0x0008CC3B
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp CreateFullOuterJoinOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.FullOuterJoinOp.Instance;
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0008EA42 File Offset: 0x0008CC42
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp CreateCrossJoinOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.CrossJoinOp.Instance;
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0008EA49 File Offset: 0x0008CC49
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp CreateCrossApplyOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.CrossApplyOp.Instance;
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x0008EA50 File Offset: 0x0008CC50
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp CreateOuterApplyOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.OuterApplyOp.Instance;
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x0008EA57 File Offset: 0x0008CC57
		internal static global::System.Data.Entity.Core.Query.InternalTrees.SortKey CreateSortKey(global::System.Data.Entity.Core.Query.InternalTrees.Var v, bool asc, string collation)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.SortKey(v, asc, collation);
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x0008EA61 File Offset: 0x0008CC61
		internal static global::System.Data.Entity.Core.Query.InternalTrees.SortKey CreateSortKey(global::System.Data.Entity.Core.Query.InternalTrees.Var v, bool asc)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.SortKey(v, asc, "");
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x0008EA6F File Offset: 0x0008CC6F
		internal static global::System.Data.Entity.Core.Query.InternalTrees.SortKey CreateSortKey(global::System.Data.Entity.Core.Query.InternalTrees.Var v)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.SortKey(v, true, "");
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x0008EA7D File Offset: 0x0008CC7D
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.SortOp CreateSortOp(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.SortOp(sortKeys);
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x0008EA85 File Offset: 0x0008CC85
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp CreateConstrainedSortOp(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp(sortKeys, false);
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x0008EA8E File Offset: 0x0008CC8E
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp CreateConstrainedSortOp(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys, bool withTies)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp(sortKeys, withTies);
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x0008EA97 File Offset: 0x0008CC97
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp CreateGroupByOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec gbyKeys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp(gbyKeys, outputs);
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x0008EAA0 File Offset: 0x0008CCA0
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp CreateGroupByIntoOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec gbyKeys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec inputs, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp(gbyKeys, inputs, outputs);
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x0008EAAA File Offset: 0x0008CCAA
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp CreateDistinctOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVars)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp(keyVars);
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x0008EAB2 File Offset: 0x0008CCB2
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp CreateDistinctOp(global::System.Data.Entity.Core.Query.InternalTrees.Var keyVar)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp(this.CreateVarVec(keyVar));
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x0008EAC0 File Offset: 0x0008CCC0
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp CreateUnionAllOp(global::System.Data.Entity.Core.Query.InternalTrees.VarMap leftMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap rightMap)
		{
			return this.CreateUnionAllOp(leftMap, rightMap, null);
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x0008EACC File Offset: 0x0008CCCC
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp CreateUnionAllOp(global::System.Data.Entity.Core.Query.InternalTrees.VarMap leftMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap rightMap, global::System.Data.Entity.Core.Query.InternalTrees.Var branchDiscriminator)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in leftMap.Keys)
			{
				varVec.Set(v);
			}
			return new global::System.Data.Entity.Core.Query.InternalTrees.UnionAllOp(varVec, leftMap, rightMap, branchDiscriminator);
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x0008EB2C File Offset: 0x0008CD2C
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp CreateIntersectOp(global::System.Data.Entity.Core.Query.InternalTrees.VarMap leftMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap rightMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in leftMap.Keys)
			{
				varVec.Set(v);
			}
			return new global::System.Data.Entity.Core.Query.InternalTrees.IntersectOp(varVec, leftMap, rightMap);
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x0008EB88 File Offset: 0x0008CD88
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp CreateExceptOp(global::System.Data.Entity.Core.Query.InternalTrees.VarMap leftMap, global::System.Data.Entity.Core.Query.InternalTrees.VarMap rightMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.CreateVarVec();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in leftMap.Keys)
			{
				varVec.Set(v);
			}
			return new global::System.Data.Entity.Core.Query.InternalTrees.ExceptOp(varVec, leftMap, rightMap);
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x0008EBE4 File Offset: 0x0008CDE4
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp CreateSingleRowOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.SingleRowOp.Instance;
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x0008EBEB File Offset: 0x0008CDEB
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp CreateSingleRowTableOp()
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.SingleRowTableOp.Instance;
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0008EBF2 File Offset: 0x0008CDF2
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp CreatePhysicalProjectOp(global::System.Data.Entity.Core.Query.InternalTrees.VarList outputVars, global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp(outputVars, columnMap);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x0008EBFC File Offset: 0x0008CDFC
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp CreatePhysicalProjectOp(global::System.Data.Entity.Core.Query.InternalTrees.Var outputVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarList varList = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList();
			varList.Add(outputVar);
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap varRefColumnMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap(outputVar);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap = new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.CreateCollectionType(varRefColumnMap.Type), null, varRefColumnMap, new global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[0], new global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[0]);
			return this.CreatePhysicalProjectOp(varList, columnMap);
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x0008EC44 File Offset: 0x0008CE44
		internal static global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo CreateCollectionInfo(global::System.Data.Entity.Core.Query.InternalTrees.Var collectionVar, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap, global::System.Data.Entity.Core.Query.InternalTrees.VarList flattenedElementVars, global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys, object discriminatorValue)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo(collectionVar, columnMap, flattenedElementVars, keys, sortKeys, discriminatorValue);
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x0008EC53 File Offset: 0x0008CE53
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp CreateSingleStreamNestOp(global::System.Data.Entity.Core.Query.InternalTrees.VarVec keys, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> prefixSortKeys, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> postfixSortKeys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> collectionInfoList, global::System.Data.Entity.Core.Query.InternalTrees.Var discriminatorVar)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.SingleStreamNestOp(keys, prefixSortKeys, postfixSortKeys, outputVars, collectionInfoList, discriminatorVar);
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x0008EC63 File Offset: 0x0008CE63
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp CreateMultiStreamNestOp(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> prefixSortKeys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> collectionInfoList)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.MultiStreamNestOp(prefixSortKeys, outputVars, collectionInfoList);
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x0008EC6D File Offset: 0x0008CE6D
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.NodeInfo GetNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return n.GetNodeInfo(this);
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x0008EC76 File Offset: 0x0008CE76
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.ExtendedNodeInfo GetExtendedNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return n.GetExtendedNodeInfo(this);
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x0008EC7F File Offset: 0x0008CE7F
		internal virtual void RecomputeNodeInfo(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.m_nodeInfoVisitor.RecomputeNodeInfo(n);
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x0008EC8D File Offset: 0x0008CE8D
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.KeyVec PullupKeys(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.m_keyPullupVisitor.GetKeys(n);
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x0008EC9B File Offset: 0x0008CE9B
		internal static bool EqualTypes(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage x, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage y)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.TypeUsageEqualityComparer.Instance.Equals(x, y);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x0008ECA9 File Offset: 0x0008CEA9
		internal static bool EqualTypes(global::System.Data.Entity.Core.Metadata.Edm.EdmType x, global::System.Data.Entity.Core.Metadata.Edm.EdmType y)
		{
			return global::System.Data.Entity.Core.Query.PlanCompiler.TypeUsageEqualityComparer.Equals(x, y);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x0008ECB4 File Offset: 0x0008CEB4
		internal virtual void BuildUnionAllLadder(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> inputNodes, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Var> inputVars, out global::System.Data.Entity.Core.Query.InternalTrees.Node resultNode, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Var> resultVars)
		{
			if (inputNodes.Count == 0)
			{
				resultNode = null;
				resultVars = null;
				return;
			}
			int num = inputVars.Count / inputNodes.Count;
			if (inputNodes.Count == 1)
			{
				resultNode = inputNodes[0];
				resultVars = inputVars;
				return;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = inputNodes[0];
			for (int i = 0; i < num; i++)
			{
				list.Add(inputVars[i]);
			}
			for (int j = 1; j < inputNodes.Count; j++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
				global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap2 = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
				for (int k = 0; k < num; k++)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.SetOpVar setOpVar = this.CreateSetOpVar(list[k].Type);
					list2.Add(setOpVar);
					varMap.Add(setOpVar, list[k]);
					varMap2.Add(setOpVar, inputVars[j * num + k]);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Op op = this.CreateUnionAllOp(varMap, varMap2);
				node = this.CreateNode(op, node, inputNodes[j]);
				list = list2;
			}
			resultNode = node;
			resultVars = list;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x0008EDCC File Offset: 0x0008CFCC
		internal virtual void BuildUnionAllLadder(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Node> inputNodes, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Var> inputVars, out global::System.Data.Entity.Core.Query.InternalTrees.Node resultNode, out global::System.Data.Entity.Core.Query.InternalTrees.Var resultVar)
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Query.InternalTrees.Var> list;
			this.BuildUnionAllLadder(inputNodes, inputVars, out resultNode, out list);
			if (list != null && list.Count > 0)
			{
				resultVar = list[0];
				return;
			}
			resultVar = null;
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0008EE00 File Offset: 0x0008D000
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node BuildProject(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> inputVars, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Node> computedExpressions)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op = this.CreateVarDefListOp();
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.CreateNode(op);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.CreateVarVec(inputVars);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node2 in computedExpressions)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Var v = this.CreateComputedVar(node2.Op.Type);
				varVec.Set(v);
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op2 = this.CreateVarDefOp(v);
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.CreateNode(op2, node2);
				node.Children.Add(item);
			}
			return this.CreateNode(this.CreateProjectOp(varVec), inputNode, node);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x0008EEA8 File Offset: 0x0008D0A8
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node BuildProject(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Data.Entity.Core.Query.InternalTrees.Node computedExpression, out global::System.Data.Entity.Core.Query.InternalTrees.Var projectVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.BuildProject(input, new global::System.Data.Entity.Core.Query.InternalTrees.Var[0], new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				computedExpression
			});
			projectVar = ((global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)node.Op).Outputs.First;
			return node;
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x0008EEE8 File Offset: 0x0008D0E8
		internal virtual void BuildOfTypeTree(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, global::System.Data.Entity.Core.Query.InternalTrees.Var inputVar, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage desiredType, bool includeSubtypes, out global::System.Data.Entity.Core.Query.InternalTrees.Node resultNode, out global::System.Data.Entity.Core.Query.InternalTrees.Var resultVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = includeSubtypes ? this.CreateIsOfOp(desiredType) : this.CreateIsOfOnlyOp(desiredType);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.CreateNode(op, this.CreateNode(this.CreateVarRefOp(inputVar)));
			global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode2 = this.CreateNode(this.CreateFilterOp(), inputNode, arg);
			resultNode = this.BuildFakeTreatProject(inputNode2, inputVar, desiredType, out resultVar);
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x0008EF3C File Offset: 0x0008D13C
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node BuildFakeTreatProject(global::System.Data.Entity.Core.Query.InternalTrees.Node inputNode, global::System.Data.Entity.Core.Query.InternalTrees.Var inputVar, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage desiredType, out global::System.Data.Entity.Core.Query.InternalTrees.Var resultVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node computedExpression = this.CreateNode(this.CreateFakeTreatOp(desiredType), this.CreateNode(this.CreateVarRefOp(inputVar)));
			return this.BuildProject(inputNode, computedExpression, out resultVar);
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x0008EF70 File Offset: 0x0008D170
		internal global::System.Data.Entity.Core.Query.InternalTrees.Node BuildComparison(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Query.InternalTrees.Node arg0, global::System.Data.Entity.Core.Query.InternalTrees.Node arg1, bool useDatabaseNullSemantics = false)
		{
			if (!global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(arg0.Op.Type, arg1.Op.Type))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage commonTypeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.GetCommonTypeUsage(arg0.Op.Type, arg1.Op.Type);
				if (!global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(commonTypeUsage, arg0.Op.Type))
				{
					arg0 = this.CreateNode(this.CreateSoftCastOp(commonTypeUsage), arg0);
				}
				if (!global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(commonTypeUsage, arg1.Op.Type))
				{
					arg1 = this.CreateNode(this.CreateSoftCastOp(commonTypeUsage), arg1);
				}
			}
			return this.CreateNode(this.CreateComparisonOp(opType, useDatabaseNullSemantics), arg0, arg1);
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x0008F010 File Offset: 0x0008D210
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.Node BuildCollect(global::System.Data.Entity.Core.Query.InternalTrees.Node relOpNode, global::System.Data.Entity.Core.Query.InternalTrees.Var relOpVar)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.CreateNode(this.CreatePhysicalProjectOp(relOpVar), relOpNode);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = global::System.Data.Entity.Core.Common.TypeHelpers.CreateCollectionTypeUsage(relOpVar.Type);
			return this.CreateNode(this.CreateCollectOp(type), arg);
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x0008F046 File Offset: 0x0008D246
		private void AddRelPropertyReference(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty)
		{
			if (relProperty.ToEnd.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many && !this.m_referencedRelProperties.Contains(relProperty))
			{
				this.m_referencedRelProperties.Add(relProperty);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x0008F071 File Offset: 0x0008D271
		internal virtual global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> ReferencedRelProperties
		{
			get
			{
				return this.m_referencedRelProperties;
			}
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0008F079 File Offset: 0x0008D279
		internal virtual bool IsRelPropertyReferenced(global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty)
		{
			return this.m_referencedRelProperties.Contains(relProperty);
		}

		// Token: 0x04000EF2 RID: 3826
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar> m_parameterMap;

		// Token: 0x04000EF3 RID: 3827
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> m_vars;

		// Token: 0x04000EF4 RID: 3828
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Table> m_tables;

		// Token: 0x04000EF5 RID: 3829
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace m_metadataWorkspace;

		// Token: 0x04000EF6 RID: 3830
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_boolType;

		// Token: 0x04000EF7 RID: 3831
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_intType;

		// Token: 0x04000EF8 RID: 3832
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_stringType;

		// Token: 0x04000EF9 RID: 3833
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp m_trueOp;

		// Token: 0x04000EFA RID: 3834
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ConstantPredicateOp m_falseOp;

		// Token: 0x04000EFB RID: 3835
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.NodeInfoVisitor m_nodeInfoVisitor;

		// Token: 0x04000EFC RID: 3836
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.KeyPullup m_keyPullupVisitor;

		// Token: 0x04000EFD RID: 3837
		private int m_nextNodeId;

		// Token: 0x04000EFE RID: 3838
		private int m_nextBranchDiscriminatorValue = 1000;

		// Token: 0x04000EFF RID: 3839
		private bool m_disableVarVecEnumCaching;

		// Token: 0x04000F00 RID: 3840
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.InternalTrees.VarVec.VarVecEnumerator> m_freeVarVecEnumerators;

		// Token: 0x04000F01 RID: 3841
		private readonly global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Query.InternalTrees.VarVec> m_freeVarVecs;

		// Token: 0x04000F02 RID: 3842
		private readonly global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Query.InternalTrees.RelProperty> m_referencedRelProperties;
	}
}
