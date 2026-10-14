using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000067 RID: 103
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class ReflectionObject
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00017979 File Offset: 0x00015B79
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		public global::Newtonsoft.Json.Serialization.ObjectConstructor<object> Creator { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] get; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00017981 File Offset: 0x00015B81
		public global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Utilities.ReflectionMember> Members { get; }

		// Token: 0x06000591 RID: 1425 RVA: 0x00017989 File Offset: 0x00015B89
		private ReflectionObject([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] global::Newtonsoft.Json.Serialization.ObjectConstructor<object> creator)
		{
			this.Members = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Utilities.ReflectionMember>();
			this.Creator = creator;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000179A3 File Offset: 0x00015BA3
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public object GetValue(object target, string member)
		{
			return this.Members[member].Getter(target);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000179BC File Offset: 0x00015BBC
		public void SetValue(object target, string member, [global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			this.Members[member].Setter(target, value);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000179D6 File Offset: 0x00015BD6
		public global::System.Type GetType(string member)
		{
			return this.Members[member].MemberType;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000179E9 File Offset: 0x00015BE9
		public static global::Newtonsoft.Json.Utilities.ReflectionObject Create(global::System.Type t, params string[] memberNames)
		{
			return global::Newtonsoft.Json.Utilities.ReflectionObject.Create(t, null, memberNames);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000179F4 File Offset: 0x00015BF4
		public static global::Newtonsoft.Json.Utilities.ReflectionObject Create(global::System.Type t, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Reflection.MethodBase creator, params string[] memberNames)
		{
			global::Newtonsoft.Json.Utilities.ReflectionDelegateFactory reflectionDelegateFactory = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory;
			global::Newtonsoft.Json.Serialization.ObjectConstructor<object> creator2 = null;
			if (creator != null)
			{
				creator2 = reflectionDelegateFactory.CreateParameterizedConstructor(creator);
			}
			else if (global::Newtonsoft.Json.Utilities.ReflectionUtils.HasDefaultConstructor(t, false))
			{
				global::System.Func<object> ctor = reflectionDelegateFactory.CreateDefaultConstructor<object>(t);
				creator2 = (([global::System.Runtime.CompilerServices.Nullable(new byte[]
				{
					1,
					2
				})] object[] args) => ctor());
			}
			global::Newtonsoft.Json.Utilities.ReflectionObject reflectionObject = new global::Newtonsoft.Json.Utilities.ReflectionObject(creator2);
			int i = 0;
			while (i < memberNames.Length)
			{
				string text = memberNames[i];
				global::System.Reflection.MemberInfo[] member = t.GetMember(text, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
				if (member.Length != 1)
				{
					throw new global::System.ArgumentException("Expected a single member with the name '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text));
				}
				global::System.Reflection.MemberInfo memberInfo = member.Single<global::System.Reflection.MemberInfo>();
				global::Newtonsoft.Json.Utilities.ReflectionMember reflectionMember = new global::Newtonsoft.Json.Utilities.ReflectionMember();
				global::System.Reflection.MemberTypes memberTypes = memberInfo.MemberType();
				if (memberTypes == global::System.Reflection.MemberTypes.Field)
				{
					goto IL_AA;
				}
				if (memberTypes != global::System.Reflection.MemberTypes.Method)
				{
					if (memberTypes == global::System.Reflection.MemberTypes.Property)
					{
						goto IL_AA;
					}
					throw new global::System.ArgumentException("Unexpected member type '{0}' for member '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, memberInfo.MemberType(), memberInfo.Name));
				}
				else
				{
					global::System.Reflection.MethodInfo methodInfo = (global::System.Reflection.MethodInfo)memberInfo;
					if (methodInfo.IsPublic)
					{
						global::System.Reflection.ParameterInfo[] parameters = methodInfo.GetParameters();
						if (parameters.Length == 0 && methodInfo.ReturnType != typeof(void))
						{
							global::Newtonsoft.Json.Utilities.MethodCall<object, object> call = reflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
							reflectionMember.Getter = ((object target) => call(target, new object[0]));
						}
						else if (parameters.Length == 1 && methodInfo.ReturnType == typeof(void))
						{
							global::Newtonsoft.Json.Utilities.MethodCall<object, object> call = reflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
							reflectionMember.Setter = delegate(object target, [global::System.Runtime.CompilerServices.Nullable(2)] object arg)
							{
								call(target, new object[]
								{
									arg
								});
							};
						}
					}
				}
				IL_1BF:
				reflectionMember.MemberType = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetMemberUnderlyingType(memberInfo);
				reflectionObject.Members[text] = reflectionMember;
				i++;
				continue;
				IL_AA:
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.CanReadMemberValue(memberInfo, false))
				{
					reflectionMember.Getter = reflectionDelegateFactory.CreateGet<object>(memberInfo);
				}
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.CanSetMemberValue(memberInfo, false, false))
				{
					reflectionMember.Setter = reflectionDelegateFactory.CreateSet<object>(memberInfo);
					goto IL_1BF;
				}
				goto IL_1BF;
			}
			return reflectionObject;
		}
	}
}
