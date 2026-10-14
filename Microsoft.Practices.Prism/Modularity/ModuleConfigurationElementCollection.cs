using System;
using System.Collections.Generic;
using System.Configuration;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200003D RID: 61
	public class ModuleConfigurationElementCollection : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00005BE3 File Offset: 0x00003DE3
		public ModuleConfigurationElementCollection()
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00005BEC File Offset: 0x00003DEC
		public ModuleConfigurationElementCollection(global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement[] modules)
		{
			if (modules == null)
			{
				throw new global::System.ArgumentNullException("modules");
			}
			foreach (global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement element in modules)
			{
				this.BaseAdd(element);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00005C28 File Offset: 0x00003E28
		protected override bool ThrowOnDuplicate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00005C2B File Offset: 0x00003E2B
		public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return global::System.Configuration.ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00005C2E File Offset: 0x00003E2E
		protected override string ElementName
		{
			get
			{
				return "module";
			}
		}

		// Token: 0x1700003C RID: 60
		public global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement this[int index]
		{
			get
			{
				return (global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement)base.BaseGet(index);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005C43 File Offset: 0x00003E43
		public void Add(global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement module)
		{
			this.BaseAdd(module);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00005C4C File Offset: 0x00003E4C
		public bool Contains(string moduleName)
		{
			return base.BaseGet(moduleName) != null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00005C5C File Offset: 0x00003E5C
		public global::System.Collections.Generic.IList<global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement> FindAll(global::System.Predicate<global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement> match)
		{
			if (match == null)
			{
				throw new global::System.ArgumentNullException("match");
			}
			global::System.Collections.Generic.IList<global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement> list = new global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement>();
			foreach (object obj in this)
			{
				global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement moduleConfigurationElement = (global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement)obj;
				if (match(moduleConfigurationElement))
				{
					list.Add(moduleConfigurationElement);
				}
			}
			return list;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005CD0 File Offset: 0x00003ED0
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			return new global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005CD7 File Offset: 0x00003ED7
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			return ((global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement)element).ModuleName;
		}
	}
}
