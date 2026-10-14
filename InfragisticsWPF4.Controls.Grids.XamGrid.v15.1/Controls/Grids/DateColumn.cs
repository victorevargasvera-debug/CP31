using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200024A RID: 586
	public class DateColumn : global::Infragistics.Controls.Grids.DateColumnBase
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x00045438 File Offset: 0x00043638
		public DateColumn()
		{
			base.AddNewRowItemTemplateVerticalContentAlignment = (base.VerticalContentAlignment = global::System.Windows.VerticalAlignment.Stretch);
			base.AddNewRowItemTemplateHorizontalContentAlignment = (base.HorizontalContentAlignment = global::System.Windows.HorizontalAlignment.Stretch);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0004546B File Offset: 0x0004366B
		protected internal override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase GenerateContentProvider()
		{
			return new global::Infragistics.Controls.Grids.DateColumnContentProvider();
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00045472 File Offset: 0x00043672
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x00045484 File Offset: 0x00043684
		public global::System.Windows.Controls.DatePickerFormat SelectedDateFormat
		{
			get
			{
				return (global::System.Windows.Controls.DatePickerFormat)base.GetValue(global::Infragistics.Controls.Grids.DateColumn.SelectedDateFormatProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.DateColumn.SelectedDateFormatProperty, value);
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00045498 File Offset: 0x00043698
		private static void SelectedDateFormatChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.DateColumn dateColumn = (global::Infragistics.Controls.Grids.DateColumn)obj;
			dateColumn.OnPropertyChanged("SelectedDateFormat");
		}

		// Token: 0x040005D2 RID: 1490
		public static readonly global::System.Windows.DependencyProperty SelectedDateFormatProperty = global::System.Windows.DependencyProperty.Register("SelectedDateFormat", typeof(global::System.Windows.Controls.DatePickerFormat), typeof(global::Infragistics.Controls.Grids.DateColumn), new global::System.Windows.PropertyMetadata(global::System.Windows.Controls.DatePickerFormat.Short, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.DateColumn.SelectedDateFormatChanged)));
	}
}
