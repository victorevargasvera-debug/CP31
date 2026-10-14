using System;
using System.Data;

namespace Gibraltar.Serialization
{
	// Token: 0x0200010E RID: 270
	internal class SerializedPacket
	{
		// Token: 0x06000B25 RID: 2853 RVA: 0x0001C454 File Offset: 0x0001A654
		internal SerializedPacket(global::Gibraltar.Serialization.PacketDefinition definition)
		{
			this.m_Definition = definition;
			this.m_Values = new object[definition.Fields.Count];
			this.m_ReadOnly = false;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0001C480 File Offset: 0x0001A680
		internal SerializedPacket(global::Gibraltar.Serialization.PacketDefinition definition, object[] values)
		{
			this.m_Definition = definition;
			this.m_Values = values;
			this.m_ReadOnly = true;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		public void GetField(string fieldName, out string value)
		{
			value = (string)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0001C4B0 File Offset: 0x0001A6B0
		public void GetField(int fieldIndex, out string value)
		{
			value = (string)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		public void GetField(string fieldName, out string[] value)
		{
			value = (string[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0001C4D4 File Offset: 0x0001A6D4
		public void GetField(int fieldIndex, out string[] value)
		{
			value = (string[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		public void GetField(string fieldName, out double value)
		{
			value = (double)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0001C4F8 File Offset: 0x0001A6F8
		public void GetField(int fieldIndex, out double value)
		{
			value = (double)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0001C50C File Offset: 0x0001A70C
		public void GetField(string fieldName, out double[] value)
		{
			value = (double[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0001C51C File Offset: 0x0001A71C
		public void GetField(int fieldIndex, out double[] value)
		{
			value = (double[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0001C530 File Offset: 0x0001A730
		public void GetField(string fieldName, out bool value)
		{
			value = (bool)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0001C540 File Offset: 0x0001A740
		public void GetField(int fieldIndex, out bool value)
		{
			value = (bool)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0001C554 File Offset: 0x0001A754
		public void GetField(string fieldName, out bool[] value)
		{
			value = (bool[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0001C564 File Offset: 0x0001A764
		public void GetField(int fieldIndex, out bool[] value)
		{
			value = (bool[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0001C578 File Offset: 0x0001A778
		public void GetField(string fieldName, out int value)
		{
			value = (int)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0001C588 File Offset: 0x0001A788
		public void GetField(int fieldIndex, out int value)
		{
			value = (int)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0001C59C File Offset: 0x0001A79C
		public void GetField(string fieldName, out int[] value)
		{
			value = (int[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0001C5AC File Offset: 0x0001A7AC
		public void GetField(int fieldIndex, out int[] value)
		{
			value = (int[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		public void GetField(string fieldName, out uint value)
		{
			value = (uint)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0001C5D0 File Offset: 0x0001A7D0
		public void GetField(int fieldIndex, out uint value)
		{
			value = (uint)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0001C5E4 File Offset: 0x0001A7E4
		public void GetField(string fieldName, out uint[] value)
		{
			value = (uint[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0001C5F4 File Offset: 0x0001A7F4
		public void GetField(int fieldIndex, out uint[] value)
		{
			value = (uint[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0001C608 File Offset: 0x0001A808
		public void GetField(string fieldName, out long value)
		{
			value = (long)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0001C618 File Offset: 0x0001A818
		public void GetField(int fieldIndex, out long value)
		{
			value = (long)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0001C62C File Offset: 0x0001A82C
		public void GetField(string fieldName, out long[] value)
		{
			value = (long[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0001C63C File Offset: 0x0001A83C
		public void GetField(int fieldIndex, out long[] value)
		{
			value = (long[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0001C650 File Offset: 0x0001A850
		public void GetField(string fieldName, out ulong value)
		{
			value = (ulong)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0001C660 File Offset: 0x0001A860
		public void GetField(int fieldIndex, out ulong value)
		{
			value = (ulong)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0001C674 File Offset: 0x0001A874
		public void GetField(string fieldName, out ulong[] value)
		{
			value = (ulong[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0001C684 File Offset: 0x0001A884
		public void GetField(int fieldIndex, out ulong[] value)
		{
			value = (ulong[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0001C698 File Offset: 0x0001A898
		public void GetField(string fieldName, out global::System.TimeSpan value)
		{
			value = (global::System.TimeSpan)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0001C6AC File Offset: 0x0001A8AC
		public void GetField(int fieldIndex, out global::System.TimeSpan value)
		{
			value = (global::System.TimeSpan)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0001C6C4 File Offset: 0x0001A8C4
		public void GetField(string fieldName, out global::System.TimeSpan[] value)
		{
			value = (global::System.TimeSpan[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		public void GetField(int fieldIndex, out global::System.TimeSpan[] value)
		{
			value = (global::System.TimeSpan[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0001C6E8 File Offset: 0x0001A8E8
		public void GetField(string fieldName, out global::System.DateTime value)
		{
			value = (global::System.DateTime)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0001C6FC File Offset: 0x0001A8FC
		public void GetField(int fieldIndex, out global::System.DateTime value)
		{
			value = (global::System.DateTime)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0001C714 File Offset: 0x0001A914
		public void GetField(string fieldName, out global::System.DateTime[] value)
		{
			value = (global::System.DateTime[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0001C724 File Offset: 0x0001A924
		public void GetField(int fieldIndex, out global::System.DateTime[] value)
		{
			value = (global::System.DateTime[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0001C738 File Offset: 0x0001A938
		public void GetField(string fieldName, out global::System.DateTimeOffset value)
		{
			value = (global::System.DateTimeOffset)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0001C74C File Offset: 0x0001A94C
		public void GetField(int fieldIndex, out global::System.DateTimeOffset value)
		{
			value = (global::System.DateTimeOffset)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0001C764 File Offset: 0x0001A964
		public void GetField(string fieldName, out global::System.DateTimeOffset[] value)
		{
			value = (global::System.DateTimeOffset[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0001C774 File Offset: 0x0001A974
		public void GetField(int fieldIndex, out global::System.DateTimeOffset[] value)
		{
			value = (global::System.DateTimeOffset[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0001C788 File Offset: 0x0001A988
		public void GetField(string fieldName, out global::System.Guid value)
		{
			value = (global::System.Guid)this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0001C79C File Offset: 0x0001A99C
		public void GetField(int fieldIndex, out global::System.Guid value)
		{
			value = (global::System.Guid)this.m_Values[fieldIndex];
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
		public void GetField(string fieldName, out global::System.Guid[] value)
		{
			value = (global::System.Guid[])this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0001C7C4 File Offset: 0x0001A9C4
		public void GetField(int fieldIndex, out global::System.Guid[] value)
		{
			value = (global::System.Guid[])this.m_Values[fieldIndex];
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
		public void GetField(string fieldName, out object value)
		{
			value = this.GetFieldValue(fieldName);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
		public void GetField(int fieldIndex, out object value)
		{
			value = this.m_Values[fieldIndex];
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
		public void SetField(string fieldName, object value)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				throw new global::System.ArgumentNullException("fieldName");
			}
			if (this.m_ReadOnly)
			{
				throw new global::System.Data.ReadOnlyException("The packet has been deserialized and is read-only");
			}
			global::Gibraltar.Serialization.FieldDefinition fieldDefinition = this.m_Definition.Fields[fieldName];
			int num = this.m_Definition.Fields.IndexOf(fieldDefinition);
			if (value != null)
			{
				global::Gibraltar.Serialization.FieldType serializableType = global::Gibraltar.Serialization.PacketDefinition.GetSerializableType(value.GetType());
				if (!fieldDefinition.IsCompatible(serializableType))
				{
					throw new global::System.ArgumentException("The provided value's type doesn't match the definition for the field.", "value");
				}
			}
			this.m_Values[num] = value;
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0001C888 File Offset: 0x0001AA88
		internal object[] Values
		{
			get
			{
				return this.m_Values;
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0001C890 File Offset: 0x0001AA90
		internal object GetFieldValue(string fieldName)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				throw new global::System.ArgumentNullException("fieldName");
			}
			int num = this.m_Definition.Fields.IndexOf(fieldName);
			return this.m_Values[num];
		}

		// Token: 0x0400031D RID: 797
		private readonly global::Gibraltar.Serialization.PacketDefinition m_Definition;

		// Token: 0x0400031E RID: 798
		private readonly object[] m_Values;

		// Token: 0x0400031F RID: 799
		private readonly bool m_ReadOnly;
	}
}
