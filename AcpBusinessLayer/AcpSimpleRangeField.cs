using System;
using System.Windows.Data;
using AcpBusinessLayer.ValueConverters;

namespace AcpBusinessLayer
{
	// Token: 0x02000021 RID: 33
	public class AcpSimpleRangeField : global::AcpBusinessLayer.AcpCustomRangeField
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x000381B8 File Offset: 0x000363B8
		public AcpSimpleRangeField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiName, string minLabel, string maxLabel, int uiOffset, int uiMultiplier) : base(value, new global::AcpBusinessLayer.ValueConverters.FactorByConverter(uiMultiplier, uiOffset), parent, name, uiName, minLabel, maxLabel)
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000381D4 File Offset: 0x000363D4
		public AcpSimpleRangeField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiName, string minLabel, string maxLabel, int uiOffset, int uiMultiplier, string[] legacyUILabels) : base(value, new global::AcpBusinessLayer.ValueConverters.FactorByConverter(uiMultiplier, uiOffset), parent, name, uiName, minLabel, maxLabel, legacyUILabels)
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000381FC File Offset: 0x000363FC
		public AcpSimpleRangeField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiName, int min, int max, string minLabel, string maxLabel, int uiOffset, int uiMultiplier) : base(value, new global::AcpBusinessLayer.ValueConverters.FactorByConverter(uiMultiplier, uiOffset), parent, name, uiName, min, max, 1, minLabel, maxLabel)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00038228 File Offset: 0x00036428
		public AcpSimpleRangeField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiName, int min, int max, string minLabel, string maxLabel, int uiOffset, int uiMultiplier, string[] legacyUILabels) : base(value, new global::AcpBusinessLayer.ValueConverters.FactorByConverter(uiMultiplier, uiOffset), parent, name, uiName, min, max, 1, minLabel, maxLabel, legacyUILabels)
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00038254 File Offset: 0x00036454
		public AcpSimpleRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiName, int min, int max, string minLabel, string maxLabel) : base(value, converter, parent, name, uiName, min, max, 1, minLabel, maxLabel)
		{
		}
	}
}
