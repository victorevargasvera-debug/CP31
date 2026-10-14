using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003FE RID: 1022
	public class ObjRecord : global::NPOI.HSSF.Record.Record, global::System.ICloneable
	{
		// Token: 0x06002517 RID: 9495 RVA: 0x0006F4E1 File Offset: 0x0006D6E1
		public ObjRecord()
		{
			this.subrecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.SubRecord>(2);
			this._uninterpretedData = null;
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x0006F4FC File Offset: 0x0006D6FC
		public ObjRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			byte[] array = in1.ReadRemainder();
			if (global::NPOI.Util.LittleEndian.GetUShort(array, 0) != 21)
			{
				this._uninterpretedData = array;
				this.subrecords = null;
				return;
			}
			this.subrecords = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.SubRecord>();
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
			{
				global::NPOI.Util.LittleEndianInputStream littleEndianInputStream = new global::NPOI.Util.LittleEndianInputStream(memoryStream);
				global::NPOI.HSSF.Record.CommonObjectDataSubRecord commonObjectDataSubRecord = (global::NPOI.HSSF.Record.CommonObjectDataSubRecord)global::NPOI.HSSF.Record.SubRecord.CreateSubRecord(littleEndianInputStream, global::NPOI.HSSF.Record.CommonObjectType.Group);
				this.subrecords.Add(commonObjectDataSubRecord);
				global::NPOI.HSSF.Record.SubRecord subRecord;
				do
				{
					subRecord = global::NPOI.HSSF.Record.SubRecord.CreateSubRecord(littleEndianInputStream, commonObjectDataSubRecord.ObjectType);
					this.subrecords.Add(subRecord);
				}
				while (!subRecord.IsTerminating);
				int num = littleEndianInputStream.Available();
				if (num > 0)
				{
					this._isPaddedToQuadByteMultiple = (array.Length % 4 == 0);
					if (num >= (this._isPaddedToQuadByteMultiple ? 4 : 2))
					{
						if (!global::NPOI.HSSF.Record.ObjRecord.CanPaddingBeDiscarded(array, num))
						{
							throw new global::NPOI.Util.RecordFormatException("Leftover " + num.ToString() + " bytes in subrecord data " + global::NPOI.Util.HexDump.ToHex(array));
						}
						this._isPaddedToQuadByteMultiple = false;
					}
				}
				else
				{
					this._isPaddedToQuadByteMultiple = false;
				}
				this._uninterpretedData = null;
			}
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x0006F610 File Offset: 0x0006D810
		private static bool CanPaddingBeDiscarded(byte[] data, int nRemainingBytes)
		{
			for (int i = data.Length - nRemainingBytes; i < data.Length; i++)
			{
				if (data[i] != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x0006F638 File Offset: 0x0006D838
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[OBJ]\n");
			for (int i = 0; i < this.subrecords.Count; i++)
			{
				global::NPOI.HSSF.Record.SubRecord subRecord = this.subrecords[i];
				stringBuilder.Append("SUBRECORD: ").Append(subRecord.ToString());
			}
			stringBuilder.Append("[/OBJ]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x0006F6A4 File Offset: 0x0006D8A4
		public override int Serialize(int offset, byte[] data)
		{
			int recordSize = this.RecordSize;
			int num = recordSize - 4;
			global::NPOI.Util.LittleEndianByteArrayOutputStream littleEndianByteArrayOutputStream = new global::NPOI.Util.LittleEndianByteArrayOutputStream(data, offset, recordSize);
			littleEndianByteArrayOutputStream.WriteShort(93);
			littleEndianByteArrayOutputStream.WriteShort(num);
			if (this._uninterpretedData == null)
			{
				for (int i = 0; i < this.subrecords.Count; i++)
				{
					this.subrecords[i].Serialize(littleEndianByteArrayOutputStream);
				}
				int num2 = offset + num;
				while (littleEndianByteArrayOutputStream.WriteIndex < num2)
				{
					littleEndianByteArrayOutputStream.WriteByte(0);
				}
			}
			else
			{
				littleEndianByteArrayOutputStream.Write(this._uninterpretedData);
			}
			return recordSize;
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x0006F730 File Offset: 0x0006D930
		public override int RecordSize
		{
			get
			{
				if (this._uninterpretedData != null)
				{
					return this._uninterpretedData.Length + 4;
				}
				int num = 0;
				for (int i = this.subrecords.Count - 1; i >= 0; i--)
				{
					global::NPOI.HSSF.Record.SubRecord subRecord = this.subrecords[i];
					num += subRecord.DataSize + 4;
				}
				if (this._isPaddedToQuadByteMultiple)
				{
					while (num % 4 != 0)
					{
						num++;
					}
				}
				else
				{
					while (num % 2 != 0)
					{
						num++;
					}
				}
				return num + 4;
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x0006F7A3 File Offset: 0x0006D9A3
		public override short Sid
		{
			get
			{
				return 93;
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600251E RID: 9502 RVA: 0x0006F7A7 File Offset: 0x0006D9A7
		public global::System.Collections.Generic.List<global::NPOI.HSSF.Record.SubRecord> SubRecords
		{
			get
			{
				return this.subrecords;
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0006F7AF File Offset: 0x0006D9AF
		public void ClearSubRecords()
		{
			this.subrecords.Clear();
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x0006F7BC File Offset: 0x0006D9BC
		public void AddSubRecord(int index, global::NPOI.HSSF.Record.SubRecord element)
		{
			this.subrecords.Insert(index, element);
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0006F7CB File Offset: 0x0006D9CB
		public void AddSubRecord(global::NPOI.HSSF.Record.SubRecord o)
		{
			this.subrecords.Add(o);
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0006F7DC File Offset: 0x0006D9DC
		public override object Clone()
		{
			global::NPOI.HSSF.Record.ObjRecord objRecord = new global::NPOI.HSSF.Record.ObjRecord();
			for (int i = 0; i < this.subrecords.Count; i++)
			{
				global::NPOI.HSSF.Record.SubRecord subRecord = this.subrecords[i];
				objRecord.AddSubRecord((global::NPOI.HSSF.Record.SubRecord)subRecord.Clone());
			}
			return objRecord;
		}

		// Token: 0x04000F98 RID: 3992
		private const int NORMAL_PAD_ALIGNMENT = 2;

		// Token: 0x04000F99 RID: 3993
		private const int MAX_PAD_ALIGNMENT = 4;

		// Token: 0x04000F9A RID: 3994
		public const short sid = 93;

		// Token: 0x04000F9B RID: 3995
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.SubRecord> subrecords;

		// Token: 0x04000F9C RID: 3996
		private byte[] _uninterpretedData;

		// Token: 0x04000F9D RID: 3997
		private bool _isPaddedToQuadByteMultiple;
	}
}
