using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000C1 RID: 193
	internal class DragToolWindow : global::Infragistics.Windows.Controls.ToolWindow
	{
		// Token: 0x060008FF RID: 2303 RVA: 0x00025AF8 File Offset: 0x00023CF8
		static DragToolWindow()
		{
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ContentPresenter));
			frameworkElementFactory.Name = "PART_Content";
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.Controls.ToolWindow));
			controlTemplate.VisualTree = frameworkElementFactory;
			controlTemplate.Seal();
			global::Infragistics.Windows.DataPresenter.DragToolWindow.g_indicatorToolWindowTemplate = controlTemplate;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00025B44 File Offset: 0x00023D44
		public DragToolWindow(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			this._dataPresenter = dataPresenter;
			base.ResizeMode = global::System.Windows.ResizeMode.NoResize;
			base.UseOSNonClientArea = false;
			base.Topmost = true;
			base.VerticalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual;
			base.HorizontalAlignmentMode = global::Infragistics.Windows.Controls.ToolWindowAlignmentMode.Manual;
			base.Template = global::Infragistics.Windows.DataPresenter.DragToolWindow.g_indicatorToolWindowTemplate;
			base.Focusable = false;
			base.IsHitTestVisible = false;
			base.Resources.MergedDictionaries.Add(dataPresenter.Resources);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00025BB0 File Offset: 0x00023DB0
		internal override bool KeepOnScreen
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00025BB3 File Offset: 0x00023DB3
		internal void Dispose()
		{
			base.Resources.MergedDictionaries.Clear();
			this._dataPresenter = null;
		}

		// Token: 0x0400037D RID: 893
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x0400037E RID: 894
		private static global::System.Windows.Controls.ControlTemplate g_indicatorToolWindowTemplate;
	}
}
