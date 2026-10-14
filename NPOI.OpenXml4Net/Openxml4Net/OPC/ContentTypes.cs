using System;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x0200000E RID: 14
	public class ContentTypes
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00002B00 File Offset: 0x00000D00
		public static string GetContentTypeFromFileExtension(string filename)
		{
			string text = filename.Substring(filename.LastIndexOf(".") + 1).ToLower();
			if (text.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.EXTENSION_JPG_1) || text.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.EXTENSION_JPG_2))
			{
				return global::NPOI.OpenXml4Net.OPC.ContentTypes.IMAGE_JPEG;
			}
			if (text.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.EXTENSION_GIF))
			{
				return global::NPOI.OpenXml4Net.OPC.ContentTypes.IMAGE_GIF;
			}
			if (text.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.EXTENSION_PICT))
			{
				return global::NPOI.OpenXml4Net.OPC.ContentTypes.IMAGE_PICT;
			}
			if (text.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.EXTENSION_PNG))
			{
				return global::NPOI.OpenXml4Net.OPC.ContentTypes.IMAGE_PNG;
			}
			if (text.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.EXTENSION_TIFF))
			{
				return global::NPOI.OpenXml4Net.OPC.ContentTypes.IMAGE_TIFF;
			}
			if (text.Equals(global::NPOI.OpenXml4Net.OPC.ContentTypes.EXTENSION_XML))
			{
				return global::NPOI.OpenXml4Net.OPC.ContentTypes.XML;
			}
			return null;
		}

		// Token: 0x04000014 RID: 20
		public static string CORE_PROPERTIES_PART = "application/vnd.openxmlformats-package.core-properties+xml";

		// Token: 0x04000015 RID: 21
		public static string DIGITAL_SIGNATURE_CERTIFICATE_PART = "application/vnd.openxmlformats-package.digital-signature-certificate";

		// Token: 0x04000016 RID: 22
		public static string DIGITAL_SIGNATURE_ORIGIN_PART = "application/vnd.openxmlformats-package.digital-signature-origin";

		// Token: 0x04000017 RID: 23
		public static string DIGITAL_SIGNATURE_XML_SIGNATURE_PART = "application/vnd.openxmlformats-package.digital-signature-xmlsignature+xml";

		// Token: 0x04000018 RID: 24
		public static string RELATIONSHIPS_PART = "application/vnd.openxmlformats-package.relationships+xml";

		// Token: 0x04000019 RID: 25
		public static string CUSTOM_XML_PART = "application/vnd.openxmlformats-officedocument.customXmlProperties+xml";

		// Token: 0x0400001A RID: 26
		public static string PLAIN_OLD_XML = "application/xml";

		// Token: 0x0400001B RID: 27
		public static string IMAGE_JPEG = "image/jpeg";

		// Token: 0x0400001C RID: 28
		public static string EXTENSION_JPG_1 = "jpg";

		// Token: 0x0400001D RID: 29
		public static string EXTENSION_JPG_2 = "jpeg";

		// Token: 0x0400001E RID: 30
		public static string IMAGE_PNG = "image/png";

		// Token: 0x0400001F RID: 31
		public static string EXTENSION_PNG = "png";

		// Token: 0x04000020 RID: 32
		public static string IMAGE_GIF = "image/gif";

		// Token: 0x04000021 RID: 33
		public static string EXTENSION_GIF = "gif";

		// Token: 0x04000022 RID: 34
		public static string IMAGE_TIFF = "image/tiff";

		// Token: 0x04000023 RID: 35
		public static string EXTENSION_TIFF = "tiff";

		// Token: 0x04000024 RID: 36
		public static string IMAGE_PICT = "image/pict";

		// Token: 0x04000025 RID: 37
		public static string EXTENSION_PICT = "tiff";

		// Token: 0x04000026 RID: 38
		public static string XML = "text/xml";

		// Token: 0x04000027 RID: 39
		public static string EXTENSION_XML = "xml";
	}
}
