using System;
using System.Drawing;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200053F RID: 1343
	public class EscherPictBlip : global::NPOI.DDF.EscherBlipRecord
	{
		// Token: 0x060032BC RID: 12988 RVA: 0x0009D134 File Offset: 0x0009B334
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = offset + 8;
			global::System.Array.Copy(data, num2, this.field_1_UID, 0, 16);
			num2 += 16;
			this.field_2_cb = global::NPOI.Util.LittleEndian.GetInt(data, num2);
			num2 += 4;
			this.field_3_rcBounds_x1 = global::NPOI.Util.LittleEndian.GetInt(data, num2);
			num2 += 4;
			this.field_3_rcBounds_y1 = global::NPOI.Util.LittleEndian.GetInt(data, num2);
			num2 += 4;
			this.field_3_rcBounds_x2 = global::NPOI.Util.LittleEndian.GetInt(data, num2);
			num2 += 4;
			this.field_3_rcBounds_y2 = global::NPOI.Util.LittleEndian.GetInt(data, num2);
			num2 += 4;
			this.field_4_ptSize_w = global::NPOI.Util.LittleEndian.GetInt(data, num2);
			num2 += 4;
			this.field_4_ptSize_h = global::NPOI.Util.LittleEndian.GetInt(data, num2);
			num2 += 4;
			this.field_5_cbSave = global::NPOI.Util.LittleEndian.GetInt(data, num2);
			num2 += 4;
			this.field_6_fCompression = data[num2];
			num2++;
			this.field_7_fFilter = data[num2];
			num2++;
			this.raw_pictureData = new byte[this.field_5_cbSave];
			global::System.Array.Copy(data, num2, this.raw_pictureData, 0, this.field_5_cbSave);
			if (this.field_6_fCompression == 0)
			{
				this.field_pictureData = global::NPOI.DDF.EscherPictBlip.InflatePictureData(this.raw_pictureData);
			}
			else
			{
				this.field_pictureData = this.raw_pictureData;
			}
			return num + 8;
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x0009D254 File Offset: 0x0009B454
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			int num = offset + 2;
			global::NPOI.Util.LittleEndian.PutShort(data, num, this.RecordId);
			num += 2;
			global::NPOI.Util.LittleEndian.PutInt(data, 0, this.RecordSize - 8);
			num += 4;
			global::System.Array.Copy(this.field_1_UID, 0, data, num, 16);
			num += 16;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_2_cb);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_3_rcBounds_x1);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_3_rcBounds_y1);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_3_rcBounds_x2);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_3_rcBounds_y2);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_4_ptSize_w);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_4_ptSize_h);
			num += 4;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.field_5_cbSave);
			num += 4;
			data[num] = this.field_6_fCompression;
			num++;
			data[num] = this.field_7_fFilter;
			num++;
			global::System.Array.Copy(this.raw_pictureData, 0, data, num, this.raw_pictureData.Length);
			listener.AfterRecordSerialize(offset + this.RecordSize, this.RecordId, this.RecordSize, this);
			return 25 + this.raw_pictureData.Length;
		}

		// Token: 0x060032BE RID: 12990 RVA: 0x0009D39C File Offset: 0x0009B59C
		private static byte[] InflatePictureData(byte[] data)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				try
				{
					using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(data))
					{
						global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf = new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(false);
						using (global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream inflaterInputStream = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream(memoryStream2, inf))
						{
							byte[] array = new byte[4096];
							int count;
							while ((count = inflaterInputStream.Read(array, 0, array.Length)) > 0)
							{
								memoryStream.Write(array, 0, count);
							}
							result = memoryStream.ToArray();
						}
					}
				}
				catch (global::System.IO.IOException exception)
				{
					global::NPOI.DDF.EscherPictBlip.log.Log(3, "Possibly corrupt compression or non-compressed data", exception);
					result = data;
				}
			}
			return result;
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x0009D468 File Offset: 0x0009B668
		public override int RecordSize
		{
			get
			{
				return 58 + this.raw_pictureData.Length;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x0009D475 File Offset: 0x0009B675
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x0009D47D File Offset: 0x0009B67D
		public byte[] UID
		{
			get
			{
				return this.field_1_UID;
			}
			set
			{
				if (value == null || value.Length != 16)
				{
					throw new global::System.ArgumentException("uid must be byte[16]");
				}
				global::System.Array.Copy(value, 0, this.field_1_UID, 0, this.field_1_UID.Length);
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x0009D4AA File Offset: 0x0009B6AA
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x0009D4B2 File Offset: 0x0009B6B2
		public int UncompressedSize
		{
			get
			{
				return this.field_2_cb;
			}
			set
			{
				this.field_2_cb = value;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x0009D4BB File Offset: 0x0009B6BB
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x0009D4E8 File Offset: 0x0009B6E8
		public global::System.Drawing.Rectangle Bounds
		{
			get
			{
				return new global::System.Drawing.Rectangle(this.field_3_rcBounds_x1, this.field_3_rcBounds_y1, this.field_3_rcBounds_x2 - this.field_3_rcBounds_x1, this.field_3_rcBounds_y2 - this.field_3_rcBounds_y1);
			}
			set
			{
				this.field_3_rcBounds_x1 = value.X;
				this.field_3_rcBounds_y1 = value.Y;
				this.field_3_rcBounds_x2 = value.X + value.Width;
				this.field_3_rcBounds_y2 = value.Y + value.Height;
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x0009D539 File Offset: 0x0009B739
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x0009D54C File Offset: 0x0009B74C
		public global::System.Drawing.Size SizeEMU
		{
			get
			{
				return new global::System.Drawing.Size(this.field_4_ptSize_w, this.field_4_ptSize_h);
			}
			set
			{
				this.field_4_ptSize_w = value.Width;
				this.field_4_ptSize_h = value.Height;
			}
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x0009D568 File Offset: 0x0009B768
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x0009D570 File Offset: 0x0009B770
		public int CompressedSize
		{
			get
			{
				return this.field_5_cbSave;
			}
			set
			{
				this.field_5_cbSave = value;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x0009D579 File Offset: 0x0009B779
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x0009D584 File Offset: 0x0009B784
		public bool IsCompressed
		{
			get
			{
				return this.field_6_fCompression == 0;
			}
			set
			{
				this.field_6_fCompression = (value ? 0 : 254);
			}
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x0009D598 File Offset: 0x0009B798
		public override string ToString()
		{
			string newLine = global::System.Environment.NewLine;
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				string text;
				try
				{
					global::NPOI.Util.HexDump.Dump(this.field_pictureData, 0L, memoryStream, 0);
					text = memoryStream.ToString();
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
					"  Version: 0x",
					global::NPOI.Util.HexDump.ToHex(this.Version),
					"\n  Instance: 0x",
					global::NPOI.Util.HexDump.ToHex(this.Instance),
					"\n  UID: 0x",
					global::NPOI.Util.HexDump.ToHex(this.field_1_UID),
					newLine,
					"  Uncompressed Size: ",
					global::NPOI.Util.HexDump.ToHex(this.field_2_cb),
					newLine,
					"  Bounds: ",
					this.Bounds.ToString(),
					newLine,
					"  Size in EMU: ",
					this.SizeEMU.ToString(),
					newLine,
					"  Compressed Size: ",
					global::NPOI.Util.HexDump.ToHex(this.field_5_cbSave),
					newLine,
					"  Compression: ",
					global::NPOI.Util.HexDump.ToHex(this.field_6_fCompression),
					newLine,
					"  Filter: ",
					global::NPOI.Util.HexDump.ToHex(this.field_7_fFilter),
					newLine,
					"  Extra Data:",
					newLine,
					text
				});
			}
			return result;
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x0009D774 File Offset: 0x0009B974
		public override string ToXml(string tab)
		{
			string value = "";
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<UID>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_UID)).Append("</UID>\n").Append(tab).Append("\t").Append("<UncompressedSize>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_cb)).Append("</UncompressedSize>\n").Append(tab).Append("\t").Append("<Bounds>").Append(this.Bounds).Append("</Bounds>\n").Append(tab).Append("\t").Append("<SizeInEMU>").Append(this.SizeEMU).Append("</SizeInEMU>\n").Append(tab).Append("\t").Append("<CompressedSize>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_5_cbSave)).Append("</CompressedSize>\n").Append(tab).Append("\t").Append("<Compression>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_6_fCompression)).Append("</Compression>\n").Append(tab).Append("\t").Append("<Filter>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_7_fFilter)).Append("</Filter>\n").Append(tab).Append("\t").Append("<ExtraData>").Append(value).Append("</ExtraData>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x040016A6 RID: 5798
		private static global::NPOI.Util.POILogger log = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.DDF.EscherPictBlip));

		// Token: 0x040016A7 RID: 5799
		public const short RECORD_ID_EMF = -4070;

		// Token: 0x040016A8 RID: 5800
		public const short RECORD_ID_WMF = -4069;

		// Token: 0x040016A9 RID: 5801
		public const short RECORD_ID_PICT = -4068;

		// Token: 0x040016AA RID: 5802
		private const int HEADER_SIZE = 8;

		// Token: 0x040016AB RID: 5803
		private byte[] field_1_UID = new byte[16];

		// Token: 0x040016AC RID: 5804
		private int field_2_cb;

		// Token: 0x040016AD RID: 5805
		private int field_3_rcBounds_x1;

		// Token: 0x040016AE RID: 5806
		private int field_3_rcBounds_y1;

		// Token: 0x040016AF RID: 5807
		private int field_3_rcBounds_x2;

		// Token: 0x040016B0 RID: 5808
		private int field_3_rcBounds_y2;

		// Token: 0x040016B1 RID: 5809
		private int field_4_ptSize_w;

		// Token: 0x040016B2 RID: 5810
		private int field_4_ptSize_h;

		// Token: 0x040016B3 RID: 5811
		private int field_5_cbSave;

		// Token: 0x040016B4 RID: 5812
		private byte field_6_fCompression;

		// Token: 0x040016B5 RID: 5813
		private byte field_7_fFilter;

		// Token: 0x040016B6 RID: 5814
		private byte[] raw_pictureData;
	}
}
