using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BA RID: 186
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JConstructor : global::Newtonsoft.Json.Linq.JContainer
	{
		// Token: 0x060009A6 RID: 2470 RVA: 0x000281E8 File Offset: 0x000263E8
		public override global::System.Threading.Tasks.Task WriteToAsync(global::Newtonsoft.Json.JsonWriter writer, global::System.Threading.CancellationToken cancellationToken, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			global::Newtonsoft.Json.Linq.JConstructor.<WriteToAsync>d__0 <WriteToAsync>d__;
			<WriteToAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteToAsync>d__.<>4__this = this;
			<WriteToAsync>d__.writer = writer;
			<WriteToAsync>d__.cancellationToken = cancellationToken;
			<WriteToAsync>d__.converters = converters;
			<WriteToAsync>d__.<>1__state = -1;
			<WriteToAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JConstructor.<WriteToAsync>d__0>(ref <WriteToAsync>d__);
			return <WriteToAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00028243 File Offset: 0x00026443
		public new static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JConstructor> LoadAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::Newtonsoft.Json.Linq.JConstructor.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00028250 File Offset: 0x00026450
		public new static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JConstructor> LoadAsync(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Linq.JConstructor.<LoadAsync>d__2 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Newtonsoft.Json.Linq.JConstructor>.Create();
			<LoadAsync>d__.reader = reader;
			<LoadAsync>d__.settings = settings;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JConstructor.<LoadAsync>d__2>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x000282A3 File Offset: 0x000264A3
		protected override global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> ChildrenTokens
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000282AB File Offset: 0x000264AB
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override int IndexOfItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			if (item == null)
			{
				return -1;
			}
			return this._values.IndexOfReference(item);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000282C0 File Offset: 0x000264C0
		internal override void MergeItem(object content, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonMergeSettings settings)
		{
			global::Newtonsoft.Json.Linq.JConstructor jconstructor = content as global::Newtonsoft.Json.Linq.JConstructor;
			if (jconstructor == null)
			{
				return;
			}
			if (jconstructor.Name != null)
			{
				this.Name = jconstructor.Name;
			}
			global::Newtonsoft.Json.Linq.JContainer.MergeEnumerableContent(this, jconstructor, settings);
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x000282F4 File Offset: 0x000264F4
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x000282FC File Offset: 0x000264FC
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public string Name
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this._name;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				this._name = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00028305 File Offset: 0x00026505
		public override global::Newtonsoft.Json.Linq.JTokenType Type
		{
			get
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Constructor;
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00028308 File Offset: 0x00026508
		public JConstructor()
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002831B File Offset: 0x0002651B
		public JConstructor(global::Newtonsoft.Json.Linq.JConstructor other) : base(other)
		{
			this._name = other.Name;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0002833B File Offset: 0x0002653B
		public JConstructor(string name, params object[] content) : this(name, content)
		{
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00028345 File Offset: 0x00026545
		public JConstructor(string name, object content) : this(name)
		{
			this.Add(content);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00028355 File Offset: 0x00026555
		public JConstructor(string name)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new global::System.ArgumentException("Constructor name cannot be empty.", "name");
			}
			this._name = name;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00028398 File Offset: 0x00026598
		internal override bool DeepEquals(global::Newtonsoft.Json.Linq.JToken node)
		{
			global::Newtonsoft.Json.Linq.JConstructor jconstructor = node as global::Newtonsoft.Json.Linq.JConstructor;
			return jconstructor != null && this._name == jconstructor.Name && base.ContentsEqual(jconstructor);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000283CB File Offset: 0x000265CB
		internal override global::Newtonsoft.Json.Linq.JToken CloneToken()
		{
			return new global::Newtonsoft.Json.Linq.JConstructor(this);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x000283D4 File Offset: 0x000265D4
		public override void WriteTo(global::Newtonsoft.Json.JsonWriter writer, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			writer.WriteStartConstructor(this._name);
			int count = this._values.Count;
			for (int i = 0; i < count; i++)
			{
				this._values[i].WriteTo(writer, converters);
			}
			writer.WriteEndConstructor();
		}

		// Token: 0x170001C3 RID: 451
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override global::Newtonsoft.Json.Linq.JToken this[object key]
		{
			[return: global::System.Runtime.CompilerServices.Nullable(2)]
			get
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(key, "key");
				if (key is int)
				{
					int index = (int)key;
					return this.GetItem(index);
				}
				throw new global::System.ArgumentException("Accessed JConstructor values with invalid key value: {0}. Argument position index expected.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ToString(key)));
			}
			[param: global::System.Runtime.CompilerServices.Nullable(2)]
			set
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(key, "key");
				if (key is int)
				{
					int index = (int)key;
					this.SetItem(index, value);
					return;
				}
				throw new global::System.ArgumentException("Set JConstructor values with invalid key value: {0}. Argument position index expected.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ToString(key)));
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000284B8 File Offset: 0x000266B8
		internal override int GetDeepHashCode()
		{
			string name = this._name;
			return ((name != null) ? name.GetHashCode() : 0) ^ base.ContentsHashCode();
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x000284D3 File Offset: 0x000266D3
		public new static global::Newtonsoft.Json.Linq.JConstructor Load(global::Newtonsoft.Json.JsonReader reader)
		{
			return global::Newtonsoft.Json.Linq.JConstructor.Load(reader, null);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000284DC File Offset: 0x000266DC
		public new static global::Newtonsoft.Json.Linq.JConstructor Load(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.None && !reader.Read())
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JConstructor from JsonReader.");
			}
			reader.MoveToContent();
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.StartConstructor)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
			}
			global::Newtonsoft.Json.Linq.JConstructor jconstructor = new global::Newtonsoft.Json.Linq.JConstructor((string)reader.Value);
			jconstructor.SetLineInfo(reader as global::Newtonsoft.Json.IJsonLineInfo, settings);
			jconstructor.ReadTokenFrom(reader, settings);
			return jconstructor;
		}

		// Token: 0x0400035F RID: 863
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private string _name;

		// Token: 0x04000360 RID: 864
		private readonly global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken> _values = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken>();
	}
}
