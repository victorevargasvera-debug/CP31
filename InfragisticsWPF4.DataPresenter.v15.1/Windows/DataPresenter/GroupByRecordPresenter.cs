using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200036A RID: 874
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByRecordPresenter : global::Infragistics.Windows.DataPresenter.RecordPresenter
	{
		// Token: 0x06002A9C RID: 10908 RVA: 0x000BE35C File Offset: 0x000BC55C
		static GroupByRecordPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter)));
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x000BE3E0 File Offset: 0x000BC5E0
		internal override global::System.Windows.Controls.ControlTemplate GetDefaultTemplateProperty(global::System.Windows.DependencyProperty templateProperty)
		{
			if (!global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplatesCached)
			{
				lock (typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter))
				{
					if (!global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplatesCached)
					{
						global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplatesCached = true;
						global::System.Windows.Style groupByRecordPresenter = global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>.GroupByRecordPresenter;
						if (groupByRecordPresenter != null)
						{
							global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplate = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(groupByRecordPresenter, global::System.Windows.Controls.Control.TemplateProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
							global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplateTabluar = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(groupByRecordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
							global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplateCardView = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(groupByRecordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
						}
					}
				}
			}
			if (templateProperty == global::System.Windows.Controls.Control.TemplateProperty)
			{
				return global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplate;
			}
			if (templateProperty == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty)
			{
				return global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplateTabluar;
			}
			if (templateProperty == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty)
			{
				return global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.s_DefaultTemplateCardView;
			}
			return null;
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x000BE4AC File Offset: 0x000BC6AC
		internal override string GetRecordDescription()
		{
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = base.Record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			if (groupByRecord == null)
			{
				return null;
			}
			return groupByRecord.DescriptionWithSummaries;
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x000BE4D0 File Offset: 0x000BC6D0
		public override void OnApplyTemplate()
		{
			if (base.Tag == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateRecordPresenterId)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				if (fieldLayout != null)
				{
					fieldLayout.TemplateDataRecordCache.OnTemplateRecordTemplateChanged(this);
				}
			}
			base.OnApplyTemplate();
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x000BE508 File Offset: 0x000BC708
		protected override void OnRecordChanged(global::Infragistics.Windows.DataPresenter.Record oldRecord, global::Infragistics.Windows.DataPresenter.Record newRecord)
		{
			base.OnRecordChanged(oldRecord, newRecord);
			this.UpdateShouldDisplaySummaries();
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = newRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			global::Infragistics.Windows.DataPresenter.Field field = (groupByRecord != null) ? groupByRecord.GroupByField : null;
			if (field == null)
			{
				this._styleTracker = null;
				return;
			}
			this._styleTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(field, "GroupByRecordPresenterStyleResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnStyleSettingChanged), true);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000BE560 File Offset: 0x000BC760
		protected override void OnRecordPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnRecordPropertyChanged(e);
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "IsExpanded"))
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = base.Record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord != null && groupByRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout && groupByRecord.ScrollCountInternal == 1)
				{
					base.InvalidateGridViewPanelFlat();
				}
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002AA2 RID: 10914 RVA: 0x000BE5B3 File Offset: 0x000BC7B3
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool ShouldDisplaySummaryCells
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.ShouldDisplaySummaryCellsProperty);
			}
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000BE5C5 File Offset: 0x000BC7C5
		private void OnStyleSettingChanged()
		{
			base.InvalidateStyle();
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000BE5D0 File Offset: 0x000BC7D0
		internal void UpdateShouldDisplaySummaries()
		{
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = base.Record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			bool flag = global::Infragistics.Windows.DataPresenter.GroupByRecord.ShouldDisplaySummaries(groupByRecord);
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.ShouldDisplaySummaryCellsPropertyKey, flag);
		}

		// Token: 0x04001492 RID: 5266
		private global::Infragistics.Windows.Internal.PropertyValueTracker _styleTracker;

		// Token: 0x04001493 RID: 5267
		private static bool s_DefaultTemplatesCached = false;

		// Token: 0x04001494 RID: 5268
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplate = null;

		// Token: 0x04001495 RID: 5269
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateTabluar = null;

		// Token: 0x04001496 RID: 5270
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateCardView = null;

		// Token: 0x04001497 RID: 5271
		private static readonly global::System.Windows.DependencyPropertyKey ShouldDisplaySummaryCellsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ShouldDisplaySummaryCells", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04001498 RID: 5272
		public static readonly global::System.Windows.DependencyProperty ShouldDisplaySummaryCellsProperty = global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.ShouldDisplaySummaryCellsPropertyKey.DependencyProperty;
	}
}
