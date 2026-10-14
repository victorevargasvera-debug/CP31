using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x02000267 RID: 615
	[global::System.Serializable]
	public class CoordinatesInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x06006E11 RID: 28177 RVA: 0x00621FF4 File Offset: 0x006201F4
		public global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerSection CoordinatesInnerSection
		{
			get
			{
				short num = (short)2016428806;
				short num2 = num;
				num = (short)1522483974;
				switch (num2 == num)
				{
				}
				num = (short)659292160;
				if (num != 0)
				{
				}
				num = (short)1135214593;
				if (num != 0)
				{
				}
				num = (short)501350400;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerSection)base[10811];
			}
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x006220AC File Offset: 0x006202AC
		public CoordinatesInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諈꓊ꋌ뷎뗐뫒믔뛖귘뻚껜", a_);
			base.UIName = global::CommonResources.AcgResources.ID_COORDINATES;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x006220F8 File Offset: 0x006202F8
		protected CoordinatesInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 17;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("金믓맕꫗뻙뗛냝臟雡臣闥", a_);
		}
	}
}
