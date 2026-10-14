using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C7 RID: 199
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JTokenReader : global::Newtonsoft.Json.JsonReader, global::Newtonsoft.Json.IJsonLineInfo
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0002D2C4 File Offset: 0x0002B4C4
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Linq.JToken CurrentToken
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this._current;
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0002D2CC File Offset: 0x0002B4CC
		public JTokenReader(global::Newtonsoft.Json.Linq.JToken token)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(token, "token");
			this._root = token;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0002D2E6 File Offset: 0x0002B4E6
		public JTokenReader(global::Newtonsoft.Json.Linq.JToken token, string initialPath) : this(token)
		{
			this._initialPath = initialPath;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0002D2F8 File Offset: 0x0002B4F8
		public override bool Read()
		{
			if (base.CurrentState != global::Newtonsoft.Json.JsonReader.State.Start)
			{
				if (this._current == null)
				{
					return false;
				}
				global::Newtonsoft.Json.Linq.JContainer jcontainer = this._current as global::Newtonsoft.Json.Linq.JContainer;
				if (jcontainer != null && this._parent != jcontainer)
				{
					return this.ReadInto(jcontainer);
				}
				return this.ReadOver(this._current);
			}
			else
			{
				if (this._current == this._root)
				{
					return false;
				}
				this._current = this._root;
				this.SetToken(this._current);
				return true;
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002D370 File Offset: 0x0002B570
		private bool ReadOver(global::Newtonsoft.Json.Linq.JToken t)
		{
			if (t == this._root)
			{
				return this.ReadToEnd();
			}
			global::Newtonsoft.Json.Linq.JToken next = t.Next;
			if (next != null && next != t && t != t.Parent.Last)
			{
				this._current = next;
				this.SetToken(this._current);
				return true;
			}
			if (t.Parent == null)
			{
				return this.ReadToEnd();
			}
			return this.SetEnd(t.Parent);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0002D3D9 File Offset: 0x0002B5D9
		private bool ReadToEnd()
		{
			this._current = null;
			base.SetToken(global::Newtonsoft.Json.JsonToken.None);
			return false;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0002D3EC File Offset: 0x0002B5EC
		private global::Newtonsoft.Json.JsonToken? GetEndToken(global::Newtonsoft.Json.Linq.JContainer c)
		{
			switch (c.Type)
			{
			case global::Newtonsoft.Json.Linq.JTokenType.Object:
				return new global::Newtonsoft.Json.JsonToken?(global::Newtonsoft.Json.JsonToken.EndObject);
			case global::Newtonsoft.Json.Linq.JTokenType.Array:
				return new global::Newtonsoft.Json.JsonToken?(global::Newtonsoft.Json.JsonToken.EndArray);
			case global::Newtonsoft.Json.Linq.JTokenType.Constructor:
				return new global::Newtonsoft.Json.JsonToken?(global::Newtonsoft.Json.JsonToken.EndConstructor);
			case global::Newtonsoft.Json.Linq.JTokenType.Property:
				return null;
			default:
				throw global::Newtonsoft.Json.Utilities.MiscellaneousUtils.CreateArgumentOutOfRangeException("Type", c.Type, "Unexpected JContainer type.");
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0002D458 File Offset: 0x0002B658
		private bool ReadInto(global::Newtonsoft.Json.Linq.JContainer c)
		{
			global::Newtonsoft.Json.Linq.JToken first = c.First;
			if (first == null)
			{
				return this.SetEnd(c);
			}
			this.SetToken(first);
			this._current = first;
			this._parent = c;
			return true;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0002D490 File Offset: 0x0002B690
		private bool SetEnd(global::Newtonsoft.Json.Linq.JContainer c)
		{
			global::Newtonsoft.Json.JsonToken? endToken = this.GetEndToken(c);
			if (endToken != null)
			{
				base.SetToken(endToken.GetValueOrDefault());
				this._current = c;
				this._parent = c;
				return true;
			}
			return this.ReadOver(c);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0002D4D4 File Offset: 0x0002B6D4
		private void SetToken(global::Newtonsoft.Json.Linq.JToken token)
		{
			switch (token.Type)
			{
			case global::Newtonsoft.Json.Linq.JTokenType.Object:
				base.SetToken(global::Newtonsoft.Json.JsonToken.StartObject);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Array:
				base.SetToken(global::Newtonsoft.Json.JsonToken.StartArray);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Constructor:
				base.SetToken(global::Newtonsoft.Json.JsonToken.StartConstructor, ((global::Newtonsoft.Json.Linq.JConstructor)token).Name);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Property:
				base.SetToken(global::Newtonsoft.Json.JsonToken.PropertyName, ((global::Newtonsoft.Json.Linq.JProperty)token).Name);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Comment:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Comment, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Integer:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Integer, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Float:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Float, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.String:
				base.SetToken(global::Newtonsoft.Json.JsonToken.String, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Boolean:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Boolean, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Null:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Null, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Undefined:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Undefined, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Date:
			{
				object obj = ((global::Newtonsoft.Json.Linq.JValue)token).Value;
				if (obj is global::System.DateTime)
				{
					global::System.DateTime value = (global::System.DateTime)obj;
					obj = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
				}
				base.SetToken(global::Newtonsoft.Json.JsonToken.Date, obj);
				return;
			}
			case global::Newtonsoft.Json.Linq.JTokenType.Raw:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Raw, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Bytes:
				base.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, ((global::Newtonsoft.Json.Linq.JValue)token).Value);
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Guid:
				base.SetToken(global::Newtonsoft.Json.JsonToken.String, this.SafeToString(((global::Newtonsoft.Json.Linq.JValue)token).Value));
				return;
			case global::Newtonsoft.Json.Linq.JTokenType.Uri:
			{
				object value2 = ((global::Newtonsoft.Json.Linq.JValue)token).Value;
				global::Newtonsoft.Json.JsonToken newToken = global::Newtonsoft.Json.JsonToken.String;
				global::System.Uri uri = value2 as global::System.Uri;
				base.SetToken(newToken, (uri != null) ? uri.OriginalString : this.SafeToString(value2));
				return;
			}
			case global::Newtonsoft.Json.Linq.JTokenType.TimeSpan:
				base.SetToken(global::Newtonsoft.Json.JsonToken.String, this.SafeToString(((global::Newtonsoft.Json.Linq.JValue)token).Value));
				return;
			default:
				throw global::Newtonsoft.Json.Utilities.MiscellaneousUtils.CreateArgumentOutOfRangeException("Type", token.Type, "Unexpected JTokenType.");
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0002D6D5 File Offset: 0x0002B8D5
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private string SafeToString(object value)
		{
			if (value == null)
			{
				return null;
			}
			return value.ToString();
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0002D6E4 File Offset: 0x0002B8E4
		bool global::Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			if (base.CurrentState == global::Newtonsoft.Json.JsonReader.State.Start)
			{
				return false;
			}
			global::Newtonsoft.Json.IJsonLineInfo current = this._current;
			return current != null && current.HasLineInfo();
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0002D710 File Offset: 0x0002B910
		int global::Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			get
			{
				if (base.CurrentState == global::Newtonsoft.Json.JsonReader.State.Start)
				{
					return 0;
				}
				global::Newtonsoft.Json.IJsonLineInfo current = this._current;
				if (current != null)
				{
					return current.LineNumber;
				}
				return 0;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0002D73C File Offset: 0x0002B93C
		int global::Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			get
			{
				if (base.CurrentState == global::Newtonsoft.Json.JsonReader.State.Start)
				{
					return 0;
				}
				global::Newtonsoft.Json.IJsonLineInfo current = this._current;
				if (current != null)
				{
					return current.LinePosition;
				}
				return 0;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002D768 File Offset: 0x0002B968
		public override string Path
		{
			get
			{
				string text = base.Path;
				if (this._initialPath == null)
				{
					this._initialPath = this._root.Path;
				}
				if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(this._initialPath))
				{
					if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(text))
					{
						return this._initialPath;
					}
					if (text.StartsWith('['))
					{
						text = this._initialPath + text;
					}
					else
					{
						text = this._initialPath + "." + text;
					}
				}
				return text;
			}
		}

		// Token: 0x04000386 RID: 902
		private readonly global::Newtonsoft.Json.Linq.JToken _root;

		// Token: 0x04000387 RID: 903
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private string _initialPath;

		// Token: 0x04000388 RID: 904
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Linq.JToken _parent;

		// Token: 0x04000389 RID: 905
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Linq.JToken _current;
	}
}
