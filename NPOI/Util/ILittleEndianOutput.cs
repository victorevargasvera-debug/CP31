using System;

namespace NPOI.Util
{
	// Token: 0x02000277 RID: 631
	public interface ILittleEndianOutput
	{
		// Token: 0x060010CC RID: 4300
		void WriteByte(int v);

		// Token: 0x060010CD RID: 4301
		void WriteShort(int v);

		// Token: 0x060010CE RID: 4302
		void WriteInt(int v);

		// Token: 0x060010CF RID: 4303
		void WriteLong(long v);

		// Token: 0x060010D0 RID: 4304
		void WriteDouble(double v);

		// Token: 0x060010D1 RID: 4305
		void Write(byte[] b);

		// Token: 0x060010D2 RID: 4306
		void Write(byte[] b, int offset, int len);
	}
}
