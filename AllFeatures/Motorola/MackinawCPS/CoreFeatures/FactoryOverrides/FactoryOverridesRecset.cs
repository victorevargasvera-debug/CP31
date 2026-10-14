using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200044F RID: 1103
	[global::System.Serializable]
	public class FactoryOverridesRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060093B6 RID: 37814 RVA: 0x008B41CC File Offset: 0x008B23CC
		public FactoryOverridesRecset()
		{
			int a_ = 16;
			base..ctor(global::AllFeatures.CodeplugGuid.b("韐닒뛔ꏖ뛘꧚ꓜ￞껠闢胤闦鯨苪觬諮苰", a_));
			this.SetValues();
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x008B41FC File Offset: 0x008B23FC
		public FactoryOverridesRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x008B4228 File Offset: 0x008B2428
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1838612480;
			short num2 = num;
			num = (short)1669317148;
			short num3 = num;
			num = (short)1460978204;
			switch (num3 == num)
			{
			}
			num = (short)304611328;
			if (num != 0)
			{
			}
			num = (short)759889921;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.FactoryOverrides(this);
		}

		// Token: 0x060093B9 RID: 37817 RVA: 0x008B42D4 File Offset: 0x008B24D4
		internal void SetValues()
		{
			int a_ = 10;
			short num = (short)751697920;
			short num2 = num;
			num = (short)1121205209;
			short num3 = num;
			num = (short)1160068057;
			switch (num3 == num)
			{
			}
			num = (short)2064842752;
			if (num != 0)
			{
			}
			num = (short)1407057921;
			if (num != 0)
			{
			}
			base.Id = 2003;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴뇶飸飺觼郾猀稂┄䠆缈渊缌紎砐眒瀔搖䔘崚簜簞唠䰢圤带昨崪䠬崮䌰娲儴制䨸ᔺ䔼帾ⱀ⽂", a_);
			base.UIName = global::CommonResources.AcgResources.ID_FACTORYOVERRIDES;
			base.DataTransferOrder = 5;
		}
	}
}
