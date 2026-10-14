using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000439 RID: 1081
	internal class ComplexTypeMaterializer
	{
		// Token: 0x060034DD RID: 13533 RVA: 0x000A8DB1 File Offset: 0x000A6FB1
		internal ComplexTypeMaterializer(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			this._workspace = workspace;
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x000A8DC0 File Offset: 0x000A6FC0
		internal object CreateComplex(global::System.Data.Entity.Core.IExtendedDataRecord record, global::System.Data.Entity.Core.Common.DataRecordInfo recordInfo, object result)
		{
			global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.Plan plan = this.GetPlan(recordInfo);
			if (result == null)
			{
				result = plan.ClrType();
			}
			this.SetProperties(record, result, plan.Properties);
			return result;
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x000A8DF4 File Offset: 0x000A6FF4
		private void SetProperties(global::System.Data.Entity.Core.IExtendedDataRecord record, object result, global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.PlanEdmProperty[] properties)
		{
			for (int i = 0; i < properties.Length; i++)
			{
				if (properties[i].GetExistingComplex != null)
				{
					object obj = properties[i].GetExistingComplex(result);
					object arg = this.CreateComplexRecursive(record.GetValue(properties[i].Ordinal), obj);
					if (obj == null)
					{
						properties[i].ClrProperty(result, arg);
					}
				}
				else
				{
					properties[i].ClrProperty(result, global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.ConvertDBNull(record.GetValue(properties[i].Ordinal)));
				}
			}
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000A8E91 File Offset: 0x000A7091
		private static object ConvertDBNull(object value)
		{
			if (global::System.DBNull.Value == value)
			{
				return null;
			}
			return value;
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x000A8E9E File Offset: 0x000A709E
		private object CreateComplexRecursive(object record, object existing)
		{
			if (global::System.DBNull.Value == record)
			{
				return existing;
			}
			return this.CreateComplexRecursive((global::System.Data.Entity.Core.IExtendedDataRecord)record, existing);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x000A8EB7 File Offset: 0x000A70B7
		private object CreateComplexRecursive(global::System.Data.Entity.Core.IExtendedDataRecord record, object existing)
		{
			return this.CreateComplex(record, record.DataRecordInfo, existing);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x000A8EC8 File Offset: 0x000A70C8
		private global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.Plan GetPlan(global::System.Data.Entity.Core.Common.DataRecordInfo recordInfo)
		{
			global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.Plan[] array;
			if ((array = this._lastPlans) == null)
			{
				array = (this._lastPlans = new global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.Plan[4]);
			}
			global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.Plan[] array2 = array;
			int num = this._lastPlanIndex - 1;
			for (int i = 0; i < 4; i++)
			{
				num = (num + 1) % 4;
				if (array2[num] == null)
				{
					break;
				}
				if (array2[num].Key == recordInfo.RecordType)
				{
					this._lastPlanIndex = num;
					return array2[num];
				}
			}
			global::System.Data.Entity.Core.Mapping.ObjectTypeMapping objectMapping = global::System.Data.Entity.Core.Metadata.Edm.Util.GetObjectMapping(recordInfo.RecordType.EdmType, this._workspace);
			this._lastPlanIndex = num;
			array2[num] = new global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.Plan(recordInfo.RecordType, objectMapping, recordInfo.FieldMetadata);
			return array2[num];
		}

		// Token: 0x04001103 RID: 4355
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _workspace;

		// Token: 0x04001104 RID: 4356
		private const int MaxPlanCount = 4;

		// Token: 0x04001105 RID: 4357
		private global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.Plan[] _lastPlans;

		// Token: 0x04001106 RID: 4358
		private int _lastPlanIndex;

		// Token: 0x02000A43 RID: 2627
		private sealed class Plan
		{
			// Token: 0x06006186 RID: 24966 RVA: 0x0014EF90 File Offset: 0x0014D190
			internal Plan(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage key, global::System.Data.Entity.Core.Mapping.ObjectTypeMapping mapping, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.FieldMetadata> fields)
			{
				this.Key = key;
				this.ClrType = global::System.Data.Entity.Core.Objects.DelegateFactory.GetConstructorDelegateForType((global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType)mapping.ClrType);
				this.Properties = new global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.PlanEdmProperty[fields.Count];
				for (int i = 0; i < this.Properties.Length; i++)
				{
					global::System.Data.Entity.Core.Common.FieldMetadata fieldMetadata = fields[i];
					int ordinal = fieldMetadata.Ordinal;
					this.Properties[i] = new global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.PlanEdmProperty(ordinal, mapping.GetPropertyMap(fieldMetadata.FieldType.Name).ClrProperty);
				}
			}

			// Token: 0x04002A3E RID: 10814
			internal readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Key;

			// Token: 0x04002A3F RID: 10815
			internal readonly global::System.Func<object> ClrType;

			// Token: 0x04002A40 RID: 10816
			internal readonly global::System.Data.Entity.Core.Objects.Internal.ComplexTypeMaterializer.PlanEdmProperty[] Properties;
		}

		// Token: 0x02000A44 RID: 2628
		private struct PlanEdmProperty
		{
			// Token: 0x06006187 RID: 24967 RVA: 0x0014F01F File Offset: 0x0014D21F
			internal PlanEdmProperty(int ordinal, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
			{
				this.Ordinal = ordinal;
				this.GetExistingComplex = (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsComplexType(property.TypeUsage.EdmType) ? global::System.Data.Entity.Core.Objects.DelegateFactory.GetGetterDelegateForProperty(property) : null);
				this.ClrProperty = global::System.Data.Entity.Core.Objects.DelegateFactory.GetSetterDelegateForProperty(property);
			}

			// Token: 0x04002A41 RID: 10817
			internal readonly int Ordinal;

			// Token: 0x04002A42 RID: 10818
			internal readonly global::System.Func<object, object> GetExistingComplex;

			// Token: 0x04002A43 RID: 10819
			internal readonly global::System.Action<object, object> ClrProperty;
		}
	}
}
