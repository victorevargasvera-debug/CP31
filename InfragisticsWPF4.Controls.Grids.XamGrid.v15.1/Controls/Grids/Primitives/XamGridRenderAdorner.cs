using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200010B RID: 267
	public abstract class XamGridRenderAdorner
	{
		// Token: 0x060008F3 RID: 2291 RVA: 0x0002317F File Offset: 0x0002137F
		protected XamGridRenderAdorner(global::Infragistics.Controls.Grids.XamGrid grid)
		{
			this._grid = grid;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000231AF File Offset: 0x000213AF
		public void RegisterRowsPanel(global::Infragistics.Controls.Grids.Primitives.RowsPanel panel)
		{
			this.RowsPanel = panel;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x000231B8 File Offset: 0x000213B8
		public void UnregisterRowsPanel()
		{
			this.Reset();
			this.RowsPanel = null;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000231C8 File Offset: 0x000213C8
		public virtual void Reset()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement>> keyValuePair in this._elementsLookupTable)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Windows.UIElement> keyValuePair2 in keyValuePair.Value)
				{
					this.UnregisterElement(keyValuePair2.Value);
				}
				keyValuePair.Value.Clear();
			}
			this._elementsLookupTable.Clear();
			this._usedObjects.Clear();
			this._usedKeys.Clear();
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0002328C File Offset: 0x0002148C
		public void Measure(global::System.Windows.Size availableSize)
		{
			this.MeasureAdorners(availableSize);
			foreach (object obj in this._previouslyUsedRows)
			{
				if (!this._usedObjects.Contains(obj))
				{
					this.UnregisterObject(obj);
				}
				else
				{
					global::System.Collections.Generic.List<string> list = this._usedKeys[obj];
					foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement>> keyValuePair in this._elementsLookupTable)
					{
						if (!list.Contains(keyValuePair.Key))
						{
							this.UnregisterElement(obj, keyValuePair.Key);
						}
					}
				}
			}
			this._previouslyUsedRows = null;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00023368 File Offset: 0x00021568
		public virtual void Initialize()
		{
			this._previouslyUsedRows = new global::System.Collections.Generic.List<object>(this._usedObjects);
			this._usedObjects.Clear();
			this._usedKeys.Clear();
		}

		// Token: 0x060008F9 RID: 2297
		public abstract double MeasureAfterRow(global::Infragistics.Controls.Grids.RowBase row);

		// Token: 0x060008FA RID: 2298
		protected abstract void MeasureAdorners(global::System.Windows.Size availableSize);

		// Token: 0x060008FB RID: 2299
		public abstract double ArrangeAfterRow(global::Infragistics.Controls.Grids.RowBase row, double top, global::System.Windows.Size finalSize);

		// Token: 0x060008FC RID: 2300
		public abstract void ArrangeAdornments(global::System.Windows.Size finalSize, double dataRowTop);

		// Token: 0x060008FD RID: 2301 RVA: 0x00023391 File Offset: 0x00021591
		protected void RegisterObjectUsed(object obj)
		{
			if (!this._usedObjects.Contains(obj))
			{
				this._usedObjects.Add(obj);
				this._usedKeys.Add(obj, new global::System.Collections.Generic.List<string>());
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x000233C0 File Offset: 0x000215C0
		protected void UnregisterObject(object obj)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement>> keyValuePair in this._elementsLookupTable)
			{
				this.UnregisterElement(obj, keyValuePair.Key);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0002341C File Offset: 0x0002161C
		protected void UnregisterElement(object obj, string key)
		{
			global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement> dictionary = this._elementsLookupTable[key];
			if (dictionary != null && dictionary.ContainsKey(obj))
			{
				this.UnregisterElement(dictionary[obj]);
				dictionary.Remove(obj);
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00023457 File Offset: 0x00021657
		protected void UnregisterElement(global::System.Windows.UIElement element)
		{
			this.RowsPanel.Children.Remove(element);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0002346C File Offset: 0x0002166C
		protected global::System.Windows.UIElement GetElement(object obj, string key)
		{
			this.RegisterObjectUsed(obj);
			if (!this._usedKeys[obj].Contains(key))
			{
				this._usedKeys[obj].Add(key);
			}
			global::System.Windows.UIElement result = null;
			if (this._elementsLookupTable.ContainsKey(key))
			{
				global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement> dictionary = this._elementsLookupTable[key];
				if (dictionary.ContainsKey(obj))
				{
					result = dictionary[obj];
				}
			}
			return result;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x000234D8 File Offset: 0x000216D8
		protected global::System.Windows.UIElement AddElement(object row, string key, global::System.Windows.UIElement element)
		{
			this.RegisterObjectUsed(row);
			if (!this._usedKeys[row].Contains(key))
			{
				this._usedKeys[row].Add(key);
			}
			if (!this._elementsLookupTable.ContainsKey(key))
			{
				this._elementsLookupTable.Add(key, new global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement>());
			}
			global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement> dictionary = this._elementsLookupTable[key];
			if (dictionary.ContainsKey(row))
			{
				global::System.Windows.UIElement uielement = dictionary[row];
				if (uielement != null)
				{
					this.RowsPanel.Children.Remove(uielement);
				}
				dictionary.Remove(row);
			}
			dictionary.Add(row, element);
			if (!this.RowsPanel.Children.Contains(element))
			{
				this.RowsPanel.Children.Add(element);
			}
			return element;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00023599 File Offset: 0x00021799
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x000235A1 File Offset: 0x000217A1
		private protected global::Infragistics.Controls.Grids.Primitives.RowsPanel RowsPanel { protected get; private set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x000235AA File Offset: 0x000217AA
		public global::Infragistics.Controls.Grids.XamGrid XamGrid
		{
			get
			{
				return this._grid;
			}
		}

		// Token: 0x04000238 RID: 568
		private global::Infragistics.Controls.Grids.XamGrid _grid;

		// Token: 0x04000239 RID: 569
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement>> _elementsLookupTable = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<object, global::System.Windows.UIElement>>();

		// Token: 0x0400023A RID: 570
		private global::System.Collections.Generic.List<object> _usedObjects = new global::System.Collections.Generic.List<object>();

		// Token: 0x0400023B RID: 571
		private global::System.Collections.Generic.Dictionary<object, global::System.Collections.Generic.List<string>> _usedKeys = new global::System.Collections.Generic.Dictionary<object, global::System.Collections.Generic.List<string>>();

		// Token: 0x0400023C RID: 572
		private global::System.Collections.Generic.List<object> _previouslyUsedRows;
	}
}
