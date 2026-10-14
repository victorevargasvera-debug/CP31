using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E0 RID: 224
	public class CalculationChain : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000DF3 RID: 3571 RVA: 0x00030331 File Offset: 0x0002E531
		public CalculationChain()
		{
			this.chain = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcChain();
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00030344 File Offset: 0x0002E544
		internal CalculationChain(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			global::System.Xml.XmlDocument xml = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(part.GetInputStream());
			this.ReadFrom(xml);
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x0003036B File Offset: 0x0002E56B
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public CalculationChain(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00030374 File Offset: 0x0002E574
		public void ReadFrom(global::System.Xml.XmlDocument xml)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CalcChainDocument calcChainDocument = global::NPOI.OpenXmlFormats.Spreadsheet.CalcChainDocument.Parse(xml, global::NPOI.POIXMLDocumentPart.NamespaceManager);
			this.chain = calcChainDocument.GetCalcChain();
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00030399 File Offset: 0x0002E599
		public void WriteTo(global::System.IO.Stream out1)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CalcChainDocument calcChainDocument = new global::NPOI.OpenXmlFormats.Spreadsheet.CalcChainDocument();
			calcChainDocument.SetCalcChain(this.chain);
			calcChainDocument.Save(out1);
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x000303B4 File Offset: 0x0002E5B4
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.WriteTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x000303DA File Offset: 0x0002E5DA
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcChain GetCTCalcChain()
		{
			return this.chain;
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x000303E4 File Offset: 0x0002E5E4
		public void RemoveItem(int sheetId, string ref1)
		{
			int num = -1;
			global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcCell> c = this.chain.c;
			for (int i = 0; i < c.Count; i++)
			{
				if (c[i].iSpecified)
				{
					num = c[i].i;
				}
				if (num == sheetId && c[i].r.Equals(ref1))
				{
					if (c[i].iSpecified && i < c.Count - 1 && !c[i + 1].iSpecified)
					{
						c[i + 1].i = num;
						c[i + 1].iSpecified = true;
					}
					this.chain.RemoveC(i);
					return;
				}
			}
		}

		// Token: 0x04000416 RID: 1046
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CalcChain chain;
	}
}
