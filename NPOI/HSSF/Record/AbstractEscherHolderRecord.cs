using System;
using System.Collections.Generic;
using System.Text;
using NPOI.DDF;
using NPOI.HSSF.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A6 RID: 934
	public abstract class AbstractEscherHolderRecord : global::NPOI.HSSF.Record.Record, global::System.ICloneable
	{
		// Token: 0x06002041 RID: 8257 RVA: 0x0006331A File Offset: 0x0006151A
		public AbstractEscherHolderRecord()
		{
			this.escherRecords = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>();
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00063338 File Offset: 0x00061538
		public AbstractEscherHolderRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.escherRecords = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>();
			if (!global::NPOI.HSSF.Record.AbstractEscherHolderRecord.DESERIALISE)
			{
				this.rawDataContainer.Concatenate(in1.ReadRemainder());
				return;
			}
			byte[] array = in1.ReadAllContinuedRemainder();
			this.ConvertToEscherRecords(0, array.Length, array);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0006338C File Offset: 0x0006158C
		protected void ConvertRawBytesToEscherRecords()
		{
			if (!global::NPOI.HSSF.Record.AbstractEscherHolderRecord.DESERIALISE)
			{
				byte[] rawData = this.RawData;
				this.ConvertToEscherRecords(0, rawData.Length, rawData);
			}
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000633B4 File Offset: 0x000615B4
		private void ConvertToEscherRecords(int offset, int size, byte[] data)
		{
			this.escherRecords.Clear();
			global::NPOI.DDF.IEscherRecordFactory escherRecordFactory = new global::NPOI.DDF.DefaultEscherRecordFactory();
			int num;
			for (int i = offset; i < offset + size; i += num)
			{
				global::NPOI.DDF.EscherRecord escherRecord = escherRecordFactory.CreateRecord(data, i);
				num = escherRecord.FillFields(data, i, escherRecordFactory);
				this.escherRecords.Add(escherRecord);
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00063400 File Offset: 0x00061600
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string newLine = global::System.Environment.NewLine;
			stringBuilder.Append("[" + this.RecordName + "]" + newLine);
			if (this.escherRecords.Count == 0)
			{
				stringBuilder.Append("No Escher Records Decoded" + newLine);
			}
			foreach (global::NPOI.DDF.EscherRecord escherRecord in this.escherRecords)
			{
				stringBuilder.Append(escherRecord.ToString());
			}
			stringBuilder.Append("[/" + this.RecordName + "]" + newLine);
			return stringBuilder.ToString();
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002046 RID: 8262
		protected abstract string RecordName { get; }

		// Token: 0x06002047 RID: 8263 RVA: 0x000634C4 File Offset: 0x000616C4
		public override int Serialize(int offset, byte[] data)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Sid);
			global::NPOI.Util.LittleEndian.PutShort(data, 2 + offset, (short)(this.RecordSize - 4));
			byte[] rawData = this.RawData;
			if (this.escherRecords.Count == 0 && rawData != null)
			{
				global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Sid);
				global::NPOI.Util.LittleEndian.PutShort(data, 2 + offset, (short)(this.RecordSize - 4));
				global::System.Array.Copy(rawData, 0, data, 4 + offset, rawData.Length);
				return rawData.Length + 4;
			}
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Sid);
			global::NPOI.Util.LittleEndian.PutShort(data, 2 + offset, (short)(this.RecordSize - 4));
			int num = offset + 4;
			foreach (global::NPOI.DDF.EscherRecord escherRecord in this.escherRecords)
			{
				num += escherRecord.Serialize(num, data, new global::NPOI.DDF.NullEscherSerializationListener());
			}
			return this.RecordSize;
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x000635B4 File Offset: 0x000617B4
		public override int RecordSize
		{
			get
			{
				byte[] rawData = this.RawData;
				if (this.escherRecords.Count == 0 && rawData != null)
				{
					return rawData.Length + 4;
				}
				int num = 4;
				foreach (global::NPOI.DDF.EscherRecord escherRecord in this.escherRecords)
				{
					num += escherRecord.RecordSize;
				}
				return num;
			}
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00062BA1 File Offset: 0x00060DA1
		public override object Clone()
		{
			return base.CloneViaReserialise();
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0006362C File Offset: 0x0006182C
		public void AddEscherRecord(int index, global::NPOI.DDF.EscherRecord element)
		{
			this.escherRecords.Insert(index, element);
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0006363B File Offset: 0x0006183B
		public bool AddEscherRecord(global::NPOI.DDF.EscherRecord element)
		{
			this.escherRecords.Add(element);
			return true;
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x0006364A File Offset: 0x0006184A
		public global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> EscherRecords
		{
			get
			{
				return this.escherRecords;
			}
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00063652 File Offset: 0x00061852
		public void ClearEscherRecords()
		{
			this.escherRecords.Clear();
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00063660 File Offset: 0x00061860
		public global::NPOI.DDF.EscherContainerRecord GetEscherContainer()
		{
			foreach (object obj in this.escherRecords)
			{
				if (obj is global::NPOI.DDF.EscherContainerRecord)
				{
					return (global::NPOI.DDF.EscherContainerRecord)obj;
				}
			}
			return null;
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0006369F File Offset: 0x0006189F
		public global::NPOI.DDF.EscherRecord FindFirstWithId(short id)
		{
			return this.FindFirstWithId(id, this.EscherRecords);
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x000636B0 File Offset: 0x000618B0
		private global::NPOI.DDF.EscherRecord FindFirstWithId(short id, global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> records)
		{
			foreach (object obj in records)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				if (escherRecord.RecordId == id)
				{
					return escherRecord;
				}
			}
			foreach (object obj2 in records)
			{
				global::NPOI.DDF.EscherRecord escherRecord2 = (global::NPOI.DDF.EscherRecord)obj2;
				if (escherRecord2.IsContainerRecord)
				{
					global::NPOI.DDF.EscherRecord escherRecord3 = this.FindFirstWithId(id, escherRecord2.ChildRecords);
					if (escherRecord3 != null)
					{
						return escherRecord3;
					}
				}
			}
			return null;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0006372B File Offset: 0x0006192B
		public global::NPOI.DDF.EscherRecord GetEscherRecord(int index)
		{
			return this.escherRecords[index];
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00063739 File Offset: 0x00061939
		public void Join(global::NPOI.HSSF.Record.AbstractEscherHolderRecord record)
		{
			this.rawDataContainer.Concatenate(record.RawData);
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0006374C File Offset: 0x0006194C
		public void ProcessContinueRecord(byte[] record)
		{
			this.rawDataContainer.Concatenate(record);
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x0006375A File Offset: 0x0006195A
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x00063767 File Offset: 0x00061967
		public byte[] RawData
		{
			get
			{
				return this.rawDataContainer.ToArray();
			}
			set
			{
				this.rawDataContainer.Clear();
				this.rawDataContainer.Concatenate(value);
			}
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00063780 File Offset: 0x00061980
		public void Decode()
		{
			if (this.escherRecords == null || this.escherRecords.Count == 0)
			{
				byte[] rawData = this.RawData;
				this.ConvertToEscherRecords(0, rawData.Length, rawData);
			}
		}

		// Token: 0x04000C94 RID: 3220
		private static bool DESERIALISE = false;

		// Token: 0x04000C95 RID: 3221
		private global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> escherRecords;

		// Token: 0x04000C96 RID: 3222
		private global::NPOI.HSSF.Util.LazilyConcatenatedByteArray rawDataContainer = new global::NPOI.HSSF.Util.LazilyConcatenatedByteArray();
	}
}
