using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using NPOI.OpenXml4Net.Util;
using NPOI.OpenXmlFormats.Dml.WordProcessing;
using NPOI.OpenXmlFormats.Vml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000130 RID: 304
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_R
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x0001BD6C File Offset: 0x00019F6C
		public CT_R()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0001BD8A File Offset: 0x00019F8A
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x0001BD92 File Offset: 0x00019F92
		[global::System.Xml.Serialization.XmlElement(Order = 0, IsNullable = true)]
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPr
		{
			get
			{
				return this.rPrField;
			}
			set
			{
				this.rPrField = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0001BD9B File Offset: 0x00019F9B
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x0001BDA3 File Offset: 0x00019FA3
		public global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent alternateContent
		{
			get
			{
				return this.alternateContentField;
			}
			set
			{
				this.alternateContentField = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0001BDAC File Offset: 0x00019FAC
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x0001BDB4 File Offset: 0x00019FB4
		[global::System.Xml.Serialization.XmlElement("annotationRef", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("br", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("commentReference", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("continuationSeparator", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("cr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("dayLong", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("dayShort", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("delInstrText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("delText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("drawing", typeof(global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("endnoteRef", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("endnoteReference", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("fldChar", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("footnoteRef", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("footnoteReference", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("instrText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("lastRenderedPageBreak", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("monthLong", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("monthShort", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("noBreakHyphen", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("object", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("pgNum", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("pict", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("ptab", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("ruby", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("separator", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("softHyphen", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("sym", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("t", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("tab", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("yearLong", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlElement("yearShort", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 1)]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public global::System.Collections.ArrayList Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = new global::System.Collections.ArrayList();
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0001BDC1 File Offset: 0x00019FC1
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x0001BDC9 File Offset: 0x00019FC9
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 2)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType> ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType>();
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0001BDD6 File Offset: 0x00019FD6
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x0001BDDE File Offset: 0x00019FDE
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidRPr
		{
			get
			{
				return this.rsidRPrField;
			}
			set
			{
				this.rsidRPrField = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0001BDE7 File Offset: 0x00019FE7
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x0001BDEF File Offset: 0x00019FEF
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidDel
		{
			get
			{
				return this.rsidDelField;
			}
			set
			{
				this.rsidDelField = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x0001BE00 File Offset: 0x0001A000
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, DataType = "hexBinary")]
		public byte[] rsidR
		{
			get
			{
				return this.rsidRField;
			}
			set
			{
				this.rsidRField = value;
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0001BE09 File Offset: 0x0001A009
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text AddNewT()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.t);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0001BE13 File Offset: 0x0001A013
		public void RemoveT(int pos)
		{
			this.RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.t, pos);
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0001BE1E File Offset: 0x0001A01E
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr AddNewRPr()
		{
			if (this.rPrField == null)
			{
				this.rPrField = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr();
			}
			return this.rPrField;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0001BE39 File Offset: 0x0001A039
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty AddNewTab()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.tab);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0001BE43 File Offset: 0x0001A043
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar AddNewFldChar()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.fldChar);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0001BE4D File Offset: 0x0001A04D
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text AddNewInstrText()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.instrText);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0001BE57 File Offset: 0x0001A057
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty AddNewCr()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.cr);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0001BE60 File Offset: 0x0001A060
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br AddNewBr()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.br);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0001BE69 File Offset: 0x0001A069
		public bool IsSetRPr()
		{
			return this.rPrField != null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0001BE74 File Offset: 0x0001A074
		public int SizeOfTArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.t);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0001BE7E File Offset: 0x0001A07E
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text GetTArray(int pos)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text>(pos, global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.t);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0001BE89 File Offset: 0x0001A089
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text> GetTList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.t);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0001BE93 File Offset: 0x0001A093
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing AddNewDrawing()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.drawing);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001BE9D File Offset: 0x0001A09D
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing> GetDrawingList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.drawing);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0001BEA7 File Offset: 0x0001A0A7
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text> GetDelTextList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.delText);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture> GetPictList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.pict);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0001BEBA File Offset: 0x0001A0BA
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture AddNewPict()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.pict);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0001BEC4 File Offset: 0x0001A0C4
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType type) where T : class
		{
			global::System.Collections.Generic.List<T> result;
			lock (this)
			{
				global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
				for (int i = 0; i < this.itemsElementNameField.Count; i++)
				{
					if (this.itemsElementNameField[i] == type)
					{
						list.Add(this.itemsField[i] as T);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0001BF48 File Offset: 0x0001A148
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType type)
		{
			int result;
			lock (this)
			{
				int num = 0;
				for (int i = 0; i < this.itemsElementNameField.Count; i++)
				{
					if (this.itemsElementNameField[i] == type)
					{
						num++;
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType type) where T : class
		{
			T t;
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				if (objectIndex < 0 || objectIndex >= this.itemsField.Count)
				{
					t = default(T);
					t = t;
				}
				else
				{
					t = (this.itemsField[objectIndex] as T);
				}
			}
			return t;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0001C024 File Offset: 0x0001A224
		private T InsertNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType type, int p) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				this.itemsElementNameField.Insert(objectIndex, type);
				this.itemsField.Insert(objectIndex, t);
			}
			return t;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0001C088 File Offset: 0x0001A288
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
		private void SetObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType type, int p, T obj) where T : class
		{
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				if (objectIndex >= 0 && objectIndex < this.itemsField.Count)
				{
					if (!(this.itemsField[objectIndex] is T))
					{
						throw new global::System.Exception(string.Format("object types are difference, itemsField[{0}] is {1}, and parameter obj is {2}", objectIndex, this.itemsField[objectIndex].GetType().Name, typeof(T).Name));
					}
					this.itemsField[objectIndex] = obj;
				}
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001C198 File Offset: 0x0001A398
		public bool IsSetRsidDel()
		{
			return this.rsidDelField != null;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType type, int p)
		{
			int result = -1;
			int num = 0;
			for (int i = 0; i < this.itemsElementNameField.Count; i++)
			{
				if (this.itemsElementNameField[i] == type)
				{
					if (num == p)
					{
						result = i;
						break;
					}
					num++;
				}
			}
			return result;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0001C1E8 File Offset: 0x0001A3E8
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType type, int p)
		{
			lock (this)
			{
				int objectIndex = this.GetObjectIndex(type, p);
				if (objectIndex >= 0 && objectIndex < this.itemsField.Count)
				{
					this.itemsElementNameField.RemoveAt(objectIndex);
					this.itemsField.RemoveAt(objectIndex);
				}
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0001C254 File Offset: 0x0001A454
		public global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing GetDrawingArray(int p)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing>(p, global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.drawing);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0001C25F File Offset: 0x0001A45F
		public int SizeOfCrArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.cr);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x0001C268 File Offset: 0x0001A468
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty> GetCrList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.cr);
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x0001C271 File Offset: 0x0001A471
		public int SizeOfBrArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.br);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x0001C27C File Offset: 0x0001A47C
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_R Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_R ct_R = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_R();
			ct_R.rsidRPr = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidRPr"]);
			ct_R.rsidDel = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidDel"]);
			ct_R.rsidR = global::NPOI.OpenXml4Net.Util.XmlHelper.ReadBytes(node.Attributes["w:rsidR"]);
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "rPr")
				{
					ct_R.rPr = global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "instrText")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.instrText);
				}
				else if (xmlNode.LocalName == "object")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.@object);
				}
				else if (xmlNode.LocalName == "pgNum")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.pgNum);
				}
				else if (xmlNode.LocalName == "annotationRef")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.annotationRef);
				}
				else if (xmlNode.LocalName == "br")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.br);
				}
				else if (xmlNode.LocalName == "commentReference")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.commentReference);
				}
				else if (xmlNode.LocalName == "continuationSeparator")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.continuationSeparator);
				}
				else if (xmlNode.LocalName == "cr")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.cr);
				}
				else if (xmlNode.LocalName == "dayLong")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.dayLong);
				}
				else if (xmlNode.LocalName == "dayShort")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.dayShort);
				}
				else if (xmlNode.LocalName == "delInstrText")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.delInstrText);
				}
				else if (xmlNode.LocalName == "delText")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.delText);
				}
				else if (xmlNode.LocalName == "drawing")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.drawing);
				}
				else if (xmlNode.LocalName == "AlternateContent")
				{
					ct_R.alternateContent = global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent.Parse(xmlNode, namespaceManager);
				}
				else if (xmlNode.LocalName == "endnoteRef")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.endnoteRef);
				}
				else if (xmlNode.LocalName == "endnoteReference")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.endnoteReference);
				}
				else if (xmlNode.LocalName == "fldChar")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.fldChar);
				}
				else if (xmlNode.LocalName == "footnoteRef")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.footnoteRef);
				}
				else if (xmlNode.LocalName == "footnoteReference")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.footnoteReference);
				}
				else if (xmlNode.LocalName == "lastRenderedPageBreak")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.lastRenderedPageBreak);
				}
				else if (xmlNode.LocalName == "monthLong")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.monthLong);
				}
				else if (xmlNode.LocalName == "monthShort")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.monthShort);
				}
				else if (xmlNode.LocalName == "noBreakHyphen")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.noBreakHyphen);
				}
				else if (xmlNode.LocalName == "yearLong")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.yearLong);
				}
				else if (xmlNode.LocalName == "pict")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.pict);
				}
				else if (xmlNode.LocalName == "ptab")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.ptab);
				}
				else if (xmlNode.LocalName == "ruby")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.ruby);
				}
				else if (xmlNode.LocalName == "separator")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.separator);
				}
				else if (xmlNode.LocalName == "softHyphen")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.softHyphen);
				}
				else if (xmlNode.LocalName == "sym")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.sym);
				}
				else if (xmlNode.LocalName == "t")
				{
					ct_R.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text.Parse(xmlNode, namespaceManager));
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.t);
				}
				else if (xmlNode.LocalName == "tab")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.tab);
				}
				else if (xmlNode.LocalName == "yearShort")
				{
					ct_R.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_R.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.yearShort);
				}
			}
			return ct_R;
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0001CA30 File Offset: 0x0001AC30
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidR", this.rsidR);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidRPr", this.rsidRPr);
			global::NPOI.OpenXml4Net.Util.XmlHelper.WriteAttribute(sw, "w:rsidDel", this.rsidDel);
			sw.Write(">");
			if (this.rPr != null)
			{
				this.rPr.Write(sw, "rPr");
			}
			int num = 0;
			foreach (object obj in this.Items)
			{
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.instrText)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Write(sw, "instrText");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Object)obj).Write(sw, "object");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.pgNum)
				{
					sw.Write("<w:pgNum/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.annotationRef)
				{
					sw.Write("<w:annotationRef/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Br)obj).Write(sw, "br");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Markup)obj).Write(sw, "commentReference");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.continuationSeparator)
				{
					sw.Write("<w:continuationSeparator/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.cr)
				{
					sw.Write("<w:cr/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.dayLong)
				{
					sw.Write("<w:dayLong/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.dayShort)
				{
					sw.Write("<w:dayShort/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.delInstrText)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Write(sw, "delInstrText");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.delText)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Write(sw, "delText");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing)
				{
					((global::NPOI.OpenXmlFormats.Dml.WordProcessing.CT_Drawing)obj).Write(sw, "drawing");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.endnoteRef)
				{
					sw.Write("<w:endnoteRef/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.endnoteReference)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef)obj).Write(sw, "endnoteReference");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.footnoteReference)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_FtnEdnRef)obj).Write(sw, "footnoteReference");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_FldChar)obj).Write(sw, "fldChar");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.footnoteRef)
				{
					sw.Write("<w:footnoteRef/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.lastRenderedPageBreak)
				{
					sw.Write("<w:lastRenderedPageBreak/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.monthLong)
				{
					sw.Write("<w:monthLong/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.monthShort)
				{
					sw.Write("<w:monthShort/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.noBreakHyphen)
				{
					sw.Write("<w:noBreakHyphen/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.yearLong)
				{
					sw.Write("<w:yearLong/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Picture)obj).Write(sw, "pict");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_PTab)obj).Write(sw, "ptab");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Ruby)obj).Write(sw, "ruby");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.separator)
				{
					sw.Write("<w:separator/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.softHyphen)
				{
					sw.Write("<w:softHyphen/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Sym)obj).Write(sw, "sym");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.t)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Text)obj).Write(sw, "t");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.tab)
				{
					sw.Write("<w:tab/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && this.ItemsElementName[num] == global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.yearShort)
				{
					sw.Write("<w:yearShort/>");
				}
				num++;
			}
			if (this.alternateContent != null)
			{
				this.alternateContent.Write(sw, "AlternateContent");
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0001CFDC File Offset: 0x0001B1DC
		public int SizeOfTabArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.tab);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0001CFE6 File Offset: 0x0001B1E6
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty> GetTabList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty>(global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType.tab);
		}

		// Token: 0x04000749 RID: 1865
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rPrField;

		// Token: 0x0400074A RID: 1866
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x0400074B RID: 1867
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.RunItemsChoiceType> itemsElementNameField;

		// Token: 0x0400074C RID: 1868
		private byte[] rsidRPrField;

		// Token: 0x0400074D RID: 1869
		private byte[] rsidDelField;

		// Token: 0x0400074E RID: 1870
		private byte[] rsidRField;

		// Token: 0x0400074F RID: 1871
		private global::NPOI.OpenXmlFormats.Vml.CT_AlternateContent alternateContentField;
	}
}
