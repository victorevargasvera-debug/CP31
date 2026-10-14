using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x0200029D RID: 669
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FlatText
	{
		// Token: 0x06001B3F RID: 6975 RVA: 0x00049CD0 File Offset: 0x00047ED0
		public CT_FlatText()
		{
			this.zField = 0L;
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00049CE0 File Offset: 0x00047EE0
		public static global::NPOI.OpenXmlFormats.Dml.CT_FlatText Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_FlatText
			{
				z = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadLong(node.Attributes["z"])
			};
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00049D08 File Offset: 0x00047F08
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "z", (double)this.z);
			sw.Write(">");
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00049D54 File Offset: 0x00047F54
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x00049D5C File Offset: 0x00047F5C
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(typeof(long), "0")]
		public long z
		{
			get
			{
				return this.zField;
			}
			set
			{
				this.zField = value;
			}
		}

		// Token: 0x04001467 RID: 5223
		private long zField;
	}
}
