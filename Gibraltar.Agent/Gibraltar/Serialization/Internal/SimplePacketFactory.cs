using System;
using System.Collections.Generic;
using System.Reflection;

namespace Gibraltar.Serialization.Internal
{
	// Token: 0x02000115 RID: 277
	internal class SimplePacketFactory : global::Gibraltar.Serialization.IPacketFactory
	{
		// Token: 0x06000B8C RID: 2956 RVA: 0x0001D45C File Offset: 0x0001B65C
		public SimplePacketFactory(global::System.Type type)
		{
			if (!typeof(global::Gibraltar.Serialization.IPacket).IsAssignableFrom(type))
			{
				global::Gibraltar.ErrorNotifier.Notify(this, new global::System.ArgumentException("SimplePacketFactory constructor requires a type that implements IPacket"));
				return;
			}
			this.m_Constructor = type.GetConstructor(global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.InvokeMethod, null, new global::System.Type[0], null);
			if (this.m_Constructor == null)
			{
				global::Gibraltar.ErrorNotifier.Notify(this, new global::System.ArgumentException("SimplePacketFactory is only compatible with IPacket objects that have a default constructor"));
				return;
			}
			this.m_ReadMethods = new global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>();
			while (typeof(global::Gibraltar.Serialization.IPacket).IsAssignableFrom(type))
			{
				global::System.Reflection.MethodInfo method = type.GetMethod("ReadFields", global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.InvokeMethod, null, new global::System.Type[]
				{
					typeof(global::Gibraltar.Serialization.PacketDefinition),
					typeof(global::Gibraltar.Serialization.IFieldReader)
				}, new global::System.Reflection.ParameterModifier[0]);
				this.m_ReadMethods.Add(method);
				type = type.BaseType;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0001D53C File Offset: 0x0001B73C
		public bool IsValid
		{
			get
			{
				return this.m_Constructor != null && this.m_ReadMethods != null;
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0001D554 File Offset: 0x0001B754
		public global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			global::Gibraltar.Serialization.IPacket packet = (global::Gibraltar.Serialization.IPacket)this.m_Constructor.Invoke(new object[0]);
			definition.ReadFields(packet, reader);
			return packet;
		}

		// Token: 0x0400033E RID: 830
		private readonly global::System.Reflection.ConstructorInfo m_Constructor;

		// Token: 0x0400033F RID: 831
		private readonly global::System.Collections.Generic.List<global::System.Reflection.MethodInfo> m_ReadMethods;
	}
}
