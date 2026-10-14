using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000037 RID: 55
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DocumentTabPanel : global::System.Windows.Controls.VirtualizingPanel
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x0000EF64 File Offset: 0x0000D164
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			global::System.Windows.Controls.Dock tabStripPlacement = this.TabStripPlacement;
			bool flag = tabStripPlacement == global::System.Windows.Controls.Dock.Top || tabStripPlacement == global::System.Windows.Controls.Dock.Bottom;
			for (int i = children.Count - 1; i >= 0; i--)
			{
				global::System.Windows.UIElement uielement = children[i];
				bool flag2 = i < this._outOfViewItems;
				if (flag)
				{
					finalRect.Width = (flag2 ? 0.0 : uielement.DesiredSize.Width);
				}
				else
				{
					finalRect.Height = (flag2 ? 0.0 : uielement.DesiredSize.Height);
				}
				uielement.Arrange(finalRect);
				if (flag)
				{
					finalRect.X += finalRect.Width;
				}
				else
				{
					finalRect.Y += finalRect.Height;
				}
			}
			global::System.EventHandler value = new global::System.EventHandler(this.OnLayoutUpdated);
			base.LayoutUpdated -= value;
			base.LayoutUpdated += value;
			return finalSize;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000F070 File Offset: 0x0000D270
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			bool isHorizontal = this.IsHorizontal;
			global::System.Windows.Controls.UIElementCollection children = base.Children;
			global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator = base.ItemContainerGenerator;
			global::System.Windows.Controls.ItemsControl itemsOwner = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this);
			int num = (itemsOwner != null) ? itemsOwner.Items.Count : 0;
			global::System.Windows.Size availableSize2 = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
			int num2 = 0;
			int previousLastIndex = 0;
			int num3 = (itemsOwner is global::System.Windows.Controls.TabControl) ? ((global::System.Windows.Controls.TabControl)itemsOwner).SelectedIndex : -1;
			if (itemContainerGenerator == null || itemsOwner == null)
			{
				return default(global::System.Windows.Size);
			}
			if (this._previousLastIndex < 0)
			{
				this._previousLastIndex = num - 1;
			}
			double num4 = 0.0;
			double num5 = 0.0;
			double num6 = isHorizontal ? availableSize.Width : availableSize.Height;
			if (!isHorizontal)
			{
				double width = availableSize.Width;
			}
			else
			{
				double height = availableSize.Height;
			}
			int num7 = children.Count;
			global::System.Windows.Controls.Primitives.GeneratorPosition generatorPositionFromItemIndex = this.GetGeneratorPositionFromItemIndex(0);
			using (itemContainerGenerator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
			{
				for (int i = 0; i < num; i++)
				{
					bool flag;
					global::System.Windows.UIElement uielement = itemContainerGenerator.GenerateNext(out flag) as global::System.Windows.UIElement;
					if (uielement == null)
					{
						break;
					}
					if (flag)
					{
						base.InsertInternalChild(num7, uielement);
						itemContainerGenerator.PrepareItemContainer(uielement);
					}
					else
					{
						num7--;
					}
					uielement.Measure(availableSize2);
					global::System.Windows.Size desiredSize = uielement.DesiredSize;
					double num8 = isHorizontal ? desiredSize.Width : desiredSize.Height;
					double val = isHorizontal ? desiredSize.Height : desiredSize.Width;
					if (num2 > 0 && num8 + num4 > num6)
					{
						break;
					}
					previousLastIndex = i;
					num2++;
					num4 += num8;
					num5 = global::System.Math.Max(val, num5);
				}
			}
			this._outOfViewItems = 0;
			bool flag2 = num3 >= 0 && num3 > num2;
			for (int j = children.Count - 1; j >= num2; j--)
			{
				generatorPositionFromItemIndex = new global::System.Windows.Controls.Primitives.GeneratorPosition(j, 0);
				if (itemContainerGenerator.IndexFromGeneratorPosition(generatorPositionFromItemIndex) == num3)
				{
					flag2 = false;
					this._outOfViewItems++;
				}
				else if (generatorPositionFromItemIndex.Offset == 0)
				{
					itemContainerGenerator.Remove(generatorPositionFromItemIndex, 1);
					base.RemoveInternalChildRange(this._outOfViewItems, 1);
				}
			}
			if (flag2)
			{
				generatorPositionFromItemIndex = this.GetGeneratorPositionFromItemIndex(num3);
				using (itemContainerGenerator.StartAt(generatorPositionFromItemIndex, global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
				{
					bool flag3;
					global::System.Windows.UIElement uielement2 = itemContainerGenerator.GenerateNext(out flag3) as global::System.Windows.UIElement;
					if (uielement2 != null && flag3)
					{
						base.InsertInternalChild(0, uielement2);
						itemContainerGenerator.PrepareItemContainer(uielement2);
					}
				}
				this._outOfViewItems++;
			}
			this._previousLastIndex = previousLastIndex;
			global::System.Windows.Size result;
			if (isHorizontal)
			{
				result = new global::System.Windows.Size(num4, num5);
			}
			else
			{
				result = new global::System.Windows.Size(num5, num4);
			}
			if (itemsOwner != null)
			{
				itemsOwner.SetValue(global::Infragistics.Windows.DockManager.DocumentTabPanel.HasItemsOutOfViewPropertyKey, (children.Count != num) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
			}
			return result;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000F360 File Offset: 0x0000D560
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			switch (args.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				if (args.Position.Offset == 0)
				{
					base.RemoveInternalChildRange(base.Children.Count - 1 - args.Position.Index, 1);
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				if (args.OldPosition.Offset == 0)
				{
					base.RemoveInternalChildRange(base.Children.Count - 1 - args.OldPosition.Index, 1);
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				base.RemoveInternalChildRange(0, base.Children.Count);
				this._previousLastIndex = -1;
				break;
			}
			base.OnItemsChanged(sender, args);
			base.InvalidateMeasure();
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x0000F428 File Offset: 0x0000D628
		private bool IsHorizontal
		{
			get
			{
				switch (this.TabStripPlacement)
				{
				case global::System.Windows.Controls.Dock.Left:
				case global::System.Windows.Controls.Dock.Right:
					return false;
				default:
					return true;
				}
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000F455 File Offset: 0x0000D655
		public static bool GetHasItemsOutOfView(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.DocumentTabPanel.HasItemsOutOfViewProperty);
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000F467 File Offset: 0x0000D667
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000F479 File Offset: 0x0000D679
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Dock TabStripPlacement
		{
			get
			{
				return (global::System.Windows.Controls.Dock)base.GetValue(global::Infragistics.Windows.DockManager.DocumentTabPanel.TabStripPlacementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.DocumentTabPanel.TabStripPlacementProperty, value);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000F48C File Offset: 0x0000D68C
		private global::System.Windows.Controls.Primitives.GeneratorPosition GetGeneratorPositionFromItemIndex(int itemIndex)
		{
			if (!base.IsItemsHost)
			{
				return new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
			}
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator = base.ItemContainerGenerator;
			return (itemContainerGenerator != null) ? itemContainerGenerator.GeneratorPositionFromIndex(itemIndex) : new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, itemIndex + 1);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.OnLayoutUpdated;
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this) as global::Infragistics.Windows.DockManager.TabGroupPane;
			if (tabGroupPane != null)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(tabGroupPane.EnsureSelectedDocumentIsInView));
			}
		}

		// Token: 0x04000189 RID: 393
		private int _previousLastIndex = -1;

		// Token: 0x0400018A RID: 394
		private int _outOfViewItems;

		// Token: 0x0400018B RID: 395
		private static readonly global::System.Windows.DependencyPropertyKey HasItemsOutOfViewPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("HasItemsOutOfView", typeof(bool), typeof(global::Infragistics.Windows.DockManager.DocumentTabPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400018C RID: 396
		public static readonly global::System.Windows.DependencyProperty HasItemsOutOfViewProperty = global::Infragistics.Windows.DockManager.DocumentTabPanel.HasItemsOutOfViewPropertyKey.DependencyProperty;

		// Token: 0x0400018D RID: 397
		public static readonly global::System.Windows.DependencyProperty TabStripPlacementProperty = global::System.Windows.Controls.TabControl.TabStripPlacementProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.DocumentTabPanel), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.DockTopBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
	}
}
