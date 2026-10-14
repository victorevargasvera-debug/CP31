using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004BE RID: 1214
	public sealed class EnumMember : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003C23 RID: 15395 RVA: 0x000C67AF File Offset: 0x000C49AF
		internal EnumMember(string name, object value) : base(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Readonly)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._name = name;
			this._value = value;
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x000C67D2 File Offset: 0x000C49D2
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumMember;
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x000C67D6 File Offset: 0x000C49D6
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x000C67DE File Offset: 0x000C49DE
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType, false)]
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x000C67E6 File Offset: 0x000C49E6
		internal override string Identity
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x000C67EE File Offset: 0x000C49EE
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x000C67F6 File Offset: 0x000C49F6
		[global::System.CLSCompliant(false)]
		public static global::System.Data.Entity.Core.Metadata.Edm.EnumMember Create(string name, sbyte value, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			return global::System.Data.Entity.Core.Metadata.Edm.EnumMember.CreateInternal(name, value, metadataProperties);
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x000C6811 File Offset: 0x000C4A11
		public static global::System.Data.Entity.Core.Metadata.Edm.EnumMember Create(string name, byte value, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			return global::System.Data.Entity.Core.Metadata.Edm.EnumMember.CreateInternal(name, value, metadataProperties);
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x000C682C File Offset: 0x000C4A2C
		public static global::System.Data.Entity.Core.Metadata.Edm.EnumMember Create(string name, short value, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			return global::System.Data.Entity.Core.Metadata.Edm.EnumMember.CreateInternal(name, value, metadataProperties);
		}

		// Token: 0x06003C2C RID: 15404 RVA: 0x000C6847 File Offset: 0x000C4A47
		public static global::System.Data.Entity.Core.Metadata.Edm.EnumMember Create(string name, int value, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			return global::System.Data.Entity.Core.Metadata.Edm.EnumMember.CreateInternal(name, value, metadataProperties);
		}

		// Token: 0x06003C2D RID: 15405 RVA: 0x000C6862 File Offset: 0x000C4A62
		public static global::System.Data.Entity.Core.Metadata.Edm.EnumMember Create(string name, long value, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			return global::System.Data.Entity.Core.Metadata.Edm.EnumMember.CreateInternal(name, value, metadataProperties);
		}

		// Token: 0x06003C2E RID: 15406 RVA: 0x000C6880 File Offset: 0x000C4A80
		private static global::System.Data.Entity.Core.Metadata.Edm.EnumMember CreateInternal(string name, object value, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember = new global::System.Data.Entity.Core.Metadata.Edm.EnumMember(name, value);
			if (metadataProperties != null)
			{
				enumMember.AddMetadataProperties(metadataProperties);
			}
			enumMember.SetReadOnly();
			return enumMember;
		}

		// Token: 0x040014B2 RID: 5298
		private readonly string _name;

		// Token: 0x040014B3 RID: 5299
		private readonly object _value;
	}
}
