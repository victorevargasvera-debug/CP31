using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D1 RID: 465
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplatePart(Name = "PART_RecordContentSite", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_NestedContentSite", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_HeaderContentSite", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplateVisualState(Name = "FilteredOut", GroupName = "FilterStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilteredIn", GroupName = "FilterStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Fixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	public abstract class RecordPresenter : global::System.Windows.Controls.Control, global::Infragistics.Windows.Selection.ISelectableElement, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06001B43 RID: 6979 RVA: 0x0007A8E4 File Offset: 0x00078AE4
		static RecordPresenter()
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HideNestedContentEvent = global::System.Windows.EventManager.RegisterRoutedEvent("HideNestedContent", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ShowNestedContentEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ShowNestedContent", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.CellPresentationProperty = global::System.Windows.DependencyProperty.Register("CellPresentation", typeof(global::Infragistics.Windows.DataPresenter.CellPresentation), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellPresentation.GridView, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.CoerceCellPresentation)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.DescriptionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Description", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.DescriptionProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.DescriptionPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ExpansionIndicatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("ExpansionIndicatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.CoerceExpansionIndicatorVisibility)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnFieldLayoutChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixedNearElementTransform", typeof(global::System.Windows.Media.Transform), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixedFarElementTransform", typeof(global::System.Windows.Media.Transform), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasChildDataPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasChildData", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasChildDataProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.HasChildDataPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasHeaderContent", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasNestedContent", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorAfterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSeparatorAfter", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorAfterProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorAfterPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorBeforePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasSeparatorBefore", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorBeforeProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorBeforePropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HeaderContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HeaderContent", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.RecordPresenter.HeaderContentProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.HeaderContentPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAlternate", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternateProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnIsActiveChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsExpandedProperty = global::System.Windows.DependencyProperty.Register("IsExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.CoerceIsExpanded)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilterRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFilterRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilterRecordProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilterRecordPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFilteredOut", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnIsFilteredOutPropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixedOnBottom", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixedOnTop", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsHeaderRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsInCard", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsOpacityReducedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsOpacityReduced", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsOpacityReducedProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsOpacityReducedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsRecordEnabled", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.CoerceIsSelected)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("NestedContent", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentMarginPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("NestedContentMargin", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentMarginProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentMarginPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentBackgroundProperty = global::System.Windows.DependencyProperty.Register("NestedContentBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.OrientationProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.OrientationPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.Record), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordContentAreaTemplatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordContentAreaTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordContentAreaTemplateProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordContentAreaTemplatePropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollableElementTransform", typeof(global::System.Windows.Media.Transform), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayExpandableRecordContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ShouldDisplayExpandableRecordContent", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayExpandableRecordContentProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayExpandableRecordContentPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayGroupByRecordContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ShouldDisplayGroupByRecordContent", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayGroupByRecordContentProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayGroupByRecordContentPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayRecordContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ShouldDisplayRecordContent", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayRecordContentProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayRecordContentPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty = global::System.Windows.DependencyProperty.Register("TemplateCardView", typeof(global::System.Windows.Controls.ControlTemplate), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnTargetedTemplateChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty = global::System.Windows.DependencyProperty.Register("TemplateGridView", typeof(global::System.Windows.Controls.ControlTemplate), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnTargetedTemplateChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitHeightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AutoFitHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitHeightProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitHeightPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitWidthPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AutoFitWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitWidthProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitWidthPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldInfoProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordsInViewVersionProperty = global::System.Windows.DependencyProperty.Register("RecordsInViewVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.None));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordManagerForHeader", typeof(global::Infragistics.Windows.DataPresenter.RecordManager), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitVersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("AutoFitVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitVersionProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitVersionPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldOffsetProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldOffsetProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnFixedFieldOffsetsChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldViewportExtentProperty = global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.FixedFieldViewportExtentProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnFixedFieldOffsetsChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.ParentRecordAutoFitVersionProperty = global::System.Windows.DependencyProperty.Register("ParentRecordAutoFitVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateVersionProperty = global::Infragistics.Windows.DataPresenter.FieldLayout.TemplateVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnTemplateVersionChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("VisibilityResolved", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateRecordPresenterId = new object();
			global::Infragistics.Windows.Helpers.FocusWithinManager.RegisterType(typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter));
			global::System.Windows.Input.CommandBinding commandBinding = new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveRecordCellFilters, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DataPresenter.RecordPresenter.ExecuteCommandHandler), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DataPresenter.RecordPresenter.CanExecuteCommandHandler));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), commandBinding);
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.CoerceClip)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0007B4B0 File Offset: 0x000796B0
		protected RecordPresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.RecordPresenter.StyleSelectorHelper(this);
			base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0007B50C File Offset: 0x0007970C
		private static void CanExecuteCommandHandler(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = sender as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			e.CanExecute = false;
			if (e.Command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveRecordCellFilters)
			{
				if (recordPresenter != null && recordPresenter.Record is global::Infragistics.Windows.DataPresenter.FilterRecord)
				{
					e.CanExecute = ((global::Infragistics.Windows.DataPresenter.FilterRecord)recordPresenter.Record).HasActiveFilters;
				}
				e.Handled = true;
			}
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0007B564 File Offset: 0x00079764
		private static void ExecuteCommandHandler(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = sender as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				recordPresenter.ExecuteCommandImpl(e.Command as global::System.Windows.Input.RoutedCommand, e.Parameter, e.Source, e.OriginalSource);
			}
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0007B5A0 File Offset: 0x000797A0
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object parameter, object source, object originalSource)
		{
			if (command == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			bool result = false;
			if (command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveRecordCellFilters)
			{
				global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = this.Record as global::Infragistics.Windows.DataPresenter.FilterRecord;
				if (filterRecord != null)
				{
					filterRecord.ClearActiveFilters(true);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0007B5E0 File Offset: 0x000797E0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
			if (dataPresenter != null && fieldLayout != null && fieldLayout.IsAutoFit && (base.IsVisible || base.DataContext != null))
			{
				if (!this._layoutUpdatedWired)
				{
					this._layoutUpdatedWired = true;
					dataPresenter.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
				}
				if (this._asyncAutoFit == null && !dataPresenter.IsReportControl)
				{
					this._asyncAutoFit = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnUpdateAutoFitAsync));
				}
			}
			return result;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0007B674 File Offset: 0x00079874
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (this._record is global::Infragistics.Windows.DataPresenter.TemplateDataRecord)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._record.FieldLayout;
				if (fieldLayout.WasRemovedFromCollection)
				{
					return base.DesiredSize;
				}
				fieldLayout.TemplateDataRecordCache.Verify();
			}
			if (dataPresenter == null && !this._hasRecordEverBeenInitialized)
			{
				base.DataContext = base.GetType().Name + " RecordContentArea";
				if (this.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					global::System.Windows.Controls.TextBlock textBlock = new global::System.Windows.Controls.TextBlock();
					textBlock.Text = "HeaderContent (GridView format only)";
					textBlock.Padding = new global::System.Windows.Thickness(2.0);
					textBlock.Foreground = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Gray);
					textBlock.FontStyle = global::System.Windows.FontStyles.Normal;
					textBlock.FontWeight = global::System.Windows.FontWeights.Normal;
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ExpansionIndicatorVisibilityProperty, global::Infragistics.KnownBoxes.VisibilityVisibleBox);
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HeaderContentPropertyKey, textBlock);
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentPropertyKey, "NestedContent (GridView format only)");
				}
				else
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ExpansionIndicatorVisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HeaderContentPropertyKey);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentPropertyKey);
				}
			}
			if (this._isTemplateDirty)
			{
				this.SetTemplateBasedOnTemplateType();
				if (!this._isTemplateDirty)
				{
					base.ApplyTemplate();
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = this.FieldLayout;
			global::System.Windows.FrameworkElement parentContentPresenter = this._parentContentPresenter;
			if (fieldLayout2 != null && fieldLayout2.IsAutoFit && this._record != null)
			{
				if (this._record.ParentDataRecord != null && !this.IsHeaderRecord)
				{
					global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), true, dataPresenter) as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
					if (dataRecordPresenter != null)
					{
						base.SetBinding(global::Infragistics.Windows.DataPresenter.RecordPresenter.ParentRecordAutoFitVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitVersionProperty, global::System.Windows.Data.BindingMode.OneWay, dataRecordPresenter));
					}
				}
				else
				{
					global::System.Type type = null;
					global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
					if (currentViewInternal.RecordPresenterContainerType == null)
					{
						if (!currentViewInternal.AutoFitToRecord)
						{
							type = typeof(global::Infragistics.Windows.DataPresenter.RecordListControl);
						}
					}
					else
					{
						type = dataPresenter.CurrentViewInternal.RecordPresenterContainerType;
					}
					if (type != null)
					{
						global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::System.Windows.Controls.ScrollContentPresenter), false, null, type) as global::System.Windows.FrameworkElement;
						if (type == typeof(global::Infragistics.Windows.DataPresenter.RecordListControl))
						{
							global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = this;
							while (frameworkElement != null && recordPresenter != null && recordPresenter.Record != null && recordPresenter.Record.ParentRecord != null)
							{
								recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(frameworkElement, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, dataPresenter) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
								if (recordPresenter != null)
								{
									frameworkElement = (global::Infragistics.Windows.Utilities.GetAncestorFromType(recordPresenter, typeof(global::System.Windows.Controls.ScrollContentPresenter), false, null, type) as global::System.Windows.FrameworkElement);
								}
							}
						}
						this._parentContentPresenter = frameworkElement;
					}
					else
					{
						this._parentContentPresenter = null;
					}
				}
			}
			else
			{
				this._parentContentPresenter = null;
			}
			if (this._parentContentPresenter == null)
			{
				this._parentCPWidthTracker = (this._parentCPHeightTracker = null);
			}
			else
			{
				if (fieldLayout2.IsAutoFitWidth)
				{
					if (this._parentCPWidthTracker == null || this._parentContentPresenter != parentContentPresenter)
					{
						this._parentCPWidthTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._parentContentPresenter, global::System.Windows.FrameworkElement.ActualWidthProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnAutoFitExtentChanged));
					}
				}
				else
				{
					this._parentCPWidthTracker = null;
				}
				if (fieldLayout2.IsAutoFitHeight)
				{
					if (this._parentCPHeightTracker == null || this._parentContentPresenter != parentContentPresenter)
					{
						this._parentCPHeightTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._parentContentPresenter, global::System.Windows.FrameworkElement.ActualHeightProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnAutoFitExtentChanged));
					}
				}
				else
				{
					this._parentCPHeightTracker = null;
				}
			}
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x0007BA1C File Offset: 0x00079C1C
		public override void OnApplyTemplate()
		{
			if (this._expansionIndicator != null)
			{
				this._expansionIndicator.Click -= this.OnExpansionIndicatorClick;
				this._expansionIndicator = null;
			}
			base.OnApplyTemplate();
			global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::Infragistics.Windows.Controls.ExpansionIndicator> callback = (global::Infragistics.Windows.Controls.ExpansionIndicator indicator) => indicator.Command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleRecordIsExpanded;
			this._expansionIndicator = global::Infragistics.Windows.Utilities.GetTemplateChild<global::Infragistics.Windows.Controls.ExpansionIndicator>(this, callback);
			if (this._expansionIndicator != null)
			{
				this._expansionIndicator.Command = null;
				this._expansionIndicator.Click += this.OnExpansionIndicatorClick;
			}
			global::System.Windows.FrameworkElement recordContentSite = this.GetRecordContentSite();
			if (recordContentSite != null)
			{
				recordContentSite.SetBinding(global::System.Windows.UIElement.IsEnabledProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			}
			if (base.IsLoaded)
			{
				this.RaiseNestedContentEvent(this.HasNestedContent);
			}
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x0007BAF4 File Offset: 0x00079CF4
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			this.ClearLastLayoutExtent();
			global::Infragistics.Windows.DataPresenter.CardViewCard cardViewCard = base.Parent as global::Infragistics.Windows.DataPresenter.CardViewCard;
			if (cardViewCard != null)
			{
				global::Infragistics.Windows.DataPresenter.CardViewSettings cardViewSettings = (this.DataPresenter != null && this.DataPresenter.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.CardView) ? ((global::Infragistics.Windows.DataPresenter.CardView)this.DataPresenter.CurrentViewInternal).ViewSettings : null;
				if (cardViewSettings != null && double.IsNaN(cardViewSettings.CardWidth) && double.IsNaN(cardViewSettings.CardHeight))
				{
					global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(cardViewCard) as global::System.Windows.UIElement;
					global::System.Windows.UIElement uielement2 = this;
					do
					{
						uielement2.InvalidateMeasure();
						if (uielement2 == uielement)
						{
							break;
						}
						uielement2 = (global::System.Windows.Media.VisualTreeHelper.GetParent(uielement2) as global::System.Windows.UIElement);
					}
					while (uielement2 != null);
				}
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0007BB94 File Offset: 0x00079D94
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordPresenterAutomationPeer(this);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x0007BB9C File Offset: 0x00079D9C
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this.ShouldDisplayRecordContent)
			{
				global::System.Windows.FrameworkElement recordContentSite = this.GetRecordContentSite();
				if (recordContentSite != null)
				{
					global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.Windows.DataPresenter.RecordPresenter.FindFocusableDescendant(recordContentSite);
					if (frameworkElement != null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
						if (dataPresenter != null)
						{
							if (dataPresenter.IsKeyboardFocusWithin)
							{
								frameworkElement.Focus();
								return;
							}
							if ((bool)dataPresenter.GetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty))
							{
								global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(frameworkElement);
								if (focusScope != null)
								{
									global::Infragistics.Windows.Utilities.SetFocusedElement(focusScope, frameworkElement);
								}
							}
						}
					}
					return;
				}
			}
			base.OnGotFocus(e);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x0007BC0C File Offset: 0x00079E0C
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.Property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				this._isAlternateInitialized = false;
			}
			base.OnPropertyChanged(e);
			if (this._isClearingBindings)
			{
				return;
			}
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::System.Windows.FrameworkElement.StyleProperty)
			{
				if (!this._preparingItemForContainer)
				{
					this._isTemplateDirty = true;
					base.ClearValue(global::System.Windows.Controls.Control.TemplateProperty);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty);
					this.InitializeMinWidth();
					this.ClearLastLayoutExtent();
					return;
				}
			}
			else if (property == global::System.Windows.Controls.Control.TemplateProperty)
			{
				this.ClearLastLayoutExtent();
				if (!this._isSwappingTemplate)
				{
					this._isTemplateDirty = true;
					this._cachedTemplate = base.Template;
					return;
				}
			}
			else if (property == global::Infragistics.Windows.DataPresenter.RecordPresenter.InternalVersionProperty)
			{
				if (!this._isClearingBindings)
				{
					this.InitializeVersionInfo();
					this.SetTemplateBasedOnTemplateType();
					return;
				}
			}
			else if (property == global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordsInViewVersionProperty)
			{
				if (!this._preparingItemForContainer)
				{
					if (this._ignoreNextRecordsInViewVersionPropertyChange)
					{
						this._ignoreNextRecordsInViewVersionPropertyChange = false;
						return;
					}
					base.InvalidateMeasure();
					if (this.Record.ParentRecord != null)
					{
						for (global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(this); parent != null; parent = global::System.Windows.Media.VisualTreeHelper.GetParent(parent))
						{
							if (parent is global::System.Windows.UIElement && !(parent is global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer))
							{
								((global::System.Windows.UIElement)parent).InvalidateMeasure();
								return;
							}
						}
						return;
					}
				}
			}
			else if (property == global::Infragistics.Windows.DataPresenter.RecordPresenter.CellPresentationProperty)
			{
				if (!this._preparingItemForContainer)
				{
					this._isTemplateDirty = true;
					base.InvalidateMeasure();
					return;
				}
			}
			else
			{
				if (e.Property == global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty)
				{
					this.OnIsFocusWithinChanged((bool)e.NewValue);
					return;
				}
				if (e.Property == global::System.Windows.UIElement.IsVisibleProperty)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
					if (dataPresenter != null && this.IsExpanded)
					{
						if (!(bool)e.NewValue)
						{
							this._nestedDataRequiresInitalization = true;
							return;
						}
						if (this._nestedDataRequiresInitalization)
						{
							dataPresenter.QueueNestedContentInitializationRequest(this);
							return;
						}
					}
				}
				else
				{
					if (e.Property == global::Infragistics.Windows.DataPresenter.RecordPresenter.ParentRecordAutoFitVersionProperty || e.Property == global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitWidthProperty || e.Property == global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitHeightProperty)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter2 = this.DataPresenter;
						if (dataPresenter2 == null || !dataPresenter2.IsSynchronousControl)
						{
							global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateMeasureAsynch(this);
						}
						else
						{
							base.InvalidateMeasure();
						}
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitVersionPropertyKey, this.AutoFitVersion + 1);
						return;
					}
					if (e.Property == global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentProperty)
					{
						if (base.IsLoaded)
						{
							this.RaiseNestedContentEvent((bool)e.NewValue);
							return;
						}
						base.Loaded += this.OnLoaded;
						return;
					}
					else if (e.Property == global::System.Windows.FrameworkElement.MarginProperty)
					{
						this.ClearLastLayoutExtent();
					}
				}
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0007BE88 File Offset: 0x0007A088
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("RecordPresenter: ");
			if (this.Record != null)
			{
				stringBuilder.Append(this.Record.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0007BEC7 File Offset: 0x0007A0C7
		protected virtual void OnHideNestedContent(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x0007BED0 File Offset: 0x0007A0D0
		internal void RaiseHideNestedContent(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.RecordPresenter.HideNestedContentEvent;
			args.Source = this;
			this.OnHideNestedContent(args);
		}

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06001B52 RID: 6994 RVA: 0x0007BEEB File Offset: 0x0007A0EB
		// (remove) Token: 0x06001B53 RID: 6995 RVA: 0x0007BEF9 File Offset: 0x0007A0F9
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> HideNestedContent
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.RecordPresenter.HideNestedContentEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.RecordPresenter.HideNestedContentEvent, value);
			}
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x0007BF07 File Offset: 0x0007A107
		protected virtual void OnShowNestedContent(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0007BF10 File Offset: 0x0007A110
		internal void RaiseShowNestedContent(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.RecordPresenter.ShowNestedContentEvent;
			args.Source = this;
			this.OnShowNestedContent(args);
		}

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06001B56 RID: 6998 RVA: 0x0007BF2B File Offset: 0x0007A12B
		// (remove) Token: 0x06001B57 RID: 6999 RVA: 0x0007BF39 File Offset: 0x0007A139
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> ShowNestedContent
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.RecordPresenter.ShowNestedContentEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.RecordPresenter.ShowNestedContentEvent, value);
			}
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x0007BF48 File Offset: 0x0007A148
		private static object CoerceCellPresentation(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = recordPresenter.DataPresenter;
				if (dataPresenter != null)
				{
					return dataPresenter.CurrentViewInternal.CellPresentation;
				}
			}
			return value;
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x0007BF7B File Offset: 0x0007A17B
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0007BF8D File Offset: 0x0007A18D
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)]
		public global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.CellPresentation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.CellPresentationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.CellPresentationProperty, value);
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0007BFA0 File Offset: 0x0007A1A0
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record record = this.Record;
				if (record != null)
				{
					return record.DataPresenter;
				}
				return null;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0007BFBF File Offset: 0x0007A1BF
		public string Description
		{
			get
			{
				if (this._descSyncPending)
				{
					this.SynchronizeDescriptionProperty();
				}
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.DescriptionProperty);
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0007BFE0 File Offset: 0x0007A1E0
		private static object CoerceExpansionIndicatorVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = (global::Infragistics.Windows.DataPresenter.RecordPresenter)d;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = recordPresenter.DataPresenter;
			if (dataPresenter != null && dataPresenter.IsTreeView)
			{
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			if (recordPresenter.IsHeaderRecord)
			{
				global::Infragistics.Windows.DataPresenter.Record record = recordPresenter.Record;
				if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord || (record.IsSpecialRecord && record.ParentCollection.RecordsType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByField))
				{
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = record.RecordManager;
					if (recordManager == null || recordManager.Sorted.Count == 0 || recordManager.Sorted[0].ExpansionIndicatorVisibility == global::System.Windows.Visibility.Collapsed)
					{
						return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
					}
				}
			}
			return newValue;
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0007C06B File Offset: 0x0007A26B
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0007C07D File Offset: 0x0007A27D
		public global::System.Windows.Visibility ExpansionIndicatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ExpansionIndicatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ExpansionIndicatorVisibilityProperty, value);
			}
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0007C090 File Offset: 0x0007A290
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				recordPresenter._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				if (recordPresenter._cachedFieldLayout == null)
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(recordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateVersionProperty);
					return;
				}
				global::System.Windows.Data.BindingOperations.SetBinding(recordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.TemplateVersionProperty, global::System.Windows.Data.BindingMode.OneWay, recordPresenter._cachedFieldLayout));
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0007C0EA File Offset: 0x0007A2EA
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0007C0F2 File Offset: 0x0007A2F2
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._cachedFieldLayout;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FieldLayoutProperty, value);
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0007C100 File Offset: 0x0007A300
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Transform FixedNearElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformProperty);
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x0007C112 File Offset: 0x0007A312
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Transform FixedFarElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformProperty);
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0007C124 File Offset: 0x0007A324
		public bool HasChildData
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasChildDataProperty);
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001B66 RID: 7014 RVA: 0x0007C136 File Offset: 0x0007A336
		public bool HasHeaderContent
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentProperty);
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x0007C148 File Offset: 0x0007A348
		public bool HasNestedContent
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentProperty);
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001B68 RID: 7016 RVA: 0x0007C15A File Offset: 0x0007A35A
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasSeparatorAfter
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorAfterProperty);
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0007C16C File Offset: 0x0007A36C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasSeparatorBefore
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorBeforeProperty);
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0007C17E File Offset: 0x0007A37E
		public object HeaderContent
		{
			get
			{
				return this._headerContent;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0007C186 File Offset: 0x0007A386
		public bool IsAlternate
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternateProperty);
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0007C198 File Offset: 0x0007A398
		private static void OnIsActiveChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				bool flag = (bool)e.NewValue;
				if (flag != recordPresenter._cachedIsActive)
				{
					recordPresenter._cachedIsActive = flag;
				}
				if (recordPresenter._record != null && recordPresenter._record.DataPresenter != null)
				{
					if (flag)
					{
						if (recordPresenter._record.DataPresenter.ActiveRecord != recordPresenter._record)
						{
							recordPresenter._record.DataPresenter.ActiveRecord = recordPresenter._record;
						}
					}
					else if (recordPresenter._record.DataPresenter.ActiveRecord == recordPresenter._record)
					{
						recordPresenter._record.DataPresenter.ActiveRecord = null;
					}
				}
				recordPresenter.UpdateVisualStates();
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0007C246 File Offset: 0x0007A446
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0007C24E File Offset: 0x0007A44E
		public bool IsActive
		{
			get
			{
				return this._cachedIsActive;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0007C264 File Offset: 0x0007A464
		private static object CoerceIsExpanded(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.Record record = recordPresenter.Record;
				if (record != null && recordPresenter.DataPresenter != null)
				{
					if (!recordPresenter._isSynchingExpandedState)
					{
						record.IsExpanded = (bool)value;
					}
					if (record.IsExpanded != (bool)value)
					{
						if (record.DataPresenter.IsSynchronousControl)
						{
							recordPresenter.ResyncIsExpandedState();
						}
						else
						{
							recordPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(recordPresenter.ResyncIsExpandedState));
						}
					}
				}
			}
			return (bool)value;
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0007C2E8 File Offset: 0x0007A4E8
		private void ResyncIsExpandedState()
		{
			if (this._record != null)
			{
				this._isSynchingExpandedState = true;
				this.IsExpanded = this._record.IsExpanded;
				this._isSynchingExpandedState = false;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x0007C314 File Offset: 0x0007A514
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x0007C333 File Offset: 0x0007A533
		public bool IsExpanded
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record record = this.Record;
				return record != null && record.IsExpanded;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsExpandedProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0007C346 File Offset: 0x0007A546
		public bool IsFilterRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilterRecordProperty);
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0007C358 File Offset: 0x0007A558
		private static void OnIsFilteredOutPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				recordPresenter.SynchronizeIsOpacityReduced();
			}
			global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged(target, e);
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0007C37C File Offset: 0x0007A57C
		public bool? IsFilteredOut
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutProperty);
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0007C38E File Offset: 0x0007A58E
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFixedOnBottom
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomProperty);
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0007C3A0 File Offset: 0x0007A5A0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFixedOnTop
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopProperty);
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0007C3B2 File Offset: 0x0007A5B2
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsHeaderRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordProperty);
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0007C3C4 File Offset: 0x0007A5C4
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsInCard
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardProperty);
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x0007C3D6 File Offset: 0x0007A5D6
		public bool IsOpacityReduced
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsOpacityReducedProperty);
			}
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0007C3E8 File Offset: 0x0007A5E8
		private void SynchronizeIsOpacityReduced()
		{
			bool? flag = null;
			if (this._record != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._record.FieldLayout;
				switch (fieldLayout.FilterActionResolved)
				{
				case global::Infragistics.Windows.DataPresenter.RecordFilterAction.Hide:
					if (fieldLayout.IsTreeView)
					{
						flag = this.IsFilteredOut;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.RecordFilterAction.Disable:
				case global::Infragistics.Windows.DataPresenter.RecordFilterAction.ReduceOpacity:
					flag = this.IsFilteredOut;
					break;
				}
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsOpacityReducedPropertyKey, global::Infragistics.KnownBoxes.FromValue(flag != null && flag.Value));
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0007C469 File Offset: 0x0007A669
		public bool IsRecordEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledProperty);
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0007C47C File Offset: 0x0007A67C
		private static object CoerceIsSelected(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.Record record = recordPresenter.Record;
				if (record != null && recordPresenter.DataPresenter != null)
				{
					record.IsSelected = (bool)value;
					return record.IsSelected;
				}
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x0007C4C4 File Offset: 0x0007A6C4
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0007C4E3 File Offset: 0x0007A6E3
		public bool IsSelected
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record record = this.Record;
				return record != null && record.IsSelected;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0007C4F6 File Offset: 0x0007A6F6
		internal void InitializeNestedContent(object nestedContent)
		{
			this._nestedContent = nestedContent;
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentPropertyKey, this._nestedContent);
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._nestedContent != null));
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0007C52C File Offset: 0x0007A72C
		public object NestedContent
		{
			get
			{
				if (this._record == null || !this._record.IsExpanded)
				{
					this._nestedContent = null;
					return null;
				}
				return this._nestedContent;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0007C552 File Offset: 0x0007A752
		public global::System.Windows.Thickness NestedContentMargin
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentMarginProperty);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0007C564 File Offset: 0x0007A764
		// (set) Token: 0x06001B84 RID: 7044 RVA: 0x0007C576 File Offset: 0x0007A776
		public global::System.Windows.Media.Brush NestedContentBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentBackgroundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentBackgroundProperty, value);
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001B85 RID: 7045 RVA: 0x0007C584 File Offset: 0x0007A784
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.OrientationProperty);
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0007C596 File Offset: 0x0007A796
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x0007C5A0 File Offset: 0x0007A7A0
		public global::System.Windows.DataTemplate RecordContentAreaTemplate
		{
			get
			{
				if (this._cachedFieldLayout != null)
				{
					global::Infragistics.Windows.DataPresenter.Record record = this.Record;
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator fieldLayoutTemplateGenerator = this._cachedFieldLayout.StyleGenerator;
					if (fieldLayoutTemplateGenerator == null)
					{
						fieldLayoutTemplateGenerator = this.DataPresenter.CurrentViewInternal.GetFieldLayoutTemplateGenerator(this._cachedFieldLayout);
						if (fieldLayoutTemplateGenerator != null)
						{
							this._cachedFieldLayout.Initialize(fieldLayoutTemplateGenerator);
						}
					}
					if (fieldLayoutTemplateGenerator != null)
					{
						return this.GetRecordContentAreaTemplate(fieldLayoutTemplateGenerator);
					}
				}
				return null;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x0007C5FD File Offset: 0x0007A7FD
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Transform ScrollableElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformProperty);
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0007C60F File Offset: 0x0007A80F
		public bool ShouldDisplayExpandableRecordContent
		{
			get
			{
				return this._shouldDisplayExpandableRecordContent;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0007C617 File Offset: 0x0007A817
		public bool ShouldDisplayGroupByRecordContent
		{
			get
			{
				return this._shouldDisplayGroupByRecordContent;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001B8B RID: 7051 RVA: 0x0007C61F File Offset: 0x0007A81F
		public bool ShouldDisplayRecordContent
		{
			get
			{
				return this._shouldDisplayRecordContent;
			}
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0007C628 File Offset: 0x0007A828
		private static void OnTargetedTemplateChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null && (e.OldValue == null || recordPresenter.IsVisible || recordPresenter.DataContext != null))
			{
				recordPresenter._isTemplateDirty = true;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = recordPresenter.DataPresenter;
				if (dataPresenter == null || !dataPresenter.IsSynchronousControl)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.InvalidateMeasureAsynch(recordPresenter);
					return;
				}
				recordPresenter.InvalidateMeasure();
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0007C67E File Offset: 0x0007A87E
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0007C690 File Offset: 0x0007A890
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ControlTemplate TemplateCardView
		{
			get
			{
				return (global::System.Windows.Controls.ControlTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty, value);
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x0007C69E File Offset: 0x0007A89E
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0007C6B0 File Offset: 0x0007A8B0
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ControlTemplate TemplateGridView
		{
			get
			{
				return (global::System.Windows.Controls.ControlTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty, value);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0007C6BE File Offset: 0x0007A8BE
		internal double AutoFitHeight
		{
			get
			{
				return this.CalculateAutoFitExtent(false);
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x0007C6C7 File Offset: 0x0007A8C7
		internal double AutoFitWidth
		{
			get
			{
				return this.CalculateAutoFitExtent(true);
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x0007C6D0 File Offset: 0x0007A8D0
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x0007C6EC File Offset: 0x0007A8EC
		internal global::Infragistics.Windows.DataPresenter.RecordCellAreaBase CellArea
		{
			get
			{
				if (this._cellArea == null)
				{
					return null;
				}
				return (global::Infragistics.Windows.DataPresenter.RecordCellAreaBase)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._cellArea);
			}
			set
			{
				bool flag = value == null || (this._record is global::Infragistics.Windows.DataPresenter.DataRecord && value is global::Infragistics.Windows.DataPresenter.DataRecordCellArea) || (this._record is global::Infragistics.Windows.DataPresenter.SummaryRecord && value is global::Infragistics.Windows.DataPresenter.SummaryRecordCellArea) || (this._record == null && value is global::Infragistics.Windows.DataPresenter.HeaderLabelArea);
				if (flag)
				{
					global::Infragistics.Windows.DataPresenter.RecordCellAreaBase cellArea = this.CellArea;
					if (value != cellArea)
					{
						this._cellArea = ((value != null) ? new global::System.WeakReference(value) : null);
						this.VerifyFixedFarTransform();
					}
				}
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x0007C764 File Offset: 0x0007A964
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x0007C776 File Offset: 0x0007A976
		internal global::Infragistics.Windows.DataPresenter.FixedFieldInfo FixedFieldInfo
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FixedFieldInfo)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty, value);
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0007C784 File Offset: 0x0007A984
		internal bool HasCellInEditMode
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._record as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord == null || !dataRecord.IsActive)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				global::Infragistics.Windows.DataPresenter.Cell cell = (dataPresenter != null) ? dataPresenter.ActiveCell : null;
				return cell != null && cell.IsInEditMode && cell.Record == dataRecord;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x0007C7D4 File Offset: 0x0007A9D4
		// (set) Token: 0x06001B99 RID: 7065 RVA: 0x0007C7E6 File Offset: 0x0007A9E6
		internal int RecordsInViewVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordsInViewVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordsInViewVersionProperty, value);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0007C7F9 File Offset: 0x0007A9F9
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0007C801 File Offset: 0x0007AA01
		internal global::System.Windows.Media.Geometry InternalClip
		{
			get
			{
				return this._internalClip;
			}
			set
			{
				if (this._internalClip != value)
				{
					this._explicitClip = null;
					this._combinedClip = null;
					this._internalClip = value;
					base.CoerceValue(global::System.Windows.UIElement.ClipProperty);
				}
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x0007C82C File Offset: 0x0007AA2C
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0007C83E File Offset: 0x0007AA3E
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.InternalVersionProperty, value);
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x0007C851 File Offset: 0x0007AA51
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0007C859 File Offset: 0x0007AA59
		internal bool IsActiveFixedRecord
		{
			get
			{
				return this._isActiveFixedRecord;
			}
			set
			{
				this._isActiveFixedRecord = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0007C862 File Offset: 0x0007AA62
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0007C86A File Offset: 0x0007AA6A
		internal bool IsActiveHeaderRecord
		{
			get
			{
				return this._isActiveHeaderRecord;
			}
			set
			{
				this._isActiveHeaderRecord = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0007C873 File Offset: 0x0007AA73
		// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x0007C87B File Offset: 0x0007AA7B
		internal bool IsArrangedInView
		{
			get
			{
				return this._isArrangedInView;
			}
			set
			{
				this._isArrangedInView = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x0007C884 File Offset: 0x0007AA84
		// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0007C88C File Offset: 0x0007AA8C
		internal bool IsBoundaryRecord
		{
			get
			{
				return this._isBoundaryRecord;
			}
			set
			{
				if (value == this._isBoundaryRecord)
				{
					return;
				}
				this._isBoundaryRecord = value;
				this._ignoreNextRecordsInViewVersionPropertyChange = true;
				if (!this._isBoundaryRecord)
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordsInViewVersionProperty);
					return;
				}
				base.SetBinding(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordsInViewVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this.DataPresenter));
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x0007C8E2 File Offset: 0x0007AAE2
		internal bool IsClearingBindings
		{
			get
			{
				return this._isClearingBindings;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001BA7 RID: 7079 RVA: 0x0007C8EC File Offset: 0x0007AAEC
		internal bool IsDeactivated
		{
			get
			{
				global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::System.Windows.FrameworkElement;
				if (frameworkElement is global::System.Windows.Controls.Panel || frameworkElement == null)
				{
					return base.Visibility == global::System.Windows.Visibility.Collapsed;
				}
				return frameworkElement.Visibility == global::System.Windows.Visibility.Collapsed;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x0007C923 File Offset: 0x0007AB23
		internal bool IsPreparingItemForContainer
		{
			get
			{
				return this._preparingItemForContainer;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001BA9 RID: 7081 RVA: 0x0007C92C File Offset: 0x0007AB2C
		internal bool IsFocusWithinContentArea
		{
			get
			{
				global::System.Windows.FrameworkElement recordContentSite = this.GetRecordContentSite();
				return recordContentSite != null && global::Infragistics.Windows.Helpers.FocusWithinManager.CheckFocusWithinHelper(recordContentSite);
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x0007C94B File Offset: 0x0007AB4B
		internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManagerForHeader
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordManager)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderProperty);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x0007C95D File Offset: 0x0007AB5D
		// (set) Token: 0x06001BAC RID: 7084 RVA: 0x0007C965 File Offset: 0x0007AB65
		internal bool TreatAsCollapsed
		{
			get
			{
				return this._treatAsCollapsed;
			}
			set
			{
				if (value != this._treatAsCollapsed)
				{
					this._treatAsCollapsed = value;
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.VisibilityToUse));
				}
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x0007C98D File Offset: 0x0007AB8D
		// (set) Token: 0x06001BAE RID: 7086 RVA: 0x0007C995 File Offset: 0x0007AB95
		internal global::System.Windows.FrameworkElement TreeExpander
		{
			get
			{
				return this._treeExpander;
			}
			set
			{
				this._treeExpander = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0007C99E File Offset: 0x0007AB9E
		internal global::System.WeakReference WeakRef
		{
			get
			{
				if (this._weakRef == null)
				{
					this._weakRef = new global::System.WeakReference(this);
				}
				return this._weakRef;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x0007C9BA File Offset: 0x0007ABBA
		private int AutoFitVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitVersionProperty);
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0007C9CC File Offset: 0x0007ABCC
		private static void OnFixedFieldOffsetsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.RecordPresenter)d).VerifyFixedFarTransform();
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x0007C9D9 File Offset: 0x0007ABD9
		// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0007C9EB File Offset: 0x0007ABEB
		private int ParentRecordAutoFitVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ParentRecordAutoFitVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ParentRecordAutoFitVersionProperty, value);
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0007C9FE File Offset: 0x0007ABFE
		private static void OnTemplateVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.RecordPresenter)d).InitializeFixedFieldInfo();
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0007CA0B File Offset: 0x0007AC0B
		private global::System.Windows.Visibility VisibilityToUse
		{
			get
			{
				if (this.TreatAsCollapsed)
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				if (this.Record != null)
				{
					return this.Record.VisibilityResolved;
				}
				return global::System.Windows.Visibility.Collapsed;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0007CA2C File Offset: 0x0007AC2C
		private global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedProperty);
			}
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0007CA3E File Offset: 0x0007AC3E
		public static global::Infragistics.Windows.DataPresenter.RecordPresenter FromRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			return record.AssociatedRecordPresenter;
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0007CA54 File Offset: 0x0007AC54
		internal void CleanUp()
		{
			if (this.IsBoundaryRecord)
			{
				this.IsBoundaryRecord = false;
			}
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0007CA65 File Offset: 0x0007AC65
		internal void ClearContainerForItem(object item)
		{
			this.ClearContainerForItem(item, false);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x0007CA70 File Offset: 0x0007AC70
		internal void ClearContainerForItem(object item, bool isUsedForHeaderOnly)
		{
			this._isClearingBindings = true;
			try
			{
				this._parentContentPresenter = null;
				this._parentCPHeightTracker = (this._parentCPWidthTracker = null);
				this._layoutUpdatedWired = false;
				this.FieldLayout = null;
				global::System.Windows.Data.BindingOperations.ClearAllBindings(this);
				this.InitializeRecord(null, isUsedForHeaderOnly);
			}
			finally
			{
				this._isClearingBindings = false;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				((global::Infragistics.Windows.DataPresenter.Record)item).InvalidatePeer();
			}
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x0007CAE4 File Offset: 0x0007ACE4
		internal void FocusIfAppropriate()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			if (!this.IsFocusWithinContentArea)
			{
				if (dataPresenter.IsKeyboardFocusWithin)
				{
					base.Focus();
					return;
				}
				if ((bool)dataPresenter.GetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty))
				{
					global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
					if (focusScope != null)
					{
						global::Infragistics.Windows.Utilities.SetFocusedElement(focusScope, this);
					}
				}
			}
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x0007CB38 File Offset: 0x0007AD38
		internal global::System.Windows.FrameworkElement GetRecordContentSite()
		{
			if (!this.ShouldDisplayRecordContent)
			{
				return null;
			}
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_RecordContentSite");
			if (templateChild == null)
			{
				return global::Infragistics.Windows.Utilities.GetDescendantFromType(this, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), true) as global::System.Windows.FrameworkElement;
			}
			return templateChild as global::System.Windows.FrameworkElement;
		}

		// Token: 0x06001BBD RID: 7101 RVA: 0x0007CB7C File Offset: 0x0007AD7C
		internal global::System.Windows.FrameworkElement GetHeaderContentSite()
		{
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_HeaderContentSite");
			return templateChild as global::System.Windows.FrameworkElement;
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0007CB9C File Offset: 0x0007AD9C
		internal global::System.Windows.FrameworkElement GetNestedContentSite()
		{
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_NestedContentSite");
			return templateChild as global::System.Windows.FrameworkElement;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0007CBBB File Offset: 0x0007ADBB
		internal virtual global::System.Windows.DataTemplate GetRecordContentAreaTemplate(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator generator)
		{
			return null;
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0007CBC0 File Offset: 0x0007ADC0
		internal virtual string GetRecordDescription()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this.Record;
			if (record == null)
			{
				return null;
			}
			return record.Description;
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0007CBDF File Offset: 0x0007ADDF
		internal virtual global::Infragistics.Windows.DataPresenter.Record GetRecordForMeasure()
		{
			return this.Record;
		}

		// Token: 0x06001BC2 RID: 7106
		internal abstract global::System.Windows.Controls.ControlTemplate GetDefaultTemplateProperty(global::System.Windows.DependencyProperty templateProperty);

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0007CBE7 File Offset: 0x0007ADE7
		internal void InitializeExpandableRecordContentVisibility(bool showExpandableRecordContent)
		{
			if (showExpandableRecordContent != this._shouldDisplayExpandableRecordContent)
			{
				this._shouldDisplayExpandableRecordContent = showExpandableRecordContent;
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayExpandableRecordContentPropertyKey, global::Infragistics.KnownBoxes.FromValue(showExpandableRecordContent));
			}
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0007CC0A File Offset: 0x0007AE0A
		internal void InitializeGroupByRecordContentVisibility(bool showGroupByRecordContent)
		{
			if (showGroupByRecordContent != this._shouldDisplayGroupByRecordContent)
			{
				this._shouldDisplayGroupByRecordContent = showGroupByRecordContent;
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayGroupByRecordContentPropertyKey, global::Infragistics.KnownBoxes.FromValue(showGroupByRecordContent));
			}
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0007CC30 File Offset: 0x0007AE30
		internal void InitializeHeaderContent(bool addHeader)
		{
			if ((!addHeader || (this.FieldLayout != null && this.FieldLayout.StyleGenerator != null && !this.FieldLayout.StyleGenerator.HasSeparateHeader)) && !(this.Record is global::Infragistics.Windows.DataPresenter.HeaderRecord))
			{
				if (this._headerContent != null)
				{
					global::Infragistics.Windows.DataPresenter.HeaderPresenter headerPresenter = this._headerContent as global::Infragistics.Windows.DataPresenter.HeaderPresenter;
					if (headerPresenter != null && base.Tag != global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateRecordPresenterId)
					{
						this.FieldLayout.ReturnHeaderPresenterToCache(headerPresenter);
					}
					this._headerContent = null;
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HeaderContentPropertyKey, null);
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				}
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = null;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter != null && !dataPresenter.IsExportControl && !dataPresenter.IsReportControl)
			{
				recordManager = global::Infragistics.Windows.DataPresenter.GridUtilities.GetRPRecordManager(this, this.FieldLayout, true);
			}
			if (this._headerContent == null)
			{
				if (base.Tag == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateRecordPresenterId)
				{
					global::Infragistics.Windows.DataPresenter.HeaderPresenter headerPresenter2 = new global::Infragistics.Windows.DataPresenter.HeaderPresenter();
					headerPresenter2.Content = this._cachedFieldLayout;
					headerPresenter2.SetValue(global::System.Windows.Controls.ContentControl.ContentTemplateProperty, this._cachedFieldLayout.StyleGenerator.TemplateDataRecordHeaderAreaTemplate);
					headerPresenter2.SetBinding(global::Infragistics.Windows.DataPresenter.HeaderPresenter.InternalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this._cachedFieldLayout));
					this._headerContent = headerPresenter2;
				}
				else
				{
					this._headerContent = this.FieldLayout.GetHeaderPresenterFromCache();
				}
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HeaderContentPropertyKey, this._headerContent);
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				if (recordManager != null)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderPropertyKey, recordManager);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderPropertyKey);
				}
				global::Infragistics.Windows.DataPresenter.HeaderPresenter headerPresenter3 = this._headerContent as global::Infragistics.Windows.DataPresenter.HeaderPresenter;
				if (headerPresenter3 != null)
				{
					headerPresenter3.RecordPresenter = this;
				}
				return;
			}
			if (recordManager != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderPropertyKey, recordManager);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderPropertyKey);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0007CDE0 File Offset: 0x0007AFE0
		internal void InitializeIsAlternate(bool force)
		{
			if (force)
			{
				this._isAlternateInitialized = false;
			}
			this.InitializeIsAlternate();
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0007CDF4 File Offset: 0x0007AFF4
		internal void InitializeRecordContentVisibility(bool showRecordContent)
		{
			if (showRecordContent && this.Record is global::Infragistics.Windows.DataPresenter.HeaderRecord)
			{
				showRecordContent = false;
			}
			if (showRecordContent != this._shouldDisplayRecordContent)
			{
				this._shouldDisplayRecordContent = showRecordContent;
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayRecordContentPropertyKey, global::Infragistics.KnownBoxes.FromValue(showRecordContent));
				this.SynchronizeSeparatorVisibility();
			}
			if (showRecordContent)
			{
				this.InitializeIsFixedOnTopOrBottom();
			}
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0007CE44 File Offset: 0x0007B044
		internal void InvalidateStyle()
		{
			this._styleSelectorHelper.InvalidateStyle();
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0007CE54 File Offset: 0x0007B054
		internal void InvalidateGridViewPanelFlat()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
			if (currentViewInternal == null)
			{
				return;
			}
			global::System.Type itemsPanelType = currentViewInternal.ItemsPanelType;
			if (itemsPanelType != null && typeof(global::Infragistics.Windows.DataPresenter.GridViewPanelFlat).IsAssignableFrom(itemsPanelType))
			{
				global::Infragistics.Windows.DataPresenter.GridViewPanelFlat gridViewPanelFlat = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::Infragistics.Windows.DataPresenter.GridViewPanelFlat), true) as global::Infragistics.Windows.DataPresenter.GridViewPanelFlat;
				if (gridViewPanelFlat != null)
				{
					gridViewPanelFlat.InvalidateMeasure();
				}
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0007CEBC File Offset: 0x0007B0BC
		internal void OnIsFocusWithinChanged(bool gotFocus)
		{
			if (gotFocus && this.Record != null && this.Record == base.DataContext && !this.IsActive && !this.IsHeaderRecord && !this.Record.IsAncestorOf(this.DataPresenter.ActiveRecord))
			{
				this.IsActive = true;
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0007CF11 File Offset: 0x0007B111
		internal void PrepareContainerForItem(object item)
		{
			this.PrepareContainerForItem(item, item is global::Infragistics.Windows.DataPresenter.HeaderRecord);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0007CF24 File Offset: 0x0007B124
		internal virtual void PrepareContainerForItem(object item, bool isUsedForHeaderOnly)
		{
			if (item == null)
			{
				base.Visibility = global::System.Windows.Visibility.Collapsed;
				return;
			}
			object obj = base.ReadLocalValue(global::System.Windows.UIElement.VisibilityProperty);
			if (!(obj is global::System.Windows.Data.BindingExpression))
			{
				base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			}
			this._preparingItemForContainer = true;
			try
			{
				if (item is global::Infragistics.Windows.DataPresenter.HeaderRecord)
				{
					isUsedForHeaderOnly = true;
				}
				if (isUsedForHeaderOnly)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				this.InitializeRecord(item, isUsedForHeaderOnly);
				global::Infragistics.Windows.DataPresenter.Record record = this.Record;
				if (this.Record == null)
				{
					return;
				}
				if (record.FieldLayout == null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
				if (dataPresenter == null)
				{
					return;
				}
				this.FieldLayout = record.FieldLayout;
				this.CellPresentation = currentViewInternal.CellPresentation;
				base.SetBinding(global::Infragistics.Windows.DataPresenter.RecordPresenter.InternalVersionProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FieldLayout.InternalVersionProperty, global::System.Windows.Data.BindingMode.OneWay, this.FieldLayout));
				if (!isUsedForHeaderOnly)
				{
					this.InitializeIsFixedOnTopOrBottom();
				}
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.VisibilityToUse));
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Path = new global::System.Windows.PropertyPath("ExpansionIndicatorVisibility", new object[0]);
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				binding.Source = this.Record;
				base.SetBinding(global::Infragistics.Windows.DataPresenter.RecordPresenter.ExpansionIndicatorVisibilityProperty, binding);
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordContentAreaTemplatePropertyKey, this.RecordContentAreaTemplate);
				this.InitializeNestedDataContent();
				this._styleSelectorHelper.InvalidateStyle();
				this._cachedTemplate = base.Template;
				this._hasBeenPrepared = true;
				this._isTemplateDirty = true;
				this.SetTemplateBasedOnTemplateType();
				if ((bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsExpandedProperty))
				{
					this.ResyncIsExpandedState();
				}
				if (this._isAlternateInitialized)
				{
					this._isAlternateInitialized = false;
					this.InitializeIsAlternate();
				}
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardPropertyKey, (currentViewInternal is global::Infragistics.Windows.DataPresenter.CardView) ? global::Infragistics.KnownBoxes.TrueBox : global::Infragistics.KnownBoxes.FalseBox);
			}
			finally
			{
				this._preparingItemForContainer = false;
			}
			if (this._record != null)
			{
				this._record.InvalidatePeer();
			}
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0007D128 File Offset: 0x0007B328
		internal static void SetIsFilteredOutPropertyHelper(global::System.Windows.FrameworkElement fe, global::Infragistics.Windows.DataPresenter.Record record)
		{
			bool? flag = (record != null) ? record.InternalIsFilteredOutNullable_NoVerify : null;
			if (flag != null)
			{
				fe.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey, global::Infragistics.KnownBoxes.FromValue(flag.Value));
				return;
			}
			fe.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey);
			if (fe is global::Infragistics.Windows.DataPresenter.RecordPresenter && record != null && record.FieldLayout.IsTreeView)
			{
				((global::Infragistics.Windows.DataPresenter.RecordPresenter)fe).SynchronizeIsOpacityReduced();
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0007D199 File Offset: 0x0007B399
		internal void SynchronizeDescriptionProperty()
		{
			this._descSyncPending = false;
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.DescriptionPropertyKey, this.GetRecordDescription());
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0007D1B3 File Offset: 0x0007B3B3
		internal void SynchronizeDescriptionPropertyAsync()
		{
			if (this._descSyncPending)
			{
				return;
			}
			this._descSyncPending = true;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.SynchronizeDescriptionProperty));
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0007D1E0 File Offset: 0x0007B3E0
		private void SynchronizeSeparatorVisibility()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this._record;
			bool shouldDisplayRecordContent = this.ShouldDisplayRecordContent;
			global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility recordSeparatorVisibility = (record != null && this.ShouldDisplayRecordContent) ? record.SeparatorVisibility : global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.None;
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorAfterPropertyKey, global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.After == recordSeparatorVisibility);
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorBeforePropertyKey, global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.Before == recordSeparatorVisibility);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0007D238 File Offset: 0x0007B438
		internal void VerifyFixedFarTransform()
		{
			global::System.Windows.Media.TranslateTransform translateTransform = (global::System.Windows.Media.TranslateTransform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformProperty);
			global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo = (global::Infragistics.Windows.DataPresenter.FixedFieldInfo)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty);
			global::Infragistics.Windows.DataPresenter.RecordCellAreaBase cellArea = this.CellArea;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
			if (fixedFieldInfo == null || cellArea == null || fieldLayout == null)
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformPropertyKey);
				return;
			}
			bool isHorizontal = fieldLayout.IsHorizontal;
			double num = isHorizontal ? cellArea.ActualHeight : cellArea.ActualWidth;
			double num2 = global::System.Math.Min(fixedFieldInfo.Extent, global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel.CalculateFixedRecordAreaEdge(isHorizontal, num, this, null, this, false));
			double viewportExtent = fixedFieldInfo.ViewportExtent;
			double offset = fixedFieldInfo.Offset;
			double num3 = isHorizontal ? cellArea.RenderOffset.Y : cellArea.RenderOffset.X;
			double num4 = -global::System.Math.Min(num, global::System.Math.Max(num2 - viewportExtent - offset, 0.0));
			if (translateTransform == null)
			{
				translateTransform = new global::System.Windows.Media.TranslateTransform();
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformPropertyKey, translateTransform);
			}
			else if (isHorizontal)
			{
				translateTransform.X = 0.0;
			}
			else
			{
				translateTransform.Y = 0.0;
			}
			if (isHorizontal)
			{
				translateTransform.Y = num4 - num3;
				return;
			}
			translateTransform.X = num4 - num3;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0007D375 File Offset: 0x0007B575
		protected virtual void OnRecordChanged(global::Infragistics.Windows.DataPresenter.Record oldRecord, global::Infragistics.Windows.DataPresenter.Record newRecord)
		{
			this.SynchronizeSeparatorVisibility();
			this.UpdateVisualStates();
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0007D384 File Offset: 0x0007B584
		protected virtual void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.VerifyHasChildData();
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "Description":
			case "DescriptionWithSummaries":
				this.SynchronizeDescriptionPropertyAsync();
				break;
			case "ActiveCell":
			case "IsActive":
				this.IsActive = this.Record.IsActive;
				break;
			case "FilterAction":
				this.SynchronizeIsOpacityReduced();
				break;
			case "IsEnabledResolved":
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.Record.IsEnabledResolved));
				break;
			case "IsExpanded":
				this.ResyncIsExpandedState();
				this.InitializeNestedDataContent();
				if (this.IsExpanded)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
					if (dataPresenter == null || !dataPresenter.IsFlatView)
					{
						global::System.Windows.FrameworkElement frameworkElement = this;
						while (frameworkElement != null)
						{
							frameworkElement.InvalidateMeasure();
							frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(frameworkElement) as global::System.Windows.FrameworkElement);
							if (frameworkElement is global::Infragistics.Windows.DataPresenter.RecordListControl)
							{
								break;
							}
						}
					}
				}
				break;
			case "HasChildren":
				if (this.HasChildData != this._record.HasChildData || this.HasChildData != this.HasNestedContent)
				{
					this.InitializeNestedDataContent();
				}
				break;
			case "IsFilteredOut":
				global::Infragistics.Windows.DataPresenter.RecordPresenter.SetIsFilteredOutPropertyHelper(this, this.Record);
				break;
			case "IsFixed":
				if (this.Record.IsFixed)
				{
					if (this.Record.IsOnTopWhenFixed)
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey);
					}
					else
					{
						base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey);
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey);
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey);
				}
				break;
			case "IsSelected":
				this.IsSelected = this.Record.IsSelected;
				break;
			case "SeparatorVisibility":
				this.SynchronizeSeparatorVisibility();
				break;
			case "Visibility":
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.VisibilityToUse));
				break;
			}
			this.InitializeMinWidth();
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0007D63C File Offset: 0x0007B83C
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled || !this.IsRecordEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			if (this.IsActive)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Active", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
			}
			bool? isFilteredOut = this.IsFilteredOut;
			if (isFilteredOut != null && isFilteredOut.Value)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "FilteredOut", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "FilteredIn", useTransitions);
			}
			global::Infragistics.Windows.DataPresenter.Record record = this.Record;
			if (record != null && record.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Fixed", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unfixed", useTransitions);
			}
			if (this.IsSelected)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Selected", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Unselected", useTransitions);
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0007D720 File Offset: 0x0007B920
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				recordPresenter.UpdateVisualStates();
			}
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0007D73D File Offset: 0x0007B93D
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0007D746 File Offset: 0x0007B946
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0007D764 File Offset: 0x0007B964
		private double CalculateAutoFitExtent(bool isAutoFitWidth)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
			if (fieldLayout == null)
			{
				return double.NaN;
			}
			if (isAutoFitWidth)
			{
				if (!fieldLayout.IsAutoFitWidth)
				{
					return double.NaN;
				}
			}
			else if (!fieldLayout.IsAutoFitHeight)
			{
				return double.NaN;
			}
			if (this._parentContentPresenter == null)
			{
				return double.NaN;
			}
			double num;
			if (isAutoFitWidth)
			{
				num = this._parentContentPresenter.ActualWidth;
			}
			else
			{
				num = this._parentContentPresenter.ActualHeight;
			}
			if (double.IsNaN(num) || num < 1.0)
			{
				return double.NaN;
			}
			global::System.Windows.Thickness margin = base.Margin;
			global::System.Windows.Point point = base.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this._parentContentPresenter);
			if (isAutoFitWidth)
			{
				return global::System.Math.Max(num - (margin.Left + margin.Right + point.X), 0.0);
			}
			return global::System.Math.Max(num - (margin.Top + margin.Bottom + point.Y), 0.0);
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0007D876 File Offset: 0x0007BA76
		private void ClearLastLayoutExtent()
		{
			if (this._record != null)
			{
				this._record.LastLayoutExtent = 0.0;
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0007D894 File Offset: 0x0007BA94
		private static object CoerceClip(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null && recordPresenter._internalClip != null)
			{
				if (value == null)
				{
					recordPresenter._combinedClip = null;
					recordPresenter._explicitClip = null;
				}
				else
				{
					if (value != recordPresenter._explicitClip)
					{
						recordPresenter._explicitClip = (value as global::System.Windows.Media.Geometry);
						recordPresenter._combinedClip = ((recordPresenter._explicitClip == null) ? null : new global::System.Windows.Media.CombinedGeometry(recordPresenter._explicitClip, recordPresenter._internalClip));
					}
					if (recordPresenter._combinedClip != null)
					{
						return recordPresenter._combinedClip;
					}
				}
				return recordPresenter._internalClip;
			}
			return value;
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0007D914 File Offset: 0x0007BB14
		private static global::System.Windows.FrameworkElement FindFocusableDescendant(global::System.Windows.FrameworkElement parent)
		{
			if (parent.Focusable)
			{
				return parent;
			}
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(parent);
			if (childrenCount == 0)
			{
				return null;
			}
			global::System.Collections.Generic.Queue<global::System.Windows.FrameworkElement> queue = null;
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetChild(parent, i) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					if (frameworkElement.Focusable)
					{
						return frameworkElement;
					}
					if (queue == null)
					{
						queue = new global::System.Collections.Generic.Queue<global::System.Windows.FrameworkElement>();
					}
					queue.Enqueue(frameworkElement);
				}
			}
			if (queue != null)
			{
				foreach (global::System.Windows.FrameworkElement parent2 in queue)
				{
					global::System.Windows.FrameworkElement frameworkElement2 = global::Infragistics.Windows.DataPresenter.RecordPresenter.FindFocusableDescendant(parent2);
					if (frameworkElement2 != null)
					{
						return frameworkElement2;
					}
				}
			}
			return null;
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0007D9C8 File Offset: 0x0007BBC8
		private void InitializeIsAlternate()
		{
			if (!this._isAlternateInitialized)
			{
				bool flag = false;
				if (!this._cachedFieldLayout.HighlightAlternateRecordsResolved)
				{
					this._isAlternateInitialized = true;
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				}
				else
				{
					object dataContext = base.DataContext;
					if (dataContext != null)
					{
						int num = -1;
						global::Infragistics.Windows.DataPresenter.Record record = dataContext as global::Infragistics.Windows.DataPresenter.Record;
						if (record != null)
						{
							if (record is global::Infragistics.Windows.DataPresenter.DataRecord && !(record is global::Infragistics.Windows.DataPresenter.HeaderRecord))
							{
								num = ((global::Infragistics.Windows.DataPresenter.DataRecord)record).VisibleIndex;
							}
						}
						else if (base.Tag != global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateRecordPresenterId)
						{
							global::System.Windows.Controls.ItemsControl itemsControl = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::System.Windows.Controls.ItemsControl), true) as global::System.Windows.Controls.ItemsControl;
							if (itemsControl != null)
							{
								num = itemsControl.Items.IndexOf(dataContext);
							}
						}
						if (num >= 0)
						{
							flag = (num % 2 > 0);
							this._isAlternateInitialized = true;
							if (flag)
							{
								base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
							}
							else
							{
								base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternatePropertyKey);
							}
						}
					}
				}
				global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._cellArea) as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
				if (dataRecordCellArea != null && dataRecordCellArea.IsAlternate != flag)
				{
					dataRecordCellArea.SetIsAlternate(flag);
				}
			}
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0007DAD4 File Offset: 0x0007BCD4
		private void InitializeIsFixedOnTopOrBottom()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this.Record;
			if (record == null || !record.IsFixed)
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey);
				return;
			}
			if (record.IsOnTopWhenFixed)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey);
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0007DB4C File Offset: 0x0007BD4C
		private void InitializeFixedFieldInfo()
		{
			if (base.Tag == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateRecordPresenterId)
			{
				return;
			}
			if (this._isInitializeFixedFieldInfoPending)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter != null && !dataPresenter.IsSynchronousControl)
			{
				this._isInitializeFixedFieldInfoPending = true;
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.InitializeFixedFieldInfoImpl));
				return;
			}
			this.InitializeFixedFieldInfoImpl();
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0007DBAC File Offset: 0x0007BDAC
		private void InitializeFixedFieldInfoImpl()
		{
			this._isInitializeFixedFieldInfoPending = false;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FixedFieldInfo fixedFieldInfo = (dataPresenter != null) ? dataPresenter.GetFixedFieldInfo(this) : null;
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = this._nestedContent as global::Infragistics.Windows.DataPresenter.RecordListControl;
			if (fixedFieldInfo != null)
			{
				bool isFixedAreaVertical = dataPresenter.CurrentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal;
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty, fixedFieldInfo);
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformPropertyKey, fixedFieldInfo.GetTransform(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge, isFixedAreaVertical));
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformPropertyKey, fixedFieldInfo.GetTransform(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable, isFixedAreaVertical));
				base.SetBinding(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.OffsetProperty, global::System.Windows.Data.BindingMode.OneWay, fixedFieldInfo));
				base.SetBinding(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldViewportExtentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.FixedFieldInfo.ViewportExtentProperty, global::System.Windows.Data.BindingMode.OneWay, fixedFieldInfo));
			}
			else
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldInfoProperty);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldOffsetProperty);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFieldViewportExtentProperty);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformPropertyKey);
			}
			this.VerifyFixedFarTransform();
			if (recordListControl != null)
			{
				recordListControl.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformPropertyKey, this.FixedNearElementTransform);
				recordListControl.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformPropertyKey, this.ScrollableElementTransform);
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0007DCC4 File Offset: 0x0007BEC4
		private void InitializeMinWidth()
		{
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0007DCC8 File Offset: 0x0007BEC8
		internal void InitializeNestedDataContent()
		{
			if (this._record == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			bool flag = dataPresenter != null && dataPresenter.IsFlatView;
			if (flag && this._nestedContent == null)
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = this._record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
				if (expandableFieldRecord == null || expandableFieldRecord.Field.IsExpandableByDefault)
				{
					return;
				}
			}
			if (this.IsHeaderRecord)
			{
				return;
			}
			if (this.IsExpanded && !base.IsVisible)
			{
				this._nestedDataRequiresInitalization = true;
				return;
			}
			this._nestedDataRequiresInitalization = false;
			this.VerifyHasChildData();
			if (!this._record.IsExpanded)
			{
				if (this._nestedContent != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = this._nestedContent as global::Infragistics.Windows.DataPresenter.RecordListControl;
					if (recordListControl != null)
					{
						global::System.Windows.Data.BindingOperations.ClearAllBindings(recordListControl);
					}
					this._nestedContent = null;
				}
				this.InitializeNestedContent(null);
				return;
			}
			if (this.DataPresenter.IsReportControl)
			{
				return;
			}
			if (!this.DataPresenter.IsNestedDataDisplayEnabled)
			{
				return;
			}
			if (this.CellPresentation != global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)
			{
				return;
			}
			bool flag2 = false;
			if (!this.HasChildData)
			{
				global::Infragistics.Windows.DataPresenter.RecordType recordType = this._record.RecordType;
				if (recordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
				{
					flag2 = true;
				}
				if (!flag2)
				{
					return;
				}
			}
			else if (this._record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord && this._record.HasChildrenInternal)
			{
				flag2 = true;
			}
			global::System.Windows.FrameworkElement nestedContent;
			if (this._record.HasVisibleChildren || flag2)
			{
				if (this.DataPresenter.IsFlatView)
				{
					this.InitializeNestedContent(null);
					return;
				}
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl2 = this._nestedContent as global::Infragistics.Windows.DataPresenter.RecordListControl;
				if (recordListControl2 == null)
				{
					recordListControl2 = new global::Infragistics.Windows.DataPresenter.RecordListControl(this.DataPresenter, false);
				}
				recordListControl2.SetBinding(global::System.Windows.Controls.ItemsControl.ItemsPanelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ItemsPanelProperty, global::System.Windows.Data.BindingMode.OneWay, this.DataPresenter));
				recordListControl2.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformPropertyKey, this.FixedNearElementTransform);
				recordListControl2.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformPropertyKey, this.ScrollableElementTransform);
				global::System.Windows.Style recordListControlStyle = this.DataPresenter.GetRecordListControlStyle(this._record.FieldLayout);
				if (recordListControlStyle != null)
				{
					recordListControl2.Style = recordListControlStyle;
				}
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
				binding.Source = this._record;
				binding.Path = new global::System.Windows.PropertyPath("ViewableChildRecords", new object[0]);
				recordListControl2.SetBinding(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty, binding);
				nestedContent = recordListControl2;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord2 = this._record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
				if (expandableFieldRecord2 == null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter expandedCellPresenter = this._nestedContent as global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter;
				if (expandedCellPresenter == null)
				{
					expandedCellPresenter = new global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter(this.DataPresenter, expandableFieldRecord2);
				}
				expandedCellPresenter.DataContext = expandableFieldRecord2.ParentDataRecord;
				expandedCellPresenter.Field = expandableFieldRecord2.Field;
				expandedCellPresenter.Orientation = this.Orientation;
				expandedCellPresenter.Content = expandableFieldRecord2.ParentDataRecord.GetCellValue(expandableFieldRecord2.Field, true);
				nestedContent = expandedCellPresenter;
			}
			this.InitializeNestedContent(nestedContent);
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0007DF64 File Offset: 0x0007C164
		private void InitializeRecord(object item, bool isUsedForHeaderOnly)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != this._record)
			{
				global::Infragistics.Windows.DataPresenter.Record record2 = this._record;
				if (this._record != null && !isUsedForHeaderOnly)
				{
					global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._record, this, string.Empty);
					if (this._record.AssociatedRecordPresenter == this)
					{
						this._record.AssociatedRecordPresenter = null;
					}
				}
				this._record = record;
				if (this._record != null)
				{
					this._hasRecordEverBeenInitialized = true;
					if (!isUsedForHeaderOnly)
					{
						global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._record, this, string.Empty);
						this._record.AssociatedRecordPresenter = this;
						this.SynchronizeDescriptionProperty();
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(this._record.IsActive));
						this.ResyncIsExpandedState();
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(this._record.IsSelected));
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilterRecordPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._record is global::Infragistics.Windows.DataPresenter.FilterRecord));
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._record.IsEnabledResolved));
						global::Infragistics.Windows.DataPresenter.RecordPresenter.SetIsFilteredOutPropertyHelper(this, this._record);
					}
					else if (this._record is global::Infragistics.Windows.DataPresenter.HeaderRecord)
					{
						this._record.AssociatedRecordPresenter = this;
					}
					if (isUsedForHeaderOnly)
					{
						base.CoerceValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ExpansionIndicatorVisibilityProperty);
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordPropertyKey, this._record);
				}
				this.OnRecordChanged(record2, this._record);
			}
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0007E0CC File Offset: 0x0007C2CC
		private void InitializeVersionInfo()
		{
			if (this._cachedFieldLayout != null && this._cachedFieldLayout.DataPresenter != null)
			{
				if (this._headerContent != null && !(this.Record is global::Infragistics.Windows.DataPresenter.HeaderRecord))
				{
					this._headerContent = null;
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HeaderContentPropertyKey, null);
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				}
				if (this._cachedFieldLayout.StyleGenerator != null)
				{
					int internalVersion = this.InternalVersion;
					if (this._cachedVersion != internalVersion)
					{
						base.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
						base.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
						this.InitializeMinWidth();
						this._isAlternateInitialized = false;
						this._cachedVersion = internalVersion;
						if (this._versionInitialized)
						{
							if (!this._preparingItemForContainer)
							{
								this._styleSelectorHelper.InvalidateStyle();
							}
							if (this is global::Infragistics.Windows.DataPresenter.DataRecordPresenter || this is global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter)
							{
								base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordContentAreaTemplatePropertyKey, this.RecordContentAreaTemplate);
							}
						}
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.OrientationPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.FieldLayout.StyleGenerator.LogicalOrientation));
						global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.DataPresenter.CurrentViewInternal;
						this.CellPresentation = currentViewInternal.CellPresentation;
						global::Infragistics.Windows.DataPresenter.Record record = this.Record;
						int scrollCountInternal = record.ScrollCountInternal;
						global::System.Windows.Visibility expansionIndicatorVisibility = record.ExpansionIndicatorVisibility;
						if ((this is global::Infragistics.Windows.DataPresenter.DataRecordPresenter || this is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter) && currentViewInternal.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.CardView)
						{
							record.IsExpanded = false;
						}
					}
					this.InitializeIsAlternate();
					this.InitializeMinWidth();
					this.InitializeFixedFieldInfo();
					this._versionInitialized = true;
				}
			}
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0007E23C File Offset: 0x0007C43C
		private void OnAutoFitExtentChanged()
		{
			if (!this._layoutUpdatedWired && (base.IsVisible || base.DataContext != null))
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter != null)
				{
					this._layoutUpdatedWired = true;
					dataPresenter.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
				}
			}
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0007E284 File Offset: 0x0007C484
		private void OnExpansionIndicatorClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleRecordIsExpanded.CanExecute(this.Record, this))
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleRecordIsExpanded.Execute(this.Record, this);
			}
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0007E2AA File Offset: 0x0007C4AA
		private void OnLayoutUpdated()
		{
			if (this._layoutUpdatedWired)
			{
				if (this._asyncAutoFit != null)
				{
					this._asyncAutoFit.Abort();
					this._asyncAutoFit = null;
				}
				this._layoutUpdatedWired = false;
				this.UpdateAutoFitProperties();
			}
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0007E2DC File Offset: 0x0007C4DC
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			this.RaiseNestedContentEvent(this.HasNestedContent);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0007E2FC File Offset: 0x0007C4FC
		private void RaiseNestedContentEvent(bool show)
		{
			if (this.VisualChildrenCount == 0)
			{
				return;
			}
			if (show)
			{
				this.RaiseShowNestedContent(new global::System.Windows.RoutedEventArgs());
				return;
			}
			this.RaiseHideNestedContent(new global::System.Windows.RoutedEventArgs());
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0007E321 File Offset: 0x0007C521
		private void OnUpdateAutoFitAsync()
		{
			if (this._asyncAutoFit != null)
			{
				this._asyncAutoFit = null;
				this.UpdateAutoFitProperties();
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0007E338 File Offset: 0x0007C538
		private void SetTemplateBasedOnTemplateType()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter != null && (this._record == null || !this._hasBeenPrepared || !base.IsInitialized))
			{
				return;
			}
			this._isTemplateDirty = false;
			global::System.Windows.DependencyProperty dependencyProperty;
			if (this.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)
			{
				dependencyProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty;
			}
			else
			{
				dependencyProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty;
			}
			global::System.Windows.Controls.ControlTemplate controlTemplate = (global::System.Windows.Controls.ControlTemplate)base.GetValue(dependencyProperty);
			if (controlTemplate != null && controlTemplate == this.GetDefaultTemplateProperty(dependencyProperty) && this._cachedTemplate != null && this._cachedTemplate != this.GetDefaultTemplateProperty(global::System.Windows.Controls.Control.TemplateProperty))
			{
				controlTemplate = this._cachedTemplate;
			}
			try
			{
				this._isSwappingTemplate = true;
				if (controlTemplate == null)
				{
					if (this._cachedTemplate != null && this._cachedTemplate != this.GetDefaultTemplateProperty(global::System.Windows.Controls.Control.TemplateProperty))
					{
						controlTemplate = this._cachedTemplate;
					}
					if (controlTemplate == null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase.SetDefaultValue(dataPresenter, this, global::System.Windows.Controls.Control.TemplateProperty, dependencyProperty, true);
						return;
					}
				}
				base.Template = controlTemplate;
			}
			finally
			{
				this._isSwappingTemplate = false;
			}
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0007E428 File Offset: 0x0007C628
		internal virtual void UpdateAutoFitProperties()
		{
			if (!this._isArrangedInView)
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitHeightPropertyKey);
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitVersionPropertyKey);
				return;
			}
			if (this.IsHeaderRecord)
			{
				if (!this.HasHeaderContent)
				{
					return;
				}
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Record record = this.Record;
				if (record == null || !record.OccupiesScrollPosition)
				{
					return;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
			if (fieldLayout == null)
			{
				return;
			}
			if (fieldLayout.IsAutoFitWidth)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitWidthPropertyKey, this.AutoFitWidth);
			}
			else
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitWidthPropertyKey);
			}
			if (fieldLayout.IsAutoFitHeight)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitHeightPropertyKey, this.AutoFitHeight);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitHeightPropertyKey);
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0007E4D8 File Offset: 0x0007C6D8
		private void VerifyHasChildData()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			if (dataPresenter == null || !dataPresenter.IsNestedDataDisplayEnabled)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasChildDataPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record record = this.Record;
			if (record == null)
			{
				return;
			}
			global::System.Windows.Visibility expansionIndicatorVisibility = record.ExpansionIndicatorVisibility;
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasChildDataPropertyKey, global::Infragistics.KnownBoxes.FromValue(record.HasChildData));
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0007E530 File Offset: 0x0007C730
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectableElement.SelectableItem
		{
			get
			{
				if (this._record is global::Infragistics.Windows.DataPresenter.FilterRecord)
				{
					return null;
				}
				return this._record;
			}
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0007E548 File Offset: 0x0007C748
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					this.OnRecordPropertyChanged(propertyChangedEventArgs);
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000AFD RID: 2813
		private int _cachedVersion;

		// Token: 0x04000AFE RID: 2814
		private bool _versionInitialized;

		// Token: 0x04000AFF RID: 2815
		private bool _isAlternateInitialized;

		// Token: 0x04000B00 RID: 2816
		private bool _isArrangedInView = true;

		// Token: 0x04000B01 RID: 2817
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000B02 RID: 2818
		private object _nestedContent;

		// Token: 0x04000B03 RID: 2819
		private object _headerContent;

		// Token: 0x04000B04 RID: 2820
		private global::Infragistics.Windows.DataPresenter.RecordPresenter.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x04000B05 RID: 2821
		private bool _isBoundaryRecord;

		// Token: 0x04000B06 RID: 2822
		private bool _ignoreNextRecordsInViewVersionPropertyChange;

		// Token: 0x04000B07 RID: 2823
		private bool _preparingItemForContainer;

		// Token: 0x04000B08 RID: 2824
		private bool _hasBeenPrepared;

		// Token: 0x04000B09 RID: 2825
		private bool _shouldDisplayExpandableRecordContent = true;

		// Token: 0x04000B0A RID: 2826
		private bool _shouldDisplayGroupByRecordContent = true;

		// Token: 0x04000B0B RID: 2827
		private bool _shouldDisplayRecordContent = true;

		// Token: 0x04000B0C RID: 2828
		private bool _isSwappingTemplate;

		// Token: 0x04000B0D RID: 2829
		private bool _isTemplateDirty = true;

		// Token: 0x04000B0E RID: 2830
		private bool _isClearingBindings;

		// Token: 0x04000B0F RID: 2831
		private bool _hasRecordEverBeenInitialized;

		// Token: 0x04000B10 RID: 2832
		private bool _descSyncPending;

		// Token: 0x04000B11 RID: 2833
		private global::System.Windows.Controls.ControlTemplate _cachedTemplate;

		// Token: 0x04000B12 RID: 2834
		private global::System.Windows.FrameworkElement _parentContentPresenter;

		// Token: 0x04000B13 RID: 2835
		private global::Infragistics.Windows.Internal.PropertyValueTracker _parentCPWidthTracker;

		// Token: 0x04000B14 RID: 2836
		private global::Infragistics.Windows.Internal.PropertyValueTracker _parentCPHeightTracker;

		// Token: 0x04000B15 RID: 2837
		private bool _isActiveFixedRecord;

		// Token: 0x04000B16 RID: 2838
		private bool _isActiveHeaderRecord;

		// Token: 0x04000B17 RID: 2839
		private bool _treatAsCollapsed;

		// Token: 0x04000B18 RID: 2840
		private bool _layoutUpdatedWired;

		// Token: 0x04000B19 RID: 2841
		private global::System.Windows.Threading.DispatcherOperation _asyncAutoFit;

		// Token: 0x04000B1A RID: 2842
		private global::System.WeakReference _cellArea;

		// Token: 0x04000B1B RID: 2843
		private global::System.WeakReference _weakRef;

		// Token: 0x04000B1C RID: 2844
		private bool _nestedDataRequiresInitalization;

		// Token: 0x04000B1D RID: 2845
		private global::System.Windows.Media.Geometry _internalClip;

		// Token: 0x04000B1E RID: 2846
		private global::System.Windows.Media.Geometry _explicitClip;

		// Token: 0x04000B1F RID: 2847
		private global::System.Windows.Media.CombinedGeometry _combinedClip;

		// Token: 0x04000B20 RID: 2848
		private global::Infragistics.Windows.Controls.ExpansionIndicator _expansionIndicator;

		// Token: 0x04000B21 RID: 2849
		private bool _isInitializeFixedFieldInfoPending;

		// Token: 0x04000B22 RID: 2850
		private global::System.Windows.FrameworkElement _treeExpander;

		// Token: 0x04000B23 RID: 2851
		private bool _isSynchingExpandedState;

		// Token: 0x04000B24 RID: 2852
		private bool _hasVisualStateGroups;

		// Token: 0x04000B27 RID: 2855
		public static readonly global::System.Windows.DependencyProperty CellPresentationProperty;

		// Token: 0x04000B28 RID: 2856
		private static readonly global::System.Windows.DependencyPropertyKey DescriptionPropertyKey;

		// Token: 0x04000B29 RID: 2857
		public static readonly global::System.Windows.DependencyProperty DescriptionProperty;

		// Token: 0x04000B2A RID: 2858
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorVisibilityProperty;

		// Token: 0x04000B2B RID: 2859
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty;

		// Token: 0x04000B2C RID: 2860
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x04000B2D RID: 2861
		internal static readonly global::System.Windows.DependencyPropertyKey FixedNearElementTransformPropertyKey;

		// Token: 0x04000B2E RID: 2862
		public static readonly global::System.Windows.DependencyProperty FixedNearElementTransformProperty;

		// Token: 0x04000B2F RID: 2863
		private static readonly global::System.Windows.DependencyPropertyKey FixedFarElementTransformPropertyKey;

		// Token: 0x04000B30 RID: 2864
		public static readonly global::System.Windows.DependencyProperty FixedFarElementTransformProperty;

		// Token: 0x04000B31 RID: 2865
		private static readonly global::System.Windows.DependencyPropertyKey HasChildDataPropertyKey;

		// Token: 0x04000B32 RID: 2866
		public static readonly global::System.Windows.DependencyProperty HasChildDataProperty;

		// Token: 0x04000B33 RID: 2867
		private static readonly global::System.Windows.DependencyPropertyKey HasHeaderContentPropertyKey;

		// Token: 0x04000B34 RID: 2868
		public static readonly global::System.Windows.DependencyProperty HasHeaderContentProperty;

		// Token: 0x04000B35 RID: 2869
		private static readonly global::System.Windows.DependencyPropertyKey HasNestedContentPropertyKey;

		// Token: 0x04000B36 RID: 2870
		public static readonly global::System.Windows.DependencyProperty HasNestedContentProperty;

		// Token: 0x04000B37 RID: 2871
		private static readonly global::System.Windows.DependencyPropertyKey HasSeparatorAfterPropertyKey;

		// Token: 0x04000B38 RID: 2872
		public static readonly global::System.Windows.DependencyProperty HasSeparatorAfterProperty;

		// Token: 0x04000B39 RID: 2873
		private static readonly global::System.Windows.DependencyPropertyKey HasSeparatorBeforePropertyKey;

		// Token: 0x04000B3A RID: 2874
		public static readonly global::System.Windows.DependencyProperty HasSeparatorBeforeProperty;

		// Token: 0x04000B3B RID: 2875
		private static readonly global::System.Windows.DependencyPropertyKey HeaderContentPropertyKey;

		// Token: 0x04000B3C RID: 2876
		public static readonly global::System.Windows.DependencyProperty HeaderContentProperty;

		// Token: 0x04000B3D RID: 2877
		internal static readonly global::System.Windows.DependencyPropertyKey IsAlternatePropertyKey;

		// Token: 0x04000B3E RID: 2878
		public static readonly global::System.Windows.DependencyProperty IsAlternateProperty;

		// Token: 0x04000B3F RID: 2879
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;

		// Token: 0x04000B40 RID: 2880
		private bool _cachedIsActive;

		// Token: 0x04000B41 RID: 2881
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty;

		// Token: 0x04000B42 RID: 2882
		internal static readonly global::System.Windows.DependencyPropertyKey IsFilterRecordPropertyKey;

		// Token: 0x04000B43 RID: 2883
		public static readonly global::System.Windows.DependencyProperty IsFilterRecordProperty;

		// Token: 0x04000B44 RID: 2884
		internal static readonly global::System.Windows.DependencyPropertyKey IsFilteredOutPropertyKey;

		// Token: 0x04000B45 RID: 2885
		public static readonly global::System.Windows.DependencyProperty IsFilteredOutProperty;

		// Token: 0x04000B46 RID: 2886
		internal static readonly global::System.Windows.DependencyPropertyKey IsFixedOnBottomPropertyKey;

		// Token: 0x04000B47 RID: 2887
		public static readonly global::System.Windows.DependencyProperty IsFixedOnBottomProperty;

		// Token: 0x04000B48 RID: 2888
		internal static readonly global::System.Windows.DependencyPropertyKey IsFixedOnTopPropertyKey;

		// Token: 0x04000B49 RID: 2889
		public static readonly global::System.Windows.DependencyProperty IsFixedOnTopProperty;

		// Token: 0x04000B4A RID: 2890
		private static readonly global::System.Windows.DependencyPropertyKey IsHeaderRecordPropertyKey;

		// Token: 0x04000B4B RID: 2891
		public static readonly global::System.Windows.DependencyProperty IsHeaderRecordProperty;

		// Token: 0x04000B4C RID: 2892
		private static readonly global::System.Windows.DependencyPropertyKey IsInCardPropertyKey;

		// Token: 0x04000B4D RID: 2893
		public static readonly global::System.Windows.DependencyProperty IsInCardProperty;

		// Token: 0x04000B4E RID: 2894
		internal static readonly global::System.Windows.DependencyPropertyKey IsOpacityReducedPropertyKey;

		// Token: 0x04000B4F RID: 2895
		public static readonly global::System.Windows.DependencyProperty IsOpacityReducedProperty;

		// Token: 0x04000B50 RID: 2896
		internal static readonly global::System.Windows.DependencyPropertyKey IsRecordEnabledPropertyKey;

		// Token: 0x04000B51 RID: 2897
		public static readonly global::System.Windows.DependencyProperty IsRecordEnabledProperty;

		// Token: 0x04000B52 RID: 2898
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x04000B53 RID: 2899
		private static readonly global::System.Windows.DependencyPropertyKey NestedContentPropertyKey;

		// Token: 0x04000B54 RID: 2900
		public static readonly global::System.Windows.DependencyProperty NestedContentProperty;

		// Token: 0x04000B55 RID: 2901
		private static readonly global::System.Windows.DependencyPropertyKey NestedContentMarginPropertyKey;

		// Token: 0x04000B56 RID: 2902
		public static readonly global::System.Windows.DependencyProperty NestedContentMarginProperty;

		// Token: 0x04000B57 RID: 2903
		public static readonly global::System.Windows.DependencyProperty NestedContentBackgroundProperty;

		// Token: 0x04000B58 RID: 2904
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey;

		// Token: 0x04000B59 RID: 2905
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;

		// Token: 0x04000B5A RID: 2906
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey;

		// Token: 0x04000B5B RID: 2907
		public static readonly global::System.Windows.DependencyProperty RecordProperty;

		// Token: 0x04000B5C RID: 2908
		private static readonly global::System.Windows.DependencyPropertyKey RecordContentAreaTemplatePropertyKey;

		// Token: 0x04000B5D RID: 2909
		public static readonly global::System.Windows.DependencyProperty RecordContentAreaTemplateProperty;

		// Token: 0x04000B5E RID: 2910
		internal static readonly global::System.Windows.DependencyPropertyKey ScrollableElementTransformPropertyKey;

		// Token: 0x04000B5F RID: 2911
		public static readonly global::System.Windows.DependencyProperty ScrollableElementTransformProperty;

		// Token: 0x04000B60 RID: 2912
		private static readonly global::System.Windows.DependencyPropertyKey ShouldDisplayExpandableRecordContentPropertyKey;

		// Token: 0x04000B61 RID: 2913
		public static readonly global::System.Windows.DependencyProperty ShouldDisplayExpandableRecordContentProperty;

		// Token: 0x04000B62 RID: 2914
		private static readonly global::System.Windows.DependencyPropertyKey ShouldDisplayGroupByRecordContentPropertyKey;

		// Token: 0x04000B63 RID: 2915
		public static readonly global::System.Windows.DependencyProperty ShouldDisplayGroupByRecordContentProperty;

		// Token: 0x04000B64 RID: 2916
		private static readonly global::System.Windows.DependencyPropertyKey ShouldDisplayRecordContentPropertyKey;

		// Token: 0x04000B65 RID: 2917
		public static readonly global::System.Windows.DependencyProperty ShouldDisplayRecordContentProperty;

		// Token: 0x04000B66 RID: 2918
		public static readonly global::System.Windows.DependencyProperty TemplateCardViewProperty;

		// Token: 0x04000B67 RID: 2919
		public static readonly global::System.Windows.DependencyProperty TemplateGridViewProperty;

		// Token: 0x04000B68 RID: 2920
		private static readonly global::System.Windows.DependencyPropertyKey AutoFitHeightPropertyKey;

		// Token: 0x04000B69 RID: 2921
		internal static readonly global::System.Windows.DependencyProperty AutoFitHeightProperty;

		// Token: 0x04000B6A RID: 2922
		private static readonly global::System.Windows.DependencyPropertyKey AutoFitWidthPropertyKey;

		// Token: 0x04000B6B RID: 2923
		internal static readonly global::System.Windows.DependencyProperty AutoFitWidthProperty;

		// Token: 0x04000B6C RID: 2924
		internal static readonly global::System.Windows.DependencyProperty FixedFieldInfoProperty;

		// Token: 0x04000B6D RID: 2925
		internal static readonly global::System.Windows.DependencyProperty RecordsInViewVersionProperty;

		// Token: 0x04000B6E RID: 2926
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty;

		// Token: 0x04000B6F RID: 2927
		private static readonly global::System.Windows.DependencyPropertyKey RecordManagerForHeaderPropertyKey;

		// Token: 0x04000B70 RID: 2928
		internal static readonly global::System.Windows.DependencyProperty RecordManagerForHeaderProperty;

		// Token: 0x04000B71 RID: 2929
		private static readonly global::System.Windows.DependencyPropertyKey AutoFitVersionPropertyKey;

		// Token: 0x04000B72 RID: 2930
		private static readonly global::System.Windows.DependencyProperty AutoFitVersionProperty;

		// Token: 0x04000B73 RID: 2931
		internal static readonly global::System.Windows.DependencyProperty FixedFieldOffsetProperty;

		// Token: 0x04000B74 RID: 2932
		internal static readonly global::System.Windows.DependencyProperty FixedFieldViewportExtentProperty;

		// Token: 0x04000B75 RID: 2933
		private static readonly global::System.Windows.DependencyProperty ParentRecordAutoFitVersionProperty;

		// Token: 0x04000B76 RID: 2934
		private static global::System.Windows.DependencyProperty TemplateVersionProperty;

		// Token: 0x04000B77 RID: 2935
		private static readonly global::System.Windows.DependencyPropertyKey VisibilityResolvedPropertyKey;

		// Token: 0x04000B78 RID: 2936
		private static readonly global::System.Windows.DependencyProperty VisibilityResolvedProperty;

		// Token: 0x04000B79 RID: 2937
		internal static readonly object TemplateRecordPresenterId;

		// Token: 0x020001D2 RID: 466
		private class MinWidthConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06001BF0 RID: 7152 RVA: 0x0007E57B File Offset: 0x0007C77B
			internal MinWidthConverter()
			{
			}

			// Token: 0x06001BF1 RID: 7153 RVA: 0x0007E584 File Offset: 0x0007C784
			object global::System.Windows.Data.IValueConverter.Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				if (value is double)
				{
					double num = (double)value;
					num -= 6.0;
					num -= global::System.Windows.SystemParameters.VerticalScrollBarWidth;
					num = global::System.Math.Max(num, 0.0);
					return num;
				}
				return value;
			}

			// Token: 0x06001BF2 RID: 7154 RVA: 0x0007E5CC File Offset: 0x0007C7CC
			object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return value;
			}
		}

		// Token: 0x020001D3 RID: 467
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06001BF3 RID: 7155 RVA: 0x0007E5CF File Offset: 0x0007C7CF
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.RecordPresenter rp) : base(rp)
			{
				this._rp = rp;
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x0007E5E0 File Offset: 0x0007C7E0
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._rp == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._rp.FieldLayout;
					if (fieldLayout != null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
						if (dataPresenter != null)
						{
							return dataPresenter.InternalRecordStyleSelector.SelectStyle(this._rp.Record, this._rp);
						}
					}
					return null;
				}
			}

			// Token: 0x04000B7B RID: 2939
			private global::Infragistics.Windows.DataPresenter.RecordPresenter _rp;
		}
	}
}
