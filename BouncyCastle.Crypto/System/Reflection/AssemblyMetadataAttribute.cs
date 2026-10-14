using System;

namespace System.Reflection
{
	// Token: 0x02000005 RID: 5
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	internal sealed class AssemblyMetadataAttribute : global::System.Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000021D5 File Offset: 0x000003D5
		public AssemblyMetadataAttribute(string key, string value)
		{
			this.Key = key;
			this.Value = value;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000021EB File Offset: 0x000003EB
		public string Key { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021F3 File Offset: 0x000003F3
		public string Value { get; }
	}
}
