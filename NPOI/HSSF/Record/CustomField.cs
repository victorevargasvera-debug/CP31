using System;
using System.Text;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C1 RID: 961
	[global::System.Obsolete("Not found in poi,is it useful?")]
	public interface CustomField : global::System.ICloneable
	{
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060021BE RID: 8638
		int Size { get; }

		// Token: 0x060021BF RID: 8639
		int FillField(global::NPOI.HSSF.Record.RecordInputStream in1);

		// Token: 0x060021C0 RID: 8640
		void ToString(global::System.Text.StringBuilder str);

		// Token: 0x060021C1 RID: 8641
		int SerializeField(int offset, byte[] data);
	}
}
