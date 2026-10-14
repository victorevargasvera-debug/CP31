using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000492 RID: 1170
	public class ComplexType : global::System.Data.Entity.Core.Metadata.Edm.StructuralType
	{
		// Token: 0x060039F6 RID: 14838 RVA: 0x000BDF9D File Offset: 0x000BC19D
		internal ComplexType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(name, namespaceName, dataSpace)
		{
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x000BDFA8 File Offset: 0x000BC1A8
		internal ComplexType()
		{
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x000BDFB0 File Offset: 0x000BC1B0
		internal ComplexType(string name) : this(name, "Transient", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace)
		{
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x000BDFBF File Offset: 0x000BC1BF
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060039FA RID: 14842 RVA: 0x000BDFC2 File Offset: 0x000BC1C2
		public virtual global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> Properties
		{
			get
			{
				return new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(base.Members, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty));
			}
		}

		// Token: 0x060039FB RID: 14843 RVA: 0x000BDFDB File Offset: 0x000BC1DB
		internal override void ValidateMemberForAdd(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
		}

		// Token: 0x060039FC RID: 14844 RVA: 0x000BDFE0 File Offset: 0x000BC1E0
		public static global::System.Data.Entity.Core.Metadata.Edm.ComplexType Create(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> members, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>>(members, "members");
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType(name, namespaceName, dataSpace);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember member in members)
			{
				complexType.AddMember(member);
			}
			if (metadataProperties != null)
			{
				complexType.AddMetadataProperties(metadataProperties);
			}
			complexType.SetReadOnly();
			return complexType;
		}
	}
}
