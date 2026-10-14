using System;
using System.Configuration;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x02000152 RID: 338
	internal class ProviderCollection : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x060015BA RID: 5562 RVA: 0x000377D7 File Offset: 0x000359D7
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			return new global::System.Data.Entity.Internal.ConfigFile.ProviderElement();
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000377DE File Offset: 0x000359DE
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			return ((global::System.Data.Entity.Internal.ConfigFile.ProviderElement)element).InvariantName;
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x000377EB File Offset: 0x000359EB
		public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return global::System.Configuration.ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x000377EE File Offset: 0x000359EE
		protected override string ElementName
		{
			get
			{
				return "provider";
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000377F5 File Offset: 0x000359F5
		protected override void BaseAdd(global::System.Configuration.ConfigurationElement element)
		{
			if (!this.ValidateProviderElement(element))
			{
				base.BaseAdd(element);
			}
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00037807 File Offset: 0x00035A07
		protected override void BaseAdd(int index, global::System.Configuration.ConfigurationElement element)
		{
			if (!this.ValidateProviderElement(element))
			{
				base.BaseAdd(index, element);
			}
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0003781C File Offset: 0x00035A1C
		private bool ValidateProviderElement(global::System.Configuration.ConfigurationElement element)
		{
			object elementKey = this.GetElementKey(element);
			global::System.Data.Entity.Internal.ConfigFile.ProviderElement providerElement = (global::System.Data.Entity.Internal.ConfigFile.ProviderElement)base.BaseGet(elementKey);
			if (providerElement != null && providerElement.ProviderTypeName != ((global::System.Data.Entity.Internal.ConfigFile.ProviderElement)element).ProviderTypeName)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ProviderInvariantRepeatedInConfig(elementKey));
			}
			return providerElement != null;
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0003786C File Offset: 0x00035A6C
		public global::System.Data.Entity.Internal.ConfigFile.ProviderElement AddProvider(string invariantName, string providerTypeName)
		{
			global::System.Data.Entity.Internal.ConfigFile.ProviderElement providerElement = (global::System.Data.Entity.Internal.ConfigFile.ProviderElement)this.CreateNewElement();
			base.BaseAdd(providerElement);
			providerElement.InvariantName = invariantName;
			providerElement.ProviderTypeName = providerTypeName;
			return providerElement;
		}

		// Token: 0x040009EE RID: 2542
		private const string ProviderKey = "provider";
	}
}
