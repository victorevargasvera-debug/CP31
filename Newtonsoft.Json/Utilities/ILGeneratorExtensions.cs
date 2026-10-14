using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005B RID: 91
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class ILGeneratorExtensions
	{
		// Token: 0x06000540 RID: 1344 RVA: 0x000164D0 File Offset: 0x000146D0
		public static void PushInstance(this global::System.Reflection.Emit.ILGenerator generator, global::System.Type type)
		{
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			if (type.IsValueType())
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Unbox, type);
				return;
			}
			generator.Emit(global::System.Reflection.Emit.OpCodes.Castclass, type);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000164FE File Offset: 0x000146FE
		public static void PushArrayInstance(this global::System.Reflection.Emit.ILGenerator generator, int argsIndex, int arrayIndex)
		{
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg, argsIndex);
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldc_I4, arrayIndex);
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldelem_Ref);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00016523 File Offset: 0x00014723
		public static void BoxIfNeeded(this global::System.Reflection.Emit.ILGenerator generator, global::System.Type type)
		{
			if (type.IsValueType())
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Box, type);
				return;
			}
			generator.Emit(global::System.Reflection.Emit.OpCodes.Castclass, type);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00016546 File Offset: 0x00014746
		public static void UnboxIfNeeded(this global::System.Reflection.Emit.ILGenerator generator, global::System.Type type)
		{
			if (type.IsValueType())
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Unbox_Any, type);
				return;
			}
			generator.Emit(global::System.Reflection.Emit.OpCodes.Castclass, type);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00016569 File Offset: 0x00014769
		public static void CallMethod(this global::System.Reflection.Emit.ILGenerator generator, global::System.Reflection.MethodInfo methodInfo)
		{
			if (methodInfo.IsFinal || !methodInfo.IsVirtual)
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo);
				return;
			}
			generator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, methodInfo);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00016594 File Offset: 0x00014794
		public static void Return(this global::System.Reflection.Emit.ILGenerator generator)
		{
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
		}
	}
}
