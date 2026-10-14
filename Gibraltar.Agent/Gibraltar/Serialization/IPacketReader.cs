using System;
using System.Reflection;

namespace Gibraltar.Serialization
{
	// Token: 0x02000102 RID: 258
	internal interface IPacketReader
	{
		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000ABA RID: 2746
		long Position { get; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000ABB RID: 2747
		long Length { get; }

		// Token: 0x06000ABC RID: 2748
		global::Gibraltar.Serialization.IPacket Read();

		// Token: 0x06000ABD RID: 2749
		void RegisterType(global::System.Type type);

		// Token: 0x06000ABE RID: 2750
		void RegisterFactory(string typeName, global::Gibraltar.Serialization.IPacketFactory factory);

		// Token: 0x06000ABF RID: 2751
		void RegisterAssembly(global::System.Reflection.Assembly assembly);
	}
}
