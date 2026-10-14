using System;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200054F RID: 1359
	public class UnknownEscherRecord : global::NPOI.DDF.EscherRecord, global::System.ICloneable
	{
		// Token: 0x06003357 RID: 13143 RVA: 0x000A08E4 File Offset: 0x0009EAE4
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int i = base.ReadHeader(data, offset);
			int num = data.Length - (offset + 8);
			if (i > num)
			{
				i = num;
			}
			if (base.IsContainerRecord)
			{
				int num2 = 0;
				this._thedata = new byte[0];
				offset += 8;
				num2 += 8;
				while (i > 0)
				{
					global::NPOI.DDF.EscherRecord escherRecord = recordFactory.CreateRecord(data, offset);
					int num3 = escherRecord.FillFields(data, offset, recordFactory);
					num2 += num3;
					offset += num3;
					i -= num3;
					this.ChildRecords.Add(escherRecord);
				}
				return num2;
			}
			this._thedata = new byte[i];
			global::System.Array.Copy(data, offset + 8, this._thedata, 0, i);
			return i + 8;
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x000A0980 File Offset: 0x0009EB80
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			int num = this._thedata.Length;
			foreach (object obj in this.ChildRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
				num += escherRecord.RecordSize;
			}
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, num);
			global::System.Array.Copy(this._thedata, 0, data, offset + 8, this._thedata.Length);
			int num2 = offset + 8 + this._thedata.Length;
			foreach (object obj2 in this.ChildRecords)
			{
				global::NPOI.DDF.EscherRecord escherRecord2 = (global::NPOI.DDF.EscherRecord)obj2;
				num2 += escherRecord2.Serialize(num2, data);
			}
			listener.AfterRecordSerialize(num2, this.RecordId, num2 - offset, this);
			return num2 - offset;
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06003359 RID: 13145 RVA: 0x000A0A6A File Offset: 0x0009EC6A
		public byte[] Data
		{
			get
			{
				return this._thedata;
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x0600335A RID: 13146 RVA: 0x000A0A72 File Offset: 0x0009EC72
		public override int RecordSize
		{
			get
			{
				return 8 + this._thedata.Length;
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x0600335B RID: 13147 RVA: 0x000A0A7E File Offset: 0x0009EC7E
		// (set) Token: 0x0600335C RID: 13148 RVA: 0x000A0A86 File Offset: 0x0009EC86
		public override global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> ChildRecords
		{
			get
			{
				return this._childRecords;
			}
			set
			{
				this._childRecords = value;
			}
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x000A0A8F File Offset: 0x0009EC8F
		public override object Clone()
		{
			return new global::NPOI.DDF.UnknownEscherRecord
			{
				_thedata = (byte[])this._thedata.Clone(),
				Options = this.Options,
				RecordId = this.RecordId
			};
		}

		// Token: 0x17000D83 RID: 3459
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x000A0AC4 File Offset: 0x0009ECC4
		public override string RecordName
		{
			get
			{
				return "Unknown 0x" + global::NPOI.Util.HexDump.ToHex(this.RecordId);
			}
		}

		// Token: 0x0600335F RID: 13151 RVA: 0x000A0ADC File Offset: 0x0009ECDC
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.ChildRecords.Count > 0)
			{
				stringBuilder.Append("  children: " + newLine);
				foreach (object obj in this.ChildRecords)
				{
					global::NPOI.DDF.EscherRecord escherRecord = (global::NPOI.DDF.EscherRecord)obj;
					stringBuilder.Append(escherRecord.ToString());
					stringBuilder.Append(newLine);
				}
			}
			string text = "";
			try
			{
				if (this._thedata.Length != 0)
				{
					text = "  Extra Data(" + this._thedata.Length.ToString() + "):" + newLine;
					text += global::NPOI.Util.HexDump.Dump(this._thedata, 0L, 0);
				}
			}
			catch (global::System.Exception)
			{
				text = "Error!!";
			}
			return string.Concat(new string[]
			{
				base.GetType().Name,
				":",
				newLine,
				"  isContainer: ",
				base.IsContainerRecord.ToString(),
				newLine,
				"  version: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Version),
				newLine,
				"  instance: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Instance),
				newLine,
				"  recordId: 0x",
				global::NPOI.Util.HexDump.ToHex(this.RecordId),
				newLine,
				"  numchildren: ",
				this.ChildRecords.Count.ToString(),
				newLine,
				text,
				stringBuilder.ToString()
			});
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x000A0C84 File Offset: 0x0009EE84
		public override string ToXml(string tab)
		{
			string value = global::NPOI.Util.HexDump.ToHex(this._thedata, 32);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<IsContainer>").Append(base.IsContainerRecord).Append("</IsContainer>\n").Append(tab).Append("\t").Append("<Numchildren>").Append(global::NPOI.Util.HexDump.ToHex(this._childRecords.Count)).Append("</Numchildren>\n");
			foreach (global::NPOI.DDF.EscherRecord escherRecord in this._childRecords)
			{
				stringBuilder.Append(escherRecord.ToXml(tab + "\t"));
			}
			stringBuilder.Append(value).Append("\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000A0DCA File Offset: 0x0009EFCA
		public void AddChildRecord(global::NPOI.DDF.EscherRecord childRecord)
		{
			this.ChildRecords.Add(childRecord);
		}

		// Token: 0x04001818 RID: 6168
		private static byte[] NO_BYTES = new byte[0];

		// Token: 0x04001819 RID: 6169
		private byte[] _thedata = global::NPOI.DDF.UnknownEscherRecord.NO_BYTES;

		// Token: 0x0400181A RID: 6170
		private global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord> _childRecords = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherRecord>();
	}
}
