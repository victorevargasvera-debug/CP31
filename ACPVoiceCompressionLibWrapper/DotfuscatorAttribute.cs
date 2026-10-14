using System;
using System.Runtime.InteropServices;

// Token: 0x02000002 RID: 2
[global::System.Runtime.InteropServices.ComVisible(false)]
[global::System.AttributeUsage(global::System.AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : global::System.Attribute
{
	// Token: 0x06000002 RID: 2 RVA: 0x0000214C File Offset: 0x0000034C
	public DotfuscatorAttribute(string a, int c)
	{
		this.a = a;
		this.c = c;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002170 File Offset: 0x00000370
	public string A
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002184 File Offset: 0x00000384
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
