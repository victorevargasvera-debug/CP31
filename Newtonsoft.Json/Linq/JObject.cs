using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BD RID: 189
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JObject : global::Newtonsoft.Json.Linq.JContainer, global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>, global::System.Collections.IEnumerable, global::System.ComponentModel.INotifyPropertyChanged, global::System.ComponentModel.ICustomTypeDescriptor, global::System.ComponentModel.INotifyPropertyChanging
	{
		// Token: 0x06000A28 RID: 2600 RVA: 0x0002972C File Offset: 0x0002792C
		public override global::System.Threading.Tasks.Task WriteToAsync(global::Newtonsoft.Json.JsonWriter writer, global::System.Threading.CancellationToken cancellationToken, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			global::System.Threading.Tasks.Task task = writer.WriteStartObjectAsync(cancellationToken);
			if (!task.IsCompletedSucessfully())
			{
				return this.<WriteToAsync>g__AwaitProperties|0_0(task, 0, writer, cancellationToken, converters);
			}
			for (int i = 0; i < this._properties.Count; i++)
			{
				task = this._properties[i].WriteToAsync(writer, cancellationToken, converters);
				if (!task.IsCompletedSucessfully())
				{
					return this.<WriteToAsync>g__AwaitProperties|0_0(task, i + 1, writer, cancellationToken, converters);
				}
			}
			return writer.WriteEndObjectAsync(cancellationToken);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002979D File Offset: 0x0002799D
		public new static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JObject> LoadAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::Newtonsoft.Json.Linq.JObject.LoadAsync(reader, null, cancellationToken);
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000297A8 File Offset: 0x000279A8
		public new static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JObject> LoadAsync(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Linq.JObject.<LoadAsync>d__2 <LoadAsync>d__;
			<LoadAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Newtonsoft.Json.Linq.JObject>.Create();
			<LoadAsync>d__.reader = reader;
			<LoadAsync>d__.settings = settings;
			<LoadAsync>d__.cancellationToken = cancellationToken;
			<LoadAsync>d__.<>1__state = -1;
			<LoadAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JObject.<LoadAsync>d__2>(ref <LoadAsync>d__);
			return <LoadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x000297FB File Offset: 0x000279FB
		protected override global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> ChildrenTokens
		{
			get
			{
				return this._properties;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000A2C RID: 2604 RVA: 0x00029804 File Offset: 0x00027A04
		// (remove) Token: 0x06000A2D RID: 2605 RVA: 0x0002983C File Offset: 0x00027A3C
		[global::System.Runtime.CompilerServices.Nullable(2)]
		[method: global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000A2E RID: 2606 RVA: 0x00029874 File Offset: 0x00027A74
		// (remove) Token: 0x06000A2F RID: 2607 RVA: 0x000298AC File Offset: 0x00027AAC
		[global::System.Runtime.CompilerServices.Nullable(2)]
		[method: global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public event global::System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

		// Token: 0x06000A30 RID: 2608 RVA: 0x000298E1 File Offset: 0x00027AE1
		public JObject()
		{
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x000298F4 File Offset: 0x00027AF4
		public JObject(global::Newtonsoft.Json.Linq.JObject other) : base(other)
		{
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00029908 File Offset: 0x00027B08
		public JObject(params object[] content) : this(content)
		{
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00029911 File Offset: 0x00027B11
		public JObject(object content)
		{
			this.Add(content);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0002992C File Offset: 0x00027B2C
		internal override bool DeepEquals(global::Newtonsoft.Json.Linq.JToken node)
		{
			global::Newtonsoft.Json.Linq.JObject jobject = node as global::Newtonsoft.Json.Linq.JObject;
			return jobject != null && this._properties.Compare(jobject._properties);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00029956 File Offset: 0x00027B56
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override int IndexOfItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			if (item == null)
			{
				return -1;
			}
			return this._properties.IndexOfReference(item);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00029969 File Offset: 0x00027B69
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal override bool InsertItem(int index, global::Newtonsoft.Json.Linq.JToken item, bool skipParentCheck)
		{
			return (item == null || item.Type != global::Newtonsoft.Json.Linq.JTokenType.Comment) && base.InsertItem(index, item, skipParentCheck);
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00029984 File Offset: 0x00027B84
		internal override void ValidateToken(global::Newtonsoft.Json.Linq.JToken o, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JToken existing)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(o, "o");
			if (o.Type != global::Newtonsoft.Json.Linq.JTokenType.Property)
			{
				throw new global::System.ArgumentException("Can not add {0} to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
			}
			global::Newtonsoft.Json.Linq.JProperty jproperty = (global::Newtonsoft.Json.Linq.JProperty)o;
			if (existing != null)
			{
				global::Newtonsoft.Json.Linq.JProperty jproperty2 = (global::Newtonsoft.Json.Linq.JProperty)existing;
				if (jproperty.Name == jproperty2.Name)
				{
					return;
				}
			}
			if (this._properties.TryGetValue(jproperty.Name, out existing))
			{
				throw new global::System.ArgumentException("Can not add property {0} to {1}. Property with the same name already exists on object.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jproperty.Name, base.GetType()));
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00029A24 File Offset: 0x00027C24
		internal override void MergeItem(object content, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonMergeSettings settings)
		{
			global::Newtonsoft.Json.Linq.JObject jobject = content as global::Newtonsoft.Json.Linq.JObject;
			if (jobject == null)
			{
				return;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> keyValuePair in jobject)
			{
				global::Newtonsoft.Json.Linq.JProperty jproperty = this.Property(keyValuePair.Key, (settings != null) ? settings.PropertyNameComparison : global::System.StringComparison.Ordinal);
				if (jproperty == null)
				{
					this.Add(keyValuePair.Key, keyValuePair.Value);
				}
				else if (keyValuePair.Value != null)
				{
					global::Newtonsoft.Json.Linq.JContainer jcontainer = jproperty.Value as global::Newtonsoft.Json.Linq.JContainer;
					if (jcontainer == null || jcontainer.Type != keyValuePair.Value.Type)
					{
						if (!global::Newtonsoft.Json.Linq.JObject.IsNull(keyValuePair.Value) || (settings != null && settings.MergeNullValueHandling == global::Newtonsoft.Json.Linq.MergeNullValueHandling.Merge))
						{
							jproperty.Value = keyValuePair.Value;
						}
					}
					else
					{
						jcontainer.Merge(keyValuePair.Value, settings);
					}
				}
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00029B10 File Offset: 0x00027D10
		private static bool IsNull(global::Newtonsoft.Json.Linq.JToken token)
		{
			if (token.Type == global::Newtonsoft.Json.Linq.JTokenType.Null)
			{
				return true;
			}
			global::Newtonsoft.Json.Linq.JValue jvalue = token as global::Newtonsoft.Json.Linq.JValue;
			return jvalue != null && jvalue.Value == null;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00029B40 File Offset: 0x00027D40
		internal void InternalPropertyChanged(global::Newtonsoft.Json.Linq.JProperty childProperty)
		{
			this.OnPropertyChanged(childProperty.Name);
			if (this._listChanged != null)
			{
				this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemChanged, this.IndexOfItem(childProperty)));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace, childProperty, childProperty, this.IndexOfItem(childProperty)));
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00029B91 File Offset: 0x00027D91
		internal void InternalPropertyChanging(global::Newtonsoft.Json.Linq.JProperty childProperty)
		{
			this.OnPropertyChanging(childProperty.Name);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00029B9F File Offset: 0x00027D9F
		internal override global::Newtonsoft.Json.Linq.JToken CloneToken()
		{
			return new global::Newtonsoft.Json.Linq.JObject(this);
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00029BA7 File Offset: 0x00027DA7
		public override global::Newtonsoft.Json.Linq.JTokenType Type
		{
			get
			{
				return global::Newtonsoft.Json.Linq.JTokenType.Object;
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00029BAA File Offset: 0x00027DAA
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JProperty> Properties()
		{
			return this._properties.Cast<global::Newtonsoft.Json.Linq.JProperty>();
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00029BB7 File Offset: 0x00027DB7
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JProperty Property(string name)
		{
			return this.Property(name, global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00029BC4 File Offset: 0x00027DC4
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JProperty Property(string name, global::System.StringComparison comparison)
		{
			if (name == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JToken jtoken;
			if (this._properties.TryGetValue(name, out jtoken))
			{
				return (global::Newtonsoft.Json.Linq.JProperty)jtoken;
			}
			if (comparison != global::System.StringComparison.Ordinal)
			{
				for (int i = 0; i < this._properties.Count; i++)
				{
					global::Newtonsoft.Json.Linq.JProperty jproperty = (global::Newtonsoft.Json.Linq.JProperty)this._properties[i];
					if (string.Equals(jproperty.Name, name, comparison))
					{
						return jproperty;
					}
				}
			}
			return null;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00029C2B File Offset: 0x00027E2B
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1
		})]
		public global::Newtonsoft.Json.Linq.JEnumerable<global::Newtonsoft.Json.Linq.JToken> PropertyValues()
		{
			return new global::Newtonsoft.Json.Linq.JEnumerable<global::Newtonsoft.Json.Linq.JToken>(from p in this.Properties()
			select p.Value);
		}

		// Token: 0x170001DC RID: 476
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override global::Newtonsoft.Json.Linq.JToken this[object key]
		{
			[return: global::System.Runtime.CompilerServices.Nullable(2)]
			get
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(key, "key");
				string text = key as string;
				if (text == null)
				{
					throw new global::System.ArgumentException("Accessed JObject values with invalid key value: {0}. Object property name expected.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ToString(key)));
				}
				return this[text];
			}
			[param: global::System.Runtime.CompilerServices.Nullable(2)]
			set
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(key, "key");
				string text = key as string;
				if (text == null)
				{
					throw new global::System.ArgumentException("Set JObject values with invalid key value: {0}. Object property name expected.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ToString(key)));
				}
				this[text] = value;
			}
		}

		// Token: 0x170001DD RID: 477
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JToken this[string propertyName]
		{
			[return: global::System.Runtime.CompilerServices.Nullable(2)]
			get
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(propertyName, "propertyName");
				global::Newtonsoft.Json.Linq.JProperty jproperty = this.Property(propertyName, global::System.StringComparison.Ordinal);
				if (jproperty == null)
				{
					return null;
				}
				return jproperty.Value;
			}
			[param: global::System.Runtime.CompilerServices.Nullable(2)]
			set
			{
				global::Newtonsoft.Json.Linq.JProperty jproperty = this.Property(propertyName, global::System.StringComparison.Ordinal);
				if (jproperty != null)
				{
					jproperty.Value = value;
					return;
				}
				this.OnPropertyChanging(propertyName);
				this.Add(propertyName, value);
				this.OnPropertyChanged(propertyName);
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00029D3F File Offset: 0x00027F3F
		public new static global::Newtonsoft.Json.Linq.JObject Load(global::Newtonsoft.Json.JsonReader reader)
		{
			return global::Newtonsoft.Json.Linq.JObject.Load(reader, null);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00029D48 File Offset: 0x00027F48
		public new static global::Newtonsoft.Json.Linq.JObject Load(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(reader, "reader");
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.None && !reader.Read())
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JObject from JsonReader.");
			}
			reader.MoveToContent();
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.StartObject)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
			}
			global::Newtonsoft.Json.Linq.JObject jobject = new global::Newtonsoft.Json.Linq.JObject();
			jobject.SetLineInfo(reader as global::Newtonsoft.Json.IJsonLineInfo, settings);
			jobject.ReadTokenFrom(reader, settings);
			return jobject;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00029DC7 File Offset: 0x00027FC7
		public new static global::Newtonsoft.Json.Linq.JObject Parse(string json)
		{
			return global::Newtonsoft.Json.Linq.JObject.Parse(json, null);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00029DD0 File Offset: 0x00027FD0
		public new static global::Newtonsoft.Json.Linq.JObject Parse(string json, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			global::Newtonsoft.Json.Linq.JObject result;
			using (global::Newtonsoft.Json.JsonReader jsonReader = new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StringReader(json)))
			{
				global::Newtonsoft.Json.Linq.JObject jobject = global::Newtonsoft.Json.Linq.JObject.Load(jsonReader, settings);
				while (jsonReader.Read())
				{
				}
				result = jobject;
			}
			return result;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00029E18 File Offset: 0x00028018
		public new static global::Newtonsoft.Json.Linq.JObject FromObject(object o)
		{
			return global::Newtonsoft.Json.Linq.JObject.FromObject(o, global::Newtonsoft.Json.JsonSerializer.CreateDefault());
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00029E28 File Offset: 0x00028028
		public new static global::Newtonsoft.Json.Linq.JObject FromObject(object o, global::Newtonsoft.Json.JsonSerializer jsonSerializer)
		{
			global::Newtonsoft.Json.Linq.JToken jtoken = global::Newtonsoft.Json.Linq.JToken.FromObjectInternal(o, jsonSerializer);
			if (jtoken.Type != global::Newtonsoft.Json.Linq.JTokenType.Object)
			{
				throw new global::System.ArgumentException("Object serialized to {0}. JObject instance expected.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jtoken.Type));
			}
			return (global::Newtonsoft.Json.Linq.JObject)jtoken;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00029E6C File Offset: 0x0002806C
		public override void WriteTo(global::Newtonsoft.Json.JsonWriter writer, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			writer.WriteStartObject();
			for (int i = 0; i < this._properties.Count; i++)
			{
				this._properties[i].WriteTo(writer, converters);
			}
			writer.WriteEndObject();
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00029EAE File Offset: 0x000280AE
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public global::Newtonsoft.Json.Linq.JToken GetValue(string propertyName)
		{
			return this.GetValue(propertyName, global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00029EB8 File Offset: 0x000280B8
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public global::Newtonsoft.Json.Linq.JToken GetValue(string propertyName, global::System.StringComparison comparison)
		{
			if (propertyName == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JProperty jproperty = this.Property(propertyName, comparison);
			if (jproperty == null)
			{
				return null;
			}
			return jproperty.Value;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00029ED2 File Offset: 0x000280D2
		public bool TryGetValue(string propertyName, global::System.StringComparison comparison, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::Newtonsoft.Json.Linq.JToken value)
		{
			value = this.GetValue(propertyName, comparison);
			return value != null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00029EE3 File Offset: 0x000280E3
		public void Add(string propertyName, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JToken value)
		{
			this.Add(new global::Newtonsoft.Json.Linq.JProperty(propertyName, value));
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00029EF2 File Offset: 0x000280F2
		public bool ContainsKey(string propertyName)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(propertyName, "propertyName");
			return this._properties.Contains(propertyName);
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00029F0B File Offset: 0x0002810B
		global::System.Collections.Generic.ICollection<string> global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Linq.JToken>.Keys
		{
			get
			{
				return this._properties.Keys;
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00029F18 File Offset: 0x00028118
		public bool Remove(string propertyName)
		{
			global::Newtonsoft.Json.Linq.JProperty jproperty = this.Property(propertyName, global::System.StringComparison.Ordinal);
			if (jproperty == null)
			{
				return false;
			}
			jproperty.Remove();
			return true;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00029F3C File Offset: 0x0002813C
		public bool TryGetValue(string propertyName, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::Newtonsoft.Json.Linq.JToken value)
		{
			global::Newtonsoft.Json.Linq.JProperty jproperty = this.Property(propertyName, global::System.StringComparison.Ordinal);
			if (jproperty == null)
			{
				value = null;
				return false;
			}
			value = jproperty.Value;
			return true;
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00029F63 File Offset: 0x00028163
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken> global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Linq.JToken>.Values
		{
			[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00029F6A File Offset: 0x0002816A
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>.Add([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1,
			2
		})] global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> item)
		{
			this.Add(new global::Newtonsoft.Json.Linq.JProperty(item.Key, item.Value));
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00029F85 File Offset: 0x00028185
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>.Clear()
		{
			base.RemoveAll();
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00029F90 File Offset: 0x00028190
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>.Contains([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1,
			2
		})] global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> item)
		{
			global::Newtonsoft.Json.Linq.JProperty jproperty = this.Property(item.Key, global::System.StringComparison.Ordinal);
			return jproperty != null && jproperty.Value == item.Value;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00029FC0 File Offset: 0x000281C0
		void global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>.CopyTo([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new global::System.ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (arrayIndex >= array.Length && arrayIndex != 0)
			{
				throw new global::System.ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (base.Count > array.Length - arrayIndex)
			{
				throw new global::System.ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in this._properties)
			{
				global::Newtonsoft.Json.Linq.JProperty jproperty = (global::Newtonsoft.Json.Linq.JProperty)jtoken;
				array[arrayIndex + num] = new global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>(jproperty.Name, jproperty.Value);
				num++;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0002A07C File Offset: 0x0002827C
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0002A07F File Offset: 0x0002827F
		bool global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>.Remove([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1,
			2
		})] global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> item)
		{
			if (!((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>>)this).Contains(item))
			{
				return false;
			}
			((global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Linq.JToken>)this).Remove(item.Key);
			return true;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0002A09B File Offset: 0x0002829B
		internal override int GetDeepHashCode()
		{
			return base.ContentsHashCode();
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0002A0A3 File Offset: 0x000282A3
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})]
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>> GetEnumerator()
		{
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in this._properties)
			{
				global::Newtonsoft.Json.Linq.JProperty jproperty = (global::Newtonsoft.Json.Linq.JProperty)jtoken;
				yield return new global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken>(jproperty.Name, jproperty.Value);
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0002A0B2 File Offset: 0x000282B2
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged == null)
			{
				return;
			}
			propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0002A0CB File Offset: 0x000282CB
		protected virtual void OnPropertyChanging(string propertyName)
		{
			global::System.ComponentModel.PropertyChangingEventHandler propertyChanging = this.PropertyChanging;
			if (propertyChanging == null)
			{
				return;
			}
			propertyChanging(this, new global::System.ComponentModel.PropertyChangingEventArgs(propertyName));
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0002A0E4 File Offset: 0x000282E4
		global::System.ComponentModel.PropertyDescriptorCollection global::System.ComponentModel.ICustomTypeDescriptor.GetProperties()
		{
			return ((global::System.ComponentModel.ICustomTypeDescriptor)this).GetProperties(null);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0002A0F0 File Offset: 0x000282F0
		global::System.ComponentModel.PropertyDescriptorCollection global::System.ComponentModel.ICustomTypeDescriptor.GetProperties(global::System.Attribute[] attributes)
		{
			global::System.ComponentModel.PropertyDescriptor[] array = new global::System.ComponentModel.PropertyDescriptor[base.Count];
			int num = 0;
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> keyValuePair in this)
			{
				array[num] = new global::Newtonsoft.Json.Linq.JPropertyDescriptor(keyValuePair.Key);
				num++;
			}
			return new global::System.ComponentModel.PropertyDescriptorCollection(array);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0002A158 File Offset: 0x00028358
		global::System.ComponentModel.AttributeCollection global::System.ComponentModel.ICustomTypeDescriptor.GetAttributes()
		{
			return global::System.ComponentModel.AttributeCollection.Empty;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0002A15F File Offset: 0x0002835F
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		string global::System.ComponentModel.ICustomTypeDescriptor.GetClassName()
		{
			return null;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0002A162 File Offset: 0x00028362
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		string global::System.ComponentModel.ICustomTypeDescriptor.GetComponentName()
		{
			return null;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0002A165 File Offset: 0x00028365
		global::System.ComponentModel.TypeConverter global::System.ComponentModel.ICustomTypeDescriptor.GetConverter()
		{
			return new global::System.ComponentModel.TypeConverter();
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0002A16C File Offset: 0x0002836C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		global::System.ComponentModel.EventDescriptor global::System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent()
		{
			return null;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0002A16F File Offset: 0x0002836F
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		global::System.ComponentModel.PropertyDescriptor global::System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty()
		{
			return null;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002A172 File Offset: 0x00028372
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		object global::System.ComponentModel.ICustomTypeDescriptor.GetEditor(global::System.Type editorBaseType)
		{
			return null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0002A175 File Offset: 0x00028375
		global::System.ComponentModel.EventDescriptorCollection global::System.ComponentModel.ICustomTypeDescriptor.GetEvents(global::System.Attribute[] attributes)
		{
			return global::System.ComponentModel.EventDescriptorCollection.Empty;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0002A17C File Offset: 0x0002837C
		global::System.ComponentModel.EventDescriptorCollection global::System.ComponentModel.ICustomTypeDescriptor.GetEvents()
		{
			return global::System.ComponentModel.EventDescriptorCollection.Empty;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0002A183 File Offset: 0x00028383
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		object global::System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(global::System.ComponentModel.PropertyDescriptor pd)
		{
			if (pd is global::Newtonsoft.Json.Linq.JPropertyDescriptor)
			{
				return this;
			}
			return null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0002A190 File Offset: 0x00028390
		protected override global::System.Dynamic.DynamicMetaObject GetMetaObject(global::System.Linq.Expressions.Expression parameter)
		{
			return new global::Newtonsoft.Json.Utilities.DynamicProxyMetaObject<global::Newtonsoft.Json.Linq.JObject>(parameter, this, new global::Newtonsoft.Json.Linq.JObject.JObjectDynamicProxy());
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0002A1A0 File Offset: 0x000283A0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Threading.Tasks.Task <WriteToAsync>g__AwaitProperties|0_0(global::System.Threading.Tasks.Task task, int i, global::Newtonsoft.Json.JsonWriter Writer, global::System.Threading.CancellationToken CancellationToken, global::Newtonsoft.Json.JsonConverter[] Converters)
		{
			global::Newtonsoft.Json.Linq.JObject.<<WriteToAsync>g__AwaitProperties|0_0>d <<WriteToAsync>g__AwaitProperties|0_0>d;
			<<WriteToAsync>g__AwaitProperties|0_0>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<<WriteToAsync>g__AwaitProperties|0_0>d.<>4__this = this;
			<<WriteToAsync>g__AwaitProperties|0_0>d.task = task;
			<<WriteToAsync>g__AwaitProperties|0_0>d.i = i;
			<<WriteToAsync>g__AwaitProperties|0_0>d.Writer = Writer;
			<<WriteToAsync>g__AwaitProperties|0_0>d.CancellationToken = CancellationToken;
			<<WriteToAsync>g__AwaitProperties|0_0>d.Converters = Converters;
			<<WriteToAsync>g__AwaitProperties|0_0>d.<>1__state = -1;
			<<WriteToAsync>g__AwaitProperties|0_0>d.<>t__builder.Start<global::Newtonsoft.Json.Linq.JObject.<<WriteToAsync>g__AwaitProperties|0_0>d>(ref <<WriteToAsync>g__AwaitProperties|0_0>d);
			return <<WriteToAsync>g__AwaitProperties|0_0>d.<>t__builder.Task;
		}

		// Token: 0x04000368 RID: 872
		private readonly global::Newtonsoft.Json.Linq.JPropertyKeyedCollection _properties = new global::Newtonsoft.Json.Linq.JPropertyKeyedCollection();

		// Token: 0x020001C3 RID: 451
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1
		})]
		private class JObjectDynamicProxy : global::Newtonsoft.Json.Utilities.DynamicProxy<global::Newtonsoft.Json.Linq.JObject>
		{
			// Token: 0x06000F8D RID: 3981 RVA: 0x0004464F File Offset: 0x0004284F
			public override bool TryGetMember(global::Newtonsoft.Json.Linq.JObject instance, global::System.Dynamic.GetMemberBinder binder, [global::System.Runtime.CompilerServices.Nullable(2)] out object result)
			{
				result = instance[binder.Name];
				return true;
			}

			// Token: 0x06000F8E RID: 3982 RVA: 0x00044660 File Offset: 0x00042860
			public override bool TrySetMember(global::Newtonsoft.Json.Linq.JObject instance, global::System.Dynamic.SetMemberBinder binder, object value)
			{
				global::Newtonsoft.Json.Linq.JToken jtoken = value as global::Newtonsoft.Json.Linq.JToken;
				if (jtoken == null)
				{
					jtoken = new global::Newtonsoft.Json.Linq.JValue(value);
				}
				instance[binder.Name] = jtoken;
				return true;
			}

			// Token: 0x06000F8F RID: 3983 RVA: 0x0004468C File Offset: 0x0004288C
			public override global::System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames(global::Newtonsoft.Json.Linq.JObject instance)
			{
				return from p in instance.Properties()
				select p.Name;
			}
		}
	}
}
