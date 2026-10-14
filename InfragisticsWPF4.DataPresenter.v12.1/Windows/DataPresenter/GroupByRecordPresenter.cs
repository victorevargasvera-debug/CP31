using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000329 RID: 809
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GroupByRecordPresenter : global::Infragistics.Windows.DataPresenter.RecordPresenter
	{
		// Token: 0x060026DB RID: 9947 RVA: 0x000A99C0 File Offset: 0x000A7BC0
		static GroupByRecordPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter)));
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000A9A44 File Offset: 0x000A7C44
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

		// Token: 0x060026DD RID: 9949 RVA: 0x000A9B10 File Offset: 0x000A7D10
		internal override string GetRecordDescription()
		{
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = base.Record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			if (groupByRecord == null)
			{
				return null;
			}
			return groupByRecord.DescriptionWithSummaries;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x000A9B34 File Offset: 0x000A7D34
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

		// Token: 0x060026DF RID: 9951 RVA: 0x000A9B6C File Offset: 0x000A7D6C
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

		// Token: 0x060026E0 RID: 9952 RVA: 0x000A9BC4 File Offset: 0x000A7DC4
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

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000A9C17 File Offset: 0x000A7E17
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public bool ShouldDisplaySummaryCells
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.ShouldDisplaySummaryCellsProperty);
			}
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000A9C29 File Offset: 0x000A7E29
		private void OnStyleSettingChanged()
		{
			base.InvalidateStyle();
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x000A9C34 File Offset: 0x000A7E34
		internal void UpdateShouldDisplaySummaries()
		{
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = base.Record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			bool flag = global::Infragistics.Windows.DataPresenter.GroupByRecord.ShouldDisplaySummaries(groupByRecord);
			base.SetValue(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.ShouldDisplaySummaryCellsPropertyKey, flag);
		}

		// Token: 0x0400126F RID: 4719
		private global::Infragistics.Windows.Internal.PropertyValueTracker _styleTracker;

		// Token: 0x04001270 RID: 4720
		private static bool s_DefaultTemplatesCached = false;

		// Token: 0x04001271 RID: 4721
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplate = null;

		// Token: 0x04001272 RID: 4722
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateTabluar = null;

		// Token: 0x04001273 RID: 4723
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateCardView = null;

		// Token: 0x04001274 RID: 4724
		private static readonly global::System.Windows.DependencyPropertyKey ShouldDisplaySummaryCellsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ShouldDisplaySummaryCells", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04001275 RID: 4725
		public static readonly global::System.Windows.DependencyProperty ShouldDisplaySummaryCellsProperty = global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter.ShouldDisplaySummaryCellsPropertyKey.DependencyProperty;
	}
}
