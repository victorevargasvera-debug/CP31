using System;
using System.Drawing;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200053D RID: 1341
	public class EscherMetafileBlip : global::NPOI.DDF.EscherBlipRecord
	{
		// Token: 0x0600329A RID: 12954 RVA: 0x0009C488 File Offset: 0x0009A688
		public override int FillFields(byte[] data, int offset, global::NPOI.DDF.IEscherRecordFactory recordFactory)
		{
			int num = base.ReadHeader(data, offset);
			int num2 = offset + 8;
			global::System.Array.Copy(data, num2, this.field_1_UID, 0, 16);
			num2 += 16;
			if ((this.Options ^ this.Signature) == 16)
			{
				global::System.Array.Copy(data, num2, this.field_2_UID, 0, 16);
				num2 += 16;
			}
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
			num2 += this.field_5_cbSave;
			if (this.field_6_fCompression == 0)
			{
				this.field_pictureData = global::NPOI.DDF.EscherMetafileBlip.InflatePictureData(this.raw_pictureData);
			}
			else
			{
				this.field_pictureData = this.raw_pictureData;
			}
			int num3 = num - num2 + offset + 8;
			if (num3 > 0)
			{
				this.remainingData = new byte[num3];
				global::System.Array.Copy(data, num2, this.remainingData, 0, num3);
			}
			return num + 8;
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x0009C5FC File Offset: 0x0009A7FC
		public override int Serialize(int offset, byte[] data, global::NPOI.DDF.EscherSerializationListener listener)
		{
			listener.BeforeRecordSerialize(offset, this.RecordId, this);
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Options);
			int num = offset + 2;
			global::NPOI.Util.LittleEndian.PutShort(data, num, this.RecordId);
			num += 2;
			global::NPOI.Util.LittleEndian.PutInt(data, num, this.RecordSize - 8);
			num += 4;
			global::System.Array.Copy(this.field_1_UID, 0, data, num, this.field_1_UID.Length);
			num += this.field_1_UID.Length;
			if ((this.Options ^ this.Signature) == 16)
			{
				global::System.Array.Copy(this.field_2_UID, 0, data, num, this.field_2_UID.Length);
				num += this.field_2_UID.Length;
			}
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
			num += this.raw_pictureData.Length;
			if (this.remainingData != null)
			{
				global::System.Array.Copy(this.remainingData, 0, data, num, this.remainingData.Length);
				num += this.remainingData.Length;
			}
			listener.AfterRecordSerialize(offset + this.RecordSize, this.RecordId, this.RecordSize, this);
			return this.RecordSize;
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x0009C7B0 File Offset: 0x0009A9B0
		private static byte[] InflatePictureData(byte[] data)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data))
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
				{
					try
					{
						global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf = new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(false);
						global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream inflaterInputStream = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream(memoryStream, inf);
						byte[] array = new byte[4096];
						int count;
						while ((count = inflaterInputStream.Read(array, 0, array.Length)) > 0)
						{
							memoryStream2.Write(array, 0, count);
						}
						result = memoryStream2.ToArray();
					}
					catch (global::System.IO.IOException exception)
					{
						global::NPOI.DDF.EscherMetafileBlip.log.Log(5, "Possibly corrupt compression or non-compressed data", exception);
						result = data;
					}
				}
			}
			return result;
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600329D RID: 12957 RVA: 0x0009C868 File Offset: 0x0009AA68
		public override int RecordSize
		{
			get
			{
				int num = 58 + this.raw_pictureData.Length;
				if (this.remainingData != null)
				{
					num += this.remainingData.Length;
				}
				if ((this.Options ^ this.Signature) == 16)
				{
					num += this.field_2_UID.Length;
				}
				return num;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x0009C8B1 File Offset: 0x0009AAB1
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x0009C8B9 File Offset: 0x0009AAB9
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

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x0009C8E6 File Offset: 0x0009AAE6
		// (set) Token: 0x060032A1 RID: 12961 RVA: 0x0009C8EE File Offset: 0x0009AAEE
		public byte[] PrimaryUID
		{
			get
			{
				return this.field_2_UID;
			}
			set
			{
				if (value == null || value.Length != 16)
				{
					throw new global::System.ArgumentException("primaryUID must be byte[16]");
				}
				global::System.Array.Copy(value, 0, this.field_2_UID, 0, this.field_2_UID.Length);
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x060032A2 RID: 12962 RVA: 0x0009C91B File Offset: 0x0009AB1B
		// (set) Token: 0x060032A3 RID: 12963 RVA: 0x0009C923 File Offset: 0x0009AB23
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

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x0009C92C File Offset: 0x0009AB2C
		// (set) Token: 0x060032A5 RID: 12965 RVA: 0x0009C95C File Offset: 0x0009AB5C
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

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x0009C9AD File Offset: 0x0009ABAD
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x0009C9C0 File Offset: 0x0009ABC0
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

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x0009C9DC File Offset: 0x0009ABDC
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x0009C9E4 File Offset: 0x0009ABE4
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

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x0009C9ED File Offset: 0x0009ABED
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x0009C9F8 File Offset: 0x0009ABF8
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

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x0009CA0B File Offset: 0x0009AC0B
		public byte[] RemainingData
		{
			get
			{
				return this.remainingData;
			}
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x0009CA14 File Offset: 0x0009AC14
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
					(this.field_2_UID == null) ? "" : ("  UID2: 0x" + global::NPOI.Util.HexDump.ToHex(this.field_2_UID) + newLine),
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
					text,
					(this.remainingData == null) ? null : ("\n Remaining Data: " + global::NPOI.Util.HexDump.ToHex(this.remainingData, 32))
				});
			}
			return result;
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x0009CC40 File Offset: 0x0009AE40
		public override string ToXml(string tab)
		{
			string value = "";
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append(base.FormatXmlRecordHeader(base.GetType().Name, global::NPOI.Util.HexDump.ToHex(this.RecordId), global::NPOI.Util.HexDump.ToHex(this.Version), global::NPOI.Util.HexDump.ToHex(this.Instance))).Append(tab).Append("\t").Append("<UID>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_UID) + "\n" + ((this.field_2_UID == null) ? "" : ("  UID2: 0x" + global::NPOI.Util.HexDump.ToHex(this.field_2_UID) + "\n"))).Append("</UID>\n").Append(tab).Append("\t").Append("<UncompressedSize>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_cb)).Append("</UncompressedSize>\n").Append(tab).Append("\t").Append("<Bounds>").Append(this.Bounds).Append("</Bounds>\n").Append(tab).Append("\t").Append("<SizeInEMU>").Append(this.SizeEMU).Append("</SizeInEMU>\n").Append(tab).Append("\t").Append("<CompressedSize>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_5_cbSave)).Append("</CompressedSize>\n").Append(tab).Append("\t").Append("<Compression>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_6_fCompression)).Append("</Compression>\n").Append(tab).Append("\t").Append("<Filter>0x").Append(global::NPOI.Util.HexDump.ToHex(this.field_7_fFilter)).Append("</Filter>\n").Append(tab).Append("\t").Append("<ExtraData>").Append(value).Append("</ExtraData>\n").Append(tab).Append("\t").Append("<RemainingData>0x").Append(global::NPOI.Util.HexDump.ToHex(this.remainingData, 32)).Append("</RemainingData>\n");
			stringBuilder.Append(tab).Append("</").Append(base.GetType().Name).Append(">\n");
			return stringBuilder.ToString();
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x060032AF RID: 12975 RVA: 0x0009CEC8 File Offset: 0x0009B0C8
		public short Signature
		{
			get
			{
				short result = 0;
				switch (this.RecordId)
				{
				case -4070:
					result = 15680;
					break;
				case -4069:
					result = 8544;
					break;
				case -4068:
					result = 21536;
					break;
				default:
					global::NPOI.DDF.EscherMetafileBlip.log.Log(5, "Unknown metafile: " + this.RecordId.ToString());
					break;
				}
				return result;
			}
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x0009CF34 File Offset: 0x0009B134
		public void SetPictureData(byte[] pictureData)
		{
			base.PictureData = pictureData;
			this.UncompressedSize = pictureData.Length;
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream deflaterOutputStream = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream(memoryStream);
				deflaterOutputStream.Write(pictureData, 0, pictureData.Length);
				deflaterOutputStream.Close();
				this.raw_pictureData = memoryStream.ToArray();
			}
			catch (global::System.IO.IOException ex)
			{
				throw new global::NPOI.Util.RuntimeException("Can't compress metafile picture data", ex);
			}
			this.CompressedSize = this.raw_pictureData.Length;
			this.IsCompressed = true;
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x060032B1 RID: 12977 RVA: 0x0009CFB0 File Offset: 0x0009B1B0
		// (set) Token: 0x060032B2 RID: 12978 RVA: 0x0009CFB8 File Offset: 0x0009B1B8
		public byte Filter
		{
			get
			{
				return this.field_7_fFilter;
			}
			set
			{
				this.field_7_fFilter = value;
			}
		}

		// Token: 0x0400168E RID: 5774
		private static global::NPOI.Util.POILogger log = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.DDF.EscherMetafileBlip));

		// Token: 0x0400168F RID: 5775
		public const short RECORD_ID_EMF = -4070;

		// Token: 0x04001690 RID: 5776
		public const short RECORD_ID_WMF = -4069;

		// Token: 0x04001691 RID: 5777
		public const short RECORD_ID_PICT = -4068;

		// Token: 0x04001692 RID: 5778
		public const short SIGNATURE_EMF = 15680;

		// Token: 0x04001693 RID: 5779
		public const short SIGNATURE_WMF = 8544;

		// Token: 0x04001694 RID: 5780
		public const short SIGNATURE_PICT = 21536;

		// Token: 0x04001695 RID: 5781
		private const int HEADER_SIZE = 8;

		// Token: 0x04001696 RID: 5782
		private byte[] field_1_UID = new byte[16];

		// Token: 0x04001697 RID: 5783
		private byte[] field_2_UID = new byte[16];

		// Token: 0x04001698 RID: 5784
		private int field_2_cb;

		// Token: 0x04001699 RID: 5785
		private int field_3_rcBounds_x1;

		// Token: 0x0400169A RID: 5786
		private int field_3_rcBounds_y1;

		// Token: 0x0400169B RID: 5787
		private int field_3_rcBounds_x2;

		// Token: 0x0400169C RID: 5788
		private int field_3_rcBounds_y2;

		// Token: 0x0400169D RID: 5789
		private int field_4_ptSize_w;

		// Token: 0x0400169E RID: 5790
		private int field_4_ptSize_h;

		// Token: 0x0400169F RID: 5791
		private int field_5_cbSave;

		// Token: 0x040016A0 RID: 5792
		private byte field_6_fCompression;

		// Token: 0x040016A1 RID: 5793
		private byte field_7_fFilter;

		// Token: 0x040016A2 RID: 5794
		private byte[] raw_pictureData;

		// Token: 0x040016A3 RID: 5795
		private byte[] remainingData;
	}
}
