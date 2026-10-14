using System;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000532 RID: 1330
	public class EscherBlipRecord : global::NPOI.DDF.EscherRecord
	{
		// Token: 0x060031ED RID: 12781 RVA: 0x000975B4 File Offset: 0x000957B4
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int sourceIndex = offset + 8;
			this.field_pictureData = new byte[num];
			global::System.Array.Copy(data, sourceIndex, this.field_pictureData, 0, num);
			return num + 8;
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x000975EC File Offset: 0x000957EC
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			global::NPOI.Util.LittleEndian.PutShort(data, offset + 2, this.RecordId);
			global::System.Array.Copy(this.field_pictureData, 0, data, offset + 4, this.field_pictureData.Length);
			listener.AfterRecordSerialize(offset + 4 + this.field_pictureData.Length, this.RecordId, this.field_pictureData.Length + 4, this);
			return this.field_pictureData.Length + 4;
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060031EF RID: 12783 RVA: 0x00097668 File Offset: 0x00095868
		public override int RecordSize
		{
			get
			{
				return this.field_pictureData.Length + 8;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060031F0 RID: 12784 RVA: 0x00097674 File Offset: 0x00095874
		public override string RecordName
		{
			get
			{
				return "Blip";
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x0009767B File Offset: 0x0009587B
		// (set) Token: 0x060031F2 RID: 12786 RVA: 0x00097683 File Offset: 0x00095883
		public byte[] PictureData
		{
			get
			{
				return this.field_pictureData;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("picture data can't be null");
				}
				this.field_pictureData = new byte[value.Length];
				if (value.Length != 0)
				{
					global::System.Array.Copy(value, this.field_pictureData, value.Length);
				}
			}
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x000976B4 File Offset: 0x000958B4
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			string text = string.Empty;
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				try
				{
					global::NPOI.Util.HexDump.Dump(this.field_pictureData, 0L, memoryStream, 0);
					text = global::NPOI.Util.HexDump.ToHex(memoryStream.ToArray());
				}
				catch (global::System.Exception ex)
				{
					text = ex.ToString();
				}
				result = string.Concat(new string[]
				{
					base.GetType().Name,
					":",
					newLine,
					"  RecordId: 0x",
					global::NPOI.Util.HexDump.ToHex(this.RecordId),
					newLine,
					"  Options: 0x",
					global::NPOI.Util.HexDump.ToHex(this.Options),
					newLine,
					"  Version: 0x",
					global::NPOI.Util.HexDump.ToHex(this.Version),
					newLine,
					"  Instance: 0x",
					global::NPOI.Util.HexDump.ToHex(this.Instance),
					newLine,
					"  Extra Data:",
					newLine,
					text
				});
			}
			return result;
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x000977CC File Offset: 0x000959CC
		public override string ToXml(string tab)
		{
			string value = global::NPOI.Util.HexDump.ToHex(this.field_pictureData, 32);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<ExtraData>").Append(value).Append("</ExtraData>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04001647 RID: 5703
		public const short RECORD_ID_START = -4072;

		// Token: 0x04001648 RID: 5704
		public const short RECORD_ID_END = -3817;

		// Token: 0x04001649 RID: 5705
		public const string RECORD_DESCRIPTION = "msofbtBlip";

		// Token: 0x0400164A RID: 5706
		private const int HEADER_SIZE = 8;

		// Token: 0x0400164B RID: 5707
		protected byte[] field_pictureData;
	}
}
