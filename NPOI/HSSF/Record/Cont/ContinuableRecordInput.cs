using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.Cont
{
	// Token: 0x02000451 RID: 1105
	public class ContinuableRecordInput : global::NPOI.Util.ILittleEndianInput
	{
		// Token: 0x060028D6 RID: 10454 RVA: 0x0007B716 File Offset: 0x00079916
		public ContinuableRecordInput(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._in = in1;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x0007B725 File Offset: 0x00079925
		public int Available()
		{
			return this._in.Available();
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0007B732 File Offset: 0x00079932
		public int ReadByte()
		{
			return this._in.ReadByte();
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0007B73F File Offset: 0x0007993F
		public int ReadUByte()
		{
			return this._in.ReadUByte();
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0007B74C File Offset: 0x0007994C
		public short ReadShort()
		{
			return this._in.ReadShort();
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0007B75C File Offset: 0x0007995C
		public int ReadUShort()
		{
			int num = this.ReadUByte();
			return (this.ReadUByte() << 8) + num;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0007B77C File Offset: 0x0007997C
		public int ReadInt()
		{
			int num = this._in.ReadUByte();
			int num2 = this._in.ReadUByte();
			int num3 = this._in.ReadUByte();
			return (this._in.ReadUByte() << 24) + (num3 << 16) + (num2 << 8) + num;
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0007B7C8 File Offset: 0x000799C8
		public long ReadLong()
		{
			int num = this._in.ReadUByte();
			int num2 = this._in.ReadUByte();
			int num3 = this._in.ReadUByte();
			int num4 = this._in.ReadUByte();
			int num5 = this._in.ReadUByte();
			int num6 = this._in.ReadUByte();
			int num7 = this._in.ReadUByte();
			return ((long)this._in.ReadUByte() << 56) + ((long)num7 << 48) + ((long)num6 << 40) + ((long)num5 << 32) + ((long)num4 << 24) + (long)((long)num3 << 16) + (long)((long)num2 << 8) + (long)num;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0007B864 File Offset: 0x00079A64
		public double ReadDouble()
		{
			return this._in.ReadDouble();
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0007B871 File Offset: 0x00079A71
		public void ReadFully(byte[] buf)
		{
			this._in.ReadFully(buf);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0007B87F File Offset: 0x00079A7F
		public void ReadFully(byte[] buf, int off, int len)
		{
			this._in.ReadFully(buf, off, len);
		}

		// Token: 0x0400118E RID: 4494
		private global::NPOI.HSSF.Record.RecordInputStream _in;
	}
}
