using System;
using System.Diagnostics;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Navigation;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000258 RID: 600
	public class HyperlinkColumnContentProvider : global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase
	{
		// Token: 0x0600133A RID: 4922 RVA: 0x000485B4 File Offset: 0x000467B4
		public HyperlinkColumnContentProvider()
		{
			this._run = new global::System.Windows.Documents.Run();
			this._hyperlink = new global::System.Windows.Documents.Hyperlink(this._run);
			this._hyperlink.RequestNavigate += this.Hyperlink_RequestNavigate;
			this._textBlock = new global::System.Windows.Controls.TextBlock();
			this._textBlock.Inlines.Add(this._hyperlink);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0004861C File Offset: 0x0004681C
		public override global::System.Windows.FrameworkElement ResolveDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.HyperlinkColumn hyperlinkColumn = (global::Infragistics.Controls.Grids.HyperlinkColumn)cell.Column;
			if (cell.Row.RowType == global::Infragistics.Controls.Grids.RowType.FilterRow)
			{
				this._textBlock.IsHitTestVisible = false;
			}
			this._textBlock.Style = hyperlinkColumn.HyperlinkButtonStyle;
			this._hyperlink.TargetName = hyperlinkColumn.TargetName;
			this.ApplyBindingToDisplayElement(cell, cellBinding);
			return this._textBlock;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00048680 File Offset: 0x00046880
		private void ApplyBindingToDisplayElement(global::Infragistics.Controls.Grids.Cell cell, global::System.Windows.Data.Binding cellBinding)
		{
			global::Infragistics.Controls.Grids.HyperlinkColumn hyperlinkColumn = (global::Infragistics.Controls.Grids.HyperlinkColumn)cell.Column;
			if (hyperlinkColumn.Key != null)
			{
				if (cellBinding != null)
				{
					this._hyperlink.SetBinding(global::System.Windows.Documents.Hyperlink.NavigateUriProperty, cellBinding);
				}
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(hyperlinkColumn.Key);
				if (hyperlinkColumn.Content == null)
				{
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					if (hyperlinkColumn.ContentBinding != null)
					{
						this._run.SetBinding(global::System.Windows.Documents.Run.TextProperty, hyperlinkColumn.ContentBinding);
						return;
					}
					this._run.SetBinding(global::System.Windows.Documents.Run.TextProperty, binding);
					return;
				}
				else
				{
					binding = new global::System.Windows.Data.Binding("Content");
					binding.Source = hyperlinkColumn;
					this._run.SetBinding(global::System.Windows.Documents.Run.TextProperty, binding);
				}
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0004872B File Offset: 0x0004692B
		protected override global::System.Windows.FrameworkElement ResolveEditorControl(global::Infragistics.Controls.Grids.Cell cell, object editorValue, double availableWidth, double availableHeight, global::System.Windows.Data.Binding editorBinding)
		{
			return null;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0004872E File Offset: 0x0004692E
		public override object ResolveValueFromEditor(global::Infragistics.Controls.Grids.Cell cell)
		{
			return null;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00048731 File Offset: 0x00046931
		private void Hyperlink_RequestNavigate(object sender, global::System.Windows.Navigation.RequestNavigateEventArgs e)
		{
			this.NavigateToLink(e.Uri.AbsoluteUri);
			e.Handled = true;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0004874B File Offset: 0x0004694B
		[global::System.Security.SecuritySafeCritical]
		private void NavigateToLink(string uri)
		{
			global::System.Diagnostics.Process.Start(new global::System.Diagnostics.ProcessStartInfo(uri));
		}

		// Token: 0x040005EA RID: 1514
		private global::System.Windows.Documents.Hyperlink _hyperlink;

		// Token: 0x040005EB RID: 1515
		private global::System.Windows.Controls.TextBlock _textBlock;

		// Token: 0x040005EC RID: 1516
		private global::System.Windows.Documents.Run _run;
	}
}
