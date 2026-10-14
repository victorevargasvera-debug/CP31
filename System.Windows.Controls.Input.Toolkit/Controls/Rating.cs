using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Properties;
using System.Windows.Data;
using System.Windows.Input;

namespace System.Windows.Controls
{
	// Token: 0x02000006 RID: 6
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(global::System.Windows.Controls.RatingItem))]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "ReadOnly", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	public class Rating : global::System.Windows.Controls.ItemsControl, global::System.Windows.Controls.IUpdateVisualState
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002111 File Offset: 0x00000311
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002123 File Offset: 0x00000323
		protected double DisplayValue
		{
			get
			{
				return (double)base.GetValue(global::System.Windows.Controls.Rating.DisplayValueProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Rating.DisplayValueProperty, value);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002138 File Offset: 0x00000338
		private static void OnDisplayValueChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs eventArgs)
		{
			global::System.Windows.Controls.Rating rating = (global::System.Windows.Controls.Rating)dependencyObject;
			rating.OnDisplayValueChanged();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002152 File Offset: 0x00000352
		private void OnDisplayValueChanged()
		{
			this.UpdateDisplayValues();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000215A File Offset: 0x0000035A
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002162 File Offset: 0x00000362
		private global::System.Windows.Controls.RatingItem HoveredRatingItem { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000216B File Offset: 0x0000036B
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002173 File Offset: 0x00000373
		internal global::System.Windows.Controls.InteractionHelper Interaction { get; private set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000217C File Offset: 0x0000037C
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000218E File Offset: 0x0000038E
		public int ItemCount
		{
			get
			{
				return (int)base.GetValue(global::System.Windows.Controls.Rating.ItemCountProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Rating.ItemCountProperty, value);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000021A4 File Offset: 0x000003A4
		private static void OnItemCountChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Rating rating = d as global::System.Windows.Controls.Rating;
			int newValue = (int)e.NewValue;
			rating.OnItemCountChanged(newValue);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000021CC File Offset: 0x000003CC
		private void OnItemCountChanged(int newValue)
		{
			if (newValue < 0)
			{
				throw new global::System.ArgumentException(global::System.Windows.Controls.Properties.Resources.Rating_SetItemCount_ItemCountMustBeLargerThanOrEqualToZero);
			}
			int num = newValue - base.Items.Count;
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					base.Items.Add(new global::System.Windows.Controls.RatingItem());
				}
				return;
			}
			if (num < 0)
			{
				for (int j = 0; j < global::System.Math.Abs(num); j++)
				{
					base.Items.RemoveAt(base.Items.Count - 1);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002245 File Offset: 0x00000445
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002257 File Offset: 0x00000457
		public bool IsReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::System.Windows.Controls.Rating.IsReadOnlyProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Rating.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000226C File Offset: 0x0000046C
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Rating rating = (global::System.Windows.Controls.Rating)d;
			bool oldValue = (bool)e.OldValue;
			bool newValue = (bool)e.NewValue;
			rating.OnIsReadOnlyChanged(oldValue, newValue);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022A4 File Offset: 0x000004A4
		protected virtual void OnIsReadOnlyChanged(bool oldValue, bool newValue)
		{
			this.Interaction.OnIsReadOnlyChanged(newValue);
			foreach (global::System.Windows.Controls.RatingItem ratingItem in this.GetRatingItems())
			{
				ratingItem.IsReadOnly = newValue;
			}
			this.UpdateHoverStates();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002304 File Offset: 0x00000504
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002316 File Offset: 0x00000516
		public global::System.Windows.Controls.RatingSelectionMode SelectionMode
		{
			get
			{
				return (global::System.Windows.Controls.RatingSelectionMode)base.GetValue(global::System.Windows.Controls.Rating.SelectionModeProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Rating.SelectionModeProperty, value);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000232C File Offset: 0x0000052C
		private static void OnSelectionModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Rating rating = (global::System.Windows.Controls.Rating)d;
			global::System.Windows.Controls.RatingSelectionMode oldValue = (global::System.Windows.Controls.RatingSelectionMode)e.OldValue;
			global::System.Windows.Controls.RatingSelectionMode newValue = (global::System.Windows.Controls.RatingSelectionMode)e.NewValue;
			rating.OnSelectionModeChanged(oldValue, newValue);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002362 File Offset: 0x00000562
		protected virtual void OnSelectionModeChanged(global::System.Windows.Controls.RatingSelectionMode oldValue, global::System.Windows.Controls.RatingSelectionMode newValue)
		{
			this.UpdateDisplayValues();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000236A File Offset: 0x0000056A
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0000237C File Offset: 0x0000057C
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.Controls.NullableConverter<double>))]
		public double? Value
		{
			get
			{
				return (double?)base.GetValue(global::System.Windows.Controls.Rating.ValueProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Rating.ValueProperty, value);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002390 File Offset: 0x00000590
		private static void OnValueChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Rating rating = (global::System.Windows.Controls.Rating)d;
			double? oldValue = (double?)e.OldValue;
			double? newValue = (double?)e.NewValue;
			rating.OnValueChanged(oldValue, newValue);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000023C6 File Offset: 0x000005C6
		protected virtual void OnValueChanged(double? oldValue, double? newValue)
		{
			this.UpdateValues();
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<double?>(oldValue, newValue, global::System.Windows.Controls.Rating.ValueChangedEvent));
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002414 File Offset: 0x00000614
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.EventHandler layoutUpdated = null;
			layoutUpdated = delegate(object A_1, global::System.EventArgs A_2)
			{
				this.LayoutUpdated -= layoutUpdated;
				this.UpdateValues();
				this.UpdateDisplayValues();
			};
			base.LayoutUpdated += layoutUpdated;
			this.ItemCount = base.Items.Count;
			base.OnItemsChanged(e);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600002D RID: 45 RVA: 0x0000246B File Offset: 0x0000066B
		// (remove) Token: 0x0600002E RID: 46 RVA: 0x00002479 File Offset: 0x00000679
		public event global::System.Windows.RoutedPropertyChangedEventHandler<double?> ValueChanged
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.Rating.ValueChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.Rating.ValueChangedEvent, value);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002488 File Offset: 0x00000688
		static Rating()
		{
			global::System.Windows.Controls.Rating.ValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ValueChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<double?>), typeof(global::System.Windows.Controls.Rating));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::System.Windows.Controls.Rating), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.Windows.Controls.Rating)));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000260E File Offset: 0x0000080E
		public Rating()
		{
			this.Interaction = new global::System.Windows.Controls.InteractionHelper(this);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002622 File Offset: 0x00000822
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.Interaction.AllowMouseEnter(e))
			{
				this.Interaction.UpdateVisualStateBase(true);
			}
			base.OnMouseEnter(e);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002645 File Offset: 0x00000845
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.Interaction.AllowMouseLeave(e))
			{
				this.Interaction.UpdateVisualStateBase(true);
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002668 File Offset: 0x00000868
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Interaction.AllowMouseLeftButtonDown(e))
			{
				this.Interaction.OnMouseLeftButtonDownBase();
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000268A File Offset: 0x0000088A
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Interaction.AllowMouseLeftButtonUp(e))
			{
				this.Interaction.OnMouseLeftButtonUpBase();
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000026C0 File Offset: 0x000008C0
		private void UpdateValues()
		{
			global::System.Collections.Generic.IList<global::System.Windows.Controls.RatingItem> list = this.GetRatingItems().ToList<global::System.Windows.Controls.RatingItem>();
			global::System.Windows.Controls.RatingItem selectedRatingItem = this.GetSelectedRatingItem();
			global::System.Collections.Generic.IEnumerable<global::System.Windows.Controls.Tuple<global::System.Windows.Controls.RatingItem, double>> enumerable = global::System.Windows.Controls.EnumerableFunctions.Zip<global::System.Windows.Controls.RatingItem, double, global::System.Windows.Controls.Tuple<global::System.Windows.Controls.RatingItem, double>>(list, (from ratingItem in list
			select 1.0).GetWeightedValues(this.Value.GetValueOrDefault()), (global::System.Windows.Controls.RatingItem item, double percent) => global::System.Windows.Controls.Tuple.Create<global::System.Windows.Controls.RatingItem, double>(item, percent));
			foreach (global::System.Windows.Controls.Tuple<global::System.Windows.Controls.RatingItem, double> tuple in enumerable)
			{
				tuple.First.Value = tuple.Second;
			}
			global::System.Windows.Controls.RatingItem selectedRatingItem2 = this.GetSelectedRatingItem();
			if (selectedRatingItem != selectedRatingItem2)
			{
				if (selectedRatingItem2 != null && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected))
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(selectedRatingItem2);
					if (automationPeer != null)
					{
						automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected);
					}
				}
				if (selectedRatingItem != null && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer2 = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(selectedRatingItem);
					if (automationPeer2 != null)
					{
						automationPeer2.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection);
					}
				}
			}
			if (this.HoveredRatingItem == null)
			{
				this.DisplayValue = this.Value.GetValueOrDefault();
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002818 File Offset: 0x00000A18
		private void UpdateDisplayValues()
		{
			global::System.Collections.Generic.IList<global::System.Windows.Controls.RatingItem> list = this.GetRatingItems().ToList<global::System.Windows.Controls.RatingItem>();
			global::System.Collections.Generic.IEnumerable<global::System.Windows.Controls.Tuple<global::System.Windows.Controls.RatingItem, double>> enumerable = global::System.Windows.Controls.EnumerableFunctions.Zip<global::System.Windows.Controls.RatingItem, double, global::System.Windows.Controls.Tuple<global::System.Windows.Controls.RatingItem, double>>(list, (from ratingItem in list
			select 1.0).GetWeightedValues(this.DisplayValue), (global::System.Windows.Controls.RatingItem item, double percent) => global::System.Windows.Controls.Tuple.Create<global::System.Windows.Controls.RatingItem, double>(item, percent));
			global::System.Windows.Controls.Tuple<global::System.Windows.Controls.RatingItem, double> tuple = enumerable.LastOrDefault((global::System.Windows.Controls.Tuple<global::System.Windows.Controls.RatingItem, double> i) => i.Second > 0.0);
			global::System.Windows.Controls.RatingItem ratingItem2;
			if (tuple != null)
			{
				ratingItem2 = tuple.First;
			}
			else
			{
				ratingItem2 = this.GetSelectedRatingItem();
			}
			foreach (global::System.Windows.Controls.Tuple<global::System.Windows.Controls.RatingItem, double> tuple2 in enumerable)
			{
				if (this.SelectionMode == global::System.Windows.Controls.RatingSelectionMode.Individual && tuple2.First != ratingItem2)
				{
					tuple2.First.DisplayValue = 0.0;
				}
				else
				{
					tuple2.First.DisplayValue = tuple2.Second;
				}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002934 File Offset: 0x00000B34
		private void UpdateHoverStates()
		{
			if (this.HoveredRatingItem != null && !this.IsReadOnly)
			{
				global::System.Collections.Generic.IList<global::System.Windows.Controls.RatingItem> list = this.GetRatingItems().ToList<global::System.Windows.Controls.RatingItem>();
				int num = list.IndexOf(this.HoveredRatingItem);
				double num2 = (double)list.Count<global::System.Windows.Controls.RatingItem>();
				double num3 = (double)(num + 1);
				this.DisplayValue = num3 / num2;
				for (int i = 0; i < list.Count; i++)
				{
					global::System.Windows.Controls.RatingItem ratingItem = list[i];
					if (i <= num && this.SelectionMode == global::System.Windows.Controls.RatingSelectionMode.Continuous)
					{
						global::System.Windows.Controls.VisualStates.GoToState(ratingItem, true, new string[]
						{
							"MouseOver"
						});
					}
					else
					{
						global::System.Windows.Controls.IUpdateVisualState updateVisualState = ratingItem;
						updateVisualState.UpdateVisualState(true);
					}
				}
				return;
			}
			this.DisplayValue = this.Value.GetValueOrDefault();
			foreach (global::System.Windows.Controls.IUpdateVisualState updateVisualState2 in this.GetRatingItems().OfType<global::System.Windows.Controls.IUpdateVisualState>())
			{
				updateVisualState2.UpdateVisualState(true);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002A40 File Offset: 0x00000C40
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::System.Windows.Controls.RatingItem();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002A47 File Offset: 0x00000C47
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::System.Windows.Controls.RatingItem;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A54 File Offset: 0x00000C54
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::System.Windows.Controls.RatingItem ratingItem = (global::System.Windows.Controls.RatingItem)element;
			object obj = ratingItem.ReadLocalValue(global::System.Windows.Controls.Control.ForegroundProperty);
			if (obj == global::System.Windows.DependencyProperty.UnsetValue)
			{
				ratingItem.SetBinding(global::System.Windows.Controls.Control.ForegroundProperty, new global::System.Windows.Data.Binding("Foreground")
				{
					Source = this
				});
			}
			ratingItem.IsReadOnly = this.IsReadOnly;
			if (ratingItem.Style == null)
			{
				ratingItem.Style = base.ItemContainerStyle;
			}
			ratingItem.Click += this.RatingItemClick;
			ratingItem.MouseEnter += this.RatingItemMouseEnter;
			ratingItem.MouseLeave += this.RatingItemMouseLeave;
			ratingItem.ParentRating = this;
			base.PrepareContainerForItemOverride(element, item);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002B00 File Offset: 0x00000D00
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::System.Windows.Controls.RatingItem ratingItem = (global::System.Windows.Controls.RatingItem)element;
			ratingItem.Click -= this.RatingItemClick;
			ratingItem.MouseEnter -= this.RatingItemMouseEnter;
			ratingItem.MouseLeave -= this.RatingItemMouseLeave;
			ratingItem.ParentRating = null;
			if (ratingItem == this.HoveredRatingItem)
			{
				this.HoveredRatingItem = null;
				this.UpdateDisplayValues();
				this.UpdateHoverStates();
			}
			base.ClearContainerForItemOverride(element, item);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002B75 File Offset: 0x00000D75
		private void RatingItemMouseEnter(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.HoveredRatingItem = (global::System.Windows.Controls.RatingItem)sender;
			this.UpdateHoverStates();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002B89 File Offset: 0x00000D89
		private void RatingItemMouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.HoveredRatingItem = null;
			this.UpdateDisplayValues();
			this.UpdateHoverStates();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002B9E File Offset: 0x00000D9E
		internal global::System.Collections.Generic.IEnumerable<global::System.Windows.Controls.RatingItem> GetRatingItems()
		{
			return base.Items.Cast<global::System.Windows.Controls.RatingItem>();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002BB8 File Offset: 0x00000DB8
		internal void SelectRatingItem(global::System.Windows.Controls.RatingItem selectedRatingItem)
		{
			if (!this.IsReadOnly)
			{
				global::System.Collections.Generic.IList<global::System.Windows.Controls.RatingItem> list = this.GetRatingItems().ToList<global::System.Windows.Controls.RatingItem>();
				global::System.Collections.Generic.IEnumerable<double> source = from ratingItem in list
				select 1.0;
				double num = (double)list.Count<global::System.Windows.Controls.RatingItem>();
				if (num != 0.0)
				{
					double value = source.Take(list.IndexOf(selectedRatingItem) + 1).Sum() / num;
					this.Value = new double?(value);
				}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002C34 File Offset: 0x00000E34
		private void RatingItemClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (!this.IsReadOnly)
			{
				global::System.Windows.Controls.RatingItem ratingItem = (global::System.Windows.Controls.RatingItem)sender;
				this.OnRatingItemValueSelected(ratingItem, 1.0);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002C73 File Offset: 0x00000E73
		private global::System.Windows.Controls.RatingItem GetSelectedRatingItem()
		{
			return this.GetRatingItems().LastOrDefault((global::System.Windows.Controls.RatingItem ratingItem) => ratingItem.Value > 0.0);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002CA0 File Offset: 0x00000EA0
		protected virtual void OnRatingItemValueSelected(global::System.Windows.Controls.RatingItem ratingItem, double newValue)
		{
			global::System.Collections.Generic.List<global::System.Windows.Controls.RatingItem> list = this.GetRatingItems().ToList<global::System.Windows.Controls.RatingItem>();
			double num = (double)list.Count<global::System.Windows.Controls.RatingItem>();
			double value = ((double)list.Take(list.IndexOf(ratingItem)).Count<global::System.Windows.Controls.RatingItem>() + newValue) / num;
			this.Value = new double?(value);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002CE5 File Offset: 0x00000EE5
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::System.Windows.Automation.Peers.RatingAutomationPeer(this);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002CF0 File Offset: 0x00000EF0
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (!this.Interaction.AllowKeyDown(e))
			{
				return;
			}
			base.OnKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			global::System.Windows.Input.Key key = e.Key;
			switch (key)
			{
			case global::System.Windows.Input.Key.Left:
			{
				global::System.Windows.Controls.RatingItem ratingItem = global::System.Windows.Input.FocusManager.GetFocusedElement(global::System.Windows.Application.Current.MainWindow) as global::System.Windows.Controls.RatingItem;
				if (ratingItem != null)
				{
					ratingItem = this.GetRatingItemAtOffsetFrom(ratingItem, -1);
				}
				else
				{
					ratingItem = this.GetRatingItems().FirstOrDefault<global::System.Windows.Controls.RatingItem>();
				}
				if (ratingItem != null && ratingItem.Focus())
				{
					e.Handled = true;
					return;
				}
				break;
			}
			case global::System.Windows.Input.Key.Up:
				break;
			case global::System.Windows.Input.Key.Right:
			{
				global::System.Windows.Controls.RatingItem ratingItem2 = global::System.Windows.Input.FocusManager.GetFocusedElement(global::System.Windows.Application.Current.MainWindow) as global::System.Windows.Controls.RatingItem;
				if (ratingItem2 != null)
				{
					ratingItem2 = this.GetRatingItemAtOffsetFrom(ratingItem2, 1);
				}
				else
				{
					ratingItem2 = this.GetRatingItems().FirstOrDefault<global::System.Windows.Controls.RatingItem>();
				}
				if (ratingItem2 != null && ratingItem2.Focus())
				{
					e.Handled = true;
					return;
				}
				break;
			}
			default:
				switch (key)
				{
				case global::System.Windows.Input.Key.Add:
					if (!this.IsReadOnly)
					{
						global::System.Windows.Controls.RatingItem ratingItem3 = this.GetSelectedRatingItem();
						if (ratingItem3 != null)
						{
							ratingItem3 = this.GetRatingItemAtOffsetFrom(ratingItem3, 1);
						}
						else
						{
							ratingItem3 = this.GetRatingItems().FirstOrDefault<global::System.Windows.Controls.RatingItem>();
						}
						if (ratingItem3 != null)
						{
							ratingItem3.SelectValue();
							e.Handled = true;
							return;
						}
					}
					break;
				case global::System.Windows.Input.Key.Separator:
					break;
				case global::System.Windows.Input.Key.Subtract:
					if (!this.IsReadOnly)
					{
						global::System.Windows.Controls.RatingItem ratingItem4 = this.GetSelectedRatingItem();
						if (ratingItem4 != null)
						{
							ratingItem4 = this.GetRatingItemAtOffsetFrom(ratingItem4, -1);
						}
						if (ratingItem4 != null)
						{
							ratingItem4.SelectValue();
							e.Handled = true;
						}
					}
					break;
				default:
					return;
				}
				break;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002E40 File Offset: 0x00001040
		private global::System.Windows.Controls.RatingItem GetRatingItemAtOffsetFrom(global::System.Windows.Controls.RatingItem ratingItem, int offset)
		{
			global::System.Collections.Generic.IList<global::System.Windows.Controls.RatingItem> list = this.GetRatingItems().ToList<global::System.Windows.Controls.RatingItem>();
			int num = list.IndexOf(ratingItem);
			if (num == -1)
			{
				return null;
			}
			num += offset;
			if (num >= 0 && num < list.Count)
			{
				ratingItem = list[num];
			}
			else
			{
				ratingItem = null;
			}
			return ratingItem;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002E87 File Offset: 0x00001087
		void global::System.Windows.Controls.IUpdateVisualState.UpdateVisualState(bool useTransitions)
		{
			this.Interaction.UpdateVisualStateBase(useTransitions);
		}

		// Token: 0x04000003 RID: 3
		protected static readonly global::System.Windows.DependencyProperty DisplayValueProperty = global::System.Windows.DependencyProperty.Register("DisplayValue", typeof(double), typeof(global::System.Windows.Controls.Rating), new global::System.Windows.PropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Rating.OnDisplayValueChanged)));

		// Token: 0x04000004 RID: 4
		public static readonly global::System.Windows.DependencyProperty ItemCountProperty = global::System.Windows.DependencyProperty.Register("ItemCount", typeof(int), typeof(global::System.Windows.Controls.Rating), new global::System.Windows.PropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Rating.OnItemCountChanged)));

		// Token: 0x04000005 RID: 5
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(global::System.Windows.Controls.Rating), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Rating.OnIsReadOnlyChanged)));

		// Token: 0x04000006 RID: 6
		public static readonly global::System.Windows.DependencyProperty SelectionModeProperty = global::System.Windows.DependencyProperty.Register("SelectionMode", typeof(global::System.Windows.Controls.RatingSelectionMode), typeof(global::System.Windows.Controls.Rating), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.RatingSelectionMode.Continuous, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Rating.OnSelectionModeChanged)));

		// Token: 0x04000007 RID: 7
		public static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(double?), typeof(global::System.Windows.Controls.Rating), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Rating.OnValueChanged)));
	}
}
