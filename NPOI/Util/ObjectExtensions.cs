using System;
using System.Collections.Generic;
using System.Reflection;
using NPOI.Util.ArrayExtensions;

namespace NPOI.Util
{
	// Token: 0x02000282 RID: 642
	public static class ObjectExtensions
	{
		// Token: 0x06001149 RID: 4425 RVA: 0x000342E4 File Offset: 0x000324E4
		public static bool IsPrimitive(this global::System.Type type)
		{
			return type == typeof(string) || (type.IsValueType & type.IsPrimitive);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00034307 File Offset: 0x00032507
		public static object Copy(this object originalObject)
		{
			return global::NPOI.Util.ObjectExtensions.InternalCopy(originalObject, new global::System.Collections.Generic.Dictionary<object, object>(new global::NPOI.Util.ReferenceEqualityComparer()));
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0003431C File Offset: 0x0003251C
		private static object InternalCopy(object originalObject, global::System.Collections.Generic.IDictionary<object, object> visited)
		{
			if (originalObject == null)
			{
				return null;
			}
			global::System.Type type = originalObject.GetType();
			if (type.IsPrimitive())
			{
				return originalObject;
			}
			if (visited.ContainsKey(originalObject))
			{
				return visited[originalObject];
			}
			if (typeof(global::System.Delegate).IsAssignableFrom(type))
			{
				return null;
			}
			object obj = global::NPOI.Util.ObjectExtensions.CloneMethod.Invoke(originalObject, null);
			if (type.IsArray && !type.GetElementType().IsPrimitive())
			{
				global::System.Array clonedArray = (global::System.Array)obj;
				clonedArray.ForEach(delegate(global::System.Array array, int[] indices)
				{
					array.SetValue(global::NPOI.Util.ObjectExtensions.InternalCopy(clonedArray.GetValue(indices), visited), indices);
				});
			}
			visited.Add(originalObject, obj);
			global::NPOI.Util.ObjectExtensions.CopyFields(originalObject, visited, obj, type, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.FlattenHierarchy, null);
			global::NPOI.Util.ObjectExtensions.RecursiveCopyBaseTypePrivateFields(originalObject, visited, obj, type);
			return obj;
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000343F0 File Offset: 0x000325F0
		private static void RecursiveCopyBaseTypePrivateFields(object originalObject, global::System.Collections.Generic.IDictionary<object, object> visited, object cloneObject, global::System.Type typeToReflect)
		{
			if (typeToReflect.BaseType != null)
			{
				global::NPOI.Util.ObjectExtensions.RecursiveCopyBaseTypePrivateFields(originalObject, visited, cloneObject, typeToReflect.BaseType);
				global::NPOI.Util.ObjectExtensions.CopyFields(originalObject, visited, cloneObject, typeToReflect.BaseType, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic, (global::System.Reflection.FieldInfo info) => info.IsPrivate);
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00034448 File Offset: 0x00032648
		private static void CopyFields(object originalObject, global::System.Collections.Generic.IDictionary<object, object> visited, object cloneObject, global::System.Type typeToReflect, global::System.Reflection.BindingFlags bindingFlags = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.FlattenHierarchy, global::System.Func<global::System.Reflection.FieldInfo, bool> filter = null)
		{
			foreach (global::System.Reflection.FieldInfo fieldInfo in typeToReflect.GetFields(bindingFlags))
			{
				if ((filter == null || filter(fieldInfo)) && !fieldInfo.FieldType.IsPrimitive())
				{
					object value = global::NPOI.Util.ObjectExtensions.InternalCopy(fieldInfo.GetValue(originalObject), visited);
					fieldInfo.SetValue(cloneObject, value);
				}
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x000344A1 File Offset: 0x000326A1
		public static T Copy<T>(this T original)
		{
			return (T)((object)original.Copy());
		}

		// Token: 0x04000756 RID: 1878
		private static readonly global::System.Reflection.MethodInfo CloneMethod = typeof(object).GetMethod("MemberwiseClone", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
	}
}
