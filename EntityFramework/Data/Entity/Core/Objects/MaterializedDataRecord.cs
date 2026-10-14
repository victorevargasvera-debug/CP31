using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000411 RID: 1041
	internal sealed class MaterializedDataRecord : global::System.Data.Common.DbDataRecord, global::System.Data.Entity.Core.IExtendedDataRecord, global::System.Data.IDataRecord, global::System.ComponentModel.ICustomTypeDescriptor
	{
		// Token: 0x06003156 RID: 12630 RVA: 0x0009C39C File Offset: 0x0009A59C
		internal MaterializedDataRecord(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage edmUsage, object[] values)
		{
			this._workspace = workspace;
			this._edmUsage = edmUsage;
			this._values = values;
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x0009C3BC File Offset: 0x0009A5BC
		public global::System.Data.Entity.Core.Common.DataRecordInfo DataRecordInfo
		{
			get
			{
				if (this._recordInfo == null)
				{
					if (this._workspace == null)
					{
						this._recordInfo = new global::System.Data.Entity.Core.Common.DataRecordInfo(this._edmUsage);
					}
					else
					{
						this._recordInfo = new global::System.Data.Entity.Core.Common.DataRecordInfo(this._workspace.GetOSpaceTypeUsage(this._edmUsage));
					}
				}
				return this._recordInfo;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x0009C40E File Offset: 0x0009A60E
		public override int FieldCount
		{
			get
			{
				return this._values.Length;
			}
		}

		// Token: 0x17000995 RID: 2453
		public override object this[int ordinal]
		{
			get
			{
				return this.GetValue(ordinal);
			}
		}

		// Token: 0x17000996 RID: 2454
		public override object this[string name]
		{
			get
			{
				return this.GetValue(this.GetOrdinal(name));
			}
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x0009C430 File Offset: 0x0009A630
		public override bool GetBoolean(int ordinal)
		{
			return (bool)this._values[ordinal];
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x0009C43F File Offset: 0x0009A63F
		public override byte GetByte(int ordinal)
		{
			return (byte)this._values[ordinal];
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x0009C450 File Offset: 0x0009A650
		public override long GetBytes(int ordinal, long fieldOffset, byte[] buffer, int bufferOffset, int length)
		{
			int num = 0;
			byte[] array = (byte[])this._values[ordinal];
			num = array.Length;
			if (fieldOffset > 2147483647L)
			{
				throw new global::System.ArgumentOutOfRangeException("fieldOffset", global::System.Data.Entity.Resources.Strings.ADP_InvalidSourceBufferIndex(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture), fieldOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			int num2 = (int)fieldOffset;
			if (buffer == null)
			{
				return (long)num;
			}
			try
			{
				if (num2 < num)
				{
					if (num2 + length > num)
					{
						num -= num2;
					}
					else
					{
						num = length;
					}
				}
				global::System.Array.Copy(array, num2, buffer, bufferOffset, num);
			}
			catch (global::System.Exception e)
			{
				if (e.IsCatchableExceptionType())
				{
					num = array.Length;
					if (length < 0)
					{
						throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataLength(((long)length).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					if (bufferOffset < 0 || bufferOffset >= buffer.Length)
					{
						throw new global::System.ArgumentOutOfRangeException("bufferOffset", global::System.Data.Entity.Resources.Strings.ADP_InvalidDestinationBufferIndex(length.ToString(global::System.Globalization.CultureInfo.InvariantCulture), bufferOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					if (fieldOffset < 0L || fieldOffset >= (long)num)
					{
						throw new global::System.ArgumentOutOfRangeException("fieldOffset", global::System.Data.Entity.Resources.Strings.ADP_InvalidSourceBufferIndex(length.ToString(global::System.Globalization.CultureInfo.InvariantCulture), fieldOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					if (num + bufferOffset > buffer.Length)
					{
						throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.ADP_InvalidBufferSizeOrIndex(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture), bufferOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
				}
				throw;
			}
			return (long)num;
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0009C5A4 File Offset: 0x0009A7A4
		public override char GetChar(int ordinal)
		{
			return ((string)this.GetValue(ordinal))[0];
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0009C5B8 File Offset: 0x0009A7B8
		public override long GetChars(int ordinal, long fieldOffset, char[] buffer, int bufferOffset, int length)
		{
			int num = 0;
			string text = (string)this._values[ordinal];
			num = text.Length;
			if (fieldOffset > 2147483647L)
			{
				throw new global::System.ArgumentOutOfRangeException("fieldOffset", global::System.Data.Entity.Resources.Strings.ADP_InvalidSourceBufferIndex(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture), fieldOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
			int num2 = (int)fieldOffset;
			if (buffer == null)
			{
				return (long)num;
			}
			try
			{
				if (num2 < num)
				{
					if (num2 + length > num)
					{
						num -= num2;
					}
					else
					{
						num = length;
					}
				}
				text.CopyTo(num2, buffer, bufferOffset, num);
			}
			catch (global::System.Exception e)
			{
				if (e.IsCatchableExceptionType())
				{
					num = text.Length;
					if (length < 0)
					{
						throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.ADP_InvalidDataLength(((long)length).ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					if (bufferOffset < 0 || bufferOffset >= buffer.Length)
					{
						throw new global::System.ArgumentOutOfRangeException("bufferOffset", global::System.Data.Entity.Resources.Strings.ADP_InvalidDestinationBufferIndex(buffer.Length.ToString(global::System.Globalization.CultureInfo.InvariantCulture), bufferOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					if (fieldOffset < 0L || fieldOffset >= (long)num)
					{
						throw new global::System.ArgumentOutOfRangeException("fieldOffset", global::System.Data.Entity.Resources.Strings.ADP_InvalidSourceBufferIndex(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture), fieldOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
					if (num + bufferOffset > buffer.Length)
					{
						throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.ADP_InvalidBufferSizeOrIndex(num.ToString(global::System.Globalization.CultureInfo.InvariantCulture), bufferOffset.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
					}
				}
				throw;
			}
			return (long)num;
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x0009C718 File Offset: 0x0009A918
		public global::System.Data.Common.DbDataRecord GetDataRecord(int ordinal)
		{
			return (global::System.Data.Common.DbDataRecord)this._values[ordinal];
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x0009C727 File Offset: 0x0009A927
		public global::System.Data.Common.DbDataReader GetDataReader(int i)
		{
			return this.GetDbDataReader(i);
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x0009C730 File Offset: 0x0009A930
		public override string GetDataTypeName(int ordinal)
		{
			return this.GetMember(ordinal).TypeUsage.EdmType.Name;
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0009C748 File Offset: 0x0009A948
		public override global::System.DateTime GetDateTime(int ordinal)
		{
			return (global::System.DateTime)this._values[ordinal];
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x0009C757 File Offset: 0x0009A957
		public override decimal GetDecimal(int ordinal)
		{
			return (decimal)this._values[ordinal];
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x0009C766 File Offset: 0x0009A966
		public override double GetDouble(int ordinal)
		{
			return (double)this._values[ordinal];
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x0009C775 File Offset: 0x0009A975
		public override global::System.Type GetFieldType(int ordinal)
		{
			return this.GetMember(ordinal).TypeUsage.EdmType.ClrType ?? typeof(object);
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x0009C79B File Offset: 0x0009A99B
		public override float GetFloat(int ordinal)
		{
			return (float)this._values[ordinal];
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x0009C7AA File Offset: 0x0009A9AA
		public override global::System.Guid GetGuid(int ordinal)
		{
			return (global::System.Guid)this._values[ordinal];
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x0009C7B9 File Offset: 0x0009A9B9
		public override short GetInt16(int ordinal)
		{
			return (short)this._values[ordinal];
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x0009C7C8 File Offset: 0x0009A9C8
		public override int GetInt32(int ordinal)
		{
			return (int)this._values[ordinal];
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x0009C7D7 File Offset: 0x0009A9D7
		public override long GetInt64(int ordinal)
		{
			return (long)this._values[ordinal];
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x0009C7E6 File Offset: 0x0009A9E6
		public override string GetName(int ordinal)
		{
			return this.GetMember(ordinal).Name;
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x0009C7F4 File Offset: 0x0009A9F4
		public override int GetOrdinal(string name)
		{
			if (this._fieldNameLookup == null)
			{
				this._fieldNameLookup = new global::System.Data.Entity.Core.FieldNameLookup(this);
			}
			return this._fieldNameLookup.GetOrdinal(name);
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x0009C816 File Offset: 0x0009AA16
		public override string GetString(int ordinal)
		{
			return (string)this._values[ordinal];
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x0009C825 File Offset: 0x0009AA25
		public override object GetValue(int ordinal)
		{
			return this._values[ordinal];
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x0009C830 File Offset: 0x0009AA30
		public override int GetValues(object[] values)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(values, "values");
			int num = global::System.Math.Min(values.Length, this.FieldCount);
			for (int i = 0; i < num; i++)
			{
				values[i] = this._values[i];
			}
			return num;
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x0009C870 File Offset: 0x0009AA70
		private global::System.Data.Entity.Core.Metadata.Edm.EdmMember GetMember(int ordinal)
		{
			return this.DataRecordInfo.FieldMetadata[ordinal].FieldType;
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x0009C896 File Offset: 0x0009AA96
		public override bool IsDBNull(int ordinal)
		{
			return global::System.DBNull.Value == this._values[ordinal];
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x0009C8A7 File Offset: 0x0009AAA7
		global::System.ComponentModel.AttributeCollection global::System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
		{
			return global::System.ComponentModel.TypeDescriptor.GetAttributes(this, true);
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x0009C8B0 File Offset: 0x0009AAB0
		string global::System.ComponentModel.ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x0009C8B3 File Offset: 0x0009AAB3
		string global::System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0009C8B8 File Offset: 0x0009AAB8
		private global::System.ComponentModel.PropertyDescriptorCollection InitializePropertyDescriptors()
		{
			if (this._values == null)
			{
				return null;
			}
			if (this._propertyDescriptors == null && this._values.Length != 0)
			{
				this._propertyDescriptors = global::System.Data.Entity.Core.Objects.MaterializedDataRecord.CreatePropertyDescriptorCollection(this.DataRecordInfo.RecordType.EdmType as global::System.Data.Entity.Core.Metadata.Edm.StructuralType, typeof(global::System.Data.Entity.Core.Objects.MaterializedDataRecord), true);
			}
			return this._propertyDescriptors;
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x0009C914 File Offset: 0x0009AB14
		internal static global::System.ComponentModel.PropertyDescriptorCollection CreatePropertyDescriptorCollection(global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType, global::System.Type componentType, bool isReadOnly)
		{
			global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor> list = new global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor>();
			if (structuralType != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in structuralType.Members)
				{
					if (edmMember.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property = (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty)edmMember;
						global::System.Data.Entity.Core.Objects.FieldDescriptor item = new global::System.Data.Entity.Core.Objects.FieldDescriptor(componentType, isReadOnly, property);
						list.Add(item);
					}
				}
			}
			return new global::System.ComponentModel.PropertyDescriptorCollection(list.ToArray());
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x0009C998 File Offset: 0x0009AB98
		global::System.ComponentModel.PropertyDescriptorCollection global::System.ComponentModel.ICustomTypeDescriptor.GetProperties()
		{
			return ((global::System.ComponentModel.ICustomTypeDescriptor)this).GetProperties(null);
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x0009C9A4 File Offset: 0x0009ABA4
		global::System.ComponentModel.PropertyDescriptorCollection global::System.ComponentModel.ICustomTypeDescriptor.GetProperties(global::System.Attribute[] attributes)
		{
			bool flag = attributes != null && attributes.Length != 0;
			global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptorCollection = this.InitializePropertyDescriptors();
			if (propertyDescriptorCollection == null)
			{
				return propertyDescriptorCollection;
			}
			global::System.Data.Entity.Core.Objects.MaterializedDataRecord.FilterCache filterCache = this._filterCache;
			if (flag && filterCache != null && filterCache.IsValid(attributes))
			{
				return filterCache.FilteredProperties;
			}
			if (!flag && propertyDescriptorCollection != null)
			{
				return propertyDescriptorCollection;
			}
			if (this._attrCache == null && attributes != null && attributes.Length != 0)
			{
				this._attrCache = new global::System.Collections.Generic.Dictionary<object, global::System.ComponentModel.AttributeCollection>();
				foreach (object obj in this._propertyDescriptors)
				{
					global::System.Data.Entity.Core.Objects.FieldDescriptor fieldDescriptor = (global::System.Data.Entity.Core.Objects.FieldDescriptor)obj;
					object[] customAttributes = fieldDescriptor.GetValue(this).GetType().GetCustomAttributes(false);
					global::System.Attribute[] array = new global::System.Attribute[customAttributes.Length];
					customAttributes.CopyTo(array, 0);
					this._attrCache.Add(fieldDescriptor, new global::System.ComponentModel.AttributeCollection(array));
				}
			}
			propertyDescriptorCollection = new global::System.ComponentModel.PropertyDescriptorCollection(null);
			foreach (object obj2 in this._propertyDescriptors)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj2;
				if (this._attrCache[propertyDescriptor].Matches(attributes))
				{
					propertyDescriptorCollection.Add(propertyDescriptor);
				}
			}
			if (flag)
			{
				this._filterCache = new global::System.Data.Entity.Core.Objects.MaterializedDataRecord.FilterCache
				{
					Attributes = attributes,
					FilteredProperties = propertyDescriptorCollection
				};
			}
			return propertyDescriptorCollection;
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x0009CB1C File Offset: 0x0009AD1C
		object global::System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(global::System.ComponentModel.PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x0400103F RID: 4159
		private global::System.Data.Entity.Core.FieldNameLookup _fieldNameLookup;

		// Token: 0x04001040 RID: 4160
		private global::System.Data.Entity.Core.Common.DataRecordInfo _recordInfo;

		// Token: 0x04001041 RID: 4161
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _workspace;

		// Token: 0x04001042 RID: 4162
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _edmUsage;

		// Token: 0x04001043 RID: 4163
		private readonly object[] _values;

		// Token: 0x04001044 RID: 4164
		private global::System.ComponentModel.PropertyDescriptorCollection _propertyDescriptors;

		// Token: 0x04001045 RID: 4165
		private global::System.Data.Entity.Core.Objects.MaterializedDataRecord.FilterCache _filterCache;

		// Token: 0x04001046 RID: 4166
		private global::System.Collections.Generic.Dictionary<object, global::System.ComponentModel.AttributeCollection> _attrCache;

		// Token: 0x02000A17 RID: 2583
		private class FilterCache
		{
			// Token: 0x0600610F RID: 24847 RVA: 0x0014C6E4 File Offset: 0x0014A8E4
			public bool IsValid(global::System.Attribute[] other)
			{
				if (other == null || this.Attributes == null)
				{
					return false;
				}
				if (this.Attributes.Length != other.Length)
				{
					return false;
				}
				for (int i = 0; i < other.Length; i++)
				{
					if (!this.Attributes[i].Match(other[i]))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x04002946 RID: 10566
			public global::System.Attribute[] Attributes;

			// Token: 0x04002947 RID: 10567
			public global::System.ComponentModel.PropertyDescriptorCollection FilteredProperties;
		}
	}
}
