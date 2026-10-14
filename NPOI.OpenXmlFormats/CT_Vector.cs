using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x02000019 RID: 25
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes")]
	[global::System.Serializable]
	public class CT_Vector
	{
		// Token: 0x06000113 RID: 275 RVA: 0x00002D76 File Offset: 0x00000F76
		public CT_Vector()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ST_VectorBaseType>();
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00002D94 File Offset: 0x00000F94
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002DA1 File Offset: 0x00000FA1
		[global::System.Xml.Serialization.XmlElement("bool", typeof(bool))]
		[global::System.Xml.Serialization.XmlElement("bstr", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("cf", typeof(global::NPOI.OpenXmlFormats.CT_Cf))]
		[global::System.Xml.Serialization.XmlElement("clsid", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("cy", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("date", typeof(global::System.DateTime))]
		[global::System.Xml.Serialization.XmlElement("error", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("filetime", typeof(global::System.DateTime))]
		[global::System.Xml.Serialization.XmlElement("i1", typeof(sbyte))]
		[global::System.Xml.Serialization.XmlElement("i2", typeof(short))]
		[global::System.Xml.Serialization.XmlElement("i4", typeof(int))]
		[global::System.Xml.Serialization.XmlElement("i8", typeof(long))]
		[global::System.Xml.Serialization.XmlElement("lpstr", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("lpwstr", typeof(string))]
		[global::System.Xml.Serialization.XmlElement("r4", typeof(float))]
		[global::System.Xml.Serialization.XmlElement("r8", typeof(double))]
		[global::System.Xml.Serialization.XmlElement("ui1", typeof(byte))]
		[global::System.Xml.Serialization.XmlElement("ui2", typeof(ushort))]
		[global::System.Xml.Serialization.XmlElement("ui4", typeof(uint))]
		[global::System.Xml.Serialization.XmlElement("ui8", typeof(ulong))]
		[global::System.Xml.Serialization.XmlElement("variant", typeof(global::NPOI.OpenXmlFormats.CT_Variant))]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
		{
			get
			{
				return this.itemsField.ToArray();
			}
			set
			{
				if (value != null && value.Length != 0)
				{
					this.itemsField = new global::System.Collections.Generic.List<object>(value);
					return;
				}
				this.itemsField = new global::System.Collections.Generic.List<object>();
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002DC2 File Offset: 0x00000FC2
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002DCF File Offset: 0x00000FCF
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.ST_VectorBaseType[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField.ToArray();
			}
			set
			{
				if (value != null && value.Length != 0)
				{
					this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ST_VectorBaseType>(value);
					return;
				}
				this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ST_VectorBaseType>();
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00002DF0 File Offset: 0x00000FF0
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00002DF8 File Offset: 0x00000FF8
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.ST_VectorBaseType baseType
		{
			get
			{
				return this.baseTypeField;
			}
			set
			{
				this.baseTypeField = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002E01 File Offset: 0x00001001
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002E09 File Offset: 0x00001009
		[global::System.Xml.Serialization.XmlAttribute]
		public uint size
		{
			get
			{
				return this.sizeField;
			}
			set
			{
				this.sizeField = value;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002E12 File Offset: 0x00001012
		public int SizeOfVariantArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.ST_VectorBaseType.variant);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002E1B File Offset: 0x0000101B
		public global::NPOI.OpenXmlFormats.CT_Variant GetVariantArray(int p)
		{
			return this.GetObjectArray<global::NPOI.OpenXmlFormats.CT_Variant>(p, global::NPOI.OpenXmlFormats.ST_VectorBaseType.variant);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002E25 File Offset: 0x00001025
		public int SizeOfLpstrArray()
		{
			return this.SizeOfArray(global::NPOI.OpenXmlFormats.ST_VectorBaseType.lpstr);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002E2F File Offset: 0x0000102F
		public string GetLpstrArray(int p)
		{
			return this.GetObjectArray<string>(p, global::NPOI.OpenXmlFormats.ST_VectorBaseType.lpstr);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002E3C File Offset: 0x0000103C
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.ST_VectorBaseType type) where T : class
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

		// Token: 0x06000121 RID: 289 RVA: 0x00002EC0 File Offset: 0x000010C0
		private int SizeOfArray(global::NPOI.OpenXmlFormats.ST_VectorBaseType type)
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

		// Token: 0x06000122 RID: 290 RVA: 0x00002F28 File Offset: 0x00001128
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.ST_VectorBaseType type) where T : class
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

		// Token: 0x06000123 RID: 291 RVA: 0x00002F9C File Offset: 0x0000119C
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.ST_VectorBaseType type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002FF8 File Offset: 0x000011F8
		private void SetObject<T>(global::NPOI.OpenXmlFormats.ST_VectorBaseType type, int p, T obj) where T : class
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

		// Token: 0x06000125 RID: 293 RVA: 0x000030AC File Offset: 0x000012AC
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.ST_VectorBaseType type, int p)
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

		// Token: 0x06000126 RID: 294 RVA: 0x000030F0 File Offset: 0x000012F0
		private void RemoveObject(global::NPOI.OpenXmlFormats.ST_VectorBaseType type, int p)
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

		// Token: 0x040000A1 RID: 161
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x040000A2 RID: 162
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.ST_VectorBaseType> itemsElementNameField;

		// Token: 0x040000A3 RID: 163
		private global::NPOI.OpenXmlFormats.ST_VectorBaseType baseTypeField;

		// Token: 0x040000A4 RID: 164
		private uint sizeField;
	}
}
