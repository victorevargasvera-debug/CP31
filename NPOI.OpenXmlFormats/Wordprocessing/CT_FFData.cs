using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000093 RID: 147
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main", IsNullable = true)]
	[global::System.Serializable]
	public class CT_FFData
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0000BCB5 File Offset: 0x00009EB5
		public CT_FFData()
		{
			this.itemsElementNameField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType>();
			this.itemsField = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000BCD3 File Offset: 0x00009ED3
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		[global::System.Xml.Serialization.XmlElement("calcOnExit", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("checkBox", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("ddList", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFDDList), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("enabled", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("entryMacro", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MacroName), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("exitMacro", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MacroName), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("helpText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFHelpText), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("name", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFName), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("statusText", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFStatusText), Order = 0)]
		[global::System.Xml.Serialization.XmlElement("textInput", typeof(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextInput), Order = 0)]
		[global::System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
		{
			get
			{
				return this.itemsField.ToArray();
			}
			set
			{
				this.itemsField.Clear();
				this.itemsField.AddRange(value);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0000BCF9 File Offset: 0x00009EF9
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x0000BD06 File Offset: 0x00009F06
		[global::System.Xml.Serialization.XmlElement("ItemsElementName", Order = 1)]
		[global::System.Xml.Serialization.XmlIgnore]
		public global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField.ToArray();
			}
			set
			{
				this.itemsElementNameField.Clear();
				this.itemsElementNameField.AddRange(value);
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000BD20 File Offset: 0x00009F20
		internal static global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFData Parse(global::System.Xml.XmlNode node, global::System.Xml.XmlNamespaceManager namespaceManager)
		{
			if (node == null)
			{
				return null;
			}
			global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFData ct_FFData = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFData();
			foreach (object obj in node.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode.LocalName == "name")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFName.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.name);
				}
				else if (xmlNode.LocalName == "enabled")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.enabled);
				}
				else if (xmlNode.LocalName == "calcOnExit")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.calcOnExit);
				}
				else if (xmlNode.LocalName == "checkBox")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.checkBox);
				}
				else if (xmlNode.LocalName == "ddList")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFDDList.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.ddList);
				}
				else if (xmlNode.LocalName == "entryMacro")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MacroName.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.entryMacro);
				}
				else if (xmlNode.LocalName == "exitMacro")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_MacroName.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.exitMacro);
				}
				else if (xmlNode.LocalName == "helpText")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFHelpText.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.helpText);
				}
				else if (xmlNode.LocalName == "statusText")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFStatusText.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.statusText);
				}
				else if (xmlNode.LocalName == "textInput")
				{
					ct_FFData.AddNewObject(global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextInput.Parse(xmlNode, namespaceManager), global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.textInput);
				}
			}
			return ct_FFData;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<w:{0}>", nodeName));
			for (int i = 0; i < this.itemsElementNameField.Count; i++)
			{
				if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.name)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFName).Write(sw, "name");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.enabled)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff).Write(sw, "enabled");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.calcOnExit)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_OnOff).Write(sw, "calcOnExit");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.ddList)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFDDList).Write(sw, "ddList");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.checkBox)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox).Write(sw, "checkBox");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.entryMacro)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_MacroName).Write(sw, "entryMacro");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.exitMacro)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_MacroName).Write(sw, "exitMacro");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.helpText)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFHelpText).Write(sw, "helpText");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.statusText)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFStatusText).Write(sw, "statusText");
				}
				else if (this.itemsElementNameField[i] == global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.textInput)
				{
					(this.itemsField[i] as global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFTextInput).Write(sw, "textInput");
				}
			}
			sw.Write(string.Format("</w:{0}>", nodeName));
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000C118 File Offset: 0x0000A318
		private void AddNewObject(object obj, global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type)
		{
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(obj);
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000C168 File Offset: 0x0000A368
		private global::System.Collections.Generic.List<T> GetObjectList<T>(global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type) where T : class
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

		// Token: 0x06000415 RID: 1045 RVA: 0x0000C1EC File Offset: 0x0000A3EC
		private int SizeOfObjectArray(global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type)
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

		// Token: 0x06000416 RID: 1046 RVA: 0x0000C254 File Offset: 0x0000A454
		private T GetObjectArray<T>(int p, global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type) where T : class
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

		// Token: 0x06000417 RID: 1047 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		private T InsertNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type, int p) where T : class, new()
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

		// Token: 0x06000418 RID: 1048 RVA: 0x0000C32C File Offset: 0x0000A52C
		private T AddNewObject<T>(global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type) where T : class, new()
		{
			T t = global::System.Activator.CreateInstance<T>();
			lock (this)
			{
				this.itemsElementNameField.Add(type);
				this.itemsField.Add(t);
			}
			return t;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000C388 File Offset: 0x0000A588
		private void SetObjectArray<T>(global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type, int p, T obj) where T : class
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

		// Token: 0x0600041A RID: 1050 RVA: 0x0000C43C File Offset: 0x0000A63C
		private int GetObjectIndex(global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type, int p)
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

		// Token: 0x0600041B RID: 1051 RVA: 0x0000C480 File Offset: 0x0000A680
		private void RemoveObject(global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType type, int p)
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

		// Token: 0x0600041C RID: 1052 RVA: 0x0000C4EC File Offset: 0x0000A6EC
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox> GetCheckBoxList()
		{
			return this.GetObjectList<global::NPOI.OpenXmlFormats.Wordprocessing.CT_FFCheckBox>(global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType.checkBox);
		}

		// Token: 0x040003A0 RID: 928
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x040003A1 RID: 929
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.FFDataItemsType> itemsElementNameField;
	}
}
