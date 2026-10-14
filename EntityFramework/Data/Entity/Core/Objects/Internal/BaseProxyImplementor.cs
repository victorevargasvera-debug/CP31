using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000436 RID: 1078
	internal class BaseProxyImplementor
	{
		// Token: 0x06003489 RID: 13449 RVA: 0x000A84E0 File Offset: 0x000A66E0
		public BaseProxyImplementor()
		{
			this._baseGetters = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>();
			this._baseSetters = new global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo>();
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x0600348A RID: 13450 RVA: 0x000A84FE File Offset: 0x000A66FE
		public global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> BaseGetters
		{
			get
			{
				return this._baseGetters;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x000A8506 File Offset: 0x000A6706
		public global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> BaseSetters
		{
			get
			{
				return this._baseSetters;
			}
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x000A850E File Offset: 0x000A670E
		public void AddBasePropertyGetter(global::System.Reflection.PropertyInfo baseProperty)
		{
			this._baseGetters.Add(baseProperty);
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x000A851C File Offset: 0x000A671C
		public void AddBasePropertySetter(global::System.Reflection.PropertyInfo baseProperty)
		{
			this._baseSetters.Add(baseProperty);
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x000A852A File Offset: 0x000A672A
		public void Implement(global::System.Reflection.Emit.TypeBuilder typeBuilder)
		{
			if (this._baseGetters.Count > 0)
			{
				this.ImplementBaseGetter(typeBuilder);
			}
			if (this._baseSetters.Count > 0)
			{
				this.ImplementBaseSetter(typeBuilder);
			}
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x000A8558 File Offset: 0x000A6758
		private void ImplementBaseGetter(global::System.Reflection.Emit.TypeBuilder typeBuilder)
		{
			global::System.Reflection.Emit.ILGenerator ilgenerator = typeBuilder.DefineMethod("GetBasePropertyValue", global::System.Reflection.MethodAttributes.FamANDAssem | global::System.Reflection.MethodAttributes.Family | global::System.Reflection.MethodAttributes.HideBySig, typeof(object), new global::System.Type[]
			{
				typeof(string)
			}).GetILGenerator();
			global::System.Reflection.Emit.Label[] array = new global::System.Reflection.Emit.Label[this._baseGetters.Count];
			for (int i = 0; i < this._baseGetters.Count; i++)
			{
				array[i] = ilgenerator.DefineLabel();
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, this._baseGetters[i].Name);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, global::System.Data.Entity.Core.Objects.Internal.BaseProxyImplementor.StringEquals);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brfalse_S, array[i]);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, this._baseGetters[i].Getter());
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
				ilgenerator.MarkLabel(array[i]);
			}
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Newobj, global::System.Data.Entity.Core.Objects.Internal.BaseProxyImplementor._invalidOperationConstructor);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Throw);
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x000A8678 File Offset: 0x000A6878
		private void ImplementBaseSetter(global::System.Reflection.Emit.TypeBuilder typeBuilder)
		{
			global::System.Reflection.Emit.ILGenerator ilgenerator = typeBuilder.DefineMethod("SetBasePropertyValue", global::System.Reflection.MethodAttributes.FamANDAssem | global::System.Reflection.MethodAttributes.Family | global::System.Reflection.MethodAttributes.HideBySig, typeof(void), new global::System.Type[]
			{
				typeof(string),
				typeof(object)
			}).GetILGenerator();
			global::System.Reflection.Emit.Label[] array = new global::System.Reflection.Emit.Label[this._baseSetters.Count];
			for (int i = 0; i < this._baseSetters.Count; i++)
			{
				array[i] = ilgenerator.DefineLabel();
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, this._baseSetters[i].Name);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, global::System.Data.Entity.Core.Objects.Internal.BaseProxyImplementor.StringEquals);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brfalse_S, array[i]);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_2);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Castclass, this._baseSetters[i].PropertyType);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, this._baseSetters[i].Setter());
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
				ilgenerator.MarkLabel(array[i]);
			}
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Newobj, global::System.Data.Entity.Core.Objects.Internal.BaseProxyImplementor._invalidOperationConstructor);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Throw);
		}

		// Token: 0x040010F1 RID: 4337
		private readonly global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> _baseGetters;

		// Token: 0x040010F2 RID: 4338
		private readonly global::System.Collections.Generic.List<global::System.Reflection.PropertyInfo> _baseSetters;

		// Token: 0x040010F3 RID: 4339
		internal static readonly global::System.Reflection.MethodInfo StringEquals = typeof(string).GetDeclaredMethod("op_Equality", new global::System.Type[]
		{
			typeof(string),
			typeof(string)
		});

		// Token: 0x040010F4 RID: 4340
		private static readonly global::System.Reflection.ConstructorInfo _invalidOperationConstructor = typeof(global::System.InvalidOperationException).GetDeclaredConstructor(new global::System.Type[0]);
	}
}
