using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C5 RID: 197
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public abstract class JToken : global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.IEnumerable, global::Newtonsoft.Json.IJsonLineInfo, global::System.ICloneable, global::System.Dynamic.IDynamicMetaObjectProvider
	{
		// Token: 0x06000AC2 RID: 2754 RVA: 0x0002ACB6 File Offset: 0x00028EB6
		public virtual global::System.Threading.Tasks.Task WriteToAsync(global::Newtonsoft.Json.JsonWriter writer, global::System.Threading.CancellationToken cancellationToken, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0002ACC0 File Offset: 0x00028EC0
		public global::System.Threading.Tasks.Task WriteToAsync(global::Newtonsoft.Json.JsonWriter writer, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			return this.WriteToAsync(writer, default(global::System.Threading.CancellationToken), converters);
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0002ACDE File Offset: 0x00028EDE
		public static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JToken> ReadFromAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::Newtonsoft.Json.Linq.JToken.ReadFromAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0002ACE8 File Offset: 0x00028EE8
		public static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JToken> ReadFromAsync(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Linq.JToken.<ReadFromAsync>d__3 <ReadFromAsync>d__;
			<ReadFromAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Newtonsoft.Json.Linq.JToken>.Create();
			<ReadFromAsync>d__.reader = reader;
			<ReadFromAsync>d__.settings = settings;
			<ReadFromAsync>d__.cancellationToken = cancellationToken;
			<ReadFromAsync>d__.<>1__state = -1;
			<ReadFromAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JToken.<ReadFromAsync>d__3>(ref <ReadFromAsync>d__);
			return <ReadFromAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0002AD3B File Offset: 0x00028F3B
		public static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JToken> LoadAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::Newtonsoft.Json.Linq.JToken.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0002AD45 File Offset: 0x00028F45
		public static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JToken> LoadAsync(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::Newtonsoft.Json.Linq.JToken.ReadFromAsync(reader, settings, cancellationToken);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0002AD4F File Offset: 0x00028F4F
		public static global::Newtonsoft.Json.Linq.JTokenEqualityComparer EqualityComparer
		{
			get
			{
				if (global::Newtonsoft.Json.Linq.JToken._equalityComparer == null)
				{
					global::Newtonsoft.Json.Linq.JToken._equalityComparer = new global::Newtonsoft.Json.Linq.JTokenEqualityComparer();
				}
				return global::Newtonsoft.Json.Linq.JToken._equalityComparer;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0002AD67 File Offset: 0x00028F67
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0002AD6F File Offset: 0x00028F6F
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JContainer Parent
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return this._parent;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			internal set
			{
				this._parent = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0002AD78 File Offset: 0x00028F78
		public global::Newtonsoft.Json.Linq.JToken Root
		{
			get
			{
				global::Newtonsoft.Json.Linq.JContainer parent = this.Parent;
				if (parent == null)
				{
					return this;
				}
				while (parent.Parent != null)
				{
					parent = parent.Parent;
				}
				return parent;
			}
		}

		// Token: 0x06000ACC RID: 2764
		internal abstract global::Newtonsoft.Json.Linq.JToken CloneToken();

		// Token: 0x06000ACD RID: 2765
		internal abstract bool DeepEquals(global::Newtonsoft.Json.Linq.JToken node);

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000ACE RID: 2766
		public abstract global::Newtonsoft.Json.Linq.JTokenType Type { get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000ACF RID: 2767
		public abstract bool HasValues { get; }

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0002ADA1 File Offset: 0x00028FA1
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static bool DeepEquals(global::Newtonsoft.Json.Linq.JToken t1, global::Newtonsoft.Json.Linq.JToken t2)
		{
			return t1 == t2 || (t1 != null && t2 != null && t1.DeepEquals(t2));
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0002ADB8 File Offset: 0x00028FB8
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0002ADC0 File Offset: 0x00028FC0
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JToken Next
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this._next;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			internal set
			{
				this._next = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0002ADC9 File Offset: 0x00028FC9
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x0002ADD1 File Offset: 0x00028FD1
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JToken Previous
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this._previous;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			internal set
			{
				this._previous = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0002ADDC File Offset: 0x00028FDC
		public string Path
		{
			get
			{
				if (this.Parent == null)
				{
					return string.Empty;
				}
				global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition> list = new global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition>();
				global::Newtonsoft.Json.Linq.JToken jtoken = null;
				for (global::Newtonsoft.Json.Linq.JToken jtoken2 = this; jtoken2 != null; jtoken2 = jtoken2.Parent)
				{
					global::Newtonsoft.Json.Linq.JTokenType type = jtoken2.Type;
					if (type - global::Newtonsoft.Json.Linq.JTokenType.Array > 1)
					{
						if (type == global::Newtonsoft.Json.Linq.JTokenType.Property)
						{
							global::Newtonsoft.Json.Linq.JProperty jproperty = (global::Newtonsoft.Json.Linq.JProperty)jtoken2;
							global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition> list2 = list;
							global::Newtonsoft.Json.JsonPosition item = new global::Newtonsoft.Json.JsonPosition(global::Newtonsoft.Json.JsonContainerType.Object)
							{
								PropertyName = jproperty.Name
							};
							list2.Add(item);
						}
					}
					else if (jtoken != null)
					{
						int position = ((global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken>)jtoken2).IndexOf(jtoken);
						global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition> list3 = list;
						global::Newtonsoft.Json.JsonPosition item = new global::Newtonsoft.Json.JsonPosition(global::Newtonsoft.Json.JsonContainerType.Array)
						{
							Position = position
						};
						list3.Add(item);
					}
					jtoken = jtoken2;
				}
				list.FastReverse<global::Newtonsoft.Json.JsonPosition>();
				return global::Newtonsoft.Json.JsonPosition.BuildPath(list, null);
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0002AE89 File Offset: 0x00029089
		internal JToken()
		{
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0002AE94 File Offset: 0x00029094
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public void AddAfterSelf(object content)
		{
			if (this._parent == null)
			{
				throw new global::System.InvalidOperationException("The parent is missing.");
			}
			int num = this._parent.IndexOfItem(this);
			this._parent.TryAddInternal(num + 1, content, false);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0002AED4 File Offset: 0x000290D4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public void AddBeforeSelf(object content)
		{
			if (this._parent == null)
			{
				throw new global::System.InvalidOperationException("The parent is missing.");
			}
			int index = this._parent.IndexOfItem(this);
			this._parent.TryAddInternal(index, content, false);
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0002AF10 File Offset: 0x00029110
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> Ancestors()
		{
			return this.GetAncestors(false);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0002AF19 File Offset: 0x00029119
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> AncestorsAndSelf()
		{
			return this.GetAncestors(true);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0002AF22 File Offset: 0x00029122
		internal global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> GetAncestors(bool self)
		{
			global::Newtonsoft.Json.Linq.JToken current;
			for (current = (self ? this : this.Parent); current != null; current = current.Parent)
			{
				yield return current;
			}
			current = null;
			yield break;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0002AF39 File Offset: 0x00029139
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> AfterSelf()
		{
			if (this.Parent == null)
			{
				yield break;
			}
			global::Newtonsoft.Json.Linq.JToken o;
			for (o = this.Next; o != null; o = o.Next)
			{
				yield return o;
			}
			o = null;
			yield break;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0002AF49 File Offset: 0x00029149
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> BeforeSelf()
		{
			if (this.Parent == null)
			{
				yield break;
			}
			global::Newtonsoft.Json.Linq.JToken o = this.Parent.First;
			while (o != this && o != null)
			{
				yield return o;
				o = o.Next;
			}
			o = null;
			yield break;
		}

		// Token: 0x170001FC RID: 508
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public virtual global::Newtonsoft.Json.Linq.JToken this[object key]
		{
			[return: global::System.Runtime.CompilerServices.Nullable(2)]
			get
			{
				throw new global::System.InvalidOperationException("Cannot access child value on {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType()));
			}
			[param: global::System.Runtime.CompilerServices.Nullable(2)]
			set
			{
				throw new global::System.InvalidOperationException("Cannot set child value on {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0002AF94 File Offset: 0x00029194
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual T Value<T>([global::System.Runtime.CompilerServices.Nullable(1)] object key)
		{
			global::Newtonsoft.Json.Linq.JToken jtoken = this[key];
			if (jtoken != null)
			{
				return jtoken.Convert<global::Newtonsoft.Json.Linq.JToken, T>();
			}
			return default(T);
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0002AFBC File Offset: 0x000291BC
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public virtual global::Newtonsoft.Json.Linq.JToken First
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw new global::System.InvalidOperationException("Cannot access child value on {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0002AFD8 File Offset: 0x000291D8
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public virtual global::Newtonsoft.Json.Linq.JToken Last
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw new global::System.InvalidOperationException("Cannot access child value on {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0002AFF4 File Offset: 0x000291F4
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1
		})]
		public virtual global::Newtonsoft.Json.Linq.JEnumerable<global::Newtonsoft.Json.Linq.JToken> Children()
		{
			return global::Newtonsoft.Json.Linq.JEnumerable<global::Newtonsoft.Json.Linq.JToken>.Empty;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0002AFFB File Offset: 0x000291FB
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1
		})]
		public global::Newtonsoft.Json.Linq.JEnumerable<T> Children<T>() where T : global::Newtonsoft.Json.Linq.JToken
		{
			return new global::Newtonsoft.Json.Linq.JEnumerable<T>(this.Children().OfType<T>());
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0002B012 File Offset: 0x00029212
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public virtual global::System.Collections.Generic.IEnumerable<T> Values<T>()
		{
			throw new global::System.InvalidOperationException("Cannot access child value on {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType()));
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0002B02E File Offset: 0x0002922E
		public void Remove()
		{
			if (this._parent == null)
			{
				throw new global::System.InvalidOperationException("The parent is missing.");
			}
			this._parent.RemoveItem(this);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0002B050 File Offset: 0x00029250
		public void Replace(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (this._parent == null)
			{
				throw new global::System.InvalidOperationException("The parent is missing.");
			}
			this._parent.ReplaceItem(this, value);
		}

		// Token: 0x06000AE8 RID: 2792
		public abstract void WriteTo(global::Newtonsoft.Json.JsonWriter writer, params global::Newtonsoft.Json.JsonConverter[] converters);

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0002B072 File Offset: 0x00029272
		public override string ToString()
		{
			return this.ToString(global::Newtonsoft.Json.Formatting.Indented, new global::Newtonsoft.Json.JsonConverter[0]);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0002B084 File Offset: 0x00029284
		public string ToString(global::Newtonsoft.Json.Formatting formatting, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			string result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture))
			{
				this.WriteTo(new global::Newtonsoft.Json.JsonTextWriter(stringWriter)
				{
					Formatting = formatting
				}, converters);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0002B0D8 File Offset: 0x000292D8
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private static global::Newtonsoft.Json.Linq.JValue EnsureValue(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException("value");
			}
			global::Newtonsoft.Json.Linq.JProperty jproperty = value as global::Newtonsoft.Json.Linq.JProperty;
			if (jproperty != null)
			{
				value = jproperty.Value;
			}
			return value as global::Newtonsoft.Json.Linq.JValue;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0002B10C File Offset: 0x0002930C
		private static string GetType(global::Newtonsoft.Json.Linq.JToken token)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(token, "token");
			global::Newtonsoft.Json.Linq.JProperty jproperty = token as global::Newtonsoft.Json.Linq.JProperty;
			if (jproperty != null)
			{
				token = jproperty.Value;
			}
			return token.Type.ToString();
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0002B14A File Offset: 0x0002934A
		private static bool ValidateToken(global::Newtonsoft.Json.Linq.JToken o, global::Newtonsoft.Json.Linq.JTokenType[] validTypes, bool nullable)
		{
			return global::System.Array.IndexOf<global::Newtonsoft.Json.Linq.JTokenType>(validTypes, o.Type) != -1 || (nullable && (o.Type == global::Newtonsoft.Json.Linq.JTokenType.Null || o.Type == global::Newtonsoft.Json.Linq.JTokenType.Undefined));
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0002B178 File Offset: 0x00029378
		public static explicit operator bool(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.BooleanTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Boolean.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return global::System.Convert.ToBoolean((int)value3);
			}
			return global::System.Convert.ToBoolean(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0002B1EC File Offset: 0x000293EC
		public static explicit operator global::System.DateTimeOffset(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.DateTimeTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.DateTimeOffset)
			{
				return (global::System.DateTimeOffset)value2;
			}
			string text = jvalue.Value as string;
			if (text != null)
			{
				return global::System.DateTimeOffset.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			return new global::System.DateTimeOffset(global::System.Convert.ToDateTime(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0002B274 File Offset: 0x00029474
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator bool?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.BooleanTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Boolean.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new bool?(global::System.Convert.ToBoolean((int)value3));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new bool?(global::System.Convert.ToBoolean(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0002B310 File Offset: 0x00029510
		public static explicit operator long(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Int64.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (long)value3;
			}
			return global::System.Convert.ToInt64(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0002B380 File Offset: 0x00029580
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator global::System.DateTime?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.DateTimeTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to DateTime.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.DateTimeOffset)
			{
				return new global::System.DateTime?(((global::System.DateTimeOffset)value2).DateTime);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new global::System.DateTime?(global::System.Convert.ToDateTime(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x0002B418 File Offset: 0x00029618
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator global::System.DateTimeOffset?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.DateTimeTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to DateTimeOffset.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.DateTimeOffset)
			{
				global::System.DateTimeOffset value3 = (global::System.DateTimeOffset)value2;
				return new global::System.DateTimeOffset?(value3);
			}
			string text = jvalue.Value as string;
			if (text != null)
			{
				return new global::System.DateTimeOffset?(global::System.DateTimeOffset.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture));
			}
			return new global::System.DateTimeOffset?(new global::System.DateTimeOffset(global::System.Convert.ToDateTime(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture)));
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0002B4D4 File Offset: 0x000296D4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator decimal?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Decimal.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new decimal?((decimal)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new decimal?(global::System.Convert.ToDecimal(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0002B56C File Offset: 0x0002976C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator double?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Double.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new double?((double)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new double?(global::System.Convert.ToDouble(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0002B604 File Offset: 0x00029804
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator char?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.CharTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Char.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new char?((char)((ushort)value3));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new char?(global::System.Convert.ToChar(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0002B69C File Offset: 0x0002989C
		public static explicit operator int(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Int32.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (int)value3;
			}
			return global::System.Convert.ToInt32(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0002B70C File Offset: 0x0002990C
		public static explicit operator short(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Int16.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (short)value3;
			}
			return global::System.Convert.ToInt16(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0002B77C File Offset: 0x0002997C
		[global::System.CLSCompliant(false)]
		public static explicit operator ushort(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to UInt16.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (ushort)value3;
			}
			return global::System.Convert.ToUInt16(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0002B7EC File Offset: 0x000299EC
		[global::System.CLSCompliant(false)]
		public static explicit operator char(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.CharTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Char.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (char)((ushort)value3);
			}
			return global::System.Convert.ToChar(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0002B85C File Offset: 0x00029A5C
		public static explicit operator byte(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Byte.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (byte)value3;
			}
			return global::System.Convert.ToByte(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0002B8CC File Offset: 0x00029ACC
		[global::System.CLSCompliant(false)]
		public static explicit operator sbyte(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to SByte.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (sbyte)value3;
			}
			return global::System.Convert.ToSByte(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0002B93C File Offset: 0x00029B3C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator int?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Int32.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new int?((int)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new int?(global::System.Convert.ToInt32(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0002B9D4 File Offset: 0x00029BD4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator short?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Int16.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new short?((short)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new short?(global::System.Convert.ToInt16(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0002BA6C File Offset: 0x00029C6C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.CLSCompliant(false)]
		public static explicit operator ushort?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to UInt16.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new ushort?((ushort)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new ushort?(global::System.Convert.ToUInt16(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0002BB04 File Offset: 0x00029D04
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator byte?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Byte.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new byte?((byte)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new byte?(global::System.Convert.ToByte(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0002BB9C File Offset: 0x00029D9C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.CLSCompliant(false)]
		public static explicit operator sbyte?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to SByte.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new sbyte?((sbyte)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new sbyte?(global::System.Convert.ToSByte(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002BC34 File Offset: 0x00029E34
		public static explicit operator global::System.DateTime(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.DateTimeTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to DateTime.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.DateTimeOffset)
			{
				return ((global::System.DateTimeOffset)value2).DateTime;
			}
			return global::System.Convert.ToDateTime(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0002BCA4 File Offset: 0x00029EA4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator long?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Int64.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new long?((long)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new long?(global::System.Convert.ToInt64(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0002BD3C File Offset: 0x00029F3C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator float?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Single.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new float?((float)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new float?(global::System.Convert.ToSingle(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0002BDD4 File Offset: 0x00029FD4
		public static explicit operator decimal(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Decimal.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (decimal)value3;
			}
			return global::System.Convert.ToDecimal(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002BE44 File Offset: 0x0002A044
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.CLSCompliant(false)]
		public static explicit operator uint?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to UInt32.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new uint?((uint)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new uint?(global::System.Convert.ToUInt32(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0002BEDC File Offset: 0x0002A0DC
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.CLSCompliant(false)]
		public static explicit operator ulong?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to UInt64.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return new ulong?((ulong)value3);
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new ulong?(global::System.Convert.ToUInt64(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0002BF74 File Offset: 0x0002A174
		public static explicit operator double(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Double.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (double)value3;
			}
			return global::System.Convert.ToDouble(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002BFE4 File Offset: 0x0002A1E4
		public static explicit operator float(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Single.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (float)value3;
			}
			return global::System.Convert.ToSingle(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x0002C054 File Offset: 0x0002A254
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator string(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.StringTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to String.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return global::System.Convert.ToBase64String(array);
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				return ((global::System.Numerics.BigInteger)value2).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			}
			return global::System.Convert.ToString(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x0002C0EC File Offset: 0x0002A2EC
		[global::System.CLSCompliant(false)]
		public static explicit operator uint(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to UInt32.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (uint)value3;
			}
			return global::System.Convert.ToUInt32(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x0002C15C File Offset: 0x0002A35C
		[global::System.CLSCompliant(false)]
		public static explicit operator ulong(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.NumberTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to UInt64.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value3 = (global::System.Numerics.BigInteger)value2;
				return (ulong)value3;
			}
			return global::System.Convert.ToUInt64(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0002C1CC File Offset: 0x0002A3CC
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator byte[](global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.BytesTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to byte array.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			if (jvalue.Value is string)
			{
				return global::System.Convert.FromBase64String(global::System.Convert.ToString(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Numerics.BigInteger)
			{
				return ((global::System.Numerics.BigInteger)value2).ToByteArray();
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return array;
			}
			throw new global::System.ArgumentException("Can not convert {0} to byte array.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x0002C280 File Offset: 0x0002A480
		public static explicit operator global::System.Guid(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.GuidTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Guid.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return new global::System.Guid(array);
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.Guid)
			{
				return (global::System.Guid)value2;
			}
			return new global::System.Guid(global::System.Convert.ToString(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0002C308 File Offset: 0x0002A508
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator global::System.Guid?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.GuidTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Guid.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			byte[] array = jvalue.Value as byte[];
			if (array != null)
			{
				return new global::System.Guid?(new global::System.Guid(array));
			}
			object value2 = jvalue.Value;
			global::System.Guid value3;
			if (value2 is global::System.Guid)
			{
				global::System.Guid guid = (global::System.Guid)value2;
				value3 = guid;
			}
			else
			{
				value3 = new global::System.Guid(global::System.Convert.ToString(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
			}
			return new global::System.Guid?(value3);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0002C3BC File Offset: 0x0002A5BC
		public static explicit operator global::System.TimeSpan(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.TimeSpanTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to TimeSpan.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			object value2 = jvalue.Value;
			if (value2 is global::System.TimeSpan)
			{
				return (global::System.TimeSpan)value2;
			}
			return global::Newtonsoft.Json.Utilities.ConvertUtils.ParseTimeSpan(global::System.Convert.ToString(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0002C42C File Offset: 0x0002A62C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator global::System.TimeSpan?(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.TimeSpanTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to TimeSpan.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			object value2 = jvalue.Value;
			global::System.TimeSpan value3;
			if (value2 is global::System.TimeSpan)
			{
				global::System.TimeSpan timeSpan = (global::System.TimeSpan)value2;
				value3 = timeSpan;
			}
			else
			{
				value3 = global::Newtonsoft.Json.Utilities.ConvertUtils.ParseTimeSpan(global::System.Convert.ToString(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
			}
			return new global::System.TimeSpan?(value3);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static explicit operator global::System.Uri(global::Newtonsoft.Json.Linq.JToken value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.UriTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to Uri.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			global::System.Uri uri = jvalue.Value as global::System.Uri;
			if (uri == null)
			{
				return new global::System.Uri(global::System.Convert.ToString(jvalue.Value, global::System.Globalization.CultureInfo.InvariantCulture));
			}
			return uri;
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0002C538 File Offset: 0x0002A738
		private static global::System.Numerics.BigInteger ToBigInteger(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.BigIntegerTypes, false))
			{
				throw new global::System.ArgumentException("Can not convert {0} to BigInteger.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			return global::Newtonsoft.Json.Utilities.ConvertUtils.ToBigInteger(jvalue.Value);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0002C584 File Offset: 0x0002A784
		private static global::System.Numerics.BigInteger? ToBigIntegerNullable(global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JToken.EnsureValue(value);
			if (jvalue == null || !global::Newtonsoft.Json.Linq.JToken.ValidateToken(jvalue, global::Newtonsoft.Json.Linq.JToken.BigIntegerTypes, true))
			{
				throw new global::System.ArgumentException("Can not convert {0} to BigInteger.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Linq.JToken.GetType(value)));
			}
			if (jvalue.Value == null)
			{
				return null;
			}
			return new global::System.Numerics.BigInteger?(global::Newtonsoft.Json.Utilities.ConvertUtils.ToBigInteger(jvalue.Value));
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x0002C5E6 File Offset: 0x0002A7E6
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(bool value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002C5EE File Offset: 0x0002A7EE
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(global::System.DateTimeOffset value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0002C5F6 File Offset: 0x0002A7F6
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(byte value)
		{
			return new global::Newtonsoft.Json.Linq.JValue((long)((ulong)value));
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x0002C5FF File Offset: 0x0002A7FF
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(byte? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0002C60C File Offset: 0x0002A80C
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(sbyte value)
		{
			return new global::Newtonsoft.Json.Linq.JValue((long)value);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0002C615 File Offset: 0x0002A815
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(sbyte? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0002C622 File Offset: 0x0002A822
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(bool? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0002C62F File Offset: 0x0002A82F
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(long value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0002C637 File Offset: 0x0002A837
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(global::System.DateTime? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0002C644 File Offset: 0x0002A844
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(global::System.DateTimeOffset? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0002C651 File Offset: 0x0002A851
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(decimal? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0002C65E File Offset: 0x0002A85E
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(double? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0002C66B File Offset: 0x0002A86B
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(short value)
		{
			return new global::Newtonsoft.Json.Linq.JValue((long)value);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0002C674 File Offset: 0x0002A874
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(ushort value)
		{
			return new global::Newtonsoft.Json.Linq.JValue((long)((ulong)value));
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0002C67D File Offset: 0x0002A87D
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(int value)
		{
			return new global::Newtonsoft.Json.Linq.JValue((long)value);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0002C686 File Offset: 0x0002A886
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(int? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0002C693 File Offset: 0x0002A893
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(global::System.DateTime value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0002C69B File Offset: 0x0002A89B
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(long? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0002C6A8 File Offset: 0x0002A8A8
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(float? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0002C6B5 File Offset: 0x0002A8B5
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(decimal value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0002C6BD File Offset: 0x0002A8BD
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(short? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0002C6CA File Offset: 0x0002A8CA
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(ushort? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0002C6D7 File Offset: 0x0002A8D7
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(uint? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0002C6E4 File Offset: 0x0002A8E4
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(ulong? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0002C6F1 File Offset: 0x0002A8F1
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(double value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0002C6F9 File Offset: 0x0002A8F9
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(float value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0002C701 File Offset: 0x0002A901
		public static implicit operator global::Newtonsoft.Json.Linq.JToken([global::System.Runtime.CompilerServices.Nullable(2)] string value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0002C709 File Offset: 0x0002A909
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(uint value)
		{
			return new global::Newtonsoft.Json.Linq.JValue((long)((ulong)value));
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0002C712 File Offset: 0x0002A912
		[global::System.CLSCompliant(false)]
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(ulong value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0002C71A File Offset: 0x0002A91A
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(byte[] value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0002C722 File Offset: 0x0002A922
		public static implicit operator global::Newtonsoft.Json.Linq.JToken([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Uri value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0002C72A File Offset: 0x0002A92A
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(global::System.TimeSpan value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0002C732 File Offset: 0x0002A932
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(global::System.TimeSpan? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0002C73F File Offset: 0x0002A93F
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(global::System.Guid value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0002C747 File Offset: 0x0002A947
		public static implicit operator global::Newtonsoft.Json.Linq.JToken(global::System.Guid? value)
		{
			return new global::Newtonsoft.Json.Linq.JValue(value);
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0002C754 File Offset: 0x0002A954
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)this).GetEnumerator();
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0002C75C File Offset: 0x0002A95C
		global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>.GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		// Token: 0x06000B3A RID: 2874
		internal abstract int GetDeepHashCode();

		// Token: 0x170001FF RID: 511
		global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken>.this[object key]
		{
			get
			{
				return this[key];
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0002C780 File Offset: 0x0002A980
		public global::Newtonsoft.Json.JsonReader CreateReader()
		{
			return new global::Newtonsoft.Json.Linq.JTokenReader(this);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x0002C788 File Offset: 0x0002A988
		internal static global::Newtonsoft.Json.Linq.JToken FromObjectInternal(object o, global::Newtonsoft.Json.JsonSerializer jsonSerializer)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(o, "o");
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
			global::Newtonsoft.Json.Linq.JToken token;
			using (global::Newtonsoft.Json.Linq.JTokenWriter jtokenWriter = new global::Newtonsoft.Json.Linq.JTokenWriter())
			{
				jsonSerializer.Serialize(jtokenWriter, o);
				token = jtokenWriter.Token;
			}
			return token;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0002C7E0 File Offset: 0x0002A9E0
		public static global::Newtonsoft.Json.Linq.JToken FromObject(object o)
		{
			return global::Newtonsoft.Json.Linq.JToken.FromObjectInternal(o, global::Newtonsoft.Json.JsonSerializer.CreateDefault());
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0002C7ED File Offset: 0x0002A9ED
		public static global::Newtonsoft.Json.Linq.JToken FromObject(object o, global::Newtonsoft.Json.JsonSerializer jsonSerializer)
		{
			return global::Newtonsoft.Json.Linq.JToken.FromObjectInternal(o, jsonSerializer);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0002C7F6 File Offset: 0x0002A9F6
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public T ToObject<T>()
		{
			return (T)((object)this.ToObject(typeof(T)));
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0002C810 File Offset: 0x0002AA10
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public object ToObject(global::System.Type objectType)
		{
			if (global::Newtonsoft.Json.JsonConvert.DefaultSettings == null)
			{
				bool flag;
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode = global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(objectType, out flag);
				if (flag)
				{
					if (this.Type == global::Newtonsoft.Json.Linq.JTokenType.String)
					{
						try
						{
							return this.ToObject(objectType, global::Newtonsoft.Json.JsonSerializer.CreateDefault());
						}
						catch (global::System.Exception innerException)
						{
							global::System.Type type = objectType.IsEnum() ? objectType : global::System.Nullable.GetUnderlyingType(objectType);
							throw new global::System.ArgumentException("Could not convert '{0}' to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, (string)this, type.Name), innerException);
						}
					}
					if (this.Type == global::Newtonsoft.Json.Linq.JTokenType.Integer)
					{
						return global::System.Enum.ToObject(objectType.IsEnum() ? objectType : global::System.Nullable.GetUnderlyingType(objectType), ((global::Newtonsoft.Json.Linq.JValue)this).Value);
					}
				}
				switch (typeCode)
				{
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char:
					return (char)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.CharNullable:
					return (char?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean:
					return (bool)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BooleanNullable:
					return (bool?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte:
					return (sbyte)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByteNullable:
					return (sbyte?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16:
					return (short)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16Nullable:
					return (short?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16:
					return (ushort)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16Nullable:
					return (ushort?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32:
					return (int)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32Nullable:
					return (int?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte:
					return (byte)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.ByteNullable:
					return (byte?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32:
					return (uint)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32Nullable:
					return (uint?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64:
					return (long)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64Nullable:
					return (long?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64:
					return (ulong)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64Nullable:
					return (ulong?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single:
					return (float)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SingleNullable:
					return (float?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double:
					return (double)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DoubleNullable:
					return (double?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime:
					return (global::System.DateTime)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeNullable:
					return (global::System.DateTime?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset:
					return (global::System.DateTimeOffset)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffsetNullable:
					return (global::System.DateTimeOffset?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Decimal:
					return (decimal)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DecimalNullable:
					return (decimal?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Guid:
					return (global::System.Guid)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.GuidNullable:
					return (global::System.Guid?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpan:
					return (global::System.TimeSpan)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpanNullable:
					return (global::System.TimeSpan?)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigInteger:
					return global::Newtonsoft.Json.Linq.JToken.ToBigInteger(this);
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigIntegerNullable:
					return global::Newtonsoft.Json.Linq.JToken.ToBigIntegerNullable(this);
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Uri:
					return (global::System.Uri)this;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.String:
					return (string)this;
				}
			}
			return this.ToObject(objectType, global::Newtonsoft.Json.JsonSerializer.CreateDefault());
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002CB34 File Offset: 0x0002AD34
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public T ToObject<T>([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonSerializer jsonSerializer)
		{
			return (T)((object)this.ToObject(typeof(T), jsonSerializer));
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0002CB4C File Offset: 0x0002AD4C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public object ToObject(global::System.Type objectType, global::Newtonsoft.Json.JsonSerializer jsonSerializer)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(jsonSerializer, "jsonSerializer");
			object result;
			using (global::Newtonsoft.Json.Linq.JTokenReader jtokenReader = new global::Newtonsoft.Json.Linq.JTokenReader(this))
			{
				result = jsonSerializer.Deserialize(jtokenReader, objectType);
			}
			return result;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0002CB94 File Offset: 0x0002AD94
		public static global::Newtonsoft.Json.Linq.JToken ReadFrom(global::Newtonsoft.Json.JsonReader reader)
		{
			return global::Newtonsoft.Json.Linq.JToken.ReadFrom(reader, null);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0002CBA0 File Offset: 0x0002ADA0
		public static global::Newtonsoft.Json.Linq.JToken ReadFrom(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(reader, "reader");
			bool flag;
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.None)
			{
				flag = ((settings != null && settings.CommentHandling == global::Newtonsoft.Json.Linq.CommentHandling.Ignore) ? reader.ReadAndMoveToContent() : reader.Read());
			}
			else
			{
				flag = (reader.TokenType != global::Newtonsoft.Json.JsonToken.Comment || settings == null || settings.CommentHandling != global::Newtonsoft.Json.Linq.CommentHandling.Ignore || reader.ReadAndMoveToContent());
			}
			if (!flag)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JToken from JsonReader.");
			}
			global::Newtonsoft.Json.IJsonLineInfo lineInfo = reader as global::Newtonsoft.Json.IJsonLineInfo;
			switch (reader.TokenType)
			{
			case global::Newtonsoft.Json.JsonToken.StartObject:
				return global::Newtonsoft.Json.Linq.JObject.Load(reader, settings);
			case global::Newtonsoft.Json.JsonToken.StartArray:
				return global::Newtonsoft.Json.Linq.JArray.Load(reader, settings);
			case global::Newtonsoft.Json.JsonToken.StartConstructor:
				return global::Newtonsoft.Json.Linq.JConstructor.Load(reader, settings);
			case global::Newtonsoft.Json.JsonToken.PropertyName:
				return global::Newtonsoft.Json.Linq.JProperty.Load(reader, settings);
			case global::Newtonsoft.Json.JsonToken.Comment:
			{
				global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JValue.CreateComment(reader.Value.ToString());
				jvalue.SetLineInfo(lineInfo, settings);
				return jvalue;
			}
			case global::Newtonsoft.Json.JsonToken.Integer:
			case global::Newtonsoft.Json.JsonToken.Float:
			case global::Newtonsoft.Json.JsonToken.String:
			case global::Newtonsoft.Json.JsonToken.Boolean:
			case global::Newtonsoft.Json.JsonToken.Date:
			case global::Newtonsoft.Json.JsonToken.Bytes:
			{
				global::Newtonsoft.Json.Linq.JValue jvalue2 = new global::Newtonsoft.Json.Linq.JValue(reader.Value);
				jvalue2.SetLineInfo(lineInfo, settings);
				return jvalue2;
			}
			case global::Newtonsoft.Json.JsonToken.Null:
			{
				global::Newtonsoft.Json.Linq.JValue jvalue3 = global::Newtonsoft.Json.Linq.JValue.CreateNull();
				jvalue3.SetLineInfo(lineInfo, settings);
				return jvalue3;
			}
			case global::Newtonsoft.Json.JsonToken.Undefined:
			{
				global::Newtonsoft.Json.Linq.JValue jvalue4 = global::Newtonsoft.Json.Linq.JValue.CreateUndefined();
				jvalue4.SetLineInfo(lineInfo, settings);
				return jvalue4;
			}
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JToken from JsonReader. Unexpected token: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0002CCEF File Offset: 0x0002AEEF
		public static global::Newtonsoft.Json.Linq.JToken Parse(string json)
		{
			return global::Newtonsoft.Json.Linq.JToken.Parse(json, null);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0002CCF8 File Offset: 0x0002AEF8
		public static global::Newtonsoft.Json.Linq.JToken Parse(string json, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			global::Newtonsoft.Json.Linq.JToken result;
			using (global::Newtonsoft.Json.JsonReader jsonReader = new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StringReader(json)))
			{
				global::Newtonsoft.Json.Linq.JToken jtoken = global::Newtonsoft.Json.Linq.JToken.Load(jsonReader, settings);
				while (jsonReader.Read())
				{
				}
				result = jtoken;
			}
			return result;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0002CD40 File Offset: 0x0002AF40
		public static global::Newtonsoft.Json.Linq.JToken Load(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			return global::Newtonsoft.Json.Linq.JToken.ReadFrom(reader, settings);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0002CD49 File Offset: 0x0002AF49
		public static global::Newtonsoft.Json.Linq.JToken Load(global::Newtonsoft.Json.JsonReader reader)
		{
			return global::Newtonsoft.Json.Linq.JToken.Load(reader, null);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0002CD52 File Offset: 0x0002AF52
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal void SetLineInfo(global::Newtonsoft.Json.IJsonLineInfo lineInfo, global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			if (settings != null && settings.LineInfoHandling != global::Newtonsoft.Json.Linq.LineInfoHandling.Load)
			{
				return;
			}
			if (lineInfo == null || !lineInfo.HasLineInfo())
			{
				return;
			}
			this.SetLineInfo(lineInfo.LineNumber, lineInfo.LinePosition);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0002CD7F File Offset: 0x0002AF7F
		internal void SetLineInfo(int lineNumber, int linePosition)
		{
			this.AddAnnotation(new global::Newtonsoft.Json.Linq.JToken.LineInfoAnnotation(lineNumber, linePosition));
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0002CD8E File Offset: 0x0002AF8E
		bool global::Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			return this.Annotation<global::Newtonsoft.Json.Linq.JToken.LineInfoAnnotation>() != null;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0002CD9C File Offset: 0x0002AF9C
		int global::Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			get
			{
				global::Newtonsoft.Json.Linq.JToken.LineInfoAnnotation lineInfoAnnotation = this.Annotation<global::Newtonsoft.Json.Linq.JToken.LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.LineNumber;
				}
				return 0;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002CDBC File Offset: 0x0002AFBC
		int global::Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			get
			{
				global::Newtonsoft.Json.Linq.JToken.LineInfoAnnotation lineInfoAnnotation = this.Annotation<global::Newtonsoft.Json.Linq.JToken.LineInfoAnnotation>();
				if (lineInfoAnnotation != null)
				{
					return lineInfoAnnotation.LinePosition;
				}
				return 0;
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0002CDDB File Offset: 0x0002AFDB
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JToken SelectToken(string path)
		{
			return this.SelectToken(path, null);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JToken SelectToken(string path, bool errorWhenNoMatch)
		{
			object obj;
			if (!errorWhenNoMatch)
			{
				obj = null;
			}
			else
			{
				(obj = new global::Newtonsoft.Json.Linq.JsonSelectSettings()).ErrorWhenNoMatch = true;
			}
			global::Newtonsoft.Json.Linq.JsonSelectSettings settings = obj;
			return this.SelectToken(path, settings);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0002CE10 File Offset: 0x0002B010
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public global::Newtonsoft.Json.Linq.JToken SelectToken([global::System.Runtime.CompilerServices.Nullable(1)] string path, global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			global::Newtonsoft.Json.Linq.JsonPath.JPath jpath = new global::Newtonsoft.Json.Linq.JsonPath.JPath(path);
			global::Newtonsoft.Json.Linq.JToken jtoken = null;
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken2 in jpath.Evaluate(this, this, settings))
			{
				if (jtoken != null)
				{
					throw new global::Newtonsoft.Json.JsonException("Path returned multiple tokens.");
				}
				jtoken = jtoken2;
			}
			return jtoken;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0002CE70 File Offset: 0x0002B070
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> SelectTokens(string path)
		{
			return this.SelectTokens(path, null);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002CE7C File Offset: 0x0002B07C
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> SelectTokens(string path, bool errorWhenNoMatch)
		{
			object obj;
			if (!errorWhenNoMatch)
			{
				obj = null;
			}
			else
			{
				(obj = new global::Newtonsoft.Json.Linq.JsonSelectSettings()).ErrorWhenNoMatch = true;
			}
			global::Newtonsoft.Json.Linq.JsonSelectSettings settings = obj;
			return this.SelectTokens(path, settings);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0002CEA4 File Offset: 0x0002B0A4
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> SelectTokens(string path, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			return new global::Newtonsoft.Json.Linq.JsonPath.JPath(path).Evaluate(this, this, settings);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0002CEB4 File Offset: 0x0002B0B4
		protected virtual global::System.Dynamic.DynamicMetaObject GetMetaObject(global::System.Linq.Expressions.Expression parameter)
		{
			return new global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<global::Newtonsoft.Json.Linq.JToken>(parameter, this, new global::Newtonsoft.Json.Utilities.DynamicProxy<global::Newtonsoft.Json.Linq.JToken>());
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0002CEC2 File Offset: 0x0002B0C2
		global::System.Dynamic.DynamicMetaObject global::System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(global::System.Linq.Expressions.Expression parameter)
		{
			return this.GetMetaObject(parameter);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0002CECB File Offset: 0x0002B0CB
		object global::System.ICloneable.Clone()
		{
			return this.DeepClone();
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0002CED3 File Offset: 0x0002B0D3
		public global::Newtonsoft.Json.Linq.JToken DeepClone()
		{
			return this.CloneToken();
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0002CEDC File Offset: 0x0002B0DC
		public void AddAnnotation(object annotation)
		{
			if (annotation == null)
			{
				throw new global::System.ArgumentNullException("annotation");
			}
			if (this._annotations == null)
			{
				object annotations;
				if (!(annotation is object[]))
				{
					annotations = annotation;
				}
				else
				{
					(annotations = new object[1])[0] = annotation;
				}
				this._annotations = annotations;
				return;
			}
			object[] array = this._annotations as object[];
			if (array == null)
			{
				this._annotations = new object[]
				{
					this._annotations,
					annotation
				};
				return;
			}
			int num = 0;
			while (num < array.Length && array[num] != null)
			{
				num++;
			}
			if (num == array.Length)
			{
				global::System.Array.Resize<object>(ref array, num * 2);
				this._annotations = array;
			}
			array[num] = annotation;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0002CF74 File Offset: 0x0002B174
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public T Annotation<T>() where T : class
		{
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					return this._annotations as T;
				}
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						return t;
					}
				}
			}
			return default(T);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0002CFE0 File Offset: 0x0002B1E0
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public object Annotation(global::System.Type type)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (type.IsInstanceOfType(this._annotations))
					{
						return this._annotations;
					}
				}
				else
				{
					foreach (object obj in array)
					{
						if (obj == null)
						{
							break;
						}
						if (type.IsInstanceOfType(obj))
						{
							return obj;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0002D04E File Offset: 0x0002B24E
		public global::System.Collections.Generic.IEnumerable<T> Annotations<T>() where T : class
		{
			if (this._annotations == null)
			{
				yield break;
			}
			object annotations2 = this._annotations;
			object[] annotations = annotations2 as object[];
			if (annotations != null)
			{
				int num;
				for (int i = 0; i < annotations.Length; i = num + 1)
				{
					object obj = annotations[i];
					if (obj == null)
					{
						break;
					}
					T t = obj as T;
					if (t != null)
					{
						yield return t;
					}
					num = i;
				}
				yield break;
			}
			T t2 = this._annotations as T;
			if (t2 == null)
			{
				yield break;
			}
			yield return t2;
			yield break;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0002D05E File Offset: 0x0002B25E
		public global::System.Collections.Generic.IEnumerable<object> Annotations(global::System.Type type)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			if (this._annotations == null)
			{
				yield break;
			}
			object annotations2 = this._annotations;
			object[] annotations = annotations2 as object[];
			if (annotations != null)
			{
				int num;
				for (int i = 0; i < annotations.Length; i = num + 1)
				{
					object obj = annotations[i];
					if (obj == null)
					{
						break;
					}
					if (type.IsInstanceOfType(obj))
					{
						yield return obj;
					}
					num = i;
				}
				yield break;
			}
			if (!type.IsInstanceOfType(this._annotations))
			{
				yield break;
			}
			yield return this._annotations;
			yield break;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0002D078 File Offset: 0x0002B278
		public void RemoveAnnotations<T>() where T : class
		{
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (this._annotations is T)
					{
						this._annotations = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!(obj is T))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this._annotations = null;
				}
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0002D0F4 File Offset: 0x0002B2F4
		public void RemoveAnnotations(global::System.Type type)
		{
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			if (this._annotations != null)
			{
				object[] array = this._annotations as object[];
				if (array == null)
				{
					if (type.IsInstanceOfType(this._annotations))
					{
						this._annotations = null;
						return;
					}
				}
				else
				{
					int i = 0;
					int j = 0;
					while (i < array.Length)
					{
						object obj = array[i];
						if (obj == null)
						{
							break;
						}
						if (!type.IsInstanceOfType(obj))
						{
							array[j++] = obj;
						}
						i++;
					}
					if (j != 0)
					{
						while (j < i)
						{
							array[j++] = null;
						}
						return;
					}
					this._annotations = null;
				}
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0002D184 File Offset: 0x0002B384
		internal void CopyAnnotations(global::Newtonsoft.Json.Linq.JToken target, global::Newtonsoft.Json.Linq.JToken source)
		{
			object[] array = source._annotations as object[];
			if (array != null)
			{
				target._annotations = array.ToArray<object>();
				return;
			}
			target._annotations = source._annotations;
		}

		// Token: 0x04000377 RID: 887
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private static global::Newtonsoft.Json.Linq.JTokenEqualityComparer _equalityComparer;

		// Token: 0x04000378 RID: 888
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Linq.JContainer _parent;

		// Token: 0x04000379 RID: 889
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Linq.JToken _previous;

		// Token: 0x0400037A RID: 890
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Linq.JToken _next;

		// Token: 0x0400037B RID: 891
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private object _annotations;

		// Token: 0x0400037C RID: 892
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] BooleanTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.Integer,
			global::Newtonsoft.Json.Linq.JTokenType.Float,
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw,
			global::Newtonsoft.Json.Linq.JTokenType.Boolean
		};

		// Token: 0x0400037D RID: 893
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] NumberTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.Integer,
			global::Newtonsoft.Json.Linq.JTokenType.Float,
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw,
			global::Newtonsoft.Json.Linq.JTokenType.Boolean
		};

		// Token: 0x0400037E RID: 894
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] BigIntegerTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.Integer,
			global::Newtonsoft.Json.Linq.JTokenType.Float,
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw,
			global::Newtonsoft.Json.Linq.JTokenType.Boolean,
			global::Newtonsoft.Json.Linq.JTokenType.Bytes
		};

		// Token: 0x0400037F RID: 895
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] StringTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.Date,
			global::Newtonsoft.Json.Linq.JTokenType.Integer,
			global::Newtonsoft.Json.Linq.JTokenType.Float,
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw,
			global::Newtonsoft.Json.Linq.JTokenType.Boolean,
			global::Newtonsoft.Json.Linq.JTokenType.Bytes,
			global::Newtonsoft.Json.Linq.JTokenType.Guid,
			global::Newtonsoft.Json.Linq.JTokenType.TimeSpan,
			global::Newtonsoft.Json.Linq.JTokenType.Uri
		};

		// Token: 0x04000380 RID: 896
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] GuidTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw,
			global::Newtonsoft.Json.Linq.JTokenType.Guid,
			global::Newtonsoft.Json.Linq.JTokenType.Bytes
		};

		// Token: 0x04000381 RID: 897
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] TimeSpanTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw,
			global::Newtonsoft.Json.Linq.JTokenType.TimeSpan
		};

		// Token: 0x04000382 RID: 898
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] UriTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw,
			global::Newtonsoft.Json.Linq.JTokenType.Uri
		};

		// Token: 0x04000383 RID: 899
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] CharTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.Integer,
			global::Newtonsoft.Json.Linq.JTokenType.Float,
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw
		};

		// Token: 0x04000384 RID: 900
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] DateTimeTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.Date,
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw
		};

		// Token: 0x04000385 RID: 901
		private static readonly global::Newtonsoft.Json.Linq.JTokenType[] BytesTypes = new global::Newtonsoft.Json.Linq.JTokenType[]
		{
			global::Newtonsoft.Json.Linq.JTokenType.Bytes,
			global::Newtonsoft.Json.Linq.JTokenType.String,
			global::Newtonsoft.Json.Linq.JTokenType.Comment,
			global::Newtonsoft.Json.Linq.JTokenType.Raw,
			global::Newtonsoft.Json.Linq.JTokenType.Integer
		};

		// Token: 0x020001CC RID: 460
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		private class LineInfoAnnotation
		{
			// Token: 0x06000FB4 RID: 4020 RVA: 0x00045292 File Offset: 0x00043492
			public LineInfoAnnotation(int lineNumber, int linePosition)
			{
				this.LineNumber = lineNumber;
				this.LinePosition = linePosition;
			}

			// Token: 0x040007C0 RID: 1984
			internal readonly int LineNumber;

			// Token: 0x040007C1 RID: 1985
			internal readonly int LinePosition;
		}
	}
}
