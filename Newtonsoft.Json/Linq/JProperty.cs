using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BE RID: 190
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JProperty : global::Newtonsoft.Json.Linq.JContainer
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x0002A210 File Offset: 0x00028410
		public override global::System.Threading.Tasks.Task WriteToAsync(global::Newtonsoft.Json.JsonWriter writer, global::System.Threading.CancellationToken cancellationToken, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			global::System.Threading.Tasks.Task task = writer.WritePropertyNameAsync(this._name, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this.WriteValueAsync(writer, cancellationToken, converters);
			}
			return this.WriteToAsync(task, writer, cancellationToken, converters);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0002A248 File Offset: 0x00028448
		private global::System.Threading.Tasks.Task WriteToAsync(global::System.Threading.Tasks.Task task, global::Newtonsoft.Json.JsonWriter writer, global::System.Threading.CancellationToken cancellationToken, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			global::Newtonsoft.Json.Linq.JProperty.<WriteToAsync>d__1 <WriteToAsync>d__;
			<WriteToAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteToAsync>d__.<>4__this = this;
			<WriteToAsync>d__.task = task;
			<WriteToAsync>d__.writer = writer;
			<WriteToAsync>d__.cancellationToken = cancellationToken;
			<WriteToAsync>d__.converters = converters;
			<WriteToAsync>d__.<>1__state = -1;
			<WriteToAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JProperty.<WriteToAsync>d__1>(ref <WriteToAsync>d__);
			return <WriteToAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0002A2AC File Offset: 0x000284AC
		private global::System.Threading.Tasks.Task WriteValueAsync(global::Newtonsoft.Json.JsonWriter writer, global::System.Threading.CancellationToken cancellationToken, global::Newtonsoft.Json.JsonConverter[] converters)
		{
			global::Newtonsoft.Json.Linq.JToken value = this.Value;
			if (value == null)
			{
				return writer.WriteNullAsync(cancellationToken);
			}
			return value.WriteToAsync(writer, cancellationToken, converters);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0002A2D4 File Offset: 0x000284D4
		public new static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JProperty> LoadAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::Newtonsoft.Json.Linq.JProperty.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0002A2E0 File Offset: 0x000284E0
		public new static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JProperty> LoadAsync(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Linq.JProperty.<LoadAsync>d__4 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Newtonsoft.Json.Linq.JProperty>.Create();
			<LoadAsync>d__.reader = reader;
			<LoadAsync>d__.settings = settings;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JProperty.<LoadAsync>d__4>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0002A333 File Offset: 0x00028533
		protected override global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> ChildrenTokens
		{
			get
			{
				return this._content;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0002A33B File Offset: 0x0002853B
		public string Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return this._name;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0002A343 File Offset: 0x00028543
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0002A350 File Offset: 0x00028550
		public new global::Newtonsoft.Json.Linq.JToken Value
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return this._content._token;
			}
			set
			{
				base.CheckReentrancy();
				global::Newtonsoft.Json.Linq.JToken item = value ?? global::Newtonsoft.Json.Linq.JValue.CreateNull();
				if (this._content._token == null)
				{
					this.InsertItem(0, item, false);
					return;
				}
				this.SetItem(0, item);
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0002A38E File Offset: 0x0002858E
		public JProperty(global::Newtonsoft.Json.Linq.JProperty other) : base(other)
		{
			this._name = other.Name;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002A3AE File Offset: 0x000285AE
		internal override global::Newtonsoft.Json.Linq.JToken GetItem(int index)
		{
			if (index != 0)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			return this.Value;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002A3C0 File Offset: 0x000285C0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override void SetItem(int index, global::Newtonsoft.Json.Linq.JToken item)
		{
			if (index != 0)
			{
				throw new global::System.ArgumentOutOfRangeException();
			}
			if (global::Newtonsoft.Json.Linq.JContainer.IsTokenUnchanged(this.Value, item))
			{
				return;
			}
			global::Newtonsoft.Json.Linq.JObject jobject = (global::Newtonsoft.Json.Linq.JObject)base.Parent;
			if (jobject != null)
			{
				jobject.InternalPropertyChanging(this);
			}
			base.SetItem(0, item);
			global::Newtonsoft.Json.Linq.JObject jobject2 = (global::Newtonsoft.Json.Linq.JObject)base.Parent;
			if (jobject2 == null)
			{
				return;
			}
			jobject2.InternalPropertyChanged(this);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002A41A File Offset: 0x0002861A
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override bool RemoveItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			throw new global::Newtonsoft.Json.JsonException("Cannot add or remove items from {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeof(global::Newtonsoft.Json.Linq.JProperty)));
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0002A43A File Offset: 0x0002863A
		internal override void RemoveItemAt(int index)
		{
			throw new global::Newtonsoft.Json.JsonException("Cannot add or remove items from {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeof(global::Newtonsoft.Json.Linq.JProperty)));
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0002A45A File Offset: 0x0002865A
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override int IndexOfItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			if (item == null)
			{
				return -1;
			}
			return this._content.IndexOf(item);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0002A46D File Offset: 0x0002866D
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override bool InsertItem(int index, global::Newtonsoft.Json.Linq.JToken item, bool skipParentCheck)
		{
			if (item != null && item.Type == global::Newtonsoft.Json.Linq.JTokenType.Comment)
			{
				return false;
			}
			if (this.Value != null)
			{
				throw new global::Newtonsoft.Json.JsonException("{0} cannot have multiple values.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeof(global::Newtonsoft.Json.Linq.JProperty)));
			}
			return base.InsertItem(0, item, false);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0002A4AD File Offset: 0x000286AD
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override bool ContainsItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			return this.Value == item;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002A4B8 File Offset: 0x000286B8
		internal override void MergeItem(object content, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonMergeSettings settings)
		{
			global::Newtonsoft.Json.Linq.JProperty jproperty = content as global::Newtonsoft.Json.Linq.JProperty;
			global::Newtonsoft.Json.Linq.JToken jtoken = (jproperty != null) ? jproperty.Value : null;
			if (jtoken != null && jtoken.Type != global::Newtonsoft.Json.Linq.JTokenType.Null)
			{
				this.Value = jtoken;
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0002A4EC File Offset: 0x000286EC
		internal override void ClearItems()
		{
			throw new global::Newtonsoft.Json.JsonException("Cannot add or remove items from {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeof(global::Newtonsoft.Json.Linq.JProperty)));
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0002A50C File Offset: 0x0002870C
		internal override bool DeepEquals(global::Newtonsoft.Json.Linq.JToken node)
		{
			global::Newtonsoft.Json.Linq.JProperty jproperty = node as global::Newtonsoft.Json.Linq.JProperty;
			return jproperty != null && this._name == jproperty.Name && base.ContentsEqual(jproperty);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0002A53F File Offset: 0x0002873F
		internal override global::Newtonsoft.Json.Linq.JToken CloneToken()
		{
			return new global::Newtonsoft.Json.Linq.JProperty(this);
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0002A547 File Offset: 0x00028747
		public override global::Newtonsoft.Json.Linq.JTokenType Type
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Property;
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0002A54A File Offset: 0x0002874A
		internal JProperty(string name)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(name, "name");
			this._name = name;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0002A56F File Offset: 0x0002876F
		public JProperty(string name, params object[] content) : this(name, content)
		{
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0002A57C File Offset: 0x0002877C
		public JProperty(string name, [global::System.Runtime.CompilerServices.Nullable(2)] object content)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(name, "name");
			this._name = name;
			this.Value = (base.IsMultiContent(content) ? new global::Newtonsoft.Json.Linq.JArray(content) : global::Newtonsoft.Json.Linq.JContainer.CreateFromContent(content));
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0002A5CC File Offset: 0x000287CC
		public override void WriteTo(global::Newtonsoft.Json.JsonWriter writer, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			writer.WritePropertyName(this._name);
			global::Newtonsoft.Json.Linq.JToken value = this.Value;
			if (value != null)
			{
				value.WriteTo(writer, converters);
				return;
			}
			writer.WriteNull();
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0002A5FE File Offset: 0x000287FE
		internal override int GetDeepHashCode()
		{
			int hashCode = this._name.GetHashCode();
			global::Newtonsoft.Json.Linq.JToken value = this.Value;
			return hashCode ^ ((value != null) ? value.GetDeepHashCode() : 0);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0002A61E File Offset: 0x0002881E
		public new static global::Newtonsoft.Json.Linq.JProperty Load(global::Newtonsoft.Json.JsonReader reader)
		{
			return global::Newtonsoft.Json.Linq.JProperty.Load(reader, null);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0002A628 File Offset: 0x00028828
		public new static global::Newtonsoft.Json.Linq.JProperty Load(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.None && !reader.Read())
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JProperty from JsonReader.");
			}
			reader.MoveToContent();
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
			}
			global::Newtonsoft.Json.Linq.JProperty jproperty = new global::Newtonsoft.Json.Linq.JProperty((string)reader.Value);
			jproperty.SetLineInfo(reader as global::Newtonsoft.Json.IJsonLineInfo, settings);
			jproperty.ReadTokenFrom(reader, settings);
			return jproperty;
		}

		// Token: 0x0400036B RID: 875
		private readonly global::Newtonsoft.Json.Linq.JProperty.JPropertyList _content = new global::Newtonsoft.Json.Linq.JProperty.JPropertyList();

		// Token: 0x0400036C RID: 876
		private readonly string _name;

		// Token: 0x020001C8 RID: 456
		[global::System.Runtime.CompilerServices.Nullable(0)]
		private class JPropertyList : global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000F9F RID: 3999 RVA: 0x00044CA6 File Offset: 0x00042EA6
			public global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> GetEnumerator()
			{
				if (this._token != null)
				{
					yield return this._token;
				}
				yield break;
			}

			// Token: 0x06000FA0 RID: 4000 RVA: 0x00044CB5 File Offset: 0x00042EB5
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x06000FA1 RID: 4001 RVA: 0x00044CBD File Offset: 0x00042EBD
			public void Add(global::Newtonsoft.Json.Linq.JToken item)
			{
				this._token = item;
			}

			// Token: 0x06000FA2 RID: 4002 RVA: 0x00044CC6 File Offset: 0x00042EC6
			public void Clear()
			{
				this._token = null;
			}

			// Token: 0x06000FA3 RID: 4003 RVA: 0x00044CCF File Offset: 0x00042ECF
			public bool Contains(global::Newtonsoft.Json.Linq.JToken item)
			{
				return this._token == item;
			}

			// Token: 0x06000FA4 RID: 4004 RVA: 0x00044CDA File Offset: 0x00042EDA
			public void CopyTo(global::Newtonsoft.Json.Linq.JToken[] array, int arrayIndex)
			{
				if (this._token != null)
				{
					array[arrayIndex] = this._token;
				}
			}

			// Token: 0x06000FA5 RID: 4005 RVA: 0x00044CED File Offset: 0x00042EED
			public bool Remove(global::Newtonsoft.Json.Linq.JToken item)
			{
				if (this._token == item)
				{
					this._token = null;
					return true;
				}
				return false;
			}

			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00044D02 File Offset: 0x00042F02
			public int Count
			{
				get
				{
					if (this._token == null)
					{
						return 0;
					}
					return 1;
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00044D0F File Offset: 0x00042F0F
			public bool IsReadOnly
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000FA8 RID: 4008 RVA: 0x00044D12 File Offset: 0x00042F12
			public int IndexOf(global::Newtonsoft.Json.Linq.JToken item)
			{
				if (this._token != item)
				{
					return -1;
				}
				return 0;
			}

			// Token: 0x06000FA9 RID: 4009 RVA: 0x00044D20 File Offset: 0x00042F20
			public void Insert(int index, global::Newtonsoft.Json.Linq.JToken item)
			{
				if (index == 0)
				{
					this._token = item;
				}
			}

			// Token: 0x06000FAA RID: 4010 RVA: 0x00044D2C File Offset: 0x00042F2C
			public void RemoveAt(int index)
			{
				if (index == 0)
				{
					this._token = null;
				}
			}

			// Token: 0x170002A1 RID: 673
			public global::Newtonsoft.Json.Linq.JToken this[int index]
			{
				get
				{
					if (index != 0)
					{
						throw new global::System.IndexOutOfRangeException();
					}
					return this._token;
				}
				set
				{
					if (index != 0)
					{
						throw new global::System.IndexOutOfRangeException();
					}
					this._token = value;
				}
			}

			// Token: 0x040007A8 RID: 1960
			[global::System.Runtime.CompilerServices.Nullable(2)]
			internal global::Newtonsoft.Json.Linq.JToken _token;
		}
	}
}
