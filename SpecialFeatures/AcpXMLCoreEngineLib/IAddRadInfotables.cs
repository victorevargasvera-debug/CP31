using System;

namespace SpecialFeatures.AcpXMLCoreEngineLib
{
	// Token: 0x0200022B RID: 555
	public interface IAddRadInfotables
	{
		// Token: 0x06001C40 RID: 7232
		void AddGeneral(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData);

		// Token: 0x06001C41 RID: 7233
		void AddTracking(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData);

		// Token: 0x06001C42 RID: 7234
		void AddFlashPort(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData);

		// Token: 0x06001C43 RID: 7235
		void AddVersion(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData);

		// Token: 0x06001C44 RID: 7236
		void AddFeatures(ref global::SpecialFeatures.AcpXMLCoreEngineLib._XMLData RptXMLData);
	}
}
