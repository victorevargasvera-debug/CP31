using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Autofac.Util
{
	// Token: 0x0200001B RID: 27
	internal static class Enforce
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x00004618 File Offset: 0x00002818
		public static global::System.Collections.Generic.IEnumerable<T> ArgumentElementNotNull<T>(global::System.Collections.Generic.IEnumerable<T> value, string name) where T : class
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(name);
			}
			if (value.Any((T e) => e == null))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Util.EnforceResources.ElementCannotBeNull, new object[]
				{
					name
				}));
			}
			return value;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004676 File Offset: 0x00002876
		public static T NotNull<T>([global::Autofac.Util.ValidatedNotNull] T value) where T : class
		{
			if (value == null)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Util.EnforceResources.CannotBeNull, new object[]
				{
					typeof(T).FullName
				}));
			}
			return value;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000046B0 File Offset: 0x000028B0
		public static string ArgumentNotNullOrEmpty([global::Autofac.Util.ValidatedNotNull] string value, string description)
		{
			if (description == null)
			{
				throw new global::System.ArgumentNullException("description");
			}
			if (value == null)
			{
				throw new global::System.ArgumentNullException(description);
			}
			if (value.Length == 0)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Util.EnforceResources.CannotBeEmpty, new object[]
				{
					description
				}));
			}
			return value;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00004700 File Offset: 0x00002900
		public static void ArgumentTypeIsFunction(global::System.Type delegateType)
		{
			if (delegateType == null)
			{
				throw new global::System.ArgumentNullException("delegateType");
			}
			global::System.Reflection.MethodInfo declaredMethod = delegateType.GetTypeInfo().GetDeclaredMethod("Invoke");
			if (declaredMethod == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Util.EnforceResources.NotDelegate, new object[]
				{
					delegateType
				}));
			}
			if (declaredMethod.ReturnType == typeof(void))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Util.EnforceResources.DelegateReturnsVoid, new object[]
				{
					delegateType
				}));
			}
		}
	}
}
