using System;

namespace NPOI.Util
{
	// Token: 0x02000275 RID: 629
	public interface ILittleEndianInput
	{
		// Token: 0x060010AF RID: 4271
		int Available();

		// Token: 0x060010B0 RID: 4272
		int ReadByte();

		// Token: 0x060010B1 RID: 4273
		int ReadUByte();

		// Token: 0x060010B2 RID: 4274
		short ReadShort();

		// Token: 0x060010B3 RID: 4275
		int ReadUShort();

		// Token: 0x060010B4 RID: 4276
		int ReadInt();

		// Token: 0x060010B5 RID: 4277
		long ReadLong();

		// Token: 0x060010B6 RID: 4278
		double ReadDouble();

		// Token: 0x060010B7 RID: 4279
		void ReadFully(byte[] buf);

		// Token: 0x060010B8 RID: 4280
		void ReadFully(byte[] buf, int off, int len);
	}
}
