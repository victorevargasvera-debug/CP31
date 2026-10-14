using System;
using System.Data.Entity.Utilities;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200023B RID: 571
	public class DefaultDbModelStore : global::System.Data.Entity.Infrastructure.DbModelStore
	{
		// Token: 0x06001E27 RID: 7719 RVA: 0x000533DA File Offset: 0x000515DA
		public DefaultDbModelStore(string directory)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(directory, "directory");
			this._directory = directory;
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000533F5 File Offset: 0x000515F5
		public string Directory
		{
			get
			{
				return this._directory;
			}
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00053400 File Offset: 0x00051600
		public override global::System.Data.Entity.Infrastructure.DbCompiledModel TryLoad(global::System.Type contextType)
		{
			return this.LoadXml<global::System.Data.Entity.Infrastructure.DbCompiledModel>(contextType, delegate(global::System.Xml.XmlReader reader)
			{
				string defaultSchema = this.GetDefaultSchema(contextType);
				return global::System.Data.Entity.Infrastructure.EdmxReader.Read(reader, defaultSchema);
			});
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00053439 File Offset: 0x00051639
		public override global::System.Xml.Linq.XDocument TryGetEdmx(global::System.Type contextType)
		{
			return this.LoadXml<global::System.Xml.Linq.XDocument>(contextType, new global::System.Func<global::System.Xml.XmlReader, global::System.Xml.Linq.XDocument>(global::System.Xml.Linq.XDocument.Load));
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00053450 File Offset: 0x00051650
		internal T LoadXml<T>(global::System.Type contextType, global::System.Func<global::System.Xml.XmlReader, T> xmlReaderDelegate)
		{
			string filePath = this.GetFilePath(contextType);
			T result;
			if (!global::System.IO.File.Exists(filePath))
			{
				result = default(T);
				return result;
			}
			if (!this.FileIsValid(contextType, filePath))
			{
				global::System.IO.File.Delete(filePath);
				result = default(T);
				return result;
			}
			using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(filePath))
			{
				result = xmlReaderDelegate(xmlReader);
			}
			return result;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x000534C0 File Offset: 0x000516C0
		public override void Save(global::System.Type contextType, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(this.GetFilePath(contextType), new global::System.Xml.XmlWriterSettings
			{
				Indent = true
			}))
			{
				global::System.Data.Entity.Infrastructure.EdmxWriter.WriteEdmx(model, xmlWriter);
			}
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0005350C File Offset: 0x0005170C
		protected virtual string GetFilePath(global::System.Type contextType)
		{
			string path = contextType.FullName + ".edmx";
			return global::System.IO.Path.Combine(this._directory, path);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00053538 File Offset: 0x00051738
		protected virtual bool FileIsValid(global::System.Type contextType, string filePath)
		{
			global::System.DateTime lastWriteTimeUtc = global::System.IO.File.GetLastWriteTimeUtc(contextType.Assembly.Location);
			return global::System.IO.File.GetLastWriteTimeUtc(filePath) >= lastWriteTimeUtc;
		}

		// Token: 0x04000B2C RID: 2860
		private const string FileExtension = ".edmx";

		// Token: 0x04000B2D RID: 2861
		private readonly string _directory;
	}
}
