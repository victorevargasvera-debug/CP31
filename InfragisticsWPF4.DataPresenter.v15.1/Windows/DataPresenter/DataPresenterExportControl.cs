using System;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200010C RID: 268
	internal class DataPresenterExportControl : global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase
	{
		// Token: 0x06001094 RID: 4244 RVA: 0x0004A135 File Offset: 0x00048335
		internal DataPresenterExportControl(global::Infragistics.Windows.DataPresenter.DataPresenterBase sourceDataPresenter, global::Infragistics.Windows.DataPresenter.IDataPresenterExporter exporter) : base(sourceDataPresenter)
		{
			if (exporter == null)
			{
				throw new global::System.ArgumentNullException("exporter");
			}
			this._exporter = exporter;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0004A153 File Offset: 0x00048353
		internal global::Infragistics.Windows.DataPresenter.IDataPresenterExporter Exporter
		{
			get
			{
				return this._exporter;
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0004A15B File Offset: 0x0004835B
		internal void OnEndExport()
		{
			if (this._sectionContainer != null)
			{
				this._sectionContainer.Section = null;
				base.SourceDataPresenter.InternalRemoveLogicalChild(this._sectionContainer);
				this._sectionContainer = null;
			}
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0004A18C File Offset: 0x0004838C
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

		// Token: 0x04000697 RID: 1687
		private global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer _sectionContainer;

		// Token: 0x04000698 RID: 1688
		private global::Infragistics.Windows.DataPresenter.IDataPresenterExporter _exporter;
	}
}
