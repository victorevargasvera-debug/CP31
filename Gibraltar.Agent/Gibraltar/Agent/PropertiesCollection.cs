using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x0200026B RID: 619
	[global::System.Configuration.ConfigurationCollection(typeof(global::Gibraltar.Agent.PropertyElement))]
	internal class PropertiesCollection : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x06001FA2 RID: 8098 RVA: 0x00073060 File Offset: 0x00071260
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			return new global::Gibraltar.Agent.PropertyElement();
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x00073068 File Offset: 0x00071268
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			return ((global::Gibraltar.Agent.PropertyElement)element).Name;
		}

		// Token: 0x17000A52 RID: 2642
		public global::Gibraltar.Agent.PropertyElement this[int idx]
		{
			get
			{
				return (global::Gibraltar.Agent.PropertyElement)base.BaseGet(idx);
			}
		}
	}
}
