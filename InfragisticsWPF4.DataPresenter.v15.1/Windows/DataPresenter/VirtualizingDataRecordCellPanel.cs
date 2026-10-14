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
	// Token: 0x02000238 RID: 568
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class VirtualizingDataRecordCellPanel : global::System.Windows.FrameworkElement, global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060020C2 RID: 8386 RVA: 0x0008E4A8 File Offset: 0x0008C6A8
		static VirtualizingDataRecordCellPanel()
		{
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnDataContextChanged)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnRequestBringIntoView));
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x0008E76C File Offset: 0x0008C96C
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

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0008E7D8 File Offset: 0x0008C9D8
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x0008E7EA File Offset: 0x0008C9EA
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

		// Token: 0x060020C6 RID: 8390 RVA: 0x0008E800 File Offset: 0x0008CA00
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

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0008E8A1 File Offset: 0x0008CAA1
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x0008E8B3 File Offset: 0x0008CAB3
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

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x0008E8C8 File Offset: 0x0008CAC8
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

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x0008E994 File Offset: 0x0008CB94
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

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0008E9AF File Offset: 0x0008CBAF
		internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter FarSplitter
		{
			get
			{
				return this._farSplitter;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x0008E9B7 File Offset: 0x0008CBB7
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x0008E9C0 File Offset: 0x0008CBC0
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

		// Token: 0x060020CE RID: 8398 RVA: 0x0008EA7C File Offset: 0x0008CC7C
		private static void OnFixedFieldOffsetsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)d;
			virtualizingDataRecordCellPanel.VerifyFixedFieldOffsets();
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0008EA98 File Offset: 0x0008CC98
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

		// Token: 0x060020D0 RID: 8400 RVA: 0x0008EB0C File Offset: 0x0008CD0C
		private static void OnGridColumnWidthVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel)d;
			if (virtualizingDataRecordCellPanel._fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = virtualizingDataRecordCellPanel._fieldLayout.DataPresenter;
				if (dataPresenter == null || (!dataPresenter.IsSynchronousControl && !dataPresenter.IsProcessingFieldAutoSize))
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

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x0008EB5B File Offset: 0x0008CD5B
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x0008EB6D File Offset: 0x0008CD6D
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

		// Token: 0x060020D3 RID: 8403 RVA: 0x0008EB80 File Offset: 0x0008CD80
		private static void OnGridMeasureVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = d as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			virtualizingDataRecordCellPanel.OnGridMeasureVersionChanged();
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0008EB9C File Offset: 0x0008CD9C
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

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x0008EC7F File Offset: 0x0008CE7F
		private bool IsFieldLayoutDisposed
		{
			get
			{
				return this._fieldLayout != null && this._fieldLayout.WasRemovedFromCollection;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x0008EC96 File Offset: 0x0008CE96
		internal bool IsHeaderArea
		{
			get
			{
				return this._isHeader;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x0008ECA0 File Offset: 0x0008CEA0
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

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0008ECE4 File Offset: 0x0008CEE4
		private bool IsNestedFixedHeader
		{
			get
			{
				return this._isHeader && this._containingRp != null && this._containingRp.Record != null && this._containingRp.Record.ParentRecord != null;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060020D9 RID: 8409 RVA: 0x0008ED1B File Offset: 0x0008CF1B
		// (set) Token: 0x060020DA RID: 8410 RVA: 0x0008ED2D File Offset: 0x0008CF2D
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

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060020DB RID: 8411 RVA: 0x0008ED44 File Offset: 0x0008CF44
		internal global::Infragistics.Windows.DataPresenter.FixedFieldSplitter NearSplitter
		{
			get
			{
				return this._nearSplitter;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x0008ED4C File Offset: 0x0008CF4C
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> NonVirtualizedFields
		{
			get
			{
				this.VerifyFieldLists();
				return this._nonVirtualizedFields;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x0008ED5A File Offset: 0x0008CF5A
		internal global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x0008ED62 File Offset: 0x0008CF62
		internal global::System.Windows.Rect ScrollableAreaRect
		{
			get
			{
				return this._scrollableClipRect;
			}
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x0008ED6C File Offset: 0x0008CF6C
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
				global::Infragistics.Windows.DataPresenter.Record record = (virtualizingDataRecordCellPanel._record is global::Infragistics.Windows.DataPresenter.SummaryRecord && ((global::Infragistics.Windows.DataPresenter.SummaryRecord)virtualizingDataRecordCellPanel._record).SummaryDisplayAreaContext.IsGroupByRecordSummaries) ? virtualizingDataRecordCellPanel._record.ParentRecord : virtualizingDataRecordCellPanel._record;
				if (virtualizingDataRecordCellPanel._isHeader || (record != null && !record.HasCollapsedAncestor))
				{
					virtualizingDataRecordCellPanel.WireLayouUpdatedEvent();
				}
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x0008EDFD File Offset: 0x0008CFFD
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x0008EE0F File Offset: 0x0008D00F
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

		// Token: 0x060020E2 RID: 8418 RVA: 0x0008EE24 File Offset: 0x0008D024
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

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x0008EE67 File Offset: 0x0008D067
		// (set) Token: 0x060020E4 RID: 8420 RVA: 0x0008EE79 File Offset: 0x0008D079
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

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060020E5 RID: 8421 RVA: 0x0008EE8C File Offset: 0x0008D08C
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> VirtualizedFields
		{
			get
			{
				this.VerifyFieldLists();
				return this._virtualizedFields;
			}
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0008EE9C File Offset: 0x0008D09C
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

		// Token: 0x060020E7 RID: 8423 RVA: 0x0008F69C File Offset: 0x0008D89C
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

		// Token: 0x060020E8 RID: 8424 RVA: 0x0008F704 File Offset: 0x0008D904
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

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0008F9CC File Offset: 0x0008DBCC
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

		// Token: 0x060020EA RID: 8426 RVA: 0x0008FA38 File Offset: 0x0008DC38
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

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x0008FB18 File Offset: 0x0008DD18
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

		// Token: 0x060020EC RID: 8428 RVA: 0x0008FB4A File Offset: 0x0008DD4A
		private void AddChild(global::System.Windows.FrameworkElement child)
		{
			base.AddLogicalChild(child);
			this.children.Add(child);
			base.AddVisualChild(child);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x0008FB68 File Offset: 0x0008DD68
		internal void AdjustCellRect(global::Infragistics.Windows.DataPresenter.FixedFieldLocation location, ref global::System.Windows.Rect rect)
		{
			if (this._usingFixedInfo)
			{
				global::System.Windows.Vector fixedAreaOffset = this.GetFixedAreaOffset(location, true);
				rect.Offset(fixedAreaOffset);
			}
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x0008FB90 File Offset: 0x0008DD90
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

		// Token: 0x060020EF RID: 8431 RVA: 0x0008FC04 File Offset: 0x0008DE04
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

		// Token: 0x060020F0 RID: 8432 RVA: 0x0008FCC4 File Offset: 0x0008DEC4
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

		// Token: 0x060020F1 RID: 8433 RVA: 0x0008FD2C File Offset: 0x0008DF2C
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

		// Token: 0x060020F2 RID: 8434 RVA: 0x0008FD70 File Offset: 0x0008DF70
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

		// Token: 0x060020F3 RID: 8435 RVA: 0x0008FEF0 File Offset: 0x0008E0F0
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

		// Token: 0x060020F4 RID: 8436 RVA: 0x0008FFD4 File Offset: 0x0008E1D4
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
						num += fieldLayout.GetRecordSelectorExtent(rp.Record);
					}
					break;
				case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea:
				case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.RightOfCellArea:
					if (!isHorizontal)
					{
						num += fieldLayout.GetRecordSelectorExtent(rp.Record);
					}
					break;
				}
			}
			return num;
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000901DC File Offset: 0x0008E3DC
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

		// Token: 0x060020F6 RID: 8438 RVA: 0x00090240 File Offset: 0x0008E440
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

		// Token: 0x060020F7 RID: 8439 RVA: 0x000904D8 File Offset: 0x0008E6D8
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

		// Token: 0x060020F8 RID: 8440 RVA: 0x000907B3 File Offset: 0x0008E9B3
		private static global::System.Windows.Rect ConstrainCellRectBottom(global::System.Windows.Rect rect, double height)
		{
			if (rect.Bottom > height)
			{
				rect.Height = global::System.Math.Max(height - rect.Top, 1.0);
			}
			return rect;
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000907E0 File Offset: 0x0008E9E0
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

		// Token: 0x060020FA RID: 8442 RVA: 0x00090882 File Offset: 0x0008EA82
		[global::System.Diagnostics.Conditional("DEBUG_MEASURE_ARRANGE")]
		private static void DebugArrange(object value, string category)
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00090884 File Offset: 0x0008EA84
		internal void DirtyCellElements(bool invalidateMeasureAndArrange)
		{
			this.RemoveCellElements();
			if (invalidateMeasureAndArrange)
			{
				base.InvalidateMeasure();
				base.InvalidateArrange();
			}
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x0009089C File Offset: 0x0008EA9C
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

		// Token: 0x060020FD RID: 8445 RVA: 0x00090AF4 File Offset: 0x0008ECF4
		internal void EnsureCellIsCreated(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this.EnsureCellIsCreated(cell.Field, this.IsMouseOverCellArea);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00090B0C File Offset: 0x0008ED0C
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

		// Token: 0x060020FF RID: 8447 RVA: 0x00090BB0 File Offset: 0x0008EDB0
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

		// Token: 0x06002100 RID: 8448 RVA: 0x00090CF8 File Offset: 0x0008EEF8
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

		// Token: 0x06002101 RID: 8449 RVA: 0x00090D2E File Offset: 0x0008EF2E
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VirtualCellInfo> GetCellInfo(bool includeInViewOnly)
		{
			return this.GetCellInfo(includeInViewOnly, true, true);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00090D3C File Offset: 0x0008EF3C
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

		// Token: 0x06002103 RID: 8451 RVA: 0x00090E80 File Offset: 0x0008F080
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> GetFieldsInView()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			global::System.Windows.Rect clipRect = this.GetClipRect(base.RenderSize);
			this._lastFieldsInViewClipRect = clipRect;
			if (this._fieldLayout != null && this._cellElementRects != null)
			{
				int num = this._cellElementRects.Length;
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.GetAllFields(false))
				{
					int templateCellIndex = field.TemplateCellIndex;
					if (templateCellIndex >= 0 && templateCellIndex < num)
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

		// Token: 0x06002104 RID: 8452 RVA: 0x00090F48 File Offset: 0x0008F148
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

		// Token: 0x06002105 RID: 8453 RVA: 0x0009105C File Offset: 0x0008F25C
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

		// Token: 0x06002106 RID: 8454 RVA: 0x000910AC File Offset: 0x0008F2AC
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

		// Token: 0x06002107 RID: 8455 RVA: 0x000910D9 File Offset: 0x0008F2D9
		private global::System.Windows.Rect GetClipRect(global::System.Windows.Size currentElementSize)
		{
			return this.GetClipRect(currentElementSize, false);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000910E4 File Offset: 0x0008F2E4
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

		// Token: 0x06002109 RID: 8457 RVA: 0x000911B8 File Offset: 0x0008F3B8
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

		// Token: 0x0600210A RID: 8458 RVA: 0x00091218 File Offset: 0x0008F418
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

		// Token: 0x0600210B RID: 8459 RVA: 0x00091252 File Offset: 0x0008F452
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

		// Token: 0x0600210C RID: 8460 RVA: 0x00091280 File Offset: 0x0008F480
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

		// Token: 0x0600210D RID: 8461 RVA: 0x000913B8 File Offset: 0x0008F5B8
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

		// Token: 0x0600210E RID: 8462 RVA: 0x00091424 File Offset: 0x0008F624
		internal void GetFixedEdgeScrollState(out bool isScrolledNearEdge, out bool isScrolledFarEdge)
		{
			bool flag = this._fieldLayout != null && this._fieldLayout.IsHorizontal;
			global::System.Windows.Vector fixedNearOffset = this._fixedNearOffset;
			isScrolledNearEdge = ((flag && (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(fixedNearOffset.Y, 0.0) || fixedNearOffset.Y < 0.0)) || (!flag && (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(fixedNearOffset.X, 0.0) || fixedNearOffset.X < 0.0)));
			global::System.Windows.Point bottomRight = this._fixedFarRect.BottomRight;
			isScrolledFarEdge = ((flag && (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(bottomRight.Y, base.ActualHeight) || bottomRight.Y > base.ActualHeight)) || (!flag && (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(bottomRight.X, base.ActualWidth) || bottomRight.X > base.ActualWidth)));
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x00091518 File Offset: 0x0008F718
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

		// Token: 0x06002110 RID: 8464 RVA: 0x00091678 File Offset: 0x0008F878
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
								if (this._record == null || this._record.RecordType != global::Infragistics.Windows.DataPresenter.RecordType.DataRecord || this.NonVirtualizedFields == null || this._nonVirtualizedFields.Count != 0)
								{
									flag = true;
								}
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

		// Token: 0x06002111 RID: 8465 RVA: 0x00091794 File Offset: 0x0008F994
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

		// Token: 0x06002112 RID: 8466 RVA: 0x00091CF0 File Offset: 0x0008FEF0
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager GetResizeLayoutManager()
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager result = this.GetLayoutManager();
			if (this.ForceUseCellLayoutManager)
			{
				result = this._fieldLayout.CellLayoutManager;
			}
			return result;
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00091D1C File Offset: 0x0008FF1C
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

		// Token: 0x06002114 RID: 8468 RVA: 0x00091DDC File Offset: 0x0008FFDC
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

		// Token: 0x06002115 RID: 8469 RVA: 0x00091E54 File Offset: 0x00090054
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

		// Token: 0x06002116 RID: 8470 RVA: 0x00091F54 File Offset: 0x00090154
		private bool HasClipRectChanged()
		{
			global::System.Windows.Rect clipRect = this.GetClipRect(base.RenderSize);
			return this._lastClipRect != clipRect && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(this._lastClipRect, clipRect) && !this._lastClipRect.Contains(clipRect);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00091F9C File Offset: 0x0009019C
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

		// Token: 0x06002118 RID: 8472 RVA: 0x000920D8 File Offset: 0x000902D8
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

		// Token: 0x06002119 RID: 8473 RVA: 0x000921A0 File Offset: 0x000903A0
		private void InitializeCachedDimensions(ref global::System.Windows.Size availableSize, double splitterExtent, ref global::System.Windows.Size autoFitSize, ref global::System.Windows.Size templateGridSize)
		{
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = this._isHeader ? this._fieldLayout.LabelLayoutManager : this._fieldLayout.CellLayoutManager;
			global::System.Windows.Size size = default(global::System.Windows.Size);
			if (!double.IsNaN(autoFitSize.Width) && this._fieldLayout.IsGridBagAutoFitWidth)
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

		// Token: 0x0600211A RID: 8474 RVA: 0x0009229C File Offset: 0x0009049C
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

		// Token: 0x0600211B RID: 8475 RVA: 0x00092328 File Offset: 0x00090528
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

		// Token: 0x0600211C RID: 8476 RVA: 0x000923AC File Offset: 0x000905AC
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

		// Token: 0x0600211D RID: 8477 RVA: 0x00092484 File Offset: 0x00090684
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

		// Token: 0x0600211E RID: 8478 RVA: 0x000924F8 File Offset: 0x000906F8
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

		// Token: 0x0600211F RID: 8479 RVA: 0x00092538 File Offset: 0x00090738
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
			global::Infragistics.Windows.DataPresenter.Record record = null;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout;
			if (fieldLayout2 != null)
			{
				virtualizingDataRecordCellPanel._isHeader = true;
			}
			else
			{
				record = (e.NewValue as global::Infragistics.Windows.DataPresenter.Record);
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
				if (record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
				{
					virtualizingDataRecordCellPanel._generationMode = fieldLayout2.DataPresenter.SummaryCellContainerGenerationMode;
				}
				else
				{
					virtualizingDataRecordCellPanel._generationMode = fieldLayout2.DataPresenter.CellContainerGenerationMode;
				}
				virtualizingDataRecordCellPanel._lastAutoSizeElementVersion = -1;
				return;
			}
			if (virtualizingDataRecordCellPanel._usingFixedInfo)
			{
				virtualizingDataRecordCellPanel._usingFixedInfo = false;
				virtualizingDataRecordCellPanel.ClearValue(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldInfoProperty);
			}
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000926EC File Offset: 0x000908EC
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
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenterBase.CurrentViewInternal;
			if (currentViewInternal != null && currentViewInternal.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = (this._fieldLayout != null && dataPresenterBase.IsReportControl) ? null : (global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				if (recordPresenter != null && recordPresenter.Record != null)
				{
					if (this._fieldLayout.IsHorizontal)
					{
						recordPresenter.Record.LastLayoutExtent = recordPresenter.DesiredSize.Width;
					}
					else
					{
						recordPresenter.Record.LastLayoutExtent = recordPresenter.DesiredSize.Height;
					}
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

		// Token: 0x06002121 RID: 8481 RVA: 0x0009294C File Offset: 0x00090B4C
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

		// Token: 0x06002122 RID: 8482 RVA: 0x000929C8 File Offset: 0x00090BC8
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
								num += fieldLayout.GetRecordSelectorExtent(record);
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
								num2 += fieldLayout.GetRecordSelectorExtent(record2);
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

		// Token: 0x06002123 RID: 8483 RVA: 0x00092DB0 File Offset: 0x00090FB0
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

		// Token: 0x06002124 RID: 8484 RVA: 0x00092F3C File Offset: 0x0009113C
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

		// Token: 0x06002125 RID: 8485 RVA: 0x00092F8F File Offset: 0x0009118F
		internal void ReleaseCachedDimensions()
		{
			this._cachedDimensions = null;
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00092F98 File Offset: 0x00091198
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

		// Token: 0x06002127 RID: 8487 RVA: 0x00093004 File Offset: 0x00091204
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

		// Token: 0x06002128 RID: 8488 RVA: 0x0009303C File Offset: 0x0009123C
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

		// Token: 0x06002129 RID: 8489 RVA: 0x00093064 File Offset: 0x00091264
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
			global::System.Collections.Generic.Dictionary<object, global::System.Collections.Generic.Stack<global::System.Windows.Controls.Control>> dictionary = (this._generationMode == global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.Recycle) ? new global::System.Collections.Generic.Dictionary<object, global::System.Collections.Generic.Stack<global::System.Windows.Controls.Control>>() : null;
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

		// Token: 0x0600212A RID: 8490 RVA: 0x0009344C File Offset: 0x0009164C
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

		// Token: 0x0600212B RID: 8491 RVA: 0x00093484 File Offset: 0x00091684
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
					if (fieldFromControl != null && !fieldFromControl.IsValid)
					{
						this._cellElements[i] = null;
						this.RemoveChild(control);
					}
				}
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000934DC File Offset: 0x000916DC
		internal void SetLastMeasureSize(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Size size)
		{
			int templateCellIndex = field.TemplateCellIndex;
			if (templateCellIndex >= 0 && templateCellIndex < this._cellElementMeasureSizes.Length)
			{
				this._cellElementMeasureSizes[templateCellIndex] = new global::System.Windows.Size?(size);
			}
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00093518 File Offset: 0x00091718
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

		// Token: 0x0600212E RID: 8494 RVA: 0x00093754 File Offset: 0x00091954
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

		// Token: 0x0600212F RID: 8495 RVA: 0x000937C8 File Offset: 0x000919C8
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
				bool flag4 = this._generationMode == global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.Recycle;
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
						bool flag5 = rect2.IntersectsWith(rect3);
						if (!flag5 && control != null && global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(control).IntersectsWith(clipRect))
						{
							flag5 = true;
						}
						if (!flag5)
						{
							if (control == null)
							{
								goto IL_2BE;
							}
							if (!this._positionAllAllocatedCells)
							{
								if (flag4 && !control.IsKeyboardFocusWithin)
								{
									if (linkedList == null)
									{
										linkedList = new global::System.Collections.Generic.LinkedList<global::System.Windows.Controls.Control>();
									}
									linkedList.AddLast(control);
									goto IL_2BE;
								}
								goto IL_2BE;
							}
						}
						list.Add(i);
					}
					IL_2BE:;
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
						if (flag4 && linkedList != null)
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

		// Token: 0x06002130 RID: 8496 RVA: 0x00093C78 File Offset: 0x00091E78
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

		// Token: 0x06002131 RID: 8497 RVA: 0x00093D82 File Offset: 0x00091F82
		private void VerifyClipRect()
		{
			if (this.HasClipRectChanged())
			{
				base.InvalidateArrange();
			}
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00093D94 File Offset: 0x00091F94
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
				global::Infragistics.Windows.DataPresenter.SummaryRecord summaryRecord = this._record as global::Infragistics.Windows.DataPresenter.SummaryRecord;
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> summaryResults = this._summaryResults;
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> enumerable = (summaryRecord != null && !this._isHeader) ? summaryRecord.SummaryResults : null;
				global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = this._fieldLayout.TemplateDataRecordCache;
				if (templateDataRecordCache.CacheVersion == this._templateCacheVersion && enumerable == summaryResults)
				{
					return;
				}
				this._templateCacheVersion = templateDataRecordCache.CacheVersion;
				this._summaryResults = enumerable;
				if (enumerable != null)
				{
					templateDataRecordCache.GetVirtualizedSummaryFields(summaryRecord, out list2, out list);
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

		// Token: 0x06002133 RID: 8499 RVA: 0x00093F40 File Offset: 0x00092140
		private void VerifyFixedFieldOffsets()
		{
			global::System.Windows.Vector vector = default(global::System.Windows.Vector);
			global::System.Windows.Vector vector2 = default(global::System.Windows.Vector);
			double prePostPanelSpacing = double.NaN;
			if (!this._usingFixedInfo && this._record == null && !(base.DataContext is global::Infragistics.Windows.DataPresenter.FieldLayout))
			{
				return;
			}
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

		// Token: 0x06002134 RID: 8500 RVA: 0x00094154 File Offset: 0x00092354
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

		// Token: 0x06002135 RID: 8501 RVA: 0x00094374 File Offset: 0x00092574
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

		// Token: 0x06002136 RID: 8502 RVA: 0x000943C4 File Offset: 0x000925C4
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

		// Token: 0x06002137 RID: 8503 RVA: 0x000943F0 File Offset: 0x000925F0
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

		// Token: 0x06002138 RID: 8504 RVA: 0x0009443A File Offset: 0x0009263A
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

		// Token: 0x06002139 RID: 8505 RVA: 0x0009445D File Offset: 0x0009265D
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			return (global::System.Windows.Rect)containerContext;
		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00094468 File Offset: 0x00092668
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

		// Token: 0x04000DDB RID: 3547
		private global::System.Windows.Controls.Control[] _cellElements;

		// Token: 0x04000DDC RID: 3548
		private int _allocatedCellCount;

		// Token: 0x04000DDD RID: 3549
		private bool _positionAllAllocatedCells;

		// Token: 0x04000DDE RID: 3550
		private global::System.Windows.Rect _lastClipRect;

		// Token: 0x04000DDF RID: 3551
		private bool _isAutoFitInitialized;

		// Token: 0x04000DE0 RID: 3552
		private bool _cellElementsDirty = true;

		// Token: 0x04000DE1 RID: 3553
		private global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> children = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();

		// Token: 0x04000DE2 RID: 3554
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000DE3 RID: 3555
		private bool _isHeader;

		// Token: 0x04000DE4 RID: 3556
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000DE5 RID: 3557
		private bool _isVerifyingCells;

		// Token: 0x04000DE6 RID: 3558
		private global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode _generationMode;

		// Token: 0x04000DE7 RID: 3559
		private bool _requiresAsynchMeasureInvalidation;

		// Token: 0x04000DE8 RID: 3560
		private global::Infragistics.Windows.DataPresenter.Internal.ReportLayoutInfo _reportLayoutInfo;

		// Token: 0x04000DE9 RID: 3561
		private double? _normalizedOffsetFromPanel;

		// Token: 0x04000DEA RID: 3562
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _recordLayoutManager;

		// Token: 0x04000DEB RID: 3563
		private global::System.Windows.Rect[] _cellElementRects;

		// Token: 0x04000DEC RID: 3564
		private global::Infragistics.Windows.DataPresenter.FieldRectsLayoutContainer _cellPresenterRectContainer;

		// Token: 0x04000DED RID: 3565
		private global::Infragistics.Windows.DataPresenter.FixedFieldSplitter _nearSplitter;

		// Token: 0x04000DEE RID: 3566
		private global::Infragistics.Windows.DataPresenter.FixedFieldSplitter _farSplitter;

		// Token: 0x04000DEF RID: 3567
		private global::System.Windows.Vector _nearSplitterOffset;

		// Token: 0x04000DF0 RID: 3568
		private global::System.Windows.Vector _farSplitterOffset;

		// Token: 0x04000DF1 RID: 3569
		private global::System.Windows.Vector _fixedNearOffset;

		// Token: 0x04000DF2 RID: 3570
		private global::System.Windows.Vector _fixedFarOffset;

		// Token: 0x04000DF3 RID: 3571
		private global::System.Windows.Rect _scrollableClipRect;

		// Token: 0x04000DF4 RID: 3572
		private bool _usingFixedInfo;

		// Token: 0x04000DF5 RID: 3573
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _containingRp;

		// Token: 0x04000DF6 RID: 3574
		private global::System.Windows.Rect _fixedNearRect;

		// Token: 0x04000DF7 RID: 3575
		private global::System.Windows.Rect _fixedFarRect;

		// Token: 0x04000DF8 RID: 3576
		private global::Infragistics.Windows.DataPresenter.RecordCellAreaBase _containingCellArea;

		// Token: 0x04000DF9 RID: 3577
		private global::System.Windows.Vector _fixedNearAdjustment;

		// Token: 0x04000DFA RID: 3578
		private global::System.Windows.Vector _fixedFarAdjustment;

		// Token: 0x04000DFB RID: 3579
		private double _prePostPanelSpacing;

		// Token: 0x04000DFC RID: 3580
		private global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensionsCollection _cachedDimensions;

		// Token: 0x04000DFD RID: 3581
		private global::System.Windows.Size _lastMeasureSize;

		// Token: 0x04000DFE RID: 3582
		private static readonly global::Infragistics.Windows.DataPresenter.Field[] EmptyFields = new global::Infragistics.Windows.DataPresenter.Field[0];

		// Token: 0x04000DFF RID: 3583
		private int _templateCacheVersion;

		// Token: 0x04000E00 RID: 3584
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> _virtualizedFields = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.EmptyFields;

		// Token: 0x04000E01 RID: 3585
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> _nonVirtualizedFields = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.EmptyFields;

		// Token: 0x04000E02 RID: 3586
		private int _generatorTemplateVersion = -1;

		// Token: 0x04000E03 RID: 3587
		private int _fieldsVersion = -1;

		// Token: 0x04000E04 RID: 3588
		private int _cellElementVersion;

		// Token: 0x04000E05 RID: 3589
		private int _lastAutoSizeElementVersion;

		// Token: 0x04000E06 RID: 3590
		private global::System.Windows.Rect _lastFieldsInViewClipRect;

		// Token: 0x04000E07 RID: 3591
		private global::System.Windows.Size?[] _cellElementMeasureSizes;

		// Token: 0x04000E08 RID: 3592
		private global::Infragistics.Windows.Internal.PropertyValueTracker _recordMouseOverTracker;

		// Token: 0x04000E09 RID: 3593
		private global::System.Windows.Rect? _lastLayoutContainerRect;

		// Token: 0x04000E0A RID: 3594
		private int _lastLayoutContainerCount;

		// Token: 0x04000E0B RID: 3595
		private global::System.WeakReference _lastLayoutManager;

		// Token: 0x04000E0C RID: 3596
		internal bool IsPerformingAutoSizeMeasure;

		// Token: 0x04000E0D RID: 3597
		private global::System.Windows.Size? _lastDPMeasureSize;

		// Token: 0x04000E0E RID: 3598
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.SummaryResult> _summaryResults;

		// Token: 0x04000E0F RID: 3599
		private static readonly global::System.Windows.DependencyProperty AutoFitHeightProperty = global::System.Windows.DependencyProperty.Register("AutoFitHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnAutoFitWidthHeightChanged)));

		// Token: 0x04000E10 RID: 3600
		private static readonly global::System.Windows.DependencyProperty AutoFitWidthProperty = global::System.Windows.DependencyProperty.Register("AutoFitWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnAutoFitWidthHeightChanged)));

		// Token: 0x04000E11 RID: 3601
		internal static readonly global::System.Windows.DependencyProperty FixedFieldExtentProperty = global::System.Windows.DependencyProperty.Register("FixedFieldExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000E12 RID: 3602
		internal static readonly global::System.Windows.DependencyProperty FixedFieldInfoProperty = global::System.Windows.DependencyProperty.Register("FixedFieldInfo", typeof(global::Infragistics.Windows.DataPresenter.FixedFieldInfo), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnFixedFieldInfoChanged)));

		// Token: 0x04000E13 RID: 3603
		internal static readonly global::System.Windows.DependencyProperty FixedFieldOffsetProperty = global::System.Windows.DependencyProperty.Register("FixedFieldOffset", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000E14 RID: 3604
		internal static readonly global::System.Windows.DependencyProperty FixedFieldViewportExtentProperty = global::System.Windows.DependencyProperty.Register("FixedFieldViewportExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnFixedFieldOffsetsChanged)));

		// Token: 0x04000E15 RID: 3605
		internal static readonly global::System.Windows.DependencyProperty GridColumnWidthVersionProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.GridColumnWidthVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnGridColumnWidthVersionChanged)));

		// Token: 0x04000E16 RID: 3606
		private static global::System.Windows.DependencyProperty GridMeasureVersionProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GridMeasureVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnGridMeasureVersionChanged)));

		// Token: 0x04000E17 RID: 3607
		internal static readonly global::System.Windows.DependencyProperty ScrollVersionProperty = global::System.Windows.DependencyProperty.Register("ScrollVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnScrollVersionChanged)));

		// Token: 0x04000E18 RID: 3608
		internal static readonly global::System.Windows.DependencyProperty TemplateVersionProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.TemplateVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.OnTemplateVersionChanged)));

		// Token: 0x04000E19 RID: 3609
		private global::System.Windows.Controls.Control _childBeingInitialized;
	}
}
