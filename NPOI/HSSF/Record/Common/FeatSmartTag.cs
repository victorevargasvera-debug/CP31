using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Common
{
	// Token: 0x02000460 RID: 1120
	public class FeatSmartTag : global::NPOI.HSSF.Record.Common.SharedFeature
	{
		// Token: 0x06002972 RID: 10610 RVA: 0x0007CDEB File Offset: 0x0007AFEB
		public FeatSmartTag()
		{
			this.data = new byte[0];
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x0007CDFF File Offset: 0x0007AFFF
		public FeatSmartTag(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.data = in1.ReadRemainder();
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0007CE13 File Offset: 0x0007B013
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(" [FEATURE SMART TAGS]\n");
			stringBuilder.Append(" [/FEATURE SMART TAGS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x0007CE37 File Offset: 0x0007B037
		public int DataSize
		{
			get
			{
				return this.data.Length;
			}
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x0007CE41 File Offset: 0x0007B041
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this.data);
		}

		// Token: 0x040011F0 RID: 4592
		private byte[] data;
	}
}
