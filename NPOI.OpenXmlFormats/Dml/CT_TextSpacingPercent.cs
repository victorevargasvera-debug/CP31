using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200025C RID: 604
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextSpacingPercent
	{
		// Token: 0x06001899 RID: 6297 RVA: 0x000440FE File Offset: 0x000422FE
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPercent Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPercent
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["val"])
			};
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00044125 File Offset: 0x00042325
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x00044155 File Offset: 0x00042355
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x0004415D File Offset: 0x0004235D
		[global::System.Xml.Serialization.XmlAttribute]
		public int val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x040012CA RID: 4810
		private int valField;
	}
}
