using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using System.Xml;
using Infragistics.AutomationPeers;
using Infragistics.Collections;
using Infragistics.Controls;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Shared;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.DataPresenter.Calculations;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Reporting;
using Infragistics.Windows.Resizing;
using Infragistics.Windows.Scrolling;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Themes;
using Infragistics.Windows.Themes.Internal;
using Infragistics.Windows.Tiles;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E8 RID: 232
	[global::System.Windows.StyleTypedProperty(Property = "GroupByAreaFieldLabelStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel))]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public abstract class DataPresenterBase : global::Infragistics.Windows.Controls.IGControlBase, global::Infragistics.Windows.Resizing.IResizeHost, global::Infragistics.Windows.Selection.ISelectionHost, global::Infragistics.Windows.Commands.ICommandHost, global::Infragistics.Windows.Scrolling.IDeferredScrollHost, global::Infragistics.Windows.DataPresenter.IViewPanelInfo, global::Infragistics.Windows.Resizing.IAutoResizeHost, global::System.Windows.IWeakEventListener, global::Infragistics.Controls.ISupportScrollHelper, global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginatorFactory
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x00036CC0 File Offset: 0x00034EC0
		static DataPresenterBase()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.AssigningFieldLayoutToItemEvent = global::System.Windows.EventManager.RegisterRoutedEvent("AssigningFieldLayoutToItem", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.QuerySummaryResultEvent = global::System.Windows.EventManager.RegisterRoutedEvent("QuerySummaryResult", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.QuerySummaryResultEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CellActivated", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CellActivating", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CellChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellDeactivatingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CellDeactivating", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CellUpdating", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellUpdatingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CellUpdated", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellUpdatedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCopyingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ClipboardCopying", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ClipboardCopyingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardOperationErrorEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ClipboardOperationError", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationErrorEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardPastingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ClipboardPasting", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CustomFilterSelectionControlOpeningEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CustomFilterSelectionControlOpening", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CustomFilterSelectionControlOpeningEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataErrorEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DataError", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.DataErrorEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DataValueChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeEnded", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeEnding", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeStarted", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeStarting", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeValidationErrorEvent = global::System.Windows.EventManager.RegisterRoutedEvent("EditModeValidationError", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeValidationErrorEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldChooserOpeningEvent = global::System.Windows.EventManager.RegisterRoutedEvent("FieldChooserOpening", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("FieldLayoutInitializing", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("FieldLayoutInitialized", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("FieldPositionChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("FieldPositionChanging", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Grouping", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Grouped", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeCellValuePresenterEvent = global::System.Windows.EventManager.RegisterRoutedEvent("InitializeCellValuePresenter", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeRecordEvent = global::System.Windows.EventManager.RegisterRoutedEvent("InitializeRecord", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeTemplateAddRecordEvent = global::System.Windows.EventManager.RegisterRoutedEvent("InitializeTemplateAddRecord", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeTemplateAddRecordEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordActivated", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordActivating", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordAdding", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordAddingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordAdded", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordAddedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordCollapsed", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordCollapsing", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordDeactivatingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordDeactivating", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordFilterChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordFilterChanging", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownItemInitializingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordFilterDropDownItemInitializing", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownItemInitializingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownOpeningEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordFilterDropDownOpening", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownPopulatingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordFilterDropDownPopulating", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordsDeleted", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordsDeletedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordsDeleting", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordExpanded", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordExpandedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordExpanding", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordFixedLocationChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordFixedLocationChanging", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordsInViewChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCancelingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordUpdateCanceling", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCancelingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCanceledEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordUpdateCanceled", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCanceledEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordUpdating", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordUpdatingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("RecordUpdated", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordUpdatedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectedItemsChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectedItemsChanging", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Sorting", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Sorted", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummaryResultChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SummaryResultChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SummaryResultChangedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SummarySelectionControlClosed", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlClosedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlOpeningEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SummarySelectionControlOpening", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveDataItemProperty = global::System.Windows.DependencyProperty.Register("ActiveDataItem", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnActiveDataItemChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CoerceActiveDataItem)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveCellProperty = global::System.Windows.DependencyProperty.Register("ActiveCell", typeof(global::Infragistics.Windows.DataPresenter.Cell), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnActiveCellChangedCallback), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnCoerceActiveCell)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveRecordProperty = global::System.Windows.DependencyProperty.Register("ActiveRecord", typeof(global::Infragistics.Windows.DataPresenter.Record), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnActiveRecordChangedCallback), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnCoerceActiveRecord)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.AutoFitProperty = global::System.Windows.DependencyProperty.Register("AutoFit", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnAutoFitChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.BindToSampleDataProperty = global::System.Windows.DependencyProperty.Register("BindToSampleData", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnBindToSampleDataChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CalculationAdapterProperty = global::System.Windows.DependencyProperty.Register("CalculationAdapter", typeof(global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapter), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnCalculationAdapterChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellContainerGenerationModeProperty = global::System.Windows.DependencyProperty.Register("CellContainerGenerationMode", typeof(global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.Recycle, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnCellContainerGenerationModeChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCellDelimiterProperty = global::System.Windows.DependencyProperty.Register("ClipboardCellDelimiter", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(string.Empty));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCellSeparatorProperty = global::System.Windows.DependencyProperty.Register("ClipboardCellSeparator", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata("\t"));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardRecordSeparatorProperty = global::System.Windows.DependencyProperty.Register("ClipboardRecordSeparator", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::System.Environment.NewLine));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty = global::System.Windows.DependencyProperty.RegisterAttached("CurrentView", typeof(global::Infragistics.Windows.DataPresenter.ViewBase), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataErrorContentTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), "DataErrorContentTemplateKey");
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataErrorIconStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), "DataErrorIconStyleKey");
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataItemEqualityComparerProperty = global::System.Windows.DependencyProperty.Register("DataItemEqualityComparer", typeof(global::System.Collections.IEqualityComparer), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnDataItemEqualityComparerChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceProperty = global::System.Windows.DependencyProperty.Register("DataSource", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceResetBehaviorProperty = global::System.Windows.DependencyProperty.Register("DataSourceResetBehavior", typeof(global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.ReuseRecordsViaEnumerator, global::System.Windows.FrameworkPropertyMetadataOptions.None));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DropIndicatorClipBehaviorProperty = global::Infragistics.DependencyPropertyUtilities.Register("DropIndicatorClipBehavior", typeof(global::Infragistics.Windows.DataPresenter.DropIndicatorClipBehavior?), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExportStatusPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ExportStatus", typeof(global::Infragistics.Windows.DataPresenter.RecordExportStatus), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnExportStatusChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExportStatusProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExportStatusPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldChooserButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), "FieldChooserButtonStyleKey");
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsProperty = global::System.Windows.DependencyProperty.Register("FieldLayoutSettings", typeof(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CoerceFieldLayoutSettings)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty = global::System.Windows.DependencyProperty.Register("FieldSettings", typeof(global::Infragistics.Windows.DataPresenter.FieldSettings), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CoerceFieldSettings)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FilterCellClearButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), "FilterCellClearButtonStyleKey");
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FilterDropDownLoadingTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), "FilterDropDownLoadingTemplateKey");
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.FilterRecordClearButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), "FilterRecordClearButtonStyleKey");
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaProperty = global::System.Windows.DependencyProperty.Register("GroupByArea", typeof(global::Infragistics.Windows.DataPresenter.GroupByArea), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnGroupByAreaChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaFieldLabelStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaFieldLabelStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaFieldLabelStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaFieldLabelStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaLocationProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaLocation", typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaLocation), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.AboveDataArea));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaModeProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaMode", typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMode), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.GroupByAreaMode.MultipleFieldLayoutsFull, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnGroupByAreaModeChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaMultiProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaMulti", typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnGroupByAreaMultiChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaStyleProperty = global::System.Windows.DependencyProperty.Register("GroupByAreaStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsExportingPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsExporting", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnIsExportingChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsExportingProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsExportingPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsGroupByAreaExpandedProperty = global::System.Windows.DependencyProperty.Register("IsGroupByAreaExpanded", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsNestedDataDisplayEnabledProperty = global::System.Windows.DependencyProperty.Register("IsNestedDataDisplayEnabled", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnIsNestedDataDisplayEnabledChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsSynchronizedWithCurrentItemProperty = global::System.Windows.DependencyProperty.Register("IsSynchronizedWithCurrentItem", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnIsSynchronizedWithCurrentItemChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsTouchSupportEnabledProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsTouchSupportEnabled", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnIsTouchSupportEnabledChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsUndoEnabledProperty = global::System.Windows.DependencyProperty.Register("IsUndoEnabled", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnIsUndoEnabledChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerGenerationModeProperty = global::System.Windows.DependencyProperty.Register("RecordContainerGenerationMode", typeof(global::Infragistics.Windows.Controls.ItemContainerGenerationMode), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordLoadModeProperty = global::System.Windows.DependencyProperty.Register("RecordLoadMode", typeof(global::Infragistics.Windows.DataPresenter.RecordLoadMode), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordLoadMode.LoadOnDemand));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Records", typeof(global::Infragistics.Windows.DataPresenter.RecordCollectionBase), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectorExtentProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnRecordSelectorExtentChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ValidateRecordSelectorExtent));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectorErrorIconExtentProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorErrorIconExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnRecordSelectorErrorIconExtentChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ValidateRecordSelectorExtent));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectorFixButtonExtentProperty = global::System.Windows.DependencyProperty.Register("RecordSelectorFixButtonExtent", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnRecordSelectorFixButtonExtentChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ValidateRecordSelectorExtent));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ReportViewProperty = global::System.Windows.DependencyProperty.Register("ReportView", typeof(global::Infragistics.Windows.DataPresenter.ReportViewBase), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerRetentionModeProperty = global::System.Windows.DependencyProperty.Register("RecordContainerRetentionMode", typeof(global::Infragistics.Windows.DataPresenter.RecordContainerRetentionMode), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordContainerRetentionMode.RetainDeactivatedContainersUntilResize));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollBehaviorOnListChangeProperty = global::System.Windows.DependencyProperty.Register("ScrollBehaviorOnListChange", typeof(global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange.Default));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollingModeProperty = global::System.Windows.DependencyProperty.Register("ScrollingMode", typeof(global::Infragistics.Windows.DataPresenter.ScrollingMode), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.ScrollingMode.DeferredWithScrollTips), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnValidateScrollingMode));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemProperty = global::System.Windows.DependencyProperty.Register("SelectedDataItem", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnSelectedDataItemChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemsProperty = global::System.Windows.DependencyProperty.Register("SelectedDataItems", typeof(object[]), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnSelectedDataItemsChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemsScopeProperty = global::System.Windows.DependencyProperty.Register("SelectedDataItemsScope", typeof(global::Infragistics.Windows.DataPresenter.SelectedDataItemsScope), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Windows.DataPresenter.SelectedDataItemsScope.None));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortRecordsByDataTypeProperty = global::System.Windows.DependencyProperty.Register("SortRecordsByDataType", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummaryCellContainerGenerationModeProperty = global::System.Windows.DependencyProperty.Register("SummaryCellContainerGenerationMode", typeof(global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.PreLoad, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnSummaryCellContainerGenerationModeChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnThemeChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ThemeChangedEvent = global::Infragistics.Windows.Themes.ThemeManager.ThemeChangedEvent.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.UndoLimitProperty = global::System.Windows.DependencyProperty.Register("UndoLimit", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnUndoLimitChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNonNegativeInt));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.UpdateModeProperty = global::System.Windows.DependencyProperty.Register("UpdateMode", typeof(global::Infragistics.Windows.DataPresenter.UpdateMode), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.UpdateMode.OnRecordChangeOrLostFocus));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ViewableRecordsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ViewableRecords", typeof(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnViewableRecordsChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ViewableRecordsProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ViewableRecordsPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty = global::System.Windows.DependencyProperty.RegisterAttached("DataPresenterBase", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnDataPresenterChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DataSourceInternal", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CoerceDataSourceInternal)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.GridMeasureVersionProperty = global::System.Windows.DependencyProperty.Register("GridMeasureVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.InternalRecordsProperty = global::System.Windows.DependencyProperty.Register("InternalRecords", typeof(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsScrollingPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsScrolling", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsScrollingProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsScrollingPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ItemsPanelPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemsPanel", typeof(global::System.Windows.Controls.ItemsPanelTemplate), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ItemsPanelProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ItemsPanelPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.OverallSortVersionProperty = global::System.Windows.DependencyProperty.Register("OverallSortVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.PanelSettingsProperty = global::System.Windows.DependencyProperty.RegisterAttached("PanelSettings", typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordNumberVersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordNumberVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordNumberVersionProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordNumberVersionPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RecordsInViewVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RenderVersionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RenderVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RenderVersionProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RenderVersionPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollableRecordCountVersionProperty = global::System.Windows.DependencyProperty.Register("ScrollableRecordCountVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollCountRecalcVersionProperty = global::System.Windows.DependencyProperty.Register("ScrollCountRecalcVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnScrollCountRecalcVersionChanged)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollVersionProperty = global::System.Windows.DependencyProperty.Register("ScrollVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.HorizontalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FromValue(global::System.Windows.Controls.ScrollBarVisibility.Auto)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.HorizontalScrollBarVisibilityProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.HorizontalScrollBarVisibilityPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.VerticalScrollBarVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("VerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FromValue(global::System.Windows.Controls.ScrollBarVisibility.Auto)));
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.VerticalScrollBarVisibilityProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.VerticalScrollBarVisibilityPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping,
				global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsGeneric.Locator>.Location.Grouping,
				global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>.Location.Grouping
			});
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.None));
			global::Infragistics.Windows.Scrolling.DeferredScrollService.RegisterDeferredScrollHost(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), global::System.Windows.Controls.ScrollViewer.ScrollChangedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnScrollViewerScrollChanged));
			global::Infragistics.Windows.Helpers.FocusWithinManager.RegisterType(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnRequestBringIntoView));
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnDataContextChanged)));
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00038518 File Offset: 0x00036718
		protected DataPresenterBase()
		{
			this._isDerived = (typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid) != base.GetType() && typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter) != base.GetType());
			this._cachedAutoFit = (bool?)global::Infragistics.Windows.DataPresenter.DataPresenterBase.AutoFitProperty.GetMetadata(this).DefaultValue;
			this._cachedIsNestedDataDisplayEnabled = (bool)global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsNestedDataDisplayEnabledProperty.GetMetadata(this).DefaultValue;
			this._cachedCellContainerGenerationMode = (global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode)global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellContainerGenerationModeProperty.GetMetadata(this).DefaultValue;
			this._cachedIsUndoEnabled = (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsUndoEnabledProperty);
			this.InitializeDataItemEqualityComparerResolved();
			base.Unloaded += this.OnUnloaded;
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaProperty, new global::Infragistics.Windows.DataPresenter.GroupByArea(this));
			this._fixedScrollHelper = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.FixedAreaScrollHelper(this);
			this._hadApplicationCurrent = (global::System.Windows.Application.Current != null);
			base.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, global::Infragistics.KnownBoxes.TrueBox);
			this._scrollHelper = new global::Infragistics.Controls.TouchScrollHelper(this, this);
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x0003868E File Offset: 0x0003688E
		protected internal override global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Instance;
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00038695 File Offset: 0x00036895
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			if (constraint != this._lastMeasureSize)
			{
				this._lastMeasureSize = constraint;
				this.BumpGridMeasureVersion();
			}
			return base.MeasureOverride(constraint);
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000386B9 File Offset: 0x000368B9
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyContentSiteGrid();
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x000386C7 File Offset: 0x000368C7
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer(this);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x000386D0 File Offset: 0x000368D0
		protected override void OnInitialized(global::System.EventArgs e)
		{
			if (this._groupByArea != null && this._groupByArea.Parent == null)
			{
				this.InternalAddLogicalChild(this._groupByArea);
			}
			base.OnInitialized(e);
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				base.CoerceValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsProperty);
				base.CoerceValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty);
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ViewableRecordsPropertyKey, this.RecordManager.ViewableRecords);
			if (this._pendingSelectedDataItemsOperation != null && this.DataSource != null)
			{
				this.ProcessPendingSelectedDataItems();
			}
			this.RecordManager.SetActiveRecordFromCurrentItem();
			global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(this, this, "Initialized", null);
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00038767 File Offset: 0x00036967
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return this._logicalChildren.GetEnumerator();
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0003877C File Offset: 0x0003697C
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.ModifierKeys modifiers = global::System.Windows.Input.Keyboard.Modifiers;
			bool flag = e.Key == global::System.Windows.Input.Key.Next || e.Key == global::System.Windows.Input.Key.Prior || e.Key == global::System.Windows.Input.Key.Down || e.Key == global::System.Windows.Input.Key.Up;
			if (flag && this._lastKeyDownInfo != null && this._lastKeyDownInfo.Key == e.Key && this._lastKeyDownInfo.Modifiers == modifiers && this._lastKeyDownInfo.TickCount + 35 > global::System.Environment.TickCount)
			{
				e.Handled = true;
				return;
			}
			this._isInPageUpDown = flag;
			base.OnKeyDown(e);
			this._isInPageUpDown = false;
			if (flag)
			{
				if (this._lastKeyDownInfo == null)
				{
					this._lastKeyDownInfo = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.KeyDownInfo(e.Key, modifiers);
					return;
				}
				this._lastKeyDownInfo.Key = e.Key;
				this._lastKeyDownInfo.Modifiers = modifiers;
				this._lastKeyDownInfo.TickCount = global::System.Environment.TickCount;
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00038864 File Offset: 0x00036A64
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			this._lastKeyDownInfo = null;
			base.OnKeyUp(e);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00038874 File Offset: 0x00036A74
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnLostMouseCapture(e);
			if (this._fieldDragManager != null)
			{
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(this._fieldDragManager.DragField);
				if (selectionStrategyForItem == null || !selectionStrategyForItem.IsReleasingMouseCapture)
				{
					this._fieldDragManager.OnDragEnd(e, true);
				}
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000388BA File Offset: 0x00036ABA
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnMouseMove(e);
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x000388D7 File Offset: 0x00036AD7
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnDragEnd(e, false);
				base.ReleaseMouseCapture();
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000388FC File Offset: 0x00036AFC
		protected override void OnPreviewLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.NewFocus as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
				if (activeCell != null && activeCell.IsInEditMode)
				{
					global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
					global::System.Windows.DependencyObject focusScope2 = global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject);
					if (focusScope == focusScope2 && dependencyObject != this && !global::Infragistics.Windows.Utilities.IsDescendantOf(this, dependencyObject))
					{
						this._processingPreviewLostKeyoardFocus = true;
						try
						{
							if (!this.EndEditMode(true, !base.IsVisible))
							{
								e.Handled = true;
							}
						}
						finally
						{
							this._processingPreviewLostKeyoardFocus = false;
						}
					}
				}
			}
			base.OnPreviewLostKeyboardFocus(e);
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0003898C File Offset: 0x00036B8C
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Input.MouseButtonEventArgs previewMouseDownArgs = this._previewMouseDownArgs;
			this._previewMouseDownArgs = e;
			try
			{
				base.OnPreviewMouseLeftButtonDown(e);
			}
			finally
			{
				this._previewMouseDownArgs = previewMouseDownArgs;
			}
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000389C8 File Offset: 0x00036BC8
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo info)
		{
			base.OnRenderSizeChanged(info);
			this._renderVersion++;
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RenderVersionPropertyKey, this._renderVersion);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000389F8 File Offset: 0x00036BF8
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortRecordsByDataTypeProperty)
			{
				this.BumpSortVersion();
				return;
			}
			if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceProperty)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalPropertyKey, e.NewValue);
				return;
			}
			if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalProperty)
			{
				if (this.IsExporting && !this.SuppressExportingDataSourceException)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_SetDataSourceDuringExport"));
				}
				if (e.NewValue != null && this._dataItems != null && this._dataItems.Count > 0 && e.NewValue != this._dataItems)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_7"));
				}
				if (e.OldValue != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this.DefaultFieldLayout;
					if (defaultFieldLayout != null)
					{
						defaultFieldLayout.IsDefault = false;
					}
					this._dataSourceHasBeenCleared = true;
				}
				this.ClearUndoHistory();
				this.FieldLayouts.OnDataSourceChanged();
				this._fieldLayoutAutoSizeViewableCount = 0;
				this._allRecordsAutoSizeMaxDepth = -1;
				this.ResetAllRecordsAutoSizeMaxDepth();
				global::System.Type type = null;
				if (e.OldValue != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems = this.SelectedItems;
					if (selectedItems.HasCells)
					{
						type = typeof(global::Infragistics.Windows.DataPresenter.Cell);
					}
					else if (selectedItems.HasRecords)
					{
						type = typeof(global::Infragistics.Windows.DataPresenter.Record);
					}
					else if (selectedItems.HasFields)
					{
						type = typeof(global::Infragistics.Windows.DataPresenter.Field);
					}
					selectedItems.InternalClearSelection(true, true, true, true);
				}
				this.InitializeRecordManagerDataSource();
				if (this._dataSourceHasBeenCleared && this.RecordManager.Unsorted.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this.RecordManager.Unsorted[0];
					if (dataRecord != null)
					{
						dataRecord.FieldLayout.IsDefault = true;
					}
					this.BumpGroupByAreaStyleVersion();
					this._dataSourceHasBeenCleared = false;
				}
				if (this.DefaultFieldLayout != null)
				{
					this.OnProcessSortCriteria(this.DefaultFieldLayout);
				}
				if (this._dataSourceRootChildListWrappers != null && e.NewValue != this._dataSourceRootChildListWrappers)
				{
					this._dataSourceRootChildListWrappers = null;
				}
				if (this._pendingActiveDataItem != null && e.NewValue != null)
				{
					object pendingActiveDataItem = this._pendingActiveDataItem;
					this._pendingActiveDataItem = null;
					this.SynchDataItemValue(pendingActiveDataItem);
				}
				else if (e.OldValue != null)
				{
					this.ClearActiveRecord(true);
				}
				if (this._pendingSelectedDataItemsOperation != null && e.NewValue != null)
				{
					this.ProcessPendingSelectedDataItems();
					return;
				}
				if (type != null && !this.SelectedItems.HasSelection)
				{
					this.RaiseSelectedItemsChanged(new global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs(type));
					return;
				}
			}
			else
			{
				if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaLocationProperty)
				{
					this.VerifyGroupByAreaLocation();
					return;
				}
				if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaStyleProperty)
				{
					this.SetGroupByAreaStyle();
					return;
				}
				if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaFieldLabelStyleProperty || property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaFieldLabelStyleSelectorProperty)
				{
					this.BumpGroupByAreaStyleVersion();
					return;
				}
				if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty)
				{
					if (this._x_FieldSettings != null)
					{
						global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._x_FieldSettings, this, string.Empty);
					}
					this._x_FieldSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldSettings);
					if (this._x_FieldSettings != null)
					{
						this.OnNewFieldSettings();
					}
					if (this._x_FieldSettings == null)
					{
						base.CoerceValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty);
					}
					this.InvalidateGeneratedStylesAsync(true);
					return;
				}
				if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsProperty)
				{
					if (this._x_FieldLayoutSettings != null)
					{
						global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._x_FieldLayoutSettings, this, string.Empty);
					}
					this._x_FieldLayoutSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayoutSettings);
					if (this._x_FieldLayoutSettings != null)
					{
						this.OnNewFieldLayoutSettings();
					}
					if (this._x_FieldLayoutSettings == null)
					{
						base.CoerceValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsProperty);
					}
					this.InvalidateGeneratedStylesAsync(true);
					return;
				}
				if (property == global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty)
				{
					if (this._rootRecordListControl != null)
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this._rootRecordListControl);
						if (automationPeer != null)
						{
							automationPeer.InvalidatePeer();
							global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(automationPeer);
							return;
						}
					}
				}
				else
				{
					if (e.Property == global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty)
					{
						this.OnIsFocusWithinChanged((bool)e.NewValue);
						return;
					}
					if (e.Property == global::System.Windows.FrameworkElement.LanguageProperty)
					{
						this._defaultConverterCulture = null;
						if (base.IsInitialized)
						{
							foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this.FieldLayouts)
							{
								if (fieldLayout.IsInitialized && fieldLayout.IsInitialRecordLoaded)
								{
									foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldLayout.Fields)
									{
										if (field.Owner == fieldLayout)
										{
											global::System.Globalization.CultureInfo converterCultureResolved = field.ConverterCultureResolved;
										}
									}
								}
							}
						}
						global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout2 = this.DefaultFieldLayout;
						if (defaultFieldLayout2 != null)
						{
							this.FieldLayouts.BumpSortVersions();
							this.RecordManager.VerifySort();
							base.InvalidateMeasure();
							if (this.CurrentPanel != null)
							{
								this.CurrentPanel.InvalidateMeasure();
								return;
							}
						}
					}
					else if (e.Property == global::System.Windows.UIElement.VisibilityProperty)
					{
						if (this.CurrentPanel != null && (global::System.Windows.Visibility)e.OldValue == global::System.Windows.Visibility.Hidden && (global::System.Windows.Visibility)e.NewValue == global::System.Windows.Visibility.Visible)
						{
							this.CurrentPanel.InvalidateMeasure();
							this.CurrentPanel.InvalidateArrange();
							this.CurrentPanel.UpdateLayout();
							return;
						}
					}
					else if (e.Property == global::System.Windows.Controls.Control.TemplateProperty && this._invalidateGeneratedStylesPending)
					{
						this.OnInvalidateGeneratedStyles();
					}
				}
			}
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00038F04 File Offset: 0x00037104
		internal override void PerformFocusOnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs args)
		{
			base.PerformFocusOnPreviewMouseLeftButtonDown(args);
			if (!args.Handled && !base.IsKeyboardFocusWithin && !base.IsFocused && !(bool)base.GetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinProperty) && !global::Infragistics.Windows.Utilities.IsDescendantOf(this, global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject, true))
			{
				args.Handled = true;
			}
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00038F5C File Offset: 0x0003715C
		protected virtual void OnAssigningFieldLayoutToItem(global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.AssigningFieldLayoutToItemDirect != null)
			{
				this.AssigningFieldLayoutToItemDirect(this, args);
			}
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00038F7A File Offset: 0x0003717A
		internal void RaiseAssigningFieldLayoutToItem(global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.AssigningFieldLayoutToItemEvent;
			args.Source = this;
			this.OnAssigningFieldLayoutToItem(args);
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000CB8 RID: 3256 RVA: 0x00038F95 File Offset: 0x00037195
		// (remove) Token: 0x06000CB9 RID: 3257 RVA: 0x00038FA3 File Offset: 0x000371A3
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs> AssigningFieldLayoutToItem
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.AssigningFieldLayoutToItemEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.AssigningFieldLayoutToItemEvent, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000CBA RID: 3258 RVA: 0x00038FB4 File Offset: 0x000371B4
		// (remove) Token: 0x06000CBB RID: 3259 RVA: 0x00038FEC File Offset: 0x000371EC
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs> AssigningFieldLayoutToItemDirect;

		// Token: 0x06000CBC RID: 3260 RVA: 0x00039021 File Offset: 0x00037221
		protected virtual void OnQuerySummaryResult(global::Infragistics.Windows.DataPresenter.Events.QuerySummaryResultEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0003902A File Offset: 0x0003722A
		internal void RaiseQuerySummaryResult(global::Infragistics.Windows.DataPresenter.Events.QuerySummaryResultEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.QuerySummaryResultEvent;
			args.Source = this;
			this.OnQuerySummaryResult(args);
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000CBE RID: 3262 RVA: 0x00039045 File Offset: 0x00037245
		// (remove) Token: 0x06000CBF RID: 3263 RVA: 0x00039053 File Offset: 0x00037253
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.QuerySummaryResultEventArgs> QuerySummaryResult
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.QuerySummaryResultEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.QuerySummaryResultEvent, value);
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00039061 File Offset: 0x00037261
		protected virtual void OnCellActivated(global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.CellActivatedDirect != null)
			{
				this.CellActivatedDirect(this, args);
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0003907F File Offset: 0x0003727F
		internal void RaiseCellActivated(global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatedEvent;
			args.Source = this;
			this.OnCellActivated(args);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000CC2 RID: 3266 RVA: 0x0003909A File Offset: 0x0003729A
		// (remove) Token: 0x06000CC3 RID: 3267 RVA: 0x000390A8 File Offset: 0x000372A8
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs> CellActivated
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatedEvent, value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000CC4 RID: 3268 RVA: 0x000390B8 File Offset: 0x000372B8
		// (remove) Token: 0x06000CC5 RID: 3269 RVA: 0x000390F0 File Offset: 0x000372F0
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs> CellActivatedDirect;

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00039125 File Offset: 0x00037325
		protected virtual void OnCellActivating(global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.CellActivatingDirect != null)
			{
				this.CellActivatingDirect(this, args);
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00039143 File Offset: 0x00037343
		internal void RaiseCellActivating(global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatingEvent;
			args.Source = this;
			this.OnCellActivating(args);
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000CC8 RID: 3272 RVA: 0x0003915E File Offset: 0x0003735E
		// (remove) Token: 0x06000CC9 RID: 3273 RVA: 0x0003916C File Offset: 0x0003736C
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs> CellActivating
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatingEvent, value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000CCA RID: 3274 RVA: 0x0003917C File Offset: 0x0003737C
		// (remove) Token: 0x06000CCB RID: 3275 RVA: 0x000391B4 File Offset: 0x000373B4
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs> CellActivatingDirect;

		// Token: 0x06000CCC RID: 3276 RVA: 0x000391E9 File Offset: 0x000373E9
		protected virtual void OnCellChanged(global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x000391F2 File Offset: 0x000373F2
		internal void RaiseCellChanged(global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellChangedEvent;
			args.Source = this;
			this.OnCellChanged(args);
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000CCE RID: 3278 RVA: 0x0003920D File Offset: 0x0003740D
		// (remove) Token: 0x06000CCF RID: 3279 RVA: 0x0003921B File Offset: 0x0003741B
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs> CellChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellChangedEvent, value);
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x00039229 File Offset: 0x00037429
		protected virtual void OnCellDeactivating(global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.CellDeactivatingDirect != null)
			{
				this.CellDeactivatingDirect(this, args);
			}
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x00039247 File Offset: 0x00037447
		internal void RaiseCellDeactivating(global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellDeactivatingEvent;
			args.Source = this;
			this.OnCellDeactivating(args);
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000CD2 RID: 3282 RVA: 0x00039262 File Offset: 0x00037462
		// (remove) Token: 0x06000CD3 RID: 3283 RVA: 0x00039270 File Offset: 0x00037470
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs> CellDeactivating
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellDeactivatingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellDeactivatingEvent, value);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000CD4 RID: 3284 RVA: 0x00039280 File Offset: 0x00037480
		// (remove) Token: 0x06000CD5 RID: 3285 RVA: 0x000392B8 File Offset: 0x000374B8
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs> CellDeactivatingDirect;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000CD6 RID: 3286 RVA: 0x000392ED File Offset: 0x000374ED
		// (remove) Token: 0x06000CD7 RID: 3287 RVA: 0x00039306 File Offset: 0x00037506
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs> CellsInViewChanged
		{
			add
			{
				this._cellsInViewChangedEventHandler = (global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs>)global::System.Delegate.Combine(this._cellsInViewChangedEventHandler, value);
			}
			remove
			{
				this._cellsInViewChangedEventHandler = (global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs>)global::System.Delegate.Remove(this._cellsInViewChangedEventHandler, value);
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0003931F File Offset: 0x0003751F
		internal void RaiseCellsInViewChanged(global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs eventArgs)
		{
			if (this._cellsInViewChangedEventHandler != null)
			{
				this._cellsInViewChangedEventHandler(this, eventArgs);
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x00039336 File Offset: 0x00037536
		protected virtual void OnCellUpdating(global::Infragistics.Windows.DataPresenter.Events.CellUpdatingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0003933F File Offset: 0x0003753F
		internal void RaiseCellUpdating(global::Infragistics.Windows.DataPresenter.Events.CellUpdatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatingEvent;
			args.Source = this;
			this.OnCellUpdating(args);
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000CDB RID: 3291 RVA: 0x0003935A File Offset: 0x0003755A
		// (remove) Token: 0x06000CDC RID: 3292 RVA: 0x00039368 File Offset: 0x00037568
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellUpdatingEventArgs> CellUpdating
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatingEvent, value);
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00039376 File Offset: 0x00037576
		protected virtual void OnCellUpdated(global::Infragistics.Windows.DataPresenter.Events.CellUpdatedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0003937F File Offset: 0x0003757F
		internal void RaiseCellUpdated(global::Infragistics.Windows.DataPresenter.Events.CellUpdatedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatedEvent;
			args.Source = this;
			this.OnCellUpdated(args);
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000CDF RID: 3295 RVA: 0x0003939A File Offset: 0x0003759A
		// (remove) Token: 0x06000CE0 RID: 3296 RVA: 0x000393A8 File Offset: 0x000375A8
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellUpdatedEventArgs> CellUpdated
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatedEvent, value);
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000393B6 File Offset: 0x000375B6
		protected virtual void OnClipboardCopying(global::Infragistics.Windows.DataPresenter.Events.ClipboardCopyingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000393BF File Offset: 0x000375BF
		internal void RaiseClipboardCopying(global::Infragistics.Windows.DataPresenter.Events.ClipboardCopyingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCopyingEvent;
			args.Source = this;
			this.OnClipboardCopying(args);
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000CE3 RID: 3299 RVA: 0x000393DA File Offset: 0x000375DA
		// (remove) Token: 0x06000CE4 RID: 3300 RVA: 0x000393E8 File Offset: 0x000375E8
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ClipboardCopyingEventArgs> ClipboardCopying
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCopyingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCopyingEvent, value);
			}
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x000393F6 File Offset: 0x000375F6
		protected virtual void OnClipboardOperationError(global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationErrorEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x000393FF File Offset: 0x000375FF
		internal void RaiseClipboardOperationError(global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationErrorEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardOperationErrorEvent;
			args.Source = this;
			this.OnClipboardOperationError(args);
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000CE7 RID: 3303 RVA: 0x0003941A File Offset: 0x0003761A
		// (remove) Token: 0x06000CE8 RID: 3304 RVA: 0x00039428 File Offset: 0x00037628
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationErrorEventArgs> ClipboardOperationError
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardOperationErrorEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardOperationErrorEvent, value);
			}
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x00039436 File Offset: 0x00037636
		protected virtual void OnClipboardPasting(global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x00039449 File Offset: 0x00037649
		internal void RaiseClipboardPasting(global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardPastingEvent;
			args.Source = this;
			this.OnClipboardPasting(args);
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000CEB RID: 3307 RVA: 0x00039464 File Offset: 0x00037664
		// (remove) Token: 0x06000CEC RID: 3308 RVA: 0x00039472 File Offset: 0x00037672
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs> ClipboardPasting
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardPastingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardPastingEvent, value);
			}
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x00039480 File Offset: 0x00037680
		protected virtual void OnCustomFilterSelectionControlOpening(global::Infragistics.Windows.DataPresenter.Events.CustomFilterSelectionControlOpeningEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x00039489 File Offset: 0x00037689
		internal void RaiseCustomFilterSelectionControlOpening(global::Infragistics.Windows.DataPresenter.Events.CustomFilterSelectionControlOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CustomFilterSelectionControlOpeningEvent;
			args.Source = this;
			this.OnCustomFilterSelectionControlOpening(args);
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000CEF RID: 3311 RVA: 0x000394A4 File Offset: 0x000376A4
		// (remove) Token: 0x06000CF0 RID: 3312 RVA: 0x000394B2 File Offset: 0x000376B2
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CustomFilterSelectionControlOpeningEventArgs> CustomFilterSelectionControlOpening
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CustomFilterSelectionControlOpeningEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CustomFilterSelectionControlOpeningEvent, value);
			}
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x000394C0 File Offset: 0x000376C0
		protected virtual void OnDataError(global::Infragistics.Windows.DataPresenter.Events.DataErrorEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000394C9 File Offset: 0x000376C9
		internal void RaiseDataError(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, global::System.Exception exception, global::Infragistics.Windows.DataPresenter.DataErrorOperation operation, string message)
		{
			this.RaiseDataError(record, field, exception, operation, message, false);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000394DC File Offset: 0x000376DC
		internal void RaiseDataError(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, global::System.Exception exception, global::Infragistics.Windows.DataPresenter.DataErrorOperation operation, string message, bool defaultCancelValue)
		{
			global::Infragistics.Windows.DataPresenter.DataErrorInfo info = new global::Infragistics.Windows.DataPresenter.DataErrorInfo(record, field, exception, operation, message);
			this.RaiseDataError(info, defaultCancelValue);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000394FF File Offset: 0x000376FF
		internal void RaiseDataError(global::Infragistics.Windows.DataPresenter.DataErrorInfo info)
		{
			this.RaiseDataError(info, false);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0003950C File Offset: 0x0003770C
		internal void RaiseDataError(global::Infragistics.Windows.DataPresenter.DataErrorInfo info, bool defaultCancelValue)
		{
			global::Infragistics.Windows.DataPresenter.Events.DataErrorEventArgs dataErrorEventArgs = new global::Infragistics.Windows.DataPresenter.Events.DataErrorEventArgs(info);
			dataErrorEventArgs.Cancel = defaultCancelValue;
			dataErrorEventArgs.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataErrorEvent;
			dataErrorEventArgs.Source = this;
			this.OnDataError(dataErrorEventArgs);
			if (dataErrorEventArgs.Cancel)
			{
				return;
			}
			this.DisplayDataError(dataErrorEventArgs.Message, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DataErrorMessageTitle"), global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Asterisk, true);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00039564 File Offset: 0x00037764
		private void DisplayDataError(string message, string title, global::System.Windows.MessageBoxButton buttons, global::System.Windows.MessageBoxImage image, bool processAsyncOnException)
		{
			try
			{
				global::Infragistics.Windows.Utilities.ShowMessageBox(this, message, title, buttons, image);
			}
			catch (global::System.Exception)
			{
				if (processAsyncOnException && !base.Dispatcher.HasShutdownStarted)
				{
					base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataErrorMessageDelegate(this.DisplayDataError), message, new object[]
					{
						title,
						buttons,
						image,
						false
					});
				}
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000CF7 RID: 3319 RVA: 0x000395E8 File Offset: 0x000377E8
		// (remove) Token: 0x06000CF8 RID: 3320 RVA: 0x000395F6 File Offset: 0x000377F6
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.DataErrorEventArgs> DataError
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataErrorEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataErrorEvent, value);
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00039604 File Offset: 0x00037804
		protected virtual void OnDataValueChanged(global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.DataValueChangedDirect != null)
			{
				this.DataValueChangedDirect(this, args);
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00039622 File Offset: 0x00037822
		internal void RaiseDataValueChanged(global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataValueChangedEvent;
			args.Source = this;
			this.OnDataValueChanged(args);
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000CFB RID: 3323 RVA: 0x0003963D File Offset: 0x0003783D
		// (remove) Token: 0x06000CFC RID: 3324 RVA: 0x0003964B File Offset: 0x0003784B
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs> DataValueChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataValueChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataValueChangedEvent, value);
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000CFD RID: 3325 RVA: 0x0003965C File Offset: 0x0003785C
		// (remove) Token: 0x06000CFE RID: 3326 RVA: 0x00039694 File Offset: 0x00037894
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs> DataValueChangedDirect;

		// Token: 0x06000CFF RID: 3327 RVA: 0x000396C9 File Offset: 0x000378C9
		protected virtual void OnEditModeEnded(global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x000396D2 File Offset: 0x000378D2
		internal void RaiseEditModeEnded(global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndedEvent;
			args.Source = this;
			this.OnEditModeEnded(args);
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000D01 RID: 3329 RVA: 0x000396ED File Offset: 0x000378ED
		// (remove) Token: 0x06000D02 RID: 3330 RVA: 0x000396FB File Offset: 0x000378FB
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs> EditModeEnded
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndedEvent, value);
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00039709 File Offset: 0x00037909
		protected virtual void OnEditModeEnding(global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00039712 File Offset: 0x00037912
		internal void RaiseEditModeEnding(global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndingEvent;
			args.Source = this;
			this.OnEditModeEnding(args);
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06000D05 RID: 3333 RVA: 0x0003972D File Offset: 0x0003792D
		// (remove) Token: 0x06000D06 RID: 3334 RVA: 0x0003973B File Offset: 0x0003793B
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs> EditModeEnding
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndingEvent, value);
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00039749 File Offset: 0x00037949
		protected virtual void OnEditModeStarted(global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00039752 File Offset: 0x00037952
		internal void RaiseEditModeStarted(global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartedEvent;
			args.Source = this;
			this.OnEditModeStarted(args);
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000D09 RID: 3337 RVA: 0x0003976D File Offset: 0x0003796D
		// (remove) Token: 0x06000D0A RID: 3338 RVA: 0x0003977B File Offset: 0x0003797B
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs> EditModeStarted
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartedEvent, value);
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00039789 File Offset: 0x00037989
		protected virtual void OnEditModeStarting(global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x0003979C File Offset: 0x0003799C
		internal void RaiseEditModeStarting(global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartingEvent;
			args.Source = this;
			this.OnEditModeStarting(args);
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000D0D RID: 3341 RVA: 0x000397B7 File Offset: 0x000379B7
		// (remove) Token: 0x06000D0E RID: 3342 RVA: 0x000397C5 File Offset: 0x000379C5
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs> EditModeStarting
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartingEvent, value);
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x000397D3 File Offset: 0x000379D3
		protected virtual void OnEditModeValidationError(global::Infragistics.Windows.DataPresenter.Events.EditModeValidationErrorEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x000397DC File Offset: 0x000379DC
		internal void RaiseEditModeValidationError(global::Infragistics.Windows.DataPresenter.Events.EditModeValidationErrorEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeValidationErrorEvent;
			args.Source = this;
			this.OnEditModeValidationError(args);
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000D11 RID: 3345 RVA: 0x000397F7 File Offset: 0x000379F7
		// (remove) Token: 0x06000D12 RID: 3346 RVA: 0x00039805 File Offset: 0x00037A05
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.EditModeValidationErrorEventArgs> EditModeValidationError
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeValidationErrorEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeValidationErrorEvent, value);
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x00039813 File Offset: 0x00037A13
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.ExecutingCommandDirect != null)
			{
				this.ExecutingCommandDirect(this, args);
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00039831 File Offset: 0x00037A31
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000D15 RID: 3349 RVA: 0x00039855 File Offset: 0x00037A55
		// (remove) Token: 0x06000D16 RID: 3350 RVA: 0x00039863 File Offset: 0x00037A63
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000D17 RID: 3351 RVA: 0x00039874 File Offset: 0x00037A74
		// (remove) Token: 0x06000D18 RID: 3352 RVA: 0x000398AC File Offset: 0x00037AAC
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommandDirect;

		// Token: 0x06000D19 RID: 3353 RVA: 0x000398E1 File Offset: 0x00037AE1
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.ExecutedCommandDirect != null)
			{
				this.ExecutedCommandDirect(this, args);
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000398FF File Offset: 0x00037AFF
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000D1B RID: 3355 RVA: 0x0003991A File Offset: 0x00037B1A
		// (remove) Token: 0x06000D1C RID: 3356 RVA: 0x00039928 File Offset: 0x00037B28
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000D1D RID: 3357 RVA: 0x00039938 File Offset: 0x00037B38
		// (remove) Token: 0x06000D1E RID: 3358 RVA: 0x00039970 File Offset: 0x00037B70
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommandDirect;

		// Token: 0x06000D1F RID: 3359 RVA: 0x000399A5 File Offset: 0x00037BA5
		protected virtual void OnFieldChooserOpening(global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000399AE File Offset: 0x00037BAE
		internal void RaiseFieldChooserOpening(global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldChooserOpeningEvent;
			args.Source = this;
			this.OnFieldChooserOpening(args);
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000D21 RID: 3361 RVA: 0x000399C9 File Offset: 0x00037BC9
		// (remove) Token: 0x06000D22 RID: 3362 RVA: 0x000399D7 File Offset: 0x00037BD7
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs> FieldChooserOpening
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldChooserOpeningEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldChooserOpeningEvent, value);
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x000399E8 File Offset: 0x00037BE8
		internal void RaiseFieldLayoutInitializingEvent(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this.OnFieldLayoutInitializing(new global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializingEventArgs(layout)
			{
				RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializingEvent,
				Source = this
			});
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00039A15 File Offset: 0x00037C15
		protected virtual void OnFieldLayoutInitializing(global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000D25 RID: 3365 RVA: 0x00039A1E File Offset: 0x00037C1E
		// (remove) Token: 0x06000D26 RID: 3366 RVA: 0x00039A2C File Offset: 0x00037C2C
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializingEventArgs> FieldLayoutInitializing
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializingEvent, value);
			}
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00039A3C File Offset: 0x00037C3C
		internal void RaiseFieldLayoutInitializedEvent(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this.OnFieldLayoutInitialized(new global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs(layout)
			{
				RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializedEvent,
				Source = this
			});
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00039A69 File Offset: 0x00037C69
		protected virtual void OnFieldLayoutInitialized(global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06000D29 RID: 3369 RVA: 0x00039A72 File Offset: 0x00037C72
		// (remove) Token: 0x06000D2A RID: 3370 RVA: 0x00039A80 File Offset: 0x00037C80
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs> FieldLayoutInitialized
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializedEvent, value);
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00039A8E File Offset: 0x00037C8E
		protected virtual void OnFieldPositionChanged(global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00039A97 File Offset: 0x00037C97
		internal void RaiseFieldPositionChanged(global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangedEvent;
			args.Source = this;
			this.OnFieldPositionChanged(args);
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000D2D RID: 3373 RVA: 0x00039AB2 File Offset: 0x00037CB2
		// (remove) Token: 0x06000D2E RID: 3374 RVA: 0x00039AC0 File Offset: 0x00037CC0
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs> FieldPositionChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangedEvent, value);
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00039ACE File Offset: 0x00037CCE
		protected virtual void OnFieldPositionChanging(global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00039AE1 File Offset: 0x00037CE1
		internal void RaiseFieldPositionChanging(global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangingEvent;
			args.Source = this;
			this.OnFieldPositionChanging(args);
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000D31 RID: 3377 RVA: 0x00039AFC File Offset: 0x00037CFC
		// (remove) Token: 0x06000D32 RID: 3378 RVA: 0x00039B0A File Offset: 0x00037D0A
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs> FieldPositionChanging
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangingEvent, value);
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00039B18 File Offset: 0x00037D18
		protected virtual void OnGrouping(global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00039B2B File Offset: 0x00037D2B
		internal void RaiseGrouping(global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupingEvent;
			args.Source = this;
			this.OnGrouping(args);
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000D35 RID: 3381 RVA: 0x00039B46 File Offset: 0x00037D46
		// (remove) Token: 0x06000D36 RID: 3382 RVA: 0x00039B54 File Offset: 0x00037D54
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs> Grouping
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupingEvent, value);
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00039B62 File Offset: 0x00037D62
		protected virtual void OnGrouped(global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x00039B6B File Offset: 0x00037D6B
		internal void RaiseGrouped(global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupedEvent;
			args.Source = this;
			this.OnGrouped(args);
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000D39 RID: 3385 RVA: 0x00039B86 File Offset: 0x00037D86
		// (remove) Token: 0x06000D3A RID: 3386 RVA: 0x00039B94 File Offset: 0x00037D94
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs> Grouped
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupedEvent, value);
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00039BA2 File Offset: 0x00037DA2
		protected virtual void OnInitializeCellValuePresenter(global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.InitializeCellValuePresenterDirect != null)
			{
				this.InitializeCellValuePresenterDirect(this, args);
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00039BC0 File Offset: 0x00037DC0
		internal void RaiseInitializeCellValuePresenter(global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeCellValuePresenterEvent;
			args.Source = this;
			this.OnInitializeCellValuePresenter(args);
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000D3D RID: 3389 RVA: 0x00039BDB File Offset: 0x00037DDB
		// (remove) Token: 0x06000D3E RID: 3390 RVA: 0x00039BE9 File Offset: 0x00037DE9
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs> InitializeCellValuePresenter
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeCellValuePresenterEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeCellValuePresenterEvent, value);
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000D3F RID: 3391 RVA: 0x00039BF8 File Offset: 0x00037DF8
		// (remove) Token: 0x06000D40 RID: 3392 RVA: 0x00039C30 File Offset: 0x00037E30
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs> InitializeCellValuePresenterDirect;

		// Token: 0x06000D41 RID: 3393 RVA: 0x00039C65 File Offset: 0x00037E65
		protected internal virtual void OnInitializeRecord(global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.InitializeRecordDirect != null)
			{
				this.InitializeRecordDirect(this, args);
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000D42 RID: 3394 RVA: 0x00039C83 File Offset: 0x00037E83
		// (remove) Token: 0x06000D43 RID: 3395 RVA: 0x00039C91 File Offset: 0x00037E91
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs> InitializeRecord
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeRecordEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeRecordEvent, value);
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000D44 RID: 3396 RVA: 0x00039CA0 File Offset: 0x00037EA0
		// (remove) Token: 0x06000D45 RID: 3397 RVA: 0x00039CD8 File Offset: 0x00037ED8
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs> InitializeRecordDirect;

		// Token: 0x06000D46 RID: 3398 RVA: 0x00039D10 File Offset: 0x00037F10
		internal virtual void RaiseInitializeRecord(global::Infragistics.Windows.DataPresenter.Record record, bool reInitialize, bool sortvalueChanged)
		{
			if (this._cachedInitializeRecordEventSuppressed == null)
			{
				this._cachedInitializeRecordEventSuppressed = new bool?(this.IsEventSuppressed(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeRecordEvent));
			}
			if (this._cachedInitializeRecordEventSuppressed.Value && !this._isDerived && this.InitializeRecordDirect == null)
			{
				return;
			}
			if (record is global::Infragistics.Windows.DataPresenter.HeaderRecord)
			{
				return;
			}
			bool flag = this.SuspendInitializeRecordFor(record);
			if (flag)
			{
				return;
			}
			try
			{
				this.OnInitializeRecord(new global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs(record, reInitialize, sortvalueChanged)
				{
					RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeRecordEvent,
					Source = this
				});
			}
			finally
			{
				this.ResumeInitializeRecordFor(record);
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00039DB0 File Offset: 0x00037FB0
		protected internal virtual void OnInitializeTemplateAddRecord(global::Infragistics.Windows.DataPresenter.Events.InitializeTemplateAddRecordEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000D48 RID: 3400 RVA: 0x00039DB9 File Offset: 0x00037FB9
		// (remove) Token: 0x06000D49 RID: 3401 RVA: 0x00039DC7 File Offset: 0x00037FC7
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeTemplateAddRecordEventArgs> InitializeTemplateAddRecord
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeTemplateAddRecordEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeTemplateAddRecordEvent, value);
			}
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00039DD8 File Offset: 0x00037FD8
		internal void RaiseInitializeTemplateAddRecord(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this.OnInitializeTemplateAddRecord(new global::Infragistics.Windows.DataPresenter.Events.InitializeTemplateAddRecordEventArgs(record)
			{
				RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeTemplateAddRecordEvent,
				Source = this
			});
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00039E05 File Offset: 0x00038005
		protected virtual void OnRecordActivated(global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.RecordActivatedDirect != null)
			{
				this.RecordActivatedDirect(this, args);
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00039E23 File Offset: 0x00038023
		internal void RaiseRecordActivated(global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatedEvent;
			args.Source = this;
			this.OnRecordActivated(args);
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000D4D RID: 3405 RVA: 0x00039E3E File Offset: 0x0003803E
		// (remove) Token: 0x06000D4E RID: 3406 RVA: 0x00039E4C File Offset: 0x0003804C
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs> RecordActivated
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatedEvent, value);
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06000D4F RID: 3407 RVA: 0x00039E5C File Offset: 0x0003805C
		// (remove) Token: 0x06000D50 RID: 3408 RVA: 0x00039E94 File Offset: 0x00038094
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs> RecordActivatedDirect;

		// Token: 0x06000D51 RID: 3409 RVA: 0x00039EC9 File Offset: 0x000380C9
		protected virtual void OnRecordActivating(global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.RecordActivatingDirect != null)
			{
				this.RecordActivatingDirect(this, args);
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00039EE7 File Offset: 0x000380E7
		internal void RaiseRecordActivating(global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatingEvent;
			args.Source = this;
			this.OnRecordActivating(args);
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06000D53 RID: 3411 RVA: 0x00039F02 File Offset: 0x00038102
		// (remove) Token: 0x06000D54 RID: 3412 RVA: 0x00039F10 File Offset: 0x00038110
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs> RecordActivating
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatingEvent, value);
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000D55 RID: 3413 RVA: 0x00039F20 File Offset: 0x00038120
		// (remove) Token: 0x06000D56 RID: 3414 RVA: 0x00039F58 File Offset: 0x00038158
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs> RecordActivatingDirect;

		// Token: 0x06000D57 RID: 3415 RVA: 0x00039F8D File Offset: 0x0003818D
		protected virtual void OnRecordAdding(global::Infragistics.Windows.DataPresenter.Events.RecordAddingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00039F96 File Offset: 0x00038196
		internal void RaiseRecordAdding(global::Infragistics.Windows.DataPresenter.Events.RecordAddingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddingEvent;
			args.Source = this;
			this.OnRecordAdding(args);
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000D59 RID: 3417 RVA: 0x00039FB1 File Offset: 0x000381B1
		// (remove) Token: 0x06000D5A RID: 3418 RVA: 0x00039FBF File Offset: 0x000381BF
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordAddingEventArgs> RecordAdding
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddingEvent, value);
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00039FCD File Offset: 0x000381CD
		protected virtual void OnRecordAdded(global::Infragistics.Windows.DataPresenter.Events.RecordAddedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00039FD6 File Offset: 0x000381D6
		internal void RaiseRecordAdded(global::Infragistics.Windows.DataPresenter.Events.RecordAddedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddedEvent;
			args.Source = this;
			this.OnRecordAdded(args);
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000D5D RID: 3421 RVA: 0x00039FF1 File Offset: 0x000381F1
		// (remove) Token: 0x06000D5E RID: 3422 RVA: 0x00039FFF File Offset: 0x000381FF
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordAddedEventArgs> RecordAdded
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddedEvent, value);
			}
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0003A00D File Offset: 0x0003820D
		protected virtual void OnRecordCollapsed(global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0003A016 File Offset: 0x00038216
		internal void RaiseRecordCollapsed(global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsedEvent;
			args.Source = this;
			this.OnRecordCollapsed(args);
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000D61 RID: 3425 RVA: 0x0003A031 File Offset: 0x00038231
		// (remove) Token: 0x06000D62 RID: 3426 RVA: 0x0003A03F File Offset: 0x0003823F
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs> RecordCollapsed
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsedEvent, value);
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0003A04D File Offset: 0x0003824D
		protected virtual void OnRecordCollapsing(global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0003A056 File Offset: 0x00038256
		internal void RaiseRecordCollapsing(global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsingEvent;
			args.Source = this;
			this.OnRecordCollapsing(args);
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06000D65 RID: 3429 RVA: 0x0003A071 File Offset: 0x00038271
		// (remove) Token: 0x06000D66 RID: 3430 RVA: 0x0003A07F File Offset: 0x0003827F
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs> RecordCollapsing
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsingEvent, value);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0003A08D File Offset: 0x0003828D
		protected virtual void OnRecordDeactivating(global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.RecordDeactivatingDirect != null)
			{
				this.RecordDeactivatingDirect(this, args);
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0003A0AB File Offset: 0x000382AB
		internal void RaiseRecordDeactivating(global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordDeactivatingEvent;
			args.Source = this;
			this.OnRecordDeactivating(args);
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06000D69 RID: 3433 RVA: 0x0003A0C6 File Offset: 0x000382C6
		// (remove) Token: 0x06000D6A RID: 3434 RVA: 0x0003A0D4 File Offset: 0x000382D4
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs> RecordDeactivating
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordDeactivatingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordDeactivatingEvent, value);
			}
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06000D6B RID: 3435 RVA: 0x0003A0E4 File Offset: 0x000382E4
		// (remove) Token: 0x06000D6C RID: 3436 RVA: 0x0003A11C File Offset: 0x0003831C
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs> RecordDeactivatingDirect;

		// Token: 0x06000D6D RID: 3437 RVA: 0x0003A151 File Offset: 0x00038351
		protected virtual void OnRecordFilterChanged(global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0003A15A File Offset: 0x0003835A
		internal void RaiseRecordFilterChanged(global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangedEvent;
			args.Source = this;
			this.OnRecordFilterChanged(args);
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000D6F RID: 3439 RVA: 0x0003A175 File Offset: 0x00038375
		// (remove) Token: 0x06000D70 RID: 3440 RVA: 0x0003A183 File Offset: 0x00038383
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangedEventArgs> RecordFilterChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangedEvent, value);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0003A191 File Offset: 0x00038391
		protected virtual void OnRecordFilterChanging(global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0003A1A4 File Offset: 0x000383A4
		internal void RaiseRecordFilterChanging(global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangingEvent;
			args.Source = this;
			this.OnRecordFilterChanging(args);
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000D73 RID: 3443 RVA: 0x0003A1BF File Offset: 0x000383BF
		// (remove) Token: 0x06000D74 RID: 3444 RVA: 0x0003A1CD File Offset: 0x000383CD
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs> RecordFilterChanging
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangingEvent, value);
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0003A1DB File Offset: 0x000383DB
		protected virtual void OnRecordFilterDropDownItemInitializing(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownItemInitializingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0003A1E4 File Offset: 0x000383E4
		internal void RaiseRecordFilterDropDownItemInitializing(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownItemInitializingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownItemInitializingEvent;
			args.Source = this;
			this.OnRecordFilterDropDownItemInitializing(args);
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06000D77 RID: 3447 RVA: 0x0003A1FF File Offset: 0x000383FF
		// (remove) Token: 0x06000D78 RID: 3448 RVA: 0x0003A20D File Offset: 0x0003840D
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownItemInitializingEventArgs> RecordFilterDropDownItemInitializing
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownItemInitializingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownItemInitializingEvent, value);
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x0003A21B File Offset: 0x0003841B
		protected virtual void OnRecordFilterDropDownOpening(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x0003A224 File Offset: 0x00038424
		internal void RaiseRecordFilterDropDownOpening(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownOpeningEvent;
			args.Source = this;
			this.OnRecordFilterDropDownOpening(args);
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06000D7B RID: 3451 RVA: 0x0003A23F File Offset: 0x0003843F
		// (remove) Token: 0x06000D7C RID: 3452 RVA: 0x0003A24D File Offset: 0x0003844D
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs> RecordFilterDropDownOpening
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownOpeningEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownOpeningEvent, value);
			}
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x0003A25B File Offset: 0x0003845B
		protected virtual void OnRecordFilterDropDownPopulating(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0003A264 File Offset: 0x00038464
		internal void RaiseRecordFilterDropDownPopulating(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownPopulatingEvent;
			args.Source = this;
			this.OnRecordFilterDropDownPopulating(args);
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06000D7F RID: 3455 RVA: 0x0003A27F File Offset: 0x0003847F
		// (remove) Token: 0x06000D80 RID: 3456 RVA: 0x0003A28D File Offset: 0x0003848D
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs> RecordFilterDropDownPopulating
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownPopulatingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownPopulatingEvent, value);
			}
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x0003A29B File Offset: 0x0003849B
		protected virtual void OnRecordsDeleted(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x0003A2A4 File Offset: 0x000384A4
		internal void RaiseRecordsDeleted(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletedEvent;
			args.Source = this;
			this.OnRecordsDeleted(args);
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06000D83 RID: 3459 RVA: 0x0003A2BF File Offset: 0x000384BF
		// (remove) Token: 0x06000D84 RID: 3460 RVA: 0x0003A2CD File Offset: 0x000384CD
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordsDeletedEventArgs> RecordsDeleted
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletedEvent, value);
			}
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x0003A2DB File Offset: 0x000384DB
		protected virtual void OnRecordsDeleting(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x0003A2EE File Offset: 0x000384EE
		internal void RaiseRecordsDeleting(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletingEvent;
			args.Source = this;
			this.OnRecordsDeleting(args);
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000D87 RID: 3463 RVA: 0x0003A309 File Offset: 0x00038509
		// (remove) Token: 0x06000D88 RID: 3464 RVA: 0x0003A317 File Offset: 0x00038517
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs> RecordsDeleting
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletingEvent, value);
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0003A325 File Offset: 0x00038525
		protected virtual void OnRecordExpanded(global::Infragistics.Windows.DataPresenter.Events.RecordExpandedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0003A32E File Offset: 0x0003852E
		internal void RaiseRecordExpanded(global::Infragistics.Windows.DataPresenter.Events.RecordExpandedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandedEvent;
			args.Source = this;
			this.OnRecordExpanded(args);
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000D8B RID: 3467 RVA: 0x0003A349 File Offset: 0x00038549
		// (remove) Token: 0x06000D8C RID: 3468 RVA: 0x0003A357 File Offset: 0x00038557
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordExpandedEventArgs> RecordExpanded
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandedEvent, value);
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0003A365 File Offset: 0x00038565
		protected virtual void OnRecordExpanding(global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x0003A378 File Offset: 0x00038578
		internal void RaiseRecordExpanding(global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandingEvent;
			args.Source = this;
			this.OnRecordExpanding(args);
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000D8F RID: 3471 RVA: 0x0003A393 File Offset: 0x00038593
		// (remove) Token: 0x06000D90 RID: 3472 RVA: 0x0003A3A1 File Offset: 0x000385A1
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs> RecordExpanding
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandingEvent, value);
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x0003A3AF File Offset: 0x000385AF
		protected virtual void OnRecordFixedLocationChanged(global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0003A3B8 File Offset: 0x000385B8
		internal void RaiseRecordFixedLocationChanged(global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangedEvent;
			args.Source = this;
			this.OnRecordFixedLocationChanged(args);
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000D93 RID: 3475 RVA: 0x0003A3D3 File Offset: 0x000385D3
		// (remove) Token: 0x06000D94 RID: 3476 RVA: 0x0003A3E1 File Offset: 0x000385E1
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs> RecordFixedLocationChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangedEvent, value);
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x0003A3EF File Offset: 0x000385EF
		protected virtual void OnRecordFixedLocationChanging(global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x0003A402 File Offset: 0x00038602
		internal void RaiseRecordFixedLocationChanging(global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangingEvent;
			args.Source = this;
			this.OnRecordFixedLocationChanging(args);
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000D97 RID: 3479 RVA: 0x0003A41D File Offset: 0x0003861D
		// (remove) Token: 0x06000D98 RID: 3480 RVA: 0x0003A42B File Offset: 0x0003862B
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs> RecordFixedLocationChanging
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangingEvent, value);
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0003A439 File Offset: 0x00038639
		protected virtual void OnRecordsInViewChanged(global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.RecordsInViewChangedDirect != null)
			{
				this.RecordsInViewChangedDirect(this, args);
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0003A458 File Offset: 0x00038658
		private object ProcessPostedRecordsInViewChanged(object param)
		{
			if (param is int)
			{
				int num = (int)param;
				if (num == this.ScrollVersion)
				{
					this.ScrollVersion++;
				}
			}
			this._postRecordsInViewChangedOperation = null;
			this.RaiseRecordsInViewChanged(new global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs());
			return null;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0003A49E File Offset: 0x0003869E
		internal void RaiseRecordsInViewChanged(global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewChangedEvent;
			args.Source = this;
			this.OnRecordsInViewChanged(args);
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06000D9C RID: 3484 RVA: 0x0003A4B9 File Offset: 0x000386B9
		// (remove) Token: 0x06000D9D RID: 3485 RVA: 0x0003A4C7 File Offset: 0x000386C7
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs> RecordsInViewChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewChangedEvent, value);
			}
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06000D9E RID: 3486 RVA: 0x0003A4D8 File Offset: 0x000386D8
		// (remove) Token: 0x06000D9F RID: 3487 RVA: 0x0003A510 File Offset: 0x00038710
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs> RecordsInViewChangedDirect;

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0003A545 File Offset: 0x00038745
		protected virtual void OnRecordUpdateCanceling(global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCancelingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0003A54E File Offset: 0x0003874E
		internal void RaiseRecordUpdateCanceling(global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCancelingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCancelingEvent;
			args.Source = this;
			this.OnRecordUpdateCanceling(args);
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06000DA2 RID: 3490 RVA: 0x0003A569 File Offset: 0x00038769
		// (remove) Token: 0x06000DA3 RID: 3491 RVA: 0x0003A577 File Offset: 0x00038777
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCancelingEventArgs> RecordUpdateCanceling
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCancelingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCancelingEvent, value);
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0003A585 File Offset: 0x00038785
		protected virtual void OnRecordUpdateCanceled(global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCanceledEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0003A58E File Offset: 0x0003878E
		internal void RaiseRecordUpdateCanceled(global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCanceledEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCanceledEvent;
			args.Source = this;
			this.OnRecordUpdateCanceled(args);
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06000DA6 RID: 3494 RVA: 0x0003A5A9 File Offset: 0x000387A9
		// (remove) Token: 0x06000DA7 RID: 3495 RVA: 0x0003A5B7 File Offset: 0x000387B7
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCanceledEventArgs> RecordUpdateCanceled
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCanceledEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCanceledEvent, value);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0003A5C5 File Offset: 0x000387C5
		protected virtual void OnRecordUpdating(global::Infragistics.Windows.DataPresenter.Events.RecordUpdatingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0003A5CE File Offset: 0x000387CE
		internal void RaiseRecordUpdating(global::Infragistics.Windows.DataPresenter.Events.RecordUpdatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatingEvent;
			args.Source = this;
			this.OnRecordUpdating(args);
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06000DAA RID: 3498 RVA: 0x0003A5E9 File Offset: 0x000387E9
		// (remove) Token: 0x06000DAB RID: 3499 RVA: 0x0003A5F7 File Offset: 0x000387F7
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordUpdatingEventArgs> RecordUpdating
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatingEvent, value);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0003A605 File Offset: 0x00038805
		protected virtual void OnRecordUpdated(global::Infragistics.Windows.DataPresenter.Events.RecordUpdatedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0003A60E File Offset: 0x0003880E
		internal void RaiseRecordUpdated(global::Infragistics.Windows.DataPresenter.Events.RecordUpdatedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatedEvent;
			args.Source = this;
			this.OnRecordUpdated(args);
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06000DAE RID: 3502 RVA: 0x0003A629 File Offset: 0x00038829
		// (remove) Token: 0x06000DAF RID: 3503 RVA: 0x0003A637 File Offset: 0x00038837
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordUpdatedEventArgs> RecordUpdated
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatedEvent, value);
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0003A645 File Offset: 0x00038845
		protected virtual void OnSelectedItemsChanged(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0003A64E File Offset: 0x0003884E
		internal void RaiseSelectedItemsChangedAsync(global::System.Type type)
		{
			if (this._selectedItemsChangePending != null)
			{
				return;
			}
			this._selectedItemsChangePending = type;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ProcessSelectedItemsChanged));
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0003A680 File Offset: 0x00038880
		internal void ProcessSelectedItemsChanged()
		{
			if (this._selectedItemsChangePending == null)
			{
				return;
			}
			this.RaiseSelectedItemsChanged(new global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs(this._selectedItemsChangePending));
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0003A6A4 File Offset: 0x000388A4
		internal void RaiseSelectedItemsChanged(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs args)
		{
			this._selectedItemsChangePending = null;
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangedEvent;
			args.Source = this;
			this.OnSelectedItemsChanged(args);
			this.SetSelectedDataItemsInternal();
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
			if (viewPanel != null)
			{
				viewPanel.OnSelectedItemsChanged();
			}
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06000DB4 RID: 3508 RVA: 0x0003A6EC File Offset: 0x000388EC
		// (remove) Token: 0x06000DB5 RID: 3509 RVA: 0x0003A6FA File Offset: 0x000388FA
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs> SelectedItemsChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangedEvent, value);
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0003A708 File Offset: 0x00038908
		protected virtual void OnSelectedItemsChanging(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0003A711 File Offset: 0x00038911
		internal void RaiseSelectedItemsChanging(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangingEvent;
			args.Source = this;
			this.OnSelectedItemsChanging(args);
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000DB8 RID: 3512 RVA: 0x0003A72C File Offset: 0x0003892C
		// (remove) Token: 0x06000DB9 RID: 3513 RVA: 0x0003A73A File Offset: 0x0003893A
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs> SelectedItemsChanging
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangingEvent, value);
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0003A748 File Offset: 0x00038948
		protected virtual void OnSorting(global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0003A75B File Offset: 0x0003895B
		internal void RaiseSorting(global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortingEvent;
			args.Source = this;
			this.OnSorting(args);
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06000DBC RID: 3516 RVA: 0x0003A776 File Offset: 0x00038976
		// (remove) Token: 0x06000DBD RID: 3517 RVA: 0x0003A784 File Offset: 0x00038984
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs> Sorting
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortingEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortingEvent, value);
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0003A792 File Offset: 0x00038992
		protected virtual void OnSorted(global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0003A79B File Offset: 0x0003899B
		internal void RaiseSorted(global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortedEvent;
			args.Source = this;
			this.OnSorted(args);
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06000DC0 RID: 3520 RVA: 0x0003A7B6 File Offset: 0x000389B6
		// (remove) Token: 0x06000DC1 RID: 3521 RVA: 0x0003A7C4 File Offset: 0x000389C4
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs> Sorted
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortedEvent, value);
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0003A7D2 File Offset: 0x000389D2
		protected virtual void OnSummaryResultChanged(global::Infragistics.Windows.DataPresenter.Events.SummaryResultChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0003A7DB File Offset: 0x000389DB
		internal void RaiseSummaryResultChanged(global::Infragistics.Windows.DataPresenter.Events.SummaryResultChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummaryResultChangedEvent;
			args.Source = this;
			this.OnSummaryResultChanged(args);
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06000DC4 RID: 3524 RVA: 0x0003A7F6 File Offset: 0x000389F6
		// (remove) Token: 0x06000DC5 RID: 3525 RVA: 0x0003A804 File Offset: 0x00038A04
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SummaryResultChangedEventArgs> SummaryResultChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummaryResultChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummaryResultChangedEvent, value);
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0003A812 File Offset: 0x00038A12
		protected virtual void OnSummarySelectionControlClosed(global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlClosedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0003A81B File Offset: 0x00038A1B
		internal void RaiseSummarySelectionControlClosed(global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlClosedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlClosedEvent;
			args.Source = this;
			this.OnSummarySelectionControlClosed(args);
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000DC8 RID: 3528 RVA: 0x0003A836 File Offset: 0x00038A36
		// (remove) Token: 0x06000DC9 RID: 3529 RVA: 0x0003A844 File Offset: 0x00038A44
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlClosedEventArgs> SummarySelectionControlClosed
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlClosedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlClosedEvent, value);
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0003A852 File Offset: 0x00038A52
		protected virtual void OnSummarySelectionControlOpening(global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0003A865 File Offset: 0x00038A65
		internal void RaiseSummarySelectionControlOpening(global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlOpeningEvent;
			args.Source = this;
			this.OnSummarySelectionControlOpening(args);
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06000DCC RID: 3532 RVA: 0x0003A880 File Offset: 0x00038A80
		// (remove) Token: 0x06000DCD RID: 3533 RVA: 0x0003A88E File Offset: 0x00038A8E
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs> SummarySelectionControlOpening
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlOpeningEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlOpeningEvent, value);
			}
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0003A89C File Offset: 0x00038A9C
		private static object CoerceActiveDataItem(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			return dataPresenterBase.SynchDataItemValue(value);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0003A8B8 File Offset: 0x00038AB8
		private static void OnActiveDataItemChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)dependencyObject;
			dataPresenterBase.SynchDataItemValue(e.NewValue);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0003A8DC File Offset: 0x00038ADC
		private object SynchDataItemValue(object value)
		{
			if (value != null && this.DataSource == null)
			{
				this._pendingActiveDataItem = value;
				return value;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (value == null)
			{
				if (dataRecord == null || dataRecord.DataItem == null)
				{
					return value;
				}
				this.ActiveRecord = null;
			}
			else
			{
				if (dataRecord != null && dataRecord.DataItemForComparison != null && this.DataItemEqualityComparerResolved.Equals(dataRecord.DataItemForComparison, global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(value)))
				{
					return value;
				}
				dataRecord = this.GetRecordFromDataItem(value, true);
				if (dataRecord != null && dataRecord != this.ActiveRecord)
				{
					dataRecord.EnsureAncestorsAreExpanded();
					this.ActiveRecord = dataRecord;
				}
			}
			dataRecord = (this.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord);
			if (dataRecord != null)
			{
				return dataRecord.DataItem;
			}
			return null;
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0003A981 File Offset: 0x00038B81
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x0003A98E File Offset: 0x00038B8E
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public object ActiveDataItem
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveDataItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveDataItemProperty, value);
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0003A99C File Offset: 0x00038B9C
		private static void OnActiveCellChangedCallback(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)dependencyObject;
			if ((global::Infragistics.Windows.DataPresenter.Cell)e.NewValue == null && dataPresenterBase.ReadLocalValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveCellProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnCoerceActiveCell(dataPresenterBase, null);
				if (dataPresenterBase._activeCell != null)
				{
					dataPresenterBase.ActiveCell = dataPresenterBase._activeCell;
				}
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0003A9F0 File Offset: 0x00038BF0
		private static object OnCoerceActiveCell(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase == null)
			{
				return null;
			}
			if (value == null && dataPresenterBase._clearingActiveCell)
			{
				dataPresenterBase._activeCell = null;
				return null;
			}
			dataPresenterBase._cachedLastActiveCell = dataPresenterBase._activeCell;
			dataPresenterBase.SetActiveCell(value as global::Infragistics.Windows.DataPresenter.Cell);
			dataPresenterBase._cachedLastActiveCell = null;
			return dataPresenterBase._activeCell;
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0003AA42 File Offset: 0x00038C42
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x0003AA50 File Offset: 0x00038C50
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Cell ActiveCell
		{
			get
			{
				this.VerifyActiveRecordNotDeleted();
				return this._activeCell;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveCellProperty, value);
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0003AA60 File Offset: 0x00038C60
		private static void OnActiveRecordChangedCallback(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)dependencyObject;
			if ((global::Infragistics.Windows.DataPresenter.Record)e.NewValue == null && dataPresenterBase.ReadLocalValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveRecordProperty) == global::System.Windows.DependencyProperty.UnsetValue)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.OnCoerceActiveRecord(dataPresenterBase, null);
				if (dataPresenterBase._activeRecord != null)
				{
					dataPresenterBase.ActiveRecord = dataPresenterBase._activeRecord;
				}
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = dataPresenterBase.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			dataPresenterBase.ActiveDataItem = ((dataRecord == null) ? null : dataRecord.DataItem);
			dataPresenterBase.ClearPendingActiveRecordPresenter();
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0003AAD8 File Offset: 0x00038CD8
		private static object OnCoerceActiveRecord(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				dataPresenterBase.SetActiveRecord(value as global::Infragistics.Windows.DataPresenter.Record, true);
				return dataPresenterBase._activeRecord;
			}
			return null;
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0003AB04 File Offset: 0x00038D04
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x0003AB12 File Offset: 0x00038D12
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Record ActiveRecord
		{
			get
			{
				this.VerifyActiveRecordNotDeleted();
				return this._activeRecord;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ActiveRecordProperty, value);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0003AB20 File Offset: 0x00038D20
		internal global::Infragistics.Windows.DataPresenter.Record ActiveRecordInternal
		{
			get
			{
				return this._activeRecord;
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0003AB28 File Offset: 0x00038D28
		private static void OnAutoFitChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				bool? cachedAutoFit = (bool?)e.NewValue;
				dataPresenterBase._cachedAutoFit = cachedAutoFit;
				dataPresenterBase.UpdateScrollBarVisibility();
				dataPresenterBase.InvalidateGeneratedStylesAsync(true);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x0003AB60 File Offset: 0x00038D60
		// (set) Token: 0x06000DDE RID: 3550 RVA: 0x0003AB68 File Offset: 0x00038D68
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		[global::System.ComponentModel.Bindable(true)]
		public bool? AutoFit
		{
			get
			{
				return this._cachedAutoFit;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.AutoFitProperty, value);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0003AB7B File Offset: 0x00038D7B
		public bool AutoFitResolved
		{
			get
			{
				if (this._cachedAutoFit == null)
				{
					return this.CurrentViewInternal.DefaultAutoFit;
				}
				return this._cachedAutoFit.Value;
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0003ABA4 File Offset: 0x00038DA4
		private static void OnBindToSampleDataChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				if ((bool)e.NewValue)
				{
					dataPresenterBase.DataSource = global::Infragistics.Windows.Internal.DataBindingUtilities.GetSampleData();
					return;
				}
				if (dataPresenterBase.DataSource == global::Infragistics.Windows.Internal.DataBindingUtilities.GetSampleData())
				{
					dataPresenterBase.DataSource = null;
				}
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0003ABE9 File Offset: 0x00038DE9
		// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x0003ABFB File Offset: 0x00038DFB
		[global::System.ComponentModel.DefaultValue(false)]
		public bool BindToSampleData
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.BindToSampleDataProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.BindToSampleDataProperty, value);
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0003AC10 File Offset: 0x00038E10
		private static void OnCalculationAdapterChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapterInternal dataPresenterCalculationAdapterInternal = e.OldValue as global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapterInternal;
			if (dataPresenterCalculationAdapterInternal != null)
			{
				dataPresenterBase.InternalRemoveLogicalChild(dataPresenterCalculationAdapterInternal);
				if (dataPresenterCalculationAdapterInternal.DataPresenter == dataPresenterBase)
				{
					dataPresenterCalculationAdapterInternal.DataPresenter = null;
				}
			}
			global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapterInternal dataPresenterCalculationAdapterInternal2 = e.NewValue as global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapterInternal;
			dataPresenterBase._calculationAdapter = dataPresenterCalculationAdapterInternal2;
			if (dataPresenterCalculationAdapterInternal2 != null)
			{
				if (dataPresenterCalculationAdapterInternal2.DataPresenter != null && dataPresenterCalculationAdapterInternal2.DataPresenter != dataPresenterBase)
				{
					throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CalculationAdapter_NotMultiUse"));
				}
				dataPresenterCalculationAdapterInternal2.DataPresenter = dataPresenterBase;
				dataPresenterBase.InternalAddLogicalChild(dataPresenterCalculationAdapterInternal2);
				return;
			}
			else
			{
				if (e.NewValue != null)
				{
					throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CalculationAdapter_InvalidValue"));
				}
				return;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0003ACAB File Offset: 0x00038EAB
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x0003ACBD File Offset: 0x00038EBD
		public global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapter CalculationAdapter
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapter)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CalculationAdapterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CalculationAdapterProperty, value);
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0003ACCC File Offset: 0x00038ECC
		private static void OnCellContainerGenerationModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)dependencyObject;
			global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode cachedCellContainerGenerationMode = (global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode)e.NewValue;
			dataPresenterBase._cachedCellContainerGenerationMode = cachedCellContainerGenerationMode;
			dataPresenterBase.InvalidateGeneratedStyles(true, false);
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000DE7 RID: 3559 RVA: 0x0003ACFC File Offset: 0x00038EFC
		// (set) Token: 0x06000DE8 RID: 3560 RVA: 0x0003AD0E File Offset: 0x00038F0E
		public global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode CellContainerGenerationMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellContainerGenerationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellContainerGenerationModeProperty, value);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x0003AD21 File Offset: 0x00038F21
		// (set) Token: 0x06000DEA RID: 3562 RVA: 0x0003AD33 File Offset: 0x00038F33
		[global::System.ComponentModel.Bindable(true)]
		public string ClipboardCellDelimiter
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCellDelimiterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCellDelimiterProperty, value);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0003AD41 File Offset: 0x00038F41
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x0003AD53 File Offset: 0x00038F53
		[global::System.ComponentModel.Bindable(true)]
		public string ClipboardCellSeparator
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCellSeparatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCellSeparatorProperty, value);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x0003AD61 File Offset: 0x00038F61
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x0003AD73 File Offset: 0x00038F73
		[global::System.ComponentModel.Bindable(true)]
		public string ClipboardRecordSeparator
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardRecordSeparatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardRecordSeparatorProperty, value);
			}
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0003AD81 File Offset: 0x00038F81
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static global::Infragistics.Windows.DataPresenter.ViewBase GetCurrentView(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.ViewBase)d.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0003AD93 File Offset: 0x00038F93
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetCurrentView(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DataPresenter.ViewBase value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty, value);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0003ADA1 File Offset: 0x00038FA1
		private static void OnDataItemEqualityComparerChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DataPresenter.DataPresenterBase)d).InitializeDataItemEqualityComparerResolved();
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0003ADB0 File Offset: 0x00038FB0
		private void InitializeDataItemEqualityComparerResolved()
		{
			global::System.Collections.IEqualityComparer dataItemEqualityComparer = this.DataItemEqualityComparer;
			if (dataItemEqualityComparer != null)
			{
				this._dataItemEqualityComparerResolved = (dataItemEqualityComparer as global::System.Collections.Generic.IEqualityComparer<object>);
				if (this._dataItemEqualityComparerResolved == null)
				{
					this._dataItemEqualityComparerResolved = new global::Infragistics.Windows.DataPresenter.EqualityComparerWrapper(dataItemEqualityComparer);
					return;
				}
			}
			else
			{
				this._dataItemEqualityComparerResolved = global::Infragistics.Windows.DataPresenter.ReferenceEqualityComparer.Instance;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0003ADF3 File Offset: 0x00038FF3
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x0003AE05 File Offset: 0x00039005
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.IEqualityComparer DataItemEqualityComparer
		{
			get
			{
				return (global::System.Collections.IEqualityComparer)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataItemEqualityComparerProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataItemEqualityComparerProperty, value);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0003AE13 File Offset: 0x00039013
		internal global::System.Collections.Generic.IEqualityComparer<object> DataItemEqualityComparerResolved
		{
			get
			{
				return this._dataItemEqualityComparerResolved;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x0003AE1B File Offset: 0x0003901B
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataItemsCollection DataItems
		{
			get
			{
				if (this._dataItems == null)
				{
					this._dataItems = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataItemsCollection(this);
				}
				return this._dataItems;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0003AE37 File Offset: 0x00039037
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x0003AE49 File Offset: 0x00039049
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.IEnumerable DataSource
		{
			get
			{
				return (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceProperty, value);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0003AE57 File Offset: 0x00039057
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x0003AE69 File Offset: 0x00039069
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior DataSourceResetBehavior
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceResetBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceResetBehaviorProperty, value);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x0003AE7C File Offset: 0x0003907C
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x0003AEF8 File Offset: 0x000390F8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout DefaultFieldLayout
		{
			get
			{
				if (this._defaultLayout != null && this._defaultLayout.WasRemovedFromCollection)
				{
					this._defaultLayout = null;
				}
				if (this._defaultLayout != null || this._fieldLayouts == null || this._fieldLayouts.Count <= 0)
				{
					return this._defaultLayout;
				}
				if (this.RecordManager != null && this.RecordManager.FieldLayout != null)
				{
					return this.RecordManager.FieldLayout;
				}
				return this._fieldLayouts.GetDefaultFieldLayout();
			}
			set
			{
				if (value != null && !this.FieldLayouts.Contains(value))
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_3"));
				}
				this._defaultLayout = value;
				if (base.IsInitialized && this.IsTreeView && this.FieldLayouts.Count > 0)
				{
					this.InvalidateFormatSettings();
					this.InvalidateGeneratedStyles(true, true);
				}
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0003AF59 File Offset: 0x00039159
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x0003AF6B File Offset: 0x0003916B
		public global::Infragistics.Windows.DataPresenter.DropIndicatorClipBehavior? DropIndicatorClipBehavior
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.DropIndicatorClipBehavior?)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DropIndicatorClipBehaviorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DropIndicatorClipBehaviorProperty, value);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x0003AF80 File Offset: 0x00039180
		internal global::Infragistics.Windows.DataPresenter.DropIndicatorClipBehavior DropIndicatorClipBehaviorResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DropIndicatorClipBehavior? dropIndicatorClipBehavior = this.DropIndicatorClipBehavior;
				if (dropIndicatorClipBehavior == null)
				{
					return global::Infragistics.Windows.DataPresenter.DropIndicatorClipBehavior.NoClip;
				}
				return dropIndicatorClipBehavior.GetValueOrDefault();
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x0003AFA8 File Offset: 0x000391A8
		private static void OnExportStatusChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = d as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			global::Infragistics.Windows.DataPresenter.RecordExportStatus recordExportStatus = (global::Infragistics.Windows.DataPresenter.RecordExportStatus)dataPresenterBase.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExportStatusProperty);
			dataPresenterBase._cachedExportStatus = recordExportStatus;
			dataPresenterBase.IsExporting = (recordExportStatus != global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting);
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0003AFE1 File Offset: 0x000391E1
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x0003AFE9 File Offset: 0x000391E9
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.RecordExportStatus ExportStatus
		{
			get
			{
				return this._cachedExportStatus;
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExportStatusPropertyKey, value);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0003AFFC File Offset: 0x000391FC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Windows.DataPresenter.FieldLayoutCollection FieldLayouts
		{
			get
			{
				if (this._fieldLayouts == null)
				{
					this._fieldLayouts = new global::Infragistics.Windows.DataPresenter.FieldLayoutCollection(this);
				}
				return this._fieldLayouts;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x0003B018 File Offset: 0x00039218
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutCollection FieldLayoutsIfAllocated
		{
			get
			{
				return this._fieldLayouts;
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x0003B020 File Offset: 0x00039220
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldLayouts()
		{
			return this._fieldLayouts != null && this._fieldLayouts.ShouldSerialize();
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x0003B037 File Offset: 0x00039237
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFieldLayouts()
		{
			if (this.ShouldSerializeFieldLayouts())
			{
				this._fieldLayouts.Clear();
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x0003B04C File Offset: 0x0003924C
		private static object CoerceFieldLayoutSettings(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(dataPresenterBase))
			{
				return dataPresenterBase.FieldLayoutSettings;
			}
			return value;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x0003B074 File Offset: 0x00039274
		private void OnFieldLayoutSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this._fieldLayouts != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._fieldLayouts)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout.ProcessFieldLayoutSettingsPropertyChanged(e, this._x_FieldLayoutSettings, this, false, fieldLayout, this);
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout.ProcessFieldLayoutSettingsPropertyChanged(e, this._x_FieldLayoutSettings, this, true, null, this);
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000E09 RID: 3593 RVA: 0x0003B0E4 File Offset: 0x000392E4
		// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0003B10D File Offset: 0x0003930D
		public global::Infragistics.Windows.DataPresenter.FieldLayoutSettings FieldLayoutSettings
		{
			get
			{
				if (this._x_FieldLayoutSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._x_FieldLayoutSettings = new global::Infragistics.Windows.DataPresenter.FieldLayoutSettings();
					this.OnNewFieldLayoutSettings();
				}
				return this._x_FieldLayoutSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsProperty, value);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0003B11B File Offset: 0x0003931B
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutSettings FieldLayoutSettingsIfAllocated
		{
			get
			{
				return this._x_FieldLayoutSettings;
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x0003B123 File Offset: 0x00039323
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldLayoutSettings()
		{
			return this._x_FieldLayoutSettings != null && this._x_FieldLayoutSettings.ShouldSerialize();
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x0003B13A File Offset: 0x0003933A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFieldLayoutSettings()
		{
			if (this.ShouldSerializeFieldLayoutSettings())
			{
				if (global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsProperty);
					return;
				}
				this.FieldLayoutSettings = new global::Infragistics.Windows.DataPresenter.FieldLayoutSettings();
			}
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x0003B164 File Offset: 0x00039364
		private static object CoerceFieldSettings(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(dataPresenterBase))
			{
				return dataPresenterBase.FieldSettings;
			}
			return value;
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x0003B18C File Offset: 0x0003938C
		private void OnFieldSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this._fieldLayouts != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._fieldLayouts)
				{
					global::Infragistics.Windows.DataPresenter.FieldCollection fieldsIfAllocated = fieldLayout.FieldsIfAllocated;
					if (fieldsIfAllocated != null)
					{
						foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldsIfAllocated)
						{
							global::Infragistics.Windows.DataPresenter.Field.ProcessFieldSettingsPropertyChanged(e, this._x_FieldSettings, this, false, false, field, fieldLayout, this);
						}
					}
					global::Infragistics.Windows.DataPresenter.Field.ProcessFieldSettingsPropertyChanged(e, this._x_FieldSettings, this, false, true, null, fieldLayout, this);
				}
			}
			global::Infragistics.Windows.DataPresenter.Field.ProcessFieldSettingsPropertyChanged(e, this._x_FieldSettings, this, true, false, null, null, this);
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0003B254 File Offset: 0x00039454
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x0003B27D File Offset: 0x0003947D
		public global::Infragistics.Windows.DataPresenter.FieldSettings FieldSettings
		{
			get
			{
				if (this._x_FieldSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._x_FieldSettings = new global::Infragistics.Windows.DataPresenter.FieldSettings();
					this.OnNewFieldSettings();
				}
				return this._x_FieldSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty, value);
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0003B28B File Offset: 0x0003948B
		internal global::Infragistics.Windows.DataPresenter.FieldSettings FieldSettingsIfAllocated
		{
			get
			{
				return this._x_FieldSettings;
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x0003B293 File Offset: 0x00039493
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldSettings()
		{
			return this._x_FieldSettings != null && this._x_FieldSettings.ShouldSerialize();
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x0003B2AA File Offset: 0x000394AA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFieldSettings()
		{
			if (this.ShouldSerializeFieldSettings())
			{
				if (global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty);
					return;
				}
				this.FieldSettings = new global::Infragistics.Windows.DataPresenter.FieldSettings();
			}
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x0003B2D4 File Offset: 0x000394D4
		private static void OnGroupByAreaChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				global::Infragistics.Windows.DataPresenter.GroupByArea groupByArea = e.OldValue as global::Infragistics.Windows.DataPresenter.GroupByArea;
				if (groupByArea != null)
				{
					groupByArea.InitializeDataPresenter(null);
					if (groupByArea.Parent == dataPresenterBase)
					{
						dataPresenterBase.InternalRemoveLogicalChild(groupByArea);
					}
				}
				dataPresenterBase._groupByArea = (e.NewValue as global::Infragistics.Windows.DataPresenter.GroupByArea);
				if (dataPresenterBase._groupByArea != null)
				{
					dataPresenterBase._groupByArea.InitializeDataPresenter(dataPresenterBase);
					if (dataPresenterBase.IsInitialized && dataPresenterBase._groupByArea.Parent == null)
					{
						dataPresenterBase.InternalAddLogicalChild(dataPresenterBase._groupByArea);
					}
				}
				dataPresenterBase.SetGroupByAreaStyle();
				dataPresenterBase.VerifyGroupByAreaLocation();
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x0003B368 File Offset: 0x00039568
		private void SetGroupByAreaStyle()
		{
			if (this._groupByArea == null)
			{
				return;
			}
			global::System.Windows.Style groupByAreaStyle = this.GroupByAreaStyle;
			if (groupByAreaStyle != null && groupByAreaStyle != this._groupByArea.Style)
			{
				this._groupByArea.Style = groupByAreaStyle;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0003B3A2 File Offset: 0x000395A2
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x0003B3AA File Offset: 0x000395AA
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GroupByArea GroupByArea
		{
			get
			{
				return this._groupByArea;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaProperty, value);
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x0003B3B8 File Offset: 0x000395B8
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x0003B3CA File Offset: 0x000395CA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style GroupByAreaFieldLabelStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaFieldLabelStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaFieldLabelStyleProperty, value);
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0003B3D8 File Offset: 0x000395D8
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x0003B3EA File Offset: 0x000395EA
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.StyleSelector GroupByAreaFieldLabelStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaFieldLabelStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaFieldLabelStyleSelectorProperty, value);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x0003B3F8 File Offset: 0x000395F8
		// (set) Token: 0x06000E1E RID: 3614 RVA: 0x0003B40A File Offset: 0x0003960A
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.AboveDataArea)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GroupByAreaLocation GroupByAreaLocation
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.GroupByAreaLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaLocationProperty, value);
			}
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x0003B420 File Offset: 0x00039620
		private static void OnGroupByAreaModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				dataPresenterBase.VerifyGroupByAreaLocation();
				if (dataPresenterBase.IsInitialized && dataPresenterBase.DataSource != null)
				{
					dataPresenterBase.BumpGroupByAreaStyleVersion();
				}
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0003B453 File Offset: 0x00039653
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x0003B465 File Offset: 0x00039665
		public global::Infragistics.Windows.DataPresenter.GroupByAreaMode GroupByAreaMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.GroupByAreaMode)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaModeProperty, value);
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x0003B478 File Offset: 0x00039678
		private static void OnGroupByAreaMultiChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				global::Infragistics.Windows.DataPresenter.GroupByAreaMulti groupByAreaMulti = e.OldValue as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti;
				if (groupByAreaMulti != null)
				{
					groupByAreaMulti.InitializeDataPresenter(null);
					if (groupByAreaMulti.Parent == dataPresenterBase)
					{
						dataPresenterBase.InternalRemoveLogicalChild(groupByAreaMulti);
					}
				}
				dataPresenterBase._groupByAreaMulti = (e.NewValue as global::Infragistics.Windows.DataPresenter.GroupByAreaMulti);
				if (dataPresenterBase._groupByAreaMulti != null)
				{
					dataPresenterBase._groupByAreaMulti.InitializeDataPresenter(dataPresenterBase);
					if (dataPresenterBase._groupByAreaMulti.Parent == null)
					{
						dataPresenterBase.InternalAddLogicalChild(dataPresenterBase._groupByAreaMulti);
					}
				}
				dataPresenterBase.VerifyGroupByAreaLocation();
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000E23 RID: 3619 RVA: 0x0003B4FB File Offset: 0x000396FB
		// (set) Token: 0x06000E24 RID: 3620 RVA: 0x0003B503 File Offset: 0x00039703
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.GroupByAreaMulti GroupByAreaMulti
		{
			get
			{
				return this._groupByAreaMulti;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaMultiProperty, value);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000E25 RID: 3621 RVA: 0x0003B511 File Offset: 0x00039711
		// (set) Token: 0x06000E26 RID: 3622 RVA: 0x0003B523 File Offset: 0x00039723
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Style GroupByAreaStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaStyleProperty, value);
			}
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x0003B534 File Offset: 0x00039734
		private static void OnIsExportingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = d as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			dataPresenterBase._isExporting = (bool)e.NewValue;
			if (dataPresenterBase._treeFilterManager != null)
			{
				dataPresenterBase._treeFilterManager.VerifyTimer();
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x0003B572 File Offset: 0x00039772
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x0003B57A File Offset: 0x0003977A
		[global::System.ComponentModel.Browsable(false)]
		public bool IsExporting
		{
			get
			{
				return this._isExporting;
			}
			internal set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsExportingPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0003B58D File Offset: 0x0003978D
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x0003B59F File Offset: 0x0003979F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsGroupByAreaExpanded
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsGroupByAreaExpandedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsGroupByAreaExpandedProperty, value);
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x0003B5B4 File Offset: 0x000397B4
		private static void OnIsNestedDataDisplayEnabledChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			bool cachedIsNestedDataDisplayEnabled = (bool)e.NewValue;
			dataPresenterBase._cachedIsNestedDataDisplayEnabled = cachedIsNestedDataDisplayEnabled;
			if (dataPresenterBase != null && dataPresenterBase._recordManager != null)
			{
				dataPresenterBase._recordManager.OnIsNestedDataDisplayEnabledChanged();
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x0003B5F2 File Offset: 0x000397F2
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x0003B5FA File Offset: 0x000397FA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsNestedDataDisplayEnabled
		{
			get
			{
				return this._cachedIsNestedDataDisplayEnabled;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsNestedDataDisplayEnabledProperty, value);
			}
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x0003B610 File Offset: 0x00039810
		private static void OnIsSynchronizedWithCurrentItemChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null && (bool)e.NewValue)
			{
				dataPresenterBase.RecordManager.OnIsSynchronizedWithCurrentItemSet();
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x0003B640 File Offset: 0x00039840
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x0003B652 File Offset: 0x00039852
		public bool IsSynchronizedWithCurrentItem
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsSynchronizedWithCurrentItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsSynchronizedWithCurrentItemProperty, value);
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x0003B668 File Offset: 0x00039868
		private static void OnIsTouchSupportEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d;
			dataPresenterBase._scrollHelper.IsEnabled = (bool)e.NewValue;
			dataPresenterBase.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, global::Infragistics.KnownBoxes.FromValue((bool)e.NewValue));
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x0003B6AF File Offset: 0x000398AF
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x0003B6C1 File Offset: 0x000398C1
		public bool IsTouchSupportEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsTouchSupportEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsTouchSupportEnabledProperty, value);
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0003B6D4 File Offset: 0x000398D4
		private static void OnIsUndoEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d;
			dataPresenterBase._cachedIsUndoEnabled = (bool)e.NewValue;
			if (false.Equals(e.NewValue) && dataPresenterBase._history != null)
			{
				dataPresenterBase._history.Clear();
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x0003B71F File Offset: 0x0003991F
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x0003B727 File Offset: 0x00039927
		[global::System.ComponentModel.Bindable(true)]
		public bool IsUndoEnabled
		{
			get
			{
				return this._cachedIsUndoEnabled;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsUndoEnabledProperty, value);
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0003B73A File Offset: 0x0003993A
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x0003B741 File Offset: 0x00039941
		public static bool ProcessCellInvalidationsSynchronously { get; set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0003B749 File Offset: 0x00039949
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x0003B75B File Offset: 0x0003995B
		public global::Infragistics.Windows.Controls.ItemContainerGenerationMode RecordContainerGenerationMode
		{
			get
			{
				return (global::Infragistics.Windows.Controls.ItemContainerGenerationMode)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerGenerationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerGenerationModeProperty, value);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x0003B76E File Offset: 0x0003996E
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x0003B780 File Offset: 0x00039980
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.DataPresenter.RecordLoadMode.LoadOnDemand)]
		public global::Infragistics.Windows.DataPresenter.RecordLoadMode RecordLoadMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordLoadMode)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordLoadModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordLoadModeProperty, value);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0003B794 File Offset: 0x00039994
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				if (this._recordManager == null)
				{
					this._recordManager = new global::Infragistics.Windows.DataPresenter.RecordManager(this, null, null);
					this._recordManager.PropertyChanged += this.OnRecordManagerPropertyChanged;
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsPropertyKey, this._recordManager.Current);
				}
				return this._recordManager;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x0003B7EA File Offset: 0x000399EA
		internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManagerIfAllocated
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0003B7F4 File Offset: 0x000399F4
		private void OnRecordManagerPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "Current"))
				{
					return;
				}
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsPropertyKey, this._recordManager.Current);
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ViewableRecordsPropertyKey, this._recordManager.ViewableRecords);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0003B845 File Offset: 0x00039A45
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.RecordCollectionBase Records
		{
			get
			{
				if (!this._isRecordManagerDataSourceInitialized)
				{
					this.VerifyRecordManagerDataSource();
				}
				return (global::Infragistics.Windows.DataPresenter.RecordCollectionBase)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsProperty);
			}
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0003B868 File Offset: 0x00039A68
		private static bool ValidateRecordSelectorExtent(object value)
		{
			double num = (double)value;
			return double.IsNaN(num) || (num >= 0.0 && !double.IsInfinity(num));
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x0003B8A0 File Offset: 0x00039AA0
		private static void OnRecordSelectorExtentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			dataPresenterBase._cachedRecordSelectorExtent = (double)e.NewValue;
			dataPresenterBase.InvalidateGeneratedStylesAsync(true);
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0003B8CD File Offset: 0x00039ACD
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x0003B8D5 File Offset: 0x00039AD5
		public double RecordSelectorExtent
		{
			get
			{
				return this._cachedRecordSelectorExtent;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectorExtentProperty, value);
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003B8E8 File Offset: 0x00039AE8
		private static void OnRecordSelectorErrorIconExtentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			dataPresenterBase._cachedRecordSelectorErrorIconExtent = (double)e.NewValue;
			dataPresenterBase.InvalidateGeneratedStylesAsync(true);
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0003B915 File Offset: 0x00039B15
		// (set) Token: 0x06000E48 RID: 3656 RVA: 0x0003B91D File Offset: 0x00039B1D
		public double RecordSelectorErrorIconExtent
		{
			get
			{
				return this._cachedRecordSelectorErrorIconExtent;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectorErrorIconExtentProperty, value);
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x0003B930 File Offset: 0x00039B30
		private static void OnRecordSelectorFixButtonExtentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			dataPresenterBase._cachedRecordSelectorFixButtonExtent = (double)e.NewValue;
			dataPresenterBase.InvalidateGeneratedStylesAsync(true);
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0003B95D File Offset: 0x00039B5D
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x0003B965 File Offset: 0x00039B65
		public double RecordSelectorFixButtonExtent
		{
			get
			{
				return this._cachedRecordSelectorFixButtonExtent;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectorFixButtonExtentProperty, value);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0003B978 File Offset: 0x00039B78
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x0003B98A File Offset: 0x00039B8A
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
		public global::Infragistics.Windows.DataPresenter.ReportViewBase ReportView
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.ReportViewBase)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ReportViewProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ReportViewProperty, value);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0003B998 File Offset: 0x00039B98
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x0003B9AA File Offset: 0x00039BAA
		public global::Infragistics.Windows.DataPresenter.RecordContainerRetentionMode RecordContainerRetentionMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordContainerRetentionMode)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerRetentionModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordContainerRetentionModeProperty, value);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0003B9BD File Offset: 0x00039BBD
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x0003B9CF File Offset: 0x00039BCF
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.Description("Determines the scroll position behavior when records are added or removed before the current records in view.")]
		public global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange ScrollBehaviorOnListChange
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollBehaviorOnListChangeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollBehaviorOnListChangeProperty, value);
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0003B9E2 File Offset: 0x00039BE2
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::System.Windows.Controls.Primitives.IScrollInfo ScrollInfo
		{
			get
			{
				if (this._rootRecordListControl != null)
				{
					return this._rootRecordListControl.ScrollInfo;
				}
				return null;
			}
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x0003B9F9 File Offset: 0x00039BF9
		private static bool OnValidateScrollingMode(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.ScrollingMode), value))
			{
				throw new global::System.ArgumentException();
			}
			return true;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0003BA14 File Offset: 0x00039C14
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x0003BA26 File Offset: 0x00039C26
		public global::Infragistics.Windows.DataPresenter.ScrollingMode ScrollingMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.ScrollingMode)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollingModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollingModeProperty, value);
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0003BA39 File Offset: 0x00039C39
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeScrollingMode()
		{
			return base.ReadLocalValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollingModeProperty) != global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0003BA50 File Offset: 0x00039C50
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetScrollingMode()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollingModeProperty);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0003BA60 File Offset: 0x00039C60
		private static void OnSelectedDataItemChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null && !dataPresenterBase._isSettingSelectedDataItems)
			{
				dataPresenterBase.SetSelectedDataItemsExternal((e.NewValue != null) ? new object[]
				{
					e.NewValue
				} : null);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0003BAA3 File Offset: 0x00039CA3
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x0003BAB0 File Offset: 0x00039CB0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedDataItem
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemProperty, value);
			}
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0003BAC0 File Offset: 0x00039CC0
		private static void OnSelectedDataItemsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null && !dataPresenterBase._isSettingSelectedDataItems)
			{
				dataPresenterBase.SetSelectedDataItemsExternal(e.NewValue as object[]);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0003BAF1 File Offset: 0x00039CF1
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x0003BB03 File Offset: 0x00039D03
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object[] SelectedDataItems
		{
			get
			{
				return (object[])base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemsProperty, value);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0003BB11 File Offset: 0x00039D11
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x0003BB23 File Offset: 0x00039D23
		public global::Infragistics.Windows.DataPresenter.SelectedDataItemsScope SelectedDataItemsScope
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SelectedDataItemsScope)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemsScopeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemsScopeProperty, value);
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0003BB36 File Offset: 0x00039D36
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder SelectedItems
		{
			get
			{
				if (this._selectedItems == null)
				{
					this._selectedItems = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
				}
				return this._selectedItems;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0003BB52 File Offset: 0x00039D52
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x0003BB5A File Offset: 0x00039D5A
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal global::Infragistics.Windows.Selection.ISelectionStrategyFilter SelectionStrategyFilter
		{
			get
			{
				return this._selectionStrategyFilter;
			}
			set
			{
				this._selectionStrategyFilter = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0003BB63 File Offset: 0x00039D63
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x0003BB75 File Offset: 0x00039D75
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Bindable(true)]
		public bool SortRecordsByDataType
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortRecordsByDataTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortRecordsByDataTypeProperty, value);
			}
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0003BB88 File Offset: 0x00039D88
		private static void OnSummaryCellContainerGenerationModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d;
			dataPresenterBase.InvalidateGeneratedStyles(true, false);
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x0003BBA4 File Offset: 0x00039DA4
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x0003BBB6 File Offset: 0x00039DB6
		public global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode SummaryCellContainerGenerationMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummaryCellContainerGenerationModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummaryCellContainerGenerationModeProperty, value);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x0003BBC9 File Offset: 0x00039DC9
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RoutedEventWrapper> SuppressedEvents
		{
			get
			{
				if (this._suppressedEvents == null)
				{
					this._suppressedEvents = new global::Infragistics.Windows.DataPresenter.SuppressedEventsCollection(this);
				}
				return this._suppressedEvents.Collection;
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x0003BBEC File Offset: 0x00039DEC
		private static void OnThemeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			string text = (string)e.NewValue;
			if (text != null && text.Length > 0)
			{
				dataPresenterBase._themeRegistered_DP_ResourceSet = global::Infragistics.Windows.Themes.ThemeManager.GetResourceSet(text, global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>.Location.Grouping);
			}
			else
			{
				dataPresenterBase._themeRegistered_DP_ResourceSet = null;
			}
			dataPresenterBase.ClearPendingActiveRecordPresenter();
			dataPresenterBase.ClearStyleCache();
			dataPresenterBase.FieldLayouts.BumpLayoutVersions();
			dataPresenterBase.InvalidateMeasure();
			if (dataPresenterBase.IsInitialized)
			{
				dataPresenterBase.UpdateLayout();
			}
			if (dataPresenterBase.CurrentPanel != null)
			{
				dataPresenterBase.CurrentPanel.InvalidateMeasure();
			}
			dataPresenterBase.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0003BC94 File Offset: 0x00039E94
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x0003BCA6 File Offset: 0x00039EA6
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.DataPresenterThemeTypeConverter))]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
		public string Theme
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ThemeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ThemeProperty, value);
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0003BCB4 File Offset: 0x00039EB4
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			this.RaiseEventHelper(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x06000E6D RID: 3693 RVA: 0x0003BCE2 File Offset: 0x00039EE2
		// (remove) Token: 0x06000E6E RID: 3694 RVA: 0x0003BCF0 File Offset: 0x00039EF0
		public event global::System.Windows.RoutedPropertyChangedEventHandler<string> ThemeChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ThemeChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ThemeChangedEvent, value);
			}
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0003BD00 File Offset: 0x00039F00
		private static void OnUndoLimitChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d;
			if (dataPresenterBase._history != null)
			{
				dataPresenterBase._history.UndoLimit = (int)e.NewValue;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x0003BD33 File Offset: 0x00039F33
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x0003BD45 File Offset: 0x00039F45
		[global::System.ComponentModel.Bindable(true)]
		public int UndoLimit
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.UndoLimitProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.UndoLimitProperty, value);
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x0003BD58 File Offset: 0x00039F58
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x0003BD6A File Offset: 0x00039F6A
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.DataPresenter.UpdateMode.OnRecordChangeOrLostFocus)]
		public global::Infragistics.Windows.DataPresenter.UpdateMode UpdateMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.UpdateMode)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.UpdateModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.UpdateModeProperty, value);
			}
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x0003BD80 File Offset: 0x00039F80
		private static void OnViewableRecordsChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = e.OldValue as global::Infragistics.Windows.DataPresenter.ViewableRecordCollection;
				if (viewableRecordCollection != null)
				{
					viewableRecordCollection.PropertyChanged -= dataPresenterBase.OnViewableRecordsPropertyChanged;
				}
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection2 = e.NewValue as global::Infragistics.Windows.DataPresenter.ViewableRecordCollection;
				if (viewableRecordCollection2 != null)
				{
					viewableRecordCollection2.PropertyChanged += dataPresenterBase.OnViewableRecordsPropertyChanged;
					dataPresenterBase._cachedOverallScrollCountDirty = true;
					return;
				}
				dataPresenterBase._cachedOverallScrollCountDirty = true;
				dataPresenterBase._overallScrollPosition = 0;
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x0003BDF4 File Offset: 0x00039FF4
		private void OnViewableRecordsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "ScrollCount")
			{
				this._cachedOverallScrollCountDirty = true;
				if (this.IsSynchronousControl)
				{
					this.BumpScrollableRecordCountVersion();
					return;
				}
				if (this._bumpScrollCountOperation == null)
				{
					this._bumpScrollCountOperation = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.BumpScrollableRecordCountVersion));
				}
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0003BE50 File Offset: 0x0003A050
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecords
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = (global::Infragistics.Windows.DataPresenter.ViewableRecordCollection)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ViewableRecordsProperty);
				if (viewableRecordCollection == null)
				{
					viewableRecordCollection = this.RecordManager.ViewableRecords;
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ViewableRecordsPropertyKey, viewableRecordCollection);
				}
				if (!this._isRecordManagerDataSourceInitialized)
				{
					this.VerifyRecordManagerDataSource();
				}
				return viewableRecordCollection;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x0003BE98 File Offset: 0x0003A098
		internal int AllRecordsAutoSizeMaxDepth
		{
			get
			{
				if (this._allRecordsAutoSizeMaxDepth < -1)
				{
					this._allRecordsAutoSizeMaxDepth = -1;
					foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this._fieldLayouts)
					{
						if (fieldLayout.AutoSizeInfo.HasAllRecordFields)
						{
							this._allRecordsAutoSizeMaxDepth = global::System.Math.Max(this._allRecordsAutoSizeMaxDepth, fieldLayout.MaxRecordManagerDepth);
						}
					}
				}
				return this._allRecordsAutoSizeMaxDepth;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x0003BF18 File Offset: 0x0003A118
		internal global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo ClipboardOperationInfo
		{
			get
			{
				if (this._clipboardOperationInfo == null)
				{
					this._clipboardOperationInfo = new global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo(this);
				}
				return this._clipboardOperationInfo;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x0003BF34 File Offset: 0x0003A134
		internal int CommandsBeingExecuted
		{
			get
			{
				return this._commandsBeingExecuted;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x0003BF3C File Offset: 0x0003A13C
		internal global::Infragistics.Windows.Commands.CommandsBase CommandsInternal
		{
			get
			{
				return this.Commands;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x0003BF44 File Offset: 0x0003A144
		internal global::Infragistics.Windows.DataPresenter.RecordListControl CurrentRecordListControl
		{
			get
			{
				if (this._currentRecordListControl == null)
				{
					this.InitializeRecordManagerDataSource();
				}
				else
				{
					global::System.Windows.Controls.Grid grid = this._currentRecordListControl.Parent as global::System.Windows.Controls.Grid;
					if (grid != null && grid != this._dataAreaGrid)
					{
						grid.Children.Remove(this._currentRecordListControl);
					}
				}
				return this._currentRecordListControl;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0003BF95 File Offset: 0x0003A195
		internal global::System.Windows.Controls.Panel CurrentPanel
		{
			get
			{
				if (this._currentRecordListControl != null)
				{
					return this.VerifyCurrentPanel();
				}
				return null;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0003BFA7 File Offset: 0x0003A1A7
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x0003BFB0 File Offset: 0x0003A1B0
		internal global::Infragistics.Windows.DataPresenter.ViewBase CurrentViewInternal
		{
			get
			{
				return this._currentViewInternal;
			}
			set
			{
				if (value != this._currentViewInternal)
				{
					bool flag = this._currentViewInternal != null;
					if (this._currentViewInternal != null)
					{
						this._currentViewInternal.ViewStateChanged -= this.OnCurrentViewStateChanged;
					}
					this._currentViewInternal = value;
					if (value != null)
					{
						this._currentViewInternal.ViewStateChanged += this.OnCurrentViewStateChanged;
					}
					if (flag)
					{
						this.EditHelper.EndEditMode(false, true);
						this._itemsPanel = null;
						this.UpdateScrollBarVisibility();
						this.ClearItemsHost();
						this.InvalidateFormatSettings();
						this.ResetItemsPanel();
						this.InitializeItemsPanel();
						if (this.DefaultFieldLayout != null)
						{
							this.DefaultFieldLayout.SetFieldLayoutInfo(null, false, false);
						}
					}
					global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayoutsIfAllocated = this.FieldLayoutsIfAllocated;
					if (fieldLayoutsIfAllocated != null)
					{
						foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in fieldLayoutsIfAllocated)
						{
							fieldLayout.OnCurrentViewChanged(false);
						}
					}
					this.VerifyGroupByAreaLocation();
					if (this._treeFilterManager != null && !this.IsTreeView)
					{
						this._treeFilterManager.Stop();
						this._treeFilterManager = null;
						this.RecordManager.ClearCachedRecordsAndReset();
					}
					this.InitializeSpacingOnResizeController();
				}
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0003C0E0 File Offset: 0x0003A2E0
		internal global::Infragistics.Windows.DataPresenter.CustomizationsManager CustomizationsManager
		{
			get
			{
				if (this._customizationsManager == null)
				{
					this._customizationsManager = new global::Infragistics.Windows.DataPresenter.CustomizationsManager(this);
				}
				return this._customizationsManager;
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x0003C0FC File Offset: 0x0003A2FC
		private static void OnDataPresenterChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0003C0FE File Offset: 0x0003A2FE
		internal static global::Infragistics.Windows.DataPresenter.DataPresenterBase GetDataPresenter(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0003C110 File Offset: 0x0003A310
		internal static void SetDataPresenter(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DataPresenter.DataPresenterBase value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty, value);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0003C120 File Offset: 0x0003A320
		private static object CoerceDataSourceInternal(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase == null)
			{
				return value;
			}
			global::System.ComponentModel.IListSource listSource = value as global::System.ComponentModel.IListSource;
			if (listSource != null)
			{
				value = listSource.GetList();
			}
			global::System.Collections.IEnumerable enumerable = value as global::System.Collections.IEnumerable;
			if (enumerable == null)
			{
				dataPresenterBase.UnwireDataSourceRootList();
				return null;
			}
			global::System.Collections.IList list = enumerable as global::System.Collections.IList;
			if (list != null && list.Count == 1)
			{
				dataPresenterBase.WireDataSourceRootList(list);
				object obj = list[0];
				if (obj != null)
				{
					if (obj is global::System.Collections.IEnumerable)
					{
						if (obj is string || obj is global::System.Xml.XmlNode)
						{
							return enumerable;
						}
						return obj;
					}
					else
					{
						global::System.ComponentModel.ITypedList typedList = list as global::System.ComponentModel.ITypedList;
						if (typedList != null)
						{
							global::System.ComponentModel.PropertyDescriptorCollection itemProperties = typedList.GetItemProperties(null);
							if (itemProperties != null)
							{
								int count = itemProperties.Count;
								if (count == 0)
								{
									return typedList;
								}
								bool flag = true;
								for (int i = 0; i < count; i++)
								{
									global::System.Type propertyType = itemProperties[i].PropertyType;
									if (!(propertyType != typeof(string)) || !(propertyType != typeof(global::System.Xml.XmlNode)) || !typeof(global::System.Collections.IEnumerable).IsAssignableFrom(propertyType))
									{
										flag = false;
										break;
									}
								}
								if (flag)
								{
									if (count == 1)
									{
										return itemProperties[0].GetValue(obj);
									}
									global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.EnumerableObjectWrapper> list2 = null;
									int num = 0;
									if (dataPresenterBase._dataSourceRootChildListWrappers == null)
									{
										dataPresenterBase._dataSourceRootChildListWrappers = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Helpers.EnumerableObjectWrapper>();
									}
									else if (dataPresenterBase._dataSourceRootChildListWrappers.Count > 0)
									{
										list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.EnumerableObjectWrapper>(dataPresenterBase._dataSourceRootChildListWrappers);
										num = list2.Count;
									}
									int j = 0;
									while (j < count)
									{
										global::System.ComponentModel.PropertyDescriptor propertyDescriptor = itemProperties[j];
										global::System.Collections.IEnumerable enumerable2 = propertyDescriptor.GetValue(obj) as global::System.Collections.IEnumerable;
										if (list2 == null || list2.Count <= 0)
										{
											goto IL_200;
										}
										bool flag2 = false;
										global::System.Data.DataView view = enumerable2 as global::System.Data.DataView;
										for (int k = 0; k < list2.Count; k++)
										{
											global::System.Collections.IEnumerable items = list2[k].Items;
											global::System.Data.DataView dataView = items as global::System.Data.DataView;
											if (enumerable2 == items || (dataView != null && dataView.Equals(view)))
											{
												flag2 = true;
												list2.RemoveAt(k);
												break;
											}
										}
										if (!flag2)
										{
											goto IL_200;
										}
										IL_21D:
										j++;
										continue;
										IL_200:
										if (enumerable2 != null)
										{
											dataPresenterBase._dataSourceRootChildListWrappers.Add(new global::Infragistics.Windows.Helpers.EnumerableObjectWrapper(enumerable2, propertyDescriptor.Name));
											goto IL_21D;
										}
										goto IL_21D;
									}
									if (list2 != null && list2.Count > 0)
									{
										for (int l = 0; l < list2.Count; l++)
										{
											global::Infragistics.Windows.Helpers.EnumerableObjectWrapper enumerableObjectWrapper = list2[l];
											for (int m = 0; m < num; m++)
											{
												if (enumerableObjectWrapper == dataPresenterBase._dataSourceRootChildListWrappers[m])
												{
													dataPresenterBase._dataSourceRootChildListWrappers.RemoveAt(m);
													break;
												}
											}
										}
									}
									if (count == dataPresenterBase._dataSourceRootChildListWrappers.Count)
									{
										for (int n = 0; n < count; n++)
										{
											global::System.ComponentModel.PropertyDescriptor propertyDescriptor2 = itemProperties[n];
											global::System.Collections.IEnumerable enumerable3 = propertyDescriptor2.GetValue(obj) as global::System.Collections.IEnumerable;
											global::System.Data.DataView dataView2 = enumerable3 as global::System.Data.DataView;
											global::System.Collections.IEnumerable items2 = dataPresenterBase._dataSourceRootChildListWrappers[n].Items;
											global::System.Data.DataView view2 = items2 as global::System.Data.DataView;
											if (enumerable3 != items2 && (dataView2 == null || !dataView2.Equals(view2)))
											{
												for (int num2 = n + 1; num2 < count; num2++)
												{
													global::Infragistics.Windows.Helpers.EnumerableObjectWrapper enumerableObjectWrapper2 = dataPresenterBase._dataSourceRootChildListWrappers[num2];
													items2 = enumerableObjectWrapper2.Items;
													view2 = (items2 as global::System.Data.DataView);
													if (enumerable3 == items2 || (dataView2 != null && dataView2.Equals(view2)))
													{
														dataPresenterBase._dataSourceRootChildListWrappers.RemoveAt(num2);
														dataPresenterBase._dataSourceRootChildListWrappers.Insert(n, enumerableObjectWrapper2);
														break;
													}
												}
											}
										}
									}
									return dataPresenterBase._dataSourceRootChildListWrappers;
								}
							}
						}
					}
				}
			}
			return enumerable;
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x0003C4A8 File Offset: 0x0003A6A8
		internal object DataSourceInternal
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalProperty);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x0003C4B5 File Offset: 0x0003A6B5
		internal global::System.Globalization.CultureInfo DefaultConverterCulture
		{
			get
			{
				if (this._defaultConverterCulture == null)
				{
					this._defaultConverterCulture = global::Infragistics.Windows.Utilities.GetNonNeutralCulture(this);
				}
				return this._defaultConverterCulture;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x0003C4D1 File Offset: 0x0003A6D1
		internal global::Infragistics.Windows.DataPresenter.EditModeHelper EditHelper
		{
			get
			{
				if (this._editHelper == null)
				{
					this._editHelper = new global::Infragistics.Windows.DataPresenter.EditModeHelper(this);
				}
				return this._editHelper;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0003C4ED File Offset: 0x0003A6ED
		internal global::Infragistics.Windows.DataPresenter.ExportHelper ExportHelper
		{
			get
			{
				if (this._exportHelper == null)
				{
					this._exportHelper = new global::Infragistics.Windows.DataPresenter.ExportHelper(this);
				}
				return this._exportHelper;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0003C509 File Offset: 0x0003A709
		internal bool HasAutoSizeAllRecordFields
		{
			get
			{
				return this._fieldLayoutAutoSizeAllRecordsCount > 0;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x0003C514 File Offset: 0x0003A714
		// (set) Token: 0x06000E8A RID: 3722 RVA: 0x0003C51C File Offset: 0x0003A71C
		internal int FieldLayoutAutoSizeRecordsInViewCount
		{
			get
			{
				return this._fieldLayoutAutoSizeRecordsInViewCount;
			}
			set
			{
				this._fieldLayoutAutoSizeRecordsInViewCount = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x0003C525 File Offset: 0x0003A725
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x0003C52D File Offset: 0x0003A72D
		internal int FieldLayoutAutoSizeViewableCount
		{
			get
			{
				return this._fieldLayoutAutoSizeViewableCount;
			}
			set
			{
				this._fieldLayoutAutoSizeViewableCount = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0003C536 File Offset: 0x0003A736
		internal bool HasFieldLayoutSettings
		{
			get
			{
				return this._x_FieldLayoutSettings != null;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0003C544 File Offset: 0x0003A744
		internal bool HasFieldLayouts
		{
			get
			{
				return this._fieldLayouts != null;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x0003C552 File Offset: 0x0003A752
		internal bool HasFieldSettings
		{
			get
			{
				return this._x_FieldSettings != null;
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0003C560 File Offset: 0x0003A760
		private void BumpGridMeasureVersion()
		{
			int num = (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GridMeasureVersionProperty);
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GridMeasureVersionProperty, num + 1);
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0003C591 File Offset: 0x0003A791
		internal global::Infragistics.Windows.DataPresenter.DataPresenterHistory History
		{
			get
			{
				if (this._history == null)
				{
					this._history = new global::Infragistics.Windows.DataPresenter.DataPresenterHistory(this);
				}
				return this._history;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0003C5AD File Offset: 0x0003A7AD
		internal global::System.Windows.Controls.StyleSelector InternalCellPresenterStyleSelector
		{
			get
			{
				if (this._internalCellPresenterStyleSelector == null)
				{
					this._internalCellPresenterStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPCellPresenterStyleSelector(this);
				}
				return this._internalCellPresenterStyleSelector;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0003C5C9 File Offset: 0x0003A7C9
		internal global::System.Windows.Controls.StyleSelector InternalCellValuePresenterStyleSelector
		{
			get
			{
				if (this._internalCellValuePresenterStyleSelector == null)
				{
					this._internalCellValuePresenterStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPCellValuePresenterStyleSelector(this);
				}
				return this._internalCellValuePresenterStyleSelector;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0003C5E5 File Offset: 0x0003A7E5
		internal global::System.Windows.Controls.StyleSelector InternalEditorStyleSelector
		{
			get
			{
				if (this._internalEditorStyleSelector == null)
				{
					this._internalEditorStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPEditorStyleSelector(this);
				}
				return this._internalEditorStyleSelector;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0003C601 File Offset: 0x0003A801
		internal global::System.Windows.Controls.StyleSelector InternalExpandedCellStyleSelector
		{
			get
			{
				if (this._internalExpandedCellStyleSelector == null)
				{
					this._internalExpandedCellStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPExpandedCellStyleSelector(this);
				}
				return this._internalExpandedCellStyleSelector;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0003C61D File Offset: 0x0003A81D
		internal global::System.Windows.Controls.StyleSelector InternalHeaderPresenterStyleSelector
		{
			get
			{
				if (this._internalHeaderPresenterStyleSelector == null)
				{
					this._internalHeaderPresenterStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPHeaderPresenterStyleSelector(this);
				}
				return this._internalHeaderPresenterStyleSelector;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0003C639 File Offset: 0x0003A839
		internal global::System.Windows.Controls.StyleSelector InternalHeaderLabelAreaStyleSelector
		{
			get
			{
				if (this._internalHeaderLabelAreaStyleSelector == null)
				{
					this._internalHeaderLabelAreaStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPHeaderLabelAreaStyleSelector(this);
				}
				return this._internalHeaderLabelAreaStyleSelector;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0003C655 File Offset: 0x0003A855
		internal global::System.Windows.Controls.StyleSelector InternalHeaderPrefixAreaStyleSelector
		{
			get
			{
				if (this._internalHeaderPrefixAreaStyleSelector == null)
				{
					this._internalHeaderPrefixAreaStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPHeaderPrefixAreaStyleSelector(this);
				}
				return this._internalHeaderPrefixAreaStyleSelector;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x0003C671 File Offset: 0x0003A871
		internal global::System.Windows.Controls.StyleSelector InternalLabelPresenterStyleSelector
		{
			get
			{
				if (this._internalLabelPresenterStyleSelector == null)
				{
					this._internalLabelPresenterStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPLabelPresenterStyleSelector(this);
				}
				return this._internalLabelPresenterStyleSelector;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0003C68D File Offset: 0x0003A88D
		internal global::System.Windows.Controls.StyleSelector InternalRecordCellAreaStyleSelector
		{
			get
			{
				if (this._internalRecordCellAreaStyleSelector == null)
				{
					this._internalRecordCellAreaStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordCellAreaStyleSelector(this);
				}
				return this._internalRecordCellAreaStyleSelector;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x0003C6A9 File Offset: 0x0003A8A9
		internal global::System.Windows.Controls.StyleSelector InternalRecordStyleSelector
		{
			get
			{
				if (this._internalRecordStyleSelector == null)
				{
					this._internalRecordStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector(this);
				}
				return this._internalRecordStyleSelector;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0003C6C5 File Offset: 0x0003A8C5
		internal global::System.Windows.Controls.StyleSelector InternalRecordSelectorStyleSelector
		{
			get
			{
				if (this._internalRecordSelectorStyleSelector == null)
				{
					this._internalRecordSelectorStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordSelectorStyleSelector(this);
				}
				return this._internalRecordSelectorStyleSelector;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0003C6E1 File Offset: 0x0003A8E1
		internal global::System.Windows.Controls.StyleSelector InternalRecordSelectorNumberStyleSelector
		{
			get
			{
				if (this._internalRecordSelectorNumberStyleSelector == null)
				{
					this._internalRecordSelectorNumberStyleSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordSelectorNumberStyleSelector(this);
				}
				return this._internalRecordSelectorNumberStyleSelector;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0003C6FD File Offset: 0x0003A8FD
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> InternalRecords
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InternalRecordsProperty);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0003C70F File Offset: 0x0003A90F
		internal virtual bool IsExportControl
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0003C712 File Offset: 0x0003A912
		internal bool IsProcessingFieldAutoSize
		{
			get
			{
				return this._processingFieldAutoSize;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0003C71A File Offset: 0x0003A91A
		internal bool IsReportControl
		{
			get
			{
				return this is global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0003C725 File Offset: 0x0003A925
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x0003C72D File Offset: 0x0003A92D
		internal bool IsApplyingCustomizations
		{
			get
			{
				return this._isLoadingCustomizations;
			}
			set
			{
				this._isLoadingCustomizations = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0003C736 File Offset: 0x0003A936
		internal bool IsDraggingField
		{
			get
			{
				return null != this._fieldDragManager;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0003C744 File Offset: 0x0003A944
		internal bool IsFlatView
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.SupportedDataDisplayMode == global::Infragistics.Windows.DataPresenter.DataDisplayMode.FlattenedHierarchical;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0003C766 File Offset: 0x0003A966
		internal bool IsScrolling
		{
			get
			{
				return this._isScrollingTimer != null && this._isScrollingTimer.IsEnabled;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0003C77D File Offset: 0x0003A97D
		internal virtual bool IsSynchronousControl
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0003C780 File Offset: 0x0003A980
		internal virtual bool IsTreeView
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0003C783 File Offset: 0x0003A983
		internal global::System.Windows.Controls.ItemsPanelTemplate ItemsPanel
		{
			get
			{
				return (global::System.Windows.Controls.ItemsPanelTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ItemsPanelProperty);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0003C795 File Offset: 0x0003A995
		internal global::System.Windows.Size LastMeasureSize
		{
			get
			{
				return this._lastMeasureSize;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0003C79D File Offset: 0x0003A99D
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x0003C7AF File Offset: 0x0003A9AF
		internal int OverallSortVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OverallSortVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.OverallSortVersionProperty, value);
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0003C7C2 File Offset: 0x0003A9C2
		private static global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings GetPanelSettings(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings)d.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.PanelSettingsProperty);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0003C7D4 File Offset: 0x0003A9D4
		private static void SetPanelSettings(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.PanelSettingsProperty, value);
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0003C7E2 File Offset: 0x0003A9E2
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x0003C7EA File Offset: 0x0003A9EA
		internal global::Infragistics.Windows.DataPresenter.RecordPresenter PendingActiveRecordPresenter
		{
			get
			{
				return this._pendingActiveRecordPresenter;
			}
			set
			{
				this._pendingActiveRecordPresenter = value;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0003C7F3 File Offset: 0x0003A9F3
		internal bool ProcessingPreviewLostKeyoardFocus
		{
			get
			{
				return this._processingPreviewLostKeyoardFocus;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0003C7FB File Offset: 0x0003A9FB
		internal object RecordOrCellBeingActivated
		{
			get
			{
				return this._recordOrCellBeingActivated;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0003C804 File Offset: 0x0003AA04
		internal string RecordNumberSeparator
		{
			get
			{
				if (this._recordNumberSeparator == null)
				{
					this._recordNumberSeparator = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("RecordNumberSeparator");
					if (this._recordNumberSeparator == null)
					{
						return ".";
					}
					this._recordNumberSeparatorTracker = new global::Infragistics.Windows.DataPresenter.DynamicResourceTracker(this._recordNumberSeparator, new global::Infragistics.Windows.DataPresenter.DynamicResourceTracker.RaisePropertyValueChanged(this.OnDynamicResourceChanged), "RecordNumberSeparator");
				}
				return this._recordNumberSeparator.Value;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0003C864 File Offset: 0x0003AA64
		internal int RecordNumberVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordNumberVersionProperty);
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0003C876 File Offset: 0x0003AA76
		internal int RecordsInViewVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionProperty);
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0003C888 File Offset: 0x0003AA88
		internal int RenderVersion
		{
			get
			{
				return this._renderVersion;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0003C890 File Offset: 0x0003AA90
		internal global::Infragistics.Windows.DataPresenter.RecordListControl RootRecordListControl
		{
			get
			{
				return this._rootRecordListControl;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0003C898 File Offset: 0x0003AA98
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x0003C8AA File Offset: 0x0003AAAA
		internal int ScrollableRecordCountVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollableRecordCountVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollableRecordCountVersionProperty, value);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0003C8BD File Offset: 0x0003AABD
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x0003C8C5 File Offset: 0x0003AAC5
		internal int ScrollCountRecalcVersion
		{
			get
			{
				return this._cachedScrollCountRecalcVersion;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollCountRecalcVersionProperty, value);
			}
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0003C8D8 File Offset: 0x0003AAD8
		internal void BumpScrollCountRecalcVersion()
		{
			this.ScrollCountRecalcVersion++;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0003C8E8 File Offset: 0x0003AAE8
		private static void OnScrollCountRecalcVersionChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)dependencyObject;
			dataPresenterBase._cachedScrollCountRecalcVersion = (int)e.NewValue;
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0003C90E File Offset: 0x0003AB0E
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x0003C920 File Offset: 0x0003AB20
		internal int ScrollVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollVersionProperty, value);
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0003C934 File Offset: 0x0003AB34
		internal global::Infragistics.Windows.DataPresenter.SelectionDepthMode SelectionDepthMode
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.TreeViewSettings treeViewSettings = null;
				global::Infragistics.Windows.DataPresenter.TreeView treeView = this.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TreeView;
				if (treeView != null)
				{
					treeViewSettings = treeView.ViewSettings;
				}
				if (treeViewSettings == null)
				{
					return global::Infragistics.Windows.DataPresenter.SelectionDepthMode.Single;
				}
				return treeViewSettings.SelectionDepthMode;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0003C964 File Offset: 0x0003AB64
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder SelectionSnapshot
		{
			get
			{
				if (this._selectionSnapshot == null)
				{
					this._selectionSnapshot = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
				}
				return this._selectionSnapshot;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0003C980 File Offset: 0x0003AB80
		internal bool ShouldRaiseCellsInViewChanged
		{
			get
			{
				return null != this._cellsInViewChangedEventHandler;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0003C98E File Offset: 0x0003AB8E
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x0003C996 File Offset: 0x0003AB96
		internal bool SuppressExportingDataSourceException
		{
			get
			{
				return this._suppressExportingDataSourceException;
			}
			set
			{
				this._suppressExportingDataSourceException = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0003C99F File Offset: 0x0003AB9F
		internal global::System.Type TypeBeingSelected
		{
			get
			{
				return this._typeBeingSelected;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
		private global::Infragistics.Windows.DataPresenter.DataRecord FirstOverallDataRecord
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
				int scrollCount = viewableRecords.ScrollCount;
				for (int i = 0; i < scrollCount; i++)
				{
					global::Infragistics.Windows.DataPresenter.Record recordAtScrollPosition = viewableRecords.GetRecordAtScrollPosition(i);
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtScrollPosition, global::Infragistics.Windows.DataPresenter.RecordType.DataRecord))
					{
						return recordAtScrollPosition as global::Infragistics.Windows.DataPresenter.DataRecord;
					}
				}
				return null;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0003C9E8 File Offset: 0x0003ABE8
		private global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.HorizontalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0003C9FC File Offset: 0x0003ABFC
		private global::Infragistics.Windows.DataPresenter.DataRecord LastOverallDataRecord
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
				int scrollCount = viewableRecords.ScrollCount;
				for (int i = scrollCount - 1; i >= 0; i--)
				{
					global::Infragistics.Windows.DataPresenter.Record recordAtScrollPosition = viewableRecords.GetRecordAtScrollPosition(i);
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtScrollPosition, global::Infragistics.Windows.DataPresenter.RecordType.DataRecord))
					{
						return recordAtScrollPosition as global::Infragistics.Windows.DataPresenter.DataRecord;
					}
				}
				return null;
			}
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0003CA3E File Offset: 0x0003AC3E
		private void RaiseEventHelper(global::System.Windows.RoutedEventArgs args)
		{
			if (this.IsEventSuppressed(args.RoutedEvent))
			{
				return;
			}
			base.RaiseEvent(args);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0003CA58 File Offset: 0x0003AC58
		private void SetPivotMember<T>(ref T member, T newValue) where T : global::Infragistics.Windows.Selection.ISelectableItem
		{
			if (!object.Equals(member, newValue))
			{
				T t = member;
				member = newValue;
				this._fixedScrollHelper.OnPivotItemChanged(t, newValue);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0003CAA2 File Offset: 0x0003ACA2
		private global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.VerticalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0003CAB4 File Offset: 0x0003ACB4
		public void BringCellIntoView(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (cell == null)
			{
				throw new global::System.ArgumentNullException("cell");
			}
			if (cell.Field == null || cell.Record == null || cell.Field.Owner == null)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_4"));
			}
			if (cell.DataPresenter != this)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_5"));
			}
			bool isInEditMode = cell.IsInEditMode;
			try
			{
				if (isInEditMode)
				{
					this.SuspendEndEditOnScroll();
				}
				this.BringCellIntoViewImpl(cell);
			}
			finally
			{
				if (isInEditMode)
				{
					this.ResumeEndEditOnScroll();
				}
			}
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0003CB48 File Offset: 0x0003AD48
		private void BringCellIntoViewImpl(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this.BringRecordIntoView(cell.Record);
			base.UpdateLayout();
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = cell.Record.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
			if (dataRecordPresenter != null && dataRecordPresenter.ShouldDisplayRecordContent)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = (global::Infragistics.Windows.DataPresenter.DataRecordCellArea)global::Infragistics.Windows.Utilities.GetDescendantFromType(dataRecordPresenter, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), true);
				global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = (dataRecordCellArea != null) ? (dataRecordCellArea.Content as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel) : null;
				if (virtualizingDataRecordCellPanel != null)
				{
					virtualizingDataRecordCellPanel.EnsureCellIsCreated(cell);
				}
			}
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
			if (viewPanel != null)
			{
				viewPanel.EnsureCellIsVisible(cell);
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0003CBD0 File Offset: 0x0003ADD0
		public void BringDataItemIntoView(object dataItem, bool recursive)
		{
			if (dataItem == null)
			{
				throw new global::System.ArgumentNullException("dataItem");
			}
			global::Infragistics.Windows.DataPresenter.DataRecord recordFromDataItem = this.GetRecordFromDataItem(dataItem, recursive);
			if (recordFromDataItem == null)
			{
				return;
			}
			this.BringRecordIntoView(recordFromDataItem);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0003CC00 File Offset: 0x0003AE00
		public void BringRecordIntoView(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			if (record.DataPresenter != this)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_6"));
			}
			if (this._invalidateGeneratedStylesPending)
			{
				this.OnInvalidateGeneratedStyles();
			}
			base.UpdateLayout();
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
			if (viewPanel != null)
			{
				viewPanel.EnsureRecordIsVisible(record);
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0003CC5F File Offset: 0x0003AE5F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void CancelExport(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter)
		{
			this.ExportHelper.CancelExport(exporter);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0003CC6D File Offset: 0x0003AE6D
		public void ClearCustomizations(global::Infragistics.Windows.DataPresenter.CustomizationType customizations)
		{
			this.CustomizationsManager.ClearCustomizations(customizations);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x0003CC7B File Offset: 0x0003AE7B
		public void ClearUndoHistory()
		{
			if (this._history != null)
			{
				this._history.Clear();
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x0003CC90 File Offset: 0x0003AE90
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.CommandWrapper commandWrapper)
		{
			if (commandWrapper == null)
			{
				throw new global::System.ArgumentNullException("commandWrapper");
			}
			return this.ExecuteCommand(commandWrapper.Command, null);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x0003CCAD File Offset: 0x0003AEAD
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(command, null, true);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0003CCB8 File Offset: 0x0003AEB8
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command, object parameter)
		{
			return this.ExecuteCommandImpl(command, parameter, true);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x0003CCC3 File Offset: 0x0003AEC3
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object commandParameter, bool raiseEvents)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command, commandParameter, null), raiseEvents);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x0003CCD4 File Offset: 0x0003AED4
		private bool ExecuteCommandImpl(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo, bool raiseEvents)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			object parameter = commandInfo.Parameter;
			if (routedCommand == null)
			{
				throw new global::System.ArgumentNullException("command");
			}
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.DataPresenter.DataPresenterBase>.IsMinimumStatePresentForCommand(this, routedCommand))
			{
				return false;
			}
			if (raiseEvents)
			{
				global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(routedCommand, parameter);
				if (!this.RaiseExecutingCommand(executingCommandEventArgs))
				{
					return !executingCommandEventArgs.ContinueKeyRouting;
				}
			}
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
			bool flag = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
			bool flag2 = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
			bool flag3 = global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.Tab);
			this._commandsBeingExecuted++;
			bool flag4 = false;
			if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FlipOrientation)
			{
				global::Infragistics.Windows.DataPresenter.CardView cardView = this.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.CardView;
				if (cardView != null)
				{
					cardView.ViewSettings.Orientation = ((cardView.ViewSettings.Orientation == global::System.Windows.Controls.Orientation.Horizontal) ? global::System.Windows.Controls.Orientation.Vertical : global::System.Windows.Controls.Orientation.Horizontal);
					flag4 = true;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.GridView gridView = this.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.GridView;
					if (gridView != null)
					{
						foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this.FieldLayouts)
						{
							fieldLayout.FlipFieldPositions();
						}
						gridView.ViewSettings.Orientation = ((gridView.ViewSettings.Orientation == global::System.Windows.Controls.Orientation.Horizontal) ? global::System.Windows.Controls.Orientation.Vertical : global::System.Windows.Controls.Orientation.Horizontal);
						flag4 = true;
					}
				}
			}
			if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearAllSelected)
			{
				flag4 = this.ClearAllSelected();
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.DeleteSelectedDataRecords)
			{
				flag4 = this.DeleteSelectedRecords(true);
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CollapseRecord || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ExpandRecord)
			{
				global::Infragistics.Windows.DataPresenter.Record activeRecord = this.ActiveRecord;
				if (activeRecord != null)
				{
					flag4 = activeRecord.ExpandCollapse(routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ExpandRecord, true, false);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.StartEditMode)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
				if (activeCell != null)
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = activeCell.AssociatedCellValuePresenter;
					if (associatedCellValuePresenter != null)
					{
						flag4 = associatedCellValuePresenter.StartEditMode();
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndDiscardChanges || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndCommitRecord)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell2 = this.ActiveCell;
				if (activeCell2 != null)
				{
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndAcceptChanges || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndCommitRecord)
					{
						activeCell2.EndEditMode(true);
					}
					else
					{
						activeCell2.EndEditMode(false);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndCommitRecord)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord record = activeCell2.Record;
						if (record.IsDataChanged && !activeCell2.IsInEditMode)
						{
							this.CommitChangesToRecord(record);
						}
					}
					flag4 = true;
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CommitChangesToActiveRecord)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null)
				{
					this.CommitChangesToRecord(dataRecord);
					flag4 = !dataRecord.IsDataChanged;
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CommitChangesToAllRecords)
			{
				if (this._recordManager != null)
				{
					this._recordManager.UpdateRecordsWithPendingChanges(false, true);
				}
				flag4 = true;
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.DiscardChangesToActiveRecord)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = this.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord2 != null)
				{
					this._recordWhoseChangesAreBeingDiscarded = dataRecord2;
					if (dataRecord2.IsDataChanged)
					{
						dataRecord2.CancelUpdate();
					}
					this._recordWhoseChangesAreBeingDiscarded = null;
					flag4 = !dataRecord2.IsDataChanged;
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.DiscardChangesToAllRecords)
			{
				if (this._recordManager != null)
				{
					this._recordManager.UpdateRecordsWithPendingChanges(true, true);
				}
				flag4 = true;
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordBelow || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLeft || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordRight || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordNext || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPrevious)
			{
				if (viewPanel != null)
				{
					global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection = (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordAbove) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordBelow) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLeft) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordRight) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordNext && viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewVertical) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordNext && viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewHorizontal) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPrevious && viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewVertical) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPrevious && viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewHorizontal) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordNext && viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.Custom) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPrevious && viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.Custom) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous : global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous)))))))));
					global::Infragistics.Windows.DataPresenter.Record navigationTargetRecord = viewPanel.GetNavigationTargetRecord(this.ActiveRecord, navigationDirection, this, flag, flag2, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsNoWrap, typeof(global::Infragistics.Windows.DataPresenter.Record));
					if (navigationTargetRecord != null)
					{
						global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(navigationTargetRecord);
						if (selectionStrategyForItem != null)
						{
							if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPrevious)
							{
								flag = false;
							}
							this.VerifyPivots();
							if (flag && this._pivotRecord == null && selectionStrategyForItem.IsMultiSelect)
							{
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = this.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
								if (dataRecord3 != null && !dataRecord3.IsSpecialRecord)
								{
									this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Record>(ref this._pivotRecord, dataRecord3);
									this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Cell>(ref this._pivotCell, null);
								}
							}
							selectionStrategyForItem.SelectItemViaKeyboard(navigationTargetRecord, flag, flag2, false);
							flag4 = true;
						}
						this.BringRecordIntoView(navigationTargetRecord);
						if (navigationTargetRecord != null && base.IsKeyboardFocusWithin)
						{
							navigationTargetRecord.FocusIfActive();
						}
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordBelow || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLeft || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordRight)
					{
						flag4 = true;
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstDisplayed || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastDisplayed || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastOverall)
			{
				global::System.Type recordType = flag ? typeof(global::Infragistics.Windows.DataPresenter.DataRecord) : typeof(global::Infragistics.Windows.DataPresenter.Record);
				global::Infragistics.Windows.DataPresenter.Record record2 = (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstDisplayed) ? viewPanel.GetFirstDisplayedRecord(recordType) : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastDisplayed) ? viewPanel.GetLastDisplayedRecord(recordType) : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall) ? viewPanel.GetFirstOverallRecord(recordType) : viewPanel.GetLastOverallRecord(recordType)));
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem2 = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(record2);
				if (selectionStrategyForItem2 != null)
				{
					selectionStrategyForItem2.SelectItemViaKeyboard(record2, flag, flag2, false);
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastOverall)
					{
						if (this._invalidateGeneratedStylesPending)
						{
							this.OnInvalidateGeneratedStyles();
						}
						base.UpdateLayout();
						if (record2.IsFixed)
						{
							global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = record2.ParentCollection.ViewableRecords;
							if (viewableRecords != null && viewableRecords.Count > viewableRecords.CountOfFixedRecordsOnBottom + viewableRecords.CountOfFixedRecordsOnTop)
							{
								if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall)
								{
									record2 = viewableRecords[viewableRecords.CountOfFixedRecordsOnTop];
								}
								else
								{
									record2 = viewableRecords[viewableRecords.Count - (viewableRecords.CountOfFixedRecordsOnBottom + 1)];
								}
							}
						}
						if (record2 != null)
						{
							viewPanel.EnsureRecordIsVisible(record2);
						}
					}
					flag4 = true;
				}
				if (record2 != null && base.IsKeyboardFocusWithin)
				{
					record2.FocusIfActive();
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageBelow || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageLeft || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageRight)
			{
				if (viewPanel != null)
				{
					global::Infragistics.Windows.DataPresenter.States currentState = (global::Infragistics.Windows.DataPresenter.States)((global::Infragistics.Windows.Commands.ICommandHost)this).GetCurrentState(96L);
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageBelow || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageRight)
					{
						if ((currentState & global::Infragistics.Windows.DataPresenter.States.RecordLastDisplayed) == (global::Infragistics.Windows.DataPresenter.States)0L)
						{
							flag4 = this.ExecuteCommandImpl(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastDisplayed, null, false);
							goto IL_163A;
						}
					}
					else if ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageLeft) && (currentState & global::Infragistics.Windows.DataPresenter.States.RecordFirstDisplayed) == (global::Infragistics.Windows.DataPresenter.States)0L)
					{
						flag4 = this.ExecuteCommandImpl(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstDisplayed, null, false);
						goto IL_163A;
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageAbove)
					{
						viewPanel.Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageAbove);
					}
					else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageBelow)
					{
						viewPanel.Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageBelow);
					}
					else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageLeft)
					{
						viewPanel.Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageLeft);
					}
					else
					{
						viewPanel.Scroll(global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageRight);
					}
					this.CurrentPanel.InvalidateMeasure();
					if (!flag && !flag2 && this._isInPageUpDown)
					{
						if (this._asyncCommand == null)
						{
							this._asyncCommand = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.AsyncPageCommand(this);
						}
						this._asyncCommand.Command = routedCommand;
					}
					else
					{
						if (this._asyncCommand != null)
						{
							this._asyncCommand.Detach();
							this._asyncCommand = null;
						}
						this.CurrentPanel.UpdateLayout();
						this.SelectFirstOrLastDisplayedRecord(routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageLeft, flag, flag2);
					}
					flag4 = true;
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellBelow || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLeft || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellRight || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellNext || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPrevious || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellNextByTab || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPreviousByTab)
			{
				if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellRight)
					{
						routedCommand = global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLeft;
					}
					else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLeft)
					{
						routedCommand = global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellRight;
					}
				}
				if (viewPanel != null)
				{
					global::Infragistics.Windows.DataPresenter.Cell activeCell3 = this.ActiveCell;
					bool flag5 = activeCell3 != null && activeCell3.IsInEditMode;
					global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection2 = (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellAbove) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellBelow) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLeft) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellRight) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellNext || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellNextByTab) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPrevious || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPreviousByTab) ? global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous : global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next)))));
					global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle = global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.AcrossParentsNoWrap;
					if (flag3 && routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPreviousByTab)
					{
						flag = false;
					}
					global::Infragistics.Windows.DataPresenter.Cell navigationTargetCell = this.GetNavigationTargetCell(activeCell3, navigationDirection2, this, flag, flag2, siblingNavigationStyle);
					if (navigationTargetCell != null)
					{
						global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem3 = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(navigationTargetCell);
						if (selectionStrategyForItem3 != null)
						{
							if (flag && this._pivotCell == null && activeCell3 != null && selectionStrategyForItem3.IsMultiSelect)
							{
								this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Record>(ref this._pivotRecord, null);
								this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Cell>(ref this._pivotCell, activeCell3);
							}
							if (flag && this._pivotCell != null)
							{
								global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
								if (currentViewInternal != null)
								{
									global::System.Windows.Controls.Orientation logicalOrientation = currentViewInternal.LogicalOrientation;
									if (this._pivotCell.IsOnSameTier(activeCell3, logicalOrientation))
									{
										if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
										{
											if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLeft || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellRight)
											{
												this._snaking = true;
											}
										}
										else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellBelow)
										{
											this._snaking = true;
										}
									}
								}
							}
							if (selectionStrategyForItem3.SelectItemViaKeyboard(navigationTargetCell, flag, flag2, false))
							{
								this.BringCellIntoView(navigationTargetCell);
							}
							if ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPreviousByTab || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellNextByTab) && navigationTargetCell.IsEditingAllowed && navigationTargetCell.IsActive)
							{
								bool flag6 = false;
								switch (navigationTargetCell.Record.GetCellClickActionResolved(navigationTargetCell.Field))
								{
								case global::Infragistics.Windows.DataPresenter.CellClickAction.SelectCell:
								case global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord:
									flag6 = flag5;
									break;
								case global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed:
									flag6 = true;
									break;
								}
								if (flag6)
								{
									this.ExecuteCommand(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.StartEditMode);
								}
							}
						}
						else
						{
							this.BringCellIntoView(navigationTargetCell);
						}
						if (base.IsKeyboardFocusWithin)
						{
							navigationTargetCell.FocusIfActive();
						}
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout owner = activeCell3.Field.Owner;
						if (flag3 && routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellNextByTab && activeCell3 != null && activeCell3.Record.IsAddRecord && raiseEvents && owner != null && owner.AddNewRecordLocationResolved == global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnBottom)
						{
							this.CommitChangesToRecord(activeCell3.Record);
							flag4 = this.ExecuteCommandImpl(routedCommand, parameter, false);
							goto IL_163A;
						}
					}
					flag4 = (navigationTargetCell != null || !flag3);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstDisplayed || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastDisplayed || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstInRecord || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastInRecord)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord4 = null;
				if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstDisplayed)
				{
					dataRecord4 = (viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord);
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastDisplayed)
				{
					dataRecord4 = (viewPanel.GetLastDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord);
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall)
				{
					dataRecord4 = this.FirstOverallDataRecord;
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastOverall)
				{
					dataRecord4 = this.LastOverallDataRecord;
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstInRecord || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastInRecord)
				{
					dataRecord4 = (this.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord);
				}
				if (dataRecord4 != null)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell;
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstDisplayed || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstInRecord)
					{
						cell = dataRecord4.FirstDisplayedCell;
					}
					else
					{
						cell = dataRecord4.LastDisplayedCell;
					}
					if (cell != null)
					{
						global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem4 = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(cell);
						if (selectionStrategyForItem4 != null)
						{
							selectionStrategyForItem4.SelectItemViaKeyboard(cell, flag, flag2, false);
							base.UpdateLayout();
							if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastOverall)
							{
								viewPanel.EnsureRecordIsVisible(dataRecord4);
							}
							this.BringCellIntoView(cell);
							flag4 = true;
						}
						if (base.IsKeyboardFocusWithin)
						{
							cell.FocusIfActive();
						}
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageBelow || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageLeft || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageRight)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell4 = this.ActiveCell;
				if (activeCell4 != null && viewPanel != null && viewPanel.EnsureRecordIsVisible(activeCell4.Record))
				{
					base.UpdateLayout();
					if (viewPanel.EnsureCellIsVisible(activeCell4))
					{
						bool flag7 = routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageRight || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageBelow;
						bool flag8 = routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageRight || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellPageLeft;
						base.UpdateLayout();
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter>();
						this.GetRecordPresentersInViewHelper(this, this.CurrentPanel, list, true, flag8, !flag8, true, typeof(global::Infragistics.Windows.DataPresenter.DataRecord), true, true);
						int num = -1;
						for (int i = 0; i < list.Count; i++)
						{
							global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = list[i] as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
							if (dataRecordPresenter != null && dataRecordPresenter.Record == activeCell4.Record)
							{
								num = i;
								break;
							}
						}
						if (num >= 0)
						{
							global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = activeCell4.AssociatedCellValuePresenter;
							global::System.Windows.Rect empty;
							if (cellValuePresenter != null)
							{
								empty = new global::System.Windows.Rect(cellValuePresenter.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this), new global::System.Windows.Size(cellValuePresenter.ActualWidth, cellValuePresenter.ActualHeight));
							}
							else
							{
								empty = global::System.Windows.Rect.Empty;
							}
							bool flag9 = false;
							global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType scrollType = global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageAbove;
							if (flag7)
							{
								if (num >= list.Count - 1)
								{
									flag9 = true;
									if (flag8)
									{
										scrollType = global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageRight;
									}
									else
									{
										scrollType = global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageBelow;
									}
								}
							}
							else if (num < 1)
							{
								flag9 = true;
								if (flag8)
								{
									scrollType = global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageLeft;
								}
								else
								{
									scrollType = global::Infragistics.Windows.DataPresenter.PanelNavigationScrollType.PageAbove;
								}
							}
							global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = null;
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter>(list);
							int num2 = 0;
							while (flag9 && num2 < 2)
							{
								recordPresenter = null;
								viewPanel.Scroll(scrollType);
								num2++;
								base.UpdateLayout();
								global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter>();
								this.GetRecordPresentersInViewHelper(this, this.CurrentPanel, list3, true, flag8, !flag8, true, typeof(global::Infragistics.Windows.DataPresenter.DataRecord), true, false);
								if (list2.Count == list3.Count)
								{
									bool flag10 = false;
									if (list3.Count > 0)
									{
										flag10 = (list2[0] != list3[0]);
									}
									if (!flag10)
									{
										if (list2.Count == 0)
										{
											this.ClearActiveCell();
											activeCell4 = this.ActiveCell;
											break;
										}
										break;
									}
								}
								if (list3.Count > 0 && list3[0] != list[0])
								{
									if (flag7)
									{
										recordPresenter = list3[list3.Count - 1];
									}
									else
									{
										recordPresenter = list3[global::System.Math.Min(num, list3.Count - 1)];
									}
									if (recordPresenter.Record != activeCell4.Record)
									{
										break;
									}
								}
								list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter>(list3);
							}
							if (recordPresenter == null)
							{
								if (flag7)
								{
									recordPresenter = list[list.Count - 1];
								}
								else
								{
									recordPresenter = list[0];
								}
							}
							if (recordPresenter != null)
							{
								global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter2 = recordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
								global::Infragistics.Windows.DataPresenter.Cell cell2 = null;
								if (dataRecordPresenter2 != null && activeCell4 != null)
								{
									if (dataRecordPresenter2.FieldLayout == activeCell4.Field.Owner)
									{
										cell2 = dataRecordPresenter2.DataRecord.Cells[activeCell4.Field];
									}
									else
									{
										global::Infragistics.Windows.DataPresenter.CellValuePresenter[] childCellValuePresenters = dataRecordPresenter2.GetChildCellValuePresenters();
										if (childCellValuePresenters != null && childCellValuePresenters.Length > 0)
										{
											bool flag11 = true;
											for (int j = 0; j < childCellValuePresenters.Length; j++)
											{
												cellValuePresenter = childCellValuePresenters[j];
												global::System.Windows.Rect rect = new global::System.Windows.Rect(cellValuePresenter.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this), new global::System.Windows.Size(cellValuePresenter.ActualWidth, cellValuePresenter.ActualHeight));
												if (flag8)
												{
													rect.Y = empty.Y;
													rect.Height = empty.Height;
												}
												else
												{
													rect.X = empty.X;
													rect.Width = empty.Width;
												}
												if (rect.IntersectsWith(empty))
												{
													cell2 = cellValuePresenter.Cell;
													break;
												}
												bool flag12;
												if (flag8)
												{
													flag12 = (empty.Left < rect.Left);
												}
												else
												{
													flag12 = (empty.Top < rect.Top);
												}
												if (j > 0 && flag12 != flag11)
												{
													cell2 = cellValuePresenter.Cell;
													break;
												}
												flag11 = flag12;
											}
											if (flag11)
											{
												cell2 = childCellValuePresenters[0].Cell;
											}
											else
											{
												cell2 = childCellValuePresenters[childCellValuePresenters.Length - 1].Cell;
											}
										}
									}
								}
								global::Infragistics.Windows.Selection.ISelectableItem selectableItem;
								if (cell2 != null)
								{
									selectableItem = cell2;
								}
								else
								{
									selectableItem = recordPresenter.Record;
									flag = false;
									flag2 = false;
								}
								if (selectableItem == null)
								{
									flag4 = true;
								}
								else
								{
									global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem5 = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(selectableItem);
									if (selectionStrategyForItem5 != null)
									{
										selectionStrategyForItem5.SelectItemViaKeyboard(selectableItem, flag, flag2, false);
									}
									if (!recordPresenter.Record.IsActive)
									{
										this.ActiveRecord = recordPresenter.Record;
									}
									if (cell2 != null)
									{
										viewPanel.EnsureCellIsVisible(cell2);
									}
									else if (recordPresenter.Record != null)
									{
										viewPanel.EnsureRecordIsVisible(recordPresenter.Record);
									}
									base.UpdateLayout();
									flag4 = true;
								}
							}
						}
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleActiveCellSelectionState)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell5 = this.ActiveCell;
				if (activeCell5 != null && ((global::Infragistics.Windows.Selection.ISelectableItem)activeCell5).IsSelectable)
				{
					global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem6 = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(activeCell5);
					if (selectionStrategyForItem6 != null && (selectionStrategyForItem6.IsMultiSelect || selectionStrategyForItem6.IsSingleSelect))
					{
						bool isSelected = activeCell5.IsSelected;
						selectionStrategyForItem6.SelectItemViaKeyboard(activeCell5, flag, flag2, true);
						flag4 = (isSelected != activeCell5.IsSelected);
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleActiveRecordSelectionState)
			{
				global::Infragistics.Windows.DataPresenter.Record activeRecord2 = this.ActiveRecord;
				if (activeRecord2 != null && ((global::Infragistics.Windows.Selection.ISelectableItem)activeRecord2).IsSelectable)
				{
					global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem7 = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(activeRecord2);
					if (selectionStrategyForItem7 != null && (selectionStrategyForItem7.IsMultiSelect || selectionStrategyForItem7.IsSingleSelect))
					{
						bool isSelected2 = activeRecord2.IsSelected;
						if (this.ActiveCell != null)
						{
							this.ActiveCell = null;
							if (this.ActiveCell != null)
							{
								goto IL_163A;
							}
						}
						selectionStrategyForItem7.SelectItemViaKeyboard(activeRecord2, flag, flag2, true);
						flag4 = (isSelected2 != activeRecord2.IsSelected);
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveCellFilters || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleFilterOperatorDropDown)
			{
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell = parameter as global::Infragistics.Windows.DataPresenter.FilterCell;
				if (filterCell == null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = parameter as global::Infragistics.Windows.DataPresenter.Field;
					if (field != null)
					{
						global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = this.ActiveRecord as global::Infragistics.Windows.DataPresenter.FilterRecord;
						if (filterRecord != null && field.Owner == filterRecord.FieldLayout)
						{
							filterCell = filterRecord.Cells[field];
						}
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = parameter as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
						if (filterCellValuePresenter != null)
						{
							filterCell = (filterCellValuePresenter.Cell as global::Infragistics.Windows.DataPresenter.FilterCell);
						}
					}
				}
				if (filterCell == null)
				{
					filterCell = (this.ActiveCell as global::Infragistics.Windows.DataPresenter.FilterCell);
				}
				if (filterCell != null && (filterCell.IsInEditMode || this.EndEditMode(true, false)))
				{
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveCellFilters)
					{
						filterCell.ClearActiveFilters(true);
						flag4 = true;
					}
					else
					{
						this.BringCellIntoView(filterCell);
						base.UpdateLayout();
						global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter2 = filterCell.AssociatedCellValuePresenter as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
						if (filterCellValuePresenter2 != null && filterCellValuePresenter2.Field != null && filterCellValuePresenter2.Field.FilterOperatorVisibilityResolved == global::System.Windows.Visibility.Visible)
						{
							filterCellValuePresenter2.IsOperatorDropDownOpen = !filterCellValuePresenter2.IsOperatorDropDownOpen;
							flag4 = true;
						}
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearActiveRecordCellFilters)
			{
				global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord2 = parameter as global::Infragistics.Windows.DataPresenter.FilterRecord;
				if (filterRecord2 == null)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter2 = parameter as global::Infragistics.Windows.DataPresenter.RecordPresenter;
					if (recordPresenter2 != null)
					{
						filterRecord2 = (recordPresenter2.Record as global::Infragistics.Windows.DataPresenter.FilterRecord);
					}
				}
				if (filterRecord2 == null)
				{
					filterRecord2 = (this.ActiveRecord as global::Infragistics.Windows.DataPresenter.FilterRecord);
				}
				if (filterRecord2 != null)
				{
					filterRecord2.ClearActiveFilters(true);
					flag4 = true;
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldFar || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldNear || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixField)
			{
				global::Infragistics.Windows.DataPresenter.Field field2 = parameter as global::Infragistics.Windows.DataPresenter.Field;
				if (field2 != null)
				{
					global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedFieldLocation;
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldNear)
					{
						fixedFieldLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge;
					}
					else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldFar)
					{
						fixedFieldLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge;
					}
					else
					{
						fixedFieldLocation = global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable;
					}
					if (field2.FixedLocation != fixedFieldLocation && field2.IsFixedLocationAllowed(fixedFieldLocation))
					{
						global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason fieldPositionChangeReason = (fixedFieldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable) ? global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed : global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed;
						global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs fieldPositionChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs(field2, fieldPositionChangeReason);
						this.RaiseFieldPositionChanging(fieldPositionChangingEventArgs);
						if (!fieldPositionChangingEventArgs.Cancel)
						{
							if (this.IsUndoEnabled)
							{
								global::Infragistics.Windows.DataPresenter.FieldPositionAction action = new global::Infragistics.Windows.DataPresenter.FieldPositionAction(new global::Infragistics.Windows.DataPresenter.Field[]
								{
									field2
								}, field2.Owner.GetFieldLayoutInfo(true, true), global::Infragistics.Windows.DataPresenter.FieldPositionAction.GetUndoReason(fieldPositionChangeReason), field2.FixedLocation);
								this.History.AddUndoActionInternal(action);
							}
							field2.SetFixedLocation(fixedFieldLocation);
							if (field2.Owner != null)
							{
								field2.Owner.InvalidateGeneratedStyles(false, false);
							}
							flag4 = true;
							this.RaiseFieldPositionChanged(new global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs(field2, fieldPositionChangeReason));
						}
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordTop || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordBottom || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixRecord)
			{
				global::Infragistics.Windows.DataPresenter.Record record3 = parameter as global::Infragistics.Windows.DataPresenter.Record;
				if (record3 != null)
				{
					global::Infragistics.Windows.DataPresenter.FixedRecordLocation fixedRecordLocation;
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordTop)
					{
						fixedRecordLocation = global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop;
					}
					else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixRecordBottom)
					{
						fixedRecordLocation = global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToBottom;
					}
					else
					{
						fixedRecordLocation = global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable;
					}
					if (record3.FixedLocation != fixedRecordLocation && record3.IsFixedLocationAllowed(fixedRecordLocation))
					{
						global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs recordFixedLocationChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs(record3, fixedRecordLocation);
						this.RaiseRecordFixedLocationChanging(recordFixedLocationChangingEventArgs);
						if (!recordFixedLocationChangingEventArgs.Cancel)
						{
							if (this.IsUndoEnabled)
							{
								global::Infragistics.Windows.DataPresenter.RecordFixedStateAction action2 = new global::Infragistics.Windows.DataPresenter.RecordFixedStateAction(new global::Infragistics.Windows.DataPresenter.Record[]
								{
									record3
								}, record3.FixedLocation);
								this.History.AddUndoActionInternal(action2);
							}
							record3.FixedLocation = fixedRecordLocation;
							flag4 = true;
							this.RaiseRecordFixedLocationChanged(new global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs(record3));
						}
					}
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Undo || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Redo)
			{
				flag4 = (this._history != null && this._history.PerformUndoRedo(routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Undo));
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Cut || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Copy || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Paste || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearCellContents)
			{
				flag4 = this.ClipboardOperationInfo.PerformOperation(routedCommand);
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleRecordIsExpanded)
			{
				global::Infragistics.Windows.DataPresenter.Record record4 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
				if (record4 != null)
				{
					flag4 = record4.ExpandCollapse(!record4.IsExpanded, true, false);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AutoSizeField)
			{
				global::Infragistics.Windows.DataPresenter.Field field3 = commandInfo.Parameter as global::Infragistics.Windows.DataPresenter.Field;
				if (field3 != null)
				{
					field3.PerformAutoSize(field3.AutoSizeOptionsResolved, field3.AutoSizeScopeResolved, true);
					flag4 = true;
				}
			}
			else
			{
				if (global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ShowFieldChooser == routedCommand)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = parameter as global::Infragistics.Windows.DataPresenter.FieldLayout;
					this.ShowFieldChooser(fieldLayout2, true, true);
				}
				if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleCardCollapsedState)
				{
					global::Infragistics.Windows.DataPresenter.Record record5 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
					if (record5 != null)
					{
						flag4 = record5.ToggleContainingCardCollapsedState(true);
					}
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleEmptyCardCellsCollapsedState)
				{
					global::Infragistics.Windows.DataPresenter.Record record6 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
					if (record6 != null)
					{
						flag4 = record6.ToggleContainingCardEmptyCellsCollapsedState(true);
					}
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CancelExport)
				{
					flag4 = this.ExportHelper.CancelExport(this);
				}
			}
			IL_163A:
			this._commandsBeingExecuted--;
			if (raiseEvents && flag4)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(routedCommand, parameter));
			}
			return flag4;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x0003E350 File Offset: 0x0003C550
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Export(global::Infragistics.Windows.DataPresenter.IDataPresenterExporter exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			this.ExportHelper.Export(exporter, options);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0003E35F File Offset: 0x0003C55F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ExportAsync(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options, bool showExportStatus)
		{
			this.ExportHelper.ExportAsync(exporter, options, showExportStatus);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0003E36F File Offset: 0x0003C56F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ExportAsync(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options, bool showExportStatus, global::System.TimeSpan duration, global::System.TimeSpan interval)
		{
			this.ExportHelper.ExportAsync(exporter, options, showExportStatus, duration, interval);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0003E383 File Offset: 0x0003C583
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> GetCellsInView()
		{
			return global::Infragistics.Windows.DataPresenter.VisibleDataBlock.Create(this);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0003E38C File Offset: 0x0003C58C
		public global::Infragistics.Windows.DataPresenter.DataRecord GetRecordFromDataItem(object dataItem, bool recursive)
		{
			if (dataItem == null)
			{
				throw new global::System.ArgumentNullException("dataItem");
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecordFromDataItem = ((global::Infragistics.Windows.DataPresenter.DataRecordCollection)this.RecordManager.Unsorted).GetDataRecordFromDataItem(dataItem, recursive);
			if (dataRecordFromDataItem != null && dataRecordFromDataItem.DataPresenter != this)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_7"));
			}
			return dataRecordFromDataItem;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0003E3DC File Offset: 0x0003C5DC
		public global::Infragistics.Windows.DataPresenter.DataRecord[] GetRecordsFromDataItems(object[] dataItems, bool recursive)
		{
			global::Infragistics.Windows.DataPresenter.DataItemRecordMap dataItemRecordMap = new global::Infragistics.Windows.DataPresenter.DataItemRecordMap(this, dataItems);
			if (dataItemRecordMap._itemsRemainingToBeMapped == 0)
			{
				return new global::Infragistics.Windows.DataPresenter.DataRecord[0];
			}
			((global::Infragistics.Windows.DataPresenter.DataRecordCollection)this.RecordManager.Unsorted).LoadDataItemRecordMap(dataItemRecordMap, recursive);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>(dataItemRecordMap._map.Count);
			if (dataItemRecordMap._dataItemsForComparison != null)
			{
				for (int i = 0; i < dataItemRecordMap._dataItemsForComparison.Length; i++)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
					if (dataItemRecordMap._map.TryGetValue(dataItemRecordMap._dataItemsForComparison[i], out dataRecord) && dataRecord != null)
					{
						list.Add(dataRecord);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0003E46A File Offset: 0x0003C66A
		public global::Infragistics.Windows.DataPresenter.Record[] GetRecordsInView(bool recursive)
		{
			return this.GetRecordsInView(recursive, false);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0003E474 File Offset: 0x0003C674
		internal global::Infragistics.Windows.DataPresenter.Record[] GetRecordsInView(bool recursive, bool ignoreAnimations)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresentersInView = this.GetRecordPresentersInView(recursive, ignoreAnimations, false, true);
			global::Infragistics.Windows.DataPresenter.Record[] array = new global::Infragistics.Windows.DataPresenter.Record[recordPresentersInView.Count];
			for (int i = 0; i < recordPresentersInView.Count; i++)
			{
				array[i] = recordPresentersInView[i].Record;
			}
			return array;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0003E4BC File Offset: 0x0003C6BC
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> GetRecordPresentersInView(bool recursive, bool ignoreAnimations, bool skipUpdateLayout = false, bool processPendingInvalidateGeneratedStyles = true)
		{
			if (this._invalidateGeneratedStylesPending && processPendingInvalidateGeneratedStyles)
			{
				this.OnInvalidateGeneratedStyles();
			}
			if (!skipUpdateLayout)
			{
				base.UpdateLayout();
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter>();
			global::System.Windows.Controls.Panel currentPanel = this.CurrentPanel;
			if (currentPanel != null)
			{
				this.GetRecordPresentersInViewHelper(currentPanel, currentPanel, list, recursive && this.CurrentViewInternal.IsNestedPanelsSupported, false, false, false, null, ignoreAnimations, false);
			}
			return list;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0003E518 File Offset: 0x0003C718
		private void GetRecordPresentersInViewHelper(global::System.Windows.FrameworkElement parent, global::System.Windows.Controls.Panel topLevelPanel, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresenters, bool recursive, bool onlyFullyInViewInXDimension, bool onlyFullyInViewInYDimension, bool excludeFixedRootRecords, global::System.Type restrictToRecordType, bool ignoreAnimations, bool dontExcludeActiveRecord = false)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter descendantFromType = global::Infragistics.Windows.Utilities.GetDescendantFromType<global::Infragistics.Windows.DataPresenter.RecordPresenter>(parent, true, null, new global::System.Type[]
			{
				typeof(global::Infragistics.Windows.DataPresenter.RecordCellAreaBase)
			});
			if (descendantFromType == null)
			{
				return;
			}
			bool isFlatView = this.IsFlatView;
			global::System.Windows.Media.Visual stopAtVisual = global::System.Windows.Media.VisualTreeHelper.GetParent(parent) as global::System.Windows.Media.Visual;
			global::System.Windows.Controls.Panel panel = topLevelPanel;
			global::System.Windows.DependencyObject descendant = descendantFromType;
			while (panel != null)
			{
				panel = (global::Infragistics.Windows.Utilities.GetAncestorFromType(descendant, typeof(global::System.Windows.Controls.Panel), true, stopAtVisual) as global::System.Windows.Controls.Panel);
				if (panel is global::Infragistics.Windows.DataPresenter.IViewPanel || panel is global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)
				{
					break;
				}
				descendant = panel;
			}
			if (panel == null)
			{
				return;
			}
			global::System.Windows.Controls.ScrollContentPresenter scrollContentPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(topLevelPanel, typeof(global::System.Windows.Controls.ScrollContentPresenter), true, this) as global::System.Windows.Controls.ScrollContentPresenter;
			global::System.Windows.Rect rect;
			if (scrollContentPresenter != null)
			{
				rect = new global::System.Windows.Rect(new global::System.Windows.Size(scrollContentPresenter.ActualWidth, scrollContentPresenter.ActualHeight));
			}
			else
			{
				rect = new global::System.Windows.Rect(new global::System.Windows.Size(topLevelPanel.ActualWidth, topLevelPanel.ActualHeight));
			}
			global::System.Collections.IList list;
			if (panel is global::Infragistics.Windows.Virtualization.RecyclingItemsPanel)
			{
				list = ((global::Infragistics.Windows.Virtualization.RecyclingItemsPanel)panel).ChildElements;
			}
			else
			{
				list = panel.Children;
			}
			global::Infragistics.Windows.Tiles.TilesPanelBase tilesPanelBase = panel as global::Infragistics.Windows.Tiles.TilesPanelBase;
			foreach (object obj in list)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = uielement as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				if (recordPresenter == null)
				{
					recordPresenter = (global::Infragistics.Windows.Utilities.GetDescendantFromType(uielement, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
					if (recordPresenter == null)
					{
						continue;
					}
				}
				if (recordPresenter.Visibility == global::System.Windows.Visibility.Visible && recordPresenter.Opacity >= 0.0001 && recordPresenter.Record.RecordType != global::Infragistics.Windows.DataPresenter.RecordType.HeaderRecord && (!(restrictToRecordType != null) || restrictToRecordType.IsAssignableFrom(recordPresenter.Record.GetType())))
				{
					global::System.Windows.Rect rect2 = global::System.Windows.Rect.Empty;
					global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
					if (ignoreAnimations && tilesPanelBase != null)
					{
						rect2 = tilesPanelBase.GetInViewRect(uielement);
						if (rect2.IsEmpty)
						{
							continue;
						}
						empty = new global::System.Windows.Rect(uielement.RenderSize);
					}
					else
					{
						global::System.Windows.Media.GeneralTransform generalTransform = recordPresenter.TransformToAncestor(topLevelPanel);
						global::System.Windows.Rect rect3;
						if (generalTransform != null)
						{
							rect3 = new global::System.Windows.Rect(generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0)), new global::System.Windows.Size(recordPresenter.ActualWidth, recordPresenter.ActualHeight));
						}
						else
						{
							rect3 = new global::System.Windows.Rect(recordPresenter.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), topLevelPanel), new global::System.Windows.Size(recordPresenter.ActualWidth, recordPresenter.ActualHeight));
						}
						if (!rect3.IntersectsWith(rect))
						{
							continue;
						}
					}
					bool flag = true;
					global::System.Windows.DependencyObject parent2 = global::System.Windows.Media.VisualTreeHelper.GetParent(recordPresenter);
					while (flag && parent2 != null && parent2 != panel)
					{
						global::System.Windows.FrameworkElement frameworkElement = parent2 as global::System.Windows.FrameworkElement;
						if (frameworkElement != null && (frameworkElement.Visibility != global::System.Windows.Visibility.Visible || frameworkElement.Opacity < 0.0001))
						{
							flag = false;
						}
						else
						{
							parent2 = global::System.Windows.Media.VisualTreeHelper.GetParent(parent2);
						}
					}
					if (flag)
					{
						bool flag2 = recordPresenter.ShouldDisplayRecordContent && recordPresenter.Record.OccupiesScrollPosition;
						if (excludeFixedRootRecords && flag2 && recordPresenter.Record.IsFixed && (!dontExcludeActiveRecord || recordPresenter.Record != this._activeRecord))
						{
							flag2 = false;
						}
						if (flag2)
						{
							global::System.Windows.FrameworkElement recordContentSite = recordPresenter.GetRecordContentSite();
							if (recordContentSite != null)
							{
								if (!empty.IsEmpty)
								{
									if (onlyFullyInViewInXDimension && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(empty.Width, rect2.Width))
									{
										flag2 = false;
									}
									if (onlyFullyInViewInYDimension && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(empty.Height, rect2.Height))
									{
										flag2 = false;
									}
								}
								else
								{
									global::System.Windows.Media.GeneralTransform generalTransform = recordContentSite.TransformToAncestor(topLevelPanel);
									global::System.Windows.Rect rect3;
									if (generalTransform != null)
									{
										rect3 = new global::System.Windows.Rect(generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0)), new global::System.Windows.Size(recordContentSite.ActualWidth, recordContentSite.ActualHeight));
									}
									else
									{
										rect3 = new global::System.Windows.Rect(recordContentSite.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), topLevelPanel), new global::System.Windows.Size(recordContentSite.ActualWidth, recordContentSite.ActualHeight));
									}
									if (onlyFullyInViewInXDimension)
									{
										if (rect3.Left < rect.Left || rect3.Right > rect.Right)
										{
											flag2 = false;
										}
										else
										{
											global::System.Windows.Media.RectangleGeometry rectangleGeometry = recordPresenter.InternalClip as global::System.Windows.Media.RectangleGeometry;
											if (rectangleGeometry != null && rectangleGeometry.Bounds.Width < rect3.Width)
											{
												flag2 = false;
											}
										}
									}
									if (onlyFullyInViewInYDimension)
									{
										if (rect3.Top < rect.Top || rect3.Bottom > rect.Bottom)
										{
											flag2 = false;
										}
										else
										{
											global::System.Windows.Media.RectangleGeometry rectangleGeometry2 = recordPresenter.InternalClip as global::System.Windows.Media.RectangleGeometry;
											if (rectangleGeometry2 != null && rectangleGeometry2.Bounds.Height < rect3.Height)
											{
												flag2 = false;
											}
										}
									}
								}
							}
						}
						if (flag2)
						{
							recordPresenters.Add(recordPresenter);
						}
						if (recursive && !isFlatView && recordPresenter.IsExpanded)
						{
							this.GetRecordPresentersInViewHelper(recordPresenter, topLevelPanel, recordPresenters, recursive, onlyFullyInViewInXDimension, onlyFullyInViewInYDimension, false, restrictToRecordType, ignoreAnimations, false);
						}
					}
				}
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0003EA20 File Offset: 0x0003CC20
		internal bool HasRegisteredFieldChoosers()
		{
			return this._registeredFieldChoosers != null && global::Infragistics.Windows.DataPresenter.GridUtilities.GetCountNonOptimized(this._registeredFieldChoosers) > 0;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0003EA3A File Offset: 0x0003CC3A
		public void LoadCustomizations(global::System.IO.Stream stream)
		{
			this.CustomizationsManager.LoadCustomizations(stream);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0003EA48 File Offset: 0x0003CC48
		public void LoadCustomizations(string Customizations)
		{
			this.CustomizationsManager.LoadCustomizations(Customizations);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0003EA58 File Offset: 0x0003CC58
		public void LoadCustomizations(global::System.IO.Stream stream, out string error)
		{
			try
			{
				this.CustomizationsManager.LoadCustomizations(stream);
				error = null;
			}
			catch (global::System.Exception ex)
			{
				error = ex.Message;
			}
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0003EA94 File Offset: 0x0003CC94
		public void LoadCustomizations(string Customizations, out string error)
		{
			try
			{
				this.CustomizationsManager.LoadCustomizations(Customizations);
				error = null;
			}
			catch (global::System.Exception ex)
			{
				error = ex.Message;
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0003EAD0 File Offset: 0x0003CCD0
		internal void RegisterFieldChooser(global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
		{
			global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser> weakList = this._registeredFieldChoosers;
			if (weakList == null)
			{
				weakList = (this._registeredFieldChoosers = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser>());
			}
			if (!weakList.Contains(fieldChooser))
			{
				weakList.Add(fieldChooser);
			}
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0003EB05 File Offset: 0x0003CD05
		public void SaveCustomizations(global::System.IO.Stream stream)
		{
			this.CustomizationsManager.SaveCustomizations(stream);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0003EB13 File Offset: 0x0003CD13
		public string SaveCustomizations()
		{
			return this.CustomizationsManager.SaveCustomizations();
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0003EB20 File Offset: 0x0003CD20
		public void ShowFieldChooser()
		{
			this.ShowFieldChooserHelper(null, true, true, null);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0003EB2C File Offset: 0x0003CD2C
		public void ShowFieldChooser(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool allowFieldLayoutSelection)
		{
			this.ShowFieldChooserHelper(fieldLayout, allowFieldLayoutSelection, true, null);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0003EB38 File Offset: 0x0003CD38
		public void ShowFieldChooser(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool allowFieldLayoutSelection, bool retainFieldChooser)
		{
			this.ShowFieldChooserHelper(fieldLayout, allowFieldLayoutSelection, retainFieldChooser, null);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0003EB44 File Offset: 0x0003CD44
		public void ShowFieldChooser(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool allowFieldLayoutSelection, bool retainFieldChooser, string windowCaption)
		{
			this.ShowFieldChooserHelper(fieldLayout, allowFieldLayoutSelection, retainFieldChooser, windowCaption);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0003EB54 File Offset: 0x0003CD54
		private void ShowFieldChooserHelper(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool allowFieldLayoutSelection, bool retainFieldChooser, string windowCaption)
		{
			global::Infragistics.Windows.Controls.ToolWindow toolWindow;
			bool flag;
			if (this._retainedFieldChooserWindow != null)
			{
				toolWindow = this._retainedFieldChooserWindow;
				flag = true;
			}
			else
			{
				flag = false;
				toolWindow = new global::Infragistics.Windows.Controls.ToolWindow();
				toolWindow.AllowClose = true;
				toolWindow.ResizeMode = global::System.Windows.ResizeMode.CanResize;
			}
			if (retainFieldChooser)
			{
				this._retainedFieldChooserWindow = toolWindow;
			}
			if (windowCaption != null)
			{
				toolWindow.Title = windowCaption;
			}
			else
			{
				global::Infragistics.Shared.DynamicResourceString dynamicResourceString = global::Infragistics.Windows.DataPresenter.Resources.GetDynamicResourceString("FieldChooser_Title", null, null);
				toolWindow.SetBinding(global::Infragistics.Windows.Controls.ToolWindow.TitleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("Value", global::System.Windows.Data.BindingMode.OneWay, dynamicResourceString));
			}
			if (!flag)
			{
				toolWindow.MaxWidth = 600.0;
				toolWindow.Height = 300.0;
			}
			global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser = toolWindow.Content as global::Infragistics.Windows.DataPresenter.FieldChooser;
			if (fieldChooser == null)
			{
				fieldChooser = new global::Infragistics.Windows.DataPresenter.FieldChooser();
				toolWindow.Content = fieldChooser;
				fieldChooser.DataPresenter = this;
			}
			fieldChooser.FieldGroupSelectorVisibility = (allowFieldLayoutSelection ? null : new global::System.Windows.Visibility?(global::System.Windows.Visibility.Collapsed));
			global::Infragistics.Windows.DataPresenter.FieldChooserGroup currentFieldGroup = fieldChooser.CurrentFieldGroup;
			if (fieldLayout != null && fieldLayout != currentFieldGroup.FieldLayout)
			{
				fieldChooser.CurrentFieldGroup = new global::Infragistics.Windows.DataPresenter.FieldChooserGroup(fieldLayout, null);
			}
			global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs fieldChooserOpeningEventArgs = new global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs(toolWindow, fieldChooser);
			this.RaiseFieldChooserOpening(fieldChooserOpeningEventArgs);
			if (!fieldChooserOpeningEventArgs.Cancel)
			{
				if (!toolWindow.IsVisible)
				{
					toolWindow.Show(this);
					return;
				}
				toolWindow.Activate();
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0003EC78 File Offset: 0x0003CE78
		internal void UnregisterFieldChooser(global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
		{
			global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser> registeredFieldChoosers = this._registeredFieldChoosers;
			if (registeredFieldChoosers != null)
			{
				registeredFieldChoosers.Remove(fieldChooser);
			}
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0003EC97 File Offset: 0x0003CE97
		internal void AddStatusControl(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl)
		{
			if (ctrl != null && this._dataAreaGrid != null && global::System.Windows.Media.VisualTreeHelper.GetParent(ctrl) == null)
			{
				this._dataAreaGrid.Children.Add(ctrl);
			}
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0003ECC0 File Offset: 0x0003CEC0
		internal void BringFieldIntoView(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._bypassScrollIntoView)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record[] recordsInView = this.GetRecordsInView(true);
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			global::Infragistics.Windows.DataPresenter.Record[] array = recordsInView;
			int i = 0;
			while (i < array.Length)
			{
				global::Infragistics.Windows.DataPresenter.Record record = array[i];
				if (!(record is global::Infragistics.Windows.DataPresenter.HeaderRecord) && record is global::Infragistics.Windows.DataPresenter.DataRecord && record.FieldLayout == owner)
				{
					global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
					if (viewPanel != null)
					{
						viewPanel.EnsureCellIsVisible(((global::Infragistics.Windows.DataPresenter.DataRecord)record).Cells[field]);
						return;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0003ED44 File Offset: 0x0003CF44
		internal void BumpGroupByAreaStyleVersion()
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaResolved = this.GetGroupByAreaResolved(false);
			if (groupByAreaResolved != null)
			{
				groupByAreaResolved.StyleVersionNumber++;
			}
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0003ED6A File Offset: 0x0003CF6A
		internal void BumpOverallSortVersion()
		{
			this.OverallSortVersion++;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0003ED7A File Offset: 0x0003CF7A
		internal void BumpRecordNumberVersion()
		{
			this._bumpRecordNumberVersionPending = null;
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordNumberVersionPropertyKey, this.RecordNumberVersion + 1);
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0003ED9B File Offset: 0x0003CF9B
		internal void BumpRecordNumberVersionAsync()
		{
			if (this.IsSynchronousControl)
			{
				this.BumpRecordNumberVersion();
				return;
			}
			if (this._bumpRecordNumberVersionPending == null)
			{
				this._bumpRecordNumberVersionPending = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.BumpRecordNumberVersion));
			}
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0003EDD4 File Offset: 0x0003CFD4
		internal void BumpRecordsInViewVersion()
		{
			int num = this.RecordsInViewVersion;
			if (num == 2147483647)
			{
				num = 1;
			}
			else
			{
				num++;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionPropertyKey, num);
			this.RaiseCellsInViewChangedAsyncHelper();
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0003EE0F File Offset: 0x0003D00F
		internal void BumpScrollableRecordCountVersion()
		{
			this._bumpScrollCountOperation = null;
			this.ScrollableRecordCountVersion++;
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0003EE28 File Offset: 0x0003D028
		internal void BumpSortVersion()
		{
			if (this._fieldLayouts == null || this._fieldLayouts.Count < 1)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this.FieldLayouts)
			{
				fieldLayout.BumpSortVersion();
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0003EE8C File Offset: 0x0003D08C
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder CalculateNewSelection(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
			if (!clearExistingSelection)
			{
				if (!(item is global::Infragistics.Windows.DataPresenter.Record) && this.SelectedItems.Cells.Count > 0)
				{
					selectedItemHolder.Cells.InternalAddRange(this.SelectedItems.Cells);
				}
				if (!(item is global::Infragistics.Windows.DataPresenter.Cell) && this.SelectedItems.Records.Count > 0)
				{
					selectedItemHolder.Records.InternalAddRange(this.SelectedItems.Records);
				}
				if (this.SelectedItems.Fields.Count > 0)
				{
					selectedItemHolder.Fields.InternalAddRange(this.SelectedItems.Fields);
				}
			}
			else
			{
				bool flag = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
				if (flag && (item is global::Infragistics.Windows.DataPresenter.Cell || item is global::Infragistics.Windows.DataPresenter.Record) && this.SelectedItems.Fields.Count > 0)
				{
					selectedItemHolder.SetFields(this.SelectedItems.Fields);
				}
				if (flag && item.GetType() == typeof(global::Infragistics.Windows.DataPresenter.Field))
				{
					if (this.SelectedItems.Cells.Count > 0)
					{
						selectedItemHolder.SetCells(this.SelectedItems.Cells);
					}
					if (this.SelectedItems.Records.Count > 0)
					{
						selectedItemHolder.SetRecords(this.SelectedItems.Records);
					}
				}
			}
			if (select)
			{
				this.AddToSelectedCollection(selectedItemHolder, item);
			}
			else
			{
				this.RemoveFromSelectedCollection(selectedItemHolder, item);
			}
			if (item != null && select)
			{
				this.EnsureItemsWithinMaxSelectedItemsBounds(item, selectedItemHolder);
			}
			return selectedItemHolder;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0003F004 File Offset: 0x0003D204
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder CalculateNewSelectionRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				this.CalculateSelectionRange(item as global::Infragistics.Windows.DataPresenter.Record, selectedItemHolder, clearExistingSelection, select);
			}
			else if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				this.CalculateSelectionRange(item as global::Infragistics.Windows.DataPresenter.Cell, selectedItemHolder, clearExistingSelection, select);
			}
			else if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				this.CalculateSelectionRange(item as global::Infragistics.Windows.DataPresenter.Field, selectedItemHolder, clearExistingSelection, select);
			}
			this.EnsureItemsWithinMaxSelectedItemsBounds(item, selectedItemHolder);
			return selectedItemHolder;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0003F06A File Offset: 0x0003D26A
		internal bool ClearActiveCell()
		{
			return this.ClearActiveCell(false, false);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0003F074 File Offset: 0x0003D274
		internal bool ClearActiveCell(bool shutdown)
		{
			return this.ClearActiveCell(shutdown, false);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0003F080 File Offset: 0x0003D280
		internal bool ClearActiveCell(bool shutdown, bool calledFromSetActiveCell)
		{
			if (this._activeCell == null)
			{
				return true;
			}
			if (!shutdown)
			{
				if (this._activeCell.IsInEditMode)
				{
					this._activeCell.EndEditMode();
					if (this._activeCell != null && this._activeCell.IsInEditMode)
					{
						return false;
					}
				}
				global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs cellDeactivatingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs(this._activeCell);
				this.RaiseCellDeactivating(cellDeactivatingEventArgs);
				if (cellDeactivatingEventArgs.Cancel)
				{
					return false;
				}
				if (this._activeCell == null)
				{
					return false;
				}
			}
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this._activeCell;
			try
			{
				this._clearingActiveCell = true;
				if (calledFromSetActiveCell)
				{
					this._activeCell = null;
				}
				else
				{
					this.ActiveCell = null;
				}
			}
			finally
			{
				this._clearingActiveCell = false;
				if (shutdown)
				{
					this.EditHelper.ClearCellValuePresenter();
				}
			}
			if (!calledFromSetActiveCell)
			{
				activeCell.OnActiveCellChanged();
			}
			return true;
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0003F144 File Offset: 0x0003D344
		internal void ClearActiveRecord()
		{
			this.ClearActiveRecord(false);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0003F150 File Offset: 0x0003D350
		internal void ClearActiveRecord(bool force)
		{
			this._forceClearActiveRecord = force;
			try
			{
				this.ActiveCell = null;
				this.ActiveRecord = null;
			}
			finally
			{
				this._forceClearActiveRecord = false;
			}
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x0003F18C File Offset: 0x0003D38C
		internal bool ClearAllSelected()
		{
			global::System.Type type;
			if (this.SelectedItems.Cells != null && this.SelectedItems.Cells.Count > 0)
			{
				type = this.SelectedItems.Cells[0].GetType();
			}
			else if (this.SelectedItems.Records != null && this.SelectedItems.Records.Count > 0)
			{
				type = this.SelectedItems.Records[0].GetType();
			}
			else
			{
				if (this.SelectedItems.Fields == null || this.SelectedItems.Fields.Count <= 0)
				{
					return true;
				}
				type = this.SelectedItems.Fields[0].GetType();
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
			bool flag = !this.SelectNewSelection(type, selected);
			if (flag)
			{
				return false;
			}
			this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Record>(ref this._pivotRecord, null);
			this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Field>(ref this._pivotField, null);
			this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Cell>(ref this._pivotCell, null);
			return true;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x0003F288 File Offset: 0x0003D488
		internal void ClearPendingActiveRecordPresenter()
		{
			if (this._pendingActiveRecordPresenter != null)
			{
				this._pendingActiveRecordPresenter.ClearContainerForItem(this._pendingActiveRecordPresenter.Record);
				this._pendingActiveRecordPresenter = null;
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0003F2AF File Offset: 0x0003D4AF
		internal bool ClearSelectedItemsOfType(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				return this.ClearSelectedCells();
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				return this.ClearSelectedFields();
			}
			return item is global::Infragistics.Windows.DataPresenter.Record && this.ClearSelectedRecords();
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0003F2DF File Offset: 0x0003D4DF
		internal void ClearGroupBy()
		{
			if (this.DefaultFieldLayout == null)
			{
				return;
			}
			if (this.DefaultFieldLayout.HasGroupBySortFields)
			{
				this.DefaultFieldLayout.SortedFields.Clear();
				this.OnProcessSortCriteria(this.DefaultFieldLayout);
			}
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0003F313 File Offset: 0x0003D513
		internal void ClearItemsHost()
		{
			if (this._currentRecordListControl != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.SetPanelSettings(this._currentRecordListControl, null);
			}
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0003F32C File Offset: 0x0003D52C
		internal bool ClearSelectedCells()
		{
			if (this.SelectedItems.Cells != null && this.SelectedItems.Cells.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
				bool flag = !this.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Cell), selected);
				if (flag)
				{
					return false;
				}
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Record>(ref this._pivotRecord, null);
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Cell>(ref this._pivotCell, null);
			}
			return true;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0003F398 File Offset: 0x0003D598
		internal bool ClearSelectedFields()
		{
			if (this.SelectedItems.Fields != null && this.SelectedItems.Fields.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
				bool flag = !this.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Field), selected);
				if (flag)
				{
					return false;
				}
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Field>(ref this._pivotField, null);
			}
			return true;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0003F3F4 File Offset: 0x0003D5F4
		internal bool ClearSelectedRecords()
		{
			if (this.SelectedItems.Records != null && this.SelectedItems.Records.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
				bool flag = !this.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Record), selected);
				if (flag)
				{
					return false;
				}
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Record>(ref this._pivotRecord, null);
			}
			return true;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0003F450 File Offset: 0x0003D650
		internal void ClearStyleCache()
		{
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0003F454 File Offset: 0x0003D654
		internal bool DeleteRecords(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> recordList, bool displayPromptMessage, bool addToUndo)
		{
			if (addToUndo && this.IsUndoEnabled)
			{
				global::Infragistics.Windows.DataPresenter.DeleteRecordsAction action = new global::Infragistics.Windows.DataPresenter.DeleteRecordsAction(this, recordList, displayPromptMessage);
				return this.History.PerformAction(action, null);
			}
			global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction undeleteRecordsAction;
			int num;
			return this.DeleteRecords(recordList, displayPromptMessage, false, out undeleteRecordsAction, out num);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0003F490 File Offset: 0x0003D690
		internal bool DeleteRecords(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> recordList, bool displayPromptMessage, bool createUndoAction, out global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction undoAction, out int deletionCount)
		{
			undoAction = null;
			deletionCount = 0;
			if (recordList == null)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			foreach (global::Infragistics.Windows.DataPresenter.Record record in recordList)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null && dataRecord.CanDelete)
				{
					list.Add(dataRecord);
				}
			}
			if (list.Count == 0)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord[] array = list.ToArray();
			global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs recordsDeletingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs(array, displayPromptMessage);
			this.RaiseRecordsDeleting(recordsDeletingEventArgs);
			if (recordsDeletingEventArgs.Cancel)
			{
				return false;
			}
			if (recordsDeletingEventArgs.DisplayPromptMessage)
			{
				string @string;
				string string2;
				if (recordsDeletingEventArgs.Records.Count > 1)
				{
					@string = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DeleteMultipleRecordsPrompt", new object[]
					{
						array.Length
					});
					string2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DeleteRecordsMessageTitle");
				}
				else
				{
					@string = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DeleteSingleRecordPrompt");
					string2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DeleteSingleRecordMessageTitle");
				}
				global::System.Windows.MessageBoxResult messageBoxResult = global::Infragistics.Windows.Utilities.ShowMessageBox(this, @string, string2, global::System.Windows.MessageBoxButton.YesNo, global::System.Windows.MessageBoxImage.Question);
				if (messageBoxResult != global::System.Windows.MessageBoxResult.Yes)
				{
					return false;
				}
			}
			global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy undeleteStrategy = recordsDeletingEventArgs.UndeleteStrategy;
			global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo[] array2 = null;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> list2 = null;
			if (undeleteStrategy != null && createUndoAction)
			{
				list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>();
				int num = 0;
				array2 = new global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo[array.Length];
				for (int i = array.Length - 1; i >= 0; i--)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = array[i];
					global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo = global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo.Create(dataRecord2);
					array2[i] = recordInfo;
					if (dataRecord2.HasChildren)
					{
						num++;
					}
				}
				if (num > 0 && undeleteStrategy.RestoreDescendantActions)
				{
					global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo = this.History.CreateUndeleteDescendantInfo(array);
					for (int j = 0; j < array.Length; j++)
					{
						global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo2 = array2[j];
						if (recordInfo2 != null)
						{
							recordInfo2.AddChildren(array[j], descendantInfo);
						}
					}
				}
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = null;
			int index = -1;
			global::Infragistics.Windows.DataPresenter.Record activeRecord = this.ActiveRecord;
			for (int k = array.Length - 1; k >= 0; k--)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = array[k];
				try
				{
					int num2 = -1;
					if (dataRecord3.IsActive || (activeRecord != null && dataRecord3.IsAncestorOf(activeRecord)))
					{
						recordManager = dataRecord3.ParentCollection.ParentRecordManager;
						num2 = dataRecord3.SortIndex;
					}
					bool isAddRecord = dataRecord3.IsAddRecord;
					object dataItem = dataRecord3.DataItem;
					dataRecord3.DeleteHelper();
					if (dataRecord3.IsDeleted || (isAddRecord && (dataRecord3.IsAddRecordTemplate || !global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(dataRecord3.DataItem, dataItem))))
					{
						if (array2 != null && array2[k] != null)
						{
							list2.Add(array2[k]);
						}
						deletionCount++;
					}
					if (num2 >= 0)
					{
						index = num2;
					}
				}
				catch (global::System.Exception ex)
				{
					this.RaiseDataError(dataRecord3, null, ex, global::Infragistics.Windows.DataPresenter.DataErrorOperation.RecordDelete, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DataErrorDeleteRecordUnableToDelete", new object[]
					{
						ex.Message
					}));
				}
			}
			if (list2 != null && list2.Count > 0)
			{
				list2.Reverse();
				undoAction = new global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction(this, list2, undeleteStrategy);
			}
			this.SelectedItems.Records.InternalClear();
			if (recordManager != null)
			{
				recordManager.ReselectRecordAtSortedIndex(index);
			}
			this.RaiseRecordsDeleted(new global::Infragistics.Windows.DataPresenter.Events.RecordsDeletedEventArgs());
			return true;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0003F7A8 File Offset: 0x0003D9A8
		internal bool DeleteSelectedRecords(bool displayPromptMessage)
		{
			if (this.SelectedItems.Records.Count == 0)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.Record[] array = this.SelectedItems.Records.ToArray();
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (currentViewInternal.IsCrossLevelSelectionSupported && array.Length > 1)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(array);
				global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.Record> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.Record>(array);
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.Record record = null;
				for (int i = 0; i < list.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.Record record2 = list[i];
					global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = record2.ParentDataRecord;
					if (parentDataRecord != record)
					{
						record = parentDataRecord;
						flag = false;
						while (parentDataRecord != null)
						{
							if (hashSet.Contains(parentDataRecord))
							{
								flag = true;
								break;
							}
							parentDataRecord = parentDataRecord.ParentDataRecord;
						}
					}
					if (flag)
					{
						list.RemoveAt(i);
						i--;
					}
				}
				if (list.Count < array.Length)
				{
					array = list.ToArray();
				}
			}
			return this.DeleteRecords(array, displayPromptMessage, true);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0003F88C File Offset: 0x0003DA8C
		internal void DirtyFieldChooserFields()
		{
			global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser> registeredFieldChoosers = this._registeredFieldChoosers;
			if (registeredFieldChoosers != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser in registeredFieldChoosers)
				{
					if (fieldChooser != null)
					{
						fieldChooser.ReInitializeCurrentFields();
					}
				}
			}
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0003F8E0 File Offset: 0x0003DAE0
		internal bool EndEditMode(bool acceptChanges, bool force)
		{
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
			return activeCell == null || !activeCell.IsInEditMode || activeCell.EndEditMode(acceptChanges, force);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0003F90C File Offset: 0x0003DB0C
		internal object FindResourceForStylingPoint(global::System.Type elementType, bool walkResourceChain)
		{
			if (this._themeRegistered_DP_ResourceSet != null && this._themeRegistered_DP_ResourceSet.Contains(elementType))
			{
				object obj = this._themeRegistered_DP_ResourceSet[elementType];
				if (obj != null || !walkResourceChain)
				{
					return obj;
				}
			}
			return base.FindResource(elementType);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0003F94B File Offset: 0x0003DB4B
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> GetCrossLevelRecordsInRange(global::Infragistics.Windows.DataPresenter.Record startingRecord, bool forward)
		{
			return this.GetCrossLevelRecordsInRange(null, startingRecord, forward);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0003F956 File Offset: 0x0003DB56
		internal object GetDefaultResource(global::System.Type key, bool walkResourceChain)
		{
			if (this._themeRegistered_DP_ResourceSet != null)
			{
				return this.FindResourceForStylingPoint(key, walkResourceChain);
			}
			return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetGenericResource(key);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0003F970 File Offset: 0x0003DB70
		internal global::Infragistics.Windows.DataPresenter.FixedFieldInfo GetFixedFieldInfo(global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = rp.FieldLayout;
			if (fieldLayout == null || !fieldLayout.IsFixedFieldsEnabled)
			{
				return null;
			}
			return this.CurrentViewInternal.GetFixedFieldInfo(rp);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0003F9A0 File Offset: 0x0003DBA0
		internal global::Infragistics.Windows.DataPresenter.GroupByAreaBase GetGroupByAreaResolved(bool allocateIfNecessary)
		{
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (currentViewInternal != null && !currentViewInternal.IsGroupBySupported)
			{
				return null;
			}
			if (this.GroupByAreaMode != global::Infragistics.Windows.DataPresenter.GroupByAreaMode.DefaultFieldLayoutOnly)
			{
				if (this._groupByAreaMulti == null && allocateIfNecessary && this.GroupByAreaLocation != global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.None)
				{
					this.GroupByAreaMulti = new global::Infragistics.Windows.DataPresenter.GroupByAreaMulti();
				}
				return this._groupByAreaMulti;
			}
			if (this._groupByArea == null && allocateIfNecessary && this.GroupByAreaLocation != global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.None)
			{
				return this.GroupByArea;
			}
			return this._groupByArea;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0003FA10 File Offset: 0x0003DC10
		internal static object GetGenericResource(global::System.Type key)
		{
			if (global::Infragistics.Windows.Themes.DataPresenterGeneric.Instance.Contains(key))
			{
				return global::Infragistics.Windows.Themes.DataPresenterGeneric.Instance[key];
			}
			if (global::Infragistics.Windows.Themes.PrimitivesGeneric.Instance.Contains(key))
			{
				return global::Infragistics.Windows.Themes.PrimitivesGeneric.Instance[key];
			}
			if (global::Infragistics.Windows.Themes.EditorsGeneric.Instance.Contains(key))
			{
				return global::Infragistics.Windows.Themes.EditorsGeneric.Instance[key];
			}
			return null;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x0003FA6C File Offset: 0x0003DC6C
		internal bool GetHighlightPrimaryFieldResolved(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			global::Infragistics.Windows.DataPresenter.HighlightPrimaryField highlightPrimaryField = global::Infragistics.Windows.DataPresenter.HighlightPrimaryField.Default;
			if (layout != null && layout.HasSettings)
			{
				highlightPrimaryField = layout.Settings.HighlightPrimaryField;
			}
			if (highlightPrimaryField == global::Infragistics.Windows.DataPresenter.HighlightPrimaryField.Default && this.HasFieldLayoutSettings)
			{
				highlightPrimaryField = this.FieldLayoutSettings.HighlightPrimaryField;
			}
			switch (highlightPrimaryField)
			{
			case global::Infragistics.Windows.DataPresenter.HighlightPrimaryField.Highlight:
				return true;
			case global::Infragistics.Windows.DataPresenter.HighlightPrimaryField.SameAsOtherFields:
				return false;
			default:
				if (layout == null)
				{
					layout = this.DefaultFieldLayout;
				}
				if (layout != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = layout.StyleGenerator;
					return styleGenerator != null && !(styleGenerator is global::Infragistics.Windows.DataPresenter.GridViewFieldLayoutTemplateGenerator);
				}
				return false;
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x0003FAE9 File Offset: 0x0003DCE9
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(name, null);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0003FAF2 File Offset: 0x0003DCF2
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003FAFB File Offset: 0x0003DCFB
		internal void InternalAddLogicalChild(object child)
		{
			if (!this._logicalChildren.Contains(child))
			{
				base.AddLogicalChild(child);
				this._logicalChildren.Add(child);
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0003FB20 File Offset: 0x0003DD20
		internal void InitializeItemsPanel()
		{
			if (this._contentSiteGrid == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			global::System.Type itemsPanelType = currentViewInternal.ItemsPanelType;
			if (itemsPanelType.IsAbstract || !typeof(global::System.Windows.Controls.Panel).IsAssignableFrom(itemsPanelType))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_8"));
			}
			if (this._itemsPanel == null || this._itemsPanel.VisualTree.Type != itemsPanelType)
			{
				global::Infragistics.Windows.DataPresenter.RecordListControl rootRecordListControl = this._rootRecordListControl;
				if (rootRecordListControl != null)
				{
					this.ClearGroupBy();
					this.BumpGroupByAreaStyleVersion();
				}
				if (this._currentRecordListControl != null)
				{
					global::System.Windows.Data.BindingOperations.ClearBinding(this._currentRecordListControl, global::System.Windows.Controls.ItemsControl.ItemsPanelProperty);
				}
				this._rootRecordListControl = (this._currentRecordListControl = new global::Infragistics.Windows.DataPresenter.RecordListControl(this, true));
				this._itemsPanel = this.InitializeRecordListControlPanel(this._currentRecordListControl, itemsPanelType);
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ItemsPanelPropertyKey, this._itemsPanel);
				this._currentRecordListControl.SetBinding(global::System.Windows.Controls.ItemsControl.ItemsPanelProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ItemsPanelProperty, global::System.Windows.Data.BindingMode.OneWay, this));
				this._currentRecordListControl.InvalidateMeasure();
				this.UpdateScrollBarVisibility();
				this._currentRecordListControl.SetBinding(global::Infragistics.Windows.DataPresenter.RecordListControl.HorizontalScrollBarVisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.HorizontalScrollBarVisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, this));
				this._currentRecordListControl.SetBinding(global::Infragistics.Windows.DataPresenter.RecordListControl.VerticalScrollBarVisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.VerticalScrollBarVisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			}
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0003FC64 File Offset: 0x0003DE64
		internal void InternalRemoveLogicalChild(object child)
		{
			global::System.Windows.DependencyObject dependencyObject = child as global::System.Windows.DependencyObject;
			if (dependencyObject == null || global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject) == this)
			{
				base.RemoveLogicalChild(child);
			}
			if (this._logicalChildren.Contains(child))
			{
				this._logicalChildren.Remove(child);
			}
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0003FCA8 File Offset: 0x0003DEA8
		internal bool InternalSelectItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			if (item != null && !item.IsSelectable)
			{
				if (clearExistingSelection)
				{
					this.ClearSelectedItemsOfType(item);
				}
				return false;
			}
			if (!clearExistingSelection && select && item.IsSelected && this._selectedItems != null && this.SelectedItems.IsItemInCollection(item))
			{
				return true;
			}
			if (!clearExistingSelection && !this.IsItemSelectableWithCurrentSelection(item))
			{
				this.SelectedItems.ClearItemsOfType(item);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = this.CalculateNewSelection(item, clearExistingSelection, select);
			if (this._selectedItems != null && this._selectedItems != null && item != null && this._selectedItems.IsSelectionSameForItemType(item.GetType(), selectedItemHolder))
			{
				return true;
			}
			bool flag = !this.SelectNewSelection(item.GetType(), selectedItemHolder);
			return !flag;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x0003FD58 File Offset: 0x0003DF58
		internal bool InternalSelectRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected = this.CalculateNewSelectionRange(item, clearExistingSelection, select);
			bool flag = this.SelectNewSelection(item.GetType(), selected);
			return !flag;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x0003FD84 File Offset: 0x0003DF84
		internal void InvalidateFormatSettings()
		{
			this.EndEditMode(true, true);
			global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this.DefaultFieldLayout;
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (defaultFieldLayout != null)
			{
				defaultFieldLayout.OnCurrentViewChanged(true);
				defaultFieldLayout.Reset();
				global::System.Windows.Controls.Panel currentPanel = this.CurrentPanel;
				bool flag = defaultFieldLayout.IsInitialized;
				if (currentPanel != null)
				{
					currentPanel.InvalidateMeasure();
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator fieldLayoutTemplateGenerator = currentViewInternal.GetFieldLayoutTemplateGenerator(defaultFieldLayout);
					if (fieldLayoutTemplateGenerator != null)
					{
						defaultFieldLayout.Initialize(fieldLayoutTemplateGenerator);
						flag = false;
					}
				}
				if (flag)
				{
					defaultFieldLayout.InternalVersion++;
				}
				defaultFieldLayout.BumpSpecialRecordsVersion();
				if (this.FieldLayouts.Count > 1)
				{
					foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this.FieldLayouts)
					{
						if (fieldLayout != defaultFieldLayout)
						{
							fieldLayout.OnCurrentViewChanged(true);
							fieldLayout.BumpSpecialRecordsVersion();
							fieldLayout.Reset();
							global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator fieldLayoutTemplateGenerator2 = currentViewInternal.GetFieldLayoutTemplateGenerator(fieldLayout);
							if (fieldLayoutTemplateGenerator2 != null)
							{
								fieldLayout.Initialize(fieldLayoutTemplateGenerator2);
							}
						}
					}
				}
			}
			this.ResetGroupBySettings();
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0003FE88 File Offset: 0x0003E088
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool clearGroupBy)
		{
			this.InvalidateGeneratedStyles(bumpVersion, clearGroupBy, true);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0003FE94 File Offset: 0x0003E094
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool clearGroupBy, bool regenerateTemplates)
		{
			if (!this.HasFieldLayouts)
			{
				return;
			}
			if (clearGroupBy)
			{
				this.ClearGroupBy();
			}
			this.EndEditMode(true, true);
			this.ClearPendingActiveRecordPresenter();
			if (this._invalidateGeneratedStylesPending && this._invalidateTemplatesWithPendingGeneratedStyles != false)
			{
				regenerateTemplates = true;
			}
			bool value = regenerateTemplates || this._invalidateGeneratedStylesPending;
			this._invalidateTemplatesWithPendingGeneratedStyles = null;
			this._invalidateGeneratedStylesPending = false;
			this.FieldLayouts.InvalidateGeneratedStyles(bumpVersion, regenerateTemplates, false, new bool?(value));
			global::System.Windows.Controls.Panel currentPanel = this.CurrentPanel;
			if (currentPanel != null)
			{
				currentPanel.InvalidateMeasure();
				this.BumpRecordsInViewVersion();
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x0003FF38 File Offset: 0x0003E138
		internal void InvalidateGeneratedStylesAsync(bool invalidateTemplates = true)
		{
			if (!this._haveAnyTemplatesBeenGenerated)
			{
				return;
			}
			if (this._invalidateTemplatesWithPendingGeneratedStyles != true)
			{
				this._invalidateTemplatesWithPendingGeneratedStyles = new bool?(invalidateTemplates);
			}
			if (this._invalidateGeneratedStylesPending)
			{
				return;
			}
			if (this.IsSynchronousControl)
			{
				this.InvalidateGeneratedStyles(true, false, invalidateTemplates);
				return;
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnInvalidateGeneratedStyles));
			this._invalidateGeneratedStylesPending = true;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x0003FFB8 File Offset: 0x0003E1B8
		internal void InvalidateItemsHost()
		{
			global::System.Windows.Controls.Panel currentPanel = this.CurrentPanel;
			if (currentPanel != null)
			{
				currentPanel.InvalidateMeasure();
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0003FFD5 File Offset: 0x0003E1D5
		internal bool IsEventSuppressed(global::System.Windows.RoutedEvent routedEvent)
		{
			return this._suppressedEvents != null && this._suppressedEvents.IsEventSuppressed(routedEvent);
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x0003FFED File Offset: 0x0003E1ED
		internal bool IsInitializeRecordSuspendedFor(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this._initializeRecordSuspendedFor == record || (this._initializeRecordSuspendedFor_List != null && this._initializeRecordSuspendedFor_List.Contains(record));
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00040010 File Offset: 0x0003E210
		internal bool IsItemSelectableWithCurrentSelection(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null)
			{
				return this.SelectedItems.Records.Count < 1 || this.CurrentViewInternal.IsCrossLevelSelectionSupported || (this.SelectedItems.Records[0].FieldLayout == record.FieldLayout && record.NestingDepth == this.SelectedItems.Records[0].NestingDepth);
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = item as global::Infragistics.Windows.DataPresenter.Cell;
			if (cell != null)
			{
				return this.SelectedItems.Cells.Count < 1 || ((this.SelectedItems.Cells[0].Field.Owner == cell.Field.Owner || this.CurrentViewInternal.IsCrossLevelSelectionSupported) && global::Infragistics.Windows.DataPresenter.GridUtilities.IsAddRecordTemplate(this.SelectedItems.Cells[0].Record) == global::Infragistics.Windows.DataPresenter.GridUtilities.IsAddRecordTemplate(cell.Record) && (this.CurrentViewInternal.IsCrossLevelSelectionSupported || this.SelectedItems.Cells[0].Record.NestingDepth == cell.Record.NestingDepth));
			}
			global::Infragistics.Windows.DataPresenter.Field field = item as global::Infragistics.Windows.DataPresenter.Field;
			return field == null || this.SelectedItems.Fields.Count < 1 || this.SelectedItems.Fields[0].Owner == field.Owner;
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00040184 File Offset: 0x0003E384
		internal bool IsFixedFieldsSupportedResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.IsFixedFieldsSupported && currentViewInternal.HasLogicalOrientation;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x000401AC File Offset: 0x0003E3AC
		internal bool IsFixedRecordsSupportedResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.IsFixedRecordsSupported;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x000401CC File Offset: 0x0003E3CC
		internal bool IsFilterRecordSupportedResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.IsFilterRecordSupported;
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x000401EC File Offset: 0x0003E3EC
		internal bool IsOperationAllowed(global::Infragistics.Windows.DataPresenter.UIOperation operation)
		{
			if (this._cachedExportStatus == global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting)
			{
				return true;
			}
			switch (operation)
			{
			case global::Infragistics.Windows.DataPresenter.UIOperation.ClearCellContents:
			case global::Infragistics.Windows.DataPresenter.UIOperation.Edit:
			case global::Infragistics.Windows.DataPresenter.UIOperation.FieldGrouping:
			case global::Infragistics.Windows.DataPresenter.UIOperation.Paste:
			case global::Infragistics.Windows.DataPresenter.UIOperation.RecordResizing:
			case global::Infragistics.Windows.DataPresenter.UIOperation.RecordFixing:
			case global::Infragistics.Windows.DataPresenter.UIOperation.RecordFiltering:
			case global::Infragistics.Windows.DataPresenter.UIOperation.RecordExpandCollapse:
			case global::Infragistics.Windows.DataPresenter.UIOperation.DeleteRecord:
			case global::Infragistics.Windows.DataPresenter.UIOperation.Undo:
				return false;
			case global::Infragistics.Windows.DataPresenter.UIOperation.FieldMoving:
			case global::Infragistics.Windows.DataPresenter.UIOperation.FieldFixing:
			case global::Infragistics.Windows.DataPresenter.UIOperation.FieldVisibility:
			case global::Infragistics.Windows.DataPresenter.UIOperation.FieldResizing:
			case global::Infragistics.Windows.DataPresenter.UIOperation.FieldAutoSizing:
			case global::Infragistics.Windows.DataPresenter.UIOperation.FieldSorting:
			case global::Infragistics.Windows.DataPresenter.UIOperation.FieldSummaries:
				return this._cachedExportStatus == global::Infragistics.Windows.DataPresenter.RecordExportStatus.Exporting;
			default:
				return true;
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00040260 File Offset: 0x0003E460
		internal bool OnActiveRecordChange(global::Infragistics.Windows.DataPresenter.Record newActiveRecord, bool scrollIntoView)
		{
			if (newActiveRecord == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs recordActivatingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs(newActiveRecord);
			this.RaiseRecordActivating(recordActivatingEventArgs);
			if (recordActivatingEventArgs.Cancel)
			{
				return false;
			}
			this._activeRecord = newActiveRecord;
			if (this._activeRecord != null)
			{
				this._activeRecord.OnActiveRecordChanged();
				if (this._activeRecord == null)
				{
					return false;
				}
			}
			global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs(newActiveRecord);
			this.RaiseRecordActivated(args);
			if (this._activeRecord != null)
			{
				if (scrollIntoView)
				{
					this.BringRecordIntoView(this._activeRecord);
					base.UpdateLayout();
					if (this._activeRecord == null)
					{
						return false;
					}
				}
				global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = this._activeRecord.AssociatedRecordPresenter;
				if (associatedRecordPresenter != null && associatedRecordPresenter.IsVisible)
				{
					associatedRecordPresenter.FocusIfAppropriate();
				}
				if (this._activeRecord != null)
				{
					global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
					if (viewPanel != null)
					{
						viewPanel.OnActiveRecordChanged(this._activeRecord);
					}
				}
			}
			return true;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00040324 File Offset: 0x0003E524
		internal bool OnActiveRecordCleared(bool update)
		{
			if (!this.ClearActiveCell())
			{
				return false;
			}
			if (this._activeRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.Record activeRecord = this._activeRecord;
				if (activeRecord != null)
				{
					global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs recordDeactivatingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs(this._activeRecord);
					this.RaiseRecordDeactivating(recordDeactivatingEventArgs);
					if (recordDeactivatingEventArgs.Cancel)
					{
						return false;
					}
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = activeRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null && dataRecord.IsDataChanged && this.UpdateMode != global::Infragistics.Windows.DataPresenter.UpdateMode.OnUpdate && !dataRecord.Update())
					{
						return false;
					}
				}
				global::Infragistics.Windows.DataPresenter.Record activeRecord2 = this._activeRecord;
				this._activeRecord = null;
				if (activeRecord2 != null)
				{
					activeRecord2.OnActiveRecordChanged();
				}
				this.ProcessRecordWithPendingFilterHelper(activeRecord2);
			}
			return true;
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000403AE File Offset: 0x0003E5AE
		internal void OnAfterApplyCustomizations()
		{
			this.InvalidateGeneratedStylesAsync(false);
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000403B7 File Offset: 0x0003E5B7
		internal void OnBeforeApplyCustomizations()
		{
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000403B9 File Offset: 0x0003E5B9
		internal void OnCurrentRecordListControlSelectionChanged(object sender, global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (e.AddedItems.Count == 1)
			{
				this.SetActiveRecord(e.AddedItems[0] as global::Infragistics.Windows.DataPresenter.Record, false);
				return;
			}
			if (e.RemovedItems.Count == 1)
			{
				this.SetActiveRecord(null, false);
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000403F8 File Offset: 0x0003E5F8
		internal void OnAutoSizeAllRecordsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fl, bool hasAllRecords)
		{
			this._fieldLayoutAutoSizeAllRecordsCount += (hasAllRecords ? 1 : -1);
			if (!hasAllRecords)
			{
				this.ResetAllRecordsAutoSizeMaxDepth();
				return;
			}
			this._allRecordsAutoSizeMaxDepth = global::System.Math.Max(this._allRecordsAutoSizeMaxDepth, fl.MaxRecordManagerDepth);
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x0004042F File Offset: 0x0003E62F
		internal void OnAutoSizePending(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (this._fieldLayoutsAutoSizePending == null)
			{
				this._fieldLayoutsAutoSizePending = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>();
			}
			this._fieldLayoutsAutoSizePending.Add(fieldLayout);
			if (!this._processingFieldAutoSize && this._pendingFieldAutoSize == null)
			{
				this.SetupAsyncAutoSize();
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00040466 File Offset: 0x0003E666
		internal void OnFieldLayoutTemplateGeneration()
		{
			this._haveAnyTemplatesBeenGenerated = true;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0004046F File Offset: 0x0003E66F
		internal void OnFormatSettingsInvalidated()
		{
			if (this.DefaultFieldLayout == null)
			{
				return;
			}
			this.InvalidateFormatSettings();
			this.ClearGroupBy();
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00040488 File Offset: 0x0003E688
		internal void OnIsFocusWithinChanged(bool gotFocus)
		{
			if (!gotFocus)
			{
				this.EndEditMode(true, !base.IsVisible);
				switch (this.UpdateMode)
				{
				case global::Infragistics.Windows.DataPresenter.UpdateMode.OnRecordChangeOrLostFocus:
				case global::Infragistics.Windows.DataPresenter.UpdateMode.OnCellChangeOrLostFocus:
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null && dataRecord.IsDataChangedSinceLastCommitAttempt)
					{
						dataRecord.Update();
						return;
					}
					break;
				}
				case global::Infragistics.Windows.DataPresenter.UpdateMode.OnRecordChange:
					break;
				default:
					return;
				}
			}
			else
			{
				global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this);
				if (focusScope != null && global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) == this)
				{
					global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = (activeCell != null) ? activeCell.AssociatedCellValuePresenter : null;
					if (cellValuePresenter != null)
					{
						cellValuePresenter.FocusIfAppropriate(!cellValuePresenter.IsInEditMode);
						return;
					}
					global::Infragistics.Windows.DataPresenter.Record activeRecord = this.ActiveRecord;
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = (activeRecord != null) ? activeRecord.AssociatedRecordPresenter : null;
					if (recordPresenter != null)
					{
						recordPresenter.FocusIfAppropriate();
					}
				}
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00040541 File Offset: 0x0003E741
		internal bool OnRecordExpandStateChanged(global::Infragistics.Windows.DataPresenter.Record record, bool isExpanded)
		{
			return this.OnRecordExpandStateChanged(record, isExpanded, false);
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x0004054C File Offset: 0x0003E74C
		internal bool OnRecordExpandStateChanged(global::Infragistics.Windows.DataPresenter.Record record, bool isExpanded, bool addToUndo)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = (addToUndo && this.IsUndoEnabled) ? new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>() : null;
			bool flag = this.OnRecordExpandStateChanged(record, isExpanded, list);
			if (flag && list != null)
			{
				this.History.AddUndoActionInternal(new global::Infragistics.Windows.DataPresenter.RecordExpansionAction(list, !isExpanded));
			}
			return flag;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00040594 File Offset: 0x0003E794
		internal bool OnRecordExpandStateChanged(global::Infragistics.Windows.DataPresenter.Record record, bool isExpanded, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> recordsChanged)
		{
			if (isExpanded)
			{
				global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs recordExpandingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs(record);
				this.RaiseRecordExpanding(recordExpandingEventArgs);
				if (recordExpandingEventArgs.Cancel)
				{
					return false;
				}
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
				if (activeCell != null && activeCell.IsInEditMode && activeCell.Record != null && record.IsTrivialAncestorOf(activeCell.Record))
				{
					activeCell.EndEditMode(true, false);
					if (activeCell.IsInEditMode)
					{
						return false;
					}
				}
				global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs recordCollapsingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs(record);
				this.RaiseRecordCollapsing(recordCollapsingEventArgs);
				if (recordCollapsingEventArgs.Cancel)
				{
					return false;
				}
			}
			record.SetIsExpanded(isExpanded, recordsChanged);
			if (record.IsExpanded != isExpanded)
			{
				return false;
			}
			if (isExpanded)
			{
				global::Infragistics.Windows.DataPresenter.Events.RecordExpandedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.RecordExpandedEventArgs(record);
				this.RaiseRecordExpanded(args);
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs args2 = new global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs(record);
				this.RaiseRecordCollapsed(args2);
			}
			return true;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00040648 File Offset: 0x0003E848
		internal void OnRootCollectionChanged()
		{
			if (base.CheckAccess())
			{
				base.CoerceValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalProperty);
				this._asyncChangePending = null;
				return;
			}
			if (this.IsSynchronousControl)
			{
				this.OnRootCollectionChanged();
				return;
			}
			if (this._asyncChangePending == null)
			{
				this._asyncChangePending = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnRootCollectionChanged));
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00040704 File Offset: 0x0003E904
		internal void OnRootFilterCriteriaChanged()
		{
			if (this._pendingFilterCriteriaChanged == null && this.IsTreeView && base.IsInitialized)
			{
				this._pendingFilterCriteriaChanged = base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					this._pendingFilterCriteriaChanged = null;
					bool flag = this._treeFilterManager != null;
					if (flag)
					{
						this._treeFilterManager.Stop();
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this.DefaultFieldLayout;
					if (defaultFieldLayout != null)
					{
						global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection recordFiltersResolvedIfAllocated = this.RecordManager.RecordFiltersResolvedIfAllocated;
						if (flag || (recordFiltersResolvedIfAllocated != null && recordFiltersResolvedIfAllocated.HasActiveFilters(defaultFieldLayout)))
						{
							this.StartAsyncTreeFilterManager(true);
						}
					}
				}), global::System.Windows.Threading.DispatcherPriority.Send, new object[0]);
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00040794 File Offset: 0x0003E994
		private void ProcessLayoutUpdatedCallbackList(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.ProcessLayoutUpdatedCallbackList;
			if (this._layoutUpdatedCallbacks != null && this._layoutUpdatedCallbacks.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate[] array = this._layoutUpdatedCallbacks.ToArray<global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate>();
				this._layoutUpdatedCallbacks.Clear();
				global::System.Comparison<global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate> comparison = delegate(global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate d1, global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate d2)
				{
					if (d1 == null)
					{
						if (d2 != null)
						{
							return -1;
						}
						return 0;
					}
					else
					{
						if (d2 == null)
						{
							return 1;
						}
						if (d1.Target != d2.Target)
						{
							if (d1.Target is global::Infragistics.Windows.DataPresenter.DataPresenterBase)
							{
								return 1;
							}
							if (d2.Target is global::Infragistics.Windows.DataPresenter.DataPresenterBase)
							{
								return -1;
							}
						}
						return 0;
					}
				};
				global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate>(array, global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate>(comparison));
				foreach (global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate methodDelegate in array)
				{
					methodDelegate();
				}
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00040829 File Offset: 0x0003EA29
		internal bool ProcessPendingTreeViewFilterManager(int maxTicksPerSlice)
		{
			return this._treeFilterManager != null && this._treeFilterManager.IsActive && this._treeFilterManager.ProcessRecords(maxTicksPerSlice);
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00040850 File Offset: 0x0003EA50
		internal void ProcessRecordWithPendingFilterHelper(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.Record activeRecordWithPendingDirtyFilterState = this._activeRecordWithPendingDirtyFilterState;
			if (activeRecordWithPendingDirtyFilterState != null && (activeRecordWithPendingDirtyFilterState == record || record == null))
			{
				this._activeRecordWithPendingDirtyFilterState = null;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = activeRecordWithPendingDirtyFilterState.FieldLayout;
				if (fieldLayout != null && fieldLayout.ReevaluateFiltersOnDataChangeResolved)
				{
					activeRecordWithPendingDirtyFilterState.DirtyFilterState();
				}
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x0004088D File Offset: 0x0003EA8D
		internal void QueueNestedContentInitializationRequest(global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			if (this._recordsPendingNestedContentInitialization == null)
			{
				this._recordsPendingNestedContentInitialization = new global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.RecordPresenter>();
			}
			if (this._recordsPendingNestedContentInitialization.Count == 0)
			{
				this.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
			}
			this._recordsPendingNestedContentInitialization.Enqueue(rp);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x000408CD File Offset: 0x0003EACD
		internal void RemoveStatusControl(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl)
		{
			if (ctrl != null && this._dataAreaGrid != null && global::System.Windows.Media.VisualTreeHelper.GetParent(ctrl) == this._dataAreaGrid)
			{
				this._dataAreaGrid.Children.Remove(ctrl);
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x000408F9 File Offset: 0x0003EAF9
		internal void ResetAllRecordsAutoSizeMaxDepth()
		{
			this._allRecordsAutoSizeMaxDepth = -2;
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00040904 File Offset: 0x0003EB04
		internal void ResetGroupBySettings()
		{
			if (this.FieldLayouts != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout in this.FieldLayouts)
				{
					if (fieldLayout.HasGroupBySortFields)
					{
						fieldLayout.SortedFields.Clear();
					}
				}
			}
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x00040968 File Offset: 0x0003EB68
		internal void ResetItemsPanel()
		{
			global::System.Windows.Controls.Panel currentPanel = this.CurrentPanel;
			if (currentPanel != null)
			{
				currentPanel.InvalidateMeasure();
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.SetPanelSettings(this._currentRecordListControl, null);
			}
			if (this.DefaultFieldLayout != null)
			{
				this.DefaultFieldLayout.Reset();
			}
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x000409A4 File Offset: 0x0003EBA4
		internal void ResumeEndEditOnScroll()
		{
			this._endEditOnScrollSuspendCount--;
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000409B4 File Offset: 0x0003EBB4
		internal void ResumeInitializeRecordFor(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == this._initializeRecordSuspendedFor)
			{
				this._initializeRecordSuspendedFor = null;
				if (this._initializeRecordSuspendedFor_List != null)
				{
					int num = this._initializeRecordSuspendedFor_List.Count - 1;
					if (num >= 0)
					{
						this._initializeRecordSuspendedFor = this._initializeRecordSuspendedFor_List[num];
						this._initializeRecordSuspendedFor_List.RemoveAt(num);
					}
					if (num == 0)
					{
						this._initializeRecordSuspendedFor_List = null;
						return;
					}
				}
			}
			else if (this._initializeRecordSuspendedFor_List != null)
			{
				this._initializeRecordSuspendedFor_List.Remove(record);
				if (this._initializeRecordSuspendedFor_List.Count == 0)
				{
					this._initializeRecordSuspendedFor_List = null;
				}
			}
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x00040A40 File Offset: 0x0003EC40
		internal bool SelectNewSelection(global::System.Type type, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected)
		{
			this._typeBeingSelected = type;
			try
			{
				if (this.ActiveCell != null && !this.ActiveCell.EndEditMode())
				{
					return false;
				}
			}
			finally
			{
				this._typeBeingSelected = null;
			}
			global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs selectedItemsChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs(type, selected);
			this.RaiseSelectedItemsChanging(selectedItemsChangingEventArgs);
			if (selectedItemsChangingEventArgs.Cancel)
			{
				return false;
			}
			this.UpdateSelectedItems(selected);
			global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs(type);
			this.RaiseSelectedItemsChanged(args);
			return true;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00040AB8 File Offset: 0x0003ECB8
		private void SetActiveCell(global::Infragistics.Windows.DataPresenter.Cell newValue)
		{
			base.VerifyAccess();
			if (newValue == this._activeCell)
			{
				return;
			}
			if (newValue != null)
			{
				if (newValue.Record == null)
				{
					return;
				}
				if (newValue.Record.DataPresenter != this)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_9"));
				}
			}
			if (newValue != null && newValue.Record != this.ActiveRecord)
			{
				this.ActiveRecord = newValue.Record;
				if (this.ActiveRecord != newValue.Record)
				{
					this._activeCell = this.ActiveCell;
					return;
				}
			}
			this._recordOrCellBeingActivated = newValue;
			try
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this._activeCell;
				if (activeCell != null)
				{
					this.ClearActiveCell(this._forceClearActiveRecord, true);
					if (this._activeCell != null)
					{
						return;
					}
				}
				if (newValue != null)
				{
					global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs cellActivatingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs(newValue);
					this.RaiseCellActivating(cellActivatingEventArgs);
					if (cellActivatingEventArgs.Cancel)
					{
						if (this._activeCell != activeCell && activeCell != null)
						{
							activeCell.OnActiveCellChanged();
						}
						return;
					}
				}
				this._activeCell = newValue;
				if (this._activeCell != null)
				{
					if (this._activeRecord == null || this._activeRecord != this._activeCell.Record)
					{
						this._activeCell = null;
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = this._activeRecord.AssociatedRecordPresenter;
						if (associatedRecordPresenter != null)
						{
							global::Infragistics.Windows.DataPresenter.Field field = this._activeCell.Field;
							global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this._activeCell.Record, field);
							if (cellValuePresenter != null)
							{
								this._activeCell.AssociatedCellValuePresenterInternal = cellValuePresenter;
							}
						}
						if (this._activeCell != null)
						{
							this._activeCell.OnActiveCellChanged();
						}
					}
				}
				if (activeCell != null)
				{
					activeCell.OnActiveCellChanged();
				}
				if (this._activeCell != null)
				{
					global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs(this._activeCell);
					this.RaiseCellActivated(args);
				}
			}
			finally
			{
				this._recordOrCellBeingActivated = null;
			}
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00040C64 File Offset: 0x0003EE64
		internal void SetActiveRecord(global::Infragistics.Windows.DataPresenter.Record record, bool scrollIntoView)
		{
			base.VerifyAccess();
			if (record == this._activeRecord)
			{
				return;
			}
			if (record != null && !record.IsEnabledResolved)
			{
				return;
			}
			if (record == null && this._forceClearActiveRecord)
			{
				global::Infragistics.Windows.DataPresenter.Record activeRecord = this._activeRecord;
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this._activeCell;
				this._activeRecord = null;
				this._activeCell = null;
				if (activeCell != null)
				{
					activeCell.OnActiveCellChanged();
				}
				if (activeRecord != null)
				{
					activeRecord.OnActiveRecordChanged();
				}
				return;
			}
			if (record != null && record.DataPresenter != this)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_10"));
			}
			this._recordOrCellBeingActivated = record;
			try
			{
				if (this.OnActiveRecordCleared(true))
				{
					this.OnActiveRecordChange(record, scrollIntoView && !this._bypassScrollIntoView);
					if (this.IsSynchronizedWithCurrentItem)
					{
						if (record == null)
						{
							this.RecordManager.SetCurrentItemFromActiveRecord();
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord) ? (record as global::Infragistics.Windows.DataPresenter.DataRecord) : record.ParentDataRecord;
							global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.DataRecord> stack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.DataRecord>();
							while (dataRecord != null)
							{
								stack.Push(dataRecord);
								dataRecord = dataRecord.ParentDataRecord;
							}
							bool flag = true;
							if (stack.Count == 0)
							{
								this.RecordManager.SetCurrentItemFromActiveRecord();
							}
							else
							{
								while (stack.Count > 0)
								{
									dataRecord = stack.Pop();
									global::Infragistics.Windows.DataPresenter.RecordManager recordManager = dataRecord.RecordManager;
									if (!recordManager.SetCurrentItemFromActiveRecord())
									{
										break;
									}
									if (flag)
									{
										flag = false;
									}
									else if (recordManager.IsCollectionView)
									{
										bool flag2 = false;
										if (this._nonRootCurrencyTrackingManagers == null)
										{
											this._nonRootCurrencyTrackingManagers = new global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.RecordManager>();
										}
										else
										{
											flag2 = this._nonRootCurrencyTrackingManagers.Contains(recordManager);
										}
										if (!flag2)
										{
											recordManager.WireCollectionViewEvents();
											this._nonRootCurrencyTrackingManagers.Add(recordManager);
										}
									}
								}
							}
						}
					}
					if (this._nonRootCurrencyTrackingManagers != null && this._nonRootCurrencyTrackingManagers.Count > 0)
					{
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager> list = null;
						foreach (global::Infragistics.Windows.DataPresenter.RecordManager recordManager2 in this._nonRootCurrencyTrackingManagers)
						{
							if (!recordManager2.IsInActiveRecordChain)
							{
								if (list == null)
								{
									list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager>();
								}
								list.Add(recordManager2);
							}
						}
						if (list != null)
						{
							int count = list.Count;
							for (int i = 0; i < count; i++)
							{
								global::Infragistics.Windows.DataPresenter.RecordManager recordManager3 = list[i];
								this._nonRootCurrencyTrackingManagers.Remove(recordManager3);
								recordManager3.UnwireCollectionViewEvents();
							}
						}
					}
				}
			}
			finally
			{
				this._recordOrCellBeingActivated = null;
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00040ED0 File Offset: 0x0003F0D0
		internal static bool SetDefaultValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Windows.FrameworkElement target, global::System.Windows.DependencyProperty targetProperty, global::System.Windows.DependencyProperty sourceProperty, bool extractTargetPropifSourceNotFound)
		{
			global::System.Windows.Style style;
			if (dp != null)
			{
				style = (dp.GetDefaultResource(target.GetType(), false) as global::System.Windows.Style);
			}
			else
			{
				style = (global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetGenericResource(target.GetType()) as global::System.Windows.Style);
			}
			bool flag = false;
			if (style != null)
			{
				flag = global::Infragistics.Windows.Utilities.SetPropertyFromStyle(target, targetProperty, style, sourceProperty, true);
				if (!flag && extractTargetPropifSourceNotFound)
				{
					flag = global::Infragistics.Windows.Utilities.SetPropertyFromStyle(target, targetProperty, style, targetProperty, true);
				}
			}
			return flag;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00040F2C File Offset: 0x0003F12C
		internal void SetFieldDragManagerHelper(global::Infragistics.Windows.DataPresenter.FieldDragManager fieldDragManager)
		{
			this._fieldDragManager = fieldDragManager;
			global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser> registeredFieldChoosers = this._registeredFieldChoosers;
			if (registeredFieldChoosers != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser in registeredFieldChoosers)
				{
					fieldChooser.UpdateIsDraggingItemFromDataPresenter();
				}
			}
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00040F84 File Offset: 0x0003F184
		internal bool StartFieldDragHelper(global::Infragistics.Windows.DataPresenter.Field field, global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.Source as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = (dependencyObject != null) ? ((global::Infragistics.Windows.DataPresenter.LabelPresenter)global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true)) : null;
			if (labelPresenter == null)
			{
				dependencyObject = (base.InputHitTest(e.GetPosition(this)) as global::System.Windows.DependencyObject);
				labelPresenter = ((dependencyObject != null) ? ((global::Infragistics.Windows.DataPresenter.LabelPresenter)global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter), true)) : null);
			}
			return labelPresenter != null && labelPresenter.Field == field && labelPresenter.StartDragHelper(e, false);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00041006 File Offset: 0x0003F206
		internal void SuspendEndEditOnScroll()
		{
			this._endEditOnScrollSuspendCount++;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00041018 File Offset: 0x0003F218
		internal bool SuspendInitializeRecordFor(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (this._initializeRecordSuspendedFor == null)
			{
				this._initializeRecordSuspendedFor = record;
			}
			else
			{
				if (record == this._initializeRecordSuspendedFor)
				{
					return true;
				}
				if (this._initializeRecordSuspendedFor_List == null)
				{
					this._initializeRecordSuspendedFor_List = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				}
				else if (this._initializeRecordSuspendedFor_List.Contains(record))
				{
					return true;
				}
				this._initializeRecordSuspendedFor_List.Add(this._initializeRecordSuspendedFor);
				this._initializeRecordSuspendedFor = record;
			}
			return false;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00041080 File Offset: 0x0003F280
		internal void ToggleFocusAsync()
		{
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
			if (activeCell != null && activeCell.IsInEditMode)
			{
				int? num = null;
				int? num2 = null;
				global::System.Windows.Controls.TextBox activeCellTextBoxWithFocus = this.GetActiveCellTextBoxWithFocus();
				if (activeCellTextBoxWithFocus != null)
				{
					num = new int?(activeCellTextBoxWithFocus.SelectionStart);
					num2 = new int?(activeCellTextBoxWithFocus.SelectionLength);
				}
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RefocusActiveCellDelegate(this.RefocusActiveCell), num, new object[]
				{
					num2
				});
				base.Focus();
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00041110 File Offset: 0x0003F310
		internal global::System.Windows.Controls.Panel VerifyCurrentPanel()
		{
			if (this._currentRecordListControl == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings panelSettings = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetPanelSettings(this._currentRecordListControl);
			global::System.Windows.Controls.Panel panel = this._currentRecordListControl.Panel;
			if (panel != null)
			{
				if (panelSettings != null && panelSettings.Panel == panel)
				{
					return panel;
				}
				if (panel != null)
				{
					this.CachePanelSettings(panel, this._currentRecordListControl);
				}
			}
			return panel;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00041164 File Offset: 0x0003F364
		internal void VerifyCurrentPanel(object item, global::System.Windows.DependencyObject container)
		{
			if (this.CurrentPanel != null)
			{
				return;
			}
			global::System.Windows.Media.Visual visual = container as global::System.Windows.Media.Visual;
			if (visual == null)
			{
				visual = (item as global::System.Windows.Media.Visual);
			}
			global::System.Windows.Controls.Panel panel = null;
			if (visual != null)
			{
				panel = (global::Infragistics.Windows.Utilities.GetItemsHostFromItem(visual) as global::System.Windows.Controls.Panel);
			}
			if (panel != null)
			{
				global::System.Windows.Controls.ItemsControl itemsOwner = global::System.Windows.Controls.ItemsControl.GetItemsOwner(panel);
				if (itemsOwner != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings panelSettings = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetPanelSettings(itemsOwner);
					if (panelSettings == null || panelSettings.Panel == null)
					{
						this.CachePanelSettings(panel, itemsOwner);
					}
				}
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000411C8 File Offset: 0x0003F3C8
		internal void VerifyInternalRecords()
		{
			if (this.CurrentViewInternal == null)
			{
				return;
			}
			bool isFlatView = this.IsFlatView;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			if (!isFlatView)
			{
				base.SetBinding(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InternalRecordsProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ViewableRecordsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
				return;
			}
			global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatScrollRecordsCollection = this.InternalRecords as global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
			if (flatScrollRecordsCollection != null && flatScrollRecordsCollection.RecordManager == recordManager)
			{
				return;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InternalRecordsProperty, new global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection(recordManager));
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0004123C File Offset: 0x0003F43C
		internal bool VerifyOperationIsAllowed(global::System.Windows.RoutedEventArgs args)
		{
			global::Infragistics.Windows.DataPresenter.UIOperation operation;
			if (args is global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs)
			{
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.Edit;
			}
			else if (args is global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs)
			{
				global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs fieldPositionChangingEventArgs = args as global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs;
				switch (fieldPositionChangingEventArgs.ChangeReason)
				{
				case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Moved:
					operation = global::Infragistics.Windows.DataPresenter.UIOperation.FieldMoving;
					break;
				case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Fixed:
				case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Unfixed:
					operation = global::Infragistics.Windows.DataPresenter.UIOperation.FieldFixing;
					break;
				case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Hidden:
				case global::Infragistics.Windows.DataPresenter.FieldPositionChangeReason.Displayed:
					operation = global::Infragistics.Windows.DataPresenter.UIOperation.FieldVisibility;
					break;
				default:
					return true;
				}
			}
			else if (args is global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs)
			{
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.FieldGrouping;
			}
			else if (args is global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs)
			{
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.DeleteRecord;
			}
			else if (args is global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs)
			{
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.RecordFixing;
			}
			else if (args is global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs)
			{
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.RecordFiltering;
			}
			else if (args is global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs || args is global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs)
			{
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.RecordExpandCollapse;
			}
			else if (args is global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs)
			{
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.FieldSummaries;
			}
			else if (args is global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs)
			{
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.FieldSorting;
			}
			else
			{
				if (!(args is global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs))
				{
					return true;
				}
				operation = global::Infragistics.Windows.DataPresenter.UIOperation.Paste;
			}
			if (this.VerifyOperationIsAllowed(operation))
			{
				return true;
			}
			global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs cancelableRoutedEventArgs = args as global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs;
			if (cancelableRoutedEventArgs != null)
			{
				cancelableRoutedEventArgs.Cancel = true;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs editModeStartingEventArgs = args as global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs;
				if (editModeStartingEventArgs != null)
				{
					editModeStartingEventArgs.Cancel = true;
				}
			}
			return false;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0004133C File Offset: 0x0003F53C
		internal bool VerifyOperationIsAllowed(global::Infragistics.Windows.DataPresenter.UIOperation operation)
		{
			if (this.IsOperationAllowed(operation))
			{
				return true;
			}
			string name = "UIOperation_" + operation.ToString();
			string @string = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ExportOperationDisabled_Message", new object[]
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(name)
			});
			string string2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ExportOperationDisabled_Title");
			global::System.Windows.MessageBox.Show(@string, string2, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
			return false;
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000413A0 File Offset: 0x0003F5A0
		internal void VerifyRecordManagerDataSource()
		{
			if (!base.IsInitialized && (!this.IsExportControl || this.IsReportControl))
			{
				return;
			}
			if (this.RecordManager.DataSource == null && this._hadApplicationCurrent && global::System.Windows.Application.Current == null)
			{
				return;
			}
			if (this.DataSource == null && this._dataItems != null && this._dataItems.Count > 0)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalPropertyKey, this._dataItems);
			}
			this.RecordManager.DataSource = (this.DataSourceInternal as global::System.Collections.IEnumerable);
			if (this._treeFilterManager != null)
			{
				this._treeFilterManager.Stop();
			}
			if (this.RecordManager.DataSource != null)
			{
				this._isRecordManagerDataSourceInitialized = true;
				this.StartAsyncTreeFilterManager(false);
			}
			global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(this, this, "DataSource", null);
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00041464 File Offset: 0x0003F664
		internal void WireLayoutUpdated(global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate callback)
		{
			if (this._layoutUpdatedCallbacks == null)
			{
				this._layoutUpdatedCallbacks = new global::Infragistics.Windows.Helpers.HashSet();
			}
			int count = this._layoutUpdatedCallbacks.Count;
			this._layoutUpdatedCallbacks.Add(callback);
			if (count == 0)
			{
				base.LayoutUpdated += this.ProcessLayoutUpdatedCallbackList;
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000414B4 File Offset: 0x0003F6B4
		protected internal virtual global::System.Windows.Style GetRecordListControlStyle(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::System.Windows.Style style = null;
			if (fieldLayout != null && fieldLayout.HasSettings)
			{
				style = fieldLayout.Settings.RecordListControlStyle;
			}
			if (style != null && this.HasFieldLayoutSettings)
			{
				style = this.FieldLayoutSettings.RecordListControlStyle;
			}
			return base.FindResource(typeof(global::Infragistics.Windows.DataPresenter.RecordListControl)) as global::System.Windows.Style;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00041508 File Offset: 0x0003F708
		protected virtual bool OnReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					if (sender is global::Infragistics.Windows.DataPresenter.FieldLayoutSettings)
					{
						this.OnFieldLayoutSettingsPropertyChanged(sender, propertyChangedEventArgs);
					}
					else if (sender is global::Infragistics.Windows.DataPresenter.FieldSettings)
					{
						this.OnFieldSettingsPropertyChanged(sender, propertyChangedEventArgs);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00041558 File Offset: 0x0003F758
		protected internal virtual void OnSortCriteriaChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (base.IsLoaded)
			{
				this.OnProcessSortCriteria(fieldLayout);
				return;
			}
			if (!this.IsSynchronousControl)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.DataPresenter.DataPresenterBase.ProcessSortCriteria(this.OnProcessSortCriteria), fieldLayout);
				return;
			}
			if (!this.IsReportControl)
			{
				this.OnProcessSortCriteria(fieldLayout);
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x000415A8 File Offset: 0x0003F7A8
		private void AddToSelectedCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected, global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				selected.Records.InternalAdd(item as global::Infragistics.Windows.DataPresenter.Record);
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				selected.Cells.InternalAdd(item as global::Infragistics.Windows.DataPresenter.Cell);
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				selected.Fields.InternalAdd(item as global::Infragistics.Windows.DataPresenter.Field);
			}
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00041608 File Offset: 0x0003F808
		private void CachePanelSettings(global::System.Windows.Controls.Panel panel, global::System.Windows.Controls.ItemsControl ic)
		{
			if (panel == null || ic == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SetPanelSettings(ic, new global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings
			{
				Panel = panel
			});
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00041630 File Offset: 0x0003F830
		private void CalculateSelectionRange(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection, bool clearExistingSelection, bool select)
		{
			if (this._pivotCell == null || cell == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record record = cell.Record;
			global::Infragistics.Windows.DataPresenter.Record record2 = this._pivotCell.Record;
			if (record == null || record2 == null)
			{
				return;
			}
			bool isTreeView = this.IsTreeView;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator rangeSelectionEvaluator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator(this, this._pivotCell, cell, this._snaking);
			global::Infragistics.Windows.DataPresenter.SelectedRecordCollection recordsForSelection = this.GetRecordsForSelection(select, rangeSelectionEvaluator);
			global::Infragistics.Windows.DataPresenter.SelectedFieldCollection fieldsForSelection = this.GetFieldsForSelection(select, rangeSelectionEvaluator);
			if (isTreeView)
			{
				for (int i = 0; i < fieldsForSelection.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fieldsForSelection[i];
					if (field.Owner.IsDefault)
					{
						break;
					}
					if (!field.IsFieldMapped)
					{
						fieldsForSelection.RemoveAt(i);
						i--;
					}
				}
			}
			for (int j = 0; j < recordsForSelection.Count; j++)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = recordsForSelection[j] as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null)
				{
					for (int k = 0; k < fieldsForSelection.Count; k++)
					{
						global::Infragistics.Windows.DataPresenter.Field field2 = fieldsForSelection[k];
						if (rangeSelectionEvaluator.IsCellInRange(dataRecord, field2, false, false))
						{
							if (field2.Owner != dataRecord.FieldLayout)
							{
								field2 = dataRecord.FieldLayout.GetFieldFromMappedField(field2);
								if (field2 == null)
								{
									goto IL_12A;
								}
							}
							global::Infragistics.Windows.DataPresenter.Cell cell2 = dataRecord.Cells[field2];
							if (cell2 != null && ((global::Infragistics.Windows.Selection.ISelectableItem)cell2).IsSelectable)
							{
								newSelection.Cells.InternalAdd(cell2);
							}
						}
						IL_12A:;
					}
				}
			}
			if (!clearExistingSelection)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Cell cell3 in this.SelectionSnapshot.Cells)
				{
					if (!rangeSelectionEvaluator.IsCellInRange(cell3.Record, cell3.Field, !select, false))
					{
						newSelection.Cells.InternalAdd(cell3);
					}
				}
				newSelection.Fields.InternalAddRange(this.SelectedItems.Fields);
			}
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00041814 File Offset: 0x0003FA14
		private void CalculateSelectionRange(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection, bool clearExistingSelection, bool select)
		{
			if (this._pivotField == null)
			{
				((global::Infragistics.Windows.Selection.ISelectionHost)this).SetPivotItem(field, false);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator rangeSelectionEvaluator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator(this, this._pivotField, field, this._snaking);
			newSelection.Fields.InternalAddRange(this.GetFieldsForSelection(select, rangeSelectionEvaluator));
			if (!clearExistingSelection)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Field field2 in this.SelectionSnapshot.Fields)
				{
					if (!rangeSelectionEvaluator.IsFieldInRange(field2, !select, false))
					{
						newSelection.Fields.InternalAdd(field2);
					}
				}
				newSelection.Cells.InternalAddRange(this.SelectedItems.Cells);
				newSelection.Records.InternalAddRange(this.SelectedItems.Records);
			}
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x000418E4 File Offset: 0x0003FAE4
		private void CalculateSelectionRange(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection, bool clearExistingSelection, bool select)
		{
			this.VerifyPivots();
			if (this._pivotRecord == null)
			{
				((global::Infragistics.Windows.Selection.ISelectionHost)this).SetPivotItem(record, false);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator rangeSelectionEvaluator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator(this, this._pivotRecord, record, this._snaking);
			newSelection.Records.InternalAddRange(this.GetRecordsForSelection(select, rangeSelectionEvaluator));
			if (!clearExistingSelection)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record record2 in this.SelectionSnapshot.Records)
				{
					if (!rangeSelectionEvaluator.IsRecordInRange(record2, !select, false))
					{
						newSelection.Records.InternalAdd(record2);
					}
				}
				newSelection.Fields.InternalAddRange(this.SelectedItems.Fields);
			}
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x000419A4 File Offset: 0x0003FBA4
		private double CalculateScrollOffsetFactorInRecords(global::Infragistics.Windows.Selection.ScrollSpeed speed, double viewportExtent)
		{
			if (speed == global::Infragistics.Windows.Selection.ScrollSpeed.Fast)
			{
				return 2.0;
			}
			return 1.0;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x000419CC File Offset: 0x0003FBCC
		private double CalculateScrollOffsetFactorInPixels(global::Infragistics.Windows.Selection.ScrollSpeed speed, double viewportExtent)
		{
			switch (speed)
			{
			case global::Infragistics.Windows.Selection.ScrollSpeed.Slowest:
				return 2.0;
			case global::Infragistics.Windows.Selection.ScrollSpeed.Slower:
				return 8.0;
			case global::Infragistics.Windows.Selection.ScrollSpeed.Slow:
				return 16.0;
			case global::Infragistics.Windows.Selection.ScrollSpeed.Medium:
				return 30.0;
			case global::Infragistics.Windows.Selection.ScrollSpeed.Fast:
				return global::System.Math.Max(35.0, global::System.Math.Min(50.0, viewportExtent / 5.0));
			case global::Infragistics.Windows.Selection.ScrollSpeed.Faster:
				return global::System.Math.Max(40.0, global::System.Math.Min(100.0, viewportExtent / 4.0));
			}
			return global::System.Math.Max(50.0, global::System.Math.Min(200.0, viewportExtent / 3.0));
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00041AA0 File Offset: 0x0003FCA0
		private bool CanAutoSizeField(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Field field = commandInfo.Parameter as global::Infragistics.Windows.DataPresenter.Field;
			return field != null && field.AutoSizeOptionsResolved != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00041ACC File Offset: 0x0003FCCC
		private bool CanExecuteUndoCommand(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			if (!this.IsUndoEnabled)
			{
				commandInfo.ContinueRouting = true;
				return false;
			}
			if (this._history == null)
			{
				return false;
			}
			if (commandInfo.Command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Undo)
			{
				return this._history.CanUndo();
			}
			return commandInfo.Command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Redo && this._history.CanRedo();
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00041B28 File Offset: 0x0003FD28
		private static bool CanToggleIsExpanded(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Record record = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
			return null != record;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00041B44 File Offset: 0x0003FD44
		private static bool CanToggleCardCollapsedState(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Record record = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
			return null != record;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00041B60 File Offset: 0x0003FD60
		private static bool CanToggleEmptyCardCellsCollapsedState(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Record record = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
			return null != record;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00041B7C File Offset: 0x0003FD7C
		private void CommitChangesToRecord(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			if (record == null || !record.IsDataChanged)
			{
				return;
			}
			bool flag = record.IsAddRecord && !record.IsAddRecordTemplate;
			if (record.Update() && flag)
			{
				if (this._invalidateGeneratedStylesPending)
				{
					this.OnInvalidateGeneratedStyles();
				}
				base.UpdateLayout();
				global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
				if (viewPanel != null)
				{
					viewPanel.EnsureRecordIsVisible(record);
				}
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00041BE0 File Offset: 0x0003FDE0
		private void ConstrainFixedFieldMaxExtent(global::System.Windows.FrameworkElement resizableItem, global::Infragistics.Windows.Resizing.ResizeConstraints constraints, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel panel)
		{
			if (!field.IsFixed)
			{
				return;
			}
			bool isHorizontal = field.Owner.IsHorizontal;
			if (constraints.ResizeInXAxis == isHorizontal)
			{
				return;
			}
			if (isHorizontal)
			{
				if (field.Owner.IsAutoFitHeight)
				{
					return;
				}
			}
			else if (field.Owner.IsAutoFitWidth)
			{
				return;
			}
			double num = isHorizontal ? resizableItem.ActualHeight : resizableItem.ActualWidth;
			double num2 = isHorizontal ? panel.ScrollableAreaRect.Height : panel.ScrollableAreaRect.Width;
			double num3 = 0.0;
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(panel, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, this) as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter != null)
			{
				double num4 = isHorizontal ? panel.ActualHeight : panel.ActualWidth;
				double num5 = isHorizontal ? recordPresenter.ActualHeight : recordPresenter.ActualWidth;
				global::System.Windows.Controls.ScrollContentPresenter scrollContentPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(recordPresenter, typeof(global::System.Windows.Controls.ScrollContentPresenter), false, null, typeof(global::System.Windows.Controls.ScrollViewer)) as global::System.Windows.Controls.ScrollContentPresenter;
				if (scrollContentPresenter != null)
				{
					num5 = global::System.Math.Min(num5, isHorizontal ? scrollContentPresenter.ActualHeight : scrollContentPresenter.ActualWidth);
				}
				global::Infragistics.Windows.DataPresenter.Internal.TemplateDataRecordCache templateDataRecordCache = field.Owner.TemplateDataRecordCache;
				double virtPanelOffsetToRecordPresenter = templateDataRecordCache.GetVirtPanelOffsetToRecordPresenter(true, true);
				num3 = global::System.Math.Max(num5 - (num4 + virtPanelOffsetToRecordPresenter), 0.0);
			}
			double num6 = 8.0;
			constraints.MaxExtent = global::System.Math.Min(constraints.MaxExtent, global::System.Math.Max(num, num2 + num + num3 - num6));
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00041D58 File Offset: 0x0003FF58
		private void EnsureItemsWithinMaxSelectedItemsBounds(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = ((global::Infragistics.Windows.DataPresenter.Record)item).FieldLayout;
				int maxSelectedRecordsResolved = fieldLayout.MaxSelectedRecordsResolved;
				if (newSelection.Records.Count > maxSelectedRecordsResolved)
				{
					for (int i = newSelection.Records.Count - 1; i >= maxSelectedRecordsResolved; i--)
					{
						newSelection.Records.RemoveAt(i);
					}
					return;
				}
			}
			else if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = ((global::Infragistics.Windows.DataPresenter.Cell)item).Record.FieldLayout;
				int maxSelectedCellsResolved = fieldLayout2.MaxSelectedCellsResolved;
				if (newSelection.Cells.Count > maxSelectedCellsResolved)
				{
					for (int j = newSelection.Cells.Count - 1; j >= maxSelectedCellsResolved; j--)
					{
						newSelection.Cells.RemoveAt(j);
					}
				}
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00041E10 File Offset: 0x00040010
		private global::Infragistics.Windows.Selection.ISelectableItem FindNearesScrollableCompatibleRecord(bool isFixedOnTop, global::Infragistics.Windows.Selection.ISelectableItem item, ref global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			global::Infragistics.Windows.DataPresenter.Record record = rp.Record;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresentersInView = this.GetRecordPresentersInView(true, true, true, true);
			bool flag = false;
			int num = isFixedOnTop ? 0 : (recordPresentersInView.Count - 1);
			int num2 = isFixedOnTop ? recordPresentersInView.Count : -1;
			int num3 = isFixedOnTop ? 1 : -1;
			for (int num4 = num; num4 != num2; num4 += num3)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = recordPresentersInView[num4];
				if (flag)
				{
					global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedRecordLocationOverride = recordPresenter.Record.FixedRecordLocationOverride;
					if (fixedRecordLocationOverride != global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top && fixedRecordLocationOverride != global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom)
					{
						global::Infragistics.Windows.Selection.ISelectableItem record2 = recordPresenter.Record;
						if (record2 != null && record2.IsSelectable && this.IsItemSelectableWithCurrentSelection(record2))
						{
							rp = recordPresenter;
							if (item is global::Infragistics.Windows.DataPresenter.Record)
							{
								return rp.Record;
							}
							break;
						}
					}
				}
				else
				{
					flag = (recordPresenter == rp);
				}
			}
			return null;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00041ECC File Offset: 0x000400CC
		private global::System.Windows.Controls.TextBox GetActiveCellTextBoxWithFocus()
		{
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
			if (activeCell == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenterInternal = activeCell.AssociatedCellValuePresenterInternal;
			if (associatedCellValuePresenterInternal != null && associatedCellValuePresenterInternal.IsKeyboardFocusWithin)
			{
				global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Input.FocusManager.GetFocusedElement(global::System.Windows.Input.FocusManager.GetFocusScope(this)) as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					if (dependencyObject is global::System.Windows.Controls.TextBox)
					{
						return dependencyObject as global::System.Windows.Controls.TextBox;
					}
					return global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::System.Windows.Controls.TextBox), true, associatedCellValuePresenterInternal) as global::System.Windows.Controls.TextBox;
				}
			}
			return null;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00041F33 File Offset: 0x00040133
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> GetAllResizableFieldItems(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel panel, global::Infragistics.Windows.DataPresenter.Field field, bool isLabel, bool resizeInXAxis, bool autoSize)
		{
			return this.GetAllResizableFieldItems(panel.GetResizeLayoutManager(), field, isLabel, resizeInXAxis, autoSize);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00041F48 File Offset: 0x00040148
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> GetAllResizableFieldItems(global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager lm, global::Infragistics.Windows.DataPresenter.Field field, bool isLabel, bool resizeInXAxis, bool autoSize)
		{
			bool flag = !autoSize;
			bool flag2 = this.SelectedItems.HasFields && this.SelectedItems.Fields[0].Owner == field.Owner;
			bool isSelected = field.IsSelected;
			if (flag && (!isSelected || !flag2 || this.SelectedItems.Fields.Count == 1))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = lm.GetLayoutItem(field, isLabel);
			if (layoutItem == null)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase>();
			global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = lm.LayoutItems.GetConstraint(layoutItem) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint;
			int num = resizeInXAxis ? (gridBagConstraint.Column + gridBagConstraint.ColumnSpan) : (gridBagConstraint.Row + gridBagConstraint.RowSpan);
			global::Infragistics.Windows.DataPresenter.LayoutItemSize size = resizeInXAxis ? global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredWidth : global::Infragistics.Windows.DataPresenter.LayoutItemSize.PreferredHeight;
			bool flag3 = global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase.ShouldSynchronize(size, field);
			foreach (global::Infragistics.Windows.DataPresenter.Field field2 in field.Owner.Fields)
			{
				if (field2.IsInLayout && field2.AllowResizeResolved && (!autoSize || field2.AutoSizeOptionsResolved != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None) && (!isSelected || !flag2 || field2.IsSelected))
				{
					for (int i = 0; i < 2; i++)
					{
						bool flag4 = i == 0;
						global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem2 = lm.GetLayoutItem(field2, flag4);
						if (layoutItem2 != null)
						{
							if (flag)
							{
								if (layoutItem2 == layoutItem)
								{
									goto IL_1AF;
								}
								if (isLabel != flag4)
								{
									goto IL_1AF;
								}
							}
							else if (layoutItem2 != layoutItem)
							{
								global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint2 = lm.LayoutItems.GetConstraint(layoutItem2) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint;
								int num2 = resizeInXAxis ? (gridBagConstraint2.Column + gridBagConstraint2.ColumnSpan) : (gridBagConstraint2.Row + gridBagConstraint2.RowSpan);
								if (isSelected && field2.IsSelected)
								{
									if (!flag3 && isLabel != flag4 && num2 != num)
									{
										goto IL_1AF;
									}
								}
								else if (num2 != num)
								{
									goto IL_1AF;
								}
							}
							list.Add(layoutItem2);
						}
						IL_1AF:;
					}
				}
			}
			return list;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00042140 File Offset: 0x00040340
		private static global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel GetCellPanelForResize(global::System.Windows.FrameworkElement resizableItem, global::Infragistics.Windows.DataPresenter.Record recordToResize)
		{
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(resizableItem, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			if (virtualizingDataRecordCellPanel == null && recordToResize != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = recordToResize.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
				if (dataRecordPresenter != null)
				{
					virtualizingDataRecordCellPanel = dataRecordPresenter.AssociatedVirtualizingDataRecordCellPanel;
				}
			}
			return virtualizingDataRecordCellPanel;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00042184 File Offset: 0x00040384
		private global::Infragistics.Windows.Selection.ISelectableElement GetCompatibleSelectableElement(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.DependencyObject element)
		{
			if (element is global::Infragistics.Windows.Selection.ISelectableElement)
			{
				global::Infragistics.Windows.Selection.ISelectableItem selectableItem = (element as global::Infragistics.Windows.Selection.ISelectableElement).SelectableItem;
				if (!((global::Infragistics.Windows.Selection.ISelectionHost)this).IsItemSelectableWithCurrentSelection(selectableItem))
				{
					if (item is global::Infragistics.Windows.DataPresenter.Record && element is global::Infragistics.Windows.DataPresenter.RecordPresenter)
					{
						return null;
					}
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Record)
				{
					if (selectableItem is global::Infragistics.Windows.DataPresenter.Record)
					{
						return element as global::Infragistics.Windows.Selection.ISelectableElement;
					}
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Field)
				{
					if (selectableItem is global::Infragistics.Windows.DataPresenter.Field)
					{
						return element as global::Infragistics.Windows.Selection.ISelectableElement;
					}
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Cell && selectableItem is global::Infragistics.Windows.DataPresenter.Cell)
				{
					return element as global::Infragistics.Windows.Selection.ISelectableElement;
				}
			}
			if (element == this)
			{
				return null;
			}
			global::System.Windows.DependencyObject parent = global::Infragistics.Windows.Utilities.GetParent(element);
			if (parent == null)
			{
				return null;
			}
			return this.GetCompatibleSelectableElement(item, parent);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00042220 File Offset: 0x00040420
		private global::Infragistics.Windows.DataPresenter.RecordPresenter GetCompatibleRecordPresenter(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.DependencyObject element)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = element as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter == null)
			{
				recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(element as global::System.Windows.Media.Visual, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, this) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
			}
			if (recordPresenter != null && recordPresenter.Record != null)
			{
				if (item is global::Infragistics.Windows.DataPresenter.Record)
				{
					if (recordPresenter.Record.IsSiblingOf(item as global::Infragistics.Windows.DataPresenter.Record))
					{
						return recordPresenter;
					}
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Cell && recordPresenter.Record.IsSiblingOf((item as global::Infragistics.Windows.DataPresenter.Cell).Record))
				{
					return recordPresenter;
				}
			}
			return null;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00042744 File Offset: 0x00040944
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> GetCrossLevelRecordsInRange(global::Infragistics.Windows.DataPresenter.Record selectThruRecord, global::Infragistics.Windows.DataPresenter.Record pivotRcd, bool forward)
		{
			int step = forward ? 1 : -1;
			int nestingDepth = pivotRcd.NestingDepth;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel> ancestorList = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel>();
			global::Infragistics.Windows.DataPresenter.Record parent = pivotRcd;
			if (pivotRcd.HasChildren && pivotRcd.AreChildrenAfterParent == forward)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsInternal = pivotRcd.ChildRecordsInternal;
				if (childRecordsInternal != null)
				{
					ancestorList.Add(new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel(childRecordsInternal, forward));
				}
			}
			while (parent != null)
			{
				ancestorList.Add(new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel(parent));
				parent = parent.ParentRecord;
			}
			global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel> levelStack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel>();
			for (int i = ancestorList.Count - 1; i >= 0; i--)
			{
				levelStack.Push(ancestorList[i]);
			}
			bool selectThruRecordFound = false;
			while (levelStack.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel level = levelStack.Peek();
				level._currentIndex += step;
				while (!selectThruRecordFound && level._currentIndex >= 0 && level._currentIndex < level._siblings.Count)
				{
					global::Infragistics.Windows.DataPresenter.Record record = level._siblings[level._currentIndex];
					if (record is global::Infragistics.Windows.DataPresenter.DataRecord && record.VisibilityResolved != global::System.Windows.Visibility.Visible)
					{
						level._currentIndex += step;
					}
					else
					{
						bool hasChildren = record.HasChildren;
						if ((!hasChildren || record.AreChildrenAfterParent == forward) && record is global::Infragistics.Windows.DataPresenter.DataRecord)
						{
							yield return record;
							if (record == selectThruRecord)
							{
								goto IL_3D1;
							}
						}
						if (hasChildren)
						{
							global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsInternal2 = record.ChildRecordsInternal;
							if (childRecordsInternal2 != null && childRecordsInternal2.Count > 0)
							{
								global::Infragistics.Windows.DataPresenter.Record record2 = childRecordsInternal2[forward ? 0 : (childRecordsInternal2.Count - 1)];
								if (record2 != null)
								{
									level = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel(record2);
									levelStack.Push(level);
									continue;
								}
							}
						}
						selectThruRecordFound = (record == selectThruRecord);
						level._currentIndex += step;
					}
				}
				levelStack.Pop();
				if (levelStack.Count > 0)
				{
					level = levelStack.Peek();
					if (level._currentIndex >= 0 && level._currentIndex < level._siblings.Count)
					{
						global::Infragistics.Windows.DataPresenter.Record rcd = level._siblings[level._currentIndex];
						if (rcd is global::Infragistics.Windows.DataPresenter.DataRecord && rcd != pivotRcd)
						{
							bool returnChildrenFirst = rcd.AreChildrenAfterParent != forward;
							if (returnChildrenFirst)
							{
								yield return rcd;
								if (rcd == selectThruRecord)
								{
									break;
								}
							}
						}
					}
				}
			}
			IL_3D1:
			yield break;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00042918 File Offset: 0x00040B18
		private global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> GetCrossLevelVisibleRecordsInRange(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Record pivotRcd)
		{
			record.EnsureAncestorsAreExpanded();
			pivotRcd.EnsureAncestorsAreExpanded();
			int start = pivotRcd.OverallScrollPosition;
			int end = record.OverallScrollPosition;
			int step = (start < end) ? 1 : -1;
			int stopAt = end + step;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc = this.ViewableRecords;
			for (int i = start + step; i != stopAt; i += step)
			{
				yield return vrc.GetRecordAtScrollPosition(i);
			}
			yield break;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00042943 File Offset: 0x00040B43
		private global::System.Windows.Style GetDefaultStyle(global::System.Type type)
		{
			return null;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00042948 File Offset: 0x00040B48
		private static global::Infragistics.Windows.DataPresenter.Field GetFieldForRecordResize(global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager)
		{
			global::Infragistics.Windows.DataPresenter.Field result = null;
			int num = -1;
			int num2 = int.MaxValue;
			bool isHorizontal = layoutManager.FieldLayout.IsHorizontal;
			foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)layoutManager.LayoutItems))
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = layoutItem as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
				if (fieldLayoutItemBase != null && !fieldLayoutItemBase.IsLabel && ((global::Infragistics.Controls.Layouts.Primitives.ILayoutItem)fieldLayoutItemBase).Visibility != global::System.Windows.Visibility.Collapsed)
				{
					global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint gridBagConstraint = layoutManager.LayoutItems.GetConstraint(fieldLayoutItemBase) as global::Infragistics.Controls.Layouts.Primitives.IGridBagConstraint;
					int num3 = isHorizontal ? (gridBagConstraint.Column + gridBagConstraint.ColumnSpan) : (gridBagConstraint.Row + gridBagConstraint.RowSpan);
					int num4 = (!isHorizontal) ? gridBagConstraint.Column : gridBagConstraint.Row;
					if (num3 > num || (num3 == num && num4 < num2))
					{
						num = num3;
						num2 = num4;
						result = fieldLayoutItemBase.Field;
					}
				}
			}
			return result;
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x00042A3C File Offset: 0x00040C3C
		private global::Infragistics.Windows.DataPresenter.SelectedFieldCollection GetFieldsForSelection(bool select, global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator evaluator)
		{
			global::Infragistics.Windows.DataPresenter.SelectedFieldCollection selectedFieldCollection = new global::Infragistics.Windows.DataPresenter.SelectedFieldCollection(this);
			if (evaluator.IsRangeOfCells)
			{
				selectedFieldCollection.InternalAddRange(evaluator.PivotField.Owner.Fields);
				return selectedFieldCollection;
			}
			bool excludePivot = evaluator.IsRangeOfFields && !select;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in evaluator.PivotField.Owner.Fields)
			{
				if (evaluator.IsFieldInRange(field, excludePivot, false) && (evaluator.IsRangeOfCells || ((global::Infragistics.Windows.Selection.ISelectableItem)field).IsSelectable))
				{
					selectedFieldCollection.InternalAdd(field);
				}
			}
			return selectedFieldCollection;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00042AE8 File Offset: 0x00040CE8
		private static global::Infragistics.Windows.DataPresenter.FieldLayout GetFieldLayoutForSelectableItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				return (item as global::Infragistics.Windows.DataPresenter.Record).FieldLayout;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				return (item as global::Infragistics.Windows.DataPresenter.Cell).Record.FieldLayout;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				return (item as global::Infragistics.Windows.DataPresenter.Field).Owner;
			}
			return null;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00042B38 File Offset: 0x00040D38
		private double GetFirstItemExtentHelper(bool isWidth)
		{
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (!currentViewInternal.IsPanningModeSupported || !currentViewInternal.HasLogicalOrientation)
			{
				return 20.0;
			}
			if (isWidth)
			{
				if (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					return 20.0;
				}
			}
			else if (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
			{
				return 20.0;
			}
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
			if (viewPanel == null)
			{
				return 20.0;
			}
			global::Infragistics.Windows.DataPresenter.Record firstDisplayedRecord = viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord));
			if (firstDisplayedRecord == null)
			{
				firstDisplayedRecord = viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.Record));
				if (firstDisplayedRecord == null)
				{
					return 20.0;
				}
			}
			global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = firstDisplayedRecord.AssociatedRecordPresenter;
			if (associatedRecordPresenter != null)
			{
				double num = isWidth ? associatedRecordPresenter.ActualWidth : associatedRecordPresenter.ActualHeight;
				if (num == 0.0)
				{
					num = (isWidth ? associatedRecordPresenter.DesiredSize.Width : associatedRecordPresenter.DesiredSize.Height);
				}
				if (num < 10.0)
				{
					num = 20.0;
				}
				if (isWidth)
				{
					this._previousFirstItemWidth = num;
				}
				else
				{
					this._previousFirstItemHeight = num;
				}
				return num;
			}
			if (!isWidth)
			{
				return this._previousFirstItemHeight;
			}
			return this._previousFirstItemWidth;
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00042C68 File Offset: 0x00040E68
		private void GetGroupByAndDataAreaRows(ref int groupByAreaRow, ref int dataAreaRow)
		{
			if (this.GroupByAreaLocation == global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.BelowDataArea)
			{
				groupByAreaRow = 1;
				dataAreaRow = 0;
				return;
			}
			groupByAreaRow = 0;
			dataAreaRow = 1;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00042C80 File Offset: 0x00040E80
		private global::Infragistics.Windows.DataPresenter.Cell GetNavigationTargetCell(global::Infragistics.Windows.DataPresenter.Cell currentCell, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle)
		{
			if (currentCell == null)
			{
				throw new global::System.ArgumentNullException("currentRecord");
			}
			if (selectionHost == null)
			{
				throw new global::System.ArgumentNullException("selectionHost");
			}
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = selectionHost.GetSelectionStrategyForItem(currentCell);
			if (selectionStrategyForItem == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_4"));
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = currentCell.Record.FieldLayout;
			global::Infragistics.Windows.DataPresenter.GridFieldMap gridFieldMap;
			if (fieldLayout.UseCellPresenters)
			{
				gridFieldMap = fieldLayout.StyleGenerator.GridFieldMap;
			}
			else
			{
				gridFieldMap = currentCell.Record.FieldLayout.TemplateDataRecordCache.CellFieldMap;
			}
			global::Infragistics.Windows.DataPresenter.Cell navigationTargetCell = gridFieldMap.GetNavigationTargetCell(currentCell, navigationDirection, this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel, selectionHost, shiftKeyDown, ctlKeyDown, siblingNavigationStyle);
			if (navigationTargetCell != null && selectionStrategyForItem.CanItemBeNavigatedTo(navigationTargetCell, shiftKeyDown, ctlKeyDown))
			{
				return navigationTargetCell;
			}
			return null;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00042D2C File Offset: 0x00040F2C
		private global::Infragistics.Windows.DataPresenter.Cell GetNearestCompatibleCell(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point pt)
		{
			this.VerifyPivots();
			if (this._pivotCell == null)
			{
				return null;
			}
			if (!(item is global::Infragistics.Windows.DataPresenter.Cell))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record record;
			global::Infragistics.Windows.DataPresenter.Field field;
			this.GetNearestCompatibleField(item, pt, this._pivotCell.Field, this._pivotCell.Record, true, null, out record, out field);
			if (!(record is global::Infragistics.Windows.DataPresenter.DataRecord) || field == null)
			{
				return null;
			}
			if (record is global::Infragistics.Windows.DataPresenter.HeaderRecord)
			{
				return null;
			}
			return ((global::Infragistics.Windows.DataPresenter.DataRecord)record).Cells[field];
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00042DA0 File Offset: 0x00040FA0
		private global::Infragistics.Windows.DataPresenter.Field GetNearestCompatibleField(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point pt, global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			this.VerifyPivots();
			if (this._pivotField == null)
			{
				return null;
			}
			if (!(item is global::Infragistics.Windows.DataPresenter.Field))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Record pivotRecord = null;
			global::Infragistics.Windows.DataPresenter.Record record;
			global::Infragistics.Windows.DataPresenter.Field result;
			if (!this.GetNearestCompatibleField(item, pt, this._pivotField, pivotRecord, false, rp, out record, out result) && !this.GetNearestCompatibleField(item, pt, this._pivotField, pivotRecord, true, rp, out record, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00042DFC File Offset: 0x00040FFC
		private bool GetNearestCompatibleField(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point pt, global::Infragistics.Windows.DataPresenter.Field pivotField, global::Infragistics.Windows.DataPresenter.Record pivotRecord, bool cells, global::Infragistics.Windows.DataPresenter.RecordPresenter rp, out global::Infragistics.Windows.DataPresenter.Record nearestRecord, out global::Infragistics.Windows.DataPresenter.Field nearestField)
		{
			nearestField = null;
			nearestRecord = null;
			this.VerifyPivots();
			if (pivotField == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = (rp as global::Infragistics.Windows.DataPresenter.DataRecordPresenter) ?? (this.GetNearestCompatibleRecordPresenter(item, pt) as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel cellPanel = global::Infragistics.Windows.DataPresenter.GridUtilities.GetCellPanel(dataRecordPresenter, !cells);
			if (cellPanel == null)
			{
				return false;
			}
			global::System.Windows.Rect inViewRect = cellPanel.GetInViewRect();
			if (inViewRect.IsEmpty)
			{
				return false;
			}
			global::System.Windows.Point relativePoint = base.TransformToDescendant(cellPanel).Transform(pt);
			if (relativePoint.X < inViewRect.X)
			{
				relativePoint.X = inViewRect.X;
			}
			else if (relativePoint.X >= inViewRect.Right)
			{
				relativePoint.X = inViewRect.Right - 1.0;
			}
			if (relativePoint.Y < inViewRect.Y)
			{
				relativePoint.Y = inViewRect.Y;
			}
			else if (relativePoint.Y >= inViewRect.Bottom)
			{
				relativePoint.Y = inViewRect.Bottom - 1.0;
			}
			nearestField = cellPanel.GetNearestCompatibleField(item, relativePoint, pivotField, pivotRecord);
			if (nearestField != null)
			{
				nearestRecord = dataRecordPresenter.Record;
			}
			return nearestField != null;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00042F1C File Offset: 0x0004111C
		private global::Infragistics.Windows.DataPresenter.RecordPresenter GetNearestCompatibleRecordPresenter(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point pt)
		{
			this.VerifyPivots();
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = null;
			global::Infragistics.Windows.DataPresenter.Record record = this._pivotRecord;
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				if (this._pivotCell != null)
				{
					record = this._pivotCell.Record;
				}
			}
			else if (item is global::Infragistics.Windows.DataPresenter.Field && this._pivotField != null)
			{
				if (this._pivotField.Owner != null)
				{
					recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(this._pivotField.Owner.LastSelectableItemLabel, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, this) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				}
				if (recordPresenter != null)
				{
					record = recordPresenter.Record;
					if (record is global::Infragistics.Windows.DataPresenter.HeaderRecord)
					{
						record = ((global::Infragistics.Windows.DataPresenter.HeaderRecord)record).AttachedToRecord;
					}
				}
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				if (record != null)
				{
					return record.AssociatedRecordPresenter;
				}
				return null;
			}
			else
			{
				if (record == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				if (!currentViewInternal.HasLogicalOrientation)
				{
					return null;
				}
				double num = double.NaN;
				global::Infragistics.Windows.DataPresenter.RecordPresenter result = null;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresentersInView = this.GetRecordPresentersInView(true, true, false, true);
				bool isCrossLevelSelectionSupported = this.CurrentViewInternal.IsCrossLevelSelectionSupported;
				foreach (global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter2 in recordPresentersInView)
				{
					global::Infragistics.Windows.DataPresenter.Record record2 = recordPresenter2.Record;
					if (record2 != null && record2.RecordType == record.RecordType && (isCrossLevelSelectionSupported || (record2.FieldLayout == record.FieldLayout && record2.NestingDepth == record.NestingDepth)))
					{
						recordPresenter = recordPresenter2;
						global::System.Windows.Point point = recordPresenter.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this);
						global::System.Windows.Point point2 = recordPresenter.TranslatePoint(new global::System.Windows.Point(recordPresenter.ActualWidth, recordPresenter.ActualHeight), this);
						double num2;
						if (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
						{
							if (pt.Y >= point.Y && pt.Y <= point2.Y)
							{
								return recordPresenter;
							}
							if (pt.Y < point.Y)
							{
								num2 = point.Y - pt.Y;
							}
							else
							{
								num2 = pt.Y - point2.Y;
							}
						}
						else
						{
							if (pt.X >= point.X && pt.X <= point2.X)
							{
								return recordPresenter;
							}
							if (pt.X < point.X)
							{
								num2 = point.X - pt.X;
							}
							else
							{
								num2 = pt.X - point2.X;
							}
						}
						if (double.IsNaN(num) || num2 < num)
						{
							num = num2;
							result = recordPresenter;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x000431C0 File Offset: 0x000413C0
		private static global::Infragistics.Windows.DataPresenter.Record GetRecord(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Record record = commandInfo.Parameter as global::Infragistics.Windows.DataPresenter.Record;
			if (record == null && commandInfo.Parameter == null)
			{
				global::System.Windows.DependencyObject dependencyObject = commandInfo.OriginalSource as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = (dependencyObject as global::Infragistics.Windows.DataPresenter.RecordPresenter) ?? (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
					if (recordPresenter != null)
					{
						record = recordPresenter.Record;
					}
				}
			}
			return record;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00043220 File Offset: 0x00041420
		private global::Infragistics.Windows.DataPresenter.SelectedRecordCollection GetRecordsForSelection(bool select, global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator evaluator)
		{
			global::Infragistics.Windows.DataPresenter.SelectedRecordCollection selectedRecordCollection = new global::Infragistics.Windows.DataPresenter.SelectedRecordCollection(this);
			global::Infragistics.Windows.DataPresenter.Record pivotRecord = evaluator.PivotRecord;
			global::Infragistics.Windows.DataPresenter.Record endOfRangeRecord = evaluator.EndOfRangeRecord;
			long overallSelectionPosition = endOfRangeRecord.OverallSelectionPosition;
			long overallSelectionPosition2 = pivotRecord.OverallSelectionPosition;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = pivotRecord.FieldLayout;
			int nestingDepth = pivotRecord.NestingDepth;
			bool isCrossLevelSelectionSupported = this.CurrentViewInternal.IsCrossLevelSelectionSupported;
			if (overallSelectionPosition != overallSelectionPosition2 && select)
			{
				global::System.Collections.IEnumerator enumerator;
				switch (this.SelectionDepthMode)
				{
				case global::Infragistics.Windows.DataPresenter.SelectionDepthMode.VisibleOnly:
					enumerator = this.GetCrossLevelVisibleRecordsInRange(endOfRangeRecord, pivotRecord).GetEnumerator();
					break;
				case global::Infragistics.Windows.DataPresenter.SelectionDepthMode.Single:
					enumerator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator(endOfRangeRecord, pivotRecord, overallSelectionPosition > overallSelectionPosition2);
					break;
				case global::Infragistics.Windows.DataPresenter.SelectionDepthMode.All:
					enumerator = this.GetCrossLevelRecordsInRange(endOfRangeRecord, pivotRecord, overallSelectionPosition > overallSelectionPosition2).GetEnumerator();
					break;
				default:
					enumerator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator(endOfRangeRecord, pivotRecord, overallSelectionPosition > overallSelectionPosition2);
					break;
				}
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					global::Infragistics.Windows.DataPresenter.Record record = obj as global::Infragistics.Windows.DataPresenter.Record;
					if (record != null && (isCrossLevelSelectionSupported || (record.FieldLayout == fieldLayout && record.NestingDepth == nestingDepth)) && ((global::Infragistics.Windows.Selection.ISelectableItem)record).IsSelectable && record.VisibilityResolved == global::System.Windows.Visibility.Visible)
					{
						selectedRecordCollection.InternalAdd(record);
					}
				}
			}
			if ((select || evaluator.IsRangeOfCells) && pivotRecord.IsSelectable)
			{
				selectedRecordCollection.InternalInsert(0, pivotRecord);
			}
			return selectedRecordCollection;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0004334F File Offset: 0x0004154F
		private static double GetScrollValueHelper(double actualValue, ref double? cachedValue)
		{
			if (cachedValue != null)
			{
				return cachedValue.Value;
			}
			return actualValue;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00043361 File Offset: 0x00041561
		private void InitializeRecordManagerDataSource()
		{
			if (this._contentSiteGrid == null && !this._isRecordManagerDataSourceInitialized)
			{
				return;
			}
			this.VerifyRecordManagerDataSource();
			this.InitializeItemsPanel();
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00043380 File Offset: 0x00041580
		private global::System.Windows.Controls.ItemsPanelTemplate InitializeRecordListControlPanel(global::Infragistics.Windows.DataPresenter.RecordListControl rlc, global::System.Type panelType)
		{
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate();
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(panelType);
			itemsPanelTemplate.VisualTree = frameworkElementFactory;
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("", global::System.Windows.Data.BindingMode.OneTime, this));
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty, global::Infragistics.Windows.Utilities.CreateBindingObject("", global::System.Windows.Data.BindingMode.OneTime, this.CurrentViewInternal));
			global::System.Windows.Controls.Grid.SetRow(rlc, 1);
			global::System.Windows.Style recordListControlStyle = this.GetRecordListControlStyle(this.DefaultFieldLayout);
			if (recordListControlStyle != null)
			{
				rlc.Style = recordListControlStyle;
			}
			if (this.ViewableRecords != null)
			{
				int count = this.RecordManager.ViewableRecords.Count;
			}
			if (!this.IsExportControl)
			{
				this.VerifyInternalRecords();
				rlc.SetBinding(global::System.Windows.Controls.ItemsControl.ItemsSourceProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InternalRecordsProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			}
			this.ReplaceDataAreaContent(rlc);
			return itemsPanelTemplate;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0004343C File Offset: 0x0004163C
		private void InitializeSpacingOnResizeController()
		{
			if (this._resizeController == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (currentViewInternal == null)
			{
				return;
			}
			this._resizeController.InterItemSpacingX = currentViewInternal.InterRecordSpacingX;
			this._resizeController.InterItemSpacingY = currentViewInternal.InterRecordSpacingY;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00043480 File Offset: 0x00041680
		private void ApplyAsyncCommand(global::Infragistics.Windows.DataPresenter.DataPresenterBase.AsyncPageCommand apc)
		{
			if (apc != this._asyncCommand)
			{
				return;
			}
			this._asyncCommand = null;
			if (!base.IsLoaded || !base.IsVisible)
			{
				return;
			}
			global::System.Windows.Input.RoutedCommand command = apc.Command;
			this.SelectFirstOrLastDisplayedRecord(command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageAbove || command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageLeft, false, false);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000434D1 File Offset: 0x000416D1
		internal void OnChildRecordsDisplayOrderChanged()
		{
			this.BumpScrollCountRecalcVersion();
			this.UpdateScrollBarVisibility();
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000434E0 File Offset: 0x000416E0
		private void OnCurrentViewStateChanged(object sender, global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateFieldLayouts:
				this.BumpScrollCountRecalcVersion();
				this.OnFormatSettingsInvalidated();
				this.InitializeSpacingOnResizeController();
				break;
			case global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateArrange:
				base.InvalidateArrange();
				break;
			case global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure:
				base.InvalidateMeasure();
				if (this.CurrentPanel != null)
				{
					this.CurrentPanel.InvalidateMeasure();
				}
				this.InitializeSpacingOnResizeController();
				break;
			case global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateRender:
				base.InvalidateVisual();
				this.InitializeSpacingOnResizeController();
				break;
			}
			this.UpdateScrollBarVisibility();
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0004355C File Offset: 0x0004175C
		private static void OnDataContextChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			int num = (dataPresenterBase._fieldLayouts != null) ? dataPresenterBase._fieldLayouts.Count : 0;
			for (int i = 0; i < num; i++)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dataPresenterBase._fieldLayouts[i];
				if (fieldLayout.DataPresenter == dataPresenterBase)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.SetCurrentValueIfSourceDefault(fieldLayout, global::System.Windows.FrameworkElement.DataContextProperty, e.NewValue);
				}
			}
			if (dataPresenterBase._x_FieldLayoutSettings != null && dataPresenterBase._x_FieldLayoutSettings.HasFieldBinding)
			{
				dataPresenterBase._x_FieldLayoutSettings.SetCurrentValue(global::System.Windows.FrameworkElement.DataContextProperty, e.NewValue);
			}
			if (dataPresenterBase._x_FieldSettings != null && dataPresenterBase._x_FieldSettings.HasFieldBinding)
			{
				dataPresenterBase._x_FieldSettings.SetCurrentValue(global::System.Windows.FrameworkElement.DataContextProperty, e.NewValue);
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00043614 File Offset: 0x00041814
		private void OnDynamicResourceChanged(string propName)
		{
			if (propName != null)
			{
				if (!(propName == "RecordNumberSeparator"))
				{
					return;
				}
				this.BumpRecordNumberVersionAsync();
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0004363C File Offset: 0x0004183C
		private void OnInvalidateGeneratedStyles()
		{
			if (this._invalidateGeneratedStylesPending)
			{
				this.InvalidateGeneratedStyles(true, false, this._invalidateTemplatesWithPendingGeneratedStyles != false);
				this._invalidateGeneratedStylesPending = false;
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00043680 File Offset: 0x00041880
		private void OnLayoutUpdated()
		{
			global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordsPendingNestedContentInitialization = this._recordsPendingNestedContentInitialization;
			if (recordsPendingNestedContentInitialization != null)
			{
				this._recordsPendingNestedContentInitialization = null;
				while (recordsPendingNestedContentInitialization.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = recordsPendingNestedContentInitialization.Dequeue();
					if (recordPresenter.IsVisible)
					{
						recordPresenter.InitializeNestedDataContent();
					}
				}
				global::Infragistics.Windows.Virtualization.RecyclingItemsPanel recyclingItemsPanel = this.CurrentPanel as global::Infragistics.Windows.Virtualization.RecyclingItemsPanel;
				if (recyclingItemsPanel != null)
				{
					bool flag = false;
					switch (this.RecordContainerRetentionMode)
					{
					case global::Infragistics.Windows.DataPresenter.RecordContainerRetentionMode.RetainDeactivatedContainersUntilResize:
					{
						global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
						if (currentViewInternal.HasLogicalOrientation)
						{
							double num = (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical) ? base.ActualHeight : base.ActualHeight;
							if (num < this._lastScrollDimensionExtent)
							{
								flag = true;
							}
							this._lastScrollDimensionExtent = num;
							goto IL_A5;
						}
						goto IL_A5;
					}
					case global::Infragistics.Windows.DataPresenter.RecordContainerRetentionMode.RetainDeactivatedContainers:
						goto IL_A5;
					}
					flag = true;
					IL_A5:
					if (flag)
					{
						recyclingItemsPanel.RemoveAllDeactivatedContainers();
					}
				}
			}
			this.ProcessPendingAutoSizeOperations();
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00043741 File Offset: 0x00041941
		private void OnNewFieldLayoutSettings()
		{
			if (this._x_FieldLayoutSettings != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._x_FieldLayoutSettings, this, string.Empty);
				if (this._x_FieldLayoutSettings.HasFieldBinding)
				{
					this._x_FieldLayoutSettings.SetCurrentValue(global::System.Windows.FrameworkElement.DataContextProperty, base.DataContext);
				}
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0004377F File Offset: 0x0004197F
		private void OnNewFieldSettings()
		{
			if (this._x_FieldSettings != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._x_FieldSettings, this, string.Empty);
				if (this._x_FieldSettings.HasFieldBinding)
				{
					this._x_FieldSettings.SetCurrentValue(global::System.Windows.FrameworkElement.DataContextProperty, base.DataContext);
				}
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000437C0 File Offset: 0x000419C0
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.Controls.Page page = global::Infragistics.Windows.Utilities.GetAncestorFromType(this, typeof(global::System.Windows.Controls.Page), true) as global::System.Windows.Controls.Page;
			if (page != null && !page.IsLoaded)
			{
				base.Unloaded -= this.OnUnloaded;
				base.Loaded += this.OnLoaded;
			}
			if (this._isScrollingTimer != null && this._isScrollingTimer.IsEnabled)
			{
				this.ProcessIsScrollingTimerTick();
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0004382E File Offset: 0x00041A2E
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			base.Unloaded += this.OnUnloaded;
			this.RefreshFieldLayout();
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0004385A File Offset: 0x00041A5A
		private object OnPerformFieldAutoSize(object parameter)
		{
			this.ProcessPendingAutoSizeOperations();
			return null;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00043864 File Offset: 0x00041A64
		private void OnProcessSortCriteria(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if ((this._currentRecordListControl == null && (!this.IsExportControl || this.IsReportControl)) || this._recordManager == null)
			{
				return;
			}
			int num = 0;
			if (this.DefaultFieldLayout != null && this.DefaultFieldLayout.HasSortedFields)
			{
				num = this.DefaultFieldLayout.SortedFields.GroupbyVersion;
			}
			this.BumpOverallSortVersion();
			if (num != this._groupbyVersion)
			{
				this._groupbyVersion = num;
				((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this).OverallScrollPosition = 0;
				if (!this._recordManager.IsInReset)
				{
					this._recordManager.VerifySort();
					return;
				}
			}
			else if (!this._recordManager.IsInReset)
			{
				this._recordManager.VerifySort();
			}
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0004390C File Offset: 0x00041B0C
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			if (e.OriginalSource == sender && e.TargetRect.IsEmpty)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = sender as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
				if (dataPresenterBase._previewMouseDownArgs != null)
				{
					global::System.Windows.Point position = dataPresenterBase._previewMouseDownArgs.GetPosition(dataPresenterBase);
					dataPresenterBase._previewMouseDownArgs = null;
					global::System.Windows.DependencyObject dependencyObject = dataPresenterBase.InputHitTest(position) as global::System.Windows.DependencyObject;
					if (dependencyObject != null)
					{
						while (dependencyObject is global::System.Windows.ContentElement)
						{
							dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
						}
						global::System.Windows.DependencyObject dependencyObject2 = null;
						while (dependencyObject != null && !(dependencyObject is global::Infragistics.Windows.DataPresenter.CellValuePresenter) && !(dependencyObject is global::Infragistics.Windows.DataPresenter.LabelPresenter) && !(dependencyObject is global::Infragistics.Windows.DataPresenter.CellPresenterBase) && !(dependencyObject is global::Infragistics.Windows.DataPresenter.RecordCellAreaBase) && !(dependencyObject is global::Infragistics.Windows.DataPresenter.RecordPresenter) && !(dependencyObject is global::Infragistics.Windows.DataPresenter.GroupByAreaBase) && dependencyObject != dataPresenterBase)
						{
							if (dependencyObject2 == null)
							{
								global::System.Windows.IInputElement inputElement = dependencyObject as global::System.Windows.IInputElement;
								if (inputElement != null && inputElement.Focusable)
								{
									dependencyObject2 = dependencyObject;
								}
							}
							dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject, false);
						}
						if (dependencyObject == null)
						{
							dependencyObject = dependencyObject2;
						}
						global::System.Windows.UIElement uielement = dependencyObject as global::System.Windows.UIElement;
						if (uielement != null && uielement != dataPresenterBase)
						{
							global::System.Windows.Media.GeneralTransform generalTransform = uielement.TransformToAncestor(dataPresenterBase);
							if (generalTransform != null)
							{
								global::System.Windows.Rect targetRectangle = generalTransform.TransformBounds(new global::System.Windows.Rect(uielement.RenderSize));
								targetRectangle.Intersect(new global::System.Windows.Rect(dataPresenterBase.RenderSize));
								if (!targetRectangle.IsEmpty)
								{
									dataPresenterBase.BringIntoView(targetRectangle);
								}
							}
						}
					}
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00043A44 File Offset: 0x00041C44
		private static void OnScrollViewerScrollChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = sender as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				dataPresenterBase.ScrollVersion++;
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00043A69 File Offset: 0x00041C69
		private void OnIsScrollingTimerTick(object sender, global::System.EventArgs e)
		{
			this.ProcessIsScrollingTimerTick();
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x00043A71 File Offset: 0x00041C71
		private void ProcessIsScrollingTimerTick()
		{
			this._isScrollingTimer.Stop();
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsScrollingPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00043A90 File Offset: 0x00041C90
		private void ProcessPendingAutoSizeOperations()
		{
			if (!global::Infragistics.Windows.DataPresenter.GridUtilities.HasItems(this._fieldLayoutsAutoSizePending))
			{
				return;
			}
			if (this._processingFieldAutoSize)
			{
				return;
			}
			this._processingFieldAutoSize = true;
			try
			{
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.WalkAllRecordItems(this._fieldLayoutsAutoSizePending);
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.TransferViewableRecords(this._fieldLayoutsAutoSizePending);
				int scrollCount = this.ViewableRecords.ScrollCount;
				if (this._pendingFieldAutoSize != null && this._pendingFieldAutoSize.Status == global::System.Windows.Threading.DispatcherOperationStatus.Pending)
				{
					this._pendingFieldAutoSize.Abort();
				}
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> fieldLayoutsAutoSizePending = this._fieldLayoutsAutoSizePending;
				this._fieldLayoutsAutoSizePending = null;
				global::Infragistics.Windows.DataPresenter.RecordsInViewHelper recordsInViewHelper = new global::Infragistics.Windows.DataPresenter.RecordsInViewHelper(this);
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldLayoutInfo.ProcessPendingOperations(fieldLayoutsAutoSizePending, recordsInViewHelper);
			}
			finally
			{
				this._processingFieldAutoSize = false;
				this._pendingFieldAutoSize = null;
			}
			this.SetupAsyncAutoSize();
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00043B44 File Offset: 0x00041D44
		private void ProcessPendingSelectedDataItems()
		{
			if (this.DataSource == null || !base.IsInitialized)
			{
				return;
			}
			bool flag = false;
			object[] array = this._pendingSelectedDataItemsOperation as object[];
			try
			{
				global::Infragistics.Windows.DataPresenter.DataRecord[] recordsFromDataItems = this.GetRecordsFromDataItems(array, true);
				int num = (recordsFromDataItems != null) ? recordsFromDataItems.Length : 0;
				if (num == 0)
				{
					this.ClearSelectedRecords();
					this.ClearSelectedCells();
					flag = (array != null);
					if (!flag)
					{
						this._previousSelectedRecord = null;
						base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemProperty, null);
						base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemsProperty, null);
					}
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
					selectedItemHolder.Records.InternalAddRange(recordsFromDataItems);
					if (this._selectedItems != null && this._selectedItems.HasFields)
					{
						selectedItemHolder.Fields.InternalAddRange(this._selectedItems.Fields);
					}
					if (this.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Record), selectedItemHolder))
					{
						flag = true;
						for (int i = 0; i < num; i++)
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = recordsFromDataItems[i];
							if (dataRecord != null && dataRecord.IsSelected)
							{
								dataRecord.EnsureAncestorsAreExpanded();
							}
						}
					}
				}
			}
			finally
			{
				this._pendingSelectedDataItemsOperation = null;
				if (flag)
				{
					this.SetSelectedDataItemsInternal();
				}
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00043C6C File Offset: 0x00041E6C
		internal void RaiseCellsInViewChangedAsyncHelper()
		{
			if (this._pendingRaiseCellsInViewChangedAsyncHelperHandler || !this.ShouldRaiseCellsInViewChanged)
			{
				return;
			}
			global::System.Windows.Threading.Dispatcher dispatcher = base.Dispatcher;
			if (dispatcher != null)
			{
				dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.RaiseCellsInViewChangedAsyncHelperHandler));
				this._pendingRaiseCellsInViewChangedAsyncHelperHandler = true;
			}
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00043CAF File Offset: 0x00041EAF
		private void RaiseCellsInViewChangedAsyncHelperHandler()
		{
			this._pendingRaiseCellsInViewChangedAsyncHelperHandler = false;
			if (this.ShouldRaiseCellsInViewChanged)
			{
				global::Infragistics.Windows.DataPresenter.VisibleDataBlock.RaiseCellsInViewChanged(this);
			}
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00043CC8 File Offset: 0x00041EC8
		private void RefocusActiveCell(int? selectionStart, int? selectionLength)
		{
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
			if (activeCell != null && base.IsFocused)
			{
				activeCell.FocusIfActive();
				global::System.Windows.Controls.TextBox activeCellTextBoxWithFocus = this.GetActiveCellTextBoxWithFocus();
				if (activeCellTextBoxWithFocus != null)
				{
					if (selectionStart != null)
					{
						activeCellTextBoxWithFocus.SelectionStart = selectionStart.Value;
					}
					if (selectionLength != null)
					{
						activeCellTextBoxWithFocus.SelectionLength = selectionLength.Value;
					}
				}
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00043D24 File Offset: 0x00041F24
		private void RefreshFieldLayout()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this.DefaultFieldLayout;
			if (defaultFieldLayout != null)
			{
				this.FieldLayouts.BumpSortVersions();
				this.InvalidateGeneratedStylesAsync(true);
			}
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00043D50 File Offset: 0x00041F50
		private void RemoveFromSelectedCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected, global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				selected.Records.Remove(item as global::Infragistics.Windows.DataPresenter.Record);
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				selected.Cells.Remove(item as global::Infragistics.Windows.DataPresenter.Cell);
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				selected.Fields.Remove(item as global::Infragistics.Windows.DataPresenter.Field);
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00043DAC File Offset: 0x00041FAC
		private void ReplaceDataAreaContent(global::System.Windows.FrameworkElement newDataAreaContent)
		{
			int num = this._dataAreaGrid.Children.IndexOf(this._contentSiteDataAreaContent);
			if (num >= 0)
			{
				this._dataAreaGrid.Children.Remove(this._contentSiteDataAreaContent);
			}
			this._contentSiteDataAreaContent = newDataAreaContent;
			if (num >= 0)
			{
				this._dataAreaGrid.Children.Insert(num, this._contentSiteDataAreaContent);
			}
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00043E0C File Offset: 0x0004200C
		private void SelectFirstOrLastDisplayedRecord(bool first, bool shiftKeyDown, bool ctlKeyDown)
		{
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
			if (viewPanel == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record record;
			if (first)
			{
				record = viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord));
			}
			else
			{
				record = viewPanel.GetLastDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord));
			}
			if (record != null)
			{
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(record);
				if (selectionStrategyForItem != null)
				{
					selectionStrategyForItem.SelectItemViaKeyboard(record, shiftKeyDown, ctlKeyDown, false);
				}
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00043E69 File Offset: 0x00042069
		private void SetSelectedDataItemsExternal(object[] newItems)
		{
			this._pendingSelectedDataItemsOperation = ((newItems != null) ? newItems : global::System.DBNull.Value);
			this.ProcessPendingSelectedDataItems();
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00043E84 File Offset: 0x00042084
		private void SetSelectedDataItemsInternal()
		{
			if (this.VerifyPendingSelectedDataItems())
			{
				return;
			}
			this._isSettingSelectedDataItems = true;
			try
			{
				global::Infragistics.Windows.DataPresenter.SelectedDataItemsScope selectedDataItemsScope = this.SelectedDataItemsScope;
				switch (selectedDataItemsScope)
				{
				case global::Infragistics.Windows.DataPresenter.SelectedDataItemsScope.RecordsOnly:
				case global::Infragistics.Windows.DataPresenter.SelectedDataItemsScope.RecordsOrCells:
				{
					object[] selectedDataItems = this.SelectedDataItems;
					int num = (selectedDataItems != null) ? selectedDataItems.Length : 0;
					global::System.Collections.Generic.List<object> list = null;
					bool flag = false;
					if (this._selectedItems != null)
					{
						if (this._selectedItems.HasRecords)
						{
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records = this._selectedItems.Records;
							int count = records.Count;
							flag = (num != count);
							list = new global::System.Collections.Generic.List<object>(count);
							for (int i = 0; i < count; i++)
							{
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = records[i] as global::Infragistics.Windows.DataPresenter.DataRecord;
								if (dataRecord != null)
								{
									object dataItem = dataRecord.DataItem;
									list.Add(dataItem);
									if (!flag)
									{
										flag = (dataItem != selectedDataItems[i]);
									}
								}
								else
								{
									flag = true;
								}
							}
						}
						else if (selectedDataItemsScope == global::Infragistics.Windows.DataPresenter.SelectedDataItemsScope.RecordsOrCells && this._selectedItems.HasCells)
						{
							list = new global::System.Collections.Generic.List<object>();
							global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells = this._selectedItems.Cells;
							int count2 = cells.Count;
							global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.DataRecord> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.DataRecord>();
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = null;
							for (int j = 0; j < count2; j++)
							{
								global::Infragistics.Windows.DataPresenter.DataRecord record = cells[j].Record;
								if (record != dataRecord2)
								{
									dataRecord2 = record;
									if (!hashSet.Contains(record))
									{
										hashSet.Add(record);
										object dataItem2 = record.DataItem;
										list.Add(dataItem2);
										if (!flag)
										{
											flag = (list.Count > num || dataItem2 != selectedDataItems[list.Count - 1]);
										}
									}
								}
							}
						}
					}
					if (!flag)
					{
						flag = ((list != null) ? (list.Count != num) : (num > 0));
					}
					if (flag)
					{
						object[] value = (list != null) ? list.ToArray() : null;
						base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemsProperty, value);
					}
					break;
				}
				}
			}
			finally
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = null;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord4 = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._previousSelectedRecord) as global::Infragistics.Windows.DataPresenter.DataRecord;
				bool flag2 = false;
				if (this._selectedItems != null)
				{
					if (this._selectedItems.HasRecords)
					{
						flag2 = (dataRecord4 != null && dataRecord4.IsSelected);
						if (!flag2)
						{
							global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records2 = this._selectedItems.Records;
							int count3 = records2.Count;
							for (int k = 0; k < count3; k++)
							{
								dataRecord3 = (records2[k] as global::Infragistics.Windows.DataPresenter.DataRecord);
								if (dataRecord3 != null)
								{
									break;
								}
							}
						}
					}
					else if (this._selectedItems.HasCells)
					{
						if (dataRecord4 != null)
						{
							flag2 = dataRecord4.HasSelectedCells;
						}
						if (!flag2)
						{
							global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells2 = this._selectedItems.Cells;
							dataRecord3 = cells2[0].Record;
						}
					}
				}
				if (!flag2)
				{
					if (dataRecord3 != null)
					{
						this._previousSelectedRecord = new global::System.WeakReference(dataRecord3);
						base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemProperty, dataRecord3.DataItem);
					}
					else
					{
						this._previousSelectedRecord = null;
						base.SetCurrentValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedDataItemProperty, null);
					}
				}
				this._isSettingSelectedDataItems = false;
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00044174 File Offset: 0x00042374
		private void SetupAsyncAutoSize()
		{
			if (this._processingFieldAutoSize)
			{
				return;
			}
			if (this._fieldLayoutsAutoSizePending == null || this._fieldLayoutsAutoSizePending.Count == 0)
			{
				return;
			}
			if (this._pendingFieldAutoSize != null)
			{
				return;
			}
			this._pendingFieldAutoSize = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Windows.Threading.DispatcherOperationCallback(this.OnPerformFieldAutoSize), null);
			this.WireLayoutUpdated(new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnLayoutUpdated));
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000441DC File Offset: 0x000423DC
		private bool ShouldResizeSiblingField(global::System.Windows.FrameworkElement resizableItem, global::Infragistics.Windows.DataPresenter.DataItemPresenter siblingFieldItem, bool resizeInXAxis, ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition targetPosition, ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition siblingPosition)
		{
			bool flag = false;
			bool flag2 = false;
			if (resizeInXAxis)
			{
				if (siblingPosition.Column + siblingPosition.ColumnSpan == targetPosition.Column + targetPosition.ColumnSpan)
				{
					flag = true;
				}
				else if (siblingPosition.Column <= targetPosition.Column && siblingPosition.Column + siblingPosition.ColumnSpan > targetPosition.Column + targetPosition.ColumnSpan)
				{
					flag = true;
					flag2 = true;
				}
			}
			else if (siblingPosition.Row + siblingPosition.RowSpan == targetPosition.Row + targetPosition.RowSpan)
			{
				flag = true;
			}
			else if (siblingPosition.Row <= targetPosition.Row && siblingPosition.Row + siblingPosition.RowSpan > targetPosition.Row + targetPosition.RowSpan)
			{
				flag = true;
				flag2 = true;
			}
			if (!flag)
			{
				return false;
			}
			if (!flag2)
			{
				return true;
			}
			global::System.Windows.Point point = default(global::System.Windows.Point);
			global::System.Windows.Point point2 = new global::System.Windows.Point(resizableItem.ActualWidth, resizableItem.ActualHeight);
			global::System.Windows.Point point3 = siblingFieldItem.TranslatePoint(default(global::System.Windows.Point), resizableItem);
			global::System.Windows.Point point4 = siblingFieldItem.TranslatePoint(new global::System.Windows.Point(siblingFieldItem.ActualWidth, siblingFieldItem.ActualHeight), resizableItem);
			if (resizeInXAxis)
			{
				return point3.X <= point.X && point4.X >= point2.X;
			}
			return point3.Y <= point.Y && point4.Y >= point2.Y;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00044360 File Offset: 0x00042560
		private void StartAsyncTreeFilterManager(bool force)
		{
			if (this.IsExportControl)
			{
				return;
			}
			if (this.IsTreeView && base.IsInitialized && (force || (this.DefaultFieldLayout != null && this.DefaultFieldLayout.HasRecordFilters)))
			{
				if (this._treeFilterManager == null)
				{
					this._treeFilterManager = new global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager(this);
				}
				this._treeFilterManager.Start();
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000443C0 File Offset: 0x000425C0
		private void UnwireDataSourceRootList()
		{
			if (this._dataSourceRootList == null || this._dataSourceRootListChangeListener == null)
			{
				return;
			}
			if (this._dataSourceRootList is global::System.Collections.Specialized.INotifyCollectionChanged)
			{
				global::System.Collections.Specialized.CollectionChangedEventManager.RemoveListener(this._dataSourceRootList as global::System.Collections.Specialized.INotifyCollectionChanged, this._dataSourceRootListChangeListener);
			}
			if (this._dataSourceRootList is global::System.ComponentModel.IBindingList)
			{
				global::Infragistics.Windows.Helpers.BindingListChangedEventManager.RemoveListener(this._dataSourceRootList as global::System.ComponentModel.IBindingList, this._dataSourceRootListChangeListener);
			}
			this._dataSourceRootList = null;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0004442C File Offset: 0x0004262C
		private void UpdateScrollBarVisibility()
		{
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (currentViewInternal == null)
			{
				return;
			}
			global::System.Windows.Controls.ScrollBarVisibility horizontalScrollBarVisibility = currentViewInternal.HorizontalScrollBarVisibility;
			global::System.Windows.Controls.ScrollBarVisibility verticalScrollBarVisibility = currentViewInternal.VerticalScrollBarVisibility;
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.HorizontalScrollBarVisibilityPropertyKey, global::Infragistics.KnownBoxes.FromValue(horizontalScrollBarVisibility));
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.VerticalScrollBarVisibilityPropertyKey, global::Infragistics.KnownBoxes.FromValue(verticalScrollBarVisibility));
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00044474 File Offset: 0x00042674
		private void UpdateSelectedItems(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = null;
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionPatternOnInvalidated) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected))
			{
				selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(this);
				if (this.SelectedItems.HasCells)
				{
					selectedItemHolder.Cells.InternalAddRange(this.SelectedItems.Cells);
				}
				if (this.SelectedItems.HasRecords)
				{
					selectedItemHolder.Records.InternalAddRange(this.SelectedItems.Records);
				}
				if (this.SelectedItems.HasFields)
				{
					selectedItemHolder.Fields.InternalAddRange(this.SelectedItems.Fields);
				}
			}
			if (this.SelectedItems.HasCells)
			{
				global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells = this.SelectedItems.Cells;
				for (int i = 0; i < cells.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = cells[i];
					if (!selected.HasCells || !selected.Cells.Contains(cell))
					{
						cell.InternalSelect(false);
					}
				}
			}
			if (selected.HasCells)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Cell cell2 in selected.Cells)
				{
					cell2.InternalSelect(true);
				}
			}
			if (this.SelectedItems.HasRecords)
			{
				global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records = this.SelectedItems.Records;
				for (int j = 0; j < records.Count; j++)
				{
					global::Infragistics.Windows.DataPresenter.Record record = this.SelectedItems.Records[j];
					if (!selected.HasRecords || !selected.Records.Contains(record))
					{
						record.InternalSelect(false);
					}
				}
			}
			if (selected.HasRecords)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record record2 in selected.Records)
				{
					record2.InternalSelect(true);
				}
			}
			if (this.SelectedItems.HasFields && !this.SelectedItems.IsSelectionSameForItemType(typeof(global::Infragistics.Windows.DataPresenter.Field), selected))
			{
				for (int k = 0; k < this.SelectedItems.Fields.Count; k++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = this.SelectedItems.Fields[k];
					field.InternalSelect(false);
				}
			}
			if (selected.HasFields)
			{
				for (int l = 0; l < selected.Fields.Count; l++)
				{
					global::Infragistics.Windows.DataPresenter.Field field2 = selected.Fields[l];
					field2.InternalSelect(true);
				}
			}
			this.SelectedItems.Records.InternalSetList(selected.Records);
			this.SelectedItems.Cells.InternalSetList(selected.Cells);
			this.SelectedItems.Fields.InternalSetList(selected.Fields);
			if (selectedItemHolder != null)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.RaiseAutomationSelectionEvents(selectedItemHolder, this.SelectedItems);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0004474C File Offset: 0x0004294C
		private void VerifyActiveRecordNotDeleted()
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._activeRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && dataRecord.IsDeleted)
			{
				if (this._activeCell != null)
				{
					this._activeCell = null;
					this.ActiveCell = null;
				}
				this._activeRecord = null;
				this.ActiveRecord = null;
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00044794 File Offset: 0x00042994
		private void VerifyContentSiteGrid()
		{
			this.RemoveStatusControl(this.ExportHelper.InternalStatusControl);
			if (this._contentSiteGrid != null)
			{
				this._logicalChildren.Remove(this._contentSiteGrid);
			}
			global::System.Windows.DependencyObject templateChild = base.GetTemplateChild("PART_ContentSiteGrid");
			if (templateChild == null)
			{
				return;
			}
			global::System.Windows.Controls.Grid grid = templateChild as global::System.Windows.Controls.Grid;
			if (grid == null)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_4", new object[]
				{
					"Grid",
					"PART_ContentSiteGrid",
					"DataPresenterBase",
					templateChild.GetType().Name
				}));
			}
			global::System.Windows.Controls.Grid contentSiteGrid = this._contentSiteGrid;
			this._contentSiteGrid = grid;
			grid.RowDefinitions.Clear();
			int num = 0;
			int value = 1;
			this.GetGroupByAndDataAreaRows(ref num, ref value);
			global::System.Windows.Controls.RowDefinition rowDefinition = new global::System.Windows.Controls.RowDefinition();
			if (num == 0)
			{
				rowDefinition.Height = global::System.Windows.GridLength.Auto;
			}
			else
			{
				rowDefinition.Height = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
			}
			grid.RowDefinitions.Add(rowDefinition);
			rowDefinition = new global::System.Windows.Controls.RowDefinition();
			if (num == 1)
			{
				rowDefinition.Height = global::System.Windows.GridLength.Auto;
			}
			else
			{
				rowDefinition.Height = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
			}
			grid.RowDefinitions.Add(rowDefinition);
			this._dataAreaGrid = new global::System.Windows.Controls.Grid();
			rowDefinition = new global::System.Windows.Controls.RowDefinition();
			rowDefinition.Height = global::System.Windows.GridLength.Auto;
			this._dataAreaGrid.RowDefinitions.Add(rowDefinition);
			rowDefinition = new global::System.Windows.Controls.RowDefinition();
			rowDefinition.Height = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
			this._dataAreaGrid.RowDefinitions.Add(rowDefinition);
			global::System.Windows.Controls.Grid.SetRow(this._dataAreaGrid, value);
			this._contentSiteGrid.Children.Add(this._dataAreaGrid);
			global::Infragistics.Windows.DataPresenter.RecordListControl currentRecordListControl = this.CurrentRecordListControl;
			if (currentRecordListControl != null)
			{
				this._dataAreaGrid.Children.Add(currentRecordListControl);
			}
			this._contentSiteDataAreaContent = currentRecordListControl;
			global::System.Windows.Controls.Grid grid2 = null;
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaResolved = this.GetGroupByAreaResolved(false);
			if (groupByAreaResolved != null)
			{
				grid2 = (groupByAreaResolved.Parent as global::System.Windows.Controls.Grid);
			}
			if (grid2 != null && grid2 != this._contentSiteGrid && grid2 == contentSiteGrid)
			{
				grid2.Children.Remove(groupByAreaResolved);
			}
			this.VerifyGroupByAreaLocation();
			this.AddStatusControl(this.ExportHelper.InternalStatusControl);
			if (this.DataSource != null || (this._dataItems != null && this._dataItems.Count > 0))
			{
				this.InitializeRecordManagerDataSource();
			}
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000449F0 File Offset: 0x00042BF0
		private void VerifyGroupByAreaLocation()
		{
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (this._contentSiteGrid != null && currentViewInternal != null)
			{
				bool flag = !currentViewInternal.IsGroupBySupported || this.GroupByAreaLocation == global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.None;
				global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaBase = (!flag) ? this.GetGroupByAreaResolved(base.IsInitialized) : null;
				global::System.Windows.UIElement[] array = new global::System.Windows.UIElement[this._contentSiteGrid.Children.Count];
				this._contentSiteGrid.Children.CopyTo(array, 0);
				bool flag2 = false;
				foreach (global::System.Windows.UIElement uielement in array)
				{
					global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaBase2 = uielement as global::Infragistics.Windows.DataPresenter.GroupByAreaBase;
					if (groupByAreaBase2 != null)
					{
						if (groupByAreaBase2 == groupByAreaBase && !flag)
						{
							flag2 = true;
						}
						else
						{
							this._contentSiteGrid.Children.Remove(groupByAreaBase2);
							if (groupByAreaBase2.Parent == null)
							{
								this.InternalAddLogicalChild(groupByAreaBase2);
							}
						}
					}
				}
				if (!flag)
				{
					if (groupByAreaBase == null)
					{
						return;
					}
					int value = 0;
					int value2 = 1;
					this.GetGroupByAndDataAreaRows(ref value, ref value2);
					if (!flag2 && global::System.Windows.Media.VisualTreeHelper.GetParent(groupByAreaBase) == null)
					{
						if (groupByAreaBase.Parent == this)
						{
							this.InternalRemoveLogicalChild(groupByAreaBase);
						}
						this._contentSiteGrid.Children.Add(groupByAreaBase);
					}
					if (this.GroupByAreaLocation == global::Infragistics.Windows.DataPresenter.GroupByAreaLocation.AboveDataArea)
					{
						this._contentSiteGrid.RowDefinitions[0].Height = global::System.Windows.GridLength.Auto;
						this._contentSiteGrid.RowDefinitions[1].Height = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
					}
					else
					{
						this._contentSiteGrid.RowDefinitions[0].Height = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
						this._contentSiteGrid.RowDefinitions[1].Height = global::System.Windows.GridLength.Auto;
					}
					if (this._contentSiteGrid.Children.Contains(groupByAreaBase) && groupByAreaBase != null)
					{
						global::System.Windows.Controls.Grid.SetRow(groupByAreaBase, value);
					}
					if (this._dataAreaGrid != null)
					{
						global::System.Windows.Controls.Grid.SetRow(this._dataAreaGrid, value2);
					}
				}
			}
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00044BC8 File Offset: 0x00042DC8
		private bool VerifyPendingSelectedDataItems()
		{
			if (this._pendingSelectedDataItemsOperation == null)
			{
				return false;
			}
			object[] array = this._pendingSelectedDataItemsOperation as object[];
			if (this._selectedItems == null || !this._selectedItems.HasRecords)
			{
				return array == null || array.Length <= 0;
			}
			if (array == null || array.Length == 0)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records = this._selectedItems.Records;
			int count = records.Count;
			bool flag = count == array.Length;
			if (flag)
			{
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = records[i] as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord == null || array[i] != dataRecord.DataItem)
					{
						flag = false;
						break;
					}
				}
			}
			return flag;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00044C6C File Offset: 0x00042E6C
		private void VerifyPivots()
		{
			if (this._pivotRecord != null && (!this._pivotRecord.FieldLayout.IsInitialRecordLoaded || !this._pivotRecord.IsStillValid))
			{
				this._pivotRecord = null;
			}
			if (this._pivotCell != null && (!this._pivotCell.Field.Owner.IsInitialRecordLoaded || !this._pivotCell.Record.IsStillValid || this._pivotCell.Field.Owner.Index < 0))
			{
				this._pivotCell = null;
			}
			if (this._pivotField != null && this._pivotField.Owner.Index < 0)
			{
				this._pivotField = null;
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00044D1C File Offset: 0x00042F1C
		private void WireDataSourceRootList(global::System.Collections.IEnumerable rootList)
		{
			if (this._dataSourceRootList == rootList)
			{
				return;
			}
			this.UnwireDataSourceRootList();
			this._dataSourceRootList = rootList;
			if (this._dataSourceRootListChangeListener == null)
			{
				this._dataSourceRootListChangeListener = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceRootListChangeListener(this);
			}
			if (this._dataSourceRootList is global::System.Collections.Specialized.INotifyCollectionChanged)
			{
				global::System.Collections.Specialized.CollectionChangedEventManager.AddListener(this._dataSourceRootList as global::System.Collections.Specialized.INotifyCollectionChanged, this._dataSourceRootListChangeListener);
			}
			if (this._dataSourceRootList is global::System.ComponentModel.IBindingList)
			{
				global::Infragistics.Windows.Helpers.BindingListChangedEventManager.AddListener(this._dataSourceRootList as global::System.ComponentModel.IBindingList, this._dataSourceRootListChangeListener);
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00044D9C File Offset: 0x00042F9C
		bool global::Infragistics.Windows.Resizing.IAutoResizeHost.PerformAutoSize(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis)
		{
			global::Infragistics.Windows.Resizing.IResizableElement resizableElement = resizableItem as global::Infragistics.Windows.Resizing.IResizableElement;
			global::Infragistics.Windows.DataPresenter.Field field = (resizableElement != null) ? (resizableElement.ResizeContext as global::Infragistics.Windows.DataPresenter.Field) : null;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : null;
			if (field == null || fieldLayout == null)
			{
				return false;
			}
			bool flag;
			if (resizeInXAxis)
			{
				flag = fieldLayout.IsHorizontal;
			}
			else
			{
				flag = !fieldLayout.IsHorizontal;
			}
			if (flag)
			{
				return false;
			}
			if (field.AutoSizeOptionsResolved == global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(resizableItem, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			if (virtualizingDataRecordCellPanel == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager fieldRecordManager = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldRecordManager(resizableItem, field, false);
			if (fieldRecordManager == null)
			{
				return false;
			}
			bool isLabel = resizableItem is global::Infragistics.Windows.DataPresenter.LabelPresenter;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> allResizableFieldItems = this.GetAllResizableFieldItems(virtualizingDataRecordCellPanel, field, isLabel, resizeInXAxis, true);
			if (allResizableFieldItems == null || allResizableFieldItems.Count == 0)
			{
				return false;
			}
			if (!this.VerifyOperationIsAllowed(global::Infragistics.Windows.DataPresenter.UIOperation.FieldAutoSizing))
			{
				return true;
			}
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings>();
			bool useCellPresenters = field.Owner.UseCellPresenters;
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase in allResizableFieldItems)
			{
				global::Infragistics.Windows.DataPresenter.Field field2 = fieldLayoutItemBase.Field;
				global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions fieldAutoSizeOptions = field2.AutoSizeOptionsResolved;
				if (useCellPresenters)
				{
					if (fieldLayoutItemBase.IsLabel)
					{
						fieldAutoSizeOptions &= global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label;
					}
					else
					{
						fieldAutoSizeOptions &= ~global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.Label;
					}
				}
				global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings value;
				if (!dictionary.TryGetValue(field2, out value))
				{
					value = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldSettings(fieldAutoSizeOptions, field2.AutoSizeScopeResolved);
				}
				else
				{
					value.Options |= fieldAutoSizeOptions;
				}
				dictionary[fieldLayoutItemBase.Field] = value;
			}
			global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper autoSizeFieldHelper = new global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper(dictionary, field.Owner);
			int nestingDepth = global::Infragistics.Windows.DataPresenter.AutoSizeFieldHelper.GetNestingDepth(fieldRecordManager);
			global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags flags = global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.RecalculateRecords | global::Infragistics.Windows.DataPresenter.AutoSizeCalculationFlags.UseTemplateRecordAsFallback;
			if (!autoSizeFieldHelper.ExitEditModeIfNeeded())
			{
				return true;
			}
			if (!autoSizeFieldHelper.Calculate(this.Records, nestingDepth, flags, null))
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager resizeLayoutManager = virtualizingDataRecordCellPanel.GetResizeLayoutManager();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> preferredSizes = autoSizeFieldHelper.GetPreferredSizes(resizeLayoutManager, allResizableFieldItems);
			if (preferredSizes.Count == 0)
			{
				return false;
			}
			object containerContext = new global::System.Windows.Rect(virtualizingDataRecordCellPanel.LayoutManagerSize);
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary2;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary3;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> newExtents = resizeLayoutManager.PerformAutoSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext, preferredSizes, fieldLayout.IsGridBagAutoFitWidth, fieldLayout.IsGridBagAutoFitHeight, out dictionary2, out dictionary3, resizeInXAxis, !resizeInXAxis);
			this._initialResizeIsPending = false;
			return resizeLayoutManager.ResizeItems(newExtents, resizeInXAxis, null, true, global::Infragistics.Windows.DataPresenter.ItemSizeType.ExplicitAutoSize, resizeInXAxis ? dictionary2 : dictionary3);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00044FE0 File Offset: 0x000431E0
		void global::Infragistics.Windows.Resizing.IResizeHost.AddResizerBar(global::System.Windows.FrameworkElement resizerBar)
		{
			base.AddVisualChild(resizerBar);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00044FE9 File Offset: 0x000431E9
		global::Infragistics.Windows.Resizing.ResizeController global::Infragistics.Windows.Resizing.IResizeHost.Controller
		{
			get
			{
				if (this._resizeController == null)
				{
					this._resizeController = new global::Infragistics.Windows.Resizing.ResizeController(this);
					this.InitializeSpacingOnResizeController();
				}
				return this._resizeController;
			}
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0004500C File Offset: 0x0004320C
		bool global::Infragistics.Windows.Resizing.IResizeHost.CanResize(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis)
		{
			if (resizableItem == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (currentViewInternal == null)
			{
				return false;
			}
			global::Infragistics.Windows.Resizing.IResizableElement resizableElement = resizableItem as global::Infragistics.Windows.Resizing.IResizableElement;
			if (resizableElement == null)
			{
				return false;
			}
			if (this.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.CardView && resizableElement is global::Infragistics.Windows.DataPresenter.CardViewCard)
			{
				if (((global::Infragistics.Windows.DataPresenter.CardViewCard)resizableElement).IsCollapsed)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = ((global::Infragistics.Windows.DataPresenter.CardView)this.CurrentViewInternal).ViewSettings;
				if (resizeInXAxis)
				{
					return viewSettings.AllowCardWidthResizing;
				}
				return viewSettings.AllowCardHeightResizing;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = resizableItem as global::Infragistics.Windows.DataPresenter.LabelPresenter;
				if (labelPresenter != null && (labelPresenter.IsInGroupByArea || labelPresenter.IsInFieldChooser))
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Field field = resizableElement.ResizeContext as global::Infragistics.Windows.DataPresenter.Field;
				bool flag;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout;
				if (field == null || field.Owner == null)
				{
					if (!(resizableElement.ResizeContext is global::Infragistics.Windows.DataPresenter.Record))
					{
						return false;
					}
					flag = true;
					fieldLayout = ((global::Infragistics.Windows.DataPresenter.Record)resizableElement.ResizeContext).FieldLayout;
					if (resizeInXAxis != fieldLayout.IsHorizontal)
					{
						return false;
					}
				}
				else
				{
					if (field.IsExpandableResolved)
					{
						return false;
					}
					fieldLayout = field.Owner;
					if (resizeInXAxis)
					{
						flag = fieldLayout.IsHorizontal;
					}
					else
					{
						flag = !fieldLayout.IsHorizontal;
					}
				}
				if (flag)
				{
					if (labelPresenter != null)
					{
						return false;
					}
					if (!currentViewInternal.IsLogicalFieldHeightResizingAllowed)
					{
						return false;
					}
					switch (fieldLayout.RecordResizingAreaResolved)
					{
					case global::Infragistics.Windows.DataPresenter.RecordResizingArea.RecordSelectorsOnly:
						if (!(resizableItem is global::Infragistics.Windows.DataPresenter.RecordSelector))
						{
							return false;
						}
						break;
					case global::Infragistics.Windows.DataPresenter.RecordResizingArea.CellsOnly:
						if (!(resizableItem is global::Infragistics.Windows.DataPresenter.CellValuePresenter))
						{
							return false;
						}
						break;
					}
					switch (fieldLayout.DataRecordSizingModeResolved)
					{
					case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.IndividuallySizable:
					case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndIndividuallySizable:
					case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizableSynchronized:
						return true;
					}
					return false;
				}
				else
				{
					if (!currentViewInternal.IsLogicalFieldWidthResizingAllowed)
					{
						return false;
					}
					if (!field.AllowResizeResolved)
					{
						return false;
					}
					switch (fieldLayout.FieldResizingAreaResolved)
					{
					case global::Infragistics.Windows.DataPresenter.FieldResizingArea.LabelsOnly:
						if (!(resizableItem is global::Infragistics.Windows.DataPresenter.LabelPresenter))
						{
							return false;
						}
						break;
					case global::Infragistics.Windows.DataPresenter.FieldResizingArea.CellsOnly:
						if (!(resizableItem is global::Infragistics.Windows.DataPresenter.CellValuePresenter))
						{
							return false;
						}
						break;
					}
					if ((resizeInXAxis && fieldLayout.IsAutoFitWidth) || (!resizeInXAxis && fieldLayout.IsAutoFitHeight))
					{
						global::System.Windows.FrameworkElement resizeAreaForItem = ((global::Infragistics.Windows.Resizing.IResizeHost)this).GetResizeAreaForItem(resizableItem);
						global::Infragistics.Windows.Resizing.ResizeConstraints resizeConstraints = new global::Infragistics.Windows.Resizing.ResizeConstraints(null, resizeAreaForItem, resizeInXAxis);
						((global::Infragistics.Windows.Resizing.IResizeHost)this).InitializeResizeConstraints(resizeAreaForItem, resizableItem, resizeConstraints);
						if (resizeConstraints.MinExtent == resizeConstraints.MaxExtent)
						{
							return false;
						}
					}
					return true;
				}
			}
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00045212 File Offset: 0x00043412
		global::System.Windows.FrameworkElement global::Infragistics.Windows.Resizing.IResizeHost.GetResizeAreaForItem(global::System.Windows.FrameworkElement resizableItem)
		{
			return this;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00045215 File Offset: 0x00043415
		global::System.Windows.Input.Cursor global::Infragistics.Windows.Resizing.IResizeHost.GetResizeCursor(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis, global::System.Windows.Input.Cursor cursor)
		{
			return cursor;
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00045218 File Offset: 0x00043418
		void global::Infragistics.Windows.Resizing.IResizeHost.InitializeResizeConstraints(global::System.Windows.FrameworkElement resizeArea, global::System.Windows.FrameworkElement resizableItem, global::Infragistics.Windows.Resizing.ResizeConstraints constraints)
		{
			this._initialResizeIsPending = true;
			constraints.ResizeWhileDragging = false;
			if (resizableItem is global::Infragistics.Windows.DataPresenter.CardViewCard)
			{
				global::Infragistics.Windows.DataPresenter.CardViewPanel cardViewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.CardViewPanel;
				if (cardViewPanel == null)
				{
					return;
				}
				global::System.Windows.Controls.ScrollContentPresenter scrollContentPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(resizableItem, typeof(global::System.Windows.Controls.ScrollContentPresenter), true) as global::System.Windows.Controls.ScrollContentPresenter;
				global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = cardViewPanel.ViewSettings;
				global::System.Windows.Point point = resizableItem.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), cardViewPanel);
				double num = 50.0;
				if (constraints.ResizeInXAxis)
				{
					double val = double.IsNaN(resizableItem.DesiredSize.Width) ? num : global::System.Math.Min(num, resizableItem.DesiredSize.Width);
					constraints.MinExtent = global::System.Math.Max(val, resizableItem.MinWidth);
					double num2 = (scrollContentPresenter != null) ? scrollContentPresenter.ActualWidth : cardViewPanel.ActualWidth;
					constraints.MaxExtent = num2 - (viewSettings.Padding.Left + viewSettings.Padding.Right + point.X) - 4.0;
					return;
				}
				double val2 = double.IsNaN(resizableItem.DesiredSize.Height) ? num : global::System.Math.Min(num, resizableItem.DesiredSize.Height);
				constraints.MinExtent = global::System.Math.Max(val2, resizableItem.MinHeight);
				double num3 = (scrollContentPresenter != null) ? scrollContentPresenter.ActualHeight : cardViewPanel.ActualHeight;
				constraints.MaxExtent = num3 - (viewSettings.Padding.Top + viewSettings.Padding.Bottom + point.Y) - 4.0;
				return;
			}
			else
			{
				global::Infragistics.Windows.Controls.ResizingMode resizingMode = global::Infragistics.Windows.Controls.ResizingMode.Default;
				if (resizableItem is global::Infragistics.Windows.Resizing.IResizableElement)
				{
					global::Infragistics.Windows.DataPresenter.Field field = ((global::Infragistics.Windows.Resizing.IResizableElement)resizableItem).ResizeContext as global::Infragistics.Windows.DataPresenter.Field;
					global::Infragistics.Windows.DataPresenter.Record record = ((global::Infragistics.Windows.Resizing.IResizableElement)resizableItem).ResizeContext as global::Infragistics.Windows.DataPresenter.Record;
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : ((record != null) ? record.FieldLayout : null);
					if (fieldLayout != null)
					{
						resizingMode = fieldLayout.ResizingModeResolved;
						global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel cellPanelForResize = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetCellPanelForResize(resizableItem, record);
						if (cellPanelForResize != null)
						{
							global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager resizeLayoutManager = cellPanelForResize.GetResizeLayoutManager();
							bool isLabel = resizableItem is global::Infragistics.Windows.DataPresenter.LabelPresenter;
							if (record != null && field == null)
							{
								field = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetFieldForRecordResize(resizeLayoutManager);
							}
							global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = (field != null) ? resizeLayoutManager.GetLayoutItem(field, isLabel) : null;
							if (fieldLayoutItemBase != null)
							{
								global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> allResizableFieldItems = this.GetAllResizableFieldItems(cellPanelForResize, field, isLabel, constraints.ResizeInXAxis, false);
								object containerContext = new global::System.Windows.Rect(cellPanelForResize.LayoutManagerSize);
								bool flag = resizeLayoutManager.CellPanel == null;
								if (flag)
								{
									resizeLayoutManager.InitializePanelReference(cellPanelForResize);
									cellPanelForResize.InitializeCachedDimensions();
									resizeLayoutManager.InvalidateLayout();
								}
								fieldLayout.TemplateDataRecordCache.Verify();
								resizeLayoutManager.VerifyLayout();
								double num4;
								double num5;
								double num6;
								double num7;
								resizeLayoutManager.GetResizeRange(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext, fieldLayoutItemBase, out num4, out num5, out num6, out num7, fieldLayout.IsGridBagAutoFitWidth, fieldLayout.IsGridBagAutoFitHeight, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.ConvertLayoutItems(allResizableFieldItems));
								if (flag)
								{
									cellPanelForResize.ReleaseCachedDimensions();
									resizeLayoutManager.InitializePanelReference(null);
								}
								if (constraints.ResizeInXAxis)
								{
									constraints.MinExtent = global::System.Math.Min(resizableItem.ActualWidth - num4, resizableItem.ActualWidth);
									constraints.MaxExtent = global::System.Math.Max(resizableItem.ActualWidth + num5, resizableItem.ActualWidth);
								}
								else
								{
									constraints.MinExtent = global::System.Math.Min(resizableItem.ActualHeight - num6, resizableItem.ActualHeight);
									constraints.MaxExtent = global::System.Math.Max(resizableItem.ActualHeight + num7, resizableItem.ActualHeight);
								}
								this.ConstrainFixedFieldMaxExtent(resizableItem, constraints, field, cellPanelForResize);
							}
						}
					}
				}
				switch (resizingMode)
				{
				default:
					constraints.ResizeWhileDragging = false;
					return;
				case global::Infragistics.Windows.Controls.ResizingMode.Immediate:
					constraints.ResizeWhileDragging = true;
					return;
				}
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000FAC RID: 4012 RVA: 0x000455BB File Offset: 0x000437BB
		global::System.Windows.FrameworkElement global::Infragistics.Windows.Resizing.IResizeHost.RootElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000455BE File Offset: 0x000437BE
		void global::Infragistics.Windows.Resizing.IResizeHost.RemoveResizerBar(global::System.Windows.FrameworkElement resizerBar)
		{
			base.RemoveVisualChild(resizerBar);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000455C8 File Offset: 0x000437C8
		void global::Infragistics.Windows.Resizing.IResizeHost.Resize(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis, double delta)
		{
			if (resizableItem == null || delta == 0.0)
			{
				return;
			}
			global::Infragistics.Windows.Resizing.IResizableElement resizableElement = resizableItem as global::Infragistics.Windows.Resizing.IResizableElement;
			if (resizableElement == null)
			{
				return;
			}
			if (resizableItem is global::Infragistics.Windows.DataPresenter.CardViewCard)
			{
				global::Infragistics.Windows.DataPresenter.CardView cardView = this.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.CardView;
				if (cardView != null)
				{
					if (resizeInXAxis)
					{
						cardView.ViewSettings.CardWidth = resizableItem.ActualWidth + delta;
						return;
					}
					cardView.ViewSettings.CardHeight = resizableItem.ActualHeight + delta;
				}
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field field = resizableElement.ResizeContext as global::Infragistics.Windows.DataPresenter.Field;
			global::Infragistics.Windows.DataPresenter.Record record = resizableElement.ResizeContext as global::Infragistics.Windows.DataPresenter.Record;
			if ((field == null || field.Owner == null) && record == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (record != null) ? record.FieldLayout : field.Owner;
			bool flag = resizableItem is global::Infragistics.Windows.DataPresenter.LabelPresenter;
			bool flag2;
			if (resizeInXAxis)
			{
				flag2 = fieldLayout.IsHorizontal;
			}
			else
			{
				flag2 = !fieldLayout.IsHorizontal;
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel cellPanelForResize = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetCellPanelForResize(resizableItem, record);
			if (cellPanelForResize == null)
			{
				return;
			}
			if (flag && !this.VerifyOperationIsAllowed(global::Infragistics.Windows.DataPresenter.UIOperation.FieldResizing))
			{
				return;
			}
			if (flag2 && !this.VerifyOperationIsAllowed(global::Infragistics.Windows.DataPresenter.UIOperation.RecordResizing))
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = cellPanelForResize.GetResizeLayoutManager();
			if (record != null && field == null)
			{
				field = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetFieldForRecordResize(fieldGridBagLayoutManager);
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = fieldGridBagLayoutManager.GetLayoutItem(field, flag);
			global::Infragistics.Windows.DataPresenter.Record record2 = null;
			if (layoutItem != null)
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(cellPanelForResize.LayoutManagerSize);
				if (fieldLayout.AutoFitModeResolved == global::Infragistics.Windows.DataPresenter.AutoFitMode.ExtendLastField)
				{
					rect = new global::System.Windows.Rect(rect.X, rect.Y, (!fieldLayout.IsGridBagAutoFitWidth) ? double.PositiveInfinity : rect.Width, (!fieldLayout.IsGridBagAutoFitHeight) ? double.PositiveInfinity : rect.Height);
				}
				object containerContext = rect;
				bool flag3 = false;
				if (!flag && flag2)
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = (resizableItem as global::Infragistics.Windows.DataPresenter.CellValuePresenter) ?? (global::Infragistics.Windows.Utilities.GetDescendantFromType(resizableItem, typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), true) as global::Infragistics.Windows.DataPresenter.CellValuePresenter);
					if (record == null && cellValuePresenter != null)
					{
						record = cellValuePresenter.Record;
					}
					if (record == null)
					{
						return;
					}
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsVariableHeightRecordMode(layoutItem.RecordSizingMode))
					{
						record2 = record;
						fieldGridBagLayoutManager = record2.GetLayoutManager(true);
						layoutItem = fieldGridBagLayoutManager.GetLayoutItem(field, flag);
						if (layoutItem == null)
						{
							return;
						}
						flag3 = true;
						fieldGridBagLayoutManager.InitializePanelReference(cellPanelForResize);
						cellPanelForResize.InitializeCachedDimensions();
						fieldGridBagLayoutManager.InvalidateLayout();
						fieldGridBagLayoutManager.LayoutContainer(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext);
					}
				}
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> allResizableFieldItems = this.GetAllResizableFieldItems(cellPanelForResize, field, flag, resizeInXAxis, false);
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary2;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> newExtents = fieldGridBagLayoutManager.ResizeItem(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext, layoutItem, resizeInXAxis ? delta : 0.0, resizeInXAxis ? 0.0 : delta, fieldLayout.IsGridBagAutoFitWidth, fieldLayout.IsGridBagAutoFitHeight, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.ConvertLayoutItems(allResizableFieldItems), out dictionary, out dictionary2);
				bool initialResizeIsPending = this._initialResizeIsPending;
				this._initialResizeIsPending = false;
				if (flag3)
				{
					cellPanelForResize.ReleaseCachedDimensions();
					fieldGridBagLayoutManager.InitializePanelReference(null);
				}
				fieldGridBagLayoutManager.ResizeItems(newExtents, resizeInXAxis, record2, initialResizeIsPending, global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit, resizeInXAxis ? dictionary : dictionary2);
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00045885 File Offset: 0x00043A85
		global::System.Windows.FrameworkElement global::Infragistics.Windows.Selection.ISelectionHost.RootElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00045888 File Offset: 0x00043A88
		bool global::Infragistics.Windows.Selection.ISelectionHost.ActivateItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool preventScrollItemIntoView)
		{
			this.VerifyPivots();
			this._bypassScrollIntoView = preventScrollItemIntoView;
			if (item != this._itemPendingScrollItemIntoView)
			{
				this._itemPendingScrollItemIntoView = (this._bypassScrollIntoView ? item : null);
			}
			try
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = item as global::Infragistics.Windows.DataPresenter.Cell;
				if (cell != null)
				{
					if (cell.DataPresenter != this)
					{
						return false;
					}
					if (cell.Record != this.ActiveRecord)
					{
						this.ActiveRecord = cell.Record;
					}
					if (cell.Record == this.ActiveRecord)
					{
						this.ActiveCell = cell;
					}
					return this.ActiveCell == cell;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
					if (record != null)
					{
						if (record.DataPresenter != this)
						{
							return false;
						}
						this.ActiveRecord = record;
						return this.ActiveRecord == record;
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.Field field = item as global::Infragistics.Windows.DataPresenter.Field;
						if (field != null)
						{
							this.BringFieldIntoView(field);
							return true;
						}
					}
				}
			}
			finally
			{
				this._bypassScrollIntoView = false;
			}
			return false;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00045970 File Offset: 0x00043B70
		void global::Infragistics.Windows.Selection.ISelectionHost.ClearSnapshot()
		{
			this.SelectionSnapshot.SetCells(null);
			this.SelectionSnapshot.SetFields(null);
			this.SelectionSnapshot.SetRecords(null);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00045996 File Offset: 0x00043B96
		bool global::Infragistics.Windows.Selection.ISelectionHost.DeselectItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return this.InternalSelectItem(item, false, false);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000459A1 File Offset: 0x00043BA1
		bool global::Infragistics.Windows.Selection.ISelectionHost.DeselectRange(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return this.InternalSelectRange(item, false, false);
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x000459AC File Offset: 0x00043BAC
		void global::Infragistics.Windows.Selection.ISelectionHost.DoAutoScrollHorizontal(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.Selection.ScrollDirection direction, global::Infragistics.Windows.Selection.ScrollSpeed speed)
		{
			global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
			if (scrollInfo == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (currentViewInternal.HasLogicalOrientation)
			{
				double num;
				if (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal)
				{
					num = this.CalculateScrollOffsetFactorInRecords(speed, scrollInfo.ViewportWidth);
				}
				else
				{
					num = this.CalculateScrollOffsetFactorInPixels(speed, scrollInfo.ViewportWidth);
				}
				double num2;
				if (direction == global::Infragistics.Windows.Selection.ScrollDirection.Increment)
				{
					num2 = 1.0;
				}
				else
				{
					num2 = -1.0;
				}
				num2 *= num;
				scrollInfo.SetHorizontalOffset(global::System.Math.Max(global::System.Math.Min(scrollInfo.HorizontalOffset + num2, scrollInfo.ExtentWidth - scrollInfo.ViewportWidth), 0.0));
				if (currentViewInternal.LogicalOrientation != global::System.Windows.Controls.Orientation.Horizontal)
				{
					base.UpdateLayout();
				}
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00045A58 File Offset: 0x00043C58
		void global::Infragistics.Windows.Selection.ISelectionHost.DoAutoScrollVertical(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.Selection.ScrollDirection direction, global::Infragistics.Windows.Selection.ScrollSpeed speed)
		{
			global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
			if (scrollInfo == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (currentViewInternal.HasLogicalOrientation)
			{
				double num;
				if (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					num = this.CalculateScrollOffsetFactorInRecords(speed, scrollInfo.ViewportHeight);
				}
				else
				{
					num = this.CalculateScrollOffsetFactorInPixels(speed, scrollInfo.ViewportHeight);
				}
				double num2;
				if (direction == global::Infragistics.Windows.Selection.ScrollDirection.Increment)
				{
					num2 = 1.0;
				}
				else
				{
					num2 = -1.0;
				}
				num2 *= num;
				scrollInfo.SetVerticalOffset(global::System.Math.Max(global::System.Math.Min(scrollInfo.VerticalOffset + num2, scrollInfo.ExtentHeight - scrollInfo.ViewportHeight), 0.0));
				if (currentViewInternal.LogicalOrientation != global::System.Windows.Controls.Orientation.Vertical)
				{
					base.UpdateLayout();
				}
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00045B08 File Offset: 0x00043D08
		void global::Infragistics.Windows.Selection.ISelectionHost.EnterSnakingMode(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = item as global::Infragistics.Windows.DataPresenter.Cell;
			if (cell == null)
			{
				return;
			}
			global::Infragistics.Windows.Selection.ISelectableItem pivotItem = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetPivotItem(item);
			global::Infragistics.Windows.DataPresenter.Cell cell2 = pivotItem as global::Infragistics.Windows.DataPresenter.Cell;
			if (cell2 == null)
			{
				return;
			}
			if (this.CurrentViewInternal == null)
			{
				return;
			}
			if (cell2.IsOnSameTier(cell, this.CurrentViewInternal.LogicalOrientation))
			{
				this._snaking = false;
				return;
			}
			this._snaking = true;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00045B60 File Offset: 0x00043D60
		global::Infragistics.Windows.Selection.AutoScrollInfo global::Infragistics.Windows.Selection.ISelectionHost.GetAutoScrollInfo(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			if (scrollInfo == null || !currentViewInternal.HasLogicalOrientation)
			{
				return new global::Infragistics.Windows.Selection.AutoScrollInfo(this, false, false, false, false);
			}
			bool flag = scrollInfo.CanVerticallyScroll && scrollInfo.VerticalOffset + scrollInfo.ViewportHeight < scrollInfo.ExtentHeight;
			bool flag2 = scrollInfo.CanVerticallyScroll && scrollInfo.VerticalOffset > 0.0;
			bool flag3 = scrollInfo.CanHorizontallyScroll && scrollInfo.HorizontalOffset + scrollInfo.ViewportWidth < scrollInfo.ExtentWidth;
			bool flag4 = scrollInfo.CanHorizontallyScroll && scrollInfo.HorizontalOffset > 0.0;
			if (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				if (item is global::Infragistics.Windows.DataPresenter.Record)
				{
					flag4 = false;
					flag3 = false;
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Field)
				{
					flag = false;
					flag2 = false;
				}
			}
			else if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				flag = false;
				flag2 = false;
			}
			else if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				flag4 = false;
				flag3 = false;
			}
			global::Infragistics.Windows.Selection.AutoScrollInfo result = new global::Infragistics.Windows.Selection.AutoScrollInfo(this, flag, flag4, flag3, flag2);
			if (flag || flag4 || flag3 || flag2)
			{
				result.AdjustScrollInfoCallback = new global::Infragistics.Windows.Selection.AdjustScrollInfoCallback(this._fixedScrollHelper.AdjustScrollInfoCallback);
			}
			return result;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00045C90 File Offset: 0x00043E90
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.GetNearestCompatibleItem(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			this.VerifyPivots();
			if (item == null)
			{
				return null;
			}
			global::System.Windows.Point position = e.MouseDevice.GetPosition(this);
			if (this._selectionPoint == null)
			{
				this._selectionPoint = new global::System.Windows.Point?(position);
			}
			global::System.Windows.DependencyObject dependencyObject = base.InputHitTest(position) as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = null;
			if (dependencyObject != null)
			{
				global::Infragistics.Windows.Selection.ISelectableElement selectableElement = this.GetCompatibleSelectableElement(item, dependencyObject);
				selectableElement = this._fixedScrollHelper.VerifyNearestCompatibleItem(selectableElement, item, e);
				if (selectableElement != null)
				{
					return selectableElement.SelectableItem;
				}
				recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject as global::System.Windows.Media.Visual, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, this) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
				if (recordPresenter != null && item is global::Infragistics.Windows.DataPresenter.Cell && global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject as global::System.Windows.Media.Visual, typeof(global::Infragistics.Windows.DataPresenter.FixedFieldSplitter), true, recordPresenter) != null)
				{
					return null;
				}
				if (recordPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedRecordLocationOverride = recordPresenter.Record.FixedRecordLocationOverride;
					switch (fixedRecordLocationOverride)
					{
					case global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top:
					case global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom:
					{
						global::Infragistics.Windows.Selection.ISelectableItem selectableItem = this.FindNearesScrollableCompatibleRecord(fixedRecordLocationOverride == global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top, item, ref recordPresenter);
						if (selectableItem != null)
						{
							return selectableItem;
						}
						break;
					}
					}
					if (item is global::Infragistics.Windows.DataPresenter.Record)
					{
						return null;
					}
					if (item is global::Infragistics.Windows.DataPresenter.Cell && !((global::Infragistics.Windows.DataPresenter.Cell)item).Record.IsSiblingOf(recordPresenter.Record))
					{
						return this.GetNearestCompatibleCell(item, position);
					}
					if (item is global::Infragistics.Windows.DataPresenter.Field)
					{
						if (((global::Infragistics.Windows.DataPresenter.Field)item).Owner != recordPresenter.Record.FieldLayout)
						{
							return null;
						}
						return this.GetNearestCompatibleField(item, position, recordPresenter);
					}
				}
				recordPresenter = this.GetCompatibleRecordPresenter(item, dependencyObject);
			}
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				return this.GetNearestCompatibleCell(item, position);
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				return this.GetNearestCompatibleField(item, position, null);
			}
			if (recordPresenter == null)
			{
				recordPresenter = this.GetNearestCompatibleRecordPresenter(item, position);
			}
			if (recordPresenter == null)
			{
				return null;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				return recordPresenter.Record;
			}
			return null;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00045E35 File Offset: 0x00044035
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.GetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			this.VerifyPivots();
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				return this._pivotCell;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				return this._pivotRecord;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				return this._pivotField;
			}
			return null;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00045E6C File Offset: 0x0004406C
		global::Infragistics.Windows.Selection.SelectionStrategyBase global::Infragistics.Windows.Selection.ISelectionHost.GetSelectionStrategyForItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (this._selectionStrategyFilter != null)
			{
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = this._selectionStrategyFilter.GetSelectionStrategyForItem(item);
				if (selectionStrategyForItem != null)
				{
					return selectionStrategyForItem;
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayoutForSelectableItem = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetFieldLayoutForSelectableItem(item);
			if (fieldLayoutForSelectableItem != null)
			{
				return fieldLayoutForSelectableItem.GetSelectionStrategyForItem(item);
			}
			return null;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00045EA8 File Offset: 0x000440A8
		bool global::Infragistics.Windows.Selection.ISelectionHost.IsItemSelectableWithCurrentSelection(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return item != null && item.IsSelectable && this.IsItemSelectableWithCurrentSelection(item);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00045EC0 File Offset: 0x000440C0
		bool global::Infragistics.Windows.Selection.ISelectionHost.IsMaxSelectedItemsReached(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
				if (fieldLayout == null)
				{
					return false;
				}
				int maxSelectedRecordsResolved = fieldLayout.MaxSelectedRecordsResolved;
				return this._selectedItems != null && this._selectedItems.HasRecords && this._selectedItems.Records.Count >= maxSelectedRecordsResolved;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = item as global::Infragistics.Windows.DataPresenter.Cell;
				if (cell == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = cell.Field.Owner;
				if (owner == null)
				{
					return false;
				}
				int maxSelectedCellsResolved = owner.MaxSelectedCellsResolved;
				return this._selectedItems != null && this._selectedItems.HasCells && this._selectedItems.Cells.Count >= maxSelectedCellsResolved;
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00045F6C File Offset: 0x0004416C
		bool global::Infragistics.Windows.Selection.ISelectionHost.OnDragStart(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)item;
				global::Infragistics.Windows.DataPresenter.SelectedFieldCollection fields = this.SelectedItems.Fields;
				int count = fields.Count;
				if (count <= 1 || !fields.Contains(field))
				{
					return this.StartFieldDragHelper(field, e);
				}
			}
			return false;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00045FB2 File Offset: 0x000441B2
		void global::Infragistics.Windows.Selection.ISelectionHost.OnDragMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager._selectionHost_LastDragMoveEventArgs = e;
				this._fieldDragManager.OnMouseMove(e);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00045FD4 File Offset: 0x000441D4
		void global::Infragistics.Windows.Selection.ISelectionHost.OnDragEnd(bool canceled)
		{
			if (this._fieldDragManager != null)
			{
				global::System.Windows.Input.MouseEventArgs selectionHost_LastDragMoveEventArgs = this._fieldDragManager._selectionHost_LastDragMoveEventArgs;
				this._fieldDragManager.OnDragEnd(selectionHost_LastDragMoveEventArgs, canceled || null == selectionHost_LastDragMoveEventArgs);
			}
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0004600B File Offset: 0x0004420B
		void global::Infragistics.Windows.Selection.ISelectionHost.OnMouseUp(global::System.Windows.Input.MouseEventArgs e, bool preventScrollItemIntoView)
		{
			if (!preventScrollItemIntoView)
			{
				((global::Infragistics.Windows.Selection.ISelectionHost)this).ScrollPendingItemIntoView();
			}
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00046018 File Offset: 0x00044218
		void global::Infragistics.Windows.Selection.ISelectionHost.ScrollPendingItemIntoView()
		{
			if (this._itemPendingScrollItemIntoView != null)
			{
				try
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = this._itemPendingScrollItemIntoView as global::Infragistics.Windows.DataPresenter.Cell;
					if (cell != null && cell == this.ActiveCell)
					{
						this.BringCellIntoView(cell);
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.Record record = this._itemPendingScrollItemIntoView as global::Infragistics.Windows.DataPresenter.Record;
						if (record != null && record == this.ActiveRecord)
						{
							this.BringRecordIntoView(record);
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.Field field = this._itemPendingScrollItemIntoView as global::Infragistics.Windows.DataPresenter.Field;
							if (field != null)
							{
								this.BringFieldIntoView(field);
							}
						}
					}
				}
				finally
				{
					this._itemPendingScrollItemIntoView = null;
				}
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x000460A4 File Offset: 0x000442A4
		bool global::Infragistics.Windows.Selection.ISelectionHost.SelectItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection)
		{
			this._snaking = false;
			return this.InternalSelectItem(item, clearExistingSelection, true);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x000460B8 File Offset: 0x000442B8
		bool global::Infragistics.Windows.Selection.ISelectionHost.SelectRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection)
		{
			this.VerifyPivots();
			bool result = this.InternalSelectRange(item, clearExistingSelection, true);
			if (this._snaking && this._pivotCell != null)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = item as global::Infragistics.Windows.DataPresenter.Cell;
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				if (cell != null && currentViewInternal != null && this._pivotCell.IsOnSameTier(cell, currentViewInternal.LogicalOrientation))
				{
					this._snaking = false;
				}
			}
			return result;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00046118 File Offset: 0x00044318
		void global::Infragistics.Windows.Selection.ISelectionHost.SetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool isRangeSelect)
		{
			global::Infragistics.Windows.Selection.ISelectableItem pivotItem = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetPivotItem(item);
			this._selectionPoint = null;
			if (isRangeSelect && pivotItem != null)
			{
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Cell>(ref this._pivotCell, item as global::Infragistics.Windows.DataPresenter.Cell);
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Record>(ref this._pivotRecord, null);
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Record>(ref this._pivotRecord, item as global::Infragistics.Windows.DataPresenter.Record);
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Cell>(ref this._pivotCell, null);
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Field>(ref this._pivotField, item as global::Infragistics.Windows.DataPresenter.Field);
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x000461AC File Offset: 0x000443AC
		void global::Infragistics.Windows.Selection.ISelectionHost.SnapshotSelection(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				if (this.SelectedItems.Records.Count > 0)
				{
					this.SelectionSnapshot.Records.InternalAddRange(this.SelectedItems.Records);
				}
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				if (this.SelectedItems.Cells.Count > 0)
				{
					this.SelectionSnapshot.Cells.InternalAddRange(this.SelectedItems.Cells);
				}
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field && this.SelectedItems.Fields.Count > 0)
			{
				this.SelectionSnapshot.Fields.InternalAddRange(this.SelectedItems.Fields);
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00046260 File Offset: 0x00044460
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.TranslateItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = item as global::Infragistics.Windows.DataPresenter.Cell;
			if (cell != null && cell.Record.GetCellClickActionResolved(cell.Field) == global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord)
			{
				return cell.Record;
			}
			return item;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00046294 File Offset: 0x00044494
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQueryLong)
		{
			global::Infragistics.Windows.DataPresenter.States states = (global::Infragistics.Windows.DataPresenter.States)0L;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems = this.SelectedItems;
			if (selectedItems.HasSelection)
			{
				states |= global::Infragistics.Windows.DataPresenter.States.ItemsSelected;
				if (0L != (2097152L & statesToQueryLong) && selectedItems.HasRecords && selectedItems.Records[0] is global::Infragistics.Windows.DataPresenter.DataRecord)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.DataRecordsSelected;
				}
				if (0L != (134217728L & statesToQueryLong) && selectedItems.HasCells)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.CellsSelected;
				}
			}
			if (0L != (2L & statesToQueryLong) && this.RecordManager.ViewableRecords.Count > 0)
			{
				states |= global::Infragistics.Windows.DataPresenter.States.Records;
			}
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
			global::Infragistics.Windows.DataPresenter.Record activeRecord = this.ActiveRecord;
			if (activeRecord != null)
			{
				states |= global::Infragistics.Windows.DataPresenter.States.Record;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = activeRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (0L != (8L & statesToQueryLong) && activeRecord.ExpansionIndicatorVisibility == global::System.Windows.Visibility.Visible)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.RecordExpandable;
				}
				if (0L != (4194304L & statesToQueryLong) && dataRecord != null && dataRecord.IsDataChanged)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.RecordHasPendingChanges;
				}
				if (0L != (16L & statesToQueryLong) && activeRecord.IsExpanded)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.RecordExpanded;
				}
				if (0L != (512L & statesToQueryLong) && activeRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.GroupByRecord;
				}
				if (0L != (1024L & statesToQueryLong) && activeRecord is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.ExpandableFieldRecord;
				}
				global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = activeRecord as global::Infragistics.Windows.DataPresenter.FilterRecord;
				if (filterRecord != null)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.FilterRecord;
					if (0L != (67108864L & statesToQueryLong) && filterRecord.HasActiveFilters)
					{
						states |= global::Infragistics.Windows.DataPresenter.States.FilterRecordHasActiveFilters;
					}
				}
				if (viewPanel != null)
				{
					if (0L != (32L & statesToQueryLong) && activeRecord == viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.Record)))
					{
						states |= global::Infragistics.Windows.DataPresenter.States.RecordFirstDisplayed;
					}
					if (0L != (64L & statesToQueryLong) && activeRecord == viewPanel.GetLastDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.Record)))
					{
						states |= global::Infragistics.Windows.DataPresenter.States.RecordLastDisplayed;
					}
					if (0L != (128L & statesToQueryLong) && activeRecord == viewPanel.GetFirstOverallRecord(typeof(global::Infragistics.Windows.DataPresenter.Record)))
					{
						states |= global::Infragistics.Windows.DataPresenter.States.RecordFirstOverall;
					}
					if (0L != (256L & statesToQueryLong) && activeRecord == viewPanel.GetLastOverallRecord(typeof(global::Infragistics.Windows.DataPresenter.Record)))
					{
						states |= global::Infragistics.Windows.DataPresenter.States.RecordLastOverall;
					}
				}
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
				if (activeCell != null)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.Cell;
					if (0L != (4296015872L & statesToQueryLong) && this.EditHelper.CellValuePresenter != null)
					{
						if (0L != (1048576L & statesToQueryLong))
						{
							states |= global::Infragistics.Windows.DataPresenter.States.IsInEditMode;
						}
						if (0L != (4294967296L & statesToQueryLong) && this.EditHelper.CellValuePresenter.AcceptsArrowKeysInEditMode)
						{
							states |= global::Infragistics.Windows.DataPresenter.States.EditorAcceptsArrowKeys;
						}
					}
					if (viewPanel != null)
					{
						if (0L != (16384L & statesToQueryLong))
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord;
							if (dataRecord2 != null && dataRecord2.IsFirstDisplayedCell(activeCell))
							{
								states |= global::Infragistics.Windows.DataPresenter.States.CellFirstDisplayed;
							}
						}
						if (0L != (32768L & statesToQueryLong))
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = viewPanel.GetLastDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord;
							if (dataRecord3 != null && dataRecord3.IsLastDisplayedCell(activeCell))
							{
								states |= global::Infragistics.Windows.DataPresenter.States.CellLastDisplayed;
							}
						}
					}
					if (0L != (65536L & statesToQueryLong))
					{
						global::Infragistics.Windows.DataPresenter.DataRecord firstOverallDataRecord = this.FirstOverallDataRecord;
						if (firstOverallDataRecord != null && firstOverallDataRecord.IsFirstDisplayedCell(activeCell))
						{
							states |= global::Infragistics.Windows.DataPresenter.States.CellFirstOverall;
						}
					}
					if (0L != (131072L & statesToQueryLong))
					{
						global::Infragistics.Windows.DataPresenter.DataRecord lastOverallDataRecord = this.LastOverallDataRecord;
						if (lastOverallDataRecord != null && lastOverallDataRecord.IsLastDisplayedCell(activeCell))
						{
							states |= global::Infragistics.Windows.DataPresenter.States.CellLastOverall;
						}
					}
					if (dataRecord != null)
					{
						if (0L != (4096L & statesToQueryLong) && dataRecord.IsFirstDisplayedCell(activeCell))
						{
							states |= global::Infragistics.Windows.DataPresenter.States.CellFirstInRecord;
						}
						if (0L != (8192L & statesToQueryLong) && dataRecord.IsLastDisplayedCell(activeCell))
						{
							states |= global::Infragistics.Windows.DataPresenter.States.CellLastInRecord;
						}
					}
					global::Infragistics.Windows.DataPresenter.FilterCell filterCell = activeCell as global::Infragistics.Windows.DataPresenter.FilterCell;
					if (filterCell != null)
					{
						states |= global::Infragistics.Windows.DataPresenter.States.FilterCell;
						if (0L != (16777216L & statesToQueryLong) && filterCell.HasActiveFilters)
						{
							states |= global::Infragistics.Windows.DataPresenter.States.FilterCellHasActiveFilters;
						}
					}
				}
			}
			if (viewPanel != null)
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				if (currentViewInternal is global::Infragistics.Windows.DataPresenter.GridView || currentViewInternal is global::Infragistics.Windows.DataPresenter.CardView)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.CanFlipOrientation;
				}
				if (viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewHorizontal)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.NavigationLayoutStyleGridViewHorizontal;
				}
				else if (viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewVertical)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.NavigationLayoutStyleGridViewVertical;
				}
				else if (currentViewInternal is global::Infragistics.Windows.DataPresenter.CardView)
				{
					global::Infragistics.Windows.DataPresenter.CardViewSettings viewSettings = ((global::Infragistics.Windows.DataPresenter.CardView)this.CurrentViewInternal).ViewSettings;
					if (viewSettings.Orientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						states |= global::Infragistics.Windows.DataPresenter.States.NavigationLayoutStyleCardViewHorizontal;
					}
					else
					{
						states |= global::Infragistics.Windows.DataPresenter.States.NavigationLayoutStyleCardViewVertical;
					}
				}
			}
			if (0L != (1073741824L & statesToQueryLong) && this.IsExporting)
			{
				states |= global::Infragistics.Windows.DataPresenter.States.IsExporting;
			}
			if (0UL != ((ulong)-2147483648 & (ulong)statesToQueryLong) && !this.IsExporting && this._cachedExportStatus != global::Infragistics.Windows.DataPresenter.RecordExportStatus.Exporting)
			{
				states |= (global::Infragistics.Windows.DataPresenter.States)((ulong)int.MinValue);
			}
			return (long)(states & (global::Infragistics.Windows.DataPresenter.States)statesToQueryLong);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00046740 File Offset: 0x00044940
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			if (routedCommand != null)
			{
				global::Infragistics.Windows.DataPresenter.FixedFieldLocation? fixedFieldLocation = null;
				if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldNear)
				{
					fixedFieldLocation = new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge);
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FixFieldFar)
				{
					fixedFieldLocation = new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge);
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.UnfixField)
				{
					fixedFieldLocation = new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
				}
				else
				{
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Undo)
					{
						return this.CanExecuteUndoCommand(commandInfo);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Redo)
					{
						return this.CanExecuteUndoCommand(commandInfo);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Cut)
					{
						return this.ClipboardOperationInfo.CanPerformOperation(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Cut);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Copy)
					{
						return this.ClipboardOperationInfo.CanPerformOperation(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Paste)
					{
						return this.ClipboardOperationInfo.CanPerformOperation(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearCellContents)
					{
						return this.ClipboardOperationInfo.CanPerformOperation(global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleRecordIsExpanded)
					{
						return global::Infragistics.Windows.DataPresenter.DataPresenterBase.CanToggleIsExpanded(commandInfo);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.AutoSizeField)
					{
						return this.CanAutoSizeField(commandInfo);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleCardCollapsedState)
					{
						return global::Infragistics.Windows.DataPresenter.DataPresenterBase.CanToggleCardCollapsedState(commandInfo);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleEmptyCardCellsCollapsedState)
					{
						return global::Infragistics.Windows.DataPresenter.DataPresenterBase.CanToggleEmptyCardCellsCollapsedState(commandInfo);
					}
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.FlipOrientation)
					{
						return this.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.GridView || this.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.CardView;
					}
				}
				if (fixedFieldLocation != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = commandInfo.Parameter as global::Infragistics.Windows.DataPresenter.Field;
					return field != null && field.IsFixedLocationAllowed(fixedFieldLocation.Value);
				}
			}
			return routedCommand != null && routedCommand.OwnerType == typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000468BA File Offset: 0x00044ABA
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return commandInfo.RoutedCommand != null && this.ExecuteCommandImpl(commandInfo, true);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000FCA RID: 4042 RVA: 0x000468CE File Offset: 0x00044ACE
		global::Infragistics.Windows.Scrolling.IDeferredScrollPanel global::Infragistics.Windows.Scrolling.IDeferredScrollHost.ScrollPanel
		{
			get
			{
				return this.CurrentPanel as global::Infragistics.Windows.Scrolling.IDeferredScrollPanel;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x000468DB File Offset: 0x00044ADB
		int global::Infragistics.Windows.DataPresenter.IViewPanelInfo.OverallScrollCount
		{
			get
			{
				if (this._cachedOverallScrollCountDirty)
				{
					this._cachedOverallScrollCount = ((this.ViewableRecords != null) ? this.ViewableRecords.ScrollCount : 0);
					this._cachedOverallScrollCountDirty = false;
				}
				return this._cachedOverallScrollCount;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x0004690E File Offset: 0x00044B0E
		// (set) Token: 0x06000FCD RID: 4045 RVA: 0x0004692C File Offset: 0x00044B2C
		int global::Infragistics.Windows.DataPresenter.IViewPanelInfo.OverallScrollPosition
		{
			get
			{
				return global::System.Math.Max(0, global::System.Math.Min(this._overallScrollPosition, ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this).OverallScrollCount - 1));
			}
			set
			{
				if (value != this._overallScrollPosition)
				{
					int num = global::System.Math.Abs(value - this._overallScrollPosition);
					int num2 = global::System.Math.Max(global::System.Math.Min(350, num * 100), 100);
					if (this._isScrollingTimer == null)
					{
						this._isScrollingTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Render, base.Dispatcher);
						this._isScrollingTimer.Tick += this.OnIsScrollingTimerTick;
						base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsScrollingPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else if (this._isScrollingTimer.IsEnabled)
					{
						this._isScrollingTimer.Stop();
					}
					else
					{
						base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsScrollingPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					this._isScrollingTimer.Interval = global::System.TimeSpan.FromMilliseconds((double)num2);
					this._isScrollingTimer.Start();
					this._overallScrollPosition = global::System.Math.Max(0, global::System.Math.Min(value, ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this).OverallScrollCount - 1));
					if (this.CurrentPanel is global::Infragistics.Windows.DataPresenter.CardViewPanel)
					{
						((global::Infragistics.Windows.DataPresenter.CardViewPanel)this.CurrentPanel).SetScrollPosition(this._overallScrollPosition);
					}
					this.BumpRecordsInViewVersion();
				}
			}
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00046A38 File Offset: 0x00044C38
		bool global::Infragistics.Windows.DataPresenter.IViewPanelInfo.IsOkToScroll()
		{
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
			if (activeCell != null && activeCell.IsInEditMode && this._endEditOnScrollSuspendCount == 0)
			{
				global::Infragistics.Windows.DataPresenter.Record record = activeCell.Record;
				if (record != null && (!record.IsFixed || record.ParentRecord != null))
				{
					activeCell.EndEditMode(true, false);
					if (activeCell.IsInEditMode)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00046A8D File Offset: 0x00044C8D
		int global::Infragistics.Windows.DataPresenter.IViewPanelInfo.GetOverallScrollPositionForRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			if (record.DataPresenter != this)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_13"), "record");
			}
			return record.OverallScrollPosition;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00046AC4 File Offset: 0x00044CC4
		global::Infragistics.Windows.DataPresenter.Record global::Infragistics.Windows.DataPresenter.IViewPanelInfo.GetRecordAtOverallScrollPosition(int scrollPosition)
		{
			if (scrollPosition < 0)
			{
				return null;
			}
			int overallScrollCount = ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this).OverallScrollCount;
			if (scrollPosition >= overallScrollCount)
			{
				return null;
			}
			return this.ViewableRecords.GetRecordAtScrollPosition(scrollPosition);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00046AF0 File Offset: 0x00044CF0
		void global::Infragistics.Windows.DataPresenter.IViewPanelInfo.OnRecordsInViewChanged()
		{
			this.BumpRecordsInViewVersion();
			if (this.IsSynchronousControl)
			{
				this.NotifyAutoSizeInViewRecordsChanged();
				this.ProcessPostedRecordsInViewChanged(null);
				return;
			}
			if (this._postRecordsInViewChangedOperation == null)
			{
				this.NotifyAutoSizeInViewRecordsChanged();
				object arg = (this.CellContainerGenerationMode != global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode.PreLoad) ? base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollVersionProperty) : null;
				this._postRecordsInViewChangedOperation = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::System.Windows.Threading.DispatcherOperationCallback(this.ProcessPostedRecordsInViewChanged), arg);
			}
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00046B60 File Offset: 0x00044D60
		private void NotifyAutoSizeInViewRecordsChanged()
		{
			if (this.FieldLayoutAutoSizeRecordsInViewCount > 0)
			{
				int i = 0;
				int count = this._fieldLayouts.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayouts[i];
					if (fieldLayout.IsInitialRecordLoaded)
					{
						fieldLayout.AutoSizeInfo.OnRecordsInViewChanged();
					}
					i++;
				}
			}
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00046BB0 File Offset: 0x00044DB0
		global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginatorFactory.Create()
		{
			return new global::Infragistics.Windows.DataPresenter.DataPresenterReportControl(this);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00046BC5 File Offset: 0x00044DC5
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			return this.OnReceiveWeakEvent(managerType, sender, e);
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00046BD0 File Offset: 0x00044DD0
		double global::Infragistics.Controls.ISupportScrollHelper.HorizontalMax
		{
			get
			{
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
				if (scrollInfo != null && scrollInfo.CanHorizontallyScroll)
				{
					return global::System.Math.Max(scrollInfo.ExtentWidth - scrollInfo.ViewportWidth, 0.0);
				}
				return 0.0;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x00046C1C File Offset: 0x00044E1C
		global::Infragistics.Controls.ScrollType global::Infragistics.Controls.ISupportScrollHelper.HorizontalScrollType
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				if (!currentViewInternal.HasLogicalOrientation)
				{
					return global::Infragistics.Controls.ScrollType.Item;
				}
				if (currentViewInternal.LogicalOrientation != global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Controls.ScrollType.Item;
				}
				return global::Infragistics.Controls.ScrollType.Pixel;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00046C48 File Offset: 0x00044E48
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x00046C80 File Offset: 0x00044E80
		double global::Infragistics.Controls.ISupportScrollHelper.HorizontalValue
		{
			get
			{
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
				if (scrollInfo != null)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetScrollValueHelper(scrollInfo.HorizontalOffset, ref this._cachedHorizValue);
				}
				return 0.0;
			}
			set
			{
				this._cachedHorizValue = new double?(value);
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
				if (scrollInfo != null)
				{
					scrollInfo.SetHorizontalOffset(value);
				}
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x00046CB0 File Offset: 0x00044EB0
		double global::Infragistics.Controls.ISupportScrollHelper.VerticalMax
		{
			get
			{
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
				if (scrollInfo != null && scrollInfo.CanVerticallyScroll)
				{
					return global::System.Math.Max(scrollInfo.ExtentHeight - scrollInfo.ViewportHeight, 0.0);
				}
				return 0.0;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x00046CFC File Offset: 0x00044EFC
		global::Infragistics.Controls.ScrollType global::Infragistics.Controls.ISupportScrollHelper.VerticalScrollType
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				if (!currentViewInternal.HasLogicalOrientation)
				{
					return global::Infragistics.Controls.ScrollType.Item;
				}
				if (currentViewInternal.LogicalOrientation != global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Controls.ScrollType.Pixel;
				}
				return global::Infragistics.Controls.ScrollType.Item;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x00046D28 File Offset: 0x00044F28
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00046D60 File Offset: 0x00044F60
		double global::Infragistics.Controls.ISupportScrollHelper.VerticalValue
		{
			get
			{
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
				if (scrollInfo != null)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetScrollValueHelper(scrollInfo.VerticalOffset, ref this._cachedVertValue);
				}
				return 0.0;
			}
			set
			{
				this._cachedVertValue = new double?(value);
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this.CurrentPanel as global::System.Windows.Controls.Primitives.IScrollInfo;
				if (scrollInfo != null)
				{
					scrollInfo.SetVerticalOffset(value);
				}
			}
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00046D8F File Offset: 0x00044F8F
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemHeight()
		{
			return this.GetFirstItemExtentHelper(false);
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00046D98 File Offset: 0x00044F98
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemWidth()
		{
			return this.GetFirstItemExtentHelper(true);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00046DA4 File Offset: 0x00044FA4
		global::Infragistics.Controls.TouchScrollMode global::Infragistics.Controls.ISupportScrollHelper.GetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver)
		{
			if (elementDirectlyOver == null || !this.CurrentViewInternal.IsPanningModeSupported)
			{
				return global::Infragistics.Controls.TouchScrollMode.None;
			}
			global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
			global::Infragistics.Windows.DataPresenter.Field field = null;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			global::Infragistics.Windows.DataPresenter.DataItemPresenter dataItemPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(elementDirectlyOver, typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), true, this) as global::Infragistics.Windows.DataPresenter.DataItemPresenter;
			if (dataItemPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = dataItemPresenter as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
				if (cellValuePresenter != null)
				{
					if (cellValuePresenter.IsInEditMode)
					{
						return global::Infragistics.Controls.TouchScrollMode.None;
					}
					record = cellValuePresenter.Record;
					field = cellValuePresenter.Field;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.LabelPresenter labelPresenter = dataItemPresenter as global::Infragistics.Windows.DataPresenter.LabelPresenter;
					if (labelPresenter != null && !labelPresenter.IsInGroupByArea)
					{
						field = labelPresenter.Field;
						global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(labelPresenter, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, this) as global::Infragistics.Windows.DataPresenter.RecordPresenter;
						if (recordPresenter != null)
						{
							record = recordPresenter.Record;
						}
					}
				}
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter2 = global::Infragistics.Windows.Utilities.GetAncestorFromType(elementDirectlyOver, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true, this) as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				if (recordPresenter2 != null)
				{
					record = recordPresenter2.Record;
				}
			}
			bool flag = record != null && (record.NestingDepth >= 0 || !record.IsFixed);
			bool flag2 = (field == null && record != null) || (field != null && !field.IsFixed);
			if (!flag && !flag2)
			{
				return global::Infragistics.Controls.TouchScrollMode.None;
			}
			bool flag3;
			if (currentViewInternal.HasLogicalOrientation)
			{
				flag3 = (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical);
			}
			else
			{
				flag3 = (((global::Infragistics.Controls.ISupportScrollHelper)this).VerticalMax > 0.0);
				flag2 = false;
			}
			if (flag)
			{
				if (flag2)
				{
					return global::Infragistics.Controls.TouchScrollMode.Both;
				}
				if (flag3)
				{
					return global::Infragistics.Controls.TouchScrollMode.Vertical;
				}
				return global::Infragistics.Controls.TouchScrollMode.Horizontal;
			}
			else
			{
				if (!flag2)
				{
					return global::Infragistics.Controls.TouchScrollMode.None;
				}
				if (flag3)
				{
					return global::Infragistics.Controls.TouchScrollMode.Horizontal;
				}
				return global::Infragistics.Controls.TouchScrollMode.Vertical;
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00046F07 File Offset: 0x00045107
		void global::Infragistics.Controls.ISupportScrollHelper.InvalidateScrollLayout()
		{
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00046F09 File Offset: 0x00045109
		void global::Infragistics.Controls.ISupportScrollHelper.OnPanComplete()
		{
			this._cachedHorizValue = null;
			this._cachedVertValue = null;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00046F23 File Offset: 0x00045123
		void global::Infragistics.Controls.ISupportScrollHelper.OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
		}

		// Token: 0x04000521 RID: 1313
		private const int ExpandRecordAnimationDuration = 1000;

		// Token: 0x04000522 RID: 1314
		private const int CollapseRecordAnimationDuration = 700;

		// Token: 0x04000523 RID: 1315
		private const double DEFAULT_RECORD_HEIGHT = 20.0;

		// Token: 0x04000524 RID: 1316
		private global::Infragistics.Windows.Resizing.ResizeController _resizeController;

		// Token: 0x04000525 RID: 1317
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _selectedItems;

		// Token: 0x04000526 RID: 1318
		private global::System.Windows.Controls.Grid _contentSiteGrid;

		// Token: 0x04000527 RID: 1319
		private global::System.Windows.Controls.Grid _dataAreaGrid;

		// Token: 0x04000528 RID: 1320
		private global::System.Windows.FrameworkElement _contentSiteDataAreaContent;

		// Token: 0x04000529 RID: 1321
		private global::System.Windows.Controls.ItemsPanelTemplate _itemsPanel;

		// Token: 0x0400052A RID: 1322
		private global::System.Collections.IEnumerable _dataSourceRootList;

		// Token: 0x0400052B RID: 1323
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Helpers.EnumerableObjectWrapper> _dataSourceRootChildListWrappers;

		// Token: 0x0400052C RID: 1324
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceRootListChangeListener _dataSourceRootListChangeListener;

		// Token: 0x0400052D RID: 1325
		private global::Infragistics.Windows.DataPresenter.RecordListControl _rootRecordListControl;

		// Token: 0x0400052E RID: 1326
		private global::Infragistics.Windows.DataPresenter.RecordListControl _currentRecordListControl;

		// Token: 0x0400052F RID: 1327
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x04000530 RID: 1328
		private global::System.Collections.Generic.List<object> _logicalChildren = new global::System.Collections.Generic.List<object>();

		// Token: 0x04000531 RID: 1329
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataItemsCollection _dataItems;

		// Token: 0x04000532 RID: 1330
		private global::Infragistics.Windows.DataPresenter.FieldLayoutCollection _fieldLayouts;

		// Token: 0x04000533 RID: 1331
		private global::Infragistics.Windows.DataPresenter.FieldLayout _defaultLayout;

		// Token: 0x04000534 RID: 1332
		private global::Infragistics.Windows.DataPresenter.Record _activeRecord;

		// Token: 0x04000535 RID: 1333
		private global::Infragistics.Windows.DataPresenter.Cell _activeCell;

		// Token: 0x04000536 RID: 1334
		private global::Infragistics.Windows.DataPresenter.Record _pivotRecord;

		// Token: 0x04000537 RID: 1335
		private global::Infragistics.Windows.DataPresenter.Field _pivotField;

		// Token: 0x04000538 RID: 1336
		private global::Infragistics.Windows.DataPresenter.Cell _pivotCell;

		// Token: 0x04000539 RID: 1337
		private global::Infragistics.Windows.DataPresenter.EditModeHelper _editHelper;

		// Token: 0x0400053A RID: 1338
		private global::System.Windows.Point? _selectionPoint;

		// Token: 0x0400053B RID: 1339
		private bool _snaking;

		// Token: 0x0400053C RID: 1340
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _selectionSnapshot;

		// Token: 0x0400053D RID: 1341
		private global::Infragistics.Windows.Selection.ISelectionStrategyFilter _selectionStrategyFilter;

		// Token: 0x0400053E RID: 1342
		private global::System.Windows.Controls.StyleSelector _internalCellPresenterStyleSelector;

		// Token: 0x0400053F RID: 1343
		private global::System.Windows.Controls.StyleSelector _internalCellValuePresenterStyleSelector;

		// Token: 0x04000540 RID: 1344
		private global::System.Windows.Controls.StyleSelector _internalEditorStyleSelector;

		// Token: 0x04000541 RID: 1345
		private global::System.Windows.Controls.StyleSelector _internalExpandedCellStyleSelector;

		// Token: 0x04000542 RID: 1346
		private global::System.Windows.Controls.StyleSelector _internalLabelPresenterStyleSelector;

		// Token: 0x04000543 RID: 1347
		private global::System.Windows.Controls.StyleSelector _internalHeaderPresenterStyleSelector;

		// Token: 0x04000544 RID: 1348
		private global::System.Windows.Controls.StyleSelector _internalHeaderPrefixAreaStyleSelector;

		// Token: 0x04000545 RID: 1349
		private global::System.Windows.Controls.StyleSelector _internalHeaderLabelAreaStyleSelector;

		// Token: 0x04000546 RID: 1350
		private global::System.Windows.Controls.StyleSelector _internalRecordStyleSelector;

		// Token: 0x04000547 RID: 1351
		private global::System.Windows.Controls.StyleSelector _internalRecordCellAreaStyleSelector;

		// Token: 0x04000548 RID: 1352
		private global::System.Windows.Controls.StyleSelector _internalRecordSelectorStyleSelector;

		// Token: 0x04000549 RID: 1353
		private global::System.Windows.Controls.StyleSelector _internalRecordSelectorNumberStyleSelector;

		// Token: 0x0400054A RID: 1354
		private global::System.Windows.Threading.DispatcherOperation _pendingFilterCriteriaChanged;

		// Token: 0x0400054B RID: 1355
		private object _pendingSelectedDataItemsOperation;

		// Token: 0x0400054C RID: 1356
		private object _pendingActiveDataItem;

		// Token: 0x0400054D RID: 1357
		private bool _isSettingSelectedDataItems;

		// Token: 0x0400054E RID: 1358
		private global::System.Windows.Threading.DispatcherOperation _postRecordsInViewChangedOperation;

		// Token: 0x0400054F RID: 1359
		private global::System.Windows.Threading.DispatcherOperation _bumpScrollCountOperation;

		// Token: 0x04000550 RID: 1360
		internal global::Infragistics.Controls.TouchScrollHelper _scrollHelper;

		// Token: 0x04000551 RID: 1361
		private double? _cachedHorizValue;

		// Token: 0x04000552 RID: 1362
		private double? _cachedVertValue;

		// Token: 0x04000553 RID: 1363
		private double _previousFirstItemWidth = 20.0;

		// Token: 0x04000554 RID: 1364
		private double _previousFirstItemHeight = 20.0;

		// Token: 0x04000555 RID: 1365
		private global::Infragistics.Shared.DynamicResourceString _recordNumberSeparator;

		// Token: 0x04000556 RID: 1366
		private global::Infragistics.Windows.DataPresenter.DynamicResourceTracker _recordNumberSeparatorTracker;

		// Token: 0x04000557 RID: 1367
		private bool _clearingActiveCell;

		// Token: 0x04000558 RID: 1368
		private bool _dataSourceHasBeenCleared;

		// Token: 0x04000559 RID: 1369
		private int _groupbyVersion;

		// Token: 0x0400055A RID: 1370
		private int _renderVersion;

		// Token: 0x0400055B RID: 1371
		private int _cachedOverallScrollCount;

		// Token: 0x0400055C RID: 1372
		internal bool _cachedOverallScrollCountDirty = true;

		// Token: 0x0400055D RID: 1373
		private int _overallScrollPosition;

		// Token: 0x0400055E RID: 1374
		private global::Infragistics.Windows.Helpers.HashSet _layoutUpdatedCallbacks;

		// Token: 0x0400055F RID: 1375
		private global::Infragistics.Windows.DataPresenter.GroupByArea _groupByArea;

		// Token: 0x04000560 RID: 1376
		private global::Infragistics.Windows.DataPresenter.GroupByAreaMulti _groupByAreaMulti;

		// Token: 0x04000561 RID: 1377
		private global::Infragistics.Windows.DataPresenter.ViewBase _currentViewInternal;

		// Token: 0x04000562 RID: 1378
		private bool _forceClearActiveRecord;

		// Token: 0x04000563 RID: 1379
		private bool _isRecordManagerDataSourceInitialized;

		// Token: 0x04000564 RID: 1380
		private global::System.Windows.Threading.DispatcherOperation _asyncChangePending;

		// Token: 0x04000565 RID: 1381
		private bool _invalidateGeneratedStylesPending;

		// Token: 0x04000566 RID: 1382
		private bool? _invalidateTemplatesWithPendingGeneratedStyles;

		// Token: 0x04000567 RID: 1383
		private bool _haveAnyTemplatesBeenGenerated;

		// Token: 0x04000568 RID: 1384
		private global::System.Globalization.CultureInfo _defaultConverterCulture;

		// Token: 0x04000569 RID: 1385
		private global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.RecordPresenter> _recordsPendingNestedContentInitialization;

		// Token: 0x0400056A RID: 1386
		private global::Infragistics.Windows.DataPresenter.CustomizationsManager _customizationsManager;

		// Token: 0x0400056B RID: 1387
		private bool _isLoadingCustomizations;

		// Token: 0x0400056C RID: 1388
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.RecordManager> _nonRootCurrencyTrackingManagers;

		// Token: 0x0400056D RID: 1389
		private global::Infragistics.Windows.DataPresenter.FieldDragManager _fieldDragManager;

		// Token: 0x0400056E RID: 1390
		private global::System.Windows.Input.MouseButtonEventArgs _previewMouseDownArgs;

		// Token: 0x0400056F RID: 1391
		internal global::Infragistics.Windows.DataPresenter.Record _activeRecordWithPendingDirtyFilterState;

		// Token: 0x04000570 RID: 1392
		private global::Infragistics.Windows.Selection.ISelectableItem _itemPendingScrollItemIntoView;

		// Token: 0x04000571 RID: 1393
		private bool _bypassScrollIntoView;

		// Token: 0x04000572 RID: 1394
		private global::Infragistics.Windows.DataPresenter.Record _initializeRecordSuspendedFor;

		// Token: 0x04000573 RID: 1395
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _initializeRecordSuspendedFor_List;

		// Token: 0x04000574 RID: 1396
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _pendingActiveRecordPresenter;

		// Token: 0x04000575 RID: 1397
		private global::Infragistics.Windows.DataPresenter.DataPresenterHistory _history;

		// Token: 0x04000576 RID: 1398
		private global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo _clipboardOperationInfo;

		// Token: 0x04000577 RID: 1399
		private bool _initialResizeIsPending;

		// Token: 0x04000578 RID: 1400
		private global::Infragistics.Windows.Controls.ToolWindow _retainedFieldChooserWindow;

		// Token: 0x04000579 RID: 1401
		internal global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser> _registeredFieldChoosers;

		// Token: 0x0400057A RID: 1402
		private int _endEditOnScrollSuspendCount;

		// Token: 0x0400057B RID: 1403
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> _fieldLayoutsAutoSizePending;

		// Token: 0x0400057C RID: 1404
		private int _fieldLayoutAutoSizeViewableCount;

		// Token: 0x0400057D RID: 1405
		private int _fieldLayoutAutoSizeAllRecordsCount;

		// Token: 0x0400057E RID: 1406
		private int _allRecordsAutoSizeMaxDepth = -1;

		// Token: 0x0400057F RID: 1407
		private global::System.Windows.Threading.DispatcherOperation _pendingFieldAutoSize;

		// Token: 0x04000580 RID: 1408
		private bool _processingFieldAutoSize;

		// Token: 0x04000581 RID: 1409
		private int _fieldLayoutAutoSizeRecordsInViewCount;

		// Token: 0x04000582 RID: 1410
		private bool _isExporting;

		// Token: 0x04000583 RID: 1411
		private bool _suppressExportingDataSourceException;

		// Token: 0x04000584 RID: 1412
		internal int _cachedScrollCountRecalcVersion;

		// Token: 0x04000585 RID: 1413
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock.VisibleDataBlockCache> _lastVisibleDataBlocks;

		// Token: 0x04000586 RID: 1414
		private global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs> _cellsInViewChangedEventHandler;

		// Token: 0x04000587 RID: 1415
		internal bool _pendingRaiseCellsInViewChangedAsyncHelperHandler;

		// Token: 0x04000588 RID: 1416
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.AsyncPageCommand _asyncCommand;

		// Token: 0x04000589 RID: 1417
		private bool _isInPageUpDown;

		// Token: 0x0400058A RID: 1418
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.KeyDownInfo _lastKeyDownInfo;

		// Token: 0x0400058B RID: 1419
		private global::Infragistics.Windows.DataPresenter.SuppressedEventsCollection _suppressedEvents;

		// Token: 0x0400058C RID: 1420
		internal readonly bool _isDerived;

		// Token: 0x0400058D RID: 1421
		internal bool? _cachedInitializeRecordEventSuppressed;

		// Token: 0x0400058E RID: 1422
		private double _lastScrollDimensionExtent;

		// Token: 0x0400058F RID: 1423
		private bool _cachedIsUndoEnabled;

		// Token: 0x04000590 RID: 1424
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.FixedAreaScrollHelper _fixedScrollHelper;

		// Token: 0x04000591 RID: 1425
		private global::Infragistics.Windows.DataPresenter.ExportHelper _exportHelper;

		// Token: 0x04000592 RID: 1426
		internal global::Infragistics.Windows.DataPresenter.Record _recordWhoseChangesAreBeingDiscarded;

		// Token: 0x04000593 RID: 1427
		internal global::System.Windows.Threading.DispatcherTimer _isScrollingTimer;

		// Token: 0x04000594 RID: 1428
		private global::System.Windows.Threading.DispatcherOperation _bumpRecordNumberVersionPending;

		// Token: 0x04000595 RID: 1429
		private global::System.Windows.Size _lastMeasureSize;

		// Token: 0x04000596 RID: 1430
		private double _cachedRecordSelectorExtent = double.NaN;

		// Token: 0x04000597 RID: 1431
		private double _cachedRecordSelectorFixButtonExtent = double.NaN;

		// Token: 0x04000598 RID: 1432
		private double _cachedRecordSelectorErrorIconExtent = double.NaN;

		// Token: 0x04000599 RID: 1433
		private int _commandsBeingExecuted;

		// Token: 0x0400059A RID: 1434
		private bool _processingPreviewLostKeyoardFocus;

		// Token: 0x0400059B RID: 1435
		private object _recordOrCellBeingActivated;

		// Token: 0x0400059C RID: 1436
		private global::System.Type _typeBeingSelected;

		// Token: 0x0400059D RID: 1437
		private global::System.WeakReference _previousSelectedRecord;

		// Token: 0x0400059E RID: 1438
		private global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager _treeFilterManager;

		// Token: 0x0400059F RID: 1439
		private bool _hadApplicationCurrent;

		// Token: 0x040005E4 RID: 1508
		private global::System.Type _selectedItemsChangePending;

		// Token: 0x040005EB RID: 1515
		public static readonly global::System.Windows.DependencyProperty ActiveDataItemProperty;

		// Token: 0x040005EC RID: 1516
		public static readonly global::System.Windows.DependencyProperty ActiveCellProperty;

		// Token: 0x040005ED RID: 1517
		private global::Infragistics.Windows.DataPresenter.Cell _cachedLastActiveCell;

		// Token: 0x040005EE RID: 1518
		public static readonly global::System.Windows.DependencyProperty ActiveRecordProperty;

		// Token: 0x040005EF RID: 1519
		public static readonly global::System.Windows.DependencyProperty AutoFitProperty;

		// Token: 0x040005F0 RID: 1520
		private bool? _cachedAutoFit;

		// Token: 0x040005F1 RID: 1521
		public static readonly global::System.Windows.DependencyProperty BindToSampleDataProperty;

		// Token: 0x040005F2 RID: 1522
		public static readonly global::System.Windows.DependencyProperty CalculationAdapterProperty;

		// Token: 0x040005F3 RID: 1523
		internal global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapterInternal _calculationAdapter;

		// Token: 0x040005F4 RID: 1524
		public static readonly global::System.Windows.DependencyProperty CellContainerGenerationModeProperty;

		// Token: 0x040005F5 RID: 1525
		private global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode _cachedCellContainerGenerationMode;

		// Token: 0x040005F6 RID: 1526
		public static readonly global::System.Windows.DependencyProperty ClipboardCellDelimiterProperty;

		// Token: 0x040005F7 RID: 1527
		public static readonly global::System.Windows.DependencyProperty ClipboardCellSeparatorProperty;

		// Token: 0x040005F8 RID: 1528
		public static readonly global::System.Windows.DependencyProperty ClipboardRecordSeparatorProperty;

		// Token: 0x040005F9 RID: 1529
		public static readonly global::System.Windows.DependencyProperty CurrentViewProperty;

		// Token: 0x040005FA RID: 1530
		public static readonly global::System.Windows.ResourceKey DataErrorContentTemplateKey;

		// Token: 0x040005FB RID: 1531
		public static readonly global::System.Windows.ResourceKey DataErrorIconStyleKey;

		// Token: 0x040005FC RID: 1532
		private global::System.Collections.Generic.IEqualityComparer<object> _dataItemEqualityComparerResolved;

		// Token: 0x040005FD RID: 1533
		public static readonly global::System.Windows.DependencyProperty DataItemEqualityComparerProperty;

		// Token: 0x040005FE RID: 1534
		public static readonly global::System.Windows.DependencyProperty DataSourceProperty;

		// Token: 0x040005FF RID: 1535
		public static readonly global::System.Windows.DependencyProperty DataSourceResetBehaviorProperty;

		// Token: 0x04000600 RID: 1536
		public static readonly global::System.Windows.DependencyProperty DropIndicatorClipBehaviorProperty;

		// Token: 0x04000601 RID: 1537
		private global::Infragistics.Windows.DataPresenter.RecordExportStatus _cachedExportStatus;

		// Token: 0x04000602 RID: 1538
		private static readonly global::System.Windows.DependencyPropertyKey ExportStatusPropertyKey;

		// Token: 0x04000603 RID: 1539
		public static readonly global::System.Windows.DependencyProperty ExportStatusProperty;

		// Token: 0x04000604 RID: 1540
		public static readonly global::System.Windows.ResourceKey FieldChooserButtonStyleKey;

		// Token: 0x04000605 RID: 1541
		public static readonly global::System.Windows.DependencyProperty FieldLayoutSettingsProperty;

		// Token: 0x04000606 RID: 1542
		private global::Infragistics.Windows.DataPresenter.FieldLayoutSettings _x_FieldLayoutSettings;

		// Token: 0x04000607 RID: 1543
		public static readonly global::System.Windows.DependencyProperty FieldSettingsProperty;

		// Token: 0x04000608 RID: 1544
		private global::Infragistics.Windows.DataPresenter.FieldSettings _x_FieldSettings;

		// Token: 0x04000609 RID: 1545
		public static readonly global::System.Windows.ResourceKey FilterCellClearButtonStyleKey;

		// Token: 0x0400060A RID: 1546
		public static readonly global::System.Windows.ResourceKey FilterDropDownLoadingTemplateKey;

		// Token: 0x0400060B RID: 1547
		public static readonly global::System.Windows.ResourceKey FilterRecordClearButtonStyleKey;

		// Token: 0x0400060C RID: 1548
		public static readonly global::System.Windows.DependencyProperty GroupByAreaProperty;

		// Token: 0x0400060D RID: 1549
		public static readonly global::System.Windows.DependencyProperty GroupByAreaFieldLabelStyleProperty;

		// Token: 0x0400060E RID: 1550
		public static readonly global::System.Windows.DependencyProperty GroupByAreaFieldLabelStyleSelectorProperty;

		// Token: 0x0400060F RID: 1551
		public static readonly global::System.Windows.DependencyProperty GroupByAreaLocationProperty;

		// Token: 0x04000610 RID: 1552
		public static readonly global::System.Windows.DependencyProperty GroupByAreaModeProperty;

		// Token: 0x04000611 RID: 1553
		public static readonly global::System.Windows.DependencyProperty GroupByAreaMultiProperty;

		// Token: 0x04000612 RID: 1554
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static readonly global::System.Windows.DependencyProperty GroupByAreaStyleProperty;

		// Token: 0x04000613 RID: 1555
		private static readonly global::System.Windows.DependencyPropertyKey IsExportingPropertyKey;

		// Token: 0x04000614 RID: 1556
		public static readonly global::System.Windows.DependencyProperty IsExportingProperty;

		// Token: 0x04000615 RID: 1557
		public static readonly global::System.Windows.DependencyProperty IsGroupByAreaExpandedProperty;

		// Token: 0x04000616 RID: 1558
		public static readonly global::System.Windows.DependencyProperty IsNestedDataDisplayEnabledProperty;

		// Token: 0x04000617 RID: 1559
		private bool _cachedIsNestedDataDisplayEnabled;

		// Token: 0x04000618 RID: 1560
		public static readonly global::System.Windows.DependencyProperty IsSynchronizedWithCurrentItemProperty;

		// Token: 0x04000619 RID: 1561
		public static readonly global::System.Windows.DependencyProperty IsTouchSupportEnabledProperty;

		// Token: 0x0400061A RID: 1562
		public static readonly global::System.Windows.DependencyProperty IsUndoEnabledProperty;

		// Token: 0x0400061B RID: 1563
		public static readonly global::System.Windows.DependencyProperty RecordContainerGenerationModeProperty;

		// Token: 0x0400061C RID: 1564
		public static readonly global::System.Windows.DependencyProperty RecordLoadModeProperty;

		// Token: 0x0400061D RID: 1565
		private static readonly global::System.Windows.DependencyPropertyKey RecordsPropertyKey;

		// Token: 0x0400061E RID: 1566
		public static readonly global::System.Windows.DependencyProperty RecordsProperty;

		// Token: 0x0400061F RID: 1567
		public static readonly global::System.Windows.DependencyProperty RecordSelectorExtentProperty;

		// Token: 0x04000620 RID: 1568
		public static readonly global::System.Windows.DependencyProperty RecordSelectorErrorIconExtentProperty;

		// Token: 0x04000621 RID: 1569
		public static readonly global::System.Windows.DependencyProperty RecordSelectorFixButtonExtentProperty;

		// Token: 0x04000622 RID: 1570
		public static readonly global::System.Windows.DependencyProperty ReportViewProperty;

		// Token: 0x04000623 RID: 1571
		public static readonly global::System.Windows.DependencyProperty RecordContainerRetentionModeProperty;

		// Token: 0x04000624 RID: 1572
		public static readonly global::System.Windows.DependencyProperty ScrollBehaviorOnListChangeProperty;

		// Token: 0x04000625 RID: 1573
		public static readonly global::System.Windows.DependencyProperty ScrollingModeProperty;

		// Token: 0x04000626 RID: 1574
		public static readonly global::System.Windows.DependencyProperty SelectedDataItemProperty;

		// Token: 0x04000627 RID: 1575
		public static readonly global::System.Windows.DependencyProperty SelectedDataItemsProperty;

		// Token: 0x04000628 RID: 1576
		public static readonly global::System.Windows.DependencyProperty SelectedDataItemsScopeProperty;

		// Token: 0x04000629 RID: 1577
		public static readonly global::System.Windows.DependencyProperty SortRecordsByDataTypeProperty;

		// Token: 0x0400062A RID: 1578
		public static readonly global::System.Windows.DependencyProperty SummaryCellContainerGenerationModeProperty;

		// Token: 0x0400062B RID: 1579
		public static readonly global::System.Windows.DependencyProperty ThemeProperty;

		// Token: 0x0400062D RID: 1581
		private global::System.Windows.ResourceDictionary _themeRegistered_DP_ResourceSet;

		// Token: 0x0400062E RID: 1582
		public static readonly global::System.Windows.DependencyProperty UndoLimitProperty;

		// Token: 0x0400062F RID: 1583
		public static readonly global::System.Windows.DependencyProperty UpdateModeProperty;

		// Token: 0x04000630 RID: 1584
		private static readonly global::System.Windows.DependencyPropertyKey ViewableRecordsPropertyKey;

		// Token: 0x04000631 RID: 1585
		public static readonly global::System.Windows.DependencyProperty ViewableRecordsProperty;

		// Token: 0x04000632 RID: 1586
		public static readonly global::System.Windows.DependencyProperty DataPresenterProperty;

		// Token: 0x04000633 RID: 1587
		private static readonly global::System.Windows.DependencyPropertyKey DataSourceInternalPropertyKey;

		// Token: 0x04000634 RID: 1588
		internal static readonly global::System.Windows.DependencyProperty DataSourceInternalProperty;

		// Token: 0x04000635 RID: 1589
		internal static readonly global::System.Windows.DependencyProperty GridMeasureVersionProperty;

		// Token: 0x04000636 RID: 1590
		private static readonly global::System.Windows.DependencyProperty InternalRecordsProperty;

		// Token: 0x04000637 RID: 1591
		private static readonly global::System.Windows.DependencyPropertyKey IsScrollingPropertyKey;

		// Token: 0x04000638 RID: 1592
		internal static readonly global::System.Windows.DependencyProperty IsScrollingProperty;

		// Token: 0x04000639 RID: 1593
		private static readonly global::System.Windows.DependencyPropertyKey ItemsPanelPropertyKey;

		// Token: 0x0400063A RID: 1594
		internal static readonly global::System.Windows.DependencyProperty ItemsPanelProperty;

		// Token: 0x0400063B RID: 1595
		internal static readonly global::System.Windows.DependencyProperty OverallSortVersionProperty;

		// Token: 0x0400063C RID: 1596
		private static readonly global::System.Windows.DependencyProperty PanelSettingsProperty;

		// Token: 0x0400063D RID: 1597
		private static readonly global::System.Windows.DependencyPropertyKey RecordNumberVersionPropertyKey;

		// Token: 0x0400063E RID: 1598
		internal static readonly global::System.Windows.DependencyProperty RecordNumberVersionProperty;

		// Token: 0x0400063F RID: 1599
		private static readonly global::System.Windows.DependencyPropertyKey RecordsInViewVersionPropertyKey;

		// Token: 0x04000640 RID: 1600
		internal static readonly global::System.Windows.DependencyProperty RecordsInViewVersionProperty;

		// Token: 0x04000641 RID: 1601
		private static readonly global::System.Windows.DependencyPropertyKey RenderVersionPropertyKey;

		// Token: 0x04000642 RID: 1602
		internal static readonly global::System.Windows.DependencyProperty RenderVersionProperty;

		// Token: 0x04000643 RID: 1603
		internal static readonly global::System.Windows.DependencyProperty ScrollableRecordCountVersionProperty;

		// Token: 0x04000644 RID: 1604
		internal static readonly global::System.Windows.DependencyProperty ScrollCountRecalcVersionProperty;

		// Token: 0x04000645 RID: 1605
		internal static readonly global::System.Windows.DependencyProperty ScrollVersionProperty;

		// Token: 0x04000646 RID: 1606
		private static readonly global::System.Windows.DependencyPropertyKey HorizontalScrollBarVisibilityPropertyKey;

		// Token: 0x04000647 RID: 1607
		private static readonly global::System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty;

		// Token: 0x04000648 RID: 1608
		private static readonly global::System.Windows.DependencyPropertyKey VerticalScrollBarVisibilityPropertyKey;

		// Token: 0x04000649 RID: 1609
		private static readonly global::System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty;

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x06000FE6 RID: 4070
		private delegate void DataErrorMessageDelegate(string message, string title, global::System.Windows.MessageBoxButton buttons, global::System.Windows.MessageBoxImage image, bool processAsyncOnException);

		// Token: 0x020000EA RID: 234
		// (Invoke) Token: 0x06000FEA RID: 4074
		private delegate void ProcessSortCriteria(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout);

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x06000FEE RID: 4078
		private delegate void RefocusActiveCellDelegate(int? selectionStart, int? selectionLength);

		// Token: 0x020000EC RID: 236
		public class DataItemsCollection : global::System.Collections.ObjectModel.ObservableCollection<object>
		{
			// Token: 0x06000FF1 RID: 4081 RVA: 0x00046F25 File Offset: 0x00045125
			internal DataItemsCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
			{
				this._dp = dp;
			}

			// Token: 0x06000FF2 RID: 4082 RVA: 0x00046F34 File Offset: 0x00045134
			protected override void ClearItems()
			{
				foreach (object child in this)
				{
					this._dp.InternalRemoveLogicalChild(child);
				}
				base.ClearItems();
			}

			// Token: 0x06000FF3 RID: 4083 RVA: 0x00046F88 File Offset: 0x00045188
			protected override void InsertItem(int index, object item)
			{
				if (this._dp.DataSource != null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_8"));
				}
				base.InsertItem(index, item);
				if (this._dp.DataSourceInternal != this)
				{
					this._dp.InitializeRecordManagerDataSource();
				}
				this._dp.InternalAddLogicalChild(item);
			}

			// Token: 0x06000FF4 RID: 4084 RVA: 0x00046FDF File Offset: 0x000451DF
			protected override void MoveItem(int oldIndex, int newIndex)
			{
				base.MoveItem(oldIndex, newIndex);
			}

			// Token: 0x06000FF5 RID: 4085 RVA: 0x00046FEC File Offset: 0x000451EC
			protected override void RemoveItem(int index)
			{
				object child = base[index];
				base.RemoveItem(index);
				this._dp.InternalRemoveLogicalChild(child);
			}

			// Token: 0x06000FF6 RID: 4086 RVA: 0x00047014 File Offset: 0x00045214
			protected override void SetItem(int index, object item)
			{
				object child = base[index];
				base.SetItem(index, item);
				this._dp.InternalRemoveLogicalChild(child);
				this._dp.InternalAddLogicalChild(item);
			}

			// Token: 0x0400064C RID: 1612
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;
		}

		// Token: 0x020000ED RID: 237
		private class DataSourceRootListChangeListener : global::System.Windows.IWeakEventListener
		{
			// Token: 0x06000FF7 RID: 4087 RVA: 0x00047049 File Offset: 0x00045249
			internal DataSourceRootListChangeListener(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
			{
				this._dataPresenter = dataPresenter;
			}

			// Token: 0x06000FF8 RID: 4088 RVA: 0x00047058 File Offset: 0x00045258
			bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
			{
				if (managerType == typeof(global::System.Collections.Specialized.CollectionChangedEventManager) && e is global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)
				{
					this._dataPresenter.OnRootCollectionChanged();
					return true;
				}
				if (managerType == typeof(global::Infragistics.Windows.Helpers.BindingListChangedEventManager) && e is global::System.ComponentModel.ListChangedEventArgs)
				{
					this._dataPresenter.OnRootCollectionChanged();
					return true;
				}
				return false;
			}

			// Token: 0x0400064D RID: 1613
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;
		}

		// Token: 0x020000EE RID: 238
		private class RangeSelectionEvaluator
		{
			// Token: 0x06000FF9 RID: 4089 RVA: 0x000470B4 File Offset: 0x000452B4
			internal RangeSelectionEvaluator(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter, global::Infragistics.Windows.DataPresenter.Record pivotRecord, global::Infragistics.Windows.DataPresenter.Record record, bool snaking)
			{
				if (presenter == null)
				{
					throw new global::System.ArgumentNullException("presenter", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (pivotRecord == null)
				{
					throw new global::System.ArgumentNullException("pivotRecord", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (record == null)
				{
					throw new global::System.ArgumentNullException("Record", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				this._dataPresenter = presenter;
				this._pivotRecord = pivotRecord;
				this._endOfRangeRecord = record;
				this._snaking = snaking;
				this.Initialize();
			}

			// Token: 0x06000FFA RID: 4090 RVA: 0x00047134 File Offset: 0x00045334
			internal RangeSelectionEvaluator(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter, global::Infragistics.Windows.DataPresenter.Cell pivotCell, global::Infragistics.Windows.DataPresenter.Cell cell, bool snaking)
			{
				if (presenter == null)
				{
					throw new global::System.ArgumentNullException("presenter", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (pivotCell == null)
				{
					throw new global::System.ArgumentNullException("pivotCell", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (cell == null)
				{
					throw new global::System.ArgumentNullException("Cell", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				this._dataPresenter = presenter;
				this._pivotCell = pivotCell;
				this._pivotRecord = pivotCell.Record;
				this._pivotField = pivotCell.Field;
				this._endOfRangeCell = cell;
				this._endOfRangeRecord = cell.Record;
				this._endOfRangeField = cell.Field;
				this._snaking = snaking;
				this.Initialize();
			}

			// Token: 0x06000FFB RID: 4091 RVA: 0x000471E4 File Offset: 0x000453E4
			internal RangeSelectionEvaluator(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter, global::Infragistics.Windows.DataPresenter.Field pivotField, global::Infragistics.Windows.DataPresenter.Field field, bool snaking)
			{
				if (presenter == null)
				{
					throw new global::System.ArgumentNullException("presenter", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (pivotField == null)
				{
					throw new global::System.ArgumentNullException("pivotField", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (field == null)
				{
					throw new global::System.ArgumentNullException("Field", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				this._dataPresenter = presenter;
				this._pivotField = pivotField;
				this._endOfRangeField = field;
				this._snaking = snaking;
				this.Initialize();
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00047262 File Offset: 0x00045462
			internal global::Infragistics.Windows.DataPresenter.Cell EndOfRangeCell
			{
				get
				{
					return this._endOfRangeCell;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06000FFD RID: 4093 RVA: 0x0004726A File Offset: 0x0004546A
			internal global::Infragistics.Windows.DataPresenter.Field EndOfRangeField
			{
				get
				{
					return this._endOfRangeField;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00047272 File Offset: 0x00045472
			internal global::Infragistics.Windows.DataPresenter.Record EndOfRangeRecord
			{
				get
				{
					return this._endOfRangeRecord;
				}
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0004727A File Offset: 0x0004547A
			internal bool IsRangeOfCells
			{
				get
				{
					return this._pivotCell != null;
				}
			}

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x06001000 RID: 4096 RVA: 0x00047288 File Offset: 0x00045488
			internal bool IsRangeOfFields
			{
				get
				{
					return this._pivotField != null && !this.IsRangeOfCells;
				}
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06001001 RID: 4097 RVA: 0x0004729D File Offset: 0x0004549D
			internal bool IsRangeOfRecords
			{
				get
				{
					return this._pivotRecord != null && !this.IsRangeOfRecords;
				}
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06001002 RID: 4098 RVA: 0x000472B2 File Offset: 0x000454B2
			internal global::Infragistics.Windows.DataPresenter.Cell PivotCell
			{
				get
				{
					return this._pivotCell;
				}
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06001003 RID: 4099 RVA: 0x000472BA File Offset: 0x000454BA
			internal global::Infragistics.Windows.DataPresenter.Field PivotField
			{
				get
				{
					return this._pivotField;
				}
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06001004 RID: 4100 RVA: 0x000472C2 File Offset: 0x000454C2
			internal global::Infragistics.Windows.DataPresenter.Record PivotRecord
			{
				get
				{
					return this._pivotRecord;
				}
			}

			// Token: 0x06001005 RID: 4101 RVA: 0x000472CC File Offset: 0x000454CC
			internal static int CompareFieldPositions(ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition position1, ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition position2)
			{
				if (position1.Row == position2.Row)
				{
					if (position1.Column == position2.Column)
					{
						return 0;
					}
					if (position1.Column < position2.Column)
					{
						return 1;
					}
					if (position1.Column > position2.Column)
					{
						return -1;
					}
				}
				if (position1.Row < position2.Row)
				{
					return 1;
				}
				return -1;
			}

			// Token: 0x06001006 RID: 4102 RVA: 0x00047334 File Offset: 0x00045534
			internal static bool IsPositionInFieldRectangle(ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition fromPosition, ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition thruPosition, ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition testPosition)
			{
				int num = global::System.Math.Min(fromPosition.Row, thruPosition.Row);
				int num2 = global::System.Math.Max(fromPosition.Row + fromPosition.RowSpan, thruPosition.Row + thruPosition.RowSpan);
				int num3 = global::System.Math.Min(fromPosition.Column, thruPosition.Column);
				int num4 = global::System.Math.Max(fromPosition.Column + fromPosition.ColumnSpan, thruPosition.Column + thruPosition.ColumnSpan);
				return testPosition.Row >= num && testPosition.Row + testPosition.RowSpan <= num2 && testPosition.Column >= num3 && testPosition.Column + testPosition.ColumnSpan <= num4;
			}

			// Token: 0x06001007 RID: 4103 RVA: 0x000473F0 File Offset: 0x000455F0
			internal bool IsPositionInRectangularCellSlice(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition fieldGridPosition = (this._fieldMap != null) ? this._fieldMap.GetPositionInMap(field) : field.GridPosition;
				int num;
				int num2;
				int num3;
				int num4;
				int num5;
				int num6;
				if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					num = this._pivotFieldPosition.Column;
					num2 = this._pivotFieldPosition.ColumnSpan;
					num3 = this._endOfRangeFieldPosition.Column;
					num4 = this._endOfRangeFieldPosition.ColumnSpan;
					num5 = fieldGridPosition.Column;
					num6 = fieldGridPosition.ColumnSpan;
				}
				else
				{
					num = this._pivotFieldPosition.Row;
					num2 = this._pivotFieldPosition.RowSpan;
					num3 = this._endOfRangeFieldPosition.Row;
					num4 = this._endOfRangeFieldPosition.RowSpan;
					num5 = fieldGridPosition.Row;
					num6 = fieldGridPosition.RowSpan;
				}
				int num7 = global::System.Math.Max(num + num2, num3 + num4);
				int num8;
				if (num <= num3)
				{
					num8 = num;
				}
				else
				{
					num8 = num3;
				}
				if (num5 < num8 || num5 + num6 > num7)
				{
					return false;
				}
				if (record == this._pivotRecord || record == this._endOfRangeRecord)
				{
					if (this._gridViewOrientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						num = this._pivotFieldPosition.Row;
						num2 = this._pivotFieldPosition.RowSpan;
						num3 = this._endOfRangeFieldPosition.Row;
						num4 = this._endOfRangeFieldPosition.RowSpan;
						num5 = fieldGridPosition.Row;
						num6 = fieldGridPosition.RowSpan;
					}
					else
					{
						num = this._pivotFieldPosition.Column;
						num2 = this._pivotFieldPosition.ColumnSpan;
						num3 = this._endOfRangeFieldPosition.Column;
						num4 = this._endOfRangeFieldPosition.ColumnSpan;
						num5 = fieldGridPosition.Column;
						num6 = fieldGridPosition.ColumnSpan;
					}
					if (record == this._pivotRecord)
					{
						if (this._isPivotLessThanEnd)
						{
							return num5 >= num;
						}
						return num5 + num6 <= num + num2;
					}
					else if (record == this._endOfRangeRecord)
					{
						if (this._isPivotLessThanEnd)
						{
							return num5 + num6 <= num3 + num4;
						}
						return num5 >= num3;
					}
				}
				return true;
			}

			// Token: 0x06001008 RID: 4104 RVA: 0x000475CC File Offset: 0x000457CC
			internal bool IsCellInRange(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field, bool excludePivot, bool excludeEndRange)
			{
				field = this.GetMappedField(field);
				if (record == null || field == null || this._pivotCell == null || this._endOfRangeCell == null)
				{
					return false;
				}
				if (field == this._pivotCell.Field && record == this._pivotCell.Record)
				{
					return !excludePivot;
				}
				if (field == this._endOfRangeCell.Field && record == this._endOfRangeCell.Record)
				{
					return !excludeEndRange;
				}
				if (field.VisibilityResolved != global::System.Windows.Visibility.Visible || field.CellContentAlignmentResolved == global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly || field.IsExpandableResolved)
				{
					return false;
				}
				bool flag = this.IsRecordInRange(record, this._snaking, this._snaking);
				if (this._snaking)
				{
					if (flag)
					{
						return true;
					}
					if (this._pivotRecord == this._endOfRangeRecord)
					{
						return this.IsFieldInRange(field, false, false);
					}
					if (this._pivotRecord != record && this._endOfRangeRecord != record)
					{
						return false;
					}
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition fieldGridPosition = (this._fieldMap != null) ? this._fieldMap.GetPositionInMap(field) : field.GridPosition;
					int num;
					if (this._isPivotLessThanEnd)
					{
						num = -1;
					}
					else
					{
						num = 1;
					}
					int num2;
					if (this._pivotRecord == record)
					{
						num *= -1;
						num2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._pivotFieldPosition, ref fieldGridPosition);
					}
					else
					{
						num2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._endOfRangeFieldPosition, ref fieldGridPosition);
					}
					if (num >= 0)
					{
						return num2 >= 0;
					}
					return num2 <= 0;
				}
				else
				{
					if (!flag)
					{
						return false;
					}
					if (this._pivotRecord == this._endOfRangeRecord || !this._isGridView)
					{
						return this.IsFieldInRange(field, false, false);
					}
					return this.IsPositionInRectangularCellSlice(record, field);
				}
			}

			// Token: 0x06001009 RID: 4105 RVA: 0x00047740 File Offset: 0x00045940
			internal bool IsFieldInRange(global::Infragistics.Windows.DataPresenter.Field field, bool excludePivot, bool excludeEndRange)
			{
				field = this.GetMappedField(field);
				if (field == null)
				{
					return false;
				}
				if (field.VisibilityResolved != global::System.Windows.Visibility.Visible || field.IsExpandableResolved)
				{
					return false;
				}
				if (field == this._pivotField)
				{
					return !excludePivot;
				}
				if (field == this._endOfRangeField)
				{
					return !excludeEndRange;
				}
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition fieldGridPosition = (this._fieldMap != null) ? this._fieldMap.GetPositionInMap(field) : field.GridPosition;
				if (!this._snaking)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.IsPositionInFieldRectangle(ref this._pivotFieldPosition, ref this._endOfRangeFieldPosition, ref fieldGridPosition);
				}
				int num = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._pivotFieldPosition, ref this._endOfRangeFieldPosition);
				int num2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._pivotFieldPosition, ref fieldGridPosition);
				if (num == 0)
				{
					return num2 == 0;
				}
				int num3 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._endOfRangeFieldPosition, ref fieldGridPosition);
				if (num > 0)
				{
					return num2 >= 0 && num3 <= 0;
				}
				return num2 <= 0 && num3 >= 0;
			}

			// Token: 0x0600100A RID: 4106 RVA: 0x00047818 File Offset: 0x00045A18
			internal bool IsRecordInRange(global::Infragistics.Windows.DataPresenter.Record record, bool excludePivot, bool excludeEndRange)
			{
				if (record == null)
				{
					return false;
				}
				if (record == this._pivotRecord)
				{
					return !excludePivot;
				}
				if (record == this._endOfRangeRecord)
				{
					return !excludeEndRange;
				}
				long overallSelectionPosition = record.OverallSelectionPosition;
				if (this._isPivotLessThanEnd)
				{
					return overallSelectionPosition > this._pivotRecordPosition && overallSelectionPosition < this._endOfRangeRecordPosition;
				}
				return overallSelectionPosition < this._pivotRecordPosition && overallSelectionPosition > this._endOfRangeRecordPosition;
			}

			// Token: 0x0600100B RID: 4107 RVA: 0x00047880 File Offset: 0x00045A80
			private global::Infragistics.Windows.DataPresenter.Field GetMappedField(global::Infragistics.Windows.DataPresenter.Field field)
			{
				if (field != null && this._fieldLayoutToMapFieldsTo != null && field.Owner != this._fieldLayoutToMapFieldsTo)
				{
					global::Infragistics.Windows.DataPresenter.Field mappedTreeField = field.MappedTreeField;
					if (mappedTreeField == global::Infragistics.Windows.DataPresenter.Field.UnMappedField)
					{
						return null;
					}
				}
				return field;
			}

			// Token: 0x0600100C RID: 4108 RVA: 0x000478B8 File Offset: 0x00045AB8
			private void Initialize()
			{
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				if (this._endOfRangeField != null)
				{
					this._endOfRangeFieldPosition = this._endOfRangeField.GridPosition;
				}
				if (this._pivotField != null)
				{
					this._pivotFieldPosition = this._pivotField.GridPosition;
					fieldLayout = this._pivotField.Owner;
				}
				if (this._endOfRangeRecord != null)
				{
					this._endOfRangeRecordPosition = this._endOfRangeRecord.OverallSelectionPosition;
				}
				if (this._pivotRecord != null)
				{
					this._pivotRecordPosition = this._pivotRecord.OverallSelectionPosition;
					flag = (this._pivotRecord != this._endOfRangeRecord);
					fieldLayout = this._pivotRecord.FieldLayout;
				}
				if (this._dataPresenter.IsTreeView)
				{
					this._useFieldPositions = true;
					if (this._dataPresenter.CurrentViewInternal.IsCrossLevelSelectionSupported)
					{
						fieldLayout = fieldLayout.DataPresenter.DefaultFieldLayout;
						this._fieldLayoutToMapFieldsTo = fieldLayout;
						if (this._endOfRangeField != null && this._endOfRangeField.Owner != fieldLayout)
						{
							this._endOfRangeField = this._endOfRangeField.MappedTreeField;
						}
						if (this._pivotField != null && this._pivotField.Owner != fieldLayout && this._pivotField.IsFieldMapped)
						{
							this._pivotField = this._pivotField.MappedTreeField;
						}
					}
				}
				else
				{
					this._useFieldPositions = !this._dataPresenter.CurrentViewInternal.IsCrossLevelSelectionSupported;
				}
				if (flag)
				{
					if (this._pivotRecordPosition <= this._endOfRangeRecordPosition)
					{
						this._isPivotLessThanEnd = true;
					}
				}
				else if (this._pivotFieldPosition != null && this._endOfRangeFieldPosition != null && this._pivotFieldPosition.Row <= this._endOfRangeFieldPosition.Row)
				{
					this._isPivotLessThanEnd = true;
				}
				if (fieldLayout != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = fieldLayout.StyleGenerator;
					if (styleGenerator != null)
					{
						this._gridViewOrientation = styleGenerator.LogicalOrientation;
						if (styleGenerator.CellPresentation == global::Infragistics.Windows.DataPresenter.CellPresentation.GridView)
						{
							this._isGridView = true;
						}
						if (this._useFieldPositions && !fieldLayout.UseCellPresenters)
						{
							if (this._pivotCell != null)
							{
								this._fieldMap = fieldLayout.TemplateDataRecordCache.CellFieldMap;
							}
							else if (this._pivotField != null)
							{
								this._fieldMap = fieldLayout.TemplateDataRecordCache.LabelFieldMap;
							}
							if (this._fieldMap != null)
							{
								if (this._endOfRangeField != null)
								{
									this._endOfRangeFieldPosition = this._fieldMap.GetPositionInMap(this._endOfRangeField);
								}
								if (this._pivotField != null)
								{
									this._pivotFieldPosition = this._fieldMap.GetPositionInMap(this._pivotField);
								}
							}
						}
					}
				}
			}

			// Token: 0x0400064E RID: 1614
			private global::Infragistics.Windows.DataPresenter.Record _pivotRecord;

			// Token: 0x0400064F RID: 1615
			private global::Infragistics.Windows.DataPresenter.Cell _pivotCell;

			// Token: 0x04000650 RID: 1616
			private global::Infragistics.Windows.DataPresenter.Field _pivotField;

			// Token: 0x04000651 RID: 1617
			private global::Infragistics.Windows.DataPresenter.Record _endOfRangeRecord;

			// Token: 0x04000652 RID: 1618
			private global::Infragistics.Windows.DataPresenter.Cell _endOfRangeCell;

			// Token: 0x04000653 RID: 1619
			private global::Infragistics.Windows.DataPresenter.Field _endOfRangeField;

			// Token: 0x04000654 RID: 1620
			private bool _snaking;

			// Token: 0x04000655 RID: 1621
			private bool _isPivotLessThanEnd;

			// Token: 0x04000656 RID: 1622
			private bool _isGridView;

			// Token: 0x04000657 RID: 1623
			private global::System.Windows.Controls.Orientation _gridViewOrientation;

			// Token: 0x04000658 RID: 1624
			private long _pivotRecordPosition;

			// Token: 0x04000659 RID: 1625
			private long _endOfRangeRecordPosition;

			// Token: 0x0400065A RID: 1626
			private global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition _pivotFieldPosition;

			// Token: 0x0400065B RID: 1627
			private global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition _endOfRangeFieldPosition;

			// Token: 0x0400065C RID: 1628
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

			// Token: 0x0400065D RID: 1629
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayoutToMapFieldsTo;

			// Token: 0x0400065E RID: 1630
			private bool _useFieldPositions;

			// Token: 0x0400065F RID: 1631
			private global::Infragistics.Windows.DataPresenter.GridFieldMap _fieldMap;
		}

		// Token: 0x020000EF RID: 239
		public class SelectedItemHolder : global::Infragistics.PropertyChangeNotifier, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Selection.ISelectableItem>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600100D RID: 4109 RVA: 0x00047B10 File Offset: 0x00045D10
			internal SelectedItemHolder(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
			{
				this._dp = dp;
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x0600100E RID: 4110 RVA: 0x00047B1F File Offset: 0x00045D1F
			public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
			{
				get
				{
					return this._dp;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x0600100F RID: 4111 RVA: 0x00047B27 File Offset: 0x00045D27
			public global::Infragistics.Windows.DataPresenter.SelectedCellCollection Cells
			{
				get
				{
					if (this._cells == null)
					{
						this._cells = new global::Infragistics.Windows.DataPresenter.SelectedCellCollection(this._dp);
						this._cells.Initialize(this);
					}
					return this._cells;
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06001010 RID: 4112 RVA: 0x00047B54 File Offset: 0x00045D54
			public global::Infragistics.Windows.DataPresenter.SelectedFieldCollection Fields
			{
				get
				{
					if (this._fields == null)
					{
						this._fields = new global::Infragistics.Windows.DataPresenter.SelectedFieldCollection(this._dp);
						this._fields.Initialize(this);
					}
					return this._fields;
				}
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06001011 RID: 4113 RVA: 0x00047B81 File Offset: 0x00045D81
			public global::Infragistics.Windows.DataPresenter.SelectedRecordCollection Records
			{
				get
				{
					if (this._records == null)
					{
						this._records = new global::Infragistics.Windows.DataPresenter.SelectedRecordCollection(this._dp);
						this._records.Initialize(this);
					}
					return this._records;
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x06001012 RID: 4114 RVA: 0x00047BB0 File Offset: 0x00045DB0
			internal int Count
			{
				get
				{
					int num = 0;
					if (this._fields != null)
					{
						num += this._fields.Count;
					}
					if (this._records != null)
					{
						num += this._records.Count;
					}
					if (this._cells != null)
					{
						num += this._cells.Count;
					}
					return num;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x06001013 RID: 4115 RVA: 0x00047C02 File Offset: 0x00045E02
			internal bool HasCells
			{
				get
				{
					return this._cells != null && this._cells.Count > 0;
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x06001014 RID: 4116 RVA: 0x00047C1C File Offset: 0x00045E1C
			internal bool HasFields
			{
				get
				{
					return this._fields != null && this._fields.Count > 0;
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x06001015 RID: 4117 RVA: 0x00047C38 File Offset: 0x00045E38
			internal bool HasMixedSelection
			{
				get
				{
					int num = 0;
					if (this.HasCells)
					{
						num++;
					}
					if (this.HasRecords)
					{
						num++;
					}
					if (this.HasFields)
					{
						num++;
					}
					return num > 1;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x06001016 RID: 4118 RVA: 0x00047C6F File Offset: 0x00045E6F
			internal bool HasRecords
			{
				get
				{
					return this._records != null && this._records.Count > 0;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x06001017 RID: 4119 RVA: 0x00047C89 File Offset: 0x00045E89
			internal bool HasSelection
			{
				get
				{
					return this.HasCells || this.HasFields || this.HasRecords;
				}
			}

			// Token: 0x06001018 RID: 4120 RVA: 0x00047CA3 File Offset: 0x00045EA3
			internal void ClearAllSelected()
			{
				if (this._records != null)
				{
					this._records.Clear();
				}
				if (this._fields != null)
				{
					this._fields.Clear();
				}
				if (this._cells != null)
				{
					this._cells.Clear();
				}
			}

			// Token: 0x06001019 RID: 4121 RVA: 0x00047CE0 File Offset: 0x00045EE0
			internal void ClearItemsOfType(global::Infragistics.Windows.Selection.ISelectableItem item)
			{
				if (item is global::Infragistics.Windows.DataPresenter.Record)
				{
					if (this.HasRecords)
					{
						this.Records.Clear();
						return;
					}
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Cell)
				{
					if (this.HasCells)
					{
						this.Cells.Clear();
						return;
					}
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Field && this.HasFields)
				{
					this.Fields.Clear();
				}
			}

			// Token: 0x0600101A RID: 4122 RVA: 0x00047D40 File Offset: 0x00045F40
			private bool CompareCollections(global::System.Collections.ICollection coll1, global::System.Collections.ICollection coll2)
			{
				if (coll1 == coll2)
				{
					return true;
				}
				int num = (coll1 != null) ? coll1.Count : 0;
				int num2 = (coll2 != null) ? coll2.Count : 0;
				if (num <= 0 && num2 <= 0)
				{
					return true;
				}
				if (num != num2)
				{
					return false;
				}
				bool flag = true;
				global::System.Collections.IEnumerator enumerator = coll2.GetEnumerator();
				enumerator.Reset();
				foreach (object obj in coll1)
				{
					if (!enumerator.MoveNext() || obj != enumerator.Current)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					return true;
				}
				global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable(coll1.Count);
				global::System.Collections.Hashtable hashtable2 = new global::System.Collections.Hashtable(coll2.Count);
				object value = new object();
				foreach (object key in coll1)
				{
					hashtable[key] = value;
				}
				foreach (object key2 in coll2)
				{
					hashtable2[key2] = value;
				}
				if (hashtable.Count != hashtable2.Count)
				{
					return false;
				}
				foreach (object key3 in hashtable.Keys)
				{
					if (!hashtable2.ContainsKey(key3))
					{
						return false;
					}
				}
				foreach (object key4 in hashtable2.Keys)
				{
					if (!hashtable.ContainsKey(key4))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x0600101B RID: 4123 RVA: 0x00047F60 File Offset: 0x00046160
			internal global::Infragistics.Windows.Selection.ISelectableItem GetItem(int index)
			{
				if (this._fields != null)
				{
					int count = this._fields.Count;
					if (index < count)
					{
						return this._fields[index];
					}
					index -= count;
				}
				if (this._records != null)
				{
					int count = this._records.Count;
					if (index < count)
					{
						return this._records[index];
					}
					index -= count;
				}
				if (this._cells != null)
				{
					int count = this._cells.Count;
					if (index < count)
					{
						return this._cells[index];
					}
				}
				return null;
			}

			// Token: 0x0600101C RID: 4124 RVA: 0x00047FE8 File Offset: 0x000461E8
			internal bool IsItemInCollection(global::Infragistics.Windows.Selection.ISelectableItem item)
			{
				if (item == null)
				{
					return false;
				}
				bool result = false;
				if (this._records != null && this.Records.Contains(item))
				{
					result = true;
				}
				else if (this._fields != null && this.Fields.Contains(item))
				{
					result = true;
				}
				else if (this._cells != null && this.Cells.Contains(item))
				{
					result = true;
				}
				return result;
			}

			// Token: 0x0600101D RID: 4125 RVA: 0x0004804C File Offset: 0x0004624C
			internal bool IsSelectionSameForItemType(global::System.Type itemType, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectionToCompareTo)
			{
				if (typeof(global::Infragistics.Windows.DataPresenter.Record).IsAssignableFrom(itemType))
				{
					return this.CompareCollections(this._records, selectionToCompareTo._records);
				}
				if (typeof(global::Infragistics.Windows.DataPresenter.Cell).IsAssignableFrom(itemType))
				{
					return this.CompareCollections(this._cells, selectionToCompareTo._cells);
				}
				return typeof(global::Infragistics.Windows.DataPresenter.Field).IsAssignableFrom(itemType) && this.CompareCollections(this._fields, selectionToCompareTo._fields);
			}

			// Token: 0x0600101E RID: 4126 RVA: 0x000480CC File Offset: 0x000462CC
			internal bool InternalClearSelection(bool clearCells, bool clearRecords, bool clearFields, bool resetItemSelectionStates)
			{
				bool result = false;
				if (clearCells && this.HasCells)
				{
					this.Cells.InternalClear(resetItemSelectionStates);
					result = true;
				}
				if (clearRecords && this.HasRecords)
				{
					this.Records.InternalClear(resetItemSelectionStates);
					result = true;
				}
				if (clearFields && this.HasFields)
				{
					this.Fields.InternalClear(resetItemSelectionStates);
					result = true;
				}
				return result;
			}

			// Token: 0x0600101F RID: 4127 RVA: 0x0004812C File Offset: 0x0004632C
			internal static void RemoveDuplicateObjects(global::System.Collections.ArrayList list)
			{
				int num = 0;
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					while (i + 1 < count && object.ReferenceEquals(list[i], list[i + 1]))
					{
						i++;
					}
					if (i >= count)
					{
						break;
					}
					list[num] = list[i];
					num++;
					i++;
				}
				if (num < count)
				{
					list.RemoveRange(num, count - num);
				}
			}

			// Token: 0x06001020 RID: 4128 RVA: 0x00048194 File Offset: 0x00046394
			internal void RemoveItemFromCollection(global::Infragistics.Windows.Selection.ISelectableItem item)
			{
				if (item is global::Infragistics.Windows.DataPresenter.Record)
				{
					if (this._records != null)
					{
						this._records.Remove((global::Infragistics.Windows.DataPresenter.Record)item);
						return;
					}
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Cell)
				{
					if (this._cells != null)
					{
						this._cells.Remove((global::Infragistics.Windows.DataPresenter.Cell)item);
						return;
					}
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Field && this._fields != null)
				{
					this._fields.Remove((global::Infragistics.Windows.DataPresenter.Field)item);
				}
			}

			// Token: 0x06001021 RID: 4129 RVA: 0x00048208 File Offset: 0x00046408
			private static global::Infragistics.Windows.DataPresenter.FieldLayout GetFieldLayoutFromItem(global::Infragistics.Windows.Selection.ISelectableItem item)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout result = null;
				if (item is global::Infragistics.Windows.DataPresenter.Record)
				{
					result = ((global::Infragistics.Windows.DataPresenter.Record)item).FieldLayout;
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Cell)
				{
					result = ((global::Infragistics.Windows.DataPresenter.Cell)item).Record.FieldLayout;
				}
				else if (item is global::Infragistics.Windows.DataPresenter.Field)
				{
					result = ((global::Infragistics.Windows.DataPresenter.Field)item).Owner;
				}
				return result;
			}

			// Token: 0x06001022 RID: 4130 RVA: 0x00048260 File Offset: 0x00046460
			internal static void RemoveItemFromCollectionHelper(global::Infragistics.Windows.Selection.ISelectableItem item)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayoutFromItem = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.GetFieldLayoutFromItem(item);
				if (fieldLayoutFromItem != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayoutFromItem.DataPresenter;
					if (dataPresenter != null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems = dataPresenter.SelectedItems;
						selectedItems.RemoveItemFromCollection(item);
					}
				}
			}

			// Token: 0x06001023 RID: 4131 RVA: 0x0004828F File Offset: 0x0004648F
			internal void SetCells(global::Infragistics.Windows.DataPresenter.SelectedCellCollection newCells)
			{
				this._cells = newCells;
				if (this._cells != null && this._cells.Owner == null)
				{
					this._cells.Initialize(this);
				}
				base.RaisePropertyChangedEvent("Cells");
			}

			// Token: 0x06001024 RID: 4132 RVA: 0x000482C4 File Offset: 0x000464C4
			internal void SetFields(global::Infragistics.Windows.DataPresenter.SelectedFieldCollection newFields)
			{
				this._fields = newFields;
				if (this._fields != null && this._fields.Owner == null)
				{
					this._fields.Initialize(this);
				}
				base.RaisePropertyChangedEvent("Fields");
			}

			// Token: 0x06001025 RID: 4133 RVA: 0x000482F9 File Offset: 0x000464F9
			internal void SetRecords(global::Infragistics.Windows.DataPresenter.SelectedRecordCollection newRecords)
			{
				this._records = newRecords;
				if (this._records != null && this._records.Owner == null)
				{
					this._records.Initialize(this);
				}
				base.RaisePropertyChangedEvent("Records");
			}

			// Token: 0x06001026 RID: 4134 RVA: 0x0004832E File Offset: 0x0004652E
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Selection.ISelectableItem> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Selection.ISelectableItem>.GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator(this);
			}

			// Token: 0x06001027 RID: 4135 RVA: 0x00048336 File Offset: 0x00046536
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator(this);
			}

			// Token: 0x04000660 RID: 1632
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;

			// Token: 0x04000661 RID: 1633
			private global::Infragistics.Windows.DataPresenter.SelectedRecordCollection _records;

			// Token: 0x04000662 RID: 1634
			private global::Infragistics.Windows.DataPresenter.SelectedFieldCollection _fields;

			// Token: 0x04000663 RID: 1635
			private global::Infragistics.Windows.DataPresenter.SelectedCellCollection _cells;

			// Token: 0x020000F0 RID: 240
			internal class SelectionPositionSortComparer : global::System.Collections.IComparer
			{
				// Token: 0x06001028 RID: 4136 RVA: 0x0004833E File Offset: 0x0004653E
				internal SelectionPositionSortComparer()
				{
				}

				// Token: 0x06001029 RID: 4137 RVA: 0x00048348 File Offset: 0x00046548
				internal static int CompareRecord(global::Infragistics.Windows.DataPresenter.Record recordX, global::Infragistics.Windows.DataPresenter.Record recordY)
				{
					global::Infragistics.Windows.DataPresenter.Record parentRecord = recordX.ParentRecord;
					global::Infragistics.Windows.DataPresenter.Record parentRecord2 = recordY.ParentRecord;
					if (parentRecord != null)
					{
						int num = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectionPositionSortComparer.CompareRecord(parentRecord, parentRecord2);
						if (num != 0)
						{
							return num;
						}
					}
					return recordX.Index.CompareTo(recordY.Index);
				}

				// Token: 0x0600102A RID: 4138 RVA: 0x00048388 File Offset: 0x00046588
				int global::System.Collections.IComparer.Compare(object x, object y)
				{
					if (x == y)
					{
						return 0;
					}
					if (x == null)
					{
						return 1;
					}
					if (y == null)
					{
						return -1;
					}
					if (x is global::Infragistics.Windows.DataPresenter.Record && y is global::Infragistics.Windows.DataPresenter.Record)
					{
						global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)x;
						global::Infragistics.Windows.DataPresenter.Record record2 = (global::Infragistics.Windows.DataPresenter.Record)y;
						if (record.FieldLayout == record2.FieldLayout)
						{
							return global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectionPositionSortComparer.CompareRecord(record, record2);
						}
						return record.OverallSelectionPosition.CompareTo(record2.OverallSelectionPosition);
					}
					else if (x is global::Infragistics.Windows.DataPresenter.Cell && y is global::Infragistics.Windows.DataPresenter.Cell)
					{
						global::Infragistics.Windows.DataPresenter.Cell cell = (global::Infragistics.Windows.DataPresenter.Cell)x;
						global::Infragistics.Windows.DataPresenter.Cell cell2 = (global::Infragistics.Windows.DataPresenter.Cell)y;
						int num = ((global::System.Collections.IComparer)this).Compare(cell.Record, cell2.Record);
						if (num == 0)
						{
							return cell.Field.IndexForCompare.CompareTo(cell2.Field.IndexForCompare);
						}
						return num;
					}
					else
					{
						if (x is global::Infragistics.Windows.DataPresenter.Field && y is global::Infragistics.Windows.DataPresenter.Field)
						{
							global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)x;
							global::Infragistics.Windows.DataPresenter.Field field2 = (global::Infragistics.Windows.DataPresenter.Field)y;
							return field.IndexForCompare.CompareTo(field2.IndexForCompare);
						}
						throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_11"));
					}
				}
			}

			// Token: 0x020000F1 RID: 241
			private class SelectableItemEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Selection.ISelectableItem>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x0600102B RID: 4139 RVA: 0x0004848F File Offset: 0x0004668F
				internal SelectableItemEnumerator(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder)
				{
					this._selectedItemHolder = selectedItemHolder;
					this._currentPosition = -1;
					this._currentItem = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator.UnsetObjectMarker;
				}

				// Token: 0x0600102C RID: 4140 RVA: 0x000484B0 File Offset: 0x000466B0
				public void Dispose()
				{
					this.Reset();
				}

				// Token: 0x17000402 RID: 1026
				// (get) Token: 0x0600102D RID: 4141 RVA: 0x000484B8 File Offset: 0x000466B8
				public global::Infragistics.Windows.Selection.ISelectableItem Current
				{
					get
					{
						if (this._currentItem != global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator.UnsetObjectMarker)
						{
							return this._currentItem as global::Infragistics.Windows.Selection.ISelectableItem;
						}
						if (this._currentPosition == -1)
						{
							throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_25"));
						}
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_26"));
					}
				}

				// Token: 0x0600102E RID: 4142 RVA: 0x00048508 File Offset: 0x00046708
				public bool MoveNext()
				{
					int count = this._selectedItemHolder.Count;
					if (this._currentPosition < count - 1)
					{
						this._currentPosition++;
						this._currentItem = this._selectedItemHolder.GetItem(this._currentPosition);
						return true;
					}
					this._currentPosition = count;
					this._currentItem = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator.UnsetObjectMarker;
					return false;
				}

				// Token: 0x0600102F RID: 4143 RVA: 0x00048566 File Offset: 0x00046766
				public void Reset()
				{
					this._currentPosition = -1;
					this._currentItem = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator.UnsetObjectMarker;
				}

				// Token: 0x17000403 RID: 1027
				// (get) Token: 0x06001030 RID: 4144 RVA: 0x0004857A File Offset: 0x0004677A
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x04000664 RID: 1636
				private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _selectedItemHolder;

				// Token: 0x04000665 RID: 1637
				private int _currentPosition;

				// Token: 0x04000666 RID: 1638
				private object _currentItem;

				// Token: 0x04000667 RID: 1639
				private static object UnsetObjectMarker = new object();
			}
		}

		// Token: 0x020000F2 RID: 242
		private class DrillDownStackItem
		{
			// Token: 0x06001032 RID: 4146 RVA: 0x0004858E File Offset: 0x0004678E
			internal DrillDownStackItem(global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl, global::System.Windows.Point recordListControlOffset, global::Infragistics.Windows.DataPresenter.Record expandedRecord, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter, global::System.Windows.FrameworkElement container)
			{
				this._recordListControl = recordListControl;
				this._recordListControlOffset = recordListControlOffset;
				this._expandedRecord = expandedRecord;
				this._recordPresenter = recordPresenter;
				this._container = container;
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x06001033 RID: 4147 RVA: 0x000485BB File Offset: 0x000467BB
			internal global::System.Windows.FrameworkElement Container
			{
				get
				{
					return this._container;
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x06001034 RID: 4148 RVA: 0x000485C3 File Offset: 0x000467C3
			internal global::Infragistics.Windows.DataPresenter.Record ExpandedRecord
			{
				get
				{
					return this._expandedRecord;
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x06001035 RID: 4149 RVA: 0x000485CB File Offset: 0x000467CB
			internal global::Infragistics.Windows.DataPresenter.RecordPresenter RecordPresenter
			{
				get
				{
					return this._recordPresenter;
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06001036 RID: 4150 RVA: 0x000485D3 File Offset: 0x000467D3
			internal global::Infragistics.Windows.DataPresenter.RecordListControl RecordListControl
			{
				get
				{
					return this._recordListControl;
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06001037 RID: 4151 RVA: 0x000485DB File Offset: 0x000467DB
			internal global::System.Windows.Point RecordListControlOffset
			{
				get
				{
					return this._recordListControlOffset;
				}
			}

			// Token: 0x04000668 RID: 1640
			private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

			// Token: 0x04000669 RID: 1641
			private global::System.Windows.Point _recordListControlOffset;

			// Token: 0x0400066A RID: 1642
			private global::Infragistics.Windows.DataPresenter.Record _expandedRecord;

			// Token: 0x0400066B RID: 1643
			private global::Infragistics.Windows.DataPresenter.RecordPresenter _recordPresenter;

			// Token: 0x0400066C RID: 1644
			private global::System.Windows.FrameworkElement _container;
		}

		// Token: 0x020000F3 RID: 243
		private class DrillActionItem
		{
			// Token: 0x06001038 RID: 4152 RVA: 0x000485E3 File Offset: 0x000467E3
			internal DrillActionItem(bool expand, global::Infragistics.Windows.DataPresenter.Record record)
			{
				this._expand = expand;
				this._record = record;
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06001039 RID: 4153 RVA: 0x000485F9 File Offset: 0x000467F9
			internal bool Expand
			{
				get
				{
					return this._expand;
				}
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x0600103A RID: 4154 RVA: 0x00048601 File Offset: 0x00046801
			internal global::Infragistics.Windows.DataPresenter.Record Record
			{
				get
				{
					return this._record;
				}
			}

			// Token: 0x0400066D RID: 1645
			private bool _expand;

			// Token: 0x0400066E RID: 1646
			private global::Infragistics.Windows.DataPresenter.Record _record;
		}

		// Token: 0x020000F4 RID: 244
		private class ListBoxPanelSettings
		{
			// Token: 0x0600103B RID: 4155 RVA: 0x00048609 File Offset: 0x00046809
			internal ListBoxPanelSettings()
			{
			}

			// Token: 0x0400066F RID: 1647
			internal int LayoutVersion = -1;

			// Token: 0x04000670 RID: 1648
			internal global::System.Windows.Controls.Panel Panel;
		}

		// Token: 0x020000F5 RID: 245
		internal abstract class FieldSettingsStyleSelector : global::System.Windows.Controls.StyleSelector
		{
			// Token: 0x0600103C RID: 4156 RVA: 0x00048618 File Offset: 0x00046818
			protected FieldSettingsStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter, global::System.Windows.DependencyProperty styleProperty, global::System.Windows.DependencyProperty selectorProperty, global::System.Type elementType)
			{
				this._presenter = presenter;
				this._styleProperty = styleProperty;
				this._selectorProperty = selectorProperty;
				this._elementType = elementType;
			}

			// Token: 0x0600103D RID: 4157 RVA: 0x00048640 File Offset: 0x00046840
			protected virtual global::System.Windows.Style GetSettingsStyle(global::Infragistics.Windows.DataPresenter.FieldSettings settings, object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Controls.StyleSelector styleSelector = (global::System.Windows.Controls.StyleSelector)settings.GetValue(this._selectorProperty);
				global::System.Windows.Style style = null;
				if (styleSelector != null)
				{
					style = styleSelector.SelectStyle(item, container);
				}
				return style ?? ((global::System.Windows.Style)settings.GetValue(this._styleProperty));
			}

			// Token: 0x0600103E RID: 4158 RVA: 0x00048684 File Offset: 0x00046884
			protected global::System.Windows.Style SelectStyle(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, object item, global::System.Windows.DependencyObject container)
			{
				if (field != null)
				{
					if (field.HasSettings)
					{
						global::System.Windows.Style settingsStyle = this.GetSettingsStyle(field.Settings, item, container);
						if (settingsStyle != null)
						{
							return settingsStyle;
						}
					}
					fieldLayout = field.Owner;
				}
				if (fieldLayout != null && fieldLayout.HasFieldSettings)
				{
					global::System.Windows.Style settingsStyle = this.GetSettingsStyle(fieldLayout.FieldSettings, item, container);
					if (settingsStyle != null)
					{
						return settingsStyle;
					}
				}
				if (this._presenter.HasFieldSettings)
				{
					global::System.Windows.Style settingsStyle = this.GetSettingsStyle(this._presenter.FieldSettings, item, container);
					if (settingsStyle != null)
					{
						return settingsStyle;
					}
				}
				if (!(null != this._elementType))
				{
					return null;
				}
				return this._presenter.GetDefaultStyle(this._elementType);
			}

			// Token: 0x04000671 RID: 1649
			internal readonly global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

			// Token: 0x04000672 RID: 1650
			private global::System.Windows.DependencyProperty _styleProperty;

			// Token: 0x04000673 RID: 1651
			private global::System.Windows.DependencyProperty _selectorProperty;

			// Token: 0x04000674 RID: 1652
			private global::System.Type _elementType;
		}

		// Token: 0x020000F6 RID: 246
		internal abstract class FieldLayoutSettingsStyleSelector : global::System.Windows.Controls.StyleSelector
		{
			// Token: 0x0600103F RID: 4159 RVA: 0x00048721 File Offset: 0x00046921
			protected FieldLayoutSettingsStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter, global::System.Windows.DependencyProperty styleProperty, global::System.Windows.DependencyProperty selectorProperty, global::System.Type elementType)
			{
				this._presenter = presenter;
				this._styleProperty = styleProperty;
				this._selectorProperty = selectorProperty;
				this._elementType = elementType;
			}

			// Token: 0x06001040 RID: 4160 RVA: 0x00048748 File Offset: 0x00046948
			protected global::System.Windows.Style GetSettingsStyle(global::Infragistics.Windows.DataPresenter.FieldLayoutSettings settings, object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Style style = null;
				if (this._selectorProperty != null)
				{
					global::System.Windows.Controls.StyleSelector styleSelector = (global::System.Windows.Controls.StyleSelector)settings.GetValue(this._selectorProperty);
					if (styleSelector != null)
					{
						style = styleSelector.SelectStyle(item, container);
					}
				}
				return style ?? ((global::System.Windows.Style)settings.GetValue(this._styleProperty));
			}

			// Token: 0x06001041 RID: 4161 RVA: 0x00048794 File Offset: 0x00046994
			protected global::System.Windows.Style SelectStyle(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, object item, global::System.Windows.DependencyObject container)
			{
				if (fieldLayout != null && fieldLayout.HasSettings)
				{
					global::System.Windows.Style settingsStyle = this.GetSettingsStyle(fieldLayout.Settings, item, container);
					if (settingsStyle != null)
					{
						return settingsStyle;
					}
				}
				if (this._presenter.HasFieldLayoutSettings)
				{
					global::System.Windows.Style settingsStyle = this.GetSettingsStyle(this._presenter.FieldLayoutSettings, item, container);
					if (settingsStyle != null)
					{
						return settingsStyle;
					}
				}
				if (!(null != this._elementType))
				{
					return null;
				}
				return this._presenter.GetDefaultStyle(this._elementType);
			}

			// Token: 0x04000675 RID: 1653
			internal readonly global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

			// Token: 0x04000676 RID: 1654
			private global::System.Windows.DependencyProperty _styleProperty;

			// Token: 0x04000677 RID: 1655
			private global::System.Windows.DependencyProperty _selectorProperty;

			// Token: 0x04000678 RID: 1656
			private global::System.Type _elementType;
		}

		// Token: 0x020000F7 RID: 247
		internal class DPCellPresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x06001042 RID: 4162 RVA: 0x00048807 File Offset: 0x00046A07
			internal DPCellPresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.CellPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.CellPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.CellPresenter))
			{
			}

			// Token: 0x06001043 RID: 4163 RVA: 0x00048824 File Offset: 0x00046A24
			protected override global::System.Windows.Style GetSettingsStyle(global::Infragistics.Windows.DataPresenter.FieldSettings settings, object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Controls.StyleSelector cellPresenterStyleSelector = settings.CellPresenterStyleSelector;
				global::System.Windows.Style style = null;
				if (cellPresenterStyleSelector != null)
				{
					style = cellPresenterStyleSelector.SelectStyle(item, container);
				}
				return style ?? settings.CellPresenterStyle;
			}

			// Token: 0x06001044 RID: 4164 RVA: 0x00048854 File Offset: 0x00046A54
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Field field = null;
				global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = item as global::Infragistics.Windows.DataPresenter.CellPresenter;
				if (cellPresenter != null)
				{
					field = cellPresenter.Field;
				}
				if (field == null && container != null)
				{
					cellPresenter = (container as global::Infragistics.Windows.DataPresenter.CellPresenter);
					if (cellPresenter != null)
					{
						field = cellPresenter.Field;
					}
					if (field == null && container is global::System.Windows.Media.Visual)
					{
						field = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.CellPresenter.FieldProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.Field);
					}
				}
				return base.SelectStyle(field, null, item, container);
			}
		}

		// Token: 0x020000F8 RID: 248
		internal class DPCellValuePresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x06001045 RID: 4165 RVA: 0x000488BC File Offset: 0x00046ABC
			internal DPCellValuePresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.CellValuePresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.CellValuePresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter))
			{
			}

			// Token: 0x06001046 RID: 4166 RVA: 0x000488DC File Offset: 0x00046ADC
			protected override global::System.Windows.Style GetSettingsStyle(global::Infragistics.Windows.DataPresenter.FieldSettings settings, object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Controls.StyleSelector cellValuePresenterStyleSelector = settings.CellValuePresenterStyleSelector;
				global::System.Windows.Style style = null;
				if (cellValuePresenterStyleSelector != null)
				{
					style = cellValuePresenterStyleSelector.SelectStyle(item, container);
				}
				return style ?? settings.CellValuePresenterStyle;
			}

			// Token: 0x06001047 RID: 4167 RVA: 0x0004890C File Offset: 0x00046B0C
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Field field = null;
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = item as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
				if (cellValuePresenter != null)
				{
					field = cellValuePresenter.Field;
				}
				if (field == null && container != null)
				{
					cellValuePresenter = (container as global::Infragistics.Windows.DataPresenter.CellValuePresenter);
					if (cellValuePresenter != null)
					{
						field = cellValuePresenter.Field;
					}
					if (field == null && container is global::System.Windows.Media.Visual)
					{
						field = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.Field);
					}
				}
				if (field != null)
				{
					global::System.Windows.Style cellValuePresenterStyle = field.CellValuePresenterStyle;
					if (cellValuePresenterStyle != null)
					{
						return cellValuePresenterStyle;
					}
				}
				return base.SelectStyle(field, null, item, container);
			}
		}

		// Token: 0x020000F9 RID: 249
		internal class DPEditorStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x06001048 RID: 4168 RVA: 0x00048983 File Offset: 0x00046B83
			internal DPEditorStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.EditorStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.EditorStyleSelectorProperty, null)
			{
			}

			// Token: 0x06001049 RID: 4169 RVA: 0x00048998 File Offset: 0x00046B98
			protected override global::System.Windows.Style GetSettingsStyle(global::Infragistics.Windows.DataPresenter.FieldSettings settings, object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Controls.StyleSelector editorStyleSelector = settings.EditorStyleSelector;
				global::System.Windows.Style style = null;
				if (editorStyleSelector != null)
				{
					style = editorStyleSelector.SelectStyle(item, container);
				}
				return style ?? settings.EditorStyle;
			}

			// Token: 0x0600104A RID: 4170 RVA: 0x000489C8 File Offset: 0x00046BC8
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Style style = this.SelectStyleHelper(item, container);
				if (style != null)
				{
					global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(style, typeof(global::Infragistics.Windows.Editors.ValueEditor), "EditorStyle");
				}
				return style;
			}

			// Token: 0x0600104B RID: 4171 RVA: 0x000489F8 File Offset: 0x00046BF8
			private global::System.Windows.Style SelectStyleHelper(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Field field = null;
				if (item is global::Infragistics.Windows.DataPresenter.CellValuePresenter)
				{
					field = ((global::Infragistics.Windows.DataPresenter.CellValuePresenter)item).Field;
				}
				if (field == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.CellValuePresenter)
					{
						field = ((global::Infragistics.Windows.DataPresenter.CellValuePresenter)container).Field;
					}
					if (field == null && container is global::System.Windows.Media.Visual)
					{
						field = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.Field);
					}
				}
				if (field != null)
				{
					global::System.Windows.Style editorStyle = field.EditorStyle;
					if (editorStyle != null)
					{
						return editorStyle;
					}
				}
				return base.SelectStyle(field, null, item, container);
			}
		}

		// Token: 0x020000FA RID: 250
		internal class DPExpandedCellStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x0600104C RID: 4172 RVA: 0x00048A75 File Offset: 0x00046C75
			internal DPExpandedCellStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandedCellStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandedCellStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter))
			{
			}

			// Token: 0x0600104D RID: 4173 RVA: 0x00048A94 File Offset: 0x00046C94
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Field field = null;
				if (item is global::Infragistics.Windows.DataPresenter.CellValuePresenter)
				{
					field = ((global::Infragistics.Windows.DataPresenter.CellValuePresenter)item).Field;
				}
				if (field == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.CellValuePresenter)
					{
						field = ((global::Infragistics.Windows.DataPresenter.CellValuePresenter)container).Field;
					}
					if (field == null && container is global::System.Windows.Media.Visual)
					{
						field = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.Field);
					}
				}
				return base.SelectStyle(field, null, item, container);
			}
		}

		// Token: 0x020000FB RID: 251
		internal class DPLabelPresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x0600104E RID: 4174 RVA: 0x00048B02 File Offset: 0x00046D02
			internal DPLabelPresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.LabelPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.LabelPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter))
			{
			}

			// Token: 0x0600104F RID: 4175 RVA: 0x00048B20 File Offset: 0x00046D20
			protected override global::System.Windows.Style GetSettingsStyle(global::Infragistics.Windows.DataPresenter.FieldSettings settings, object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Controls.StyleSelector labelPresenterStyleSelector = settings.LabelPresenterStyleSelector;
				global::System.Windows.Style style = null;
				if (labelPresenterStyleSelector != null)
				{
					style = labelPresenterStyleSelector.SelectStyle(item, container);
				}
				return style ?? settings.LabelPresenterStyle;
			}

			// Token: 0x06001050 RID: 4176 RVA: 0x00048B50 File Offset: 0x00046D50
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Field field = null;
				if (item is global::Infragistics.Windows.DataPresenter.LabelPresenter)
				{
					field = ((global::Infragistics.Windows.DataPresenter.LabelPresenter)item).Field;
				}
				if (field == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.LabelPresenter)
					{
						field = ((global::Infragistics.Windows.DataPresenter.LabelPresenter)container).Field;
					}
					if (field == null && container is global::System.Windows.Media.Visual)
					{
						field = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.Field);
					}
				}
				return base.SelectStyle(field, null, item, container);
			}
		}

		// Token: 0x020000FC RID: 252
		internal class DPHeaderPresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06001051 RID: 4177 RVA: 0x00048BBE File Offset: 0x00046DBE
			internal DPHeaderPresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPresenterStyleProperty, null, typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter))
			{
			}

			// Token: 0x06001052 RID: 4178 RVA: 0x00048BD8 File Offset: 0x00046DD8
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = item as global::Infragistics.Windows.DataPresenter.FieldLayout;
				if (fieldLayout == null && container is global::System.Windows.FrameworkElement)
				{
					fieldLayout = (((global::System.Windows.FrameworkElement)container).DataContext as global::Infragistics.Windows.DataPresenter.FieldLayout);
				}
				return base.SelectStyle(fieldLayout, item, container);
			}
		}

		// Token: 0x020000FD RID: 253
		internal class DPHeaderLabelAreaStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06001053 RID: 4179 RVA: 0x00048C11 File Offset: 0x00046E11
			internal DPHeaderLabelAreaStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderLabelAreaStyleProperty, null, typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea))
			{
			}

			// Token: 0x06001054 RID: 4180 RVA: 0x00048C2C File Offset: 0x00046E2C
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				if (record != null)
				{
					fieldLayout = record.FieldLayout;
				}
				if (fieldLayout == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.HeaderLabelArea)
					{
						fieldLayout = ((global::Infragistics.Windows.DataPresenter.HeaderLabelArea)container).FieldLayout;
					}
					if (fieldLayout == null && container is global::System.Windows.Media.Visual)
					{
						fieldLayout = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.HeaderLabelArea.FieldLayoutProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.FieldLayout);
					}
				}
				return base.SelectStyle(fieldLayout, item, container);
			}
		}

		// Token: 0x020000FE RID: 254
		internal class DPHeaderPrefixAreaStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06001055 RID: 4181 RVA: 0x00048C96 File Offset: 0x00046E96
			internal DPHeaderPrefixAreaStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPrefixAreaStyleProperty, null, typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea))
			{
			}

			// Token: 0x06001056 RID: 4182 RVA: 0x00048CB0 File Offset: 0x00046EB0
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				if (record != null)
				{
					fieldLayout = record.FieldLayout;
				}
				if (fieldLayout == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.HeaderPrefixArea)
					{
						fieldLayout = ((global::Infragistics.Windows.DataPresenter.HeaderPrefixArea)container).FieldLayout;
					}
					if (fieldLayout == null && container is global::System.Windows.Media.Visual)
					{
						fieldLayout = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.RecordPrefixArea.FieldLayoutProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.FieldLayout);
					}
				}
				return base.SelectStyle(fieldLayout, item, container);
			}
		}

		// Token: 0x020000FF RID: 255
		internal class DPRecordPresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06001057 RID: 4183 RVA: 0x00048D1A File Offset: 0x00046F1A
			internal DPRecordPresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter))
			{
				this.groupBySelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector.GroupByRecordStyleSelector(presenter);
				this.expandableSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector.ExpandableFieldRecordStyleSelector(presenter);
			}

			// Token: 0x06001058 RID: 4184 RVA: 0x00048D50 File Offset: 0x00046F50
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				this._presenter.VerifyCurrentPanel(item, container);
				global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
				if (record != null)
				{
					if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
					{
						return this.groupBySelector.SelectStyle(record, container);
					}
					if (record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)
					{
						return this.expandableSelector.SelectStyle(record, container);
					}
					if (record is global::Infragistics.Windows.DataPresenter.SummaryRecord)
					{
						return this.SelectSummaryPresenterStyle(record, container);
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				if (record != null)
				{
					fieldLayout = record.FieldLayout;
				}
				if (fieldLayout == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.RecordPresenter)
					{
						fieldLayout = ((global::Infragistics.Windows.DataPresenter.RecordPresenter)container).FieldLayout;
					}
					if (fieldLayout == null && container is global::System.Windows.Media.Visual)
					{
						fieldLayout = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.RecordPresenter.FieldLayoutProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.FieldLayout);
					}
				}
				return base.SelectStyle(fieldLayout, item, container);
			}

			// Token: 0x06001059 RID: 4185 RVA: 0x00048E07 File Offset: 0x00047007
			private global::System.Windows.Style SelectSummaryPresenterStyle(global::Infragistics.Windows.DataPresenter.Record record, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
				return this._presenter.GetDefaultStyle(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter));
			}

			// Token: 0x04000679 RID: 1657
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector.GroupByRecordStyleSelector groupBySelector;

			// Token: 0x0400067A RID: 1658
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector.ExpandableFieldRecordStyleSelector expandableSelector;

			// Token: 0x02000100 RID: 256
			private class GroupByRecordStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
			{
				// Token: 0x0600105A RID: 4186 RVA: 0x00048E25 File Offset: 0x00047025
				internal GroupByRecordStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByRecordPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByRecordPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter))
				{
				}

				// Token: 0x0600105B RID: 4187 RVA: 0x00048E44 File Offset: 0x00047044
				public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
				{
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = item as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					global::Infragistics.Windows.DataPresenter.Field associatedField = groupByRecord.AssociatedField;
					return base.SelectStyle(associatedField, groupByRecord.FieldLayout, item, container);
				}
			}

			// Token: 0x02000101 RID: 257
			private class ExpandableFieldRecordStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
			{
				// Token: 0x0600105C RID: 4188 RVA: 0x00048E6E File Offset: 0x0004706E
				internal ExpandableFieldRecordStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter))
				{
				}

				// Token: 0x0600105D RID: 4189 RVA: 0x00048E8C File Offset: 0x0004708C
				public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = item as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
					global::Infragistics.Windows.DataPresenter.Field associatedField = expandableFieldRecord.AssociatedField;
					return base.SelectStyle(associatedField, expandableFieldRecord.FieldLayout, item, container);
				}
			}
		}

		// Token: 0x02000102 RID: 258
		internal class DPRecordSelectorStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x0600105E RID: 4190 RVA: 0x00048EB6 File Offset: 0x000470B6
			internal DPRecordSelectorStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorStyleProperty, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.RecordSelector))
			{
			}

			// Token: 0x0600105F RID: 4191 RVA: 0x00048ED4 File Offset: 0x000470D4
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				if (record != null)
				{
					fieldLayout = record.FieldLayout;
				}
				if (fieldLayout == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.RecordSelector)
					{
						fieldLayout = ((global::Infragistics.Windows.DataPresenter.RecordSelector)container).FieldLayout;
					}
					if (fieldLayout == null && container is global::System.Windows.Media.Visual)
					{
						fieldLayout = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.RecordSelector.FieldLayoutProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.FieldLayout);
					}
				}
				return base.SelectStyle(fieldLayout, item, container);
			}
		}

		// Token: 0x02000103 RID: 259
		internal class DPRecordSelectorNumberStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06001060 RID: 4192 RVA: 0x00048F3E File Offset: 0x0004713E
			internal DPRecordSelectorNumberStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberStyleProperty, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorNumberStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorNumber))
			{
			}

			// Token: 0x06001061 RID: 4193 RVA: 0x00048F5C File Offset: 0x0004715C
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				if (record != null)
				{
					fieldLayout = record.FieldLayout;
				}
				if (fieldLayout == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.RecordSelectorNumber)
					{
						fieldLayout = ((global::Infragistics.Windows.DataPresenter.RecordSelectorNumber)container).FieldLayout;
					}
					if (fieldLayout == null && container is global::System.Windows.Media.Visual)
					{
						fieldLayout = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.RecordSelectorNumber.FieldLayoutProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.FieldLayout);
					}
				}
				return base.SelectStyle(fieldLayout, item, container);
			}
		}

		// Token: 0x02000104 RID: 260
		internal class DPRecordCellAreaStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06001062 RID: 4194 RVA: 0x00048FC6 File Offset: 0x000471C6
			internal DPRecordCellAreaStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaStyleProperty, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea))
			{
			}

			// Token: 0x06001063 RID: 4195 RVA: 0x00048FE4 File Offset: 0x000471E4
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				if (record != null)
				{
					fieldLayout = record.FieldLayout;
				}
				if (fieldLayout == null && container != null)
				{
					if (container is global::Infragistics.Windows.DataPresenter.DataRecordCellArea)
					{
						fieldLayout = ((global::Infragistics.Windows.DataPresenter.DataRecordCellArea)container).FieldLayout;
					}
					if (fieldLayout == null && container is global::System.Windows.Media.Visual)
					{
						fieldLayout = (global::Infragistics.Windows.Utilities.GetAncestorPropertyValue((global::System.Windows.Media.Visual)container, global::Infragistics.Windows.DataPresenter.DataRecordCellArea.FieldLayoutProperty, this._presenter) as global::Infragistics.Windows.DataPresenter.FieldLayout);
					}
				}
				return base.SelectStyle(fieldLayout, item, container);
			}
		}

		// Token: 0x02000105 RID: 261
		private class AsyncPageCommand
		{
			// Token: 0x06001064 RID: 4196 RVA: 0x0004904E File Offset: 0x0004724E
			internal AsyncPageCommand(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
			{
				this._dp = dp;
				this._dp.LayoutUpdated += this.OnLayoutUpdated;
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06001065 RID: 4197 RVA: 0x00049074 File Offset: 0x00047274
			// (set) Token: 0x06001066 RID: 4198 RVA: 0x0004907C File Offset: 0x0004727C
			internal global::System.Windows.Input.RoutedCommand Command
			{
				get
				{
					return this._command;
				}
				set
				{
					this._command = value;
				}
			}

			// Token: 0x06001067 RID: 4199 RVA: 0x00049085 File Offset: 0x00047285
			internal void Detach()
			{
				this._dp.LayoutUpdated -= this.OnLayoutUpdated;
			}

			// Token: 0x06001068 RID: 4200 RVA: 0x0004909E File Offset: 0x0004729E
			private void OnLayoutUpdated(object sender, global::System.EventArgs e)
			{
				this.Detach();
				this._dp.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ProcessCommand));
			}

			// Token: 0x06001069 RID: 4201 RVA: 0x000490C4 File Offset: 0x000472C4
			private void ProcessCommand()
			{
				this._dp.ApplyAsyncCommand(this);
			}

			// Token: 0x0400067B RID: 1659
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;

			// Token: 0x0400067C RID: 1660
			private global::System.Windows.Input.RoutedCommand _command;
		}

		// Token: 0x02000106 RID: 262
		private class KeyDownInfo
		{
			// Token: 0x0600106A RID: 4202 RVA: 0x000490D2 File Offset: 0x000472D2
			internal KeyDownInfo(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
			{
				this._tickCount = global::System.Environment.TickCount;
				this._key = key;
				this._modifiers = modifiers;
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x0600106B RID: 4203 RVA: 0x000490F3 File Offset: 0x000472F3
			// (set) Token: 0x0600106C RID: 4204 RVA: 0x000490FB File Offset: 0x000472FB
			internal global::System.Windows.Input.Key Key
			{
				get
				{
					return this._key;
				}
				set
				{
					this._key = value;
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x0600106D RID: 4205 RVA: 0x00049104 File Offset: 0x00047304
			// (set) Token: 0x0600106E RID: 4206 RVA: 0x0004910C File Offset: 0x0004730C
			internal global::System.Windows.Input.ModifierKeys Modifiers
			{
				get
				{
					return this._modifiers;
				}
				set
				{
					this._modifiers = value;
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x0600106F RID: 4207 RVA: 0x00049115 File Offset: 0x00047315
			// (set) Token: 0x06001070 RID: 4208 RVA: 0x0004911D File Offset: 0x0004731D
			internal int TickCount
			{
				get
				{
					return this._tickCount;
				}
				set
				{
					this._tickCount = value;
				}
			}

			// Token: 0x0400067D RID: 1661
			private int _tickCount;

			// Token: 0x0400067E RID: 1662
			private global::System.Windows.Input.Key _key;

			// Token: 0x0400067F RID: 1663
			private global::System.Windows.Input.ModifierKeys _modifiers;
		}

		// Token: 0x02000107 RID: 263
		private class RecordSelectionEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06001071 RID: 4209 RVA: 0x00049126 File Offset: 0x00047326
			internal RecordSelectionEnumerator(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Record pivotRcd, bool forward)
			{
				this._record = record;
				this._pivotRcd = pivotRcd;
				this._forward = forward;
				this._step = (forward ? 1 : -1);
				this.Reset();
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06001072 RID: 4210 RVA: 0x00049156 File Offset: 0x00047356
			public object Current
			{
				get
				{
					if (this._currentRecord != null)
					{
						return this._currentRecord;
					}
					if (this._eofReached)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_26"));
					}
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_25"));
				}
			}

			// Token: 0x06001073 RID: 4211 RVA: 0x00049190 File Offset: 0x00047390
			public bool MoveNext()
			{
				if (this._eofReached)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_26"));
				}
				if (this._currentRecord == this._record)
				{
					this._currentRecord = null;
					this._eofReached = true;
					return false;
				}
				bool flag = true;
				while (flag)
				{
					this._currentRecord = this.GetNextSiblingRecord(0, ref flag);
				}
				if (this._currentRecord == null)
				{
					this._eofReached = true;
					return false;
				}
				return true;
			}

			// Token: 0x06001074 RID: 4212 RVA: 0x000491FC File Offset: 0x000473FC
			public void Reset()
			{
				this._currentRecord = null;
				this._eofReached = false;
				int num = this._pivotRcd.NestingDepth + 1;
				this._ancestorLevels = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel[num];
				global::Infragistics.Windows.DataPresenter.Record record = this._pivotRcd;
				for (int i = 0; i < num; i++)
				{
					this._ancestorLevels[i] = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel(record);
					record = record.ParentRecord;
				}
			}

			// Token: 0x06001075 RID: 4213 RVA: 0x0004925C File Offset: 0x0004745C
			private global::Infragistics.Windows.DataPresenter.Record GetNextSiblingRecord(int levelIndex, ref bool retry)
			{
				retry = false;
				if (levelIndex >= this._ancestorLevels.Length)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel ancestorLevel = this._ancestorLevels[levelIndex];
				ancestorLevel._currentIndex += this._step;
				while (ancestorLevel._currentIndex >= 0 && ancestorLevel._currentIndex < ancestorLevel._siblings.Count)
				{
					global::Infragistics.Windows.DataPresenter.Record record = ancestorLevel._siblings[ancestorLevel._currentIndex];
					if (record.VisibilityResolved == global::System.Windows.Visibility.Visible)
					{
						return record;
					}
					ancestorLevel._currentIndex += this._step;
				}
				if (levelIndex >= this._ancestorLevels.Length)
				{
					return null;
				}
				bool flag = true;
				global::Infragistics.Windows.DataPresenter.Record record2 = null;
				while (flag)
				{
					record2 = this.GetNextSiblingRecord(levelIndex + 1, ref flag);
				}
				if (record2 == null)
				{
					return null;
				}
				ancestorLevel._siblings = record2.ChildRecordsInternal;
				if (this._forward)
				{
					ancestorLevel._currentIndex = -1;
				}
				else
				{
					ancestorLevel._currentIndex = ancestorLevel._siblings.Count;
				}
				retry = true;
				return null;
			}

			// Token: 0x04000680 RID: 1664
			private global::Infragistics.Windows.DataPresenter.Record _record;

			// Token: 0x04000681 RID: 1665
			private global::Infragistics.Windows.DataPresenter.Record _pivotRcd;

			// Token: 0x04000682 RID: 1666
			private global::Infragistics.Windows.DataPresenter.Record _currentRecord;

			// Token: 0x04000683 RID: 1667
			private bool _forward;

			// Token: 0x04000684 RID: 1668
			private bool _eofReached;

			// Token: 0x04000685 RID: 1669
			private int _step;

			// Token: 0x04000686 RID: 1670
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator.AncestorLevel[] _ancestorLevels;

			// Token: 0x02000108 RID: 264
			internal class AncestorLevel
			{
				// Token: 0x06001076 RID: 4214 RVA: 0x0004933D File Offset: 0x0004753D
				internal AncestorLevel(global::Infragistics.Windows.DataPresenter.Record record)
				{
					this._siblings = record.ParentCollection;
					this._currentIndex = record.Index;
				}

				// Token: 0x06001077 RID: 4215 RVA: 0x0004935D File Offset: 0x0004755D
				internal AncestorLevel(global::Infragistics.Windows.DataPresenter.RecordCollectionBase siblings, bool forward)
				{
					this._siblings = siblings;
					this._currentIndex = (forward ? -1 : siblings.Count);
				}

				// Token: 0x04000687 RID: 1671
				internal int _currentIndex;

				// Token: 0x04000688 RID: 1672
				internal global::Infragistics.Windows.DataPresenter.RecordCollectionBase _siblings;
			}
		}

		// Token: 0x02000109 RID: 265
		private class FixedAreaScrollHelper
		{
			// Token: 0x06001078 RID: 4216 RVA: 0x0004937E File Offset: 0x0004757E
			internal FixedAreaScrollHelper(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner)
			{
				this._owner = owner;
			}

			// Token: 0x06001079 RID: 4217 RVA: 0x00049390 File Offset: 0x00047590
			internal void AdjustScrollInfoCallback(bool isHorizontal, global::System.Windows.Input.MouseEventArgs mouseArgs, global::Infragistics.Windows.Selection.ISelectableItem item, ref global::Infragistics.Windows.Selection.ScrollDirection? scrollDirection, ref double timerInterval)
			{
				if (scrollDirection != null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldLayout(item);
				if (fieldLayout == null)
				{
					return;
				}
				if (item is global::Infragistics.Windows.DataPresenter.Field || item is global::Infragistics.Windows.DataPresenter.Cell)
				{
					if (fieldLayout.IsHorizontal != isHorizontal)
					{
						this.AdjustFieldScrollInfo(mouseArgs, item, ref scrollDirection, fieldLayout);
					}
					global::Infragistics.Windows.DataPresenter.Field field = item as global::Infragistics.Windows.DataPresenter.Field;
				}
			}

			// Token: 0x0600107A RID: 4218 RVA: 0x000493E0 File Offset: 0x000475E0
			internal void OnPivotItemChanged(global::Infragistics.Windows.Selection.ISelectableItem oldValue, global::Infragistics.Windows.Selection.ISelectableItem newValue)
			{
				if (oldValue is global::Infragistics.Windows.DataPresenter.Cell && newValue == null)
				{
					this._pivotFixedFieldLocationCell = null;
					this._pivotFixedRecordLocationCell = null;
					this._isInitialCellRecordScrollPending = false;
					this._isInitialCellFieldScrollPending = false;
				}
				else if (newValue is global::Infragistics.Windows.DataPresenter.Cell)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = newValue as global::Infragistics.Windows.DataPresenter.Cell;
					this._pivotFixedRecordLocationCell = new global::Infragistics.Windows.DataPresenter.FixedRecordLocation?(cell.Record.FixedLocation);
					this._pivotFixedFieldLocationCell = new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(cell.Field.FixedLocation);
					this._isInitialCellRecordScrollPending = (this._pivotFixedRecordLocationCell != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable);
					this._isInitialCellFieldScrollPending = (this._pivotFixedFieldLocationCell != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
				}
				else if (oldValue is global::Infragistics.Windows.DataPresenter.Record && newValue == null)
				{
					this._pivotFixedRecordLocation = null;
					this._isInitialRecordScrollPending = false;
				}
				else if (newValue is global::Infragistics.Windows.DataPresenter.Record)
				{
					global::Infragistics.Windows.DataPresenter.Record record = newValue as global::Infragistics.Windows.DataPresenter.Record;
					this._pivotFixedRecordLocation = new global::Infragistics.Windows.DataPresenter.FixedRecordLocation?(record.FixedLocation);
					this._isInitialRecordScrollPending = (this._pivotFixedRecordLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable);
				}
				else if (oldValue is global::Infragistics.Windows.DataPresenter.Field && newValue == null)
				{
					this._pivotFixedFieldLocation = null;
					this._isInitialFieldScrollPending = false;
				}
				else if (newValue is global::Infragistics.Windows.DataPresenter.Field)
				{
					global::Infragistics.Windows.DataPresenter.Field field = newValue as global::Infragistics.Windows.DataPresenter.Field;
					this._pivotFixedFieldLocation = new global::Infragistics.Windows.DataPresenter.FixedFieldLocation?(field.FixedLocation);
					this._isInitialFieldScrollPending = (this._pivotFixedFieldLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
				}
				if (newValue != null)
				{
					if (!this._owner.IsFixedFieldsSupportedResolved)
					{
						this._pivotFixedFieldLocation = null;
						this._pivotFixedFieldLocationCell = null;
						this._isInitialFieldScrollPending = false;
						this._isInitialCellFieldScrollPending = false;
					}
					if (!this._owner.IsFixedRecordsSupportedResolved)
					{
						this._pivotFixedRecordLocation = null;
						this._pivotFixedRecordLocationCell = null;
						this._isInitialCellRecordScrollPending = false;
						this._isInitialRecordScrollPending = false;
					}
				}
			}

			// Token: 0x0600107B RID: 4219 RVA: 0x000495E0 File Offset: 0x000477E0
			internal global::Infragistics.Windows.Selection.ISelectableElement VerifyNearestCompatibleItem(global::Infragistics.Windows.Selection.ISelectableElement selectableElement, global::Infragistics.Windows.Selection.ISelectableItem relatedItem, global::System.Windows.Input.MouseEventArgs e)
			{
				global::Infragistics.Windows.DataPresenter.DataItemPresenter dataItemPresenter = selectableElement as global::Infragistics.Windows.DataPresenter.DataItemPresenter;
				if (dataItemPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.FixedFieldLocation? fixedFieldLocation = null;
					bool isInitialScrollPending = false;
					if (relatedItem is global::Infragistics.Windows.DataPresenter.Field)
					{
						fixedFieldLocation = this._pivotFixedFieldLocation;
						isInitialScrollPending = this._isInitialFieldScrollPending;
					}
					else if (relatedItem is global::Infragistics.Windows.DataPresenter.Cell)
					{
						fixedFieldLocation = this._pivotFixedFieldLocationCell;
						isInitialScrollPending = this._isInitialCellFieldScrollPending;
					}
					if (fixedFieldLocation != null)
					{
						this.VerifyCompatibleItemForField(ref selectableElement, relatedItem, dataItemPresenter, fixedFieldLocation.Value, isInitialScrollPending);
					}
				}
				return selectableElement;
			}

			// Token: 0x0600107C RID: 4220 RVA: 0x0004964C File Offset: 0x0004784C
			private void AdjustFieldScrollInfo(global::System.Windows.Input.MouseEventArgs mouseArgs, global::Infragistics.Windows.Selection.ISelectableItem item, ref global::Infragistics.Windows.Selection.ScrollDirection? scrollDirection, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
			{
				if (!this._owner.IsFixedFieldsSupportedResolved)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.Internal.FixedFieldLayoutInfo fixedFieldInfo = fieldLayout.GetFixedFieldInfo(false);
				if (fixedFieldInfo == null || !fixedFieldInfo.HasFixedFields)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.FixedFieldLocation? fixedFieldLocation = (item is global::Infragistics.Windows.DataPresenter.Cell) ? this._pivotFixedFieldLocationCell : this._pivotFixedFieldLocation;
				if (fixedFieldLocation != null)
				{
					global::System.Windows.IInputElement inputElement = this._owner.InputHitTest(mouseArgs.GetPosition(this._owner));
					global::Infragistics.Windows.DataPresenter.DataItemPresenter dataItemPresenter = null;
					if (inputElement is global::System.Windows.DependencyObject)
					{
						dataItemPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(inputElement as global::System.Windows.DependencyObject, typeof(global::Infragistics.Windows.DataPresenter.DataItemPresenter), true, this._owner) as global::Infragistics.Windows.DataPresenter.DataItemPresenter);
					}
					bool flag = true;
					if (dataItemPresenter != null)
					{
						global::Infragistics.Windows.DataPresenter.Field field = dataItemPresenter.Field;
						global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation = field.FixedLocation;
						global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(dataItemPresenter, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true, null, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter)) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
						if (virtualizingDataRecordCellPanel == null)
						{
							return;
						}
						bool flag2;
						bool flag3;
						virtualizingDataRecordCellPanel.GetFixedEdgeScrollState(out flag2, out flag3);
						if (fixedFieldLocation == fixedLocation && fixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
						{
							return;
						}
						flag = false;
						if (fixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge && !flag2)
						{
							scrollDirection = new global::Infragistics.Windows.Selection.ScrollDirection?(global::Infragistics.Windows.Selection.ScrollDirection.Decrement);
						}
						else if (fixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge && !flag3)
						{
							scrollDirection = new global::Infragistics.Windows.Selection.ScrollDirection?(global::Infragistics.Windows.Selection.ScrollDirection.Increment);
						}
						else
						{
							flag = (fixedLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable);
						}
					}
					if (flag)
					{
						global::Infragistics.Windows.Selection.ISelectableItem nearestCompatibleItem = ((global::Infragistics.Windows.Selection.ISelectionHost)this._owner).GetNearestCompatibleItem(item, mouseArgs);
						if (nearestCompatibleItem != null && nearestCompatibleItem.IsSelectable && !nearestCompatibleItem.IsSelected)
						{
							global::Infragistics.Windows.DataPresenter.Field field2 = null;
							if (nearestCompatibleItem is global::Infragistics.Windows.DataPresenter.Field)
							{
								field2 = (nearestCompatibleItem as global::Infragistics.Windows.DataPresenter.Field);
							}
							else if (nearestCompatibleItem is global::Infragistics.Windows.DataPresenter.Cell)
							{
								field2 = ((global::Infragistics.Windows.DataPresenter.Cell)nearestCompatibleItem).Field;
							}
							if (field2 != null && field2.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
							{
								if (field2.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge)
								{
									scrollDirection = new global::Infragistics.Windows.Selection.ScrollDirection?(global::Infragistics.Windows.Selection.ScrollDirection.Increment);
									return;
								}
								scrollDirection = new global::Infragistics.Windows.Selection.ScrollDirection?(global::Infragistics.Windows.Selection.ScrollDirection.Decrement);
							}
						}
					}
				}
			}

			// Token: 0x0600107D RID: 4221 RVA: 0x00049818 File Offset: 0x00047A18
			private void VerifyCompatibleItemForField(ref global::Infragistics.Windows.Selection.ISelectableElement selectableElement, global::Infragistics.Windows.Selection.ISelectableItem relatedItem, global::Infragistics.Windows.DataPresenter.DataItemPresenter dip, global::Infragistics.Windows.DataPresenter.FixedFieldLocation fieldLocation, bool isInitialScrollPending)
			{
				if (dip.Field == null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(dip, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true, null, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter)) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
				if (virtualizingDataRecordCellPanel == null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation = dip.Field.FixedLocation;
				if (fixedLocation == fieldLocation)
				{
					if (isInitialScrollPending || fieldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable)
					{
						return;
					}
					bool flag;
					bool flag2;
					virtualizingDataRecordCellPanel.GetFixedEdgeScrollState(out flag, out flag2);
					if (fieldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge && flag)
					{
						return;
					}
					if (fieldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge && flag2)
					{
						return;
					}
				}
				else if (isInitialScrollPending)
				{
					global::System.Windows.Point? point = null;
					if (fieldLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge)
					{
						global::System.Windows.Vector fixedAreaOffset = virtualizingDataRecordCellPanel.GetFixedAreaOffset(global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge, false);
						point = new global::System.Windows.Point?(new global::System.Windows.Point(-fixedAreaOffset.X, -fixedAreaOffset.Y));
					}
					else
					{
						point = new global::System.Windows.Point?(new global::System.Windows.Point(virtualizingDataRecordCellPanel.ActualWidth, virtualizingDataRecordCellPanel.ActualHeight));
					}
					if (point != null)
					{
						virtualizingDataRecordCellPanel.BringIntoView(new global::System.Windows.Rect(point.Value, default(global::System.Windows.Size)));
					}
					if (relatedItem is global::Infragistics.Windows.DataPresenter.Field)
					{
						this._isInitialFieldScrollPending = false;
					}
					else if (relatedItem is global::Infragistics.Windows.DataPresenter.Cell)
					{
						this._isInitialCellFieldScrollPending = false;
					}
					virtualizingDataRecordCellPanel.UpdateLayout();
				}
				else
				{
					bool flag3;
					bool flag4;
					virtualizingDataRecordCellPanel.GetFixedEdgeScrollState(out flag3, out flag4);
					if (fixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge && flag3)
					{
						return;
					}
					if (fixedLocation == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge && flag4)
					{
						return;
					}
					if (relatedItem is global::Infragistics.Windows.DataPresenter.Field && this._owner._itemPendingScrollItemIntoView is global::Infragistics.Windows.DataPresenter.Field)
					{
						global::Infragistics.Windows.DataPresenter.Field field = this._owner._itemPendingScrollItemIntoView as global::Infragistics.Windows.DataPresenter.Field;
						this._owner._itemPendingScrollItemIntoView = null;
						this._owner.BringFieldIntoView(field);
					}
				}
				selectableElement = null;
			}

			// Token: 0x04000689 RID: 1673
			private global::Infragistics.Windows.DataPresenter.FixedRecordLocation? _pivotFixedRecordLocation;

			// Token: 0x0400068A RID: 1674
			private global::Infragistics.Windows.DataPresenter.FixedFieldLocation? _pivotFixedFieldLocation;

			// Token: 0x0400068B RID: 1675
			private global::Infragistics.Windows.DataPresenter.FixedRecordLocation? _pivotFixedRecordLocationCell;

			// Token: 0x0400068C RID: 1676
			private global::Infragistics.Windows.DataPresenter.FixedFieldLocation? _pivotFixedFieldLocationCell;

			// Token: 0x0400068D RID: 1677
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _owner;

			// Token: 0x0400068E RID: 1678
			private bool _isInitialCellFieldScrollPending;

			// Token: 0x0400068F RID: 1679
			private bool _isInitialCellRecordScrollPending;

			// Token: 0x04000690 RID: 1680
			private bool _isInitialRecordScrollPending;

			// Token: 0x04000691 RID: 1681
			private bool _isInitialFieldScrollPending;
		}
	}
}
