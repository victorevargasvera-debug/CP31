using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000223 RID: 547
	[global::System.Windows.TemplatePart(Name = "SummaryDisplay", Type = typeof(global::System.Windows.Controls.Panel))]
	public class SummaryRowCellControl : global::Infragistics.Controls.Grids.CellControl
	{
		// Token: 0x06000F6F RID: 3951 RVA: 0x0003ABCE File Offset: 0x00038DCE
		public SummaryRowCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl);
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0003ABE6 File Offset: 0x00038DE6
		// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0003ABF8 File Offset: 0x00038DF8
		public global::System.Windows.DataTemplate SummaryDisplayTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl.SummaryDisplayTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl.SummaryDisplayTemplateProperty, value);
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0003AC08 File Offset: 0x00038E08
		private static void SummaryDisplayTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl summaryRowCellControl = (global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl)obj;
			summaryRowCellControl.OnPropertyChanged("SummaryDisplayTemplate");
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0003AC27 File Offset: 0x00038E27
		public override void OnApplyTemplate()
		{
			this._panel = (base.GetTemplateChild("SummaryDisplay") as global::System.Windows.Controls.Panel);
			if (this._panel != null)
			{
				this.FillPanelWithSummaryResults(this._panel);
			}
			base.OnApplyTemplate();
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0003AC59 File Offset: 0x00038E59
		protected internal override void EnsureContent()
		{
			base.EnsureContent();
			if (this._panel != null)
			{
				this.FillPanelWithSummaryResults(this._panel);
			}
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0003AC75 File Offset: 0x00038E75
		protected override void ReleaseContent()
		{
			if (this._panel != null)
			{
				this._panel.Children.Clear();
			}
			base.ReleaseContent();
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0003AC98 File Offset: 0x00038E98
		protected override object ToolTipContent
		{
			get
			{
				if (this._toolTipPanel == null)
				{
					this._toolTipPanel = new global::System.Windows.Controls.StackPanel();
					this._toolTipPanel.Orientation = global::System.Windows.Controls.Orientation.Vertical;
				}
				this.FillPanelWithSummaryResults(this._toolTipPanel);
				if (this._toolTipPanel.Children.Count > 0)
				{
					return this._toolTipPanel;
				}
				return null;
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0003ACEC File Offset: 0x00038EEC
		protected virtual void FillPanelWithSummaryResults(global::System.Windows.Controls.Panel panel)
		{
			panel.Children.Clear();
			if (base.Cell != null)
			{
				global::Infragistics.SummaryResultCollection summaryResultCollectionInternal = ((global::Infragistics.Controls.Grids.RowsManager)base.Cell.Row.Manager).SummaryResultCollectionInternal;
				foreach (global::Infragistics.SummaryResult summaryResult in summaryResultCollectionInternal)
				{
					if (summaryResult.SummaryDefinition.ColumnKey == base.Cell.Column.Key)
					{
						global::System.Windows.Controls.ContentControl contentControl = new global::System.Windows.Controls.ContentControl();
						contentControl.ContentTemplate = this.SummaryDisplayTemplate;
						contentControl.Content = summaryResult;
						panel.Children.Add(contentControl);
					}
				}
			}
		}

		// Token: 0x040004E1 RID: 1249
		private global::System.Windows.Controls.Panel _panel;

		// Token: 0x040004E2 RID: 1250
		private global::System.Windows.Controls.StackPanel _toolTipPanel;

		// Token: 0x040004E3 RID: 1251
		public static readonly global::System.Windows.DependencyProperty SummaryDisplayTemplateProperty = global::System.Windows.DependencyProperty.Register("SummaryDisplayTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.SummaryRowCellControl.SummaryDisplayTemplateChanged)));
	}
}
