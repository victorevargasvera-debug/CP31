using System;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000EE RID: 238
	internal class DataPresenterExportControl : global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase
	{
		// Token: 0x06000D1F RID: 3359 RVA: 0x00039771 File Offset: 0x00037971
		internal DataPresenterExportControl(global::Infragistics.Windows.DataPresenter.DataPresenterBase sourceDataPresenter, global::Infragistics.Windows.DataPresenter.IDataPresenterExporter exporter) : base(sourceDataPresenter)
		{
			if (exporter == null)
			{
				throw new global::System.ArgumentNullException("exporter");
			}
			this._exporter = exporter;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0003978F File Offset: 0x0003798F
		internal global::Infragistics.Windows.DataPresenter.IDataPresenterExporter Exporter
		{
			get
			{
				return this._exporter;
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00039797 File Offset: 0x00037997
		internal void OnEndExport()
		{
			if (this._sectionContainer != null)
			{
				this._sectionContainer.Section = null;
				base.SourceDataPresenter.InternalRemoveLogicalChild(this._sectionContainer);
				this._sectionContainer = null;
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x000397C8 File Offset: 0x000379C8
		protected override void OnBeginCloneSource(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			base.OnBeginCloneSource(section);
			if (this._sectionContainer == null)
			{
				this._sectionContainer = new global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer();
				this._sectionContainer.Section = this;
				base.SourceDataPresenter.InternalAddLogicalChild(this._sectionContainer);
				return;
			}
			this._sectionContainer.Section = this;
		}

		// Token: 0x040004FA RID: 1274
		private global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer _sectionContainer;

		// Token: 0x040004FB RID: 1275
		private global::Infragistics.Windows.DataPresenter.IDataPresenterExporter _exporter;
	}
}
