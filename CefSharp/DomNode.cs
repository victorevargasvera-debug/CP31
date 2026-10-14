using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CefSharp
{
	// Token: 0x02000022 RID: 34
	public class DomNode : global::CefSharp.IDomNode, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, string>>, global::System.Collections.IEnumerable
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00002E07 File Offset: 0x00001007
		public DomNode(string tagName, global::System.Collections.Generic.IDictionary<string, string> attributes)
		{
			this.TagName = tagName;
			this.attributes = attributes;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002E20 File Offset: 0x00001020
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.attributes != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.attributes)
				{
					stringBuilder.AppendFormat("{0}{1}:'{2}'", (0 < stringBuilder.Length) ? ", " : string.Empty, keyValuePair.Key, keyValuePair.Value);
				}
			}
			if (!string.IsNullOrWhiteSpace(this.TagName))
			{
				stringBuilder.Insert(0, string.Format("{0} ", this.TagName));
			}
			if (stringBuilder.Length < 1)
			{
				return base.ToString();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000040 RID: 64
		public string this[string name]
		{
			get
			{
				if (this.attributes == null || this.attributes.Count < 1 || !this.attributes.ContainsKey(name))
				{
					return null;
				}
				return this.attributes[name];
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002F14 File Offset: 0x00001114
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002F1C File Offset: 0x0000111C
		public string TagName { get; private set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002F25 File Offset: 0x00001125
		public global::System.Collections.ObjectModel.ReadOnlyCollection<string> AttributeNames
		{
			get
			{
				if (this.attributes == null)
				{
					return new global::System.Collections.ObjectModel.ReadOnlyCollection<string>(new global::System.Collections.Generic.List<string>());
				}
				return global::System.Array.AsReadOnly<string>(this.attributes.Keys.ToArray<string>());
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002F4F File Offset: 0x0000114F
		public bool HasAttribute(string attributeName)
		{
			return this.attributes != null && this.attributes.ContainsKey(attributeName);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002F67 File Offset: 0x00001167
		public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator()
		{
			if (this.attributes == null)
			{
				return new global::System.Collections.Generic.Dictionary<string, string>().GetEnumerator();
			}
			return this.attributes.GetEnumerator();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002F8C File Offset: 0x0000118C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000036 RID: 54
		private readonly global::System.Collections.Generic.IDictionary<string, string> attributes;
	}
}
