using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;
using System.Security;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000456 RID: 1110
	internal sealed class SerializableImplementor
	{
		// Token: 0x0600363A RID: 13882 RVA: 0x000ADD70 File Offset: 0x000ABF70
		internal SerializableImplementor(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			this._baseClrType = ospaceEntityType.ClrType;
			this._baseImplementsISerializable = (this._baseClrType.IsSerializable() && typeof(global::System.Runtime.Serialization.ISerializable).IsAssignableFrom(this._baseClrType));
			if (this._baseImplementsISerializable)
			{
				global::System.Reflection.InterfaceMapping interfaceMap = this._baseClrType.GetInterfaceMap(typeof(global::System.Runtime.Serialization.ISerializable));
				this._getObjectDataMethod = interfaceMap.TargetMethods[0];
				if (this._getObjectDataMethod.IsVirtual && !this._getObjectDataMethod.IsFinal && this._getObjectDataMethod.IsPublic)
				{
					this._serializationConstructor = this._baseClrType.GetDeclaredConstructor((global::System.Reflection.ConstructorInfo c) => c.IsPublic || c.IsFamily || c.IsFamilyOrAssembly, new global::System.Type[][]
					{
						new global::System.Type[]
						{
							typeof(global::System.Runtime.Serialization.SerializationInfo),
							typeof(global::System.Runtime.Serialization.StreamingContext)
						},
						new global::System.Type[]
						{
							typeof(global::System.Runtime.Serialization.SerializationInfo),
							typeof(object)
						},
						new global::System.Type[]
						{
							typeof(object),
							typeof(global::System.Runtime.Serialization.StreamingContext)
						},
						new global::System.Type[]
						{
							typeof(object),
							typeof(object)
						}
					});
					this._canOverride = (this._serializationConstructor != null);
				}
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x000ADEEA File Offset: 0x000AC0EA
		internal bool TypeIsSuitable
		{
			get
			{
				return !this._baseImplementsISerializable || this._canOverride;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x0600363C RID: 13884 RVA: 0x000ADEFC File Offset: 0x000AC0FC
		internal bool TypeImplementsISerializable
		{
			get
			{
				return this._baseImplementsISerializable;
			}
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x000ADF04 File Offset: 0x000AC104
		internal void Implement(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Collections.Generic.IEnumerable<global::System.Reflection.Emit.FieldBuilder> serializedFields)
		{
			if (this._baseImplementsISerializable && this._canOverride)
			{
				global::System.Type[] parameterTypes = new global::System.Type[]
				{
					typeof(global::System.Runtime.Serialization.SerializationInfo),
					typeof(global::System.Runtime.Serialization.StreamingContext)
				};
				global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod(this._getObjectDataMethod.Name, global::System.Reflection.MethodAttributes.FamANDAssem | global::System.Reflection.MethodAttributes.Family | global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig, null, parameterTypes);
				methodBuilder.SetCustomAttribute(new global::System.Reflection.Emit.CustomAttributeBuilder(typeof(global::System.Security.SecurityCriticalAttribute).GetDeclaredConstructor(new global::System.Type[0]), new object[0]));
				global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
				foreach (global::System.Reflection.Emit.FieldBuilder fieldBuilder in serializedFields)
				{
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, fieldBuilder.Name);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, fieldBuilder);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldtoken, fieldBuilder.FieldType);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, global::System.Data.Entity.Core.Objects.Internal.SerializableImplementor.GetTypeFromHandleMethod);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.SerializableImplementor.AddValueMethod);
				}
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_2);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, this._getObjectDataMethod);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
				global::System.Reflection.MethodAttributes methodAttributes = global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.SpecialName | global::System.Reflection.MethodAttributes.RTSpecialName;
				methodAttributes |= (this._serializationConstructor.IsPublic ? global::System.Reflection.MethodAttributes.Public : global::System.Reflection.MethodAttributes.Private);
				global::System.Reflection.Emit.ILGenerator ilgenerator2 = typeBuilder.DefineConstructor(methodAttributes, global::System.Reflection.CallingConventions.Standard | global::System.Reflection.CallingConventions.HasThis, parameterTypes).GetILGenerator();
				ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
				ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_2);
				ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Call, this._serializationConstructor);
				foreach (global::System.Reflection.Emit.FieldBuilder fieldBuilder2 in serializedFields)
				{
					ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
					ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
					ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, fieldBuilder2.Name);
					ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldtoken, fieldBuilder2.FieldType);
					ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Call, global::System.Data.Entity.Core.Objects.Internal.SerializableImplementor.GetTypeFromHandleMethod);
					ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.SerializableImplementor.GetValueMethod);
					ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Castclass, fieldBuilder2.FieldType);
					ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Stfld, fieldBuilder2);
				}
				ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			}
		}

		// Token: 0x04001182 RID: 4482
		private readonly global::System.Type _baseClrType;

		// Token: 0x04001183 RID: 4483
		private readonly bool _baseImplementsISerializable;

		// Token: 0x04001184 RID: 4484
		private readonly bool _canOverride;

		// Token: 0x04001185 RID: 4485
		private readonly global::System.Reflection.MethodInfo _getObjectDataMethod;

		// Token: 0x04001186 RID: 4486
		private readonly global::System.Reflection.ConstructorInfo _serializationConstructor;

		// Token: 0x04001187 RID: 4487
		internal static readonly global::System.Reflection.MethodInfo GetTypeFromHandleMethod = typeof(global::System.Type).GetDeclaredMethod("GetTypeFromHandle", new global::System.Type[]
		{
			typeof(global::System.RuntimeTypeHandle)
		});

		// Token: 0x04001188 RID: 4488
		internal static readonly global::System.Reflection.MethodInfo AddValueMethod = typeof(global::System.Runtime.Serialization.SerializationInfo).GetDeclaredMethod("AddValue", new global::System.Type[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		});

		// Token: 0x04001189 RID: 4489
		internal static readonly global::System.Reflection.MethodInfo GetValueMethod = typeof(global::System.Runtime.Serialization.SerializationInfo).GetDeclaredMethod("GetValue", new global::System.Type[]
		{
			typeof(string),
			typeof(global::System.Type)
		});
	}
}
