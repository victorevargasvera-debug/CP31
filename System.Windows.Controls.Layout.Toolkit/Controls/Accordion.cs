using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Properties;
using System.Windows.Data;
using System.Windows.Input;

namespace System.Windows.Controls
{
	// Token: 0x0200000B RID: 11
	[global::System.Windows.StyleTypedProperty(Property = "AccordionButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.AccordionButton))]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(global::System.Windows.Controls.AccordionItem))]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	public class Accordion : global::System.Windows.Controls.ItemsControl, global::System.Windows.Controls.IUpdateVisualState
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003BEF File Offset: 0x00001DEF
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00003BF7 File Offset: 0x00001DF7
		internal global::System.Windows.Controls.ItemsControlHelper ItemsControlHelper { get; private set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003C00 File Offset: 0x00001E00
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00003C08 File Offset: 0x00001E08
		internal bool IsResizing { get; private set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003C11 File Offset: 0x00001E11
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00003C19 File Offset: 0x00001E19
		private global::System.Windows.Controls.InteractionHelper Interaction { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003C22 File Offset: 0x00001E22
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00003C34 File Offset: 0x00001E34
		public global::System.Windows.Controls.ExpandDirection ExpandDirection
		{
			get
			{
				return (global::System.Windows.Controls.ExpandDirection)base.GetValue(global::System.Windows.Controls.Accordion.ExpandDirectionProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Accordion.ExpandDirectionProperty, value);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003C48 File Offset: 0x00001E48
		private static void OnExpandDirectionPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Accordion accordion = (global::System.Windows.Controls.Accordion)d;
			global::System.Windows.Controls.ExpandDirection expandDirection = (global::System.Windows.Controls.ExpandDirection)e.NewValue;
			if (expandDirection != global::System.Windows.Controls.ExpandDirection.Down && expandDirection != global::System.Windows.Controls.ExpandDirection.Up && expandDirection != global::System.Windows.Controls.ExpandDirection.Left && expandDirection != global::System.Windows.Controls.ExpandDirection.Right)
			{
				accordion.SetValue(global::System.Windows.Controls.Accordion.ExpandDirectionProperty, e.OldValue);
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.Accordion_OnExpandDirectionPropertyChanged_InvalidValue, new object[]
				{
					expandDirection
				});
				throw new global::System.ArgumentOutOfRangeException("e", message);
			}
			for (int i = 0; i < accordion.Items.Count; i++)
			{
				global::System.Windows.Controls.AccordionItem accordionItem = accordion.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.Controls.AccordionItem;
				if (accordionItem != null)
				{
					accordionItem.ExpandDirection = expandDirection;
				}
			}
			accordion.SetPanelOrientation();
			accordion.Dispatcher.BeginInvoke(new global::System.Action(accordion.LayoutChildren), new object[0]);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003D13 File Offset: 0x00001F13
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00003D25 File Offset: 0x00001F25
		public global::System.Windows.Controls.AccordionSelectionMode SelectionMode
		{
			get
			{
				return (global::System.Windows.Controls.AccordionSelectionMode)base.GetValue(global::System.Windows.Controls.Accordion.SelectionModeProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Accordion.SelectionModeProperty, value);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003D38 File Offset: 0x00001F38
		private static void OnSelectionModePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Accordion accordion = (global::System.Windows.Controls.Accordion)d;
			global::System.Windows.Controls.AccordionSelectionMode accordionSelectionMode = (global::System.Windows.Controls.AccordionSelectionMode)e.NewValue;
			if (accordionSelectionMode != global::System.Windows.Controls.AccordionSelectionMode.One && accordionSelectionMode != global::System.Windows.Controls.AccordionSelectionMode.OneOrMore && accordionSelectionMode != global::System.Windows.Controls.AccordionSelectionMode.ZeroOrMore && accordionSelectionMode != global::System.Windows.Controls.AccordionSelectionMode.ZeroOrOne)
			{
				accordion.SetValue(global::System.Windows.Controls.Accordion.SelectionModeProperty, e.OldValue);
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.Accordion_OnSelectionModePropertyChanged_InvalidValue, new object[]
				{
					accordionSelectionMode
				});
				throw new global::System.ArgumentOutOfRangeException("e", message);
			}
			for (int i = 0; i < accordion.Items.Count; i++)
			{
				global::System.Windows.Controls.AccordionItem accordionItem = accordion.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.Controls.AccordionItem;
				if (accordionItem != null)
				{
					accordionItem.IsLocked = false;
				}
			}
			if (accordion.IsMinimumOneSelected && accordion.GetValue(global::System.Windows.Controls.Accordion.SelectedItemProperty) == null && accordion.Items.Count > 0)
			{
				accordion.SetValue(global::System.Windows.Controls.Accordion.SelectedItemProperty, accordion.Items[0]);
			}
			if (accordion.IsMaximumOneSelected && accordion.SelectedIndices.Count > 1)
			{
				global::System.Collections.Generic.List<int> list = accordion.SelectedIndices.ToList<int>();
				foreach (int num in list)
				{
					if (num != accordion.SelectedIndex)
					{
						accordion.UnselectItem(num, null);
					}
				}
			}
			accordion.SetLockedProperties();
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003E94 File Offset: 0x00002094
		private bool IsMinimumOneSelected
		{
			get
			{
				return this.SelectionMode == global::System.Windows.Controls.AccordionSelectionMode.One || this.SelectionMode == global::System.Windows.Controls.AccordionSelectionMode.OneOrMore;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003EA9 File Offset: 0x000020A9
		private bool IsMaximumOneSelected
		{
			get
			{
				return this.SelectionMode == global::System.Windows.Controls.AccordionSelectionMode.One || this.SelectionMode == global::System.Windows.Controls.AccordionSelectionMode.ZeroOrOne;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003EBE File Offset: 0x000020BE
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00003ECB File Offset: 0x000020CB
		public object SelectedItem
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.Accordion.SelectedItemProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Accordion.SelectedItemProperty, value);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003F18 File Offset: 0x00002118
		private static void OnSelectedItemPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Accordion source = (global::System.Windows.Controls.Accordion)d;
			object oldValue = e.OldValue;
			object newValue = e.NewValue;
			object[] addedItems = (newValue == null) ? new object[0] : new object[]
			{
				newValue
			};
			object[] removedItems = (oldValue == null) ? new object[0] : new object[]
			{
				oldValue
			};
			if (oldValue != null && oldValue.Equals(newValue))
			{
				source.OnSelectedItemChanged(new global::System.Windows.Controls.SelectionChangedEventArgs(global::System.Windows.Controls.Accordion.SelectionChangedEvent, removedItems, addedItems));
				return;
			}
			if (!source.IsValidItemForSelection(newValue))
			{
				source._selectedItemNestedLevel++;
				source.SetValue(global::System.Windows.Controls.Accordion.SelectedItemProperty, oldValue);
				source._selectedItemNestedLevel--;
				return;
			}
			if (source._selectedItemNestedLevel == 0)
			{
				if (newValue == null)
				{
					source.SelectedIndex = -1;
				}
				else
				{
					int num = source.SelectedIndex;
					if (num < 0 || num > source.Items.Count || !newValue.Equals(source.Items[num]))
					{
						global::System.Collections.Generic.IEnumerable<int> source2 = from i in source.SelectedIndices
						where i >= 0 && i < source.Items.Count && newValue.Equals(source.Items[i])
						select i;
						num = ((source2.Count<int>() > 0) ? source2.First<int>() : source.Items.IndexOf(newValue));
					}
					source.SelectedIndex = num;
				}
				source.OnSelectedItemChanged(new global::System.Windows.Controls.SelectionChangedEventArgs(global::System.Windows.Controls.Accordion.SelectionChangedEvent, removedItems, addedItems));
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000040F9 File Offset: 0x000022F9
		private bool IsValidItemForSelection(object newValue)
		{
			if (newValue == null)
			{
				return !this.IsMinimumOneSelected || base.Items.Count == 0;
			}
			return base.Items.OfType<object>().Contains(newValue);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00004128 File Offset: 0x00002328
		// (set) Token: 0x06000089 RID: 137 RVA: 0x0000413A File Offset: 0x0000233A
		public int SelectedIndex
		{
			get
			{
				return (int)base.GetValue(global::System.Windows.Controls.Accordion.SelectedIndexProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Accordion.SelectedIndexProperty, value);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004150 File Offset: 0x00002350
		private static void OnSelectedIndexPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Accordion accordion = (global::System.Windows.Controls.Accordion)d;
			int num = (int)e.OldValue;
			int num2 = (int)e.NewValue;
			if (accordion._isIgnoringSelectedIndicesChanges)
			{
				return;
			}
			if (accordion.IsValidIndexForSelection(num2))
			{
				if (accordion._selectedIndexNestedLevel == 0)
				{
					accordion.SelectedItem = ((num2 >= 0 && num2 < accordion.Items.Count) ? accordion.Items[num2] : null);
					accordion.ChangeSelectedIndex(num, num2);
				}
				return;
			}
			if (accordion.IsValidIndexForSelection(num))
			{
				accordion._selectedIndexNestedLevel++;
				accordion.SetValue(global::System.Windows.Controls.Accordion.SelectedIndexProperty, num);
				accordion._selectedIndexNestedLevel--;
				return;
			}
			accordion.SetValue(global::System.Windows.Controls.Accordion.SelectedIndexProperty, accordion.ProposeSelectedIndexCandidate(num2));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004216 File Offset: 0x00002416
		private bool IsValidIndexForSelection(int newValue)
		{
			if (newValue == -1)
			{
				return !this.IsMinimumOneSelected || base.Items.Count == 0;
			}
			return newValue >= 0 && newValue < base.Items.Count;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004249 File Offset: 0x00002449
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0000425B File Offset: 0x0000245B
		public global::System.Windows.Controls.SelectionSequence SelectionSequence
		{
			get
			{
				return (global::System.Windows.Controls.SelectionSequence)base.GetValue(global::System.Windows.Controls.Accordion.SelectionSequenceProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Accordion.SelectionSequenceProperty, value);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00004270 File Offset: 0x00002470
		private static void OnSelectionSequencePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.SelectionSequence selectionSequence = (global::System.Windows.Controls.SelectionSequence)e.NewValue;
			if (selectionSequence != global::System.Windows.Controls.SelectionSequence.CollapseBeforeExpand && selectionSequence != global::System.Windows.Controls.SelectionSequence.Simultaneous)
			{
				d.SetValue(global::System.Windows.Controls.Accordion.SelectionSequenceProperty, e.OldValue);
				string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.Accordion_OnSelectionSequencepropertyChanged_InvalidValue, new object[]
				{
					selectionSequence
				});
				throw new global::System.ArgumentOutOfRangeException("e", message);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000042D0 File Offset: 0x000024D0
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000042E2 File Offset: 0x000024E2
		public global::System.Collections.IList SelectedItems
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.Accordion.SelectedItemsProperty) as global::System.Collections.IList;
			}
			private set
			{
				this._isAllowedToWriteSelectedItems = true;
				base.SetValue(global::System.Windows.Controls.Accordion.SelectedItemsProperty, value);
				this._isAllowedToWriteSelectedItems = false;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004300 File Offset: 0x00002500
		private static void OnSelectedItemsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Accordion accordion = (global::System.Windows.Controls.Accordion)d;
			if (!accordion._isAllowedToWriteSelectedItems)
			{
				accordion.SelectedItems = (e.OldValue as global::System.Collections.IList);
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_OnSelectedItemsChanged_InvalidWrite);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004339 File Offset: 0x00002539
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000434B File Offset: 0x0000254B
		public global::System.Collections.Generic.IList<int> SelectedIndices
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.Accordion.SelectedIndicesProperty) as global::System.Collections.Generic.IList<int>;
			}
			private set
			{
				this._isAllowedToWriteSelectedIndices = true;
				base.SetValue(global::System.Windows.Controls.Accordion.SelectedIndicesProperty, value);
				this._isAllowedToWriteSelectedIndices = false;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004368 File Offset: 0x00002568
		private static void OnSelectedIndicesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Controls.Accordion accordion = (global::System.Windows.Controls.Accordion)d;
			if (!accordion._isAllowedToWriteSelectedIndices)
			{
				accordion.SelectedIndices = (e.OldValue as global::System.Collections.Generic.IList<int>);
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_OnSelectedIndicesChanged_InvalidWrite);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000043A1 File Offset: 0x000025A1
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000043B3 File Offset: 0x000025B3
		public global::System.Windows.Style AccordionButtonStyle
		{
			get
			{
				return base.GetValue(global::System.Windows.Controls.Accordion.AccordionButtonStyleProperty) as global::System.Windows.Style;
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Accordion.AccordionButtonStyleProperty, value);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000043C1 File Offset: 0x000025C1
		private static void OnAccordionButtonStylePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000043C3 File Offset: 0x000025C3
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000043D5 File Offset: 0x000025D5
		public global::System.Windows.DataTemplate ContentTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::System.Windows.Controls.Accordion.ContentTemplateProperty);
			}
			set
			{
				base.SetValue(global::System.Windows.Controls.Accordion.ContentTemplateProperty, value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600009A RID: 154 RVA: 0x000043E3 File Offset: 0x000025E3
		// (remove) Token: 0x0600009B RID: 155 RVA: 0x000043F1 File Offset: 0x000025F1
		public event global::System.Windows.Controls.SelectionChangedEventHandler SelectionChanged
		{
			add
			{
				base.AddHandler(global::System.Windows.Controls.Accordion.SelectionChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::System.Windows.Controls.Accordion.SelectionChangedEvent, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600009C RID: 156 RVA: 0x000043FF File Offset: 0x000025FF
		// (remove) Token: 0x0600009D RID: 157 RVA: 0x00004418 File Offset: 0x00002618
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler SelectedItemsChanged;

		// Token: 0x0600009E RID: 158 RVA: 0x00004434 File Offset: 0x00002634
		static Accordion()
		{
			global::System.Windows.Controls.Accordion.SelectionChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectionChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.Controls.SelectionChangedEventHandler), typeof(global::System.Windows.Controls.Accordion));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::System.Windows.Controls.Accordion)));
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000466C File Offset: 0x0000286C
		public Accordion()
		{
			this.ItemsControlHelper = new global::System.Windows.Controls.ItemsControlHelper(this);
			global::System.Collections.ObjectModel.ObservableCollection<object> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<object>();
			global::System.Collections.ObjectModel.ObservableCollection<int> observableCollection2 = new global::System.Collections.ObjectModel.ObservableCollection<int>();
			this.SelectedItems = observableCollection;
			this.SelectedIndices = observableCollection2;
			observableCollection.CollectionChanged += this.OnSelectedItemsCollectionChanged;
			observableCollection2.CollectionChanged += this.OnSelectedIndicesCollectionChanged;
			this._scheduledActions = new global::System.Collections.Generic.List<global::System.Windows.Controls.AccordionItem>();
			base.SizeChanged += this.OnAccordionSizeChanged;
			this.Interaction = new global::System.Windows.Controls.InteractionHelper(this);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000046F2 File Offset: 0x000028F2
		public override void OnApplyTemplate()
		{
			this.ItemsControlHelper.OnApplyTemplate();
			base.OnApplyTemplate();
			this.Interaction.OnApplyTemplateBase();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004710 File Offset: 0x00002910
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::System.Windows.Automation.Peers.AccordionAutomationPeer(this);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004718 File Offset: 0x00002918
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::System.Windows.Controls.AccordionItem();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000471F File Offset: 0x0000291F
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::System.Windows.Controls.AccordionItem;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000472C File Offset: 0x0000292C
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = element as global::System.Windows.Controls.AccordionItem;
			if (accordionItem != null)
			{
				global::System.Windows.DataTemplate contentTemplate = accordionItem.ContentTemplate;
				base.PrepareContainerForItemOverride(element, item);
				global::System.Windows.Controls.ItemsControlHelper.PrepareContainerForItemOverride(accordionItem, base.ItemContainerStyle);
				global::System.Windows.Controls.AccordionItem.PreparePrepareHeaderedContentControlContainerForItemOverride(accordionItem, item, this, base.ItemContainerStyle);
				global::System.Windows.DataTemplate contentTemplate2 = accordionItem.ContentTemplate;
				accordionItem.ContentTemplate = contentTemplate;
				if (accordionItem.ContentTemplate == null)
				{
					accordionItem.SetBinding(global::System.Windows.Controls.ContentControl.ContentTemplateProperty, new global::System.Windows.Data.Binding("ContentTemplate")
					{
						Source = this,
						Mode = global::System.Windows.Data.BindingMode.OneWay
					});
				}
				if (accordionItem.HeaderTemplate == null)
				{
					accordionItem.SetBinding(global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty, new global::System.Windows.Data.Binding("ItemTemplate")
					{
						Source = this,
						Mode = global::System.Windows.Data.BindingMode.OneWay
					});
				}
				if (accordionItem.AccordionButtonStyle == null)
				{
					accordionItem.SetBinding(global::System.Windows.Controls.AccordionItem.AccordionButtonStyleProperty, new global::System.Windows.Data.Binding("AccordionButtonStyle")
					{
						Source = this,
						Mode = global::System.Windows.Data.BindingMode.OneWay
					});
				}
				if (contentTemplate2 != null && !string.IsNullOrEmpty(base.DisplayMemberPath))
				{
					if (accordionItem.ContentTemplate == null)
					{
						accordionItem.ContentTemplate = contentTemplate2;
					}
					if (accordionItem.HeaderTemplate == null)
					{
						accordionItem.HeaderTemplate = contentTemplate2;
					}
				}
				accordionItem.ParentAccordion = this;
				int item2 = base.ItemContainerGenerator.IndexFromContainer(accordionItem);
				if (!accordionItem.IsSelected && this.SelectedIndices.Contains(item2))
				{
					accordionItem.IsSelected = true;
				}
				if (accordionItem.IsSelected)
				{
					this.SelectedItem = item;
				}
				if (accordionItem.IsSelected)
				{
					if (!this.SelectedItems.OfType<object>().Contains(item))
					{
						this.SelectedItems.Add(item);
					}
					if (!this.SelectedIndices.Contains(item2))
					{
						this.SelectedIndices.Add(item2);
					}
				}
				accordionItem.ExpandDirection = this.ExpandDirection;
			}
			else
			{
				base.PrepareContainerForItemOverride(element, item);
				global::System.Windows.Controls.ItemsControlHelper.PrepareContainerForItemOverride(element, base.ItemContainerStyle);
			}
			this.SetPanelOrientation();
			this.SetLockedProperties();
			base.Dispatcher.BeginInvoke(new global::System.Action(this.LayoutChildren), new object[0]);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004910 File Offset: 0x00002B10
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = element as global::System.Windows.Controls.AccordionItem;
			if (accordionItem != null)
			{
				accordionItem.IsLocked = false;
				accordionItem.IsSelected = false;
				accordionItem.ParentAccordion = null;
			}
			base.ClearContainerForItemOverride(element, item);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004980 File Offset: 0x00002B80
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				try
				{
					this._isIgnoringSelectedIndicesChanges = true;
					for (int k = 0; k < this.SelectedIndices.Count; k++)
					{
						if (this.SelectedIndices[k] >= e.NewStartingIndex)
						{
							this.SelectedIndices[k] = this.SelectedIndices[k] + 1;
						}
					}
				}
				finally
				{
					this._isIgnoringSelectedIndicesChanges = false;
				}
				if (this.SelectedIndex >= e.NewStartingIndex && this.SelectedIndex > -1)
				{
					this.SelectedIndex++;
				}
				if (this.SelectedItem == null && this.IsMinimumOneSelected)
				{
					if (!this.SelectedItems.OfType<object>().Contains(e.NewItems[0]))
					{
						this.SelectedItems.Add(e.NewItems[0]);
					}
					this.SelectedItem = e.NewItems[0];
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			{
				int oldStartingIndex = e.OldStartingIndex;
				object item = e.OldItems[0];
				try
				{
					this._isIgnoringSelectedIndicesChanges = true;
					if (this.SelectedIndices.Contains(oldStartingIndex))
					{
						this.SelectedIndices.Remove(oldStartingIndex);
					}
					for (int j = 0; j < this.SelectedIndices.Count; j++)
					{
						if (this.SelectedIndices[j] > oldStartingIndex)
						{
							this.SelectedIndices[j] = this.SelectedIndices[j] - 1;
						}
					}
				}
				finally
				{
					this._isIgnoringSelectedIndicesChanges = false;
				}
				try
				{
					this._isIgnoringSelectedItemsChanges = true;
					if (this.SelectedItems.Contains(item))
					{
						if (this.SelectedIndices.Count((int i) => i < this.Items.Count && this.Items[i].Equals(item)) == 0)
						{
							this.SelectedItems.Remove(item);
						}
					}
				}
				finally
				{
					this._isIgnoringSelectedItemsChanges = false;
				}
				if (this.SelectedIndex == oldStartingIndex)
				{
					this.SelectedIndex = -1;
				}
				if (this.SelectedIndex > e.OldStartingIndex && this.SelectedIndex > -1)
				{
					this.SelectedIndex--;
				}
				break;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				this._isIgnoringSelectedIndicesChanges = true;
				this._isIgnoringSelectedItemsChanges = true;
				try
				{
					this.SelectedItems.Clear();
					this.SelectedIndices.Clear();
					this.SelectedItem = null;
					this.SelectedIndex = -1;
				}
				finally
				{
					this._isIgnoringSelectedIndicesChanges = false;
					this._isIgnoringSelectedItemsChanges = false;
				}
				this.InitializeNewItemsSource();
				break;
			}
			this.SetPanelOrientation();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004C44 File Offset: 0x00002E44
		private void InitializeNewItemsSource()
		{
			if (this.IsMinimumOneSelected && this.SelectedItem == null && base.Items.Count > 0)
			{
				if (!this.SelectedItems.OfType<object>().Contains(base.Items[0]))
				{
					this.SelectedItems.Add(base.Items[0]);
				}
				this.SelectedItem = base.Items[0];
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004CB7 File Offset: 0x00002EB7
		internal void OnAccordionItemUnselected(global::System.Windows.Controls.AccordionItem accordionItem)
		{
			this.UnselectItem(base.ItemContainerGenerator.IndexFromContainer(accordionItem), base.ItemContainerGenerator.ItemFromContainer(accordionItem));
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004D1C File Offset: 0x00002F1C
		private void UnselectItem(int index, object item)
		{
			if (index < 0 || index > base.Items.Count)
			{
				return;
			}
			global::System.Windows.Controls.AccordionItem accordionItem = (index >= 0 && index < base.Items.Count) ? (base.ItemContainerGenerator.ContainerFromIndex(index) as global::System.Windows.Controls.AccordionItem) : null;
			if (accordionItem != null && accordionItem.IsSelected)
			{
				accordionItem.IsLocked = false;
				accordionItem.IsSelected = false;
				return;
			}
			item = (item ?? base.Items[index]);
			int num = -1;
			if (this.SelectedIndex > -1 && this.SelectedIndex == index)
			{
				num = this.ProposeSelectedIndexCandidate(index);
				this.SelectedIndex = num;
			}
			if (this.SelectedItems.OfType<object>().Contains(item) && index != num && !item.Equals(this.SelectedItem))
			{
				if (this.SelectedIndices.Count((int i) => i != index && i < this.Items.Count && this.Items[i].Equals(item)) == 0)
				{
					if (this._isInSelectedItemsCollectionChanged)
					{
						throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
					}
					this.SelectedItems.Remove(item);
				}
			}
			if (this.SelectedIndices.Contains(index))
			{
				if (this._isInSelectedIndicesCollectionChanged)
				{
					throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
				}
				this.SelectedIndices.Remove(index);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004EAF File Offset: 0x000030AF
		internal void OnAccordionItemSelected(global::System.Windows.Controls.AccordionItem accordionItem)
		{
			this.SelectItem(base.ItemContainerGenerator.IndexFromContainer(accordionItem));
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004EC4 File Offset: 0x000030C4
		private void SelectItem(int index)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = (index >= 0 && index < base.Items.Count) ? (base.ItemContainerGenerator.ContainerFromIndex(index) as global::System.Windows.Controls.AccordionItem) : null;
			if (accordionItem != null && !accordionItem.IsSelected)
			{
				accordionItem.IsSelected = true;
				return;
			}
			this.SelectedIndex = index;
			object obj = base.Items[index];
			if (obj != null)
			{
				if (!this.SelectedItems.OfType<object>().Contains(obj))
				{
					if (this._isInSelectedItemsCollectionChanged)
					{
						throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
					}
					this.SelectedItems.Add(obj);
				}
				if (!this.SelectedIndices.Contains(index))
				{
					if (this._isInSelectedIndicesCollectionChanged)
					{
						throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
					}
					this.SelectedIndices.Add(index);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004F84 File Offset: 0x00003184
		private void ChangeSelectedIndex(int oldIndex, int newIndex)
		{
			global::System.Windows.Controls.AccordionItem accordionItem = (oldIndex >= 0 && oldIndex < base.Items.Count) ? (base.ItemContainerGenerator.ContainerFromIndex(oldIndex) as global::System.Windows.Controls.AccordionItem) : null;
			global::System.Windows.Controls.AccordionItem accordionItem2 = (newIndex >= 0 && newIndex < base.Items.Count) ? (base.ItemContainerGenerator.ContainerFromIndex(newIndex) as global::System.Windows.Controls.AccordionItem) : null;
			if (oldIndex != newIndex && (this.IsMaximumOneSelected || newIndex == -1))
			{
				if (accordionItem != null)
				{
					accordionItem.IsLocked = false;
					accordionItem.IsSelected = false;
				}
				else if (oldIndex > -1)
				{
					this.UnselectItem(oldIndex, null);
				}
				if (accordionItem2 != null && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected))
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(accordionItem2);
					if (automationPeer != null)
					{
						automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected);
					}
				}
			}
			if (accordionItem2 != null)
			{
				accordionItem2.IsSelected = true;
			}
			else if (newIndex != -1)
			{
				this.SelectItem(newIndex);
			}
			this.SelectedIndex = newIndex;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005130 File Offset: 0x00003330
		private void OnSelectedItemsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._isIgnoringSelectedItemsChanges)
			{
				return;
			}
			this._isInSelectedItemsCollectionChanged = true;
			int i;
			global::System.Action<object> action = delegate(object item)
			{
				global::System.Collections.Generic.List<int> list = (from i in this.SelectedIndices
				where i < this.Items.Count && item.Equals(this.Items[i])
				select i).ToList<int>();
				if (list.Count > 0)
				{
					using (global::System.Collections.Generic.List<int>.Enumerator enumerator3 = list.GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							int index = enumerator3.Current;
							this.UnselectItem(index, item);
						}
						return;
					}
				}
				this.UnselectItem(base.Items.IndexOf(item), item);
			};
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				if (this.IsMaximumOneSelected && this.SelectedItem != null && !e.NewItems.Contains(this.SelectedItem))
				{
					throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
				}
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object selectedItem = obj;
						this.SelectedItem = selectedItem;
					}
					goto IL_1C7;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				goto IL_195;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				goto IL_121;
			default:
				goto IL_195;
			}
			if (this.IsMinimumOneSelected && e.OldItems.Contains(this.SelectedItem))
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
			}
			using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					object obj3 = obj2;
					action(obj3);
				}
				goto IL_1C7;
			}
			IL_121:
			if (this.IsMinimumOneSelected && base.Items.Count > 0)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
			}
			for (i = this.SelectedIndices.Count - 1; i >= 0; i--)
			{
				int num = this.SelectedIndices[i];
				if (num < base.Items.Count)
				{
					object obj4 = base.Items[num];
					action(obj4);
				}
			}
			goto IL_1C7;
			IL_195:
			string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.Accordion_UnsupportedCollectionAction, new object[]
			{
				e.Action
			});
			throw new global::System.NotSupportedException(message);
			IL_1C7:
			this.RaiseOnSelectedItemsCollectionChanged(e);
			this._isInSelectedItemsCollectionChanged = false;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005330 File Offset: 0x00003530
		private void OnSelectedIndicesCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._isIgnoringSelectedIndicesChanges)
			{
				return;
			}
			this._isInSelectedIndicesCollectionChanged = true;
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				if (this.IsMaximumOneSelected && ((this.SelectedItem != null && e.NewItems.Count != 1) || ((int)e.NewItems[0] < base.Items.Count && !base.Items[(int)e.NewItems[0]].Equals(this.SelectedItem))))
				{
					throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
				}
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						int num = (int)obj;
						if (num < base.Items.Count)
						{
							this.SelectedIndex = num;
							if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection))
							{
								global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this);
								if (automationPeer != null)
								{
									automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection);
								}
							}
						}
					}
					goto IL_292;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				goto IL_260;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				goto IL_1EC;
			default:
				goto IL_260;
			}
			if (this.IsMinimumOneSelected && e.OldItems.Contains(this.SelectedIndex) && this.SelectedIndex < base.Items.Count && base.Items[this.SelectedIndex].Equals(this.SelectedItem) && this.SelectedIndices.Count == 0)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
			}
			using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					object obj2 = enumerator2.Current;
					int num2 = (int)obj2;
					if (num2 < base.Items.Count)
					{
						this.UnselectItem(num2, null);
						if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
						{
							global::System.Windows.Automation.Peers.AutomationPeer automationPeer2 = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this);
							if (automationPeer2 != null)
							{
								automationPeer2.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection);
							}
						}
					}
				}
				goto IL_292;
			}
			IL_1EC:
			if (this.IsMinimumOneSelected && base.Items.Count > 0)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_InvalidManipulationOfSelectionCollections);
			}
			for (int i = this.SelectedItems.Count - 1; i >= 0; i--)
			{
				object item = this.SelectedItems[i];
				this.UnselectItem(i, item);
				if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer3 = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this);
					if (automationPeer3 != null)
					{
						automationPeer3.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection);
					}
				}
			}
			goto IL_292;
			IL_260:
			string message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::System.Windows.Controls.Properties.Resources.Accordion_UnsupportedCollectionAction, new object[]
			{
				e.Action
			});
			throw new global::System.NotSupportedException(message);
			IL_292:
			this.SetLockedProperties();
			this.LayoutChildren();
			this._isInSelectedIndicesCollectionChanged = false;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005640 File Offset: 0x00003840
		private int ProposeSelectedIndexCandidate(int nonCandidateIndex)
		{
			object item = (nonCandidateIndex >= 0 && nonCandidateIndex < base.Items.Count) ? base.Items[nonCandidateIndex] : null;
			global::System.Collections.Generic.IEnumerable<int> source = from i in this.SelectedIndices
			where i != nonCandidateIndex && (item == null || !item.Equals(this.Items[i]))
			select i;
			if (source.Count<int>() > 0)
			{
				return source.First<int>();
			}
			if (this.IsMinimumOneSelected && base.Items.Count > 0)
			{
				return 0;
			}
			return -1;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000056D8 File Offset: 0x000038D8
		public void SelectAll()
		{
			this.UpdateAccordionItemsSelection(true);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000056E1 File Offset: 0x000038E1
		public void UnselectAll()
		{
			this.UpdateAccordionItemsSelection(false);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000056EC File Offset: 0x000038EC
		private void UpdateAccordionItemsSelection(bool selectedValue)
		{
			foreach (object item in ((global::System.Collections.IEnumerable)base.Items))
			{
				global::System.Windows.Controls.AccordionItem accordionItem = base.ItemContainerGenerator.ContainerFromItem(item) as global::System.Windows.Controls.AccordionItem;
				if (accordionItem != null && !accordionItem.IsLocked)
				{
					accordionItem.IsSelected = selectedValue;
				}
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005760 File Offset: 0x00003960
		private void SetLockedProperties()
		{
			for (int i = 0; i < base.Items.Count; i++)
			{
				global::System.Windows.Controls.AccordionItem accordionItem = base.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.Controls.AccordionItem;
				if (accordionItem != null)
				{
					accordionItem.IsLocked = (accordionItem.IsSelected && this.IsMinimumOneSelected && this.SelectedIndices.Count == 1);
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000057BF File Offset: 0x000039BF
		protected virtual void OnSelectedItemChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000057C8 File Offset: 0x000039C8
		private void RaiseOnSelectedItemsCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventHandler selectedItemsChanged = this.SelectedItemsChanged;
			if (selectedItemsChanged != null)
			{
				selectedItemsChanged(this, e);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000057E7 File Offset: 0x000039E7
		private void OnAccordionSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.IsResizing = true;
			this.LayoutChildren();
			this.IsResizing = false;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000057FD File Offset: 0x000039FD
		internal void OnHeaderSizeChange(global::System.Windows.Controls.AccordionItem item)
		{
			this.LayoutChildren();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00005808 File Offset: 0x00003A08
		internal virtual bool ScheduleAction(global::System.Windows.Controls.AccordionItem item, global::System.Windows.Controls.AccordionAction action)
		{
			if (this.SelectionSequence == global::System.Windows.Controls.SelectionSequence.CollapseBeforeExpand)
			{
				lock (this)
				{
					if (!this._scheduledActions.Contains(item))
					{
						this._scheduledActions.Add(item);
					}
				}
				if (this._currentActioningItem == null)
				{
					base.Dispatcher.BeginInvoke(new global::System.Action(this.StartNextAction), new object[0]);
				}
				return false;
			}
			return true;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005884 File Offset: 0x00003A84
		internal virtual void OnActionFinish(global::System.Windows.Controls.AccordionItem item)
		{
			if (this.SelectionSequence == global::System.Windows.Controls.SelectionSequence.CollapseBeforeExpand)
			{
				lock (this)
				{
					if (!this._currentActioningItem.Equals(item))
					{
						throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Accordion_OnActionFinish_InvalidFinish);
					}
					this._currentActioningItem = null;
					this.StartNextAction();
				}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005904 File Offset: 0x00003B04
		private void StartNextAction()
		{
			if (this._currentActioningItem != null)
			{
				return;
			}
			global::System.Windows.Controls.AccordionItem accordionItem = this._scheduledActions.FirstOrDefault((global::System.Windows.Controls.AccordionItem item) => item.ScheduledAction == global::System.Windows.Controls.AccordionAction.Collapse);
			if (accordionItem == null)
			{
				accordionItem = this._scheduledActions.FirstOrDefault((global::System.Windows.Controls.AccordionItem item) => item.ScheduledAction == global::System.Windows.Controls.AccordionAction.Resize);
			}
			if (accordionItem == null)
			{
				accordionItem = this._scheduledActions.FirstOrDefault((global::System.Windows.Controls.AccordionItem item) => item.ScheduledAction == global::System.Windows.Controls.AccordionAction.Expand);
			}
			if (accordionItem != null)
			{
				this._currentActioningItem = accordionItem;
				this._scheduledActions.Remove(accordionItem);
				accordionItem.StartAction();
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000059B8 File Offset: 0x00003BB8
		private void LayoutChildren()
		{
			global::System.Windows.Controls.ScrollViewer scrollHost = this.ItemsControlHelper.ScrollHost;
			global::System.Windows.Size contentTargetSize = new global::System.Windows.Size(double.NaN, double.NaN);
			if (scrollHost != null && this.ItemsControlHelper.ItemsHost != null)
			{
				if (this.IsShouldFillWidth)
				{
					contentTargetSize.Width = global::System.Math.Max(0.0, scrollHost.ViewportWidth - this.ItemsControlHelper.ItemsHost.ActualWidth);
					foreach (object item in ((global::System.Collections.IEnumerable)base.Items))
					{
						global::System.Windows.Controls.AccordionItem accordionItem = base.ItemContainerGenerator.ContainerFromItem(item) as global::System.Windows.Controls.AccordionItem;
						if (accordionItem != null)
						{
							contentTargetSize.Width += accordionItem.RelevantContentSize.Width;
						}
					}
					double num = scrollHost.ViewportWidth - this.ItemsControlHelper.ItemsHost.ActualWidth;
					if (num < 0.0)
					{
						contentTargetSize.Width = global::System.Math.Max(0.0, contentTargetSize.Width + num);
					}
					if (contentTargetSize.Width > 1.0)
					{
						contentTargetSize.Width -= 1.0;
					}
					if (scrollHost.ExtentWidth > scrollHost.ViewportWidth)
					{
						contentTargetSize.Width = global::System.Math.Max(0.0, contentTargetSize.Width - (scrollHost.ExtentWidth - scrollHost.ViewportWidth));
					}
					contentTargetSize.Width = ((this.SelectedItems.Count > 0) ? (contentTargetSize.Width / (double)this.SelectedItems.Count) : contentTargetSize.Width);
				}
				else if (this.IsShouldFillHeight)
				{
					contentTargetSize.Height = global::System.Math.Max(0.0, scrollHost.ViewportHeight - this.ItemsControlHelper.ItemsHost.ActualHeight);
					foreach (object item2 in ((global::System.Collections.IEnumerable)base.Items))
					{
						global::System.Windows.Controls.AccordionItem accordionItem2 = base.ItemContainerGenerator.ContainerFromItem(item2) as global::System.Windows.Controls.AccordionItem;
						if (accordionItem2 != null)
						{
							contentTargetSize.Height += accordionItem2.RelevantContentSize.Height;
						}
					}
					double num2 = scrollHost.ViewportHeight - this.ItemsControlHelper.ItemsHost.ActualHeight;
					if (num2 < 0.0)
					{
						contentTargetSize.Height = global::System.Math.Max(0.0, contentTargetSize.Height + num2);
					}
					if (contentTargetSize.Height > 1.0)
					{
						contentTargetSize.Height -= 1.0;
					}
					contentTargetSize.Height = ((this.SelectedItems.Count > 0) ? (contentTargetSize.Height / (double)this.SelectedItems.Count) : contentTargetSize.Height);
				}
				foreach (object item3 in ((global::System.Collections.IEnumerable)base.Items))
				{
					global::System.Windows.Controls.AccordionItem accordionItem3 = base.ItemContainerGenerator.ContainerFromItem(item3) as global::System.Windows.Controls.AccordionItem;
					if (accordionItem3 != null && accordionItem3.IsSelected)
					{
						accordionItem3.ContentTargetSize = contentTargetSize;
					}
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00005D4C File Offset: 0x00003F4C
		private bool IsShouldFillWidth
		{
			get
			{
				return (this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Left || this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Right) && (!double.IsNaN(base.Width) || base.HorizontalAlignment == global::System.Windows.HorizontalAlignment.Stretch);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00005D7A File Offset: 0x00003F7A
		private bool IsShouldFillHeight
		{
			get
			{
				return (this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Down || this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Up) && (!double.IsNaN(base.Height) || base.VerticalAlignment == global::System.Windows.VerticalAlignment.Stretch);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005DA8 File Offset: 0x00003FA8
		private void SetPanelOrientation()
		{
			global::System.Windows.Controls.StackPanel stackPanel = this.ItemsControlHelper.ItemsHost as global::System.Windows.Controls.StackPanel;
			if (stackPanel != null)
			{
				switch (this.ExpandDirection)
				{
				case global::System.Windows.Controls.ExpandDirection.Down:
				case global::System.Windows.Controls.ExpandDirection.Up:
					stackPanel.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
					stackPanel.VerticalAlignment = ((this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Down) ? global::System.Windows.VerticalAlignment.Top : global::System.Windows.VerticalAlignment.Bottom);
					stackPanel.Orientation = global::System.Windows.Controls.Orientation.Vertical;
					return;
				case global::System.Windows.Controls.ExpandDirection.Left:
				case global::System.Windows.Controls.ExpandDirection.Right:
					stackPanel.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
					stackPanel.HorizontalAlignment = ((this.ExpandDirection == global::System.Windows.Controls.ExpandDirection.Left) ? global::System.Windows.HorizontalAlignment.Right : global::System.Windows.HorizontalAlignment.Left);
					stackPanel.Orientation = global::System.Windows.Controls.Orientation.Horizontal;
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005E29 File Offset: 0x00004029
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this.Interaction.AllowGotFocus(e))
			{
				this.Interaction.OnGotFocusBase();
				base.OnGotFocus(e);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005E4B File Offset: 0x0000404B
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this.Interaction.AllowLostFocus(e))
			{
				this.Interaction.OnLostFocusBase();
				base.OnLostFocus(e);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005E6D File Offset: 0x0000406D
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.Interaction.AllowMouseEnter(e))
			{
				this.Interaction.OnMouseEnterBase();
				base.OnMouseEnter(e);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005E8F File Offset: 0x0000408F
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.Interaction.AllowMouseLeave(e))
			{
				this.Interaction.OnMouseLeaveBase();
				base.OnMouseLeave(e);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005EB1 File Offset: 0x000040B1
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Interaction.AllowMouseLeftButtonDown(e))
			{
				this.Interaction.OnMouseLeftButtonDownBase();
				base.OnMouseLeftButtonDown(e);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005ED3 File Offset: 0x000040D3
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Interaction.AllowMouseLeftButtonUp(e))
			{
				this.Interaction.OnMouseLeftButtonUpBase();
				base.OnMouseLeftButtonUp(e);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005EF5 File Offset: 0x000040F5
		void global::System.Windows.Controls.IUpdateVisualState.UpdateVisualState(bool useTransitions)
		{
			this.UpdateVisualState(useTransitions);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005EFE File Offset: 0x000040FE
		internal virtual void UpdateVisualState(bool useTransitions)
		{
			this.Interaction.UpdateVisualStateBase(useTransitions);
		}

		// Token: 0x04000028 RID: 40
		private const string AccordionButtonStyleName = "AccordionButtonStyle";

		// Token: 0x04000029 RID: 41
		private readonly global::System.Collections.Generic.List<global::System.Windows.Controls.AccordionItem> _scheduledActions;

		// Token: 0x0400002A RID: 42
		private bool _isAllowedToWriteSelectedItems;

		// Token: 0x0400002B RID: 43
		private bool _isAllowedToWriteSelectedIndices;

		// Token: 0x0400002C RID: 44
		private bool _isIgnoringSelectedIndicesChanges;

		// Token: 0x0400002D RID: 45
		private bool _isIgnoringSelectedItemsChanges;

		// Token: 0x0400002E RID: 46
		private bool _isInSelectedItemsCollectionChanged;

		// Token: 0x0400002F RID: 47
		private bool _isInSelectedIndicesCollectionChanged;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Controls.AccordionItem _currentActioningItem;

		// Token: 0x04000031 RID: 49
		public static readonly global::System.Windows.DependencyProperty ExpandDirectionProperty = global::System.Windows.DependencyProperty.Register("ExpandDirection", typeof(global::System.Windows.Controls.ExpandDirection), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.ExpandDirection.Down, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Accordion.OnExpandDirectionPropertyChanged)));

		// Token: 0x04000032 RID: 50
		public static readonly global::System.Windows.DependencyProperty SelectionModeProperty = global::System.Windows.DependencyProperty.Register("SelectionMode", typeof(global::System.Windows.Controls.AccordionSelectionMode), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.AccordionSelectionMode.One, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Accordion.OnSelectionModePropertyChanged)));

		// Token: 0x04000033 RID: 51
		public static readonly global::System.Windows.DependencyProperty SelectedItemProperty = global::System.Windows.DependencyProperty.Register("SelectedItem", typeof(object), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Accordion.OnSelectedItemPropertyChanged)));

		// Token: 0x04000034 RID: 52
		private int _selectedItemNestedLevel;

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty SelectedIndexProperty = global::System.Windows.DependencyProperty.Register("SelectedIndex", typeof(int), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Accordion.OnSelectedIndexPropertyChanged)));

		// Token: 0x04000036 RID: 54
		private int _selectedIndexNestedLevel;

		// Token: 0x04000037 RID: 55
		public static readonly global::System.Windows.DependencyProperty SelectionSequenceProperty = global::System.Windows.DependencyProperty.Register("SelectionSequence", typeof(global::System.Windows.Controls.SelectionSequence), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.SelectionSequence.Simultaneous, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Accordion.OnSelectionSequencePropertyChanged)));

		// Token: 0x04000038 RID: 56
		public static readonly global::System.Windows.DependencyProperty SelectedItemsProperty = global::System.Windows.DependencyProperty.Register("SelectedItems", typeof(global::System.Collections.IList), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Accordion.OnSelectedItemsChanged)));

		// Token: 0x04000039 RID: 57
		public static readonly global::System.Windows.DependencyProperty SelectedIndicesProperty = global::System.Windows.DependencyProperty.Register("SelectedIndices", typeof(global::System.Collections.Generic.IList<int>), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Accordion.OnSelectedIndicesChanged)));

		// Token: 0x0400003A RID: 58
		public static readonly global::System.Windows.DependencyProperty AccordionButtonStyleProperty = global::System.Windows.DependencyProperty.Register("AccordionButtonStyle", typeof(global::System.Windows.Style), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::System.Windows.Controls.Accordion.OnAccordionButtonStylePropertyChanged)));

		// Token: 0x0400003B RID: 59
		public static readonly global::System.Windows.DependencyProperty ContentTemplateProperty = global::System.Windows.DependencyProperty.Register("ContentTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::System.Windows.Controls.Accordion), new global::System.Windows.PropertyMetadata(null));
	}
}
