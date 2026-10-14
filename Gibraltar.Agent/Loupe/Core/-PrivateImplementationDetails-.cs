using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000273 RID: 627
[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class <PrivateImplementationDetails>
{
	// Token: 0x06002059 RID: 8281 RVA: 0x00073DD4 File Offset: 0x00071FD4
	internal static uint ComputeStringHash(string s)
	{
		uint num;
		if (s != null)
		{
			num = 2166136261U;
			for (int i = 0; i < s.Length; i++)
			{
				num = ((uint)s[i] ^ num) * 16777619U;
			}
		}
		return num;
	}

	// Token: 0x04000BFA RID: 3066 RVA: 0x000BD17A File Offset: 0x000BB37A
	internal static readonly global::Loupe.Core.<PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 0C228E7D5E3F554EDDFE4B5E3F580BD65AE654AA;

	// Token: 0x04000BFB RID: 3067 RVA: 0x000BD180 File Offset: 0x000BB380
	internal static readonly global::Loupe.Core.<PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 426C257363D79BBE7C9083E515CAD7E1E2C1D84E;

	// Token: 0x04000BFC RID: 3068 RVA: 0x000BD18C File Offset: 0x000BB38C
	internal static readonly global::Loupe.Core.<PrivateImplementationDetails>.__StaticArrayInitTypeSize=22 6F8875729BF2B7C7AA441E87A10E068D5BA8C8DD;

	// Token: 0x020004BA RID: 1210
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit, Pack = 1, Size = 6)]
	private struct __StaticArrayInitTypeSize=6
	{
	}

	// Token: 0x020004BB RID: 1211
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit, Pack = 1, Size = 12)]
	private struct __StaticArrayInitTypeSize=12
	{
	}

	// Token: 0x020004BC RID: 1212
	[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Explicit, Pack = 1, Size = 22)]
	private struct __StaticArrayInitTypeSize=22
	{
	}
}
