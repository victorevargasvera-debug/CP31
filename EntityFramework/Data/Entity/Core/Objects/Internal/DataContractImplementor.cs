using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200043A RID: 1082
	internal sealed class DataContractImplementor
	{
		// Token: 0x060034E4 RID: 13540 RVA: 0x000A8F64 File Offset: 0x000A7164
		internal DataContractImplementor(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			this._baseClrType = ospaceEntityType.ClrType;
			this._dataContract = this._baseClrType.GetCustomAttributes(false).FirstOrDefault<global::System.Runtime.Serialization.DataContractAttribute>();
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x000A8F90 File Offset: 0x000A7190
		internal void Implement(global::System.Reflection.Emit.TypeBuilder typeBuilder)
		{
			if (this._dataContract != null)
			{
				object[] propertyValues = new object[]
				{
					this._dataContract.IsReference
				};
				global::System.Reflection.Emit.CustomAttributeBuilder customAttribute = new global::System.Reflection.Emit.CustomAttributeBuilder(global::System.Data.Entity.Core.Objects.Internal.DataContractImplementor.DataContractAttributeConstructor, new object[0], global::System.Data.Entity.Core.Objects.Internal.DataContractImplementor.DataContractProperties, propertyValues);
				typeBuilder.SetCustomAttribute(customAttribute);
			}
		}

		// Token: 0x04001107 RID: 4359
		internal static readonly global::System.Reflection.ConstructorInfo DataContractAttributeConstructor = typeof(global::System.Runtime.Serialization.DataContractAttribute).GetDeclaredConstructor(new global::System.Type[0]);

		// Token: 0x04001108 RID: 4360
		internal static readonly global::System.Reflection.PropertyInfo[] DataContractProperties = new global::System.Reflection.PropertyInfo[]
		{
			typeof(global::System.Runtime.Serialization.DataContractAttribute).GetDeclaredProperty("IsReference")
		};

		// Token: 0x04001109 RID: 4361
		private readonly global::System.Type _baseClrType;

		// Token: 0x0400110A RID: 4362
		private readonly global::System.Runtime.Serialization.DataContractAttribute _dataContract;
	}
}
