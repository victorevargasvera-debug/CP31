using System;
using System.Text;
using NPOI.HSSF.Util;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003EB RID: 1003
	public class HyperlinkRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x0600240D RID: 9229 RVA: 0x0006C6C8 File Offset: 0x0006A8C8
		public HyperlinkRecord()
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0006C708 File Offset: 0x0006A908
		public HyperlinkRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._range = new global::NPOI.SS.Util.CellRangeAddress(in1);
			this._guid = new global::NPOI.HSSF.Util.GUID(in1);
			int num = in1.ReadInt();
			if (num != 2)
			{
				throw new global::NPOI.Util.RecordFormatException("Stream Version must be 0x2 but found " + num.ToString());
			}
			this._linkOpts = in1.ReadInt();
			if ((this._linkOpts & 20) != 0)
			{
				int requestedLength = in1.ReadInt();
				this._label = in1.ReadUnicodeLEString(requestedLength);
			}
			if ((this._linkOpts & 128) != 0)
			{
				int requestedLength2 = in1.ReadInt();
				this._targetFrame = in1.ReadUnicodeLEString(requestedLength2);
			}
			if ((this._linkOpts & 1) != 0 && (this._linkOpts & 256) != 0)
			{
				this._moniker = null;
				int requestedLength3 = in1.ReadInt();
				this._address = in1.ReadUnicodeLEString(requestedLength3);
			}
			if ((this._linkOpts & 1) != 0 && (this._linkOpts & 256) == 0)
			{
				this._moniker = new global::NPOI.HSSF.Util.GUID(in1);
				if (global::NPOI.HSSF.Record.HyperlinkRecord.URL_MONIKER.Equals(this._moniker))
				{
					int num2 = in1.ReadInt();
					int remaining = in1.Remaining;
					if (num2 == remaining)
					{
						int requestedLength4 = num2 / 2;
						this._address = in1.ReadUnicodeLEString(requestedLength4);
					}
					else
					{
						int requestedLength5 = (num2 - global::NPOI.HSSF.Record.HyperlinkRecord.TAIL_SIZE) / 2;
						this._address = in1.ReadUnicodeLEString(requestedLength5);
						this._uninterpretedTail = global::NPOI.HSSF.Record.HyperlinkRecord.ReadTail(global::NPOI.HSSF.Record.HyperlinkRecord.URL_uninterpretedTail, in1);
					}
				}
				else if (global::NPOI.HSSF.Record.HyperlinkRecord.FILE_MONIKER.Equals(this._moniker))
				{
					this._fileOpts = in1.ReadShort();
					int nChars = in1.ReadInt();
					this._shortFilename = global::NPOI.Util.StringUtil.ReadCompressedUnicode(in1, nChars);
					this._uninterpretedTail = global::NPOI.HSSF.Record.HyperlinkRecord.ReadTail(global::NPOI.HSSF.Record.HyperlinkRecord.FILE_uninterpretedTail, in1);
					if (in1.ReadInt() > 0)
					{
						int num3 = in1.ReadInt();
						in1.ReadUShort();
						this._address = global::NPOI.Util.StringUtil.ReadUnicodeLE(in1, num3 / 2);
					}
					else
					{
						this._address = null;
					}
				}
				else if (global::NPOI.HSSF.Record.HyperlinkRecord.STD_MONIKER.Equals(this._moniker))
				{
					this._fileOpts = in1.ReadShort();
					byte[] array = new byte[in1.ReadInt()];
					in1.ReadFully(array);
					this._address = global::System.Text.Encoding.UTF8.GetString(array);
				}
			}
			if ((this._linkOpts & 8) != 0)
			{
				int requestedLength6 = in1.ReadInt();
				this._textMark = in1.ReadUnicodeLEString(requestedLength6);
			}
			if (in1.Remaining > 0)
			{
				global::System.Console.WriteLine(global::NPOI.Util.HexDump.ToHex(in1.ReadRemainder()));
			}
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0006C9A0 File Offset: 0x0006ABA0
		private static byte[] ReadTail(byte[] expectedTail, global::NPOI.Util.ILittleEndianInput in1)
		{
			byte[] array = new byte[global::NPOI.HSSF.Record.HyperlinkRecord.TAIL_SIZE];
			in1.ReadFully(array);
			return array;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0006C9C0 File Offset: 0x0006ABC0
		private static void WriteTail(byte[] tail, global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.Write(tail);
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x0006C9C9 File Offset: 0x0006ABC9
		// (set) Token: 0x06002412 RID: 9234 RVA: 0x0006C9D6 File Offset: 0x0006ABD6
		public int FirstColumn
		{
			get
			{
				return this._range.FirstColumn;
			}
			set
			{
				this._range.FirstColumn = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x0006C9E4 File Offset: 0x0006ABE4
		// (set) Token: 0x06002414 RID: 9236 RVA: 0x0006C9F1 File Offset: 0x0006ABF1
		public int LastColumn
		{
			get
			{
				return this._range.LastColumn;
			}
			set
			{
				this._range.LastColumn = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x0006C9FF File Offset: 0x0006ABFF
		// (set) Token: 0x06002416 RID: 9238 RVA: 0x0006CA0C File Offset: 0x0006AC0C
		public int FirstRow
		{
			get
			{
				return this._range.FirstRow;
			}
			set
			{
				this._range.FirstRow = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x0006CA1A File Offset: 0x0006AC1A
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x0006CA27 File Offset: 0x0006AC27
		public int LastRow
		{
			get
			{
				return this._range.LastRow;
			}
			set
			{
				this._range.LastRow = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x0006CA35 File Offset: 0x0006AC35
		public global::NPOI.HSSF.Util.GUID Guid
		{
			get
			{
				return this._guid;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x0006CA3D File Offset: 0x0006AC3D
		public global::NPOI.HSSF.Util.GUID Moniker
		{
			get
			{
				return this._moniker;
			}
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0006CA48 File Offset: 0x0006AC48
		private static string CleanString(string s)
		{
			if (s == null)
			{
				return null;
			}
			int num = s.IndexOf('\0');
			if (num < 0)
			{
				return s;
			}
			return s.Substring(0, num);
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0006CA70 File Offset: 0x0006AC70
		private static string AppendNullTerm(string s)
		{
			if (s == null)
			{
				return null;
			}
			return s + "\0";
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x0006CA82 File Offset: 0x0006AC82
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x0006CA8F File Offset: 0x0006AC8F
		public string Label
		{
			get
			{
				return global::NPOI.HSSF.Record.HyperlinkRecord.CleanString(this._label);
			}
			set
			{
				this._label = global::NPOI.HSSF.Record.HyperlinkRecord.AppendNullTerm(value);
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x0006CAA0 File Offset: 0x0006ACA0
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x0006CB10 File Offset: 0x0006AD10
		public string Address
		{
			get
			{
				if ((this._linkOpts & 1) != 0 && this._moniker != null && global::NPOI.HSSF.Record.HyperlinkRecord.FILE_MONIKER.Equals(this._moniker))
				{
					return global::NPOI.HSSF.Record.HyperlinkRecord.CleanString((this._address != null) ? this._address : this._shortFilename);
				}
				if ((this._linkOpts & 8) != 0)
				{
					return global::NPOI.HSSF.Record.HyperlinkRecord.CleanString(this._textMark);
				}
				return global::NPOI.HSSF.Record.HyperlinkRecord.CleanString(this._address);
			}
			set
			{
				if ((this._linkOpts & 1) != 0 && this._moniker != null && global::NPOI.HSSF.Record.HyperlinkRecord.FILE_MONIKER.Equals(this._moniker))
				{
					this._shortFilename = global::NPOI.HSSF.Record.HyperlinkRecord.AppendNullTerm(value);
					return;
				}
				if ((this._linkOpts & 8) != 0)
				{
					this._textMark = global::NPOI.HSSF.Record.HyperlinkRecord.AppendNullTerm(value);
					return;
				}
				this._address = global::NPOI.HSSF.Record.HyperlinkRecord.AppendNullTerm(value);
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x0006CB71 File Offset: 0x0006AD71
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x0006CB7E File Offset: 0x0006AD7E
		public string TextMark
		{
			get
			{
				return global::NPOI.HSSF.Record.HyperlinkRecord.CleanString(this._textMark);
			}
			set
			{
				this._textMark = global::NPOI.HSSF.Record.HyperlinkRecord.AppendNullTerm(value);
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x0006CB8C File Offset: 0x0006AD8C
		public int LinkOptions
		{
			get
			{
				return this._linkOpts;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x0006CB94 File Offset: 0x0006AD94
		public string TargetFrame
		{
			get
			{
				return global::NPOI.HSSF.Record.HyperlinkRecord.CleanString(this._targetFrame);
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x0006CBA1 File Offset: 0x0006ADA1
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x0006CBAE File Offset: 0x0006ADAE
		public string ShortFilename
		{
			get
			{
				return global::NPOI.HSSF.Record.HyperlinkRecord.CleanString(this._shortFilename);
			}
			set
			{
				this._shortFilename = global::NPOI.HSSF.Record.HyperlinkRecord.AppendNullTerm(value);
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x00016A02 File Offset: 0x00014C02
		public int LabelOptions
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x0006CBBC File Offset: 0x0006ADBC
		public int FileOptions
		{
			get
			{
				return (int)this._fileOpts;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x0006CBC4 File Offset: 0x0006ADC4
		public override short Sid
		{
			get
			{
				return 440;
			}
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x0006CBCC File Offset: 0x0006ADCC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			this._range.Serialize(out1);
			this._guid.Serialize(out1);
			out1.WriteInt(2);
			out1.WriteInt(this._linkOpts);
			if ((this._linkOpts & 20) != 0)
			{
				out1.WriteInt(this._label.Length);
				global::NPOI.Util.StringUtil.PutUnicodeLE(this._label, out1);
			}
			if ((this._linkOpts & 128) != 0)
			{
				out1.WriteInt(this._targetFrame.Length);
				global::NPOI.Util.StringUtil.PutUnicodeLE(this._targetFrame, out1);
			}
			if ((this._linkOpts & 1) != 0 && (this._linkOpts & 256) != 0)
			{
				out1.WriteInt(this._address.Length);
				global::NPOI.Util.StringUtil.PutUnicodeLE(this._address, out1);
			}
			if ((this._linkOpts & 1) != 0 && (this._linkOpts & 256) == 0)
			{
				this._moniker.Serialize(out1);
				if (this._moniker != null && global::NPOI.HSSF.Record.HyperlinkRecord.URL_MONIKER.Equals(this._moniker))
				{
					if (this._uninterpretedTail == null)
					{
						out1.WriteInt(this._address.Length * 2);
						global::NPOI.Util.StringUtil.PutUnicodeLE(this._address, out1);
					}
					else
					{
						out1.WriteInt(this._address.Length * 2 + global::NPOI.HSSF.Record.HyperlinkRecord.TAIL_SIZE);
						global::NPOI.Util.StringUtil.PutUnicodeLE(this._address, out1);
						global::NPOI.HSSF.Record.HyperlinkRecord.WriteTail(this._uninterpretedTail, out1);
					}
				}
				else if (this._moniker != null && global::NPOI.HSSF.Record.HyperlinkRecord.FILE_MONIKER.Equals(this._moniker))
				{
					out1.WriteShort((int)this._fileOpts);
					out1.WriteInt(this._shortFilename.Length);
					global::NPOI.Util.StringUtil.PutCompressedUnicode(this._shortFilename, out1);
					global::NPOI.HSSF.Record.HyperlinkRecord.WriteTail(this._uninterpretedTail, out1);
					if (string.IsNullOrEmpty(this._address))
					{
						out1.WriteInt(0);
					}
					else
					{
						int num = this._address.Length * 2;
						out1.WriteInt(num + 6);
						out1.WriteInt(num);
						out1.WriteShort(3);
						global::NPOI.Util.StringUtil.PutUnicodeLE(this._address, out1);
					}
				}
			}
			if ((this._linkOpts & 8) != 0)
			{
				out1.WriteInt(this._textMark.Length);
				global::NPOI.Util.StringUtil.PutUnicodeLE(this._textMark, out1);
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x0006CDF4 File Offset: 0x0006AFF4
		protected override int DataSize
		{
			get
			{
				int num = 0;
				num += 8;
				num += 16;
				num += 4;
				num += 4;
				if ((this._linkOpts & 20) != 0)
				{
					num += 4;
					num += this._label.Length * 2;
				}
				if ((this._linkOpts & 128) != 0)
				{
					num += 4;
					num += this._targetFrame.Length * 2;
				}
				if ((this._linkOpts & 1) != 0 && (this._linkOpts & 256) != 0)
				{
					num += 4;
					num += this._address.Length * 2;
				}
				if ((this._linkOpts & 1) != 0 && (this._linkOpts & 256) == 0)
				{
					num += 16;
					if (this._moniker != null && global::NPOI.HSSF.Record.HyperlinkRecord.URL_MONIKER.Equals(this._moniker))
					{
						num += 4;
						num += this._address.Length * 2;
						if (this._uninterpretedTail != null)
						{
							num += global::NPOI.HSSF.Record.HyperlinkRecord.TAIL_SIZE;
						}
					}
					else if (this._moniker != null && global::NPOI.HSSF.Record.HyperlinkRecord.FILE_MONIKER.Equals(this._moniker))
					{
						num += 2;
						num += 4;
						num += ((this._shortFilename == null) ? 0 : this._shortFilename.Length);
						num += global::NPOI.HSSF.Record.HyperlinkRecord.TAIL_SIZE;
						num += 4;
						if (!string.IsNullOrEmpty(this._address))
						{
							num += 6;
							num += this._address.Length * 2;
						}
					}
				}
				if ((this._linkOpts & 8) != 0)
				{
					num += 4;
					num += this._textMark.Length * 2;
				}
				return num;
			}
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0006CF6C File Offset: 0x0006B16C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[HYPERLINK RECORD]\n");
			stringBuilder.Append("    .range            = ").Append(this._range.FormatAsString()).Append("\n");
			stringBuilder.Append("    .guid        = ").Append(this._guid.FormatAsString()).Append("\n");
			stringBuilder.Append("    .linkOpts          = ").Append(global::NPOI.Util.HexDump.IntToHex(this._linkOpts)).Append("\n");
			stringBuilder.Append("    .label          = ").Append(this.Label).Append("\n");
			if ((this._linkOpts & 128) != 0)
			{
				stringBuilder.Append("    .targetFrame= ").Append(this.TargetFrame).Append("\n");
			}
			if ((this._linkOpts & 1) != 0 && this._moniker != null)
			{
				stringBuilder.Append("    .moniker          = ").Append(this._moniker.FormatAsString()).Append("\n");
			}
			if ((this._linkOpts & 8) != 0)
			{
				stringBuilder.Append("    .targetFrame= ").Append(this.TextMark).Append("\n");
			}
			stringBuilder.Append("    .address            = ").Append(this.Address).Append("\n");
			stringBuilder.Append("[/HYPERLINK RECORD]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x0006D0E3 File Offset: 0x0006B2E3
		public bool IsUrlLink
		{
			get
			{
				return (this._linkOpts & 1) > 0 && (this._linkOpts & 2) > 0;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x0006D0FD File Offset: 0x0006B2FD
		public bool IsFileLink
		{
			get
			{
				return (this._linkOpts & 1) > 0 && (this._linkOpts & 2) == 0;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x0006D117 File Offset: 0x0006B317
		public bool IsDocumentLink
		{
			get
			{
				return (this._linkOpts & 8) > 0;
			}
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0006D124 File Offset: 0x0006B324
		public void CreateUrlLink()
		{
			this._range = new global::NPOI.SS.Util.CellRangeAddress(0, 0, 0, 0);
			this._guid = global::NPOI.HSSF.Record.HyperlinkRecord.STD_MONIKER;
			this._linkOpts = 23;
			this.Label = "";
			this._moniker = global::NPOI.HSSF.Record.HyperlinkRecord.URL_MONIKER;
			this.Address = "";
			this._uninterpretedTail = global::NPOI.HSSF.Record.HyperlinkRecord.URL_uninterpretedTail;
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x0006D180 File Offset: 0x0006B380
		public void CreateFileLink()
		{
			this._range = new global::NPOI.SS.Util.CellRangeAddress(0, 0, 0, 0);
			this._guid = global::NPOI.HSSF.Record.HyperlinkRecord.STD_MONIKER;
			this._linkOpts = 21;
			this._fileOpts = 0;
			this.Label = "";
			this._moniker = global::NPOI.HSSF.Record.HyperlinkRecord.FILE_MONIKER;
			this.Address = null;
			this.ShortFilename = "";
			this._uninterpretedTail = global::NPOI.HSSF.Record.HyperlinkRecord.FILE_uninterpretedTail;
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0006D1EC File Offset: 0x0006B3EC
		public void CreateDocumentLink()
		{
			this._range = new global::NPOI.SS.Util.CellRangeAddress(0, 0, 0, 0);
			this._guid = global::NPOI.HSSF.Record.HyperlinkRecord.STD_MONIKER;
			this._linkOpts = 28;
			this.Label = "";
			this._moniker = global::NPOI.HSSF.Record.HyperlinkRecord.FILE_MONIKER;
			this.Address = "";
			this.TextMark = "";
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0006D248 File Offset: 0x0006B448
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.HyperlinkRecord
			{
				_range = this._range.Copy(),
				_guid = this._guid,
				_linkOpts = this._linkOpts,
				_fileOpts = this._fileOpts,
				_label = this._label,
				_address = this._address,
				_moniker = this._moniker,
				_shortFilename = this._shortFilename,
				_targetFrame = this._targetFrame,
				_textMark = this._textMark,
				_uninterpretedTail = this._uninterpretedTail
			};
		}

		// Token: 0x04000F22 RID: 3874
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HSSF.Record.HyperlinkRecord));

		// Token: 0x04000F23 RID: 3875
		public const int HLINK_URL = 1;

		// Token: 0x04000F24 RID: 3876
		public const int HLINK_ABS = 2;

		// Token: 0x04000F25 RID: 3877
		public const int HLINK_LABEL = 20;

		// Token: 0x04000F26 RID: 3878
		public const int HLINK_PLACE = 8;

		// Token: 0x04000F27 RID: 3879
		private const int HLINK_TARGET_FRAME = 128;

		// Token: 0x04000F28 RID: 3880
		private const int HLINK_UNC_PATH = 256;

		// Token: 0x04000F29 RID: 3881
		public static readonly global::NPOI.HSSF.Util.GUID STD_MONIKER = global::NPOI.HSSF.Util.GUID.Parse("79EAC9D0-BAF9-11CE-8C82-00AA004BA90B");

		// Token: 0x04000F2A RID: 3882
		public static readonly global::NPOI.HSSF.Util.GUID URL_MONIKER = global::NPOI.HSSF.Util.GUID.Parse("79EAC9E0-BAF9-11CE-8C82-00AA004BA90B");

		// Token: 0x04000F2B RID: 3883
		public static readonly global::NPOI.HSSF.Util.GUID FILE_MONIKER = global::NPOI.HSSF.Util.GUID.Parse("00000303-0000-0000-C000-000000000046");

		// Token: 0x04000F2C RID: 3884
		public static readonly byte[] URL_uninterpretedTail = global::NPOI.Util.HexRead.ReadFromString("79 58 81 F4  3B 1D 7F 48   AF 2C 82 5D  C4 85 27 63   00 00 00 00  A5 AB 00 00");

		// Token: 0x04000F2D RID: 3885
		public static readonly byte[] FILE_uninterpretedTail = global::NPOI.Util.HexRead.ReadFromString("FF FF AD DE  00 00 00 00   00 00 00 00  00 00 00 00   00 00 00 00  00 00 00 00");

		// Token: 0x04000F2E RID: 3886
		private static readonly int TAIL_SIZE = global::NPOI.HSSF.Record.HyperlinkRecord.FILE_uninterpretedTail.Length;

		// Token: 0x04000F2F RID: 3887
		public const short sid = 440;

		// Token: 0x04000F30 RID: 3888
		private global::NPOI.SS.Util.CellRangeAddress _range;

		// Token: 0x04000F31 RID: 3889
		private global::NPOI.HSSF.Util.GUID _guid;

		// Token: 0x04000F32 RID: 3890
		private short _fileOpts;

		// Token: 0x04000F33 RID: 3891
		private int _linkOpts;

		// Token: 0x04000F34 RID: 3892
		private string _label = string.Empty;

		// Token: 0x04000F35 RID: 3893
		private string _targetFrame = string.Empty;

		// Token: 0x04000F36 RID: 3894
		private global::NPOI.HSSF.Util.GUID _moniker;

		// Token: 0x04000F37 RID: 3895
		private string _shortFilename = string.Empty;

		// Token: 0x04000F38 RID: 3896
		private string _address = string.Empty;

		// Token: 0x04000F39 RID: 3897
		private string _textMark = string.Empty;

		// Token: 0x04000F3A RID: 3898
		private byte[] _uninterpretedTail;
	}
}
