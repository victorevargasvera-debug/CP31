using System;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001FF RID: 511
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter))]
	public sealed class StaticPropertyResourceKey : global::System.Windows.ResourceKey
	{
		// Token: 0x06001362 RID: 4962 RVA: 0x000478C8 File Offset: 0x00045AC8
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

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00047906 File Offset: 0x00045B06
		public override global::System.Reflection.Assembly Assembly
		{
			get
			{
				return this._type.Assembly;
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00047914 File Offset: 0x00045B14
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(this._type.Name);
			stringBuilder.Append(".");
			stringBuilder.Append(this._propertyName);
			return stringBuilder.ToString();
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x00047958 File Offset: 0x00045B58
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x00047960 File Offset: 0x00045B60
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x040009F4 RID: 2548
		private global::System.Type _type;

		// Token: 0x040009F5 RID: 2549
		private string _propertyName;
	}
}
