using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000404 RID: 1028
	internal sealed class DataRecordObjectView : global::System.Data.Entity.Core.Objects.ObjectView<global::System.Data.Common.DbDataRecord>, global::System.ComponentModel.ITypedList
	{
		// Token: 0x06002FEF RID: 12271 RVA: 0x000968A0 File Offset: 0x00094AA0
		internal DataRecordObjectView(global::System.Data.Entity.Core.Objects.IObjectViewData<global::System.Data.Common.DbDataRecord> viewData, object eventDataSource, global::System.Data.Entity.Core.Metadata.Edm.RowType rowType, global::System.Type propertyComponentType) : base(viewData, eventDataSource)
		{
			if (!typeof(global::System.Data.IDataRecord).IsAssignableFrom(propertyComponentType))
			{
				propertyComponentType = typeof(global::System.Data.IDataRecord);
			}
			this._rowType = rowType;
			this._propertyDescriptorsCache = global::System.Data.Entity.Core.Objects.MaterializedDataRecord.CreatePropertyDescriptorCollection(this._rowType, propertyComponentType, true);
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x000968F0 File Offset: 0x00094AF0
		private static global::System.Reflection.PropertyInfo GetTypedIndexer(global::System.Type type)
		{
			global::System.Reflection.PropertyInfo propertyInfo = null;
			if (typeof(global::System.Collections.IList).IsAssignableFrom(type) || typeof(global::System.ComponentModel.ITypedList).IsAssignableFrom(type) || typeof(global::System.ComponentModel.IListSource).IsAssignableFrom(type))
			{
				foreach (global::System.Reflection.PropertyInfo propertyInfo2 in from p in type.GetInstanceProperties()
				where p.IsPublic()
				select p)
				{
					if (propertyInfo2.GetIndexParameters().Length != 0 && propertyInfo2.PropertyType != typeof(object))
					{
						propertyInfo = propertyInfo2;
						if (propertyInfo.Name == "Item")
						{
							break;
						}
					}
				}
			}
			return propertyInfo;
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x000969CC File Offset: 0x00094BCC
		private static global::System.Type GetListItemType(global::System.Type type)
		{
			global::System.Type result;
			if (typeof(global::System.Array).IsAssignableFrom(type))
			{
				result = type.GetElementType();
			}
			else
			{
				global::System.Reflection.PropertyInfo typedIndexer = global::System.Data.Entity.Core.Objects.DataRecordObjectView.GetTypedIndexer(type);
				if (typedIndexer != null)
				{
					result = typedIndexer.PropertyType;
				}
				else
				{
					result = type;
				}
			}
			return result;
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x00096A10 File Offset: 0x00094C10
		global::System.ComponentModel.PropertyDescriptorCollection global::System.ComponentModel.ITypedList.GetItemProperties(global::System.ComponentModel.PropertyDescriptor[] listAccessors)
		{
			global::System.ComponentModel.PropertyDescriptorCollection result;
			if (listAccessors == null || listAccessors.Length == 0)
			{
				result = this._propertyDescriptorsCache;
			}
			else
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = listAccessors[listAccessors.Length - 1];
				global::System.Data.Entity.Core.Objects.FieldDescriptor fieldDescriptor = propertyDescriptor as global::System.Data.Entity.Core.Objects.FieldDescriptor;
				if (fieldDescriptor != null && fieldDescriptor.EdmProperty != null && fieldDescriptor.EdmProperty.TypeUsage.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
				{
					result = global::System.Data.Entity.Core.Objects.MaterializedDataRecord.CreatePropertyDescriptorCollection((global::System.Data.Entity.Core.Metadata.Edm.RowType)fieldDescriptor.EdmProperty.TypeUsage.EdmType, typeof(global::System.Data.IDataRecord), true);
				}
				else
				{
					result = global::System.ComponentModel.TypeDescriptor.GetProperties(global::System.Data.Entity.Core.Objects.DataRecordObjectView.GetListItemType(propertyDescriptor.PropertyType));
				}
			}
			return result;
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00096A9A File Offset: 0x00094C9A
		string global::System.ComponentModel.ITypedList.GetListName(global::System.ComponentModel.PropertyDescriptor[] listAccessors)
		{
			return this._rowType.Name;
		}

		// Token: 0x0400101D RID: 4125
		private readonly global::System.ComponentModel.PropertyDescriptorCollection _propertyDescriptorsCache;

		// Token: 0x0400101E RID: 4126
		private readonly global::System.Data.Entity.Core.Metadata.Edm.RowType _rowType;
	}
}
