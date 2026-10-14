using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml.Chart
{
	// Token: 0x020003F3 RID: 1011
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/chart", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Boolean
	{
		// Token: 0x0600287E RID: 10366 RVA: 0x00066000 File Offset: 0x00064200
		public CT_Boolean()
		{
			this.valField = true;
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x0600287F RID: 10367 RVA: 0x0006600F File Offset: 0x0006420F
		// (set) Token: 0x06002880 RID: 10368 RVA: 0x0006601C File Offset: 0x0006421C
		[global::System.Xml.Serialization.XmlAttribute]
		public int val
		{
			get
			{
				if (!this.valField)
				{
					return 0;
				}
				return 1;
			}
			set
			{
				this.valField = (value == 1);
			}
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x0006602C File Offset: 0x0006422C
		public static global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.Chart.CT_Boolean
			{
				val = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["val"])
			};
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00066053 File Offset: 0x00064253
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<c:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "val", this.val, true);
			sw.Write("/>");
		}

		// Token: 0x04001D76 RID: 7542
		private bool valField;
	}
}
