using System;
using System.Globalization;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000051 RID: 81
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class DynamicReflectionDelegateFactory : global::Newtonsoft.Json.Utilities.ReflectionDelegateFactory
	{
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00014837 File Offset: 0x00012A37
		internal static global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory Instance { get; } = new global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory();

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001483E File Offset: 0x00012A3E
		private static global::System.Reflection.Emit.DynamicMethod CreateDynamicMethod(string name, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Type returnType, global::System.Type[] parameterTypes, global::System.Type owner)
		{
			if (owner.IsInterface())
			{
				return new global::System.Reflection.Emit.DynamicMethod(name, returnType, parameterTypes, owner.Module, true);
			}
			return new global::System.Reflection.Emit.DynamicMethod(name, returnType, parameterTypes, owner, true);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00014864 File Offset: 0x00012A64
		public override global::Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(global::System.Reflection.MethodBase method)
		{
			global::System.Reflection.Emit.DynamicMethod dynamicMethod = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDynamicMethod(method.ToString(), typeof(object), new global::System.Type[]
			{
				typeof(object[])
			}, method.DeclaringType);
			global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateMethodCallIL(method, ilgenerator, 0);
			return (global::Newtonsoft.Json.Serialization.ObjectConstructor<object>)dynamicMethod.CreateDelegate(typeof(global::Newtonsoft.Json.Serialization.ObjectConstructor<object>));
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000148C4 File Offset: 0x00012AC4
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.MethodBase method)
		{
			global::System.Reflection.Emit.DynamicMethod dynamicMethod = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDynamicMethod(method.ToString(), typeof(object), new global::System.Type[]
			{
				typeof(object),
				typeof(object[])
			}, method.DeclaringType);
			global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateMethodCallIL(method, ilgenerator, 1);
			return (global::Newtonsoft.Json.Utilities.MethodCall<T, object>)dynamicMethod.CreateDelegate(typeof(global::Newtonsoft.Json.Utilities.MethodCall<T, object>));
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00014930 File Offset: 0x00012B30
		private void GenerateCreateMethodCallIL(global::System.Reflection.MethodBase method, global::System.Reflection.Emit.ILGenerator generator, int argsIndex)
		{
			global::System.Reflection.ParameterInfo[] parameters = method.GetParameters();
			global::System.Reflection.Emit.Label label = generator.DefineLabel();
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg, argsIndex);
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldlen);
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldc_I4, parameters.Length);
			generator.Emit(global::System.Reflection.Emit.OpCodes.Beq, label);
			generator.Emit(global::System.Reflection.Emit.OpCodes.Newobj, typeof(global::System.Reflection.TargetParameterCountException).GetConstructor(global::Newtonsoft.Json.Utilities.ReflectionUtils.EmptyTypes));
			generator.Emit(global::System.Reflection.Emit.OpCodes.Throw);
			generator.MarkLabel(label);
			if (!method.IsConstructor && !method.IsStatic)
			{
				generator.PushInstance(method.DeclaringType);
			}
			global::System.Reflection.Emit.LocalBuilder local = generator.DeclareLocal(typeof(global::System.IConvertible));
			global::System.Reflection.Emit.LocalBuilder local2 = generator.DeclareLocal(typeof(object));
			global::System.Reflection.Emit.OpCode opcode = (parameters.Length < 256) ? global::System.Reflection.Emit.OpCodes.Ldloca_S : global::System.Reflection.Emit.OpCodes.Ldloca;
			global::System.Reflection.Emit.OpCode opcode2 = (parameters.Length < 256) ? global::System.Reflection.Emit.OpCodes.Ldloc_S : global::System.Reflection.Emit.OpCodes.Ldloc;
			for (int i = 0; i < parameters.Length; i++)
			{
				global::System.Reflection.ParameterInfo parameterInfo = parameters[i];
				global::System.Type type = parameterInfo.ParameterType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					global::System.Reflection.Emit.LocalBuilder local3 = generator.DeclareLocal(type);
					if (!parameterInfo.IsOut)
					{
						generator.PushArrayInstance(argsIndex, i);
						if (type.IsValueType())
						{
							global::System.Reflection.Emit.Label label2 = generator.DefineLabel();
							global::System.Reflection.Emit.Label label3 = generator.DefineLabel();
							generator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue_S, label2);
							generator.Emit(opcode, local3);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Initobj, type);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Br_S, label3);
							generator.MarkLabel(label2);
							generator.PushArrayInstance(argsIndex, i);
							generator.UnboxIfNeeded(type);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Stloc_S, local3);
							generator.MarkLabel(label3);
						}
						else
						{
							generator.UnboxIfNeeded(type);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Stloc_S, local3);
						}
					}
					generator.Emit(opcode, local3);
				}
				else if (type.IsValueType())
				{
					generator.PushArrayInstance(argsIndex, i);
					generator.Emit(global::System.Reflection.Emit.OpCodes.Stloc_S, local2);
					global::System.Reflection.Emit.Label label4 = generator.DefineLabel();
					global::System.Reflection.Emit.Label label5 = generator.DefineLabel();
					generator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_S, local2);
					generator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue_S, label4);
					global::System.Reflection.Emit.LocalBuilder local4 = generator.DeclareLocal(type);
					generator.Emit(opcode, local4);
					generator.Emit(global::System.Reflection.Emit.OpCodes.Initobj, type);
					generator.Emit(opcode2, local4);
					generator.Emit(global::System.Reflection.Emit.OpCodes.Br_S, label5);
					generator.MarkLabel(label4);
					if (type.IsPrimitive())
					{
						global::System.Reflection.MethodInfo method2 = typeof(global::System.IConvertible).GetMethod("To" + type.Name, new global::System.Type[]
						{
							typeof(global::System.IFormatProvider)
						});
						if (method2 != null)
						{
							global::System.Reflection.Emit.Label label6 = generator.DefineLabel();
							generator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_S, local2);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Isinst, type);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue_S, label6);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_S, local2);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Isinst, typeof(global::System.IConvertible));
							generator.Emit(global::System.Reflection.Emit.OpCodes.Stloc_S, local);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_S, local);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Brfalse_S, label6);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_S, local);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Ldnull);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, method2);
							generator.Emit(global::System.Reflection.Emit.OpCodes.Br_S, label5);
							generator.MarkLabel(label6);
						}
					}
					generator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_S, local2);
					generator.UnboxIfNeeded(type);
					generator.MarkLabel(label5);
				}
				else
				{
					generator.PushArrayInstance(argsIndex, i);
					generator.UnboxIfNeeded(type);
				}
			}
			if (method.IsConstructor)
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Newobj, (global::System.Reflection.ConstructorInfo)method);
			}
			else
			{
				generator.CallMethod((global::System.Reflection.MethodInfo)method);
			}
			global::System.Type type2 = method.IsConstructor ? method.DeclaringType : ((global::System.Reflection.MethodInfo)method).ReturnType;
			if (type2 != typeof(void))
			{
				generator.BoxIfNeeded(type2);
			}
			else
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Ldnull);
			}
			generator.Return();
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00014D3C File Offset: 0x00012F3C
		public override global::System.Func<T> CreateDefaultConstructor<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Type type)
		{
			global::System.Reflection.Emit.DynamicMethod dynamicMethod = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDynamicMethod("Create" + type.FullName, typeof(T), global::Newtonsoft.Json.Utilities.ReflectionUtils.EmptyTypes, type);
			dynamicMethod.InitLocals = true;
			global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateDefaultConstructorIL(type, ilgenerator, typeof(T));
			return (global::System.Func<T>)dynamicMethod.CreateDelegate(typeof(global::System.Func<T>));
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00014DA4 File Offset: 0x00012FA4
		private void GenerateCreateDefaultConstructorIL(global::System.Type type, global::System.Reflection.Emit.ILGenerator generator, global::System.Type delegateType)
		{
			if (type.IsValueType())
			{
				generator.DeclareLocal(type);
				generator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_0);
				if (type != delegateType)
				{
					generator.Emit(global::System.Reflection.Emit.OpCodes.Box, type);
				}
			}
			else
			{
				global::System.Reflection.ConstructorInfo constructor = type.GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, global::Newtonsoft.Json.Utilities.ReflectionUtils.EmptyTypes, null);
				if (constructor == null)
				{
					throw new global::System.ArgumentException("Could not get constructor for {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
				}
				generator.Emit(global::System.Reflection.Emit.OpCodes.Newobj, constructor);
			}
			generator.Return();
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00014E24 File Offset: 0x00013024
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Reflection.Emit.DynamicMethod dynamicMethod = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDynamicMethod("Get" + propertyInfo.Name, typeof(object), new global::System.Type[]
			{
				typeof(T)
			}, propertyInfo.DeclaringType);
			global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateGetPropertyIL(propertyInfo, ilgenerator);
			return (global::System.Func<T, object>)dynamicMethod.CreateDelegate(typeof(global::System.Func<T, object>));
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00014E8C File Offset: 0x0001308C
		private void GenerateCreateGetPropertyIL(global::System.Reflection.PropertyInfo propertyInfo, global::System.Reflection.Emit.ILGenerator generator)
		{
			global::System.Reflection.MethodInfo getMethod = propertyInfo.GetGetMethod(true);
			if (getMethod == null)
			{
				throw new global::System.ArgumentException("Property '{0}' does not have a getter.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, propertyInfo.Name));
			}
			if (!getMethod.IsStatic)
			{
				generator.PushInstance(propertyInfo.DeclaringType);
			}
			generator.CallMethod(getMethod);
			generator.BoxIfNeeded(propertyInfo.PropertyType);
			generator.Return();
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00014EF4 File Offset: 0x000130F4
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.FieldInfo fieldInfo)
		{
			if (fieldInfo.IsLiteral)
			{
				object constantValue = fieldInfo.GetValue(null);
				return (T o) => constantValue;
			}
			global::System.Reflection.Emit.DynamicMethod dynamicMethod = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDynamicMethod("Get" + fieldInfo.Name, typeof(T), new global::System.Type[]
			{
				typeof(object)
			}, fieldInfo.DeclaringType);
			global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			this.GenerateCreateGetFieldIL(fieldInfo, ilgenerator);
			return (global::System.Func<T, object>)dynamicMethod.CreateDelegate(typeof(global::System.Func<T, object>));
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00014F84 File Offset: 0x00013184
		private void GenerateCreateGetFieldIL(global::System.Reflection.FieldInfo fieldInfo, global::System.Reflection.Emit.ILGenerator generator)
		{
			if (!fieldInfo.IsStatic)
			{
				generator.PushInstance(fieldInfo.DeclaringType);
				generator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, fieldInfo);
			}
			else
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Ldsfld, fieldInfo);
			}
			generator.BoxIfNeeded(fieldInfo.FieldType);
			generator.Return();
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00014FD4 File Offset: 0x000131D4
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.FieldInfo fieldInfo)
		{
			global::System.Reflection.Emit.DynamicMethod dynamicMethod = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDynamicMethod("Set" + fieldInfo.Name, null, new global::System.Type[]
			{
				typeof(T),
				typeof(object)
			}, fieldInfo.DeclaringType);
			global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.GenerateCreateSetFieldIL(fieldInfo, ilgenerator);
			return (global::System.Action<T, object>)dynamicMethod.CreateDelegate(typeof(global::System.Action<T, object>));
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00015040 File Offset: 0x00013240
		internal static void GenerateCreateSetFieldIL(global::System.Reflection.FieldInfo fieldInfo, global::System.Reflection.Emit.ILGenerator generator)
		{
			if (!fieldInfo.IsStatic)
			{
				generator.PushInstance(fieldInfo.DeclaringType);
			}
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			generator.UnboxIfNeeded(fieldInfo.FieldType);
			if (!fieldInfo.IsStatic)
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Stfld, fieldInfo);
			}
			else
			{
				generator.Emit(global::System.Reflection.Emit.OpCodes.Stsfld, fieldInfo);
			}
			generator.Return();
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000150A0 File Offset: 0x000132A0
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public override global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.PropertyInfo propertyInfo)
		{
			global::System.Reflection.Emit.DynamicMethod dynamicMethod = global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDynamicMethod("Set" + propertyInfo.Name, null, new global::System.Type[]
			{
				typeof(T),
				typeof(object)
			}, propertyInfo.DeclaringType);
			global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			global::Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.GenerateCreateSetPropertyIL(propertyInfo, ilgenerator);
			return (global::System.Action<T, object>)dynamicMethod.CreateDelegate(typeof(global::System.Action<T, object>));
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001510C File Offset: 0x0001330C
		internal static void GenerateCreateSetPropertyIL(global::System.Reflection.PropertyInfo propertyInfo, global::System.Reflection.Emit.ILGenerator generator)
		{
			global::System.Reflection.MethodInfo setMethod = propertyInfo.GetSetMethod(true);
			if (!setMethod.IsStatic)
			{
				generator.PushInstance(propertyInfo.DeclaringType);
			}
			generator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			generator.UnboxIfNeeded(propertyInfo.PropertyType);
			generator.CallMethod(setMethod);
			generator.Return();
		}
	}
}
