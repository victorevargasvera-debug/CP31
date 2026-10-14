using System;
using System.ComponentModel;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001DC RID: 476
	public class ThemeTypeConverter : global::System.ComponentModel.StringConverter
	{
		// Token: 0x060011B7 RID: 4535 RVA: 0x0003FB28 File Offset: 0x0003DD28
		public ThemeTypeConverter() : this("*")
		{
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0003FB35 File Offset: 0x0003DD35
		public ThemeTypeConverter(string grouping)
		{
			this._grouping = grouping;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0003FB44 File Offset: 0x0003DD44
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return new global::System.ComponentModel.TypeConverter.StandardValuesCollection(global::Infragistics.Windows.Themes.ThemeManager.GetThemes(false, this._grouping));
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0003FB57 File Offset: 0x0003DD57
		public override bool GetStandardValuesExclusive(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return false;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0003FB5A File Offset: 0x0003DD5A
		public override bool GetStandardValuesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0400092F RID: 2351
		private string _grouping;
	}
}
