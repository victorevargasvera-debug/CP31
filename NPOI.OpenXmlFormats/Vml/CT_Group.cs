using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using NPOI.OpenXmlFormats.Vml.Presentation;
using NPOI.OpenXmlFormats.Vml.Spreadsheet;
using NPOI.OpenXmlFormats.Vml.Wordprocessing;

namespace NPOI.OpenXmlFormats.Vml
{
	// Token: 0x020001E8 RID: 488
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:vml")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:vml", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Group
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x0003F445 File Offset: 0x0003D645
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x0003F45C File Offset: 0x0003D65C
		[global::System.Xml.Serialization.XmlElement("ClientData", typeof(global::NPOI.OpenXmlFormats.Vml.Spreadsheet.CT_ClientData), Namespace = "urn:schemas-microsoft-com:office:excel")]
		[global::System.Xml.Serialization.XmlElement("textdata", typeof(global::NPOI.OpenXmlFormats.Vml.Presentation.CT_Rel), Namespace = "urn:schemas-microsoft-com:office:powerpoint")]
		[global::System.Xml.Serialization.XmlElement("anchorlock", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_AnchorLock), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("borderbottom", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("borderleft", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("borderright", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("bordertop", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Border), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("wrap", typeof(global::NPOI.OpenXmlFormats.Vml.Wordprocessing.CT_Wrap), Namespace = "urn:schemas-microsoft-com:office:word")]
		[global::System.Xml.Serialization.XmlElement("arc", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Arc))]
		[global::System.Xml.Serialization.XmlElement("curve", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Curve))]
		[global::System.Xml.Serialization.XmlElement("fill", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Fill))]
		[global::System.Xml.Serialization.XmlElement("formulas", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Formulas))]
		[global::System.Xml.Serialization.XmlElement("group", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Group))]
		[global::System.Xml.Serialization.XmlElement("handles", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Handles))]
		[global::System.Xml.Serialization.XmlElement("image", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Image))]
		[global::System.Xml.Serialization.XmlElement("imagedata", typeof(global::NPOI.OpenXmlFormats.Vml.CT_ImageData))]
		[global::System.Xml.Serialization.XmlElement("line", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Line))]
		[global::System.Xml.Serialization.XmlElement("oval", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Oval))]
		[global::System.Xml.Serialization.XmlElement("path", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Path))]
		[global::System.Xml.Serialization.XmlElement("polyline", typeof(global::NPOI.OpenXmlFormats.Vml.CT_PolyLine))]
		[global::System.Xml.Serialization.XmlElement("rect", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Rect))]
		[global::System.Xml.Serialization.XmlElement("roundrect", typeof(global::NPOI.OpenXmlFormats.Vml.CT_RoundRect))]
		[global::System.Xml.Serialization.XmlElement("shadow", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Shadow))]
		[global::System.Xml.Serialization.XmlElement("shape", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Shape))]
		[global::System.Xml.Serialization.XmlElement("shapetype", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Shapetype))]
		[global::System.Xml.Serialization.XmlElement("stroke", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Stroke))]
		[global::System.Xml.Serialization.XmlElement("textbox", typeof(global::NPOI.OpenXmlFormats.Vml.CT_Textbox))]
		[global::System.Xml.Serialization.XmlElement("textpath", typeof(global::NPOI.OpenXmlFormats.Vml.CT_TextPath))]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
		{
			get
			{
				if (this.itemsField == null)
				{
					return null;
				}
				return this.itemsField.ToArray();
			}
			set
			{
				if (value == null)
				{
					this.itemsField = new global::System.Collections.Generic.List<object>();
					return;
				}
				this.itemsField = new global::System.Collections.Generic.List<object>(value);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x0003F479 File Offset: 0x0003D679
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x0003F486 File Offset: 0x0003D686
		[global::System.Xml.Serialization.XmlElement("ItemsElementName")]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField.ToArray();
			}
			set
			{
				if (value == null)
				{
					this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6>();
					return;
				}
				this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6>(value);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0003F4A3 File Offset: 0x0003D6A3
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x0003F4AB File Offset: 0x0003D6AB
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse filled
		{
			get
			{
				return this.filledField;
			}
			set
			{
				this.filledField = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0003F4B4 File Offset: 0x0003D6B4
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x0003F4BC File Offset: 0x0003D6BC
		[global::System.Xml.Serialization.XmlIgnore]
		public bool filledSpecified
		{
			get
			{
				return this.filledFieldSpecified;
			}
			set
			{
				this.filledFieldSpecified = value;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0003F4C5 File Offset: 0x0003D6C5
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x0003F4CD File Offset: 0x0003D6CD
		[global::System.Xml.Serialization.XmlAttribute]
		public string fillcolor
		{
			get
			{
				return this.fillcolorField;
			}
			set
			{
				this.fillcolorField = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0003F4D6 File Offset: 0x0003D6D6
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0003F4DE File Offset: 0x0003D6DE
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.ST_EditAs editas
		{
			get
			{
				return this.editasField;
			}
			set
			{
				this.editasField = value;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0003F4E7 File Offset: 0x0003D6E7
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x0003F4EF File Offset: 0x0003D6EF
		[global::System.Xml.Serialization.XmlIgnore]
		public bool editasSpecified
		{
			get
			{
				return this.editasFieldSpecified;
			}
			set
			{
				this.editasFieldSpecified = value;
			}
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x0003F4F8 File Offset: 0x0003D6F8
		public global::NPOI.OpenXmlFormats.Vml.CT_Shapetype AddNewShapetype()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Vml.CT_Shapetype>(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6.shapetype);
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x0003F504 File Offset: 0x0003D704
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6 type) where T : class
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

		// Token: 0x060013AC RID: 5036 RVA: 0x0003F588 File Offset: 0x0003D788
		private int SizeOfObjectArray(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6 type)
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

		// Token: 0x060013AD RID: 5037 RVA: 0x0003F5F0 File Offset: 0x0003D7F0
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6 type) where T : class
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

		// Token: 0x060013AE RID: 5038 RVA: 0x0003F664 File Offset: 0x0003D864
		private T InsertNewObject<T>(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6 type, int p) where T : class, new()
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

		// Token: 0x060013AF RID: 5039 RVA: 0x0003F6C8 File Offset: 0x0003D8C8
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6 type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0003F724 File Offset: 0x0003D924
		private void SetObjectArray<T>(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6 type, int p, T obj) where T : class
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

		// Token: 0x060013B1 RID: 5041 RVA: 0x0003F7D8 File Offset: 0x0003D9D8
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6 type, int p)
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

		// Token: 0x060013B2 RID: 5042 RVA: 0x0003F81C File Offset: 0x0003DA1C
		private void RemoveObject(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6 type, int p)
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

		// Token: 0x060013B3 RID: 5043 RVA: 0x0003F888 File Offset: 0x0003DA88
		public global::NPOI.OpenXmlFormats.Vml.CT_Shape AddNewShape()
		{
			return this.AddNewObject<global::NPOI.OpenXmlFormats.Vml.CT_Shape>(global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6.shape);
		}

		// Token: 0x04000EE0 RID: 3808
		private global::System.Collections.Generic.List<object> itemsField = new global::System.Collections.Generic.List<object>();

		// Token: 0x04000EE1 RID: 3809
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6> itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Vml.ItemsChoiceType6>();

		// Token: 0x04000EE2 RID: 3810
		private global::NPOI.OpenXmlFormats.Vml.ST_TrueFalse filledField;

		// Token: 0x04000EE3 RID: 3811
		private bool filledFieldSpecified;

		// Token: 0x04000EE4 RID: 3812
		private string fillcolorField;

		// Token: 0x04000EE5 RID: 3813
		private global::NPOI.OpenXmlFormats.Vml.ST_EditAs editasField;

		// Token: 0x04000EE6 RID: 3814
		private bool editasFieldSpecified;
	}
}
