using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001DF RID: 479
	[global::System.Serializable]
	public class ShepherdsRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06005422 RID: 21538 RVA: 0x004C83A8 File Offset: 0x004C65A8
		public ShepherdsRecset()
		{
			int a_ = 17;
			base..ctor(global::AllFeatures.CodeplugGuid.b("臑볓돕꣗닙맛곝蓟釡", a_));
			this.SetValues();
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x004C83D8 File Offset: 0x004C65D8
		public ShepherdsRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06005424 RID: 21540 RVA: 0x004C8404 File Offset: 0x004C6604
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1422917632;
			short num2 = num;
			num = (short)1404612750;
			short num3 = num;
			num = (short)1089974414;
			switch (num3 == num)
			{
			}
			num = (short)1175519233;
			if (num != 0)
			{
			}
			num = (short)1652293632;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.Shepherds(this);
		}

		// Token: 0x06005425 RID: 21541 RVA: 0x004C84B4 File Offset: 0x004C66B4
		internal void SetValues()
		{
			int a_ = 16;
			short num = (short)1040973824;
			short num2 = num;
			num = (short)1190902537;
			short num3 = num;
			num = (short)1683405577;
			switch (num3 == num)
			{
			}
			num = (short)1947860993;
			if (num != 0)
			{
			}
			num = (short)300744704;
			if (num != 0)
			{
			}
			base.Id = 2013;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6ꫨ蓪胬鿮黰鷲郴駶跸ꟺ꿼黾攀樂樄✆䰈礊樌怎缐簒研縖稘栚㴜尞丠䴢䌤並丨帪弬丮䔰娲娴夶攸栺唼娾ㅀ⭂⁄㕆ⵈ㡊ᅌᱎ㥐㙒╔㽖㱘⥚㥜ⱞ你᭢Ѥ੦ը", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SHEPHERDS;
			base.DataTransferOrder = 22;
			this.b();
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x004C85A4 File Offset: 0x004C67A4
		private void b()
		{
			short num = (short)1928331264;
			short num2 = num;
			num = (short)1839676362;
			short num3 = num;
			num = (short)1315388362;
			switch (num3 == num)
			{
			}
			num = (short)1444610049;
			if (num != 0)
			{
			}
			num = (short)597032960;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x004C8654 File Offset: 0x004C6854
		private void a()
		{
			short num = (short)1900347393;
			if (num != 0)
			{
			}
			num = (short)569835520;
			short num2 = num;
			if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.LABTOOL)
			{
				num = (short)119587782;
				short num3 = num;
				num = (short)1803600838;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1599012864;
					if (num != 0)
					{
					}
					base.HiddenStatic = true;
					return;
				}
			}
			base.HiddenStatic = false;
		}
	}
}
