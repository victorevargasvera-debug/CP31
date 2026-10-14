using System;
using System.Collections;
using System.Linq;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace System.Windows.Controls
{
	// Token: 0x0200000B RID: 11
	public class SelectorSelectionAdapter : global::System.Windows.Controls.ISelectionAdapter
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000035F7 File Offset: 0x000017F7
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000035FF File Offset: 0x000017FF
		private bool IgnoringSelectionChanged { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00003608 File Offset: 0x00001808
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00003610 File Offset: 0x00001810
		public global::System.Windows.Controls.Primitives.Selector SelectorControl
		{
			get
			{
				return this._selector;
			}
			set
			{
				if (this._selector != null)
				{
					this._selector.SelectionChanged -= this.OnSelectionChanged;
					this._selector.MouseLeftButtonUp -= this.OnSelectorMouseLeftButtonUp;
				}
				this._selector = value;
				if (this._selector != null)
				{
					this._selector.SelectionChanged += this.OnSelectionChanged;
					this._selector.MouseLeftButtonUp += this.OnSelectorMouseLeftButtonUp;
				}
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000069 RID: 105 RVA: 0x00003690 File Offset: 0x00001890
		// (remove) Token: 0x0600006A RID: 106 RVA: 0x000036A9 File Offset: 0x000018A9
		public event global::System.Windows.Controls.SelectionChangedEventHandler SelectionChanged;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600006B RID: 107 RVA: 0x000036C2 File Offset: 0x000018C2
		// (remove) Token: 0x0600006C RID: 108 RVA: 0x000036DB File Offset: 0x000018DB
		public event global::System.Windows.RoutedEventHandler Commit;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600006D RID: 109 RVA: 0x000036F4 File Offset: 0x000018F4
		// (remove) Token: 0x0600006E RID: 110 RVA: 0x0000370D File Offset: 0x0000190D
		public event global::System.Windows.RoutedEventHandler Cancel;

		// Token: 0x0600006F RID: 111 RVA: 0x00003726 File Offset: 0x00001926
		public SelectorSelectionAdapter()
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000372E File Offset: 0x0000192E
		public SelectorSelectionAdapter(global::System.Windows.Controls.Primitives.Selector selector)
		{
			this.SelectorControl = selector;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000373D File Offset: 0x0000193D
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00003754 File Offset: 0x00001954
		public object SelectedItem
		{
			get
			{
				if (this.SelectorControl != null)
				{
					return this.SelectorControl.SelectedItem;
				}
				return null;
			}
			set
			{
				this.IgnoringSelectionChanged = true;
				if (this.SelectorControl != null)
				{
					this.SelectorControl.SelectedItem = value;
				}
				if (value == null)
				{
					this.ResetScrollViewer();
				}
				this.IgnoringSelectionChanged = false;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003781 File Offset: 0x00001981
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00003798 File Offset: 0x00001998
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				if (this.SelectorControl != null)
				{
					return this.SelectorControl.ItemsSource;
				}
				return null;
			}
			set
			{
				if (this.SelectorControl != null)
				{
					this.SelectorControl.ItemsSource = value;
				}
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000037B0 File Offset: 0x000019B0
		private void ResetScrollViewer()
		{
			if (this.SelectorControl != null)
			{
				global::System.Windows.Controls.ScrollViewer scrollViewer = this.SelectorControl.GetLogicalChildrenBreadthFirst().OfType<global::System.Windows.Controls.ScrollViewer>().FirstOrDefault<global::System.Windows.Controls.ScrollViewer>();
				if (scrollViewer != null)
				{
					scrollViewer.ScrollToTop();
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000037E4 File Offset: 0x000019E4
		private void OnSelectorMouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.OnCommit();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000037EC File Offset: 0x000019EC
		private void OnSelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (this.IgnoringSelectionChanged)
			{
				return;
			}
			global::System.Windows.Controls.SelectionChangedEventHandler selectionChanged = this.SelectionChanged;
			if (selectionChanged != null)
			{
				selectionChanged(sender, e);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003814 File Offset: 0x00001A14
		protected void SelectedIndexIncrement()
		{
			if (this.SelectorControl != null)
			{
				this.SelectorControl.SelectedIndex = ((this.SelectorControl.SelectedIndex + 1 >= this.SelectorControl.Items.Count) ? -1 : (this.SelectorControl.SelectedIndex + 1));
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003864 File Offset: 0x00001A64
		protected void SelectedIndexDecrement()
		{
			if (this.SelectorControl != null)
			{
				int selectedIndex = this.SelectorControl.SelectedIndex;
				if (selectedIndex >= 0)
				{
					this.SelectorControl.SelectedIndex--;
					return;
				}
				if (selectedIndex == -1)
				{
					this.SelectorControl.SelectedIndex = this.SelectorControl.Items.Count - 1;
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000038C0 File Offset: 0x00001AC0
		public void HandleKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.Key key = e.Key;
			if (key != global::System.Windows.Input.Key.Return)
			{
				if (key != global::System.Windows.Input.Key.Escape)
				{
					switch (key)
					{
					case global::System.Windows.Input.Key.Up:
						this.SelectedIndexDecrement();
						e.Handled = true;
						return;
					case global::System.Windows.Input.Key.Right:
						break;
					case global::System.Windows.Input.Key.Down:
						if ((global::System.Windows.Input.ModifierKeys.Alt & global::System.Windows.Input.Keyboard.Modifiers) == global::System.Windows.Input.ModifierKeys.None)
						{
							this.SelectedIndexIncrement();
							e.Handled = true;
							return;
						}
						break;
					default:
						return;
					}
				}
				else
				{
					this.OnCancel();
					e.Handled = true;
				}
				return;
			}
			this.OnCommit();
			e.Handled = true;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00003933 File Offset: 0x00001B33
		protected virtual void OnCommit()
		{
			this.OnCommit(this, new global::System.Windows.RoutedEventArgs());
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003944 File Offset: 0x00001B44
		private void OnCommit(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.RoutedEventHandler commit = this.Commit;
			if (commit != null)
			{
				commit(sender, e);
			}
			this.AfterAdapterAction();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003969 File Offset: 0x00001B69
		protected virtual void OnCancel()
		{
			this.OnCancel(this, new global::System.Windows.RoutedEventArgs());
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003978 File Offset: 0x00001B78
		private void OnCancel(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.RoutedEventHandler cancel = this.Cancel;
			if (cancel != null)
			{
				cancel(sender, e);
			}
			this.AfterAdapterAction();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000399D File Offset: 0x00001B9D
		private void AfterAdapterAction()
		{
			this.IgnoringSelectionChanged = true;
			if (this.SelectorControl != null)
			{
				this.SelectorControl.SelectedItem = null;
				this.SelectorControl.SelectedIndex = -1;
			}
			this.IgnoringSelectionChanged = false;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000039CD File Offset: 0x00001BCD
		public global::System.Windows.Automation.Peers.AutomationPeer CreateAutomationPeer()
		{
			if (this._selector == null)
			{
				return null;
			}
			return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this._selector);
		}

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Controls.Primitives.Selector _selector;
	}
}
