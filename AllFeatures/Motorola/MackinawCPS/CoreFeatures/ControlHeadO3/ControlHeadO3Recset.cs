using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003BA RID: 954
	[global::System.Serializable]
	public class ControlHeadO3Recset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600898A RID: 35210 RVA: 0x0080B650 File Offset: 0x00809850
		public ControlHeadO3Recset()
		{
			int a_ = 11;
			base..ctor(global::AllFeatures.CodeplugGuid.b("迋ꇍ뻏ꛑꛓ맕듗龎铛믝臟蛡쓣쯥죧ꗩ\udfeb", a_));
			this.SetValues();
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x0080B680 File Offset: 0x00809880
		public ControlHeadO3Recset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x0600898C RID: 35212 RVA: 0x0080B6AC File Offset: 0x008098AC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)18022400;
			short num2 = num;
			num = (short)1466818316;
			short num3 = num;
			num = (short)869719820;
			switch (num3 == num)
			{
			}
			num = (short)1690697729;
			if (num != 0)
			{
			}
			num = (short)1976893440;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3(this);
		}

		// Token: 0x0600898D RID: 35213 RVA: 0x0080B75C File Offset: 0x0080995C
		internal void SetValues()
		{
			int a_ = 12;
			short num = (short)302907392;
			short num2 = num;
			num = (short)2116550657;
			if (num != 0)
			{
			}
			num = (short)784330323;
			short num3 = num;
			num = (short)1507978835;
			switch (num3 == num)
			{
			}
			num = (short)1647509504;
			if (num != 0)
			{
			}
			base.Id = 2127;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶꯸髺駼雾渀⌂䀄甆済搊挌怎簐稒瘔搖㤘堚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲椴琶嘸唺䤼䴾⹀⽂㙄ᭆੈ⑊⍌㭎⍐㱒㥔睖ᅘ㹚㱜㭞䅠乢䕤⡦婨㝪⹬nὰݲݴᡶᕸ㍺᡼Ṿ첂뚄ꦆ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO3;
			base.DataTransferOrder = 17;
		}
	}
}
