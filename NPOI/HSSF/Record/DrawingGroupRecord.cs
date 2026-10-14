using System;
using System.Collections;
using NPOI.DDF;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003C8 RID: 968
	public class DrawingGroupRecord : global::NPOI.HSSF.Record.AbstractEscherHolderRecord
	{
		// Token: 0x06002204 RID: 8708 RVA: 0x0006739E File Offset: 0x0006559E
		public DrawingGroupRecord()
		{
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x000673A6 File Offset: 0x000655A6
		public DrawingGroupRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002206 RID: 8710 RVA: 0x000673AF File Offset: 0x000655AF
		protected override string RecordName
		{
			get
			{
				return "MSODRAWINGGROUP";
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000673B6 File Offset: 0x000655B6
		public override short Sid
		{
			get
			{
				return 235;
			}
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x000673C0 File Offset: 0x000655C0
		public override int Serialize(int offset, byte[] data)
		{
			byte[] rawData = base.RawData;
			if (base.EscherRecords.Count == 0 && rawData != null)
			{
				return this.WriteData(offset, data, rawData);
			}
			byte[] array = new byte[this.RawDataSize];
			int num = 0;
			foreach (object obj in base.EscherRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				num += escherRecord.Serialize(num, array, new global::NPOI.DDF.NullEscherSerializationListener());
			}
			return this.WriteData(offset, data, array);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x0006743E File Offset: 0x0006563E
		public void ProcessChildRecords()
		{
			base.ConvertRawBytesToEscherRecords();
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x00067446 File Offset: 0x00065646
		public override int RecordSize
		{
			get
			{
				return global::NPOI.HSSF.Record.DrawingGroupRecord.GrossSizeFromDataSize(this.RawDataSize);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00067454 File Offset: 0x00065654
		public int RawDataSize
		{
			get
			{
				global::System.Collections.IList escherRecords = base.EscherRecords;
				byte[] rawData = base.RawData;
				if (escherRecords.Count == 0 && rawData != null)
				{
					return rawData.Length;
				}
				int num = 0;
				foreach (object obj in escherRecords)
				{
					global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
					num += escherRecord.RecordSize;
				}
				return num;
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x000674A9 File Offset: 0x000656A9
		public static int GrossSizeFromDataSize(int dataSize)
		{
			return dataSize + ((dataSize - 1) / 8224 + 1) * 4;
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x000674BC File Offset: 0x000656BC
		private int WriteData(int offset, byte[] data, byte[] rawData)
		{
			int num = 0;
			int i = 0;
			while (i < rawData.Length)
			{
				int num2 = global::System.Math.Min(rawData.Length - i, 8224);
				if (i / 8224 >= 2)
				{
					this.WriteContinueHeader(data, offset, num2);
				}
				else
				{
					this.WriteHeader(data, offset, num2);
				}
				num += 4;
				offset += 4;
				global::System.Array.Copy(rawData, i, data, offset, num2);
				offset += num2;
				i += num2;
				num += num2;
			}
			return num;
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00067524 File Offset: 0x00065724
		private void WriteHeader(byte[] data, int offset, int sizeExcludingHeader)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Sid);
			global::NPOI.Util.LittleEndian.PutShort(data, 2 + offset, (short)sizeExcludingHeader);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0006753E File Offset: 0x0006573E
		private void WriteContinueHeader(byte[] data, int offset, int sizeExcludingHeader)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, offset, 60);
			global::NPOI.Util.LittleEndian.PutShort(data, 2 + offset, (short)sizeExcludingHeader);
		}

		// Token: 0x04000D58 RID: 3416
		public const short sid = 235;

		// Token: 0x04000D59 RID: 3417
		private const int MAX_RECORD_SIZE = 8228;

		// Token: 0x04000D5A RID: 3418
		private const int MAX_DATA_SIZE = 8224;
	}
}
