using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F5 RID: 757
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class HeaderPrefixArea : global::Infragistics.Windows.DataPresenter.RecordPrefixArea
	{
		// Token: 0x06002360 RID: 9056 RVA: 0x0009A43A File Offset: 0x0009863A
		static HeaderPrefixArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea)));
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x0009A467 File Offset: 0x00098667
		internal override global::Infragistics.Windows.Helpers.StyleSelectorHelperBase CreateStyleSelectorHelper()
		{
			return new global::Infragistics.Windows.DataPresenter.HeaderPrefixArea.StyleSelectorHelper(this);
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x0009A470 File Offset: 0x00098670
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("HeaderPrefixArea: ");
			if (base.Record != null)
			{
				stringBuilder.Append(base.Record.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x020002F6 RID: 758
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06002364 RID: 9060 RVA: 0x0009A4AF File Offset: 0x000986AF
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea rs) : base(rs)
			{
				this._rs = rs;
			}

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x06002365 RID: 9061 RVA: 0x0009A4C0 File Offset: 0x000986C0
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
							return dataPresenter.InternalHeaderPrefixAreaStyleSelector.SelectStyle(this._rs.DataContext, this._rs);
						}
					}
					return null;
				}
			}

			// Token: 0x04001132 RID: 4402
			private global::Infragistics.Windows.DataPresenter.HeaderPrefixArea _rs;
		}
	}
}
