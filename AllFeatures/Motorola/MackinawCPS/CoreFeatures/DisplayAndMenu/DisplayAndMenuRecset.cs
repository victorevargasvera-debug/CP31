using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x0200028A RID: 650
	[global::System.Serializable]
	public class DisplayAndMenuRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060070ED RID: 28909 RVA: 0x0064A00C File Offset: 0x0064820C
		public DisplayAndMenuRecset()
		{
			int a_ = 18;
			base..ctor(global::AllFeatures.CodeplugGuid.b("韒볔ꓖ꧘럚볜ꛞ", a_));
			this.SetValues();
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x0064A03C File Offset: 0x0064823C
		public DisplayAndMenuRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060070EF RID: 28911 RVA: 0x0064A068 File Offset: 0x00648268
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1992761598;
			short num2 = num;
			num = (short)627581182;
			switch (num2 == num)
			{
			}
			num = (short)1911881728;
			short num3 = num;
			num = (short)1730805760;
			if (num != 0)
			{
			}
			num = (short)315949057;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu(this);
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x0064A118 File Offset: 0x00648318
		internal void SetValues()
		{
			int a_ = 5;
			short num = (short)714811593;
			short num2 = num;
			num = (short)985016521;
			switch (num2 == num)
			{
			}
			num = (short)1712193536;
			short num3 = num;
			num = (short)122290177;
			if (num != 0)
			{
			}
			num = (short)152502272;
			if (num != 0)
			{
			}
			base.Id = 2010;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯ꃱ闳鋵釷闹\udcfb믽狿攁欃栅朇有攋洍挏㈑圓礕瘗簙甛礝唟倡䔣別䄧䔩䈫爭琯嬱䜳䘵吷嬹䔻ḽℿⱁ⁃晅Շ⽉≋㭍౏ᙑ㵓╕⡗㙙㵛❝⅟ౡc⭥൧ѩᥫ䁭࡯፱ᥳ᩵", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DISPLAY;
			base.DataTransferOrder = 25;
		}
	}
}
