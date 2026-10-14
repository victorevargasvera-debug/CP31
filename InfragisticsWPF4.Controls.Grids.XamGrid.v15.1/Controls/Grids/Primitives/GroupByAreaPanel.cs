using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000FF RID: 255
	public class GroupByAreaPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x06000860 RID: 2144 RVA: 0x000216E8 File Offset: 0x0001F8E8
		public GroupByAreaPanel()
		{
			this._comparer = new global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfoComparer();
			this._measuredItems = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo>();
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00021708 File Offset: 0x0001F908
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this._measuredItems.Clear();
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey>();
			double num = 0.0;
			double num2 = 0.0;
			double height = 0.0;
			double num3 = 0.0;
			foreach (object obj in base.Children)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				int index = global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GetIndex(uielement);
				global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey groupByKey = new global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey
				{
					Level = global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GetLevel(uielement),
					Key = global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GetLevelKey(uielement)
				};
				uielement.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				int num4 = list.IndexOf(groupByKey);
				if (num4 == -1)
				{
					list.Add(groupByKey);
					groupByKey.Children = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo>();
				}
				else
				{
					groupByKey = list[num4];
				}
				groupByKey.Children.Add(new global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo
				{
					Index = index,
					Element = uielement
				});
			}
			list.Sort(this._comparer);
			foreach (global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey groupByKey2 in list)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo> children = groupByKey2.Children;
				children.Sort(this._comparer);
				int count = children.Count;
				double num5 = 0.0;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo groupByChildInfo = children[i];
					global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl groupByHeaderCellControl = groupByChildInfo.Element as global::Infragistics.Controls.Grids.Primitives.GroupByHeaderCellControl;
					if (groupByHeaderCellControl != null)
					{
						groupByHeaderCellControl.Cell.ApplyStyle();
						groupByHeaderCellControl.IsFirst = (i == 0);
						groupByHeaderCellControl.IsLast = (i == count - 1);
						groupByHeaderCellControl.UpdateState();
					}
					groupByChildInfo.Left = num2;
					groupByChildInfo.Top = num;
					num2 += groupByChildInfo.Element.DesiredSize.Width;
					num5 = global::System.Math.Max(groupByChildInfo.Element.DesiredSize.Height, num5);
					this._measuredItems.Add(groupByChildInfo);
				}
				foreach (global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo groupByChildInfo2 in children)
				{
					groupByChildInfo2.MaxHeight = num5;
				}
				num3 = global::System.Math.Max(num2, num3);
				num += num5 + 5.0;
				height = num - 5.0;
				num2 = 0.0;
			}
			if (double.IsInfinity(availableSize.Height))
			{
				availableSize.Height = height;
			}
			if (double.IsInfinity(availableSize.Width))
			{
				availableSize.Width = num3;
			}
			return availableSize;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00021A34 File Offset: 0x0001FC34
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			int num = this._measuredItems.Count;
			foreach (global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo groupByChildInfo in this._measuredItems)
			{
				groupByChildInfo.Element.Arrange(new global::System.Windows.Rect(groupByChildInfo.Left, groupByChildInfo.Top, groupByChildInfo.Element.DesiredSize.Width, groupByChildInfo.MaxHeight));
				global::System.Windows.Controls.Panel.SetZIndex(groupByChildInfo.Element, num);
				num--;
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00021AD4 File Offset: 0x0001FCD4
		public static string GetLevelKey(global::System.Windows.UIElement element)
		{
			return (string)element.GetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.LevelKeyProperty);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00021AE6 File Offset: 0x0001FCE6
		public static void SetLevelKey(global::System.Windows.UIElement element, string key)
		{
			element.SetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.LevelKeyProperty, key);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00021AF4 File Offset: 0x0001FCF4
		public static int GetLevel(global::System.Windows.UIElement element)
		{
			return (int)element.GetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.LevelProperty);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00021B06 File Offset: 0x0001FD06
		public static void SetLevel(global::System.Windows.UIElement element, int level)
		{
			element.SetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.LevelProperty, level);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00021B19 File Offset: 0x0001FD19
		public static int GetIndex(global::System.Windows.UIElement element)
		{
			return (int)element.GetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.IndexProperty);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00021B2B File Offset: 0x0001FD2B
		public static void SetIndex(global::System.Windows.UIElement element, int index)
		{
			element.SetValue(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.IndexProperty, index);
		}

		// Token: 0x0400020E RID: 526
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo> _measuredItems;

		// Token: 0x0400020F RID: 527
		private global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfoComparer _comparer;

		// Token: 0x04000210 RID: 528
		public static readonly global::System.Windows.DependencyProperty LevelKeyProperty = global::System.Windows.DependencyProperty.RegisterAttached("LevelKey", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel), null);

		// Token: 0x04000211 RID: 529
		public static readonly global::System.Windows.DependencyProperty LevelProperty = global::System.Windows.DependencyProperty.RegisterAttached("Level", typeof(int), typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel), null);

		// Token: 0x04000212 RID: 530
		public static readonly global::System.Windows.DependencyProperty IndexProperty = global::System.Windows.DependencyProperty.RegisterAttached("Index", typeof(int), typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel), null);

		// Token: 0x02000100 RID: 256
		private class GroupByChildInfoComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo>, global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey>
		{
			// Token: 0x0600086A RID: 2154 RVA: 0x00021BBC File Offset: 0x0001FDBC
			public int Compare(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo x, global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo y)
			{
				return x.Index.CompareTo(y.Index);
			}

			// Token: 0x0600086B RID: 2155 RVA: 0x00021BE0 File Offset: 0x0001FDE0
			public int Compare(global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey x, global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey y)
			{
				int num = x.Level.CompareTo(y.Level);
				if (num != 0)
				{
					return num;
				}
				return string.Compare(x.Key, y.Key, global::System.StringComparison.CurrentCulture);
			}
		}

		// Token: 0x02000101 RID: 257
		private class GroupByKey
		{
			// Token: 0x17000295 RID: 661
			// (get) Token: 0x0600086D RID: 2157 RVA: 0x00021C21 File Offset: 0x0001FE21
			// (set) Token: 0x0600086E RID: 2158 RVA: 0x00021C29 File Offset: 0x0001FE29
			public int Level { get; set; }

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x0600086F RID: 2159 RVA: 0x00021C32 File Offset: 0x0001FE32
			// (set) Token: 0x06000870 RID: 2160 RVA: 0x00021C3A File Offset: 0x0001FE3A
			public string Key { get; set; }

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000871 RID: 2161 RVA: 0x00021C43 File Offset: 0x0001FE43
			// (set) Token: 0x06000872 RID: 2162 RVA: 0x00021C4B File Offset: 0x0001FE4B
			public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByChildInfo> Children { get; set; }

			// Token: 0x06000873 RID: 2163 RVA: 0x00021C54 File Offset: 0x0001FE54
			public override bool Equals(object obj)
			{
				global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey groupByKey = obj as global::Infragistics.Controls.Grids.Primitives.GroupByAreaPanel.GroupByKey;
				return groupByKey != null && this.Level == groupByKey.Level && this.Key == groupByKey.Key;
			}

			// Token: 0x06000874 RID: 2164 RVA: 0x00021C8E File Offset: 0x0001FE8E
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
		}

		// Token: 0x02000102 RID: 258
		private class GroupByChildInfo
		{
			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000876 RID: 2166 RVA: 0x00021C9E File Offset: 0x0001FE9E
			// (set) Token: 0x06000877 RID: 2167 RVA: 0x00021CA6 File Offset: 0x0001FEA6
			public int Index { get; set; }

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000878 RID: 2168 RVA: 0x00021CAF File Offset: 0x0001FEAF
			// (set) Token: 0x06000879 RID: 2169 RVA: 0x00021CB7 File Offset: 0x0001FEB7
			public global::System.Windows.UIElement Element { get; set; }

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x0600087A RID: 2170 RVA: 0x00021CC0 File Offset: 0x0001FEC0
			// (set) Token: 0x0600087B RID: 2171 RVA: 0x00021CC8 File Offset: 0x0001FEC8
			public double Top { get; set; }

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x0600087C RID: 2172 RVA: 0x00021CD1 File Offset: 0x0001FED1
			// (set) Token: 0x0600087D RID: 2173 RVA: 0x00021CD9 File Offset: 0x0001FED9
			public double Left { get; set; }

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x0600087E RID: 2174 RVA: 0x00021CE2 File Offset: 0x0001FEE2
			// (set) Token: 0x0600087F RID: 2175 RVA: 0x00021CEA File Offset: 0x0001FEEA
			public double MaxHeight { get; set; }
		}
	}
}
