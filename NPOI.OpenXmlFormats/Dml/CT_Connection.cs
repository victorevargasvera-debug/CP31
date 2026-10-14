using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002E7 RID: 743
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Connection
	{
		// Token: 0x06001CE6 RID: 7398 RVA: 0x0004E9EC File Offset: 0x0004CBEC
		public static global::NPOI.OpenXmlFormats.Dml.CT_Connection Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_Connection
			{
				id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["id"]),
				idx = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["idx"])
			};
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0004EA3C File Offset: 0x0004CC3C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "idx", this.idx, false);
			sw.Write("/>");
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0004EA89 File Offset: 0x0004CC89
		// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x0004EA91 File Offset: 0x0004CC91
		[global::System.Xml.Serialization.XmlAttribute]
		public uint id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001CEA RID: 7402 RVA: 0x0004EA9A File Offset: 0x0004CC9A
		// (set) Token: 0x06001CEB RID: 7403 RVA: 0x0004EAA2 File Offset: 0x0004CCA2
		[global::System.Xml.Serialization.XmlAttribute]
		public uint idx
		{
			get
			{
				return this.idxField;
			}
			set
			{
				this.idxField = value;
			}
		}

		// Token: 0x0400174E RID: 5966
		private uint idField;

		// Token: 0x0400174F RID: 5967
		private uint idxField;
	}
}
