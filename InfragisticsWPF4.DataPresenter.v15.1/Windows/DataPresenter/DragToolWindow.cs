using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000CA RID: 202
	internal class DragToolWindow : global::Infragistics.Windows.Controls.ToolWindow
	{
		// Token: 0x060009AC RID: 2476 RVA: 0x000295E0 File Offset: 0x000277E0
		static DragToolWindow()
		{
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.ContentPresenter));
			frameworkElementFactory.Name = "PART_Content";
			global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.Controls.ToolWindow));
			controlTemplate.VisualTree = frameworkElementFactory;
			controlTemplate.Seal();
			global::Infragistics.Windows.DataPresenter.DragToolWindow.g_indicatorToolWindowTemplate = controlTemplate;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0002962C File Offset: 0x0002782C
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

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00029698 File Offset: 0x00027898
		internal override bool KeepOnScreen
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0002969B File Offset: 0x0002789B
		internal void Dispose()
		{
			base.Resources.MergedDictionaries.Clear();
			this._dataPresenter = null;
		}

		// Token: 0x040003D8 RID: 984
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040003D9 RID: 985
		private static global::System.Windows.Controls.ControlTemplate g_indicatorToolWindowTemplate;

		// Token: 0x040003DA RID: 986
		internal global::Infragistics.Windows.Controls.ToolWindowHostType _toolWindowHostType;
	}
}
