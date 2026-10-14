using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002A0 RID: 672
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_LightRig
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x0004A100 File Offset: 0x00048300
		public static global::NPOI.OpenXmlFormats.Dml.CT_LightRig Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_LightRig ct_LightRig = new global::NPOI.OpenXmlFormats.Dml.CT_LightRig();
			if (node.Attributes["rig"] != null)
			{
				ct_LightRig.rig = (global::NPOI.OpenXmlFormats.Dml.ST_LightRigType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_LightRigType), node.Attributes["rig"].Value);
			}
			if (node.Attributes["dir"] != null)
			{
				ct_LightRig.dir = (global::NPOI.OpenXmlFormats.Dml.ST_LightRigDirection)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_LightRigDirection), node.Attributes["dir"].Value);
			}
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rot")
				{
					ct_LightRig.rot = global::NPOI.OpenXmlFormats.Dml.CT_SphereCoords.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_LightRig;
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0004A200 File Offset: 0x00048400
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "rig", this.rig.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dir", this.dir.ToString());
			sw.Write(">");
			if (this.rot != null)
			{
				this.rot.Write(sw, "rot");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0004A291 File Offset: 0x00048491
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0004A299 File Offset: 0x00048499
		[global::System.Xml.Serialization.XmlElement(Order = 0)]
		public global::NPOI.OpenXmlFormats.Dml.CT_SphereCoords rot
		{
			get
			{
				return this.rotField;
			}
			set
			{
				this.rotField = value;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x0004A2A2 File Offset: 0x000484A2
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x0004A2AA File Offset: 0x000484AA
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_LightRigType rig
		{
			get
			{
				return this.rigField;
			}
			set
			{
				this.rigField = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0004A2B3 File Offset: 0x000484B3
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0004A2BB File Offset: 0x000484BB
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_LightRigDirection dir
		{
			get
			{
				return this.dirField;
			}
			set
			{
				this.dirField = value;
			}
		}

		// Token: 0x04001470 RID: 5232
		private global::NPOI.OpenXmlFormats.Dml.CT_SphereCoords rotField;

		// Token: 0x04001471 RID: 5233
		private global::NPOI.OpenXmlFormats.Dml.ST_LightRigType rigField;

		// Token: 0x04001472 RID: 5234
		private global::NPOI.OpenXmlFormats.Dml.ST_LightRigDirection dirField;
	}
}
