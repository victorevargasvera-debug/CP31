using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200025D RID: 605
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TextSpacingPoint
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x00044166 File Offset: 0x00042366
		public static global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPoint Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_TextSpacingPoint
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["val"])
			};
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0004418D File Offset: 0x0004238D
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060018A0 RID: 6304 RVA: 0x000441BD File Offset: 0x000423BD
		// (set) Token: 0x060018A1 RID: 6305 RVA: 0x000441C5 File Offset: 0x000423C5
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

		// Token: 0x040012CB RID: 4811
		private int valField;
	}
}
