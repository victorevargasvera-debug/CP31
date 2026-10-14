using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001AC RID: 428
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordPrefixArea : global::Infragistics.Windows.DataPresenter.RecordPrefixArea
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x00067C07 File Offset: 0x00065E07
		static SummaryRecordPrefixArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea)));
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00067C34 File Offset: 0x00065E34
		internal override global::Infragistics.Windows.Helpers.StyleSelectorHelperBase CreateStyleSelectorHelper()
		{
			return new global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea.StyleSelectorHelper(this);
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00067C3C File Offset: 0x00065E3C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("SummaryRecordPrefixArea: ");
			global::Infragistics.Windows.DataPresenter.Record record = base.Record;
			if (record != null)
			{
				stringBuilder.Append(record.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x020001AD RID: 429
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06001783 RID: 6019 RVA: 0x00067C78 File Offset: 0x00065E78
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea rs) : base(rs)
			{
				this._rs = rs;
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x06001784 RID: 6020 RVA: 0x00067C88 File Offset: 0x00065E88
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._rs == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._rs.FieldLayout;
					if (fieldLayout != null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
						if (dataPresenter != null)
						{
							return null;
						}
					}
					return null;
				}
			}

			// Token: 0x04000932 RID: 2354
			private global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea _rs;
		}
	}
}
