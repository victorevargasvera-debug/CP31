using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000065 RID: 101
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal abstract class ReflectionDelegateFactory
	{
		// Token: 0x0600057E RID: 1406 RVA: 0x00017884 File Offset: 0x00015A84
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.MemberInfo memberInfo)
		{
			global::System.Reflection.PropertyInfo propertyInfo = memberInfo as global::System.Reflection.PropertyInfo;
			if (propertyInfo != null)
			{
				if (propertyInfo.PropertyType.IsByRef)
				{
					throw new global::System.InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, propertyInfo));
				}
				return this.CreateGet<T>(propertyInfo);
			}
			else
			{
				global::System.Reflection.FieldInfo fieldInfo = memberInfo as global::System.Reflection.FieldInfo;
				if (fieldInfo != null)
				{
					return this.CreateGet<T>(fieldInfo);
				}
				throw new global::System.Exception("Could not create getter for {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, memberInfo));
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x000178F0 File Offset: 0x00015AF0
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.MemberInfo memberInfo)
		{
			global::System.Reflection.PropertyInfo propertyInfo = memberInfo as global::System.Reflection.PropertyInfo;
			if (propertyInfo != null)
			{
				return this.CreateSet<T>(propertyInfo);
			}
			global::System.Reflection.FieldInfo fieldInfo = memberInfo as global::System.Reflection.FieldInfo;
			if (fieldInfo != null)
			{
				return this.CreateSet<T>(fieldInfo);
			}
			throw new global::System.Exception("Could not create setter for {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, memberInfo));
		}

		// Token: 0x06000580 RID: 1408
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public abstract global::Newtonsoft.Json.Utilities.MethodCall<T, object> CreateMethodCall<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.MethodBase method);

		// Token: 0x06000581 RID: 1409
		public abstract global::Newtonsoft.Json.Serialization.ObjectConstructor<object> CreateParameterizedConstructor(global::System.Reflection.MethodBase method);

		// Token: 0x06000582 RID: 1410
		public abstract global::System.Func<T> CreateDefaultConstructor<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Type type);

		// Token: 0x06000583 RID: 1411
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public abstract global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.PropertyInfo propertyInfo);

		// Token: 0x06000584 RID: 1412
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public abstract global::System.Func<T, object> CreateGet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.FieldInfo fieldInfo);

		// Token: 0x06000585 RID: 1413
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public abstract global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.FieldInfo fieldInfo);

		// Token: 0x06000586 RID: 1414
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		public abstract global::System.Action<T, object> CreateSet<[global::System.Runtime.CompilerServices.Nullable(2)] T>(global::System.Reflection.PropertyInfo propertyInfo);
	}
}
