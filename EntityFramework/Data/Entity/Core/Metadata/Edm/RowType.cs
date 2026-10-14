using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Text;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F7 RID: 1271
	public class RowType : global::System.Data.Entity.Core.Metadata.Edm.StructuralType
	{
		// Token: 0x06003F0A RID: 16138 RVA: 0x000D0AFD File Offset: 0x000CECFD
		internal RowType()
		{
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x000D0B05 File Offset: 0x000CED05
		internal RowType(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties) : this(properties, null)
		{
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x000D0B10 File Offset: 0x000CED10
		internal RowType(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata) : base(global::System.Data.Entity.Core.Metadata.Edm.RowType.GetRowTypeIdentityFromProperties(global::System.Data.Entity.Core.Metadata.Edm.RowType.CheckProperties(properties), initializerMetadata), "Transient", (global::System.Data.Entity.Core.Metadata.Edm.DataSpace)(-1))
		{
			if (properties != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property in properties)
				{
					this.AddProperty(property);
				}
			}
			this._initializerMetadata = initializerMetadata;
			this.SetReadOnly();
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06003F0D RID: 16141 RVA: 0x000D0B80 File Offset: 0x000CED80
		internal global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata InitializerMetadata
		{
			get
			{
				return this._initializerMetadata;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x000D0B88 File Offset: 0x000CED88
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType;
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06003F0F RID: 16143 RVA: 0x000D0B8C File Offset: 0x000CED8C
		public virtual global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> Properties
		{
			get
			{
				if (this._properties == null)
				{
					global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(ref this._properties, new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(base.Members, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmProperty)), null);
				}
				return this._properties;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x000D0BC0 File Offset: 0x000CEDC0
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> DeclaredProperties
		{
			get
			{
				return base.GetDeclaredOnlyMembers<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
			}
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x000D0BC8 File Offset: 0x000CEDC8
		private void AddProperty(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(property, "property");
			base.AddMember(property);
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x000D0BDD File Offset: 0x000CEDDD
		internal override void ValidateMemberForAdd(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x000D0BE0 File Offset: 0x000CEDE0
		private static string GetRowTypeIdentityFromProperties(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata initializerMetadata)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("rowtype[");
			if (properties != null)
			{
				int num = 0;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in properties)
				{
					if (num > 0)
					{
						stringBuilder.Append(",");
					}
					stringBuilder.Append("(");
					stringBuilder.Append(edmProperty.Name);
					stringBuilder.Append(",");
					edmProperty.TypeUsage.BuildIdentity(stringBuilder);
					stringBuilder.Append(")");
					num++;
				}
			}
			stringBuilder.Append("]");
			if (initializerMetadata != null)
			{
				stringBuilder.Append(",").Append(initializerMetadata.Identity);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06003F14 RID: 16148 RVA: 0x000D0CB0 File Offset: 0x000CEEB0
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> CheckProperties(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties)
		{
			if (properties != null)
			{
				int num = 0;
				using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerator = properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == null)
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNull("properties"));
						}
						num++;
					}
				}
			}
			return properties;
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x000D0D0C File Offset: 0x000CEF0C
		internal override bool EdmEquals(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			if (this == item)
			{
				return true;
			}
			if (item == null || global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType != item.BuiltInTypeKind)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)item;
			if (base.Members.Count != rowType.Members.Count)
			{
				return false;
			}
			for (int i = 0; i < base.Members.Count; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember = base.Members[i];
				global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember2 = rowType.Members[i];
				if (!edmMember.EdmEquals(edmMember2) || !edmMember.TypeUsage.EdmEquals(edmMember2.TypeUsage))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x000D0DA0 File Offset: 0x000CEFA0
		public static global::System.Data.Entity.Core.Metadata.Edm.RowType Create(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> properties, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(properties, "properties");
			global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = new global::System.Data.Entity.Core.Metadata.Edm.RowType(properties);
			if (metadataProperties != null)
			{
				rowType.AddMetadataProperties(metadataProperties);
			}
			rowType.SetReadOnly();
			return rowType;
		}

		// Token: 0x04001583 RID: 5507
		private global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> _properties;

		// Token: 0x04001584 RID: 5508
		private readonly global::System.Data.Entity.Core.Objects.ELinq.InitializerMetadata _initializerMetadata;
	}
}
