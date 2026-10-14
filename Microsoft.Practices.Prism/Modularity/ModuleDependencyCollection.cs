using System;
using System.Configuration;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200003F RID: 63
	public class ModuleDependencyCollection : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00005CFB File Offset: 0x00003EFB
		public ModuleDependencyCollection()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005D04 File Offset: 0x00003F04
		public ModuleDependencyCollection(global::Microsoft.Practices.Prism.Modularity.ModuleDependencyConfigurationElement[] dependencies)
		{
			if (dependencies == null)
			{
				throw new global::System.ArgumentNullException("dependencies");
			}
			foreach (global::Microsoft.Practices.Prism.Modularity.ModuleDependencyConfigurationElement element in dependencies)
			{
				this.BaseAdd(element);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00005D40 File Offset: 0x00003F40
		public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return global::System.Configuration.ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00005D43 File Offset: 0x00003F43
		protected override string ElementName
		{
			get
			{
				return "dependency";
			}
		}

		// Token: 0x17000040 RID: 64
		public global::Microsoft.Practices.Prism.Modularity.ModuleDependencyConfigurationElement this[int index]
		{
			get
			{
				return (global::Microsoft.Practices.Prism.Modularity.ModuleDependencyConfigurationElement)base.BaseGet(index);
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00005D58 File Offset: 0x00003F58
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			return new global::Microsoft.Practices.Prism.Modularity.ModuleDependencyConfigurationElement();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00005D5F File Offset: 0x00003F5F
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			return ((global::Microsoft.Practices.Prism.Modularity.ModuleDependencyConfigurationElement)element).ModuleName;
		}
	}
}
