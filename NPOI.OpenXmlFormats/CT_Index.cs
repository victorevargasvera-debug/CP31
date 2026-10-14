using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200002D RID: 45
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Index
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x00003620 File Offset: 0x00001820
		public static global::NPOI.OpenXmlFormats.CT_Index Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.CT_Index
			{
				v = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["v"])
			};
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003648 File Offset: 0x00001848
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "v", this.v, false);
			sw.Write(">");
			sw.Write(string.Format("</{0}>", nodeName));
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00003694 File Offset: 0x00001894
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000369C File Offset: 0x0000189C
		[global::System.Xml.Serialization.XmlAttribute]
		public uint v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x0400013E RID: 318
		private uint vField;
	}
}
