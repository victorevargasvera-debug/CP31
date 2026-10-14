using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000206 RID: 518
	[global::System.Serializable]
	public class QCIICallList : global::AcpBusinessLayer.FeatureNode, global::AcpCommonLib.IAcpFeatureNodeCallList
	{
		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x0021B3E8 File Offset: 0x002195E8
		public override string ReferenceKey
		{
			get
			{
				int a_ = 18;
				short num = (short)1082064901;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.CallListQCII.ToneBFreq != null)
						{
							num = (short)1996554247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 1:
						num = (short)988020736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.CallListQCII.CallFormat != null)
						{
							num = (short)39911427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 3:
					{
						num = (short)2112550710;
						short num3 = num;
						num = (short)454817590;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_85;
						default:
							num = (short)1705705472;
							if (num != 0)
							{
							}
							num = (short)1499791364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (this.CallListQCII.ToneAFreq != null)
						{
							num = (short)902627329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_264;
					case 5:
						num = (short)882769921;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_75;
						}
						continue;
					case 6:
					{
						num = (short)1012137984;
						short num4 = num;
						num = (short)1482489858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_106;
					}
					goto IL_75;
					IL_85:
					num = (short)2015952902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_75:
					if (this.CallListQCII.SystemGroupNumber != null)
					{
						goto IL_85;
					}
					goto IL_264;
				}
				IL_106:
				return string.Concat(new string[]
				{
					this.CallListQCII.SystemGroupNumber.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_),
					this.CallListQCII.CallFormat.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_),
					this.CallListQCII.ToneAFreq.ToString(),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢔", a_),
					this.CallListQCII.ToneBFreq
				});
				IL_264:
				return base.FeatureName;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x0021B660 File Offset: 0x00219860
		internal global::SpecialFeatures.Ucl.Contact.QCIICallListCallListSection CallListQCII
		{
			get
			{
				short num = (short)512686575;
				short num2 = num;
				num = (short)1604647407;
				switch (num2 == num)
				{
				}
				num = (short)465043456;
				short num3 = num;
				num = (short)1962409985;
				if (num != 0)
				{
				}
				num = (short)1584070656;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.QCIICallListCallListSection)base[10410];
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x0021B718 File Offset: 0x00219918
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0021B7C8 File Offset: 0x002199C8
		public int HotlistParentRecsetId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)49282506;
				short num2 = num;
				num = (short)1943338442;
				switch (num2 == num)
				{
				}
				num = (short)1210384384;
				short num3 = num;
				num = (short)1210908672;
				if (num != 0)
				{
				}
				num = (short)41877505;
				if (num != 0)
				{
				}
				return this.<HotlistParentRecsetId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)757408451;
				short num2 = num;
				num = (short)68887235;
				switch (num2 == num)
				{
				}
				num = (short)1101594624;
				short num3 = num;
				num = (short)661585920;
				if (num != 0)
				{
				}
				num = (short)830537729;
				if (num != 0)
				{
				}
				this.<HotlistParentRecsetId>k__BackingField = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x0021B878 File Offset: 0x00219A78
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x0021B928 File Offset: 0x00219B28
		public int HotlistParentSectionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1283884964;
				short num2 = num;
				num = (short)548833188;
				switch (num2 == num)
				{
				}
				num = (short)271646720;
				short num3 = num;
				num = (short)1872625665;
				if (num != 0)
				{
				}
				num = (short)1391460352;
				if (num != 0)
				{
				}
				return this.<HotlistParentSectionId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1712873429;
				short num2 = num;
				num = (short)702439381;
				switch (num2 == num)
				{
				}
				num = (short)1109262336;
				short num3 = num;
				num = (short)550240257;
				if (num != 0)
				{
				}
				num = (short)1475215360;
				if (num != 0)
				{
				}
				this.<HotlistParentSectionId>k__BackingField = value;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x0021B9DC File Offset: 0x00219BDC
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x0021BA8C File Offset: 0x00219C8C
		public int HotlistRecsetId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2111897601;
				if (num != 0)
				{
				}
				num = (short)1672274265;
				short num2 = num;
				num = (short)1585766745;
				switch (num2 == num)
				{
				default:
				{
					num = (short)644349952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1625358336;
				if (num != 0)
				{
				}
				return this.<HotlistRecsetId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)520843871;
				short num2 = num;
				num = (short)1705538143;
				switch (num2 == num)
				{
				}
				num = (short)1086586880;
				short num3 = num;
				num = (short)220528641;
				if (num != 0)
				{
				}
				num = (short)670105600;
				if (num != 0)
				{
				}
				this.<HotlistRecsetId>k__BackingField = value;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x0021BB38 File Offset: 0x00219D38
		// (set) Token: 0x0600198F RID: 6543 RVA: 0x0021BBE8 File Offset: 0x00219DE8
		public int HotlistSectionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)935067649;
				if (num != 0)
				{
				}
				num = (short)1267570689;
				short num2 = num;
				num = (short)379033601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1118830592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1995112448;
				if (num != 0)
				{
				}
				return this.<HotlistSectionId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)735061387;
				short num2 = num;
				num = (short)222176651;
				switch (num2 == num)
				{
				}
				num = (short)1219624960;
				short num3 = num;
				num = (short)677838849;
				if (num != 0)
				{
				}
				num = (short)1330315264;
				if (num != 0)
				{
				}
				this.<HotlistSectionId>k__BackingField = value;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x0021BC98 File Offset: 0x00219E98
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x0021BD48 File Offset: 0x00219F48
		public int CalllistContactAliasSectionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1681438823;
				short num2 = num;
				num = (short)514111591;
				switch (num2 == num)
				{
				}
				num = (short)520421376;
				short num3 = num;
				num = (short)1002438656;
				if (num != 0)
				{
				}
				num = (short)1805713409;
				if (num != 0)
				{
				}
				return this.<CalllistContactAliasSectionId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)295132534;
				short num2 = num;
				num = (short)1314282870;
				switch (num2 == num)
				{
				}
				num = (short)377815040;
				short num3 = num;
				num = (short)916324353;
				if (num != 0)
				{
				}
				num = (short)1055391744;
				if (num != 0)
				{
				}
				this.<CalllistContactAliasSectionId>k__BackingField = value;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x0021BDFC File Offset: 0x00219FFC
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x0021BEAC File Offset: 0x0021A0AC
		public string CalllistContactAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)968359566;
				short num2 = num;
				num = (short)1073806990;
				switch (num2 == num)
				{
				}
				num = (short)1681129472;
				short num3 = num;
				num = (short)1564147712;
				if (num != 0)
				{
				}
				num = (short)265879553;
				if (num != 0)
				{
				}
				return this.<CalllistContactAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)936443905;
				if (num != 0)
				{
				}
				num = (short)32932;
				short num2 = num;
				num = (short)1172865188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2014445568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1287127040;
				if (num != 0)
				{
				}
				this.<CalllistContactAlias>k__BackingField = value;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x0021BF5C File Offset: 0x0021A15C
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x0021C00C File Offset: 0x0021A20C
		public string HotlistContactAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1675558913;
				if (num != 0)
				{
				}
				num = (short)1578370085;
				short num2 = num;
				num = (short)131138597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)941293568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1300889600;
				if (num != 0)
				{
				}
				return this.<HotlistContactAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)638350313;
				short num2 = num;
				num = (short)2096919529;
				switch (num2 == num)
				{
				}
				num = (short)55836672;
				short num3 = num;
				num = (short)1867841536;
				if (num != 0)
				{
				}
				num = (short)1184497665;
				if (num != 0)
				{
				}
				this.<HotlistContactAlias>k__BackingField = value;
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x0021C0BC File Offset: 0x0021A2BC
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x0021C170 File Offset: 0x0021A370
		public string HotlistContactCallId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1861943297;
				if (num != 0)
				{
				}
				num = (short)1041288458;
				short num2 = num;
				num = (short)439143690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1859649536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)937885696;
				if (num != 0)
				{
				}
				return this.<HotlistContactCallId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1386003310;
				short num2 = num;
				num = (short)1514650478;
				switch (num2 == num)
				{
				}
				num = (short)772079616;
				short num3 = num;
				num = (short)576978945;
				if (num != 0)
				{
				}
				num = (short)146538496;
				if (num != 0)
				{
				}
				this.<HotlistContactCallId>k__BackingField = value;
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00003D03 File Offset: 0x00001F03
		private QCIICallList() : this(null)
		{
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0021C220 File Offset: 0x0021A420
		internal QCIICallList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒆꾎\udd90朗", a_);
			this.HotlistParentRecsetId = 2218;
			this.HotlistParentSectionId = 10425;
			this.HotlistRecsetId = 2219;
			this.HotlistSectionId = 10426;
			this.CalllistContactAliasSectionId = 10400;
			this.CalllistContactAlias = global::CommonResources.AppResources.Contact_Alias;
			this.HotlistContactAlias = global::CommonResources.AppResources.Contact_Alias;
			this.HotlistContactCallId = global::CommonResources.AppResources.Call_ID;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.QCIICallListCallListSection(this));
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0021C2B8 File Offset: 0x0021A4B8
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)908528275;
			short num2 = num;
			num = (short)639699603;
			switch (num2 == num)
			{
			}
			num = (short)1080623104;
			short num3 = num;
			num = (short)584122368;
			if (num != 0)
			{
			}
			num = (short)1211367425;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000038AD File Offset: 0x00001AAD
		protected QCIICallList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
