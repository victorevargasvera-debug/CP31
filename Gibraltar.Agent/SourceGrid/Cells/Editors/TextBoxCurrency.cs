using System;
using System.ComponentModel;
using DevAge.ComponentModel.Converter;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x020003B6 RID: 950
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class TextBoxCurrency : global::SourceGrid.Cells.Editors.TextBoxNumeric
	{
		// Token: 0x06002B98 RID: 11160 RVA: 0x0009257C File Offset: 0x0009077C
		public TextBoxCurrency(global::System.Type p_Type) : base(p_Type)
		{
			base.TypeConverter = new global::DevAge.ComponentModel.Converter.CurrencyTypeConverter(p_Type);
		}
	}
}
