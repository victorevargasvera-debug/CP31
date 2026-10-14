using System;
using System.Reflection;

namespace System.Data.Entity.Utilities
{
	// Token: 0x0200008D RID: 141
	internal static class MemberInfoExtensions
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x0000FAB8 File Offset: 0x0000DCB8
		public static object GetValue(this global::System.Reflection.MemberInfo memberInfo)
		{
			global::System.Reflection.PropertyInfo propertyInfo = memberInfo as global::System.Reflection.PropertyInfo;
			if (!(propertyInfo != null))
			{
				return ((global::System.Reflection.FieldInfo)memberInfo).GetValue(null);
			}
			return propertyInfo.GetValue(null, null);
		}
	}
}
