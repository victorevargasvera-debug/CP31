using System;
using System.Configuration;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x02000149 RID: 329
	internal class ContextCollection : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x0600157A RID: 5498 RVA: 0x0003733F File Offset: 0x0003553F
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			return new global::System.Data.Entity.Internal.ConfigFile.ContextElement();
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00037346 File Offset: 0x00035546
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			return ((global::System.Data.Entity.Internal.ConfigFile.ContextElement)element).ContextTypeName;
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00037353 File Offset: 0x00035553
		public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return global::System.Configuration.ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00037356 File Offset: 0x00035556
		protected override string ElementName
		{
			get
			{
				return "context";
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00037360 File Offset: 0x00035560
		protected override void BaseAdd(global::System.Configuration.ConfigurationElement element)
		{
			object elementKey = this.GetElementKey(element);
			if (base.BaseGet(elementKey) != null)
			{
				throw global::System.Data.Entity.Resources.Error.ContextConfiguredMultipleTimes(elementKey);
			}
			base.BaseAdd(element);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0003738C File Offset: 0x0003558C
		protected override void BaseAdd(int index, global::System.Configuration.ConfigurationElement element)
		{
			object elementKey = this.GetElementKey(element);
			if (base.BaseGet(elementKey) != null)
			{
				throw global::System.Data.Entity.Resources.Error.ContextConfiguredMultipleTimes(elementKey);
			}
			base.BaseAdd(index, element);
		}

		// Token: 0x040009D5 RID: 2517
		private const string ContextKey = "context";
	}
}
