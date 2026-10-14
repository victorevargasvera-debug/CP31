using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200054D RID: 1357
	public class EscherTextboxRecord : global::NPOI.DDF.EscherRecord, global::System.ICloneable
	{
		// Token: 0x06003347 RID: 13127 RVA: 0x000A054C File Offset: 0x0009E74C
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			this._thedata = new byte[num];
			global::System.Array.Copy(data, offset + 8, this._thedata, 0, num);
			return num + 8;
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x000A0584 File Offset: 0x0009E784
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			int value = this._thedata.Length;
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 4, value);
			global::System.Array.Copy(this._thedata, 0, data, offset + 8, this._thedata.Length);
			int num = offset + 8 + this._thedata.Length;
			listener.AfterRecordSerialize(num, this.RecordId, num - offset, this);
			int num2 = num - offset;
			if (num2 != this.RecordSize)
			{
				throw new global::NPOI.Util.RecordFormatException(num2.ToString() + " bytes written but RecordSize reports " + this.RecordSize.ToString());
			}
			return num2;
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06003349 RID: 13129 RVA: 0x000A0637 File Offset: 0x0009E837
		public byte[] Data
		{
			get
			{
				return this._thedata;
			}
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x000A063F File Offset: 0x0009E83F
		public void SetData(byte[] b, int start, int length)
		{
			this._thedata = new byte[length];
			global::System.Array.Copy(b, start, this._thedata, 0, length);
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x000A065C File Offset: 0x0009E85C
		public void SetData(byte[] b)
		{
			this.SetData(b, 0, b.Length);
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x000A0669 File Offset: 0x0009E869
		public override int RecordSize
		{
			get
			{
				return 8 + this._thedata.Length;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600334D RID: 13133 RVA: 0x000A0675 File Offset: 0x0009E875
		public override string RecordName
		{
			get
			{
				return "ClientTextbox";
			}
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x000A067C File Offset: 0x0009E87C
		public override object Clone()
		{
			return new global::NPOI.DDF.EscherTextboxRecord
			{
				Options = this.Options,
				RecordId = this.RecordId,
				_thedata = (byte[])this._thedata.Clone()
			};
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x000A06B4 File Offset: 0x0009E8B4
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			string text = "";
			try
			{
				if (this._thedata.Length != 0)
				{
					text = "  Extra Data:" + newLine;
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
				"  options: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Options),
				newLine,
				"  recordId: 0x",
				global::NPOI.Util.HexDump.ToHex(this.RecordId),
				newLine,
				"  numchildren: ",
				this.ChildRecords.Count.ToString(),
				newLine,
				text
			});
		}

		// Token: 0x06003350 RID: 13136 RVA: 0x000A07B8 File Offset: 0x0009E9B8
		public override string ToXml(string tab)
		{
			string text = "";
			try
			{
				if (this._thedata.Length != 0)
				{
					text += global::NPOI.Util.HexDump.Dump(this._thedata, 0L, 0);
				}
			}
			catch (global::System.Exception)
			{
				text = "Error!!";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<ExtraData>").Append(text).Append("</ExtraData>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001814 RID: 6164
		public const short RECORD_ID = -4083;

		// Token: 0x04001815 RID: 6165
		public const string RECORD_DESCRIPTION = "msofbtClientTextbox";

		// Token: 0x04001816 RID: 6166
		private static readonly byte[] NO_BYTES = new byte[0];

		// Token: 0x04001817 RID: 6167
		private byte[] _thedata = global::NPOI.DDF.EscherTextboxRecord.NO_BYTES;
	}
}
