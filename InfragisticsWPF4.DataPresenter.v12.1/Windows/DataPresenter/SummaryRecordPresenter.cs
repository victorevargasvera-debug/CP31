using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001B1 RID: 433
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordPresenter : global::Infragistics.Windows.DataPresenter.RecordPresenter
	{
		// Token: 0x06001831 RID: 6193 RVA: 0x0006B868 File Offset: 0x00069A68
		static SummaryRecordPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0006B960 File Offset: 0x00069B60
		internal override global::System.Windows.Controls.ControlTemplate GetDefaultTemplateProperty(global::System.Windows.DependencyProperty templateProperty)
		{
			if (!global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplatesCached)
			{
				lock (typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter))
				{
					if (!global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplatesCached)
					{
						global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplatesCached = true;
						global::System.Windows.Style summaryRecordPresenter = global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>.SummaryRecordPresenter;
						if (summaryRecordPresenter != null)
						{
							global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplate = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(summaryRecordPresenter, global::System.Windows.Controls.Control.TemplateProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
							global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplateTabluar = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(summaryRecordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
							global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplateCardView = (global::Infragistics.Windows.Utilities.GetPropertyValueFromStyle(summaryRecordPresenter, global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty, true, false) as global::System.Windows.Controls.ControlTemplate);
						}
					}
				}
			}
			if (templateProperty == global::System.Windows.Controls.Control.TemplateProperty)
			{
				return global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplate;
			}
			if (templateProperty == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateGridViewProperty)
			{
				return global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplateTabluar;
			}
			if (templateProperty == global::Infragistics.Windows.DataPresenter.RecordPresenter.TemplateCardViewProperty)
			{
				return global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.s_DefaultTemplateCardView;
			}
			return null;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0006BA2C File Offset: 0x00069C2C
		internal override global::System.Windows.DataTemplate GetRecordContentAreaTemplate(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator generator)
		{
			return generator.GeneratedSummaryRecordContentAreaTemplate;
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0006BA34 File Offset: 0x00069C34
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.InitializeContentAreaMarginBinding(this, base.Record, base.GetType());
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0006BA4E File Offset: 0x00069C4E
		protected override void OnRecordChanged(global::Infragistics.Windows.DataPresenter.Record oldRecord, global::Infragistics.Windows.DataPresenter.Record newRecord)
		{
			base.OnRecordChanged(oldRecord, newRecord);
			this._cachedSummaryRecord = (newRecord as global::Infragistics.Windows.DataPresenter.SummaryRecord);
			base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.SummaryRecordPropertyKey, newRecord);
			global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.InitializeContentAreaMarginBinding(this, base.Record, base.GetType());
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x0006BA82 File Offset: 0x00069C82
		internal override void UpdateAutoFitProperties()
		{
			if (!base.IsArrangedInView)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter.ClearAutoFitCellAreaProperties(this);
				return;
			}
			base.UpdateAutoFitProperties();
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter.UpdateAutoFitPropertiesHelper(this);
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x0006BA9F File Offset: 0x00069C9F
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x0006BAB1 File Offset: 0x00069CB1
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Thickness ContentAreaMargins
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.ContentAreaMarginsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.ContentAreaMarginsProperty, value);
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600183A RID: 6202 RVA: 0x0006BAC4 File Offset: 0x00069CC4
		// (set) Token: 0x0600183B RID: 6203 RVA: 0x0006BAD6 File Offset: 0x00069CD6
		public global::System.Windows.Media.Brush HeaderAreaBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HeaderAreaBackgroundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HeaderAreaBackgroundProperty, value);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x0006BAE4 File Offset: 0x00069CE4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.SummaryRecord SummaryRecord
		{
			get
			{
				return this._cachedSummaryRecord;
			}
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0006BAEC File Offset: 0x00069CEC
		internal static void InitializeContentAreaMarginBinding(global::System.Windows.Controls.Control control, global::Infragistics.Windows.DataPresenter.Record record, global::System.Type targetType)
		{
			if (record == null)
			{
				return;
			}
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(control, global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.ContentAreaMarginsProperty).BaseValueSource < global::System.Windows.BaseValueSource.Style)
			{
				control.SetBinding(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.ContentAreaMarginsProperty, global::Infragistics.Windows.DataPresenter.GridUtilities.CreateRecordContentMarginBinding(record.FieldLayout, false, targetType));
			}
		}

		// Token: 0x040009AE RID: 2478
		private global::Infragistics.Windows.DataPresenter.SummaryRecord _cachedSummaryRecord;

		// Token: 0x040009AF RID: 2479
		private static bool s_DefaultTemplatesCached = false;

		// Token: 0x040009B0 RID: 2480
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplate = null;

		// Token: 0x040009B1 RID: 2481
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateTabluar = null;

		// Token: 0x040009B2 RID: 2482
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateCardView = null;

		// Token: 0x040009B3 RID: 2483
		public static readonly global::System.Windows.DependencyProperty ContentAreaMarginsProperty = global::System.Windows.DependencyProperty.Register("ContentAreaMargins", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040009B4 RID: 2484
		public static readonly global::System.Windows.DependencyProperty HeaderAreaBackgroundProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HeaderAreaBackgroundProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter));

		// Token: 0x040009B5 RID: 2485
		private static readonly global::System.Windows.DependencyPropertyKey SummaryRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryRecord", typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040009B6 RID: 2486
		public static readonly global::System.Windows.DependencyProperty SummaryRecordProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.SummaryRecordPropertyKey.DependencyProperty;
	}
}
