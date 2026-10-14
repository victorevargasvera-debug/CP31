using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200006F RID: 111
	public class RegionAdapterMappings
	{
		// Token: 0x06000315 RID: 789 RVA: 0x00008E88 File Offset: 0x00007088
		public void RegisterMapping(global::System.Type controlType, global::Microsoft.Practices.Prism.Regions.IRegionAdapter adapter)
		{
			if (controlType == null)
			{
				throw new global::System.ArgumentNullException("controlType");
			}
			if (adapter == null)
			{
				throw new global::System.ArgumentNullException("adapter");
			}
			if (this.mappings.ContainsKey(controlType))
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.MappingExistsException, new object[]
				{
					controlType.Name
				}));
			}
			this.mappings.Add(controlType, adapter);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00008EF8 File Offset: 0x000070F8
		public global::Microsoft.Practices.Prism.Regions.IRegionAdapter GetMapping(global::System.Type controlType)
		{
			global::System.Type type = controlType;
			while (type != null)
			{
				if (this.mappings.ContainsKey(type))
				{
					return this.mappings[type];
				}
				type = type.BaseType;
			}
			throw new global::System.Collections.Generic.KeyNotFoundException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.NoRegionAdapterException, new object[]
			{
				controlType
			}));
		}

		// Token: 0x040000B1 RID: 177
		private readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::Microsoft.Practices.Prism.Regions.IRegionAdapter> mappings = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Microsoft.Practices.Prism.Regions.IRegionAdapter>();
	}
}
