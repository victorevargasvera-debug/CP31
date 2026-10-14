using System;
using NPOI.OpenXml4Net.OPC;

namespace NPOI
{
	// Token: 0x0200000C RID: 12
	public abstract class POIXMLTextExtractor : global::NPOI.POITextExtractor
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000040E0 File Offset: 0x000022E0
		public POIXMLTextExtractor(global::NPOI.POIXMLDocument document)
		{
			this._document = document;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000040EF File Offset: 0x000022EF
		public global::NPOI.CoreProperties GetCoreProperties()
		{
			return this._document.GetProperties().CoreProperties;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004101 File Offset: 0x00002301
		public global::NPOI.ExtendedProperties GetExtendedProperties()
		{
			return this._document.GetProperties().ExtendedProperties;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004113 File Offset: 0x00002313
		public global::NPOI.CustomProperties GetCustomProperties()
		{
			return this._document.GetProperties().CustomProperties;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00004125 File Offset: 0x00002325
		public global::NPOI.POIXMLDocument Document
		{
			get
			{
				return this._document;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000412D File Offset: 0x0000232D
		public global::NPOI.OpenXml4Net.OPC.OPCPackage Package
		{
			get
			{
				return this._document.Package;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000413A File Offset: 0x0000233A
		public override global::NPOI.POITextExtractor MetadataTextExtractor
		{
			get
			{
				return new global::NPOI.POIXMLPropertiesTextExtractor(this._document);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004148 File Offset: 0x00002348
		public override void Close()
		{
			if (this._document != null)
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage package = this._document.Package;
				if (package != null)
				{
					package.Revert();
				}
			}
			base.Close();
		}

		// Token: 0x04000021 RID: 33
		private global::NPOI.POIXMLDocument _document;
	}
}
