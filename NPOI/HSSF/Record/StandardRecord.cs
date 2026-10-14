using System;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000422 RID: 1058
	public abstract class StandardRecord : global::NPOI.HSSF.Record.Record
	{
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060026D6 RID: 9942
		protected abstract int DataSize { get; }

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x0007498D File Offset: 0x00072B8D
		public override int RecordSize
		{
			get
			{
				return 4 + this.DataSize;
			}
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00074998 File Offset: 0x00072B98
		public override int Serialize(int offset, byte[] data)
		{
			int dataSize = this.DataSize;
			int num = 4 + dataSize;
			global::NPOI.Util.LittleEndianByteArrayOutputStream littleEndianByteArrayOutputStream = new global::NPOI.Util.LittleEndianByteArrayOutputStream(data, offset, num);
			littleEndianByteArrayOutputStream.WriteShort((int)this.Sid);
			littleEndianByteArrayOutputStream.WriteShort(dataSize);
			this.Serialize(littleEndianByteArrayOutputStream);
			if (littleEndianByteArrayOutputStream.WriteIndex - offset != num)
			{
				throw new global::System.InvalidOperationException(string.Concat(new string[]
				{
					"Error in serialization of (",
					base.GetType().Name,
					"): Incorrect number of bytes written - expected ",
					num.ToString(),
					" but got ",
					(littleEndianByteArrayOutputStream.WriteIndex - offset).ToString()
				}));
			}
			return num;
		}

		// Token: 0x060026D9 RID: 9945
		public abstract void Serialize(global::NPOI.Util.ILittleEndianOutput out1);
	}
}
