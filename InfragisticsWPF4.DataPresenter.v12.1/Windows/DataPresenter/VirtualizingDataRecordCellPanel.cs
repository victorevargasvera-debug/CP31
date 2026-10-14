using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000204 RID: 516
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class VirtualizingDataRecordCellPanel : global::System.Windows.FrameworkElement, global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06001C44 RID: 7236 RVA: 0x000780F0 File Offset: 0x000762F0
		static VirtualizingDataRecordCellPanel()
		{
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnDataContextChanged)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnRequestBringIntoView));
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x000783B4 File Offset: 0x000765B4
		public VirtualizingDataRecordCellPanel()
		{
			base.IsVisibleChanged += delegate(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				if (true.Equals(e.NewValue))
				{
					((global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)sender).InvalidateArrange();
				}
			};
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00078420 File Offset: 0x00076620
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x00078432 File Offset: 0x00076632
		private double AutoFitHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AutoFitHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AutoFitHeightProperty, value);
			}
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00078448 File Offset: 0x00076648
		private static void OnAutoFitWidthHeightChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose((double)e.NewValue, (double)e.OldValue))
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)d;
			if (virtualizingDataRecordCellPanel._fieldLayout != null)
			{
				virtualizingDataRecordCellPanel._lastDPMeasureSize = new global::System.Windows.Size?(virtualizingDataRecordCellPanel._fieldLayout.DataPresenter.LastMeasureSize);
			}
			else
			{
				virtualizingDataRecordCellPanel._lastDPMeasureSize = null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (virtualizingDataRecordCellPanel._fieldLayout != null) ? virtualizingDataRecordCellPanel._fieldLayout.DataPresenter : null;
			if (dataPresenterBase == null || !dataPresenterBase.IsSynchronousControl)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateMeasureAsynch(virtualizingDataRecordCellPanel);
			}
			else
			{
				virtualizingDataRecordCellPanel.InvalidateMeasure();
				virtualizingDataRecordCellPanel.InvalidateArrange();
			}
			virtualizingDataRecordCellPanel.InvalidateLayoutManager();
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000784E9 File Offset: 0x000766E9
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x000784FB File Offset: 0x000766FB
		private double AutoFitWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AutoFitWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AutoFitWidthProperty, value);
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00078510 File Offset: 0x00076710
		internal global::System.Windows.Size LayoutManagerSize
		{
			get
			{
				global::System.Windows.Size renderSize = base.RenderSize;
				bool flag = this._fieldLayout != null && this._fieldLayout.IsHorizontal;
				if (this._nearSplitter != null)
				{
					if (flag)
					{
						renderSize.Height -= this._nearSplitter.DesiredSize.Height;
					}
					else
					{
						renderSize.Width -= this._nearSplitter.DesiredSize.Width;
					}
				}
				if (this._farSplitter != null)
				{
					if (flag)
					{
						renderSize.Height -= this._farSplitter.DesiredSize.Height;
					}
					else
					{
						renderSize.Width -= this._farSplitter.DesiredSize.Width;
					}
				}
				return renderSize;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x000785DC File Offset: 0x000767DC
		private global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer CellPresenterRectContainer
		{
			get
			{
				if (this._cellPresenterRectContainer == null)
				{
					this._cellPresenterRectContainer = new global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer();
				}
				return this._cellPresenterRectContainer;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001C4D RID: 7245 RVA: 0x000785F7 File Offset: 0x000767F7
		internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter FarSplitter
		{
			get
			{
				return this._farSplitter;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000785FF File Offset: 0x000767FF
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00078608 File Offset: 0x00076808
		private static void OnFixedFieldInfoChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)d;
			if (virtualizingDataRecordCellPanel != null)
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo = (global::Infragistics.Windows.DataPresenter.FixedFieldInfo)e.NewValue;
				global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo2 = (global::Infragistics.Windows.DataPresenter.FixedFieldInfo)e.OldValue;
				if (fixedFieldInfo != null)
				{
					virtualizingDataRecordCellPanel.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.OffsetProperty, global::System.Windows.Data.BindingMode.OneWay, fixedFieldInfo));
					virtualizingDataRecordCellPanel.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldExtentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ExtentProperty, global::System.Windows.Data.BindingMode.OneWay, fixedFieldInfo));
					virtualizingDataRecordCellPanel.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldViewportExtentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ViewportExtentProperty, global::System.Windows.Data.BindingMode.OneWay, fixedFieldInfo));
					fixedFieldInfo.AddPanel(virtualizingDataRecordCellPanel);
				}
				else
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(virtualizingDataRecordCellPanel, global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldOffsetProperty);
					global::System.Windows.Data.BindingOperations.ClearBinding(virtualizingDataRecordCellPanel, global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldExtentProperty);
					global::System.Windows.Data.BindingOperations.ClearBinding(virtualizingDataRecordCellPanel, global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldViewportExtentProperty);
				}
				if (fixedFieldInfo2 != null)
				{
					fixedFieldInfo2.RemovePanel(virtualizingDataRecordCellPanel);
				}
				virtualizingDataRecordCellPanel.VerifyFixedFieldOffsets();
			}
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000786C4 File Offset: 0x000768C4
		private static void OnFixedFieldOffsetsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)d;
			virtualizingDataRecordCellPanel.VerifyFixedFieldOffsets();
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x000786E0 File Offset: 0x000768E0
		private bool ForceUseCellLayoutManager
		{
			get
			{
				if (this._fieldLayout != null && !this._isHeader && this._record is global::Infragistics.Windows.DataPresenter.DataRecord && !(this._record is global::Infragistics.Windows.DataPresenter.FilterRecord))
				{
					switch (this._fieldLayout.DataRecordSizingModeResolved)
					{
					case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Fixed:
					case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizableSynchronized:
						return true;
					case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.IndividuallySizable:
						return this._record.GetLayoutManager(false) == null;
					}
				}
				return false;
			}
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00078754 File Offset: 0x00076954
		private static void OnGridColumnWidthVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)d;
			if (virtualizingDataRecordCellPanel._fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = virtualizingDataRecordCellPanel._fieldLayout.DataPresenter;
				if (dataPresenter == null || !dataPresenter.IsSynchronousControl)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateMeasureAsynch(virtualizingDataRecordCellPanel);
				}
				else
				{
					virtualizingDataRecordCellPanel.InvalidateMeasure();
				}
			}
			virtualizingDataRecordCellPanel.InvalidateLayoutManager();
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0007879B File Offset: 0x0007699B
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x000787AD File Offset: 0x000769AD
		internal int GridColumnWidthVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GridColumnWidthVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GridColumnWidthVersionProperty, value);
			}
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x000787C0 File Offset: 0x000769C0
		private static void OnGridMeasureVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = d as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			virtualizingDataRecordCellPanel.OnGridMeasureVersionChanged();
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000787DC File Offset: 0x000769DC
		private void OnGridMeasureVersionChanged()
		{
			if (this._lastDPMeasureSize != null && this._fieldLayout != null && this._fieldLayout.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
				if (dataPresenter != null && !dataPresenter.CurrentViewInternal.AutoFitToRecord)
				{
					bool flag = false;
					if (!double.IsNaN(this.AutoFitWidth) && !global::Infragistics.CoreUtilities.AreClose(this._lastDPMeasureSize.Value.Width, dataPresenter.LastMeasureSize.Width))
					{
						flag = true;
					}
					else if (!double.IsNaN(this.AutoFitHeight) && !global::Infragistics.CoreUtilities.AreClose(this._lastDPMeasureSize.Value.Height, dataPresenter.LastMeasureSize.Height))
					{
						flag = true;
					}
					if (flag)
					{
						global::Infragistics.Windows.Utilities.InvalidateMeasure(this, dataPresenter.CurrentPanel);
						base.InvalidateMeasure();
					}
				}
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x000788BF File Offset: 0x00076ABF
		private bool IsFieldLayoutDisposed
		{
			get
			{
				return this._fieldLayout != null && this._fieldLayout.WasRemovedFromCollection;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000788D6 File Offset: 0x00076AD6
		internal bool IsHeaderArea
		{
			get
			{
				return this._isHeader;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x000788E0 File Offset: 0x00076AE0
		private bool? IsMouseOverCellArea
		{
			get
			{
				if (this._containingCellArea != null && !this._isHeader && this._record is global::Infragistics.Windows.DataPresenter.DataRecord)
				{
					return new bool?(this._containingCellArea.IsMouseOver);
				}
				return null;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x00078924 File Offset: 0x00076B24
		private bool IsNestedFixedHeader
		{
			get
			{
				return this._isHeader && this._containingRp != null && this._containingRp.Record != null && this._containingRp.Record.ParentRecord != null;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0007895B File Offset: 0x00076B5B
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x0007896D File Offset: 0x00076B6D
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager LastLayoutManager
		{
			get
			{
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._lastLayoutManager) as global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager;
			}
			private set
			{
				if (this.LastLayoutManager != value)
				{
					this._lastLayoutManager = new global::System.WeakReference(value);
				}
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x00078984 File Offset: 0x00076B84
		internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter NearSplitter
		{
			get
			{
				return this._nearSplitter;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0007898C File Offset: 0x00076B8C
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> NonVirtualizedFields
		{
			get
			{
				this.VerifyFieldLists();
				return this._nonVirtualizedFields;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0007899A File Offset: 0x00076B9A
		internal global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x000789A2 File Offset: 0x00076BA2
		internal global::System.Windows.Rect ScrollableAreaRect
		{
			get
			{
				return this._scrollableClipRect;
			}
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000789AC File Offset: 0x00076BAC
		private static void OnScrollVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)d;
			if (virtualizingDataRecordCellPanel.IsFieldLayoutDisposed)
			{
				return;
			}
			if (!virtualizingDataRecordCellPanel._cellElementsDirty)
			{
				if (!virtualizingDataRecordCellPanel._usingFixedInfo)
				{
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> virtualizedFields = virtualizingDataRecordCellPanel.VirtualizedFields;
					if (virtualizedFields == null || virtualizedFields.Count == 0)
					{
						return;
					}
				}
				if (virtualizingDataRecordCellPanel._isHeader || (virtualizingDataRecordCellPanel._record != null && !virtualizingDataRecordCellPanel._record.HasCollapsedAncestor))
				{
					virtualizingDataRecordCellPanel.WireLayouUpdatedEvent();
				}
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00078A0F File Offset: 0x00076C0F
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x00078A21 File Offset: 0x00076C21
		internal int ScrollVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ScrollVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ScrollVersionProperty, value);
			}
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00078A34 File Offset: 0x00076C34
		private static void OnTemplateVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = d as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (virtualizingDataRecordCellPanel._fieldLayout != null) ? virtualizingDataRecordCellPanel._fieldLayout.DataPresenter : null;
			if (dataPresenterBase == null || !dataPresenterBase.IsSynchronousControl)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateMeasureAsynch(virtualizingDataRecordCellPanel);
				return;
			}
			virtualizingDataRecordCellPanel.InvalidateMeasure();
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00078A77 File Offset: 0x00076C77
		// (set) Token: 0x06001C66 RID: 7270 RVA: 0x00078A89 File Offset: 0x00076C89
		internal int TemplateVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.TemplateVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.TemplateVersionProperty, value);
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x00078A9C File Offset: 0x00076C9C
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> VirtualizedFields
		{
			get
			{
				this.VerifyFieldLists();
				return this._virtualizedFields;
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00078AAC File Offset: 0x00076CAC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this.IsFieldLayoutDisposed)
			{
				return finalSize;
			}
			if (this._fieldLayout != null)
			{
				this.VerifyPropertyDescriptorProvider();
				if (this._cellElementsDirty)
				{
					this.VerifyCellElements();
				}
				global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = this.GetLayoutManager();
				this.LastLayoutManager = layoutManager;
				bool isHorizontal = this._fieldLayout.IsHorizontal;
				global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo = this._fieldLayout.GetFixedFieldInfo(false);
				bool flag = this._fieldLayout != null && this._fieldLayout.UseCellPresenters;
				global::System.Windows.Size size = finalSize;
				global::System.Windows.Size size2 = (this._nearSplitter != null) ? this._nearSplitter.DesiredSize : default(global::System.Windows.Size);
				global::System.Windows.Size size3 = (this._farSplitter != null) ? this._farSplitter.DesiredSize : default(global::System.Windows.Size);
				double num;
				if (isHorizontal)
				{
					num = size2.Height + size3.Height;
					size.Height -= num;
				}
				else
				{
					num = size2.Width + size3.Width;
					size.Width -= num;
				}
				object obj = new global::System.Windows.Rect(size);
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> nonVirtualizedFields = this.NonVirtualizedFields;
				if (!isHorizontal && nonVirtualizedFields != null && nonVirtualizedFields.Count > 0)
				{
					global::System.Windows.Size autoFitSize = this.GetAutoFitSize();
					global::System.Windows.Size templateGridSize = this._fieldLayout.TemplateDataRecordCache.TemplateGridSize;
					this.InitializeCachedDimensions(ref finalSize, num, ref autoFitSize, ref templateGridSize);
				}
				layoutManager.InitializePanelReference(this);
				if (flag)
				{
					this.CellPresenterRectContainer.Reset(this._fixedNearOffset + this._fixedNearAdjustment, this._nearSplitterOffset, this._fixedFarOffset + this._farSplitterOffset + this._fixedFarAdjustment);
					layoutManager.CalculateCellPresenterRects(this.CellPresenterRectContainer, size, this._cellElementRects);
				}
				else if (this._lastLayoutContainerCount != layoutManager.InvalidateLayoutCount || this._lastLayoutContainerRect != (global::System.Windows.Rect)obj)
				{
					this._lastLayoutContainerCount = layoutManager.InvalidateLayoutCount;
					this._lastLayoutContainerRect = new global::System.Windows.Rect?((global::System.Windows.Rect)obj);
					global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensionsCached = layoutManager.GetLayoutItemDimensionsCached(this, obj);
					foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)layoutManager.LayoutItems))
					{
						global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions gridBagLayoutItemDimensions = layoutItemDimensionsCached[layoutItem];
						if (gridBagLayoutItemDimensions != null)
						{
							((global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer)this).PositionItem(layoutItem, gridBagLayoutItemDimensions.Bounds, null);
						}
					}
				}
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensionsCached2 = layoutManager.GetLayoutItemDimensionsCached(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, obj);
				layoutManager.InitializePanelReference(null);
				this._cachedDimensions = null;
				global::System.Windows.Vector fixedNearAdjustment = this._fixedNearAdjustment;
				global::System.Windows.Vector fixedFarAdjustment = this._fixedFarAdjustment;
				double num2 = 0.0;
				double num3 = 0.0;
				this._fixedNearAdjustment = default(global::System.Windows.Vector);
				this._fixedFarAdjustment = default(global::System.Windows.Vector);
				if (this._usingFixedInfo)
				{
					double num5;
					int num4 = this.CalculateFixedExtents(isHorizontal, fixedFieldInfo, ref size2, ref size3, layoutItemDimensionsCached2, out num2, out num3, out num5);
					global::System.Windows.Rect scrollableClipRect = default(global::System.Windows.Rect);
					double num6 = (double)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldOffsetProperty);
					double num7 = this.CalculateScrollableExtent(ref finalSize, isHorizontal, num2, num3, num6);
					double num8 = this._prePostPanelSpacing + num2 + num3 - (double)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldViewportExtentProperty);
					if (num8 > 0.0)
					{
						num7 += num8;
						if (isHorizontal)
						{
							this._fixedFarAdjustment.Y = num8;
						}
						else
						{
							this._fixedFarAdjustment.X = num8;
						}
					}
					if (isHorizontal)
					{
						scrollableClipRect.Width = finalSize.Width;
						scrollableClipRect.Y = num2 + num6;
						scrollableClipRect.Height = global::System.Math.Max(num7, 0.0);
						this._fixedNearAdjustment.Y = global::System.Math.Min(0.0, num7);
					}
					else
					{
						scrollableClipRect.Height = finalSize.Height;
						scrollableClipRect.X = num2 + num6;
						scrollableClipRect.Width = global::System.Math.Max(num7, 0.0);
						this._fixedNearAdjustment.X = global::System.Math.Min(0.0, num7);
					}
					this._scrollableClipRect = scrollableClipRect;
					this._fixedNearRect = new global::System.Windows.Rect(isHorizontal ? 0.0 : num6, (!isHorizontal) ? 0.0 : num6, isHorizontal ? finalSize.Width : num2, isHorizontal ? num2 : finalSize.Height);
					this._fixedFarRect = new global::System.Windows.Rect(isHorizontal ? 0.0 : this._scrollableClipRect.Right, (!isHorizontal) ? 0.0 : this._scrollableClipRect.Bottom, isHorizontal ? finalSize.Width : num3, isHorizontal ? num3 : finalSize.Height);
					this._fixedNearRect.Offset(this._fixedNearAdjustment);
					this._fixedFarRect.Offset(this._fixedFarAdjustment);
					if (this._nearSplitter != null)
					{
						global::System.Windows.Rect finalRect = new global::System.Windows.Rect(this._nearSplitter.DesiredSize);
						int num9 = num4 * (fixedFieldInfo.NearFixedOrigin + fixedFieldInfo.NearFixedSpan);
						if (isHorizontal)
						{
							finalRect.Width = finalSize.Width;
							if (num9 < layoutItemDimensionsCached2.RowDims.Length)
							{
								finalRect.Y = layoutItemDimensionsCached2.RowDims[num9];
							}
						}
						else
						{
							finalRect.Height = finalSize.Height;
							if (num9 < layoutItemDimensionsCached2.ColumnDims.Length)
							{
								finalRect.X = layoutItemDimensionsCached2.ColumnDims[num9];
							}
						}
						finalRect.Offset(this._fixedNearOffset + this._fixedNearAdjustment);
						this._nearSplitter.Arrange(finalRect);
					}
					if (this._farSplitter != null)
					{
						global::System.Windows.Rect finalRect2 = new global::System.Windows.Rect(this._farSplitter.DesiredSize);
						int num10 = num4 * fixedFieldInfo.FarFixedOrigin;
						if (isHorizontal)
						{
							finalRect2.Width = finalSize.Width;
							if (num10 < layoutItemDimensionsCached2.RowDims.Length)
							{
								finalRect2.Y = layoutItemDimensionsCached2.RowDims[num10];
							}
						}
						else
						{
							finalRect2.Height = finalSize.Height;
							if (num10 < layoutItemDimensionsCached2.ColumnDims.Length)
							{
								finalRect2.X = layoutItemDimensionsCached2.ColumnDims[num10];
							}
						}
						finalRect2.Offset(this._fixedFarOffset + this._fixedFarAdjustment);
						finalRect2.Offset(this._nearSplitterOffset);
						this._farSplitter.Arrange(finalRect2);
					}
				}
				if (this._containingCellArea != null && this._usingFixedInfo)
				{
					this._containingCellArea.RenderOffset = this._fixedNearAdjustment;
					this._containingCellArea.MinCellPanelExtent = num2 + num3;
				}
				global::System.Windows.Vector delta = this._fixedFarAdjustment - fixedFarAdjustment;
				global::System.Windows.Vector delta2 = this._fixedNearAdjustment - fixedNearAdjustment;
				this.AdjustCellRects(fixedFieldInfo.NearFixedFields, delta2);
				this.AdjustCellRects(fixedFieldInfo.FarFixedFields, delta);
				if (nonVirtualizedFields != null)
				{
					int i = 0;
					int count = nonVirtualizedFields.Count;
					while (i < count)
					{
						int templateCellIndex = nonVirtualizedFields[i].TemplateCellIndex;
						global::System.Windows.FrameworkElement frameworkElement = this._cellElements[templateCellIndex];
						if (frameworkElement != null)
						{
							if (frameworkElement is global::Infragistics.Windows.DataPresenter.CellPresenterBase)
							{
								this.InitializeCellPresenterRects(frameworkElement);
							}
							global::System.Windows.Rect rect = this._cellElementRects[templateCellIndex];
							global::System.Windows.Size? size4 = this._cellElementMeasureSizes[templateCellIndex];
							if (size4 == null)
							{
								size4 = new global::System.Windows.Size?(rect.Size);
								this._cellElementMeasureSizes[templateCellIndex] = size4;
							}
							this.ArrangeHelper(frameworkElement, rect, size4.Value, templateCellIndex);
						}
						i++;
					}
				}
				this.VerifyCellsInView(finalSize);
				global::System.Windows.Size size5 = layoutManager.CalculateMinimumSize();
				if (isHorizontal)
				{
					size5.Height += size2.Height + size3.Height;
				}
				else
				{
					size5.Width += size2.Width + size3.Width;
				}
				global::System.Windows.Size result = finalSize;
				if (result.Width < size5.Width)
				{
					result.Width = size5.Width;
				}
				if (result.Height < size5.Height)
				{
					result.Height = size5.Height;
				}
				this.VerifyAutoSizeFields();
				return result;
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x000792AC File Offset: 0x000774AC
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index < this.children.Count)
			{
				return this.children[index];
			}
			index -= this.children.Count;
			if (this._nearSplitter != null)
			{
				if (index == 0)
				{
					return this._nearSplitter;
				}
				index--;
			}
			if (this._farSplitter != null && index == 0)
			{
				return this._farSplitter;
			}
			throw new global::System.ArgumentOutOfRangeException();
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00079314 File Offset: 0x00077514
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this.IsFieldLayoutDisposed)
			{
				return base.DesiredSize;
			}
			this._lastMeasureSize = availableSize;
			if (this._fieldLayout == null)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			this.VerifyPropertyDescriptorProvider();
			this._fieldLayout.AutoSizeInfo.Verify();
			this.VerifyFieldLists();
			this.RefreshReportLayoutInfo();
			if (this._cellElementsDirty)
			{
				this.VerifyCellElements();
			}
			if (!this._isAutoFitInitialized)
			{
				this.InitializeAutoFitBindings();
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = this.GetLayoutManager();
			if (layoutManager == null)
			{
				return new global::System.Windows.Size(1.0, 1.0);
			}
			this.VerifyFixedState();
			double num = 0.0;
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			this._nearSplitterOffset = default(global::System.Windows.Vector);
			this._farSplitterOffset = default(global::System.Windows.Vector);
			if (this._nearSplitter != null)
			{
				this._nearSplitter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				global::System.Windows.Size desiredSize = this._nearSplitter.DesiredSize;
				num += (isHorizontal ? desiredSize.Height : desiredSize.Width);
				if (isHorizontal)
				{
					this._nearSplitterOffset.Y = num;
				}
				else
				{
					this._nearSplitterOffset.X = num;
				}
			}
			if (this._farSplitter != null)
			{
				this._farSplitter.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
				global::System.Windows.Size desiredSize2 = this._farSplitter.DesiredSize;
				num += (isHorizontal ? desiredSize2.Height : desiredSize2.Width);
				if (isHorizontal)
				{
					this._farSplitterOffset.Y = num;
				}
				else
				{
					this._farSplitterOffset.X = num;
				}
			}
			global::System.Windows.Size autoFitSize = this.GetAutoFitSize();
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
			global::System.Windows.Size templateGridSize = templateDataRecordCache.TemplateGridSize;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> nonVirtualizedFields = this.NonVirtualizedFields;
			if (!isHorizontal && nonVirtualizedFields != null && nonVirtualizedFields.Count > 0)
			{
				this.InitializeCachedDimensions(ref availableSize, num, ref autoFitSize, ref templateGridSize);
			}
			layoutManager.InitializePanelReference(this);
			global::System.Windows.Size result = layoutManager.CalculatePreferredSize();
			global::System.Windows.Size minSize = layoutManager.CalculateMinimumSize();
			global::System.Windows.Size maxSize = layoutManager.CalculateMaximumSize();
			layoutManager.InitializePanelReference(null);
			this._cachedDimensions = null;
			if (this.ForceUseCellLayoutManager && (!this._fieldLayout.IsEmptyCellCollapsingSupportedByView || !this._record.ShouldCollapseEmptyCellsResolved))
			{
				global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager cellLayoutManager = this._fieldLayout.CellLayoutManager;
				result = cellLayoutManager.CalculatePreferredSize();
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AdjustForSplitter(num, isHorizontal, ref result, ref minSize, ref maxSize);
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.EnforceMinMax(ref availableSize, ref autoFitSize, ref templateGridSize, ref result, minSize, maxSize, this._fieldLayout);
			if (this._reportLayoutInfo != null)
			{
				if (isHorizontal)
				{
					result.Height = global::System.Math.Max(result.Height, this._reportLayoutInfo.OverallExtent);
				}
				else
				{
					result.Width = global::System.Math.Max(result.Width, this._reportLayoutInfo.OverallExtent);
				}
			}
			return result;
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x000795DC File Offset: 0x000777DC
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._nearSplitter == null && this._farSplitter == null)
				{
					return this.children.GetEnumerator();
				}
				return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
				{
					this.children.GetEnumerator(),
					new global::Infragistics.Collections.SingleItemEnumerator(this._nearSplitter),
					new global::Infragistics.Collections.SingleItemEnumerator(this._farSplitter)
				});
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00079648 File Offset: 0x00077848
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._isVerifyingCells)
			{
				return;
			}
			if (!(child is global::Infragistics.Windows.DataPresenter.FixedFieldSplitter))
			{
				bool flag = false;
				if (this._record != null && this._record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord)
				{
					global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(child);
					if (!this.IsPerformingAutoSizeMeasure && fieldFromControl != null && fieldFromControl.Owner != null)
					{
						fieldFromControl.Owner.AutoSizeInfo.OnFieldElementDesiredSizeChanged(this._record, fieldFromControl);
					}
					if (fieldFromControl != null && fieldFromControl.IsCellVirtualized)
					{
						flag = true;
						if ((this._recordLayoutManager != null || this._record.GetLayoutManager(false) != null) && this._record.ShouldCollapseEmptyCellsResolved)
						{
							flag = false;
						}
					}
				}
				else if (this._isHeader || (this._record != null && this._record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.HeaderRecord))
				{
					global::Infragistics.Windows.DataPresenter.Field fieldFromControl2 = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(child);
					if (fieldFromControl2 != null && fieldFromControl2.IsLabelVirtualized)
					{
						flag = true;
					}
				}
				if (flag)
				{
					return;
				}
			}
			this.InvalidateLayoutManager();
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x00079728 File Offset: 0x00077928
		protected override int VisualChildrenCount
		{
			get
			{
				int num = this.children.Count;
				if (this._nearSplitter != null)
				{
					num++;
				}
				if (this._farSplitter != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0007975A File Offset: 0x0007795A
		private void AddChild(global::System.Windows.FrameworkElement child)
		{
			base.AddLogicalChild(child);
			this.children.Add(child);
			base.AddVisualChild(child);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00079778 File Offset: 0x00077978
		internal void AdjustCellRect(global::Infragistics.Windows.DataPresenter.FixedFieldLocation location, ref global::System.Windows.Rect rect)
		{
			if (this._usingFixedInfo)
			{
				global::System.Windows.Vector fixedAreaOffset = this.GetFixedAreaOffset(location, true);
				rect.Offset(fixedAreaOffset);
			}
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000797A0 File Offset: 0x000779A0
		private void AdjustCellRects(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> fields, global::System.Windows.Vector delta)
		{
			if (delta.X != 0.0 || delta.Y != 0.0)
			{
				int i = 0;
				int count = fields.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fields[i];
					int templateCellIndex = field.TemplateCellIndex;
					if (templateCellIndex >= 0 && templateCellIndex < this._cellElementRects.Length)
					{
						this._cellElementRects[templateCellIndex].Offset(delta);
					}
					i++;
				}
			}
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00079814 File Offset: 0x00077A14
		internal void AdjustDragPoint(ref global::System.Windows.Point pt)
		{
			if (this._usingFixedInfo)
			{
				bool isHorizontal = this._fieldLayout.IsHorizontal;
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.Contains(this._fixedNearRect, pt, !isHorizontal))
				{
					pt.Offset(-this._fixedNearOffset.X + this._fixedNearAdjustment.X, -this._fixedNearOffset.Y + this._fixedNearAdjustment.Y);
					return;
				}
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.Contains(this._fixedFarRect, pt, !isHorizontal))
				{
					pt.Offset(-this._fixedFarOffset.X + this._fixedFarAdjustment.X, -this._fixedFarOffset.Y + this._fixedFarAdjustment.Y);
				}
			}
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x000798D4 File Offset: 0x00077AD4
		private static void AdjustForSplitter(double splitterExtent, bool isHorizontal, ref global::System.Windows.Size size, ref global::System.Windows.Size minSize, ref global::System.Windows.Size maxSize)
		{
			if (isHorizontal)
			{
				size.Height += splitterExtent;
				minSize.Height += splitterExtent;
				maxSize.Height += splitterExtent;
				return;
			}
			size.Width += splitterExtent;
			minSize.Width += splitterExtent;
			maxSize.Width += splitterExtent;
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0007993C File Offset: 0x00077B3C
		internal static void ApplyTemplateRecursively(global::System.Windows.DependencyObject dependencyObject)
		{
			global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.ApplyTemplate();
			}
			int i = 0;
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(dependencyObject);
			while (i < childrenCount)
			{
				global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, i);
				if (child != null)
				{
					global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ApplyTemplateRecursively(child);
				}
				i++;
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00079980 File Offset: 0x00077B80
		private void ArrangeHelper(global::System.Windows.FrameworkElement child, global::System.Windows.Rect rect, global::System.Windows.Size lastMeasureSize, int cellIndex)
		{
			bool isVerifyingCells = this._isVerifyingCells;
			this._isVerifyingCells = true;
			try
			{
				if (this._reportLayoutInfo != null)
				{
					global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(child);
					bool isHorizontal = this._fieldLayout.IsHorizontal;
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = fieldFromControl.GridPosition;
					int num = isHorizontal ? gridPosition.Row : gridPosition.Column;
					int span = isHorizontal ? gridPosition.RowSpan : gridPosition.ColumnSpan;
					double offset = this._reportLayoutInfo.GetOffset(fieldFromControl, num);
					double extent = this._reportLayoutInfo.GetExtent(fieldFromControl, num, span);
					if (isHorizontal)
					{
						rect.Y = offset;
						rect.Height = extent;
					}
					else
					{
						rect.X = offset;
						rect.Width = extent;
					}
				}
				if (this._usingFixedInfo)
				{
					child.CoerceValue(global::System.Windows.UIElement.ClipProperty);
				}
				global::System.Windows.Size size = rect.Size;
				global::System.Windows.Size desiredSize = child.DesiredSize;
				if (desiredSize.Height <= size.Height && lastMeasureSize.Height > size.Height)
				{
					size.Height = lastMeasureSize.Height;
				}
				if (desiredSize.Width <= size.Width && lastMeasureSize.Width > size.Width)
				{
					size.Width = lastMeasureSize.Width;
				}
				this._cellElementMeasureSizes[cellIndex] = new global::System.Windows.Size?(size);
				child.Measure(size);
				child.Arrange(rect);
			}
			finally
			{
				this._isVerifyingCells = isVerifyingCells;
			}
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00079B00 File Offset: 0x00077D00
		private int CalculateFixedExtents(bool isHorizontal, global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo, ref global::System.Windows.Size nearSplitSize, ref global::System.Windows.Size farSplitSize, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection dims, out double nearFixedExtent, out double farFixedExtent, out double scrollableExtent)
		{
			int num = fixedFieldInfo.FieldLayout.UseCellPresenters ? 2 : 1;
			double[] array = isHorizontal ? dims.RowDims : dims.ColumnDims;
			int num2 = num * (fixedFieldInfo.NearFixedOrigin + fixedFieldInfo.NearFixedSpan);
			int num3 = num * (fixedFieldInfo.FarFixedOrigin + fixedFieldInfo.FarFixedSpan);
			int num4 = num * fixedFieldInfo.FarFixedOrigin;
			nearFixedExtent = ((num2 < array.Length) ? array[num2] : 0.0);
			farFixedExtent = ((num3 < array.Length) ? (array[num3] - array[num4]) : 0.0);
			int num5 = num4;
			scrollableExtent = ((num3 < array.Length) ? (array[num5] - array[num2]) : 0.0);
			nearFixedExtent += (isHorizontal ? nearSplitSize.Height : nearSplitSize.Width);
			farFixedExtent += (isHorizontal ? farSplitSize.Height : farSplitSize.Width);
			return num;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00079BE4 File Offset: 0x00077DE4
		internal static double CalculateFixedRecordAreaEdge(bool isHorizontal, double cellAreaExtent, global::Infragistics.Windows.DataPresenter.RecordPresenter rp, global::Infragistics.Windows.DataPresenter.Record record, global::System.Windows.FrameworkElement referenceElement, bool isHeader)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = rp.FieldLayout;
			double num = cellAreaExtent;
			if (fieldLayout == null)
			{
				return 0.0;
			}
			global::Infragistics.Windows.DataPresenter.Record record2 = (rp != null) ? rp.GetRecordForMeasure() : null;
			global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = record2 as global::Infragistics.Windows.DataPresenter.HeaderRecord;
			if (headerRecord != null)
			{
				record2 = headerRecord.RecordForLayoutCalculations;
			}
			if (record2 != null)
			{
				num += record2.CalculateNestedRecordContentNearOffset() + record2.FarOffset;
			}
			global::System.Windows.Thickness? thickness = null;
			global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter summaryRecordPresenter = rp as global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter;
			if (summaryRecordPresenter != null)
			{
				thickness = new global::System.Windows.Thickness?(summaryRecordPresenter.ContentAreaMargins);
			}
			else if (referenceElement != null && record is global::Infragistics.Windows.DataPresenter.SummaryRecord && rp is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter)
			{
				global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter groupBySummariesPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(referenceElement, typeof(global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter), true, rp) as global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter;
				if (groupBySummariesPresenter != null)
				{
					thickness = new global::System.Windows.Thickness?(groupBySummariesPresenter.ContentAreaMargins);
				}
			}
			if (thickness != null)
			{
				if (!isHorizontal)
				{
					num += thickness.Value.Left + thickness.Value.Right;
				}
				else
				{
					num += thickness.Value.Top + thickness.Value.Bottom;
				}
			}
			bool flag = false;
			bool flag2 = true;
			if (record is global::Infragistics.Windows.DataPresenter.SummaryRecord && !(rp is global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter))
			{
				flag2 = false;
			}
			else if (isHeader && record2 != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
				if (fieldLayout.HasGroupBySortFields && !(record2.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord))
				{
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = record2.RecordManager;
					if (recordManager != null && recordManager.Sorted.Count > 0)
					{
						flag = (recordManager.Sorted[0].ExpansionIndicatorVisibility == global::System.Windows.Visibility.Collapsed);
					}
				}
			}
			if (flag)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager2 = rp.Record.RecordManager;
				if (!isHorizontal)
				{
					num -= fieldLayout.ExpansionIndicatorSize.Width;
				}
				else
				{
					num -= fieldLayout.ExpansionIndicatorSize.Height;
				}
			}
			if (fieldLayout != null && flag2)
			{
				switch (fieldLayout.RecordSelectorLocationResolved)
				{
				case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea:
				case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.BelowCellArea:
					if (isHorizontal)
					{
						num += fieldLayout.RecordSelectorExtentResolved;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea:
				case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.RightOfCellArea:
					if (!isHorizontal)
					{
						num += fieldLayout.RecordSelectorExtentResolved;
					}
					break;
				}
			}
			return num;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00079DE0 File Offset: 0x00077FE0
		private double CalculateScrollableExtent(ref global::System.Windows.Size finalSize, bool isHorizontal, double nearFixedExtent, double farFixedExtent, double offset)
		{
			double num;
			if (isHorizontal)
			{
				num = finalSize.Height + this._fixedFarOffset.Y - offset - farFixedExtent - nearFixedExtent;
			}
			else
			{
				num = finalSize.Width + this._fixedFarOffset.X - offset - farFixedExtent - nearFixedExtent;
			}
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(0.0, num))
			{
				num = 0.0;
			}
			return num;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00079E44 File Offset: 0x00078044
		internal double CalculateSplitterLayout(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> affectedFields, global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType splitterType, out bool willHaveScrollableFields)
		{
			willHaveScrollableFields = false;
			if (this._fieldLayout == null)
			{
				return 0.0;
			}
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			double result = isHorizontal ? this._scrollableClipRect.Height : this._scrollableClipRect.Width;
			if (affectedFields == null || affectedFields.Count == 0)
			{
				return result;
			}
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation oldLocation;
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation;
			this.GetSplitterLocations(affectedFields, splitterType, out oldLocation, out fixedFieldLocation);
			for (int i = affectedFields.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.Field field = affectedFields[i];
				if (!field.IsFixedLocationAllowed(fixedFieldLocation))
				{
					affectedFields.RemoveAt(i);
				}
			}
			if (affectedFields.Count == 0)
			{
				return result;
			}
			global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = this._fieldLayout.GetFieldLayoutInfo(false, false);
			if (layoutInfo != null)
			{
				layoutInfo = layoutInfo.Clone(true);
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = this.GetLayoutManager();
			if (layoutInfo == null)
			{
				layoutInfo = layoutManager.CreateLayoutInfo(true);
			}
			layoutInfo.UpdateFixedLocation(oldLocation, fixedFieldLocation, affectedFields);
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = layoutManager.Clone(layoutInfo);
			fieldGridBagLayoutManager.VerifyLayout();
			global::System.Windows.Size size = fieldGridBagLayoutManager.CalculatePreferredSize();
			global::System.Windows.Size minSize = fieldGridBagLayoutManager.CalculateMinimumSize();
			global::System.Windows.Size maxSize = fieldGridBagLayoutManager.CalculateMaximumSize();
			global::System.Windows.Size size2 = (this._nearSplitter != null) ? this._nearSplitter.DesiredSize : default(global::System.Windows.Size);
			global::System.Windows.Size size3 = (this._farSplitter != null) ? this._farSplitter.DesiredSize : default(global::System.Windows.Size);
			double num;
			if (isHorizontal)
			{
				num = size2.Height + size3.Height;
			}
			else
			{
				num = size2.Width + size3.Width;
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AdjustForSplitter(num, isHorizontal, ref size, ref minSize, ref maxSize);
			global::System.Windows.Size lastMeasureSize = this._lastMeasureSize;
			global::System.Windows.Size autoFitSize = this.GetAutoFitSize();
			global::System.Windows.Size templateGridSize = this._fieldLayout.TemplateDataRecordCache.TemplateGridSize;
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.EnforceMinMax(ref lastMeasureSize, ref autoFitSize, ref templateGridSize, ref size, minSize, maxSize, this._fieldLayout);
			global::System.Windows.Size size4 = size;
			if (isHorizontal)
			{
				size4.Height = global::System.Math.Max(size.Height - num, 0.0);
			}
			else
			{
				size4.Width = global::System.Math.Max(size.Width - num, 0.0);
			}
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensionsCached = fieldGridBagLayoutManager.GetLayoutItemDimensionsCached(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, new global::System.Windows.Rect(size4));
			global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo = new global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo(this._fieldLayout, layoutInfo);
			double nearFixedExtent;
			double farFixedExtent;
			double num2;
			this.CalculateFixedExtents(isHorizontal, fixedFieldInfo, ref size2, ref size3, layoutItemDimensionsCached, out nearFixedExtent, out farFixedExtent, out num2);
			double offset = (double)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldOffsetProperty);
			global::System.Windows.Size size5 = new global::System.Windows.Size(base.ActualWidth, base.ActualHeight);
			double num3 = this.CalculateScrollableExtent(ref size5, isHorizontal, nearFixedExtent, farFixedExtent, offset);
			willHaveScrollableFields = (num2 > num3 && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(num2, num3));
			return num3;
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0007A0DC File Offset: 0x000782DC
		internal static object CoerceCellClip(global::System.Windows.DependencyObject d, object newValue)
		{
			global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)d;
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(frameworkElement) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			bool flag = virtualizingDataRecordCellPanel != null && virtualizingDataRecordCellPanel._usingFixedInfo;
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager;
			if (flag)
			{
				if ((fieldGridBagLayoutManager = virtualizingDataRecordCellPanel._recordLayoutManager) == null)
				{
					fieldGridBagLayoutManager = (virtualizingDataRecordCellPanel.LastLayoutManager ?? virtualizingDataRecordCellPanel.GetLayoutManager());
				}
			}
			else
			{
				fieldGridBagLayoutManager = null;
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager2 = fieldGridBagLayoutManager;
			if (fieldGridBagLayoutManager2 != null)
			{
				global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(frameworkElement);
				global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = fieldGridBagLayoutManager2.GetLayoutItem(fieldFromControl, frameworkElement is global::Infragistics.Windows.DataPresenter.LabelPresenter);
				if (layoutItem != null && layoutItem.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
				{
					int templateCellIndex = fieldFromControl.TemplateCellIndex;
					global::System.Windows.Rect rect = (templateCellIndex >= 0 && templateCellIndex < virtualizingDataRecordCellPanel._cellElementRects.Length) ? virtualizingDataRecordCellPanel._cellElementRects[templateCellIndex] : global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(frameworkElement);
					if (rect.Width > 0.0 && rect.Height > 0.0)
					{
						global::System.Windows.Rect scrollableClipRect = virtualizingDataRecordCellPanel._scrollableClipRect;
						global::System.Windows.Rect rect2 = global::System.Windows.Rect.Intersect(scrollableClipRect, rect);
						bool flag2 = virtualizingDataRecordCellPanel._isHeader || virtualizingDataRecordCellPanel._record is global::Infragistics.Windows.DataPresenter.HeaderRecord;
						if (!flag2 && (rect2.Width <= 0.0 || rect2.Height <= 0.0))
						{
							return global::System.Windows.Media.Geometry.Empty;
						}
						bool isHorizontal = virtualizingDataRecordCellPanel._fieldLayout.IsHorizontal;
						if (!flag2)
						{
							if (!isHorizontal)
							{
								bool flag3 = global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect2.Left, rect.Left);
								if (flag3 && virtualizingDataRecordCellPanel._fixedFarRect.Width == 0.0)
								{
									return newValue;
								}
								bool flag4 = global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect2.Right, rect.Right);
								if (flag4 && (flag3 || virtualizingDataRecordCellPanel._fixedNearRect.Width == 0.0))
								{
									return newValue;
								}
							}
							else
							{
								bool flag5 = global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect2.Top, rect.Top);
								if (flag5 && virtualizingDataRecordCellPanel._fixedFarRect.Height == 0.0)
								{
									return newValue;
								}
								bool flag6 = global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect2.Bottom, rect.Bottom);
								if (flag6 && (flag5 || virtualizingDataRecordCellPanel._fixedNearRect.Height == 0.0))
								{
									return newValue;
								}
							}
						}
						rect2 = scrollableClipRect;
						rect2.Offset(-rect.X, -rect.Y);
						if (frameworkElement.FlowDirection != virtualizingDataRecordCellPanel.FlowDirection)
						{
							global::System.Windows.Media.Transform transform = global::System.Windows.Media.VisualTreeHelper.GetTransform(frameworkElement);
							if (transform != null)
							{
								rect2 = transform.TransformBounds(rect2);
							}
						}
						if (isHorizontal)
						{
							rect2.X -= 1.0;
							rect2.Width += 2.0;
						}
						else
						{
							rect2.Y -= 1.0;
							rect2.Height += 2.0;
						}
						global::System.Windows.Media.Geometry geometry = new global::System.Windows.Media.RectangleGeometry(rect2);
						geometry.Freeze();
						return geometry;
					}
				}
			}
			return newValue;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0007A3B7 File Offset: 0x000785B7
		private static global::System.Windows.Rect ConstrainCellRectBottom(global::System.Windows.Rect rect, double height)
		{
			if (rect.Bottom > height)
			{
				rect.Height = global::System.Math.Max(height - rect.Top, 1.0);
			}
			return rect;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0007A3E4 File Offset: 0x000785E4
		private global::System.Windows.Controls.Control CreateCellElement(int index, global::Infragistics.Windows.DataPresenter.Field field, bool useCellPresenter, bool? isMouseOverCellArea)
		{
			global::System.Windows.Controls.Control control;
			if (this._isHeader)
			{
				control = field.GetLabelPresenter();
			}
			else if (this._record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
			{
				global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = this._record as global::Infragistics.Windows.DataPresenter.SummaryRecord;
				if (!summaryRecord.HasFixedSummaryResults(field))
				{
					return null;
				}
				control = (useCellPresenter ? new global::Infragistics.Windows.DataPresenter.SummaryCellPresenter() : new global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter());
			}
			else
			{
				control = (useCellPresenter ? new global::Infragistics.Windows.DataPresenter.CellPresenter() : ((this._record is global::Infragistics.Windows.DataPresenter.FilterRecord) ? new global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter() : field.GetCellValuePresenter()));
			}
			this._cellElements[index] = control;
			this.AddChild(control);
			this.InitializeCellElement(control, field, isMouseOverCellArea);
			this._allocatedCellCount--;
			return control;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0007A486 File Offset: 0x00078686
		[global::System.Diagnostics.Conditional("DEBUG_MEASURE_ARRANGE")]
		private static void DebugArrange(object value, string category)
		{
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0007A488 File Offset: 0x00078688
		internal void DirtyCellElements(bool invalidateMeasureAndArrange)
		{
			this.RemoveCellElements();
			if (invalidateMeasureAndArrange)
			{
				base.InvalidateMeasure();
				base.InvalidateArrange();
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0007A4A0 File Offset: 0x000786A0
		private static void EnforceMinMax(ref global::System.Windows.Size availableSize, ref global::System.Windows.Size autoFitSize, ref global::System.Windows.Size templateGridSize, ref global::System.Windows.Size size, global::System.Windows.Size minSize, global::System.Windows.Size maxSize, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (!double.IsNaN(autoFitSize.Width) || double.IsNaN(templateGridSize.Width))
			{
				if (!double.IsNaN(autoFitSize.Width) && fieldLayout != null && fieldLayout.AutoFitModeResolved == global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField)
				{
					autoFitSize.Width = global::System.Math.Max(autoFitSize.Width, size.Width);
				}
				if (autoFitSize.Width > size.Width)
				{
					size.Width = global::System.Math.Max(global::System.Math.Min(autoFitSize.Width, maxSize.Width), minSize.Width);
				}
				else if (autoFitSize.Width < size.Width)
				{
					size.Width = global::System.Math.Max(autoFitSize.Width, minSize.Width);
				}
				else if (!global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(size.Width, availableSize.Width) && size.Width > availableSize.Width && fieldLayout.IsAutoFitWidth)
				{
					size.Width = global::System.Math.Max(availableSize.Width, minSize.Width);
				}
				else if (size.Width < minSize.Width)
				{
					size.Width = minSize.Width;
				}
			}
			else if (!double.IsNaN(templateGridSize.Width))
			{
				size.Width = templateGridSize.Width;
			}
			if (!double.IsNaN(autoFitSize.Height) || double.IsNaN(templateGridSize.Height))
			{
				if (!double.IsNaN(autoFitSize.Height) && fieldLayout != null && fieldLayout.AutoFitModeResolved == global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField)
				{
					autoFitSize.Height = global::System.Math.Max(autoFitSize.Height, size.Height);
				}
				if (autoFitSize.Height > size.Height)
				{
					size.Height = global::System.Math.Max(global::System.Math.Min(autoFitSize.Height, maxSize.Height), minSize.Height);
					return;
				}
				if (autoFitSize.Height < size.Height)
				{
					size.Height = global::System.Math.Max(autoFitSize.Height, minSize.Height);
					return;
				}
				if (!global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(size.Height, availableSize.Height) && size.Height > availableSize.Height && fieldLayout.IsAutoFitHeight)
				{
					size.Height = global::System.Math.Max(availableSize.Height, minSize.Height);
					return;
				}
				if (size.Height < minSize.Height)
				{
					size.Height = minSize.Height;
					return;
				}
			}
			else if (!double.IsNaN(templateGridSize.Height))
			{
				size.Height = templateGridSize.Height;
			}
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0007A6F8 File Offset: 0x000788F8
		internal void EnsureCellIsCreated(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this.EnsureCellIsCreated(cell.Field, this.IsMouseOverCellArea);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0007A710 File Offset: 0x00078910
		private global::System.Windows.Controls.Control EnsureCellIsCreated(global::Infragistics.Windows.DataPresenter.Field field, bool? isMouseOverCellArea)
		{
			global::System.Windows.Controls.Control result = null;
			if (this._fieldLayout != null)
			{
				if (this._cellElementsDirty)
				{
					this.VerifyCellElements();
				}
				int fieldIndex = this._fieldLayout.TemplateDataRecordCache.GetFieldIndex(field);
				if (fieldIndex >= 0 && this._cellElements != null && this._cellElements[fieldIndex] == null)
				{
					this.CreateCellElement(fieldIndex, field, this._fieldLayout.UseCellPresenters, isMouseOverCellArea);
					bool positionAllAllocatedCells = this._positionAllAllocatedCells;
					try
					{
						this._positionAllAllocatedCells = true;
						base.InvalidateArrange();
						base.UpdateLayout();
					}
					finally
					{
						this._positionAllAllocatedCells = positionAllAllocatedCells;
					}
				}
				if (fieldIndex >= 0)
				{
					result = this._cellElements[fieldIndex];
				}
			}
			return result;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0007A7B4 File Offset: 0x000789B4
		private global::System.Windows.Size GetAutoFitSize()
		{
			global::System.Windows.Size result = new global::System.Windows.Size(this.AutoFitWidth, this.AutoFitHeight);
			if (this._lastDPMeasureSize != null && this._fieldLayout != null && this._fieldLayout.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
				if (dataPresenter != null && !dataPresenter.CurrentViewInternal.AutoFitToRecord)
				{
					global::System.Windows.Size lastMeasureSize = dataPresenter.LastMeasureSize;
					global::System.Windows.Size value = this._lastDPMeasureSize.Value;
					if (!double.IsNaN(result.Width) && !double.IsInfinity(lastMeasureSize.Width) && !double.IsInfinity(value.Width))
					{
						result.Width = global::System.Math.Min(result.Width, global::System.Math.Max(result.Width - (value.Width - lastMeasureSize.Width), 0.0));
					}
					if (!double.IsNaN(result.Height) && !double.IsInfinity(lastMeasureSize.Height) && !double.IsInfinity(value.Height))
					{
						result.Height = global::System.Math.Min(result.Height, global::System.Math.Max(result.Height - (value.Height - lastMeasureSize.Height), 0.0));
					}
				}
			}
			return result;
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0007A8FC File Offset: 0x00078AFC
		internal global::System.Windows.Controls.Control GetCellElement(global::Infragistics.Windows.DataPresenter.Field field, bool verify)
		{
			int templateCellIndex = field.TemplateCellIndex;
			if (verify)
			{
				this.VerifyCellElements();
			}
			if (templateCellIndex < 0 || templateCellIndex >= this._cellElements.Length)
			{
				return null;
			}
			return this._cellElements[templateCellIndex];
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0007A932 File Offset: 0x00078B32
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> GetCellInfo(bool includeInViewOnly)
		{
			return this.GetCellInfo(includeInViewOnly, true, true);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0007A940 File Offset: 0x00078B40
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> GetCellInfo(bool includeInViewOnly, bool includeFixedNear, bool includeFixedFar)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo>();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayout;
			bool usingFixedInfo = this._usingFixedInfo;
			if (fieldLayout != null)
			{
				global::System.Windows.Rect rect = usingFixedInfo ? this._scrollableClipRect : this.GetClipRect(base.RenderSize);
				global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
				if (usingFixedInfo)
				{
					if (!includeFixedNear)
					{
						rect.Union(this._fixedNearRect);
					}
					if (!includeFixedFar)
					{
						rect.Union(this._fixedFarRect);
					}
				}
				int i = 0;
				int num = this._cellElementRects.Length;
				while (i < num)
				{
					global::System.Windows.Rect rect2 = this._cellElementRects[i];
					if (!rect2.IsEmpty)
					{
						global::Infragistics.Windows.DataPresenter.Field field = fieldLayout.TemplateDataRecordCache.GetField(i);
						if (field != null)
						{
							if (usingFixedInfo)
							{
								fixedLocation = field.FixedLocation;
							}
							global::System.Windows.Rect clipRect;
							switch (fixedLocation)
							{
							default:
								if (includeInViewOnly && !rect2.IntersectsWith(rect))
								{
									goto IL_124;
								}
								clipRect = global::System.Windows.Rect.Intersect(rect, rect2);
								break;
							case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
								if (!includeFixedNear)
								{
									goto IL_124;
								}
								clipRect = rect2;
								break;
							case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
								if (!includeFixedFar)
								{
									goto IL_124;
								}
								clipRect = rect2;
								break;
							}
							global::System.Windows.FrameworkElement element = this._cellElements[i];
							global::System.Windows.Rect elementRect = this._cellElementRects[i];
							global::Infragistics.Windows.DataPresenter.VirtualCellInfo item = new global::Infragistics.Windows.DataPresenter.VirtualCellInfo(clipRect, field, fixedLocation, element, elementRect);
							list.Add(item);
						}
					}
					IL_124:
					i++;
				}
			}
			return list;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0007AA84 File Offset: 0x00078C84
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> GetFieldsInView()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			global::System.Windows.Rect clipRect = this.GetClipRect(base.RenderSize);
			this._lastFieldsInViewClipRect = clipRect;
			if (this._fieldLayout != null && this._cellElementRects != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
				{
					int templateCellIndex = field.TemplateCellIndex;
					if (templateCellIndex >= 0)
					{
						global::System.Windows.Rect rect = this._cellElementRects[templateCellIndex];
						if (!global::System.Windows.Rect.Intersect(clipRect, rect).IsEmpty)
						{
							list.Add(field);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0007AB38 File Offset: 0x00078D38
		internal void GetLogicalCellDimensions(global::System.Collections.Generic.List<double> rowDims, global::System.Collections.Generic.List<double> colDims)
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = this.GetLayoutManager();
			global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection layoutItemDimensionsCached = layoutManager.GetLayoutItemDimensionsCached(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, new global::System.Windows.Rect(this.LayoutManagerSize));
			int sourceOffset = this._fieldLayout.UseCellPresenters ? 2 : 1;
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AddExtents(layoutItemDimensionsCached.RowDims, rowDims, sourceOffset);
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AddExtents(layoutItemDimensionsCached.ColumnDims, colDims, sourceOffset);
			rowDims.Add(0.0);
			colDims.Add(0.0);
			global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo = this._fieldLayout.GetFixedFieldInfo(false);
			if (this._fieldLayout.IsHorizontal)
			{
				rowDims[fixedFieldInfo.NearFixedSpan * 2] = this._nearSplitterOffset.Y;
				rowDims[fixedFieldInfo.FarFixedOrigin * 2] = this._farSplitterOffset.Y - this._nearSplitterOffset.Y;
				return;
			}
			colDims[fixedFieldInfo.NearFixedSpan * 2] = this._nearSplitterOffset.X;
			colDims[fixedFieldInfo.FarFixedOrigin * 2] = this._farSplitterOffset.X - this._nearSplitterOffset.X;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0007AC4C File Offset: 0x00078E4C
		private static void AddExtents(double[] source, global::System.Collections.Generic.List<double> dest, int sourceOffset)
		{
			if (source.Length > 0 && sourceOffset > 0)
			{
				double num = source[0];
				for (int i = 1; i < source.Length; i += sourceOffset)
				{
					int num2 = i + sourceOffset - 1;
					dest.Add(0.0);
					dest.Add(source[num2] - num);
					num = source[num2];
				}
			}
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0007AC9C File Offset: 0x00078E9C
		internal global::Infragistics.Windows.DataPresenter.CellValuePresenter GetCellValuePresenter(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::System.Windows.Controls.Control cellElement = this.GetCellElement(field, true);
			global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = cellElement as global::Infragistics.Windows.DataPresenter.CellPresenter;
			if (cellPresenter != null)
			{
				return cellPresenter.CellValuePresenter;
			}
			return cellElement as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0007ACC9 File Offset: 0x00078EC9
		private global::System.Windows.Rect GetClipRect(global::System.Windows.Size currentElementSize)
		{
			return this.GetClipRect(currentElementSize, false);
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0007ACD4 File Offset: 0x00078ED4
		private global::System.Windows.Rect GetClipRect(global::System.Windows.Size currentElementSize, bool useRootScrollContentPresenter)
		{
			if (this._fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
				if (dataPresenter != null)
				{
					global::System.Windows.UIElement uielement;
					if (dataPresenter.IsReportControl)
					{
						uielement = dataPresenter.CurrentPanel;
						if (uielement == null)
						{
							uielement = dataPresenter;
						}
					}
					else if (this._fieldLayout.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)
					{
						uielement = dataPresenter;
					}
					else
					{
						global::System.Type type = dataPresenter.CurrentViewInternal.RecordPresenterContainerType;
						if (null == type)
						{
							type = typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter);
						}
						uielement = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, type, true) as global::System.Windows.UIElement);
					}
					if (uielement == null)
					{
						return global::System.Windows.Rect.Empty;
					}
					if (!base.IsDescendantOf(uielement))
					{
						return global::System.Windows.Rect.Empty;
					}
					if (useRootScrollContentPresenter)
					{
						global::System.Windows.Controls.ScrollContentPresenter scrollContentPresenter = null;
						for (global::System.Windows.DependencyObject dependencyObject = this; dependencyObject != uielement; dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject))
						{
							if (dependencyObject is global::System.Windows.Controls.ScrollContentPresenter)
							{
								scrollContentPresenter = (dependencyObject as global::System.Windows.Controls.ScrollContentPresenter);
							}
						}
						if (scrollContentPresenter != null)
						{
							uielement = scrollContentPresenter;
						}
					}
					return global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GetClipRect(this, currentElementSize, uielement);
				}
			}
			return global::System.Windows.Rect.Empty;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0007ADA8 File Offset: 0x00078FA8
		private static global::System.Windows.Rect GetClipRect(global::System.Windows.UIElement descendant, global::System.Windows.Size descendantSize, global::System.Windows.UIElement ancestorToClipTo)
		{
			global::System.Windows.Rect result = new global::System.Windows.Rect(descendantSize);
			try
			{
				global::System.Windows.Media.GeneralTransform generalTransform = ancestorToClipTo.TransformToDescendant(descendant);
				global::System.Windows.Rect rect = generalTransform.TransformBounds(new global::System.Windows.Rect(default(global::System.Windows.Point), ancestorToClipTo.RenderSize));
				result.Intersect(rect);
			}
			catch (global::System.InvalidOperationException)
			{
				return global::System.Windows.Rect.Empty;
			}
			return result;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0007AE08 File Offset: 0x00079008
		private static global::Infragistics.Windows.DataPresenter.Field GetField(global::System.Windows.Controls.Control control)
		{
			if (control is global::Infragistics.Windows.DataPresenter.CellValuePresenter)
			{
				return ((global::Infragistics.Windows.DataPresenter.CellValuePresenter)control).Field;
			}
			if (control is global::Infragistics.Windows.DataPresenter.CellPresenter)
			{
				return ((global::Infragistics.Windows.DataPresenter.CellPresenter)control).Field;
			}
			return (global::Infragistics.Windows.DataPresenter.Field)control.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0007AE42 File Offset: 0x00079042
		private object GetFieldKey(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._isHeader)
			{
				return field.LabelElementKey;
			}
			if (this._record is global::Infragistics.Windows.DataPresenter.FilterRecord)
			{
				return field.FilterCellElementKey;
			}
			return field.CellElementKey;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0007AE70 File Offset: 0x00079070
		internal global::Infragistics.Windows.DataPresenter.FieldPosition GetFixedArea(global::Infragistics.Windows.DataPresenter.FixedFieldLocation location)
		{
			if (this._fieldLayout == null)
			{
				return default(global::Infragistics.Windows.DataPresenter.FieldPosition);
			}
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo = this._fieldLayout.GetFixedFieldInfo(true);
			int num = this._fieldLayout.UseCellPresenters ? 2 : 1;
			switch (location)
			{
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
				return global::Infragistics.Windows.DataPresenter.FieldPosition.CreateHelper(0, 0, num * (isHorizontal ? fixedFieldInfo.ColumnCount : fixedFieldInfo.NearFixedSpan), num * (isHorizontal ? fixedFieldInfo.NearFixedSpan : fixedFieldInfo.RowCount));
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
				return global::Infragistics.Windows.DataPresenter.FieldPosition.CreateHelper(num * (isHorizontal ? 0 : fixedFieldInfo.FarFixedOrigin), num * (isHorizontal ? fixedFieldInfo.FarFixedOrigin : 0), num * (isHorizontal ? fixedFieldInfo.ColumnCount : fixedFieldInfo.FarFixedSpan), num * (isHorizontal ? fixedFieldInfo.FarFixedSpan : fixedFieldInfo.RowCount));
			}
			return global::Infragistics.Windows.DataPresenter.FieldPosition.CreateHelper(num * (isHorizontal ? 0 : fixedFieldInfo.NearFixedSpan), num * (isHorizontal ? fixedFieldInfo.FarFixedSpan : 0), num * (isHorizontal ? fixedFieldInfo.ColumnCount : (fixedFieldInfo.FarFixedOrigin - fixedFieldInfo.NearFixedSpan)), num * (isHorizontal ? (fixedFieldInfo.FarFixedOrigin - fixedFieldInfo.NearFixedSpan) : fixedFieldInfo.RowCount));
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0007AFA8 File Offset: 0x000791A8
		internal global::System.Windows.Vector GetFixedAreaOffset(global::Infragistics.Windows.DataPresenter.FixedFieldLocation location, bool includeSplitterOffset)
		{
			switch (location)
			{
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
				return this._fixedNearOffset + this._fixedNearAdjustment;
			case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
			{
				global::System.Windows.Vector vector = this._fixedFarOffset + this._fixedFarAdjustment;
				if (includeSplitterOffset)
				{
					vector += this._farSplitterOffset;
				}
				return vector;
			}
			}
			if (includeSplitterOffset)
			{
				return this._nearSplitterOffset;
			}
			return default(global::System.Windows.Vector);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0007B014 File Offset: 0x00079214
		internal void GetFixedEdgeScrollState(out bool isScrolledNearEdge, out bool isScrolledFarEdge)
		{
			bool flag = this._fieldLayout != null && this._fieldLayout.IsHorizontal;
			global::System.Windows.Vector fixedNearOffset = this._fixedNearOffset;
			isScrolledNearEdge = ((flag && (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(fixedNearOffset.Y, 0.0) || fixedNearOffset.Y < 0.0)) || (!flag && (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(fixedNearOffset.X, 0.0) || fixedNearOffset.X < 0.0)));
			global::System.Windows.Point bottomRight = this._fixedFarRect.BottomRight;
			isScrolledFarEdge = ((flag && (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(bottomRight.Y, base.ActualHeight) || bottomRight.Y > base.ActualHeight)) || (!flag && (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(bottomRight.X, base.ActualWidth) || bottomRight.X > base.ActualWidth)));
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0007B108 File Offset: 0x00079308
		internal global::System.Windows.Rect GetInViewRect()
		{
			global::System.Windows.Rect clipRect = this.GetClipRect(base.RenderSize, true);
			if (this._usingFixedInfo)
			{
				bool flag;
				bool flag2;
				this.GetFixedEdgeScrollState(out flag, out flag2);
				bool flag3 = this._fieldLayout != null && this._fieldLayout.IsHorizontal;
				if (!flag)
				{
					if (flag3)
					{
						double num = global::System.Math.Max(this._scrollableClipRect.Y - clipRect.Y, 0.0);
						clipRect.Y += num;
						clipRect.Height = global::System.Math.Max(clipRect.Height - num, 0.0);
					}
					else
					{
						double num2 = global::System.Math.Max(this._scrollableClipRect.X - clipRect.X, 0.0);
						clipRect.X += num2;
						clipRect.Width = global::System.Math.Max(clipRect.Width - num2, 0.0);
					}
				}
				if (!flag2)
				{
					if (flag3)
					{
						clipRect.Height = global::System.Math.Max(clipRect.Height - (clipRect.Bottom - this._scrollableClipRect.Bottom), 0.0);
					}
					else
					{
						clipRect.Width = global::System.Math.Max(clipRect.Width - (clipRect.Right - this._scrollableClipRect.Right), 0.0);
					}
				}
			}
			return clipRect;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0007B268 File Offset: 0x00079468
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager GetLayoutManager()
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = null;
			if (this._fieldLayout != null)
			{
				fieldGridBagLayoutManager = ((this._record != null) ? this._record.GetLayoutManager(false) : null);
				if (fieldGridBagLayoutManager == null)
				{
					fieldGridBagLayoutManager = this._recordLayoutManager;
					if (fieldGridBagLayoutManager == null)
					{
						fieldGridBagLayoutManager = (this._isHeader ? this._fieldLayout.LabelLayoutManager : this._fieldLayout.CellLayoutManager);
						bool flag = false;
						if (this._fieldLayout.IsEmptyCellCollapsingSupportedByView && (this._record == null || this._record.ShouldCollapseEmptyCellsResolved))
						{
							flag = true;
						}
						if (this._record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
						{
							flag = true;
						}
						else if (!flag)
						{
							switch (global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.CalculateSizingMode(this._record, this._fieldLayout, this._isHeader))
							{
							case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndFixed:
							case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndIndividuallySizable:
								flag = true;
								break;
							}
						}
						if (flag)
						{
							fieldGridBagLayoutManager = fieldGridBagLayoutManager.Clone();
							this._recordLayoutManager = fieldGridBagLayoutManager;
							fieldGridBagLayoutManager.Record = this._record;
						}
					}
				}
			}
			fieldGridBagLayoutManager.VerifyLayout();
			return fieldGridBagLayoutManager;
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0007B358 File Offset: 0x00079558
		internal global::Infragistics.Windows.DataPresenter.Field GetNearestCompatibleField(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point relativePoint, global::Infragistics.Windows.DataPresenter.Field pivotField, global::Infragistics.Windows.DataPresenter.Record pivotRecord)
		{
			if (this._fieldLayout == null)
			{
				return null;
			}
			bool includeFixedNear = false;
			bool includeFixedFar = false;
			if (this._usingFixedInfo)
			{
				this.GetFixedEdgeScrollState(out includeFixedNear, out includeFixedFar);
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> cellInfo = this.GetCellInfo(true, includeFixedNear, includeFixedFar);
			global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
			foreach (global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo in cellInfo)
			{
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.ContainsExclusive(virtualCellInfo.ClipRect, relativePoint))
				{
					return virtualCellInfo.Field;
				}
				empty.Union(virtualCellInfo.ClipRect);
			}
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.ContainsExclusive(empty, relativePoint))
			{
				return null;
			}
			if (pivotField == null)
			{
				return null;
			}
			int templateCellIndex = pivotField.TemplateCellIndex;
			if (templateCellIndex < 0 || templateCellIndex >= this._cellElementRects.Length)
			{
				return null;
			}
			global::System.Windows.Rect rect = this._cellElementRects[templateCellIndex];
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
			bool flag = currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal;
			bool? flag2 = null;
			if (pivotRecord == null)
			{
				if (!flag)
				{
					if (relativePoint.Y < 0.0)
					{
						flag2 = new bool?(true);
					}
					else if (relativePoint.Y >= base.ActualHeight)
					{
						flag2 = new bool?(false);
					}
				}
				else if (relativePoint.X < 0.0)
				{
					flag2 = new bool?(true);
				}
				else if (relativePoint.X >= base.ActualWidth)
				{
					flag2 = new bool?(false);
				}
			}
			else if (this._record != pivotRecord)
			{
				flag2 = new bool?(this._record.OverallScrollPosition < pivotRecord.OverallScrollPosition);
			}
			int num;
			if (relativePoint.X < rect.X)
			{
				num = -1;
			}
			else if (relativePoint.X > rect.Right)
			{
				num = 1;
			}
			else
			{
				num = 0;
			}
			int num2;
			if (relativePoint.Y < rect.Y)
			{
				num2 = -1;
			}
			else if (relativePoint.Y > rect.Bottom)
			{
				num2 = 1;
			}
			else
			{
				num2 = 0;
			}
			if (flag2 != null)
			{
				if (!flag)
				{
					num2 = ((flag2 == true) ? -1 : 1);
				}
				else
				{
					num = ((flag2 == true) ? -1 : 1);
				}
			}
			int num3 = -1;
			if (num2 == 0)
			{
				num3 = pivotField.GridPosition.Row;
			}
			else
			{
				if (num2 > 0)
				{
					num3 = 0;
				}
				else
				{
					num3 = pivotField.Owner.TotalRowsGenerated;
				}
				foreach (global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo2 in cellInfo)
				{
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = virtualCellInfo2.Field.GridPosition;
					if (num2 > 0)
					{
						if ((num3 < 0 || num3 < gridPosition.Row) && virtualCellInfo2.ElementRect.Y < relativePoint.Y)
						{
							num3 = gridPosition.Row;
						}
					}
					else if ((num3 < 0 || num3 > gridPosition.Row + gridPosition.RowSpan) && virtualCellInfo2.ElementRect.Y > relativePoint.Y)
					{
						num3 = gridPosition.Row + gridPosition.RowSpan;
					}
				}
			}
			if (num3 < 0)
			{
				return null;
			}
			int num4 = -1;
			if (num == 0)
			{
				num4 = pivotField.GridPosition.Column;
			}
			else
			{
				if (num > 0)
				{
					num4 = 0;
				}
				else
				{
					num4 = pivotField.Owner.TotalColumnsGenerated;
				}
				foreach (global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo3 in cellInfo)
				{
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition2 = virtualCellInfo3.Field.GridPosition;
					if (num > 0)
					{
						if ((num4 < 0 || num4 < gridPosition2.Column) && virtualCellInfo3.ElementRect.X < relativePoint.X)
						{
							num4 = gridPosition2.Column;
						}
					}
					else if ((num4 < 0 || num4 > gridPosition2.Column + gridPosition2.ColumnSpan) && virtualCellInfo3.ElementRect.X > relativePoint.X)
					{
						num4 = gridPosition2.Column + gridPosition2.ColumnSpan;
					}
				}
			}
			if (num4 < 0)
			{
				return null;
			}
			for (int i = cellInfo.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo4 = cellInfo[i];
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition3 = virtualCellInfo4.Field.GridPosition;
				bool flag3 = true;
				if (num2 < 0)
				{
					if (gridPosition3.Row + gridPosition3.RowSpan == num3)
					{
						flag3 = false;
					}
				}
				else if (gridPosition3.Row == num3)
				{
					flag3 = false;
				}
				if (flag3)
				{
					int num5 = cellInfo.Count - 1;
					if (num5 != i)
					{
						cellInfo[i] = cellInfo[num5];
					}
					cellInfo.RemoveAt(num5);
				}
			}
			global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo5 = null;
			foreach (global::Infragistics.Windows.DataPresenter.VirtualCellInfo virtualCellInfo6 in cellInfo)
			{
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition4 = virtualCellInfo6.Field.GridPosition;
				if (num < 0)
				{
					if (gridPosition4.Column + gridPosition4.ColumnSpan == num4)
					{
						virtualCellInfo5 = virtualCellInfo6;
					}
				}
				else if (gridPosition4.Column == num4)
				{
					virtualCellInfo5 = virtualCellInfo6;
				}
			}
			if (virtualCellInfo5 == null)
			{
				return null;
			}
			return virtualCellInfo5.Field;
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0007B8B4 File Offset: 0x00079AB4
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager GetResizeLayoutManager()
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager result = this.GetLayoutManager();
			if (this.ForceUseCellLayoutManager)
			{
				result = this._fieldLayout.CellLayoutManager;
			}
			return result;
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0007B8E0 File Offset: 0x00079AE0
		internal double GetScrollableViewport(double viewportExtent, bool ignoreIfInView)
		{
			if (this._containingRp == null || this._fieldLayout == null)
			{
				return viewportExtent;
			}
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			double num = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CalculateFixedRecordAreaEdge(isHorizontal, 0.0, this._containingRp, this._record, this, this._isHeader);
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
			num += templateDataRecordCache.GetVirtPanelOffset(true, true);
			double num2 = isHorizontal ? base.ActualHeight : base.ActualWidth;
			if (ignoreIfInView && num2 + num <= viewportExtent)
			{
				return viewportExtent;
			}
			if (isHorizontal)
			{
				num += this._fixedNearRect.Height + this._fixedFarRect.Height;
			}
			else
			{
				num += this._fixedNearRect.Width + this._fixedFarRect.Width;
			}
			return viewportExtent - num;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0007B9A0 File Offset: 0x00079BA0
		private void GetSplitterLocations(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> affectedFields, global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType splitterType, out global::Infragistics.Windows.DataPresenter.FixedFieldLocation oldLocation, out global::Infragistics.Windows.DataPresenter.FixedFieldLocation newLocation)
		{
			global::Infragistics.Windows.DataPresenter.Field field = affectedFields[0];
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = this.GetLayoutManager();
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutManager.GetLayoutItem(field, false) ?? layoutManager.GetLayoutItem(field, true);
			oldLocation = ((fieldLayoutItemBase != null) ? fieldLayoutItemBase.FixedLocation : field.FixedLocation);
			switch (splitterType)
			{
			case global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near:
				if (oldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge)
				{
					newLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
					return;
				}
				newLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge;
				return;
			case global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Far:
				if (oldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge)
				{
					newLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
					return;
				}
				newLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge;
				return;
			default:
				newLocation = oldLocation;
				return;
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0007BA18 File Offset: 0x00079C18
		internal static global::System.Windows.Size GetTemplateItemSize(global::Infragistics.Windows.DataPresenter.Field field, bool isHeader)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner.DataPresenter != null)
			{
				owner.DataPresenter.UpdateLayout();
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = (isHeader && owner.HasSeparateHeader) ? owner.LabelLayoutManager : owner.CellLayoutManager;
			fieldGridBagLayoutManager.VerifyLayout();
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = fieldGridBagLayoutManager.GetLayoutItem(field, isHeader);
			if (layoutItem == null)
			{
				return default(global::System.Windows.Size);
			}
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = owner.TemplateDataRecordCache;
			global::System.Windows.Size templateGridSize = templateDataRecordCache.TemplateGridSize;
			global::System.Windows.Size size = templateGridSize;
			if (double.IsNaN(templateGridSize.Width) || double.IsNaN(templateGridSize.Height))
			{
				global::System.Windows.Size size2 = fieldGridBagLayoutManager.CalculatePreferredSize();
				if (double.IsNaN(templateGridSize.Width))
				{
					size.Width = size2.Width;
				}
				if (double.IsNaN(templateGridSize.Height))
				{
					size.Height = size2.Height;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer fieldRectsLayoutContainer = new global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer();
			fieldGridBagLayoutManager.LayoutContainer(fieldRectsLayoutContainer, new global::System.Windows.Rect(size));
			return fieldRectsLayoutContainer[layoutItem].Size;
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0007BB18 File Offset: 0x00079D18
		private bool HasClipRectChanged()
		{
			global::System.Windows.Rect clipRect = this.GetClipRect(base.RenderSize);
			return this._lastClipRect != clipRect && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(this._lastClipRect, clipRect) && !this._lastClipRect.Contains(clipRect);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0007BB60 File Offset: 0x00079D60
		private void InitializeAutoFitBindings()
		{
			if (this._isAutoFitInitialized)
			{
				return;
			}
			this._isAutoFitInitialized = true;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayout;
			if (fieldLayout != null && fieldLayout.IsAutoFit)
			{
				if (this._containingRp == null)
				{
					this._containingRp = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this._containingCellArea ?? this, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				}
				if (fieldLayout.IsAutoFitHeight)
				{
					if (this._containingRp != null)
					{
						base.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AutoFitHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaHeightProperty, global::System.Windows.Data.BindingMode.OneWay, this._containingRp));
					}
					else
					{
						base.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AutoFitHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaHeightProperty, global::System.Windows.Data.BindingMode.OneWay, new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), 1)));
					}
				}
				if (fieldLayout.IsAutoFitWidth)
				{
					if (this._containingRp != null)
					{
						base.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AutoFitWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaWidthProperty, global::System.Windows.Data.BindingMode.OneWay, this._containingRp));
					}
					else
					{
						base.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.AutoFitWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.AutoFitCellAreaWidthProperty, global::System.Windows.Data.BindingMode.OneWay, new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), 1)));
					}
				}
				if (fieldLayout.IsAutoFit)
				{
					base.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GridMeasureVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GridMeasureVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this._fieldLayout.DataPresenter));
				}
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0007BC9C File Offset: 0x00079E9C
		internal void InitializeCachedDimensions()
		{
			global::System.Windows.Size renderSize = base.RenderSize;
			global::System.Windows.Size size = new global::System.Windows.Size(double.NaN, double.NaN);
			global::System.Windows.Size size2 = new global::System.Windows.Size(double.NaN, double.NaN);
			double num = 0.0;
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			if (isHorizontal)
			{
				return;
			}
			if (this._nearSplitter != null)
			{
				num += (isHorizontal ? this._nearSplitter.ActualHeight : this._nearSplitter.ActualWidth);
			}
			if (this._farSplitter != null)
			{
				num += (isHorizontal ? this._farSplitter.ActualHeight : this._farSplitter.ActualWidth);
			}
			this.InitializeCachedDimensions(ref renderSize, num, ref size, ref size2);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0007BD64 File Offset: 0x00079F64
		private void InitializeCachedDimensions(ref global::System.Windows.Size availableSize, double splitterExtent, ref global::System.Windows.Size autoFitSize, ref global::System.Windows.Size templateGridSize)
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = this._isHeader ? this._fieldLayout.LabelLayoutManager : this._fieldLayout.CellLayoutManager;
			global::System.Windows.Size size = default(global::System.Windows.Size);
			if (!double.IsNaN(autoFitSize.Width))
			{
				size.Width = global::System.Math.Max(autoFitSize.Width - splitterExtent, 0.0);
			}
			else if (!double.IsNaN(templateGridSize.Width))
			{
				size.Width = global::System.Math.Max(templateGridSize.Width - splitterExtent, 0.0);
			}
			else
			{
				size.Width = fieldGridBagLayoutManager.CalculatePreferredSize().Width;
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.EnforceMinMax(ref availableSize, ref autoFitSize, ref templateGridSize, ref size, fieldGridBagLayoutManager.CalculateMinimumSize(), fieldGridBagLayoutManager.CalculateMaximumSize(), this._fieldLayout);
			size.Height = double.PositiveInfinity;
			this._cachedDimensions = fieldGridBagLayoutManager.GetLayoutItemDimensionsCached(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, new global::System.Windows.Rect(size));
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0007BE54 File Offset: 0x0007A054
		private void InitializeCellElement(global::System.Windows.Controls.Control element, global::Infragistics.Windows.DataPresenter.Field field, bool? isMouseOverCellArea)
		{
			global::System.Windows.Controls.Control childBeingInitialized = this._childBeingInitialized;
			this._childBeingInitialized = element;
			try
			{
				this._cellElementVersion++;
				global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.InitializeCellElement(element, field, this._record, this._isHeader);
				if (isMouseOverCellArea != null)
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = element as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
					if (cellValuePresenter == null)
					{
						global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = element as global::Infragistics.Windows.DataPresenter.CellPresenter;
						if (cellPresenter != null)
						{
							cellValuePresenter = cellPresenter.CellValuePresenter;
						}
					}
					if (cellValuePresenter != null)
					{
						cellValuePresenter.OnRecordMouseOverChanged(isMouseOverCellArea.Value);
					}
				}
			}
			finally
			{
				this._childBeingInitialized = childBeingInitialized;
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0007BEE0 File Offset: 0x0007A0E0
		internal static void InitializeCellElement(global::System.Windows.Controls.Control element, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.Record record, bool isHeader)
		{
			element.SetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, field);
			if (!isHeader && !(element is global::Infragistics.Windows.DataPresenter.CellValuePresenter))
			{
				element.SetBinding(global::Infragistics.Windows.DataPresenter.CellValuePresenter.IsFieldSelectedProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.Field.IsSelectedProperty, global::System.Windows.Data.BindingMode.OneWay, field));
			}
			if (record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
			{
				global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = (global::Infragistics.Windows.DataPresenter.SummaryRecord)record;
				if (element is global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter)
				{
					global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter summaryResultsPresenter = element as global::Infragistics.Windows.DataPresenter.SummaryResultsPresenter;
					summaryResultsPresenter.SetBinding(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty, field.VisibilityBinding);
					summaryResultsPresenter.SetBinding(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty, field.CellContentAlignmentBinding);
					record.InvalidatePeer();
				}
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0007BF64 File Offset: 0x0007A164
		private void InitializeCellPresenterRects(global::System.Windows.FrameworkElement element)
		{
			global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenterBase = element as global::Infragistics.Windows.DataPresenter.CellPresenterBase;
			if (cellPresenterBase != null)
			{
				global::Infragistics.Windows.DataPresenter.Field field = cellPresenterBase.Field;
				if (field != null)
				{
					int templateCellIndex = field.TemplateCellIndex;
					if (templateCellIndex >= 0 && templateCellIndex < this._cellElements.Length)
					{
						global::System.Windows.Rect rect = this._cellElementRects[templateCellIndex];
						global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = this.LastLayoutManager ?? this.GetLayoutManager();
						global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer cellPresenterRectContainer = this.CellPresenterRectContainer;
						for (int i = 0; i < 2; i++)
						{
							bool flag = i == 0;
							global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = fieldGridBagLayoutManager.GetLayoutItem(field, flag);
							global::System.Windows.Rect rect2;
							if (layoutItem != null)
							{
								rect2 = cellPresenterRectContainer[layoutItem];
								rect2.Offset(-rect.X, -rect.Y);
							}
							else
							{
								rect2 = default(global::System.Windows.Rect);
							}
							if (flag)
							{
								cellPresenterBase.LabelRect = rect2;
							}
							else
							{
								cellPresenterBase.CellRect = rect2;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0007C03C File Offset: 0x0007A23C
		private void InitializeSplitter(ref global::Infragistics.Windows.DataPresenter.FixedFieldSplitter splitter, global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType splitterType, global::System.Windows.Visibility visibility, bool isEnabled)
		{
			if (splitter == null)
			{
				global::System.Windows.Controls.Orientation orientation = this._fieldLayout.IsHorizontal ? global::System.Windows.Controls.Orientation.Horizontal : global::System.Windows.Controls.Orientation.Vertical;
				splitter = new global::Infragistics.Windows.DataPresenter.FixedFieldSplitter(this._isHeader, orientation, splitterType);
				base.AddLogicalChild(splitter);
				base.AddVisualChild(splitter);
			}
			splitter.Visibility = visibility;
			splitter.IsEnabled = isEnabled;
			if (this._record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
			{
				if (visibility == global::System.Windows.Visibility.Visible)
				{
					splitter.Visibility = global::System.Windows.Visibility.Hidden;
				}
				splitter.IsEnabled = false;
			}
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0007C0B0 File Offset: 0x0007A2B0
		private void InvalidateLayoutManager()
		{
			if (this._recordLayoutManager != null)
			{
				this._recordLayoutManager.InvalidateLayout();
			}
			if (this._record != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = this._record.GetLayoutManager(false);
				if (layoutManager != null)
				{
					layoutManager.InvalidateLayout();
				}
			}
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0007C0F0 File Offset: 0x0007A2F0
		private static void OnDataContextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)d;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = virtualizingDataRecordCellPanel._fieldLayout;
			if (virtualizingDataRecordCellPanel._record != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(virtualizingDataRecordCellPanel._record, virtualizingDataRecordCellPanel, "CellLayoutVersion");
			}
			virtualizingDataRecordCellPanel._record = (e.NewValue as global::Infragistics.Windows.DataPresenter.Record);
			if (virtualizingDataRecordCellPanel._record != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.AddListener(virtualizingDataRecordCellPanel._record, virtualizingDataRecordCellPanel, "CellLayoutVersion");
			}
			object oldValue = e.OldValue;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout;
			if (fieldLayout2 != null)
			{
				virtualizingDataRecordCellPanel._isHeader = true;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Record record = e.NewValue as global::Infragistics.Windows.DataPresenter.Record;
				if (record != null)
				{
					fieldLayout2 = record.FieldLayout;
					global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = record.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
					if (dataRecordPresenter != null)
					{
						dataRecordPresenter.AssociatedVirtualizingDataRecordCellPanel = virtualizingDataRecordCellPanel;
					}
				}
			}
			if (fieldLayout2 != null)
			{
				virtualizingDataRecordCellPanel._fieldLayout = fieldLayout2;
				virtualizingDataRecordCellPanel.InvalidateLayoutManager();
				if (virtualizingDataRecordCellPanel._recordLayoutManager != null)
				{
					virtualizingDataRecordCellPanel._recordLayoutManager.Record = virtualizingDataRecordCellPanel._record;
				}
				if (fieldLayout != null)
				{
					virtualizingDataRecordCellPanel.InvalidateMeasure();
					virtualizingDataRecordCellPanel.InvalidateArrange();
				}
				if (fieldLayout != virtualizingDataRecordCellPanel._fieldLayout)
				{
					virtualizingDataRecordCellPanel.RemoveCellElements();
				}
				else if (fieldLayout2.Fields.Version != virtualizingDataRecordCellPanel._fieldsVersion)
				{
					virtualizingDataRecordCellPanel.RemoveInvalidFieldElements();
				}
				virtualizingDataRecordCellPanel.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ScrollVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollVersionProperty, global::System.Windows.Data.BindingMode.OneWay, fieldLayout2.DataPresenter));
				virtualizingDataRecordCellPanel.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GridColumnWidthVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.GridColumnWidthVersionProperty, global::System.Windows.Data.BindingMode.OneWay, fieldLayout2));
				virtualizingDataRecordCellPanel.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.TemplateVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.TemplateVersionProperty, global::System.Windows.Data.BindingMode.OneWay, fieldLayout2));
				virtualizingDataRecordCellPanel._isRecycling = (fieldLayout2.DataPresenter.CellContainerGenerationMode == global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.Recycle);
				virtualizingDataRecordCellPanel._lastAutoSizeElementVersion = -1;
				return;
			}
			if (virtualizingDataRecordCellPanel._usingFixedInfo)
			{
				virtualizingDataRecordCellPanel._usingFixedInfo = false;
				virtualizingDataRecordCellPanel.ClearValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldInfoProperty);
			}
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0007C28C File Offset: 0x0007A48C
		private void OnLayoutUpdated()
		{
			if (!base.IsVisible && base.DataContext == null)
			{
				return;
			}
			bool? flag = null;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._fieldLayout != null) ? this._fieldLayout.DataPresenter : null;
			if (dataPresenterBase != null && !dataPresenterBase._pendingRaiseCellsInViewChangedAsyncHelperHandler && dataPresenterBase.ShouldRaiseCellsInViewChanged)
			{
				flag = new bool?(this.HasClipRectChanged());
				global::System.Windows.Rect clipRect = this.GetClipRect(base.DesiredSize);
				if (flag.Value || !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(this._lastFieldsInViewClipRect, clipRect))
				{
					dataPresenterBase.RaiseCellsInViewChangedAsyncHelper();
				}
			}
			if (this._reportLayoutInfo != null && this._fieldLayout != null)
			{
				if (dataPresenterBase == null)
				{
					return;
				}
				global::System.Windows.Controls.Panel currentPanel = dataPresenterBase.CurrentPanel;
				if (currentPanel == null)
				{
					return;
				}
				global::System.Windows.Point point = base.TranslatePoint(default(global::System.Windows.Point), currentPanel);
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = currentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
				double num;
				if (this._fieldLayout.IsHorizontal)
				{
					num = point.Y;
					if (scrollInfo != null)
					{
						num += scrollInfo.VerticalOffset;
					}
				}
				else
				{
					num = point.X;
					if (scrollInfo != null)
					{
						num += scrollInfo.HorizontalOffset;
					}
				}
				if (num > -1000.0)
				{
					this._normalizedOffsetFromPanel = new double?(num);
					if (this.RefreshReportLayoutInfo())
					{
						base.InvalidateMeasure();
						currentPanel.InvalidateArrange();
						currentPanel.InvalidateMeasure();
					}
				}
				return;
			}
			else
			{
				if (this._requiresAsynchMeasureInvalidation)
				{
					base.InvalidateMeasure();
					return;
				}
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> virtualizedFields = this.VirtualizedFields;
				if (virtualizedFields != null && virtualizedFields.Count > 0)
				{
					if (flag == null)
					{
						flag = new bool?(this.HasClipRectChanged());
					}
					if (flag.Value)
					{
						base.InvalidateArrange();
					}
					else if (this._fieldLayout != null && this.IsNestedFixedHeader && dataPresenterBase != null && !dataPresenterBase.IsReportControl)
					{
						base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.VerifyClipRect));
					}
				}
				this.VerifyFixedFieldOffsets();
				return;
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0007C450 File Offset: 0x0007A650
		private void OnRecordMouseOverChanged()
		{
			bool? isMouseOverCellArea = this.IsMouseOverCellArea;
			if (isMouseOverCellArea == null)
			{
				return;
			}
			int count = this.children.Count;
			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					global::System.Windows.FrameworkElement frameworkElement = this.children[i];
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = frameworkElement as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
					if (cellValuePresenter == null)
					{
						global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = frameworkElement as global::Infragistics.Windows.DataPresenter.CellPresenter;
						if (cellPresenter != null)
						{
							cellValuePresenter = cellPresenter.CellValuePresenter;
						}
					}
					if (cellValuePresenter != null)
					{
						cellValuePresenter.OnRecordMouseOverChanged(isMouseOverCellArea.Value);
					}
				}
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0007C4CC File Offset: 0x0007A6CC
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			if (e.OriginalSource == sender)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)sender;
			global::System.Windows.Media.Visual visual = e.TargetObject as global::System.Windows.Media.Visual;
			global::System.Windows.Rect rect = e.TargetRect;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = virtualizingDataRecordCellPanel._fieldLayout;
			if (fieldLayout == null || visual == null)
			{
				return;
			}
			bool flag = fieldLayout != null && fieldLayout.IsHorizontal;
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.Windows.DataPresenter.GridUtilities.GetImmediateDescendant(visual, virtualizingDataRecordCellPanel) as global::System.Windows.FrameworkElement;
			if (frameworkElement == null || frameworkElement is global::Infragistics.Windows.DataPresenter.FixedFieldSplitter)
			{
				return;
			}
			if (frameworkElement == virtualizingDataRecordCellPanel._childBeingInitialized)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(frameworkElement);
			if (fieldFromControl == null)
			{
				return;
			}
			global::System.Windows.UIElement uielement = visual as global::System.Windows.UIElement;
			if (!rect.IsEmpty || uielement != null)
			{
				if (rect.IsEmpty)
				{
					rect = new global::System.Windows.Rect(uielement.RenderSize);
				}
				bool flag2 = frameworkElement.IsKeyboardFocused || frameworkElement.IsKeyboardFocusWithin;
				if (virtualizingDataRecordCellPanel._usingFixedInfo)
				{
					global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = virtualizingDataRecordCellPanel.GetLayoutManager();
					global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutManager.GetLayoutItem(fieldFromControl, virtualizingDataRecordCellPanel._isHeader) ?? layoutManager.GetLayoutItem(fieldFromControl, !virtualizingDataRecordCellPanel._isHeader);
					if (fieldLayoutItemBase != null && fieldLayoutItemBase.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
					{
						e.Handled = true;
						return;
					}
					rect = visual.TransformToAncestor(virtualizingDataRecordCellPanel).TransformBounds(rect);
					global::System.Windows.Rect scrollableClipRect = virtualizingDataRecordCellPanel._scrollableClipRect;
					if (flag)
					{
						double num = 0.0;
						if (visual != frameworkElement && visual is global::System.Windows.UIElement)
						{
							global::System.Windows.Rect rect2 = visual.TransformToAncestor(frameworkElement).TransformBounds(new global::System.Windows.Rect(((global::System.Windows.UIElement)visual).RenderSize));
							scrollableClipRect.Height = global::System.Math.Max(scrollableClipRect.Height - (frameworkElement.ActualHeight - rect2.Height), 0.0);
							scrollableClipRect.Y += rect2.Y;
						}
						if (rect.Height > scrollableClipRect.Height)
						{
							rect.Height = scrollableClipRect.Height;
						}
						if (rect.Y < scrollableClipRect.Y)
						{
							num += virtualizingDataRecordCellPanel._fixedNearRect.Height;
							global::Infragistics.Windows.DataPresenter.Record record = (virtualizingDataRecordCellPanel._containingRp != null) ? virtualizingDataRecordCellPanel._containingRp.GetRecordForMeasure() : null;
							if (record != null)
							{
								num += record.CalculateNestedRecordContentNearOffset();
							}
							if (fieldLayout != null && fieldLayout.RecordSelectorLocationResolved == global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea)
							{
								num += fieldLayout.RecordSelectorExtentResolved;
							}
						}
						else if (rect.Bottom > scrollableClipRect.Bottom)
						{
							num += -virtualizingDataRecordCellPanel._fixedFarRect.Height;
						}
						rect.Y -= num;
					}
					else
					{
						double num2 = 0.0;
						if (visual != frameworkElement && visual is global::System.Windows.UIElement)
						{
							global::System.Windows.Rect rect3 = visual.TransformToAncestor(frameworkElement).TransformBounds(new global::System.Windows.Rect(((global::System.Windows.UIElement)visual).RenderSize));
							scrollableClipRect.Width = global::System.Math.Max(scrollableClipRect.Width - (frameworkElement.ActualWidth - rect3.Width), 0.0);
							scrollableClipRect.X += rect3.X;
						}
						if (rect.Width > scrollableClipRect.Width)
						{
							rect.Width = scrollableClipRect.Width;
						}
						if (rect.X < scrollableClipRect.X)
						{
							num2 += virtualizingDataRecordCellPanel._fixedNearRect.Width;
							global::Infragistics.Windows.DataPresenter.Record record2 = (virtualizingDataRecordCellPanel._containingRp != null) ? virtualizingDataRecordCellPanel._containingRp.Record : null;
							if (record2 != null)
							{
								num2 += record2.CalculateNestedRecordContentNearOffset();
							}
							if (fieldLayout != null && fieldLayout.RecordSelectorLocationResolved == global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea)
							{
								num2 += fieldLayout.RecordSelectorExtentResolved;
							}
						}
						else if (rect.Right > scrollableClipRect.Right)
						{
							num2 += -virtualizingDataRecordCellPanel._fixedFarRect.Width;
						}
						rect.X -= num2;
					}
				}
				else
				{
					if (!flag2)
					{
						return;
					}
					rect = visual.TransformToAncestor(virtualizingDataRecordCellPanel).TransformBounds(rect);
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
				try
				{
					if (dataPresenter != null && flag2)
					{
						dataPresenter.SuspendEndEditOnScroll();
					}
					e.Handled = true;
					virtualizingDataRecordCellPanel.BringIntoView(rect);
				}
				finally
				{
					if (dataPresenter != null && flag2)
					{
						dataPresenter.ResumeEndEditOnScroll();
					}
				}
			}
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0007C8B0 File Offset: 0x0007AAB0
		internal void ProcessFixedFieldSplitterAction(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> affectedFields, global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType splitterType)
		{
			if (affectedFields == null || affectedFields.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.LayoutInfo layoutInfo = this._fieldLayout.GetFieldLayoutInfo(true, true).Clone(true);
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation;
			global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation2;
			this.GetSplitterLocations(affectedFields, splitterType, out fixedFieldLocation, out fixedFieldLocation2);
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason fieldPositionChangeReason = (fixedFieldLocation2 == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable) ? global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed : global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed;
			if (!dataPresenter.VerifyOperationIsAllowed(global::Infragistics.Windows.DataPresenter.UIOperation.FieldFixing))
			{
				return;
			}
			for (int i = affectedFields.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.DataPresenter.Field field = affectedFields[i];
				bool flag = !field.IsFixedLocationAllowed(fixedFieldLocation2) || field.FixedLocation == fixedFieldLocation2;
				if (!flag && dataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs fieldPositionChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs(affectedFields[i], fieldPositionChangeReason);
					dataPresenter.RaiseFieldPositionChanging(fieldPositionChangingEventArgs);
					flag = fieldPositionChangingEventArgs.Cancel;
				}
				if (flag)
				{
					affectedFields.RemoveAt(i);
				}
			}
			if (affectedFields.Count == 0)
			{
				return;
			}
			layoutInfo.UpdateFixedLocation(fixedFieldLocation, fixedFieldLocation2, affectedFields);
			if (dataPresenter != null && dataPresenter.IsUndoEnabled)
			{
				global::Infragistics.Windows.DataPresenter.FieldPositionAction action = new global::Infragistics.Windows.DataPresenter.FieldPositionAction(affectedFields, this._fieldLayout.GetFieldLayoutInfo(true, true), global::Infragistics.Windows.DataPresenter.FieldPositionAction.GetUndoReason(fieldPositionChangeReason), fixedFieldLocation);
				dataPresenter.History.AddUndoActionInternal(action);
			}
			this._fieldLayout.SetFieldLayoutInfo(layoutInfo, true, false);
			for (int j = affectedFields.Count - 1; j >= 0; j--)
			{
				affectedFields[j].SetFixedLocation(fixedFieldLocation2);
			}
			if (this._fieldLayout != null)
			{
				this._fieldLayout.InvalidateGeneratedStyles(false, false);
			}
			if (dataPresenter != null)
			{
				for (int k = affectedFields.Count - 1; k >= 0; k--)
				{
					global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs(affectedFields[k], fieldPositionChangeReason);
					dataPresenter.RaiseFieldPositionChanged(args);
				}
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0007CA3C File Offset: 0x0007AC3C
		private bool RefreshReportLayoutInfo()
		{
			global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo reportLayoutInfo = this._reportLayoutInfo;
			if (this._fieldLayout != null)
			{
				this._reportLayoutInfo = this._fieldLayout.TemplateDataRecordCache.GetReportLayoutInfoForRecord(this._record, this._normalizedOffsetFromPanel);
			}
			else
			{
				this._reportLayoutInfo = null;
			}
			return reportLayoutInfo != this._reportLayoutInfo;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0007CA8F File Offset: 0x0007AC8F
		internal void ReleaseCachedDimensions()
		{
			this._cachedDimensions = null;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0007CA98 File Offset: 0x0007AC98
		private void RemoveCellElements()
		{
			global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = this.children;
			for (int i = list.Count - 1; i >= 0; i--)
			{
				global::System.Windows.FrameworkElement frameworkElement = list[i];
				if (!(frameworkElement is global::Infragistics.Windows.DataPresenter.FixedFieldSplitter))
				{
					list.RemoveAt(i);
					base.RemoveVisualChild(frameworkElement);
					base.RemoveLogicalChild(frameworkElement);
				}
			}
			if (this._record != null)
			{
				this._record.InvalidatePeer();
			}
			this._cellElementsDirty = true;
			this.InvalidateLayoutManager();
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x0007CB04 File Offset: 0x0007AD04
		private void RemoveChild(global::System.Windows.FrameworkElement child)
		{
			int num = this.children.IndexOf(child);
			if (num >= 0)
			{
				this.children.RemoveAt(num);
				base.RemoveVisualChild(child);
				base.RemoveLogicalChild(child);
			}
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x0007CB3C File Offset: 0x0007AD3C
		private void RemoveSplitter(ref global::Infragistics.Windows.DataPresenter.FixedFieldSplitter splitter)
		{
			if (splitter != null)
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldSplitter child = splitter;
				splitter = null;
				base.RemoveLogicalChild(child);
				base.RemoveVisualChild(child);
			}
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0007CB64 File Offset: 0x0007AD64
		private bool ReuseCellElements(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> newVirtFields, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> newNonVirtFields)
		{
			if (this._cellElements == null)
			{
				return false;
			}
			if (this._cellElementsDirty)
			{
				return false;
			}
			if (this._record == null && !this._isHeader)
			{
				return false;
			}
			int version = this._fieldLayout.Fields.Version;
			if (version != this._fieldsVersion)
			{
				this.RemoveInvalidFieldElements();
				this._fieldsVersion = version;
			}
			global::System.Windows.Controls.Control[] cellElements = this._cellElements;
			global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
			int cellCount = templateDataRecordCache.GetCellCount();
			this._cellElements = new global::System.Windows.Controls.Control[cellCount];
			this._cellElementMeasureSizes = new global::System.Windows.Size?[cellCount];
			this._allocatedCellCount = cellCount;
			this._cellElementRects = new global::System.Windows.Rect[cellCount];
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			hashSet.AddItems(this._nonVirtualizedFields);
			hashSet.AddItems(this._virtualizedFields);
			foreach (global::Infragistics.Windows.DataPresenter.Field item in newVirtFields)
			{
				hashSet.Remove(item);
			}
			foreach (global::Infragistics.Windows.DataPresenter.Field item2 in newNonVirtFields)
			{
				hashSet.Remove(item2);
			}
			this._virtualizedFields = newVirtFields;
			this._nonVirtualizedFields = newNonVirtFields;
			global::System.Collections.Generic.Dictionary<object, global::System.Collections.Generic.Stack<global::System.Windows.Controls.Control>> dictionary = this._isRecycling ? new global::System.Collections.Generic.Dictionary<object, global::System.Collections.Generic.Stack<global::System.Windows.Controls.Control>>() : null;
			foreach (global::System.Windows.Controls.Control control in cellElements)
			{
				if (control != null)
				{
					global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(control);
					int templateCellIndex = fieldFromControl.TemplateCellIndex;
					bool flag = templateCellIndex < 0 || templateCellIndex >= cellCount || this._cellElements[templateCellIndex] != null || hashSet.Exists(fieldFromControl);
					if (flag)
					{
						if (dictionary == null)
						{
							this.RemoveElement(control);
						}
						else
						{
							object fieldKey = this.GetFieldKey(fieldFromControl);
							global::System.Collections.Generic.Stack<global::System.Windows.Controls.Control> stack;
							if (!dictionary.TryGetValue(fieldKey, out stack))
							{
								stack = (dictionary[fieldKey] = new global::System.Collections.Generic.Stack<global::System.Windows.Controls.Control>());
							}
							stack.Push(control);
						}
					}
					else
					{
						this._cellElements[templateCellIndex] = control;
						this._allocatedCellCount--;
					}
				}
			}
			bool? isMouseOverCellArea = this.IsMouseOverCellArea;
			if (dictionary != null && dictionary.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = this._record as global::Infragistics.Windows.DataPresenter.SummaryRecord;
				for (int j = 0; j < this._cellElements.Length; j++)
				{
					if (this._cellElements[j] == null)
					{
						global::Infragistics.Windows.DataPresenter.Field field = templateDataRecordCache.GetField(j);
						object fieldKey2 = this.GetFieldKey(field);
						global::System.Collections.Generic.Stack<global::System.Windows.Controls.Control> stack2;
						if ((summaryRecord == null || summaryRecord.HasFixedSummaryResults(field)) && !hashSet.Exists(field) && dictionary.TryGetValue(fieldKey2, out stack2))
						{
							global::System.Windows.Controls.Control control2 = stack2.Pop();
							this.InitializeCellElement(control2, field, isMouseOverCellArea);
							this._cellElements[j] = control2;
							this._allocatedCellCount--;
							if (stack2.Count == 0)
							{
								dictionary.Remove(fieldKey2);
								if (dictionary.Count == 0)
								{
									break;
								}
							}
						}
					}
				}
				if (dictionary.Count > 0)
				{
					foreach (global::System.Collections.Generic.Stack<global::System.Windows.Controls.Control> stack3 in dictionary.Values)
					{
						foreach (global::System.Windows.Controls.Control ctrl in stack3)
						{
							this.RemoveElement(ctrl);
						}
					}
				}
			}
			bool useCellPresenters = this._fieldLayout.UseCellPresenters;
			int k = 0;
			int count = newNonVirtFields.Count;
			while (k < count)
			{
				global::Infragistics.Windows.DataPresenter.Field field2 = newNonVirtFields[k];
				int templateCellIndex2 = field2.TemplateCellIndex;
				if (this._cellElements[templateCellIndex2] == null)
				{
					this.CreateCellElement(templateCellIndex2, field2, useCellPresenters, isMouseOverCellArea);
				}
				k++;
			}
			this.InvalidateLayoutManager();
			return true;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0007CF44 File Offset: 0x0007B144
		private void RemoveElement(global::System.Windows.Controls.Control ctrl)
		{
			int num = this.children.IndexOf(ctrl);
			if (num >= 0)
			{
				this.children.RemoveAt(num);
				base.RemoveVisualChild(ctrl);
				base.RemoveLogicalChild(ctrl);
			}
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0007CF7C File Offset: 0x0007B17C
		private void RemoveInvalidFieldElements()
		{
			if (this._cellElements == null)
			{
				return;
			}
			for (int i = 0; i < this._cellElements.Length; i++)
			{
				global::System.Windows.Controls.Control control = this._cellElements[i];
				if (control != null)
				{
					global::Infragistics.Windows.DataPresenter.Field fieldFromControl = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldFromControl(control);
					if (fieldFromControl != null && fieldFromControl.Index < 0)
					{
						this._cellElements[i] = null;
						this.RemoveChild(control);
					}
				}
			}
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x0007CFD4 File Offset: 0x0007B1D4
		internal bool TryGetPreferredExtent(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItem, bool cell, bool width, out double extent)
		{
			extent = 0.0;
			if (((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)fieldLayoutItem).Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataRecordSizingMode recordSizingMode = fieldLayoutItem.RecordSizingMode;
			global::Infragistics.Windows.DataPresenter.Field field = fieldLayoutItem.Field;
			if (!(this._record is global::Infragistics.Windows.DataPresenter.SummaryRecord) && !(this._record is global::Infragistics.Windows.DataPresenter.FilterRecord))
			{
				if ((cell && field.IsCellVirtualized) || (!cell && field.IsLabelVirtualized))
				{
					return false;
				}
				if (cell && !double.IsNaN(field.GetCellHeightResolvedHelper(false)))
				{
					return false;
				}
				if (!cell && !double.IsNaN(field.GetLabelHeightResolvedHelper(false, false)))
				{
					return false;
				}
				switch (recordSizingMode)
				{
				default:
					return false;
				case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndFixed:
				case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndIndividuallySizable:
					break;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner == null || owner.IsHorizontal)
			{
				return false;
			}
			if (!global::Infragistics.Windows.DataPresenter.GridUtilities.IsVariableHeightRecordMode(recordSizingMode))
			{
				return false;
			}
			this.VerifyCellElements();
			int templateCellIndex = field.TemplateCellIndex;
			if (templateCellIndex < 0 || templateCellIndex >= this._cellElements.Length)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = this.GetLayoutManager();
			if (this._record is global::Infragistics.Windows.DataPresenter.FilterRecord && field.IsFilterCellVirtualized)
			{
				global::Infragistics.Windows.DataPresenter.Field filterFieldToMeasure = owner.TemplateDataRecordCache.GetFilterFieldToMeasure(field);
				if (filterFieldToMeasure != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = layoutManager.GetLayoutItem(filterFieldToMeasure, !cell);
					extent = layoutItem.PreferredHeight;
					return true;
				}
			}
			global::System.Windows.FrameworkElement frameworkElement = this._cellElements[templateCellIndex];
			if (frameworkElement == null)
			{
				return false;
			}
			double num = fieldLayoutItem.PreferredWidth;
			if (this._cachedDimensions != null)
			{
				global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = layoutManager.LayoutItems.GetConstraint(fieldLayoutItem) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint;
				if (gridBagConstraint != null && gridBagConstraint.Column + gridBagConstraint.ColumnSpan < this._cachedDimensions.ColumnDims.Length)
				{
					double num2 = this._cachedDimensions.ColumnDims[gridBagConstraint.Column + gridBagConstraint.ColumnSpan] - this._cachedDimensions.ColumnDims[gridBagConstraint.Column];
					if (!global::Infragistics.CoreUtilities.AreClose(num, num2))
					{
						num = num2;
					}
				}
			}
			global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenterBase = frameworkElement as global::Infragistics.Windows.DataPresenter.CellPresenterBase;
			if (cellPresenterBase != null)
			{
				cellPresenterBase.VerifyLayoutElements();
			}
			bool flag = global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.IsInAutoSizeMode(field, !cell, width);
			if (flag)
			{
				extent = this.TryGetPreferredExtentImpl(fieldLayoutItem, new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity), frameworkElement, templateCellIndex, width);
				if (global::Infragistics.CoreUtilities.LessThanOrClose(extent, num))
				{
					return true;
				}
			}
			global::System.Windows.Size newSize = new global::System.Windows.Size(num, double.PositiveInfinity);
			extent = this.TryGetPreferredExtentImpl(fieldLayoutItem, newSize, frameworkElement, templateCellIndex, width);
			return true;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x0007D210 File Offset: 0x0007B410
		private double TryGetPreferredExtentImpl(global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItem, global::System.Windows.Size newSize, global::System.Windows.FrameworkElement element, int templateIndex, bool width)
		{
			this._cellElementMeasureSizes[templateIndex] = new global::System.Windows.Size?(newSize);
			element.Measure(newSize);
			global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenterBase = element as global::Infragistics.Windows.DataPresenter.CellPresenterBase;
			global::System.Windows.Size size;
			if (cellPresenterBase != null)
			{
				global::System.Windows.FrameworkElement child = cellPresenterBase.GetChild(fieldLayoutItem.IsLabel);
				if (child != null)
				{
					size = child.DesiredSize;
				}
				else
				{
					size = default(global::System.Windows.Size);
				}
			}
			else
			{
				size = element.DesiredSize;
			}
			if (!width)
			{
				return size.Height;
			}
			return size.Width;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x0007D284 File Offset: 0x0007B484
		private void VerifyCellsInView(global::System.Windows.Size elementSize)
		{
			bool requiresAsynchMeasureInvalidation = this._requiresAsynchMeasureInvalidation;
			this._requiresAsynchMeasureInvalidation = false;
			if (this._fieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			global::System.Windows.Rect clipRect = this.GetClipRect(elementSize);
			this._lastClipRect = clipRect;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> virtualizedFields = this.VirtualizedFields;
			if (virtualizedFields.Count == 0)
			{
				if (this._reportLayoutInfo != null || this._usingFixedInfo || (dataPresenter != null && dataPresenter.ShouldRaiseCellsInViewChanged))
				{
					this.WireLayouUpdatedEvent();
				}
				return;
			}
			bool isHorizontal = this._fieldLayout.IsHorizontal;
			if (this._record == null && !this._isHeader)
			{
				return;
			}
			if (this._cellElements == null)
			{
				return;
			}
			this.WireLayouUpdatedEvent();
			bool flag = false;
			double num = 0.0;
			bool flag2 = clipRect.Width <= 0.0 && clipRect.Height <= 0.0;
			if (flag2 && this._allocatedCellCount == this._cellElements.Length)
			{
				return;
			}
			global::System.Windows.Controls.Control[] cellElements = this._cellElements;
			bool? isMouseOverCellArea = this.IsMouseOverCellArea;
			bool isVerifyingCells = this._isVerifyingCells;
			this._isVerifyingCells = true;
			bool usingFixedInfo = this._usingFixedInfo;
			global::System.Windows.Rect rect = clipRect;
			if (usingFixedInfo && !rect.IsEmpty)
			{
				if (isHorizontal)
				{
					rect.Y += this._fixedNearRect.Height;
					rect.Height = global::System.Math.Max(clipRect.Height - (this._fixedNearRect.Height + this._fixedFarRect.Height), 0.0);
				}
				else
				{
					rect.X += this._fixedNearRect.Width;
					rect.Width = global::System.Math.Max(clipRect.Width - (this._fixedNearRect.Width + this._fixedFarRect.Width), 0.0);
				}
			}
			try
			{
				int count = virtualizedFields.Count;
				global::System.Collections.Generic.LinkedList<global::System.Windows.Controls.Control> linkedList = null;
				global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
				bool flag3 = this._isHeader && !isHorizontal;
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = virtualizedFields[i];
					int templateCellIndex = field.TemplateCellIndex;
					global::System.Windows.Controls.Control control = cellElements[templateCellIndex];
					if (!flag2 || control != null)
					{
						global::System.Windows.Rect rect2 = this._cellElementRects[templateCellIndex];
						if (flag3)
						{
							num = global::System.Math.Max(num, rect2.Bottom);
						}
						global::System.Windows.Rect rect3 = clipRect;
						if (usingFixedInfo && field.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
						{
							rect3 = rect;
						}
						bool flag4 = rect2.IntersectsWith(rect3);
						if (!flag4 && control != null && global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(control).IntersectsWith(clipRect))
						{
							flag4 = true;
						}
						if (!flag4)
						{
							if (control == null)
							{
								goto IL_2B7;
							}
							if (!this._positionAllAllocatedCells)
							{
								if (this._isRecycling && !control.IsKeyboardFocusWithin)
								{
									if (linkedList == null)
									{
										linkedList = new global::System.Collections.Generic.LinkedList<global::System.Windows.Controls.Control>();
									}
									linkedList.AddLast(control);
									goto IL_2B7;
								}
								goto IL_2B7;
							}
						}
						list.Add(i);
					}
					IL_2B7:;
				}
				int j = 0;
				int count2 = list.Count;
				while (j < count2)
				{
					int index = list[j];
					global::Infragistics.Windows.DataPresenter.Field field2 = virtualizedFields[index];
					int templateCellIndex2 = field2.TemplateCellIndex;
					global::System.Windows.Rect rect4 = this._cellElementRects[templateCellIndex2];
					if (cellElements[templateCellIndex2] == null)
					{
						if (this._isRecycling && linkedList != null)
						{
							for (global::System.Collections.Generic.LinkedListNode<global::System.Windows.Controls.Control> linkedListNode = linkedList.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
							{
								global::Infragistics.Windows.DataPresenter.Field field3 = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.GetField(linkedListNode.Value);
								if (object.Equals(this.GetFieldKey(field3), this.GetFieldKey(field2)))
								{
									int templateCellIndex3 = field3.TemplateCellIndex;
									global::System.Windows.Controls.Control control2 = cellElements[templateCellIndex3];
									cellElements[templateCellIndex2] = control2;
									cellElements[templateCellIndex3] = null;
									this.InitializeCellElement(control2, field2, isMouseOverCellArea);
									control2.InvalidateMeasure();
									control2.InvalidateArrange();
									linkedList.Remove(linkedListNode);
									break;
								}
							}
						}
						if (cellElements[templateCellIndex2] == null)
						{
							this.CreateCellElement(templateCellIndex2, field2, this._fieldLayout.UseCellPresenters, isMouseOverCellArea);
						}
					}
					global::System.Windows.Controls.Control control3 = cellElements[templateCellIndex2];
					rect4 = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.ConstrainCellRectBottom(rect4, elementSize.Height);
					if (control3 != null)
					{
						if (control3 is global::Infragistics.Windows.DataPresenter.CellPresenterBase)
						{
							this.InitializeCellPresenterRects(control3);
						}
						if (usingFixedInfo)
						{
							control3.CoerceValue(global::System.Windows.UIElement.ClipProperty);
						}
						this._cellElementMeasureSizes[templateCellIndex2] = new global::System.Windows.Size?(rect4.Size);
						control3.Measure(rect4.Size);
						control3.Arrange(rect4);
					}
					j++;
				}
			}
			finally
			{
				this._isVerifyingCells = isVerifyingCells;
			}
			if (this._isHeader && !isHorizontal && !requiresAsynchMeasureInvalidation)
			{
				this._requiresAsynchMeasureInvalidation = (flag || (num > 0.0 && num < elementSize.Height));
			}
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x0007D730 File Offset: 0x0007B930
		internal void VerifyCellElements()
		{
			this.VerifyFieldLists();
			if (this._cellElementsDirty)
			{
				this.RemoveCellElements();
				this._cellElementsDirty = false;
				global::Infragistics.Windows.DataPresenter.Record record = this._record;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayout;
				if (fieldLayout == null)
				{
					return;
				}
				if (record != null || this._isHeader)
				{
					this._fieldsVersion = fieldLayout.Fields.Version;
					int cellCount = fieldLayout.TemplateDataRecordCache.GetCellCount();
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> nonVirtualizedFields = this.NonVirtualizedFields;
					if (this._fieldLayout == null || this._fieldLayout != fieldLayout || this._cellElementsDirty || nonVirtualizedFields == null)
					{
						return;
					}
					this._cellElements = new global::System.Windows.Controls.Control[cellCount];
					this._allocatedCellCount = cellCount;
					this._cellElementRects = new global::System.Windows.Rect[cellCount];
					this._cellElementMeasureSizes = new global::System.Windows.Size?[cellCount];
					this._lastLayoutContainerRect = null;
					bool useCellPresenters = fieldLayout.UseCellPresenters;
					bool? isMouseOverCellArea = this.IsMouseOverCellArea;
					int i = 0;
					int count = nonVirtualizedFields.Count;
					while (i < count)
					{
						global::Infragistics.Windows.DataPresenter.Field field = nonVirtualizedFields[i];
						this.CreateCellElement(field.TemplateCellIndex, field, useCellPresenters, isMouseOverCellArea);
						i++;
					}
				}
			}
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x0007D83A File Offset: 0x0007BA3A
		private void VerifyClipRect()
		{
			if (this.HasClipRectChanged())
			{
				base.InvalidateArrange();
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x0007D84C File Offset: 0x0007BA4C
		private void VerifyFieldLists()
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> virtualizedFields = this._virtualizedFields;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> nonVirtualizedFields = this._nonVirtualizedFields;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> list2;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> list;
			if (this._fieldLayout == null)
			{
				list = (list2 = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.EmptyFields);
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
				if (templateDataRecordCache.CacheVersion == this._templateCacheVersion)
				{
					return;
				}
				this._templateCacheVersion = templateDataRecordCache.CacheVersion;
				if (!this._isHeader && this._record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
				{
					list2 = new global::Infragistics.Windows.DataPresenter.Field[0];
					list = templateDataRecordCache.AllFields;
				}
				else if (this._isHeader)
				{
					list = templateDataRecordCache.NonVirtualizedLabelFields;
					list2 = templateDataRecordCache.VirtualizedLabelFields;
				}
				else if (this._record is global::Infragistics.Windows.DataPresenter.FilterRecord)
				{
					list = templateDataRecordCache.NonVirtualizedFilterCellFields;
					list2 = templateDataRecordCache.VirtualizedFilterCellFields;
				}
				else
				{
					list = templateDataRecordCache.NonVirtualizedCellFields;
					list2 = templateDataRecordCache.VirtualizedCellFields;
				}
			}
			bool flag = this._fieldLayout != null && (this._cellElements == null || global::Infragistics.Windows.DataPresenter.GridUtilities.GetCount(this._cellElements) != this._fieldLayout.TemplateDataRecordCache.GetCellCount());
			if (!flag)
			{
				flag = (!global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(virtualizedFields, list2) || !global::Infragistics.Windows.DataPresenter.GridUtilities.CompareLists(nonVirtualizedFields, list));
			}
			if (flag)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = this._fieldLayout.StyleGenerator;
				bool flag2 = false;
				if (styleGenerator != null)
				{
					if (styleGenerator.TemplateVersion != this._generatorTemplateVersion)
					{
						this._generatorTemplateVersion = styleGenerator.TemplateVersion;
					}
					else if (this._cellElements != null)
					{
						flag2 = true;
					}
				}
				if (flag2 && this.ReuseCellElements(list2, list))
				{
					return;
				}
				this._virtualizedFields = list2;
				this._nonVirtualizedFields = list;
				this._cellElementsDirty = true;
			}
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x0007D9D0 File Offset: 0x0007BBD0
		private void VerifyFixedFieldOffsets()
		{
			global::System.Windows.Vector vector = default(global::System.Windows.Vector);
			global::System.Windows.Vector vector2 = default(global::System.Windows.Vector);
			double prePostPanelSpacing = double.NaN;
			if (this._fieldLayout != null)
			{
				bool isHorizontal = this._fieldLayout.IsHorizontal;
				double num = (double)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldOffsetProperty);
				double num2 = (double)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldExtentProperty);
				double num3 = (double)base.GetValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldViewportExtentProperty);
				if (num3 < num2 && this._containingRp != null)
				{
					double num4 = isHorizontal ? base.ActualHeight : base.ActualWidth;
					double num5 = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CalculateFixedRecordAreaEdge(isHorizontal, 0.0, this._containingRp, this._isHeader ? null : this._record, this, this._isHeader);
					global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
					num5 += templateDataRecordCache.GetVirtPanelOffset(true, true);
					global::Infragistics.Windows.DataPresenter.RecordCellAreaBase recordCellAreaBase = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), true) as global::Infragistics.Windows.DataPresenter.RecordCellAreaBase;
					if (recordCellAreaBase != null)
					{
						global::System.Windows.FrameworkElement frameworkElement;
						if (this._fieldLayout.RecordSelectorLocationResolved == global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.None)
						{
							frameworkElement = recordCellAreaBase;
						}
						else
						{
							frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(recordCellAreaBase) as global::System.Windows.FrameworkElement);
						}
						if (frameworkElement != null)
						{
							global::System.Windows.Thickness margin = frameworkElement.Margin;
							if (isHorizontal)
							{
								num5 += margin.Top;
							}
							else
							{
								num5 += margin.Left;
							}
						}
					}
					prePostPanelSpacing = num5;
					double num6 = global::System.Math.Min(num2, num4 + num5);
					double num7 = -global::System.Math.Min(num4, global::System.Math.Max(num6 - num3 - num, 0.0));
					if (isHorizontal)
					{
						vector2.Y = num7;
					}
					else
					{
						vector2.X = num7;
					}
				}
				if (isHorizontal)
				{
					vector.Y = num;
				}
				else
				{
					vector.X = num;
				}
			}
			bool flag = this._fixedNearOffset != vector || this._fixedFarOffset != vector2;
			this._prePostPanelSpacing = prePostPanelSpacing;
			if (flag)
			{
				this._fixedNearOffset = vector;
				this._fixedFarOffset = vector2;
				this._lastLayoutContainerRect = null;
				base.InvalidateArrange();
			}
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0007DBC8 File Offset: 0x0007BDC8
		private void VerifyFixedState()
		{
			global::Infragistics.Windows.DataPresenter.RecordCellAreaBase recordCellAreaBase = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase), true) as global::Infragistics.Windows.DataPresenter.RecordCellAreaBase;
			if (this._containingCellArea != recordCellAreaBase)
			{
				this._containingCellArea = recordCellAreaBase;
				if (recordCellAreaBase is global::Infragistics.Windows.DataPresenter.DataRecordCellArea)
				{
					this._recordMouseOverTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._containingCellArea, "IsMouseOver", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnRecordMouseOverChanged));
				}
				else
				{
					this._recordMouseOverTracker = null;
				}
			}
			global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldLayoutInfo = (this._fieldLayout != null) ? this._fieldLayout.GetFixedFieldInfo(true) : null;
			if (fixedFieldLayoutInfo != null)
			{
				bool usingFixedInfo = this._usingFixedInfo;
				this._usingFixedInfo = (fixedFieldLayoutInfo.HasFixedFields || fixedFieldLayoutInfo.HasFixableFields);
				if (usingFixedInfo != this._usingFixedInfo)
				{
					this._lastLayoutContainerRect = null;
					if (!this._usingFixedInfo)
					{
						if (this._cellElements != null)
						{
							foreach (global::System.Windows.Controls.Control control in this._cellElements)
							{
								if (control != null)
								{
									control.CoerceValue(global::System.Windows.UIElement.ClipProperty);
								}
							}
						}
						base.ClearValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldInfoProperty);
					}
					else if (this._usingFixedInfo)
					{
						this._containingRp = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this._containingCellArea ?? this, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
						if (this._containingRp == null)
						{
							global::System.Windows.Data.RelativeSource relativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), 1);
							base.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldInfoProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
						}
						else
						{
							base.SetBinding(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldInfoProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty, global::System.Windows.Data.BindingMode.OneWay, this._containingRp));
						}
					}
				}
				if (this._isHeader && this._containingRp == null && this.FieldLayout != null)
				{
					this._containingRp = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this._containingCellArea ?? this, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				}
			}
			if (fixedFieldLayoutInfo != null && fixedFieldLayoutInfo.IncludeSplitterElements)
			{
				this.InitializeSplitter(ref this._nearSplitter, global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Near, fixedFieldLayoutInfo.NearSplitterVisibility, fixedFieldLayoutInfo.IsNearSplitterEnabled);
				this.InitializeSplitter(ref this._farSplitter, global::Infragistics.Windows.DataPresenter.FixedFieldSplitterType.Far, fixedFieldLayoutInfo.FarSplitterVisibility, fixedFieldLayoutInfo.IsFarSplitterEnabled);
				return;
			}
			this.RemoveSplitter(ref this._nearSplitter);
			this.RemoveSplitter(ref this._farSplitter);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x0007DDE8 File Offset: 0x0007BFE8
		private void VerifyAutoSizeFields()
		{
			if (this._fieldLayout != null)
			{
				bool flag = this._lastAutoSizeElementVersion != this._cellElementVersion;
				this._lastAutoSizeElementVersion = this._cellElementVersion;
				if (flag && !this._isHeader)
				{
					this._fieldLayout.AutoSizeInfo.OnCellPanelChange(this);
				}
			}
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0007DE38 File Offset: 0x0007C038
		private void VerifyPropertyDescriptorProvider()
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = dataRecord.PropertyDescriptorProvider;
				if (propertyDescriptorProvider != null)
				{
					propertyDescriptorProvider.VerifyFieldDescriptors();
				}
			}
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x0007DE64 File Offset: 0x0007C064
		private void WireLayouUpdatedEvent()
		{
			if (!base.IsVisible && base.DataContext == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (this._fieldLayout != null) ? this._fieldLayout.DataPresenter : null;
			if (dataPresenterBase != null)
			{
				dataPresenterBase.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
			}
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x0007DEAE File Offset: 0x0007C0AE
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				this.InvalidateLayoutManager();
				base.InvalidateMeasure();
				return true;
			}
			return false;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x0007DED1 File Offset: 0x0007C0D1
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			return (global::System.Windows.Rect)containerContext;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0007DEDC File Offset: 0x0007C0DC
		void global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = item as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
			if (fieldLayoutItemBase != null)
			{
				int templateCellIndex = fieldLayoutItemBase.Field.TemplateCellIndex;
				if (templateCellIndex >= 0)
				{
					this.AdjustCellRect(fieldLayoutItemBase.FixedLocation, ref rect);
					this._cellElementRects[templateCellIndex] = rect;
				}
			}
		}

		// Token: 0x04000BBF RID: 3007
		private global::System.Windows.Controls.Control[] _cellElements;

		// Token: 0x04000BC0 RID: 3008
		private int _allocatedCellCount;

		// Token: 0x04000BC1 RID: 3009
		private bool _positionAllAllocatedCells;

		// Token: 0x04000BC2 RID: 3010
		private global::System.Windows.Rect _lastClipRect;

		// Token: 0x04000BC3 RID: 3011
		private bool _isAutoFitInitialized;

		// Token: 0x04000BC4 RID: 3012
		private bool _cellElementsDirty = true;

		// Token: 0x04000BC5 RID: 3013
		private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> children = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();

		// Token: 0x04000BC6 RID: 3014
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000BC7 RID: 3015
		private bool _isHeader;

		// Token: 0x04000BC8 RID: 3016
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000BC9 RID: 3017
		private bool _isVerifyingCells;

		// Token: 0x04000BCA RID: 3018
		private bool _isRecycling;

		// Token: 0x04000BCB RID: 3019
		private bool _requiresAsynchMeasureInvalidation;

		// Token: 0x04000BCC RID: 3020
		private global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo _reportLayoutInfo;

		// Token: 0x04000BCD RID: 3021
		private double? _normalizedOffsetFromPanel;

		// Token: 0x04000BCE RID: 3022
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _recordLayoutManager;

		// Token: 0x04000BCF RID: 3023
		private global::System.Windows.Rect[] _cellElementRects;

		// Token: 0x04000BD0 RID: 3024
		private global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer _cellPresenterRectContainer;

		// Token: 0x04000BD1 RID: 3025
		private global::Infragistics.Windows.DataPresenter.FixedFieldSplitter _nearSplitter;

		// Token: 0x04000BD2 RID: 3026
		private global::Infragistics.Windows.DataPresenter.FixedFieldSplitter _farSplitter;

		// Token: 0x04000BD3 RID: 3027
		private global::System.Windows.Vector _nearSplitterOffset;

		// Token: 0x04000BD4 RID: 3028
		private global::System.Windows.Vector _farSplitterOffset;

		// Token: 0x04000BD5 RID: 3029
		private global::System.Windows.Vector _fixedNearOffset;

		// Token: 0x04000BD6 RID: 3030
		private global::System.Windows.Vector _fixedFarOffset;

		// Token: 0x04000BD7 RID: 3031
		private global::System.Windows.Rect _scrollableClipRect;

		// Token: 0x04000BD8 RID: 3032
		private bool _usingFixedInfo;

		// Token: 0x04000BD9 RID: 3033
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _containingRp;

		// Token: 0x04000BDA RID: 3034
		private global::System.Windows.Rect _fixedNearRect;

		// Token: 0x04000BDB RID: 3035
		private global::System.Windows.Rect _fixedFarRect;

		// Token: 0x04000BDC RID: 3036
		private global::Infragistics.Windows.DataPresenter.RecordCellAreaBase _containingCellArea;

		// Token: 0x04000BDD RID: 3037
		private global::System.Windows.Vector _fixedNearAdjustment;

		// Token: 0x04000BDE RID: 3038
		private global::System.Windows.Vector _fixedFarAdjustment;

		// Token: 0x04000BDF RID: 3039
		private double _prePostPanelSpacing;

		// Token: 0x04000BE0 RID: 3040
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection _cachedDimensions;

		// Token: 0x04000BE1 RID: 3041
		private global::System.Windows.Size _lastMeasureSize;

		// Token: 0x04000BE2 RID: 3042
		private static readonly global::Infragistics.Windows.DataPresenter.Field[] EmptyFields = new global::Infragistics.Windows.DataPresenter.Field[0];

		// Token: 0x04000BE3 RID: 3043
		private int _templateCacheVersion;

		// Token: 0x04000BE4 RID: 3044
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> _virtualizedFields = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.EmptyFields;

		// Token: 0x04000BE5 RID: 3045
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> _nonVirtualizedFields = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.EmptyFields;

		// Token: 0x04000BE6 RID: 3046
		private int _generatorTemplateVersion = -1;

		// Token: 0x04000BE7 RID: 3047
		private int _fieldsVersion = -1;

		// Token: 0x04000BE8 RID: 3048
		private int _cellElementVersion;

		// Token: 0x04000BE9 RID: 3049
		private int _lastAutoSizeElementVersion;

		// Token: 0x04000BEA RID: 3050
		private global::System.Windows.Rect _lastFieldsInViewClipRect;

		// Token: 0x04000BEB RID: 3051
		private global::System.Windows.Size?[] _cellElementMeasureSizes;

		// Token: 0x04000BEC RID: 3052
		private global::Infragistics.Windows.Internal.PropertyValueTracker _recordMouseOverTracker;

		// Token: 0x04000BED RID: 3053
		private global::System.Windows.Rect? _lastLayoutContainerRect;

		// Token: 0x04000BEE RID: 3054
		private int _lastLayoutContainerCount;

		// Token: 0x04000BEF RID: 3055
		private global::System.WeakReference _lastLayoutManager;

		// Token: 0x04000BF0 RID: 3056
		internal bool IsPerformingAutoSizeMeasure;

		// Token: 0x04000BF1 RID: 3057
		private global::System.Windows.Size? _lastDPMeasureSize;

		// Token: 0x04000BF2 RID: 3058
		private static readonly global::System.Windows.DependencyProperty AutoFitHeightProperty = global::System.Windows.DependencyProperty.Register("AutoFitHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnAutoFitWidthHeightChanged)));

		// Token: 0x04000BF3 RID: 3059
		private static readonly global::System.Windows.DependencyProperty AutoFitWidthProperty = global::System.Windows.DependencyProperty.Register("AutoFitWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnAutoFitWidthHeightChanged)));

		// Token: 0x04000BF4 RID: 3060
		internal static readonly global::System.Windows.DependencyProperty FixedFieldExtentProperty = global::System.Windows.DependencyProperty.Register("FixedFieldExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000BF5 RID: 3061
		internal static readonly global::System.Windows.DependencyProperty FixedFieldInfoProperty = global::System.Windows.DependencyProperty.Register("FixedFieldInfo", typeof(global::Infragistics.Windows.DataPresenter.FixedFieldInfo), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnFixedFieldInfoChanged)));

		// Token: 0x04000BF6 RID: 3062
		internal static readonly global::System.Windows.DependencyProperty FixedFieldOffsetProperty = global::System.Windows.DependencyProperty.Register("FixedFieldOffset", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000BF7 RID: 3063
		internal static readonly global::System.Windows.DependencyProperty FixedFieldViewportExtentProperty = global::System.Windows.DependencyProperty.Register("FixedFieldViewportExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000BF8 RID: 3064
		internal static readonly global::System.Windows.DependencyProperty GridColumnWidthVersionProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.GridColumnWidthVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnGridColumnWidthVersionChanged)));

		// Token: 0x04000BF9 RID: 3065
		private static global::System.Windows.DependencyProperty GridMeasureVersionProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GridMeasureVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnGridMeasureVersionChanged)));

		// Token: 0x04000BFA RID: 3066
		internal static readonly global::System.Windows.DependencyProperty ScrollVersionProperty = global::System.Windows.DependencyProperty.Register("ScrollVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnScrollVersionChanged)));

		// Token: 0x04000BFB RID: 3067
		internal static readonly global::System.Windows.DependencyProperty TemplateVersionProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.TemplateVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnTemplateVersionChanged)));

		// Token: 0x04000BFC RID: 3068
		private global::System.Windows.Controls.Control _childBeingInitialized;
	}
}
