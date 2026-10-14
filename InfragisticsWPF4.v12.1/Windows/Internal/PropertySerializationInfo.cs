using System;
using System.Windows;

namespace Infragistics.Windows.Internal
{
	// Token: 0x0200018C RID: 396
	public class PropertySerializationInfo
	{
		// Token: 0x06000D34 RID: 3380 RVA: 0x0002A03F File Offset: 0x0002823F
		public PropertySerializationInfo(global::System.Type type, string name)
		{
			this._type = type;
			this._name = name;
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x0002A055 File Offset: 0x00028255
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0002A05D File Offset: 0x0002825D
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0002A065 File Offset: 0x00028265
		public override int GetHashCode()
		{
			return this._type.GetHashCode() ^ this._name.GetHashCode();
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0002A080 File Offset: 0x00028280
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Internal.PropertySerializationInfo propertySerializationInfo = obj as global::Infragistics.Windows.Internal.PropertySerializationInfo;
			return propertySerializationInfo != null && this._type == propertySerializationInfo._type && this._name == propertySerializationInfo._name;
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0002A0BD File Offset: 0x000282BD
		public static global::Infragistics.Windows.Internal.PropertySerializationInfo Create(global::System.Windows.DependencyProperty dpProperty)
		{
			return new global::Infragistics.Windows.Internal.PropertySerializationInfo(dpProperty.PropertyType, dpProperty.Name);
		}

		// Token: 0x040006CF RID: 1743
		private global::System.Type _type;

		// Token: 0x040006D0 RID: 1744
		private string _name;
	}
}
