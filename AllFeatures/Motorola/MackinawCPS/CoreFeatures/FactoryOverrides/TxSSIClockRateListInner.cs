using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000467 RID: 1127
	[global::System.Serializable]
	public class TxSSIClockRateListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004B0F RID: 19215
		// (get) Token: 0x06009557 RID: 38231 RVA: 0x008C6B50 File Offset: 0x008C4D50
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerSection TxSSIClockRateListInnerSection
		{
			get
			{
				short num = (short)1355350016;
				short num2 = num;
				num = (short)968222705;
				short num3 = num;
				num = (short)1155000305;
				switch (num3 == num)
				{
				}
				num = (short)355205120;
				if (num != 0)
				{
				}
				num = (short)1333592065;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerSection)base[10613];
			}
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x008C6C08 File Offset: 0x008C4E08
		public TxSSIClockRateListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鷈돊鳎苐髒铖뗘듚뻜듞쇠뇢蓤鏦賨쯪ꇬ蛮苰蟲", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TXSSICLOCKRATELIST;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x008C6C54 File Offset: 0x008C4E54
		protected TxSSIClockRateListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胓껕觙进韝샟ꇡ裣觥诧臩쳫볭釯蛱釳훵듷鏹迻諽", a_);
		}
	}
}
