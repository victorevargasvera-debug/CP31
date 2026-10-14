using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D4 RID: 468
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordPresenter : global::Infragistics.Windows.DataPresenter.RecordPresenter
	{
		// Token: 0x06001BF5 RID: 7157 RVA: 0x0007E630 File Offset: 0x0007C830
		static SummaryRecordPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0007E728 File Offset: 0x0007C928
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

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0007E7F4 File Offset: 0x0007C9F4
		internal override global::System.Windows.DataTemplate GetRecordContentAreaTemplate(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator generator)
		{
			return generator.GeneratedSummaryRecordContentAreaTemplate;
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0007E7FC File Offset: 0x0007C9FC
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.InitializeContentAreaMarginBinding(this, base.Record, base.GetType());
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0007E816 File Offset: 0x0007CA16
		protected override void OnRecordChanged(global::Infragistics.Windows.DataPresenter.Record oldRecord, global::Infragistics.Windows.DataPresenter.Record newRecord)
		{
			base.OnRecordChanged(oldRecord, newRecord);
			this._cachedSummaryRecord = (newRecord as global::Infragistics.Windows.DataPresenter.SummaryRecord);
			base.SetValue(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.SummaryRecordPropertyKey, newRecord);
			global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.InitializeContentAreaMarginBinding(this, base.Record, base.GetType());
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0007E84A File Offset: 0x0007CA4A
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

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x0007E867 File Offset: 0x0007CA67
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x0007E879 File Offset: 0x0007CA79
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

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x0007E88C File Offset: 0x0007CA8C
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x0007E89E File Offset: 0x0007CA9E
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

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x0007E8AC File Offset: 0x0007CAAC
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.SummaryRecord SummaryRecord
		{
			get
			{
				return this._cachedSummaryRecord;
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0007E8B4 File Offset: 0x0007CAB4
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

		// Token: 0x04000B7C RID: 2940
		private global::Infragistics.Windows.DataPresenter.SummaryRecord _cachedSummaryRecord;

		// Token: 0x04000B7D RID: 2941
		private static bool s_DefaultTemplatesCached = false;

		// Token: 0x04000B7E RID: 2942
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplate = null;

		// Token: 0x04000B7F RID: 2943
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateTabluar = null;

		// Token: 0x04000B80 RID: 2944
		private static global::System.Windows.Controls.ControlTemplate s_DefaultTemplateCardView = null;

		// Token: 0x04000B81 RID: 2945
		public static readonly global::System.Windows.DependencyProperty ContentAreaMarginsProperty = global::System.Windows.DependencyProperty.Register("ContentAreaMargins", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000B82 RID: 2946
		public static readonly global::System.Windows.DependencyProperty HeaderAreaBackgroundProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HeaderAreaBackgroundProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter));

		// Token: 0x04000B83 RID: 2947
		private static readonly global::System.Windows.DependencyPropertyKey SummaryRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SummaryRecord", typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord), typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000B84 RID: 2948
		public static readonly global::System.Windows.DependencyProperty SummaryRecordProperty = global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter.SummaryRecordPropertyKey.DependencyProperty;
	}
}
