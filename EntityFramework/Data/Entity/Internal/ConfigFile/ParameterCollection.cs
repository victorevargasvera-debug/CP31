using System;
using System.Configuration;
using System.Linq;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x02000150 RID: 336
	internal class ParameterCollection : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x060015AB RID: 5547 RVA: 0x000376B5 File Offset: 0x000358B5
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			global::System.Configuration.ConfigurationElement result = new global::System.Data.Entity.Internal.ConfigFile.ParameterElement(this._nextKey);
			this._nextKey++;
			return result;
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000376D0 File Offset: 0x000358D0
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			return ((global::System.Data.Entity.Internal.ConfigFile.ParameterElement)element).Key;
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x000376E2 File Offset: 0x000358E2
		public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return global::System.Configuration.ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x000376E5 File Offset: 0x000358E5
		protected override string ElementName
		{
			get
			{
				return "parameter";
			}
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000376EC File Offset: 0x000358EC
		public virtual object[] GetTypedParameterValues()
		{
			return (from global::System.Data.Entity.Internal.ConfigFile.ParameterElement e in this
			select e.GetTypedParameterValue()).ToArray<object>();
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00037720 File Offset: 0x00035920
		internal global::System.Data.Entity.Internal.ConfigFile.ParameterElement NewElement()
		{
			global::System.Configuration.ConfigurationElement configurationElement = this.CreateNewElement();
			base.BaseAdd(configurationElement);
			return (global::System.Data.Entity.Internal.ConfigFile.ParameterElement)configurationElement;
		}

		// Token: 0x040009E9 RID: 2537
		private const string ParameterKey = "parameter";

		// Token: 0x040009EA RID: 2538
		private int _nextKey;
	}
}
