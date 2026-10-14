using System;
using NPOI.HSSF.Record;
using NPOI.Util;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000338 RID: 824
	public class UnsupportedBOFType : global::NPOI.Util.RecordFormatException
	{
		// Token: 0x0600180B RID: 6155 RVA: 0x000484F5 File Offset: 0x000466F5
		public UnsupportedBOFType(global::NPOI.HSSF.Record.BOFRecordType type) : base("BOF not of a supported type, found " + type.ToString())
		{
			this.type = type;
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0004851B File Offset: 0x0004671B
		public global::NPOI.HSSF.Record.BOFRecordType Type
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x040009C8 RID: 2504
		private global::NPOI.HSSF.Record.BOFRecordType type;
	}
}
