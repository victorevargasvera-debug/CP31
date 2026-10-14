using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200020B RID: 523
	public enum IPAddressSpace
	{
		// Token: 0x040008EB RID: 2283
		[global::System.Runtime.Serialization.EnumMember(Value = "Local")]
		Local,
		// Token: 0x040008EC RID: 2284
		[global::System.Runtime.Serialization.EnumMember(Value = "Private")]
		Private,
		// Token: 0x040008ED RID: 2285
		[global::System.Runtime.Serialization.EnumMember(Value = "Public")]
		Public,
		// Token: 0x040008EE RID: 2286
		[global::System.Runtime.Serialization.EnumMember(Value = "Unknown")]
		Unknown
	}
}
