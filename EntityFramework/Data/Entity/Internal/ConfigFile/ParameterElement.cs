using System;
using System.Configuration;
using System.Globalization;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x02000151 RID: 337
	internal class ParameterElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x060015B2 RID: 5554 RVA: 0x00037749 File Offset: 0x00035949
		public ParameterElement(int key)
		{
			this.Key = key;
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00037758 File Offset: 0x00035958
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00037760 File Offset: 0x00035960
		internal int Key { get; private set; }

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x00037769 File Offset: 0x00035969
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x0003777B File Offset: 0x0003597B
		[global::System.Configuration.ConfigurationProperty("value", IsRequired = true)]
		public string ValueString
		{
			get
			{
				return (string)base["value"];
			}
			set
			{
				base["value"] = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x00037789 File Offset: 0x00035989
		// (set) Token: 0x060015B8 RID: 5560 RVA: 0x0003779B File Offset: 0x0003599B
		[global::System.Configuration.ConfigurationProperty("type", DefaultValue = "System.String")]
		public string TypeName
		{
			get
			{
				return (string)base["type"];
			}
			set
			{
				base["type"] = value;
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000377AC File Offset: 0x000359AC
		public object GetTypedParameterValue()
		{
			global::System.Type type = global::System.Type.GetType(this.TypeName, true);
			return global::System.Convert.ChangeType(this.ValueString, type, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x040009EB RID: 2539
		private const string ValueKey = "value";

		// Token: 0x040009EC RID: 2540
		private const string TypeKey = "type";
	}
}
