using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000036 RID: 54
	public class XWPFFieldRun : global::NPOI.XWPF.UserModel.XWPFRun
	{
		// Token: 0x060001CA RID: 458 RVA: 0x000070A1 File Offset: 0x000052A1
		public XWPFFieldRun(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField field, global::NPOI.OpenXmlFormats.Wordprocessing.CT_R run, global::NPOI.XWPF.UserModel.IRunBody p) : base(run, p)
		{
			this.field = field;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000070B2 File Offset: 0x000052B2
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField GetCTField()
		{
			return this.field;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000070BA File Offset: 0x000052BA
		// (set) Token: 0x060001CD RID: 461 RVA: 0x000070C7 File Offset: 0x000052C7
		public string FieldInstruction
		{
			get
			{
				return this.field.instr;
			}
			set
			{
				this.field.instr = value;
			}
		}

		// Token: 0x040001C8 RID: 456
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_SimpleField field;
	}
}
