using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B7 RID: 183
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public static class Extensions
	{
		// Token: 0x06000970 RID: 2416 RVA: 0x00027AE3 File Offset: 0x00025CE3
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> Ancestors<[global::System.Runtime.CompilerServices.Nullable(0)] T>(this global::System.Collections.Generic.IEnumerable<T> source) where T : global::Newtonsoft.Json.Linq.JToken
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(source, "source");
			return source.SelectMany((T j) => j.Ancestors()).AsJEnumerable();
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00027B1A File Offset: 0x00025D1A
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> AncestorsAndSelf<[global::System.Runtime.CompilerServices.Nullable(0)] T>(this global::System.Collections.Generic.IEnumerable<T> source) where T : global::Newtonsoft.Json.Linq.JToken
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(source, "source");
			return source.SelectMany((T j) => j.AncestorsAndSelf()).AsJEnumerable();
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00027B51 File Offset: 0x00025D51
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> Descendants<[global::System.Runtime.CompilerServices.Nullable(0)] T>(this global::System.Collections.Generic.IEnumerable<T> source) where T : global::Newtonsoft.Json.Linq.JContainer
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(source, "source");
			return source.SelectMany((T j) => j.Descendants()).AsJEnumerable();
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00027B88 File Offset: 0x00025D88
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> DescendantsAndSelf<[global::System.Runtime.CompilerServices.Nullable(0)] T>(this global::System.Collections.Generic.IEnumerable<T> source) where T : global::Newtonsoft.Json.Linq.JContainer
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(source, "source");
			return source.SelectMany((T j) => j.DescendantsAndSelf()).AsJEnumerable();
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00027BBF File Offset: 0x00025DBF
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JProperty> Properties(this global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JObject> source)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(source, "source");
			return source.SelectMany((global::Newtonsoft.Json.Linq.JObject d) => d.Properties()).AsJEnumerable<global::Newtonsoft.Json.Linq.JProperty>();
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00027BF6 File Offset: 0x00025DF6
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> Values(this global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> source, [global::System.Runtime.CompilerServices.Nullable(2)] object key)
		{
			return source.Values(key).AsJEnumerable();
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00027C04 File Offset: 0x00025E04
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> Values(this global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> source)
		{
			return source.Values(null);
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00027C0D File Offset: 0x00025E0D
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public static global::System.Collections.Generic.IEnumerable<U> Values<[global::System.Runtime.CompilerServices.Nullable(2)] U>(this global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> source, object key)
		{
			return source.Values(key);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00027C16 File Offset: 0x00025E16
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public static global::System.Collections.Generic.IEnumerable<U> Values<[global::System.Runtime.CompilerServices.Nullable(2)] U>(this global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> source)
		{
			return source.Values(null);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00027C1F File Offset: 0x00025E1F
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static U Value<U>([global::System.Runtime.CompilerServices.Nullable(1)] this global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> value)
		{
			return value.Value<global::Newtonsoft.Json.Linq.JToken, U>();
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00027C27 File Offset: 0x00025E27
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static U Value<[global::System.Runtime.CompilerServices.Nullable(0)] T, [global::System.Runtime.CompilerServices.Nullable(2)] U>(this global::System.Collections.Generic.IEnumerable<T> value) where T : global::Newtonsoft.Json.Linq.JToken
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
			global::Newtonsoft.Json.Linq.JToken jtoken = value as global::Newtonsoft.Json.Linq.JToken;
			if (jtoken == null)
			{
				throw new global::System.ArgumentException("Source value must be a JToken.");
			}
			return jtoken.Convert<global::Newtonsoft.Json.Linq.JToken, U>();
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00027C4D File Offset: 0x00025E4D
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		internal static global::System.Collections.Generic.IEnumerable<U> Values<[global::System.Runtime.CompilerServices.Nullable(0)] T, [global::System.Runtime.CompilerServices.Nullable(2)] U>(this global::System.Collections.Generic.IEnumerable<T> source, [global::System.Runtime.CompilerServices.Nullable(2)] object key) where T : global::Newtonsoft.Json.Linq.JToken
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(source, "source");
			if (key == null)
			{
				foreach (T t in source)
				{
					global::Newtonsoft.Json.Linq.JValue jvalue = t as global::Newtonsoft.Json.Linq.JValue;
					if (jvalue != null)
					{
						yield return jvalue.Convert<global::Newtonsoft.Json.Linq.JValue, U>();
					}
					else
					{
						foreach (global::Newtonsoft.Json.Linq.JToken token in t.Children())
						{
							yield return token.Convert<global::Newtonsoft.Json.Linq.JToken, U>();
						}
						global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator2 = null;
					}
				}
				global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			}
			else
			{
				foreach (T t2 in source)
				{
					global::Newtonsoft.Json.Linq.JToken jtoken = t2[key];
					if (jtoken != null)
					{
						yield return jtoken.Convert<global::Newtonsoft.Json.Linq.JToken, U>();
					}
				}
				global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			}
			yield break;
			yield break;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00027C64 File Offset: 0x00025E64
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> Children<[global::System.Runtime.CompilerServices.Nullable(0)] T>(this global::System.Collections.Generic.IEnumerable<T> source) where T : global::Newtonsoft.Json.Linq.JToken
		{
			return source.Children<T, global::Newtonsoft.Json.Linq.JToken>().AsJEnumerable();
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00027C71 File Offset: 0x00025E71
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public static global::System.Collections.Generic.IEnumerable<U> Children<[global::System.Runtime.CompilerServices.Nullable(0)] T, [global::System.Runtime.CompilerServices.Nullable(2)] U>(this global::System.Collections.Generic.IEnumerable<T> source) where T : global::Newtonsoft.Json.Linq.JToken
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(source, "source");
			return source.SelectMany((T c) => c.Children()).Convert<global::Newtonsoft.Json.Linq.JToken, U>();
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00027CA8 File Offset: 0x00025EA8
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		internal static global::System.Collections.Generic.IEnumerable<U> Convert<[global::System.Runtime.CompilerServices.Nullable(0)] T, [global::System.Runtime.CompilerServices.Nullable(2)] U>(this global::System.Collections.Generic.IEnumerable<T> source) where T : global::Newtonsoft.Json.Linq.JToken
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(source, "source");
			foreach (T t in source)
			{
				yield return t.Convert<global::Newtonsoft.Json.Linq.JToken, U>();
			}
			global::System.Collections.Generic.IEnumerator<T> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00027CB8 File Offset: 0x00025EB8
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal static U Convert<[global::System.Runtime.CompilerServices.Nullable(0)] T, U>([global::System.Runtime.CompilerServices.Nullable(1)] this T token) where T : global::Newtonsoft.Json.Linq.JToken
		{
			if (token == null)
			{
				return default(U);
			}
			if (token is U)
			{
				U result = token as U;
				if (typeof(U) != typeof(global::System.IComparable) && typeof(U) != typeof(global::System.IFormattable))
				{
					return result;
				}
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = token as global::Newtonsoft.Json.Linq.JValue;
			if (jvalue == null)
			{
				throw new global::System.InvalidCastException("Cannot cast {0} to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.GetType(), typeof(T)));
			}
			object value = jvalue.Value;
			if (value is U)
			{
				return (U)((object)value);
			}
			global::System.Type type = typeof(U);
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(type))
			{
				if (jvalue.Value == null)
				{
					return default(U);
				}
				type = global::System.Nullable.GetUnderlyingType(type);
			}
			return (U)((object)global::System.Convert.ChangeType(jvalue.Value, type, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00027DC8 File Offset: 0x00025FC8
		public static global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> AsJEnumerable(this global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> source)
		{
			return source.AsJEnumerable<global::Newtonsoft.Json.Linq.JToken>();
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00027DD0 File Offset: 0x00025FD0
		public static global::Newtonsoft.Json.Linq.IJEnumerable<T> AsJEnumerable<[global::System.Runtime.CompilerServices.Nullable(0)] T>(this global::System.Collections.Generic.IEnumerable<T> source) where T : global::Newtonsoft.Json.Linq.JToken
		{
			if (source == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.IJEnumerable<T> ijenumerable = source as global::Newtonsoft.Json.Linq.IJEnumerable<T>;
			if (ijenumerable != null)
			{
				return ijenumerable;
			}
			return new global::Newtonsoft.Json.Linq.JEnumerable<T>(source);
		}
	}
}
