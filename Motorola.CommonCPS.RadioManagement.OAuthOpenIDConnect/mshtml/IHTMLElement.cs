using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000010 RID: 16
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Runtime.InteropServices.Guid("3050F1FF-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLElement
	{
		// Token: 0x06000037 RID: 55
		void _VtblGap1_1();

		// Token: 0x06000038 RID: 56
		[global::System.Runtime.InteropServices.DispId(-2147417610)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)]
		object getAttribute([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.BStr)] [global::System.Runtime.InteropServices.In] string strAttributeName, [global::System.Runtime.InteropServices.In] int lFlags = 0);
	}
}
