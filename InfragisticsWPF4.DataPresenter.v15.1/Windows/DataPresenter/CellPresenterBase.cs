using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000059 RID: 89
	public abstract class CellPresenterBase : global::System.Windows.Controls.Control
	{
		// Token: 0x060004A3 RID: 1187 RVA: 0x00010558 File Offset: 0x0000E758
		static CellPresenterBase()
		{
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CoerceCellClip)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000105CF File Offset: 0x0000E7CF
		public override void OnApplyTemplate()
		{
			this._layoutElement = global::Infragistics.Windows.Utilities.GetTemplateChild<global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase>(this);
			base.OnApplyTemplate();
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004A6 RID: 1190
		// (set) Token: 0x060004A7 RID: 1191
		public abstract global::Infragistics.Windows.DataPresenter.Field Field { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000105E3 File Offset: 0x0000E7E3
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x000105EB File Offset: 0x0000E7EB
		internal global::System.Windows.Rect CellRect
		{
			get
			{
				return this._cellRect;
			}
			set
			{
				this._cellRect = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000105F4 File Offset: 0x0000E7F4
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x000105FC File Offset: 0x0000E7FC
		internal global::System.Windows.Rect LabelRect
		{
			get
			{
				return this._labelRect;
			}
			set
			{
				this._labelRect = value;
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00010605 File Offset: 0x0000E805
		internal void InvalidateLayoutElement()
		{
			if (this._layoutElement != null)
			{
				this._layoutElement.InvalidateMeasure();
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001061A File Offset: 0x0000E81A
		internal global::System.Windows.FrameworkElement GetChild(bool label)
		{
			if (this._layoutElement == null)
			{
				return null;
			}
			if (!label)
			{
				return this._layoutElement.CellValuePresenter;
			}
			return this._layoutElement.LabelPresenter;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00010640 File Offset: 0x0000E840
		internal virtual void SynchronizeChildElements()
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00010642 File Offset: 0x0000E842
		internal void VerifyLayoutElements()
		{
			if (this._layoutElement != null)
			{
				this._layoutElement.VerifyChildElements();
			}
		}

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Rect _labelRect = global::System.Windows.Rect.Empty;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Rect _cellRect = global::System.Windows.Rect.Empty;

		// Token: 0x0400013B RID: 315
		private global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase _layoutElement;
	}
}
