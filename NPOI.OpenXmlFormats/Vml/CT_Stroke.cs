using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Util;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001DD RID: 477
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Stroke
	{
		// Token: 0x060012E8 RID: 4840 RVA: 0x0003D7E0 File Offset: 0x0003B9E0
		public static global::NPOI.OpenXmlFormats.Vml.CT_Stroke Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Vml.CT_Stroke ct_Stroke = new global::NPOI.OpenXmlFormats.Vml.CT_Stroke();
			ct_Stroke.id = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["id"]);
			if (node.Attributes["on"] != null)
			{
				ct_Stroke.on = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["on"]);
			}
			ct_Stroke.weight = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["weight"]);
			ct_Stroke.color = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["color"]);
			ct_Stroke.opacity = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["opacity"]);
			if (node.Attributes["linestyle"] != null)
			{
				ct_Stroke.linestyle = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeLineStyle)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeLineStyle), node.Attributes["linestyle"].Value);
				ct_Stroke.linestyleFieldSpecified = true;
			}
			else
			{
				ct_Stroke.linestyleFieldSpecified = false;
			}
			if (node.Attributes["miterlimit"] != null)
			{
				ct_Stroke.miterlimit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDecimal(node.Attributes["miterlimit"]);
				ct_Stroke.miterlimitFieldSpecified = true;
			}
			else
			{
				ct_Stroke.miterlimitFieldSpecified = false;
			}
			if (node.Attributes["joinstyle"] != null)
			{
				ct_Stroke.joinstyleFieldSpecified = true;
				ct_Stroke.joinstyle = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeJoinStyle)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeJoinStyle), node.Attributes["joinstyle"].Value);
			}
			else
			{
				ct_Stroke.joinstyleFieldSpecified = false;
			}
			if (node.Attributes["endcap"] != null)
			{
				ct_Stroke.endcap = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeEndCap)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeEndCap), node.Attributes["endcap"].Value);
				ct_Stroke.endcapFieldSpecified = true;
			}
			else
			{
				ct_Stroke.endcapFieldSpecified = false;
			}
			ct_Stroke.dashstyle = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["dashstyle"]);
			if (node.Attributes["filltype"] != null)
			{
				ct_Stroke.filltype = (global::NPOI.OpenXmlFormats.Vml.ST_FillType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_FillType), node.Attributes["filltype"].Value);
				ct_Stroke.filltypeFieldSpecified = true;
			}
			else
			{
				ct_Stroke.filltypeFieldSpecified = false;
			}
			ct_Stroke.src = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["src"]);
			if (node.Attributes["imageaspect"] != null)
			{
				ct_Stroke.imageaspect = (global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect), node.Attributes["imageaspect"].Value);
				ct_Stroke.imageaspectFieldSpecified = true;
			}
			else
			{
				ct_Stroke.imageaspectFieldSpecified = false;
			}
			ct_Stroke.imagesize = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["imagesize"]);
			if (node.Attributes["imagealignshape"] != null)
			{
				ct_Stroke.imagealignshape = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["imagealignshape"]);
				ct_Stroke.imagealignshapeSpecified = true;
			}
			else
			{
				ct_Stroke.imagealignshapeSpecified = false;
			}
			ct_Stroke.color2 = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadString(node.Attributes["color2"]);
			if (node.Attributes["startarrow"] != null)
			{
				ct_Stroke.startarrow = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType), node.Attributes["startarrow"].Value);
				ct_Stroke.startarrowFieldSpecified = true;
			}
			else
			{
				ct_Stroke.startarrowFieldSpecified = false;
			}
			if (node.Attributes["startarrowwidth"] != null)
			{
				ct_Stroke.startarrowwidth = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth), node.Attributes["startarrowwidth"].Value);
				ct_Stroke.startarrowwidthFieldSpecified = true;
			}
			else
			{
				ct_Stroke.startarrowwidthFieldSpecified = false;
			}
			if (node.Attributes["startarrowlength"] != null)
			{
				ct_Stroke.startarrowlength = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength), node.Attributes["startarrowlength"].Value);
				ct_Stroke.startarrowlengthFieldSpecified = true;
			}
			else
			{
				ct_Stroke.startarrowlengthFieldSpecified = false;
			}
			if (node.Attributes["endarrow"] != null)
			{
				ct_Stroke.endarrow = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType), node.Attributes["endarrow"].Value);
				ct_Stroke.endarrowFieldSpecified = true;
			}
			else
			{
				ct_Stroke.endarrowFieldSpecified = false;
			}
			if (node.Attributes["endarrowwidth"] != null)
			{
				ct_Stroke.endarrowwidth = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth), node.Attributes["endarrowwidth"].Value);
				ct_Stroke.endarrowwidthFieldSpecified = true;
			}
			else
			{
				ct_Stroke.endarrowwidthFieldSpecified = false;
			}
			if (node.Attributes["endarrowlength"] != null)
			{
				ct_Stroke.endarrowlength = (global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength)global::System.Enum.Parse(typeof(global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength), node.Attributes["endarrowlength"].Value);
				ct_Stroke.endarrowlengthFieldSpecified = true;
			}
			else
			{
				ct_Stroke.endarrowlengthFieldSpecified = false;
			}
			if (node.Attributes["insetpen"] != null)
			{
				ct_Stroke.insetpen = global::NPOI.OpenXmlFormats.Util.XmlHelper.ReadTrueFalse2(node.Attributes["insetpen"]);
			}
			return ct_Stroke;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0003DD20 File Offset: 0x0003BF20
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<v:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "id", this.id);
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "on", this.on);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "weight", this.weight);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "color", this.color);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "opacity", this.opacity);
			if (this.linestyleFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "linestyle", this.linestyle.ToString());
			}
			if (this.miterlimitFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "miterlimit", (double)((float)this.miterlimit));
			}
			if (this.joinstyleFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "joinstyle", this.joinstyle.ToString());
			}
			if (this.endcapFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endcap", this.endcap.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "dashstyle", this.dashstyle);
			if (this.filltypeFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "filltype", this.filltype.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "src", this.src);
			if (this.imageaspectFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "imageaspect", this.imageaspect.ToString());
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "imagesize", this.imagesize);
			if (this.imagealignshapeFieldSpecified)
			{
				global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "imagealignshape", this.imagealignshape);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "color2", this.color2);
			if (this.startarrowSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "startarrow", this.startarrow.ToString());
			}
			if (this.startarrowwidthFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "startarrowwidth", this.startarrowwidth.ToString());
			}
			if (this.startarrowlengthFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "startarrowlength", this.startarrowlength.ToString());
			}
			if (this.endarrowFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endarrow", this.endarrow.ToString());
			}
			if (this.endarrowwidthFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endarrowwidth", this.endarrowwidth.ToString());
			}
			if (this.endarrowlengthFieldSpecified)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "endarrowlength", this.endarrowlength.ToString());
			}
			global::NPOI.OpenXmlFormats.Util.XmlHelper.WriteAttribute(sw, "insetpen", this.insetpen);
			sw.Write("/>");
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x0003DFE8 File Offset: 0x0003C1E8
		[global::System.Xml.Serialization.XmlAttribute]
		public string id
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

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x0003DFF1 File Offset: 0x0003C1F1
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x0003DFF9 File Offset: 0x0003C1F9
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse on
		{
			get
			{
				return this.onField;
			}
			set
			{
				this.onField = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x0003E002 File Offset: 0x0003C202
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x0003E00A File Offset: 0x0003C20A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool onSpecified
		{
			get
			{
				return this.onFieldSpecified;
			}
			set
			{
				this.onFieldSpecified = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x0003E013 File Offset: 0x0003C213
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x0003E01B File Offset: 0x0003C21B
		[global::System.Xml.Serialization.XmlAttribute]
		public string weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x0003E024 File Offset: 0x0003C224
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x0003E02C File Offset: 0x0003C22C
		[global::System.Xml.Serialization.XmlAttribute]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x0003E035 File Offset: 0x0003C235
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x0003E03D File Offset: 0x0003C23D
		[global::System.Xml.Serialization.XmlAttribute]
		public string opacity
		{
			get
			{
				return this.opacityField;
			}
			set
			{
				this.opacityField = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x0003E046 File Offset: 0x0003C246
		// (set) Token: 0x060012F7 RID: 4855 RVA: 0x0003E04E File Offset: 0x0003C24E
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeLineStyle linestyle
		{
			get
			{
				return this.linestyleField;
			}
			set
			{
				this.linestyleField = value;
				this.linestyleFieldSpecified = true;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x0003E05E File Offset: 0x0003C25E
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x0003E066 File Offset: 0x0003C266
		[global::System.Xml.Serialization.XmlIgnore]
		public bool linestyleSpecified
		{
			get
			{
				return this.linestyleFieldSpecified;
			}
			set
			{
				this.linestyleFieldSpecified = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x0003E06F File Offset: 0x0003C26F
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x0003E077 File Offset: 0x0003C277
		[global::System.Xml.Serialization.XmlAttribute]
		public decimal miterlimit
		{
			get
			{
				return this.miterlimitField;
			}
			set
			{
				this.miterlimitField = value;
				this.miterlimitFieldSpecified = true;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x0003E087 File Offset: 0x0003C287
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x0003E08F File Offset: 0x0003C28F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool miterlimitSpecified
		{
			get
			{
				return this.miterlimitFieldSpecified;
			}
			set
			{
				this.miterlimitFieldSpecified = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x0003E098 File Offset: 0x0003C298
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x0003E0A0 File Offset: 0x0003C2A0
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeJoinStyle joinstyle
		{
			get
			{
				return this.joinstyleField;
			}
			set
			{
				this.joinstyleField = value;
				this.joinstyleFieldSpecified = true;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x0003E0B0 File Offset: 0x0003C2B0
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x0003E0B8 File Offset: 0x0003C2B8
		[global::System.Xml.Serialization.XmlIgnore]
		public bool joinstyleSpecified
		{
			get
			{
				return this.joinstyleFieldSpecified;
			}
			set
			{
				this.joinstyleFieldSpecified = value;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x0003E0C1 File Offset: 0x0003C2C1
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x0003E0C9 File Offset: 0x0003C2C9
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeEndCap endcap
		{
			get
			{
				return this.endcapField;
			}
			set
			{
				this.endcapField = value;
				this.endcapFieldSpecified = true;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x0003E0D9 File Offset: 0x0003C2D9
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x0003E0E1 File Offset: 0x0003C2E1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endcapSpecified
		{
			get
			{
				return this.endcapFieldSpecified;
			}
			set
			{
				this.endcapFieldSpecified = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x0003E0EA File Offset: 0x0003C2EA
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x0003E0F2 File Offset: 0x0003C2F2
		[global::System.Xml.Serialization.XmlAttribute]
		public string dashstyle
		{
			get
			{
				return this.dashstyleField;
			}
			set
			{
				this.dashstyleField = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x0003E0FB File Offset: 0x0003C2FB
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x0003E103 File Offset: 0x0003C303
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_FillType filltype
		{
			get
			{
				return this.filltypeField;
			}
			set
			{
				this.filltypeField = value;
				this.filltypeFieldSpecified = true;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x0003E113 File Offset: 0x0003C313
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x0003E11B File Offset: 0x0003C31B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool filltypeSpecified
		{
			get
			{
				return this.filltypeFieldSpecified;
			}
			set
			{
				this.filltypeFieldSpecified = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0003E124 File Offset: 0x0003C324
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x0003E12C File Offset: 0x0003C32C
		[global::System.Xml.Serialization.XmlAttribute]
		public string src
		{
			get
			{
				return this.srcField;
			}
			set
			{
				this.srcField = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0003E135 File Offset: 0x0003C335
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x0003E13D File Offset: 0x0003C33D
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect imageaspect
		{
			get
			{
				return this.imageaspectField;
			}
			set
			{
				this.imageaspectField = value;
				this.imageaspectFieldSpecified = true;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0003E14D File Offset: 0x0003C34D
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x0003E155 File Offset: 0x0003C355
		[global::System.Xml.Serialization.XmlIgnore]
		public bool imageaspectSpecified
		{
			get
			{
				return this.imageaspectFieldSpecified;
			}
			set
			{
				this.imageaspectFieldSpecified = value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x0003E15E File Offset: 0x0003C35E
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x0003E166 File Offset: 0x0003C366
		[global::System.Xml.Serialization.XmlAttribute]
		public string imagesize
		{
			get
			{
				return this.imagesizeField;
			}
			set
			{
				this.imagesizeField = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0003E16F File Offset: 0x0003C36F
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x0003E177 File Offset: 0x0003C377
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse imagealignshape
		{
			get
			{
				return this.imagealignshapeField;
			}
			set
			{
				this.imagealignshapeField = value;
				this.imagealignshapeFieldSpecified = true;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x0003E187 File Offset: 0x0003C387
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x0003E18F File Offset: 0x0003C38F
		[global::System.Xml.Serialization.XmlIgnore]
		public bool imagealignshapeSpecified
		{
			get
			{
				return this.imagealignshapeFieldSpecified;
			}
			set
			{
				this.imagealignshapeFieldSpecified = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x0003E198 File Offset: 0x0003C398
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x0003E1A0 File Offset: 0x0003C3A0
		[global::System.Xml.Serialization.XmlAttribute]
		public string color2
		{
			get
			{
				return this.color2Field;
			}
			set
			{
				this.color2Field = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x0003E1A9 File Offset: 0x0003C3A9
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x0003E1B1 File Offset: 0x0003C3B1
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType startarrow
		{
			get
			{
				return this.startarrowField;
			}
			set
			{
				this.startarrowField = value;
				this.startarrowFieldSpecified = true;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x0003E1C1 File Offset: 0x0003C3C1
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x0003E1C9 File Offset: 0x0003C3C9
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startarrowSpecified
		{
			get
			{
				return this.startarrowFieldSpecified;
			}
			set
			{
				this.startarrowFieldSpecified = value;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0003E1D2 File Offset: 0x0003C3D2
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x0003E1DA File Offset: 0x0003C3DA
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth startarrowwidth
		{
			get
			{
				return this.startarrowwidthField;
			}
			set
			{
				this.startarrowwidthField = value;
				this.startarrowwidthFieldSpecified = true;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0003E1EA File Offset: 0x0003C3EA
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x0003E1F2 File Offset: 0x0003C3F2
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startarrowwidthSpecified
		{
			get
			{
				return this.startarrowwidthFieldSpecified;
			}
			set
			{
				this.startarrowwidthFieldSpecified = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x0003E1FB File Offset: 0x0003C3FB
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x0003E203 File Offset: 0x0003C403
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength startarrowlength
		{
			get
			{
				return this.startarrowlengthField;
			}
			set
			{
				this.startarrowlengthField = value;
				this.startarrowlengthFieldSpecified = true;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0003E213 File Offset: 0x0003C413
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x0003E21B File Offset: 0x0003C41B
		[global::System.Xml.Serialization.XmlIgnore]
		public bool startarrowlengthSpecified
		{
			get
			{
				return this.startarrowlengthFieldSpecified;
			}
			set
			{
				this.startarrowlengthFieldSpecified = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0003E224 File Offset: 0x0003C424
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x0003E22C File Offset: 0x0003C42C
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType endarrow
		{
			get
			{
				return this.endarrowField;
			}
			set
			{
				this.endarrowField = value;
				this.endarrowFieldSpecified = true;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0003E23C File Offset: 0x0003C43C
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x0003E244 File Offset: 0x0003C444
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endarrowSpecified
		{
			get
			{
				return this.endarrowFieldSpecified;
			}
			set
			{
				this.endarrowFieldSpecified = value;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x0003E24D File Offset: 0x0003C44D
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x0003E255 File Offset: 0x0003C455
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth endarrowwidth
		{
			get
			{
				return this.endarrowwidthField;
			}
			set
			{
				this.endarrowwidthField = value;
				this.endarrowwidthFieldSpecified = true;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0003E265 File Offset: 0x0003C465
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x0003E26D File Offset: 0x0003C46D
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endarrowwidthSpecified
		{
			get
			{
				return this.endarrowwidthFieldSpecified;
			}
			set
			{
				this.endarrowwidthFieldSpecified = value;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0003E276 File Offset: 0x0003C476
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x0003E27E File Offset: 0x0003C47E
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength endarrowlength
		{
			get
			{
				return this.endarrowlengthField;
			}
			set
			{
				this.endarrowlengthField = value;
				this.endarrowlengthFieldSpecified = true;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0003E28E File Offset: 0x0003C48E
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x0003E296 File Offset: 0x0003C496
		[global::System.Xml.Serialization.XmlIgnore]
		public bool endarrowlengthSpecified
		{
			get
			{
				return this.endarrowlengthFieldSpecified;
			}
			set
			{
				this.endarrowlengthFieldSpecified = value;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0003E29F File Offset: 0x0003C49F
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x0003E2A7 File Offset: 0x0003C4A7
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse insetpen
		{
			get
			{
				return this.insetpenField;
			}
			set
			{
				this.insetpenField = value;
				this.insetpenFieldSpecified = true;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0003E2B7 File Offset: 0x0003C4B7
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x0003E2BF File Offset: 0x0003C4BF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool insetpenSpecified
		{
			get
			{
				return this.insetpenFieldSpecified;
			}
			set
			{
				this.insetpenFieldSpecified = value;
			}
		}

		// Token: 0x04000E5F RID: 3679
		private string idField;

		// Token: 0x04000E60 RID: 3680
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse onField;

		// Token: 0x04000E61 RID: 3681
		private bool onFieldSpecified;

		// Token: 0x04000E62 RID: 3682
		private string weightField;

		// Token: 0x04000E63 RID: 3683
		private string colorField;

		// Token: 0x04000E64 RID: 3684
		private string opacityField;

		// Token: 0x04000E65 RID: 3685
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeLineStyle linestyleField;

		// Token: 0x04000E66 RID: 3686
		private bool linestyleFieldSpecified;

		// Token: 0x04000E67 RID: 3687
		private decimal miterlimitField;

		// Token: 0x04000E68 RID: 3688
		private bool miterlimitFieldSpecified;

		// Token: 0x04000E69 RID: 3689
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeJoinStyle joinstyleField;

		// Token: 0x04000E6A RID: 3690
		private bool joinstyleFieldSpecified;

		// Token: 0x04000E6B RID: 3691
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeEndCap endcapField;

		// Token: 0x04000E6C RID: 3692
		private bool endcapFieldSpecified;

		// Token: 0x04000E6D RID: 3693
		private string dashstyleField;

		// Token: 0x04000E6E RID: 3694
		private global::NPOI.OpenXmlFormats.Vml.ST_FillType filltypeField;

		// Token: 0x04000E6F RID: 3695
		private bool filltypeFieldSpecified;

		// Token: 0x04000E70 RID: 3696
		private string srcField;

		// Token: 0x04000E71 RID: 3697
		private global::NPOI.OpenXmlFormats.Vml.ST_ImageAspect imageaspectField;

		// Token: 0x04000E72 RID: 3698
		private bool imageaspectFieldSpecified;

		// Token: 0x04000E73 RID: 3699
		private string imagesizeField;

		// Token: 0x04000E74 RID: 3700
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse imagealignshapeField;

		// Token: 0x04000E75 RID: 3701
		private bool imagealignshapeFieldSpecified;

		// Token: 0x04000E76 RID: 3702
		private string color2Field;

		// Token: 0x04000E77 RID: 3703
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType startarrowField;

		// Token: 0x04000E78 RID: 3704
		private bool startarrowFieldSpecified;

		// Token: 0x04000E79 RID: 3705
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth startarrowwidthField;

		// Token: 0x04000E7A RID: 3706
		private bool startarrowwidthFieldSpecified;

		// Token: 0x04000E7B RID: 3707
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength startarrowlengthField;

		// Token: 0x04000E7C RID: 3708
		private bool startarrowlengthFieldSpecified;

		// Token: 0x04000E7D RID: 3709
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowType endarrowField;

		// Token: 0x04000E7E RID: 3710
		private bool endarrowFieldSpecified;

		// Token: 0x04000E7F RID: 3711
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowWidth endarrowwidthField;

		// Token: 0x04000E80 RID: 3712
		private bool endarrowwidthFieldSpecified;

		// Token: 0x04000E81 RID: 3713
		private global::NPOI.OpenXmlFormats.Vml.ST_StrokeArrowLength endarrowlengthField;

		// Token: 0x04000E82 RID: 3714
		private bool endarrowlengthFieldSpecified;

		// Token: 0x04000E83 RID: 3715
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse insetpenField;

		// Token: 0x04000E84 RID: 3716
		private bool insetpenFieldSpecified;
	}
}
