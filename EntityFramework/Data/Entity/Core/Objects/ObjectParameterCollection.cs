using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Text;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000419 RID: 1049
	public class ObjectParameterCollection : global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Objects.ObjectParameter>, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectParameter>, global::System.Collections.IEnumerable
	{
		// Token: 0x06003242 RID: 12866 RVA: 0x000A0828 File Offset: 0x0009EA28
		internal ObjectParameterCollection(global::System.Data.Entity.Core.Metadata.Edm.ClrPerspective perspective)
		{
			this._perspective = perspective;
			this._parameters = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.ObjectParameter>();
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003243 RID: 12867 RVA: 0x000A0842 File Offset: 0x0009EA42
		public int Count
		{
			get
			{
				return this._parameters.Count;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000A084F File Offset: 0x0009EA4F
		bool global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Objects.ObjectParameter>.IsReadOnly
		{
			get
			{
				return this._locked;
			}
		}

		// Token: 0x170009B8 RID: 2488
		public global::System.Data.Entity.Core.Objects.ObjectParameter this[string name]
		{
			get
			{
				int num = this.IndexOf(name);
				if (num == -1)
				{
					throw new global::System.ArgumentOutOfRangeException("name", global::System.Data.Entity.Resources.Strings.ObjectParameterCollection_ParameterNameNotFound(name));
				}
				return this._parameters[num];
			}
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x000A0890 File Offset: 0x0009EA90
		public void Add(global::System.Data.Entity.Core.Objects.ObjectParameter item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter>(item, "item");
			this.CheckUnlocked();
			if (this.Contains(item))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectParameterCollection_ParameterAlreadyExists(item.Name), "item");
			}
			if (this.Contains(item.Name))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectParameterCollection_DuplicateParameterName(item.Name), "item");
			}
			if (!item.ValidateParameterType(this._perspective))
			{
				throw new global::System.ArgumentOutOfRangeException("item", global::System.Data.Entity.Resources.Strings.ObjectParameter_InvalidParameterType(item.ParameterType.FullName));
			}
			this._parameters.Add(item);
			this._cacheKey = null;
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x000A092E File Offset: 0x0009EB2E
		public void Clear()
		{
			this.CheckUnlocked();
			this._parameters.Clear();
			this._cacheKey = null;
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x000A0948 File Offset: 0x0009EB48
		public bool Contains(global::System.Data.Entity.Core.Objects.ObjectParameter item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter>(item, "item");
			return this._parameters.Contains(item);
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x000A0962 File Offset: 0x0009EB62
		public bool Contains(string name)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			return this.IndexOf(name) != -1;
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x000A097D File Offset: 0x0009EB7D
		public void CopyTo(global::System.Data.Entity.Core.Objects.ObjectParameter[] array, int arrayIndex)
		{
			this._parameters.CopyTo(array, arrayIndex);
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x000A098C File Offset: 0x0009EB8C
		public bool Remove(global::System.Data.Entity.Core.Objects.ObjectParameter item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectParameter>(item, "item");
			this.CheckUnlocked();
			bool flag = this._parameters.Remove(item);
			if (flag)
			{
				this._cacheKey = null;
			}
			return flag;
		}

		// Token: 0x0600324C RID: 12876 RVA: 0x000A09B6 File Offset: 0x0009EBB6
		public virtual global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Objects.ObjectParameter> GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectParameter>)this._parameters).GetEnumerator();
		}

		// Token: 0x0600324D RID: 12877 RVA: 0x000A09C3 File Offset: 0x0009EBC3
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return ((global::System.Collections.IEnumerable)this._parameters).GetEnumerator();
		}

		// Token: 0x0600324E RID: 12878 RVA: 0x000A09D0 File Offset: 0x0009EBD0
		internal string GetCacheKey()
		{
			if (this._cacheKey == null && this._parameters.Count > 0)
			{
				if (1 == this._parameters.Count)
				{
					global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter = this._parameters[0];
					this._cacheKey = "@@1" + objectParameter.Name + ":" + objectParameter.ParameterType.FullName;
				}
				else
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(this._parameters.Count * 20);
					stringBuilder.Append("@@");
					stringBuilder.Append(this._parameters.Count);
					for (int i = 0; i < this._parameters.Count; i++)
					{
						if (i > 0)
						{
							stringBuilder.Append(";");
						}
						global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter2 = this._parameters[i];
						stringBuilder.Append(objectParameter2.Name);
						stringBuilder.Append(":");
						stringBuilder.Append(objectParameter2.ParameterType.FullName);
					}
					this._cacheKey = stringBuilder.ToString();
				}
			}
			return this._cacheKey;
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000A0AE1 File Offset: 0x0009ECE1
		internal void SetReadOnly(bool isReadOnly)
		{
			this._locked = isReadOnly;
		}

		// Token: 0x06003250 RID: 12880 RVA: 0x000A0AEC File Offset: 0x0009ECEC
		internal static global::System.Data.Entity.Core.Objects.ObjectParameterCollection DeepCopy(global::System.Data.Entity.Core.Objects.ObjectParameterCollection copyParams)
		{
			if (copyParams == null)
			{
				return null;
			}
			global::System.Data.Entity.Core.Objects.ObjectParameterCollection objectParameterCollection = new global::System.Data.Entity.Core.Objects.ObjectParameterCollection(copyParams._perspective);
			foreach (global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter in copyParams)
			{
				objectParameterCollection.Add(objectParameter.ShallowCopy());
			}
			return objectParameterCollection;
		}

		// Token: 0x06003251 RID: 12881 RVA: 0x000A0B4C File Offset: 0x0009ED4C
		private int IndexOf(string name)
		{
			int num = 0;
			foreach (global::System.Data.Entity.Core.Objects.ObjectParameter objectParameter in this._parameters)
			{
				if (string.Compare(name, objectParameter.Name, global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000A0BB4 File Offset: 0x0009EDB4
		private void CheckUnlocked()
		{
			if (this._locked)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectParameterCollection_ParametersLocked);
			}
		}

		// Token: 0x0400107B RID: 4219
		private bool _locked;

		// Token: 0x0400107C RID: 4220
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.ObjectParameter> _parameters;

		// Token: 0x0400107D RID: 4221
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ClrPerspective _perspective;

		// Token: 0x0400107E RID: 4222
		private string _cacheKey;
	}
}
