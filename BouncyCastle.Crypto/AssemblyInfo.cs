using System;
using System.Reflection;

// Token: 0x02000003 RID: 3
internal class AssemblyInfo
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
	public static string Version
	{
		get
		{
			if (global::AssemblyInfo.version == null)
			{
				global::AssemblyInfo.version = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
				if (global::AssemblyInfo.version == null)
				{
					global::AssemblyInfo.version = string.Empty;
				}
			}
			return global::AssemblyInfo.version;
		}
	}

	// Token: 0x0400000E RID: 14
	private static string version;
}
