using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000351 RID: 849
	[global::System.Serializable]
	public class ControlHeadO9Recset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060081AD RID: 33197 RVA: 0x0078B120 File Offset: 0x00789320
		public ControlHeadO9Recset()
		{
			int a_ = 14;
			base..ctor(global::AllFeatures.CodeplugGuid.b("賎뻐뷒ꇔꗖ뛘럚﷜韞蓠苢臤쟦쓨쯪ꋬ훮", a_));
			this.SetValues();
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x0078B150 File Offset: 0x00789350
		public ControlHeadO9Recset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x0078B17C File Offset: 0x0078937C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1583495010;
			short num2 = num;
			num = (short)285620066;
			switch (num2 == num)
			{
			default:
			{
				num = (short)69533696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)838074369;
			if (num != 0)
			{
			}
			num = (short)2045181952;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9(this);
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x0078B228 File Offset: 0x00789428
		internal void SetValues()
		{
			int a_ = 11;
			short num = (short)1117958217;
			short num2 = num;
			num = (short)1393930313;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1681981440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)769458176;
			if (num != 0)
			{
			}
			num = (short)1062010881;
			if (num != 0)
			{
			}
			base.Id = 4003;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("跋ꋍ볏铑뇓럕곗꿙껛믝鏟\ud9e1꟣觥藧髩菫胭闯鳱胳ꫵ꫷鯹飻韽濿∁䄃琅漇攉戋愍紏笑眓攕㠗夙猛瀝䘟䬡䌣匥娧䬩堫䜭弯就栳电圷吹䠻䰽⼿⹁㝃ᩅେ╉≋㩍≏㵑㡓癕ၗ㽙㵛㩝䁟佡䑣⥥內㙩⽫ŭṯٱٳ᥵ᑷ㉹᥻ώ춁붃ꢅ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO9;
			base.DataTransferOrder = 50;
		}
	}
}
