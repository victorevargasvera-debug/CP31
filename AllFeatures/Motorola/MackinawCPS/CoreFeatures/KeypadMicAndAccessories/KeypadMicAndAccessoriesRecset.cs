using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000318 RID: 792
	[global::System.Serializable]
	public class KeypadMicAndAccessoriesRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007C27 RID: 31783 RVA: 0x0071E9B0 File Offset: 0x0071CBB0
		public KeypadMicAndAccessoriesRecset()
		{
			int a_ = 0;
			base..ctor(global::AllFeatures.CodeplugGuid.b("諀ꛂ별럆꣈꿊苎룐냒雖럘뿚﷜點苠胢胤铦髨蓪鿬蛮铰胲", a_));
			this.SetValues();
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x0071E9E0 File Offset: 0x0071CBE0
		public KeypadMicAndAccessoriesRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x0071EA0C File Offset: 0x0071CC0C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2127690647;
			short num2 = num;
			num = (short)39713687;
			switch (num2 == num)
			{
			}
			num = (short)252116993;
			if (num != 0)
			{
			}
			num = (short)771293184;
			short num3 = num;
			num = (short)494731264;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories(this);
		}

		// Token: 0x06007C2A RID: 31786 RVA: 0x0071EABC File Offset: 0x0071CCBC
		internal void SetValues()
		{
			int a_ = 12;
			short num = (short)1015699998;
			short num2 = num;
			num = (short)1504795166;
			switch (num2 == num)
			{
			}
			num = (short)1363673089;
			if (num != 0)
			{
			}
			num = (short)1204355072;
			short num3 = num;
			num = (short)729743360;
			if (num != 0)
			{
			}
			base.Id = 2128;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶꯸髺駼雾渀⌂䀄甆済搊挌怎簐稒瘔搖㤘堚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲椴琶嘸唺䤼䴾⹀⽂㙄ᭆɈ⹊㑌㽎ぐ㝒畔ᩖじ㡚絜Ṟའݢ䕤♦੨ࡪ࡬ᱮɰᱲݴṶᱸࡺⅼ㑾廒욊킐ﶒ횖滛튠첢힤캦첨\ud8aa莬힮킰\udeb2\ud9b4", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KEYPADMICANDACCESSORIES;
			base.DataTransferOrder = 18;
		}
	}
}
