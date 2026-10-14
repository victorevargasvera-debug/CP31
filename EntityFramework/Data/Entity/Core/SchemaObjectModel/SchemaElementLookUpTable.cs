using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000314 RID: 788
	internal sealed class SchemaElementLookUpTable<T> : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Data.Entity.Core.SchemaObjectModel.ISchemaElementLookUpTable<T> where T : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x0006A72F File Offset: 0x0006892F
		public int Count
		{
			get
			{
				return this.KeyToType.Count;
			}
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x0006A73C File Offset: 0x0006893C
		public bool ContainsKey(string key)
		{
			return this.KeyToType.ContainsKey(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<T>.KeyFromName(key));
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x0006A750 File Offset: 0x00068950
		public T LookUpEquivalentKey(string key)
		{
			key = global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<T>.KeyFromName(key);
			T result;
			if (this.KeyToType.TryGetValue(key, out result))
			{
				return result;
			}
			return default(T);
		}

		// Token: 0x170007FC RID: 2044
		public T this[string key]
		{
			get
			{
				return this.KeyToType[global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<T>.KeyFromName(key)];
			}
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x0006A793 File Offset: 0x00068993
		public T GetElementAt(int index)
		{
			return this.KeyToType[this._keysInDefOrder[index]];
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x0006A7AC File Offset: 0x000689AC
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTableEnumerator<T, T>(this.KeyToType, this._keysInDefOrder);
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x0006A7BF File Offset: 0x000689BF
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTableEnumerator<T, T>(this.KeyToType, this._keysInDefOrder);
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x0006A7D2 File Offset: 0x000689D2
		public global::System.Collections.Generic.IEnumerator<S> GetFilteredEnumerator<S>() where S : T
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTableEnumerator<S, T>(this.KeyToType, this._keysInDefOrder);
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x0006A7E8 File Offset: 0x000689E8
		public global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind TryAdd(T type)
		{
			if (string.IsNullOrEmpty(type.Identity))
			{
				return global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind.MissingNameError;
			}
			string text = global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<T>.KeyFromElement(type);
			T t;
			if (this.KeyToType.TryGetValue(text, out t))
			{
				return global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind.DuplicateNameError;
			}
			this.KeyToType.Add(text, type);
			this._keysInDefOrder.Add(text);
			return global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind.Succeeded;
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x0006A83C File Offset: 0x00068A3C
		public void Add(T type, bool doNotAddErrorForEmptyName, global::System.Func<object, string> duplicateKeyErrorFormat)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind addErrorKind = this.TryAdd(type);
			if (addErrorKind == global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind.MissingNameError)
			{
				if (!doNotAddErrorForEmptyName)
				{
					type.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidName, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.MissingName);
				}
				return;
			}
			if (addErrorKind == global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind.DuplicateNameError)
			{
				type.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, duplicateKeyErrorFormat(type.FQName));
			}
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x0006A88F File Offset: 0x00068A8F
		private static string KeyFromElement(T type)
		{
			return global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<T>.KeyFromName(type.Identity);
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x0006A8A1 File Offset: 0x00068AA1
		private static string KeyFromName(string unnormalizedKey)
		{
			return unnormalizedKey;
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x0006A8A4 File Offset: 0x00068AA4
		private global::System.Collections.Generic.Dictionary<string, T> KeyToType
		{
			get
			{
				if (this._keyToType == null)
				{
					this._keyToType = new global::System.Collections.Generic.Dictionary<string, T>(global::System.StringComparer.Ordinal);
				}
				return this._keyToType;
			}
		}

		// Token: 0x04000D3D RID: 3389
		private global::System.Collections.Generic.Dictionary<string, T> _keyToType;

		// Token: 0x04000D3E RID: 3390
		private readonly global::System.Collections.Generic.List<string> _keysInDefOrder = new global::System.Collections.Generic.List<string>();
	}
}
