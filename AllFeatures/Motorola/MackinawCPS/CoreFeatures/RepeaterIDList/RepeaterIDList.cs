using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x02000518 RID: 1304
	[global::System.Serializable]
	public class RepeaterIDList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600B122 RID: 45346 RVA: 0x00A4375C File Offset: 0x00A4195C
		public RepeaterIDList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铅귇뫉꧋꿍꓏럑ꛓ釗黙ﳛ鋝觟釡郣", a_);
			base.UIName = global::CommonResources.AcgResources.ID_REPEATERIDLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯뇱鯳飵軷鿹鋻諽槿洁樃朅搇⨉伋愍縏琑紓焕洗栙紛樝䤟䴡䨣稥稧伩尫䬭儯䘱儳䐵ᠷ猹砻ḽి⭁㝃㉅ᑇᡉ⥋㹍㕏㍑⁓㍕⩗ፙᡛቝय़ᅡၣ䡥ၧ୩ūɭ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyList(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600B123 RID: 45347 RVA: 0x00A437D4 File Offset: 0x00A419D4
		protected RepeaterIDList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駊꣌뿎듐닒ꇔ닖ꯘﯚ铜鯞쇠꿢賤铦鷨", a_);
			base.UIName = global::CommonResources.AcgResources.ID_REPEATERIDLIST;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴듶雸闺诼髾漀眂氄栆月樊愌⼎刐簒笔焖瀘簚栜洞䀠圢䰤䠦䜨眪缬䨮䄰嘲吴䌶尸䤺ᴼ瘾Հ捂ॄ⹆㩈㽊ᅌᵎ㑐⍒ご㙖ⵘ㹚⽜ᙞ╠⽢౤ᑦᵨ䕪ᕬ๮ᱰὲ", a_);
			this.a(info, context);
		}

		// Token: 0x170058F3 RID: 22771
		// (get) Token: 0x0600B124 RID: 45348 RVA: 0x00A43830 File Offset: 0x00A41A30
		public global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDList MDCRepeaterIDList
		{
			get
			{
				short num = (short)1394080098;
				short num2 = num;
				num = (short)643103074;
				switch (num2 == num)
				{
				}
				num = (short)559022081;
				if (num != 0)
				{
				}
				num = (short)1339162624;
				if (num != 0)
				{
				}
				num = (short)1221459968;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDList)base[10077];
			}
		}

		// Token: 0x170058F4 RID: 22772
		// (get) Token: 0x0600B125 RID: 45349 RVA: 0x00A438E8 File Offset: 0x00A41AE8
		public global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyList SingletoneFrequencyList
		{
			get
			{
				short num = (short)1751442465;
				short num2 = num;
				num = (short)490791969;
				switch (num2 == num)
				{
				}
				num = (short)1870528513;
				if (num != 0)
				{
				}
				num = (short)122945536;
				if (num != 0)
				{
				}
				num = (short)1789853696;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyList)base[10224];
			}
		}

		// Token: 0x0600B126 RID: 45350 RVA: 0x00A439A0 File Offset: 0x00A41BA0
		public static global::AcpCommonLib.IAcpFeatureNode GetRepeaterIDList()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2034)[0];
					num2 = (short)853213185;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_124;
				case 2:
					goto IL_F5;
				case 3:
				{
					num2 = (short)588535575;
					short num3 = num2;
					num2 = (short)215308055;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1418592256;
						if (num2 != 0)
						{
						}
						num2 = (short)158597121;
						if (num2 != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num2 = (short)1071513600;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2034)[0];
						break;
					}
					num2 = (short)1482686466;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
			}
			IL_F5:
			return result;
			IL_124:
			num2 = (short)262799360;
			short num4 = num2;
			return result;
			IL_20:
			result = null;
			num2 = (short)94044163;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x00A43B00 File Offset: 0x00A41D00
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)420255033;
			short num2 = num;
			num = (short)221877561;
			switch (num2 == num)
			{
			}
			num = (short)987430913;
			if (num != 0)
			{
			}
			num = (short)1170014208;
			if (num != 0)
			{
			}
			num = (short)1633353728;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x00A43BB0 File Offset: 0x00A41DB0
		private void a()
		{
			short num = (short)894173188;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1857748992;
					short num3 = num;
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyList(this));
					num = (short)1175715841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					num = (short)2131689475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.SingletoneFrequencyList == null)
					{
						num = (short)380436480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					break;
				}
				num = (short)520241688;
				short num4 = num;
				num = (short)1398227480;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)2008088577;
					if (num != 0)
					{
					}
					num = (short)661979136;
					if (num != 0)
					{
					}
					num = (short)159907842;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}
	}
}
