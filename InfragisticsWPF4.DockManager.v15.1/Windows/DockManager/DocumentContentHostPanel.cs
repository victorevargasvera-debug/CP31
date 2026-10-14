using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000032 RID: 50
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DocumentContentHostPanel : global::System.Windows.FrameworkElement
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x0000DA46 File Offset: 0x0000BC46
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this._splitPane != null)
			{
				this._splitPane.Arrange(new global::System.Windows.Rect(finalSize));
			}
			return finalSize;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000DA62 File Offset: 0x0000BC62
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (this._splitPane != null)
			{
				if (index == 0)
				{
					return this._splitPane;
				}
				index--;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000DA82 File Offset: 0x0000BC82
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._splitPane != null)
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(this._splitPane);
				}
				return global::Infragistics.Collections.EmptyEnumerator.Instance;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = default(global::System.Windows.Size);
			if (this._splitPane != null)
			{
				this._splitPane.Measure(availableSize);
				result.Width += this._splitPane.DesiredSize.Width;
				result.Height += this._splitPane.DesiredSize.Height;
			}
			return result;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000DB0C File Offset: 0x0000BD0C
		protected override int VisualChildrenCount
		{
			get
			{
				int num = 0;
				if (this._splitPane != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000DB28 File Offset: 0x0000BD28
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000DB30 File Offset: 0x0000BD30
		internal global::Infragistics.Windows.DockManager.DocumentContentHost Host
		{
			get
			{
				return this._host;
			}
			set
			{
				if (value != this._host)
				{
					if (this._host != null)
					{
						this._host.Panes.CollectionChanged -= this.OnPanesChanged;
					}
					this._host = value;
					this.Reinitialize();
					if (this._host != null)
					{
						this._host.Panes.CollectionChanged += this.OnPanesChanged;
					}
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000DB9C File Offset: 0x0000BD9C
		internal global::Infragistics.Windows.DockManager.SplitPane SplitPane
		{
			get
			{
				if (this._splitPane == null)
				{
					this._splitPane = new global::Infragistics.Windows.DockManager.DocumentContentHostPanel.TabbedDocumentSplitPane(this);
					this._splitPane.SetBinding(global::Infragistics.Windows.DockManager.SplitPane.SplitterOrientationProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.DocumentContentHost.RootSplitterOrientationProperty, global::System.Windows.Data.BindingMode.OneWay, this.Host));
					base.AddVisualChild(this._splitPane);
					base.AddLogicalChild(this._splitPane);
				}
				return this._splitPane;
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000DBFD File Offset: 0x0000BDFD
		private void OnPanesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.Reinitialize();
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000DC08 File Offset: 0x0000BE08
		private void Reinitialize()
		{
			if (this._host != null)
			{
				global::System.Windows.FrameworkElement[] array = new global::System.Windows.FrameworkElement[this._host.Panes.Count];
				global::Infragistics.Windows.DockManager.SplitPane[] array2 = new global::Infragistics.Windows.DockManager.SplitPane[array.Length];
				this._host.Panes.CopyTo(array2, 0);
				global::System.Array.Copy(array2, array, array.Length);
				this.SplitPane.Panes.ReInitialize(array);
				return;
			}
			this.SplitPane.Panes.Clear();
		}

		// Token: 0x04000172 RID: 370
		private global::Infragistics.Windows.DockManager.DocumentContentHost _host;

		// Token: 0x04000173 RID: 371
		private global::Infragistics.Windows.DockManager.SplitPane _splitPane;

		// Token: 0x02000036 RID: 54
		private class TabbedDocumentSplitPane : global::Infragistics.Windows.DockManager.SplitPane, global::Infragistics.Windows.DockManager.IPaneContainer
		{
			// Token: 0x060002EA RID: 746 RVA: 0x0000EEE8 File Offset: 0x0000D0E8
			internal TabbedDocumentSplitPane(global::Infragistics.Windows.DockManager.DocumentContentHostPanel owner)
			{
				this._owner = owner;
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060002EB RID: 747 RVA: 0x0000EEF7 File Offset: 0x0000D0F7
			internal override bool IncludePanesAsLogicalChildren
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060002EC RID: 748 RVA: 0x0000EEFA File Offset: 0x0000D0FA
			global::System.Collections.IList global::Infragistics.Windows.DockManager.IPaneContainer.Panes
			{
				get
				{
					return base.Panes;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060002ED RID: 749 RVA: 0x0000EF02 File Offset: 0x0000D102
			bool global::Infragistics.Windows.DockManager.IPaneContainer.CanBeRemoved
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060002EE RID: 750 RVA: 0x0000EF08 File Offset: 0x0000D108
			bool global::Infragistics.Windows.DockManager.IPaneContainer.RemovePane(object pane)
			{
				global::Infragistics.Windows.DockManager.DocumentContentHost host = this._owner.Host;
				global::Infragistics.Windows.DockManager.SplitPane splitPane = pane as global::Infragistics.Windows.DockManager.SplitPane;
				int num = (splitPane != null) ? host.Panes.IndexOf(splitPane) : -1;
				if (num >= 0)
				{
					host.Panes.RemoveAt(num);
				}
				return num >= 0;
			}

			// Token: 0x04000188 RID: 392
			private global::Infragistics.Windows.DockManager.DocumentContentHostPanel _owner;
		}
	}
}
