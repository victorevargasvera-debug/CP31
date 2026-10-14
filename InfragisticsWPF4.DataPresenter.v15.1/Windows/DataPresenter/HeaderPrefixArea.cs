using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000335 RID: 821
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class HeaderPrefixArea : global::Infragistics.Windows.DataPresenter.RecordPrefixArea
	{
		// Token: 0x06002701 RID: 9985 RVA: 0x000ADCFA File Offset: 0x000ABEFA
		static HeaderPrefixArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea)));
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000ADD27 File Offset: 0x000ABF27
		internal override global::Infragistics.Windows.Helpers.StyleSelectorHelperBase CreateStyleSelectorHelper()
		{
			return new global::Infragistics.Windows.DataPresenter.HeaderPrefixArea.StyleSelectorHelper(this);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000ADD30 File Offset: 0x000ABF30
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

		// Token: 0x02000336 RID: 822
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06002705 RID: 9989 RVA: 0x000ADD6F File Offset: 0x000ABF6F
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.HeaderPrefixArea rs) : base(rs)
			{
				this._rs = rs;
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06002706 RID: 9990 RVA: 0x000ADD80 File Offset: 0x000ABF80
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

			// Token: 0x0400134C RID: 4940
			private global::Infragistics.Windows.DataPresenter.HeaderPrefixArea _rs;
		}
	}
}
