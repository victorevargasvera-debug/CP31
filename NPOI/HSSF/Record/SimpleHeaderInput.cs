using System;
using System.IO;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000412 RID: 1042
	internal class SimpleHeaderInput : global::NPOI.HSSF.Record.BiffHeaderInput
	{
		// Token: 0x060025F1 RID: 9713 RVA: 0x00072A79 File Offset: 0x00070C79
		internal static global::NPOI.Util.ILittleEndianInput GetLEI(global::System.IO.Stream in1)
		{
			if (in1 is global::NPOI.Util.ILittleEndianInput)
			{
				return (global::NPOI.Util.ILittleEndianInput)in1;
			}
			return new global::NPOI.Util.LittleEndianInputStream(in1);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x00072A90 File Offset: 0x00070C90
		public SimpleHeaderInput(global::System.IO.Stream in1)
		{
			this._lei = global::NPOI.HSSF.Record.SimpleHeaderInput.GetLEI(in1);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x00072AA4 File Offset: 0x00070CA4
		public int Available()
		{
			return this._lei.Available();
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x00072AB1 File Offset: 0x00070CB1
		public int ReadDataSize()
		{
			return this._lei.ReadUShort();
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x00072AB1 File Offset: 0x00070CB1
		public int ReadRecordSID()
		{
			return this._lei.ReadUShort();
		}

		// Token: 0x04000FED RID: 4077
		private global::NPOI.Util.ILittleEndianInput _lei;
	}
}
