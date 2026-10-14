using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200030A RID: 778
	internal sealed class RelationshipEndCollection : global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>, global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>, global::System.Collections.IEnumerable
	{
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060024D1 RID: 9425 RVA: 0x00067955 File Offset: 0x00065B55
		public int Count
		{
			get
			{
				return this.KeysInDefOrder.Count;
			}
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00067964 File Offset: 0x00065B64
		public void Add(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement end2 = end as global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEndCollection.IsEndValid(end))
			{
				return;
			}
			if (!this.ValidateUniqueName(end2, end.Name))
			{
				return;
			}
			this.EndLookup.Add(end.Name, end);
			this.KeysInDefOrder.Add(end.Name);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x000679B4 File Offset: 0x00065BB4
		private static bool IsEndValid(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end)
		{
			return !string.IsNullOrEmpty(end.Name);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x000679C4 File Offset: 0x00065BC4
		private bool ValidateUniqueName(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement end, string name)
		{
			if (this.EndLookup.ContainsKey(name))
			{
				end.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EndNameAlreadyDefinedDuplicate(name));
				return false;
			}
			return true;
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000679E6 File Offset: 0x00065BE6
		public bool Remove(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end)
		{
			if (!global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEndCollection.IsEndValid(end))
			{
				return false;
			}
			this.KeysInDefOrder.Remove(end.Name);
			return this.EndLookup.Remove(end.Name);
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00067A15 File Offset: 0x00065C15
		public bool Contains(string name)
		{
			return this.EndLookup.ContainsKey(name);
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00067A23 File Offset: 0x00065C23
		public bool Contains(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end)
		{
			return this.Contains(end.Name);
		}

		// Token: 0x170007D4 RID: 2004
		public global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd this[int index]
		{
			get
			{
				return this.EndLookup[this.KeysInDefOrder[index]];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00067A51 File Offset: 0x00065C51
		public global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd> GetEnumerator()
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEndCollection.Enumerator(this.EndLookup, this.KeysInDefOrder);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x00067A64 File Offset: 0x00065C64
		public bool TryGetEnd(string name, out global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end)
		{
			return this.EndLookup.TryGetValue(name, out end);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00067A73 File Offset: 0x00065C73
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.RelationshipEndCollection.Enumerator(this.EndLookup, this.KeysInDefOrder);
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060024DD RID: 9437 RVA: 0x00067A86 File Offset: 0x00065C86
		private global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd> EndLookup
		{
			get
			{
				if (this._endLookup == null)
				{
					this._endLookup = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>(global::System.StringComparer.Ordinal);
				}
				return this._endLookup;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x00067AA6 File Offset: 0x00065CA6
		private global::System.Collections.Generic.List<string> KeysInDefOrder
		{
			get
			{
				if (this._keysInDefOrder == null)
				{
					this._keysInDefOrder = new global::System.Collections.Generic.List<string>();
				}
				return this._keysInDefOrder;
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00067AC1 File Offset: 0x00065CC1
		public void Clear()
		{
			this.EndLookup.Clear();
			this.KeysInDefOrder.Clear();
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x00067AD9 File Offset: 0x00065CD9
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00067ADC File Offset: 0x00065CDC
		int global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>.IndexOf(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00067AE3 File Offset: 0x00065CE3
		void global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>.Insert(int index, global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd end)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00067AEA File Offset: 0x00065CEA
		void global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00067AF4 File Offset: 0x00065CF4
		public void CopyTo(global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd[] ends, int index)
		{
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd relationshipEnd in this)
			{
				ends[index++] = relationshipEnd;
			}
		}

		// Token: 0x04000D0B RID: 3339
		private global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd> _endLookup;

		// Token: 0x04000D0C RID: 3340
		private global::System.Collections.Generic.List<string> _keysInDefOrder;

		// Token: 0x020009B5 RID: 2485
		private sealed class Enumerator : global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06005F4F RID: 24399 RVA: 0x00146F32 File Offset: 0x00145132
			public Enumerator(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd> data, global::System.Collections.Generic.List<string> keysInDefOrder)
			{
				this._Enumerator = keysInDefOrder.GetEnumerator();
				this._Data = data;
			}

			// Token: 0x06005F50 RID: 24400 RVA: 0x00146F4D File Offset: 0x0014514D
			public void Reset()
			{
				((global::System.Collections.IEnumerator)this._Enumerator).Reset();
			}

			// Token: 0x1700107E RID: 4222
			// (get) Token: 0x06005F51 RID: 24401 RVA: 0x00146F5F File Offset: 0x0014515F
			public global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd Current
			{
				get
				{
					return this._Data[this._Enumerator.Current];
				}
			}

			// Token: 0x1700107F RID: 4223
			// (get) Token: 0x06005F52 RID: 24402 RVA: 0x00146F77 File Offset: 0x00145177
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._Data[this._Enumerator.Current];
				}
			}

			// Token: 0x06005F53 RID: 24403 RVA: 0x00146F8F File Offset: 0x0014518F
			public bool MoveNext()
			{
				return this._Enumerator.MoveNext();
			}

			// Token: 0x06005F54 RID: 24404 RVA: 0x00146F9C File Offset: 0x0014519C
			public void Dispose()
			{
			}

			// Token: 0x04002801 RID: 10241
			private global::System.Collections.Generic.List<string>.Enumerator _Enumerator;

			// Token: 0x04002802 RID: 10242
			private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.IRelationshipEnd> _Data;
		}
	}
}
