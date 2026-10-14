using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Infragistics
{
	// Token: 0x0200004B RID: 75
	internal static class GroupingProxyHelper
	{
		// Token: 0x0600041A RID: 1050 RVA: 0x00010774 File Offset: 0x0000E974
		public static global::Infragistics.GroupingProxyHelper.CreateObject CreateObjectCreator(global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> props)
		{
			if (global::Infragistics.GroupingProxyHelper._creatorCache == null)
			{
				global::Infragistics.GroupingProxyHelper._creatorCache = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.GroupingProxyHelper.CreateObject>();
			}
			string cacheKey = global::Infragistics.GroupingProxyHelper.GetCacheKey(props);
			if (global::Infragistics.GroupingProxyHelper._creatorCache.ContainsKey(cacheKey))
			{
				return global::Infragistics.GroupingProxyHelper._creatorCache[cacheKey];
			}
			new global::System.Collections.Generic.List<object>();
			global::System.Type type = global::Infragistics.GroupingProxyHelper.CreateProxyType(props);
			global::System.Reflection.ConstructorInfo constructor = type.GetConstructor(new global::System.Type[0]);
			global::System.Reflection.Emit.DynamicMethod dynamicMethod = new global::System.Reflection.Emit.DynamicMethod("Creator", typeof(global::Infragistics.GroupingBase), new global::System.Type[0]);
			global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Newobj, constructor);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			global::System.Type typeFromHandle = typeof(global::Infragistics.GroupingProxyHelper.CreateObject);
			global::Infragistics.GroupingProxyHelper.CreateObject createObject = (global::Infragistics.GroupingProxyHelper.CreateObject)dynamicMethod.CreateDelegate(typeFromHandle);
			global::Infragistics.GroupingProxyHelper._creatorCache.Add(cacheKey, createObject);
			return createObject;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001083C File Offset: 0x0000EA3C
		private static string GetCacheKey(global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> props)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::Infragistics.ConcretePropertyInfo concretePropertyInfo in from p in props
			orderby p.PropertyName
			select p)
			{
				stringBuilder.Append(concretePropertyInfo.PropertyName);
				stringBuilder.Append("@@");
				stringBuilder.Append(concretePropertyInfo.PropertyType.FullName);
				stringBuilder.Append("@@");
				stringBuilder.Append(concretePropertyInfo.SourceType.FullName);
				stringBuilder.Append(";;");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001093C File Offset: 0x0000EB3C
		public static global::System.Collections.Generic.List<global::System.Tuple<string, global::System.Type>> DistinctKeysTypes(global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> props)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Tuple<string, global::System.Type>> source = from prop in props
			group prop by new
			{
				Key = prop.Key,
				Type = prop.SourceType
			} into gr
			select new global::System.Tuple<string, global::System.Type>(gr.Key.Key, gr.Key.Type);
			global::System.Collections.Generic.IEnumerable<global::System.Linq.IGrouping<string, global::Infragistics.ConcretePropertyInfo>> source2 = from prop in props
			group prop by prop.Key into gr
			select gr;
			if (source.Count<global::System.Tuple<string, global::System.Type>>() != source2.Count<global::System.Linq.IGrouping<string, global::Infragistics.ConcretePropertyInfo>>())
			{
				return null;
			}
			return source.ToList<global::System.Tuple<string, global::System.Type>>();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000109EC File Offset: 0x0000EBEC
		private static global::System.Type CreateProxyType(global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> props)
		{
			if (global::Infragistics.GroupingProxyHelper._ab == null)
			{
				global::System.Reflection.AssemblyName assemblyName = new global::System.Reflection.AssemblyName("DynamicAssembly");
				global::Infragistics.GroupingProxyHelper._ab = global::System.AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName, global::System.Reflection.Emit.AssemblyBuilderAccess.Run);
				global::Infragistics.GroupingProxyHelper._mb = global::Infragistics.GroupingProxyHelper._ab.DefineDynamicModule(assemblyName.Name);
			}
			global::System.Reflection.Emit.TypeBuilder typeBuilder = global::Infragistics.GroupingProxyHelper._mb.DefineType(global::System.Guid.NewGuid().ToString() + "__proxy", global::System.Reflection.TypeAttributes.Public, typeof(global::Infragistics.GroupingBase));
			global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.FieldBuilder> fields = new global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.FieldBuilder>();
			global::Infragistics.GroupingProxyHelper.CreateFields(props, typeBuilder, fields);
			global::Infragistics.GroupingProxyHelper.CreateProperties(props, typeBuilder, fields);
			global::Infragistics.GroupingProxyHelper.CreateSetter(props, typeBuilder, fields);
			return typeBuilder.CreateType();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00010A94 File Offset: 0x0000EC94
		private static void CreateFields(global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> props, global::System.Reflection.Emit.TypeBuilder tb, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.FieldBuilder> fields)
		{
			foreach (global::System.Tuple<string, global::System.Type> tuple in global::Infragistics.GroupingProxyHelper.DistinctKeysTypes(props))
			{
				global::System.Reflection.Emit.FieldBuilder value = tb.DefineField("_" + tuple.Item1, tuple.Item2, global::System.Reflection.FieldAttributes.Private);
				fields.Add(tuple.Item1, value);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00010B0C File Offset: 0x0000ED0C
		private static void CreateSetter(global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> props, global::System.Reflection.Emit.TypeBuilder tb, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.FieldBuilder> fields)
		{
			global::System.Reflection.Emit.MethodBuilder methodBuilder = tb.DefineMethod("SetObjectForKeyOverride", global::System.Reflection.MethodAttributes.FamANDAssem | global::System.Reflection.MethodAttributes.Family | global::System.Reflection.MethodAttributes.Virtual, typeof(void), new global::System.Type[]
			{
				typeof(string),
				typeof(object)
			});
			global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			global::System.Reflection.MethodInfo method = typeof(string).GetMethod("op_Equality", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, new global::System.Type[]
			{
				typeof(string),
				typeof(string)
			}, null);
			ilgenerator.DeclareLocal(typeof(string));
			global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.Label> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.Label>();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Stloc_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_0);
			global::System.Reflection.Emit.Label label = ilgenerator.DefineLabel();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brfalse, label);
			foreach (global::System.Tuple<string, global::System.Type> tuple in global::Infragistics.GroupingProxyHelper.DistinctKeysTypes(props))
			{
				global::System.Reflection.Emit.Label label2 = ilgenerator.DefineLabel();
				dictionary[tuple.Item1] = label2;
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, tuple.Item1);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, method);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue, label2);
			}
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Br, label);
			foreach (global::System.Tuple<string, global::System.Type> tuple2 in global::Infragistics.GroupingProxyHelper.DistinctKeysTypes(props))
			{
				global::System.Reflection.Emit.Label loc = dictionary[tuple2.Item1];
				ilgenerator.MarkLabel(loc);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_2);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Isinst, tuple2.Item2);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Stfld, fields[tuple2.Item1]);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Br, label);
			}
			ilgenerator.MarkLabel(label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00010D3C File Offset: 0x0000EF3C
		private static void CreateProperties(global::System.Collections.Generic.List<global::Infragistics.ConcretePropertyInfo> props, global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.FieldBuilder> fields)
		{
			foreach (global::Infragistics.ConcretePropertyInfo concretePropertyInfo in props)
			{
				global::System.Reflection.Emit.PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(concretePropertyInfo.PropertyName, global::System.Reflection.PropertyAttributes.None, concretePropertyInfo.PropertyType, null);
				global::System.Reflection.Emit.MethodBuilder getMethod = global::Infragistics.GroupingProxyHelper.CreateGetMethod(concretePropertyInfo, typeBuilder, fields);
				propertyBuilder.SetGetMethod(getMethod);
				if (concretePropertyInfo.SourceType.GetProperty(concretePropertyInfo.Name).CanWrite)
				{
					global::System.Reflection.Emit.MethodBuilder setMethod = global::Infragistics.GroupingProxyHelper.CreateSetMethod(concretePropertyInfo, typeBuilder, fields);
					propertyBuilder.SetSetMethod(setMethod);
				}
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00010DDC File Offset: 0x0000EFDC
		private static global::System.Reflection.Emit.MethodBuilder CreateSetMethod(global::Infragistics.ConcretePropertyInfo info, global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.FieldBuilder> fields)
		{
			global::System.Reflection.PropertyInfo property = info.SourceType.GetProperty(info.Name);
			global::System.Reflection.MethodInfo setMethod = property.GetSetMethod();
			global::System.Type[] parameterTypes = (from p in setMethod.GetParameters()
			select p.ParameterType).ToArray<global::System.Type>();
			global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("set_" + info.PropertyName, setMethod.Attributes, setMethod.CallingConvention, setMethod.ReturnType, parameterTypes);
			global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, fields[info.Key]);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, setMethod);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			return methodBuilder;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00010EB4 File Offset: 0x0000F0B4
		private static global::System.Reflection.Emit.MethodBuilder CreateGetMethod(global::Infragistics.ConcretePropertyInfo info, global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.Emit.FieldBuilder> fields)
		{
			global::System.Reflection.PropertyInfo property = info.SourceType.GetProperty(info.Name);
			global::System.Reflection.MethodInfo getMethod = property.GetGetMethod();
			global::System.Type[] parameterTypes = (from p in getMethod.GetParameters()
			select p.ParameterType).ToArray<global::System.Type>();
			global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("get_" + info.PropertyName, getMethod.Attributes, getMethod.CallingConvention, getMethod.ReturnType, parameterTypes);
			global::System.Reflection.MethodInfo method = typeof(global::Infragistics.GroupingBase).GetMethod("GetDefaultValue");
			global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			global::System.Reflection.Emit.Label label = ilgenerator.DefineLabel();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, fields[info.Key]);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldnull);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ceq);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue, label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, fields[info.Key]);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, getMethod);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			ilgenerator.MarkLabel(label);
			global::System.Reflection.MethodInfo meth = method.MakeGenericMethod(new global::System.Type[]
			{
				getMethod.ReturnType
			});
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, meth);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			return methodBuilder;
		}

		// Token: 0x04000185 RID: 389
		private static global::System.Reflection.Emit.AssemblyBuilder _ab;

		// Token: 0x04000186 RID: 390
		private static global::System.Reflection.Emit.ModuleBuilder _mb;

		// Token: 0x04000187 RID: 391
		private static global::System.Collections.Generic.Dictionary<string, global::Infragistics.GroupingProxyHelper.CreateObject> _creatorCache;

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x0600042B RID: 1067
		public delegate global::Infragistics.GroupingBase CreateObject();
	}
}
