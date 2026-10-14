using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004DA RID: 1242
	public abstract class MetadataItem
	{
		// Token: 0x06003DC6 RID: 15814 RVA: 0x000CB76C File Offset: 0x000C996C
		internal MetadataItem()
		{
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x000CB774 File Offset: 0x000C9974
		internal MetadataItem(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags flags)
		{
			this._flags = (int)flags;
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x000CB783 File Offset: 0x000C9983
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> Annotations
		{
			get
			{
				return from p in this.GetMetadataProperties()
				where p.IsAnnotation
				select p;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06003DC9 RID: 15817
		public abstract global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get; }

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06003DCA RID: 15818 RVA: 0x000CB7AF File Offset: 0x000C99AF
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataProperty, true)]
		public virtual global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> MetadataProperties
		{
			get
			{
				return this.GetMetadataProperties().AsReadOnlyMetadataCollection();
			}
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x000CB7BC File Offset: 0x000C99BC
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection GetMetadataProperties()
		{
			if (this._itemAttributes == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection metadataPropertyCollection = new global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection(this);
				if (this.IsReadOnly)
				{
					metadataPropertyCollection.SetReadOnly();
				}
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection>(ref this._itemAttributes, metadataPropertyCollection, null);
			}
			return this._itemAttributes;
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x000CB7FC File Offset: 0x000C99FC
		public void AddAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty metadataProperty = this.Annotations.FirstOrDefault((global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty a) => a.Name == name);
			if (metadataProperty == null)
			{
				if (value != null)
				{
					this.GetMetadataProperties().Add(global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty.CreateAnnotation(name, value));
				}
				return;
			}
			if (value == null)
			{
				this.RemoveAnnotation(name);
				return;
			}
			metadataProperty.Value = value;
		}

		// Token: 0x06003DCD RID: 15821 RVA: 0x000CB878 File Offset: 0x000C9A78
		public bool RemoveAnnotation(string name)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection metadataProperties = this.GetMetadataProperties();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty item;
			return metadataProperties.TryGetValue(name, false, out item) && metadataProperties.Remove(item);
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06003DCE RID: 15822 RVA: 0x000CB8AD File Offset: 0x000C9AAD
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> RawMetadataProperties
		{
			get
			{
				return this._itemAttributes;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06003DCF RID: 15823 RVA: 0x000CB8B5 File Offset: 0x000C9AB5
		// (set) Token: 0x06003DD0 RID: 15824 RVA: 0x000CB8BD File Offset: 0x000C9ABD
		public global::System.Data.Entity.Core.Metadata.Edm.Documentation Documentation { get; set; }

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06003DD1 RID: 15825
		internal abstract string Identity { get; }

		// Token: 0x06003DD2 RID: 15826 RVA: 0x000CB8C6 File Offset: 0x000C9AC6
		internal virtual bool EdmEquals(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem item)
		{
			return item != null && (this == item || (this.BuiltInTypeKind == item.BuiltInTypeKind && this.Identity == item.Identity));
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x000CB8F4 File Offset: 0x000C9AF4
		internal bool IsReadOnly
		{
			get
			{
				return this.GetFlag(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Readonly);
			}
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x000CB8FD File Offset: 0x000C9AFD
		internal virtual void SetReadOnly()
		{
			if (!this.IsReadOnly)
			{
				if (this._itemAttributes != null)
				{
					this._itemAttributes.SetReadOnly();
				}
				this.SetFlag(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Readonly, true);
			}
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x000CB923 File Offset: 0x000C9B23
		internal virtual void BuildIdentity(global::System.Text.StringBuilder builder)
		{
			builder.Append(this.Identity);
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x000CB932 File Offset: 0x000C9B32
		internal void AddMetadataProperties(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			this.GetMetadataProperties().AddRange(metadataProperties);
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x000CB940 File Offset: 0x000C9B40
		internal global::System.Data.Entity.Core.Metadata.Edm.DataSpace GetDataSpace()
		{
			switch (this._flags & 7)
			{
			case 1:
				return global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace;
			case 2:
				return global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace;
			case 3:
				return global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace;
			case 4:
				return global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace;
			case 5:
				return global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace;
			default:
				return (global::System.Data.Entity.Core.Metadata.Edm.DataSpace)(-1);
			}
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x000CB97D File Offset: 0x000C9B7D
		internal void SetDataSpace(global::System.Data.Entity.Core.Metadata.Edm.DataSpace space)
		{
			this._flags = ((this._flags & -8) | (int)(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.DataSpace & global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.Convert(space)));
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x000CB997 File Offset: 0x000C9B97
		private static global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags Convert(global::System.Data.Entity.Core.Metadata.Edm.DataSpace space)
		{
			switch (space)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.OSpace;
			case global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.CSpace;
			case global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.SSpace;
			case global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OCSpace:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.OCSpace;
			case global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.CSSpace;
			default:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.None;
			}
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x000CB9C0 File Offset: 0x000C9BC0
		internal global::System.Data.Entity.Core.Metadata.Edm.ParameterMode GetParameterMode()
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags metadataFlags = (global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags)(this._flags & 3584);
			if (metadataFlags <= global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Out)
			{
				if (metadataFlags == global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.In)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In;
				}
				if (metadataFlags == global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Out)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out;
				}
			}
			else
			{
				if (metadataFlags == global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.InOut)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut;
				}
				if (metadataFlags == global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.ReturnValue)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue;
				}
			}
			return (global::System.Data.Entity.Core.Metadata.Edm.ParameterMode)(-1);
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x000CBA0D File Offset: 0x000C9C0D
		internal void SetParameterMode(global::System.Data.Entity.Core.Metadata.Edm.ParameterMode mode)
		{
			this._flags = ((this._flags & -3585) | (int)(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.ParameterMode & global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.Convert(mode)));
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x000CBA2E File Offset: 0x000C9C2E
		private static global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags Convert(global::System.Data.Entity.Core.Metadata.Edm.ParameterMode mode)
		{
			switch (mode)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.In;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.Out:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Out;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.InOut:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.InOut;
			case global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.ReturnValue;
			default:
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.ParameterMode;
			}
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x000CBA63 File Offset: 0x000C9C63
		internal bool GetFlag(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags flag)
		{
			return flag == (global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags)(this._flags & (int)flag);
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x000CBA70 File Offset: 0x000C9C70
		internal void SetFlag(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags flag, bool value)
		{
			global::System.Threading.SpinWait spinWait = default(global::System.Threading.SpinWait);
			for (;;)
			{
				int flags = this._flags;
				int value2 = value ? (flags | (int)flag) : (flags & (int)(~(int)flag));
				if ((flags & 8) == 8)
				{
					break;
				}
				if (flags == global::System.Threading.Interlocked.CompareExchange(ref this._flags, value2, flags))
				{
					return;
				}
				spinWait.SpinOnce();
			}
			if ((flag & global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Readonly) == global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Readonly)
			{
				return;
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.OperationOnReadOnlyItem);
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x000CBACC File Offset: 0x000C9CCC
		static MetadataItem()
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[0] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[2] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[1] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[3] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[3] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[7] = new global::System.Data.Entity.Core.Metadata.Edm.EnumType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[6] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[8] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[9] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[10] = new global::System.Data.Entity.Core.Metadata.Edm.EnumType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[11] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[12] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[13] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[14] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[4] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[5] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[15] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[16] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[17] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[18] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[19] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[20] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[21] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[22] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[23] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[24] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[25] = new global::System.Data.Entity.Core.Metadata.Edm.EnumType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[26] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[27] = new global::System.Data.Entity.Core.Metadata.Edm.EnumType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[28] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[29] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[30] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[31] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[32] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[33] = new global::System.Data.Entity.Core.Metadata.Edm.EnumType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[34] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[35] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[36] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[37] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[38] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[39] = new global::System.Data.Entity.Core.Metadata.Edm.ComplexType();
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem), "ItemType", false, null);
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataProperty), "MetadataProperty", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.GlobalItem), "GlobalItem", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage), "TypeUsage", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType), "EdmType", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.GlobalItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.SimpleType), "SimpleType", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType), "EnumType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.SimpleType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType), "PrimitiveType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.SimpleType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType), "CollectionType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType), "RefType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember), "EdmMember", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty), "EdmProperty", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty), "NavigationProperty", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ProviderManifest), "ProviderManifest", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember), "RelationshipEnd", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationEndMember), "AssociationEnd", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumMember), "EnumMember", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ReferentialConstraint), "ReferentialConstraint", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.StructuralType), "StructuralType", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType), "RowType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.StructuralType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType), "ComplexType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.StructuralType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityTypeBase), "ElementType", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.StructuralType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType), "EntityType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityTypeBase));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipType), "RelationshipType", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityTypeBase));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationType), "AssociationType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Facet), "Facet", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityContainer), "EntityContainerType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.GlobalItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySetBase), "BaseEntitySetType", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet), "EntitySetType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySetBase));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipSet), "RelationshipSet", true, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySetBase));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet), "AssociationSetType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipSet));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSetEnd), "AssociationSetEndType", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.FunctionParameter), "FunctionParameter", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmFunction), "EdmFunction", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeBuiltInTypes((global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Documentation), "Documentation", false, (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeEnumType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.OperationAction, "DeleteAction", new string[]
			{
				"None",
				"Cascade"
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeEnumType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipMultiplicity, "RelationshipMultiplicity", new string[]
			{
				"One",
				"ZeroToOne",
				"Many"
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeEnumType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ParameterMode, "ParameterMode", new string[]
			{
				"In",
				"Out",
				"InOut"
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeEnumType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionKind, "CollectionKind", new string[]
			{
				"None",
				"List",
				"Bag"
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.InitializeEnumType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveTypeKind, "PrimitiveTypeKind", global::System.Enum.GetNames(typeof(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind)));
			global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[] array = new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription[2];
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._nullableFacetDescription = new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("Nullable", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean), null, null, true);
			array[0] = global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._nullableFacetDescription;
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._defaultValueFacetDescription = new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("DefaultValue", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType), null, null, null);
			array[1] = global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._defaultValueFacetDescription;
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._generalFacetDescriptions = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription>(array);
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._collectionKindFacetDescription = new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription("CollectionKind", global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType), null, null, null);
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String));
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage2 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.EdmProviderManifest.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean));
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage3 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType));
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage4 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage));
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage5 = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ComplexType));
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataProperty, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("TypeUsage", typeUsage4),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Value", typeUsage5)
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataItem, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("MetadataProperties", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.MetadataProperty).GetCollectionType())),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Documentation", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Documentation)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("EdmType", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType))),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Facets", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Facet)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Namespace", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Abstract", typeUsage2),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Sealed", typeUsage2),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("BaseType", typeUsage5)
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("EnumMembers", typeUsage)
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.CollectionType, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("TypeUsage", typeUsage4)
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RefType, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("EntityType", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("TypeUsage", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Nullable", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("DefaultValue", typeUsage5)
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("RelationshipTypeName", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("ToEndMemberName", typeUsage)
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("OperationBehaviors", typeUsage5),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("RelationshipMultiplicity", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumMember, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage)
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.ReferentialConstraint, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("ToRole", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember))),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("FromRole", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipEndMember))),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("ToProperties", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty).GetCollectionType())),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("FromProperties", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty).GetCollectionType()))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.StructuralType, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Members", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityTypeBase, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("KeyMembers", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmMember)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Facet, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("EdmType", typeUsage3),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Value", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmType)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityContainer, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("EntitySets", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySetBase, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("EntityType", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntityType))),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Schema", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Table", typeUsage)
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSet, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("AssociationSetEnds", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSetEnd).GetCollectionType()))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.AssociationSetEnd, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Role", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("EntitySetType", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.FunctionParameter, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Mode", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType))),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("TypeUsage", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.TypeUsage)))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmFunction, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Name", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Namespace", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("ReturnParameter", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.FunctionParameter))),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Parameters", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.FunctionParameter).GetCollectionType()))
			});
			global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.Documentation, new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[]
			{
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("Summary", typeUsage),
				new global::System.Data.Entity.Core.Metadata.Edm.EdmProperty("LongDescription", typeUsage)
			});
			for (int i = 0; i < global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes.Length; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[i].SetReadOnly();
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06003DE0 RID: 15840 RVA: 0x000CC871 File Offset: 0x000CAA71
		internal static global::System.Data.Entity.Core.Metadata.Edm.FacetDescription DefaultValueFacetDescription
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._defaultValueFacetDescription;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06003DE1 RID: 15841 RVA: 0x000CC878 File Offset: 0x000CAA78
		internal static global::System.Data.Entity.Core.Metadata.Edm.FacetDescription CollectionKindFacetDescription
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._collectionKindFacetDescription;
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06003DE2 RID: 15842 RVA: 0x000CC87F File Offset: 0x000CAA7F
		internal static global::System.Data.Entity.Core.Metadata.Edm.FacetDescription NullableFacetDescription
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._nullableFacetDescription;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06003DE3 RID: 15843 RVA: 0x000CC886 File Offset: 0x000CAA86
		internal static global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest EdmProviderManifest
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance;
			}
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x000CC88D File Offset: 0x000CAA8D
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmType GetBuiltInType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._builtInTypes[(int)builtInTypeKind];
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x000CC896 File Offset: 0x000CAA96
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> GetGeneralFacetDescriptions()
		{
			return global::System.Data.Entity.Core.Metadata.Edm.MetadataItem._generalFacetDescriptions;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x000CC89D File Offset: 0x000CAA9D
		private static void InitializeBuiltInTypes(global::System.Data.Entity.Core.Metadata.Edm.ComplexType builtInType, string name, bool isAbstract, global::System.Data.Entity.Core.Metadata.Edm.ComplexType baseType)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType.Initialize(builtInType, name, "Edm", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, isAbstract, baseType);
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x000CC8B0 File Offset: 0x000CAAB0
		private static void AddBuiltInTypeProperties(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty[] properties)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = (global::System.Data.Entity.Core.Metadata.Edm.ComplexType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(builtInTypeKind);
			if (properties != null)
			{
				for (int i = 0; i < properties.Length; i++)
				{
					complexType.AddMember(properties[i]);
				}
			}
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x000CC8E4 File Offset: 0x000CAAE4
		private static void InitializeEnumType(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind builtInTypeKind, string name, string[] enumMemberNames)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EnumType enumType = (global::System.Data.Entity.Core.Metadata.Edm.EnumType)global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.GetBuiltInType(builtInTypeKind);
			global::System.Data.Entity.Core.Metadata.Edm.EdmType.Initialize(enumType, name, "Edm", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, false, null);
			for (int i = 0; i < enumMemberNames.Length; i++)
			{
				enumType.AddMember(new global::System.Data.Entity.Core.Metadata.Edm.EnumMember(enumMemberNames[i], i));
			}
		}

		// Token: 0x0400150A RID: 5386
		private int _flags;

		// Token: 0x0400150B RID: 5387
		private global::System.Data.Entity.Core.Metadata.Edm.MetadataPropertyCollection _itemAttributes;

		// Token: 0x0400150D RID: 5389
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.EdmType[] _builtInTypes = new global::System.Data.Entity.Core.Metadata.Edm.EdmType[40];

		// Token: 0x0400150E RID: 5390
		private static readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.FacetDescription> _generalFacetDescriptions;

		// Token: 0x0400150F RID: 5391
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.FacetDescription _nullableFacetDescription;

		// Token: 0x04001510 RID: 5392
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.FacetDescription _defaultValueFacetDescription;

		// Token: 0x04001511 RID: 5393
		private static readonly global::System.Data.Entity.Core.Metadata.Edm.FacetDescription _collectionKindFacetDescription;

		// Token: 0x02000AF8 RID: 2808
		[global::System.Flags]
		internal enum MetadataFlags
		{
			// Token: 0x04002C64 RID: 11364
			None = 0,
			// Token: 0x04002C65 RID: 11365
			CSpace = 1,
			// Token: 0x04002C66 RID: 11366
			OSpace = 2,
			// Token: 0x04002C67 RID: 11367
			OCSpace = 3,
			// Token: 0x04002C68 RID: 11368
			SSpace = 4,
			// Token: 0x04002C69 RID: 11369
			CSSpace = 5,
			// Token: 0x04002C6A RID: 11370
			DataSpace = 7,
			// Token: 0x04002C6B RID: 11371
			Readonly = 8,
			// Token: 0x04002C6C RID: 11372
			IsAbstract = 16,
			// Token: 0x04002C6D RID: 11373
			In = 512,
			// Token: 0x04002C6E RID: 11374
			Out = 1024,
			// Token: 0x04002C6F RID: 11375
			InOut = 1536,
			// Token: 0x04002C70 RID: 11376
			ReturnValue = 2048,
			// Token: 0x04002C71 RID: 11377
			ParameterMode = 3584
		}
	}
}
