using System;
using System.Data;
using System.IO;
using System.Text;
using System.Xml;

namespace DevAge.Data
{
	// Token: 0x02000284 RID: 644
	internal abstract class FileDataSet
	{
		// Token: 0x060020DB RID: 8411 RVA: 0x00075AA8 File Offset: 0x00073CA8
		public FileDataSet()
		{
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x00075AB8 File Offset: 0x00073CB8
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x00075AC0 File Offset: 0x00073CC0
		protected global::DevAge.Data.StreamDataSetFormat SaveDataFormat
		{
			get
			{
				return this.mSaveDataFormat;
			}
			set
			{
				this.mSaveDataFormat = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x00075ACC File Offset: 0x00073CCC
		protected global::DevAge.Data.StreamDataSetFormat FileDataFormat
		{
			get
			{
				return this.mFileDataFormat;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x00075AD4 File Offset: 0x00073CD4
		// (set) Token: 0x060020E0 RID: 8416 RVA: 0x00075ADC File Offset: 0x00073CDC
		protected bool MergeReadedSchema
		{
			get
			{
				return this.mMergeReadedSchema;
			}
			set
			{
				this.mMergeReadedSchema = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x00075AE8 File Offset: 0x00073CE8
		// (set) Token: 0x060020E2 RID: 8418 RVA: 0x00075AF0 File Offset: 0x00073CF0
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
			set
			{
				this.m_FileName = value;
			}
		}

		// Token: 0x060020E3 RID: 8419
		protected abstract int GetDataVersion();

		// Token: 0x060020E4 RID: 8420
		protected abstract global::System.Data.DataSet CreateData(int version);

		// Token: 0x060020E5 RID: 8421 RVA: 0x00075AFC File Offset: 0x00073CFC
		protected virtual void SaveToFile(global::System.Data.DataSet pDataSet)
		{
			if (this.m_FileName == null)
			{
				throw new global::System.ApplicationException("FileName is null");
			}
			byte[] array2;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(memoryStream, global::System.Text.Encoding.UTF8);
				xmlTextWriter.WriteStartDocument();
				xmlTextWriter.WriteStartElement("filedataset", "http://www.devage.com/FileDataSet");
				xmlTextWriter.WriteStartElement("header", "http://www.devage.com/FileDataSet");
				xmlTextWriter.WriteAttributeString("fileversion", 1.ToString());
				xmlTextWriter.WriteAttributeString("dataversion", this.GetDataVersion().ToString());
				global::System.Xml.XmlWriter xmlWriter = xmlTextWriter;
				string localName = "dataformat";
				int num = (int)this.mSaveDataFormat;
				xmlWriter.WriteAttributeString(localName, num.ToString());
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteStartElement("data", "http://www.devage.com/FileDataSet");
				byte[] array;
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
				{
					global::DevAge.Data.StreamDataSet.Write(memoryStream2, pDataSet, this.mSaveDataFormat);
					array = memoryStream2.ToArray();
					memoryStream2.Close();
				}
				xmlTextWriter.WriteBase64(array, 0, array.Length);
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteEndElement();
				xmlTextWriter.WriteEndDocument();
				xmlTextWriter.Flush();
				array2 = memoryStream.ToArray();
				memoryStream.Close();
			}
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(this.m_FileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write))
			{
				fileStream.Write(array2, 0, array2.Length);
				fileStream.Close();
			}
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00075CB8 File Offset: 0x00073EB8
		protected virtual global::System.Data.DataSet LoadFromFile()
		{
			if (this.m_FileName == null)
			{
				throw new global::System.ApplicationException("FileName is null");
			}
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.Load(this.m_FileName);
			global::System.Xml.XmlNamespaceManager xmlNamespaceManager = new global::System.Xml.XmlNamespaceManager(xmlDocument.NameTable);
			xmlNamespaceManager.AddNamespace("fileds", "http://www.devage.com/FileDataSet");
			global::System.Xml.XmlNode xmlNode = xmlDocument.DocumentElement.SelectSingleNode("fileds:header", xmlNamespaceManager);
			if (xmlNode == null)
			{
				throw new global::System.ApplicationException("File header not found");
			}
			global::System.Xml.XmlElement xmlElement = (global::System.Xml.XmlElement)xmlNode;
			string attribute = xmlElement.GetAttribute("fileversion");
			int num = int.Parse(attribute);
			if (num == 1)
			{
				string attribute2 = xmlElement.GetAttribute("dataformat");
				this.mFileDataFormat = (global::DevAge.Data.StreamDataSetFormat)int.Parse(attribute2);
			}
			else if (num == 0)
			{
				this.mFileDataFormat = global::DevAge.Data.StreamDataSetFormat.XML;
			}
			else if (num > 1)
			{
				throw new global::System.ApplicationException("File Version not supported, expected: " + 1.ToString());
			}
			string attribute3 = xmlElement.GetAttribute("dataversion");
			int version = int.Parse(attribute3);
			global::System.Data.DataSet dataSet = this.CreateData(version);
			xmlNode = xmlDocument.DocumentElement.SelectSingleNode("fileds:data", xmlNamespaceManager);
			if (xmlNode == null)
			{
				throw new global::System.ApplicationException("File data not found");
			}
			global::System.Xml.XmlElement xmlElement2 = (global::System.Xml.XmlElement)xmlNode;
			byte[] buffer = global::System.Convert.FromBase64String(xmlElement2.InnerText);
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer))
			{
				global::DevAge.Data.StreamDataSet.Read(memoryStream, dataSet, this.mFileDataFormat, this.MergeReadedSchema);
			}
			return dataSet;
		}

		// Token: 0x04000C17 RID: 3095
		private const string c_DataNamespace = "http://www.devage.com/FileDataSet";

		// Token: 0x04000C18 RID: 3096
		private const int c_FileVersionNumber = 1;

		// Token: 0x04000C19 RID: 3097
		private const string c_FileVersion = "fileversion";

		// Token: 0x04000C1A RID: 3098
		private const string c_DataVersion = "dataversion";

		// Token: 0x04000C1B RID: 3099
		private const string c_DataFormat = "dataformat";

		// Token: 0x04000C1C RID: 3100
		private global::DevAge.Data.StreamDataSetFormat mSaveDataFormat = global::DevAge.Data.StreamDataSetFormat.Binary;

		// Token: 0x04000C1D RID: 3101
		private global::DevAge.Data.StreamDataSetFormat mFileDataFormat;

		// Token: 0x04000C1E RID: 3102
		private bool mMergeReadedSchema;

		// Token: 0x04000C1F RID: 3103
		private string m_FileName;
	}
}
