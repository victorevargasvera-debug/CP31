using System;
using System.IO;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200042E RID: 1070
	public abstract class SubRecord : global::System.ICloneable
	{
		// Token: 0x06002765 RID: 10085 RVA: 0x0007689C File Offset: 0x00074A9C
		public static global::NPOI.HSSF.Record.SubRecord CreateSubRecord(global::NPOI.Util.ILittleEndianInput in1, global::NPOI.HSSF.Record.CommonObjectType cmoOt)
		{
			int num = in1.ReadUShort();
			int num2 = in1.ReadUShort();
			if (num <= 13)
			{
				if (num == 0)
				{
					return new global::NPOI.HSSF.Record.EndSubRecord(in1, num2);
				}
				switch (num)
				{
				case 6:
					return new global::NPOI.HSSF.Record.GroupMarkerSubRecord(in1, num2);
				case 7:
					return new global::NPOI.HSSF.Record.FtCfSubRecord(in1, num2);
				case 8:
					return new global::NPOI.HSSF.Record.FtPioGrbitSubRecord(in1, num2);
				case 9:
					return new global::NPOI.HSSF.Record.EmbeddedObjectRefSubRecord(in1, num2);
				case 12:
					return new global::NPOI.HSSF.Record.FtCblsSubRecord(in1, num2);
				case 13:
					return new global::NPOI.HSSF.Record.NoteStructureSubRecord(in1, num2);
				}
			}
			else
			{
				if (num == 19)
				{
					return new global::NPOI.HSSF.Record.LbsDataSubRecord(in1, num2, (int)cmoOt);
				}
				if (num == 21)
				{
					return new global::NPOI.HSSF.Record.CommonObjectDataSubRecord(in1, num2);
				}
			}
			return new global::NPOI.HSSF.Record.UnknownSubRecord(in1, num, num2);
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06002766 RID: 10086
		public abstract short Sid { get; }

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06002767 RID: 10087
		public abstract int DataSize { get; }

		// Token: 0x06002768 RID: 10088
		public abstract void Serialize(global::NPOI.Util.ILittleEndianOutput out1);

		// Token: 0x06002769 RID: 10089 RVA: 0x00076944 File Offset: 0x00074B44
		public byte[] Serialize()
		{
			int num = this.DataSize + 4;
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(num))
			{
				this.Serialize(new global::NPOI.Util.LittleEndianOutputStream(memoryStream));
				if (memoryStream.Length != (long)num)
				{
					throw new global::System.Exception("write size mismatch");
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x0600276A RID: 10090 RVA: 0x00006EB4 File Offset: 0x000050B4
		public virtual bool IsTerminating
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600276B RID: 10091
		public abstract object Clone();
	}
}
