using System;
using System.Windows;
using System.Windows.Data;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000256 RID: 598
	public class HyperlinkColumn : global::Infragistics.Controls.Grids.Column
	{
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x000483D8 File Offset: 0x000465D8
		// (set) Token: 0x06001329 RID: 4905 RVA: 0x000483EA File Offset: 0x000465EA
		public string Content
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.HyperlinkColumn.ContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.HyperlinkColumn.ContentProperty, value);
			}
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x000483F8 File Offset: 0x000465F8
		private static void ContentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.HyperlinkColumn hyperlinkColumn = (global::Infragistics.Controls.Grids.HyperlinkColumn)obj;
			hyperlinkColumn.OnPropertyChanged("Content");
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x00048417 File Offset: 0x00046617
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x0004841F File Offset: 0x0004661F
		public global::System.Windows.Data.Binding ContentBinding
		{
			get
			{
				return this._contentBinding;
			}
			set
			{
				if (this._contentBinding != value)
				{
					this._contentBinding = value;
					this.OnPropertyChanged("ContentBinding");
				}
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0004843C File Offset: 0x0004663C
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x0004844E File Offset: 0x0004664E
		public string TargetName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.HyperlinkColumn.TargetNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.HyperlinkColumn.TargetNameProperty, value);
			}
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0004845C File Offset: 0x0004665C
		private static void TargetNameChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.HyperlinkColumn hyperlinkColumn = (global::Infragistics.Controls.Grids.HyperlinkColumn)obj;
			hyperlinkColumn.OnPropertyChanged("TargetName");
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0004847B File Offset: 0x0004667B
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x00048483 File Offset: 0x00046683
		public global::System.Windows.Style HyperlinkButtonStyle
		{
			get
			{
				return this._hyperlinkButtonStyle;
			}
			set
			{
				if (this._hyperlinkButtonStyle != value)
				{
					this._hyperlinkButtonStyle = value;
					this.OnPropertyChanged("HyperlinkButtonStyle");
				}
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x000484A0 File Offset: 0x000466A0
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x000484A8 File Offset: 0x000466A8
		public override global::System.Type DataType
		{
			get
			{
				return base.DataType;
			}
			protected internal set
			{
				base.DataType = value;
				if (base.DataType == typeof(global::System.Uri) && base.SortComparer == null)
				{
					base.SortComparer = new global::Infragistics.Controls.Grids.UriComparer();
				}
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x000484DB File Offset: 0x000466DB
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.Primitives.HyperlinkColumnContentProvider();
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000484E2 File Offset: 0x000466E2
		protected internal override void FillAvailableSummaries(global::Infragistics.SummaryOperandCollection availableSummaries)
		{
			availableSummaries.Add(new global::Infragistics.Controls.Grids.CountSummaryOperand());
		}

		// Token: 0x040005E6 RID: 1510
		private global::System.Windows.Data.Binding _contentBinding;

		// Token: 0x040005E7 RID: 1511
		private global::System.Windows.Style _hyperlinkButtonStyle;

		// Token: 0x040005E8 RID: 1512
		public static readonly global::System.Windows.DependencyProperty ContentProperty = global::System.Windows.DependencyProperty.Register("Content", typeof(string), typeof(global::Infragistics.Controls.Grids.HyperlinkColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.HyperlinkColumn.ContentChanged)));

		// Token: 0x040005E9 RID: 1513
		public static readonly global::System.Windows.DependencyProperty TargetNameProperty = global::System.Windows.DependencyProperty.Register("TargetName", typeof(string), typeof(global::Infragistics.Controls.Grids.HyperlinkColumn), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.HyperlinkColumn.TargetNameChanged)));
	}
}
