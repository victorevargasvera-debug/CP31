using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000428 RID: 1064
	internal static class ObjectViewFactory
	{
		// Token: 0x060033E1 RID: 13281 RVA: 0x000A6848 File Offset: 0x000A4A48
		internal static global::System.ComponentModel.IBindingList CreateViewForQuery<TElement>(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage elementEdmTypeUsage, global::System.Collections.Generic.IEnumerable<TElement> queryResults, global::System.Data.Entity.Core.Objects.ObjectContext objectContext, bool forceReadOnly, global::System.Data.Entity.Core.Metadata.Edm.EntitySet singleEntitySet)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ospaceTypeUsage = global::System.Data.Entity.Core.Objects.ObjectViewFactory.GetOSpaceTypeUsage(elementEdmTypeUsage, objectContext);
			global::System.Type type;
			if (ospaceTypeUsage == null)
			{
				type = typeof(TElement);
			}
			type = global::System.Data.Entity.Core.Objects.ObjectViewFactory.GetClrType<TElement>(ospaceTypeUsage.EdmType);
			object objectStateManager = objectContext.ObjectStateManager;
			global::System.ComponentModel.IBindingList result;
			if (type == typeof(TElement))
			{
				result = new global::System.Data.Entity.Core.Objects.ObjectView<TElement>(new global::System.Data.Entity.Core.Objects.ObjectViewQueryResultData<TElement>(queryResults, objectContext, forceReadOnly, singleEntitySet), objectStateManager);
			}
			else if (type == null)
			{
				result = new global::System.Data.Entity.Core.Objects.DataRecordObjectView(new global::System.Data.Entity.Core.Objects.ObjectViewQueryResultData<global::System.Data.Common.DbDataRecord>(queryResults, objectContext, true, null), objectStateManager, (global::System.Data.Entity.Core.Metadata.Edm.RowType)ospaceTypeUsage.EdmType, typeof(TElement));
			}
			else
			{
				if (!typeof(TElement).IsAssignableFrom(type))
				{
					throw global::System.Data.Entity.Core.EntityUtil.ValueInvalidCast(type, typeof(TElement));
				}
				global::System.Type type2 = global::System.Data.Entity.Core.Objects.ObjectViewFactory._genericObjectViewQueryResultDataType.MakeGenericType(new global::System.Type[]
				{
					type
				});
				object viewData = type2.GetDeclaredConstructor(new global::System.Type[]
				{
					typeof(global::System.Collections.IEnumerable),
					typeof(global::System.Data.Entity.Core.Objects.ObjectContext),
					typeof(bool),
					typeof(global::System.Data.Entity.Core.Metadata.Edm.EntitySet)
				}).Invoke(new object[]
				{
					queryResults,
					objectContext,
					forceReadOnly,
					singleEntitySet
				});
				result = global::System.Data.Entity.Core.Objects.ObjectViewFactory.CreateObjectView(type, type2, viewData, objectStateManager);
			}
			return result;
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x000A6988 File Offset: 0x000A4B88
		internal static global::System.ComponentModel.IBindingList CreateViewForEntityCollection<TElement>(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TElement> entityCollection) where TElement : class
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ospaceTypeUsage = global::System.Data.Entity.Core.Objects.ObjectViewFactory.GetOSpaceTypeUsage((entityType == null) ? null : global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(entityType), entityCollection.ObjectContext);
			global::System.Type type;
			if (ospaceTypeUsage == null)
			{
				type = typeof(TElement);
			}
			else
			{
				type = global::System.Data.Entity.Core.Objects.ObjectViewFactory.GetClrType<TElement>(ospaceTypeUsage.EdmType);
				if (type == null)
				{
					type = typeof(TElement);
				}
			}
			global::System.ComponentModel.IBindingList result;
			if (type == typeof(TElement))
			{
				result = new global::System.Data.Entity.Core.Objects.ObjectView<TElement>(new global::System.Data.Entity.Core.Objects.ObjectViewEntityCollectionData<TElement, TElement>(entityCollection), entityCollection);
			}
			else
			{
				if (!typeof(TElement).IsAssignableFrom(type))
				{
					throw global::System.Data.Entity.Core.EntityUtil.ValueInvalidCast(type, typeof(TElement));
				}
				global::System.Type type2 = global::System.Data.Entity.Core.Objects.ObjectViewFactory._genericObjectViewEntityCollectionDataType.MakeGenericType(new global::System.Type[]
				{
					type,
					typeof(TElement)
				});
				object viewData = type2.GetDeclaredConstructor(new global::System.Type[]
				{
					typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TElement>)
				}).Invoke(new object[]
				{
					entityCollection
				});
				result = global::System.Data.Entity.Core.Objects.ObjectViewFactory.CreateObjectView(type, type2, viewData, entityCollection);
			}
			return result;
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x000A6A7C File Offset: 0x000A4C7C
		private static global::System.ComponentModel.IBindingList CreateObjectView(global::System.Type clrElementType, global::System.Type objectViewDataType, object viewData, object eventDataSource)
		{
			global::System.Type type2 = global::System.Data.Entity.Core.Objects.ObjectViewFactory._genericObjectViewType.MakeGenericType(new global::System.Type[]
			{
				clrElementType
			});
			global::System.Type[] array = objectViewDataType.FindInterfaces((global::System.Type type, object unusedFilter) => type.Name == global::System.Data.Entity.Core.Objects.ObjectViewFactory._genericObjectViewDataInterfaceType.Name, null);
			return (global::System.ComponentModel.IBindingList)type2.GetDeclaredConstructor(new global::System.Type[]
			{
				array[0],
				typeof(object)
			}).Invoke(new object[]
			{
				viewData,
				eventDataSource
			});
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x000A6AFC File Offset: 0x000A4CFC
		private static global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetOSpaceTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage typeUsage, global::System.Data.Entity.Core.Objects.ObjectContext objectContext)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage result;
			if (typeUsage == null || typeUsage.EdmType == null)
			{
				result = null;
			}
			else if (typeUsage.EdmType.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
			{
				result = typeUsage;
			}
			else if (objectContext == null)
			{
				result = null;
			}
			else
			{
				result = objectContext.Perspective.MetadataWorkspace.GetOSpaceTypeUsage(typeUsage);
			}
			return result;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000A6B44 File Offset: 0x000A4D44
		private static global::System.Type GetClrType<TElement>(global::System.Data.Entity.Core.Metadata.Edm.EdmType ospaceEdmType)
		{
			global::System.Type type;
			if (ospaceEdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RowType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RowType rowType = (global::System.Data.Entity.Core.Metadata.Edm.RowType)ospaceEdmType;
				if (rowType.InitializerMetadata != null && rowType.InitializerMetadata.ClrType != null)
				{
					type = rowType.InitializerMetadata.ClrType;
				}
				else
				{
					global::System.Type typeFromHandle = typeof(TElement);
					if (typeof(global::System.Data.IDataRecord).IsAssignableFrom(typeFromHandle) || typeFromHandle == typeof(object))
					{
						type = null;
					}
					else
					{
						type = typeof(TElement);
					}
				}
			}
			else
			{
				type = ospaceEdmType.ClrType;
				if (type == null)
				{
					type = typeof(TElement);
				}
			}
			return type;
		}

		// Token: 0x040010C4 RID: 4292
		private static readonly global::System.Type _genericObjectViewType = typeof(global::System.Data.Entity.Core.Objects.ObjectView<>);

		// Token: 0x040010C5 RID: 4293
		private static readonly global::System.Type _genericObjectViewDataInterfaceType = typeof(global::System.Data.Entity.Core.Objects.IObjectViewData<>);

		// Token: 0x040010C6 RID: 4294
		private static readonly global::System.Type _genericObjectViewQueryResultDataType = typeof(global::System.Data.Entity.Core.Objects.ObjectViewQueryResultData<>);

		// Token: 0x040010C7 RID: 4295
		private static readonly global::System.Type _genericObjectViewEntityCollectionDataType = typeof(global::System.Data.Entity.Core.Objects.ObjectViewEntityCollectionData<, >);
	}
}
