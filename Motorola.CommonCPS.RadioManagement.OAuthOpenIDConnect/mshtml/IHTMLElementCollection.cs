using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml
{
	// Token: 0x02000011 RID: 17
	[global::System.Runtime.InteropServices.Guid("3050F21F-98B5-11CF-BB82-00AA00BDCE0B")]
	[global::System.Runtime.InteropServices.TypeIdentifier]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.Reflection.DefaultMember("item")]
	[global::System.Runtime.InteropServices.ComImport]
	public interface IHTMLElementCollection : global::System.Collections.IEnumerable
	{
		// Token: 0x06000039 RID: 57
		void _VtblGap1_4();

		// Token: 0x0600003A RID: 58
		[global::System.Runtime.InteropServices.DispId(0)]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.IDispatch)]
		object item([global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object name, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Struct)] [global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Optional] object index);
	}
}
