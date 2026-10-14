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
	// Token: 0x020001AE RID: 430
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Fixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplatePart(Name = "PART_HeaderContentSite", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilteredIn", GroupName = "FilterStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilteredOut", GroupName = "FilterStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplatePart(Name = "PART_RecordContentSite", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_NestedContentSite", Type = typeof(global::System.Windows.FrameworkElement))]
	public abstract class RecordPresenter : global::System.Windows.Controls.Control, global::Infragistics.Windows.Selection.ISelectableElement, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06001785 RID: 6021 RVA: 0x00067CBC File Offset: 0x00065EBC
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
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFilteredOut", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixedOnBottom", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixedOnTop", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPresenter.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsHeaderRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsInCard", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardPropertyKey.DependencyProperty;
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

		// Token: 0x06001786 RID: 6022 RVA: 0x0006884C File Offset: 0x00066A4C
		protected RecordPresenter()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.RecordPresenter.StyleSelectorHelper(this);
			base.SetBinding(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedProperty, global::System.Windows.Data.BindingMode.OneWay, this));
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x000688A8 File Offset: 0x00066AA8
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

		// Token: 0x06001788 RID: 6024 RVA: 0x00068900 File Offset: 0x00066B00
		private static void ExecuteCommandHandler(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = sender as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				recordPresenter.ExecuteCommandImpl(e.Command as global::System.Windows.Input.RoutedCommand, e.Parameter, e.Source, e.OriginalSource);
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0006893C File Offset: 0x00066B3C
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

		// Token: 0x0600178A RID: 6026 RVA: 0x0006897C File Offset: 0x00066B7C
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

		// Token: 0x0600178B RID: 6027 RVA: 0x00068A10 File Offset: 0x00066C10
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

		// Token: 0x0600178C RID: 6028 RVA: 0x00068DB8 File Offset: 0x00066FB8
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

		// Token: 0x0600178D RID: 6029 RVA: 0x00068E90 File Offset: 0x00067090
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
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

		// Token: 0x0600178E RID: 6030 RVA: 0x00068F2A File Offset: 0x0006712A
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordPresenterAutomationPeer(this);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00068F34 File Offset: 0x00067134
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

		// Token: 0x06001790 RID: 6032 RVA: 0x00068FA4 File Offset: 0x000671A4
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
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
					return;
				}
			}
			else if (property == global::System.Windows.Controls.Control.TemplateProperty)
			{
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
					}
				}
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000691EC File Offset: 0x000673EC
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

		// Token: 0x06001792 RID: 6034 RVA: 0x0006922B File Offset: 0x0006742B
		protected virtual void OnHideNestedContent(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00069234 File Offset: 0x00067434
		internal void RaiseHideNestedContent(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.RecordPresenter.HideNestedContentEvent;
			args.Source = this;
			this.OnHideNestedContent(args);
		}

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06001794 RID: 6036 RVA: 0x0006924F File Offset: 0x0006744F
		// (remove) Token: 0x06001795 RID: 6037 RVA: 0x0006925D File Offset: 0x0006745D
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

		// Token: 0x06001796 RID: 6038 RVA: 0x0006926B File Offset: 0x0006746B
		protected virtual void OnShowNestedContent(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00069274 File Offset: 0x00067474
		internal void RaiseShowNestedContent(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.RecordPresenter.ShowNestedContentEvent;
			args.Source = this;
			this.OnShowNestedContent(args);
		}

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06001798 RID: 6040 RVA: 0x0006928F File Offset: 0x0006748F
		// (remove) Token: 0x06001799 RID: 6041 RVA: 0x0006929D File Offset: 0x0006749D
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

		// Token: 0x0600179A RID: 6042 RVA: 0x000692AC File Offset: 0x000674AC
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

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x000692DF File Offset: 0x000674DF
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x000692F1 File Offset: 0x000674F1
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

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00069304 File Offset: 0x00067504
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

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00069323 File Offset: 0x00067523
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

		// Token: 0x0600179F RID: 6047 RVA: 0x00069344 File Offset: 0x00067544
		private static object CoerceExpansionIndicatorVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = (global::Infragistics.Windows.DataPresenter.RecordPresenter)d;
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

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x000693B7 File Offset: 0x000675B7
		// (set) Token: 0x060017A1 RID: 6049 RVA: 0x000693C9 File Offset: 0x000675C9
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

		// Token: 0x060017A2 RID: 6050 RVA: 0x000693DC File Offset: 0x000675DC
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

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00069436 File Offset: 0x00067636
		// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0006943E File Offset: 0x0006763E
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

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x0006944C File Offset: 0x0006764C
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Transform FixedNearElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedNearElementTransformProperty);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0006945E File Offset: 0x0006765E
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Transform FixedFarElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.FixedFarElementTransformProperty);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00069470 File Offset: 0x00067670
		public bool HasChildData
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasChildDataProperty);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00069482 File Offset: 0x00067682
		public bool HasHeaderContent
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasHeaderContentProperty);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00069494 File Offset: 0x00067694
		public bool HasNestedContent
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentProperty);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x000694A6 File Offset: 0x000676A6
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasSeparatorAfter
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorAfterProperty);
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x000694B8 File Offset: 0x000676B8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasSeparatorBefore
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorBeforeProperty);
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x000694CA File Offset: 0x000676CA
		public object HeaderContent
		{
			get
			{
				return this._headerContent;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x000694D2 File Offset: 0x000676D2
		public bool IsAlternate
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsAlternateProperty);
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000694E4 File Offset: 0x000676E4
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

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x00069592 File Offset: 0x00067792
		// (set) Token: 0x060017B0 RID: 6064 RVA: 0x0006959A File Offset: 0x0006779A
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

		// Token: 0x060017B1 RID: 6065 RVA: 0x000695B0 File Offset: 0x000677B0
		private static object CoerceIsExpanded(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.Record record = recordPresenter.Record;
				if (record != null && recordPresenter.DataPresenter != null)
				{
					record.IsExpanded = (bool)value;
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

		// Token: 0x060017B2 RID: 6066 RVA: 0x0006962C File Offset: 0x0006782C
		private void ResyncIsExpandedState()
		{
			if (this._record != null)
			{
				this.IsExpanded = this._record.IsExpanded;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00069648 File Offset: 0x00067848
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x00069667 File Offset: 0x00067867
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

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0006967A File Offset: 0x0006787A
		public bool IsFilterRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilterRecordProperty);
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0006968C File Offset: 0x0006788C
		public bool? IsFilteredOut
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutProperty);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x0006969E File Offset: 0x0006789E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsFixedOnBottom
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnBottomProperty);
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x000696B0 File Offset: 0x000678B0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsFixedOnTop
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFixedOnTopProperty);
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x000696C2 File Offset: 0x000678C2
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsHeaderRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsHeaderRecordProperty);
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x000696D4 File Offset: 0x000678D4
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsInCard
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsInCardProperty);
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x000696E6 File Offset: 0x000678E6
		public bool IsRecordEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledProperty);
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x000696F8 File Offset: 0x000678F8
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00069740 File Offset: 0x00067940
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x0006975F File Offset: 0x0006795F
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

		// Token: 0x060017BF RID: 6079 RVA: 0x00069772 File Offset: 0x00067972
		internal void InitializeNestedContent(object nestedContent)
		{
			this._nestedContent = nestedContent;
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentPropertyKey, this._nestedContent);
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasNestedContentPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._nestedContent != null));
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x000697A8 File Offset: 0x000679A8
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

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x000697CE File Offset: 0x000679CE
		public global::System.Windows.Thickness NestedContentMargin
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.NestedContentMarginProperty);
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x000697E0 File Offset: 0x000679E0
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x000697F2 File Offset: 0x000679F2
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

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00069800 File Offset: 0x00067A00
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.OrientationProperty);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x00069812 File Offset: 0x00067A12
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0006981C File Offset: 0x00067A1C
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

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x00069879 File Offset: 0x00067A79
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Media.Transform ScrollableElementTransform
		{
			get
			{
				return (global::System.Windows.Media.Transform)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ScrollableElementTransformProperty);
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0006988B File Offset: 0x00067A8B
		public bool ShouldDisplayExpandableRecordContent
		{
			get
			{
				return this._shouldDisplayExpandableRecordContent;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x00069893 File Offset: 0x00067A93
		public bool ShouldDisplayGroupByRecordContent
		{
			get
			{
				return this._shouldDisplayGroupByRecordContent;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0006989B File Offset: 0x00067A9B
		public bool ShouldDisplayRecordContent
		{
			get
			{
				return this._shouldDisplayRecordContent;
			}
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x000698A4 File Offset: 0x00067AA4
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

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x000698FA File Offset: 0x00067AFA
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x0006990C File Offset: 0x00067B0C
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

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x0006991A File Offset: 0x00067B1A
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x0006992C File Offset: 0x00067B2C
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

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0006993A File Offset: 0x00067B3A
		internal double AutoFitHeight
		{
			get
			{
				return this.CalculateAutoFitExtent(false);
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x00069943 File Offset: 0x00067B43
		internal double AutoFitWidth
		{
			get
			{
				return this.CalculateAutoFitExtent(true);
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0006994C File Offset: 0x00067B4C
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00069968 File Offset: 0x00067B68
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

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x000699E0 File Offset: 0x00067BE0
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x000699F2 File Offset: 0x00067BF2
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

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00069A00 File Offset: 0x00067C00
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

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x00069A50 File Offset: 0x00067C50
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x00069A62 File Offset: 0x00067C62
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

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x00069A75 File Offset: 0x00067C75
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x00069A7D File Offset: 0x00067C7D
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

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x00069AA8 File Offset: 0x00067CA8
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x00069ABA File Offset: 0x00067CBA
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

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00069ACD File Offset: 0x00067CCD
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x00069AD5 File Offset: 0x00067CD5
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

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00069ADE File Offset: 0x00067CDE
		// (set) Token: 0x060017E0 RID: 6112 RVA: 0x00069AE6 File Offset: 0x00067CE6
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

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00069AEF File Offset: 0x00067CEF
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x00069AF7 File Offset: 0x00067CF7
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

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00069B00 File Offset: 0x00067D00
		// (set) Token: 0x060017E4 RID: 6116 RVA: 0x00069B08 File Offset: 0x00067D08
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

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00069B5E File Offset: 0x00067D5E
		internal bool IsClearingBindings
		{
			get
			{
				return this._isClearingBindings;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00069B68 File Offset: 0x00067D68
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

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x00069B9F File Offset: 0x00067D9F
		internal bool IsPreparingItemForContainer
		{
			get
			{
				return this._preparingItemForContainer;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00069BA8 File Offset: 0x00067DA8
		internal bool IsFocusWithinContentArea
		{
			get
			{
				global::System.Windows.FrameworkElement recordContentSite = this.GetRecordContentSite();
				return recordContentSite != null && global::Infragistics.Windows.Helpers.FocusWithinManager.CheckFocusWithinHelper(recordContentSite);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00069BC7 File Offset: 0x00067DC7
		internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManagerForHeader
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordManager)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.RecordManagerForHeaderProperty);
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00069BD9 File Offset: 0x00067DD9
		// (set) Token: 0x060017EB RID: 6123 RVA: 0x00069BE1 File Offset: 0x00067DE1
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

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x00069C09 File Offset: 0x00067E09
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

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00069C25 File Offset: 0x00067E25
		private int AutoFitVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.AutoFitVersionProperty);
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00069C37 File Offset: 0x00067E37
		private static void OnFixedFieldOffsetsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.RecordPresenter)d).VerifyFixedFarTransform();
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x00069C44 File Offset: 0x00067E44
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x00069C56 File Offset: 0x00067E56
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

		// Token: 0x060017F1 RID: 6129 RVA: 0x00069C69 File Offset: 0x00067E69
		private static void OnTemplateVersionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.RecordPresenter)d).InitializeFixedFieldInfo();
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00069C76 File Offset: 0x00067E76
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

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x00069C97 File Offset: 0x00067E97
		private global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.VisibilityResolvedProperty);
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00069CA9 File Offset: 0x00067EA9
		public static global::Infragistics.Windows.DataPresenter.RecordPresenter FromRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			return record.AssociatedRecordPresenter;
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00069CBF File Offset: 0x00067EBF
		internal void CleanUp()
		{
			if (this.IsBoundaryRecord)
			{
				this.IsBoundaryRecord = false;
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00069CD0 File Offset: 0x00067ED0
		internal void ClearContainerForItem(object item)
		{
			this.ClearContainerForItem(item, false);
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00069CDC File Offset: 0x00067EDC
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

		// Token: 0x060017F8 RID: 6136 RVA: 0x00069D50 File Offset: 0x00067F50
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

		// Token: 0x060017F9 RID: 6137 RVA: 0x00069DA4 File Offset: 0x00067FA4
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

		// Token: 0x060017FA RID: 6138 RVA: 0x00069DE8 File Offset: 0x00067FE8
		internal global::System.Windows.FrameworkElement GetHeaderContentSite()
		{
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_HeaderContentSite");
			return templateChild as global::System.Windows.FrameworkElement;
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00069E08 File Offset: 0x00068008
		internal global::System.Windows.FrameworkElement GetNestedContentSite()
		{
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_NestedContentSite");
			return templateChild as global::System.Windows.FrameworkElement;
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00069E27 File Offset: 0x00068027
		internal virtual global::System.Windows.DataTemplate GetRecordContentAreaTemplate(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator generator)
		{
			return null;
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00069E2C File Offset: 0x0006802C
		internal virtual string GetRecordDescription()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this.Record;
			if (record == null)
			{
				return null;
			}
			return record.Description;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x00069E4B File Offset: 0x0006804B
		internal virtual global::Infragistics.Windows.DataPresenter.Record GetRecordForMeasure()
		{
			return this.Record;
		}

		// Token: 0x060017FF RID: 6143
		internal abstract global::System.Windows.Controls.ControlTemplate GetDefaultTemplateProperty(global::System.Windows.DependencyProperty templateProperty);

		// Token: 0x06001800 RID: 6144 RVA: 0x00069E53 File Offset: 0x00068053
		internal void InitializeExpandableRecordContentVisibility(bool showExpandableRecordContent)
		{
			if (showExpandableRecordContent != this._shouldDisplayExpandableRecordContent)
			{
				this._shouldDisplayExpandableRecordContent = showExpandableRecordContent;
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayExpandableRecordContentPropertyKey, global::Infragistics.KnownBoxes.FromValue(showExpandableRecordContent));
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x00069E76 File Offset: 0x00068076
		internal void InitializeGroupByRecordContentVisibility(bool showGroupByRecordContent)
		{
			if (showGroupByRecordContent != this._shouldDisplayGroupByRecordContent)
			{
				this._shouldDisplayGroupByRecordContent = showGroupByRecordContent;
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.ShouldDisplayGroupByRecordContentPropertyKey, global::Infragistics.KnownBoxes.FromValue(showGroupByRecordContent));
			}
		}

		// Token: 0x06001802 RID: 6146 RVA: 0x00069E9C File Offset: 0x0006809C
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

		// Token: 0x06001803 RID: 6147 RVA: 0x0006A04C File Offset: 0x0006824C
		internal void InitializeIsAlternate(bool force)
		{
			if (force)
			{
				this._isAlternateInitialized = false;
			}
			this.InitializeIsAlternate();
		}

		// Token: 0x06001804 RID: 6148 RVA: 0x0006A060 File Offset: 0x00068260
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

		// Token: 0x06001805 RID: 6149 RVA: 0x0006A0B0 File Offset: 0x000682B0
		internal void InvalidateStyle()
		{
			this._styleSelectorHelper.InvalidateStyle();
		}

		// Token: 0x06001806 RID: 6150 RVA: 0x0006A0C0 File Offset: 0x000682C0
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

		// Token: 0x06001807 RID: 6151 RVA: 0x0006A128 File Offset: 0x00068328
		internal void OnIsFocusWithinChanged(bool gotFocus)
		{
			if (gotFocus && this.Record != null && this.Record == base.DataContext && !this.IsActive && !this.IsHeaderRecord && !this.Record.IsAncestorOf(this.DataPresenter.ActiveRecord))
			{
				this.IsActive = true;
			}
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x0006A17D File Offset: 0x0006837D
		internal void PrepareContainerForItem(object item)
		{
			this.PrepareContainerForItem(item, item is global::Infragistics.Windows.DataPresenter.HeaderRecord);
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x0006A190 File Offset: 0x00068390
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
					this._record.IsExpanded = true;
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

		// Token: 0x0600180A RID: 6154 RVA: 0x0006A39C File Offset: 0x0006859C
		internal static void SetIsFilteredOutPropertyHelper(global::System.Windows.FrameworkElement fe, global::Infragistics.Windows.DataPresenter.Record record)
		{
			bool? flag = (record != null) ? record.InternalIsFilteredOutNullable_NoVerify : null;
			if (flag != null)
			{
				fe.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey, global::Infragistics.KnownBoxes.FromValue(flag.Value));
				return;
			}
			fe.ClearValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey);
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x0006A3EA File Offset: 0x000685EA
		internal void SynchronizeDescriptionProperty()
		{
			this._descSyncPending = false;
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.DescriptionPropertyKey, this.GetRecordDescription());
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x0006A404 File Offset: 0x00068604
		internal void SynchronizeDescriptionPropertyAsync()
		{
			if (this._descSyncPending)
			{
				return;
			}
			this._descSyncPending = true;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.SynchronizeDescriptionProperty));
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0006A430 File Offset: 0x00068630
		private void SynchronizeSeparatorVisibility()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this._record;
			bool shouldDisplayRecordContent = this.ShouldDisplayRecordContent;
			global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility recordSeparatorVisibility = (record != null && this.ShouldDisplayRecordContent) ? record.SeparatorVisibility : global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.None;
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorAfterPropertyKey, global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.After == recordSeparatorVisibility);
			base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.HasSeparatorBeforePropertyKey, global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility.Before == recordSeparatorVisibility);
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0006A488 File Offset: 0x00068688
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

		// Token: 0x0600180F RID: 6159 RVA: 0x0006A5C5 File Offset: 0x000687C5
		protected virtual void OnRecordChanged(global::Infragistics.Windows.DataPresenter.Record oldRecord, global::Infragistics.Windows.DataPresenter.Record newRecord)
		{
			this.SynchronizeSeparatorVisibility();
			this.UpdateVisualStates();
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x0006A5D4 File Offset: 0x000687D4
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
			case "IsEnabledResolved":
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsRecordEnabledPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.Record.IsEnabledResolved));
				break;
			case "IsExpanded":
				this.IsExpanded = this.Record.IsExpanded;
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

		// Token: 0x06001811 RID: 6161 RVA: 0x0006A87C File Offset: 0x00068A7C
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

		// Token: 0x06001812 RID: 6162 RVA: 0x0006A960 File Offset: 0x00068B60
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = target as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				recordPresenter.UpdateVisualStates();
			}
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0006A97D File Offset: 0x00068B7D
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0006A986 File Offset: 0x00068B86
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

		// Token: 0x06001815 RID: 6165 RVA: 0x0006A9A4 File Offset: 0x00068BA4
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

		// Token: 0x06001816 RID: 6166 RVA: 0x0006AAB8 File Offset: 0x00068CB8
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

		// Token: 0x06001817 RID: 6167 RVA: 0x0006AB38 File Offset: 0x00068D38
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

		// Token: 0x06001818 RID: 6168 RVA: 0x0006ABEC File Offset: 0x00068DEC
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

		// Token: 0x06001819 RID: 6169 RVA: 0x0006ACF8 File Offset: 0x00068EF8
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

		// Token: 0x0600181A RID: 6170 RVA: 0x0006AD70 File Offset: 0x00068F70
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

		// Token: 0x0600181B RID: 6171 RVA: 0x0006ADD0 File Offset: 0x00068FD0
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

		// Token: 0x0600181C RID: 6172 RVA: 0x0006AEE8 File Offset: 0x000690E8
		private void InitializeMinWidth()
		{
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0006AEEC File Offset: 0x000690EC
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

		// Token: 0x0600181E RID: 6174 RVA: 0x0006B188 File Offset: 0x00069388
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
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPresenter.IsExpandedProperty, global::Infragistics.KnownBoxes.FromValue(this._record.IsExpanded));
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

		// Token: 0x0600181F RID: 6175 RVA: 0x0006B304 File Offset: 0x00069504
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

		// Token: 0x06001820 RID: 6176 RVA: 0x0006B474 File Offset: 0x00069674
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

		// Token: 0x06001821 RID: 6177 RVA: 0x0006B4BC File Offset: 0x000696BC
		private void OnExpansionIndicatorClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleRecordIsExpanded.CanExecute(this.Record, this))
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleRecordIsExpanded.Execute(this.Record, this);
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0006B4E2 File Offset: 0x000696E2
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

		// Token: 0x06001823 RID: 6179 RVA: 0x0006B514 File Offset: 0x00069714
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			this.RaiseNestedContentEvent(this.HasNestedContent);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0006B534 File Offset: 0x00069734
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

		// Token: 0x06001825 RID: 6181 RVA: 0x0006B559 File Offset: 0x00069759
		private void OnUpdateAutoFitAsync()
		{
			if (this._asyncAutoFit != null)
			{
				this._asyncAutoFit = null;
				this.UpdateAutoFitProperties();
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0006B570 File Offset: 0x00069770
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

		// Token: 0x06001827 RID: 6183 RVA: 0x0006B660 File Offset: 0x00069860
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

		// Token: 0x06001828 RID: 6184 RVA: 0x0006B710 File Offset: 0x00069910
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

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x0006B768 File Offset: 0x00069968
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

		// Token: 0x0600182A RID: 6186 RVA: 0x0006B780 File Offset: 0x00069980
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

		// Token: 0x04000933 RID: 2355
		private int _cachedVersion;

		// Token: 0x04000934 RID: 2356
		private bool _versionInitialized;

		// Token: 0x04000935 RID: 2357
		private bool _isAlternateInitialized;

		// Token: 0x04000936 RID: 2358
		private bool _isArrangedInView = true;

		// Token: 0x04000937 RID: 2359
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000938 RID: 2360
		private object _nestedContent;

		// Token: 0x04000939 RID: 2361
		private object _headerContent;

		// Token: 0x0400093A RID: 2362
		private global::Infragistics.Windows.DataPresenter.RecordPresenter.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x0400093B RID: 2363
		private bool _isBoundaryRecord;

		// Token: 0x0400093C RID: 2364
		private bool _ignoreNextRecordsInViewVersionPropertyChange;

		// Token: 0x0400093D RID: 2365
		private bool _preparingItemForContainer;

		// Token: 0x0400093E RID: 2366
		private bool _hasBeenPrepared;

		// Token: 0x0400093F RID: 2367
		private bool _shouldDisplayExpandableRecordContent = true;

		// Token: 0x04000940 RID: 2368
		private bool _shouldDisplayGroupByRecordContent = true;

		// Token: 0x04000941 RID: 2369
		private bool _shouldDisplayRecordContent = true;

		// Token: 0x04000942 RID: 2370
		private bool _isSwappingTemplate;

		// Token: 0x04000943 RID: 2371
		private bool _isTemplateDirty = true;

		// Token: 0x04000944 RID: 2372
		private bool _isClearingBindings;

		// Token: 0x04000945 RID: 2373
		private bool _hasRecordEverBeenInitialized;

		// Token: 0x04000946 RID: 2374
		private bool _descSyncPending;

		// Token: 0x04000947 RID: 2375
		private global::System.Windows.Controls.ControlTemplate _cachedTemplate;

		// Token: 0x04000948 RID: 2376
		private global::System.Windows.FrameworkElement _parentContentPresenter;

		// Token: 0x04000949 RID: 2377
		private global::Infragistics.Windows.Internal.PropertyValueTracker _parentCPWidthTracker;

		// Token: 0x0400094A RID: 2378
		private global::Infragistics.Windows.Internal.PropertyValueTracker _parentCPHeightTracker;

		// Token: 0x0400094B RID: 2379
		private bool _isActiveFixedRecord;

		// Token: 0x0400094C RID: 2380
		private bool _isActiveHeaderRecord;

		// Token: 0x0400094D RID: 2381
		private bool _treatAsCollapsed;

		// Token: 0x0400094E RID: 2382
		private bool _layoutUpdatedWired;

		// Token: 0x0400094F RID: 2383
		private global::System.Windows.Threading.DispatcherOperation _asyncAutoFit;

		// Token: 0x04000950 RID: 2384
		private global::System.WeakReference _cellArea;

		// Token: 0x04000951 RID: 2385
		private global::System.WeakReference _weakRef;

		// Token: 0x04000952 RID: 2386
		private bool _nestedDataRequiresInitalization;

		// Token: 0x04000953 RID: 2387
		private global::System.Windows.Media.Geometry _internalClip;

		// Token: 0x04000954 RID: 2388
		private global::System.Windows.Media.Geometry _explicitClip;

		// Token: 0x04000955 RID: 2389
		private global::System.Windows.Media.CombinedGeometry _combinedClip;

		// Token: 0x04000956 RID: 2390
		private global::Infragistics.Windows.Controls.ExpansionIndicator _expansionIndicator;

		// Token: 0x04000957 RID: 2391
		private bool _isInitializeFixedFieldInfoPending;

		// Token: 0x04000958 RID: 2392
		private bool _hasVisualStateGroups;

		// Token: 0x0400095B RID: 2395
		public static readonly global::System.Windows.DependencyProperty CellPresentationProperty;

		// Token: 0x0400095C RID: 2396
		private static readonly global::System.Windows.DependencyPropertyKey DescriptionPropertyKey;

		// Token: 0x0400095D RID: 2397
		public static readonly global::System.Windows.DependencyProperty DescriptionProperty;

		// Token: 0x0400095E RID: 2398
		public static readonly global::System.Windows.DependencyProperty ExpansionIndicatorVisibilityProperty;

		// Token: 0x0400095F RID: 2399
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty;

		// Token: 0x04000960 RID: 2400
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x04000961 RID: 2401
		internal static readonly global::System.Windows.DependencyPropertyKey FixedNearElementTransformPropertyKey;

		// Token: 0x04000962 RID: 2402
		public static readonly global::System.Windows.DependencyProperty FixedNearElementTransformProperty;

		// Token: 0x04000963 RID: 2403
		private static readonly global::System.Windows.DependencyPropertyKey FixedFarElementTransformPropertyKey;

		// Token: 0x04000964 RID: 2404
		public static readonly global::System.Windows.DependencyProperty FixedFarElementTransformProperty;

		// Token: 0x04000965 RID: 2405
		private static readonly global::System.Windows.DependencyPropertyKey HasChildDataPropertyKey;

		// Token: 0x04000966 RID: 2406
		public static readonly global::System.Windows.DependencyProperty HasChildDataProperty;

		// Token: 0x04000967 RID: 2407
		private static readonly global::System.Windows.DependencyPropertyKey HasHeaderContentPropertyKey;

		// Token: 0x04000968 RID: 2408
		public static readonly global::System.Windows.DependencyProperty HasHeaderContentProperty;

		// Token: 0x04000969 RID: 2409
		private static readonly global::System.Windows.DependencyPropertyKey HasNestedContentPropertyKey;

		// Token: 0x0400096A RID: 2410
		public static readonly global::System.Windows.DependencyProperty HasNestedContentProperty;

		// Token: 0x0400096B RID: 2411
		private static readonly global::System.Windows.DependencyPropertyKey HasSeparatorAfterPropertyKey;

		// Token: 0x0400096C RID: 2412
		public static readonly global::System.Windows.DependencyProperty HasSeparatorAfterProperty;

		// Token: 0x0400096D RID: 2413
		private static readonly global::System.Windows.DependencyPropertyKey HasSeparatorBeforePropertyKey;

		// Token: 0x0400096E RID: 2414
		public static readonly global::System.Windows.DependencyProperty HasSeparatorBeforeProperty;

		// Token: 0x0400096F RID: 2415
		private static readonly global::System.Windows.DependencyPropertyKey HeaderContentPropertyKey;

		// Token: 0x04000970 RID: 2416
		public static readonly global::System.Windows.DependencyProperty HeaderContentProperty;

		// Token: 0x04000971 RID: 2417
		internal static readonly global::System.Windows.DependencyPropertyKey IsAlternatePropertyKey;

		// Token: 0x04000972 RID: 2418
		public static readonly global::System.Windows.DependencyProperty IsAlternateProperty;

		// Token: 0x04000973 RID: 2419
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;

		// Token: 0x04000974 RID: 2420
		private bool _cachedIsActive;

		// Token: 0x04000975 RID: 2421
		public static readonly global::System.Windows.DependencyProperty IsExpandedProperty;

		// Token: 0x04000976 RID: 2422
		internal static readonly global::System.Windows.DependencyPropertyKey IsFilterRecordPropertyKey;

		// Token: 0x04000977 RID: 2423
		public static readonly global::System.Windows.DependencyProperty IsFilterRecordProperty;

		// Token: 0x04000978 RID: 2424
		internal static readonly global::System.Windows.DependencyPropertyKey IsFilteredOutPropertyKey;

		// Token: 0x04000979 RID: 2425
		public static readonly global::System.Windows.DependencyProperty IsFilteredOutProperty;

		// Token: 0x0400097A RID: 2426
		internal static readonly global::System.Windows.DependencyPropertyKey IsFixedOnBottomPropertyKey;

		// Token: 0x0400097B RID: 2427
		public static readonly global::System.Windows.DependencyProperty IsFixedOnBottomProperty;

		// Token: 0x0400097C RID: 2428
		internal static readonly global::System.Windows.DependencyPropertyKey IsFixedOnTopPropertyKey;

		// Token: 0x0400097D RID: 2429
		public static readonly global::System.Windows.DependencyProperty IsFixedOnTopProperty;

		// Token: 0x0400097E RID: 2430
		private static readonly global::System.Windows.DependencyPropertyKey IsHeaderRecordPropertyKey;

		// Token: 0x0400097F RID: 2431
		public static readonly global::System.Windows.DependencyProperty IsHeaderRecordProperty;

		// Token: 0x04000980 RID: 2432
		private static readonly global::System.Windows.DependencyPropertyKey IsInCardPropertyKey;

		// Token: 0x04000981 RID: 2433
		public static readonly global::System.Windows.DependencyProperty IsInCardProperty;

		// Token: 0x04000982 RID: 2434
		internal static readonly global::System.Windows.DependencyPropertyKey IsRecordEnabledPropertyKey;

		// Token: 0x04000983 RID: 2435
		public static readonly global::System.Windows.DependencyProperty IsRecordEnabledProperty;

		// Token: 0x04000984 RID: 2436
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x04000985 RID: 2437
		private static readonly global::System.Windows.DependencyPropertyKey NestedContentPropertyKey;

		// Token: 0x04000986 RID: 2438
		public static readonly global::System.Windows.DependencyProperty NestedContentProperty;

		// Token: 0x04000987 RID: 2439
		private static readonly global::System.Windows.DependencyPropertyKey NestedContentMarginPropertyKey;

		// Token: 0x04000988 RID: 2440
		public static readonly global::System.Windows.DependencyProperty NestedContentMarginProperty;

		// Token: 0x04000989 RID: 2441
		public static readonly global::System.Windows.DependencyProperty NestedContentBackgroundProperty;

		// Token: 0x0400098A RID: 2442
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey;

		// Token: 0x0400098B RID: 2443
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;

		// Token: 0x0400098C RID: 2444
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey;

		// Token: 0x0400098D RID: 2445
		public static readonly global::System.Windows.DependencyProperty RecordProperty;

		// Token: 0x0400098E RID: 2446
		private static readonly global::System.Windows.DependencyPropertyKey RecordContentAreaTemplatePropertyKey;

		// Token: 0x0400098F RID: 2447
		public static readonly global::System.Windows.DependencyProperty RecordContentAreaTemplateProperty;

		// Token: 0x04000990 RID: 2448
		internal static readonly global::System.Windows.DependencyPropertyKey ScrollableElementTransformPropertyKey;

		// Token: 0x04000991 RID: 2449
		public static readonly global::System.Windows.DependencyProperty ScrollableElementTransformProperty;

		// Token: 0x04000992 RID: 2450
		private static readonly global::System.Windows.DependencyPropertyKey ShouldDisplayExpandableRecordContentPropertyKey;

		// Token: 0x04000993 RID: 2451
		public static readonly global::System.Windows.DependencyProperty ShouldDisplayExpandableRecordContentProperty;

		// Token: 0x04000994 RID: 2452
		private static readonly global::System.Windows.DependencyPropertyKey ShouldDisplayGroupByRecordContentPropertyKey;

		// Token: 0x04000995 RID: 2453
		public static readonly global::System.Windows.DependencyProperty ShouldDisplayGroupByRecordContentProperty;

		// Token: 0x04000996 RID: 2454
		private static readonly global::System.Windows.DependencyPropertyKey ShouldDisplayRecordContentPropertyKey;

		// Token: 0x04000997 RID: 2455
		public static readonly global::System.Windows.DependencyProperty ShouldDisplayRecordContentProperty;

		// Token: 0x04000998 RID: 2456
		public static readonly global::System.Windows.DependencyProperty TemplateCardViewProperty;

		// Token: 0x04000999 RID: 2457
		public static readonly global::System.Windows.DependencyProperty TemplateGridViewProperty;

		// Token: 0x0400099A RID: 2458
		private static readonly global::System.Windows.DependencyPropertyKey AutoFitHeightPropertyKey;

		// Token: 0x0400099B RID: 2459
		internal static readonly global::System.Windows.DependencyProperty AutoFitHeightProperty;

		// Token: 0x0400099C RID: 2460
		private static readonly global::System.Windows.DependencyPropertyKey AutoFitWidthPropertyKey;

		// Token: 0x0400099D RID: 2461
		internal static readonly global::System.Windows.DependencyProperty AutoFitWidthProperty;

		// Token: 0x0400099E RID: 2462
		internal static readonly global::System.Windows.DependencyProperty FixedFieldInfoProperty;

		// Token: 0x0400099F RID: 2463
		internal static readonly global::System.Windows.DependencyProperty RecordsInViewVersionProperty;

		// Token: 0x040009A0 RID: 2464
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty;

		// Token: 0x040009A1 RID: 2465
		private static readonly global::System.Windows.DependencyPropertyKey RecordManagerForHeaderPropertyKey;

		// Token: 0x040009A2 RID: 2466
		internal static readonly global::System.Windows.DependencyProperty RecordManagerForHeaderProperty;

		// Token: 0x040009A3 RID: 2467
		private static readonly global::System.Windows.DependencyPropertyKey AutoFitVersionPropertyKey;

		// Token: 0x040009A4 RID: 2468
		private static readonly global::System.Windows.DependencyProperty AutoFitVersionProperty;

		// Token: 0x040009A5 RID: 2469
		internal static readonly global::System.Windows.DependencyProperty FixedFieldOffsetProperty;

		// Token: 0x040009A6 RID: 2470
		internal static readonly global::System.Windows.DependencyProperty FixedFieldViewportExtentProperty;

		// Token: 0x040009A7 RID: 2471
		private static readonly global::System.Windows.DependencyProperty ParentRecordAutoFitVersionProperty;

		// Token: 0x040009A8 RID: 2472
		private static global::System.Windows.DependencyProperty TemplateVersionProperty;

		// Token: 0x040009A9 RID: 2473
		private static readonly global::System.Windows.DependencyPropertyKey VisibilityResolvedPropertyKey;

		// Token: 0x040009AA RID: 2474
		private static readonly global::System.Windows.DependencyProperty VisibilityResolvedProperty;

		// Token: 0x040009AB RID: 2475
		internal static readonly object TemplateRecordPresenterId;

		// Token: 0x020001AF RID: 431
		private class MinWidthConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x0600182C RID: 6188 RVA: 0x0006B7B3 File Offset: 0x000699B3
			internal MinWidthConverter()
			{
			}

			// Token: 0x0600182D RID: 6189 RVA: 0x0006B7BC File Offset: 0x000699BC
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

			// Token: 0x0600182E RID: 6190 RVA: 0x0006B804 File Offset: 0x00069A04
			object global::System.Windows.Data.IValueConverter.ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return value;
			}
		}

		// Token: 0x020001B0 RID: 432
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x0600182F RID: 6191 RVA: 0x0006B807 File Offset: 0x00069A07
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.RecordPresenter rp) : base(rp)
			{
				this._rp = rp;
			}

			// Token: 0x17000676 RID: 1654
			// (get) Token: 0x06001830 RID: 6192 RVA: 0x0006B818 File Offset: 0x00069A18
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

			// Token: 0x040009AD RID: 2477
			private global::Infragistics.Windows.DataPresenter.RecordPresenter _rp;
		}
	}
}
