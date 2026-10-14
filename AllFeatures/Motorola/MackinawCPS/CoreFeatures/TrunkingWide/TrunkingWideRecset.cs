using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x02000062 RID: 98
	[global::System.Serializable]
	public class TrunkingWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06000832 RID: 2098 RVA: 0x0007F6A0 File Offset: 0x0007D8A0
		public TrunkingWideRecset()
		{
			int a_ = 8;
			base..ctor(global::AllFeatures.CodeplugGuid.b("鷈맊료ꇎ뫐뫒믔냖律賚드믞蓠", a_));
			this.SetValues();
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0007F6D0 File Offset: 0x0007D8D0
		public TrunkingWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0007F6FC File Offset: 0x0007D8FC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1670428444;
			short num2 = num;
			num = (short)1428207388;
			switch (num2 == num)
			{
			}
			num = (short)1810825217;
			if (num != 0)
			{
			}
			num = (short)1652424704;
			if (num != 0)
			{
			}
			num = (short)1921253376;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingWide.TrunkingWide(this);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0007F7AC File Offset: 0x0007D9AC
		internal void SetValues()
		{
			int a_ = 5;
			short num = (short)1972436993;
			if (num != 0)
			{
			}
			num = (short)1929068446;
			short num2 = num;
			num = (short)1437876126;
			switch (num2 == num)
			{
			}
			num = (short)1235877888;
			if (num != 0)
			{
			}
			num = (short)1189543936;
			short num3 = num;
			base.Id = 2027;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯꛱蛳菵雷釹闻都柿∁䜃椅昇氉攋植攏怑甓戕焗甙爛䈝琟倡儣䠥䌧䌩䈫䤭ု攱崳刵崷昹栻䰽㔿ⱁ⽃⽅♇ⵉᭋ❍㑏㝑穓⹕㥗㝙せ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGWIDE;
			base.DataTransferOrder = 12;
		}
	}
}
