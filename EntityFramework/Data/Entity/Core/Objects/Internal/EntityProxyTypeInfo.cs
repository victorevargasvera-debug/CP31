using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200043D RID: 1085
	internal sealed class EntityProxyTypeInfo
	{
		// Token: 0x06003508 RID: 13576 RVA: 0x000A9888 File Offset: 0x000A7A88
		internal EntityProxyTypeInfo(global::System.Type proxyType, global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType ospaceEntityType, global::System.Reflection.Emit.DynamicMethod initializeCollections, global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> baseGetters, global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> baseSetters, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			this._proxyType = proxyType;
			this._entityType = ospaceEntityType;
			this._initializeCollections = initializeCollections;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo.GetAllRelationshipsForType(workspace, proxyType))
			{
				this._navigationPropertyAssociationTypes.Add(associationType.FullName, associationType);
				if (associationType.Name != associationType.FullName)
				{
					this._navigationPropertyAssociationTypes.Add(associationType.Name, associationType);
				}
			}
			global::System.Reflection.FieldInfo field = proxyType.GetField("_entityWrapper", global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "proxy");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "value");
			global::System.Linq.Expressions.Expression<global::System.Func<object, object>> expression = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object, object>>(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Convert(parameterExpression, field.DeclaringType), field), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			});
			global::System.Func<object, object> getEntityWrapperDelegate = expression.Compile();
			this.Proxy_GetEntityWrapper = delegate(object proxy)
			{
				global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper)getEntityWrapperDelegate(proxy);
				if (entityWrapper != null && entityWrapper.Entity != proxy)
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityProxyTypeInfo_ProxyHasWrongWrapper);
				}
				return entityWrapper;
			};
			this.Proxy_SetEntityWrapper = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object, object, object>>(global::System.Linq.Expressions.Expression.Assign(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Convert(parameterExpression, field.DeclaringType), field), parameterExpression2), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
			global::System.Linq.Expressions.ParameterExpression parameterExpression3 = global::System.Linq.Expressions.Expression.Parameter(typeof(string), "propertyName");
			global::System.Reflection.MethodInfo publicInstanceMethod = proxyType.GetPublicInstanceMethod("GetBasePropertyValue", new global::System.Type[]
			{
				typeof(string)
			});
			if (publicInstanceMethod != null)
			{
				this._baseGetter = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object, string, object>>(global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Convert(parameterExpression, proxyType), publicInstanceMethod, new global::System.Linq.Expressions.Expression[]
				{
					parameterExpression3
				}), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression,
					parameterExpression3
				}).Compile();
			}
			global::System.Linq.Expressions.ParameterExpression parameterExpression4 = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "propertyName");
			global::System.Reflection.MethodInfo publicInstanceMethod2 = proxyType.GetPublicInstanceMethod("SetBasePropertyValue", new global::System.Type[]
			{
				typeof(string),
				typeof(object)
			});
			if (publicInstanceMethod2 != null)
			{
				this._baseSetter = global::System.Linq.Expressions.Expression.Lambda<global::System.Action<object, string, object>>(global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Convert(parameterExpression, proxyType), publicInstanceMethod2, parameterExpression3, parameterExpression4), new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression,
					parameterExpression3,
					parameterExpression4
				}).Compile();
			}
			this._propertiesWithBaseGetter = new global::System.Collections.Generic.HashSet<string>(from p in baseGetters
			select p.Name);
			this._propertiesWithBaseSetter = new global::System.Collections.Generic.HashSet<string>(from p in baseSetters
			select p.Name);
			this._createObject = global::System.Data.Entity.Core.Objects.DelegateFactory.CreateConstructor(proxyType);
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x000A9B58 File Offset: 0x000A7D58
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> GetAllRelationshipsForType(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Type clrType)
		{
			return from a in ((global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)).GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>()
			where global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo.IsEndMemberForType(a.AssociationEndMembers[0], clrType) || global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo.IsEndMemberForType(a.AssociationEndMembers[1], clrType)
			select a;
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x000A9B94 File Offset: 0x000A7D94
		private static bool IsEndMemberForType(global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember end, global::System.Type clrType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.RefType refType = end.TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.RefType;
			return refType != null && refType.ElementType.ClrType.IsAssignableFrom(clrType);
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x000A9BC8 File Offset: 0x000A7DC8
		internal object CreateProxyObject()
		{
			return this._createObject();
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x000A9BD5 File Offset: 0x000A7DD5
		internal global::System.Type ProxyType
		{
			get
			{
				return this._proxyType;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x000A9BDD File Offset: 0x000A7DDD
		internal global::System.Reflection.Emit.DynamicMethod InitializeEntityCollections
		{
			get
			{
				return this._initializeCollections;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x000A9BE5 File Offset: 0x000A7DE5
		public global::System.Func<object, string, object> BaseGetter
		{
			get
			{
				return this._baseGetter;
			}
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x000A9BED File Offset: 0x000A7DED
		public bool ContainsBaseGetter(string propertyName)
		{
			return this.BaseGetter != null && this._propertiesWithBaseGetter.Contains(propertyName);
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x000A9C05 File Offset: 0x000A7E05
		public bool ContainsBaseSetter(string propertyName)
		{
			return this.BaseSetter != null && this._propertiesWithBaseSetter.Contains(propertyName);
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x000A9C1D File Offset: 0x000A7E1D
		public global::System.Action<object, string, object> BaseSetter
		{
			get
			{
				return this._baseSetter;
			}
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x000A9C25 File Offset: 0x000A7E25
		public bool TryGetNavigationPropertyAssociationType(string relationshipName, out global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			return this._navigationPropertyAssociationTypes.TryGetValue(relationshipName, out associationType);
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x000A9C34 File Offset: 0x000A7E34
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> GetAllAssociationTypes()
		{
			return this._navigationPropertyAssociationTypes.Values.Distinct<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x000A9C46 File Offset: 0x000A7E46
		public void ValidateType(global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType ospaceEntityType)
		{
			if (ospaceEntityType != this._entityType && ospaceEntityType.HashedDescription != this._entityType.HashedDescription)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.EntityProxyTypeInfo_DuplicateOSpaceType(ospaceEntityType.ClrType.FullName));
			}
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x000A9C7F File Offset: 0x000A7E7F
		internal global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper SetEntityWrapper(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper)
		{
			return this.Proxy_SetEntityWrapper(wrapper.Entity, wrapper) as global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper;
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x000A9C98 File Offset: 0x000A7E98
		internal global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper GetEntityWrapper(object entity)
		{
			return this.Proxy_GetEntityWrapper(entity) as global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper;
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x000A9CAB File Offset: 0x000A7EAB
		internal global::System.Func<object, object> EntityWrapperDelegate
		{
			get
			{
				return this.Proxy_GetEntityWrapper;
			}
		}

		// Token: 0x04001115 RID: 4373
		private readonly global::System.Type _proxyType;

		// Token: 0x04001116 RID: 4374
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType _entityType;

		// Token: 0x04001117 RID: 4375
		internal const string EntityWrapperFieldName = "_entityWrapper";

		// Token: 0x04001118 RID: 4376
		private const string InitializeEntityCollectionsName = "InitializeEntityCollections";

		// Token: 0x04001119 RID: 4377
		private readonly global::System.Reflection.Emit.DynamicMethod _initializeCollections;

		// Token: 0x0400111A RID: 4378
		private readonly global::System.Func<object, string, object> _baseGetter;

		// Token: 0x0400111B RID: 4379
		private readonly global::System.Collections.Generic.HashSet<string> _propertiesWithBaseGetter;

		// Token: 0x0400111C RID: 4380
		private readonly global::System.Action<object, string, object> _baseSetter;

		// Token: 0x0400111D RID: 4381
		private readonly global::System.Collections.Generic.HashSet<string> _propertiesWithBaseSetter;

		// Token: 0x0400111E RID: 4382
		private readonly global::System.Func<object, object> Proxy_GetEntityWrapper;

		// Token: 0x0400111F RID: 4383
		private readonly global::System.Func<object, object, object> Proxy_SetEntityWrapper;

		// Token: 0x04001120 RID: 4384
		private readonly global::System.Func<object> _createObject;

		// Token: 0x04001121 RID: 4385
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.AssociationType> _navigationPropertyAssociationTypes = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
	}
}
