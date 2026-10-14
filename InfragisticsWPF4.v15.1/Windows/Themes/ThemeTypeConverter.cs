using System;
using System.ComponentModel;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200020A RID: 522
	public class ThemeTypeConverter : global::System.ComponentModel.StringConverter
	{
		// Token: 0x0600138B RID: 5003 RVA: 0x000453D0 File Offset: 0x000435D0
		public ThemeTypeConverter() : this("*")
		{
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x000453DD File Offset: 0x000435DD
		public ThemeTypeConverter(string grouping)
		{
			this._grouping = grouping;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x000453EC File Offset: 0x000435EC
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return new global::System.ComponentModel.TypeConverter.StandardValuesCollection(global::Infragistics.Windows.Themes.ThemeManager.GetThemes(false, this._grouping));
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x000453FF File Offset: 0x000435FF
		public override bool GetStandardValuesExclusive(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return false;
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00045402 File Offset: 0x00043602
		public override bool GetStandardValuesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x04000A73 RID: 2675
		private string _grouping;
	}
}
