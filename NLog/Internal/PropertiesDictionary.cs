using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NLog.MessageTemplates;

namespace NLog.Internal
{
	// Token: 0x02000118 RID: 280
	internal sealed class PropertiesDictionary : global::System.Collections.Generic.IDictionary<object, object>, global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<object, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<object, object>>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<global::NLog.MessageTemplates.MessageTemplateParameter>
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x00020D18 File Offset: 0x0001EF18
		public PropertiesDictionary(global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> parameterList = null)
		{
			if (parameterList != null && parameterList.Count > 0)
			{
				global::NLog.MessageTemplates.MessageTemplateParameter[] array = new global::NLog.MessageTemplates.MessageTemplateParameter[parameterList.Count];
				for (int i = 0; i < parameterList.Count; i++)
				{
					array[i] = parameterList[i];
				}
				this.MessageProperties = array;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00020D69 File Offset: 0x0001EF69
		private bool IsEmpty
		{
			get
			{
				return (this._eventProperties == null || this._eventProperties.Count == 0) && (this._messageProperties == null || this._messageProperties.Count == 0);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00020D9C File Offset: 0x0001EF9C
		public global::System.Collections.IDictionary EventContext
		{
			get
			{
				global::System.Collections.IDictionary result;
				if ((result = this._eventContextAdapter) == null)
				{
					result = (this._eventContextAdapter = new global::NLog.Internal.DictionaryAdapter<object, object>(this));
				}
				return result;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00020DC4 File Offset: 0x0001EFC4
		private global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> EventProperties
		{
			get
			{
				if (this._eventProperties == null)
				{
					if (this._messageProperties != null && this._messageProperties.Count > 0)
					{
						this._eventProperties = new global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>(this._messageProperties.Count);
						if (!global::NLog.Internal.PropertiesDictionary.InsertMessagePropertiesIntoEmptyDictionary(this._messageProperties, this._eventProperties))
						{
							this._messageProperties = global::NLog.Internal.PropertiesDictionary.CreateUniqueMessagePropertiesListSlow(this._messageProperties, this._eventProperties);
						}
					}
					else
					{
						this._eventProperties = new global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>();
					}
				}
				return this._eventProperties;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000D4C RID: 3404 RVA: 0x00020E42 File Offset: 0x0001F042
		// (set) Token: 0x06000D4D RID: 3405 RVA: 0x00020E54 File Offset: 0x0001F054
		public global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> MessageProperties
		{
			get
			{
				return this._messageProperties ?? global::NLog.Internal.ArrayHelper.Empty<global::NLog.MessageTemplates.MessageTemplateParameter>();
			}
			internal set
			{
				if (this._eventProperties == null && global::NLog.Internal.PropertiesDictionary.VerifyUniqueMessageTemplateParametersFast(value))
				{
					this._messageProperties = value;
					return;
				}
				if (this._eventProperties == null)
				{
					this._eventProperties = new global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>(value.Count);
				}
				if (this._messageProperties != null && this._eventProperties.Count > 0)
				{
					for (int i = 0; i < this._messageProperties.Count; i++)
					{
						global::NLog.Internal.PropertiesDictionary.PropertyValue propertyValue;
						if (this._eventProperties.TryGetValue(this._messageProperties[i].Name, out propertyValue) && propertyValue.IsMessageProperty)
						{
							this._eventProperties.Remove(this._messageProperties[i].Name);
						}
					}
				}
				if (value != null && (this._eventProperties.Count > 0 || !global::NLog.Internal.PropertiesDictionary.InsertMessagePropertiesIntoEmptyDictionary(value, this._eventProperties)))
				{
					this._messageProperties = global::NLog.Internal.PropertiesDictionary.CreateUniqueMessagePropertiesListSlow(value, this._eventProperties);
					return;
				}
				this._messageProperties = value;
			}
		}

		// Token: 0x1700028E RID: 654
		public object this[object key]
		{
			get
			{
				global::NLog.Internal.PropertiesDictionary.PropertyValue propertyValue;
				if (!this.IsEmpty && this.EventProperties.TryGetValue(key, out propertyValue))
				{
					return propertyValue.Value;
				}
				throw new global::System.Collections.Generic.KeyNotFoundException();
			}
			set
			{
				this.EventProperties[key] = new global::NLog.Internal.PropertiesDictionary.PropertyValue(value, false);
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000D50 RID: 3408 RVA: 0x00020F8A File Offset: 0x0001F18A
		public global::System.Collections.Generic.ICollection<object> Keys
		{
			get
			{
				return this.KeyCollection;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00020F92 File Offset: 0x0001F192
		public global::System.Collections.Generic.ICollection<object> Values
		{
			get
			{
				return this.ValueCollection;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000D52 RID: 3410 RVA: 0x00020F9C File Offset: 0x0001F19C
		private global::NLog.Internal.PropertiesDictionary.DictionaryCollection KeyCollection
		{
			get
			{
				if (this._keyCollection != null)
				{
					return this._keyCollection;
				}
				if (this.IsEmpty)
				{
					return global::NLog.Internal.PropertiesDictionary.EmptyKeyCollection;
				}
				global::NLog.Internal.PropertiesDictionary.DictionaryCollection result;
				if ((result = this._keyCollection) == null)
				{
					result = (this._keyCollection = new global::NLog.Internal.PropertiesDictionary.DictionaryCollection(this, true));
				}
				return result;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00020FE0 File Offset: 0x0001F1E0
		private global::NLog.Internal.PropertiesDictionary.DictionaryCollection ValueCollection
		{
			get
			{
				if (this._valueCollection != null)
				{
					return this._valueCollection;
				}
				if (this.IsEmpty)
				{
					return global::NLog.Internal.PropertiesDictionary.EmptyValueCollection;
				}
				global::NLog.Internal.PropertiesDictionary.DictionaryCollection result;
				if ((result = this._valueCollection) == null)
				{
					result = (this._valueCollection = new global::NLog.Internal.PropertiesDictionary.DictionaryCollection(this, false));
				}
				return result;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000D54 RID: 3412 RVA: 0x00021024 File Offset: 0x0001F224
		public int Count
		{
			get
			{
				global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> eventProperties = this._eventProperties;
				if (eventProperties != null)
				{
					return eventProperties.Count;
				}
				global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> messageProperties = this._messageProperties;
				if (messageProperties == null)
				{
					return 0;
				}
				return messageProperties.Count;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x00021047 File Offset: 0x0001F247
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0002104A File Offset: 0x0001F24A
		public void Add(object key, object value)
		{
			this.EventProperties.Add(key, new global::NLog.Internal.PropertiesDictionary.PropertyValue(value, false));
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0002105F File Offset: 0x0001F25F
		public void Add(global::System.Collections.Generic.KeyValuePair<object, object> item)
		{
			this.Add(item.Key, item.Value);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00021075 File Offset: 0x0001F275
		public void Clear()
		{
			global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> eventProperties = this._eventProperties;
			if (eventProperties != null)
			{
				eventProperties.Clear();
			}
			if (this._messageProperties != null)
			{
				this._messageProperties = global::NLog.Internal.ArrayHelper.Empty<global::NLog.MessageTemplates.MessageTemplateParameter>();
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0002109C File Offset: 0x0001F29C
		public bool Contains(global::System.Collections.Generic.KeyValuePair<object, object> item)
		{
			if (!this.IsEmpty)
			{
				if (((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>>)this.EventProperties).Contains(new global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>(item.Key, new global::NLog.Internal.PropertiesDictionary.PropertyValue(item.Value, false))))
				{
					return true;
				}
				if (((global::System.Collections.Generic.ICollection<global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>>)this.EventProperties).Contains(new global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>(item.Key, new global::NLog.Internal.PropertiesDictionary.PropertyValue(item.Value, true))))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00021102 File Offset: 0x0001F302
		public bool ContainsKey(object key)
		{
			return !this.IsEmpty && this.EventProperties.ContainsKey(key);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0002111C File Offset: 0x0001F31C
		public void CopyTo(global::System.Collections.Generic.KeyValuePair<object, object>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new global::System.ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("arrayIndex");
			}
			if (!this.IsEmpty)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<object, object> keyValuePair in this)
				{
					array[arrayIndex++] = keyValuePair;
				}
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00021190 File Offset: 0x0001F390
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<object, object>> GetEnumerator()
		{
			if (this.IsEmpty)
			{
				return global::System.Linq.Enumerable.Empty<global::System.Collections.Generic.KeyValuePair<object, object>>().GetEnumerator();
			}
			return new global::NLog.Internal.PropertiesDictionary.DictionaryEnumerator(this);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000211AB File Offset: 0x0001F3AB
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			if (this.IsEmpty)
			{
				return global::NLog.Internal.ArrayHelper.Empty<global::System.Collections.Generic.KeyValuePair<object, object>>().GetEnumerator();
			}
			return new global::NLog.Internal.PropertiesDictionary.DictionaryEnumerator(this);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000211C6 File Offset: 0x0001F3C6
		public bool Remove(object key)
		{
			return !this.IsEmpty && this.EventProperties.Remove(key);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x000211E0 File Offset: 0x0001F3E0
		public bool Remove(global::System.Collections.Generic.KeyValuePair<object, object> item)
		{
			if (!this.IsEmpty)
			{
				if (((global::System.Collections.Generic.IDictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>)this.EventProperties).Remove(new global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>(item.Key, new global::NLog.Internal.PropertiesDictionary.PropertyValue(item.Value, false))))
				{
					return true;
				}
				if (((global::System.Collections.Generic.IDictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>)this.EventProperties).Remove(new global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>(item.Key, new global::NLog.Internal.PropertiesDictionary.PropertyValue(item.Value, true))))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00021250 File Offset: 0x0001F450
		public bool TryGetValue(object key, out object value)
		{
			global::NLog.Internal.PropertiesDictionary.PropertyValue propertyValue;
			if (!this.IsEmpty && this.EventProperties.TryGetValue(key, out propertyValue))
			{
				value = propertyValue.Value;
				return true;
			}
			value = null;
			return false;
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00021284 File Offset: 0x0001F484
		private static bool VerifyUniqueMessageTemplateParametersFast(global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> parameterList)
		{
			if (parameterList == null || parameterList.Count == 0)
			{
				return true;
			}
			if (parameterList.Count > 10)
			{
				return false;
			}
			for (int i = 0; i < parameterList.Count - 1; i++)
			{
				for (int j = i + 1; j < parameterList.Count; j++)
				{
					if (parameterList[i].Name == parameterList[j].Name)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x000212F8 File Offset: 0x0001F4F8
		private static bool InsertMessagePropertiesIntoEmptyDictionary(global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> messageProperties, global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> eventProperties)
		{
			bool result;
			try
			{
				for (int i = 0; i < messageProperties.Count; i++)
				{
					eventProperties.Add(messageProperties[i].Name, new global::NLog.Internal.PropertiesDictionary.PropertyValue(messageProperties[i].Value, true));
				}
				result = true;
			}
			catch (global::System.ArgumentException)
			{
				for (int j = 0; j < messageProperties.Count; j++)
				{
					eventProperties.Remove(messageProperties[j].Name);
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00021384 File Offset: 0x0001F584
		private static global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> CreateUniqueMessagePropertiesListSlow(global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> messageProperties, global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> eventProperties)
		{
			global::System.Collections.Generic.List<global::NLog.MessageTemplates.MessageTemplateParameter> list = null;
			for (int i = 0; i < messageProperties.Count; i++)
			{
				global::NLog.Internal.PropertiesDictionary.PropertyValue propertyValue;
				if (eventProperties.TryGetValue(messageProperties[i].Name, out propertyValue) && propertyValue.IsMessageProperty)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::NLog.MessageTemplates.MessageTemplateParameter>(messageProperties.Count);
						for (int j = 0; j < i; j++)
						{
							list.Add(messageProperties[j]);
						}
					}
				}
				else
				{
					eventProperties[messageProperties[i].Name] = new global::NLog.Internal.PropertiesDictionary.PropertyValue(messageProperties[i].Value, true);
					if (list != null)
					{
						list.Add(messageProperties[i]);
					}
				}
			}
			global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> list2 = list;
			return list2 ?? messageProperties;
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0002143E File Offset: 0x0001F63E
		global::System.Collections.Generic.IEnumerator<global::NLog.MessageTemplates.MessageTemplateParameter> global::System.Collections.Generic.IEnumerable<global::NLog.MessageTemplates.MessageTemplateParameter>.GetEnumerator()
		{
			return new global::NLog.Internal.PropertiesDictionary.ParameterEnumerator(this);
		}

		// Token: 0x040003AA RID: 938
		private global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> _eventProperties;

		// Token: 0x040003AB RID: 939
		private global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> _messageProperties;

		// Token: 0x040003AC RID: 940
		private global::NLog.Internal.PropertiesDictionary.DictionaryCollection _keyCollection;

		// Token: 0x040003AD RID: 941
		private global::NLog.Internal.PropertiesDictionary.DictionaryCollection _valueCollection;

		// Token: 0x040003AE RID: 942
		private global::System.Collections.IDictionary _eventContextAdapter;

		// Token: 0x040003AF RID: 943
		private static readonly global::NLog.Internal.PropertiesDictionary.DictionaryCollection EmptyKeyCollection = new global::NLog.Internal.PropertiesDictionary.DictionaryCollection(new global::NLog.Internal.PropertiesDictionary(null), true);

		// Token: 0x040003B0 RID: 944
		private static readonly global::NLog.Internal.PropertiesDictionary.DictionaryCollection EmptyValueCollection = new global::NLog.Internal.PropertiesDictionary.DictionaryCollection(new global::NLog.Internal.PropertiesDictionary(null), false);

		// Token: 0x0200020A RID: 522
		private struct PropertyValue
		{
			// Token: 0x060012D3 RID: 4819 RVA: 0x00030D33 File Offset: 0x0002EF33
			public PropertyValue(object value, bool isMessageProperty)
			{
				this.Value = value;
				this.IsMessageProperty = isMessageProperty;
			}

			// Token: 0x040005D4 RID: 1492
			public readonly object Value;

			// Token: 0x040005D5 RID: 1493
			public readonly bool IsMessageProperty;
		}

		// Token: 0x0200020B RID: 523
		private abstract class DictionaryEnumeratorBase : global::System.IDisposable
		{
			// Token: 0x060012D4 RID: 4820 RVA: 0x00030D43 File Offset: 0x0002EF43
			protected DictionaryEnumeratorBase(global::NLog.Internal.PropertiesDictionary dictionary)
			{
				this._dictionary = dictionary;
			}

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00030D54 File Offset: 0x0002EF54
			protected global::System.Collections.Generic.KeyValuePair<object, object> CurrentProperty
			{
				get
				{
					if (this._messagePropertiesEnumerator != null)
					{
						global::NLog.MessageTemplates.MessageTemplateParameter messageTemplateParameter = this._dictionary._messageProperties[this._messagePropertiesEnumerator.Value];
						return new global::System.Collections.Generic.KeyValuePair<object, object>(messageTemplateParameter.Name, messageTemplateParameter.Value);
					}
					if (this._eventEnumeratorCreated)
					{
						global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> keyValuePair = this._eventEnumerator.Current;
						object key = keyValuePair.Key;
						keyValuePair = this._eventEnumerator.Current;
						return new global::System.Collections.Generic.KeyValuePair<object, object>(key, keyValuePair.Value.Value);
					}
					throw new global::System.InvalidOperationException();
				}
			}

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x060012D6 RID: 4822 RVA: 0x00030DDC File Offset: 0x0002EFDC
			protected global::NLog.MessageTemplates.MessageTemplateParameter CurrentParameter
			{
				get
				{
					if (this._messagePropertiesEnumerator != null)
					{
						return this._dictionary._messageProperties[this._messagePropertiesEnumerator.Value];
					}
					if (this._eventEnumeratorCreated)
					{
						global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> keyValuePair;
						string text;
						try
						{
							keyValuePair = this._eventEnumerator.Current;
							text = global::NLog.Internal.XmlHelper.XmlConvertToString(keyValuePair.Key ?? string.Empty);
						}
						catch
						{
							text = "";
						}
						string name = text;
						keyValuePair = this._eventEnumerator.Current;
						return new global::NLog.MessageTemplates.MessageTemplateParameter(name, keyValuePair.Value.Value, null, global::NLog.MessageTemplates.CaptureType.Unknown);
					}
					throw new global::System.InvalidOperationException();
				}
			}

			// Token: 0x060012D7 RID: 4823 RVA: 0x00030E80 File Offset: 0x0002F080
			public bool MoveNext()
			{
				if (this._messagePropertiesEnumerator != null)
				{
					if (this._messagePropertiesEnumerator.Value + 1 < this._dictionary._messageProperties.Count)
					{
						this._messagePropertiesEnumerator = this.FindNextValidMessagePropertyIndex(this._messagePropertiesEnumerator.Value + 1);
						if (this._messagePropertiesEnumerator != null)
						{
							return true;
						}
						this._messagePropertiesEnumerator = new int?(this._dictionary._eventProperties.Count - 1);
					}
					if (this._dictionary._eventProperties != null && this._dictionary._eventProperties.Count > 0)
					{
						this._messagePropertiesEnumerator = null;
						this._eventEnumerator = this._dictionary._eventProperties.GetEnumerator();
						this._eventEnumeratorCreated = true;
						return this.MoveNextValidEventProperty();
					}
					return false;
				}
				else
				{
					if (this._eventEnumeratorCreated)
					{
						return this.MoveNextValidEventProperty();
					}
					if (this._dictionary._messageProperties != null && this._dictionary._messageProperties.Count > 0)
					{
						this._messagePropertiesEnumerator = this.FindNextValidMessagePropertyIndex(0);
						if (this._messagePropertiesEnumerator != null)
						{
							return true;
						}
					}
					if (this._dictionary._eventProperties != null && this._dictionary._eventProperties.Count > 0)
					{
						this._eventEnumerator = this._dictionary._eventProperties.GetEnumerator();
						this._eventEnumeratorCreated = true;
						return this.MoveNextValidEventProperty();
					}
					return false;
				}
			}

			// Token: 0x060012D8 RID: 4824 RVA: 0x00030FE4 File Offset: 0x0002F1E4
			private bool MoveNextValidEventProperty()
			{
				while (this._eventEnumerator.MoveNext())
				{
					global::System.Collections.Generic.KeyValuePair<object, global::NLog.Internal.PropertiesDictionary.PropertyValue> keyValuePair = this._eventEnumerator.Current;
					if (!keyValuePair.Value.IsMessageProperty)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x060012D9 RID: 4825 RVA: 0x00031020 File Offset: 0x0002F220
			private int? FindNextValidMessagePropertyIndex(int startIndex)
			{
				if (this._dictionary._eventProperties == null)
				{
					return new int?(startIndex);
				}
				for (int i = startIndex; i < this._dictionary._messageProperties.Count; i++)
				{
					global::NLog.Internal.PropertiesDictionary.PropertyValue propertyValue;
					if (this._dictionary._eventProperties.TryGetValue(this._dictionary._messageProperties[i].Name, out propertyValue) && propertyValue.IsMessageProperty)
					{
						return new int?(i);
					}
				}
				return null;
			}

			// Token: 0x060012DA RID: 4826 RVA: 0x000310A1 File Offset: 0x0002F2A1
			public void Dispose()
			{
			}

			// Token: 0x060012DB RID: 4827 RVA: 0x000310A3 File Offset: 0x0002F2A3
			public void Reset()
			{
				this._messagePropertiesEnumerator = null;
				this._eventEnumeratorCreated = false;
				this._eventEnumerator = default(global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>.Enumerator);
			}

			// Token: 0x040005D6 RID: 1494
			private readonly global::NLog.Internal.PropertiesDictionary _dictionary;

			// Token: 0x040005D7 RID: 1495
			private int? _messagePropertiesEnumerator;

			// Token: 0x040005D8 RID: 1496
			private bool _eventEnumeratorCreated;

			// Token: 0x040005D9 RID: 1497
			private global::System.Collections.Generic.Dictionary<object, global::NLog.Internal.PropertiesDictionary.PropertyValue>.Enumerator _eventEnumerator;
		}

		// Token: 0x0200020C RID: 524
		private class ParameterEnumerator : global::NLog.Internal.PropertiesDictionary.DictionaryEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::NLog.MessageTemplates.MessageTemplateParameter>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x1700037E RID: 894
			// (get) Token: 0x060012DC RID: 4828 RVA: 0x000310C4 File Offset: 0x0002F2C4
			public global::NLog.MessageTemplates.MessageTemplateParameter Current
			{
				get
				{
					return base.CurrentParameter;
				}
			}

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x060012DD RID: 4829 RVA: 0x000310CC File Offset: 0x0002F2CC
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return base.CurrentParameter;
				}
			}

			// Token: 0x060012DE RID: 4830 RVA: 0x000310D9 File Offset: 0x0002F2D9
			public ParameterEnumerator(global::NLog.Internal.PropertiesDictionary dictionary) : base(dictionary)
			{
			}
		}

		// Token: 0x0200020D RID: 525
		private class DictionaryEnumerator : global::NLog.Internal.PropertiesDictionary.DictionaryEnumeratorBase, global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<object, object>>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x17000380 RID: 896
			// (get) Token: 0x060012DF RID: 4831 RVA: 0x000310E2 File Offset: 0x0002F2E2
			public global::System.Collections.Generic.KeyValuePair<object, object> Current
			{
				get
				{
					return base.CurrentProperty;
				}
			}

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x060012E0 RID: 4832 RVA: 0x000310EA File Offset: 0x0002F2EA
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return base.CurrentProperty;
				}
			}

			// Token: 0x060012E1 RID: 4833 RVA: 0x000310F7 File Offset: 0x0002F2F7
			public DictionaryEnumerator(global::NLog.Internal.PropertiesDictionary dictionary) : base(dictionary)
			{
			}
		}

		// Token: 0x0200020E RID: 526
		private class DictionaryCollection : global::System.Collections.Generic.ICollection<object>, global::System.Collections.Generic.IEnumerable<object>, global::System.Collections.IEnumerable
		{
			// Token: 0x060012E2 RID: 4834 RVA: 0x00031100 File Offset: 0x0002F300
			public DictionaryCollection(global::NLog.Internal.PropertiesDictionary dictionary, bool keyCollection)
			{
				this._dictionary = dictionary;
				this._keyCollection = keyCollection;
			}

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00031116 File Offset: 0x0002F316
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x060012E4 RID: 4836 RVA: 0x00031123 File Offset: 0x0002F323
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060012E5 RID: 4837 RVA: 0x00031126 File Offset: 0x0002F326
			public void Add(object item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x060012E6 RID: 4838 RVA: 0x0003112D File Offset: 0x0002F32D
			public void Clear()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x060012E7 RID: 4839 RVA: 0x00031134 File Offset: 0x0002F334
			public bool Remove(object item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x060012E8 RID: 4840 RVA: 0x0003113C File Offset: 0x0002F33C
			public bool Contains(object item)
			{
				if (this._keyCollection)
				{
					return this._dictionary.ContainsKey(item);
				}
				if (!this._dictionary.IsEmpty)
				{
					if (this._dictionary.EventProperties.ContainsValue(new global::NLog.Internal.PropertiesDictionary.PropertyValue(item, false)))
					{
						return true;
					}
					if (this._dictionary.EventProperties.ContainsValue(new global::NLog.Internal.PropertiesDictionary.PropertyValue(item, true)))
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x060012E9 RID: 4841 RVA: 0x000311A4 File Offset: 0x0002F3A4
			public void CopyTo(object[] array, int arrayIndex)
			{
				if (array == null)
				{
					throw new global::System.ArgumentNullException("array");
				}
				if (arrayIndex < 0)
				{
					throw new global::System.ArgumentOutOfRangeException("arrayIndex");
				}
				if (!this._dictionary.IsEmpty)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<object, object> keyValuePair in this._dictionary)
					{
						array[arrayIndex++] = (this._keyCollection ? keyValuePair.Key : keyValuePair.Value);
					}
				}
			}

			// Token: 0x060012EA RID: 4842 RVA: 0x00031234 File Offset: 0x0002F434
			public global::System.Collections.Generic.IEnumerator<object> GetEnumerator()
			{
				return new global::NLog.Internal.PropertiesDictionary.DictionaryCollection.DictionaryCollectionEnumerator(this._dictionary, this._keyCollection);
			}

			// Token: 0x060012EB RID: 4843 RVA: 0x00031247 File Offset: 0x0002F447
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040005DA RID: 1498
			private readonly global::NLog.Internal.PropertiesDictionary _dictionary;

			// Token: 0x040005DB RID: 1499
			private readonly bool _keyCollection;

			// Token: 0x02000252 RID: 594
			private class DictionaryCollectionEnumerator : global::NLog.Internal.PropertiesDictionary.DictionaryEnumeratorBase, global::System.Collections.Generic.IEnumerator<object>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x060013E4 RID: 5092 RVA: 0x0003367A File Offset: 0x0003187A
				public DictionaryCollectionEnumerator(global::NLog.Internal.PropertiesDictionary dictionary, bool keyCollection) : base(dictionary)
				{
					this._keyCollection = keyCollection;
				}

				// Token: 0x170003A3 RID: 931
				// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0003368C File Offset: 0x0003188C
				public object Current
				{
					get
					{
						if (!this._keyCollection)
						{
							return base.CurrentProperty.Value;
						}
						return base.CurrentProperty.Key;
					}
				}

				// Token: 0x040006AF RID: 1711
				private readonly bool _keyCollection;
			}
		}
	}
}
