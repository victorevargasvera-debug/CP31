using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002A3 RID: 675
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Camera
	{
		// Token: 0x06001B63 RID: 7011 RVA: 0x0004A2C4 File Offset: 0x000484C4
		public static global::NPOI.OpenXmlFormats.Dml.CT_Camera Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Dml.CT_Camera ct_Camera = new global::NPOI.OpenXmlFormats.Dml.CT_Camera();
			if (node.Attributes["prst"] != null)
			{
				ct_Camera.prst = (global::NPOI.OpenXmlFormats.Dml.ST_PresetCameraType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Dml.ST_PresetCameraType), node.Attributes["prst"].Value);
			}
			ct_Camera.fov = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["fov"]);
			ct_Camera.zoom = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadInt(node.Attributes["zoom"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rot")
				{
					ct_Camera.rot = global::NPOI.OpenXmlFormats.Dml.CT_SphereCoords.Parse(xmlNode, namespaceManager);
				}
			}
			return ct_Camera;
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0004A3B8 File Offset: 0x000485B8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<a:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "prst", this.prst.ToString());
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "fov", this.fov);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "zoom", this.zoom);
			sw.Write(">");
			if (this.rot != null)
			{
				this.rot.Write(sw, "rot");
			}
			sw.Write(string.Format("</a:{0}>", nodeName));
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0004A44C File Offset: 0x0004864C
		public CT_Camera()
		{
			this.rotField = new global::NPOI.OpenXmlFormats.Dml.CT_SphereCoords();
			this.zoomField = 100000;
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0004A46A File Offset: 0x0004866A
		// (set) Token: 0x06001B67 RID: 7015 RVA: 0x0004A472 File Offset: 0x00048672
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

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0004A47B File Offset: 0x0004867B
		// (set) Token: 0x06001B69 RID: 7017 RVA: 0x0004A483 File Offset: 0x00048683
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Dml.ST_PresetCameraType prst
		{
			get
			{
				return this.prstField;
			}
			set
			{
				this.prstField = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0004A48C File Offset: 0x0004868C
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x0004A494 File Offset: 0x00048694
		[global::System.Xml.Serialization.XmlAttribute]
		public int fov
		{
			get
			{
				return this.fovField;
			}
			set
			{
				this.fovField = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0004A49D File Offset: 0x0004869D
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x0004A4A5 File Offset: 0x000486A5
		[global::System.Xml.Serialization.XmlIgnore]
		public bool fovSpecified
		{
			get
			{
				return this.fovFieldSpecified;
			}
			set
			{
				this.fovFieldSpecified = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x0004A4AE File Offset: 0x000486AE
		// (set) Token: 0x06001B6F RID: 7023 RVA: 0x0004A4B6 File Offset: 0x000486B6
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(100000)]
		public int zoom
		{
			get
			{
				return this.zoomField;
			}
			set
			{
				this.zoomField = value;
			}
		}

		// Token: 0x04001498 RID: 5272
		private global::NPOI.OpenXmlFormats.Dml.CT_SphereCoords rotField;

		// Token: 0x04001499 RID: 5273
		private global::NPOI.OpenXmlFormats.Dml.ST_PresetCameraType prstField;

		// Token: 0x0400149A RID: 5274
		private int fovField;

		// Token: 0x0400149B RID: 5275
		private bool fovFieldSpecified;

		// Token: 0x0400149C RID: 5276
		private int zoomField;
	}
}
