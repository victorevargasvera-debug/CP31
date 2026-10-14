using System;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.AcpXMLCoreEngineLib
{
	// Token: 0x02000229 RID: 553
	public interface IAddRadHandouttables
	{
		// Token: 0x06001C2B RID: 7211
		void AddGeneral(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData);

		// Token: 0x06001C2C RID: 7212
		void AddButtonsAndControl(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData);

		// Token: 0x06001C2D RID: 7213
		void AddButtonsAndControlO2(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType);

		// Token: 0x06001C2E RID: 7214
		void AddButtonsAndControlO3(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType);

		// Token: 0x06001C2F RID: 7215
		void AddButtonsAndControlO7(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType);

		// Token: 0x06001C30 RID: 7216
		void AddButtonsAndControlO5(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType);

		// Token: 0x06001C31 RID: 7217
		void AddButtonsAndControlO9(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData, global::SpecialFeatures.AcpReportManagerLib.reportType rptType);

		// Token: 0x06001C32 RID: 7218
		void AddZonesAndChannels(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData);
	}
}
