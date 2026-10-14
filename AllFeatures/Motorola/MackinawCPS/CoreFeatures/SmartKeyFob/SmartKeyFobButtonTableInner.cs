using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SmartKeyFob
{
	// Token: 0x020002CD RID: 717
	[global::System.Serializable]
	public class SmartKeyFobButtonTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x0600771B RID: 30491 RVA: 0x006BC1F8 File Offset: 0x006BA3F8
		public global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection SmartKeyFobButtonTableInnerSection
		{
			get
			{
				short num = (short)1199191431;
				short num2 = num;
				num = (short)981808519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1162739712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1660289025;
				if (num != 0)
				{
				}
				num = (short)541720576;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection)base[10748];
			}
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x006BC2B4 File Offset: 0x006BA4B4
		public SmartKeyFobButtonTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苐뻒듔ꗖ귘ﯚ雜뫞飠쏢ꏤ裦诨쯪꿬髮藰蟲髴駶\ud9f8꿺鳼鷾洀昂", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SMARTKEYFOBBUTTONTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x006BC300 File Offset: 0x006BA500
		protected SmartKeyFobButtonTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菏뿑뗓ꓕ곗龎韛믝駟싡ꋣ觥諧쫩껫鯭蓯蛱鯳飵\ud8f7껹鷻鳽泿朁", a_);
		}
	}
}
