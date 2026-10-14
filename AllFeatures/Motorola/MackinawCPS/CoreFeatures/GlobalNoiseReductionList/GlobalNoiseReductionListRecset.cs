using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList
{
	// Token: 0x0200025B RID: 603
	[global::System.Serializable]
	public class GlobalNoiseReductionListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006BF5 RID: 27637 RVA: 0x00605980 File Offset: 0x00603B80
		public GlobalNoiseReductionListRecset() : base(global::CommonResources.AcgResources.ID_GLOBALNOISEREDUCTIONLIST, global::CommonResources.AcgResources.ID_GLOBALNRLIST)
		{
			this.SetValues();
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x006059A4 File Offset: 0x00603BA4
		public GlobalNoiseReductionListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x06006BF7 RID: 27639 RVA: 0x006059D0 File Offset: 0x00603BD0
		public override int MaxPool
		{
			get
			{
				short num = (short)1766183867;
				short num2 = num;
				num = (short)845206459;
				switch (num2 == num)
				{
				}
				num = (short)1323827200;
				short num3 = num;
				num = (short)1151139840;
				if (num != 0)
				{
				}
				num = (short)1446379521;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset._MaxPool;
			}
		}

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x06006BF8 RID: 27640 RVA: 0x00605A80 File Offset: 0x00603C80
		// (set) Token: 0x06006BF9 RID: 27641 RVA: 0x00605B44 File Offset: 0x00603D44
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1853727185;
					short num2 = num;
					num = (short)1375314385;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1981349888;
						if (num != 0)
						{
						}
						num = (short)153681921;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)467206144;
					short num3 = num;
					return global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)108468133;
				short num2 = num;
				num = (short)76355493;
				switch (num2 == num)
				{
				}
				num = (short)1071382528;
				short num3 = num;
				num = (short)395182081;
				if (num != 0)
				{
				}
				num = (short)138936320;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x06006BFA RID: 27642 RVA: 0x00605BF8 File Offset: 0x00603DF8
		public bool HasDiffs
		{
			get
			{
				short num = (short)2102232049;
				short num2 = num;
				num = (short)89555953;
				switch (num2 == num)
				{
				}
				num = (short)361889792;
				short num3 = num;
				num = (short)1331625985;
				if (num != 0)
				{
				}
				num = (short)1774518272;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x00605CA8 File Offset: 0x00603EA8
		// (set) Token: 0x06006BFC RID: 27644 RVA: 0x00605D54 File Offset: 0x00603F54
		public override int Min
		{
			get
			{
				short num = (short)1886978049;
				if (num != 0)
				{
				}
				num = (short)567272082;
				short num2 = num;
				num = (short)1907745426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2068447232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1020002304;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset._Min;
			}
			set
			{
				short num = (short)1183983825;
				short num2 = num;
				num = (short)119613649;
				switch (num2 == num)
				{
				}
				num = (short)2094071808;
				short num3 = num;
				num = (short)962854912;
				if (num != 0)
				{
				}
				num = (short)1726939137;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset._Min = value;
			}
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x00605E00 File Offset: 0x00604000
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1629827294;
			short num2 = num;
			num = (short)1270624478;
			switch (num2 == num)
			{
			}
			num = (short)818741248;
			short num3 = num;
			num = (short)1777598464;
			if (num != 0)
			{
			}
			num = (short)732102657;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionList(this);
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x00605EAC File Offset: 0x006040AC
		internal void SetValues()
		{
			int a_ = 18;
			short num = (short)1857789443;
			short num2 = num;
			num = (short)575249923;
			switch (num2 == num)
			{
			}
			num = (short)667680768;
			short num3 = num;
			num = (short)2081882113;
			if (num != 0)
			{
			}
			num = (short)1193803776;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2131;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨꣪苬苮臰鳲鯴鋶韸迺ꇼ귾怀朂氄栆⤈上缌栎縐紒稔稖瀘砚渜㼞戠䰢䬤䄦䀨䰪堬崮倰䜲尴堶圸机猼倾⡀あ⁄杆ᭈ⹊⥌㩎㉐❒㱔㡖㝘筚Ṝぞའբ౤fᱨᥪ౬᭮ᡰᱲ᭴⭶㹸᝺ቼᵾꖄ즆ﺌ놐솒캠춢薤삨\ud8aa\ud9ac\udfb2\udab4햶\ud8b8ힺ킾ꣀ냂ꃄ闆곈꿊료곎ꗐ뫒뫔맖闘닚껜ꯞ뗠臢觤짦釨諪胬菮", a_);
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALNOISEREDUCTIONLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_GLOBALNRLIST;
			base.DataTransferOrder = 35;
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x00605FA8 File Offset: 0x006041A8
		// Note: this type is marked as 'beforefieldinit'.
		static GlobalNoiseReductionListRecset()
		{
			short num = (short)429654017;
			if (num != 0)
			{
			}
			num = (short)1058443305;
			short num2 = num;
			num = (short)849842217;
			switch (num2 == num)
			{
			default:
			{
				num = (short)290652160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1797128192;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListRecset._Min = 1;
		}

		// Token: 0x04002A3D RID: 10813
		public static int _MaxPool;

		// Token: 0x04002A3E RID: 10814
		public static int _Max;

		// Token: 0x04002A3F RID: 10815
		public int _DynMax;

		// Token: 0x04002A40 RID: 10816
		public static int _Min;
	}
}
