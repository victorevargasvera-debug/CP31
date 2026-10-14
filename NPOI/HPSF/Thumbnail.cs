using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x0200051E RID: 1310
	public class Thumbnail
	{
		// Token: 0x06003158 RID: 12632 RVA: 0x0000253E File Offset: 0x0000073E
		public Thumbnail()
		{
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x00094A58 File Offset: 0x00092C58
		public Thumbnail(byte[] thumbnailData)
		{
			this.thumbnailData = thumbnailData;
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x00094A67 File Offset: 0x00092C67
		// (set) Token: 0x0600315B RID: 12635 RVA: 0x00094A6F File Offset: 0x00092C6F
		public byte[] ThumbnailData
		{
			get
			{
				return this.thumbnailData;
			}
			set
			{
				this.thumbnailData = value;
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x00094A78 File Offset: 0x00092C78
		public long ClipboardFormatTag
		{
			get
			{
				return (long)global::NPOI.Util.LittleEndian.GetInt(this.ThumbnailData, 4);
			}
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00094A87 File Offset: 0x00092C87
		public long GetClipboardFormat()
		{
			if (this.ClipboardFormatTag != -1L)
			{
				throw new global::NPOI.HPSF.HPSFException("Clipboard Format Tag of Thumbnail must be CFTAG_WINDOWS.");
			}
			return (long)global::NPOI.Util.LittleEndian.GetInt(this.ThumbnailData, 8);
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00094AAC File Offset: 0x00092CAC
		public byte[] GetThumbnailAsWMF()
		{
			if (this.ClipboardFormatTag != -1L)
			{
				throw new global::NPOI.HPSF.HPSFException("Clipboard Format Tag of Thumbnail must be CFTAG_WINDOWS.");
			}
			if (this.GetClipboardFormat() != 3L)
			{
				throw new global::NPOI.HPSF.HPSFException("Clipboard Format of Thumbnail must be CF_METAFILEPICT.");
			}
			byte[] array = this.ThumbnailData;
			int num = array.Length - 20;
			byte[] array2 = new byte[num];
			global::System.Array.Copy(array, 20, array2, 0, num);
			return array2;
		}

		// Token: 0x040015A1 RID: 5537
		public const int OFFSet_CFTAG = 4;

		// Token: 0x040015A2 RID: 5538
		public const int OFFSet_CF = 8;

		// Token: 0x040015A3 RID: 5539
		public const int OFFSet_WMFDATA = 20;

		// Token: 0x040015A4 RID: 5540
		public const int CFTAG_WINDOWS = -1;

		// Token: 0x040015A5 RID: 5541
		public const int CFTAG_MACINTOSH = -2;

		// Token: 0x040015A6 RID: 5542
		public const int CFTAG_FMTID = -3;

		// Token: 0x040015A7 RID: 5543
		public const int CFTAG_NODATA = 0;

		// Token: 0x040015A8 RID: 5544
		public const int CF_METAFILEPICT = 3;

		// Token: 0x040015A9 RID: 5545
		public const int CF_DIB = 8;

		// Token: 0x040015AA RID: 5546
		public const int CF_ENHMETAFILE = 14;

		// Token: 0x040015AB RID: 5547
		[global::System.Obsolete]
		public const int CF_BITMAP = 2;

		// Token: 0x040015AC RID: 5548
		private byte[] thumbnailData;
	}
}
