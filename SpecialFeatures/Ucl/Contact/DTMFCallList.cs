using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x020001FB RID: 507
	[global::System.Serializable]
	public class DTMFCallList : global::AcpBusinessLayer.FeatureNode, global::AcpCommonLib.IAcpFeatureNodeCallList
	{
		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x0020DA88 File Offset: 0x0020BC88
		public override string ReferenceKey
		{
			get
			{
				int a_ = 15;
				short num;
				for (;;)
				{
					IL_09:
					num = (short)1603141634;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1321561741;
						short num3 = num;
						num = (short)1263758989;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1095958528;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_14B;
							case 1:
							{
								num = (short)1933049856;
								short num4 = num;
								num = (short)612106243;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_89;
								}
								continue;
							case 3:
								if (this.CallListDTMF.PrimaryID != null)
								{
									num = (short)1164640256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_176;
							}
							IL_89:
							if (this.CallListDTMF.SystemGroupNumber == null)
							{
								goto IL_176;
							}
							num = (short)1289617409;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				IL_14B:
				num = (short)1580924929;
				if (num != 0)
				{
				}
				return this.CallListDTMF.SystemGroupNumber.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾑", a_) + this.CallListDTMF.PrimaryID.ToString();
				IL_176:
				return base.FeatureName;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x0020DC14 File Offset: 0x0020BE14
		public global::SpecialFeatures.Ucl.Contact.DTMFCallListCallListSection CallListDTMF
		{
			get
			{
				short num = (short)1163255779;
				short num2 = num;
				num = (short)856285155;
				switch (num2 == num)
				{
				}
				num = (short)915472384;
				if (num != 0)
				{
				}
				num = (short)2094858240;
				short num3 = num;
				num = (short)1024983041;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.Contact.DTMFCallListCallListSection)base[10408];
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0020DCCC File Offset: 0x0020BECC
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x0020DD7C File Offset: 0x0020BF7C
		public int HotlistParentRecsetId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1709976033;
				short num2 = num;
				num = (short)579348961;
				switch (num2 == num)
				{
				}
				num = (short)936050688;
				if (num != 0)
				{
				}
				num = (short)2125856768;
				short num3 = num;
				num = (short)30277633;
				if (num != 0)
				{
				}
				return this.<HotlistParentRecsetId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)837123361;
				short num2 = num;
				num = (short)255753505;
				switch (num2 == num)
				{
				}
				num = (short)47185921;
				if (num != 0)
				{
				}
				num = (short)109707264;
				short num3 = num;
				num = (short)1737424896;
				if (num != 0)
				{
				}
				this.<HotlistParentRecsetId>k__BackingField = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0020DE2C File Offset: 0x0020C02C
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x0020DEE0 File Offset: 0x0020C0E0
		public int HotlistParentSectionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2095733883;
				short num2 = num;
				num = (short)851401851;
				switch (num2 == num)
				{
				}
				num = (short)127401985;
				if (num != 0)
				{
				}
				num = (short)1803223040;
				short num3 = num;
				num = (short)505741312;
				if (num != 0)
				{
				}
				return this.<HotlistParentSectionId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)622836031;
				short num2 = num;
				num = (short)1799403839;
				switch (num2 == num)
				{
				}
				num = (short)1664942080;
				if (num != 0)
				{
				}
				num = (short)1421869056;
				short num3 = num;
				num = (short)1925316609;
				if (num != 0)
				{
				}
				this.<HotlistParentSectionId>k__BackingField = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x0020DF90 File Offset: 0x0020C190
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x0020E040 File Offset: 0x0020C240
		public int HotlistRecsetId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1888892680;
				short num2 = num;
				num = (short)1435121416;
				switch (num2 == num)
				{
				}
				num = (short)142278656;
				if (num != 0)
				{
				}
				num = (short)690552832;
				short num3 = num;
				num = (short)1066008577;
				if (num != 0)
				{
				}
				return this.<HotlistRecsetId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1384723377;
				short num2 = num;
				num = (short)913454001;
				switch (num2 == num)
				{
				}
				num = (short)540868609;
				if (num != 0)
				{
				}
				num = (short)506134528;
				short num3 = num;
				num = (short)275841024;
				if (num != 0)
				{
				}
				this.<HotlistRecsetId>k__BackingField = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x0020E0EC File Offset: 0x0020C2EC
		// (set) Token: 0x0600187E RID: 6270 RVA: 0x0020E19C File Offset: 0x0020C39C
		public int HotlistSectionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2141978625;
				if (num != 0)
				{
				}
				num = (short)355394327;
				short num2 = num;
				num = (short)603841303;
				switch (num2 == num)
				{
				}
				num = (short)1247150080;
				short num3 = num;
				num = (short)1207238656;
				if (num != 0)
				{
				}
				return this.<HotlistSectionId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1462752897;
				short num2 = num;
				num = (short)1552930433;
				switch (num2 == num)
				{
				}
				num = (short)1177747457;
				if (num != 0)
				{
				}
				num = (short)1572929536;
				short num3 = num;
				num = (short)1020395520;
				if (num != 0)
				{
				}
				this.<HotlistSectionId>k__BackingField = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0020E24C File Offset: 0x0020C44C
		// (set) Token: 0x06001880 RID: 6272 RVA: 0x0020E2FC File Offset: 0x0020C4FC
		public int CalllistContactAliasSectionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)887941687;
				short num2 = num;
				num = (short)1526131255;
				switch (num2 == num)
				{
				}
				num = (short)186515457;
				if (num != 0)
				{
				}
				num = (short)486670336;
				short num3 = num;
				num = (short)509149184;
				if (num != 0)
				{
				}
				return this.<CalllistContactAliasSectionId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)452648174;
				short num2 = num;
				num = (short)1107156206;
				switch (num2 == num)
				{
				}
				num = (short)29818880;
				if (num != 0)
				{
				}
				num = (short)1193541632;
				short num3 = num;
				num = (short)782827521;
				if (num != 0)
				{
				}
				this.<CalllistContactAliasSectionId>k__BackingField = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x0020E3AC File Offset: 0x0020C5AC
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x0020E45C File Offset: 0x0020C65C
		public string CalllistContactAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1566571977;
				short num2 = num;
				num = (short)452722121;
				switch (num2 == num)
				{
				}
				num = (short)1225981952;
				if (num != 0)
				{
				}
				num = (short)1884553216;
				short num3 = num;
				num = (short)871038977;
				if (num != 0)
				{
				}
				return this.<CalllistContactAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1757042846;
				short num2 = num;
				num = (short)1785419934;
				switch (num2 == num)
				{
				}
				num = (short)488636416;
				if (num != 0)
				{
				}
				num = (short)740818944;
				short num3 = num;
				num = (short)636747777;
				if (num != 0)
				{
				}
				this.<CalllistContactAlias>k__BackingField = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x0020E50C File Offset: 0x0020C70C
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x0020E5BC File Offset: 0x0020C7BC
		public string HotlistContactAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1280472103;
				short num2 = num;
				num = (short)1487500327;
				switch (num2 == num)
				{
				}
				num = (short)358154240;
				if (num != 0)
				{
				}
				num = (short)1452277760;
				short num3 = num;
				num = (short)1025703937;
				if (num != 0)
				{
				}
				return this.<HotlistContactAlias>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)550043649;
				if (num != 0)
				{
				}
				num = (short)1161175250;
				short num2 = num;
				num = (short)67772626;
				switch (num2 == num)
				{
				}
				num = (short)2119434240;
				short num3 = num;
				num = (short)166395904;
				if (num != 0)
				{
				}
				this.<HotlistContactAlias>k__BackingField = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x0020E66C File Offset: 0x0020C86C
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x0020E71C File Offset: 0x0020C91C
		public string HotlistContactCallId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1695637246;
				short num2 = num;
				num = (short)620191486;
				switch (num2 == num)
				{
				}
				num = (short)760479745;
				if (num != 0)
				{
				}
				num = (short)546111488;
				short num3 = num;
				num = (short)559480832;
				if (num != 0)
				{
				}
				return this.<HotlistContactCallId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1068656665;
				short num2 = num;
				num = (short)577792025;
				switch (num2 == num)
				{
				}
				num = (short)1400438784;
				if (num != 0)
				{
				}
				num = (short)1114963968;
				short num3 = num;
				num = (short)949354497;
				if (num != 0)
				{
				}
				this.<HotlistContactCallId>k__BackingField = value;
			}
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00003C59 File Offset: 0x00001E59
		private DTMFCallList() : this(null)
		{
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0020E7CC File Offset: 0x0020C9CC
		public DTMFCallList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 11;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("춍ﺑ뚕풗", a_);
			this.HotlistParentRecsetId = 2216;
			this.HotlistParentSectionId = 10423;
			this.HotlistRecsetId = 2217;
			this.HotlistSectionId = 10424;
			this.CalllistContactAliasSectionId = 10400;
			this.CalllistContactAlias = global::CommonResources.AppResources.Contact_Alias;
			this.HotlistContactAlias = global::CommonResources.AppResources.Contact_Alias;
			this.HotlistContactCallId = global::CommonResources.AppResources.Call_ID;
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.Contact.DTMFCallListCallListSection(this));
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x0020E864 File Offset: 0x0020CA64
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1996289689;
			short num2 = num;
			num = (short)1820391065;
			switch (num2 == num)
			{
			}
			num = (short)941817856;
			if (num != 0)
			{
			}
			num = (short)333381632;
			short num3 = num;
			num = (short)1730412545;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x000038AD File Offset: 0x00001AAD
		protected DTMFCallList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
