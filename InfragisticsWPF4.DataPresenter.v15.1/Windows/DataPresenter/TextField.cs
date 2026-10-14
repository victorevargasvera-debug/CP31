using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000E6 RID: 230
	public class TextField : global::Infragistics.Windows.DataPresenter.TextFieldBase
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x000369F3 File Offset: 0x00034BF3
		protected override global::System.Type DefaultEditAsType
		{
			get
			{
				return typeof(string);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x000369FF File Offset: 0x00034BFF
		protected override global::System.Type DefaultEditorType
		{
			get
			{
				return typeof(global::Infragistics.Windows.Editors.XamTextEditor);
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00036A0B File Offset: 0x00034C0B
		private static void OnAcceptsReturnChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AcceptsReturn, e.NewValue);
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00036A20 File Offset: 0x00034C20
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00036A32 File Offset: 0x00034C32
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AcceptsReturn
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.TextField.AcceptsReturnProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TextField.AcceptsReturnProperty, value);
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00036A45 File Offset: 0x00034C45
		private static void OnAcceptsTabChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.AcceptsTab, e.NewValue);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x00036A5A File Offset: 0x00034C5A
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x00036A6C File Offset: 0x00034C6C
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.NullableBoolConverter))]
		public bool? AcceptsTab
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.TextField.AcceptsTabProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TextField.AcceptsTabProperty, value);
			}
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00036A7F File Offset: 0x00034C7F
		private static void OnHorizontalScrollBarVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.HorizontalScrollbarVisibility, e.NewValue);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00036A95 File Offset: 0x00034C95
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00036AA7 File Offset: 0x00034CA7
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Controls.ScrollBarVisibility>))]
		public global::System.Windows.Controls.ScrollBarVisibility? HorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility?)base.GetValue(global::Infragistics.Windows.DataPresenter.TextField.HorizontalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TextField.HorizontalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00036ABA File Offset: 0x00034CBA
		private static void OnTextAlignmentyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.TextAlignment, e.NewValue);
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00036AD0 File Offset: 0x00034CD0
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00036AE2 File Offset: 0x00034CE2
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.TextAlignment>))]
		public global::System.Windows.TextAlignment? TextAlignment
		{
			get
			{
				return (global::System.Windows.TextAlignment?)base.GetValue(global::Infragistics.Windows.DataPresenter.TextField.TextAlignmentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TextField.TextAlignmentProperty, value);
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00036AF5 File Offset: 0x00034CF5
		private static void OnTextWrappingyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.TextWrapping, e.NewValue);
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00036B0B File Offset: 0x00034D0B
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00036B1D File Offset: 0x00034D1D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.TextWrapping>))]
		public global::System.Windows.TextWrapping? TextWrapping
		{
			get
			{
				return (global::System.Windows.TextWrapping?)base.GetValue(global::Infragistics.Windows.DataPresenter.TextField.TextWrappingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TextField.TextWrappingProperty, value);
			}
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00036B30 File Offset: 0x00034D30
		private static void OnVerticalScrollBarVisibilityChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.Field.OnEditorPropChangedCallback(target as global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.Field.EditorPropId.VerticalScrollbarVisibility, e.NewValue);
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00036B46 File Offset: 0x00034D46
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x00036B58 File Offset: 0x00034D58
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Controls.ScrollBarVisibility>))]
		public global::System.Windows.Controls.ScrollBarVisibility? VerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility?)base.GetValue(global::Infragistics.Windows.DataPresenter.TextField.VerticalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TextField.VerticalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x0400051B RID: 1307
		public static readonly global::System.Windows.DependencyProperty AcceptsReturnProperty = global::System.Windows.DependencyProperty.Register("AcceptsReturn", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.TextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TextField.OnAcceptsReturnChanged)));

		// Token: 0x0400051C RID: 1308
		public static readonly global::System.Windows.DependencyProperty AcceptsTabProperty = global::System.Windows.DependencyProperty.Register("AcceptsTab", typeof(bool?), typeof(global::Infragistics.Windows.DataPresenter.TextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TextField.OnAcceptsTabChanged)));

		// Token: 0x0400051D RID: 1309
		public static readonly global::System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("HorizontalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility?), typeof(global::Infragistics.Windows.DataPresenter.TextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TextField.OnHorizontalScrollBarVisibilityChanged)));

		// Token: 0x0400051E RID: 1310
		public static readonly global::System.Windows.DependencyProperty TextAlignmentProperty = global::System.Windows.DependencyProperty.Register("TextAlignment", typeof(global::System.Windows.TextAlignment?), typeof(global::Infragistics.Windows.DataPresenter.TextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TextField.OnTextAlignmentyChanged)));

		// Token: 0x0400051F RID: 1311
		public static readonly global::System.Windows.DependencyProperty TextWrappingProperty = global::System.Windows.DependencyProperty.Register("TextWrapping", typeof(global::System.Windows.TextWrapping?), typeof(global::Infragistics.Windows.DataPresenter.TextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TextField.OnTextWrappingyChanged)));

		// Token: 0x04000520 RID: 1312
		public static readonly global::System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty = global::System.Windows.DependencyProperty.Register("VerticalScrollBarVisibility", typeof(global::System.Windows.Controls.ScrollBarVisibility?), typeof(global::Infragistics.Windows.DataPresenter.TextField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.TextField.OnVerticalScrollBarVisibilityChanged)));
	}
}
