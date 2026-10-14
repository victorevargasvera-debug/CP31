using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools
{
	// Token: 0x02000024 RID: 36
	[global::System.Runtime.Serialization.DataContract]
	public abstract class DevToolsDomainEventArgsBase : global::System.EventArgs
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00004CBB File Offset: 0x00002EBB
		public static object StringToEnum(global::System.Type enumType, string input)
		{
			return global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(enumType, input);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public static string EnumToString(global::System.Enum e)
		{
			return global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(e);
		}
	}
}
