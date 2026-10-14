using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004DD RID: 1245
	public class MetadataProperty : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003DFA RID: 15866 RVA: 0x000CD01D File Offset: 0x000CB21D
		internal MetadataProperty()
		{
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x000CD025 File Offset: 0x000CB225
		internal MetadataProperty(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsage, "typeUsage");
			this._name = name;
			this._value = value;
			this._typeUsage = typeUsage;
			this._propertyKind = global::System.Data.Entity.Core.Metadata.Edm.PropertyKind.Extended;
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x000CD055 File Offset: 0x000CB255
		internal MetadataProperty(string name, global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, bool isCollectionType, object value)
		{
			this._name = name;
			this._value = value;
			if (isCollectionType)
			{
				this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType.GetCollectionType());
			}
			else
			{
				this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(edmType);
			}
			this._propertyKind = global::System.Data.Entity.Core.Metadata.Edm.PropertyKind.System;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x000CD095 File Offset: 0x000CB295
		private MetadataProperty(string name, object value)
		{
			this._name = name;
			this._value = value;
			this._propertyKind = global::System.Data.Entity.Core.Metadata.Edm.PropertyKind.Extended;
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06003DFE RID: 15870 RVA: 0x000CD0B2 File Offset: 0x000CB2B2
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataProperty;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06003DFF RID: 15871 RVA: 0x000CD0B6 File Offset: 0x000CB2B6
		internal override string Identity
		{
			get
			{
				return this.Name;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06003E00 RID: 15872 RVA: 0x000CD0BE File Offset: 0x000CB2BE
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public virtual string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06003E01 RID: 15873 RVA: 0x000CD0C8 File Offset: 0x000CB2C8
		// (set) Token: 0x06003E02 RID: 15874 RVA: 0x000CD0F1 File Offset: 0x000CB2F1
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(typeof(object), false)]
		public virtual object Value
		{
			get
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyValue metadataPropertyValue = this._value as global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyValue;
				if (metadataPropertyValue != null)
				{
					return metadataPropertyValue.GetValue();
				}
				return this._value;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._value = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06003E03 RID: 15875 RVA: 0x000CD10C File Offset: 0x000CB30C
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				return this._typeUsage;
			}
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x000CD114 File Offset: 0x000CB314
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06003E05 RID: 15877 RVA: 0x000CD124 File Offset: 0x000CB324
		public virtual global::System.Data.Entity.Core.Metadata.Edm.PropertyKind PropertyKind
		{
			get
			{
				return this._propertyKind;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x000CD12C File Offset: 0x000CB32C
		public bool IsAnnotation
		{
			get
			{
				return this.PropertyKind == global::System.Data.Entity.Core.Metadata.Edm.PropertyKind.Extended && this.TypeUsage == null;
			}
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x000CD142 File Offset: 0x000CB342
		public static global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty Create(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(typeUsage, "typeUsage");
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty = new global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(name, typeUsage, value);
			metadataProperty.SetReadOnly();
			return metadataProperty;
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x000CD16A File Offset: 0x000CB36A
		public static global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty CreateAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			return new global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(name, value);
		}

		// Token: 0x0400151A RID: 5402
		private readonly string _name;

		// Token: 0x0400151B RID: 5403
		private readonly global::System.Data.Entity.Core.Metadata.Edm.PropertyKind _propertyKind;

		// Token: 0x0400151C RID: 5404
		private object _value;

		// Token: 0x0400151D RID: 5405
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _typeUsage;
	}
}
