using System;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x0200000D RID: 13
	public class Configuration
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002ADB File Offset: 0x00000CDB
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002AE2 File Offset: 0x00000CE2
		public static string PathForXmlSchema
		{
			get
			{
				return global::NPOI.OpenXml4Net.OPC.Configuration.pathForXmlSchema;
			}
			set
			{
				global::NPOI.OpenXml4Net.OPC.Configuration.pathForXmlSchema = value;
			}
		}

		// Token: 0x04000013 RID: 19
		private static string pathForXmlSchema = global::System.Environment.CurrentDirectory + "\\src\\schemas";
	}
}
