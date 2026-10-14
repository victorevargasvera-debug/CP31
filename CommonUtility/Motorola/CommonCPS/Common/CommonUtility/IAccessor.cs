using System;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x02000013 RID: 19
	public interface IAccessor
	{
		// Token: 0x0600005D RID: 93
		object GetValue(object instance, string propertyName);

		// Token: 0x0600005E RID: 94
		void SetValue(object instance, string propertyName, object newValue);
	}
}
