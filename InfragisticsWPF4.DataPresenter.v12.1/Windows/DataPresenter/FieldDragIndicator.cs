using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000C2 RID: 194
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FieldDragIndicator : global::System.Windows.Controls.Control
	{
		// Token: 0x06000903 RID: 2307 RVA: 0x00025BCC File Offset: 0x00023DCC
		static FieldDragIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00025CE0 File Offset: 0x00023EE0
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x00025CF2 File Offset: 0x00023EF2
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.FieldProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.FieldProperty, value);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00025D00 File Offset: 0x00023F00
		private static void OnFieldChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)e.NewValue;
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00025D0F File Offset: 0x00023F0F
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00025D21 File Offset: 0x00023F21
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IncludeCell
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.IncludeCellProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.IncludeCellProperty, value);
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00025D34 File Offset: 0x00023F34
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00025D46 File Offset: 0x00023F46
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSourceFromFieldChooser
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.IsSourceFromFieldChooserProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.IsSourceFromFieldChooserProperty, value);
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00025D59 File Offset: 0x00023F59
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00025D6B File Offset: 0x00023F6B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSourceFromGroupByArea
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.IsSourceFromGroupByAreaProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.IsSourceFromGroupByAreaProperty, value);
			}
		}

		// Token: 0x0400037F RID: 895
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.OnFieldChanged)));

		// Token: 0x04000380 RID: 896
		public static readonly global::System.Windows.DependencyProperty IncludeCellProperty = global::System.Windows.DependencyProperty.Register("IncludeCell", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000381 RID: 897
		public static readonly global::System.Windows.DependencyProperty IsSourceFromFieldChooserProperty = global::System.Windows.DependencyProperty.Register("IsSourceFromFieldChooser", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000382 RID: 898
		public static readonly global::System.Windows.DependencyProperty IsSourceFromGroupByAreaProperty = global::System.Windows.DependencyProperty.Register("IsSourceFromGroupByArea", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));
	}
}
