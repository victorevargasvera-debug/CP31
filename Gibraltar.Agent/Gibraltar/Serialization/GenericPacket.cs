using System;

namespace Gibraltar.Serialization
{
	// Token: 0x020000F9 RID: 249
	internal sealed class GenericPacket : global::Gibraltar.Serialization.IPacket
	{
		// Token: 0x06000A5C RID: 2652 RVA: 0x00019E68 File Offset: 0x00018068
		public GenericPacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			if (definition.BasePacket != null)
			{
				this.m_BasePacket = new global::Gibraltar.Serialization.GenericPacket(definition.BasePacket, reader);
			}
			this.m_Definition = definition;
			this.m_FieldValues = new object[definition.Fields.Count];
			for (int i = 0; i < definition.Fields.Count; i++)
			{
				switch (definition.Fields[i].FieldType)
				{
				case global::Gibraltar.Serialization.FieldType.Bool:
					this.m_FieldValues[i] = reader.ReadBool();
					break;
				case global::Gibraltar.Serialization.FieldType.BoolArray:
					this.m_FieldValues[i] = reader.ReadBoolArray();
					break;
				case global::Gibraltar.Serialization.FieldType.String:
					this.m_FieldValues[i] = reader.ReadString();
					break;
				case global::Gibraltar.Serialization.FieldType.StringArray:
					this.m_FieldValues[i] = reader.ReadStringArray();
					break;
				case global::Gibraltar.Serialization.FieldType.Int32:
					this.m_FieldValues[i] = reader.ReadInt32();
					break;
				case global::Gibraltar.Serialization.FieldType.Int32Array:
					this.m_FieldValues[i] = reader.ReadInt32Array();
					break;
				case global::Gibraltar.Serialization.FieldType.Int64:
					this.m_FieldValues[i] = reader.ReadInt64();
					break;
				case global::Gibraltar.Serialization.FieldType.Int64Array:
					this.m_FieldValues[i] = reader.ReadInt64Array();
					break;
				case global::Gibraltar.Serialization.FieldType.UInt32:
					this.m_FieldValues[i] = reader.ReadUInt32();
					break;
				case global::Gibraltar.Serialization.FieldType.UInt32Array:
					this.m_FieldValues[i] = reader.ReadUInt32Array();
					break;
				case global::Gibraltar.Serialization.FieldType.UInt64:
					this.m_FieldValues[i] = reader.ReadUInt64();
					break;
				case global::Gibraltar.Serialization.FieldType.UInt64Array:
					this.m_FieldValues[i] = reader.ReadUInt64Array();
					break;
				case global::Gibraltar.Serialization.FieldType.Double:
					this.m_FieldValues[i] = reader.ReadDouble();
					break;
				case global::Gibraltar.Serialization.FieldType.DoubleArray:
					this.m_FieldValues[i] = reader.ReadDoubleArray();
					break;
				case global::Gibraltar.Serialization.FieldType.TimeSpan:
					this.m_FieldValues[i] = reader.ReadTimeSpan();
					break;
				case global::Gibraltar.Serialization.FieldType.TimeSpanArray:
					this.m_FieldValues[i] = reader.ReadTimeSpanArray();
					break;
				case global::Gibraltar.Serialization.FieldType.DateTime:
					this.m_FieldValues[i] = reader.ReadDateTime();
					break;
				case global::Gibraltar.Serialization.FieldType.DateTimeArray:
					this.m_FieldValues[i] = reader.ReadDateTimeArray();
					break;
				case global::Gibraltar.Serialization.FieldType.Guid:
					this.m_FieldValues[i] = reader.ReadGuid();
					break;
				case global::Gibraltar.Serialization.FieldType.GuidArray:
					this.m_FieldValues[i] = reader.ReadGuidArray();
					break;
				case global::Gibraltar.Serialization.FieldType.DateTimeOffset:
					this.m_FieldValues[i] = reader.ReadDateTimeOffset();
					break;
				case global::Gibraltar.Serialization.FieldType.DateTimeOffsetArray:
					this.m_FieldValues[i] = reader.ReadDateTimeOffsetArray();
					break;
				default:
					throw new global::System.InvalidOperationException(string.Format("The field type {0} is unknown so we can't deserialize the packet ", definition.Fields[i].FieldType));
				}
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0001A148 File Offset: 0x00018348
		public int Version
		{
			get
			{
				return this.m_Definition.Version;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0001A158 File Offset: 0x00018358
		public int FieldCount
		{
			get
			{
				return this.m_Definition.Fields.Count;
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0001A16C File Offset: 0x0001836C
		public int IndexOf(string fieldName)
		{
			return this.m_Definition.Fields.IndexOf(fieldName);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0001A180 File Offset: 0x00018380
		public string GetFieldName(int index)
		{
			return this.m_Definition.Fields[index].Name;
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0001A198 File Offset: 0x00018398
		public global::Gibraltar.Serialization.FieldType GetFieldType(int index)
		{
			return this.m_Definition.Fields[index].FieldType;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0001A1B0 File Offset: 0x000183B0
		public object GetFieldValue(int index)
		{
			return this.m_FieldValues[index];
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0001A1BC File Offset: 0x000183BC
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0001A1C0 File Offset: 0x000183C0
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return this.m_Definition;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0001A1C8 File Offset: 0x000183C8
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			if (this.m_BasePacket != null)
			{
				((global::Gibraltar.Serialization.IPacket)this.m_BasePacket).WriteFields(definition, packet);
			}
			for (int i = 0; i < this.m_Definition.Fields.Count; i++)
			{
				global::Gibraltar.Serialization.FieldDefinition fieldDefinition = this.m_Definition.Fields[i];
				switch (fieldDefinition.FieldType)
				{
				case global::Gibraltar.Serialization.FieldType.Bool:
					packet.SetField(fieldDefinition.Name, (bool)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.BoolArray:
					packet.SetField(fieldDefinition.Name, (bool[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.String:
					packet.SetField(fieldDefinition.Name, (string)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.StringArray:
					packet.SetField(fieldDefinition.Name, (string[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.Int32:
					packet.SetField(fieldDefinition.Name, (int)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.Int32Array:
					packet.SetField(fieldDefinition.Name, (int[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.Int64:
					packet.SetField(fieldDefinition.Name, (long)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.Int64Array:
					packet.SetField(fieldDefinition.Name, (long[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.UInt32:
					packet.SetField(fieldDefinition.Name, (uint)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.UInt32Array:
					packet.SetField(fieldDefinition.Name, (uint[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.UInt64:
					packet.SetField(fieldDefinition.Name, (ulong)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.UInt64Array:
					packet.SetField(fieldDefinition.Name, (ulong[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.Double:
					packet.SetField(fieldDefinition.Name, (double)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.DoubleArray:
					packet.SetField(fieldDefinition.Name, (double[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.TimeSpan:
					packet.SetField(fieldDefinition.Name, (global::System.TimeSpan)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.TimeSpanArray:
					packet.SetField(fieldDefinition.Name, (global::System.TimeSpan[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.DateTime:
					packet.SetField(fieldDefinition.Name, (global::System.DateTime)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.DateTimeArray:
					packet.SetField(fieldDefinition.Name, (global::System.DateTime[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.Guid:
					packet.SetField(fieldDefinition.Name, (global::System.Guid)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.GuidArray:
					packet.SetField(fieldDefinition.Name, (global::System.Guid[])this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.DateTimeOffset:
					packet.SetField(fieldDefinition.Name, (global::System.DateTimeOffset)this.m_FieldValues[i]);
					break;
				case global::Gibraltar.Serialization.FieldType.DateTimeOffsetArray:
					packet.SetField(fieldDefinition.Name, (global::System.DateTimeOffset[])this.m_FieldValues[i]);
					break;
				default:
					throw new global::System.InvalidOperationException(string.Format("The field type {0} is unknown so we can't serialize the packet ", definition.Fields[i].FieldType));
				}
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0001A57C File Offset: 0x0001877C
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040002E6 RID: 742
		private readonly global::Gibraltar.Serialization.PacketDefinition m_Definition;

		// Token: 0x040002E7 RID: 743
		private readonly object[] m_FieldValues;

		// Token: 0x040002E8 RID: 744
		private readonly global::Gibraltar.Serialization.GenericPacket m_BasePacket;
	}
}
