using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200050B RID: 1291
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/spreadsheetml/2006/main")]
	[global::System.Serializable]
	public class CT_Col
	{
		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06003775 RID: 14197 RVA: 0x0008A69E File Offset: 0x0008889E
		// (set) Token: 0x06003776 RID: 14198 RVA: 0x0008A6A6 File Offset: 0x000888A6
		[global::System.Xml.Serialization.XmlAttribute]
		public uint min
		{
			get
			{
				return this.minField;
			}
			set
			{
				this.minField = value;
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06003777 RID: 14199 RVA: 0x0008A6AF File Offset: 0x000888AF
		// (set) Token: 0x06003778 RID: 14200 RVA: 0x0008A6B7 File Offset: 0x000888B7
		[global::System.Xml.Serialization.XmlAttribute]
		public uint max
		{
			get
			{
				return this.maxField;
			}
			set
			{
				this.maxField = value;
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x0008A6C0 File Offset: 0x000888C0
		// (set) Token: 0x0600377A RID: 14202 RVA: 0x0008A6C8 File Offset: 0x000888C8
		[global::System.Xml.Serialization.XmlAttribute]
		public double width
		{
			get
			{
				return this.widthField;
			}
			set
			{
				this.widthField = value;
				this.widthSpecified = true;
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x0008A6D8 File Offset: 0x000888D8
		// (set) Token: 0x0600377C RID: 14204 RVA: 0x0008A6E0 File Offset: 0x000888E0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool widthSpecified
		{
			get
			{
				return this.widthSpecifiedField;
			}
			set
			{
				this.widthSpecifiedField = value;
			}
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x0008A6E9 File Offset: 0x000888E9
		public bool IsSetBestFit()
		{
			return this.bestFitField;
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0008A6F1 File Offset: 0x000888F1
		public bool IsSetCustomWidth()
		{
			return this.customWidthField;
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x0008A6F9 File Offset: 0x000888F9
		public bool IsSetHidden()
		{
			return this.hiddenField;
		}

		// Token: 0x06003780 RID: 14208 RVA: 0x0008A701 File Offset: 0x00088901
		public bool IsSetStyle()
		{
			return this.styleField != null;
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x0008A70E File Offset: 0x0008890E
		public bool IsSetWidth()
		{
			return this.widthField > 0.0;
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x0008A721 File Offset: 0x00088921
		public bool IsSetCollapsed()
		{
			return this.collapsedSpecifiedField;
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x0008A729 File Offset: 0x00088929
		public bool IsSetPhonetic()
		{
			return this.phoneticField;
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x0008A731 File Offset: 0x00088931
		public bool IsSetOutlineLevel()
		{
			return this.outlineLevelField > 0;
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x0008A73C File Offset: 0x0008893C
		public void UnsetHidden()
		{
			this.hiddenField = false;
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x0008A745 File Offset: 0x00088945
		public void UnsetCollapsed()
		{
			this.collapsedField = true;
			this.collapsedSpecified = false;
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x0008A755 File Offset: 0x00088955
		// (set) Token: 0x06003788 RID: 14216 RVA: 0x0008A75D File Offset: 0x0008895D
		[global::System.Xml.Serialization.XmlAttribute]
		public uint? style
		{
			get
			{
				return this.styleField;
			}
			set
			{
				this.styleField = value;
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x0008A6F9 File Offset: 0x000888F9
		// (set) Token: 0x0600378A RID: 14218 RVA: 0x0008A766 File Offset: 0x00088966
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool hidden
		{
			get
			{
				return this.hiddenField;
			}
			set
			{
				this.hiddenField = value;
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x0008A6E9 File Offset: 0x000888E9
		// (set) Token: 0x0600378C RID: 14220 RVA: 0x0008A76F File Offset: 0x0008896F
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool bestFit
		{
			get
			{
				return this.bestFitField;
			}
			set
			{
				this.bestFitField = value;
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x0600378D RID: 14221 RVA: 0x0008A6F1 File Offset: 0x000888F1
		// (set) Token: 0x0600378E RID: 14222 RVA: 0x0008A778 File Offset: 0x00088978
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool customWidth
		{
			get
			{
				return this.customWidthField;
			}
			set
			{
				this.customWidthField = value;
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x0008A729 File Offset: 0x00088929
		// (set) Token: 0x06003790 RID: 14224 RVA: 0x0008A781 File Offset: 0x00088981
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool phonetic
		{
			get
			{
				return this.phoneticField;
			}
			set
			{
				this.phoneticField = value;
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06003791 RID: 14225 RVA: 0x0008A78A File Offset: 0x0008898A
		// (set) Token: 0x06003792 RID: 14226 RVA: 0x0008A792 File Offset: 0x00088992
		[global::System.ComponentModel.DefaultValue(typeof(byte), "0")]
		[global::System.Xml.Serialization.XmlAttribute]
		public byte outlineLevel
		{
			get
			{
				return this.outlineLevelField;
			}
			set
			{
				this.outlineLevelField = value;
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06003793 RID: 14227 RVA: 0x0008A79B File Offset: 0x0008899B
		// (set) Token: 0x06003794 RID: 14228 RVA: 0x0008A7A3 File Offset: 0x000889A3
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.Xml.Serialization.XmlAttribute]
		public bool collapsed
		{
			get
			{
				return this.collapsedField;
			}
			set
			{
				this.collapsedField = value;
				this.collapsedSpecifiedField = true;
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x0008A721 File Offset: 0x00088921
		// (set) Token: 0x06003796 RID: 14230 RVA: 0x0008A7B3 File Offset: 0x000889B3
		[global::System.Xml.Serialization.XmlIgnore]
		public bool collapsedSpecified
		{
			get
			{
				return this.collapsedSpecifiedField;
			}
			set
			{
				this.collapsedSpecifiedField = value;
			}
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x0008A7D4 File Offset: 0x000889D4
		public static global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col();
			ct_Col.min = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["min"]);
			ct_Col.max = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["max"]);
			ct_Col.width = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadDouble(node.Attributes["width"]);
			if (node.Attributes["style"] != null)
			{
				ct_Col.style = new uint?(global::NPOI.OpenXml4Net.Util.XmlHelper.ReadUInt(node.Attributes["style"]));
			}
			else
			{
				ct_Col.style = null;
			}
			ct_Col.hidden = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["hidden"]);
			ct_Col.bestFit = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["bestFit"]);
			ct_Col.outlineLevel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadByte(node.Attributes["outlineLevel"]);
			ct_Col.customWidth = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["customWidth"]);
			ct_Col.phonetic = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["phonetic"]);
			ct_Col.collapsed = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBool(node.Attributes["collapsed"]);
			return ct_Col;
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0008A924 File Offset: 0x00088B24
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "min", this.min, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "max", this.max, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "width", this.width);
			if (this.style != null)
			{
				global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "style", this.style.Value, true);
			}
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "hidden", this.hidden, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "bestFit", this.bestFit, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "customWidth", this.customWidth, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "phonetic", this.phonetic, false);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "outlineLevel", (int)this.outlineLevel);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "collapsed", this.collapsed, false);
			sw.Write("/>");
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x0008AA18 File Offset: 0x00088C18
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col Copy()
		{
			return new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col
			{
				bestFitField = this.bestFitField,
				collapsedField = this.collapsedField,
				collapsedSpecifiedField = this.collapsedSpecifiedField,
				customWidthField = this.customWidthField,
				hiddenField = this.hiddenField,
				maxField = this.maxField,
				minField = this.minField,
				outlineLevelField = this.outlineLevelField,
				phoneticField = this.phoneticField,
				styleField = this.styleField,
				widthField = this.widthField,
				widthSpecifiedField = this.widthSpecifiedField
			};
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x0008AABC File Offset: 0x00088CBC
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (!(obj is global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col))
			{
				return false;
			}
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col ct_Col = obj as global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col;
			return ct_Col.min == this.min && ct_Col.max == this.max;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x0008AAFD File Offset: 0x00088CFD
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x0008AB0A File Offset: 0x00088D0A
		public override string ToString()
		{
			return string.Format("min:{0}, max:{1}, width:{2}", this.min, this.max, this.width);
		}

		// Token: 0x0400241A RID: 9242
		private uint minField;

		// Token: 0x0400241B RID: 9243
		private uint maxField;

		// Token: 0x0400241C RID: 9244
		private double widthField;

		// Token: 0x0400241D RID: 9245
		private bool widthSpecifiedField;

		// Token: 0x0400241E RID: 9246
		private uint? styleField;

		// Token: 0x0400241F RID: 9247
		private bool hiddenField;

		// Token: 0x04002420 RID: 9248
		private bool bestFitField;

		// Token: 0x04002421 RID: 9249
		private bool customWidthField;

		// Token: 0x04002422 RID: 9250
		private bool phoneticField;

		// Token: 0x04002423 RID: 9251
		private byte outlineLevelField;

		// Token: 0x04002424 RID: 9252
		private bool collapsedField = true;

		// Token: 0x04002425 RID: 9253
		private bool collapsedSpecifiedField = true;
	}
}
