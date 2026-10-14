using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000055 RID: 85
	public abstract class CellPresenterBase : global::System.Windows.Controls.Control
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0000ED24 File Offset: 0x0000CF24
		static CellPresenterBase()
		{
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CoerceCellClip)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CellPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceFieldElementVisibility)));
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000ED9B File Offset: 0x0000CF9B
		public override void OnApplyTemplate()
		{
			this._layoutElement = global::Infragistics.Windows.Utilities.GetTemplateChild<global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase>(this);
			base.OnApplyTemplate();
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000447 RID: 1095
		// (set) Token: 0x06000448 RID: 1096
		public abstract global::Infragistics.Windows.DataPresenter.Field Field { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0000EDAF File Offset: 0x0000CFAF
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000EDB7 File Offset: 0x0000CFB7
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
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

		// Token: 0x0600044D RID: 1101 RVA: 0x0000EDD1 File Offset: 0x0000CFD1
		internal void InvalidateLayoutElement()
		{
			if (this._layoutElement != null)
			{
				this._layoutElement.InvalidateMeasure();
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000EDE6 File Offset: 0x0000CFE6
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

		// Token: 0x0600044F RID: 1103 RVA: 0x0000EE0C File Offset: 0x0000D00C
		internal virtual void SynchronizeChildElements()
		{
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000EE0E File Offset: 0x0000D00E
		internal void VerifyLayoutElements()
		{
			if (this._layoutElement != null)
			{
				this._layoutElement.VerifyChildElements();
			}
		}

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Rect _labelRect = global::System.Windows.Rect.Empty;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Rect _cellRect = global::System.Windows.Rect.Empty;

		// Token: 0x04000110 RID: 272
		private global::Infragistics.Windows.DataPresenter.CellPresenterLayoutElementBase _layoutElement;
	}
}
