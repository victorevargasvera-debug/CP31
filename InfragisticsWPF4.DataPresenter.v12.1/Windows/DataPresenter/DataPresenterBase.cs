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
	// Token: 0x020000CC RID: 204
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.TemplatePart(Name = "PART_ContentSiteGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.StyleTypedProperty(Property = "GroupByAreaFieldLabelStyle", StyleTargetType = typeof(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel))]
	[global::System.Windows.Markup.ContentProperty("DataItems")]
	public abstract class DataPresenterBase : global::Infragistics.Windows.Controls.IGControlBase, global::Infragistics.Windows.Resizing.IResizeHost, global::Infragistics.Windows.Selection.ISelectionHost, global::Infragistics.Windows.Commands.ICommandHost, global::Infragistics.Windows.Scrolling.IDeferredScrollHost, global::Infragistics.Windows.DataPresenter.IViewPanelInfo, global::Infragistics.Windows.Resizing.IAutoResizeHost, global::System.Windows.IWeakEventListener, global::Infragistics.Controls.ISupportScrollHelper, global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginatorFactory
	{
		// Token: 0x0600096E RID: 2414 RVA: 0x00028888 File Offset: 0x00026A88
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
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceProperty = global::System.Windows.DependencyProperty.Register("DataSource", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata());
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceResetBehaviorProperty = global::System.Windows.DependencyProperty.Register("DataSourceResetBehavior", typeof(global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.ReuseRecordsViaEnumerator, global::System.Windows.FrameworkPropertyMetadataOptions.None));
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
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortRecordsByDataTypeProperty = global::System.Windows.DependencyProperty.Register("SortRecordsByDataType", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
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
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00029F44 File Offset: 0x00028144
		protected DataPresenterBase()
		{
			this._isDerived = (typeof(global::Infragistics.Windows.DataPresenter.XamDataGrid) != base.GetType() && typeof(global::Infragistics.Windows.DataPresenter.XamDataPresenter) != base.GetType());
			this._cachedAutoFit = (bool?)global::Infragistics.Windows.DataPresenter.DataPresenterBase.AutoFitProperty.GetMetadata(this).DefaultValue;
			this._cachedIsNestedDataDisplayEnabled = (bool)global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsNestedDataDisplayEnabledProperty.GetMetadata(this).DefaultValue;
			this._cachedCellContainerGenerationMode = (global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode)global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellContainerGenerationModeProperty.GetMetadata(this).DefaultValue;
			this._cachedIsUndoEnabled = (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsUndoEnabledProperty);
			base.Unloaded += this.OnUnloaded;
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupByAreaProperty, new global::Infragistics.Windows.DataPresenter.GroupByArea(this));
			this._fixedScrollHelper = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.FixedAreaScrollHelper(this);
			base.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, global::Infragistics.KnownBoxes.TrueBox);
			this._scrollHelper = new global::Infragistics.Controls.TouchScrollHelper(this, this);
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0002A0A3 File Offset: 0x000282A3
		protected internal override global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Instance;
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002A0AA File Offset: 0x000282AA
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			if (constraint != this._lastMeasureSize)
			{
				this._lastMeasureSize = constraint;
				this.BumpGridMeasureVersion();
			}
			return base.MeasureOverride(constraint);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0002A0CE File Offset: 0x000282CE
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.VerifyContentSiteGrid();
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0002A0DC File Offset: 0x000282DC
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer(this);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0002A0E4 File Offset: 0x000282E4
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
			this.RecordManager.SetActiveRecordFromCurrentItem();
			global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(this, this, "Initialized", null);
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x0002A165 File Offset: 0x00028365
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return this._logicalChildren.GetEnumerator();
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0002A178 File Offset: 0x00028378
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

		// Token: 0x06000977 RID: 2423 RVA: 0x0002A260 File Offset: 0x00028460
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			this._lastKeyDownInfo = null;
			base.OnKeyUp(e);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0002A270 File Offset: 0x00028470
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

		// Token: 0x06000979 RID: 2425 RVA: 0x0002A2B6 File Offset: 0x000284B6
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnMouseMove(e);
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0002A2D3 File Offset: 0x000284D3
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager.OnDragEnd(e, false);
				base.ReleaseMouseCapture();
			}
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002A2F8 File Offset: 0x000284F8
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

		// Token: 0x0600097C RID: 2428 RVA: 0x0002A334 File Offset: 0x00028534
		protected override void OnRenderSizeChanged(global::System.Windows.SizeChangedInfo info)
		{
			base.OnRenderSizeChanged(info);
			this._renderVersion++;
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RenderVersionPropertyKey, this._renderVersion);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002A364 File Offset: 0x00028564
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
				if (e.OldValue != null)
				{
					this.SelectedItems.InternalClearSelection(true, true, true, true);
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
				if (e.OldValue != null)
				{
					this.ClearActiveRecord(true);
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
						global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._x_FieldSettings, this, string.Empty);
					}
					if (this._x_FieldSettings == null)
					{
						base.CoerceValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty);
					}
					this.InvalidateGeneratedStylesAsync();
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
						global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._x_FieldLayoutSettings, this, string.Empty);
					}
					if (this._x_FieldLayoutSettings == null)
					{
						base.CoerceValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsProperty);
					}
					this.InvalidateGeneratedStylesAsync();
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

		// Token: 0x0600097E RID: 2430 RVA: 0x0002A7D4 File Offset: 0x000289D4
		protected virtual void OnAssigningFieldLayoutToItem(global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.AssigningFieldLayoutToItemDirect != null)
			{
				this.AssigningFieldLayoutToItemDirect(this, args);
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0002A7F2 File Offset: 0x000289F2
		internal void RaiseAssigningFieldLayoutToItem(global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.AssigningFieldLayoutToItemEvent;
			args.Source = this;
			this.OnAssigningFieldLayoutToItem(args);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000980 RID: 2432 RVA: 0x0002A80D File Offset: 0x00028A0D
		// (remove) Token: 0x06000981 RID: 2433 RVA: 0x0002A81B File Offset: 0x00028A1B
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

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000982 RID: 2434 RVA: 0x0002A82C File Offset: 0x00028A2C
		// (remove) Token: 0x06000983 RID: 2435 RVA: 0x0002A864 File Offset: 0x00028A64
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs> AssigningFieldLayoutToItemDirect;

		// Token: 0x06000984 RID: 2436 RVA: 0x0002A899 File Offset: 0x00028A99
		protected virtual void OnQuerySummaryResult(global::Infragistics.Windows.DataPresenter.Events.QuerySummaryResultEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0002A8A2 File Offset: 0x00028AA2
		internal void RaiseQuerySummaryResult(global::Infragistics.Windows.DataPresenter.Events.QuerySummaryResultEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.QuerySummaryResultEvent;
			args.Source = this;
			this.OnQuerySummaryResult(args);
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000986 RID: 2438 RVA: 0x0002A8BD File Offset: 0x00028ABD
		// (remove) Token: 0x06000987 RID: 2439 RVA: 0x0002A8CB File Offset: 0x00028ACB
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

		// Token: 0x06000988 RID: 2440 RVA: 0x0002A8D9 File Offset: 0x00028AD9
		protected virtual void OnCellActivated(global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.CellActivatedDirect != null)
			{
				this.CellActivatedDirect(this, args);
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0002A8F7 File Offset: 0x00028AF7
		internal void RaiseCellActivated(global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatedEvent;
			args.Source = this;
			this.OnCellActivated(args);
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600098A RID: 2442 RVA: 0x0002A912 File Offset: 0x00028B12
		// (remove) Token: 0x0600098B RID: 2443 RVA: 0x0002A920 File Offset: 0x00028B20
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

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600098C RID: 2444 RVA: 0x0002A930 File Offset: 0x00028B30
		// (remove) Token: 0x0600098D RID: 2445 RVA: 0x0002A968 File Offset: 0x00028B68
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellActivatedEventArgs> CellActivatedDirect;

		// Token: 0x0600098E RID: 2446 RVA: 0x0002A99D File Offset: 0x00028B9D
		protected virtual void OnCellActivating(global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.CellActivatingDirect != null)
			{
				this.CellActivatingDirect(this, args);
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0002A9BB File Offset: 0x00028BBB
		internal void RaiseCellActivating(global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellActivatingEvent;
			args.Source = this;
			this.OnCellActivating(args);
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000990 RID: 2448 RVA: 0x0002A9D6 File Offset: 0x00028BD6
		// (remove) Token: 0x06000991 RID: 2449 RVA: 0x0002A9E4 File Offset: 0x00028BE4
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

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000992 RID: 2450 RVA: 0x0002A9F4 File Offset: 0x00028BF4
		// (remove) Token: 0x06000993 RID: 2451 RVA: 0x0002AA2C File Offset: 0x00028C2C
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellActivatingEventArgs> CellActivatingDirect;

		// Token: 0x06000994 RID: 2452 RVA: 0x0002AA61 File Offset: 0x00028C61
		protected virtual void OnCellChanged(global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0002AA6A File Offset: 0x00028C6A
		internal void RaiseCellChanged(global::Infragistics.Windows.DataPresenter.Events.CellChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellChangedEvent;
			args.Source = this;
			this.OnCellChanged(args);
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000996 RID: 2454 RVA: 0x0002AA85 File Offset: 0x00028C85
		// (remove) Token: 0x06000997 RID: 2455 RVA: 0x0002AA93 File Offset: 0x00028C93
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

		// Token: 0x06000998 RID: 2456 RVA: 0x0002AAA1 File Offset: 0x00028CA1
		protected virtual void OnCellDeactivating(global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.CellDeactivatingDirect != null)
			{
				this.CellDeactivatingDirect(this, args);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0002AABF File Offset: 0x00028CBF
		internal void RaiseCellDeactivating(global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellDeactivatingEvent;
			args.Source = this;
			this.OnCellDeactivating(args);
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600099A RID: 2458 RVA: 0x0002AADA File Offset: 0x00028CDA
		// (remove) Token: 0x0600099B RID: 2459 RVA: 0x0002AAE8 File Offset: 0x00028CE8
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

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600099C RID: 2460 RVA: 0x0002AAF8 File Offset: 0x00028CF8
		// (remove) Token: 0x0600099D RID: 2461 RVA: 0x0002AB30 File Offset: 0x00028D30
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellDeactivatingEventArgs> CellDeactivatingDirect;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600099E RID: 2462 RVA: 0x0002AB65 File Offset: 0x00028D65
		// (remove) Token: 0x0600099F RID: 2463 RVA: 0x0002AB7E File Offset: 0x00028D7E
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

		// Token: 0x060009A0 RID: 2464 RVA: 0x0002AB97 File Offset: 0x00028D97
		internal void RaiseCellsInViewChanged(global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs eventArgs)
		{
			if (this._cellsInViewChangedEventHandler != null)
			{
				this._cellsInViewChangedEventHandler(this, eventArgs);
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0002ABAE File Offset: 0x00028DAE
		protected virtual void OnCellUpdating(global::Infragistics.Windows.DataPresenter.Events.CellUpdatingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0002ABB7 File Offset: 0x00028DB7
		internal void RaiseCellUpdating(global::Infragistics.Windows.DataPresenter.Events.CellUpdatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatingEvent;
			args.Source = this;
			this.OnCellUpdating(args);
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060009A3 RID: 2467 RVA: 0x0002ABD2 File Offset: 0x00028DD2
		// (remove) Token: 0x060009A4 RID: 2468 RVA: 0x0002ABE0 File Offset: 0x00028DE0
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

		// Token: 0x060009A5 RID: 2469 RVA: 0x0002ABEE File Offset: 0x00028DEE
		protected virtual void OnCellUpdated(global::Infragistics.Windows.DataPresenter.Events.CellUpdatedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0002ABF7 File Offset: 0x00028DF7
		internal void RaiseCellUpdated(global::Infragistics.Windows.DataPresenter.Events.CellUpdatedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CellUpdatedEvent;
			args.Source = this;
			this.OnCellUpdated(args);
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060009A7 RID: 2471 RVA: 0x0002AC12 File Offset: 0x00028E12
		// (remove) Token: 0x060009A8 RID: 2472 RVA: 0x0002AC20 File Offset: 0x00028E20
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

		// Token: 0x060009A9 RID: 2473 RVA: 0x0002AC2E File Offset: 0x00028E2E
		protected virtual void OnClipboardCopying(global::Infragistics.Windows.DataPresenter.Events.ClipboardCopyingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0002AC37 File Offset: 0x00028E37
		internal void RaiseClipboardCopying(global::Infragistics.Windows.DataPresenter.Events.ClipboardCopyingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCopyingEvent;
			args.Source = this;
			this.OnClipboardCopying(args);
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060009AB RID: 2475 RVA: 0x0002AC52 File Offset: 0x00028E52
		// (remove) Token: 0x060009AC RID: 2476 RVA: 0x0002AC60 File Offset: 0x00028E60
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

		// Token: 0x060009AD RID: 2477 RVA: 0x0002AC6E File Offset: 0x00028E6E
		protected virtual void OnClipboardOperationError(global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationErrorEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0002AC77 File Offset: 0x00028E77
		internal void RaiseClipboardOperationError(global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationErrorEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardOperationErrorEvent;
			args.Source = this;
			this.OnClipboardOperationError(args);
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060009AF RID: 2479 RVA: 0x0002AC92 File Offset: 0x00028E92
		// (remove) Token: 0x060009B0 RID: 2480 RVA: 0x0002ACA0 File Offset: 0x00028EA0
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

		// Token: 0x060009B1 RID: 2481 RVA: 0x0002ACAE File Offset: 0x00028EAE
		protected virtual void OnClipboardPasting(global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0002ACC1 File Offset: 0x00028EC1
		internal void RaiseClipboardPasting(global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardPastingEvent;
			args.Source = this;
			this.OnClipboardPasting(args);
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060009B3 RID: 2483 RVA: 0x0002ACDC File Offset: 0x00028EDC
		// (remove) Token: 0x060009B4 RID: 2484 RVA: 0x0002ACEA File Offset: 0x00028EEA
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

		// Token: 0x060009B5 RID: 2485 RVA: 0x0002ACF8 File Offset: 0x00028EF8
		protected virtual void OnCustomFilterSelectionControlOpening(global::Infragistics.Windows.DataPresenter.Events.CustomFilterSelectionControlOpeningEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0002AD01 File Offset: 0x00028F01
		internal void RaiseCustomFilterSelectionControlOpening(global::Infragistics.Windows.DataPresenter.Events.CustomFilterSelectionControlOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.CustomFilterSelectionControlOpeningEvent;
			args.Source = this;
			this.OnCustomFilterSelectionControlOpening(args);
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060009B7 RID: 2487 RVA: 0x0002AD1C File Offset: 0x00028F1C
		// (remove) Token: 0x060009B8 RID: 2488 RVA: 0x0002AD2A File Offset: 0x00028F2A
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

		// Token: 0x060009B9 RID: 2489 RVA: 0x0002AD38 File Offset: 0x00028F38
		protected virtual void OnDataError(global::Infragistics.Windows.DataPresenter.Events.DataErrorEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0002AD41 File Offset: 0x00028F41
		internal void RaiseDataError(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, global::System.Exception exception, global::Infragistics.Windows.DataPresenter.DataErrorOperation operation, string message)
		{
			this.RaiseDataError(record, field, exception, operation, message, false);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002AD54 File Offset: 0x00028F54
		internal void RaiseDataError(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, global::System.Exception exception, global::Infragistics.Windows.DataPresenter.DataErrorOperation operation, string message, bool defaultCancelValue)
		{
			global::Infragistics.Windows.DataPresenter.DataErrorInfo info = new global::Infragistics.Windows.DataPresenter.DataErrorInfo(record, field, exception, operation, message);
			this.RaiseDataError(info, defaultCancelValue);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002AD77 File Offset: 0x00028F77
		internal void RaiseDataError(global::Infragistics.Windows.DataPresenter.DataErrorInfo info)
		{
			this.RaiseDataError(info, false);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0002AD84 File Offset: 0x00028F84
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

		// Token: 0x060009BE RID: 2494 RVA: 0x0002ADDC File Offset: 0x00028FDC
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

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060009BF RID: 2495 RVA: 0x0002AE60 File Offset: 0x00029060
		// (remove) Token: 0x060009C0 RID: 2496 RVA: 0x0002AE6E File Offset: 0x0002906E
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

		// Token: 0x060009C1 RID: 2497 RVA: 0x0002AE7C File Offset: 0x0002907C
		protected virtual void OnDataValueChanged(global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.DataValueChangedDirect != null)
			{
				this.DataValueChangedDirect(this, args);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0002AE9A File Offset: 0x0002909A
		internal void RaiseDataValueChanged(global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataValueChangedEvent;
			args.Source = this;
			this.OnDataValueChanged(args);
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060009C3 RID: 2499 RVA: 0x0002AEB5 File Offset: 0x000290B5
		// (remove) Token: 0x060009C4 RID: 2500 RVA: 0x0002AEC3 File Offset: 0x000290C3
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

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060009C5 RID: 2501 RVA: 0x0002AED4 File Offset: 0x000290D4
		// (remove) Token: 0x060009C6 RID: 2502 RVA: 0x0002AF0C File Offset: 0x0002910C
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs> DataValueChangedDirect;

		// Token: 0x060009C7 RID: 2503 RVA: 0x0002AF41 File Offset: 0x00029141
		protected virtual void OnEditModeEnded(global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002AF4A File Offset: 0x0002914A
		internal void RaiseEditModeEnded(global::Infragistics.Windows.DataPresenter.Events.EditModeEndedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndedEvent;
			args.Source = this;
			this.OnEditModeEnded(args);
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060009C9 RID: 2505 RVA: 0x0002AF65 File Offset: 0x00029165
		// (remove) Token: 0x060009CA RID: 2506 RVA: 0x0002AF73 File Offset: 0x00029173
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

		// Token: 0x060009CB RID: 2507 RVA: 0x0002AF81 File Offset: 0x00029181
		protected virtual void OnEditModeEnding(global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0002AF8A File Offset: 0x0002918A
		internal void RaiseEditModeEnding(global::Infragistics.Windows.DataPresenter.Events.EditModeEndingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeEndingEvent;
			args.Source = this;
			this.OnEditModeEnding(args);
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060009CD RID: 2509 RVA: 0x0002AFA5 File Offset: 0x000291A5
		// (remove) Token: 0x060009CE RID: 2510 RVA: 0x0002AFB3 File Offset: 0x000291B3
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

		// Token: 0x060009CF RID: 2511 RVA: 0x0002AFC1 File Offset: 0x000291C1
		protected virtual void OnEditModeStarted(global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0002AFCA File Offset: 0x000291CA
		internal void RaiseEditModeStarted(global::Infragistics.Windows.DataPresenter.Events.EditModeStartedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartedEvent;
			args.Source = this;
			this.OnEditModeStarted(args);
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060009D1 RID: 2513 RVA: 0x0002AFE5 File Offset: 0x000291E5
		// (remove) Token: 0x060009D2 RID: 2514 RVA: 0x0002AFF3 File Offset: 0x000291F3
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

		// Token: 0x060009D3 RID: 2515 RVA: 0x0002B001 File Offset: 0x00029201
		protected virtual void OnEditModeStarting(global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0002B014 File Offset: 0x00029214
		internal void RaiseEditModeStarting(global::Infragistics.Windows.DataPresenter.Events.EditModeStartingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeStartingEvent;
			args.Source = this;
			this.OnEditModeStarting(args);
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060009D5 RID: 2517 RVA: 0x0002B02F File Offset: 0x0002922F
		// (remove) Token: 0x060009D6 RID: 2518 RVA: 0x0002B03D File Offset: 0x0002923D
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

		// Token: 0x060009D7 RID: 2519 RVA: 0x0002B04B File Offset: 0x0002924B
		protected virtual void OnEditModeValidationError(global::Infragistics.Windows.DataPresenter.Events.EditModeValidationErrorEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0002B054 File Offset: 0x00029254
		internal void RaiseEditModeValidationError(global::Infragistics.Windows.DataPresenter.Events.EditModeValidationErrorEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.EditModeValidationErrorEvent;
			args.Source = this;
			this.OnEditModeValidationError(args);
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x060009D9 RID: 2521 RVA: 0x0002B06F File Offset: 0x0002926F
		// (remove) Token: 0x060009DA RID: 2522 RVA: 0x0002B07D File Offset: 0x0002927D
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

		// Token: 0x060009DB RID: 2523 RVA: 0x0002B08B File Offset: 0x0002928B
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.ExecutingCommandDirect != null)
			{
				this.ExecutingCommandDirect(this, args);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0002B0A9 File Offset: 0x000292A9
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060009DD RID: 2525 RVA: 0x0002B0CD File Offset: 0x000292CD
		// (remove) Token: 0x060009DE RID: 2526 RVA: 0x0002B0DB File Offset: 0x000292DB
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

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060009DF RID: 2527 RVA: 0x0002B0EC File Offset: 0x000292EC
		// (remove) Token: 0x060009E0 RID: 2528 RVA: 0x0002B124 File Offset: 0x00029324
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommandDirect;

		// Token: 0x060009E1 RID: 2529 RVA: 0x0002B159 File Offset: 0x00029359
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.ExecutedCommandDirect != null)
			{
				this.ExecutedCommandDirect(this, args);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0002B177 File Offset: 0x00029377
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060009E3 RID: 2531 RVA: 0x0002B192 File Offset: 0x00029392
		// (remove) Token: 0x060009E4 RID: 2532 RVA: 0x0002B1A0 File Offset: 0x000293A0
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

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060009E5 RID: 2533 RVA: 0x0002B1B0 File Offset: 0x000293B0
		// (remove) Token: 0x060009E6 RID: 2534 RVA: 0x0002B1E8 File Offset: 0x000293E8
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommandDirect;

		// Token: 0x060009E7 RID: 2535 RVA: 0x0002B21D File Offset: 0x0002941D
		protected virtual void OnFieldChooserOpening(global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002B226 File Offset: 0x00029426
		internal void RaiseFieldChooserOpening(global::Infragistics.Windows.DataPresenter.Events.FieldChooserOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldChooserOpeningEvent;
			args.Source = this;
			this.OnFieldChooserOpening(args);
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060009E9 RID: 2537 RVA: 0x0002B241 File Offset: 0x00029441
		// (remove) Token: 0x060009EA RID: 2538 RVA: 0x0002B24F File Offset: 0x0002944F
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

		// Token: 0x060009EB RID: 2539 RVA: 0x0002B260 File Offset: 0x00029460
		internal void RaiseFieldLayoutInitializingEvent(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this.OnFieldLayoutInitializing(new global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializingEventArgs(layout)
			{
				RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializingEvent,
				Source = this
			});
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002B28D File Offset: 0x0002948D
		protected virtual void OnFieldLayoutInitializing(global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060009ED RID: 2541 RVA: 0x0002B296 File Offset: 0x00029496
		// (remove) Token: 0x060009EE RID: 2542 RVA: 0x0002B2A4 File Offset: 0x000294A4
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

		// Token: 0x060009EF RID: 2543 RVA: 0x0002B2B4 File Offset: 0x000294B4
		internal void RaiseFieldLayoutInitializedEvent(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this.OnFieldLayoutInitialized(new global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs(layout)
			{
				RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutInitializedEvent,
				Source = this
			});
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002B2E1 File Offset: 0x000294E1
		protected virtual void OnFieldLayoutInitialized(global::Infragistics.Windows.DataPresenter.Events.FieldLayoutInitializedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060009F1 RID: 2545 RVA: 0x0002B2EA File Offset: 0x000294EA
		// (remove) Token: 0x060009F2 RID: 2546 RVA: 0x0002B2F8 File Offset: 0x000294F8
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

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002B306 File Offset: 0x00029506
		protected virtual void OnFieldPositionChanged(global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002B30F File Offset: 0x0002950F
		internal void RaiseFieldPositionChanged(global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangedEvent;
			args.Source = this;
			this.OnFieldPositionChanged(args);
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060009F5 RID: 2549 RVA: 0x0002B32A File Offset: 0x0002952A
		// (remove) Token: 0x060009F6 RID: 2550 RVA: 0x0002B338 File Offset: 0x00029538
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

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002B346 File Offset: 0x00029546
		protected virtual void OnFieldPositionChanging(global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002B359 File Offset: 0x00029559
		internal void RaiseFieldPositionChanging(global::Infragistics.Windows.DataPresenter.Events.FieldPositionChangingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldPositionChangingEvent;
			args.Source = this;
			this.OnFieldPositionChanging(args);
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060009F9 RID: 2553 RVA: 0x0002B374 File Offset: 0x00029574
		// (remove) Token: 0x060009FA RID: 2554 RVA: 0x0002B382 File Offset: 0x00029582
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

		// Token: 0x060009FB RID: 2555 RVA: 0x0002B390 File Offset: 0x00029590
		protected virtual void OnGrouping(global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002B3A3 File Offset: 0x000295A3
		internal void RaiseGrouping(global::Infragistics.Windows.DataPresenter.Events.GroupingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupingEvent;
			args.Source = this;
			this.OnGrouping(args);
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x060009FD RID: 2557 RVA: 0x0002B3BE File Offset: 0x000295BE
		// (remove) Token: 0x060009FE RID: 2558 RVA: 0x0002B3CC File Offset: 0x000295CC
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

		// Token: 0x060009FF RID: 2559 RVA: 0x0002B3DA File Offset: 0x000295DA
		protected virtual void OnGrouped(global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002B3E3 File Offset: 0x000295E3
		internal void RaiseGrouped(global::Infragistics.Windows.DataPresenter.Events.GroupedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GroupedEvent;
			args.Source = this;
			this.OnGrouped(args);
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000A01 RID: 2561 RVA: 0x0002B3FE File Offset: 0x000295FE
		// (remove) Token: 0x06000A02 RID: 2562 RVA: 0x0002B40C File Offset: 0x0002960C
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

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002B41A File Offset: 0x0002961A
		protected virtual void OnInitializeCellValuePresenter(global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.InitializeCellValuePresenterDirect != null)
			{
				this.InitializeCellValuePresenterDirect(this, args);
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0002B438 File Offset: 0x00029638
		internal void RaiseInitializeCellValuePresenter(global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeCellValuePresenterEvent;
			args.Source = this;
			this.OnInitializeCellValuePresenter(args);
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06000A05 RID: 2565 RVA: 0x0002B453 File Offset: 0x00029653
		// (remove) Token: 0x06000A06 RID: 2566 RVA: 0x0002B461 File Offset: 0x00029661
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

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000A07 RID: 2567 RVA: 0x0002B470 File Offset: 0x00029670
		// (remove) Token: 0x06000A08 RID: 2568 RVA: 0x0002B4A8 File Offset: 0x000296A8
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeCellValuePresenterEventArgs> InitializeCellValuePresenterDirect;

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002B4DD File Offset: 0x000296DD
		protected internal virtual void OnInitializeRecord(global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.InitializeRecordDirect != null)
			{
				this.InitializeRecordDirect(this, args);
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000A0A RID: 2570 RVA: 0x0002B4FB File Offset: 0x000296FB
		// (remove) Token: 0x06000A0B RID: 2571 RVA: 0x0002B509 File Offset: 0x00029709
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

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000A0C RID: 2572 RVA: 0x0002B518 File Offset: 0x00029718
		// (remove) Token: 0x06000A0D RID: 2573 RVA: 0x0002B550 File Offset: 0x00029750
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.InitializeRecordEventArgs> InitializeRecordDirect;

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002B588 File Offset: 0x00029788
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

		// Token: 0x06000A0F RID: 2575 RVA: 0x0002B628 File Offset: 0x00029828
		protected internal virtual void OnInitializeTemplateAddRecord(global::Infragistics.Windows.DataPresenter.Events.InitializeTemplateAddRecordEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000A10 RID: 2576 RVA: 0x0002B631 File Offset: 0x00029831
		// (remove) Token: 0x06000A11 RID: 2577 RVA: 0x0002B63F File Offset: 0x0002983F
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

		// Token: 0x06000A12 RID: 2578 RVA: 0x0002B650 File Offset: 0x00029850
		internal void RaiseInitializeTemplateAddRecord(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this.OnInitializeTemplateAddRecord(new global::Infragistics.Windows.DataPresenter.Events.InitializeTemplateAddRecordEventArgs(record)
			{
				RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.InitializeTemplateAddRecordEvent,
				Source = this
			});
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0002B67D File Offset: 0x0002987D
		protected virtual void OnRecordActivated(global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.RecordActivatedDirect != null)
			{
				this.RecordActivatedDirect(this, args);
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002B69B File Offset: 0x0002989B
		internal void RaiseRecordActivated(global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatedEvent;
			args.Source = this;
			this.OnRecordActivated(args);
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000A15 RID: 2581 RVA: 0x0002B6B6 File Offset: 0x000298B6
		// (remove) Token: 0x06000A16 RID: 2582 RVA: 0x0002B6C4 File Offset: 0x000298C4
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

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06000A17 RID: 2583 RVA: 0x0002B6D4 File Offset: 0x000298D4
		// (remove) Token: 0x06000A18 RID: 2584 RVA: 0x0002B70C File Offset: 0x0002990C
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs> RecordActivatedDirect;

		// Token: 0x06000A19 RID: 2585 RVA: 0x0002B741 File Offset: 0x00029941
		protected virtual void OnRecordActivating(global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.RecordActivatingDirect != null)
			{
				this.RecordActivatingDirect(this, args);
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0002B75F File Offset: 0x0002995F
		internal void RaiseRecordActivating(global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordActivatingEvent;
			args.Source = this;
			this.OnRecordActivating(args);
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06000A1B RID: 2587 RVA: 0x0002B77A File Offset: 0x0002997A
		// (remove) Token: 0x06000A1C RID: 2588 RVA: 0x0002B788 File Offset: 0x00029988
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

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06000A1D RID: 2589 RVA: 0x0002B798 File Offset: 0x00029998
		// (remove) Token: 0x06000A1E RID: 2590 RVA: 0x0002B7D0 File Offset: 0x000299D0
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs> RecordActivatingDirect;

		// Token: 0x06000A1F RID: 2591 RVA: 0x0002B805 File Offset: 0x00029A05
		protected virtual void OnRecordAdding(global::Infragistics.Windows.DataPresenter.Events.RecordAddingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0002B80E File Offset: 0x00029A0E
		internal void RaiseRecordAdding(global::Infragistics.Windows.DataPresenter.Events.RecordAddingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddingEvent;
			args.Source = this;
			this.OnRecordAdding(args);
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000A21 RID: 2593 RVA: 0x0002B829 File Offset: 0x00029A29
		// (remove) Token: 0x06000A22 RID: 2594 RVA: 0x0002B837 File Offset: 0x00029A37
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

		// Token: 0x06000A23 RID: 2595 RVA: 0x0002B845 File Offset: 0x00029A45
		protected virtual void OnRecordAdded(global::Infragistics.Windows.DataPresenter.Events.RecordAddedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0002B84E File Offset: 0x00029A4E
		internal void RaiseRecordAdded(global::Infragistics.Windows.DataPresenter.Events.RecordAddedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordAddedEvent;
			args.Source = this;
			this.OnRecordAdded(args);
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000A25 RID: 2597 RVA: 0x0002B869 File Offset: 0x00029A69
		// (remove) Token: 0x06000A26 RID: 2598 RVA: 0x0002B877 File Offset: 0x00029A77
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

		// Token: 0x06000A27 RID: 2599 RVA: 0x0002B885 File Offset: 0x00029A85
		protected virtual void OnRecordCollapsed(global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0002B88E File Offset: 0x00029A8E
		internal void RaiseRecordCollapsed(global::Infragistics.Windows.DataPresenter.Events.RecordCollapsedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsedEvent;
			args.Source = this;
			this.OnRecordCollapsed(args);
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000A29 RID: 2601 RVA: 0x0002B8A9 File Offset: 0x00029AA9
		// (remove) Token: 0x06000A2A RID: 2602 RVA: 0x0002B8B7 File Offset: 0x00029AB7
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

		// Token: 0x06000A2B RID: 2603 RVA: 0x0002B8C5 File Offset: 0x00029AC5
		protected virtual void OnRecordCollapsing(global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002B8CE File Offset: 0x00029ACE
		internal void RaiseRecordCollapsing(global::Infragistics.Windows.DataPresenter.Events.RecordCollapsingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordCollapsingEvent;
			args.Source = this;
			this.OnRecordCollapsing(args);
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000A2D RID: 2605 RVA: 0x0002B8E9 File Offset: 0x00029AE9
		// (remove) Token: 0x06000A2E RID: 2606 RVA: 0x0002B8F7 File Offset: 0x00029AF7
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

		// Token: 0x06000A2F RID: 2607 RVA: 0x0002B905 File Offset: 0x00029B05
		protected virtual void OnRecordDeactivating(global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.RecordDeactivatingDirect != null)
			{
				this.RecordDeactivatingDirect(this, args);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0002B923 File Offset: 0x00029B23
		internal void RaiseRecordDeactivating(global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordDeactivatingEvent;
			args.Source = this;
			this.OnRecordDeactivating(args);
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06000A31 RID: 2609 RVA: 0x0002B93E File Offset: 0x00029B3E
		// (remove) Token: 0x06000A32 RID: 2610 RVA: 0x0002B94C File Offset: 0x00029B4C
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

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06000A33 RID: 2611 RVA: 0x0002B95C File Offset: 0x00029B5C
		// (remove) Token: 0x06000A34 RID: 2612 RVA: 0x0002B994 File Offset: 0x00029B94
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordDeactivatingEventArgs> RecordDeactivatingDirect;

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002B9C9 File Offset: 0x00029BC9
		protected virtual void OnRecordFilterChanged(global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0002B9D2 File Offset: 0x00029BD2
		internal void RaiseRecordFilterChanged(global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangedEvent;
			args.Source = this;
			this.OnRecordFilterChanged(args);
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06000A37 RID: 2615 RVA: 0x0002B9ED File Offset: 0x00029BED
		// (remove) Token: 0x06000A38 RID: 2616 RVA: 0x0002B9FB File Offset: 0x00029BFB
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

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002BA09 File Offset: 0x00029C09
		protected virtual void OnRecordFilterChanging(global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002BA1C File Offset: 0x00029C1C
		internal void RaiseRecordFilterChanging(global::Infragistics.Windows.DataPresenter.Events.RecordFilterChangingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterChangingEvent;
			args.Source = this;
			this.OnRecordFilterChanging(args);
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x06000A3B RID: 2619 RVA: 0x0002BA37 File Offset: 0x00029C37
		// (remove) Token: 0x06000A3C RID: 2620 RVA: 0x0002BA45 File Offset: 0x00029C45
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

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002BA53 File Offset: 0x00029C53
		protected virtual void OnRecordFilterDropDownItemInitializing(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownItemInitializingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002BA5C File Offset: 0x00029C5C
		internal void RaiseRecordFilterDropDownItemInitializing(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownItemInitializingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownItemInitializingEvent;
			args.Source = this;
			this.OnRecordFilterDropDownItemInitializing(args);
		}

		// Token: 0x1400003B RID: 59
		// (add) Token: 0x06000A3F RID: 2623 RVA: 0x0002BA77 File Offset: 0x00029C77
		// (remove) Token: 0x06000A40 RID: 2624 RVA: 0x0002BA85 File Offset: 0x00029C85
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

		// Token: 0x06000A41 RID: 2625 RVA: 0x0002BA93 File Offset: 0x00029C93
		protected virtual void OnRecordFilterDropDownOpening(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002BA9C File Offset: 0x00029C9C
		internal void RaiseRecordFilterDropDownOpening(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownOpeningEvent;
			args.Source = this;
			this.OnRecordFilterDropDownOpening(args);
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06000A43 RID: 2627 RVA: 0x0002BAB7 File Offset: 0x00029CB7
		// (remove) Token: 0x06000A44 RID: 2628 RVA: 0x0002BAC5 File Offset: 0x00029CC5
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

		// Token: 0x06000A45 RID: 2629 RVA: 0x0002BAD3 File Offset: 0x00029CD3
		protected virtual void OnRecordFilterDropDownPopulating(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0002BADC File Offset: 0x00029CDC
		internal void RaiseRecordFilterDropDownPopulating(global::Infragistics.Windows.DataPresenter.Events.RecordFilterDropDownPopulatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFilterDropDownPopulatingEvent;
			args.Source = this;
			this.OnRecordFilterDropDownPopulating(args);
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06000A47 RID: 2631 RVA: 0x0002BAF7 File Offset: 0x00029CF7
		// (remove) Token: 0x06000A48 RID: 2632 RVA: 0x0002BB05 File Offset: 0x00029D05
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

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002BB13 File Offset: 0x00029D13
		protected virtual void OnRecordsDeleted(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002BB1C File Offset: 0x00029D1C
		internal void RaiseRecordsDeleted(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletedEvent;
			args.Source = this;
			this.OnRecordsDeleted(args);
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06000A4B RID: 2635 RVA: 0x0002BB37 File Offset: 0x00029D37
		// (remove) Token: 0x06000A4C RID: 2636 RVA: 0x0002BB45 File Offset: 0x00029D45
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

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002BB53 File Offset: 0x00029D53
		protected virtual void OnRecordsDeleting(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0002BB66 File Offset: 0x00029D66
		internal void RaiseRecordsDeleting(global::Infragistics.Windows.DataPresenter.Events.RecordsDeletingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsDeletingEvent;
			args.Source = this;
			this.OnRecordsDeleting(args);
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06000A4F RID: 2639 RVA: 0x0002BB81 File Offset: 0x00029D81
		// (remove) Token: 0x06000A50 RID: 2640 RVA: 0x0002BB8F File Offset: 0x00029D8F
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

		// Token: 0x06000A51 RID: 2641 RVA: 0x0002BB9D File Offset: 0x00029D9D
		protected virtual void OnRecordExpanded(global::Infragistics.Windows.DataPresenter.Events.RecordExpandedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0002BBA6 File Offset: 0x00029DA6
		internal void RaiseRecordExpanded(global::Infragistics.Windows.DataPresenter.Events.RecordExpandedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandedEvent;
			args.Source = this;
			this.OnRecordExpanded(args);
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06000A53 RID: 2643 RVA: 0x0002BBC1 File Offset: 0x00029DC1
		// (remove) Token: 0x06000A54 RID: 2644 RVA: 0x0002BBCF File Offset: 0x00029DCF
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

		// Token: 0x06000A55 RID: 2645 RVA: 0x0002BBDD File Offset: 0x00029DDD
		protected virtual void OnRecordExpanding(global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		internal void RaiseRecordExpanding(global::Infragistics.Windows.DataPresenter.Events.RecordExpandingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordExpandingEvent;
			args.Source = this;
			this.OnRecordExpanding(args);
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06000A57 RID: 2647 RVA: 0x0002BC0B File Offset: 0x00029E0B
		// (remove) Token: 0x06000A58 RID: 2648 RVA: 0x0002BC19 File Offset: 0x00029E19
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

		// Token: 0x06000A59 RID: 2649 RVA: 0x0002BC27 File Offset: 0x00029E27
		protected virtual void OnRecordFixedLocationChanged(global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0002BC30 File Offset: 0x00029E30
		internal void RaiseRecordFixedLocationChanged(global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangedEvent;
			args.Source = this;
			this.OnRecordFixedLocationChanged(args);
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06000A5B RID: 2651 RVA: 0x0002BC4B File Offset: 0x00029E4B
		// (remove) Token: 0x06000A5C RID: 2652 RVA: 0x0002BC59 File Offset: 0x00029E59
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

		// Token: 0x06000A5D RID: 2653 RVA: 0x0002BC67 File Offset: 0x00029E67
		protected virtual void OnRecordFixedLocationChanging(global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0002BC7A File Offset: 0x00029E7A
		internal void RaiseRecordFixedLocationChanging(global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordFixedLocationChangingEvent;
			args.Source = this;
			this.OnRecordFixedLocationChanging(args);
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06000A5F RID: 2655 RVA: 0x0002BC95 File Offset: 0x00029E95
		// (remove) Token: 0x06000A60 RID: 2656 RVA: 0x0002BCA3 File Offset: 0x00029EA3
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

		// Token: 0x06000A61 RID: 2657 RVA: 0x0002BCB1 File Offset: 0x00029EB1
		protected virtual void OnRecordsInViewChanged(global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
			if (this.RecordsInViewChangedDirect != null)
			{
				this.RecordsInViewChangedDirect(this, args);
			}
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0002BCD0 File Offset: 0x00029ED0
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

		// Token: 0x06000A63 RID: 2659 RVA: 0x0002BD16 File Offset: 0x00029F16
		internal void RaiseRecordsInViewChanged(global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewChangedEvent;
			args.Source = this;
			this.OnRecordsInViewChanged(args);
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06000A64 RID: 2660 RVA: 0x0002BD31 File Offset: 0x00029F31
		// (remove) Token: 0x06000A65 RID: 2661 RVA: 0x0002BD3F File Offset: 0x00029F3F
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

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06000A66 RID: 2662 RVA: 0x0002BD50 File Offset: 0x00029F50
		// (remove) Token: 0x06000A67 RID: 2663 RVA: 0x0002BD88 File Offset: 0x00029F88
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.RecordsInViewChangedEventArgs> RecordsInViewChangedDirect;

		// Token: 0x06000A68 RID: 2664 RVA: 0x0002BDBD File Offset: 0x00029FBD
		protected virtual void OnRecordUpdateCanceling(global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCancelingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0002BDC6 File Offset: 0x00029FC6
		internal void RaiseRecordUpdateCanceling(global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCancelingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCancelingEvent;
			args.Source = this;
			this.OnRecordUpdateCanceling(args);
		}

		// Token: 0x14000046 RID: 70
		// (add) Token: 0x06000A6A RID: 2666 RVA: 0x0002BDE1 File Offset: 0x00029FE1
		// (remove) Token: 0x06000A6B RID: 2667 RVA: 0x0002BDEF File Offset: 0x00029FEF
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

		// Token: 0x06000A6C RID: 2668 RVA: 0x0002BDFD File Offset: 0x00029FFD
		protected virtual void OnRecordUpdateCanceled(global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCanceledEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0002BE06 File Offset: 0x0002A006
		internal void RaiseRecordUpdateCanceled(global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCanceledEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdateCanceledEvent;
			args.Source = this;
			this.OnRecordUpdateCanceled(args);
		}

		// Token: 0x14000047 RID: 71
		// (add) Token: 0x06000A6E RID: 2670 RVA: 0x0002BE21 File Offset: 0x0002A021
		// (remove) Token: 0x06000A6F RID: 2671 RVA: 0x0002BE2F File Offset: 0x0002A02F
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

		// Token: 0x06000A70 RID: 2672 RVA: 0x0002BE3D File Offset: 0x0002A03D
		protected virtual void OnRecordUpdating(global::Infragistics.Windows.DataPresenter.Events.RecordUpdatingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0002BE46 File Offset: 0x0002A046
		internal void RaiseRecordUpdating(global::Infragistics.Windows.DataPresenter.Events.RecordUpdatingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatingEvent;
			args.Source = this;
			this.OnRecordUpdating(args);
		}

		// Token: 0x14000048 RID: 72
		// (add) Token: 0x06000A72 RID: 2674 RVA: 0x0002BE61 File Offset: 0x0002A061
		// (remove) Token: 0x06000A73 RID: 2675 RVA: 0x0002BE6F File Offset: 0x0002A06F
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

		// Token: 0x06000A74 RID: 2676 RVA: 0x0002BE7D File Offset: 0x0002A07D
		protected virtual void OnRecordUpdated(global::Infragistics.Windows.DataPresenter.Events.RecordUpdatedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0002BE86 File Offset: 0x0002A086
		internal void RaiseRecordUpdated(global::Infragistics.Windows.DataPresenter.Events.RecordUpdatedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordUpdatedEvent;
			args.Source = this;
			this.OnRecordUpdated(args);
		}

		// Token: 0x14000049 RID: 73
		// (add) Token: 0x06000A76 RID: 2678 RVA: 0x0002BEA1 File Offset: 0x0002A0A1
		// (remove) Token: 0x06000A77 RID: 2679 RVA: 0x0002BEAF File Offset: 0x0002A0AF
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

		// Token: 0x06000A78 RID: 2680 RVA: 0x0002BEBD File Offset: 0x0002A0BD
		protected virtual void OnSelectedItemsChanged(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0002BEC6 File Offset: 0x0002A0C6
		internal void RaiseSelectedItemsChangedAsync(global::System.Type type)
		{
			if (this._selectedItemsChangePending != null)
			{
				return;
			}
			this._selectedItemsChangePending = type;
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ProcessSelectedItemsChanged));
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0002BEF8 File Offset: 0x0002A0F8
		internal void ProcessSelectedItemsChanged()
		{
			if (this._selectedItemsChangePending == null)
			{
				return;
			}
			this.RaiseSelectedItemsChanged(new global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs(this._selectedItemsChangePending));
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0002BF1C File Offset: 0x0002A11C
		internal void RaiseSelectedItemsChanged(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangedEventArgs args)
		{
			this._selectedItemsChangePending = null;
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangedEvent;
			args.Source = this;
			this.OnSelectedItemsChanged(args);
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel;
			if (viewPanel != null)
			{
				viewPanel.OnSelectedItemsChanged();
			}
		}

		// Token: 0x1400004A RID: 74
		// (add) Token: 0x06000A7C RID: 2684 RVA: 0x0002BF5E File Offset: 0x0002A15E
		// (remove) Token: 0x06000A7D RID: 2685 RVA: 0x0002BF6C File Offset: 0x0002A16C
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

		// Token: 0x06000A7E RID: 2686 RVA: 0x0002BF7A File Offset: 0x0002A17A
		protected virtual void OnSelectedItemsChanging(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0002BF83 File Offset: 0x0002A183
		internal void RaiseSelectedItemsChanging(global::Infragistics.Windows.DataPresenter.Events.SelectedItemsChangingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemsChangingEvent;
			args.Source = this;
			this.OnSelectedItemsChanging(args);
		}

		// Token: 0x1400004B RID: 75
		// (add) Token: 0x06000A80 RID: 2688 RVA: 0x0002BF9E File Offset: 0x0002A19E
		// (remove) Token: 0x06000A81 RID: 2689 RVA: 0x0002BFAC File Offset: 0x0002A1AC
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

		// Token: 0x06000A82 RID: 2690 RVA: 0x0002BFBA File Offset: 0x0002A1BA
		protected virtual void OnSorting(global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0002BFCD File Offset: 0x0002A1CD
		internal void RaiseSorting(global::Infragistics.Windows.DataPresenter.Events.SortingEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortingEvent;
			args.Source = this;
			this.OnSorting(args);
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x06000A84 RID: 2692 RVA: 0x0002BFE8 File Offset: 0x0002A1E8
		// (remove) Token: 0x06000A85 RID: 2693 RVA: 0x0002BFF6 File Offset: 0x0002A1F6
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

		// Token: 0x06000A86 RID: 2694 RVA: 0x0002C004 File Offset: 0x0002A204
		protected virtual void OnSorted(global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0002C00D File Offset: 0x0002A20D
		internal void RaiseSorted(global::Infragistics.Windows.DataPresenter.Events.SortedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SortedEvent;
			args.Source = this;
			this.OnSorted(args);
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x06000A88 RID: 2696 RVA: 0x0002C028 File Offset: 0x0002A228
		// (remove) Token: 0x06000A89 RID: 2697 RVA: 0x0002C036 File Offset: 0x0002A236
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

		// Token: 0x06000A8A RID: 2698 RVA: 0x0002C044 File Offset: 0x0002A244
		protected virtual void OnSummaryResultChanged(global::Infragistics.Windows.DataPresenter.Events.SummaryResultChangedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0002C04D File Offset: 0x0002A24D
		internal void RaiseSummaryResultChanged(global::Infragistics.Windows.DataPresenter.Events.SummaryResultChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummaryResultChangedEvent;
			args.Source = this;
			this.OnSummaryResultChanged(args);
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06000A8C RID: 2700 RVA: 0x0002C068 File Offset: 0x0002A268
		// (remove) Token: 0x06000A8D RID: 2701 RVA: 0x0002C076 File Offset: 0x0002A276
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

		// Token: 0x06000A8E RID: 2702 RVA: 0x0002C084 File Offset: 0x0002A284
		protected virtual void OnSummarySelectionControlClosed(global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlClosedEventArgs args)
		{
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0002C08D File Offset: 0x0002A28D
		internal void RaiseSummarySelectionControlClosed(global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlClosedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlClosedEvent;
			args.Source = this;
			this.OnSummarySelectionControlClosed(args);
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06000A90 RID: 2704 RVA: 0x0002C0A8 File Offset: 0x0002A2A8
		// (remove) Token: 0x06000A91 RID: 2705 RVA: 0x0002C0B6 File Offset: 0x0002A2B6
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

		// Token: 0x06000A92 RID: 2706 RVA: 0x0002C0C4 File Offset: 0x0002A2C4
		protected virtual void OnSummarySelectionControlOpening(global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs args)
		{
			if (!this.VerifyOperationIsAllowed(args))
			{
				return;
			}
			this.RaiseEventHelper(args);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0002C0D7 File Offset: 0x0002A2D7
		internal void RaiseSummarySelectionControlOpening(global::Infragistics.Windows.DataPresenter.Events.SummarySelectionControlOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SummarySelectionControlOpeningEvent;
			args.Source = this;
			this.OnSummarySelectionControlOpening(args);
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000A94 RID: 2708 RVA: 0x0002C0F2 File Offset: 0x0002A2F2
		// (remove) Token: 0x06000A95 RID: 2709 RVA: 0x0002C100 File Offset: 0x0002A300
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

		// Token: 0x06000A96 RID: 2710 RVA: 0x0002C110 File Offset: 0x0002A310
		private static object CoerceActiveDataItem(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			return dataPresenterBase.SynchDataItemValue(value);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0002C12C File Offset: 0x0002A32C
		private static void OnActiveDataItemChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)dependencyObject;
			dataPresenterBase.SynchDataItemValue(e.NewValue);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0002C150 File Offset: 0x0002A350
		private object SynchDataItemValue(object value)
		{
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
				if (dataRecord != null && dataRecord.DataItemForComparison != null && dataRecord.DataItemForComparison == global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(value))
				{
					return value;
				}
				dataRecord = this.GetRecordFromDataItem(value, true);
				if (dataRecord != null && dataRecord != this.ActiveRecord)
				{
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x0002C1D0 File Offset: 0x0002A3D0
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x0002C1DD File Offset: 0x0002A3DD
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06000A9B RID: 2715 RVA: 0x0002C1EC File Offset: 0x0002A3EC
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

		// Token: 0x06000A9C RID: 2716 RVA: 0x0002C240 File Offset: 0x0002A440
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0002C292 File Offset: 0x0002A492
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
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

		// Token: 0x06000A9F RID: 2719 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
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

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002C328 File Offset: 0x0002A528
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

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0002C354 File Offset: 0x0002A554
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0002C362 File Offset: 0x0002A562
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0002C370 File Offset: 0x0002A570
		internal global::Infragistics.Windows.DataPresenter.Record ActiveRecordInternal
		{
			get
			{
				return this._activeRecord;
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0002C378 File Offset: 0x0002A578
		private static void OnAutoFitChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				bool? cachedAutoFit = (bool?)e.NewValue;
				dataPresenterBase._cachedAutoFit = cachedAutoFit;
				dataPresenterBase.UpdateScrollBarVisibility();
				dataPresenterBase.InvalidateGeneratedStylesAsync();
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0002C3AF File Offset: 0x0002A5AF
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0002C3B7 File Offset: 0x0002A5B7
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
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

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0002C3CA File Offset: 0x0002A5CA
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

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0002C3F0 File Offset: 0x0002A5F0
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

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0002C435 File Offset: 0x0002A635
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0002C447 File Offset: 0x0002A647
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

		// Token: 0x06000AAB RID: 2731 RVA: 0x0002C45C File Offset: 0x0002A65C
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

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0002C4F7 File Offset: 0x0002A6F7
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x0002C509 File Offset: 0x0002A709
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

		// Token: 0x06000AAE RID: 2734 RVA: 0x0002C518 File Offset: 0x0002A718
		private static void OnCellContainerGenerationModeChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)dependencyObject;
			global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode cachedCellContainerGenerationMode = (global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode)e.NewValue;
			dataPresenterBase._cachedCellContainerGenerationMode = cachedCellContainerGenerationMode;
			dataPresenterBase.InvalidateGeneratedStyles(true, false);
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002C548 File Offset: 0x0002A748
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0002C55A File Offset: 0x0002A75A
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

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0002C56D File Offset: 0x0002A76D
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0002C57F File Offset: 0x0002A77F
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

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002C58D File Offset: 0x0002A78D
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0002C59F File Offset: 0x0002A79F
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

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002C5AD File Offset: 0x0002A7AD
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0002C5BF File Offset: 0x0002A7BF
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

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0002C5CD File Offset: 0x0002A7CD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static global::Infragistics.Windows.DataPresenter.ViewBase GetCurrentView(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.ViewBase)d.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002C5DF File Offset: 0x0002A7DF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetCurrentView(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DataPresenter.ViewBase value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.CurrentViewProperty, value);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002C5ED File Offset: 0x0002A7ED
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0002C609 File Offset: 0x0002A809
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x0002C61B File Offset: 0x0002A81B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002C629 File Offset: 0x0002A829
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0002C63B File Offset: 0x0002A83B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0002C650 File Offset: 0x0002A850
		// (set) Token: 0x06000ABF RID: 2751 RVA: 0x0002C6CA File Offset: 0x0002A8CA
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
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0002C6F4 File Offset: 0x0002A8F4
		private static void OnExportStatusChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = d as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			global::Infragistics.Windows.DataPresenter.RecordExportStatus recordExportStatus = (global::Infragistics.Windows.DataPresenter.RecordExportStatus)dataPresenterBase.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ExportStatusProperty);
			dataPresenterBase._cachedExportStatus = recordExportStatus;
			dataPresenterBase.IsExporting = (recordExportStatus != global::Infragistics.Windows.DataPresenter.RecordExportStatus.NotExporting);
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0002C72D File Offset: 0x0002A92D
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x0002C735 File Offset: 0x0002A935
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0002C748 File Offset: 0x0002A948
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

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002C764 File Offset: 0x0002A964
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutCollection FieldLayoutsIfAllocated
		{
			get
			{
				return this._fieldLayouts;
			}
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0002C76C File Offset: 0x0002A96C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldLayouts()
		{
			return this._fieldLayouts != null && this._fieldLayouts.ShouldSerialize();
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0002C783 File Offset: 0x0002A983
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFieldLayouts()
		{
			if (this.ShouldSerializeFieldLayouts())
			{
				this._fieldLayouts.Clear();
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0002C798 File Offset: 0x0002A998
		private static object CoerceFieldLayoutSettings(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(dataPresenterBase))
			{
				return dataPresenterBase.FieldLayoutSettings;
			}
			return value;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
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

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0002C830 File Offset: 0x0002AA30
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x0002C864 File Offset: 0x0002AA64
		public global::Infragistics.Windows.DataPresenter.FieldLayoutSettings FieldLayoutSettings
		{
			get
			{
				if (this._x_FieldLayoutSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._x_FieldLayoutSettings = new global::Infragistics.Windows.DataPresenter.FieldLayoutSettings();
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._x_FieldLayoutSettings, this, string.Empty);
				}
				return this._x_FieldLayoutSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsProperty, value);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0002C872 File Offset: 0x0002AA72
		internal global::Infragistics.Windows.DataPresenter.FieldLayoutSettings FieldLayoutSettingsIfAllocated
		{
			get
			{
				return this._x_FieldLayoutSettings;
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0002C87A File Offset: 0x0002AA7A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldLayoutSettings()
		{
			return this._x_FieldLayoutSettings != null && this._x_FieldLayoutSettings.ShouldSerialize();
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0002C891 File Offset: 0x0002AA91
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

		// Token: 0x06000ACE RID: 2766 RVA: 0x0002C8BC File Offset: 0x0002AABC
		private static object CoerceFieldSettings(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (value == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(dataPresenterBase))
			{
				return dataPresenterBase.FieldSettings;
			}
			return value;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0002C8E4 File Offset: 0x0002AAE4
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

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0002C9AC File Offset: 0x0002ABAC
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x0002C9E0 File Offset: 0x0002ABE0
		public global::Infragistics.Windows.DataPresenter.FieldSettings FieldSettings
		{
			get
			{
				if (this._x_FieldSettings == null && !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
				{
					this._x_FieldSettings = new global::Infragistics.Windows.DataPresenter.FieldSettings();
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._x_FieldSettings, this, string.Empty);
				}
				return this._x_FieldSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsProperty, value);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002C9EE File Offset: 0x0002ABEE
		internal global::Infragistics.Windows.DataPresenter.FieldSettings FieldSettingsIfAllocated
		{
			get
			{
				return this._x_FieldSettings;
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0002C9F6 File Offset: 0x0002ABF6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFieldSettings()
		{
			return this._x_FieldSettings != null && this._x_FieldSettings.ShouldSerialize();
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0002CA0D File Offset: 0x0002AC0D
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

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0002CA38 File Offset: 0x0002AC38
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

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0002CACC File Offset: 0x0002ACCC
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0002CB06 File Offset: 0x0002AD06
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x0002CB0E File Offset: 0x0002AD0E
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0002CB1C File Offset: 0x0002AD1C
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0002CB2E File Offset: 0x0002AD2E
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0002CB3C File Offset: 0x0002AD3C
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0002CB4E File Offset: 0x0002AD4E
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

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0002CB5C File Offset: 0x0002AD5C
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x0002CB6E File Offset: 0x0002AD6E
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

		// Token: 0x06000ADF RID: 2783 RVA: 0x0002CB84 File Offset: 0x0002AD84
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

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0002CBB7 File Offset: 0x0002ADB7
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x0002CBC9 File Offset: 0x0002ADC9
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

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0002CBDC File Offset: 0x0002ADDC
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0002CC5F File Offset: 0x0002AE5F
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0002CC67 File Offset: 0x0002AE67
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

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0002CC75 File Offset: 0x0002AE75
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x0002CC87 File Offset: 0x0002AE87
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DefaultValue(null)]
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

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0002CC98 File Offset: 0x0002AE98
		private static void OnIsExportingChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = d as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			dataPresenterBase._isExporting = (bool)e.NewValue;
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0002CCC3 File Offset: 0x0002AEC3
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x0002CCCB File Offset: 0x0002AECB
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

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x0002CCDE File Offset: 0x0002AEDE
		// (set) Token: 0x06000AEB RID: 2795 RVA: 0x0002CCF0 File Offset: 0x0002AEF0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000AEC RID: 2796 RVA: 0x0002CD04 File Offset: 0x0002AF04
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

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x0002CD42 File Offset: 0x0002AF42
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x0002CD4A File Offset: 0x0002AF4A
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000AEF RID: 2799 RVA: 0x0002CD60 File Offset: 0x0002AF60
		private static void OnIsSynchronizedWithCurrentItemChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null && (bool)e.NewValue)
			{
				dataPresenterBase.RecordManager.SetActiveRecordFromCurrentItem();
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000AF0 RID: 2800 RVA: 0x0002CD90 File Offset: 0x0002AF90
		// (set) Token: 0x06000AF1 RID: 2801 RVA: 0x0002CDA2 File Offset: 0x0002AFA2
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

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0002CDB8 File Offset: 0x0002AFB8
		private static void OnIsTouchSupportEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d;
			dataPresenterBase._scrollHelper.IsEnabled = (bool)e.NewValue;
			dataPresenterBase.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, global::Infragistics.KnownBoxes.FromValue((bool)e.NewValue));
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0002CDFF File Offset: 0x0002AFFF
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0002CE11 File Offset: 0x0002B011
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

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0002CE24 File Offset: 0x0002B024
		private static void OnIsUndoEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d;
			dataPresenterBase._cachedIsUndoEnabled = (bool)e.NewValue;
			if (false.Equals(e.NewValue) && dataPresenterBase._history != null)
			{
				dataPresenterBase._history.Clear();
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0002CE6F File Offset: 0x0002B06F
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x0002CE77 File Offset: 0x0002B077
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

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0002CE8A File Offset: 0x0002B08A
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x0002CE91 File Offset: 0x0002B091
		public static bool ProcessCellInvalidationsSynchronously { get; set; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0002CE99 File Offset: 0x0002B099
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x0002CEAB File Offset: 0x0002B0AB
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

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0002CEBE File Offset: 0x0002B0BE
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x0002CED0 File Offset: 0x0002B0D0
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0002CEE4 File Offset: 0x0002B0E4
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

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0002CF3A File Offset: 0x0002B13A
		internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManagerIfAllocated
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0002CF44 File Offset: 0x0002B144
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

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0002CF95 File Offset: 0x0002B195
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x06000B02 RID: 2818 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		private static bool ValidateRecordSelectorExtent(object value)
		{
			double num = (double)value;
			return double.IsNaN(num) || (num >= 0.0 && !double.IsInfinity(num));
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
		private static void OnRecordSelectorExtentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			dataPresenterBase._cachedRecordSelectorExtent = (double)e.NewValue;
			dataPresenterBase.InvalidateGeneratedStylesAsync();
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0002D01C File Offset: 0x0002B21C
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x0002D024 File Offset: 0x0002B224
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

		// Token: 0x06000B06 RID: 2822 RVA: 0x0002D038 File Offset: 0x0002B238
		private static void OnRecordSelectorErrorIconExtentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			dataPresenterBase._cachedRecordSelectorErrorIconExtent = (double)e.NewValue;
			dataPresenterBase.InvalidateGeneratedStylesAsync();
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0002D064 File Offset: 0x0002B264
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x0002D06C File Offset: 0x0002B26C
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

		// Token: 0x06000B09 RID: 2825 RVA: 0x0002D080 File Offset: 0x0002B280
		private static void OnRecordSelectorFixButtonExtentChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = target as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			dataPresenterBase._cachedRecordSelectorFixButtonExtent = (double)e.NewValue;
			dataPresenterBase.InvalidateGeneratedStylesAsync();
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0002D0AC File Offset: 0x0002B2AC
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x0002D0B4 File Offset: 0x0002B2B4
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

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0002D0C7 File Offset: 0x0002B2C7
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x0002D0D9 File Offset: 0x0002B2D9
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

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0002D0E7 File Offset: 0x0002B2E7
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x0002D0F9 File Offset: 0x0002B2F9
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

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0002D10C File Offset: 0x0002B30C
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0002D11E File Offset: 0x0002B31E
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0002D131 File Offset: 0x0002B331
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x06000B13 RID: 2835 RVA: 0x0002D148 File Offset: 0x0002B348
		private static bool OnValidateScrollingMode(object value)
		{
			if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.ScrollingMode), value))
			{
				throw new global::System.ArgumentException();
			}
			return true;
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0002D163 File Offset: 0x0002B363
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x0002D175 File Offset: 0x0002B375
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

		// Token: 0x06000B16 RID: 2838 RVA: 0x0002D188 File Offset: 0x0002B388
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeScrollingMode()
		{
			return base.ReadLocalValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollingModeProperty) != global::System.Windows.DependencyProperty.UnsetValue;
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x0002D19F File Offset: 0x0002B39F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetScrollingMode()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollingModeProperty);
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0002D1AC File Offset: 0x0002B3AC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0002D1C8 File Offset: 0x0002B3C8
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0002D1D0 File Offset: 0x0002B3D0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0002D1D9 File Offset: 0x0002B3D9
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0002D1EB File Offset: 0x0002B3EB
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
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

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0002D1FE File Offset: 0x0002B3FE
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

		// Token: 0x06000B1E RID: 2846 RVA: 0x0002D220 File Offset: 0x0002B420
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

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0002D2DA File Offset: 0x0002B4DA
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.DataPresenterThemeTypeConverter))]
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

		// Token: 0x06000B21 RID: 2849 RVA: 0x0002D2E8 File Offset: 0x0002B4E8
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			this.RaiseEventHelper(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x06000B22 RID: 2850 RVA: 0x0002D316 File Offset: 0x0002B516
		// (remove) Token: 0x06000B23 RID: 2851 RVA: 0x0002D324 File Offset: 0x0002B524
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

		// Token: 0x06000B24 RID: 2852 RVA: 0x0002D334 File Offset: 0x0002B534
		private static void OnUndoLimitChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d;
			if (dataPresenterBase._history != null)
			{
				dataPresenterBase._history.UndoLimit = (int)e.NewValue;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0002D367 File Offset: 0x0002B567
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0002D379 File Offset: 0x0002B579
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

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0002D38C File Offset: 0x0002B58C
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0002D39E File Offset: 0x0002B59E
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

		// Token: 0x06000B29 RID: 2857 RVA: 0x0002D3B4 File Offset: 0x0002B5B4
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

		// Token: 0x06000B2A RID: 2858 RVA: 0x0002D428 File Offset: 0x0002B628
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

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0002D484 File Offset: 0x0002B684
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

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0002D4CC File Offset: 0x0002B6CC
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

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0002D54C File Offset: 0x0002B74C
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0002D568 File Offset: 0x0002B768
		internal global::Infragistics.Windows.Commands.CommandsBase CommandsInternal
		{
			get
			{
				return this.Commands;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0002D570 File Offset: 0x0002B770
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0002D5C1 File Offset: 0x0002B7C1
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

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0002D5D3 File Offset: 0x0002B7D3
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x0002D5DC File Offset: 0x0002B7DC
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
					this.InitializeSpacingOnResizeController();
				}
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0002D6E0 File Offset: 0x0002B8E0
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

		// Token: 0x06000B34 RID: 2868 RVA: 0x0002D6FC File Offset: 0x0002B8FC
		private static void OnDataPresenterChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0002D6FE File Offset: 0x0002B8FE
		internal static global::Infragistics.Windows.DataPresenter.DataPresenterBase GetDataPresenter(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.DataPresenterBase)d.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0002D710 File Offset: 0x0002B910
		internal static void SetDataPresenter(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DataPresenter.DataPresenterBase value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataPresenterProperty, value);
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0002D720 File Offset: 0x0002B920
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

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0002DAA8 File Offset: 0x0002BCA8
		internal object DataSourceInternal
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalProperty);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0002DAB5 File Offset: 0x0002BCB5
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

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0002DAD1 File Offset: 0x0002BCD1
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0002DAED File Offset: 0x0002BCED
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

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0002DB09 File Offset: 0x0002BD09
		internal bool HasAutoSizeAllRecordFields
		{
			get
			{
				return this._fieldLayoutAutoSizeAllRecordsCount > 0;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0002DB14 File Offset: 0x0002BD14
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x0002DB1C File Offset: 0x0002BD1C
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0002DB25 File Offset: 0x0002BD25
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x0002DB2D File Offset: 0x0002BD2D
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0002DB36 File Offset: 0x0002BD36
		internal bool HasFieldLayoutSettings
		{
			get
			{
				return this._x_FieldLayoutSettings != null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0002DB44 File Offset: 0x0002BD44
		internal bool HasFieldLayouts
		{
			get
			{
				return this._fieldLayouts != null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0002DB52 File Offset: 0x0002BD52
		internal bool HasFieldSettings
		{
			get
			{
				return this._x_FieldSettings != null;
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0002DB60 File Offset: 0x0002BD60
		private void BumpGridMeasureVersion()
		{
			int num = (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GridMeasureVersionProperty);
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GridMeasureVersionProperty, num + 1);
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0002DB91 File Offset: 0x0002BD91
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

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0002DBAD File Offset: 0x0002BDAD
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0002DBC9 File Offset: 0x0002BDC9
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0002DBE5 File Offset: 0x0002BDE5
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0002DC01 File Offset: 0x0002BE01
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0002DC1D File Offset: 0x0002BE1D
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0002DC39 File Offset: 0x0002BE39
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

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0002DC55 File Offset: 0x0002BE55
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

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x0002DC71 File Offset: 0x0002BE71
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

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002DC8D File Offset: 0x0002BE8D
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

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0002DCA9 File Offset: 0x0002BEA9
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

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0002DCC5 File Offset: 0x0002BEC5
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

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0002DCE1 File Offset: 0x0002BEE1
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> InternalRecords
		{
			get
			{
				return (global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.InternalRecordsProperty);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0002DCF3 File Offset: 0x0002BEF3
		internal virtual bool IsExportControl
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0002DCF6 File Offset: 0x0002BEF6
		internal bool IsReportControl
		{
			get
			{
				return this is global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0002DD01 File Offset: 0x0002BF01
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x0002DD09 File Offset: 0x0002BF09
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

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0002DD12 File Offset: 0x0002BF12
		internal bool IsDraggingField
		{
			get
			{
				return null != this._fieldDragManager;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0002DD20 File Offset: 0x0002BF20
		internal bool IsFlatView
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.SupportedDataDisplayMode == global::Infragistics.Windows.DataPresenter.DataDisplayMode.FlattenedHierarchical;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0002DD42 File Offset: 0x0002BF42
		internal bool IsScrolling
		{
			get
			{
				return this._isScrollingTimer != null && this._isScrollingTimer.IsEnabled;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0002DD59 File Offset: 0x0002BF59
		internal virtual bool IsSynchronousControl
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0002DD5C File Offset: 0x0002BF5C
		internal global::System.Windows.Controls.ItemsPanelTemplate ItemsPanel
		{
			get
			{
				return (global::System.Windows.Controls.ItemsPanelTemplate)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.ItemsPanelProperty);
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0002DD6E File Offset: 0x0002BF6E
		internal global::System.Windows.Size LastMeasureSize
		{
			get
			{
				return this._lastMeasureSize;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0002DD76 File Offset: 0x0002BF76
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x0002DD88 File Offset: 0x0002BF88
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

		// Token: 0x06000B5E RID: 2910 RVA: 0x0002DD9B File Offset: 0x0002BF9B
		private static global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings GetPanelSettings(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings)d.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.PanelSettingsProperty);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0002DDAD File Offset: 0x0002BFAD
		private static void SetPanelSettings(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DataPresenter.DataPresenterBase.ListBoxPanelSettings value)
		{
			d.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.PanelSettingsProperty, value);
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0002DDBB File Offset: 0x0002BFBB
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0002DDC3 File Offset: 0x0002BFC3
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0002DDCC File Offset: 0x0002BFCC
		internal int RecordsInViewVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordsInViewVersionProperty);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0002DDDE File Offset: 0x0002BFDE
		internal int RenderVersion
		{
			get
			{
				return this._renderVersion;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0002DDE6 File Offset: 0x0002BFE6
		internal global::Infragistics.Windows.DataPresenter.RecordListControl RootRecordListControl
		{
			get
			{
				return this._rootRecordListControl;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x0002DDEE File Offset: 0x0002BFEE
		// (set) Token: 0x06000B66 RID: 2918 RVA: 0x0002DE00 File Offset: 0x0002C000
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

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0002DE13 File Offset: 0x0002C013
		// (set) Token: 0x06000B68 RID: 2920 RVA: 0x0002DE1B File Offset: 0x0002C01B
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

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002DE2E File Offset: 0x0002C02E
		internal void BumpScrollCountRecalcVersion()
		{
			this.ScrollCountRecalcVersion++;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0002DE40 File Offset: 0x0002C040
		private static void OnScrollCountRecalcVersionChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (global::Infragistics.Windows.DataPresenter.DataPresenterBase)dependencyObject;
			dataPresenterBase._cachedScrollCountRecalcVersion = (int)e.NewValue;
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x0002DE66 File Offset: 0x0002C066
		// (set) Token: 0x06000B6C RID: 2924 RVA: 0x0002DE78 File Offset: 0x0002C078
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

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000B6D RID: 2925 RVA: 0x0002DE8B File Offset: 0x0002C08B
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

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0002DEA7 File Offset: 0x0002C0A7
		internal bool ShouldRaiseCellsInViewChanged
		{
			get
			{
				return null != this._cellsInViewChangedEventHandler;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0002DEB5 File Offset: 0x0002C0B5
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x0002DEBD File Offset: 0x0002C0BD
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

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0002DEC8 File Offset: 0x0002C0C8
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

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0002DF08 File Offset: 0x0002C108
		private global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.HorizontalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002DF1C File Offset: 0x0002C11C
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

		// Token: 0x06000B74 RID: 2932 RVA: 0x0002DF5E File Offset: 0x0002C15E
		private void RaiseEventHelper(global::System.Windows.RoutedEventArgs args)
		{
			if (this.IsEventSuppressed(args.RoutedEvent))
			{
				return;
			}
			base.RaiseEvent(args);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0002DF78 File Offset: 0x0002C178
		private void SetPivotMember<T>(ref T member, T newValue) where T : global::Infragistics.Windows.Selection.ISelectableItem
		{
			if (!object.Equals(member, newValue))
			{
				T t = member;
				member = newValue;
				this._fixedScrollHelper.OnPivotItemChanged(t, newValue);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0002DFC2 File Offset: 0x0002C1C2
		private global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.VerticalScrollBarVisibilityProperty);
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0002DFD4 File Offset: 0x0002C1D4
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

		// Token: 0x06000B78 RID: 2936 RVA: 0x0002E068 File Offset: 0x0002C268
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

		// Token: 0x06000B79 RID: 2937 RVA: 0x0002E0F0 File Offset: 0x0002C2F0
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

		// Token: 0x06000B7A RID: 2938 RVA: 0x0002E120 File Offset: 0x0002C320
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

		// Token: 0x06000B7B RID: 2939 RVA: 0x0002E17F File Offset: 0x0002C37F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void CancelExport(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter)
		{
			this.ExportHelper.CancelExport(exporter);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0002E18D File Offset: 0x0002C38D
		public void ClearCustomizations(global::Infragistics.Windows.DataPresenter.CustomizationType customizations)
		{
			this.CustomizationsManager.ClearCustomizations(customizations);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0002E19B File Offset: 0x0002C39B
		public void ClearUndoHistory()
		{
			if (this._history != null)
			{
				this._history.Clear();
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0002E1B0 File Offset: 0x0002C3B0
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.CommandWrapper commandWrapper)
		{
			if (commandWrapper == null)
			{
				throw new global::System.ArgumentNullException("commandWrapper");
			}
			return this.ExecuteCommand(commandWrapper.Command, null);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0002E1CD File Offset: 0x0002C3CD
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(command, null, true);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0002E1D8 File Offset: 0x0002C3D8
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command, object parameter)
		{
			return this.ExecuteCommandImpl(command, parameter, true);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0002E1E3 File Offset: 0x0002C3E3
		private bool ExecuteCommandImpl(global::System.Windows.Input.RoutedCommand command, object commandParameter, bool raiseEvents)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command, commandParameter, null), raiseEvents);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0002E1F4 File Offset: 0x0002C3F4
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
			bool flag4 = false;
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
					flag4 = activeRecord.ExpandCollapse(routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ExpandRecord, true);
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
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.EndEditModeAndCommitRecord && !activeCell2.IsInEditMode)
					{
						this.CommitChangesToRecord(activeCell2.Record);
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
				global::Infragistics.Windows.DataPresenter.Record record = (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstDisplayed) ? viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.Record)) : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastDisplayed) ? viewPanel.GetLastDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.Record)) : ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall) ? viewPanel.GetFirstOverallRecord(typeof(global::Infragistics.Windows.DataPresenter.Record)) : viewPanel.GetLastOverallRecord(typeof(global::Infragistics.Windows.DataPresenter.Record))));
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem2 = ((global::Infragistics.Windows.Selection.ISelectionHost)this).GetSelectionStrategyForItem(record);
				if (selectionStrategyForItem2 != null)
				{
					selectionStrategyForItem2.SelectItemViaKeyboard(record, flag, flag2, false);
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordLastOverall)
					{
						if (this._invalidateGeneratedStylesPending)
						{
							this.OnInvalidateGeneratedStyles();
						}
						base.UpdateLayout();
						if (record.IsFixed)
						{
							global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = record.ParentCollection.ViewableRecords;
							if (viewableRecords != null && viewableRecords.Count > viewableRecords.CountOfFixedRecordsOnBottom + viewableRecords.CountOfFixedRecordsOnTop)
							{
								if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstOverall)
								{
									record = viewableRecords[viewableRecords.CountOfFixedRecordsOnTop];
								}
								else
								{
									record = viewableRecords[viewableRecords.Count - (viewableRecords.CountOfFixedRecordsOnBottom + 1)];
								}
							}
						}
						if (record != null)
						{
							viewPanel.EnsureRecordIsVisible(record);
						}
					}
					flag4 = true;
				}
				if (record != null && base.IsKeyboardFocusWithin)
				{
					record.FocusIfActive();
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
							goto IL_14EB;
						}
					}
					else if ((routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageAbove || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordPageLeft) && (currentState & global::Infragistics.Windows.DataPresenter.States.RecordFirstDisplayed) == (global::Infragistics.Windows.DataPresenter.States)0L)
					{
						flag4 = this.ExecuteCommandImpl(global::Infragistics.Windows.DataPresenter.DataPresenterCommands.RecordFirstDisplayed, null, false);
						goto IL_14EB;
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
							this.ExecuteCommandImpl(routedCommand, parameter, false);
						}
					}
					flag4 = (navigationTargetCell != null || !flag3);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstDisplayed || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastDisplayed || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstInRecord || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastInRecord)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = null;
				if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstDisplayed)
				{
					dataRecord3 = (viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord);
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastDisplayed)
				{
					dataRecord3 = (viewPanel.GetLastDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord);
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall)
				{
					dataRecord3 = this.FirstOverallDataRecord;
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastOverall)
				{
					dataRecord3 = this.LastOverallDataRecord;
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstInRecord || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellLastInRecord)
				{
					dataRecord3 = (this.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord);
				}
				if (dataRecord3 != null)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell;
					if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstDisplayed || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstOverall || routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CellFirstInRecord)
					{
						cell = dataRecord3.FirstDisplayedCell;
					}
					else
					{
						cell = dataRecord3.LastDisplayedCell;
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
								viewPanel.EnsureRecordIsVisible(dataRecord3);
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
						this.GetRecordPresentersInViewHelper(this, this.CurrentPanel, list, true, flag8, !flag8, true, typeof(global::Infragistics.Windows.DataPresenter.DataRecord), true);
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
								this.GetRecordPresentersInViewHelper(this, this.CurrentPanel, list3, true, flag8, !flag8, true, typeof(global::Infragistics.Windows.DataPresenter.DataRecord), true);
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
								goto IL_14EB;
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
				global::Infragistics.Windows.DataPresenter.Record record2 = parameter as global::Infragistics.Windows.DataPresenter.Record;
				if (record2 != null)
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
					if (record2.FixedLocation != fixedRecordLocation && record2.IsFixedLocationAllowed(fixedRecordLocation))
					{
						global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs recordFixedLocationChangingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangingEventArgs(record2, fixedRecordLocation);
						this.RaiseRecordFixedLocationChanging(recordFixedLocationChangingEventArgs);
						if (!recordFixedLocationChangingEventArgs.Cancel)
						{
							if (this.IsUndoEnabled)
							{
								global::Infragistics.Windows.DataPresenter.RecordFixedStateAction action2 = new global::Infragistics.Windows.DataPresenter.RecordFixedStateAction(new global::Infragistics.Windows.DataPresenter.Record[]
								{
									record2
								}, record2.FixedLocation);
								this.History.AddUndoActionInternal(action2);
							}
							record2.FixedLocation = fixedRecordLocation;
							flag4 = true;
							this.RaiseRecordFixedLocationChanged(new global::Infragistics.Windows.DataPresenter.Events.RecordFixedLocationChangedEventArgs(record2));
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
				global::Infragistics.Windows.DataPresenter.Record record3 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
				if (record3 != null)
				{
					flag4 = record3.ExpandCollapse(!record3.IsExpanded, true);
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
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = parameter as global::Infragistics.Windows.DataPresenter.FieldLayout;
					this.ShowFieldChooser(fieldLayout, true, true);
				}
				if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleCardCollapsedState)
				{
					global::Infragistics.Windows.DataPresenter.Record record4 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
					if (record4 != null)
					{
						flag4 = record4.ToggleContainingCardCollapsedState(true);
					}
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ToggleEmptyCardCellsCollapsedState)
				{
					global::Infragistics.Windows.DataPresenter.Record record5 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
					if (record5 != null)
					{
						flag4 = record5.ToggleContainingCardEmptyCellsCollapsedState(true);
					}
				}
				else if (routedCommand == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.CancelExport)
				{
					flag4 = this.ExportHelper.CancelExport(this);
				}
			}
			IL_14EB:
			if (raiseEvents && flag4)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(routedCommand, parameter));
			}
			return flag4;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0002F702 File Offset: 0x0002D902
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void Export(global::Infragistics.Windows.DataPresenter.IDataPresenterExporter exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			this.ExportHelper.Export(exporter, options);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0002F711 File Offset: 0x0002D911
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ExportAsync(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options, bool showExportStatus)
		{
			this.ExportHelper.ExportAsync(exporter, options, showExportStatus);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0002F721 File Offset: 0x0002D921
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ExportAsync(global::Infragistics.Windows.DataPresenter.IDataPresenterExporterAsync exporter, global::Infragistics.Windows.DataPresenter.IExportOptions options, bool showExportStatus, global::System.TimeSpan duration, global::System.TimeSpan interval)
		{
			this.ExportHelper.ExportAsync(exporter, options, showExportStatus, duration, interval);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0002F735 File Offset: 0x0002D935
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> GetCellsInView()
		{
			return global::Infragistics.Windows.DataPresenter.VisibleDataBlock.Create(this);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0002F740 File Offset: 0x0002D940
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

		// Token: 0x06000B88 RID: 2952 RVA: 0x0002F790 File Offset: 0x0002D990
		public global::Infragistics.Windows.DataPresenter.Record[] GetRecordsInView(bool recursive)
		{
			return this.GetRecordsInView(recursive, false);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0002F79C File Offset: 0x0002D99C
		internal global::Infragistics.Windows.DataPresenter.Record[] GetRecordsInView(bool recursive, bool ignoreAnimations)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresentersInView = this.GetRecordPresentersInView(recursive, ignoreAnimations);
			global::Infragistics.Windows.DataPresenter.Record[] array = new global::Infragistics.Windows.DataPresenter.Record[recordPresentersInView.Count];
			for (int i = 0; i < recordPresentersInView.Count; i++)
			{
				array[i] = recordPresentersInView[i].Record;
			}
			return array;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0002F7E0 File Offset: 0x0002D9E0
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> GetRecordPresentersInView(bool recursive, bool ignoreAnimations)
		{
			if (this._invalidateGeneratedStylesPending)
			{
				this.OnInvalidateGeneratedStyles();
			}
			base.UpdateLayout();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter>();
			global::System.Windows.Controls.Panel currentPanel = this.CurrentPanel;
			if (currentPanel != null)
			{
				this.GetRecordPresentersInViewHelper(currentPanel, currentPanel, list, recursive && this.CurrentViewInternal.IsNestedPanelsSupported, false, false, false, null, ignoreAnimations);
			}
			return list;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0002F834 File Offset: 0x0002DA34
		private void GetRecordPresentersInViewHelper(global::System.Windows.FrameworkElement parent, global::System.Windows.Controls.Panel topLevelPanel, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordPresenter> recordPresenters, bool recursive, bool onlyFullyInViewInXDimension, bool onlyFullyInViewInYDimension, bool excludeFixedRootRecords, global::System.Type restrictToRecordType, bool ignoreAnimations)
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
						if (excludeFixedRootRecords && flag2 && recordPresenter.Record.IsFixed)
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
							this.GetRecordPresentersInViewHelper(recordPresenter, topLevelPanel, recordPresenters, recursive, onlyFullyInViewInXDimension, onlyFullyInViewInYDimension, false, restrictToRecordType, ignoreAnimations);
						}
					}
				}
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0002FD28 File Offset: 0x0002DF28
		internal bool HasRegisteredFieldChoosers()
		{
			return this._registeredFieldChoosers != null && global::Infragistics.Windows.DataPresenter.GridUtilities.GetCountNonOptimized(this._registeredFieldChoosers) > 0;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0002FD42 File Offset: 0x0002DF42
		public void LoadCustomizations(global::System.IO.Stream stream)
		{
			this.CustomizationsManager.LoadCustomizations(stream);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0002FD50 File Offset: 0x0002DF50
		public void LoadCustomizations(string Customizations)
		{
			this.CustomizationsManager.LoadCustomizations(Customizations);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0002FD60 File Offset: 0x0002DF60
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

		// Token: 0x06000B90 RID: 2960 RVA: 0x0002FD95 File Offset: 0x0002DF95
		public void SaveCustomizations(global::System.IO.Stream stream)
		{
			this.CustomizationsManager.SaveCustomizations(stream);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0002FDA3 File Offset: 0x0002DFA3
		public string SaveCustomizations()
		{
			return this.CustomizationsManager.SaveCustomizations();
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0002FDB0 File Offset: 0x0002DFB0
		public void ShowFieldChooser()
		{
			this.ShowFieldChooserHelper(null, true, true, null);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0002FDBC File Offset: 0x0002DFBC
		public void ShowFieldChooser(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool allowFieldLayoutSelection)
		{
			this.ShowFieldChooserHelper(fieldLayout, allowFieldLayoutSelection, true, null);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0002FDC8 File Offset: 0x0002DFC8
		public void ShowFieldChooser(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool allowFieldLayoutSelection, bool retainFieldChooser)
		{
			this.ShowFieldChooserHelper(fieldLayout, allowFieldLayoutSelection, retainFieldChooser, null);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0002FDD4 File Offset: 0x0002DFD4
		public void ShowFieldChooser(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool allowFieldLayoutSelection, bool retainFieldChooser, string windowCaption)
		{
			this.ShowFieldChooserHelper(fieldLayout, allowFieldLayoutSelection, retainFieldChooser, windowCaption);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
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
				toolWindow.Width = 200.0;
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

		// Token: 0x06000B97 RID: 2967 RVA: 0x0002FF08 File Offset: 0x0002E108
		internal void UnregisterFieldChooser(global::Infragistics.Windows.DataPresenter.FieldChooser fieldChooser)
		{
			global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser> registeredFieldChoosers = this._registeredFieldChoosers;
			if (registeredFieldChoosers != null)
			{
				registeredFieldChoosers.Remove(fieldChooser);
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0002FF27 File Offset: 0x0002E127
		internal void AddStatusControl(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl)
		{
			if (ctrl != null && this._dataAreaGrid != null && global::System.Windows.Media.VisualTreeHelper.GetParent(ctrl) == null)
			{
				this._dataAreaGrid.Children.Add(ctrl);
			}
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0002FF50 File Offset: 0x0002E150
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

		// Token: 0x06000B9A RID: 2970 RVA: 0x0002FFD4 File Offset: 0x0002E1D4
		internal void BumpGroupByAreaStyleVersion()
		{
			global::Infragistics.Windows.DataPresenter.GroupByAreaBase groupByAreaResolved = this.GetGroupByAreaResolved(false);
			if (groupByAreaResolved != null)
			{
				groupByAreaResolved.StyleVersionNumber++;
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0002FFFA File Offset: 0x0002E1FA
		internal void BumpOverallSortVersion()
		{
			this.OverallSortVersion++;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0003000C File Offset: 0x0002E20C
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

		// Token: 0x06000B9D RID: 2973 RVA: 0x00030047 File Offset: 0x0002E247
		internal void BumpScrollableRecordCountVersion()
		{
			this._bumpScrollCountOperation = null;
			this.ScrollableRecordCountVersion++;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00030060 File Offset: 0x0002E260
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

		// Token: 0x06000B9F RID: 2975 RVA: 0x000300C4 File Offset: 0x0002E2C4
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

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0003023C File Offset: 0x0002E43C
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

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000302A2 File Offset: 0x0002E4A2
		internal bool ClearActiveCell()
		{
			return this.ClearActiveCell(false, false);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000302AC File Offset: 0x0002E4AC
		internal bool ClearActiveCell(bool shutdown)
		{
			return this.ClearActiveCell(shutdown, false);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000302B8 File Offset: 0x0002E4B8
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

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0003037C File Offset: 0x0002E57C
		internal void ClearActiveRecord()
		{
			this.ClearActiveRecord(false);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x00030388 File Offset: 0x0002E588
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

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000303C4 File Offset: 0x0002E5C4
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

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000304C0 File Offset: 0x0002E6C0
		internal void ClearPendingActiveRecordPresenter()
		{
			if (this._pendingActiveRecordPresenter != null)
			{
				this._pendingActiveRecordPresenter.ClearContainerForItem(this._pendingActiveRecordPresenter.Record);
				this._pendingActiveRecordPresenter = null;
			}
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000304E7 File Offset: 0x0002E6E7
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

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00030517 File Offset: 0x0002E717
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

		// Token: 0x06000BAA RID: 2986 RVA: 0x0003054B File Offset: 0x0002E74B
		internal void ClearItemsHost()
		{
			if (this._currentRecordListControl != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.SetPanelSettings(this._currentRecordListControl, null);
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00030564 File Offset: 0x0002E764
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

		// Token: 0x06000BAC RID: 2988 RVA: 0x000305D0 File Offset: 0x0002E7D0
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

		// Token: 0x06000BAD RID: 2989 RVA: 0x0003062C File Offset: 0x0002E82C
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

		// Token: 0x06000BAE RID: 2990 RVA: 0x00030688 File Offset: 0x0002E888
		internal void ClearStyleCache()
		{
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x0003068C File Offset: 0x0002E88C
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

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000306C8 File Offset: 0x0002E8C8
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

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000309E0 File Offset: 0x0002EBE0
		internal bool DeleteSelectedRecords(bool displayPromptMessage)
		{
			return this.SelectedItems.Records.Count != 0 && this.DeleteRecords(this.SelectedItems.Records.ToArray(), displayPromptMessage, true);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00030A10 File Offset: 0x0002EC10
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

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00030A64 File Offset: 0x0002EC64
		internal bool EndEditMode(bool acceptChanges, bool force)
		{
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this.ActiveCell;
			return activeCell == null || !activeCell.IsInEditMode || activeCell.EndEditMode(acceptChanges, force);
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00030A90 File Offset: 0x0002EC90
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

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00030ACF File Offset: 0x0002ECCF
		internal object GetDefaultResource(global::System.Type key, bool walkResourceChain)
		{
			if (this._themeRegistered_DP_ResourceSet != null)
			{
				return this.FindResourceForStylingPoint(key, walkResourceChain);
			}
			return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetGenericResource(key);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00030AE8 File Offset: 0x0002ECE8
		internal global::Infragistics.Windows.DataPresenter.FixedFieldInfo GetFixedFieldInfo(global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = rp.FieldLayout;
			if (fieldLayout == null || !fieldLayout.IsFixedFieldsEnabled)
			{
				return null;
			}
			return this.CurrentViewInternal.GetFixedFieldInfo(rp);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00030B18 File Offset: 0x0002ED18
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

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00030B88 File Offset: 0x0002ED88
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

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00030BE4 File Offset: 0x0002EDE4
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

		// Token: 0x06000BBA RID: 3002 RVA: 0x00030C61 File Offset: 0x0002EE61
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(name, null);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00030C6A File Offset: 0x0002EE6A
		internal static string GetString(global::System.Globalization.CultureInfo culture, string name)
		{
			return global::SR.GetString(culture, name);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00030C73 File Offset: 0x0002EE73
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00030C7C File Offset: 0x0002EE7C
		internal void InternalAddLogicalChild(object child)
		{
			if (!this._logicalChildren.Contains(child))
			{
				base.AddLogicalChild(child);
				this._logicalChildren.Add(child);
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00030CA0 File Offset: 0x0002EEA0
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

		// Token: 0x06000BBF RID: 3007 RVA: 0x00030DE1 File Offset: 0x0002EFE1
		internal void InternalRemoveLogicalChild(object child)
		{
			base.RemoveLogicalChild(child);
			if (this._logicalChildren.Contains(child))
			{
				this._logicalChildren.Remove(child);
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00030E08 File Offset: 0x0002F008
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

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00030EB8 File Offset: 0x0002F0B8
		internal bool InternalSelectRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected = this.CalculateNewSelectionRange(item, clearExistingSelection, select);
			bool flag = this.SelectNewSelection(item.GetType(), selected);
			return !flag;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00030EE4 File Offset: 0x0002F0E4
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

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00030FE8 File Offset: 0x0002F1E8
		internal void InvalidateGeneratedStyles(bool bumpVersion, bool clearGroupBy)
		{
			this.InvalidateGeneratedStyles(bumpVersion, clearGroupBy, true);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00030FF4 File Offset: 0x0002F1F4
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
			if (this._invalidateGeneratedStylesPending)
			{
				regenerateTemplates = true;
			}
			this._invalidateGeneratedStylesPending = false;
			this.FieldLayouts.InvalidateGeneratedStyles(bumpVersion, regenerateTemplates);
			global::System.Windows.Controls.Panel currentPanel = this.CurrentPanel;
			if (currentPanel != null)
			{
				currentPanel.InvalidateMeasure();
				this.BumpRecordsInViewVersion();
			}
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00031058 File Offset: 0x0002F258
		internal void InvalidateGeneratedStylesAsync()
		{
			if (!this._haveAnyTemplatesBeenGenerated)
			{
				return;
			}
			if (this._invalidateGeneratedStylesPending)
			{
				return;
			}
			if (this.IsSynchronousControl)
			{
				this.InvalidateGeneratedStyles(true, false);
				return;
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnInvalidateGeneratedStyles));
			this._invalidateGeneratedStylesPending = true;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000310AC File Offset: 0x0002F2AC
		internal void InvalidateItemsHost()
		{
			global::System.Windows.Controls.Panel currentPanel = this.CurrentPanel;
			if (currentPanel != null)
			{
				currentPanel.InvalidateMeasure();
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000310C9 File Offset: 0x0002F2C9
		internal bool IsEventSuppressed(global::System.Windows.RoutedEvent routedEvent)
		{
			return this._suppressedEvents != null && this._suppressedEvents.IsEventSuppressed(routedEvent);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000310E1 File Offset: 0x0002F2E1
		internal bool IsInitializeRecordSuspendedFor(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this._initializeRecordSuspendedFor == record || (this._initializeRecordSuspendedFor_List != null && this._initializeRecordSuspendedFor_List.Contains(record));
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00031104 File Offset: 0x0002F304
		internal bool IsItemSelectableWithCurrentSelection(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::Infragistics.Windows.DataPresenter.Record record = item as global::Infragistics.Windows.DataPresenter.Record;
			if (record != null)
			{
				return this.SelectedItems.Records.Count < 1 || (this.SelectedItems.Records[0].FieldLayout == record.FieldLayout && record.NestingDepth == this.SelectedItems.Records[0].NestingDepth);
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = item as global::Infragistics.Windows.DataPresenter.Cell;
			if (cell != null)
			{
				return this.SelectedItems.Cells.Count < 1 || (this.SelectedItems.Cells[0].Field.Owner == cell.Field.Owner && global::Infragistics.Windows.DataPresenter.GridUtilities.IsAddRecordTemplate(this.SelectedItems.Cells[0].Record) == global::Infragistics.Windows.DataPresenter.GridUtilities.IsAddRecordTemplate(cell.Record) && this.SelectedItems.Cells[0].Record.NestingDepth == cell.Record.NestingDepth);
			}
			global::Infragistics.Windows.DataPresenter.Field field = item as global::Infragistics.Windows.DataPresenter.Field;
			return field == null || this.SelectedItems.Fields.Count < 1 || this.SelectedItems.Fields[0].Owner == field.Owner;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x00031250 File Offset: 0x0002F450
		internal bool IsFixedFieldsSupportedResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.IsFixedFieldsSupported && currentViewInternal.HasLogicalOrientation;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x00031278 File Offset: 0x0002F478
		internal bool IsFixedRecordsSupportedResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.IsFixedRecordsSupported;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00031298 File Offset: 0x0002F498
		internal bool IsFilterRecordSupportedResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.IsFilterRecordSupported;
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000312B8 File Offset: 0x0002F4B8
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

		// Token: 0x06000BCE RID: 3022 RVA: 0x0003132C File Offset: 0x0002F52C
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

		// Token: 0x06000BCF RID: 3023 RVA: 0x000313F0 File Offset: 0x0002F5F0
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

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0003147A File Offset: 0x0002F67A
		internal void OnAfterApplyCustomizations()
		{
			this.InvalidateGeneratedStylesAsync();
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00031482 File Offset: 0x0002F682
		internal void OnBeforeApplyCustomizations()
		{
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00031484 File Offset: 0x0002F684
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

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000314C3 File Offset: 0x0002F6C3
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

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000314FA File Offset: 0x0002F6FA
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

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00031531 File Offset: 0x0002F731
		internal void OnFieldLayoutTemplateGeneration()
		{
			this._haveAnyTemplatesBeenGenerated = true;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0003153A File Offset: 0x0002F73A
		internal void OnFormatSettingsInvalidated()
		{
			if (this.DefaultFieldLayout == null)
			{
				return;
			}
			this.InvalidateFormatSettings();
			this.ClearGroupBy();
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00031554 File Offset: 0x0002F754
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
						cellValuePresenter.FocusIfAppropriate();
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

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00031604 File Offset: 0x0002F804
		internal bool OnRecordExpandStateChanged(global::Infragistics.Windows.DataPresenter.Record record, bool isExpanded)
		{
			return this.OnRecordExpandStateChanged(record, isExpanded, false);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00031610 File Offset: 0x0002F810
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

		// Token: 0x06000BDA RID: 3034 RVA: 0x00031658 File Offset: 0x0002F858
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

		// Token: 0x06000BDB RID: 3035 RVA: 0x0003170C File Offset: 0x0002F90C
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

		// Token: 0x06000BDC RID: 3036 RVA: 0x000317A8 File Offset: 0x0002F9A8
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

		// Token: 0x06000BDD RID: 3037 RVA: 0x00031840 File Offset: 0x0002FA40
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

		// Token: 0x06000BDE RID: 3038 RVA: 0x0003187D File Offset: 0x0002FA7D
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

		// Token: 0x06000BDF RID: 3039 RVA: 0x000318BD File Offset: 0x0002FABD
		internal void RemoveStatusControl(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl ctrl)
		{
			if (ctrl != null && this._dataAreaGrid != null && global::System.Windows.Media.VisualTreeHelper.GetParent(ctrl) == this._dataAreaGrid)
			{
				this._dataAreaGrid.Children.Remove(ctrl);
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000318E9 File Offset: 0x0002FAE9
		internal void ResetAllRecordsAutoSizeMaxDepth()
		{
			this._allRecordsAutoSizeMaxDepth = -2;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000318F4 File Offset: 0x0002FAF4
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

		// Token: 0x06000BE2 RID: 3042 RVA: 0x00031958 File Offset: 0x0002FB58
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

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00031994 File Offset: 0x0002FB94
		internal void ResumeEndEditOnScroll()
		{
			this._endEditOnScrollSuspendCount--;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000319A4 File Offset: 0x0002FBA4
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

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00031A30 File Offset: 0x0002FC30
		internal bool SelectNewSelection(global::System.Type type, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected)
		{
			if (this.ActiveCell != null && !this.ActiveCell.EndEditMode())
			{
				return false;
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

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00031A84 File Offset: 0x0002FC84
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

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00031BFC File Offset: 0x0002FDFC
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

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00031E34 File Offset: 0x00030034
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

		// Token: 0x06000BE9 RID: 3049 RVA: 0x00031E90 File Offset: 0x00030090
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

		// Token: 0x06000BEA RID: 3050 RVA: 0x00031EE8 File Offset: 0x000300E8
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

		// Token: 0x06000BEB RID: 3051 RVA: 0x00031F6A File Offset: 0x0003016A
		internal void SuspendEndEditOnScroll()
		{
			this._endEditOnScrollSuspendCount++;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x00031F7C File Offset: 0x0003017C
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

		// Token: 0x06000BED RID: 3053 RVA: 0x00031FE4 File Offset: 0x000301E4
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

		// Token: 0x06000BEE RID: 3054 RVA: 0x00032074 File Offset: 0x00030274
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

		// Token: 0x06000BEF RID: 3055 RVA: 0x000320C8 File Offset: 0x000302C8
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

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0003212C File Offset: 0x0003032C
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

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000321A0 File Offset: 0x000303A0
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

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000322A0 File Offset: 0x000304A0
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

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00032304 File Offset: 0x00030504
		internal void VerifyRecordManagerDataSource()
		{
			if (!base.IsInitialized && (!this.IsExportControl || this.IsReportControl))
			{
				return;
			}
			if (this.DataSource == null && this._dataItems != null && this._dataItems.Count > 0)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceInternalPropertyKey, this._dataItems);
			}
			this.RecordManager.DataSource = (this.DataSourceInternal as global::System.Collections.IEnumerable);
			if (this.RecordManager.DataSource != null)
			{
				this._isRecordManagerDataSourceInitialized = true;
			}
			global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(this, this, "DataSource", null);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00032390 File Offset: 0x00030590
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

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000323E0 File Offset: 0x000305E0
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

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00032434 File Offset: 0x00030634
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

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00032484 File Offset: 0x00030684
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

		// Token: 0x06000BF8 RID: 3064 RVA: 0x000324D4 File Offset: 0x000306D4
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

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00032534 File Offset: 0x00030734
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

		// Token: 0x06000BFA RID: 3066 RVA: 0x0003255C File Offset: 0x0003075C
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
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator rangeSelectionEvaluator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator(this._pivotCell, cell, this._snaking);
			global::Infragistics.Windows.DataPresenter.SelectedRecordCollection recordsForSelection = this.GetRecordsForSelection(select, rangeSelectionEvaluator);
			global::Infragistics.Windows.DataPresenter.SelectedFieldCollection fieldsForSelection = this.GetFieldsForSelection(select, rangeSelectionEvaluator);
			for (int i = 0; i < recordsForSelection.Count; i++)
			{
				for (int j = 0; j < fieldsForSelection.Count; j++)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = recordsForSelection[i] as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null)
					{
						global::Infragistics.Windows.DataPresenter.Field field = fieldsForSelection[j];
						if (rangeSelectionEvaluator.IsCellInRange(dataRecord, field, false, false))
						{
							global::Infragistics.Windows.DataPresenter.Cell cell2 = dataRecord.Cells[field];
							if (cell2 != null && ((global::Infragistics.Windows.Selection.ISelectableItem)cell2).IsSelectable)
							{
								newSelection.Cells.InternalAdd(cell2);
							}
						}
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

		// Token: 0x06000BFB RID: 3067 RVA: 0x000326C0 File Offset: 0x000308C0
		private void CalculateSelectionRange(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection, bool clearExistingSelection, bool select)
		{
			if (this._pivotField == null)
			{
				((global::Infragistics.Windows.Selection.ISelectionHost)this).SetPivotItem(field, false);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator rangeSelectionEvaluator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator(this._pivotField, field, this._snaking);
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

		// Token: 0x06000BFC RID: 3068 RVA: 0x00032790 File Offset: 0x00030990
		private void CalculateSelectionRange(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection, bool clearExistingSelection, bool select)
		{
			if (this._pivotRecord == null)
			{
				((global::Infragistics.Windows.Selection.ISelectionHost)this).SetPivotItem(record, false);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator rangeSelectionEvaluator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator(this._pivotRecord, record, this._snaking);
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

		// Token: 0x06000BFD RID: 3069 RVA: 0x00032848 File Offset: 0x00030A48
		private double CalculateScrollOffsetFactorInRecords(global::Infragistics.Windows.Selection.ScrollSpeed speed, double viewportExtent)
		{
			if (speed == global::Infragistics.Windows.Selection.ScrollSpeed.Fast)
			{
				return 2.0;
			}
			return 1.0;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x00032870 File Offset: 0x00030A70
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

		// Token: 0x06000BFF RID: 3071 RVA: 0x00032944 File Offset: 0x00030B44
		private bool CanAutoSizeField(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Field field = commandInfo.Parameter as global::Infragistics.Windows.DataPresenter.Field;
			return field != null && field.AutoSizeOptionsResolved != global::Infragistics.Windows.DataPresenter.FieldAutoSizeOptions.None;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00032970 File Offset: 0x00030B70
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

		// Token: 0x06000C01 RID: 3073 RVA: 0x000329CC File Offset: 0x00030BCC
		private static bool CanToggleIsExpanded(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Record record = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
			return null != record;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000329E8 File Offset: 0x00030BE8
		private static bool CanToggleCardCollapsedState(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Record record = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
			return null != record;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00032A04 File Offset: 0x00030C04
		private static bool CanToggleEmptyCardCellsCollapsedState(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.DataPresenter.Record record = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetRecord(commandInfo);
			return null != record;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00032A20 File Offset: 0x00030C20
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

		// Token: 0x06000C05 RID: 3077 RVA: 0x00032A84 File Offset: 0x00030C84
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

		// Token: 0x06000C06 RID: 3078 RVA: 0x00032B3C File Offset: 0x00030D3C
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

		// Token: 0x06000C07 RID: 3079 RVA: 0x00032BA3 File Offset: 0x00030DA3
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> GetAllResizableFieldItems(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel panel, global::Infragistics.Windows.DataPresenter.Field field, bool isLabel, bool resizeInXAxis, bool autoSize)
		{
			return this.GetAllResizableFieldItems(panel.GetResizeLayoutManager(), field, isLabel, resizeInXAxis, autoSize);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00032BB8 File Offset: 0x00030DB8
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

		// Token: 0x06000C09 RID: 3081 RVA: 0x00032DB0 File Offset: 0x00030FB0
		private global::Infragistics.Windows.Selection.ISelectableElement GetCompatibleSelectableElement(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.DependencyObject element)
		{
			if (element is global::Infragistics.Windows.Selection.ISelectableElement)
			{
				global::Infragistics.Windows.Selection.ISelectableItem selectableItem = (element as global::Infragistics.Windows.Selection.ISelectableElement).SelectableItem;
				if (!((global::Infragistics.Windows.Selection.ISelectionHost)this).IsItemSelectableWithCurrentSelection(selectableItem))
				{
					if (item is global::Infragistics.Windows.DataPresenter.Record)
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

		// Token: 0x06000C0A RID: 3082 RVA: 0x00032E44 File Offset: 0x00031044
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

		// Token: 0x06000C0B RID: 3083 RVA: 0x00032ECD File Offset: 0x000310CD
		private global::System.Windows.Style GetDefaultStyle(global::System.Type type)
		{
			return null;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00032ED0 File Offset: 0x000310D0
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

		// Token: 0x06000C0D RID: 3085 RVA: 0x00032F7C File Offset: 0x0003117C
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

		// Token: 0x06000C0E RID: 3086 RVA: 0x00032FCC File Offset: 0x000311CC
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

		// Token: 0x06000C0F RID: 3087 RVA: 0x000330FC File Offset: 0x000312FC
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

		// Token: 0x06000C10 RID: 3088 RVA: 0x00033114 File Offset: 0x00031314
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
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = currentCell.Record.FieldLayout.StyleGenerator;
			global::Infragistics.Windows.DataPresenter.Cell navigationTargetCell = styleGenerator.GridFieldMap.GetNavigationTargetCell(currentCell, navigationDirection, this.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel, selectionHost, shiftKeyDown, ctlKeyDown, siblingNavigationStyle);
			if (navigationTargetCell != null && selectionStrategyForItem.CanItemBeNavigatedTo(navigationTargetCell, shiftKeyDown, ctlKeyDown))
			{
				return navigationTargetCell;
			}
			return null;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0003319C File Offset: 0x0003139C
		private global::Infragistics.Windows.DataPresenter.Cell GetNearestCompatibleCell(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point pt)
		{
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

		// Token: 0x06000C12 RID: 3090 RVA: 0x0003320C File Offset: 0x0003140C
		private global::Infragistics.Windows.DataPresenter.Field GetNearestCompatibleField(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point pt, global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
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

		// Token: 0x06000C13 RID: 3091 RVA: 0x00033260 File Offset: 0x00031460
		private bool GetNearestCompatibleField(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point pt, global::Infragistics.Windows.DataPresenter.Field pivotField, global::Infragistics.Windows.DataPresenter.Record pivotRecord, bool cells, global::Infragistics.Windows.DataPresenter.RecordPresenter rp, out global::Infragistics.Windows.DataPresenter.Record nearestRecord, out global::Infragistics.Windows.DataPresenter.Field nearestField)
		{
			nearestField = null;
			nearestRecord = null;
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

		// Token: 0x06000C14 RID: 3092 RVA: 0x0003337C File Offset: 0x0003157C
		private global::Infragistics.Windows.DataPresenter.RecordPresenter GetNearestCompatibleRecordPresenter(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Point pt)
		{
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
				global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this).GetRecordAtOverallScrollPosition(((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this).OverallScrollPosition);
				if (recordAtOverallScrollPosition == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.Record recordInParentChainContainedInCollection = recordAtOverallScrollPosition.GetRecordInParentChainContainedInCollection(record.ParentCollection);
				if (recordInParentChainContainedInCollection == null)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
					int scrollCount = viewableRecords.ScrollCount;
					int num = recordAtOverallScrollPosition.OverallScrollPosition + 1;
					while (recordInParentChainContainedInCollection == null && num < scrollCount)
					{
						global::Infragistics.Windows.DataPresenter.Record recordAtScrollPosition = viewableRecords.GetRecordAtScrollPosition(num);
						if (recordAtScrollPosition != null)
						{
							if (recordAtScrollPosition.AssociatedRecordPresenter == null)
							{
								break;
							}
							recordInParentChainContainedInCollection = recordAtScrollPosition.GetRecordInParentChainContainedInCollection(record.ParentCollection);
						}
						num++;
					}
				}
				if (recordInParentChainContainedInCollection == null)
				{
					return null;
				}
				recordPresenter = recordInParentChainContainedInCollection.AssociatedRecordPresenter;
				if (recordPresenter == null)
				{
					return null;
				}
				double num2 = double.NaN;
				global::Infragistics.Windows.DataPresenter.RecordPresenter result = null;
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.CurrentViewInternal;
				if (currentViewInternal.HasLogicalOrientation)
				{
					result = recordPresenter;
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords2 = this.ViewableRecords;
					int scrollCount2 = viewableRecords2.ScrollCount;
					int num3 = recordInParentChainContainedInCollection.OverallScrollPosition + 1;
					while (recordPresenter != null && num3 <= scrollCount2)
					{
						global::System.Windows.Point point = recordPresenter.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), this);
						global::System.Windows.Point point2 = recordPresenter.TranslatePoint(new global::System.Windows.Point(recordPresenter.ActualWidth, recordPresenter.ActualHeight), this);
						if (recordPresenter.FieldLayout == fieldLayout)
						{
							double num4;
							if (currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
							{
								if (pt.Y >= point.Y && pt.Y <= point2.Y)
								{
									return recordPresenter;
								}
								if (pt.Y < point.Y)
								{
									num4 = point.Y - pt.Y;
								}
								else
								{
									num4 = pt.Y - point2.Y;
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
									num4 = point.X - pt.X;
								}
								else
								{
									num4 = pt.X - point2.X;
								}
							}
							if (double.IsNaN(num2) || num4 < num2)
							{
								num2 = num4;
								result = recordPresenter;
							}
						}
						if (num3 == scrollCount2)
						{
							break;
						}
						global::Infragistics.Windows.DataPresenter.Record recordAtScrollPosition2 = viewableRecords2.GetRecordAtScrollPosition(num3);
						if (recordAtScrollPosition2 == null || recordAtScrollPosition2.AssociatedRecordPresenter == null)
						{
							break;
						}
						recordInParentChainContainedInCollection = recordAtScrollPosition2.GetRecordInParentChainContainedInCollection(record.ParentCollection);
						if (recordInParentChainContainedInCollection != null)
						{
							recordPresenter = recordInParentChainContainedInCollection.AssociatedRecordPresenter;
						}
						else
						{
							recordPresenter = null;
						}
						num3++;
					}
				}
				return result;
			}
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00033670 File Offset: 0x00031870
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

		// Token: 0x06000C16 RID: 3094 RVA: 0x000336D0 File Offset: 0x000318D0
		private global::Infragistics.Windows.DataPresenter.SelectedRecordCollection GetRecordsForSelection(bool select, global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator evaluator)
		{
			global::Infragistics.Windows.DataPresenter.SelectedRecordCollection selectedRecordCollection = new global::Infragistics.Windows.DataPresenter.SelectedRecordCollection(this);
			global::Infragistics.Windows.DataPresenter.Record pivotRecord = evaluator.PivotRecord;
			global::Infragistics.Windows.DataPresenter.Record endOfRangeRecord = evaluator.EndOfRangeRecord;
			long overallSelectionPosition = endOfRangeRecord.OverallSelectionPosition;
			long overallSelectionPosition2 = pivotRecord.OverallSelectionPosition;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = pivotRecord.FieldLayout;
			int nestingDepth = pivotRecord.NestingDepth;
			if (overallSelectionPosition != overallSelectionPosition2 && select)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator recordSelectionEnumerator = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.RecordSelectionEnumerator(endOfRangeRecord, pivotRecord, overallSelectionPosition > overallSelectionPosition2);
				while (recordSelectionEnumerator.MoveNext())
				{
					object obj = recordSelectionEnumerator.Current;
					global::Infragistics.Windows.DataPresenter.Record record = obj as global::Infragistics.Windows.DataPresenter.Record;
					if (record != null && record.FieldLayout == fieldLayout && record.NestingDepth == nestingDepth && ((global::Infragistics.Windows.Selection.ISelectableItem)record).IsSelectable && record.VisibilityResolved == global::System.Windows.Visibility.Visible)
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

		// Token: 0x06000C17 RID: 3095 RVA: 0x00033791 File Offset: 0x00031991
		private static double GetScrollValueHelper(double actualValue, ref double? cachedValue)
		{
			if (cachedValue != null)
			{
				return cachedValue.Value;
			}
			return actualValue;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000337A3 File Offset: 0x000319A3
		private void InitializeRecordManagerDataSource()
		{
			if (this._contentSiteGrid == null && !this._isRecordManagerDataSourceInitialized)
			{
				return;
			}
			this.VerifyRecordManagerDataSource();
			this.InitializeItemsPanel();
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000337C4 File Offset: 0x000319C4
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

		// Token: 0x06000C1A RID: 3098 RVA: 0x00033880 File Offset: 0x00031A80
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

		// Token: 0x06000C1B RID: 3099 RVA: 0x000338C4 File Offset: 0x00031AC4
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

		// Token: 0x06000C1C RID: 3100 RVA: 0x00033915 File Offset: 0x00031B15
		internal void OnChildRecordsDisplayOrderChanged()
		{
			this.BumpScrollCountRecalcVersion();
			this.UpdateScrollBarVisibility();
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00033924 File Offset: 0x00031B24
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
				this.InitializeSpacingOnResizeController();
				break;
			case global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateRender:
				base.InvalidateVisual();
				this.InitializeSpacingOnResizeController();
				break;
			}
			this.UpdateScrollBarVisibility();
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0003398C File Offset: 0x00031B8C
		private void OnInvalidateGeneratedStyles()
		{
			if (this._invalidateGeneratedStylesPending)
			{
				this.InvalidateGeneratedStyles(true, false);
				this._invalidateGeneratedStylesPending = false;
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000339A8 File Offset: 0x00031BA8
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

		// Token: 0x06000C20 RID: 3104 RVA: 0x00033A6C File Offset: 0x00031C6C
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

		// Token: 0x06000C21 RID: 3105 RVA: 0x00033ADA File Offset: 0x00031CDA
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			base.Unloaded += this.OnUnloaded;
			this.RefreshFieldLayout();
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00033B06 File Offset: 0x00031D06
		private object OnPerformFieldAutoSize(object parameter)
		{
			this.ProcessPendingAutoSizeOperations();
			return null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00033B10 File Offset: 0x00031D10
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
				this._recordManager.VerifySort();
				return;
			}
			this._recordManager.VerifySort();
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00033B9C File Offset: 0x00031D9C
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

		// Token: 0x06000C25 RID: 3109 RVA: 0x00033CD4 File Offset: 0x00031ED4
		private static void OnScrollViewerScrollChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = sender as global::Infragistics.Windows.DataPresenter.DataPresenterBase;
			if (dataPresenterBase != null)
			{
				dataPresenterBase.ScrollVersion++;
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00033CF9 File Offset: 0x00031EF9
		private void OnIsScrollingTimerTick(object sender, global::System.EventArgs e)
		{
			this.ProcessIsScrollingTimerTick();
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00033D01 File Offset: 0x00031F01
		private void ProcessIsScrollingTimerTick()
		{
			this._isScrollingTimer.Stop();
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataPresenterBase.IsScrollingPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00033D20 File Offset: 0x00031F20
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

		// Token: 0x06000C29 RID: 3113 RVA: 0x00033DD4 File Offset: 0x00031FD4
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

		// Token: 0x06000C2A RID: 3114 RVA: 0x00033E17 File Offset: 0x00032017
		private void RaiseCellsInViewChangedAsyncHelperHandler()
		{
			this._pendingRaiseCellsInViewChangedAsyncHelperHandler = false;
			if (this.ShouldRaiseCellsInViewChanged)
			{
				global::Infragistics.Windows.DataPresenter.VisibleDataBlock.RaiseCellsInViewChanged(this);
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00033E30 File Offset: 0x00032030
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

		// Token: 0x06000C2C RID: 3116 RVA: 0x00033E8C File Offset: 0x0003208C
		private void RefreshFieldLayout()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this.DefaultFieldLayout;
			if (defaultFieldLayout != null)
			{
				this.FieldLayouts.BumpSortVersions();
				this.InvalidateGeneratedStylesAsync();
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00033EB4 File Offset: 0x000320B4
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

		// Token: 0x06000C2E RID: 3118 RVA: 0x00033F10 File Offset: 0x00032110
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

		// Token: 0x06000C2F RID: 3119 RVA: 0x00033F70 File Offset: 0x00032170
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
				record = viewPanel.GetFirstDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.Record));
			}
			else
			{
				record = viewPanel.GetLastDisplayedRecord(typeof(global::Infragistics.Windows.DataPresenter.Record));
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

		// Token: 0x06000C30 RID: 3120 RVA: 0x00033FD0 File Offset: 0x000321D0
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

		// Token: 0x06000C31 RID: 3121 RVA: 0x00034038 File Offset: 0x00032238
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

		// Token: 0x06000C32 RID: 3122 RVA: 0x000341BC File Offset: 0x000323BC
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

		// Token: 0x06000C33 RID: 3123 RVA: 0x00034228 File Offset: 0x00032428
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

		// Token: 0x06000C34 RID: 3124 RVA: 0x00034270 File Offset: 0x00032470
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

		// Token: 0x06000C35 RID: 3125 RVA: 0x00034548 File Offset: 0x00032748
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

		// Token: 0x06000C36 RID: 3126 RVA: 0x00034590 File Offset: 0x00032790
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

		// Token: 0x06000C37 RID: 3127 RVA: 0x000347EC File Offset: 0x000329EC
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

		// Token: 0x06000C38 RID: 3128 RVA: 0x000349C4 File Offset: 0x00032BC4
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

		// Token: 0x06000C39 RID: 3129 RVA: 0x00034A44 File Offset: 0x00032C44
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
			global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> newExtents = resizeLayoutManager.PerformAutoSize(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext, preferredSizes, fieldLayout.IsGridBagAutoFitWidth, fieldLayout.IsGridBagAutoFitHeight, out dictionary2, out dictionary3);
			this._initialResizeIsPending = false;
			return resizeLayoutManager.ResizeItems(newExtents, resizeInXAxis, null, true, global::Infragistics.Windows.DataPresenter.ItemSizeType.ExplicitAutoSize, resizeInXAxis ? dictionary2 : dictionary3);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00034C84 File Offset: 0x00032E84
		void global::Infragistics.Windows.Resizing.IResizeHost.AddResizerBar(global::System.Windows.FrameworkElement resizerBar)
		{
			base.AddVisualChild(resizerBar);
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00034C8D File Offset: 0x00032E8D
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

		// Token: 0x06000C3C RID: 3132 RVA: 0x00034CB0 File Offset: 0x00032EB0
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
				if (field == null || field.Owner == null)
				{
					return false;
				}
				if (field.IsExpandableResolved)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
				bool flag;
				if (resizeInXAxis)
				{
					flag = owner.IsHorizontal;
				}
				else
				{
					flag = !owner.IsHorizontal;
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
					switch (owner.DataRecordSizingModeResolved)
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
					if ((resizeInXAxis && owner.IsAutoFitWidth) || (!resizeInXAxis && owner.IsAutoFitHeight))
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

		// Token: 0x06000C3D RID: 3133 RVA: 0x00034E20 File Offset: 0x00033020
		global::System.Windows.FrameworkElement global::Infragistics.Windows.Resizing.IResizeHost.GetResizeAreaForItem(global::System.Windows.FrameworkElement resizableItem)
		{
			return this;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00034E23 File Offset: 0x00033023
		global::System.Windows.Input.Cursor global::Infragistics.Windows.Resizing.IResizeHost.GetResizeCursor(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis, global::System.Windows.Input.Cursor cursor)
		{
			return cursor;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00034E28 File Offset: 0x00033028
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
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (field != null) ? field.Owner : null;
					if (field != null && fieldLayout != null)
					{
						resizingMode = fieldLayout.ResizingModeResolved;
						global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(resizableItem, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
						if (virtualizingDataRecordCellPanel != null)
						{
							global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager resizeLayoutManager = virtualizingDataRecordCellPanel.GetResizeLayoutManager();
							bool isLabel = resizableItem is global::Infragistics.Windows.DataPresenter.LabelPresenter;
							global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = resizeLayoutManager.GetLayoutItem(field, isLabel);
							if (layoutItem != null)
							{
								global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> allResizableFieldItems = this.GetAllResizableFieldItems(virtualizingDataRecordCellPanel, field, isLabel, constraints.ResizeInXAxis, false);
								object containerContext = new global::System.Windows.Rect(virtualizingDataRecordCellPanel.LayoutManagerSize);
								bool flag = resizeLayoutManager.CellPanel == null;
								if (flag)
								{
									resizeLayoutManager.InitializePanelReference(virtualizingDataRecordCellPanel);
									virtualizingDataRecordCellPanel.InitializeCachedDimensions();
									resizeLayoutManager.InvalidateLayout();
								}
								double num4;
								double num5;
								double num6;
								double num7;
								resizeLayoutManager.GetResizeRange(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext, layoutItem, out num4, out num5, out num6, out num7, fieldLayout.IsGridBagAutoFitWidth, fieldLayout.IsGridBagAutoFitHeight, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.ConvertLayoutItems(allResizableFieldItems));
								if (flag)
								{
									virtualizingDataRecordCellPanel.ReleaseCachedDimensions();
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

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0003518A File Offset: 0x0003338A
		global::System.Windows.FrameworkElement global::Infragistics.Windows.Resizing.IResizeHost.RootElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0003518D File Offset: 0x0003338D
		void global::Infragistics.Windows.Resizing.IResizeHost.RemoveResizerBar(global::System.Windows.FrameworkElement resizerBar)
		{
			base.RemoveVisualChild(resizerBar);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x00035198 File Offset: 0x00033398
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
			if (field == null || field.Owner == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			bool flag = resizableItem is global::Infragistics.Windows.DataPresenter.LabelPresenter;
			bool flag2;
			if (resizeInXAxis)
			{
				flag2 = owner.IsHorizontal;
			}
			else
			{
				flag2 = !owner.IsHorizontal;
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel virtualizingDataRecordCellPanel = global::Infragistics.Windows.Utilities.GetAncestorFromType(resizableItem, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel;
			if (virtualizingDataRecordCellPanel == null)
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
			global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager fieldGridBagLayoutManager = virtualizingDataRecordCellPanel.GetResizeLayoutManager();
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase layoutItem = fieldGridBagLayoutManager.GetLayoutItem(field, flag);
			global::Infragistics.Windows.DataPresenter.Record targetRecord = null;
			if (layoutItem != null)
			{
				object containerContext = new global::System.Windows.Rect(virtualizingDataRecordCellPanel.LayoutManagerSize);
				bool flag3 = false;
				if (!flag && flag2)
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = (resizableItem as global::Infragistics.Windows.DataPresenter.CellValuePresenter) ?? (global::Infragistics.Windows.Utilities.GetDescendantFromType(resizableItem, typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter), true) as global::Infragistics.Windows.DataPresenter.CellValuePresenter);
					if (cellValuePresenter == null)
					{
						return;
					}
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsVariableHeightRecordMode(layoutItem.RecordSizingMode))
					{
						targetRecord = cellValuePresenter.Record;
						fieldGridBagLayoutManager = cellValuePresenter.Record.GetLayoutManager(true);
						layoutItem = fieldGridBagLayoutManager.GetLayoutItem(field, flag);
						if (layoutItem == null)
						{
							return;
						}
						flag3 = true;
						fieldGridBagLayoutManager.InitializePanelReference(virtualizingDataRecordCellPanel);
						virtualizingDataRecordCellPanel.InitializeCachedDimensions();
						fieldGridBagLayoutManager.InvalidateLayout();
						fieldGridBagLayoutManager.LayoutContainer(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext);
					}
				}
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase> allResizableFieldItems = this.GetAllResizableFieldItems(virtualizingDataRecordCellPanel, field, flag, resizeInXAxis, false);
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, bool> dictionary2;
				global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Size> newExtents = fieldGridBagLayoutManager.ResizeItem(global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer.Instance, containerContext, layoutItem, resizeInXAxis ? delta : 0.0, resizeInXAxis ? 0.0 : delta, owner.IsGridBagAutoFitWidth, owner.IsGridBagAutoFitHeight, global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager.ConvertLayoutItems(allResizableFieldItems), out dictionary, out dictionary2);
				bool initialResizeIsPending = this._initialResizeIsPending;
				this._initialResizeIsPending = false;
				if (flag3)
				{
					virtualizingDataRecordCellPanel.ReleaseCachedDimensions();
					fieldGridBagLayoutManager.InitializePanelReference(null);
				}
				fieldGridBagLayoutManager.ResizeItems(newExtents, resizeInXAxis, targetRecord, initialResizeIsPending, global::Infragistics.Windows.DataPresenter.ItemSizeType.Explicit, resizeInXAxis ? dictionary : dictionary2);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x000353DB File Offset: 0x000335DB
		global::System.Windows.FrameworkElement global::Infragistics.Windows.Selection.ISelectionHost.RootElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x000353E0 File Offset: 0x000335E0
		bool global::Infragistics.Windows.Selection.ISelectionHost.ActivateItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool preventScrollItemIntoView)
		{
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

		// Token: 0x06000C45 RID: 3141 RVA: 0x000354C0 File Offset: 0x000336C0
		void global::Infragistics.Windows.Selection.ISelectionHost.ClearSnapshot()
		{
			this.SelectionSnapshot.SetCells(null);
			this.SelectionSnapshot.SetFields(null);
			this.SelectionSnapshot.SetRecords(null);
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x000354E6 File Offset: 0x000336E6
		bool global::Infragistics.Windows.Selection.ISelectionHost.DeselectItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return this.InternalSelectItem(item, false, false);
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x000354F1 File Offset: 0x000336F1
		bool global::Infragistics.Windows.Selection.ISelectionHost.DeselectRange(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return this.InternalSelectRange(item, false, false);
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000354FC File Offset: 0x000336FC
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

		// Token: 0x06000C49 RID: 3145 RVA: 0x000355A8 File Offset: 0x000337A8
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

		// Token: 0x06000C4A RID: 3146 RVA: 0x00035658 File Offset: 0x00033858
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

		// Token: 0x06000C4B RID: 3147 RVA: 0x000356B0 File Offset: 0x000338B0
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

		// Token: 0x06000C4C RID: 3148 RVA: 0x000357E0 File Offset: 0x000339E0
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.GetNearestCompatibleItem(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
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

		// Token: 0x06000C4D RID: 3149 RVA: 0x00035941 File Offset: 0x00033B41
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.GetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
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

		// Token: 0x06000C4E RID: 3150 RVA: 0x00035974 File Offset: 0x00033B74
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

		// Token: 0x06000C4F RID: 3151 RVA: 0x000359B0 File Offset: 0x00033BB0
		bool global::Infragistics.Windows.Selection.ISelectionHost.IsItemSelectableWithCurrentSelection(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return item != null && item.IsSelectable && this.IsItemSelectableWithCurrentSelection(item);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x000359C8 File Offset: 0x00033BC8
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

		// Token: 0x06000C51 RID: 3153 RVA: 0x00035A74 File Offset: 0x00033C74
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

		// Token: 0x06000C52 RID: 3154 RVA: 0x00035ABA File Offset: 0x00033CBA
		void global::Infragistics.Windows.Selection.ISelectionHost.OnDragMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._fieldDragManager != null)
			{
				this._fieldDragManager._selectionHost_LastDragMoveEventArgs = e;
				this._fieldDragManager.OnMouseMove(e);
			}
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00035ADC File Offset: 0x00033CDC
		void global::Infragistics.Windows.Selection.ISelectionHost.OnDragEnd(bool canceled)
		{
			if (this._fieldDragManager != null)
			{
				global::System.Windows.Input.MouseEventArgs selectionHost_LastDragMoveEventArgs = this._fieldDragManager._selectionHost_LastDragMoveEventArgs;
				this._fieldDragManager.OnDragEnd(selectionHost_LastDragMoveEventArgs, canceled || null == selectionHost_LastDragMoveEventArgs);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00035B14 File Offset: 0x00033D14
		void global::Infragistics.Windows.Selection.ISelectionHost.OnMouseUp(global::System.Windows.Input.MouseEventArgs e)
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

		// Token: 0x06000C55 RID: 3157 RVA: 0x00035BA0 File Offset: 0x00033DA0
		bool global::Infragistics.Windows.Selection.ISelectionHost.SelectItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection)
		{
			this._snaking = false;
			return this.InternalSelectItem(item, clearExistingSelection, true);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x00035BB4 File Offset: 0x00033DB4
		bool global::Infragistics.Windows.Selection.ISelectionHost.SelectRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection)
		{
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

		// Token: 0x06000C57 RID: 3159 RVA: 0x00035C0C File Offset: 0x00033E0C
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
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Record>(ref this._pivotRecord, item as global::Infragistics.Windows.DataPresenter.Record);
				return;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				this.SetPivotMember<global::Infragistics.Windows.DataPresenter.Field>(ref this._pivotField, item as global::Infragistics.Windows.DataPresenter.Field);
			}
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00035C84 File Offset: 0x00033E84
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

		// Token: 0x06000C59 RID: 3161 RVA: 0x00035D38 File Offset: 0x00033F38
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.TranslateItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = item as global::Infragistics.Windows.DataPresenter.Cell;
			if (cell != null && cell.Record.GetCellClickActionResolved(cell.Field) == global::Infragistics.Windows.DataPresenter.CellClickAction.SelectRecord)
			{
				return cell.Record;
			}
			return item;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00035D6C File Offset: 0x00033F6C
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
					if (0L != (1048576L & statesToQueryLong) && this.EditHelper.CellValuePresenter != null)
					{
						states |= global::Infragistics.Windows.DataPresenter.States.IsInEditMode;
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
				if (viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewHorizontal)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.NavigationLayoutStyleGridViewHorizontal;
				}
				else if (viewPanel.LayoutStyle == global::Infragistics.Windows.DataPresenter.PanelLayoutStyle.GridViewVertical)
				{
					states |= global::Infragistics.Windows.DataPresenter.States.NavigationLayoutStyleGridViewVertical;
				}
				else if (this.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.CardView)
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
			if (0L != (1073741824L & statesToQueryLong) && !this.IsExporting && this._cachedExportStatus != global::Infragistics.Windows.DataPresenter.RecordExportStatus.Exporting)
			{
				states |= global::Infragistics.Windows.DataPresenter.States.IsExporting;
			}
			return (long)(states & (global::Infragistics.Windows.DataPresenter.States)statesToQueryLong);
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x000361B8 File Offset: 0x000343B8
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
				}
				if (fixedFieldLocation != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = commandInfo.Parameter as global::Infragistics.Windows.DataPresenter.Field;
					return field != null && field.IsFixedLocationAllowed(fixedFieldLocation.Value);
				}
			}
			return routedCommand != null && routedCommand.OwnerType == typeof(global::Infragistics.Windows.DataPresenter.DataPresenterCommands);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0003630C File Offset: 0x0003450C
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return commandInfo.RoutedCommand != null && this.ExecuteCommandImpl(commandInfo, true);
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00036320 File Offset: 0x00034520
		global::Infragistics.Windows.Scrolling.IDeferredScrollPanel global::Infragistics.Windows.Scrolling.IDeferredScrollHost.ScrollPanel
		{
			get
			{
				return this.CurrentPanel as global::Infragistics.Windows.Scrolling.IDeferredScrollPanel;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0003632D File Offset: 0x0003452D
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

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00036360 File Offset: 0x00034560
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x0003637C File Offset: 0x0003457C
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

		// Token: 0x06000C61 RID: 3169 RVA: 0x00036488 File Offset: 0x00034688
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

		// Token: 0x06000C62 RID: 3170 RVA: 0x000364DD File Offset: 0x000346DD
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

		// Token: 0x06000C63 RID: 3171 RVA: 0x00036514 File Offset: 0x00034714
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

		// Token: 0x06000C64 RID: 3172 RVA: 0x00036540 File Offset: 0x00034740
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

		// Token: 0x06000C65 RID: 3173 RVA: 0x000365B0 File Offset: 0x000347B0
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

		// Token: 0x06000C66 RID: 3174 RVA: 0x00036600 File Offset: 0x00034800
		global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginatorFactory.Create()
		{
			return new global::Infragistics.Windows.DataPresenter.DataPresenterReportControl(this);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00036615 File Offset: 0x00034815
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			return this.OnReceiveWeakEvent(managerType, sender, e);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00036620 File Offset: 0x00034820
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

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x0003666C File Offset: 0x0003486C
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

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00036698 File Offset: 0x00034898
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x000366D0 File Offset: 0x000348D0
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

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00036700 File Offset: 0x00034900
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

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x0003674C File Offset: 0x0003494C
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

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00036778 File Offset: 0x00034978
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x000367B0 File Offset: 0x000349B0
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

		// Token: 0x06000C70 RID: 3184 RVA: 0x000367DF File Offset: 0x000349DF
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemHeight()
		{
			return this.GetFirstItemExtentHelper(false);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000367E8 File Offset: 0x000349E8
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemWidth()
		{
			return this.GetFirstItemExtentHelper(true);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000367F4 File Offset: 0x000349F4
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

		// Token: 0x06000C73 RID: 3187 RVA: 0x00036957 File Offset: 0x00034B57
		void global::Infragistics.Controls.ISupportScrollHelper.InvalidateScrollLayout()
		{
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00036959 File Offset: 0x00034B59
		void global::Infragistics.Controls.ISupportScrollHelper.OnPanComplete()
		{
			this._cachedHorizValue = null;
			this._cachedVertValue = null;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00036973 File Offset: 0x00034B73
		void global::Infragistics.Controls.ISupportScrollHelper.OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
		}

		// Token: 0x040003A2 RID: 930
		private const int ExpandRecordAnimationDuration = 1000;

		// Token: 0x040003A3 RID: 931
		private const int CollapseRecordAnimationDuration = 700;

		// Token: 0x040003A4 RID: 932
		private const double DEFAULT_RECORD_HEIGHT = 20.0;

		// Token: 0x040003A5 RID: 933
		private global::Infragistics.Windows.Resizing.ResizeController _resizeController;

		// Token: 0x040003A6 RID: 934
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _selectedItems;

		// Token: 0x040003A7 RID: 935
		private global::System.Windows.Controls.Grid _contentSiteGrid;

		// Token: 0x040003A8 RID: 936
		private global::System.Windows.Controls.Grid _dataAreaGrid;

		// Token: 0x040003A9 RID: 937
		private global::System.Windows.FrameworkElement _contentSiteDataAreaContent;

		// Token: 0x040003AA RID: 938
		private global::System.Windows.Controls.ItemsPanelTemplate _itemsPanel;

		// Token: 0x040003AB RID: 939
		private global::System.Collections.IEnumerable _dataSourceRootList;

		// Token: 0x040003AC RID: 940
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.Helpers.EnumerableObjectWrapper> _dataSourceRootChildListWrappers;

		// Token: 0x040003AD RID: 941
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataSourceRootListChangeListener _dataSourceRootListChangeListener;

		// Token: 0x040003AE RID: 942
		private global::Infragistics.Windows.DataPresenter.RecordListControl _rootRecordListControl;

		// Token: 0x040003AF RID: 943
		private global::Infragistics.Windows.DataPresenter.RecordListControl _currentRecordListControl;

		// Token: 0x040003B0 RID: 944
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x040003B1 RID: 945
		private global::System.Collections.Generic.List<object> _logicalChildren = new global::System.Collections.Generic.List<object>();

		// Token: 0x040003B2 RID: 946
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.DataItemsCollection _dataItems;

		// Token: 0x040003B3 RID: 947
		private global::Infragistics.Windows.DataPresenter.FieldLayoutCollection _fieldLayouts;

		// Token: 0x040003B4 RID: 948
		private global::Infragistics.Windows.DataPresenter.FieldLayout _defaultLayout;

		// Token: 0x040003B5 RID: 949
		private global::Infragistics.Windows.DataPresenter.Record _activeRecord;

		// Token: 0x040003B6 RID: 950
		private global::Infragistics.Windows.DataPresenter.Cell _activeCell;

		// Token: 0x040003B7 RID: 951
		private global::Infragistics.Windows.DataPresenter.Record _pivotRecord;

		// Token: 0x040003B8 RID: 952
		private global::Infragistics.Windows.DataPresenter.Field _pivotField;

		// Token: 0x040003B9 RID: 953
		private global::Infragistics.Windows.DataPresenter.Cell _pivotCell;

		// Token: 0x040003BA RID: 954
		private global::Infragistics.Windows.DataPresenter.EditModeHelper _editHelper;

		// Token: 0x040003BB RID: 955
		private global::System.Windows.Point? _selectionPoint;

		// Token: 0x040003BC RID: 956
		private bool _snaking;

		// Token: 0x040003BD RID: 957
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _selectionSnapshot;

		// Token: 0x040003BE RID: 958
		private global::Infragistics.Windows.Selection.ISelectionStrategyFilter _selectionStrategyFilter;

		// Token: 0x040003BF RID: 959
		private global::System.Windows.Controls.StyleSelector _internalCellPresenterStyleSelector;

		// Token: 0x040003C0 RID: 960
		private global::System.Windows.Controls.StyleSelector _internalCellValuePresenterStyleSelector;

		// Token: 0x040003C1 RID: 961
		private global::System.Windows.Controls.StyleSelector _internalEditorStyleSelector;

		// Token: 0x040003C2 RID: 962
		private global::System.Windows.Controls.StyleSelector _internalExpandedCellStyleSelector;

		// Token: 0x040003C3 RID: 963
		private global::System.Windows.Controls.StyleSelector _internalLabelPresenterStyleSelector;

		// Token: 0x040003C4 RID: 964
		private global::System.Windows.Controls.StyleSelector _internalHeaderPresenterStyleSelector;

		// Token: 0x040003C5 RID: 965
		private global::System.Windows.Controls.StyleSelector _internalHeaderPrefixAreaStyleSelector;

		// Token: 0x040003C6 RID: 966
		private global::System.Windows.Controls.StyleSelector _internalHeaderLabelAreaStyleSelector;

		// Token: 0x040003C7 RID: 967
		private global::System.Windows.Controls.StyleSelector _internalRecordStyleSelector;

		// Token: 0x040003C8 RID: 968
		private global::System.Windows.Controls.StyleSelector _internalRecordCellAreaStyleSelector;

		// Token: 0x040003C9 RID: 969
		private global::System.Windows.Controls.StyleSelector _internalRecordSelectorStyleSelector;

		// Token: 0x040003CA RID: 970
		private global::System.Windows.Threading.DispatcherOperation _postRecordsInViewChangedOperation;

		// Token: 0x040003CB RID: 971
		private global::System.Windows.Threading.DispatcherOperation _bumpScrollCountOperation;

		// Token: 0x040003CC RID: 972
		internal global::Infragistics.Controls.TouchScrollHelper _scrollHelper;

		// Token: 0x040003CD RID: 973
		private double? _cachedHorizValue;

		// Token: 0x040003CE RID: 974
		private double? _cachedVertValue;

		// Token: 0x040003CF RID: 975
		private double _previousFirstItemWidth = 20.0;

		// Token: 0x040003D0 RID: 976
		private double _previousFirstItemHeight = 20.0;

		// Token: 0x040003D1 RID: 977
		private bool _clearingActiveCell;

		// Token: 0x040003D2 RID: 978
		private bool _dataSourceHasBeenCleared;

		// Token: 0x040003D3 RID: 979
		private int _groupbyVersion;

		// Token: 0x040003D4 RID: 980
		private int _renderVersion;

		// Token: 0x040003D5 RID: 981
		private int _cachedOverallScrollCount;

		// Token: 0x040003D6 RID: 982
		internal bool _cachedOverallScrollCountDirty = true;

		// Token: 0x040003D7 RID: 983
		private int _overallScrollPosition;

		// Token: 0x040003D8 RID: 984
		private global::Infragistics.Windows.Helpers.HashSet _layoutUpdatedCallbacks;

		// Token: 0x040003D9 RID: 985
		private global::Infragistics.Windows.DataPresenter.GroupByArea _groupByArea;

		// Token: 0x040003DA RID: 986
		private global::Infragistics.Windows.DataPresenter.GroupByAreaMulti _groupByAreaMulti;

		// Token: 0x040003DB RID: 987
		private global::Infragistics.Windows.DataPresenter.ViewBase _currentViewInternal;

		// Token: 0x040003DC RID: 988
		private bool _forceClearActiveRecord;

		// Token: 0x040003DD RID: 989
		private bool _isRecordManagerDataSourceInitialized;

		// Token: 0x040003DE RID: 990
		private global::System.Windows.Threading.DispatcherOperation _asyncChangePending;

		// Token: 0x040003DF RID: 991
		private bool _invalidateGeneratedStylesPending;

		// Token: 0x040003E0 RID: 992
		private bool _haveAnyTemplatesBeenGenerated;

		// Token: 0x040003E1 RID: 993
		private global::System.Globalization.CultureInfo _defaultConverterCulture;

		// Token: 0x040003E2 RID: 994
		private global::System.Collections.Generic.Queue<global::Infragistics.Windows.DataPresenter.RecordPresenter> _recordsPendingNestedContentInitialization;

		// Token: 0x040003E3 RID: 995
		private global::Infragistics.Windows.DataPresenter.CustomizationsManager _customizationsManager;

		// Token: 0x040003E4 RID: 996
		private bool _isLoadingCustomizations;

		// Token: 0x040003E5 RID: 997
		private global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.RecordManager> _nonRootCurrencyTrackingManagers;

		// Token: 0x040003E6 RID: 998
		private global::Infragistics.Windows.DataPresenter.FieldDragManager _fieldDragManager;

		// Token: 0x040003E7 RID: 999
		private global::System.Windows.Input.MouseButtonEventArgs _previewMouseDownArgs;

		// Token: 0x040003E8 RID: 1000
		internal global::Infragistics.Windows.DataPresenter.Record _activeRecordWithPendingDirtyFilterState;

		// Token: 0x040003E9 RID: 1001
		private global::Infragistics.Windows.Selection.ISelectableItem _itemPendingScrollItemIntoView;

		// Token: 0x040003EA RID: 1002
		private bool _bypassScrollIntoView;

		// Token: 0x040003EB RID: 1003
		private global::Infragistics.Windows.DataPresenter.Record _initializeRecordSuspendedFor;

		// Token: 0x040003EC RID: 1004
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _initializeRecordSuspendedFor_List;

		// Token: 0x040003ED RID: 1005
		private global::Infragistics.Windows.DataPresenter.RecordPresenter _pendingActiveRecordPresenter;

		// Token: 0x040003EE RID: 1006
		private global::Infragistics.Windows.DataPresenter.DataPresenterHistory _history;

		// Token: 0x040003EF RID: 1007
		private global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo _clipboardOperationInfo;

		// Token: 0x040003F0 RID: 1008
		private bool _initialResizeIsPending;

		// Token: 0x040003F1 RID: 1009
		private global::Infragistics.Windows.Controls.ToolWindow _retainedFieldChooserWindow;

		// Token: 0x040003F2 RID: 1010
		internal global::Infragistics.Collections.WeakList<global::Infragistics.Windows.DataPresenter.FieldChooser> _registeredFieldChoosers;

		// Token: 0x040003F3 RID: 1011
		private int _endEditOnScrollSuspendCount;

		// Token: 0x040003F4 RID: 1012
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> _fieldLayoutsAutoSizePending;

		// Token: 0x040003F5 RID: 1013
		private int _fieldLayoutAutoSizeViewableCount;

		// Token: 0x040003F6 RID: 1014
		private int _fieldLayoutAutoSizeAllRecordsCount;

		// Token: 0x040003F7 RID: 1015
		private int _allRecordsAutoSizeMaxDepth = -1;

		// Token: 0x040003F8 RID: 1016
		private global::System.Windows.Threading.DispatcherOperation _pendingFieldAutoSize;

		// Token: 0x040003F9 RID: 1017
		private bool _processingFieldAutoSize;

		// Token: 0x040003FA RID: 1018
		private int _fieldLayoutAutoSizeRecordsInViewCount;

		// Token: 0x040003FB RID: 1019
		private bool _isExporting;

		// Token: 0x040003FC RID: 1020
		private bool _suppressExportingDataSourceException;

		// Token: 0x040003FD RID: 1021
		internal int _cachedScrollCountRecalcVersion;

		// Token: 0x040003FE RID: 1022
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock.VisibleDataBlockCache> _lastVisibleDataBlocks;

		// Token: 0x040003FF RID: 1023
		private global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CellsInViewChangedEventArgs> _cellsInViewChangedEventHandler;

		// Token: 0x04000400 RID: 1024
		internal bool _pendingRaiseCellsInViewChangedAsyncHelperHandler;

		// Token: 0x04000401 RID: 1025
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.AsyncPageCommand _asyncCommand;

		// Token: 0x04000402 RID: 1026
		private bool _isInPageUpDown;

		// Token: 0x04000403 RID: 1027
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.KeyDownInfo _lastKeyDownInfo;

		// Token: 0x04000404 RID: 1028
		private global::Infragistics.Windows.DataPresenter.SuppressedEventsCollection _suppressedEvents;

		// Token: 0x04000405 RID: 1029
		internal readonly bool _isDerived;

		// Token: 0x04000406 RID: 1030
		internal bool? _cachedInitializeRecordEventSuppressed;

		// Token: 0x04000407 RID: 1031
		private double _lastScrollDimensionExtent;

		// Token: 0x04000408 RID: 1032
		private bool _cachedIsUndoEnabled;

		// Token: 0x04000409 RID: 1033
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.FixedAreaScrollHelper _fixedScrollHelper;

		// Token: 0x0400040A RID: 1034
		private global::Infragistics.Windows.DataPresenter.ExportHelper _exportHelper;

		// Token: 0x0400040B RID: 1035
		internal global::Infragistics.Windows.DataPresenter.Record _recordWhoseChangesAreBeingDiscarded;

		// Token: 0x0400040C RID: 1036
		internal global::System.Windows.Threading.DispatcherTimer _isScrollingTimer;

		// Token: 0x0400040D RID: 1037
		private global::System.Windows.Size _lastMeasureSize;

		// Token: 0x0400040E RID: 1038
		private double _cachedRecordSelectorExtent = double.NaN;

		// Token: 0x0400040F RID: 1039
		private double _cachedRecordSelectorFixButtonExtent = double.NaN;

		// Token: 0x04000410 RID: 1040
		private double _cachedRecordSelectorErrorIconExtent = double.NaN;

		// Token: 0x04000455 RID: 1109
		private global::System.Type _selectedItemsChangePending;

		// Token: 0x0400045C RID: 1116
		public static readonly global::System.Windows.DependencyProperty ActiveDataItemProperty;

		// Token: 0x0400045D RID: 1117
		public static readonly global::System.Windows.DependencyProperty ActiveCellProperty;

		// Token: 0x0400045E RID: 1118
		private global::Infragistics.Windows.DataPresenter.Cell _cachedLastActiveCell;

		// Token: 0x0400045F RID: 1119
		public static readonly global::System.Windows.DependencyProperty ActiveRecordProperty;

		// Token: 0x04000460 RID: 1120
		public static readonly global::System.Windows.DependencyProperty AutoFitProperty;

		// Token: 0x04000461 RID: 1121
		private bool? _cachedAutoFit;

		// Token: 0x04000462 RID: 1122
		public static readonly global::System.Windows.DependencyProperty BindToSampleDataProperty;

		// Token: 0x04000463 RID: 1123
		public static readonly global::System.Windows.DependencyProperty CalculationAdapterProperty;

		// Token: 0x04000464 RID: 1124
		internal global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapterInternal _calculationAdapter;

		// Token: 0x04000465 RID: 1125
		public static readonly global::System.Windows.DependencyProperty CellContainerGenerationModeProperty;

		// Token: 0x04000466 RID: 1126
		private global::Infragistics.Windows.DataPresenter.CellContainerGenerationMode _cachedCellContainerGenerationMode;

		// Token: 0x04000467 RID: 1127
		public static readonly global::System.Windows.DependencyProperty ClipboardCellDelimiterProperty;

		// Token: 0x04000468 RID: 1128
		public static readonly global::System.Windows.DependencyProperty ClipboardCellSeparatorProperty;

		// Token: 0x04000469 RID: 1129
		public static readonly global::System.Windows.DependencyProperty ClipboardRecordSeparatorProperty;

		// Token: 0x0400046A RID: 1130
		public static readonly global::System.Windows.DependencyProperty CurrentViewProperty;

		// Token: 0x0400046B RID: 1131
		public static readonly global::System.Windows.ResourceKey DataErrorContentTemplateKey;

		// Token: 0x0400046C RID: 1132
		public static readonly global::System.Windows.ResourceKey DataErrorIconStyleKey;

		// Token: 0x0400046D RID: 1133
		public static readonly global::System.Windows.DependencyProperty DataSourceProperty;

		// Token: 0x0400046E RID: 1134
		public static readonly global::System.Windows.DependencyProperty DataSourceResetBehaviorProperty;

		// Token: 0x0400046F RID: 1135
		private global::Infragistics.Windows.DataPresenter.RecordExportStatus _cachedExportStatus;

		// Token: 0x04000470 RID: 1136
		private static readonly global::System.Windows.DependencyPropertyKey ExportStatusPropertyKey;

		// Token: 0x04000471 RID: 1137
		public static readonly global::System.Windows.DependencyProperty ExportStatusProperty;

		// Token: 0x04000472 RID: 1138
		public static readonly global::System.Windows.ResourceKey FieldChooserButtonStyleKey;

		// Token: 0x04000473 RID: 1139
		public static readonly global::System.Windows.DependencyProperty FieldLayoutSettingsProperty;

		// Token: 0x04000474 RID: 1140
		private global::Infragistics.Windows.DataPresenter.FieldLayoutSettings _x_FieldLayoutSettings;

		// Token: 0x04000475 RID: 1141
		public static readonly global::System.Windows.DependencyProperty FieldSettingsProperty;

		// Token: 0x04000476 RID: 1142
		private global::Infragistics.Windows.DataPresenter.FieldSettings _x_FieldSettings;

		// Token: 0x04000477 RID: 1143
		public static readonly global::System.Windows.ResourceKey FilterCellClearButtonStyleKey;

		// Token: 0x04000478 RID: 1144
		public static readonly global::System.Windows.ResourceKey FilterDropDownLoadingTemplateKey;

		// Token: 0x04000479 RID: 1145
		public static readonly global::System.Windows.ResourceKey FilterRecordClearButtonStyleKey;

		// Token: 0x0400047A RID: 1146
		public static readonly global::System.Windows.DependencyProperty GroupByAreaProperty;

		// Token: 0x0400047B RID: 1147
		public static readonly global::System.Windows.DependencyProperty GroupByAreaFieldLabelStyleProperty;

		// Token: 0x0400047C RID: 1148
		public static readonly global::System.Windows.DependencyProperty GroupByAreaFieldLabelStyleSelectorProperty;

		// Token: 0x0400047D RID: 1149
		public static readonly global::System.Windows.DependencyProperty GroupByAreaLocationProperty;

		// Token: 0x0400047E RID: 1150
		public static readonly global::System.Windows.DependencyProperty GroupByAreaModeProperty;

		// Token: 0x0400047F RID: 1151
		public static readonly global::System.Windows.DependencyProperty GroupByAreaMultiProperty;

		// Token: 0x04000480 RID: 1152
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static readonly global::System.Windows.DependencyProperty GroupByAreaStyleProperty;

		// Token: 0x04000481 RID: 1153
		private static readonly global::System.Windows.DependencyPropertyKey IsExportingPropertyKey;

		// Token: 0x04000482 RID: 1154
		public static readonly global::System.Windows.DependencyProperty IsExportingProperty;

		// Token: 0x04000483 RID: 1155
		public static readonly global::System.Windows.DependencyProperty IsGroupByAreaExpandedProperty;

		// Token: 0x04000484 RID: 1156
		public static readonly global::System.Windows.DependencyProperty IsNestedDataDisplayEnabledProperty;

		// Token: 0x04000485 RID: 1157
		private bool _cachedIsNestedDataDisplayEnabled;

		// Token: 0x04000486 RID: 1158
		public static readonly global::System.Windows.DependencyProperty IsSynchronizedWithCurrentItemProperty;

		// Token: 0x04000487 RID: 1159
		public static readonly global::System.Windows.DependencyProperty IsTouchSupportEnabledProperty;

		// Token: 0x04000488 RID: 1160
		public static readonly global::System.Windows.DependencyProperty IsUndoEnabledProperty;

		// Token: 0x04000489 RID: 1161
		public static readonly global::System.Windows.DependencyProperty RecordContainerGenerationModeProperty;

		// Token: 0x0400048A RID: 1162
		public static readonly global::System.Windows.DependencyProperty RecordLoadModeProperty;

		// Token: 0x0400048B RID: 1163
		private static readonly global::System.Windows.DependencyPropertyKey RecordsPropertyKey;

		// Token: 0x0400048C RID: 1164
		public static readonly global::System.Windows.DependencyProperty RecordsProperty;

		// Token: 0x0400048D RID: 1165
		public static readonly global::System.Windows.DependencyProperty RecordSelectorExtentProperty;

		// Token: 0x0400048E RID: 1166
		public static readonly global::System.Windows.DependencyProperty RecordSelectorErrorIconExtentProperty;

		// Token: 0x0400048F RID: 1167
		public static readonly global::System.Windows.DependencyProperty RecordSelectorFixButtonExtentProperty;

		// Token: 0x04000490 RID: 1168
		public static readonly global::System.Windows.DependencyProperty ReportViewProperty;

		// Token: 0x04000491 RID: 1169
		public static readonly global::System.Windows.DependencyProperty RecordContainerRetentionModeProperty;

		// Token: 0x04000492 RID: 1170
		public static readonly global::System.Windows.DependencyProperty ScrollBehaviorOnListChangeProperty;

		// Token: 0x04000493 RID: 1171
		public static readonly global::System.Windows.DependencyProperty ScrollingModeProperty;

		// Token: 0x04000494 RID: 1172
		public static readonly global::System.Windows.DependencyProperty SortRecordsByDataTypeProperty;

		// Token: 0x04000495 RID: 1173
		public static readonly global::System.Windows.DependencyProperty ThemeProperty;

		// Token: 0x04000497 RID: 1175
		private global::System.Windows.ResourceDictionary _themeRegistered_DP_ResourceSet;

		// Token: 0x04000498 RID: 1176
		public static readonly global::System.Windows.DependencyProperty UndoLimitProperty;

		// Token: 0x04000499 RID: 1177
		public static readonly global::System.Windows.DependencyProperty UpdateModeProperty;

		// Token: 0x0400049A RID: 1178
		private static readonly global::System.Windows.DependencyPropertyKey ViewableRecordsPropertyKey;

		// Token: 0x0400049B RID: 1179
		public static readonly global::System.Windows.DependencyProperty ViewableRecordsProperty;

		// Token: 0x0400049C RID: 1180
		public static readonly global::System.Windows.DependencyProperty DataPresenterProperty;

		// Token: 0x0400049D RID: 1181
		private static readonly global::System.Windows.DependencyPropertyKey DataSourceInternalPropertyKey;

		// Token: 0x0400049E RID: 1182
		internal static readonly global::System.Windows.DependencyProperty DataSourceInternalProperty;

		// Token: 0x0400049F RID: 1183
		internal static readonly global::System.Windows.DependencyProperty GridMeasureVersionProperty;

		// Token: 0x040004A0 RID: 1184
		private static readonly global::System.Windows.DependencyProperty InternalRecordsProperty;

		// Token: 0x040004A1 RID: 1185
		private static readonly global::System.Windows.DependencyPropertyKey IsScrollingPropertyKey;

		// Token: 0x040004A2 RID: 1186
		internal static readonly global::System.Windows.DependencyProperty IsScrollingProperty;

		// Token: 0x040004A3 RID: 1187
		private static readonly global::System.Windows.DependencyPropertyKey ItemsPanelPropertyKey;

		// Token: 0x040004A4 RID: 1188
		internal static readonly global::System.Windows.DependencyProperty ItemsPanelProperty;

		// Token: 0x040004A5 RID: 1189
		internal static readonly global::System.Windows.DependencyProperty OverallSortVersionProperty;

		// Token: 0x040004A6 RID: 1190
		private static readonly global::System.Windows.DependencyProperty PanelSettingsProperty;

		// Token: 0x040004A7 RID: 1191
		private static readonly global::System.Windows.DependencyPropertyKey RecordsInViewVersionPropertyKey;

		// Token: 0x040004A8 RID: 1192
		internal static readonly global::System.Windows.DependencyProperty RecordsInViewVersionProperty;

		// Token: 0x040004A9 RID: 1193
		private static readonly global::System.Windows.DependencyPropertyKey RenderVersionPropertyKey;

		// Token: 0x040004AA RID: 1194
		internal static readonly global::System.Windows.DependencyProperty RenderVersionProperty;

		// Token: 0x040004AB RID: 1195
		internal static readonly global::System.Windows.DependencyProperty ScrollableRecordCountVersionProperty;

		// Token: 0x040004AC RID: 1196
		internal static readonly global::System.Windows.DependencyProperty ScrollCountRecalcVersionProperty;

		// Token: 0x040004AD RID: 1197
		internal static readonly global::System.Windows.DependencyProperty ScrollVersionProperty;

		// Token: 0x040004AE RID: 1198
		private static readonly global::System.Windows.DependencyPropertyKey HorizontalScrollBarVisibilityPropertyKey;

		// Token: 0x040004AF RID: 1199
		private static readonly global::System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty;

		// Token: 0x040004B0 RID: 1200
		private static readonly global::System.Windows.DependencyPropertyKey VerticalScrollBarVisibilityPropertyKey;

		// Token: 0x040004B1 RID: 1201
		private static readonly global::System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty;

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000C78 RID: 3192
		private delegate void DataErrorMessageDelegate(string message, string title, global::System.Windows.MessageBoxButton buttons, global::System.Windows.MessageBoxImage image, bool processAsyncOnException);

		// Token: 0x020000CE RID: 206
		// (Invoke) Token: 0x06000C7C RID: 3196
		private delegate void ProcessSortCriteria(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout);

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x06000C80 RID: 3200
		private delegate void RefocusActiveCellDelegate(int? selectionStart, int? selectionLength);

		// Token: 0x020000D0 RID: 208
		public class DataItemsCollection : global::System.Collections.ObjectModel.ObservableCollection<object>
		{
			// Token: 0x06000C83 RID: 3203 RVA: 0x00036975 File Offset: 0x00034B75
			internal DataItemsCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
			{
				this._dp = dp;
			}

			// Token: 0x06000C84 RID: 3204 RVA: 0x00036984 File Offset: 0x00034B84
			protected override void ClearItems()
			{
				foreach (object child in this)
				{
					this._dp.InternalRemoveLogicalChild(child);
				}
				base.ClearItems();
			}

			// Token: 0x06000C85 RID: 3205 RVA: 0x000369D8 File Offset: 0x00034BD8
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

			// Token: 0x06000C86 RID: 3206 RVA: 0x00036A2F File Offset: 0x00034C2F
			protected override void MoveItem(int oldIndex, int newIndex)
			{
				base.MoveItem(oldIndex, newIndex);
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x00036A3C File Offset: 0x00034C3C
			protected override void RemoveItem(int index)
			{
				object child = base[index];
				base.RemoveItem(index);
				this._dp.InternalRemoveLogicalChild(child);
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x00036A64 File Offset: 0x00034C64
			protected override void SetItem(int index, object item)
			{
				object child = base[index];
				base.SetItem(index, item);
				this._dp.InternalRemoveLogicalChild(child);
				this._dp.InternalAddLogicalChild(item);
			}

			// Token: 0x040004B4 RID: 1204
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;
		}

		// Token: 0x020000D1 RID: 209
		private class DataSourceRootListChangeListener : global::System.Windows.IWeakEventListener
		{
			// Token: 0x06000C89 RID: 3209 RVA: 0x00036A99 File Offset: 0x00034C99
			internal DataSourceRootListChangeListener(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
			{
				this._dataPresenter = dataPresenter;
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x00036AA8 File Offset: 0x00034CA8
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

			// Token: 0x040004B5 RID: 1205
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;
		}

		// Token: 0x020000D2 RID: 210
		private class RangeSelectionEvaluator
		{
			// Token: 0x06000C8B RID: 3211 RVA: 0x00036B04 File Offset: 0x00034D04
			internal RangeSelectionEvaluator(global::Infragistics.Windows.DataPresenter.Record pivotRecord, global::Infragistics.Windows.DataPresenter.Record record, bool snaking)
			{
				if (pivotRecord == null)
				{
					throw new global::System.ArgumentNullException("pivotRecord", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (record == null)
				{
					throw new global::System.ArgumentNullException("Record", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				this._pivotRecord = pivotRecord;
				this._endOfRangeRecord = record;
				this._snaking = snaking;
				this.Initialize();
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x00036B64 File Offset: 0x00034D64
			internal RangeSelectionEvaluator(global::Infragistics.Windows.DataPresenter.Cell pivotCell, global::Infragistics.Windows.DataPresenter.Cell cell, bool snaking)
			{
				if (pivotCell == null)
				{
					throw new global::System.ArgumentNullException("pivotCell", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (cell == null)
				{
					throw new global::System.ArgumentNullException("Cell", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				this._pivotCell = pivotCell;
				this._pivotRecord = pivotCell.Record;
				this._pivotField = pivotCell.Field;
				this._endOfRangeCell = cell;
				this._endOfRangeRecord = cell.Record;
				this._endOfRangeField = cell.Field;
				this._snaking = snaking;
				this.Initialize();
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x00036BF4 File Offset: 0x00034DF4
			internal RangeSelectionEvaluator(global::Infragistics.Windows.DataPresenter.Field pivotField, global::Infragistics.Windows.DataPresenter.Field field, bool snaking)
			{
				if (pivotField == null)
				{
					throw new global::System.ArgumentNullException("pivotField", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				if (field == null)
				{
					throw new global::System.ArgumentNullException("Field", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_2"));
				}
				this._pivotField = pivotField;
				this._endOfRangeField = field;
				this._snaking = snaking;
				this.Initialize();
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00036C52 File Offset: 0x00034E52
			internal global::Infragistics.Windows.DataPresenter.Cell EndOfRangeCell
			{
				get
				{
					return this._endOfRangeCell;
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00036C5A File Offset: 0x00034E5A
			internal global::Infragistics.Windows.DataPresenter.Field EndOfRangeField
			{
				get
				{
					return this._endOfRangeField;
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00036C62 File Offset: 0x00034E62
			internal global::Infragistics.Windows.DataPresenter.Record EndOfRangeRecord
			{
				get
				{
					return this._endOfRangeRecord;
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000C91 RID: 3217 RVA: 0x00036C6A File Offset: 0x00034E6A
			internal bool IsRangeOfCells
			{
				get
				{
					return this._pivotCell != null;
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00036C78 File Offset: 0x00034E78
			internal bool IsRangeOfFields
			{
				get
				{
					return this._pivotField != null && !this.IsRangeOfCells;
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00036C8D File Offset: 0x00034E8D
			internal bool IsRangeOfRecords
			{
				get
				{
					return this._pivotRecord != null && !this.IsRangeOfRecords;
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00036CA2 File Offset: 0x00034EA2
			internal global::Infragistics.Windows.DataPresenter.Cell PivotCell
			{
				get
				{
					return this._pivotCell;
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00036CAA File Offset: 0x00034EAA
			internal global::Infragistics.Windows.DataPresenter.Field PivotField
			{
				get
				{
					return this._pivotField;
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00036CB2 File Offset: 0x00034EB2
			internal global::Infragistics.Windows.DataPresenter.Record PivotRecord
			{
				get
				{
					return this._pivotRecord;
				}
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x00036CBC File Offset: 0x00034EBC
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

			// Token: 0x06000C98 RID: 3224 RVA: 0x00036D24 File Offset: 0x00034F24
			internal static bool IsPositionInFieldRectangle(ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition fromPosition, ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition thruPosition, ref global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition testPosition)
			{
				int num = global::System.Math.Min(fromPosition.Row, thruPosition.Row);
				int num2 = global::System.Math.Max(fromPosition.Row + fromPosition.RowSpan, thruPosition.Row + thruPosition.RowSpan);
				int num3 = global::System.Math.Min(fromPosition.Column, thruPosition.Column);
				int num4 = global::System.Math.Max(fromPosition.Column + fromPosition.ColumnSpan, thruPosition.Column + thruPosition.ColumnSpan);
				return testPosition.Row >= num && testPosition.Row + testPosition.RowSpan <= num2 && testPosition.Column >= num3 && testPosition.Column + testPosition.ColumnSpan <= num4;
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x00036DE0 File Offset: 0x00034FE0
			internal bool IsPositionInRectangularCellSlice(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = field.GridPosition;
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
					num5 = gridPosition.Column;
					num6 = gridPosition.ColumnSpan;
				}
				else
				{
					num = this._pivotFieldPosition.Row;
					num2 = this._pivotFieldPosition.RowSpan;
					num3 = this._endOfRangeFieldPosition.Row;
					num4 = this._endOfRangeFieldPosition.RowSpan;
					num5 = gridPosition.Row;
					num6 = gridPosition.RowSpan;
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
						num5 = gridPosition.Row;
						num6 = gridPosition.RowSpan;
					}
					else
					{
						num = this._pivotFieldPosition.Column;
						num2 = this._pivotFieldPosition.ColumnSpan;
						num3 = this._endOfRangeFieldPosition.Column;
						num4 = this._endOfRangeFieldPosition.ColumnSpan;
						num5 = gridPosition.Column;
						num6 = gridPosition.ColumnSpan;
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

			// Token: 0x06000C9A RID: 3226 RVA: 0x00036FA4 File Offset: 0x000351A4
			internal bool IsCellInRange(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Field field, bool excludePivot, bool excludeEndRange)
			{
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
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = field.GridPosition;
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
						num2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._pivotFieldPosition, ref gridPosition);
					}
					else
					{
						num2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._endOfRangeFieldPosition, ref gridPosition);
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

			// Token: 0x06000C9B RID: 3227 RVA: 0x000370F8 File Offset: 0x000352F8
			internal bool IsFieldInRange(global::Infragistics.Windows.DataPresenter.Field field, bool excludePivot, bool excludeEndRange)
			{
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
				global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = field.GridPosition;
				if (!this._snaking)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.IsPositionInFieldRectangle(ref this._pivotFieldPosition, ref this._endOfRangeFieldPosition, ref gridPosition);
				}
				int num = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._pivotFieldPosition, ref this._endOfRangeFieldPosition);
				int num2 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._pivotFieldPosition, ref gridPosition);
				if (num == 0)
				{
					return num2 == 0;
				}
				int num3 = global::Infragistics.Windows.DataPresenter.DataPresenterBase.RangeSelectionEvaluator.CompareFieldPositions(ref this._endOfRangeFieldPosition, ref gridPosition);
				if (num > 0)
				{
					return num2 >= 0 && num3 <= 0;
				}
				return num2 <= 0 && num3 >= 0;
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x000371B0 File Offset: 0x000353B0
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

			// Token: 0x06000C9D RID: 3229 RVA: 0x00037218 File Offset: 0x00035418
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
					}
				}
			}

			// Token: 0x040004B6 RID: 1206
			private global::Infragistics.Windows.DataPresenter.Record _pivotRecord;

			// Token: 0x040004B7 RID: 1207
			private global::Infragistics.Windows.DataPresenter.Cell _pivotCell;

			// Token: 0x040004B8 RID: 1208
			private global::Infragistics.Windows.DataPresenter.Field _pivotField;

			// Token: 0x040004B9 RID: 1209
			private global::Infragistics.Windows.DataPresenter.Record _endOfRangeRecord;

			// Token: 0x040004BA RID: 1210
			private global::Infragistics.Windows.DataPresenter.Cell _endOfRangeCell;

			// Token: 0x040004BB RID: 1211
			private global::Infragistics.Windows.DataPresenter.Field _endOfRangeField;

			// Token: 0x040004BC RID: 1212
			private bool _snaking;

			// Token: 0x040004BD RID: 1213
			private bool _isPivotLessThanEnd;

			// Token: 0x040004BE RID: 1214
			private bool _isGridView;

			// Token: 0x040004BF RID: 1215
			private global::System.Windows.Controls.Orientation _gridViewOrientation;

			// Token: 0x040004C0 RID: 1216
			private long _pivotRecordPosition;

			// Token: 0x040004C1 RID: 1217
			private long _endOfRangeRecordPosition;

			// Token: 0x040004C2 RID: 1218
			private global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition _pivotFieldPosition;

			// Token: 0x040004C3 RID: 1219
			private global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition _endOfRangeFieldPosition;
		}

		// Token: 0x020000D3 RID: 211
		public class SelectedItemHolder : global::Infragistics.PropertyChangeNotifier, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Selection.ISelectableItem>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000C9E RID: 3230 RVA: 0x00037328 File Offset: 0x00035528
			internal SelectedItemHolder(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
			{
				this._dp = dp;
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00037337 File Offset: 0x00035537
			public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
			{
				get
				{
					return this._dp;
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x0003733F File Offset: 0x0003553F
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

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x0003736C File Offset: 0x0003556C
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

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00037399 File Offset: 0x00035599
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

			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000373C8 File Offset: 0x000355C8
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

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0003741A File Offset: 0x0003561A
			internal bool HasCells
			{
				get
				{
					return this._cells != null && this._cells.Count > 0;
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00037434 File Offset: 0x00035634
			internal bool HasFields
			{
				get
				{
					return this._fields != null && this._fields.Count > 0;
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00037450 File Offset: 0x00035650
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

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00037487 File Offset: 0x00035687
			internal bool HasRecords
			{
				get
				{
					return this._records != null && this._records.Count > 0;
				}
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000374A1 File Offset: 0x000356A1
			internal bool HasSelection
			{
				get
				{
					return this.HasCells || this.HasFields || this.HasRecords;
				}
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x000374BB File Offset: 0x000356BB
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

			// Token: 0x06000CAA RID: 3242 RVA: 0x000374F8 File Offset: 0x000356F8
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

			// Token: 0x06000CAB RID: 3243 RVA: 0x00037558 File Offset: 0x00035758
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

			// Token: 0x06000CAC RID: 3244 RVA: 0x00037778 File Offset: 0x00035978
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

			// Token: 0x06000CAD RID: 3245 RVA: 0x00037800 File Offset: 0x00035A00
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

			// Token: 0x06000CAE RID: 3246 RVA: 0x00037864 File Offset: 0x00035A64
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

			// Token: 0x06000CAF RID: 3247 RVA: 0x000378E4 File Offset: 0x00035AE4
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

			// Token: 0x06000CB0 RID: 3248 RVA: 0x00037944 File Offset: 0x00035B44
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

			// Token: 0x06000CB1 RID: 3249 RVA: 0x000379AC File Offset: 0x00035BAC
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

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00037A20 File Offset: 0x00035C20
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

			// Token: 0x06000CB3 RID: 3251 RVA: 0x00037A78 File Offset: 0x00035C78
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

			// Token: 0x06000CB4 RID: 3252 RVA: 0x00037AA7 File Offset: 0x00035CA7
			internal void SetCells(global::Infragistics.Windows.DataPresenter.SelectedCellCollection newCells)
			{
				this._cells = newCells;
				if (this._cells != null && this._cells.Owner == null)
				{
					this._cells.Initialize(this);
				}
				base.RaisePropertyChangedEvent("Cells");
			}

			// Token: 0x06000CB5 RID: 3253 RVA: 0x00037ADC File Offset: 0x00035CDC
			internal void SetFields(global::Infragistics.Windows.DataPresenter.SelectedFieldCollection newFields)
			{
				this._fields = newFields;
				if (this._fields != null && this._fields.Owner == null)
				{
					this._fields.Initialize(this);
				}
				base.RaisePropertyChangedEvent("Fields");
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x00037B11 File Offset: 0x00035D11
			internal void SetRecords(global::Infragistics.Windows.DataPresenter.SelectedRecordCollection newRecords)
			{
				this._records = newRecords;
				if (this._records != null && this._records.Owner == null)
				{
					this._records.Initialize(this);
				}
				base.RaisePropertyChangedEvent("Records");
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x00037B46 File Offset: 0x00035D46
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Selection.ISelectableItem> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Selection.ISelectableItem>.GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator(this);
			}

			// Token: 0x06000CB8 RID: 3256 RVA: 0x00037B4E File Offset: 0x00035D4E
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator(this);
			}

			// Token: 0x040004C4 RID: 1220
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;

			// Token: 0x040004C5 RID: 1221
			private global::Infragistics.Windows.DataPresenter.SelectedRecordCollection _records;

			// Token: 0x040004C6 RID: 1222
			private global::Infragistics.Windows.DataPresenter.SelectedFieldCollection _fields;

			// Token: 0x040004C7 RID: 1223
			private global::Infragistics.Windows.DataPresenter.SelectedCellCollection _cells;

			// Token: 0x020000D4 RID: 212
			internal class SelectionPositionSortComparer : global::System.Collections.IComparer
			{
				// Token: 0x06000CB9 RID: 3257 RVA: 0x00037B56 File Offset: 0x00035D56
				internal SelectionPositionSortComparer()
				{
				}

				// Token: 0x06000CBA RID: 3258 RVA: 0x00037B60 File Offset: 0x00035D60
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

				// Token: 0x06000CBB RID: 3259 RVA: 0x00037BA0 File Offset: 0x00035DA0
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
							return cell.Field.Index.CompareTo(cell2.Field.Index);
						}
						return num;
					}
					else
					{
						if (x is global::Infragistics.Windows.DataPresenter.Field && y is global::Infragistics.Windows.DataPresenter.Field)
						{
							global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)x;
							global::Infragistics.Windows.DataPresenter.Field field2 = (global::Infragistics.Windows.DataPresenter.Field)y;
							return field.Index.CompareTo(field2.Index);
						}
						throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_11"));
					}
				}
			}

			// Token: 0x020000D5 RID: 213
			private class SelectableItemEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Selection.ISelectableItem>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000CBC RID: 3260 RVA: 0x00037CA7 File Offset: 0x00035EA7
				internal SelectableItemEnumerator(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder)
				{
					this._selectedItemHolder = selectedItemHolder;
					this._currentPosition = -1;
					this._currentItem = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator.UnsetObjectMarker;
				}

				// Token: 0x06000CBD RID: 3261 RVA: 0x00037CC8 File Offset: 0x00035EC8
				public void Dispose()
				{
					this.Reset();
				}

				// Token: 0x170002B4 RID: 692
				// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00037CD0 File Offset: 0x00035ED0
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

				// Token: 0x06000CBF RID: 3263 RVA: 0x00037D20 File Offset: 0x00035F20
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

				// Token: 0x06000CC0 RID: 3264 RVA: 0x00037D7E File Offset: 0x00035F7E
				public void Reset()
				{
					this._currentPosition = -1;
					this._currentItem = global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectableItemEnumerator.UnsetObjectMarker;
				}

				// Token: 0x170002B5 RID: 693
				// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00037D92 File Offset: 0x00035F92
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x040004C8 RID: 1224
				private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _selectedItemHolder;

				// Token: 0x040004C9 RID: 1225
				private int _currentPosition;

				// Token: 0x040004CA RID: 1226
				private object _currentItem;

				// Token: 0x040004CB RID: 1227
				private static object UnsetObjectMarker = new object();
			}
		}

		// Token: 0x020000D6 RID: 214
		private class DrillDownStackItem
		{
			// Token: 0x06000CC3 RID: 3267 RVA: 0x00037DA6 File Offset: 0x00035FA6
			internal DrillDownStackItem(global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl, global::System.Windows.Point recordListControlOffset, global::Infragistics.Windows.DataPresenter.Record expandedRecord, global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter, global::System.Windows.FrameworkElement container)
			{
				this._recordListControl = recordListControl;
				this._recordListControlOffset = recordListControlOffset;
				this._expandedRecord = expandedRecord;
				this._recordPresenter = recordPresenter;
				this._container = container;
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00037DD3 File Offset: 0x00035FD3
			internal global::System.Windows.FrameworkElement Container
			{
				get
				{
					return this._container;
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00037DDB File Offset: 0x00035FDB
			internal global::Infragistics.Windows.DataPresenter.Record ExpandedRecord
			{
				get
				{
					return this._expandedRecord;
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00037DE3 File Offset: 0x00035FE3
			internal global::Infragistics.Windows.DataPresenter.RecordPresenter RecordPresenter
			{
				get
				{
					return this._recordPresenter;
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00037DEB File Offset: 0x00035FEB
			internal global::Infragistics.Windows.DataPresenter.RecordListControl RecordListControl
			{
				get
				{
					return this._recordListControl;
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00037DF3 File Offset: 0x00035FF3
			internal global::System.Windows.Point RecordListControlOffset
			{
				get
				{
					return this._recordListControlOffset;
				}
			}

			// Token: 0x040004CC RID: 1228
			private global::Infragistics.Windows.DataPresenter.RecordListControl _recordListControl;

			// Token: 0x040004CD RID: 1229
			private global::System.Windows.Point _recordListControlOffset;

			// Token: 0x040004CE RID: 1230
			private global::Infragistics.Windows.DataPresenter.Record _expandedRecord;

			// Token: 0x040004CF RID: 1231
			private global::Infragistics.Windows.DataPresenter.RecordPresenter _recordPresenter;

			// Token: 0x040004D0 RID: 1232
			private global::System.Windows.FrameworkElement _container;
		}

		// Token: 0x020000D7 RID: 215
		private class DrillActionItem
		{
			// Token: 0x06000CC9 RID: 3273 RVA: 0x00037DFB File Offset: 0x00035FFB
			internal DrillActionItem(bool expand, global::Infragistics.Windows.DataPresenter.Record record)
			{
				this._expand = expand;
				this._record = record;
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00037E11 File Offset: 0x00036011
			internal bool Expand
			{
				get
				{
					return this._expand;
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00037E19 File Offset: 0x00036019
			internal global::Infragistics.Windows.DataPresenter.Record Record
			{
				get
				{
					return this._record;
				}
			}

			// Token: 0x040004D1 RID: 1233
			private bool _expand;

			// Token: 0x040004D2 RID: 1234
			private global::Infragistics.Windows.DataPresenter.Record _record;
		}

		// Token: 0x020000D8 RID: 216
		private class ListBoxPanelSettings
		{
			// Token: 0x06000CCC RID: 3276 RVA: 0x00037E21 File Offset: 0x00036021
			internal ListBoxPanelSettings()
			{
			}

			// Token: 0x040004D3 RID: 1235
			internal int LayoutVersion = -1;

			// Token: 0x040004D4 RID: 1236
			internal global::System.Windows.Controls.Panel Panel;
		}

		// Token: 0x020000D9 RID: 217
		internal abstract class FieldSettingsStyleSelector : global::System.Windows.Controls.StyleSelector
		{
			// Token: 0x06000CCD RID: 3277 RVA: 0x00037E30 File Offset: 0x00036030
			protected FieldSettingsStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter, global::System.Windows.DependencyProperty styleProperty, global::System.Windows.DependencyProperty selectorProperty, global::System.Type elementType)
			{
				this._presenter = presenter;
				this._styleProperty = styleProperty;
				this._selectorProperty = selectorProperty;
				this._elementType = elementType;
			}

			// Token: 0x06000CCE RID: 3278 RVA: 0x00037E58 File Offset: 0x00036058
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

			// Token: 0x06000CCF RID: 3279 RVA: 0x00037E9C File Offset: 0x0003609C
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

			// Token: 0x040004D5 RID: 1237
			internal readonly global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

			// Token: 0x040004D6 RID: 1238
			private global::System.Windows.DependencyProperty _styleProperty;

			// Token: 0x040004D7 RID: 1239
			private global::System.Windows.DependencyProperty _selectorProperty;

			// Token: 0x040004D8 RID: 1240
			private global::System.Type _elementType;
		}

		// Token: 0x020000DA RID: 218
		internal abstract class FieldLayoutSettingsStyleSelector : global::System.Windows.Controls.StyleSelector
		{
			// Token: 0x06000CD0 RID: 3280 RVA: 0x00037F39 File Offset: 0x00036139
			protected FieldLayoutSettingsStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter, global::System.Windows.DependencyProperty styleProperty, global::System.Windows.DependencyProperty selectorProperty, global::System.Type elementType)
			{
				this._presenter = presenter;
				this._styleProperty = styleProperty;
				this._selectorProperty = selectorProperty;
				this._elementType = elementType;
			}

			// Token: 0x06000CD1 RID: 3281 RVA: 0x00037F60 File Offset: 0x00036160
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

			// Token: 0x06000CD2 RID: 3282 RVA: 0x00037FAC File Offset: 0x000361AC
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

			// Token: 0x040004D9 RID: 1241
			internal readonly global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

			// Token: 0x040004DA RID: 1242
			private global::System.Windows.DependencyProperty _styleProperty;

			// Token: 0x040004DB RID: 1243
			private global::System.Windows.DependencyProperty _selectorProperty;

			// Token: 0x040004DC RID: 1244
			private global::System.Type _elementType;
		}

		// Token: 0x020000DB RID: 219
		internal class DPCellPresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x06000CD3 RID: 3283 RVA: 0x0003801F File Offset: 0x0003621F
			internal DPCellPresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.CellPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.CellPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.CellPresenter))
			{
			}

			// Token: 0x06000CD4 RID: 3284 RVA: 0x0003803C File Offset: 0x0003623C
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

			// Token: 0x06000CD5 RID: 3285 RVA: 0x0003806C File Offset: 0x0003626C
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

		// Token: 0x020000DC RID: 220
		internal class DPCellValuePresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x06000CD6 RID: 3286 RVA: 0x000380D4 File Offset: 0x000362D4
			internal DPCellValuePresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.CellValuePresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.CellValuePresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.CellValuePresenter))
			{
			}

			// Token: 0x06000CD7 RID: 3287 RVA: 0x000380F4 File Offset: 0x000362F4
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

			// Token: 0x06000CD8 RID: 3288 RVA: 0x00038124 File Offset: 0x00036324
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
				return base.SelectStyle(field, null, item, container);
			}
		}

		// Token: 0x020000DD RID: 221
		internal class DPEditorStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x06000CD9 RID: 3289 RVA: 0x0003818C File Offset: 0x0003638C
			internal DPEditorStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.EditorStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.EditorStyleSelectorProperty, null)
			{
			}

			// Token: 0x06000CDA RID: 3290 RVA: 0x000381A0 File Offset: 0x000363A0
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

			// Token: 0x06000CDB RID: 3291 RVA: 0x000381D0 File Offset: 0x000363D0
			public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
			{
				global::System.Windows.Style style = this.SelectStyleHelper(item, container);
				if (style != null)
				{
					global::Infragistics.Windows.Utilities.ValidateTargetTypeOfStyle(style, typeof(global::Infragistics.Windows.Editors.ValueEditor), "EditorStyle");
				}
				return style;
			}

			// Token: 0x06000CDC RID: 3292 RVA: 0x00038200 File Offset: 0x00036400
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
				return base.SelectStyle(field, null, item, container);
			}
		}

		// Token: 0x020000DE RID: 222
		internal class DPExpandedCellStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x06000CDD RID: 3293 RVA: 0x0003826E File Offset: 0x0003646E
			internal DPExpandedCellStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandedCellStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandedCellStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.ExpandedCellPresenter))
			{
			}

			// Token: 0x06000CDE RID: 3294 RVA: 0x0003828C File Offset: 0x0003648C
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

		// Token: 0x020000DF RID: 223
		internal class DPLabelPresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
		{
			// Token: 0x06000CDF RID: 3295 RVA: 0x000382FA File Offset: 0x000364FA
			internal DPLabelPresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.LabelPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.LabelPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.LabelPresenter))
			{
			}

			// Token: 0x06000CE0 RID: 3296 RVA: 0x00038318 File Offset: 0x00036518
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

			// Token: 0x06000CE1 RID: 3297 RVA: 0x00038348 File Offset: 0x00036548
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

		// Token: 0x020000E0 RID: 224
		internal class DPHeaderPresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06000CE2 RID: 3298 RVA: 0x000383B6 File Offset: 0x000365B6
			internal DPHeaderPresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPresenterStyleProperty, null, typeof(global::Infragistics.Windows.DataPresenter.HeaderPresenter))
			{
			}

			// Token: 0x06000CE3 RID: 3299 RVA: 0x000383D0 File Offset: 0x000365D0
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

		// Token: 0x020000E1 RID: 225
		internal class DPHeaderLabelAreaStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06000CE4 RID: 3300 RVA: 0x00038409 File Offset: 0x00036609
			internal DPHeaderLabelAreaStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderLabelAreaStyleProperty, null, typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea))
			{
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x00038424 File Offset: 0x00036624
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

		// Token: 0x020000E2 RID: 226
		internal class DPHeaderPrefixAreaStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06000CE6 RID: 3302 RVA: 0x0003848E File Offset: 0x0003668E
			internal DPHeaderPrefixAreaStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.HeaderPrefixAreaStyleProperty, null, typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea))
			{
			}

			// Token: 0x06000CE7 RID: 3303 RVA: 0x000384A8 File Offset: 0x000366A8
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

		// Token: 0x020000E3 RID: 227
		internal class DPRecordPresenterStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06000CE8 RID: 3304 RVA: 0x00038512 File Offset: 0x00036712
			internal DPRecordPresenterStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter))
			{
				this.groupBySelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector.GroupByRecordStyleSelector(presenter);
				this.expandableSelector = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector.ExpandableFieldRecordStyleSelector(presenter);
			}

			// Token: 0x06000CE9 RID: 3305 RVA: 0x00038548 File Offset: 0x00036748
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

			// Token: 0x06000CEA RID: 3306 RVA: 0x000385FF File Offset: 0x000367FF
			private global::System.Windows.Style SelectSummaryPresenterStyle(global::Infragistics.Windows.DataPresenter.Record record, global::System.Windows.DependencyObject container)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
				return this._presenter.GetDefaultStyle(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter));
			}

			// Token: 0x040004DD RID: 1245
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector.GroupByRecordStyleSelector groupBySelector;

			// Token: 0x040004DE RID: 1246
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase.DPRecordPresenterStyleSelector.ExpandableFieldRecordStyleSelector expandableSelector;

			// Token: 0x020000E4 RID: 228
			private class GroupByRecordStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
			{
				// Token: 0x06000CEB RID: 3307 RVA: 0x0003861D File Offset: 0x0003681D
				internal GroupByRecordStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByRecordPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.GroupByRecordPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter))
				{
				}

				// Token: 0x06000CEC RID: 3308 RVA: 0x0003863C File Offset: 0x0003683C
				public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
				{
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = item as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					global::Infragistics.Windows.DataPresenter.Field associatedField = groupByRecord.AssociatedField;
					return base.SelectStyle(associatedField, groupByRecord.FieldLayout, item, container);
				}
			}

			// Token: 0x020000E5 RID: 229
			private class ExpandableFieldRecordStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldSettingsStyleSelector
			{
				// Token: 0x06000CED RID: 3309 RVA: 0x00038666 File Offset: 0x00036866
				internal ExpandableFieldRecordStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordPresenterStyleProperty, global::Infragistics.Windows.DataPresenter.FieldSettings.ExpandableFieldRecordPresenterStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter))
				{
				}

				// Token: 0x06000CEE RID: 3310 RVA: 0x00038684 File Offset: 0x00036884
				public override global::System.Windows.Style SelectStyle(object item, global::System.Windows.DependencyObject container)
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = item as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
					global::Infragistics.Windows.DataPresenter.Field associatedField = expandableFieldRecord.AssociatedField;
					return base.SelectStyle(associatedField, expandableFieldRecord.FieldLayout, item, container);
				}
			}
		}

		// Token: 0x020000E6 RID: 230
		internal class DPRecordSelectorStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06000CEF RID: 3311 RVA: 0x000386AE File Offset: 0x000368AE
			internal DPRecordSelectorStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorStyleProperty, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.RecordSelectorStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.RecordSelector))
			{
			}

			// Token: 0x06000CF0 RID: 3312 RVA: 0x000386CC File Offset: 0x000368CC
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

		// Token: 0x020000E7 RID: 231
		internal class DPRecordCellAreaStyleSelector : global::Infragistics.Windows.DataPresenter.DataPresenterBase.FieldLayoutSettingsStyleSelector
		{
			// Token: 0x06000CF1 RID: 3313 RVA: 0x00038736 File Offset: 0x00036936
			internal DPRecordCellAreaStyleSelector(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter) : base(presenter, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaStyleProperty, global::Infragistics.Windows.DataPresenter.FieldLayoutSettings.DataRecordCellAreaStyleSelectorProperty, typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea))
			{
			}

			// Token: 0x06000CF2 RID: 3314 RVA: 0x00038754 File Offset: 0x00036954
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

		// Token: 0x020000E8 RID: 232
		private class AsyncPageCommand
		{
			// Token: 0x06000CF3 RID: 3315 RVA: 0x000387BE File Offset: 0x000369BE
			internal AsyncPageCommand(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
			{
				this._dp = dp;
				this._dp.LayoutUpdated += this.OnLayoutUpdated;
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x000387E4 File Offset: 0x000369E4
			// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x000387EC File Offset: 0x000369EC
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

			// Token: 0x06000CF6 RID: 3318 RVA: 0x000387F5 File Offset: 0x000369F5
			internal void Detach()
			{
				this._dp.LayoutUpdated -= this.OnLayoutUpdated;
			}

			// Token: 0x06000CF7 RID: 3319 RVA: 0x0003880E File Offset: 0x00036A0E
			private void OnLayoutUpdated(object sender, global::System.EventArgs e)
			{
				this.Detach();
				this._dp.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.ProcessCommand));
			}

			// Token: 0x06000CF8 RID: 3320 RVA: 0x00038834 File Offset: 0x00036A34
			private void ProcessCommand()
			{
				this._dp.ApplyAsyncCommand(this);
			}

			// Token: 0x040004DF RID: 1247
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;

			// Token: 0x040004E0 RID: 1248
			private global::System.Windows.Input.RoutedCommand _command;
		}

		// Token: 0x020000E9 RID: 233
		private class KeyDownInfo
		{
			// Token: 0x06000CF9 RID: 3321 RVA: 0x00038842 File Offset: 0x00036A42
			internal KeyDownInfo(global::System.Windows.Input.Key key, global::System.Windows.Input.ModifierKeys modifiers)
			{
				this._tickCount = global::System.Environment.TickCount;
				this._key = key;
				this._modifiers = modifiers;
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00038863 File Offset: 0x00036A63
			// (set) Token: 0x06000CFB RID: 3323 RVA: 0x0003886B File Offset: 0x00036A6B
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

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00038874 File Offset: 0x00036A74
			// (set) Token: 0x06000CFD RID: 3325 RVA: 0x0003887C File Offset: 0x00036A7C
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

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00038885 File Offset: 0x00036A85
			// (set) Token: 0x06000CFF RID: 3327 RVA: 0x0003888D File Offset: 0x00036A8D
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

			// Token: 0x040004E1 RID: 1249
			private int _tickCount;

			// Token: 0x040004E2 RID: 1250
			private global::System.Windows.Input.Key _key;

			// Token: 0x040004E3 RID: 1251
			private global::System.Windows.Input.ModifierKeys _modifiers;
		}

		// Token: 0x020000EA RID: 234
		private class RecordSelectionEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06000D00 RID: 3328 RVA: 0x00038896 File Offset: 0x00036A96
			internal RecordSelectionEnumerator(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.Record pivotRcd, bool forward)
			{
				this._record = record;
				this._pivotRcd = pivotRcd;
				this._forward = forward;
				this._step = (forward ? 1 : -1);
				this.Reset();
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000388C6 File Offset: 0x00036AC6
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

			// Token: 0x06000D02 RID: 3330 RVA: 0x00038900 File Offset: 0x00036B00
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
				this._currentIndex += this._step;
				if (this._currentIndex >= 0 && this._currentIndex < this._currentCollection.Count)
				{
					this._currentRecord = this._currentCollection[this._currentIndex];
				}
				else
				{
					if (this._currentRecord == null)
					{
						this._currentRecord = this._pivotRcd;
					}
					this._currentRecord = this._currentRecord.GetCrossParentSibling(this._forward);
					if (this._currentRecord == null)
					{
						this._eofReached = true;
						return false;
					}
					this._currentIndex = this._currentRecord.Index;
					this._currentCollection = this._currentRecord.ParentCollection;
				}
				return true;
			}

			// Token: 0x06000D03 RID: 3331 RVA: 0x000389EA File Offset: 0x00036BEA
			public void Reset()
			{
				this._currentRecord = null;
				this._currentIndex = this._pivotRcd.Index;
				this._currentCollection = this._pivotRcd.ParentCollection;
				this._eofReached = false;
			}

			// Token: 0x040004E4 RID: 1252
			private global::Infragistics.Windows.DataPresenter.Record _record;

			// Token: 0x040004E5 RID: 1253
			private global::Infragistics.Windows.DataPresenter.Record _pivotRcd;

			// Token: 0x040004E6 RID: 1254
			private global::Infragistics.Windows.DataPresenter.Record _currentRecord;

			// Token: 0x040004E7 RID: 1255
			private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _currentCollection;

			// Token: 0x040004E8 RID: 1256
			private bool _forward;

			// Token: 0x040004E9 RID: 1257
			private bool _eofReached;

			// Token: 0x040004EA RID: 1258
			private int _step;

			// Token: 0x040004EB RID: 1259
			private int _currentIndex;
		}

		// Token: 0x020000EB RID: 235
		private class FixedAreaScrollHelper
		{
			// Token: 0x06000D04 RID: 3332 RVA: 0x00038A1C File Offset: 0x00036C1C
			internal FixedAreaScrollHelper(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner)
			{
				this._owner = owner;
			}

			// Token: 0x06000D05 RID: 3333 RVA: 0x00038A2C File Offset: 0x00036C2C
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

			// Token: 0x06000D06 RID: 3334 RVA: 0x00038A7C File Offset: 0x00036C7C
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

			// Token: 0x06000D07 RID: 3335 RVA: 0x00038C7C File Offset: 0x00036E7C
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

			// Token: 0x06000D08 RID: 3336 RVA: 0x00038CE8 File Offset: 0x00036EE8
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

			// Token: 0x06000D09 RID: 3337 RVA: 0x00038EB4 File Offset: 0x000370B4
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

			// Token: 0x040004EC RID: 1260
			private global::Infragistics.Windows.DataPresenter.FixedRecordLocation? _pivotFixedRecordLocation;

			// Token: 0x040004ED RID: 1261
			private global::Infragistics.Windows.DataPresenter.FixedFieldLocation? _pivotFixedFieldLocation;

			// Token: 0x040004EE RID: 1262
			private global::Infragistics.Windows.DataPresenter.FixedRecordLocation? _pivotFixedRecordLocationCell;

			// Token: 0x040004EF RID: 1263
			private global::Infragistics.Windows.DataPresenter.FixedFieldLocation? _pivotFixedFieldLocationCell;

			// Token: 0x040004F0 RID: 1264
			private global::Infragistics.Windows.DataPresenter.DataPresenterBase _owner;

			// Token: 0x040004F1 RID: 1265
			private bool _isInitialCellFieldScrollPending;

			// Token: 0x040004F2 RID: 1266
			private bool _isInitialCellRecordScrollPending;

			// Token: 0x040004F3 RID: 1267
			private bool _isInitialRecordScrollPending;

			// Token: 0x040004F4 RID: 1268
			private bool _isInitialFieldScrollPending;
		}
	}
}
