using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Xml;

namespace DevAge.Configuration
{
	// Token: 0x02000280 RID: 640
	internal class PersistableSettings
	{
		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x00074A18 File Offset: 0x00072C18
		protected global::DevAge.Configuration.PersistableItemDictionary Dictionary
		{
			get
			{
				return this.m_Dictionary;
			}
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00074A20 File Offset: 0x00072C20
		protected void AddPersistableItem(global::DevAge.Configuration.PersistableItem item)
		{
			this.m_Dictionary.Add(item.Name, item);
		}

		// Token: 0x17000ABB RID: 2747
		protected virtual object this[string name]
		{
			get
			{
				return this.m_Dictionary[name].Value;
			}
			set
			{
				this.m_Dictionary[name].Value = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x00074A5C File Offset: 0x00072C5C
		[global::System.ComponentModel.Browsable(false)]
		public virtual bool HasChanges
		{
			get
			{
				foreach (object obj in this.m_Dictionary.Values)
				{
					global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
					if (persistableItem.IsChanged)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00074AD4 File Offset: 0x00072CD4
		public virtual void AcceptChangesAsDefault()
		{
			foreach (object obj in this.m_Dictionary.Values)
			{
				global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
				persistableItem.AcceptAsDefault();
			}
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00074B3C File Offset: 0x00072D3C
		public virtual void Reset()
		{
			foreach (object obj in this.m_Dictionary.Values)
			{
				global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
				persistableItem.Reset();
			}
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x00074BA4 File Offset: 0x00072DA4
		protected virtual global::System.IO.IsolatedStorage.IsolatedStorageFile GetStorage()
		{
			return global::System.IO.IsolatedStorage.IsolatedStorageFile.GetUserStoreForDomain();
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00074BAC File Offset: 0x00072DAC
		protected virtual void WriteToIsolatedStorage(string fileName, global::DevAge.Configuration.PersistenceFlags flags)
		{
			using (global::System.IO.IsolatedStorage.IsolatedStorageFile storage = this.GetStorage())
			{
				global::System.IO.IsolatedStorage.IsolatedStorageFileStream isolatedStorageFileStream = null;
				isolatedStorageFileStream = new global::System.IO.IsolatedStorage.IsolatedStorageFileStream(fileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write, storage);
				try
				{
					this.WriteToStream(isolatedStorageFileStream, flags);
				}
				finally
				{
					isolatedStorageFileStream.Close();
				}
				storage.Close();
			}
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x00074C14 File Offset: 0x00072E14
		protected virtual void ReadFromIsolatedStorage(string fileName)
		{
			using (global::System.IO.IsolatedStorage.IsolatedStorageFile storage = this.GetStorage())
			{
				global::System.IO.IsolatedStorage.IsolatedStorageFileStream isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = new global::System.IO.IsolatedStorage.IsolatedStorageFileStream(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, storage);
				}
				catch (global::System.IO.FileNotFoundException)
				{
					isolatedStorageFileStream = null;
				}
				if (isolatedStorageFileStream != null)
				{
					try
					{
						this.ReadFromStream(isolatedStorageFileStream);
					}
					finally
					{
						isolatedStorageFileStream.Close();
					}
				}
				storage.Close();
			}
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00074C9C File Offset: 0x00072E9C
		protected virtual bool IsolatedStorageExists(string fileName)
		{
			fileName = global::System.IO.Path.GetFileName(fileName).ToLower();
			using (global::System.IO.IsolatedStorage.IsolatedStorageFile storage = this.GetStorage())
			{
				string[] fileNames = storage.GetFileNames("*");
				for (int i = 0; i < fileNames.Length; i++)
				{
					string a = global::System.IO.Path.GetFileName(fileNames[i]).ToLower();
					if (a == fileName)
					{
						return true;
					}
				}
				storage.Close();
			}
			return false;
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00074D2C File Offset: 0x00072F2C
		protected virtual void RemoveIsolatedStorage(string fileName)
		{
			using (global::System.IO.IsolatedStorage.IsolatedStorageFile storage = this.GetStorage())
			{
				storage.DeleteFile(fileName);
				storage.Close();
			}
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00074D70 File Offset: 0x00072F70
		protected virtual void WriteToStream(global::System.IO.Stream stream, global::DevAge.Configuration.PersistenceFlags flags)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.AppendChild(xmlDocument.CreateElement("settings"));
			this.WriteToXmlElement(xmlDocument.DocumentElement, flags);
			global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(stream, global::System.Text.Encoding.UTF8);
			xmlTextWriter.Formatting = global::System.Xml.Formatting.Indented;
			xmlDocument.WriteTo(xmlTextWriter);
			xmlTextWriter.Flush();
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x00074DC8 File Offset: 0x00072FC8
		protected virtual void WriteToXmlElement(global::System.Xml.XmlElement xmlElement, global::DevAge.Configuration.PersistenceFlags flags)
		{
			global::System.Xml.XmlNode xmlNode = xmlElement.SelectSingleNode("settings");
			if (xmlNode == null)
			{
				xmlNode = xmlElement.OwnerDocument.CreateElement("settings");
				xmlElement.AppendChild(xmlNode);
			}
			global::System.Xml.XmlNode xmlNode2 = xmlNode.SelectSingleNode("items");
			if (xmlNode2 == null)
			{
				xmlNode2 = xmlNode.OwnerDocument.CreateElement("items");
				xmlNode.AppendChild(xmlNode2);
				xmlNode2.Attributes.Append(xmlNode2.OwnerDocument.CreateAttribute("schemaversion"));
				xmlNode2.Attributes["schemaversion"].Value = "1";
			}
			foreach (object obj in this.m_Dictionary.Values)
			{
				global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
				string xpath = string.Format("item[@name='{0}' and @type='{1}' and @schemaversion='1']", persistableItem.Name, persistableItem.Type.FullName);
				global::System.Xml.XmlNode xmlNode3 = xmlNode2.SelectSingleNode(xpath);
				if ((flags & global::DevAge.Configuration.PersistenceFlags.OnlyChanges) == global::DevAge.Configuration.PersistenceFlags.OnlyChanges && !persistableItem.IsChanged)
				{
					if (xmlNode3 != null)
					{
						xmlNode2.RemoveChild(xmlNode3);
					}
				}
				else
				{
					if (xmlNode3 == null)
					{
						xmlNode3 = xmlNode2.OwnerDocument.CreateElement("item");
						xmlNode2.AppendChild(xmlNode3);
						xmlNode3.Attributes.Append(xmlNode3.OwnerDocument.CreateAttribute("name"));
						xmlNode3.Attributes.Append(xmlNode3.OwnerDocument.CreateAttribute("type"));
						xmlNode3.Attributes.Append(xmlNode3.OwnerDocument.CreateAttribute("schemaversion"));
						xmlNode3.Attributes["name"].Value = persistableItem.Name;
						xmlNode3.Attributes["type"].Value = persistableItem.Type.FullName;
						xmlNode3.Attributes["schemaversion"].Value = "1";
					}
					xmlNode3.InnerText = persistableItem.Validator.ValueToString(persistableItem.Value);
				}
			}
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x00075004 File Offset: 0x00073204
		protected virtual void ReadFromXmlElement(global::System.Xml.XmlElement xmlElement)
		{
			foreach (object obj in this.m_Dictionary.Values)
			{
				global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
				string xpath = string.Format("settings/items/item[@name='{0}' and @type='{1}' and @schemaversion='1']", persistableItem.Name, persistableItem.Type.FullName);
				global::System.Xml.XmlNode xmlNode = xmlElement.SelectSingleNode(xpath);
				if (xmlNode != null)
				{
					persistableItem.Value = persistableItem.Validator.StringToValue(xmlNode.InnerText);
				}
			}
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x000750A8 File Offset: 0x000732A8
		protected virtual void ReadFromStream(global::System.IO.Stream stream)
		{
			if (stream.Length == 0L)
			{
				return;
			}
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.Load(stream);
			this.ReadFromXmlElement(xmlDocument.DocumentElement);
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x000750E0 File Offset: 0x000732E0
		protected virtual void ReadFromAppSettings(string itemPrefix)
		{
			if (global::System.Configuration.ConfigurationManager.AppSettings.Count == 0)
			{
				return;
			}
			foreach (object obj in this.m_Dictionary.Values)
			{
				global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
				string text = global::System.Configuration.ConfigurationManager.AppSettings[itemPrefix + persistableItem.Name];
				if (text != null)
				{
					persistableItem.Value = persistableItem.Validator.StringToValue(text);
				}
			}
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x00075180 File Offset: 0x00073380
		protected virtual void ReadFromCommandLine(global::DevAge.Configuration.CommandLineArgs commandArguments, string itemPrefix, bool matchCase, bool throwErrorOnUnrecognizedParameter)
		{
			foreach (object obj in commandArguments.Keys)
			{
				string text = (string)obj;
				string text2 = text;
				if (!matchCase)
				{
					text2 = text2.ToUpper();
				}
				bool flag = false;
				foreach (object obj2 in this.m_Dictionary.Values)
				{
					global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj2;
					string text3 = itemPrefix + persistableItem.Name;
					if (!matchCase)
					{
						text3 = text3.ToUpper();
					}
					if (text2 == text3)
					{
						persistableItem.Value = persistableItem.Validator.StringToValue(commandArguments[text2]);
						flag = true;
						break;
					}
				}
				if (!flag && throwErrorOnUnrecognizedParameter)
				{
					throw new global::DevAge.UnrecognizedCommandLineParametersException(text);
				}
			}
		}

		// Token: 0x060020B1 RID: 8369 RVA: 0x000752AC File Offset: 0x000734AC
		protected virtual void ReadFromOther(global::DevAge.Configuration.PersistableSettings other)
		{
			foreach (object obj in this.m_Dictionary.Values)
			{
				global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
				foreach (object obj2 in other.m_Dictionary.Values)
				{
					global::DevAge.Configuration.PersistableItem persistableItem2 = (global::DevAge.Configuration.PersistableItem)obj2;
					if (persistableItem.Name == persistableItem2.Name)
					{
						string p_str = persistableItem2.Validator.ValueToString(persistableItem2.Value);
						persistableItem.Value = persistableItem.Validator.StringToValue(p_str);
						break;
					}
				}
			}
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x000753A8 File Offset: 0x000735A8
		public override string ToString()
		{
			string text = "ApplicationSetting: ";
			foreach (object obj in this.m_Dictionary.Values)
			{
				global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
				text = text + persistableItem.ToString() + ", ";
			}
			return text;
		}

		// Token: 0x04000C0B RID: 3083
		private global::DevAge.Configuration.PersistableItemDictionary m_Dictionary = new global::DevAge.Configuration.PersistableItemDictionary();
	}
}
