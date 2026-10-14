using System;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000074 RID: 116
	internal static class DbContextExtensions
	{
		// Token: 0x06000431 RID: 1073 RVA: 0x0000EA1A File Offset: 0x0000CC1A
		public static global::System.Xml.Linq.XDocument GetModel(this global::System.Data.Entity.DbContext context)
		{
			return global::System.Data.Entity.Utilities.DbContextExtensions.GetModel(delegate(global::System.Xml.XmlWriter w)
			{
				global::System.Data.Entity.Infrastructure.EdmxWriter.WriteEdmx(context, w);
			});
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000EA38 File Offset: 0x0000CC38
		public static global::System.Xml.Linq.XDocument GetModel(global::System.Action<global::System.Xml.XmlWriter> writeXml)
		{
			global::System.Xml.Linq.XDocument result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(memoryStream, new global::System.Xml.XmlWriterSettings
				{
					Indent = true
				}))
				{
					writeXml(xmlWriter);
				}
				memoryStream.Position = 0L;
				result = global::System.Xml.Linq.XDocument.Load(memoryStream);
			}
			return result;
		}
	}
}
