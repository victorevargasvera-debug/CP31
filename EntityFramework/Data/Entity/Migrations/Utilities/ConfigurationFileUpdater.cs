using System;
using System.Data.Entity.Utilities;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace System.Data.Entity.Migrations.Utilities
{
	// Token: 0x020000A2 RID: 162
	internal class ConfigurationFileUpdater
	{
		// Token: 0x06000EB9 RID: 3769 RVA: 0x0001E1C4 File Offset: 0x0001C3C4
		static ConfigurationFileUpdater()
		{
			global::System.Reflection.AssemblyName name = typeof(global::System.Data.Entity.Migrations.Utilities.ConfigurationFileUpdater).Assembly().GetName();
			global::System.Data.Entity.Migrations.Utilities.ConfigurationFileUpdater._dependentAssemblyElement = new global::System.Xml.Linq.XElement(global::System.Data.Entity.Migrations.Utilities.ConfigurationFileUpdater._asm + "dependentAssembly", new object[]
			{
				new global::System.Xml.Linq.XElement(global::System.Data.Entity.Migrations.Utilities.ConfigurationFileUpdater._asm + "assemblyIdentity", new object[]
				{
					new global::System.Xml.Linq.XAttribute("name", "EntityFramework"),
					new global::System.Xml.Linq.XAttribute("culture", "neutral"),
					new global::System.Xml.Linq.XAttribute("publicKeyToken", "b77a5c561934e089")
				}),
				new global::System.Xml.Linq.XElement(global::System.Data.Entity.Migrations.Utilities.ConfigurationFileUpdater._asm + "codeBase", new object[]
				{
					new global::System.Xml.Linq.XAttribute("version", name.Version.ToString()),
					new global::System.Xml.Linq.XAttribute("href", name.CodeBase)
				})
			});
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0001E2C8 File Offset: 0x0001C4C8
		public virtual string Update(string configurationFile)
		{
			bool flag = !string.IsNullOrWhiteSpace(configurationFile) && global::System.IO.File.Exists(configurationFile);
			global::System.Xml.Linq.XDocument xdocument = flag ? global::System.Xml.Linq.XDocument.Load(configurationFile) : new global::System.Xml.Linq.XDocument();
			xdocument.GetOrAddElement("configuration").GetOrAddElement("runtime").GetOrAddElement(global::System.Data.Entity.Migrations.Utilities.ConfigurationFileUpdater._asm + "assemblyBinding").Add(global::System.Data.Entity.Migrations.Utilities.ConfigurationFileUpdater._dependentAssemblyElement);
			string text = global::System.IO.Path.GetTempFileName();
			if (flag)
			{
				global::System.IO.File.Delete(text);
				text = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(configurationFile), global::System.IO.Path.GetFileName(text));
			}
			xdocument.Save(text);
			return text;
		}

		// Token: 0x04000831 RID: 2097
		private static readonly global::System.Xml.Linq.XNamespace _asm = "urn:schemas-microsoft-com:asm.v1";

		// Token: 0x04000832 RID: 2098
		private static readonly global::System.Xml.Linq.XElement _dependentAssemblyElement;
	}
}
