using System;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util
{
	// Token: 0x02000010 RID: 16
	public class DataMarker
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x00003137 File Offset: 0x00001337
		public DataMarker(global::NPOI.SS.UserModel.ISheet sheet, global::NPOI.SS.Util.CellRangeAddress range)
		{
			this.sheet = sheet;
			this.range = range;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000314D File Offset: 0x0000134D
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00003155 File Offset: 0x00001355
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return this.sheet;
			}
			set
			{
				this.sheet = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000315E File Offset: 0x0000135E
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00003166 File Offset: 0x00001366
		public global::NPOI.SS.Util.CellRangeAddress Range
		{
			get
			{
				return this.range;
			}
			set
			{
				this.range = value;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003170 File Offset: 0x00001370
		public string FormatAsString()
		{
			string sheetName = (this.sheet == null) ? null : this.sheet.SheetName;
			if (this.range == null)
			{
				return null;
			}
			return this.range.FormatAsString(sheetName, true);
		}

		// Token: 0x04000022 RID: 34
		private global::NPOI.SS.UserModel.ISheet sheet;

		// Token: 0x04000023 RID: 35
		private global::NPOI.SS.Util.CellRangeAddress range;
	}
}
