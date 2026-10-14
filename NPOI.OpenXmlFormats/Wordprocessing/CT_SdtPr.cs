using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x020000DB RID: 219
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_SdtPr
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x0001310E File Offset: 0x0001130E
		public CT_SdtPr()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType>();
			this.itemsField = new global::System.Collections.ArrayList();
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001312C File Offset: 0x0001132C
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00013134 File Offset: 0x00011334
		[global::System.Xml.Serialization.XmlElement("alias", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("bibliography", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("citation", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("comboBox", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtComboBox), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("dataBinding", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DataBinding), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("date", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDate), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("docPartList", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("docPartObj", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("dropDownList", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDropDownList), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("equation", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("group", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("id", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("lock", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lock), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("picture", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("placeholder", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Placeholder), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("rPr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("richText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("showingPlcHdr", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("tag", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("temporary", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("text", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtText), Order = 0)]
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001313D File Offset: 0x0001133D
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00013145 File Offset: 0x00011345
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType> ItemsElementName
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

		// Token: 0x06000646 RID: 1606 RVA: 0x00013150 File Offset: 0x00011350
		public static global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr ct_SdtPr = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtPr();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "richText")
				{
					ct_SdtPr.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.richText);
				}
				else if (xmlNode.LocalName == "docPartList")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.docPartList);
				}
				else if (xmlNode.LocalName == "docPartObj")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.docPartObj);
				}
				else if (xmlNode.LocalName == "dropDownList")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDropDownList.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.dropDownList);
				}
				else if (xmlNode.LocalName == "equation")
				{
					ct_SdtPr.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.equation);
				}
				else if (xmlNode.LocalName == "group")
				{
					ct_SdtPr.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.group);
				}
				else if (xmlNode.LocalName == "id")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.id);
				}
				else if (xmlNode.LocalName == "lock")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lock.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.@lock);
				}
				else if (xmlNode.LocalName == "date")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDate.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.date);
				}
				else if (xmlNode.LocalName == "placeholder")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Placeholder.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.placeholder);
				}
				else if (xmlNode.LocalName == "rPr")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.rPr);
				}
				else if (xmlNode.LocalName == "showingPlcHdr")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.showingPlcHdr);
				}
				else if (xmlNode.LocalName == "tag")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.tag);
				}
				else if (xmlNode.LocalName == "temporary")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.temporary);
				}
				else if (xmlNode.LocalName == "text")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtText.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.text);
				}
				else if (xmlNode.LocalName == "picture")
				{
					ct_SdtPr.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.picture);
				}
				else if (xmlNode.LocalName == "alias")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_String.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.alias);
				}
				else if (xmlNode.LocalName == "bibliography")
				{
					ct_SdtPr.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.bibliography);
				}
				else if (xmlNode.LocalName == "citation")
				{
					ct_SdtPr.Items.Add(new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty());
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.citation);
				}
				else if (xmlNode.LocalName == "comboBox")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtComboBox.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.comboBox);
				}
				else if (xmlNode.LocalName == "dataBinding")
				{
					ct_SdtPr.Items.Add(global::NPOI.OpenXmlFormats.Wordprocessing.CT_DataBinding.Parse(xmlNode, namespaceManager));
					ct_SdtPr.ItemsElementName.Add(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.dataBinding);
				}
			}
			return ct_SdtPr;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00013624 File Offset: 0x00011824
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}", nodeName));
			sw.Write(">");
			for (int i = 0; i < this.Items.Count; i++)
			{
				object obj = this.Items[i];
				global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType sdtPrElementType = this.itemsElementNameField[i];
				if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.richText)
				{
					sw.Write("<w:richText/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.docPartList)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart)obj).Write(sw, "docPartList");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.docPartObj)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart)obj).Write(sw, "docPartObj");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDropDownList)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDropDownList)obj).Write(sw, "dropDownList");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.equation)
				{
					sw.Write("<w:equation/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.group)
				{
					sw.Write("<w:group/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.id)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber)obj).Write(sw, "id");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lock)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Lock)obj).Write(sw, "lock");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDate)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDate)obj).Write(sw, "date");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Placeholder)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_Placeholder)obj).Write(sw, "placeholder");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr)obj).Write(sw, "rPr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.showingPlcHdr)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)obj).Write(sw, "showingPlcHdr");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_String && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.tag)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_String)obj).Write(sw, "tag");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.temporary)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff)obj).Write(sw, "temporary");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtText)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtText)obj).Write(sw, "text");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.picture)
				{
					sw.Write("<w:picture/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_String && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.alias)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_String)obj).Write(sw, "alias");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.bibliography)
				{
					sw.Write("<w:bibliography/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_Empty && sdtPrElementType == global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.citation)
				{
					sw.Write("<w:citation/>");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtComboBox)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtComboBox)obj).Write(sw, "comboBox");
				}
				else if (obj is global::NPOI.OpenXmlFormats.Wordprocessing.CT_DataBinding)
				{
					((global::NPOI.OpenXmlFormats.Wordprocessing.CT_DataBinding)obj).Write(sw, "dataBinding");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00013910 File Offset: 0x00011B10
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber AddNewId()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_DecimalNumber>(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.id);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0001391A File Offset: 0x00011B1A
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart AddNewDocPartObj()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Wordprocessing.CT_SdtDocPart>(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.docPartObj);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00013923 File Offset: 0x00011B23
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_String[] GetAliasArray()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_String>(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType.alias).ToArray();
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00013934 File Offset: 0x00011B34
		public global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType type) where T : class
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

		// Token: 0x0600064C RID: 1612 RVA: 0x000139B8 File Offset: 0x00011BB8
		private int SizeOfArray(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType type)
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

		// Token: 0x0600064D RID: 1613 RVA: 0x00013A20 File Offset: 0x00011C20
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType type) where T : class
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

		// Token: 0x0600064E RID: 1614 RVA: 0x00013A94 File Offset: 0x00011C94
		private T InsertNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType type, int p) where T : class, new()
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

		// Token: 0x0600064F RID: 1615 RVA: 0x00013AF8 File Offset: 0x00011CF8
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00013B54 File Offset: 0x00011D54
		private void SetObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType type, int p, T obj) where T : class
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

		// Token: 0x06000651 RID: 1617 RVA: 0x00013C08 File Offset: 0x00011E08
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType type, int p)
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

		// Token: 0x06000652 RID: 1618 RVA: 0x00013C4C File Offset: 0x00011E4C
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType type, int p)
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

		// Token: 0x0400054C RID: 1356
		private global::System.Collections.ArrayList itemsField;

		// Token: 0x0400054D RID: 1357
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.SdtPrElementType> itemsElementNameField;
	}
}
