using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000043 RID: 67
	public abstract class SummaryOperandBase : global::Infragistics.DependencyObjectNotifier
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002C8 RID: 712
		protected abstract string DefaultSelectionDisplayLabel { get; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002C9 RID: 713
		protected abstract string DefaultRowDisplayLabel { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000DF68 File Offset: 0x0000C168
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0000DF7A File Offset: 0x0000C17A
		public string SelectionDisplayLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.SummaryOperandBase.SelectionDisplayLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.SummaryOperandBase.SelectionDisplayLabelProperty, value);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000DF88 File Offset: 0x0000C188
		private static void SelectionDisplayLabelChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.SummaryOperandBase summaryOperandBase = (global::Infragistics.SummaryOperandBase)obj;
			summaryOperandBase.OnPropertyChanged("SelectionDisplayLabel");
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000DFA7 File Offset: 0x0000C1A7
		public string SelectionDisplayLabelResolved
		{
			get
			{
				if (string.IsNullOrEmpty(this.SelectionDisplayLabel))
				{
					return this.DefaultSelectionDisplayLabel;
				}
				return this.SelectionDisplayLabel;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000DFC3 File Offset: 0x0000C1C3
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0000DFD5 File Offset: 0x0000C1D5
		public string RowDisplayLabel
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.SummaryOperandBase.RowDisplayLabelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.SummaryOperandBase.RowDisplayLabelProperty, value);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		private static void RowDisplayLabelChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.SummaryOperandBase summaryOperandBase = (global::Infragistics.SummaryOperandBase)obj;
			summaryOperandBase.OnPropertyChanged("RowDisplayLabel");
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000E003 File Offset: 0x0000C203
		public string RowDisplayLabelResolved
		{
			get
			{
				if (string.IsNullOrEmpty(this.RowDisplayLabel))
				{
					return this.DefaultRowDisplayLabel;
				}
				return this.RowDisplayLabel;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000E01F File Offset: 0x0000C21F
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000E031 File Offset: 0x0000C231
		public string FormatString
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.SummaryOperandBase.FormatStringProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.SummaryOperandBase.FormatStringProperty, value);
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000E040 File Offset: 0x0000C240
		private static void FormatStringChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.SummaryOperandBase summaryOperandBase = (global::Infragistics.SummaryOperandBase)obj;
			summaryOperandBase.OnPropertyChanged("FormatString");
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000E05F File Offset: 0x0000C25F
		public virtual global::Infragistics.SummaryCalculatorBase SummaryCalculator
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0000E064 File Offset: 0x0000C264
		public virtual global::Infragistics.LinqSummaryOperator? LinqSummaryOperator
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000E07A File Offset: 0x0000C27A
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000E082 File Offset: 0x0000C282
		public virtual bool IsApplied
		{
			get
			{
				return this._isApplied;
			}
			set
			{
				if (this._isApplied != value)
				{
					this._isApplied = value;
					this.OnPropertyChanged("IsApplied");
				}
			}
		}

		// Token: 0x04000107 RID: 263
		private bool _isApplied;

		// Token: 0x04000108 RID: 264
		public static readonly global::System.Windows.DependencyProperty SelectionDisplayLabelProperty = global::System.Windows.DependencyProperty.Register("SelectionDisplayLabel", typeof(string), typeof(global::Infragistics.SummaryOperandBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.SummaryOperandBase.SelectionDisplayLabelChanged)));

		// Token: 0x04000109 RID: 265
		public static readonly global::System.Windows.DependencyProperty RowDisplayLabelProperty = global::System.Windows.DependencyProperty.Register("RowDisplayLabel", typeof(string), typeof(global::Infragistics.SummaryOperandBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.SummaryOperandBase.RowDisplayLabelChanged)));

		// Token: 0x0400010A RID: 266
		public static readonly global::System.Windows.DependencyProperty FormatStringProperty = global::System.Windows.DependencyProperty.Register("FormatString", typeof(string), typeof(global::Infragistics.SummaryOperandBase), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.SummaryOperandBase.FormatStringChanged)));
	}
}
