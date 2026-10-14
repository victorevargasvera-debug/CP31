using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CF RID: 463
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SummaryRecordPrefixArea : global::Infragistics.Windows.DataPresenter.RecordPrefixArea
	{
		// Token: 0x06001B3D RID: 6973 RVA: 0x0007A82F File Offset: 0x00078A2F
		static SummaryRecordPrefixArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea)));
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0007A85C File Offset: 0x00078A5C
		internal override global::Infragistics.Windows.Helpers.StyleSelectorHelperBase CreateStyleSelectorHelper()
		{
			return new global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea.StyleSelectorHelper(this);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0007A864 File Offset: 0x00078A64
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

		// Token: 0x020001D0 RID: 464
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06001B41 RID: 6977 RVA: 0x0007A8A0 File Offset: 0x00078AA0
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea rs) : base(rs)
			{
				this._rs = rs;
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0007A8B0 File Offset: 0x00078AB0
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

			// Token: 0x04000AFC RID: 2812
			private global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea _rs;
		}
	}
}
