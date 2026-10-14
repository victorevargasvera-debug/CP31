using System;
using System.IO;
using System.Text;
using System.Xml;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x0200001C RID: 28
	public class StreamHelper
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		private StreamHelper()
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000683C File Offset: 0x00004A3C
		public static void SaveXmlInStream(global::System.Xml.XmlDocument xmlContent, global::System.IO.Stream outStream)
		{
			global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(outStream, new global::System.Xml.XmlWriterSettings
			{
				Encoding = global::System.Text.Encoding.UTF8,
				OmitXmlDeclaration = false
			});
			xmlContent.WriteContentTo(xmlWriter);
			xmlWriter.Flush();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006878 File Offset: 0x00004A78
		public static void CopyStream(global::System.IO.Stream inStream, global::System.IO.Stream outStream)
		{
			byte[] array = new byte[1024];
			int num = 0;
			int num2;
			while ((num2 = inStream.Read(array, 0, array.Length)) > 0)
			{
				outStream.Write(array, 0, num2);
				num += num2;
			}
		}
	}
}
