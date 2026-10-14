using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x02000290 RID: 656
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LineJoinMiterProperties
	{
		// Token: 0x06001ADC RID: 6876 RVA: 0x00048F45 File Offset: 0x00047145
		public static global::NPOI.OpenXmlFormats.Dml.CT_LineJoinMiterProperties Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			return new global::NPOI.OpenXmlFormats.Dml.CT_LineJoinMiterProperties
			{
				lim = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["lim"])
			};
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00048F6C File Offset: 0x0004716C
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "lim", this.lim);
			sw.Write("/>");
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00048F9B File Offset: 0x0004719B
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x00048FA3 File Offset: 0x000471A3
		[global::System.Xml.Serialization.XmlAttribute]
		public int lim
		{
			get
			{
				return this.limField;
			}
			set
			{
				this.limField = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x00048FAC File Offset: 0x000471AC
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x00048FB4 File Offset: 0x000471B4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool limSpecified
		{
			get
			{
				return this.limFieldSpecified;
			}
			set
			{
				this.limFieldSpecified = value;
			}
		}

		// Token: 0x04001407 RID: 5127
		private int limField;

		// Token: 0x04001408 RID: 5128
		private bool limFieldSpecified;
	}
}
