using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevAge.ComponentModel.Converter;

namespace SourceGrid.Cells.Editors
{
	// Token: 0x02000349 RID: 841
	[global::System.ComponentModel.ToolboxItem(false)]
	internal class TimePicker : global::SourceGrid.Cells.Editors.DateTimePicker
	{
		// Token: 0x060028E1 RID: 10465 RVA: 0x0008D5A8 File Offset: 0x0008B7A8
		public TimePicker() : this("T", new string[]
		{
			"T"
		})
		{
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x0008D5D8 File Offset: 0x0008B7D8
		public TimePicker(string toStringFormat, string[] p_ParseFormats)
		{
			global::DevAge.ComponentModel.Converter.DateTimeTypeConverter typeConverter = new global::DevAge.ComponentModel.Converter.DateTimeTypeConverter(toStringFormat, p_ParseFormats);
			base.TypeConverter = typeConverter;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x0008D600 File Offset: 0x0008B800
		protected override global::System.Windows.Forms.Control CreateControl()
		{
			return new global::System.Windows.Forms.DateTimePicker
			{
				Format = global::System.Windows.Forms.DateTimePickerFormat.Time,
				ShowUpDown = true
			};
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x0008D628 File Offset: 0x0008B828
		public new global::System.Windows.Forms.DateTimePicker Control
		{
			get
			{
				return base.Control;
			}
		}
	}
}
