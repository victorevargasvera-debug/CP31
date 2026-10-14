using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Query.InternalTrees;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000351 RID: 849
	internal class NominalTypeEliminator : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfNode
	{
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x0007F785 File Offset: 0x0007D985
		private global::System.Data.Entity.Core.Query.InternalTrees.Command m_command
		{
			get
			{
				return this.m_compilerState.Command;
			}
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x0007F794 File Offset: 0x0007D994
		private NominalTypeEliminator(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState, global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo typeInfo, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> varPropertyMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> nodePropertyMap, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]> tvfResultKeys)
		{
			this.m_compilerState = compilerState;
			this.m_typeInfo = typeInfo;
			this.m_varPropertyMap = varPropertyMap;
			this.m_nodePropertyMap = nodePropertyMap;
			this.m_varInfoMap = new global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoMap();
			this.m_tvfResultKeys = tvfResultKeys;
			this.m_typeToNewTypeMap = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(global::System.Data.Entity.Core.Query.PlanCompiler.TypeUsageEqualityComparer.Instance);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x0007F7E8 File Offset: 0x0007D9E8
		internal static void Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState, global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo structuredTypeInfo, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]> tvfResultKeys)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> varPropertyMap;
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> nodePropertyMap;
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyPushdownHelper.Process(compilerState.Command, out varPropertyMap, out nodePropertyMap);
			new global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator(compilerState, structuredTypeInfo, varPropertyMap, nodePropertyMap, tvfResultKeys).Process();
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x0007F814 File Offset: 0x0007DA14
		private void Process()
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar parameterVar in (from v in this.m_command.Vars.OfType<global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar>()
			where global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(v.Type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(v.Type)
			select v).ToArray<global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar>())
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ParameterVar newVar = global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(parameterVar.Type) ? this.m_command.ReplaceEnumParameterVar(parameterVar) : this.m_command.ReplaceStrongSpatialParameterVar(parameterVar);
				this.m_varInfoMap.CreatePrimitiveTypeVarInfo(parameterVar, newVar);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node root = this.m_command.Root;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(root.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.PhysicalProject, "root node is not PhysicalProjectOp?");
			root.Op.Accept<global::System.Data.Entity.Core.Query.InternalTrees.Node>(this, root);
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x0007F8D8 File Offset: 0x0007DAD8
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage DefaultTypeIdType
		{
			get
			{
				return this.m_command.StringType;
			}
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0007F8E8 File Offset: 0x0007DAE8
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetNewType(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
			if (this.m_typeToNewTypeMap.TryGetValue(type, out typeUsage))
			{
				return typeUsage;
			}
			global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.CollectionType>(type, out collectionType))
			{
				typeUsage = global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.CreateCollectionType(this.GetNewType(collectionType.TypeUsage));
			}
			else if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				typeUsage = this.m_typeInfo.GetTypeInfo(type).FlattenedTypeUsage;
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(type))
			{
				typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.CreateEnumUnderlyingTypeUsage(type);
			}
			else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(type))
			{
				typeUsage = global::System.Data.Entity.Core.Common.TypeHelpers.CreateSpatialUnionTypeUsage(type);
			}
			else
			{
				typeUsage = type;
			}
			this.m_typeToNewTypeMap[type] = typeUsage;
			return typeUsage;
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x0007F974 File Offset: 0x0007DB74
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildAccessor(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Op op = input.Op;
			global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp newRecordOp = op as global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp;
			if (newRecordOp != null)
			{
				int index;
				if (newRecordOp.GetFieldPosition(property, out index))
				{
					return this.Copy(input.Children[index]);
				}
				return null;
			}
			else
			{
				if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Null)
				{
					return null;
				}
				global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op2 = this.m_command.CreatePropertyOp(property);
				return this.m_command.CreateNode(op2, this.Copy(input));
			}
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0007F9E0 File Offset: 0x0007DBE0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildAccessorWithNulls(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.BuildAccessor(input, property);
			if (node == null)
			{
				node = this.CreateNullConstantNode(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(property));
			}
			return node;
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x0007FA08 File Offset: 0x0007DC08
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildTypeIdAccessor(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (typeInfo.HasTypeIdProperty)
			{
				result = this.BuildAccessorWithNulls(input, typeInfo.TypeIdProperty);
			}
			else
			{
				result = this.CreateTypeIdConstant(typeInfo);
			}
			return result;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0007FA38 File Offset: 0x0007DC38
		private global::System.Data.Entity.Core.Query.InternalTrees.Node BuildSoftCast(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage targetType)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.Op.IsScalarOp, "Attempting SoftCast around non-ScalarOp?");
			if (global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(node.Op.Type, targetType))
			{
				return node;
			}
			while (node.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.SoftCast)
			{
				node = node.Child0;
			}
			return this.m_command.CreateNode(this.m_command.CreateSoftCastOp(targetType), node);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0007FA9E File Offset: 0x0007DC9E
		private global::System.Data.Entity.Core.Query.InternalTrees.Node Copy(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.OpCopier.Copy(this.m_command, n);
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0007FAAC File Offset: 0x0007DCAC
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNullConstantNode(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			return this.m_command.CreateNode(this.m_command.CreateNullOp(type));
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0007FAC8 File Offset: 0x0007DCC8
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateNullSentinelConstant()
		{
			global::System.Data.Entity.Core.Query.InternalTrees.NullSentinelOp op = this.m_command.CreateNullSentinelOp();
			return this.m_command.CreateNode(op);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x0007FAF0 File Offset: 0x0007DCF0
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateTypeIdConstant(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			object typeId = typeInfo.TypeId;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type;
			if (typeInfo.RootType.DiscriminatorMap != null)
			{
				type = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(typeInfo.RootType.DiscriminatorMap.DiscriminatorProperty);
			}
			else
			{
				type = this.DefaultTypeIdType;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp op = this.m_command.CreateInternalConstantOp(type, typeId);
			return this.m_command.CreateNode(op);
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0007FB4C File Offset: 0x0007DD4C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateTypeIdConstantForPrefixMatch(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo)
		{
			object typeId = typeInfo.TypeId;
			string value = ((typeId != null) ? typeId.ToString() : null) + "%";
			global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp op = this.m_command.CreateInternalConstantOp(this.DefaultTypeIdType, value);
			return this.m_command.CreateNode(op);
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x0007FB95 File Offset: 0x0007DD95
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> GetPropertyRefsForComparisonAndIsNull(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind opKind)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.IsNull || opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.Equality, "Unexpected opKind: " + opKind.ToString() + "; Can only handle IsNull and Equality");
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = typeInfo.Type;
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = null;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RowType>(type, out rowType))
			{
				if (opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.IsNull && typeInfo.HasNullSentinelProperty)
				{
					yield return global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef.Instance;
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty i in rowType.Properties)
					{
						if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(i)))
						{
							yield return new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(i);
						}
						else
						{
							global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.m_typeInfo.GetTypeInfo(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(i));
							foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in this.GetPropertyRefs(typeInfo2, opKind))
							{
								global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef2 = propertyRef.CreateNestedPropertyRef(i);
								yield return propertyRef2;
							}
							global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> enumerator2 = null;
						}
						i = null;
					}
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator = default(global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator);
				}
				yield break;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = null;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(type, out entityType))
			{
				if (opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.Equality || (opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.IsNull && !typeInfo.HasTypeIdProperty))
				{
					foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef3 in typeInfo.GetIdentityPropertyRefs())
					{
						yield return propertyRef3;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> enumerator2 = null;
				}
				else
				{
					yield return global::System.Data.Entity.Core.Query.PlanCompiler.TypeIdPropertyRef.Instance;
				}
				yield break;
			}
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = null;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.ComplexType>(type, out complexType))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.IsNull, "complex types not equality-comparable");
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(typeInfo.HasNullSentinelProperty, "complex type with no null sentinel property: can't handle isNull");
				yield return global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef.Instance;
				yield break;
			}
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType = null;
			if (global::System.Data.Entity.Core.Common.TypeHelpers.TryGetEdmType<global::System.Data.Entity.Core.Metadata.Edm.RefType>(type, out refType))
			{
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef4 in typeInfo.GetAllPropertyRefs())
				{
					yield return propertyRef4;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> enumerator2 = null;
				yield break;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "Unknown type");
			yield break;
			yield break;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0007FBB3 File Offset: 0x0007DDB3
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> GetPropertyRefs(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind opKind)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(opKind != global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.All, "unexpected attempt to GetPropertyRefs(...,OperationKind.All)");
			if (opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.GetKeys)
			{
				return typeInfo.GetKeyPropertyRefs();
			}
			if (opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.GetIdentity)
			{
				return typeInfo.GetIdentityPropertyRefs();
			}
			return this.GetPropertyRefsForComparisonAndIsNull(typeInfo, opKind);
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0007FBE4 File Offset: 0x0007DDE4
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetProperties(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind opKind)
		{
			if (opKind == global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.All)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in typeInfo.GetAllProperties())
				{
					yield return edmProperty;
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = null;
			}
			else
			{
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in this.GetPropertyRefs(typeInfo, opKind))
				{
					yield return typeInfo.GetNewProperty(propertyRef);
				}
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> enumerator2 = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0007FC04 File Offset: 0x0007DE04
		private void GetPropertyValues(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind opKind, global::System.Data.Entity.Core.Query.InternalTrees.Node input, bool ignoreMissingProperties, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> values)
		{
			values = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			properties = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property in this.GetProperties(typeInfo, opKind))
			{
				global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node> propertyValue = this.GetPropertyValue(input, property, ignoreMissingProperties);
				if (propertyValue.Value != null)
				{
					properties.Add(propertyValue.Key);
					values.Add(propertyValue.Value);
				}
			}
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0007FC90 File Offset: 0x0007DE90
		private global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node> GetPropertyValue(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property, bool ignoreMissingProperties)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node value;
			if (!ignoreMissingProperties)
			{
				value = this.BuildAccessorWithNulls(input, property);
			}
			else
			{
				value = this.BuildAccessor(input, property);
			}
			return new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.InternalTrees.Node>(property, value);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0007FCC0 File Offset: 0x0007DEC0
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> HandleSortKeys(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> keys)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey>();
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SortKey sortKey in keys)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo;
				if (!this.m_varInfoMap.TryGetVarInfo(sortKey.Var, out varInfo))
				{
					list.Add(sortKey);
				}
				else
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo structuredVarInfo = varInfo as global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo;
					if (structuredVarInfo != null && structuredVarInfo.NewVarsIncludeNullSentinelVar)
					{
						this.m_compilerState.HasSortingOnNullSentinels = true;
					}
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in varInfo.NewVars)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.SortKey item = global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateSortKey(v, sortKey.AscendingSort, sortKey.Collation);
						list.Add(item);
					}
					flag = true;
				}
			}
			if (!flag)
			{
				return keys;
			}
			return list;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0007FDB4 File Offset: 0x0007DFB4
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateTVFProjection(global::System.Data.Entity.Core.Query.InternalTrees.Node unnestNode, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> unnestOpTableColumns, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo unnestOpTableTypeInfo, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> newVars)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = unnestOpTableTypeInfo.Type.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RowType;
			bool condition = rowType != null;
			string str = "Unexpected TVF return type (must be row): ";
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = unnestOpTableTypeInfo.Type;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(condition, str + ((type != null) ? type.ToString() : null));
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef[] array = unnestOpTableTypeInfo.PropertyRefList.ToArray<global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef>();
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef>();
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in array)
			{
				dictionary.Add(unnestOpTableTypeInfo.GetNewProperty(propertyRef), propertyRef);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty key in unnestOpTableTypeInfo.FlattenedType.Properties)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef2 = dictionary[key];
				global::System.Data.Entity.Core.Query.InternalTrees.Var var = null;
				global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef simplePropertyRef = propertyRef2 as global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef;
				if (simplePropertyRef != null)
				{
					int num = rowType.Members.IndexOf(simplePropertyRef.Property);
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(num >= 0, "Can't find a column in the TVF result type");
					list2.Add(this.m_command.CreateVarDefNode(this.m_command.CreateNode(this.m_command.CreateVarRefOp(unnestOpTableColumns[num])), out var));
				}
				else if (propertyRef2 is global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef)
				{
					list2.Add(this.m_command.CreateVarDefNode(this.CreateNullSentinelConstant(), out var));
				}
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(var != null, "TVFs returning a collection of rows with non-primitive properties are not supported");
				list.Add(var);
			}
			newVars = list;
			return this.m_command.CreateNode(this.m_command.CreateProjectOp(this.m_command.CreateVarVec(list)), unnestNode, this.m_command.CreateNode(this.m_command.CreateVarDefListOp(), list2));
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x0007FF78 File Offset: 0x0007E178
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarDefListOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in n.Children)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(node.Op is global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp, "VarDefOp expected");
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = (global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp)node.Op;
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(varDefOp.Var.Type) || global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(varDefOp.Var.Type))
				{
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2;
					global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
					this.FlattenComputedVar((global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar)varDefOp.Var, node, out list2, out typeUsage);
					using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>.Enumerator enumerator2 = list2.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Data.Entity.Core.Query.InternalTrees.Node item = enumerator2.Current;
							list.Add(item);
						}
						continue;
					}
				}
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(varDefOp.Var.Type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(varDefOp.Var.Type))
				{
					list.Add(this.FlattenEnumOrStrongSpatialVar(varDefOp, node.Child0));
				}
				else
				{
					list.Add(node);
				}
			}
			return this.m_command.CreateNode(n.Op, list);
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000800C8 File Offset: 0x0007E2C8
		private void FlattenComputedVar(global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar v, global::System.Data.Entity.Core.Query.InternalTrees.Node node, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> newNodes, out global::System.Data.Entity.Core.Metadata.Edm.TypeUsage newType)
		{
			newNodes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = node.Child0;
			newType = null;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(v.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(child.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function, "Flattening of TVF output is not allowed.");
				newType = this.GetNewType(v.Type);
				global::System.Data.Entity.Core.Query.InternalTrees.Var newVar;
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.m_command.CreateVarDefNode(child, out newVar);
				newNodes.Add(item);
				this.m_varInfoMap.CreateCollectionVarInfo(v, newVar);
				return;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(v.Type);
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.m_varPropertyMap[v];
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			newNodes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in typeInfo.PropertyRefList)
			{
				if (propertyRefList.Contains(propertyRef))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty = typeInfo.GetNewProperty(propertyRef);
					global::System.Data.Entity.Core.Query.InternalTrees.Node node2;
					if (propertyRefList.AllProperties)
					{
						node2 = this.BuildAccessorWithNulls(child, newProperty);
					}
					else
					{
						node2 = this.BuildAccessor(child, newProperty);
						if (node2 == null)
						{
							continue;
						}
					}
					list2.Add(newProperty);
					global::System.Data.Entity.Core.Query.InternalTrees.Var item3;
					global::System.Data.Entity.Core.Query.InternalTrees.Node item2 = this.m_command.CreateVarDefNode(node2, out item3);
					newNodes.Add(item2);
					list.Add(item3);
					if (!flag && global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.IsNullSentinelPropertyRef(propertyRef))
					{
						flag = true;
					}
				}
			}
			this.m_varInfoMap.CreateStructuredVarInfo(v, typeInfo.FlattenedType, list, list2, flag);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00080250 File Offset: 0x0007E450
		private static bool IsNullSentinelPropertyRef(global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef)
		{
			if (propertyRef is global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef)
			{
				return true;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef nestedPropertyRef = propertyRef as global::System.Data.Entity.Core.Query.PlanCompiler.NestedPropertyRef;
			return nestedPropertyRef != null && nestedPropertyRef.OuterProperty is global::System.Data.Entity.Core.Query.PlanCompiler.NullSentinelPropertyRef;
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00080284 File Offset: 0x0007E484
		private global::System.Data.Entity.Core.Query.InternalTrees.Node FlattenEnumOrStrongSpatialVar(global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp, global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var newVar;
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = this.m_command.CreateVarDefNode(node, out newVar);
			this.m_varInfoMap.CreatePrimitiveTypeVarInfo(varDefOp.Var, newVar);
			return result;
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000802B4 File Offset: 0x0007E4B4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarList outputVars = this.FlattenVarList(op.Outputs);
			global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap = this.ExpandColumnMap(op.ColumnMap);
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp op2 = this.m_command.CreatePhysicalProjectOp(outputVars, columnMap);
			n.Op = op2;
			return n;
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x000802F8 File Offset: 0x0007E4F8
		private global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap ExpandColumnMap(global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap columnMap)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap varRefColumnMap = columnMap.Element as global::System.Data.Entity.Core.Query.InternalTrees.VarRefColumnMap;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varRefColumnMap != null, "Encountered a SimpleCollectionColumnMap element that is not VarRefColumnMap when expanding a column map in NominalTypeEliminator.");
			global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo;
			if (!this.m_varInfoMap.TryGetVarInfo(varRefColumnMap.Var, out varInfo))
			{
				return columnMap;
			}
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(varRefColumnMap.Var.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(varRefColumnMap.Var.Type);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(typeInfo.RootType.FlattenedType.Properties.Count == varInfo.NewVars.Count, string.Concat(new string[]
				{
					"Var count mismatch; Expected ",
					typeInfo.RootType.FlattenedType.Properties.Count.ToString(),
					"; got ",
					varInfo.NewVars.Count.ToString(),
					" instead."
				}));
			}
			global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap2 = new global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapProcessor(varRefColumnMap, varInfo, this.m_typeInfo).ExpandColumnMap();
			return new global::System.Data.Entity.Core.Query.InternalTrees.SimpleCollectionColumnMap(global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.CreateCollectionType(columnMap2.Type), columnMap2.Name, columnMap2, columnMap.Keys, columnMap.ForeignKeys);
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x0008041A File Offset: 0x0007E61A
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> FlattenVars(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.InternalTrees.Var> vars)
		{
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in vars)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo;
				if (!this.m_varInfoMap.TryGetVarInfo(var, out varInfo))
				{
					yield return var;
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var2 in varInfo.NewVars)
					{
						yield return var2;
					}
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>.Enumerator);
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Var> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00080431 File Offset: 0x0007E631
		private global::System.Data.Entity.Core.Query.InternalTrees.VarVec FlattenVarSet(global::System.Data.Entity.Core.Query.InternalTrees.VarVec varSet)
		{
			return this.m_command.CreateVarVec(this.FlattenVars(varSet));
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00080445 File Offset: 0x0007E645
		private global::System.Data.Entity.Core.Query.InternalTrees.VarList FlattenVarList(global::System.Data.Entity.Core.Query.InternalTrees.VarList varList)
		{
			return global::System.Data.Entity.Core.Query.InternalTrees.Command.CreateVarList(this.FlattenVars(varList));
		}

		// Token: 0x06002902 RID: 10498 RVA: 0x00080454 File Offset: 0x0007E654
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec keyVars = this.FlattenVarSet(op.Keys);
			n.Op = this.m_command.CreateDistinctOp(keyVars);
			return n;
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00080488 File Offset: 0x0007E688
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.FlattenVarSet(op.Keys);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this.FlattenVarSet(op.Outputs);
			if (varVec != op.Keys || varVec2 != op.Outputs)
			{
				n.Op = this.m_command.CreateGroupByOp(varVec, varVec2);
			}
			return n;
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x000804DC File Offset: 0x0007E6DC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GroupByIntoOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.FlattenVarSet(op.Keys);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec2 = this.FlattenVarSet(op.Inputs);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec3 = this.FlattenVarSet(op.Outputs);
			if (varVec != op.Keys || varVec2 != op.Inputs || varVec3 != op.Outputs)
			{
				n.Op = this.m_command.CreateGroupByIntoOp(varVec, varVec2, varVec3);
			}
			return n;
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00080548 File Offset: 0x0007E748
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.FlattenVarSet(op.Outputs);
			if (op.Outputs != varVec)
			{
				if (varVec.IsEmpty)
				{
					return n.Child0;
				}
				n.Op = this.m_command.CreateProjectOp(varVec);
			}
			return n;
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00080594 File Offset: 0x0007E794
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = op.Table.Columns[0];
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(var.Type);
			global::System.Data.Entity.Core.Metadata.Edm.RowType flattenedType = typeInfo.FlattenedType;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>();
			foreach (object obj in global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(var.Type.EdmType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)obj;
				hashSet.Add(edmProperty.Name);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 in flattenedType.Properties)
			{
				if (hashSet.Contains(edmProperty2.Name))
				{
					list.Add(edmProperty2);
				}
			}
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in typeInfo.GetKeyPropertyRefs())
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty = typeInfo.GetNewProperty(propertyRef);
				list2.Add(newProperty);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata = this.m_command.CreateFlatTableDefinition(list, list2, op.Table.TableMetadata.Extent);
			global::System.Data.Entity.Core.Query.InternalTrees.Table table = this.m_command.CreateTableInstance(tableMetadata);
			this.m_varInfoMap.CreateStructuredVarInfo(var, flattenedType, table.Columns, list);
			n.Op = this.m_command.CreateScanTableOp(table);
			return n;
		}

		// Token: 0x06002907 RID: 10503 RVA: 0x00080744 File Offset: 0x0007E944
		internal static global::System.Data.Entity.Core.Query.InternalTrees.Var GetSingletonVar(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			switch (n.Op.OpType)
			{
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.ScanTable:
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp scanTableOp = (global::System.Data.Entity.Core.Query.InternalTrees.ScanTableOp)n.Op;
				if (scanTableOp.Table.Columns.Count != 1)
				{
					return null;
				}
				return scanTableOp.Table.Columns[0];
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Filter:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Sort:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.ConstrainedSort:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.SingleRow:
				return global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.GetSingletonVar(n.Child0);
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Project:
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp projectOp = (global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp)n.Op;
				if (projectOp.Outputs.Count != 1)
				{
					return null;
				}
				return projectOp.Outputs.First;
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Unnest:
			{
				global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp unnestOp = (global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp)n.Op;
				if (unnestOp.Table.Columns.Count != 1)
				{
					return null;
				}
				return unnestOp.Table.Columns[0];
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.UnionAll:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Intersect:
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Except:
			{
				global::System.Data.Entity.Core.Query.InternalTrees.SetOp setOp = (global::System.Data.Entity.Core.Query.InternalTrees.SetOp)n.Op;
				if (setOp.Outputs.Count != 1)
				{
					return null;
				}
				return setOp.Outputs.First;
			}
			case global::System.Data.Entity.Core.Query.InternalTrees.OpType.Distinct:
			{
				global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp distinctOp = (global::System.Data.Entity.Core.Query.InternalTrees.DistinctOp)n.Op;
				if (distinctOp.Keys.Count != 1)
				{
					return null;
				}
				return distinctOp.Keys.First;
			}
			}
			return null;
		}

		// Token: 0x06002908 RID: 10504 RVA: 0x000808AC File Offset: 0x0007EAAC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ScanViewOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Var singletonVar = global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.GetSingletonVar(n.Child0);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(singletonVar != null, "cannot identify Var for the input node to the ScanViewOp");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.Table.Columns.Count == 1, "table for scanViewOp has more than on column?");
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = op.Table.Columns[0];
			global::System.Data.Entity.Core.Query.InternalTrees.Node result = base.VisitNode(n.Child0);
			global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo;
			if (!this.m_varInfoMap.TryGetVarInfo(singletonVar, out varInfo))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(false, "didn't find inputVar for scanViewOp?");
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo structuredVarInfo = (global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo)varInfo;
			this.m_typeInfo.GetTypeInfo(var.Type);
			this.m_varInfoMap.CreateStructuredVarInfo(var, structuredVarInfo.NewType, structuredVarInfo.NewVars, structuredVarInfo.Fields);
			return result;
		}

		// Token: 0x06002909 RID: 10505 RVA: 0x00080964 File Offset: 0x0007EB64
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = this.HandleSortKeys(op.Keys);
			if (list != op.Keys)
			{
				n.Op = this.m_command.CreateSortOp(list);
			}
			return n;
		}

		// Token: 0x0600290A RID: 10506 RVA: 0x000809A4 File Offset: 0x0007EBA4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Var var = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = null;
			if (n.HasChild0)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node child = n.Child0;
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp varDefOp = child.Op as global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp;
				if (varDefOp != null && global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(varDefOp.Var.Type))
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar computedVar = (global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar)varDefOp.Var;
					if (child.HasChild0 && child.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Function)
					{
						var = computedVar;
						edmFunction = ((global::System.Data.Entity.Core.Query.InternalTrees.FunctionOp)child.Child0.Op).Function;
					}
					else
					{
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
						global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage;
						this.FlattenComputedVar(computedVar, child, out list, out typeUsage);
						global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list.Count == 1, "Flattening unnest var produced more than one Var.");
						n.Child0 = list[0];
					}
				}
			}
			if (edmFunction != null)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(var != null, "newUnnestVar must be initialized in the TVF case.");
			}
			else
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo;
				if (!this.m_varInfoMap.TryGetVarInfo(op.Var, out varInfo) || varInfo.Kind != global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.CollectionVarInfo)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1006));
				}
				var = ((global::System.Data.Entity.Core.Query.PlanCompiler.CollectionVarInfo)varInfo).NewVar;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Var var2 = op.Table.Columns[0];
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(var2.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(edmFunction == null, "TVFs returning a collection of values of a non-structured type are not supported");
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(var2.Type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(var2.Type))
				{
					global::System.Data.Entity.Core.Query.InternalTrees.UnnestOp unnestOp = this.m_command.CreateUnnestOp(var);
					this.m_varInfoMap.CreatePrimitiveTypeVarInfo(var2, unnestOp.Table.Columns[0]);
					n.Op = unnestOp;
				}
				else
				{
					n.Op = this.m_command.CreateUnnestOp(var, op.Table);
				}
			}
			else
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(var2.Type);
				global::System.Data.Entity.Core.Query.InternalTrees.TableMD tableMetadata;
				if (edmFunction != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.RowType tvfReturnType = global::System.Data.Entity.Core.Common.TypeHelpers.GetTvfReturnType(edmFunction);
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(tvfReturnType, var2.Type.EdmType), "Unexpected TVF return type (row type is expected).");
					tableMetadata = this.m_command.CreateFlatTableDefinition(tvfReturnType.Properties, this.GetTvfResultKeys(edmFunction), null);
				}
				else
				{
					tableMetadata = this.m_command.CreateFlatTableDefinition(typeInfo.FlattenedType);
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Table table = this.m_command.CreateTableInstance(tableMetadata);
				n.Op = this.m_command.CreateUnnestOp(var, table);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> columns;
				if (edmFunction != null)
				{
					n = this.CreateTVFProjection(n, table.Columns, typeInfo, out columns);
				}
				else
				{
					columns = table.Columns;
				}
				this.m_varInfoMap.CreateStructuredVarInfo(var2, typeInfo.FlattenedType, columns, typeInfo.FlattenedType.Properties.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>());
			}
			return n;
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00080C40 File Offset: 0x0007EE40
		private global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> GetTvfResultKeys(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction tvf)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] result;
			if (this.m_tvfResultKeys.TryGetValue(tvf, out result))
			{
				return result;
			}
			return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00080C64 File Offset: 0x0007EE64
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitSetOp(global::System.Data.Entity.Core.Query.InternalTrees.SetOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			for (int i = 0; i < op.VarMap.Length; i++)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar> list;
				op.VarMap[i] = this.FlattenVarMap(op.VarMap[i], out list);
				if (list != null)
				{
					n.Children[i] = this.FixupSetOpChild(n.Children[i], op.VarMap[i], list);
				}
			}
			op.Outputs.Clear();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in op.VarMap[0].Keys)
			{
				op.Outputs.Set(v);
			}
			return n;
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00080D28 File Offset: 0x0007EF28
		private global::System.Data.Entity.Core.Query.InternalTrees.Node FixupSetOpChild(global::System.Data.Entity.Core.Query.InternalTrees.Node setOpChild, global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar> newComputedVars)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(setOpChild != null, "null setOpChild?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(varMap != null, "null varMap?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(newComputedVars != null, "null newComputedVars?");
			global::System.Data.Entity.Core.Query.InternalTrees.VarVec varVec = this.m_command.CreateVarVec();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in varMap)
			{
				varVec.Set(keyValuePair.Value);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var var in newComputedVars)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarDefOp op = this.m_command.CreateVarDefOp(var);
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.m_command.CreateNode(op, this.CreateNullConstantNode(var.Type));
				list.Add(item);
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.m_command.CreateNode(this.m_command.CreateVarDefListOp(), list);
			global::System.Data.Entity.Core.Query.InternalTrees.ProjectOp op2 = this.m_command.CreateProjectOp(varVec);
			return this.m_command.CreateNode(op2, setOpChild, arg);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00080E58 File Offset: 0x0007F058
		private global::System.Data.Entity.Core.Query.InternalTrees.VarMap FlattenVarMap(global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar> newComputedVars)
		{
			newComputedVars = null;
			global::System.Data.Entity.Core.Query.InternalTrees.VarMap varMap2 = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap();
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.InternalTrees.Var> keyValuePair in varMap)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo;
				if (!this.m_varInfoMap.TryGetVarInfo(keyValuePair.Value, out varInfo))
				{
					varMap2.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo2;
					if (!this.m_varInfoMap.TryGetVarInfo(keyValuePair.Key, out varInfo2))
					{
						varInfo2 = this.FlattenSetOpVar((global::System.Data.Entity.Core.Query.InternalTrees.SetOpVar)keyValuePair.Key);
					}
					if (varInfo2.Kind == global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.CollectionVarInfo)
					{
						varMap2.Add(((global::System.Data.Entity.Core.Query.PlanCompiler.CollectionVarInfo)varInfo2).NewVar, ((global::System.Data.Entity.Core.Query.PlanCompiler.CollectionVarInfo)varInfo).NewVar);
					}
					else if (varInfo2.Kind == global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.PrimitiveTypeVarInfo)
					{
						varMap2.Add(((global::System.Data.Entity.Core.Query.PlanCompiler.PrimitiveTypeVarInfo)varInfo2).NewVar, ((global::System.Data.Entity.Core.Query.PlanCompiler.PrimitiveTypeVarInfo)varInfo).NewVar);
					}
					else
					{
						global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo structuredVarInfo = (global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo)varInfo2;
						global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo structuredVarInfo2 = (global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo)varInfo;
						foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in structuredVarInfo.Fields)
						{
							global::System.Data.Entity.Core.Query.InternalTrees.Var var;
							global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(structuredVarInfo.TryGetVar(edmProperty, out var), "Could not find VarInfo for prop " + edmProperty.Name);
							global::System.Data.Entity.Core.Query.InternalTrees.Var var2;
							if (!structuredVarInfo2.TryGetVar(edmProperty, out var2))
							{
								var2 = this.m_command.CreateComputedVar(var.Type);
								if (newComputedVars == null)
								{
									newComputedVars = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar>();
								}
								newComputedVars.Add((global::System.Data.Entity.Core.Query.InternalTrees.ComputedVar)var2);
							}
							varMap2.Add(var, var2);
						}
					}
				}
			}
			return varMap2;
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00081028 File Offset: 0x0007F228
		private global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo FlattenSetOpVar(global::System.Data.Entity.Core.Query.InternalTrees.SetOpVar v)
		{
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(v.Type))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage newType = this.GetNewType(v.Type);
				global::System.Data.Entity.Core.Query.InternalTrees.Var newVar = this.m_command.CreateSetOpVar(newType);
				return this.m_varInfoMap.CreateCollectionVarInfo(v, newVar);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(v.Type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(v.Type))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage newType2 = this.GetNewType(v.Type);
				global::System.Data.Entity.Core.Query.InternalTrees.Var newVar2 = this.m_command.CreateSetOpVar(newType2);
				return this.m_varInfoMap.CreatePrimitiveTypeVarInfo(v, newVar2);
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(v.Type);
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.m_varPropertyMap[v];
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Var>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			bool flag = false;
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in typeInfo.PropertyRefList)
			{
				if (propertyRefList.Contains(propertyRef))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty = typeInfo.GetNewProperty(propertyRef);
					list2.Add(newProperty);
					global::System.Data.Entity.Core.Query.InternalTrees.SetOpVar item = this.m_command.CreateSetOpVar(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(newProperty));
					list.Add(item);
					if (!flag && global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.IsNullSentinelPropertyRef(propertyRef))
					{
						flag = true;
					}
				}
			}
			return this.m_varInfoMap.CreateStructuredVarInfo(v, typeInfo.FlattenedType, list, list2, flag);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x00081180 File Offset: 0x0007F380
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.SoftCastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = n.Child0.Op.Type;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2 = op.Type;
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage newType = this.GetNewType(type2);
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsRowType(type2))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Child0.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord, "Expected a record constructor here. Found " + n.Child0.Op.OpType.ToString() + " instead");
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(type);
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.m_typeInfo.GetTypeInfo(op.Type);
				global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp newRecordOp = this.m_command.CreateNewRecordOp(newType);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = newRecordOp.Properties.GetEnumerator();
				int num = newRecordOp.Properties.Count;
				enumerator.MoveNext();
				global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Query.InternalTrees.Node> enumerator2 = n.Child0.Children.GetEnumerator();
				int i = n.Child0.Children.Count;
				enumerator2.MoveNext();
				while (i < num)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(typeInfo2.HasNullSentinelProperty && !typeInfo.HasNullSentinelProperty, "NullSentinelProperty mismatch on input?");
					list.Add(this.CreateNullSentinelConstant());
					enumerator.MoveNext();
					num--;
				}
				while (i > num)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!typeInfo2.HasNullSentinelProperty && typeInfo.HasNullSentinelProperty, "NullSentinelProperty mismatch on output?");
					enumerator2.MoveNext();
					i--;
				}
				do
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member = enumerator.Current;
					global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.BuildSoftCast(enumerator2.Current, global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(member));
					list.Add(item);
					enumerator.MoveNext();
				}
				while (enumerator2.MoveNext());
				return this.m_command.CreateNode(newRecordOp, list);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsCollectionType(type2))
			{
				return this.BuildSoftCast(n.Child0, newType);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(type2))
			{
				return n;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNominalType(type2) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsReferenceType(type2), "Gasp! Not a nominal type or even a reference type");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Query.InternalTrees.Command.EqualTypes(newType, n.Child0.Op.Type), "Types are not equal");
			return n.Child0;
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x000813B4 File Offset: 0x0007F5B4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(op.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(n.Child0.Op.Type), "Primitive type expected.");
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType underlyingEdmTypeForEnumType = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetUnderlyingEdmTypeForEnumType(op.Type.EdmType);
				return this.RewriteAsCastToUnderlyingType(underlyingEdmTypeForEnumType, op, n);
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSpatialType(op.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(n.Child0.Op.Type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geography) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsPrimitiveType(n.Child0.Op.Type, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Geometry), "Union spatial type expected.");
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType spatialNormalizedPrimitiveType = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetSpatialNormalizedPrimitiveType(op.Type.EdmType);
				return this.RewriteAsCastToUnderlyingType(spatialNormalizedPrimitiveType, op, n);
			}
			return n;
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00081478 File Offset: 0x0007F678
		private global::System.Data.Entity.Core.Query.InternalTrees.Node RewriteAsCastToUnderlyingType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType underlyingType, global::System.Data.Entity.Core.Query.InternalTrees.CastOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (underlyingType.PrimitiveTypeKind == ((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType)n.Child0.Op.Type.EdmType).PrimitiveTypeKind)
			{
				return n.Child0;
			}
			return this.m_command.CreateNode(this.m_command.CreateCastOp(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(underlyingType, op.Type.Facets)), n.Child0);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x000814E0 File Offset: 0x0007F6E0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstantOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(n.Children.Count == 0, "Constant operations don't have children.");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.Value != null, "Value must not be null");
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(op.Type))
			{
				object value = op.Value.GetType().IsEnum() ? global::System.Convert.ChangeType(op.Value, op.Value.GetType().GetEnumUnderlyingType(), global::System.Globalization.CultureInfo.InvariantCulture) : op.Value;
				return this.m_command.CreateNode(this.m_command.CreateConstantOp(global::System.Data.Entity.Core.Common.TypeHelpers.CreateEnumUnderlyingTypeUsage(op.Type), value));
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(op.Type))
			{
				op.Type = global::System.Data.Entity.Core.Common.TypeHelpers.CreateSpatialUnionTypeUsage(op.Type);
			}
			return n;
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x000815A4 File Offset: 0x0007F7A4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			bool thenClauseIsNull;
			bool flag = global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompilerUtil.IsRowTypeCaseOpWithNullability(op, n, out thenClauseIsNull);
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (flag && this.TryRewriteCaseOp(n, thenClauseIsNull, out result))
			{
				return result;
			}
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsCollectionType(op.Type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(op.Type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(op.Type))
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage newType = this.GetNewType(op.Type);
				n.Op = this.m_command.CreateCaseOp(newType);
				return n;
			}
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(op.Type))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList desiredProperties = this.m_nodePropertyMap[n];
				return this.FlattenCaseOp(n, this.m_typeInfo.GetTypeInfo(op.Type), desiredProperties);
			}
			return n;
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00081650 File Offset: 0x0007F850
		private bool TryRewriteCaseOp(global::System.Data.Entity.Core.Query.InternalTrees.Node n, bool thenClauseIsNull, out global::System.Data.Entity.Core.Query.InternalTrees.Node rewrittenNode)
		{
			rewrittenNode = n;
			if (!this.m_typeInfo.GetTypeInfo(n.Op.Type).HasNullSentinelProperty)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = thenClauseIsNull ? n.Child2 : n.Child1;
			if (node.Op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord)
			{
				return false;
			}
			global::System.Data.Entity.Core.Query.InternalTrees.Node child = node.Child0;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage integerType = this.m_command.IntegerType;
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(child.Op.Type.EdmEquals(integerType), "Column that is expected to be a null sentinel is not of Integer type.");
			global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op = this.m_command.CreateCaseOp(integerType);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(3);
			list.Add(n.Child0);
			global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.m_command.CreateNode(this.m_command.CreateNullOp(integerType));
			global::System.Data.Entity.Core.Query.InternalTrees.Node item = thenClauseIsNull ? node2 : child;
			global::System.Data.Entity.Core.Query.InternalTrees.Node item2 = thenClauseIsNull ? child : node2;
			list.Add(item);
			list.Add(item2);
			node.Child0 = this.m_command.CreateNode(op, list);
			rewrittenNode = node;
			return true;
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x0008174C File Offset: 0x0007F94C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node FlattenCaseOp(global::System.Data.Entity.Core.Query.InternalTrees.Node n, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList desiredProperties)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef in typeInfo.PropertyRefList)
			{
				if (desiredProperties.Contains(propertyRef))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty = typeInfo.GetNewProperty(propertyRef);
					global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
					for (int i = 0; i < n.Children.Count - 1; i++)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.Copy(n.Children[i]);
						list3.Add(item);
						i++;
						global::System.Data.Entity.Core.Query.InternalTrees.Node item2 = this.BuildAccessorWithNulls(n.Children[i], newProperty);
						list3.Add(item2);
					}
					global::System.Data.Entity.Core.Query.InternalTrees.Node item3 = this.BuildAccessorWithNulls(n.Children[n.Children.Count - 1], newProperty);
					list3.Add(item3);
					global::System.Data.Entity.Core.Query.InternalTrees.Node item4 = this.m_command.CreateNode(this.m_command.CreateCaseOp(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(newProperty)), list3);
					list.Add(newProperty);
					list2.Add(item4);
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op = this.m_command.CreateNewRecordOp(typeInfo.FlattenedTypeUsage, list);
			return this.m_command.CreateNode(op, list2);
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x000818A0 File Offset: 0x0007FAA0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.CollectOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			n.Op = this.m_command.CreateCollectOp(this.GetNewType(op.Type));
			return n;
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x000818C8 File Offset: 0x0007FAC8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = n.Child0.Op.Type;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2 = n.Child1.Op.Type;
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				return this.VisitScalarOpDefault(op, n);
			}
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(!global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(type) && !global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsComplexType(type2), "complex type?");
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NE, "non-equality comparison of structured types?");
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(type);
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.m_typeInfo.GetTypeInfo(type2);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2;
			this.GetPropertyValues(typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.Equality, n.Child0, false, out list, out list2);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list3;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list4;
			this.GetPropertyValues(typeInfo2, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.Equality, n.Child1, false, out list3, out list4);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list.Count == list3.Count && list2.Count == list4.Count, "different shaped structured types?");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			for (int i = 0; i < list2.Count; i++)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op2 = this.m_command.CreateComparisonOp(op.OpType, op.UseDatabaseNullSemantics);
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.m_command.CreateNode(op2, list2[i], list4[i]);
				if (node == null)
				{
					node = node2;
				}
				else
				{
					node = this.m_command.CreateNode(this.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), node, node2);
				}
			}
			return node;
		}

		// Token: 0x06002919 RID: 10521 RVA: 0x00081A38 File Offset: 0x0007FC38
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConditionalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (op.OpType != global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull)
			{
				return this.VisitScalarOpDefault(op, n);
			}
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = n.Child0.Op.Type;
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type))
			{
				return this.VisitScalarOpDefault(op, n);
			}
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(type);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = null;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = null;
			this.GetPropertyValues(typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.IsNull, n.Child0, false, out list, out list2);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list.Count == list2.Count && list.Count > 0, "No properties returned from GetPropertyValues(IsNull)?");
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node arg in list2)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.m_command.CreateNode(this.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.IsNull), arg);
				if (node == null)
				{
					node = node2;
				}
				else
				{
					node = this.m_command.CreateNode(this.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.And), node, node2);
				}
			}
			return node;
		}

		// Token: 0x0600291A RID: 10522 RVA: 0x00081B50 File Offset: 0x0007FD50
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.ConstrainedSortOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> list = this.HandleSortKeys(op.Keys);
			if (list != op.Keys)
			{
				n.Op = this.m_command.CreateConstrainedSortOp(list, op.WithTies);
			}
			return n;
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x00081B93 File Offset: 0x0007FD93
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetEntityRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.FlattenGetKeyOp(op, n);
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x00081B9D File Offset: 0x0007FD9D
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.GetRefKeyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.FlattenGetKeyOp(op, n);
		}

		// Token: 0x0600291D RID: 10525 RVA: 0x00081BA8 File Offset: 0x0007FDA8
		private global::System.Data.Entity.Core.Query.InternalTrees.Node FlattenGetKeyOp(global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetEntityRef || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetRefKey, "Expecting GetEntityRef or GetRefKey ops");
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(n.Child0.Op.Type);
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.m_typeInfo.GetTypeInfo(op.Type);
			this.VisitChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2;
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetRefKey)
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list;
				this.GetPropertyValues(typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.GetKeys, n.Child0, false, out list, out list2);
			}
			else
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.GetEntityRef, "Expected OpType.GetEntityRef: Found " + op.OpType.ToString());
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list;
				this.GetPropertyValues(typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.GetIdentity, n.Child0, false, out list, out list2);
			}
			if (typeInfo2.HasNullSentinelProperty && !typeInfo.HasNullSentinelProperty)
			{
				list2.Insert(0, this.CreateNullSentinelConstant());
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(typeInfo2.FlattenedType.Properties);
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list2.Count == list3.Count, "fieldTypes.Count mismatch?");
			global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op2 = this.m_command.CreateNewRecordOp(typeInfo2.FlattenedTypeUsage, list3);
			return this.m_command.CreateNode(op2, list2);
		}

		// Token: 0x0600291E RID: 10526 RVA: 0x00081CD8 File Offset: 0x0007FED8
		private global::System.Data.Entity.Core.Query.InternalTrees.Node VisitPropertyOp(global::System.Data.Entity.Core.Query.InternalTrees.Op op, global::System.Data.Entity.Core.Query.InternalTrees.Node n, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef, bool throwIfMissing)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Property || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.RelProperty, "Unexpected optype: " + op.OpType.ToString());
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = n.Child0.Op.Type;
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type2 = op.Type;
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(type);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(type2))
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.m_typeInfo.GetTypeInfo(type2);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList propertyRefList = this.m_nodePropertyMap[n];
				foreach (global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef2 in typeInfo2.PropertyRefList)
				{
					if (propertyRefList.Contains(propertyRef2))
					{
						global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef3 = propertyRef2.CreateNestedPropertyRef(propertyRef);
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property;
						if (typeInfo.TryGetNewProperty(propertyRef3, throwIfMissing, out property))
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty = typeInfo2.GetNewProperty(propertyRef2);
							global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.BuildAccessor(n.Child0, property);
							if (node != null)
							{
								list.Add(newProperty);
								list2.Add(node);
							}
						}
					}
				}
				global::System.Data.Entity.Core.Query.InternalTrees.Op op2 = this.m_command.CreateNewRecordOp(typeInfo2.FlattenedTypeUsage, list);
				result = this.m_command.CreateNode(op2, list2);
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty2 = typeInfo.GetNewProperty(propertyRef);
				result = this.BuildAccessorWithNulls(n.Child0, newProperty2);
			}
			return result;
		}

		// Token: 0x0600291F RID: 10527 RVA: 0x00081E58 File Offset: 0x00080058
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.PropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitPropertyOp(op, n, new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(op.PropertyInfo), true);
		}

		// Token: 0x06002920 RID: 10528 RVA: 0x00081E6E File Offset: 0x0008006E
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.RelPropertyOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitPropertyOp(op, n, new global::System.Data.Entity.Core.Query.PlanCompiler.RelPropertyRef(op.PropertyInfo), false);
		}

		// Token: 0x06002921 RID: 10529 RVA: 0x00081E84 File Offset: 0x00080084
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.RefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(n.Child0.Op.Type);
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.m_typeInfo.GetTypeInfo(op.Type);
			this.VisitChildren(n);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2;
			this.GetPropertyValues(typeInfo, global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.OperationKind.All, n.Child0, false, out list, out list2);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list3 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(typeInfo2.FlattenedType.Properties);
			if (typeInfo2.HasEntitySetIdProperty)
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list3[0] == typeInfo2.EntitySetIdProperty, "OutputField0 must be the entitySetId property");
				if (typeInfo.HasNullSentinelProperty && !typeInfo2.HasNullSentinelProperty)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list3.Count == list.Count, "Mismatched field count: Expected " + list.Count.ToString() + "; Got " + list3.Count.ToString());
					global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.RemoveNullSentinel(typeInfo, list, list2);
				}
				else
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list3.Count == list.Count + 1, "Mismatched field count: Expected " + (list.Count + 1).ToString() + "; Got " + list3.Count.ToString());
				}
				int entitySetId = this.m_typeInfo.GetEntitySetId(op.EntitySet);
				list2.Insert(0, this.m_command.CreateNode(this.m_command.CreateInternalConstantOp(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(typeInfo2.EntitySetIdProperty), entitySetId)));
			}
			else
			{
				if (typeInfo.HasNullSentinelProperty && !typeInfo2.HasNullSentinelProperty)
				{
					global::System.Data.Entity.Core.Query.PlanCompiler.NominalTypeEliminator.RemoveNullSentinel(typeInfo, list, list2);
				}
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(list3.Count == list.Count, "Mismatched field count: Expected " + list.Count.ToString() + "; Got " + list3.Count.ToString());
			}
			global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op2 = this.m_command.CreateNewRecordOp(typeInfo2.FlattenedTypeUsage, list3);
			return this.m_command.CreateNode(op2, list2);
		}

		// Token: 0x06002922 RID: 10530 RVA: 0x00082073 File Offset: 0x00080273
		private static void RemoveNullSentinel(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo inputTypeInfo, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> inputFields, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> inputFieldValues)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(inputFields[0] == inputTypeInfo.NullSentinelProperty, "InputField0 must be the null sentinel property");
			inputFields.RemoveAt(0);
			inputFieldValues.RemoveAt(0);
		}

		// Token: 0x06002923 RID: 10531 RVA: 0x0008209C File Offset: 0x0008029C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.VarInfo varInfo;
			if (!this.m_varInfoMap.TryGetVarInfo(op.Var, out varInfo))
			{
				bool condition = !global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(op.Type);
				string str = "No varInfo for a structured type var: Id = ";
				string str2 = op.Var.Id.ToString();
				string str3 = " Type = ";
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type = op.Type;
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(condition, str + str2 + str3 + ((type != null) ? type.ToString() : null));
				return n;
			}
			if (varInfo.Kind == global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.CollectionVarInfo)
			{
				n.Op = this.m_command.CreateVarRefOp(((global::System.Data.Entity.Core.Query.PlanCompiler.CollectionVarInfo)varInfo).NewVar);
				return n;
			}
			if (varInfo.Kind == global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoKind.PrimitiveTypeVarInfo)
			{
				n.Op = this.m_command.CreateVarRefOp(((global::System.Data.Entity.Core.Query.PlanCompiler.PrimitiveTypeVarInfo)varInfo).NewVar);
				return n;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo structuredVarInfo = (global::System.Data.Entity.Core.Query.PlanCompiler.StructuredVarInfo)varInfo;
			global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op2 = this.m_command.CreateNewRecordOp(structuredVarInfo.NewTypeUsage, structuredVarInfo.Fields);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var v in varInfo.NewVars)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.VarRefOp op3 = this.m_command.CreateVarRefOp(v);
				list.Add(this.m_command.CreateNode(op3));
			}
			return this.m_command.CreateNode(op2, list);
		}

		// Token: 0x06002924 RID: 10532 RVA: 0x000821EC File Offset: 0x000803EC
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.FlattenConstructor(op, n);
		}

		// Token: 0x06002925 RID: 10533 RVA: 0x000821F6 File Offset: 0x000803F6
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewInstanceOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.FlattenConstructor(op, n);
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x00082200 File Offset: 0x00080400
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.FlattenConstructor(op, n);
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x0008220C File Offset: 0x0008040C
		private global::System.Data.Entity.Core.Query.InternalTrees.Node NormalizeTypeDiscriminatorValues(global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node discriminator)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(op.Type);
			global::System.Data.Entity.Core.Query.InternalTrees.CaseOp op2 = this.m_command.CreateCaseOp(typeInfo.RootType.TypeIdProperty.TypeUsage);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(op.DiscriminatorMap.TypeMap.Count * 2 - 1);
			for (int i = 0; i < op.DiscriminatorMap.TypeMap.Count; i++)
			{
				object key = op.DiscriminatorMap.TypeMap[i].Key;
				global::System.Data.Entity.Core.Metadata.Edm.EntityType value = op.DiscriminatorMap.TypeMap[i].Value;
				global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 = this.m_typeInfo.GetTypeInfo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(value));
				global::System.Data.Entity.Core.Query.InternalTrees.Node item = this.CreateTypeIdConstant(typeInfo2);
				if (i == op.DiscriminatorMap.TypeMap.Count - 1)
				{
					list.Add(item);
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.ConstantBaseOp op3 = this.m_command.CreateConstantOp(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(op.DiscriminatorMap.DiscriminatorProperty.TypeUsage), key);
					global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.m_command.CreateNode(op3);
					global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op4 = this.m_command.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false);
					global::System.Data.Entity.Core.Query.InternalTrees.Node item2 = this.m_command.CreateNode(op4, discriminator, arg);
					list.Add(item2);
					list.Add(item);
				}
			}
			discriminator = this.m_command.CreateNode(op2, list);
			return discriminator;
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x0008236C File Offset: 0x0008056C
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.FlattenConstructor(op, n);
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00082378 File Offset: 0x00080578
		private global::System.Data.Entity.Core.Query.InternalTrees.Node GetEntitySetIdExpr(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty entitySetIdProperty, global::System.Data.Entity.Core.Query.InternalTrees.NewEntityBaseOp op)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = op.EntitySet;
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (entitySet != null)
			{
				int entitySetId = this.m_typeInfo.GetEntitySetId(entitySet);
				global::System.Data.Entity.Core.Query.InternalTrees.InternalConstantOp op2 = this.m_command.CreateInternalConstantOp(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(entitySetIdProperty), entitySetId);
				result = this.m_command.CreateNode(op2);
			}
			else
			{
				result = this.CreateNullConstantNode(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(entitySetIdProperty));
			}
			return result;
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x000823D4 File Offset: 0x000805D4
		private global::System.Data.Entity.Core.Query.InternalTrees.Node FlattenConstructor(global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewInstance || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.DiscriminatedNewEntity || op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewEntity, "unexpected op: " + op.OpType.ToString() + "?");
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(op.Type);
			global::System.Data.Entity.Core.Metadata.Edm.RowType flattenedType = typeInfo.FlattenedType;
			global::System.Data.Entity.Core.Query.InternalTrees.NewEntityBaseOp newEntityBaseOp = op as global::System.Data.Entity.Core.Query.InternalTrees.NewEntityBaseOp;
			global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp discriminatedNewEntityOp = null;
			global::System.Collections.IEnumerable enumerable;
			if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.NewRecord)
			{
				enumerable = ((global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp)op).Properties;
			}
			else if (op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.DiscriminatedNewEntity)
			{
				discriminatedNewEntityOp = (global::System.Data.Entity.Core.Query.InternalTrees.DiscriminatedNewEntityOp)op;
				enumerable = discriminatedNewEntityOp.DiscriminatorMap.Properties;
			}
			else
			{
				enumerable = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(op.Type);
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			if (typeInfo.HasTypeIdProperty)
			{
				list.Add(typeInfo.TypeIdProperty);
				if (discriminatedNewEntityOp == null)
				{
					list2.Add(this.CreateTypeIdConstant(typeInfo));
				}
				else
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node node = n.Children[0];
					if (typeInfo.RootType.DiscriminatorMap == null)
					{
						node = this.NormalizeTypeDiscriminatorValues(discriminatedNewEntityOp, node);
					}
					list2.Add(node);
				}
			}
			if (typeInfo.HasEntitySetIdProperty)
			{
				list.Add(typeInfo.EntitySetIdProperty);
				global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(newEntityBaseOp != null, "unexpected optype:" + op.OpType.ToString());
				global::System.Data.Entity.Core.Query.InternalTrees.Node entitySetIdExpr = this.GetEntitySetIdExpr(typeInfo.EntitySetIdProperty, newEntityBaseOp);
				list2.Add(entitySetIdExpr);
			}
			if (typeInfo.HasNullSentinelProperty)
			{
				list.Add(typeInfo.NullSentinelProperty);
				list2.Add(this.CreateNullSentinelConstant());
			}
			int num = (discriminatedNewEntityOp == null) ? 0 : 1;
			foreach (object obj in enumerable)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = (global::System.Data.Entity.Core.Metadata.Edm.EdmMember)obj;
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = n.Children[num];
				if (global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember)))
				{
					global::System.Data.Entity.Core.Metadata.Edm.RowType flattenedType2 = this.m_typeInfo.GetTypeInfo(global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(edmMember)).FlattenedType;
					int num2 = typeInfo.RootType.GetNestedStructureOffset(new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(edmMember));
					using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>.Enumerator enumerator2 = flattenedType2.Properties.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property = enumerator2.Current;
							global::System.Data.Entity.Core.Query.InternalTrees.Node node3 = this.BuildAccessor(node2, property);
							if (node3 != null)
							{
								list.Add(flattenedType.Properties[num2]);
								list2.Add(node3);
							}
							num2++;
						}
						goto IL_29B;
					}
					goto IL_276;
				}
				goto IL_276;
				IL_29B:
				num++;
				continue;
				IL_276:
				global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRef propertyRef = new global::System.Data.Entity.Core.Query.PlanCompiler.SimplePropertyRef(edmMember);
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty newProperty = typeInfo.GetNewProperty(propertyRef);
				list.Add(newProperty);
				list2.Add(node2);
				goto IL_29B;
			}
			if (newEntityBaseOp != null)
			{
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.RelProperty relProperty in newEntityBaseOp.RelationshipProperties)
				{
					global::System.Data.Entity.Core.Query.InternalTrees.Node input = n.Children[num];
					global::System.Data.Entity.Core.Metadata.Edm.RowType flattenedType3 = this.m_typeInfo.GetTypeInfo(relProperty.ToEnd.TypeUsage).FlattenedType;
					int num3 = typeInfo.RootType.GetNestedStructureOffset(new global::System.Data.Entity.Core.Query.PlanCompiler.RelPropertyRef(relProperty));
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property2 in flattenedType3.Properties)
					{
						global::System.Data.Entity.Core.Query.InternalTrees.Node node4 = this.BuildAccessor(input, property2);
						if (node4 != null)
						{
							list.Add(flattenedType.Properties[num3]);
							list2.Add(node4);
						}
						num3++;
					}
					num++;
				}
			}
			global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op2 = this.m_command.CreateNewRecordOp(typeInfo.FlattenedTypeUsage, list);
			return this.m_command.CreateNode(op2, list2);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000827E4 File Offset: 0x000809E4
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.NullOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(op.Type))
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsEnumerationType(op.Type))
				{
					op.Type = global::System.Data.Entity.Core.Common.TypeHelpers.CreateEnumUnderlyingTypeUsage(op.Type);
				}
				else if (global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStrongSpatialType(op.Type))
				{
					op.Type = global::System.Data.Entity.Core.Common.TypeHelpers.CreateSpatialUnionTypeUsage(op.Type);
				}
				return n;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(op.Type);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> list2 = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>();
			if (typeInfo.HasTypeIdProperty)
			{
				list.Add(typeInfo.TypeIdProperty);
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage modelTypeUsage = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetModelTypeUsage(typeInfo.TypeIdProperty);
				list2.Add(this.CreateNullConstantNode(modelTypeUsage));
			}
			global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp op2 = new global::System.Data.Entity.Core.Query.InternalTrees.NewRecordOp(typeInfo.FlattenedTypeUsage, list);
			return this.m_command.CreateNode(op2, list2);
		}

		// Token: 0x0600292C RID: 10540 RVA: 0x000828A8 File Offset: 0x00080AA8
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.IsOfOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(op.IsOfType))
			{
				return n;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(op.IsOfType);
			return this.CreateTypeComparisonOp(n.Child0, typeInfo, op.IsOfOnly);
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000828F0 File Offset: 0x00080AF0
		public override global::System.Data.Entity.Core.Query.InternalTrees.Node Visit(global::System.Data.Entity.Core.Query.InternalTrees.TreatOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp scalarOp = (global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp)n.Child0.Op;
			if (op.IsFakeTreat || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsStructurallyEqual(scalarOp.Type, op.Type) || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsSubTypeOf(scalarOp.Type, op.Type))
			{
				return n.Child0;
			}
			if (!global::System.Data.Entity.Core.Query.PlanCompiler.TypeUtils.IsStructuredType(op.Type))
			{
				return n;
			}
			global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo = this.m_typeInfo.GetTypeInfo(op.Type);
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.CreateTypeComparisonOp(n.Child0, typeInfo, false);
			global::System.Data.Entity.Core.Query.InternalTrees.CaseOp caseOp = this.m_command.CreateCaseOp(typeInfo.FlattenedTypeUsage);
			global::System.Data.Entity.Core.Query.InternalTrees.Node n2 = this.m_command.CreateNode(caseOp, arg, n.Child0, this.CreateNullConstantNode(caseOp.Type));
			global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList desiredProperties = this.m_nodePropertyMap[n];
			return this.FlattenCaseOp(n2, typeInfo, desiredProperties);
		}

		// Token: 0x0600292E RID: 10542 RVA: 0x000829C8 File Offset: 0x00080BC8
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateTypeComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.Node input, global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, bool isExact)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = this.BuildTypeIdAccessor(input, typeInfo);
			global::System.Data.Entity.Core.Query.InternalTrees.Node result;
			if (isExact)
			{
				result = this.CreateTypeEqualsOp(typeInfo, node);
			}
			else if (typeInfo.RootType.DiscriminatorMap != null)
			{
				result = this.CreateDisjunctiveTypeComparisonOp(typeInfo, node);
			}
			else
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.CreateTypeIdConstantForPrefixMatch(typeInfo);
				global::System.Data.Entity.Core.Query.InternalTrees.LikeOp op = this.m_command.CreateLikeOp();
				result = this.m_command.CreateNode(op, node, arg, this.CreateNullConstantNode(this.DefaultTypeIdType));
			}
			return result;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x00082A38 File Offset: 0x00080C38
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateDisjunctiveTypeComparisonOp(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, global::System.Data.Entity.Core.Query.InternalTrees.Node typeIdProperty)
		{
			global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler.Assert(typeInfo.RootType.DiscriminatorMap != null, "should be used only for DiscriminatorMap type checks");
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo> enumerable = from t in typeInfo.GetTypeHierarchy()
			where !t.Type.EdmType.Abstract
			select t;
			global::System.Data.Entity.Core.Query.InternalTrees.Node node = null;
			foreach (global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo2 in enumerable)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.Node node2 = this.CreateTypeEqualsOp(typeInfo2, typeIdProperty);
				if (node == null)
				{
					node = node2;
				}
				else
				{
					node = this.m_command.CreateNode(this.m_command.CreateConditionalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.Or), node, node2);
				}
			}
			if (node == null)
			{
				node = this.m_command.CreateNode(this.m_command.CreateFalseOp());
			}
			return node;
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x00082B04 File Offset: 0x00080D04
		private global::System.Data.Entity.Core.Query.InternalTrees.Node CreateTypeEqualsOp(global::System.Data.Entity.Core.Query.PlanCompiler.TypeInfo typeInfo, global::System.Data.Entity.Core.Query.InternalTrees.Node typeIdProperty)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.Node arg = this.CreateTypeIdConstant(typeInfo);
			global::System.Data.Entity.Core.Query.InternalTrees.ComparisonOp op = this.m_command.CreateComparisonOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType.EQ, false);
			return this.m_command.CreateNode(op, typeIdProperty, arg);
		}

		// Token: 0x04000E30 RID: 3632
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> m_varPropertyMap;

		// Token: 0x04000E31 RID: 3633
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Node, global::System.Data.Entity.Core.Query.PlanCompiler.PropertyRefList> m_nodePropertyMap;

		// Token: 0x04000E32 RID: 3634
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.VarInfoMap m_varInfoMap;

		// Token: 0x04000E33 RID: 3635
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler m_compilerState;

		// Token: 0x04000E34 RID: 3636
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.StructuredTypeInfo m_typeInfo;

		// Token: 0x04000E35 RID: 3637
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]> m_tvfResultKeys;

		// Token: 0x04000E36 RID: 3638
		private readonly global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> m_typeToNewTypeMap;

		// Token: 0x04000E37 RID: 3639
		private const string PrefixMatchCharacter = "%";

		// Token: 0x020009EC RID: 2540
		internal enum OperationKind
		{
			// Token: 0x04002896 RID: 10390
			Equality,
			// Token: 0x04002897 RID: 10391
			IsNull,
			// Token: 0x04002898 RID: 10392
			GetIdentity,
			// Token: 0x04002899 RID: 10393
			GetKeys,
			// Token: 0x0400289A RID: 10394
			All
		}
	}
}
