using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020001BA RID: 442
	[global::System.Xml.Serialization.XmlInclude(typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPr))]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_TrPrBase
	{
		// Token: 0x060010BD RID: 4285 RVA: 0x000368DF File Offset: 0x00034ADF
		public CT_TrPrBase()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00036900 File Offset: 0x00034B00
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrBase Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrBase ct_TrPrBase = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_TrPrBase();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "gridBefore")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.gridBefore);
				}
				else if (xmlNode.LocalName == "cantSplit")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cantSplit);
				}
				else if (xmlNode.LocalName == "cnfStyle")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cnfStyle);
				}
				else if (xmlNode.LocalName == "divId")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.divId);
				}
				else if (xmlNode.LocalName == "gridAfter")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.gridAfter);
				}
				else if (xmlNode.LocalName == "trHeight")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.trHeight);
				}
				else if (xmlNode.LocalName == "hidden")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.hidden);
				}
				else if (xmlNode.LocalName == "tblCellSpacing")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblCellSpacing);
				}
				else if (xmlNode.LocalName == "tblHeader")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblHeader);
				}
				else if (xmlNode.LocalName == "jc")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.jc);
				}
				else if (xmlNode.LocalName == "wAfter")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.wAfter);
				}
				else if (xmlNode.LocalName == "wBefore")
				{
					ct_TrPrBase.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth.Parse(xmlNode, namespaceManager));
					ct_TrPrBase.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.wBefore);
				}
			}
			return ct_TrPrBase;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00036BF0 File Offset: 0x00034DF0
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			for (int i = 0; i < this.Items.Count; i++)
			{
				object obj = this.Items[i];
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.gridBefore)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber)obj).Write(sw, "gridBefore");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cantSplit)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)obj).Write(sw, "cantSplit");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cnfStyle)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf)obj).Write(sw, "cnfStyle");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.divId)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber)obj).Write(sw, "divId");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.gridAfter)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber)obj).Write(sw, "gridAfter");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.trHeight)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height)obj).Write(sw, "trHeight");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.hidden)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)obj).Write(sw, "hidden");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblCellSpacing)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth)obj).Write(sw, "tblCellSpacing");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblHeader)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)obj).Write(sw, "tblHeader");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.jc)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc)obj).Write(sw, "jc");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.wAfter)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth)obj).Write(sw, "wAfter");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth && this.ItemsElementName[i] == global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.wBefore)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth)obj).Write(sw, "wBefore");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x00036E63 File Offset: 0x00035063
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00036E6B File Offset: 0x0003506B
		[global::System.Xml.Serialization.XmlElement("cantSplit", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("cnfStyle", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Cnf), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("divId", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("gridAfter", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("gridBefore", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("hidden", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("jc", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Jc), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("tblCellSpacing", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("tblHeader", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("trHeight", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("wAfter", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("wBefore", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_TblWidth), Order = 0)]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public global::System.Collections.ArrayList Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00036E74 File Offset: 0x00035074
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00036E7C File Offset: 0x0003507C
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2> ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00036E85 File Offset: 0x00035085
		public int SizeOfTrHeightArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.trHeight);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00036E8F File Offset: 0x0003508F
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height GetTrHeightArray(int p)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height>(p, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.trHeight);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00036E9A File Offset: 0x0003509A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height AddNewTrHeight()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_Height>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.trHeight);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00036EA4 File Offset: 0x000350A4
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewCantSplit()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cantSplit);
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00036EAD File Offset: 0x000350AD
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> GetCantSplitList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cantSplit);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00036EB6 File Offset: 0x000350B6
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff AddNewTblHeader()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblHeader);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00036EBF File Offset: 0x000350BF
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff> GetTblHeaderList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblHeader);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00036EC8 File Offset: 0x000350C8
		public int SizeOfTblHeaderArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.tblHeader);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00036ED1 File Offset: 0x000350D1
		public int SizeOfCantSplitArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2.cantSplit);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00036EDC File Offset: 0x000350DC
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2 type) where T : class
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

		// Token: 0x060010CE RID: 4302 RVA: 0x00036F60 File Offset: 0x00035160
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2 type)
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

		// Token: 0x060010CF RID: 4303 RVA: 0x00036FC8 File Offset: 0x000351C8
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2 type) where T : class
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

		// Token: 0x060010D0 RID: 4304 RVA: 0x0003703C File Offset: 0x0003523C
		private T InsertNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2 type, int p) where T : class, new()
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

		// Token: 0x060010D1 RID: 4305 RVA: 0x000370A0 File Offset: 0x000352A0
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2 type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x000370FC File Offset: 0x000352FC
		private void SetObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2 type, int p, T obj) where T : class
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

		// Token: 0x060010D3 RID: 4307 RVA: 0x000371B0 File Offset: 0x000353B0
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2 type, int p)
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

		// Token: 0x060010D4 RID: 4308 RVA: 0x000371F4 File Offset: 0x000353F4
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2 type, int p)
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

		// Token: 0x04000D34 RID: 3380
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x04000D35 RID: 3381
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.ItemsChoiceType2> itemsElementNameField;
	}
}
