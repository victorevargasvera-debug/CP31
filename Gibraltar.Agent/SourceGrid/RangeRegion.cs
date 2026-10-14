using System;
using System.Collections;
using System.Collections.Generic;

namespace SourceGrid
{
	// Token: 0x020003C0 RID: 960
	internal class RangeRegion : global::System.Collections.Generic.ICollection<global::SourceGrid.Range>, global::System.Collections.Generic.IEnumerable<global::SourceGrid.Range>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002BC5 RID: 11205 RVA: 0x00092EA0 File Offset: 0x000910A0
		public RangeRegion()
		{
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x00092EB4 File Offset: 0x000910B4
		public RangeRegion(global::SourceGrid.Position position)
		{
			if (!position.IsEmpty())
			{
				this.m_RangeCollection.Add(new global::SourceGrid.Range(position));
			}
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x00092EE4 File Offset: 0x000910E4
		public RangeRegion(global::SourceGrid.Range range)
		{
			if (!range.IsEmpty())
			{
				this.m_RangeCollection.Add(range);
			}
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x00092F10 File Offset: 0x00091110
		public RangeRegion(global::SourceGrid.RangeRegion other)
		{
			this.m_RangeCollection.AddRange(other.m_RangeCollection);
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x00092F34 File Offset: 0x00091134
		public virtual bool IsEmpty()
		{
			return this.m_RangeCollection.Count == 0;
		}

		// Token: 0x17000CE9 RID: 3305
		public global::SourceGrid.Range this[int index]
		{
			get
			{
				return this.m_RangeCollection[index];
			}
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00092F5C File Offset: 0x0009115C
		public virtual global::SourceGrid.PositionCollection GetCellsPositions()
		{
			global::SourceGrid.PositionCollection positionCollection = new global::SourceGrid.PositionCollection();
			for (int i = 0; i < this.m_RangeCollection.Count; i++)
			{
				positionCollection.AddRange(this.m_RangeCollection[i].GetCellsPositions());
			}
			return positionCollection;
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00092FA8 File Offset: 0x000911A8
		public virtual int[] GetRowsIndex()
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			for (int i = 0; i < this.Count; i++)
			{
				for (int j = this[i].Start.Row; j <= this[i].End.Row; j++)
				{
					if (!arrayList.Contains(j))
					{
						arrayList.Add(j);
					}
				}
			}
			int[] array = new int[arrayList.Count];
			arrayList.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x0009304C File Offset: 0x0009124C
		public virtual int[] GetColumnsIndex()
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			for (int i = 0; i < this.Count; i++)
			{
				for (int j = this[i].Start.Column; j <= this[i].End.Column; j++)
				{
					if (!arrayList.Contains(j))
					{
						arrayList.Add(j);
					}
				}
			}
			int[] array = new int[arrayList.Count];
			arrayList.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000930F0 File Offset: 0x000912F0
		public virtual bool Contains(global::SourceGrid.Position p_Cell)
		{
			if (p_Cell.IsEmpty() || this.IsEmpty())
			{
				return false;
			}
			for (int i = 0; i < this.m_RangeCollection.Count; i++)
			{
				if (this.m_RangeCollection[i].Contains(p_Cell))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00093150 File Offset: 0x00091350
		public virtual bool Contains(global::SourceGrid.Range p_Range)
		{
			if (p_Range.IsEmpty() || this.IsEmpty())
			{
				return false;
			}
			if (p_Range.ColumnsCount == 1 && p_Range.RowsCount == 1)
			{
				return this.Contains(p_Range.Start);
			}
			for (int i = 0; i < this.m_RangeCollection.Count; i++)
			{
				if (this.m_RangeCollection[i].Contains(p_Range))
				{
					return true;
				}
			}
			global::SourceGrid.PositionCollection cellsPositions = p_Range.GetCellsPositions();
			for (int j = 0; j < cellsPositions.Count; j++)
			{
				if (!this.Contains(cellsPositions[j]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00093208 File Offset: 0x00091408
		public virtual bool Contains(global::SourceGrid.RangeRegion p_Range)
		{
			if (p_Range.IsEmpty() || this.IsEmpty())
			{
				return false;
			}
			global::SourceGrid.PositionCollection cellsPositions = p_Range.GetCellsPositions();
			for (int i = 0; i < cellsPositions.Count; i++)
			{
				if (!this.Contains(cellsPositions[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00093264 File Offset: 0x00091464
		public virtual bool ContainsRow(int p_Row)
		{
			if (this.IsEmpty())
			{
				return false;
			}
			for (int i = 0; i < this.m_RangeCollection.Count; i++)
			{
				if (this.m_RangeCollection[i].ContainsRow(p_Row))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000932B8 File Offset: 0x000914B8
		public virtual bool ContainsColumn(int p_Column)
		{
			if (this.IsEmpty())
			{
				return false;
			}
			for (int i = 0; i < this.m_RangeCollection.Count; i++)
			{
				if (this.m_RangeCollection[i].ContainsColumn(p_Column))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x0009330C File Offset: 0x0009150C
		public virtual bool IntersectsWith(global::SourceGrid.Range p_Range)
		{
			if (p_Range.IsEmpty() || this.IsEmpty())
			{
				return false;
			}
			global::SourceGrid.RangeRegion rangeRegion = this.Intersect(p_Range);
			return !rangeRegion.IsEmpty();
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x00093348 File Offset: 0x00091548
		public virtual global::SourceGrid.RangeRegion Intersect(global::SourceGrid.Range p_Range)
		{
			global::SourceGrid.RangeRegion rangeRegion = new global::SourceGrid.RangeRegion();
			if (!p_Range.IsEmpty() && !this.IsEmpty())
			{
				for (int i = 0; i < this.m_RangeCollection.Count; i++)
				{
					global::SourceGrid.Range item = p_Range.Intersect(this.m_RangeCollection[i]);
					if (!item.IsEmpty())
					{
						rangeRegion.m_RangeCollection.Add(item);
					}
				}
			}
			return rangeRegion;
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000933BC File Offset: 0x000915BC
		public global::SourceGrid.RangeRegion Intersect(global::SourceGrid.RangeRegion pRange)
		{
			global::SourceGrid.RangeRegion rangeRegion = new global::SourceGrid.RangeRegion();
			for (int i = 0; i < pRange.m_RangeCollection.Count; i++)
			{
				global::SourceGrid.Range p_Range = pRange.m_RangeCollection[i];
				global::SourceGrid.RangeRegion rangeRegion2 = this.Intersect(p_Range);
				rangeRegion.m_RangeCollection.AddRange(rangeRegion2.m_RangeCollection);
			}
			return rangeRegion;
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x00093414 File Offset: 0x00091614
		public global::SourceGrid.RangeRegion Exclude(global::SourceGrid.Range pRange)
		{
			global::SourceGrid.RangeRegion rangeRegion = new global::SourceGrid.RangeRegion();
			for (int i = 0; i < this.m_RangeCollection.Count; i++)
			{
				global::SourceGrid.RangeRegion rangeRegion2 = this.m_RangeCollection[i].Exclude(pRange);
				rangeRegion.m_RangeCollection.AddRange(rangeRegion2.m_RangeCollection);
			}
			return rangeRegion;
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x0009346C File Offset: 0x0009166C
		public global::SourceGrid.RangeRegion Exclude(global::SourceGrid.RangeRegion pRange)
		{
			global::SourceGrid.RangeRegion rangeRegion = new global::SourceGrid.RangeRegion(this);
			if (!rangeRegion.IsEmpty())
			{
				for (int i = 0; i < pRange.m_RangeCollection.Count; i++)
				{
					rangeRegion = rangeRegion.Exclude(pRange.m_RangeCollection[i]);
				}
			}
			return rangeRegion;
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x000934BC File Offset: 0x000916BC
		public void Clear()
		{
			this.Remove(new global::SourceGrid.RangeRegion(this));
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x000934CC File Offset: 0x000916CC
		public void Clear(global::SourceGrid.Range pRangeToLeave)
		{
			global::SourceGrid.RangeRegion rangeRegion = new global::SourceGrid.RangeRegion(this);
			rangeRegion.Remove(pRangeToLeave);
			this.Remove(rangeRegion);
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000934F4 File Offset: 0x000916F4
		protected virtual void ResetRange()
		{
			this.m_bValidated = false;
			this.m_RangeCollection.Clear();
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x00093508 File Offset: 0x00091708
		public bool Add(global::SourceGrid.Position pCell)
		{
			return this.Add(new global::SourceGrid.Range(pCell));
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x00093518 File Offset: 0x00091718
		public bool Remove(global::SourceGrid.Position pCell)
		{
			return this.Remove(new global::SourceGrid.Range(pCell));
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00093528 File Offset: 0x00091728
		public bool Add(global::SourceGrid.Range pRange)
		{
			return this.InternalAdd(new global::SourceGrid.RangeRegion(pRange));
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x00093538 File Offset: 0x00091738
		public bool Remove(global::SourceGrid.Range pRange)
		{
			return this.InternalRemove(new global::SourceGrid.RangeRegion(pRange));
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00093548 File Offset: 0x00091748
		public bool Add(global::SourceGrid.RangeRegion pRange)
		{
			return this.InternalAdd(pRange);
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00093554 File Offset: 0x00091754
		public bool Remove(global::SourceGrid.RangeRegion pRange)
		{
			return this.InternalRemove(pRange);
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00093560 File Offset: 0x00091760
		private bool InternalAdd(global::SourceGrid.RangeRegion pRange)
		{
			if (this.Contains(pRange))
			{
				return true;
			}
			if (pRange.Contains(this))
			{
				this.m_RangeCollection.Clear();
				this.m_RangeCollection.AddRange(pRange.m_RangeCollection);
				pRange = pRange.Exclude(this);
			}
			else
			{
				pRange = pRange.Exclude(this);
				if (pRange.IsEmpty())
				{
					return true;
				}
				pRange.m_bValidated = true;
				global::SourceGrid.RangeRegionCancelEventArgs rangeRegionCancelEventArgs = new global::SourceGrid.RangeRegionCancelEventArgs(pRange);
				this.OnAddingRange(rangeRegionCancelEventArgs);
				if (rangeRegionCancelEventArgs.Cancel)
				{
					return false;
				}
				if (!pRange.m_bValidated)
				{
					pRange = pRange.Exclude(this);
					if (pRange.IsEmpty())
					{
						return true;
					}
				}
				for (int i = 0; i < pRange.m_RangeCollection.Count; i++)
				{
					global::SourceGrid.Range item = pRange.m_RangeCollection[i];
					this.m_RangeCollection.Add(item);
				}
			}
			this.OnAddedRange(new global::SourceGrid.RangeRegionCancelEventArgs(pRange));
			this.m_bValidated = false;
			return true;
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00093654 File Offset: 0x00091854
		private bool InternalRemove(global::SourceGrid.RangeRegion pRange)
		{
			pRange = this.Intersect(pRange);
			if (pRange.IsEmpty())
			{
				return true;
			}
			pRange.m_bValidated = true;
			global::SourceGrid.RangeRegionCancelEventArgs rangeRegionCancelEventArgs = new global::SourceGrid.RangeRegionCancelEventArgs(pRange);
			this.OnRemovingRange(rangeRegionCancelEventArgs);
			if (rangeRegionCancelEventArgs.Cancel)
			{
				return false;
			}
			if (!pRange.m_bValidated)
			{
				pRange = this.Intersect(pRange);
				if (pRange.IsEmpty())
				{
					return true;
				}
			}
			this.m_RangeCollection = this.Exclude(pRange).m_RangeCollection;
			this.OnRemovedRange(rangeRegionCancelEventArgs);
			this.m_bValidated = false;
			return true;
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000936E0 File Offset: 0x000918E0
		public virtual void OnAddingRange(global::SourceGrid.RangeRegionCancelEventArgs e)
		{
			if (this.AddingRange != null)
			{
				this.AddingRange(this, e);
			}
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000936FC File Offset: 0x000918FC
		public virtual void OnRemovingRange(global::SourceGrid.RangeRegionCancelEventArgs e)
		{
			if (this.RemovingRange != null)
			{
				this.RemovingRange(this, e);
			}
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00093718 File Offset: 0x00091918
		public virtual void OnAddedRange(global::SourceGrid.RangeRegionEventArgs e)
		{
			if (this.AddedRange != null)
			{
				this.AddedRange(this, e);
			}
			this.OnChanged(new global::SourceGrid.RangeRegionChangedEventArgs(e.RangeRegion, null));
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00093744 File Offset: 0x00091944
		public virtual void OnRemovedRange(global::SourceGrid.RangeRegionEventArgs e)
		{
			if (this.RemovedRange != null)
			{
				this.RemovedRange(this, e);
			}
			this.OnChanged(new global::SourceGrid.RangeRegionChangedEventArgs(null, e.RangeRegion));
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00093770 File Offset: 0x00091970
		public virtual void OnChanged(global::SourceGrid.RangeRegionChangedEventArgs e)
		{
			if (this.Changed != null)
			{
				this.Changed(this, e);
			}
		}

		// Token: 0x140000D8 RID: 216
		// (add) Token: 0x06002BE8 RID: 11240 RVA: 0x0009378C File Offset: 0x0009198C
		// (remove) Token: 0x06002BE9 RID: 11241 RVA: 0x000937A8 File Offset: 0x000919A8
		public event global::SourceGrid.RangeRegionCancelEventHandler AddingRange;

		// Token: 0x140000D9 RID: 217
		// (add) Token: 0x06002BEA RID: 11242 RVA: 0x000937C4 File Offset: 0x000919C4
		// (remove) Token: 0x06002BEB RID: 11243 RVA: 0x000937E0 File Offset: 0x000919E0
		public event global::SourceGrid.RangeRegionCancelEventHandler RemovingRange;

		// Token: 0x140000DA RID: 218
		// (add) Token: 0x06002BEC RID: 11244 RVA: 0x000937FC File Offset: 0x000919FC
		// (remove) Token: 0x06002BED RID: 11245 RVA: 0x00093818 File Offset: 0x00091A18
		public event global::SourceGrid.RangeRegionEventHandler AddedRange;

		// Token: 0x140000DB RID: 219
		// (add) Token: 0x06002BEE RID: 11246 RVA: 0x00093834 File Offset: 0x00091A34
		// (remove) Token: 0x06002BEF RID: 11247 RVA: 0x00093850 File Offset: 0x00091A50
		public event global::SourceGrid.RangeRegionEventHandler RemovedRange;

		// Token: 0x140000DC RID: 220
		// (add) Token: 0x06002BF0 RID: 11248 RVA: 0x0009386C File Offset: 0x00091A6C
		// (remove) Token: 0x06002BF1 RID: 11249 RVA: 0x00093888 File Offset: 0x00091A88
		public event global::SourceGrid.RangeRegionChangedEventHandler Changed;

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000938A4 File Offset: 0x00091AA4
		public override string ToString()
		{
			string text = "RangeRegion";
			for (int i = 0; i < this.m_RangeCollection.Count; i++)
			{
				text = text + " | " + this.m_RangeCollection[i].ToString();
			}
			return text;
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000938FC File Offset: 0x00091AFC
		void global::System.Collections.Generic.ICollection<global::SourceGrid.Range>.Add(global::SourceGrid.Range item)
		{
			this.Add(item);
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x00093908 File Offset: 0x00091B08
		public void CopyTo(global::SourceGrid.Range[] array, int arrayIndex)
		{
			this.m_RangeCollection.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x00093918 File Offset: 0x00091B18
		public int Count
		{
			get
			{
				return this.m_RangeCollection.Count;
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x00093928 File Offset: 0x00091B28
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x0009392C File Offset: 0x00091B2C
		public global::System.Collections.Generic.IEnumerator<global::SourceGrid.Range> GetEnumerator()
		{
			return this.m_RangeCollection.GetEnumerator();
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00093940 File Offset: 0x00091B40
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_RangeCollection.GetEnumerator();
		}

		// Token: 0x04000EA6 RID: 3750
		private global::SourceGrid.RangeCollection m_RangeCollection = new global::SourceGrid.RangeCollection();

		// Token: 0x04000EA7 RID: 3751
		private bool m_bValidated;
	}
}
