using System;
using System.Text;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000088 RID: 136
	internal static class ClipboardEncodingFactory
	{
		// Token: 0x060006C3 RID: 1731 RVA: 0x0001AB48 File Offset: 0x00018D48
		public static global::Infragistics.Windows.DataPresenter.ClipboardEncoding CreateEncoding(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Windows.IDataObject dataObject, string format)
		{
			if (format == global::System.Windows.DataFormats.Html)
			{
				return new global::Infragistics.Windows.DataPresenter.HtmlClipboardEncoding();
			}
			if (format == global::System.Windows.DataFormats.CommaSeparatedValue)
			{
				if (global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.IsExcelClipboardData(dataObject))
				{
					return new global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding(global::System.Environment.NewLine, ",", "\"", global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.ExcelCSVCriteria, "\"", global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.CsvEncoding);
				}
				return new global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding(global::System.Environment.NewLine, ",", "\"", global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.CSVCriteria, "\"", global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.CsvEncoding);
			}
			else if (format == global::System.Windows.DataFormats.Text || format == global::System.Windows.DataFormats.UnicodeText || format == global::System.Windows.DataFormats.StringFormat)
			{
				if (global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.IsDefault(dp, global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardRecordSeparatorProperty) && global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.IsDefault(dp, global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCellDelimiterProperty) && global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.IsDefault(dp, global::Infragistics.Windows.DataPresenter.DataPresenterBase.ClipboardCellSeparatorProperty))
				{
					return new global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding(global::System.Environment.NewLine, "\t", "\"", global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.ExcelTSVCriteria, "\"", global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.TsvEncoding);
				}
				return new global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding(dp.ClipboardRecordSeparator, dp.ClipboardCellSeparator, dp.ClipboardCellDelimiter, global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.AlwaysUseDelimiter, null, global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.TsvEncoding);
			}
			else
			{
				if (format == global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetClipboardDataFormat(typeof(global::Infragistics.Windows.DataPresenter.ClipboardData)))
				{
					return new global::Infragistics.Windows.DataPresenter.DataPresenterClipboardEncoding();
				}
				return null;
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001AC78 File Offset: 0x00018E78
		private static bool IsDefault(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty property)
		{
			return d != null && global::System.Windows.DependencyPropertyHelper.GetValueSource(d, property).BaseValueSource == global::System.Windows.BaseValueSource.Default;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001AC9C File Offset: 0x00018E9C
		private static bool IsExcelClipboardData(global::System.Windows.IDataObject dataObject)
		{
			return dataObject != null && dataObject.GetDataPresent("BIFF8") && dataObject.GetDataPresent("BIFF5");
		}

		// Token: 0x0400021E RID: 542
		private static readonly char[] CSVCriteria = new char[]
		{
			',',
			'"',
			'\r',
			'\n',
			' '
		};

		// Token: 0x0400021F RID: 543
		private static readonly char[] ExcelCSVCriteria = new char[]
		{
			',',
			'\r',
			'\n'
		};

		// Token: 0x04000220 RID: 544
		private static readonly char[] TSVCriteria = new char[]
		{
			'\t',
			'"',
			'\r',
			'\n'
		};

		// Token: 0x04000221 RID: 545
		private static readonly char[] ExcelTSVCriteria = new char[]
		{
			'\t',
			'\r',
			'\n'
		};

		// Token: 0x04000222 RID: 546
		private static readonly char[] AlwaysUseDelimiter = new char[0];

		// Token: 0x04000223 RID: 547
		private static readonly global::System.Text.Encoding TsvEncoding = null;

		// Token: 0x04000224 RID: 548
		private static readonly global::System.Text.Encoding CsvEncoding = global::System.Text.Encoding.UTF8;
	}
}
