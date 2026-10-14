using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Spreadsheet
{
	// Token: 0x02000372 RID: 882
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing")]
	[global::System.Serializable]
	public class CT_AnchorClientData
	{
		// Token: 0x06002333 RID: 9011 RVA: 0x0005BB54 File Offset: 0x00059D54
		public static global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Spreadsheet.CT_AnchorClientData
			{
				fLocksWithSheet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fLocksWithSheet"]),
				fPrintsWithSheet = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["fPrintsWithSheet"])
			};
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x0005BBA4 File Offset: 0x00059DA4
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<xdr:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fLocksWithSheet", this.fLocksWithSheet, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fPrintsWithSheet", this.fPrintsWithSheet, false);
			sw.Write("/>");
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x0005BBF1 File Offset: 0x00059DF1
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x0005BBF9 File Offset: 0x00059DF9
		[global::System.Xml.Serialization.XmlAttribute]
		public bool fLocksWithSheet
		{
			get
			{
				return this._fLocksWithSheet;
			}
			set
			{
				this._fLocksWithSheet = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x0005BC02 File Offset: 0x00059E02
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x0005BC0A File Offset: 0x00059E0A
		[global::System.Xml.Serialization.XmlAttribute]
		public bool fPrintsWithSheet
		{
			get
			{
				return this._fPrintsWithSheet;
			}
			set
			{
				this._fPrintsWithSheet = value;
			}
		}

		// Token: 0x04001A5D RID: 6749
		private bool _fLocksWithSheet;

		// Token: 0x04001A5E RID: 6750
		private bool _fPrintsWithSheet;
	}
}
