using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Gibraltar.Serialization
{
	// Token: 0x02000105 RID: 261
	internal sealed class PacketDefinition : global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.FieldDefinition>, global::System.Collections.IEnumerable, global::System.IEquatable<global::Gibraltar.Serialization.PacketDefinition>
	{
		// Token: 0x06000ACC RID: 2764 RVA: 0x0001A8D8 File Offset: 0x00018AD8
		public static global::Gibraltar.Serialization.PacketDefinition CreatePacketDefinition(global::Gibraltar.Serialization.IPacket packet)
		{
			global::System.Collections.Generic.Stack<global::Gibraltar.Serialization.PacketDefinition> stack = new global::System.Collections.Generic.Stack<global::Gibraltar.Serialization.PacketDefinition>();
			global::System.Type type = packet.GetType();
			while (typeof(global::Gibraltar.Serialization.IPacket).IsAssignableFrom(type))
			{
				global::System.Reflection.MethodInfo ipacketMethod = global::Gibraltar.Serialization.PacketDefinition.GetIPacketMethod(type, "GetPacketDefinition", global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.InvokeMethod, global::System.Type.EmptyTypes);
				global::Gibraltar.Serialization.PacketDefinition packetDefinition;
				if (ipacketMethod != null)
				{
					packetDefinition = (global::Gibraltar.Serialization.PacketDefinition)ipacketMethod.Invoke(packet, new object[0]);
					packetDefinition.m_WriteMethod = global::Gibraltar.Serialization.PacketDefinition.GetIPacketMethod(type, "WriteFields", global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.InvokeMethod, new global::System.Type[]
					{
						typeof(global::Gibraltar.Serialization.PacketDefinition),
						typeof(global::Gibraltar.Serialization.SerializedPacket)
					});
					if (packetDefinition.m_WriteMethod == null)
					{
						throw new global::Gibraltar.Serialization.GibraltarSerializationException("The current packet implements part but not all of the IPacket interface.  No Write Method could be found.  Did you implement IPacket explicitly?");
					}
					if (packetDefinition.CanHaveRequiredPackets)
					{
						packetDefinition.m_GetRequiredPacketsMethod = global::Gibraltar.Serialization.PacketDefinition.GetIPacketMethod(type, "GetRequiredPackets", global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.InvokeMethod, global::System.Type.EmptyTypes);
						if (packetDefinition.m_GetRequiredPacketsMethod == null)
						{
							throw new global::Gibraltar.Serialization.GibraltarSerializationException("The current packet implements part but not all of the IPacket interface.  No GetRequiredPackets Method could be found.  Did you implement IPacket explicitly?");
						}
					}
				}
				else
				{
					packetDefinition = new global::Gibraltar.Serialization.PacketDefinition(type.Name, -1, false);
				}
				stack.Push(packetDefinition);
				type = type.BaseType;
			}
			while (stack.Count >= 2)
			{
				global::Gibraltar.Serialization.PacketDefinition basePacket = stack.Pop();
				stack.Peek().m_BasePacket = basePacket;
			}
			global::Gibraltar.Serialization.PacketDefinition packetDefinition2 = stack.Pop();
			global::Gibraltar.Serialization.IDynamicPacket dynamicPacket = packet as global::Gibraltar.Serialization.IDynamicPacket;
			if (dynamicPacket != null)
			{
				if (dynamicPacket.DynamicTypeName == null)
				{
					dynamicPacket.DynamicTypeName = global::System.Guid.NewGuid().ToString();
				}
				packetDefinition2.m_DynamicTypeName = dynamicPacket.DynamicTypeName;
			}
			packetDefinition2.m_IsCachable = (packet is global::Gibraltar.Serialization.ICachedPacket);
			return packetDefinition2;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0001AA64 File Offset: 0x00018C64
		public static global::Gibraltar.Serialization.PacketDefinition ReadPacketDefinition(global::Gibraltar.Serialization.IFieldReader reader)
		{
			bool isCachable = reader.ReadBool();
			int num = reader.ReadInt32();
			if (num < 1)
			{
				throw new global::Gibraltar.GibraltarException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "While reading the definition of the next packet, the number of types in the definition was read as {0} which is less than 1.", new object[]
				{
					num
				}));
			}
			string dynamicTypeName = reader.ReadString();
			global::Gibraltar.Serialization.PacketDefinition[] array = new global::Gibraltar.Serialization.PacketDefinition[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new global::Gibraltar.Serialization.PacketDefinition(reader);
				if (i > 0)
				{
					array[i].m_BasePacket = array[i - 1];
				}
			}
			global::Gibraltar.Serialization.PacketDefinition packetDefinition = array[num - 1];
			packetDefinition.m_IsCachable = isCachable;
			packetDefinition.m_DynamicTypeName = dynamicTypeName;
			return packetDefinition;
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0001AB14 File Offset: 0x00018D14
		// (set) Token: 0x06000ACF RID: 2767 RVA: 0x0001AB1C File Offset: 0x00018D1C
		public int PacketCount { get; set; }

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0001AB28 File Offset: 0x00018D28
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x0001AB30 File Offset: 0x00018D30
		public long PacketSize { get; set; }

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0001AB3C File Offset: 0x00018D3C
		private PacketDefinition(global::Gibraltar.Serialization.IFieldReader reader)
		{
			this.m_TypeName = reader.ReadString();
			this.m_Version = reader.ReadInt32();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				string fieldName = reader.ReadString();
				global::Gibraltar.Serialization.FieldType fieldType = (global::Gibraltar.Serialization.FieldType)reader.ReadInt32();
				this.m_Fields.Add(new global::Gibraltar.Serialization.FieldDefinition(fieldName, fieldType));
			}
			int num2 = reader.ReadInt32();
			this.m_SubPackets = new global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketDefinition>();
			for (int j = 0; j < num2; j++)
			{
				global::Gibraltar.Serialization.PacketDefinition item = global::Gibraltar.Serialization.PacketDefinition.ReadPacketDefinition(reader);
				this.m_SubPackets.Add(item);
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0001ABE8 File Offset: 0x00018DE8
		public PacketDefinition(string typeName, int version, bool canHaveRequiredPackets)
		{
			this.m_TypeName = typeName;
			this.m_Version = version;
			this.m_BasePacket = null;
			this.m_CanHaveRequiredPackets = canHaveRequiredPackets;
			this.m_SubPackets = new global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketDefinition>();
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0001AC24 File Offset: 0x00018E24
		public bool CanHaveRequiredPackets
		{
			get
			{
				return this.m_CanHaveRequiredPackets;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0001AC2C File Offset: 0x00018E2C
		public bool IsCachable
		{
			get
			{
				return this.m_IsCachable;
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0001AC34 File Offset: 0x00018E34
		public static bool IsSerializeableType(global::System.Type candidateType)
		{
			global::Gibraltar.Serialization.FieldType fieldType;
			return global::Gibraltar.Serialization.PacketDefinition.TryGetSerializableType(candidateType, out fieldType);
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0001AC50 File Offset: 0x00018E50
		public string TypeName
		{
			get
			{
				return this.m_TypeName;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0001AC58 File Offset: 0x00018E58
		public int Version
		{
			get
			{
				return this.m_Version;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0001AC60 File Offset: 0x00018E60
		public string DynamicTypeName
		{
			get
			{
				return this.m_DynamicTypeName;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0001AC68 File Offset: 0x00018E68
		public string QualifiedTypeName
		{
			get
			{
				if (this.m_DynamicTypeName == null)
				{
					return this.m_TypeName;
				}
				return this.m_TypeName + "+" + this.m_DynamicTypeName;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0001AC94 File Offset: 0x00018E94
		public global::Gibraltar.Serialization.FieldDefinitionCollection Fields
		{
			get
			{
				return this.m_Fields;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0001AC9C File Offset: 0x00018E9C
		public global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketDefinition> SubPackets
		{
			get
			{
				return this.m_SubPackets;
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0001ACA4 File Offset: 0x00018EA4
		public void WriteDefinition(global::Gibraltar.Serialization.IFieldWriter writer)
		{
			writer.Write(this.m_IsCachable);
			int nestingDepth = this.GetNestingDepth();
			writer.Write(nestingDepth);
			writer.Write(this.m_DynamicTypeName);
			this.WriteDefinitionForThisLevel(writer);
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		internal int GetNestingDepth()
		{
			if (this.m_BasePacket == null)
			{
				return 1;
			}
			return 1 + this.m_BasePacket.GetNestingDepth();
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0001AD00 File Offset: 0x00018F00
		internal global::Gibraltar.Serialization.PacketDefinition BasePacket
		{
			get
			{
				return this.m_BasePacket;
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0001AD08 File Offset: 0x00018F08
		private void WriteDefinitionForThisLevel(global::Gibraltar.Serialization.IFieldWriter writer)
		{
			if (this.m_BasePacket != null)
			{
				this.m_BasePacket.WriteDefinitionForThisLevel(writer);
			}
			writer.Write(this.m_TypeName);
			writer.Write(this.m_Version);
			writer.Write(this.m_Fields.Count);
			foreach (global::Gibraltar.Serialization.FieldDefinition fieldDefinition in this.m_Fields)
			{
				writer.Write(fieldDefinition.Name);
				writer.Write((int)fieldDefinition.FieldType);
			}
			writer.Write(this.m_SubPackets.Count);
			for (int i = 0; i < this.m_SubPackets.Count; i++)
			{
				this.m_SubPackets[i].WriteDefinition(writer);
			}
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0001ADEC File Offset: 0x00018FEC
		public static global::Gibraltar.Serialization.FieldType GetSerializableType(global::System.Type type)
		{
			global::Gibraltar.Serialization.FieldType result;
			if (!global::Gibraltar.Serialization.PacketDefinition.TryGetSerializableType(type, out result))
			{
				throw new global::System.ArgumentOutOfRangeException("type", type.FullName, "The provided type isn't supported for lossless serialization.");
			}
			return result;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0001AE24 File Offset: 0x00019024
		public static bool TryGetSerializableType(global::System.Type type, out global::Gibraltar.Serialization.FieldType bestType)
		{
			bestType = global::Gibraltar.Serialization.FieldType.Unknown;
			if (type == typeof(global::System.DateTime))
			{
				bestType = global::Gibraltar.Serialization.FieldType.DateTime;
			}
			else if (type == typeof(global::System.DateTime[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.DateTimeArray;
			}
			else if (type == typeof(global::System.DateTimeOffset))
			{
				bestType = global::Gibraltar.Serialization.FieldType.DateTimeOffset;
			}
			else if (type == typeof(global::System.DateTimeOffset[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.DateTimeOffsetArray;
			}
			else if (type == typeof(global::System.TimeSpan))
			{
				bestType = global::Gibraltar.Serialization.FieldType.TimeSpan;
			}
			else if (type == typeof(global::System.TimeSpan[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.TimeSpanArray;
			}
			else if (type == typeof(string))
			{
				bestType = global::Gibraltar.Serialization.FieldType.String;
			}
			else if (type == typeof(string[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.StringArray;
			}
			else if (type == typeof(long))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Int64;
			}
			else if (type == typeof(long[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Int64Array;
			}
			else if (type == typeof(ulong))
			{
				bestType = global::Gibraltar.Serialization.FieldType.UInt64;
			}
			else if (type == typeof(ulong[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.UInt64Array;
			}
			else if (type == typeof(int))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Int32;
			}
			else if (type == typeof(int[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Int32Array;
			}
			else if (type == typeof(uint))
			{
				bestType = global::Gibraltar.Serialization.FieldType.UInt32;
			}
			else if (type == typeof(uint[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.UInt32Array;
			}
			else if (type == typeof(short))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Int32;
			}
			else if (type == typeof(short[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Int32Array;
			}
			else if (type == typeof(ushort))
			{
				bestType = global::Gibraltar.Serialization.FieldType.UInt32;
			}
			else if (type == typeof(ushort[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.UInt32Array;
			}
			else if (type == typeof(double))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Double;
			}
			else if (type == typeof(double[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.DoubleArray;
			}
			else if (type == typeof(decimal))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Double;
			}
			else if (type == typeof(decimal[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.DoubleArray;
			}
			else if (type == typeof(float))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Double;
			}
			else if (type == typeof(float[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.DoubleArray;
			}
			else if (type == typeof(bool))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Bool;
			}
			else if (type == typeof(bool[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.BoolArray;
			}
			else if (type == typeof(global::System.Guid))
			{
				bestType = global::Gibraltar.Serialization.FieldType.Guid;
			}
			else if (type == typeof(global::System.Guid[]))
			{
				bestType = global::Gibraltar.Serialization.FieldType.GuidArray;
			}
			else
			{
				if (type.BaseType == typeof(global::System.Enum))
				{
					return global::Gibraltar.Serialization.PacketDefinition.TryGetSerializableType(global::System.Enum.GetUnderlyingType(type), out bestType);
				}
				if (type.BaseType == typeof(global::System.Enum[]))
				{
					return global::Gibraltar.Serialization.PacketDefinition.TryGetSerializableType(global::System.Enum.GetUnderlyingType(type), out bestType);
				}
			}
			return bestType != global::Gibraltar.Serialization.FieldType.Unknown;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0001B16C File Offset: 0x0001936C
		internal void WriteFields(global::Gibraltar.Serialization.IPacket packet, global::Gibraltar.Serialization.IFieldWriter writer)
		{
			if (!(packet is global::Gibraltar.Serialization.GenericPacket))
			{
				if (this.m_BasePacket != null)
				{
					this.m_BasePacket.WriteFields(packet, writer);
				}
				if (this.m_WriteMethod != null && this.m_Fields.Count > 0)
				{
					global::Gibraltar.Serialization.SerializedPacket serializedPacket = new global::Gibraltar.Serialization.SerializedPacket(this);
					this.m_WriteMethod.Invoke(packet, new object[]
					{
						this,
						serializedPacket
					});
					for (int i = 0; i < this.Fields.Count; i++)
					{
						global::Gibraltar.Serialization.FieldDefinition fieldDefinition = this.Fields[i];
						writer.Write(serializedPacket.Values[i], fieldDefinition.FieldType);
					}
				}
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001B218 File Offset: 0x00019418
		public global::System.Collections.Generic.Dictionary<global::Gibraltar.Serialization.IPacket, global::Gibraltar.Serialization.IPacket> GetRequiredPackets(global::Gibraltar.Serialization.IPacket packet)
		{
			global::System.Collections.Generic.Dictionary<global::Gibraltar.Serialization.IPacket, global::Gibraltar.Serialization.IPacket> dictionary;
			if (this.m_BasePacket != null)
			{
				dictionary = this.m_BasePacket.GetRequiredPackets(packet);
			}
			else
			{
				dictionary = new global::System.Collections.Generic.Dictionary<global::Gibraltar.Serialization.IPacket, global::Gibraltar.Serialization.IPacket>();
			}
			if (this.m_GetRequiredPacketsMethod != null)
			{
				global::Gibraltar.Serialization.IPacket[] array = (global::Gibraltar.Serialization.IPacket[])this.m_GetRequiredPacketsMethod.Invoke(packet, new object[0]);
				if (array != null && array.Length != 0)
				{
					foreach (global::Gibraltar.Serialization.IPacket packet2 in array)
					{
						if (packet2 != null && !dictionary.ContainsKey(packet2))
						{
							dictionary.Add(packet2, packet2);
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0001B2B8 File Offset: 0x000194B8
		public void ReadFields(global::Gibraltar.Serialization.IPacket packet, global::Gibraltar.Serialization.IFieldReader reader)
		{
			global::Gibraltar.Serialization.IDynamicPacket dynamicPacket = packet as global::Gibraltar.Serialization.IDynamicPacket;
			if (dynamicPacket != null)
			{
				dynamicPacket.DynamicTypeName = this.m_DynamicTypeName;
			}
			this.ReadFields(packet.GetType(), packet, reader);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0001B2F0 File Offset: 0x000194F0
		private void ReadFields(global::System.Type type, global::Gibraltar.Serialization.IPacket packet, global::Gibraltar.Serialization.IFieldReader reader)
		{
			global::System.Exception ex = null;
			if (this.m_BasePacket != null)
			{
				try
				{
					this.m_BasePacket.ReadFields(type.BaseType, packet, reader);
				}
				catch (global::System.Exception ex)
				{
				}
			}
			if (!this.m_ReadMethodAssigned)
			{
				if (typeof(global::Gibraltar.Serialization.IPacket).IsAssignableFrom(type))
				{
					this.m_ReadMethod = global::Gibraltar.Serialization.PacketDefinition.GetIPacketMethod(type, "ReadFields", global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.InvokeMethod, new global::System.Type[]
					{
						typeof(global::Gibraltar.Serialization.PacketDefinition),
						typeof(global::Gibraltar.Serialization.SerializedPacket)
					});
				}
				this.m_ReadMethodAssigned = true;
			}
			global::System.Exception ex2 = null;
			global::Gibraltar.Serialization.FieldType fieldType = global::Gibraltar.Serialization.FieldType.Unknown;
			string arg = null;
			if (this.m_ReadMethod != null)
			{
				object[] array = new object[this.Fields.Count];
				for (int i = 0; i < this.Fields.Count; i++)
				{
					global::Gibraltar.Serialization.FieldDefinition fieldDefinition = this.Fields[i];
					try
					{
						array[i] = reader.ReadField(fieldDefinition.FieldType);
					}
					catch (global::System.Exception ex3)
					{
						if (ex == null && ex2 == null)
						{
							ex2 = ex3;
							fieldType = fieldDefinition.FieldType;
							arg = fieldDefinition.Name;
						}
					}
				}
				if (ex != null)
				{
					throw new global::Gibraltar.Serialization.GibraltarSerializationException(string.Format("Error reading base {0} of a {1}", this.m_BasePacket.QualifiedTypeName, this.QualifiedTypeName), ex);
				}
				if (ex2 != null)
				{
					throw new global::Gibraltar.Serialization.GibraltarSerializationException(string.Format("Error reading ({0}) field \"{1}\" in a {2}", fieldType, arg, this.QualifiedTypeName), ex2);
				}
				global::Gibraltar.Serialization.SerializedPacket serializedPacket = new global::Gibraltar.Serialization.SerializedPacket(this, array);
				this.m_ReadMethod.Invoke(packet, new object[]
				{
					this,
					serializedPacket
				});
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0001B4A0 File Offset: 0x000196A0
		internal static global::System.Reflection.MethodInfo GetIPacketMethod(global::System.Type type, string methodName, global::System.Reflection.BindingFlags flags, global::System.Type[] methodArgTypes)
		{
			return type.GetMethod("Gibraltar.Serialization.IPacket." + methodName, flags, null, methodArgTypes, null);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0001B4B8 File Offset: 0x000196B8
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Serialization.FieldDefinition> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.FieldDefinition>.GetEnumerator()
		{
			return this.m_Fields.GetEnumerator();
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0001B4C8 File Offset: 0x000196C8
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.FieldDefinition>)this).GetEnumerator();
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001B4D0 File Offset: 0x000196D0
		public bool Equals(global::Gibraltar.Serialization.PacketDefinition other)
		{
			if (this.BasePacket == null)
			{
				if (other.BasePacket != null)
				{
					return false;
				}
			}
			else
			{
				if (other.BasePacket == null)
				{
					return false;
				}
				if (!this.BasePacket.Equals(other.BasePacket))
				{
					return false;
				}
			}
			if (this.TypeName != other.TypeName)
			{
				return false;
			}
			if (this.Version != other.Version)
			{
				return false;
			}
			if (this.Fields.Count != other.Fields.Count)
			{
				return false;
			}
			for (int i = 0; i < this.Fields.Count; i++)
			{
				if (this.Fields[i].Name != other.Fields[i].Name)
				{
					return false;
				}
				if (this.Fields[i].FieldType != other.Fields[i].FieldType)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040002EE RID: 750
		private bool m_CanHaveRequiredPackets;

		// Token: 0x040002EF RID: 751
		private bool m_IsCachable;

		// Token: 0x040002F0 RID: 752
		private readonly string m_TypeName;

		// Token: 0x040002F1 RID: 753
		private readonly int m_Version;

		// Token: 0x040002F2 RID: 754
		private string m_DynamicTypeName;

		// Token: 0x040002F3 RID: 755
		private readonly global::Gibraltar.Serialization.FieldDefinitionCollection m_Fields = new global::Gibraltar.Serialization.FieldDefinitionCollection();

		// Token: 0x040002F4 RID: 756
		private global::Gibraltar.Serialization.PacketDefinition m_BasePacket;

		// Token: 0x040002F5 RID: 757
		private global::System.Reflection.MethodInfo m_WriteMethod;

		// Token: 0x040002F6 RID: 758
		private global::System.Reflection.MethodInfo m_ReadMethod;

		// Token: 0x040002F7 RID: 759
		private global::System.Reflection.MethodInfo m_GetRequiredPacketsMethod;

		// Token: 0x040002F8 RID: 760
		private bool m_ReadMethodAssigned;

		// Token: 0x040002F9 RID: 761
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketDefinition> m_SubPackets;
	}
}
