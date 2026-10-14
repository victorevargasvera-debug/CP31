using System;
using System.IO;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200040D RID: 1037
	[global::System.Serializable]
	public abstract class Record : global::NPOI.HSSF.Record.RecordBase
	{
		// Token: 0x060025D4 RID: 9684 RVA: 0x000714CC File Offset: 0x0006F6CC
		public Record()
		{
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000714D4 File Offset: 0x0006F6D4
		public byte[] Serialize()
		{
			byte[] array = new byte[this.RecordSize];
			this.Serialize(0, array);
			return array;
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x060025D6 RID: 9686
		public abstract short Sid { get; }

		// Token: 0x060025D7 RID: 9687 RVA: 0x000714F7 File Offset: 0x0006F6F7
		public virtual object Clone()
		{
			throw new global::System.NotSupportedException("The class " + base.GetType().Name + " needs to define a Clone method");
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00071518 File Offset: 0x0006F718
		public global::NPOI.HSSF.Record.Record CloneViaReserialise()
		{
			global::NPOI.HSSF.Record.Record result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(this.Serialize()))
			{
				global::NPOI.HSSF.Record.RecordInputStream recordInputStream = new global::NPOI.HSSF.Record.RecordInputStream(memoryStream);
				recordInputStream.NextRecord();
				global::NPOI.HSSF.Record.Record[] array = global::NPOI.HSSF.Record.RecordFactory.CreateRecord(recordInputStream);
				if (array.Length != 1)
				{
					throw new global::System.InvalidOperationException("Re-serialised a record to clone it, but got " + array.Length.ToString() + " records back!");
				}
				result = array[0];
			}
			return result;
		}
	}
}
