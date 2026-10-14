using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000513 RID: 1299
	internal sealed class ObjectItemAttributeAssemblyLoader : global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader
	{
		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06004005 RID: 16389 RVA: 0x000D3F20 File Offset: 0x000D2120
		private new global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry CacheEntry
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry)base.CacheEntry;
			}
		}

		// Token: 0x06004006 RID: 16390 RVA: 0x000D3F2D File Offset: 0x000D212D
		internal ObjectItemAttributeAssemblyLoader(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData) : base(assembly, new global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry(), sessionData)
		{
		}

		// Token: 0x06004007 RID: 16391 RVA: 0x000D3F54 File Offset: 0x000D2154
		internal override void OnLevel1SessionProcessing()
		{
			foreach (global::System.Action action in this._referenceResolutions)
			{
				action();
			}
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x000D3FA4 File Offset: 0x000D21A4
		internal override void OnLevel2SessionProcessing()
		{
			foreach (global::System.Action action in this._unresolvedNavigationProperties)
			{
				action();
			}
		}

		// Token: 0x06004009 RID: 16393 RVA: 0x000D3FF4 File Offset: 0x000D21F4
		internal override void Load()
		{
			base.Load();
		}

		// Token: 0x0600400A RID: 16394 RVA: 0x000D3FFC File Offset: 0x000D21FC
		protected override void AddToAssembliesLoaded()
		{
			base.SessionData.AssembliesLoaded.Add(base.SourceAssembly, this.CacheEntry);
		}

		// Token: 0x0600400B RID: 16395 RVA: 0x000D401C File Offset: 0x000D221C
		private bool TryGetLoadedType(global::System.Type clrType, out global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			if (base.SessionData.TypesInLoading.TryGetValue(clrType.FullName, out edmType) || this.TryGetCachedEdmType(clrType, out edmType))
			{
				if (edmType.ClrType != clrType)
				{
					base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NewTypeConflictsWithExistingType(clrType.AssemblyQualifiedName, edmType.ClrType.AssemblyQualifiedName)));
					edmType = null;
					return false;
				}
				return true;
			}
			else
			{
				if (!clrType.IsGenericType())
				{
					edmType = null;
					return false;
				}
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2;
				if (!this.TryGetLoadedType(clrType.GetGenericArguments()[0], out edmType2))
				{
					return false;
				}
				if (typeof(global::System.Collections.IEnumerable).IsAssignableFrom(clrType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = edmType2 as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
					if (entityType == null)
					{
						return false;
					}
					edmType = entityType.GetCollectionType();
				}
				else
				{
					edmType = edmType2;
				}
				return true;
			}
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x000D40DC File Offset: 0x000D22DC
		private bool TryGetCachedEdmType(global::System.Type clrType, out global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry immutableAssemblyCacheEntry;
			if (base.SessionData.LockedAssemblyCache.TryGetValue(clrType.Assembly(), out immutableAssemblyCacheEntry))
			{
				return immutableAssemblyCacheEntry.TryGetEdmType(clrType.FullName, out edmType);
			}
			edmType = null;
			return false;
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x000D4118 File Offset: 0x000D2318
		protected override void LoadTypesFromAssembly()
		{
			this.LoadRelationshipTypes();
			foreach (global::System.Type type in base.SourceAssembly.GetAccessibleTypes())
			{
				if (type.GetCustomAttributes(false).Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmTypeAttribute>())
				{
					if (type.IsGenericType())
					{
						base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.GenericTypeNotSupported(type.FullName)));
					}
					else
					{
						this.LoadType(type);
					}
				}
			}
			if (this._referenceResolutions.Count != 0)
			{
				base.SessionData.RegisterForLevel1PostSessionProcessing(this);
			}
			if (this._unresolvedNavigationProperties.Count != 0)
			{
				base.SessionData.RegisterForLevel2PostSessionProcessing(this);
			}
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x000D41DC File Offset: 0x000D23DC
		private void LoadRelationshipTypes()
		{
			foreach (global::System.Data.Entity.Core.Objects.DataClasses.EdmRelationshipAttribute edmRelationshipAttribute in base.SourceAssembly.GetCustomAttributes<global::System.Data.Entity.Core.Objects.DataClasses.EdmRelationshipAttribute>())
			{
				if (!this.TryFindNullParametersInRelationshipAttribute(edmRelationshipAttribute))
				{
					bool flag = false;
					if (edmRelationshipAttribute.Role1Name == edmRelationshipAttribute.Role2Name)
					{
						base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.SameRoleNameOnRelationshipAttribute(edmRelationshipAttribute.RelationshipName, edmRelationshipAttribute.Role2Name)));
						flag = true;
					}
					if (!flag)
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = new global::System.Data.Entity.Core.Metadata.Edm.AssociationType(edmRelationshipAttribute.RelationshipName, edmRelationshipAttribute.RelationshipNamespaceName, edmRelationshipAttribute.IsForeignKey, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
						base.SessionData.TypesInLoading.Add(associationType.FullName, associationType);
						this.TrackClosure(edmRelationshipAttribute.Role1Type);
						this.TrackClosure(edmRelationshipAttribute.Role2Type);
						string r1Name = edmRelationshipAttribute.Role1Name;
						global::System.Type r1Type = edmRelationshipAttribute.Role1Type;
						global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity r1Multiplicity = edmRelationshipAttribute.Role1Multiplicity;
						this.AddTypeResolver(delegate
						{
							this.ResolveAssociationEnd(associationType, r1Name, r1Type, r1Multiplicity);
						});
						string r2Name = edmRelationshipAttribute.Role2Name;
						global::System.Type r2Type = edmRelationshipAttribute.Role2Type;
						global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity r2Multiplicity = edmRelationshipAttribute.Role2Multiplicity;
						this.AddTypeResolver(delegate
						{
							this.ResolveAssociationEnd(associationType, r2Name, r2Type, r2Multiplicity);
						});
						this.CacheEntry.TypesInAssembly.Add(associationType);
					}
				}
			}
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x000D4370 File Offset: 0x000D2570
		private void ResolveAssociationEnd(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, string roleName, global::System.Type clrType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType;
			if (!this.TryGetRelationshipEndEntityType(clrType, out entityType))
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.RoleTypeInEdmRelationshipAttributeIsInvalidType(associationType.Name, roleName, clrType)));
				return;
			}
			associationType.AddKeyMember(new global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember(roleName, entityType.GetReferenceType(), multiplicity));
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x000D43C0 File Offset: 0x000D25C0
		private void LoadType(global::System.Type clrType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = null;
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.DataClasses.EdmTypeAttribute> customAttributes = clrType.GetCustomAttributes(false);
			if (!customAttributes.Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmTypeAttribute>())
			{
				return;
			}
			if (clrType.IsNested)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NestedClassNotSupported(clrType.FullName, clrType.Assembly().FullName)));
				return;
			}
			global::System.Data.Entity.Core.Objects.DataClasses.EdmTypeAttribute edmTypeAttribute = customAttributes.First<global::System.Data.Entity.Core.Objects.DataClasses.EdmTypeAttribute>();
			string cspaceTypeName = string.IsNullOrEmpty(edmTypeAttribute.Name) ? clrType.Name : edmTypeAttribute.Name;
			if (string.IsNullOrEmpty(edmTypeAttribute.NamespaceName) && clrType.Namespace == null)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_TypeHasNoNamespace));
				return;
			}
			string cspaceNamespaceName = string.IsNullOrEmpty(edmTypeAttribute.NamespaceName) ? clrType.Namespace : edmTypeAttribute.NamespaceName;
			if (edmTypeAttribute.GetType() == typeof(global::System.Data.Entity.Core.Objects.DataClasses.EdmEntityTypeAttribute))
			{
				edmType = new global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType(clrType, cspaceNamespaceName, cspaceTypeName);
			}
			else if (edmTypeAttribute.GetType() == typeof(global::System.Data.Entity.Core.Objects.DataClasses.EdmComplexTypeAttribute))
			{
				edmType = new global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType(clrType, cspaceNamespaceName, cspaceTypeName);
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
				if (!global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(clrType.GetEnumUnderlyingType(), out primitiveType))
				{
					base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_UnsupportedEnumUnderlyingType(clrType.GetEnumUnderlyingType().FullName)));
					return;
				}
				edmType = new global::System.Data.Entity.Core.Metadata.Edm.ClrEnumType(clrType, cspaceNamespaceName, cspaceTypeName);
			}
			this.CacheEntry.TypesInAssembly.Add(edmType);
			base.SessionData.TypesInLoading.Add(clrType.FullName, edmType);
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStructuralType(edmType))
			{
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType))
				{
					this.TrackClosure(clrType.BaseType());
					this.AddTypeResolver(delegate
					{
						edmType.BaseType = this.ResolveBaseType(clrType.BaseType());
					});
				}
				this.LoadPropertiesFromType((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)edmType);
			}
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x000D45FF File Offset: 0x000D27FF
		private void AddTypeResolver(global::System.Action resolver)
		{
			this._referenceResolutions.Add(resolver);
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x000D4610 File Offset: 0x000D2810
		private global::System.Data.Entity.Core.Metadata.Edm.EdmType ResolveBaseType(global::System.Type type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType result;
			if (type.GetCustomAttributes(false).Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmEntityTypeAttribute>() && this.TryGetLoadedType(type, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x000D463C File Offset: 0x000D283C
		private bool TryFindNullParametersInRelationshipAttribute(global::System.Data.Entity.Core.Objects.DataClasses.EdmRelationshipAttribute roleAttribute)
		{
			if (roleAttribute.RelationshipName == null)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NullRelationshipNameforEdmRelationshipAttribute(base.SourceAssembly.FullName)));
				return true;
			}
			bool result = false;
			if (roleAttribute.RelationshipNamespaceName == null)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NullParameterForEdmRelationshipAttribute("RelationshipNamespaceName", roleAttribute.RelationshipName)));
				result = true;
			}
			if (roleAttribute.Role1Name == null)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NullParameterForEdmRelationshipAttribute("Role1Name", roleAttribute.RelationshipName)));
				result = true;
			}
			if (roleAttribute.Role1Type == null)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NullParameterForEdmRelationshipAttribute("Role1Type", roleAttribute.RelationshipName)));
				result = true;
			}
			if (roleAttribute.Role2Name == null)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NullParameterForEdmRelationshipAttribute("Role2Name", roleAttribute.RelationshipName)));
				result = true;
			}
			if (roleAttribute.Role2Type == null)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NullParameterForEdmRelationshipAttribute("Role2Type", roleAttribute.RelationshipName)));
				result = true;
			}
			return result;
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x000D4774 File Offset: 0x000D2974
		private bool TryGetRelationshipEndEntityType(global::System.Type type, out global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType)
		{
			if (type == null)
			{
				entityType = null;
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (!this.TryGetLoadedType(type, out edmType) || !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(edmType))
			{
				entityType = null;
				return false;
			}
			entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)edmType;
			return true;
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x000D47B0 File Offset: 0x000D29B0
		private void LoadPropertiesFromType(global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType)
		{
			foreach (global::System.Reflection.PropertyInfo propertyInfo in from p in structuralType.ClrType.GetDeclaredProperties()
			where !p.IsStatic()
			select p)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = null;
				bool flag = false;
				if (propertyInfo.GetCustomAttributes(false).Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute>())
				{
					global::System.Reflection.PropertyInfo pi = propertyInfo;
					this._unresolvedNavigationProperties.Add(delegate
					{
						this.ResolveNavigationProperty(structuralType, pi);
					});
				}
				else if (propertyInfo.GetCustomAttributes(false).Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmScalarPropertyAttribute>())
				{
					if ((global::System.Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType).IsEnum())
					{
						this.TrackClosure(propertyInfo.PropertyType);
						global::System.Reflection.PropertyInfo local = propertyInfo;
						this.AddTypeResolver(delegate
						{
							this.ResolveEnumTypeProperty(structuralType, local);
						});
					}
					else
					{
						edmMember = this.LoadScalarProperty(structuralType.ClrType, propertyInfo, out flag);
					}
				}
				else if (propertyInfo.GetCustomAttributes(false).Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmComplexPropertyAttribute>())
				{
					this.TrackClosure(propertyInfo.PropertyType);
					global::System.Reflection.PropertyInfo local = propertyInfo;
					this.AddTypeResolver(delegate
					{
						this.ResolveComplexTypeProperty(structuralType, local);
					});
				}
				if (edmMember != null)
				{
					structuralType.AddMember(edmMember);
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(structuralType) && flag)
					{
						((global::System.Data.Entity.Core.Metadata.Edm.EntityType)structuralType).AddKeyMember(edmMember);
					}
				}
			}
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x000D4980 File Offset: 0x000D2B80
		internal void ResolveNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.StructuralType declaringType, global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute> customAttributes = propertyInfo.GetCustomAttributes(false);
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (!this.TryGetLoadedType(propertyInfo.PropertyType, out edmType) || (edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType && edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType))
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_InvalidNavPropReturnType(propertyInfo.Name, propertyInfo.DeclaringType.FullName, propertyInfo.PropertyType.FullName)));
				return;
			}
			global::System.Data.Entity.Core.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute edmRelationshipNavigationPropertyAttribute = customAttributes.First<global::System.Data.Entity.Core.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute>();
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = null;
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2;
			if (base.SessionData.TypesInLoading.TryGetValue(edmRelationshipNavigationPropertyAttribute.RelationshipNamespaceName + "." + edmRelationshipNavigationPropertyAttribute.RelationshipName, out edmType2) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationType(edmType2))
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)edmType2;
				if (associationType != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = new global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty(propertyInfo.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType));
					navigationProperty.RelationshipType = associationType;
					edmMember = navigationProperty;
					if (associationType.Members[0].Name == edmRelationshipNavigationPropertyAttribute.TargetRoleName)
					{
						navigationProperty.ToEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)associationType.Members[0];
						navigationProperty.FromEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)associationType.Members[1];
					}
					else if (associationType.Members[1].Name == edmRelationshipNavigationPropertyAttribute.TargetRoleName)
					{
						navigationProperty.ToEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)associationType.Members[1];
						navigationProperty.FromEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)associationType.Members[0];
					}
					else
					{
						base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.TargetRoleNameInNavigationPropertyNotValid(propertyInfo.Name, propertyInfo.DeclaringType.FullName, edmRelationshipNavigationPropertyAttribute.TargetRoleName, edmRelationshipNavigationPropertyAttribute.RelationshipName)));
						edmMember = null;
					}
					if (edmMember != null && ((global::System.Data.Entity.Core.Metadata.Edm.RefType)navigationProperty.FromEndMember.TypeUsage.EdmType).ElementType.ClrType != declaringType.ClrType)
					{
						base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.NavigationPropertyRelationshipEndTypeMismatch(declaringType.FullName, navigationProperty.Name, associationType.FullName, navigationProperty.FromEndMember.Name, ((global::System.Data.Entity.Core.Metadata.Edm.RefType)navigationProperty.FromEndMember.TypeUsage.EdmType).ElementType.ClrType)));
						edmMember = null;
					}
				}
			}
			else
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.RelationshipNameInNavigationPropertyNotValid(propertyInfo.Name, propertyInfo.DeclaringType.FullName, edmRelationshipNavigationPropertyAttribute.RelationshipName)));
			}
			if (edmMember != null)
			{
				declaringType.AddMember(edmMember);
			}
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x000D4C14 File Offset: 0x000D2E14
		private global::System.Data.Entity.Core.Metadata.Edm.EdmMember LoadScalarProperty(global::System.Type clrType, global::System.Reflection.PropertyInfo property, out bool isEntityKeyProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember result = null;
			isEntityKeyProperty = false;
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType edmType;
			if (!global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader.TryGetPrimitiveType(property.PropertyType, out edmType))
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_ScalarPropertyNotPrimitive(property.Name, property.DeclaringType.FullName, property.PropertyType.FullName)));
			}
			else
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.DataClasses.EdmScalarPropertyAttribute> customAttributes = property.GetCustomAttributes(false);
				isEntityKeyProperty = customAttributes.First<global::System.Data.Entity.Core.Objects.DataClasses.EdmScalarPropertyAttribute>().EntityKeyProperty;
				bool isNullable = customAttributes.First<global::System.Data.Entity.Core.Objects.DataClasses.EdmScalarPropertyAttribute>().IsNullable;
				result = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(property.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					Nullable = new bool?(isNullable)
				}), property, clrType);
			}
			return result;
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x000D4CBC File Offset: 0x000D2EBC
		private void ResolveEnumTypeProperty(global::System.Data.Entity.Core.Metadata.Edm.StructuralType declaringType, global::System.Reflection.PropertyInfo clrProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (!this.TryGetLoadedType(clrProperty.PropertyType, out edmType) || !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(edmType))
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_ScalarPropertyNotPrimitive(clrProperty.Name, clrProperty.DeclaringType.FullName, clrProperty.PropertyType.FullName)));
				return;
			}
			global::System.Data.Entity.Core.Objects.DataClasses.EdmScalarPropertyAttribute edmScalarPropertyAttribute = clrProperty.GetCustomAttributes(false).Single<global::System.Data.Entity.Core.Objects.DataClasses.EdmScalarPropertyAttribute>();
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(clrProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				Nullable = new bool?(edmScalarPropertyAttribute.IsNullable)
			}), clrProperty, declaringType.ClrType);
			declaringType.AddMember(member);
			if (declaringType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType && edmScalarPropertyAttribute.EntityKeyProperty)
			{
				((global::System.Data.Entity.Core.Metadata.Edm.EntityType)declaringType).AddKeyMember(member);
			}
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x000D4D80 File Offset: 0x000D2F80
		private void ResolveComplexTypeProperty(global::System.Data.Entity.Core.Metadata.Edm.StructuralType type, global::System.Reflection.PropertyInfo clrProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (!this.TryGetLoadedType(clrProperty.PropertyType, out edmType) || edmType.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType)
			{
				base.SessionData.EdmItemErrors.Add(new global::System.Data.Entity.Core.Metadata.Edm.EdmItemError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_ComplexPropertyNotComplex(clrProperty.Name, clrProperty.DeclaringType.FullName, clrProperty.PropertyType.FullName)));
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(clrProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				Nullable = new bool?(false)
			}), clrProperty, type.ClrType);
			type.AddMember(member);
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x000D4E14 File Offset: 0x000D3014
		private void TrackClosure(global::System.Type type)
		{
			if (base.SourceAssembly != type.Assembly() && !this.CacheEntry.ClosureAssemblies.Contains(type.Assembly()) && global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader.IsSchemaAttributePresent(type.Assembly()) && (!type.IsGenericType() || (!global::System.Data.Entity.Core.EntityUtil.IsAnICollection(type) && !(type.GetGenericTypeDefinition() == typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<>)) && !(type.GetGenericTypeDefinition() == typeof(global::System.Nullable<>)))))
			{
				this.CacheEntry.ClosureAssemblies.Add(type.Assembly());
			}
			if (type.IsGenericType())
			{
				foreach (global::System.Type type2 in type.GetGenericArguments())
				{
					this.TrackClosure(type2);
				}
			}
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x000D4ED5 File Offset: 0x000D30D5
		internal static bool IsSchemaAttributePresent(global::System.Reflection.Assembly assembly)
		{
			return assembly.GetCustomAttributes<global::System.Data.Entity.Core.Objects.DataClasses.EdmSchemaAttribute>().Any<global::System.Data.Entity.Core.Objects.DataClasses.EdmSchemaAttribute>();
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x000D4EE2 File Offset: 0x000D30E2
		internal static global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader Create(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData)
		{
			if (!global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader.IsSchemaAttributePresent(assembly))
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemNoOpAssemblyLoader(assembly, sessionData);
			}
			return new global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAttributeAssemblyLoader(assembly, sessionData);
		}

		// Token: 0x04001657 RID: 5719
		private readonly global::System.Collections.Generic.List<global::System.Action> _unresolvedNavigationProperties = new global::System.Collections.Generic.List<global::System.Action>();

		// Token: 0x04001658 RID: 5720
		private readonly global::System.Collections.Generic.List<global::System.Action> _referenceResolutions = new global::System.Collections.Generic.List<global::System.Action>();
	}
}
