using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml.Serialization;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200043B RID: 1083
	internal class EntityProxyFactory
	{
		// Token: 0x060034E7 RID: 13543 RVA: 0x000A901C File Offset: 0x000A721C
		private static global::System.Reflection.Emit.ModuleBuilder GetDynamicModule(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			global::System.Reflection.Assembly assembly = ospaceEntityType.ClrType.Assembly();
			global::System.Reflection.Emit.ModuleBuilder moduleBuilder;
			if (!global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._moduleBuilders.TryGetValue(assembly, out moduleBuilder))
			{
				moduleBuilder = global::System.Reflection.Emit.AssemblyBuilder.DefineDynamicAssembly(new global::System.Reflection.AssemblyName(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "EntityFrameworkDynamicProxies-{0}", new object[]
				{
					assembly.FullName
				}))
				{
					Version = new global::System.Version(1, 0, 0, 0)
				}, global::System.Reflection.Emit.AssemblyBuilderAccess.Run).DefineDynamicModule("EntityProxyModule");
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._moduleBuilders.Add(assembly, moduleBuilder);
			}
			return moduleBuilder;
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x000A9094 File Offset: 0x000A7294
		private static void DiscardDynamicModule(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._moduleBuilders.Remove(ospaceEntityType.ClrType.Assembly());
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x000A90AC File Offset: 0x000A72AC
		internal static bool TryGetProxyType(global::System.Type clrType, string entityTypeName, out global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo proxyTypeInfo)
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.EnterReadLock();
			bool result;
			try
			{
				result = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyNameMap.TryGetValue(new global::System.Tuple<global::System.Type, string>(clrType, entityTypeName), out proxyTypeInfo);
			}
			finally
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.ExitReadLock();
			}
			return result;
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x000A90F4 File Offset: 0x000A72F4
		internal static bool TryGetProxyType(global::System.Type proxyType, out global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo proxyTypeInfo)
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.EnterReadLock();
			bool result;
			try
			{
				result = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyTypeMap.TryGetValue(proxyType, out proxyTypeInfo);
			}
			finally
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.ExitReadLock();
			}
			return result;
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x000A9138 File Offset: 0x000A7338
		internal static bool TryGetProxyWrapper(object instance, out global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrapper)
		{
			wrapper = null;
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo;
			if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.IsProxyType(instance.GetType()) && global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetProxyType(instance.GetType(), out entityProxyTypeInfo))
			{
				wrapper = entityProxyTypeInfo.GetEntityWrapper(instance);
			}
			return wrapper != null;
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x000A9174 File Offset: 0x000A7374
		internal static global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo GetProxyType(global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType ospaceEntityType, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo = null;
			if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetProxyType(ospaceEntityType.ClrType, ospaceEntityType.CSpaceTypeName, out entityProxyTypeInfo))
			{
				if (entityProxyTypeInfo != null)
				{
					entityProxyTypeInfo.ValidateType(ospaceEntityType);
				}
				return entityProxyTypeInfo;
			}
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.EnterUpgradeableReadLock();
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo result;
			try
			{
				result = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryCreateProxyType(ospaceEntityType, workspace);
			}
			finally
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.ExitUpgradeableReadLock();
			}
			return result;
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000A91D4 File Offset: 0x000A73D4
		internal static bool TryGetAssociationTypeFromProxyInfo(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity, string relationshipName, out global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType)
		{
			associationType = null;
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo;
			return global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetProxyType(wrappedEntity.Entity.GetType(), out entityProxyTypeInfo) && entityProxyTypeInfo != null && entityProxyTypeInfo.TryGetNavigationPropertyAssociationType(relationshipName, out associationType);
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x000A9208 File Offset: 0x000A7408
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> TryGetAllAssociationTypesFromProxyInfo(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper wrappedEntity)
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo;
			if (!global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetProxyType(wrappedEntity.Entity.GetType(), out entityProxyTypeInfo))
			{
				return null;
			}
			return entityProxyTypeInfo.GetAllAssociationTypes();
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x000A9234 File Offset: 0x000A7434
		internal static void TryCreateProxyTypes(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> ospaceEntityTypes, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.EnterUpgradeableReadLock();
			try
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType in ospaceEntityTypes)
				{
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryCreateProxyType(ospaceEntityType, workspace);
				}
			}
			finally
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.ExitUpgradeableReadLock();
			}
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000A929C File Offset: 0x000A749C
		private static global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo TryCreateProxyType(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType clrEntityType = (global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType)ospaceEntityType;
			global::System.Tuple<global::System.Type, string> key = new global::System.Tuple<global::System.Type, string>(clrEntityType.ClrType, clrEntityType.HashedDescription);
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo;
			if (!global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyNameMap.TryGetValue(key, out entityProxyTypeInfo) && global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.CanProxyType(ospaceEntityType))
			{
				try
				{
					entityProxyTypeInfo = global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.BuildType(global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.GetDynamicModule(ospaceEntityType), clrEntityType, workspace);
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.EnterWriteLock();
					try
					{
						global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyNameMap[key] = entityProxyTypeInfo;
						if (entityProxyTypeInfo != null)
						{
							global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyTypeMap[entityProxyTypeInfo.ProxyType] = entityProxyTypeInfo;
						}
					}
					finally
					{
						global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.ExitWriteLock();
					}
				}
				catch
				{
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.DiscardDynamicModule(ospaceEntityType);
					throw;
				}
			}
			return entityProxyTypeInfo;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000A9348 File Offset: 0x000A7548
		internal static bool IsProxyType(global::System.Type type)
		{
			return type != null && global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyRuntimeAssemblies.Contains(type.Assembly());
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000A9368 File Offset: 0x000A7568
		internal static global::System.Collections.Generic.IEnumerable<global::System.Type> GetKnownProxyTypes()
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.EnterReadLock();
			global::System.Collections.Generic.IEnumerable<global::System.Type> result;
			try
			{
				result = (from info in global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyNameMap.Values
				where info != null
				select info.ProxyType).ToArray<global::System.Type>();
			}
			finally
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._typeMapLock.ExitReadLock();
			}
			return result;
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x000A93F8 File Offset: 0x000A75F8
		public virtual global::System.Func<object, object> CreateBaseGetter(global::System.Type declaringType, global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression;
			global::System.Func<object, object> nonProxyGetter = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object, object>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Convert(parameterExpression, declaringType), propertyInfo), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression
			}).Compile();
			string propertyName = propertyInfo.Name;
			return delegate(object entity)
			{
				global::System.Type type = entity.GetType();
				object result;
				if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.IsProxyType(type) && global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetBasePropertyValue(type, propertyName, entity, out result))
				{
					return result;
				}
				return nonProxyGetter(entity);
			};
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x000A9460 File Offset: 0x000A7660
		private static bool TryGetBasePropertyValue(global::System.Type proxyType, string propertyName, object entity, out object value)
		{
			value = null;
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo;
			if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetProxyType(proxyType, out entityProxyTypeInfo) && entityProxyTypeInfo.ContainsBaseGetter(propertyName))
			{
				value = entityProxyTypeInfo.BaseGetter(entity, propertyName);
				return true;
			}
			return false;
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000A9495 File Offset: 0x000A7695
		public virtual global::System.Action<object, object> CreateBaseSetter(global::System.Type declaringType, global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Action<object, object> nonProxySetter = global::System.Data.Entity.Core.Objects.DelegateFactory.CreateNavigationPropertySetter(declaringType, propertyInfo);
			string propertyName = propertyInfo.Name;
			return delegate(object entity, object value)
			{
				global::System.Type type = entity.GetType();
				if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.IsProxyType(type) && global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TrySetBasePropertyValue(type, propertyName, entity, value))
				{
					return;
				}
				nonProxySetter(entity, value);
			};
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x000A94C0 File Offset: 0x000A76C0
		private static bool TrySetBasePropertyValue(global::System.Type proxyType, string propertyName, object entity, object value)
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo;
			if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.TryGetProxyType(proxyType, out entityProxyTypeInfo) && entityProxyTypeInfo.ContainsBaseSetter(propertyName))
			{
				entityProxyTypeInfo.BaseSetter(entity, propertyName, value);
				return true;
			}
			return false;
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x000A94F4 File Offset: 0x000A76F4
		private static global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo BuildType(global::System.Reflection.Emit.ModuleBuilder moduleBuilder, global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType ospaceEntityType, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder proxyTypeBuilder = new global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder(ospaceEntityType);
			global::System.Type type = proxyTypeBuilder.CreateType(moduleBuilder);
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo entityProxyTypeInfo;
			if (type != null)
			{
				global::System.Reflection.Assembly assembly = type.Assembly();
				if (!global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyRuntimeAssemblies.Contains(assembly))
				{
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory._proxyRuntimeAssemblies.Add(assembly);
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.AddAssemblyToResolveList(assembly);
				}
				entityProxyTypeInfo = new global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo(type, ospaceEntityType, proxyTypeBuilder.CreateInitializeCollectionMethod(type), proxyTypeBuilder.BaseGetters, proxyTypeBuilder.BaseSetters, workspace);
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember member in proxyTypeBuilder.LazyLoadMembers)
				{
					global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.InterceptMember(member, type, entityProxyTypeInfo);
				}
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.SetResetFKSetterFlagDelegate(type, entityProxyTypeInfo);
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.SetCompareByteArraysDelegate(type);
			}
			else
			{
				entityProxyTypeInfo = null;
			}
			return entityProxyTypeInfo;
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x000A95B4 File Offset: 0x000A77B4
		private static void AddAssemblyToResolveList(global::System.Reflection.Assembly assembly)
		{
			try
			{
				global::System.AppDomain.CurrentDomain.AssemblyResolve += delegate(object _, global::System.ResolveEventArgs args)
				{
					if (!(args.Name == assembly.FullName))
					{
						return null;
					}
					return assembly;
				};
			}
			catch (global::System.MethodAccessException)
			{
			}
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x000A95FC File Offset: 0x000A77FC
		private static void InterceptMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Type proxyType, global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo proxyTypeInfo)
		{
			global::System.Reflection.PropertyInfo topProperty = proxyType.GetTopProperty(member.Name);
			global::System.Reflection.FieldInfo field = proxyType.GetField(global::System.Data.Entity.Core.Objects.Internal.LazyLoadImplementor.GetInterceptorFieldName(member.Name), global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic);
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.AssignInterceptionDelegate(global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.GetInterceptorDelegateMethod.MakeGenericMethod(new global::System.Type[]
			{
				proxyType,
				topProperty.PropertyType
			}).Invoke(null, new object[]
			{
				member,
				proxyTypeInfo.EntityWrapperDelegate
			}) as global::System.Delegate, field);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x000A966B File Offset: 0x000A786B
		private static void AssignInterceptionDelegate(global::System.Delegate interceptorDelegate, global::System.Reflection.FieldInfo interceptorField)
		{
			interceptorField.SetValue(null, interceptorDelegate);
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x000A9678 File Offset: 0x000A7878
		private static void SetResetFKSetterFlagDelegate(global::System.Type proxyType, global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo proxyTypeInfo)
		{
			global::System.Reflection.FieldInfo field = proxyType.GetField("_resetFKSetterFlag", global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic);
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.AssignInterceptionDelegate(global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.GetResetFKSetterFlagDelegate(proxyTypeInfo.EntityWrapperDelegate), field);
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x000A96A4 File Offset: 0x000A78A4
		private static global::System.Action<object> GetResetFKSetterFlagDelegate(global::System.Func<object, object> getEntityWrapperDelegate)
		{
			return delegate(object proxy)
			{
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ResetFKSetterFlag(getEntityWrapperDelegate(proxy));
			};
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x000A96C0 File Offset: 0x000A78C0
		private static void ResetFKSetterFlag(object wrappedEntityAsObject)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = (global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper)wrappedEntityAsObject;
			if (entityWrapper != null && entityWrapper.Context != null)
			{
				entityWrapper.Context.ObjectStateManager.EntityInvokingFKSetter = null;
			}
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000A96F0 File Offset: 0x000A78F0
		private static void SetCompareByteArraysDelegate(global::System.Type proxyType)
		{
			global::System.Reflection.FieldInfo field = proxyType.GetField("_compareByteArrays", global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.NonPublic);
			global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.AssignInterceptionDelegate(new global::System.Func<object, object, bool>(global::System.Data.Entity.Core.Common.Utils.ByValueEqualityComparer.Default.Equals), field);
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x000A9724 File Offset: 0x000A7924
		private static bool CanProxyType(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			global::System.Type clrType = ospaceEntityType.ClrType;
			if (!clrType.IsPublic() || clrType.IsSealed() || typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships).IsAssignableFrom(clrType) || ospaceEntityType.Abstract)
			{
				return false;
			}
			global::System.Reflection.ConstructorInfo declaredConstructor = clrType.GetDeclaredConstructor(new global::System.Type[0]);
			return declaredConstructor != null && ((declaredConstructor.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask) == global::System.Reflection.MethodAttributes.Public || (declaredConstructor.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask) == global::System.Reflection.MethodAttributes.Family || (declaredConstructor.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask) == global::System.Reflection.MethodAttributes.FamORAssem);
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x000A97A0 File Offset: 0x000A79A0
		private static bool CanProxyMethod(global::System.Reflection.MethodInfo method)
		{
			bool result = false;
			if (method != null)
			{
				global::System.Reflection.MethodAttributes methodAttributes = method.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask;
				result = (method.IsVirtual && !method.IsFinal && (methodAttributes == global::System.Reflection.MethodAttributes.Public || methodAttributes == global::System.Reflection.MethodAttributes.Family || methodAttributes == global::System.Reflection.MethodAttributes.FamORAssem));
			}
			return result;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000A97E5 File Offset: 0x000A79E5
		internal static bool CanProxyGetter(global::System.Reflection.PropertyInfo clrProperty)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.CanProxyMethod(clrProperty.Getter());
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000A97F2 File Offset: 0x000A79F2
		internal static bool CanProxySetter(global::System.Reflection.PropertyInfo clrProperty)
		{
			return global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.CanProxyMethod(clrProperty.Setter());
		}

		// Token: 0x0400110B RID: 4363
		internal const string ResetFKSetterFlagFieldName = "_resetFKSetterFlag";

		// Token: 0x0400110C RID: 4364
		internal const string CompareByteArraysFieldName = "_compareByteArrays";

		// Token: 0x0400110D RID: 4365
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Tuple<global::System.Type, string>, global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo> _proxyNameMap = new global::System.Collections.Generic.Dictionary<global::System.Tuple<global::System.Type, string>, global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo>();

		// Token: 0x0400110E RID: 4366
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo> _proxyTypeMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Core.Objects.Internal.EntityProxyTypeInfo>();

		// Token: 0x0400110F RID: 4367
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Reflection.Emit.ModuleBuilder> _moduleBuilders = new global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Reflection.Emit.ModuleBuilder>();

		// Token: 0x04001110 RID: 4368
		private static readonly global::System.Threading.ReaderWriterLockSlim _typeMapLock = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x04001111 RID: 4369
		private static readonly global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly> _proxyRuntimeAssemblies = new global::System.Collections.Generic.HashSet<global::System.Reflection.Assembly>();

		// Token: 0x04001112 RID: 4370
		internal static readonly global::System.Reflection.MethodInfo GetInterceptorDelegateMethod = typeof(global::System.Data.Entity.Core.Objects.Internal.LazyLoadBehavior).GetOnlyDeclaredMethod("GetInterceptorDelegate");

		// Token: 0x02000A45 RID: 2629
		internal class ProxyTypeBuilder
		{
			// Token: 0x06006188 RID: 24968 RVA: 0x0014F058 File Offset: 0x0014D258
			public ProxyTypeBuilder(global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType ospaceEntityType)
			{
				this._ospaceEntityType = ospaceEntityType;
				this._baseImplementor = new global::System.Data.Entity.Core.Objects.Internal.BaseProxyImplementor();
				this._ipocoImplementor = new global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor(ospaceEntityType);
				this._lazyLoadImplementor = new global::System.Data.Entity.Core.Objects.Internal.LazyLoadImplementor(ospaceEntityType);
				this._dataContractImplementor = new global::System.Data.Entity.Core.Objects.Internal.DataContractImplementor(ospaceEntityType);
				this._iserializableImplementor = new global::System.Data.Entity.Core.Objects.Internal.SerializableImplementor(ospaceEntityType);
			}

			// Token: 0x170010BA RID: 4282
			// (get) Token: 0x06006189 RID: 24969 RVA: 0x0014F0B9 File Offset: 0x0014D2B9
			public global::System.Type BaseType
			{
				get
				{
					return this._ospaceEntityType.ClrType;
				}
			}

			// Token: 0x0600618A RID: 24970 RVA: 0x0014F0C6 File Offset: 0x0014D2C6
			public global::System.Reflection.Emit.DynamicMethod CreateInitializeCollectionMethod(global::System.Type proxyType)
			{
				return this._ipocoImplementor.CreateInitializeCollectionMethod(proxyType);
			}

			// Token: 0x170010BB RID: 4283
			// (get) Token: 0x0600618B RID: 24971 RVA: 0x0014F0D4 File Offset: 0x0014D2D4
			public global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> BaseGetters
			{
				get
				{
					return this._baseImplementor.BaseGetters;
				}
			}

			// Token: 0x170010BC RID: 4284
			// (get) Token: 0x0600618C RID: 24972 RVA: 0x0014F0E1 File Offset: 0x0014D2E1
			public global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> BaseSetters
			{
				get
				{
					return this._baseImplementor.BaseSetters;
				}
			}

			// Token: 0x170010BD RID: 4285
			// (get) Token: 0x0600618D RID: 24973 RVA: 0x0014F0EE File Offset: 0x0014D2EE
			public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> LazyLoadMembers
			{
				get
				{
					return this._lazyLoadImplementor.Members;
				}
			}

			// Token: 0x0600618E RID: 24974 RVA: 0x0014F0FC File Offset: 0x0014D2FC
			public global::System.Type CreateType(global::System.Reflection.Emit.ModuleBuilder moduleBuilder)
			{
				this._moduleBuilder = moduleBuilder;
				bool flag = false;
				if (this._iserializableImplementor.TypeIsSuitable)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in this._ospaceEntityType.Members)
					{
						if (this._ipocoImplementor.CanProxyMember(edmMember) || this._lazyLoadImplementor.CanProxyMember(edmMember))
						{
							global::System.Reflection.PropertyInfo topProperty = this.BaseType.GetTopProperty(edmMember.Name);
							global::System.Reflection.Emit.PropertyBuilder propertyBuilder = this.TypeBuilder.DefineProperty(edmMember.Name, global::System.Reflection.PropertyAttributes.None, topProperty.PropertyType, global::System.Type.EmptyTypes);
							if (!this._ipocoImplementor.EmitMember(this.TypeBuilder, edmMember, propertyBuilder, topProperty, this._baseImplementor))
							{
								global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder.EmitBaseSetter(this.TypeBuilder, propertyBuilder, topProperty);
							}
							if (!this._lazyLoadImplementor.EmitMember(this.TypeBuilder, edmMember, propertyBuilder, topProperty, this._baseImplementor))
							{
								global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder.EmitBaseGetter(this.TypeBuilder, propertyBuilder, topProperty);
							}
							flag = true;
						}
					}
					if (this._typeBuilder != null)
					{
						this._baseImplementor.Implement(this.TypeBuilder);
						this._iserializableImplementor.Implement(this.TypeBuilder, this._serializedFields);
					}
				}
				if (!flag)
				{
					return null;
				}
				return this.TypeBuilder.CreateType();
			}

			// Token: 0x170010BE RID: 4286
			// (get) Token: 0x0600618F RID: 24975 RVA: 0x0014F25C File Offset: 0x0014D45C
			private global::System.Reflection.Emit.TypeBuilder TypeBuilder
			{
				get
				{
					if (this._typeBuilder == null)
					{
						global::System.Reflection.TypeAttributes typeAttributes = global::System.Reflection.TypeAttributes.Public | global::System.Reflection.TypeAttributes.Sealed;
						if ((this.BaseType.Attributes() & global::System.Reflection.TypeAttributes.Serializable) == global::System.Reflection.TypeAttributes.Serializable)
						{
							typeAttributes |= global::System.Reflection.TypeAttributes.Serializable;
						}
						string text = (this.BaseType.Name.Length <= 20) ? this.BaseType.Name : this.BaseType.Name.Substring(0, 20);
						string name = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "System.Data.Entity.DynamicProxies.{0}_{1}", new object[]
						{
							text,
							this._ospaceEntityType.HashedDescription
						});
						this._typeBuilder = this._moduleBuilder.DefineType(name, typeAttributes, this.BaseType, this._ipocoImplementor.Interfaces);
						this._typeBuilder.DefineDefaultConstructor(global::System.Reflection.MethodAttributes.FamANDAssem | global::System.Reflection.MethodAttributes.Family | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.SpecialName | global::System.Reflection.MethodAttributes.RTSpecialName);
						global::System.Action<global::System.Reflection.Emit.FieldBuilder, bool> registerField = new global::System.Action<global::System.Reflection.Emit.FieldBuilder, bool>(this.RegisterInstanceField);
						this._ipocoImplementor.Implement(this._typeBuilder, registerField);
						this._lazyLoadImplementor.Implement(this._typeBuilder, registerField);
						if (!this._iserializableImplementor.TypeImplementsISerializable)
						{
							this._dataContractImplementor.Implement(this._typeBuilder);
						}
					}
					return this._typeBuilder;
				}
			}

			// Token: 0x06006190 RID: 24976 RVA: 0x0014F388 File Offset: 0x0014D588
			private static void EmitBaseGetter(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Reflection.Emit.PropertyBuilder propertyBuilder, global::System.Reflection.PropertyInfo baseProperty)
			{
				if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.CanProxyGetter(baseProperty))
				{
					global::System.Reflection.MethodInfo methodInfo = baseProperty.Getter();
					global::System.Reflection.MethodAttributes methodAttributes = methodInfo.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask;
					global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("get_" + baseProperty.Name, methodAttributes | (global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.SpecialName), baseProperty.PropertyType, global::System.Type.EmptyTypes);
					global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
					propertyBuilder.SetGetMethod(methodBuilder);
				}
			}

			// Token: 0x06006191 RID: 24977 RVA: 0x0014F404 File Offset: 0x0014D604
			private static void EmitBaseSetter(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Reflection.Emit.PropertyBuilder propertyBuilder, global::System.Reflection.PropertyInfo baseProperty)
			{
				if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.CanProxySetter(baseProperty))
				{
					global::System.Reflection.MethodInfo methodInfo = baseProperty.Setter();
					global::System.Reflection.MethodAttributes methodAttributes = methodInfo.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask;
					global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("set_" + baseProperty.Name, methodAttributes | (global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.SpecialName), null, new global::System.Type[]
					{
						baseProperty.PropertyType
					});
					global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
					propertyBuilder.SetSetMethod(methodBuilder);
				}
			}

			// Token: 0x06006192 RID: 24978 RVA: 0x0014F490 File Offset: 0x0014D690
			private void RegisterInstanceField(global::System.Reflection.Emit.FieldBuilder field, bool serializable)
			{
				if (serializable)
				{
					this._serializedFields.Add(field);
					return;
				}
				global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder.MarkAsNotSerializable(field);
			}

			// Token: 0x06006193 RID: 24979 RVA: 0x0014F4A8 File Offset: 0x0014D6A8
			private static global::System.Reflection.ConstructorInfo TryGetScriptIgnoreAttributeConstructor()
			{
				try
				{
					if (global::System.Data.Entity.Core.Metadata.Edm.AspProxy.IsSystemWebLoaded())
					{
						global::System.Type type = global::System.Reflection.Assembly.Load("System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35").GetType("System.Web.Script.Serialization.ScriptIgnoreAttribute");
						if (type != null)
						{
							return type.GetDeclaredConstructor(new global::System.Type[0]);
						}
					}
				}
				catch
				{
				}
				return null;
			}

			// Token: 0x06006194 RID: 24980 RVA: 0x0014F504 File Offset: 0x0014D704
			public static void MarkAsNotSerializable(global::System.Reflection.Emit.FieldBuilder field)
			{
				object[] constructorArgs = new object[0];
				field.SetCustomAttribute(new global::System.Reflection.Emit.CustomAttributeBuilder(global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder._nonSerializedAttributeConstructor, constructorArgs));
				if (field.IsPublic)
				{
					field.SetCustomAttribute(new global::System.Reflection.Emit.CustomAttributeBuilder(global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder._ignoreDataMemberAttributeConstructor, constructorArgs));
					field.SetCustomAttribute(new global::System.Reflection.Emit.CustomAttributeBuilder(global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder._xmlIgnoreAttributeConstructor, constructorArgs));
					if (global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder._scriptIgnoreAttributeConstructor.Value != null)
					{
						field.SetCustomAttribute(new global::System.Reflection.Emit.CustomAttributeBuilder(global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder._scriptIgnoreAttributeConstructor.Value, constructorArgs));
					}
				}
			}

			// Token: 0x04002A44 RID: 10820
			private global::System.Reflection.Emit.TypeBuilder _typeBuilder;

			// Token: 0x04002A45 RID: 10821
			private readonly global::System.Data.Entity.Core.Objects.Internal.BaseProxyImplementor _baseImplementor;

			// Token: 0x04002A46 RID: 10822
			private readonly global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor _ipocoImplementor;

			// Token: 0x04002A47 RID: 10823
			private readonly global::System.Data.Entity.Core.Objects.Internal.LazyLoadImplementor _lazyLoadImplementor;

			// Token: 0x04002A48 RID: 10824
			private readonly global::System.Data.Entity.Core.Objects.Internal.DataContractImplementor _dataContractImplementor;

			// Token: 0x04002A49 RID: 10825
			private readonly global::System.Data.Entity.Core.Objects.Internal.SerializableImplementor _iserializableImplementor;

			// Token: 0x04002A4A RID: 10826
			private readonly global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType _ospaceEntityType;

			// Token: 0x04002A4B RID: 10827
			private global::System.Reflection.Emit.ModuleBuilder _moduleBuilder;

			// Token: 0x04002A4C RID: 10828
			private readonly global::System.Collections.Generic.List<global::System.Reflection.Emit.FieldBuilder> _serializedFields = new global::System.Collections.Generic.List<global::System.Reflection.Emit.FieldBuilder>(3);

			// Token: 0x04002A4D RID: 10829
			private static readonly global::System.Reflection.ConstructorInfo _nonSerializedAttributeConstructor = typeof(global::System.NonSerializedAttribute).GetDeclaredConstructor(new global::System.Type[0]);

			// Token: 0x04002A4E RID: 10830
			private static readonly global::System.Reflection.ConstructorInfo _ignoreDataMemberAttributeConstructor = typeof(global::System.Runtime.Serialization.IgnoreDataMemberAttribute).GetDeclaredConstructor(new global::System.Type[0]);

			// Token: 0x04002A4F RID: 10831
			private static readonly global::System.Reflection.ConstructorInfo _xmlIgnoreAttributeConstructor = typeof(global::System.Xml.Serialization.XmlIgnoreAttribute).GetDeclaredConstructor(new global::System.Type[0]);

			// Token: 0x04002A50 RID: 10832
			private static readonly global::System.Lazy<global::System.Reflection.ConstructorInfo> _scriptIgnoreAttributeConstructor = new global::System.Lazy<global::System.Reflection.ConstructorInfo>(new global::System.Func<global::System.Reflection.ConstructorInfo>(global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.ProxyTypeBuilder.TryGetScriptIgnoreAttributeConstructor));
		}
	}
}
