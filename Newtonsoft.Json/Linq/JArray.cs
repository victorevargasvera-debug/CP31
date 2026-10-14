using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000B9 RID: 185
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JArray : global::Newtonsoft.Json.Linq.JContainer, global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000983 RID: 2435 RVA: 0x00027DFC File Offset: 0x00025FFC
		public override global::System.Threading.Tasks.Task WriteToAsync(global::Newtonsoft.Json.JsonWriter writer, global::System.Threading.CancellationToken cancellationToken, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			global::Newtonsoft.Json.Linq.JArray.<WriteToAsync>d__0 <WriteToAsync>d__;
			<WriteToAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteToAsync>d__.<>4__this = this;
			<WriteToAsync>d__.writer = writer;
			<WriteToAsync>d__.cancellationToken = cancellationToken;
			<WriteToAsync>d__.converters = converters;
			<WriteToAsync>d__.<>1__state = -1;
			<WriteToAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JArray.<WriteToAsync>d__0>(ref <WriteToAsync>d__);
			return <WriteToAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00027E57 File Offset: 0x00026057
		public new static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JArray> LoadAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::Newtonsoft.Json.Linq.JArray.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00027E64 File Offset: 0x00026064
		public new static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JArray> LoadAsync(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Linq.JArray.<LoadAsync>d__2 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Newtonsoft.Json.Linq.JArray>.Create();
			<LoadAsync>d__.reader = reader;
			<LoadAsync>d__.settings = settings;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JArray.<LoadAsync>d__2>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00027EB7 File Offset: 0x000260B7
		protected override global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> ChildrenTokens
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00027EBF File Offset: 0x000260BF
		public override global::Newtonsoft.Json.Linq.JTokenType Type
		{
			get
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Array;
			}
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00027EC2 File Offset: 0x000260C2
		public JArray()
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00027ED5 File Offset: 0x000260D5
		public JArray(global::Newtonsoft.Json.Linq.JArray other) : base(other)
		{
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00027EE9 File Offset: 0x000260E9
		public JArray(params object[] content) : this(content)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00027EF2 File Offset: 0x000260F2
		public JArray(object content)
		{
			this.Add(content);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00027F0C File Offset: 0x0002610C
		internal override bool DeepEquals(global::Newtonsoft.Json.Linq.JToken node)
		{
			global::Newtonsoft.Json.Linq.JArray jarray = node as global::Newtonsoft.Json.Linq.JArray;
			return jarray != null && base.ContentsEqual(jarray);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00027F2C File Offset: 0x0002612C
		internal override global::Newtonsoft.Json.Linq.JToken CloneToken()
		{
			return new global::Newtonsoft.Json.Linq.JArray(this);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00027F34 File Offset: 0x00026134
		public new static global::Newtonsoft.Json.Linq.JArray Load(global::Newtonsoft.Json.JsonReader reader)
		{
			return global::Newtonsoft.Json.Linq.JArray.Load(reader, null);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00027F40 File Offset: 0x00026140
		public new static global::Newtonsoft.Json.Linq.JArray Load(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.None && !reader.Read())
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JArray from JsonReader.");
			}
			reader.MoveToContent();
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.StartArray)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JArray from JsonReader. Current JsonReader item is not an array: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
			}
			global::Newtonsoft.Json.Linq.JArray jarray = new global::Newtonsoft.Json.Linq.JArray();
			jarray.SetLineInfo(reader as global::Newtonsoft.Json.IJsonLineInfo, settings);
			jarray.ReadTokenFrom(reader, settings);
			return jarray;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00027FB4 File Offset: 0x000261B4
		public new static global::Newtonsoft.Json.Linq.JArray Parse(string json)
		{
			return global::Newtonsoft.Json.Linq.JArray.Parse(json, null);
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00027FC0 File Offset: 0x000261C0
		public new static global::Newtonsoft.Json.Linq.JArray Parse(string json, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			global::Newtonsoft.Json.Linq.JArray result;
			using (global::Newtonsoft.Json.JsonReader jsonReader = new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StringReader(json)))
			{
				global::Newtonsoft.Json.Linq.JArray jarray = global::Newtonsoft.Json.Linq.JArray.Load(jsonReader, settings);
				while (jsonReader.Read())
				{
				}
				result = jarray;
			}
			return result;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00028008 File Offset: 0x00026208
		public new static global::Newtonsoft.Json.Linq.JArray FromObject(object o)
		{
			return global::Newtonsoft.Json.Linq.JArray.FromObject(o, global::Newtonsoft.Json.JsonSerializer.CreateDefault());
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00028018 File Offset: 0x00026218
		public new static global::Newtonsoft.Json.Linq.JArray FromObject(object o, global::Newtonsoft.Json.JsonSerializer jsonSerializer)
		{
			global::Newtonsoft.Json.Linq.JToken jtoken = global::Newtonsoft.Json.Linq.JToken.FromObjectInternal(o, jsonSerializer);
			if (jtoken.Type != global::Newtonsoft.Json.Linq.JTokenType.Array)
			{
				throw new global::System.ArgumentException("Object serialized to {0}. JArray instance expected.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jtoken.Type));
			}
			return (global::Newtonsoft.Json.Linq.JArray)jtoken;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0002805C File Offset: 0x0002625C
		public override void WriteTo(global::Newtonsoft.Json.JsonWriter writer, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			writer.WriteStartArray();
			for (int i = 0; i < this._values.Count; i++)
			{
				this._values[i].WriteTo(writer, converters);
			}
			writer.WriteEndArray();
		}

		// Token: 0x170001BD RID: 445
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override global::Newtonsoft.Json.Linq.JToken this[object key]
		{
			[return: global::System.Runtime.CompilerServices.Nullable(2)]
			get
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(key, "key");
				if (!(key is int))
				{
					throw new global::System.ArgumentException("Accessed JArray values with invalid key value: {0}. Int32 array index expected.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ToString(key)));
				}
				return this.GetItem((int)key);
			}
			[param: global::System.Runtime.CompilerServices.Nullable(2)]
			set
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(key, "key");
				if (!(key is int))
				{
					throw new global::System.ArgumentException("Set JArray values with invalid key value: {0}. Int32 array index expected.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ToString(key)));
				}
				this.SetItem((int)key, value);
			}
		}

		// Token: 0x170001BE RID: 446
		public global::Newtonsoft.Json.Linq.JToken this[int index]
		{
			get
			{
				return this.GetItem(index);
			}
			set
			{
				this.SetItem(index, value);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0002812A File Offset: 0x0002632A
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override int IndexOfItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			if (item == null)
			{
				return -1;
			}
			return this._values.IndexOfReference(item);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00028140 File Offset: 0x00026340
		internal override void MergeItem(object content, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonMergeSettings settings)
		{
			global::System.Collections.IEnumerable enumerable = (base.IsMultiContent(content) || content is global::Newtonsoft.Json.Linq.JArray) ? ((global::System.Collections.IEnumerable)content) : null;
			if (enumerable == null)
			{
				return;
			}
			global::Newtonsoft.Json.Linq.JContainer.MergeEnumerableContent(this, enumerable, settings);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00028174 File Offset: 0x00026374
		public int IndexOf(global::Newtonsoft.Json.Linq.JToken item)
		{
			return this.IndexOfItem(item);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0002817D File Offset: 0x0002637D
		public void Insert(int index, global::Newtonsoft.Json.Linq.JToken item)
		{
			this.InsertItem(index, item, false);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00028189 File Offset: 0x00026389
		public void RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00028194 File Offset: 0x00026394
		public global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> GetEnumerator()
		{
			return this.Children().GetEnumerator();
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000281AF File Offset: 0x000263AF
		public void Add(global::Newtonsoft.Json.Linq.JToken item)
		{
			this.Add(item);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000281B8 File Offset: 0x000263B8
		public void Clear()
		{
			this.ClearItems();
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x000281C0 File Offset: 0x000263C0
		public bool Contains(global::Newtonsoft.Json.Linq.JToken item)
		{
			return this.ContainsItem(item);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000281C9 File Offset: 0x000263C9
		public void CopyTo(global::Newtonsoft.Json.Linq.JToken[] array, int arrayIndex)
		{
			this.CopyItemsTo(array, arrayIndex);
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x000281D3 File Offset: 0x000263D3
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000281D6 File Offset: 0x000263D6
		public bool Remove(global::Newtonsoft.Json.Linq.JToken item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000281DF File Offset: 0x000263DF
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x0400035E RID: 862
		private readonly global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken> _values = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken>();
	}
}
