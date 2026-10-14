using System;

namespace NLog.Targets
{
	// Token: 0x0200003D RID: 61
	[global::System.Obsolete("Use NLog.IJsonConverter class instead. Marked obsolete on NLog 4.5")]
	public interface IJsonSerializer
	{
		// Token: 0x06000613 RID: 1555
		string SerializeObject(object value);
	}
}
