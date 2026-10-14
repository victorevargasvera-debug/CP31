using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common
{
	// Token: 0x020005E9 RID: 1513
	public class DataRecordInfo
	{
		// Token: 0x06004A02 RID: 18946 RVA: 0x00105A12 File Offset: 0x00103C12
		internal DataRecordInfo()
		{
		}

		// Token: 0x06004A03 RID: 18947 RVA: 0x00105A1C File Offset: 0x00103C1C
		public DataRecordInfo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage metadata, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> memberInfo)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(metadata, "metadata");
			global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(metadata.EdmType);
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.FieldMetadata> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.FieldMetadata>(allStructuralMembers.Count);
			if (memberInfo != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in memberInfo)
				{
					if (edmMember == null || 0 > allStructuralMembers.IndexOf(edmMember) || (global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty != edmMember.BuiltInTypeKind && edmMember.BuiltInTypeKind != global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember))
					{
						throw global::System.Data.Entity.Resources.Error.InvalidEdmMemberInstance();
					}
					if (edmMember.DeclaringType != metadata.EdmType && !edmMember.DeclaringType.IsBaseTypeOf(metadata.EdmType))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EdmMembersDefiningTypeDoNotAgreeWithMetadataType);
					}
					list.Add(new global::System.Data.Entity.Core.Common.FieldMetadata(list.Count, edmMember));
				}
			}
			if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStructuralType(metadata.EdmType) == 0 < list.Count)
			{
				this._fieldMetadata = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.FieldMetadata>(list);
				this._metadata = metadata;
				return;
			}
			throw global::System.Data.Entity.Resources.Error.InvalidEdmMemberInstance();
		}

		// Token: 0x06004A04 RID: 18948 RVA: 0x00105B24 File Offset: 0x00103D24
		internal DataRecordInfo(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage metadata)
		{
			global::System.Data.Entity.Core.Metadata.Edm.IBaseList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> allStructuralMembers = global::System.Data.Entity.Core.Common.TypeHelpers.GetAllStructuralMembers(metadata);
			global::System.Data.Entity.Core.Common.FieldMetadata[] array = new global::System.Data.Entity.Core.Common.FieldMetadata[allStructuralMembers.Count];
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember fieldType = allStructuralMembers[i];
				array[i] = new global::System.Data.Entity.Core.Common.FieldMetadata(i, fieldType);
			}
			this._fieldMetadata = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.FieldMetadata>(array);
			this._metadata = metadata;
		}

		// Token: 0x06004A05 RID: 18949 RVA: 0x00105B81 File Offset: 0x00103D81
		internal DataRecordInfo(global::System.Data.Entity.Core.Common.DataRecordInfo recordInfo)
		{
			this._fieldMetadata = recordInfo._fieldMetadata;
			this._metadata = recordInfo._metadata;
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06004A06 RID: 18950 RVA: 0x00105BA1 File Offset: 0x00103DA1
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.FieldMetadata> FieldMetadata
		{
			get
			{
				return this._fieldMetadata;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06004A07 RID: 18951 RVA: 0x00105BA9 File Offset: 0x00103DA9
		public virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage RecordType
		{
			get
			{
				return this._metadata;
			}
		}

		// Token: 0x04001A17 RID: 6679
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.FieldMetadata> _fieldMetadata;

		// Token: 0x04001A18 RID: 6680
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _metadata;
	}
}
