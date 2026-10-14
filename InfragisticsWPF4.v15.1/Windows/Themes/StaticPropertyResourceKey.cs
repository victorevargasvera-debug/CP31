using System;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200022F RID: 559
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter))]
	public sealed class StaticPropertyResourceKey : global::System.Windows.ResourceKey
	{
		// Token: 0x06001540 RID: 5440 RVA: 0x0004D614 File Offset: 0x0004B814
		public StaticPropertyResourceKey(global::System.Type type, string propertyName)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			if (propertyName == null)
			{
				throw new global::System.ArgumentNullException("propertyName");
			}
			this._type = type;
			this._propertyName = propertyName;
			global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter.CacheType(type);
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0004D652 File Offset: 0x0004B852
		public override global::System.Reflection.Assembly Assembly
		{
			get
			{
				return this._type.Assembly;
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0004D660 File Offset: 0x0004B860
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this._type.Name);
			stringBuilder.Append(".");
			stringBuilder.Append(this._propertyName);
			return stringBuilder.ToString();
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0004D6A4 File Offset: 0x0004B8A4
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0004D6AC File Offset: 0x0004B8AC
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x04000B3F RID: 2879
		private global::System.Type _type;

		// Token: 0x04000B40 RID: 2880
		private string _propertyName;
	}
}
