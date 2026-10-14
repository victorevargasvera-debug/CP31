using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000041 RID: 65
	public class SummaryDefinition : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000DD86 File Offset: 0x0000BF86
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000DD98 File Offset: 0x0000BF98
		public string ColumnKey
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.SummaryDefinition.ColumnKeyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.SummaryDefinition.ColumnKeyProperty, value);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000DDA8 File Offset: 0x0000BFA8
		private static void ColumnKeyChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.SummaryDefinition summaryDefinition = (global::Infragistics.SummaryDefinition)obj;
			summaryDefinition.OnPropertyChanged("ColumnKey");
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000DDC7 File Offset: 0x0000BFC7
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0000DDCF File Offset: 0x0000BFCF
		public global::Infragistics.SummaryOperandBase SummaryOperand { get; set; }

		// Token: 0x04000105 RID: 261
		public static readonly global::System.Windows.DependencyProperty ColumnKeyProperty = global::System.Windows.DependencyProperty.Register("ColumnKey", typeof(string), typeof(global::Infragistics.SummaryDefinition), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.SummaryDefinition.ColumnKeyChanged)));
	}
}
