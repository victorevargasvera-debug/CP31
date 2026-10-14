using System;
using NPOI.DDF;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000383 RID: 899
	public class HSSFPictureData : global::NPOI.SS.UserModel.IPictureData
	{
		// Token: 0x06001CC5 RID: 7365 RVA: 0x00057853 File Offset: 0x00055A53
		public HSSFPictureData(global::NPOI.DDF.EscherBlipRecord blip)
		{
			this.blip = blip;
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00057864 File Offset: 0x00055A64
		public byte[] Data
		{
			get
			{
				byte[] array = this.blip.PictureData;
				if (global::NPOI.Util.PngUtils.MatchesPngHeader(array, 16))
				{
					byte[] array2 = new byte[array.Length - 16];
					global::System.Array.Copy(array, 16, array2, 0, array2.Length);
					array = array2;
				}
				return array;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001CC7 RID: 7367 RVA: 0x000578A3 File Offset: 0x00055AA3
		public int Format
		{
			get
			{
				return (int)(this.blip.RecordId - -4072);
			}
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000578B8 File Offset: 0x00055AB8
		public string SuggestFileExtension()
		{
			switch (this.blip.RecordId)
			{
			case -4070:
				return "emf";
			case -4069:
				return "wmf";
			case -4068:
				return "pict";
			case -4067:
				return "jpeg";
			case -4066:
				return "png";
			case -4065:
				return "dib";
			default:
				return "";
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00057920 File Offset: 0x00055B20
		public string MimeType
		{
			get
			{
				switch (this.blip.RecordId)
				{
				case -4070:
					return "image/x-emf";
				case -4069:
					return "image/x-wmf";
				case -4068:
					return "image/x-pict";
				case -4067:
					return "image/jpeg";
				case -4066:
					return "image/png";
				case -4065:
					return "image/bmp";
				default:
					return "image/unknown";
				}
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x00057988 File Offset: 0x00055B88
		public global::NPOI.SS.UserModel.PictureType PictureType
		{
			get
			{
				switch (this.blip.RecordId)
				{
				case -4070:
					return global::NPOI.SS.UserModel.PictureType.EMF;
				case -4069:
					return global::NPOI.SS.UserModel.PictureType.WMF;
				case -4068:
					return global::NPOI.SS.UserModel.PictureType.PICT;
				case -4067:
					return global::NPOI.SS.UserModel.PictureType.JPEG;
				case -4066:
					return global::NPOI.SS.UserModel.PictureType.PNG;
				case -4065:
					return global::NPOI.SS.UserModel.PictureType.DIB;
				default:
					return global::NPOI.SS.UserModel.PictureType.Unknown;
				}
			}
		}

		// Token: 0x04000B6F RID: 2927
		public const short MSOBI_WMF = 8544;

		// Token: 0x04000B70 RID: 2928
		public const short MSOBI_EMF = 15680;

		// Token: 0x04000B71 RID: 2929
		public const short MSOBI_PICT = 21536;

		// Token: 0x04000B72 RID: 2930
		public const short MSOBI_PNG = 28160;

		// Token: 0x04000B73 RID: 2931
		public const short MSOBI_JPEG = 18080;

		// Token: 0x04000B74 RID: 2932
		public const short MSOBI_DIB = 31360;

		// Token: 0x04000B75 RID: 2933
		public const short FORMAT_MASK = -16;

		// Token: 0x04000B76 RID: 2934
		private global::NPOI.DDF.EscherBlipRecord blip;
	}
}
