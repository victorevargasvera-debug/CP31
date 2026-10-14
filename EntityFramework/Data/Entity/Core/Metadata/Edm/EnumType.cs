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
	// Token: 0x020004BF RID: 1215
	public class EnumType : global::System.Data.Entity.Core.Metadata.Edm.SimpleType
	{
		// Token: 0x06003C2F RID: 15407 RVA: 0x000C68A6 File Offset: 0x000C4AA6
		internal EnumType()
		{
			this._underlyingType = global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType.GetEdmPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32);
			this._isFlags = false;
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x000C68D2 File Offset: 0x000C4AD2
		internal EnumType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType underlyingType, bool isFlags, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(name, namespaceName, dataSpace)
		{
			this._isFlags = isFlags;
			this._underlyingType = underlyingType;
		}

		// Token: 0x06003C31 RID: 15409 RVA: 0x000C6900 File Offset: 0x000C4B00
		internal EnumType(global::System.Type clrType) : base(clrType.Name, clrType.NestingNamespace() ?? string.Empty, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
		{
			global::System.Data.Entity.Core.Metadata.Edm.Provider.ClrProviderManifest.Instance.TryGetPrimitiveType(clrType.GetEnumUnderlyingType(), out this._underlyingType);
			this._isFlags = clrType.GetCustomAttributes(false).Any<global::System.FlagsAttribute>();
			foreach (string text in global::System.Enum.GetNames(clrType))
			{
				this.AddMember(new global::System.Data.Entity.Core.Metadata.Edm.EnumMember(text, global::System.Convert.ChangeType(global::System.Enum.Parse(clrType, text), clrType.GetEnumUnderlyingType(), global::System.Globalization.CultureInfo.InvariantCulture)));
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06003C32 RID: 15410 RVA: 0x000C699E File Offset: 0x000C4B9E
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x000C69A2 File Offset: 0x000C4BA2
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumMember, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EnumMember> Members
		{
			get
			{
				return this._members;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06003C34 RID: 15412 RVA: 0x000C69AA File Offset: 0x000C4BAA
		// (set) Token: 0x06003C35 RID: 15413 RVA: 0x000C69B2 File Offset: 0x000C4BB2
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, false)]
		public bool IsFlags
		{
			get
			{
				return this._isFlags;
			}
			internal set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._isFlags = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06003C36 RID: 15414 RVA: 0x000C69C1 File Offset: 0x000C4BC1
		// (set) Token: 0x06003C37 RID: 15415 RVA: 0x000C69C9 File Offset: 0x000C4BC9
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType UnderlyingType
		{
			get
			{
				return this._underlyingType;
			}
			internal set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._underlyingType = value;
			}
		}

		// Token: 0x06003C38 RID: 15416 RVA: 0x000C69D8 File Offset: 0x000C4BD8
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				this.Members.Source.SetReadOnly();
			}
		}

		// Token: 0x06003C39 RID: 15417 RVA: 0x000C69F9 File Offset: 0x000C4BF9
		internal void AddMember(global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember)
		{
			this.Members.Source.Add(enumMember);
		}

		// Token: 0x06003C3A RID: 15418 RVA: 0x000C6A0C File Offset: 0x000C4C0C
		public static global::System.Data.Entity.Core.Metadata.Edm.EnumType Create(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType underlyingType, bool isFlags, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EnumMember> members, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType>(underlyingType, "underlyingType");
			if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSupportedEnumUnderlyingType(underlyingType.PrimitiveTypeKind))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.InvalidEnumUnderlyingType, "underlyingType");
			}
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType = new global::System.Data.Entity.Core.Metadata.Edm.EnumType(name, namespaceName, underlyingType, isFlags, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace);
			if (members != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EnumMember enumMember in members)
				{
					if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumMemberValueInRange(underlyingType.PrimitiveTypeKind, global::System.Convert.ToInt64(enumMember.Value, global::System.Globalization.CultureInfo.InvariantCulture)))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EnumMemberValueOutOfItsUnderylingTypeRange(enumMember.Value, enumMember.Name, underlyingType.Name), "members");
					}
					enumType.AddMember(enumMember);
				}
			}
			if (metadataProperties != null)
			{
				enumType.AddMetadataProperties(metadataProperties);
			}
			enumType.SetReadOnly();
			return enumType;
		}

		// Token: 0x040014B4 RID: 5300
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EnumMember> _members = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EnumMember>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EnumMember>());

		// Token: 0x040014B5 RID: 5301
		private global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType _underlyingType;

		// Token: 0x040014B6 RID: 5302
		private bool _isFlags;
	}
}
