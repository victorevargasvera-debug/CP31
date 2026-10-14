using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000112 RID: 274
	internal class PropertyEntryMetadata : global::System.Data.Entity.Internal.MemberEntryMetadata
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x00031696 File Offset: 0x0002F896
		public PropertyEntryMetadata(global::System.Type declaringType, global::System.Type propertyType, string propertyName, bool isMapped, bool isComplex) : base(declaringType, propertyType, propertyName)
		{
			this._isMapped = isMapped;
			this._isComplex = isComplex;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x000316B4 File Offset: 0x0002F8B4
		public static global::System.Data.Entity.Internal.PropertyEntryMetadata ValidateNameAndGetMetadata(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Type declaringType, global::System.Type requestedType, string propertyName)
		{
			global::System.Type type;
			global::System.Data.Entity.Internal.DbHelpers.GetPropertyTypes(declaringType).TryGetValue(propertyName, out type);
			global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace metadataWorkspace = internalContext.ObjectContext.MetadataWorkspace;
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType item = metadataWorkspace.GetItem<global::System.Data.Entity.Core.Metadata.Edm.StructuralType>(declaringType.FullNameWithNesting(), global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
			bool isMapped = false;
			bool isComplex = false;
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember;
			item.Members.TryGetValue(propertyName, false, out edmMember);
			if (edmMember != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = edmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
				if (edmProperty == null)
				{
					return null;
				}
				if (type == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = edmProperty.TypeUsage.EdmType as global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType;
					if (primitiveType != null)
					{
						type = primitiveType.ClrEquivalentType;
					}
					else
					{
						type = ((global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)metadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)).GetClrType((global::System.Data.Entity.Core.Metadata.Edm.StructuralType)edmProperty.TypeUsage.EdmType);
					}
				}
				isMapped = true;
				isComplex = (edmProperty.TypeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType);
			}
			else
			{
				global::System.Collections.Generic.IDictionary<string, global::System.Func<object, object>> propertyGetters = global::System.Data.Entity.Internal.DbHelpers.GetPropertyGetters(declaringType);
				global::System.Collections.Generic.IDictionary<string, global::System.Action<object, object>> propertySetters = global::System.Data.Entity.Internal.DbHelpers.GetPropertySetters(declaringType);
				if (!propertyGetters.ContainsKey(propertyName) && !propertySetters.ContainsKey(propertyName))
				{
					return null;
				}
			}
			if (!requestedType.IsAssignableFrom(type))
			{
				throw global::System.Data.Entity.Resources.Error.DbEntityEntry_WrongGenericForProp(propertyName, declaringType.Name, requestedType.Name, type.Name);
			}
			return new global::System.Data.Entity.Internal.PropertyEntryMetadata(declaringType, type, propertyName, isMapped, isComplex);
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x000317C3 File Offset: 0x0002F9C3
		public override global::System.Data.Entity.Internal.InternalMemberEntry CreateMemberEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry, global::System.Data.Entity.Internal.InternalPropertyEntry parentPropertyEntry)
		{
			if (parentPropertyEntry != null)
			{
				return new global::System.Data.Entity.Internal.InternalNestedPropertyEntry(parentPropertyEntry, this);
			}
			return new global::System.Data.Entity.Internal.InternalEntityPropertyEntry(internalEntityEntry, this);
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x000317D7 File Offset: 0x0002F9D7
		public bool IsComplex
		{
			get
			{
				return this._isComplex;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x000317DF File Offset: 0x0002F9DF
		public override global::System.Data.Entity.Internal.MemberEntryType MemberEntryType
		{
			get
			{
				if (!this._isComplex)
				{
					return global::System.Data.Entity.Internal.MemberEntryType.ScalarProperty;
				}
				return global::System.Data.Entity.Internal.MemberEntryType.ComplexProperty;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x000317EC File Offset: 0x0002F9EC
		public bool IsMapped
		{
			get
			{
				return this._isMapped;
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x000317F4 File Offset: 0x0002F9F4
		public override global::System.Type MemberType
		{
			get
			{
				return base.ElementType;
			}
		}

		// Token: 0x0400094D RID: 2381
		private readonly bool _isMapped;

		// Token: 0x0400094E RID: 2382
		private readonly bool _isComplex;
	}
}
