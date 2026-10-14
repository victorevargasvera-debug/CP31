using System;
using System.Runtime.InteropServices;

// Token: 0x02000002 RID: 2
[global::System.Runtime.InteropServices.ComVisible(false)]
[global::System.AttributeUsage(global::System.AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : global::System.Attribute
{
	// Token: 0x06000001 RID: 1 RVA: 0x000020E0 File Offset: 0x000002E0
	public DotfuscatorAttribute(string a, int c)
	{
		this.a = a;
		this.c = c;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002104 File Offset: 0x00000304
	public string A
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002118 File Offset: 0x00000318
	public int C
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x04000001 RID: 1
	private string a;

	// Token: 0x04000002 RID: 2
	private int c;
}
