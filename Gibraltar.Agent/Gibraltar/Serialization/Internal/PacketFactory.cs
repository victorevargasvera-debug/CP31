using System;
using System.Collections.Generic;
using System.Reflection;

namespace Gibraltar.Serialization.Internal
{
	// Token: 0x02000113 RID: 275
	internal class PacketFactory
	{
		// Token: 0x06000B7F RID: 2943 RVA: 0x0001D2AC File Offset: 0x0001B4AC
		public PacketFactory()
		{
			this.m_PacketFactories = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Serialization.IPacketFactory>();
			this.m_GenericFactory = new global::Gibraltar.Serialization.Internal.GenericPacketFactory();
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0001D2CC File Offset: 0x0001B4CC
		public void RegisterType(global::System.Type type)
		{
			global::Gibraltar.Serialization.Internal.SimplePacketFactory simplePacketFactory = new global::Gibraltar.Serialization.Internal.SimplePacketFactory(type);
			if (simplePacketFactory.IsValid)
			{
				this.RegisterFactory(type.Name, simplePacketFactory);
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0001D2FC File Offset: 0x0001B4FC
		public void RegisterFactory(string typeName, global::Gibraltar.Serialization.IPacketFactory factory)
		{
			this.m_PacketFactories[typeName] = factory;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0001D30C File Offset: 0x0001B50C
		public void RegisterAssembly(global::System.Reflection.Assembly assembly)
		{
			global::System.Type[] types = assembly.GetTypes();
			global::System.Type typeFromHandle = typeof(global::Gibraltar.Serialization.IPacket);
			foreach (global::System.Type type in types)
			{
				if (typeFromHandle.IsAssignableFrom(type))
				{
					this.RegisterType(type);
				}
			}
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001D35C File Offset: 0x0001B55C
		public global::Gibraltar.Serialization.IPacketFactory GetPacketFactory(string typeName)
		{
			global::Gibraltar.Serialization.IPacketFactory result;
			if (this.m_PacketFactories.TryGetValue(typeName, out result))
			{
				return result;
			}
			return this.m_GenericFactory;
		}

		// Token: 0x04000339 RID: 825
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Serialization.IPacketFactory> m_PacketFactories;

		// Token: 0x0400033A RID: 826
		private readonly global::Gibraltar.Serialization.Internal.GenericPacketFactory m_GenericFactory;
	}
}
