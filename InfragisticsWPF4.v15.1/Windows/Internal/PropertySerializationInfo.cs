using System;
using System.Windows;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001B1 RID: 433
	public class PropertySerializationInfo
	{
		// Token: 0x06000E81 RID: 3713 RVA: 0x0002E7A1 File Offset: 0x0002C9A1
		public PropertySerializationInfo(global::System.Type type, string name)
		{
			this._type = type;
			this._name = name;
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x0002E7B7 File Offset: 0x0002C9B7
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x0002E7BF File Offset: 0x0002C9BF
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0002E7C7 File Offset: 0x0002C9C7
		public override int GetHashCode()
		{
			return this._type.GetHashCode() ^ this._name.GetHashCode();
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0002E7E0 File Offset: 0x0002C9E0
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Internal.PropertySerializationInfo propertySerializationInfo = obj as global::Infragistics.Windows.Internal.PropertySerializationInfo;
			return propertySerializationInfo != null && this._type == propertySerializationInfo._type && this._name == propertySerializationInfo._name;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0002E81D File Offset: 0x0002CA1D
		public static global::Infragistics.Windows.Internal.PropertySerializationInfo Create(global::System.Windows.DependencyProperty dpProperty)
		{
			return new global::Infragistics.Windows.Internal.PropertySerializationInfo(dpProperty.PropertyType, dpProperty.Name);
		}

		// Token: 0x040007F6 RID: 2038
		private global::System.Type _type;

		// Token: 0x040007F7 RID: 2039
		private string _name;
	}
}
