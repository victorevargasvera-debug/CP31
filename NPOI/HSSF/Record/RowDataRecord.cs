using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A0 RID: 928
	public abstract class RowDataRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06001FF2 RID: 8178 RVA: 0x000621B4 File Offset: 0x000603B4
		public RowDataRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._rawData = in1.ReadRemainder();
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x000621C8 File Offset: 0x000603C8
		protected override int DataSize
		{
			get
			{
				return this._rawData.Length;
			}
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x000621D2 File Offset: 0x000603D2
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(this._rawData);
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x000621E0 File Offset: 0x000603E0
		public override short Sid
		{
			get
			{
				throw new global::System.NotImplementedException("must be implemented in sub class");
			}
		}

		// Token: 0x04000C64 RID: 3172
		private byte[] _rawData;
	}
}
