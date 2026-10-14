using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000CB RID: 203
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FieldDragIndicator : global::System.Windows.Controls.Control
	{
		// Token: 0x060009B0 RID: 2480 RVA: 0x000296B4 File Offset: 0x000278B4
		static FieldDragIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x000297C8 File Offset: 0x000279C8
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x000297DA File Offset: 0x000279DA
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

		// Token: 0x060009B4 RID: 2484 RVA: 0x000297E8 File Offset: 0x000279E8
		private static void OnFieldChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)e.NewValue;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000297F7 File Offset: 0x000279F7
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00029809 File Offset: 0x00027A09
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

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0002981C File Offset: 0x00027A1C
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x0002982E File Offset: 0x00027A2E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00029841 File Offset: 0x00027A41
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00029853 File Offset: 0x00027A53
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x040003DB RID: 987
		public static readonly global::System.Windows.DependencyProperty FieldProperty = global::System.Windows.DependencyProperty.Register("Field", typeof(global::Infragistics.Windows.DataPresenter.Field), typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.FieldDragIndicator.OnFieldChanged)));

		// Token: 0x040003DC RID: 988
		public static readonly global::System.Windows.DependencyProperty IncludeCellProperty = global::System.Windows.DependencyProperty.Register("IncludeCell", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040003DD RID: 989
		public static readonly global::System.Windows.DependencyProperty IsSourceFromFieldChooserProperty = global::System.Windows.DependencyProperty.Register("IsSourceFromFieldChooser", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x040003DE RID: 990
		public static readonly global::System.Windows.DependencyProperty IsSourceFromGroupByAreaProperty = global::System.Windows.DependencyProperty.Register("IsSourceFromGroupByArea", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.FieldDragIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));
	}
}
