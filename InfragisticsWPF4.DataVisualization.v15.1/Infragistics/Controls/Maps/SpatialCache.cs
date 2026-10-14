using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Maps
{
	// Token: 0x020000E8 RID: 232
	internal class SpatialCache<T>
	{
		// Token: 0x060009AA RID: 2474 RVA: 0x0002AAFB File Offset: 0x00028CFB
		public SpatialCache(int maxLevel)
		{
			this._images = new global::System.Collections.Generic.Dictionary<string, T>[maxLevel + 1];
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0002AB11 File Offset: 0x00028D11
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x0002AB19 File Offset: 0x00028D19
		public int Count { get; private set; }

		// Token: 0x060009AD RID: 2477 RVA: 0x0002AB24 File Offset: 0x00028D24
		public void AddItem(int level, int tileX, int tileY, T image)
		{
			if (this._images[level] == null)
			{
				this._images[level] = new global::System.Collections.Generic.Dictionary<string, T>();
			}
			string key = global::Infragistics.Controls.Maps.SpatialCache<T>.TilesIndexesToKey(tileX, tileY);
			if (this._images[level].ContainsKey(key))
			{
				this._images[level][key] = image;
				return;
			}
			this._images[level].Add(key, image);
			this.Count++;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0002AB8F File Offset: 0x00028D8F
		public bool ContainsItem(int level, int tileX, int tileY)
		{
			return level < this._images.Length && this._images[level] != null && this._images[level].ContainsKey(global::Infragistics.Controls.Maps.SpatialCache<T>.TilesIndexesToKey(tileX, tileY));
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0002ABBC File Offset: 0x00028DBC
		public T GetItem(int level, int tileX, int tileY)
		{
			T result;
			if (level < this._images.Length && this._images[level] != null && this._images[level].TryGetValue(global::Infragistics.Controls.Maps.SpatialCache<T>.TilesIndexesToKey(tileX, tileY), out result))
			{
				return result;
			}
			return default(T);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0002AC04 File Offset: 0x00028E04
		public void RemoveItemAt(int level, int tileX, int tileY)
		{
			if (this._images[level] == null)
			{
				return;
			}
			string key = global::Infragistics.Controls.Maps.SpatialCache<T>.TilesIndexesToKey(tileX, tileY);
			this._images[level].Remove(key);
			this.Count--;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0002AC44 File Offset: 0x00028E44
		public void RemoveItemsAtLevel(int level)
		{
			if (this._images[level] == null)
			{
				return;
			}
			int count = this._images[level].Count;
			this._images[level].Clear();
			this.Count -= count;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0002AC88 File Offset: 0x00028E88
		public void Reset()
		{
			foreach (global::System.Collections.Generic.Dictionary<string, T> dictionary in this._images)
			{
				if (dictionary != null)
				{
					dictionary.Clear();
				}
			}
			this.Count = 0;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0002ACC0 File Offset: 0x00028EC0
		public void ClearLevel(int level, int leftTile, int rightTile, int topTile, int bottomTile)
		{
			if (level >= this._images.Length || this._images[level] == null)
			{
				return;
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Collections.Generic.KeyValuePair<string, T> keyValuePair in this._images[level])
			{
				global::System.Tuple<int, int> tuple = global::Infragistics.Controls.Maps.SpatialCache<T>.KeyToTilesIndexes(keyValuePair.Key);
				int item = tuple.Item1;
				int item2 = tuple.Item2;
				if (item < leftTile || item > rightTile || item2 < topTile || item2 > bottomTile)
				{
					list.Add(keyValuePair.Key);
				}
			}
			foreach (string key in list)
			{
				this._images[level].Remove(key);
				this.Count--;
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0002ADC0 File Offset: 0x00028FC0
		public void Clear()
		{
			for (int i = 4; i < this._images.Length; i++)
			{
				if (this._images[i] != null)
				{
					int count = this._images[i].Count;
					this._images[i].Clear();
					this.Count -= count;
				}
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0002AE13 File Offset: 0x00029013
		private static string TilesIndexesToKey(int tileX, int tileY)
		{
			return tileX + "x" + tileY;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0002AE2C File Offset: 0x0002902C
		private static global::System.Tuple<int, int> KeyToTilesIndexes(string key)
		{
			string[] array = key.Split(new char[]
			{
				'x'
			});
			return new global::System.Tuple<int, int>(global::System.Convert.ToInt32(array[0]), global::System.Convert.ToInt32(array[1]));
		}

		// Token: 0x04000374 RID: 884
		private readonly global::System.Collections.Generic.Dictionary<string, T>[] _images;
	}
}
