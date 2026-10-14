using System;
using AcpCommonLib;

namespace SpecialFeatures.AcpXMLCoreEngineLib
{
	// Token: 0x02000226 RID: 550
	public interface IAcpReports
	{
		// Token: 0x06001C1F RID: 7199
		void GetFeatureSectionName(ref string sectionName, int FeatureID, int SectionID, int index);

		// Token: 0x06001C20 RID: 7200
		void GetfieldsCollection(ref global::AcpCommonLib.IAcpFeatureSection featuresection, int FeatureID, int SectionID, int index);

		// Token: 0x06001C21 RID: 7201
		void GetfieldFromPath(ref global::AcpCommonLib.IAcpField field, int FeatureID, string fieldPath);

		// Token: 0x06001C22 RID: 7202
		void GetfieldsCollectionFromName(ref global::AcpCommonLib.IAcpField field, int FeatureID, int SectionID, int index, string fieldName);
	}
}
