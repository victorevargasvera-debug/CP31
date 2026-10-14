using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000518 RID: 1304
	internal abstract class OSpaceTypeFactory
	{
		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06004042 RID: 16450
		public abstract global::System.Collections.Generic.List<global::System.Action> ReferenceResolutions { get; }

		// Token: 0x06004043 RID: 16451
		public abstract void LogLoadMessage(string message, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType);

		// Token: 0x06004044 RID: 16452
		public abstract void LogError(string errorMessage, global::System.Data.Entity.Core.Metadata.Edm.EdmType relatedType);

		// Token: 0x06004045 RID: 16453
		public abstract void TrackClosure(global::System.Type type);

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06004046 RID: 16454
		public abstract global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EdmType, global::System.Data.Entity.Core.Metadata.Edm.EdmType> CspaceToOspace { get; }

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06004047 RID: 16455
		public abstract global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> LoadedTypes { get; }

		// Token: 0x06004048 RID: 16456
		public abstract void AddToTypesInAssembly(global::System.Data.Entity.Core.Metadata.Edm.EdmType type);

		// Token: 0x06004049 RID: 16457 RVA: 0x000D57A8 File Offset: 0x000D39A8
		public virtual global::System.Data.Entity.Core.Metadata.Edm.EdmType TryCreateType(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.EdmType cspaceType)
		{
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(cspaceType) ^ type.IsEnum())
			{
				this.LogLoadMessage(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_SSpaceOSpaceTypeMismatch(cspaceType.FullName, cspaceType.FullName), cspaceType);
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType result;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(cspaceType))
			{
				this.TryCreateEnumType(type, (global::System.Data.Entity.Core.Metadata.Edm.EnumType)cspaceType, out result);
				return result;
			}
			this.TryCreateStructuralType(type, (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)cspaceType, out result);
			return result;
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x000D580C File Offset: 0x000D3A0C
		private bool TryCreateEnumType(global::System.Type enumType, global::System.Data.Entity.Core.Metadata.Edm.EnumType cspaceEnumType, out global::System.Data.Entity.Core.Metadata.Edm.EdmType newOSpaceType)
		{
			newOSpaceType = null;
			if (!this.UnderlyingEnumTypesMatch(enumType, cspaceEnumType) || !this.EnumMembersMatch(enumType, cspaceEnumType))
			{
				return false;
			}
			newOSpaceType = new global::System.Data.Entity.Core.Metadata.Edm.ClrEnumType(enumType, cspaceEnumType.NamespaceName, cspaceEnumType.Name);
			this.LoadedTypes.Add(enumType.FullName, newOSpaceType);
			return true;
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x000D585C File Offset: 0x000D3A5C
		private bool TryCreateStructuralType(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.StructuralType cspaceType, out global::System.Data.Entity.Core.Metadata.Edm.EdmType newOSpaceType)
		{
			global::System.Collections.Generic.List<global::System.Action> list = new global::System.Collections.Generic.List<global::System.Action>();
			newOSpaceType = null;
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType;
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(cspaceType))
			{
				ospaceType = new global::System.Data.Entity.Core.Metadata.Edm.ClrEntityType(type, cspaceType.NamespaceName, cspaceType.Name);
			}
			else
			{
				ospaceType = new global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType(type, cspaceType.NamespaceName, cspaceType.Name);
			}
			if (cspaceType.BaseType != null)
			{
				if (!global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.TypesMatchByConvention(type.BaseType(), cspaceType.BaseType))
				{
					string message = global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_BaseTypeIncompatible(type.BaseType().FullName, type.FullName, cspaceType.BaseType.FullName);
					this.LogLoadMessage(message, cspaceType);
					return false;
				}
				this.TrackClosure(type.BaseType());
				list.Add(delegate
				{
					ospaceType.BaseType = this.ResolveBaseType((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)cspaceType.BaseType, type);
				});
			}
			if (!this.TryCreateMembers(type, cspaceType, ospaceType, list))
			{
				return false;
			}
			this.LoadedTypes.Add(type.FullName, ospaceType);
			foreach (global::System.Action item in list)
			{
				this.ReferenceResolutions.Add(item);
			}
			newOSpaceType = ospaceType;
			return true;
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x000D5A08 File Offset: 0x000D3C08
		internal static bool TypesMatchByConvention(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.EdmType cspaceType)
		{
			return type.Name == cspaceType.Name;
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x000D5A1C File Offset: 0x000D3C1C
		private bool UnderlyingEnumTypesMatch(global::System.Type enumType, global::System.Data.Entity.Core.Metadata.Edm.EnumType cspaceEnumType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType;
			if (!global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(enumType.GetEnumUnderlyingType(), out primitiveType))
			{
				this.LogLoadMessage(global::System.Data.Entity.Resources.Strings.Validator_UnsupportedEnumUnderlyingType(enumType.GetEnumUnderlyingType().FullName), cspaceEnumType);
				return false;
			}
			if (primitiveType.PrimitiveTypeKind != cspaceEnumType.UnderlyingType.PrimitiveTypeKind)
			{
				this.LogLoadMessage(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_NonMatchingUnderlyingTypes, cspaceEnumType);
				return false;
			}
			return true;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x000D5A78 File Offset: 0x000D3C78
		private bool EnumMembersMatch(global::System.Type enumType, global::System.Data.Entity.Core.Metadata.Edm.EnumType cspaceEnumType)
		{
			global::System.Type enumUnderlyingType = enumType.GetEnumUnderlyingType();
			global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EnumMember> enumerator = (from m in cspaceEnumType.Members
			orderby m.Name
			select m).GetEnumerator();
			global::System.Collections.Generic.IEnumerator<string> enumerator2 = (from n in enumType.GetEnumNames()
			orderby n
			select n).GetEnumerator();
			if (!enumerator.MoveNext())
			{
				return true;
			}
			while (enumerator2.MoveNext())
			{
				if (enumerator.Current.Name == enumerator2.Current && enumerator.Current.Value.Equals(global::System.Convert.ChangeType(global::System.Enum.Parse(enumType, enumerator2.Current), enumUnderlyingType, global::System.Globalization.CultureInfo.InvariantCulture)) && !enumerator.MoveNext())
				{
					return true;
				}
			}
			this.LogLoadMessage(global::System.Data.Entity.Resources.Strings.Mapping_Enum_OCMapping_MemberMismatch(enumType.FullName, enumerator.Current.Name, enumerator.Current.Value, cspaceEnumType.FullName), cspaceEnumType);
			return false;
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x000D5B78 File Offset: 0x000D3D78
		private bool TryCreateMembers(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.StructuralType cspaceType, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Collections.Generic.List<global::System.Action> referenceResolutionListForCurrentType)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> clrProperties = from p in (cspaceType.BaseType == null) ? type.GetRuntimeProperties() : type.GetDeclaredProperties()
			where !p.IsStatic()
			select p;
			return this.TryFindAndCreatePrimitiveProperties(type, cspaceType, ospaceType, clrProperties) && this.TryFindAndCreateEnumProperties(type, cspaceType, ospaceType, clrProperties, referenceResolutionListForCurrentType) && this.TryFindComplexProperties(type, cspaceType, ospaceType, clrProperties, referenceResolutionListForCurrentType) && this.TryFindNavigationProperties(type, cspaceType, ospaceType, clrProperties, referenceResolutionListForCurrentType);
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x000D5C00 File Offset: 0x000D3E00
		private bool TryFindComplexProperties(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.StructuralType cspaceType, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> clrProperties, global::System.Collections.Generic.List<global::System.Action> referenceResolutionListForCurrentType)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Reflection.PropertyInfo>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Reflection.PropertyInfo>>();
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = (from m in cspaceType.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()
			where global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(m.TypeUsage.EdmType)
			select m).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty cspaceProperty = enumerator.Current;
					global::System.Reflection.PropertyInfo propertyInfo = clrProperties.FirstOrDefault((global::System.Reflection.PropertyInfo p) => global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.MemberMatchesByConvention(p, cspaceProperty));
					if (!(propertyInfo != null))
					{
						string message = global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_MissingRequiredProperty(cspaceProperty.Name, type.FullName);
						this.LogLoadMessage(message, cspaceType);
						return false;
					}
					list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Reflection.PropertyInfo>(cspaceProperty, propertyInfo));
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Reflection.PropertyInfo> keyValuePair in list)
			{
				this.TrackClosure(keyValuePair.Value.PropertyType);
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType ot = ospaceType;
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty cp = keyValuePair.Key;
				global::System.Reflection.PropertyInfo clrp = keyValuePair.Value;
				referenceResolutionListForCurrentType.Add(delegate
				{
					this.CreateAndAddComplexType(type, ot, cp, clrp);
				});
			}
			return true;
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x000D5D88 File Offset: 0x000D3F88
		private bool TryFindNavigationProperties(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.StructuralType cspaceType, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> clrProperties, global::System.Collections.Generic.List<global::System.Action> referenceResolutionListForCurrentType)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>>();
			using (global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>.Enumerator enumerator = cspaceType.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty cspaceProperty = enumerator.Current;
					global::System.Reflection.PropertyInfo propertyInfo = clrProperties.FirstOrDefault((global::System.Reflection.PropertyInfo p) => global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.NonPrimitiveMemberMatchesByConvention(p, cspaceProperty));
					if (!(propertyInfo != null))
					{
						string message = global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_MissingRequiredProperty(cspaceProperty.Name, type.FullName);
						this.LogLoadMessage(message, cspaceType);
						return false;
					}
					bool flag = cspaceProperty.ToEndMember.RelationshipMultiplicity != global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many;
					if (propertyInfo.CanRead && (!flag || propertyInfo.CanWriteExtended()))
					{
						list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>(cspaceProperty, propertyInfo));
					}
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo> keyValuePair in list)
			{
				this.TrackClosure(keyValuePair.Value.PropertyType);
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType ct = cspaceType;
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType ot = ospaceType;
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty cp = keyValuePair.Key;
				referenceResolutionListForCurrentType.Add(delegate
				{
					this.CreateAndAddNavigationProperty(ct, ot, cp);
				});
			}
			return true;
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x000D5F00 File Offset: 0x000D4100
		private global::System.Data.Entity.Core.Metadata.Edm.EdmType ResolveBaseType(global::System.Data.Entity.Core.Metadata.Edm.StructuralType baseCSpaceType, global::System.Type type)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType result;
			if (!this.CspaceToOspace.TryGetValue(baseCSpaceType, out result))
			{
				this.LogError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_BaseTypeNotLoaded(type, baseCSpaceType), baseCSpaceType);
			}
			return result;
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x000D5F2C File Offset: 0x000D412C
		private bool TryFindAndCreatePrimitiveProperties(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.StructuralType cspaceType, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> clrProperties)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = (from p in cspaceType.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()
			where global::System.Data.Entity.Core.Metadata.Edm.Helper.IsPrimitiveType(p.TypeUsage.EdmType)
			select p).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty cspaceProperty = enumerator.Current;
					global::System.Reflection.PropertyInfo propertyInfo = clrProperties.FirstOrDefault((global::System.Reflection.PropertyInfo p) => global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.MemberMatchesByConvention(p, cspaceProperty));
					if (!(propertyInfo != null))
					{
						string message = global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_MissingRequiredProperty(cspaceProperty.Name, type.FullName);
						this.LogLoadMessage(message, cspaceType);
						return false;
					}
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType propertyType;
					if (!global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.TryGetPrimitiveType(propertyInfo.PropertyType, out propertyType))
					{
						string message2 = global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_NonPrimitiveTypeProperty(propertyInfo.Name, type.FullName, propertyInfo.PropertyType.FullName);
						this.LogLoadMessage(message2, cspaceType);
						return false;
					}
					if (!propertyInfo.CanRead || !propertyInfo.CanWriteExtended())
					{
						string message3 = global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_ScalarPropertyMissginGetterOrSetter(propertyInfo.Name, type.FullName, type.Assembly().FullName);
						this.LogLoadMessage(message3, cspaceType);
						return false;
					}
					global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.AddScalarMember(type, propertyInfo, ospaceType, cspaceProperty, propertyType);
				}
			}
			return true;
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x000D607C File Offset: 0x000D427C
		protected static bool TryGetPrimitiveType(global::System.Type type, out global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(global::System.Nullable.GetUnderlyingType(type) ?? type, out primitiveType);
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x000D6094 File Offset: 0x000D4294
		private bool TryFindAndCreateEnumProperties(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.StructuralType cspaceType, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> clrProperties, global::System.Collections.Generic.List<global::System.Action> referenceResolutionListForCurrentType)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Reflection.PropertyInfo>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Reflection.PropertyInfo>>();
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = (from p in cspaceType.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>()
			where global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumType(p.TypeUsage.EdmType)
			select p).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty cspaceProperty = enumerator.Current;
					global::System.Reflection.PropertyInfo propertyInfo = clrProperties.FirstOrDefault((global::System.Reflection.PropertyInfo p) => global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.MemberMatchesByConvention(p, cspaceProperty));
					if (!(propertyInfo != null))
					{
						string message = global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_MissingRequiredProperty(cspaceProperty.Name, type.FullName);
						this.LogLoadMessage(message, cspaceType);
						return false;
					}
					list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Reflection.PropertyInfo>(cspaceProperty, propertyInfo));
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Reflection.PropertyInfo> keyValuePair in list)
			{
				this.TrackClosure(keyValuePair.Value.PropertyType);
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType ot = ospaceType;
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty cp = keyValuePair.Key;
				global::System.Reflection.PropertyInfo clrp = keyValuePair.Value;
				referenceResolutionListForCurrentType.Add(delegate
				{
					this.CreateAndAddEnumProperty(type, ot, cp, clrp);
				});
			}
			return true;
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x000D621C File Offset: 0x000D441C
		private static bool MemberMatchesByConvention(global::System.Reflection.PropertyInfo clrProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember cspaceMember)
		{
			return clrProperty.Name == cspaceMember.Name;
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x000D6230 File Offset: 0x000D4430
		private void CreateAndAddComplexType(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty cspaceProperty, global::System.Reflection.PropertyInfo clrProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (this.CspaceToOspace.TryGetValue(cspaceProperty.TypeUsage.EdmType, out edmType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(cspaceProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
				{
					Nullable = new bool?(false)
				}), clrProperty, type);
				ospaceType.AddMember(member);
				return;
			}
			this.LogError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_MissingOSpaceType(cspaceProperty.TypeUsage.EdmType.FullName), cspaceProperty.TypeUsage.EdmType);
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x000D62B0 File Offset: 0x000D44B0
		private static bool NonPrimitiveMemberMatchesByConvention(global::System.Reflection.PropertyInfo clrProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember cspaceMember)
		{
			return !clrProperty.PropertyType.IsValueType() && !clrProperty.PropertyType.IsAssignableFrom(typeof(string)) && clrProperty.Name == cspaceMember.Name;
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x000D62EC File Offset: 0x000D44EC
		private void CreateAndAddNavigationProperty(global::System.Data.Entity.Core.Metadata.Edm.StructuralType cspaceType, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty cspaceProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (this.CspaceToOspace.TryGetValue(cspaceProperty.RelationshipType, out edmType))
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 = null;
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType4;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsCollectionType(cspaceProperty.TypeUsage.EdmType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType3;
					if (this.CspaceToOspace.TryGetValue(((global::System.Data.Entity.Core.Metadata.Edm.CollectionType)cspaceProperty.TypeUsage.EdmType).TypeUsage.EdmType, out edmType3))
					{
						edmType2 = edmType3.GetCollectionType();
					}
				}
				else if (this.CspaceToOspace.TryGetValue(cspaceProperty.TypeUsage.EdmType, out edmType4))
				{
					edmType2 = edmType4;
				}
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = new global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty(cspaceProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType2));
				global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipType)edmType;
				navigationProperty.RelationshipType = relationshipType;
				navigationProperty.ToEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)relationshipType.Members.First((global::System.Data.Entity.Core.Metadata.Edm.EdmMember e) => e.Name == cspaceProperty.ToEndMember.Name);
				navigationProperty.FromEndMember = (global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember)relationshipType.Members.First((global::System.Data.Entity.Core.Metadata.Edm.EdmMember e) => e.Name == cspaceProperty.FromEndMember.Name);
				ospaceType.AddMember(navigationProperty);
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase entityTypeBase = (from e in cspaceProperty.RelationshipType.RelationshipEndMembers
			select ((global::System.Data.Entity.Core.Metadata.Edm.RefType)e.TypeUsage.EdmType).ElementType).First((global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase e) => e != cspaceType);
			this.LogError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_RelationshipNotLoaded(cspaceProperty.RelationshipType.FullName, entityTypeBase.FullName), entityTypeBase);
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x000D6480 File Offset: 0x000D4680
		private void CreateAndAddEnumProperty(global::System.Type type, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty cspaceProperty, global::System.Reflection.PropertyInfo clrProperty)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType propertyType;
			if (!this.CspaceToOspace.TryGetValue(cspaceProperty.TypeUsage.EdmType, out propertyType))
			{
				this.LogError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_MissingOSpaceType(cspaceProperty.TypeUsage.EdmType.FullName), cspaceProperty.TypeUsage.EdmType);
				return;
			}
			if (clrProperty.CanRead && clrProperty.CanWriteExtended())
			{
				global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.AddScalarMember(type, clrProperty, ospaceType, cspaceProperty, propertyType);
				return;
			}
			this.LogError(global::System.Data.Entity.Resources.Strings.Validator_OSpace_Convention_ScalarPropertyMissginGetterOrSetter(clrProperty.Name, type.FullName, type.Assembly().FullName), cspaceProperty.TypeUsage.EdmType);
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x000D651C File Offset: 0x000D471C
		private static void AddScalarMember(global::System.Type type, global::System.Reflection.PropertyInfo clrProperty, global::System.Data.Entity.Core.Metadata.Edm.StructuralType ospaceType, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty cspaceProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmType propertyType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType declaringType = cspaceProperty.DeclaringType;
			bool flag = global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityType(declaringType) && ((global::System.Data.Entity.Core.Metadata.Edm.EntityType)declaringType).KeyMemberNames.Contains(clrProperty.Name);
			bool value = !flag && (!clrProperty.PropertyType.IsValueType() || global::System.Nullable.GetUnderlyingType(clrProperty.PropertyType) != null);
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member = new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty(cspaceProperty.Name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(propertyType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
			{
				Nullable = new bool?(value)
			}), clrProperty, type);
			if (flag)
			{
				((global::System.Data.Entity.Core.Metadata.Edm.EntityType)ospaceType).AddKeyMember(member);
				return;
			}
			ospaceType.AddMember(member);
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x000D65BC File Offset: 0x000D47BC
		public virtual void CreateRelationships(global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection edmItemCollection)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in edmItemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>())
			{
				if (!this.CspaceToOspace.ContainsKey(associationType))
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmType[] array = new global::System.Data.Entity.Core.Metadata.Edm.EdmType[2];
					if (this.CspaceToOspace.TryGetValue(global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.GetRelationshipEndType(associationType.RelationshipEndMembers[0]), out array[0]) && this.CspaceToOspace.TryGetValue(global::System.Data.Entity.Core.Metadata.Edm.OSpaceTypeFactory.GetRelationshipEndType(associationType.RelationshipEndMembers[1]), out array[1]))
					{
						global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType2 = new global::System.Data.Entity.Core.Metadata.Edm.AssociationType(associationType.Name, associationType.NamespaceName, associationType.IsForeignKey, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
						for (int i = 0; i < associationType.RelationshipEndMembers.Count; i++)
						{
							global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)array[i];
							global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember = associationType.RelationshipEndMembers[i];
							associationType2.AddKeyMember(new global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember(relationshipEndMember.Name, entityType.GetReferenceType(), relationshipEndMember.RelationshipMultiplicity));
						}
						this.AddToTypesInAssembly(associationType2);
						this.LoadedTypes.Add(associationType2.FullName, associationType2);
						this.CspaceToOspace.Add(associationType, associationType2);
					}
				}
			}
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x000D6710 File Offset: 0x000D4910
		private static global::System.Data.Entity.Core.Metadata.Edm.StructuralType GetRelationshipEndType(global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember relationshipEndMember)
		{
			return ((global::System.Data.Entity.Core.Metadata.Edm.RefType)relationshipEndMember.TypeUsage.EdmType).ElementType;
		}
	}
}
