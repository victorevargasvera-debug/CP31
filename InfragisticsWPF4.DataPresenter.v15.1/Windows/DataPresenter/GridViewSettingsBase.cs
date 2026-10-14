using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E4 RID: 484
	public class GridViewSettingsBase : global::Infragistics.Windows.Controls.ViewSettingsBase
	{
		// Token: 0x06001E3D RID: 7741 RVA: 0x0008640D File Offset: 0x0008460D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override void Reset()
		{
			this.ResetAllowLastRecordScrollToTop();
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00086415 File Offset: 0x00084615
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ShouldSerialize()
		{
			return this.ShouldSerializeAllowLastRecordScrollToTop();
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00086420 File Offset: 0x00084620
		private static void OnAllowLastRecordScrollToTopChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.GridViewSettingsBase gridViewSettingsBase = (global::Infragistics.Windows.DataPresenter.GridViewSettingsBase)dependencyObject;
			bool cachedAllowLastRecordScrollToTop = (bool)e.NewValue;
			gridViewSettingsBase._cachedAllowLastRecordScrollToTop = cachedAllowLastRecordScrollToTop;
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00086448 File Offset: 0x00084648
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x00086450 File Offset: 0x00084650
		public bool AllowLastRecordScrollToTop
		{
			get
			{
				return this._cachedAllowLastRecordScrollToTop;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.GridViewSettingsBase.AllowLastRecordScrollToTopProperty, value);
			}
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00086463 File Offset: 0x00084663
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAllowLastRecordScrollToTop()
		{
			return this.AllowLastRecordScrollToTop;
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0008646B File Offset: 0x0008466B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAllowLastRecordScrollToTop()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.GridViewSettingsBase.AllowLastRecordScrollToTopProperty);
		}

		// Token: 0x04000CC8 RID: 3272
		public static readonly global::System.Windows.DependencyProperty AllowLastRecordScrollToTopProperty = global::System.Windows.DependencyProperty.Register("AllowLastRecordScrollToTop", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.GridViewSettingsBase), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridViewSettingsBase.OnAllowLastRecordScrollToTopChanged)));

		// Token: 0x04000CC9 RID: 3273
		private bool _cachedAllowLastRecordScrollToTop = (bool)global::Infragistics.Windows.DataPresenter.GridViewSettingsBase.AllowLastRecordScrollToTopProperty.DefaultMetadata.DefaultValue;
	}
}
