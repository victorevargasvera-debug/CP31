using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x0200012E RID: 302
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Object : global::NPOI.OpenXmlFormats.Wordprocessing.CT_PictureBase
	{
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0001BADC File Offset: 0x00019CDC
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x0001BAE4 File Offset: 0x00019CE4
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Control control
		{
			get
			{
				return this.controlField;
			}
			set
			{
				this.controlField = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0001BAED File Offset: 0x00019CED
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x0001BAF5 File Offset: 0x00019CF5
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong dxaOrig
		{
			get
			{
				return this.dxaOrigField;
			}
			set
			{
				this.dxaOrigField = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0001BAFE File Offset: 0x00019CFE
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x0001BB06 File Offset: 0x00019D06
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dxaOrigSpecified
		{
			get
			{
				return this.dxaOrigFieldSpecified;
			}
			set
			{
				this.dxaOrigFieldSpecified = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0001BB0F File Offset: 0x00019D0F
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x0001BB17 File Offset: 0x00019D17
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified)]
		public ulong dyaOrig
		{
			get
			{
				return this.dyaOrigField;
			}
			set
			{
				this.dyaOrigField = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0001BB20 File Offset: 0x00019D20
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0001BB28 File Offset: 0x00019D28
		[global::System.Xml.Serialization.XmlIgnore]
		public bool dyaOrigSpecified
		{
			get
			{
				return this.dyaOrigFieldSpecified;
			}
			set
			{
				this.dyaOrigFieldSpecified = value;
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0001BB34 File Offset: 0x00019D34
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object ct_Object = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object();
			ct_Object.dxaOrig = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:dxaOrig"]);
			ct_Object.dyaOrig = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadULong(node.Attributes["w:dyaOrig"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "control")
				{
					ct_Object.control = global::NPOI.OpenXmlFormats.Wordprocessing.CT_Control.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Object;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0001BBE8 File Offset: 0x00019DE8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:dxaOrig", this.dxaOrig);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:dyaOrig", this.dyaOrig);
			sw.Write(">");
			if (this.control != null)
			{
				this.control.Write(sw, "control");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x04000741 RID: 1857
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Control controlField;

		// Token: 0x04000742 RID: 1858
		private ulong dxaOrigField;

		// Token: 0x04000743 RID: 1859
		private bool dxaOrigFieldSpecified;

		// Token: 0x04000744 RID: 1860
		private ulong dyaOrigField;

		// Token: 0x04000745 RID: 1861
		private bool dyaOrigFieldSpecified;
	}
}
