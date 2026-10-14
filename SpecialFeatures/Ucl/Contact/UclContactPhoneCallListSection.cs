using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200021B RID: 539
	[global::System.Serializable]
	public sealed class UclContactPhoneCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001B90 RID: 7056 RVA: 0x00003E4A File Offset: 0x0000204A
		public UclContactPhoneCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.phoneCallListRecset;
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x0023A234 File Offset: 0x00238434
		public global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset PhoneCallListRecset
		{
			get
			{
				short num = (short)253598458;
				short num2 = num;
				num = (short)1087150842;
				switch (num2 == num)
				{
				}
				num = (short)534511617;
				if (num != 0)
				{
				}
				num = (short)227868672;
				if (num != 0)
				{
				}
				num = (short)170131456;
				short num3 = num;
				return this.phoneCallListRecset;
			}
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0023A2E8 File Offset: 0x002384E8
		public override void PopulateReferences()
		{
			short num = (short)514302659;
			short num2 = num;
			num = (short)19505859;
			switch (num2 == num)
			{
			}
			num = (short)66650113;
			if (num != 0)
			{
			}
			num = (short)410779648;
			if (num != 0)
			{
			}
			num = (short)557383680;
			short num3 = num;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0023A390 File Offset: 0x00238590
		public override void DropReferences()
		{
			short num = (short)1530582865;
			short num2 = num;
			num = (short)954652497;
			switch (num2 == num)
			{
			}
			num = (short)1968766976;
			if (num != 0)
			{
			}
			num = (short)1769472001;
			if (num != 0)
			{
			}
			num = (short)106692608;
			short num3 = num;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0023A440 File Offset: 0x00238640
		public override void SetupDependencies()
		{
			short num = (short)947277526;
			short num2 = num;
			num = (short)437472982;
			switch (num2 == num)
			{
			}
			num = (short)1832058881;
			if (num != 0)
			{
			}
			num = (short)1345388544;
			short num3 = num;
			num = (short)1694236672;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x0023A4EC File Offset: 0x002386EC
		public override void SetConstraints()
		{
			short num = (short)361365505;
			if (num != 0)
			{
			}
			num = (short)827323597;
			short num2 = num;
			num = (short)567866573;
			switch (num2 == num)
			{
			}
			num = (short)23855104;
			short num3 = num;
			num = (short)1418461184;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0023A598 File Offset: 0x00238798
		public override void Init()
		{
			int a_ = 11;
			short num = (short)575012865;
			if (num != 0)
			{
			}
			num = (short)1981324539;
			short num2 = num;
			num = (short)260087035;
			switch (num2 == num)
			{
			}
			num = (short)1176305664;
			short num3 = num;
			num = (short)1265827840;
			if (num != 0)
			{
			}
			this.phoneCallListRecset = new global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset();
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8d﶑望뢗풙슟잡횣", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Number;
			base.Id = 10413;
			base.DataTransferOrder = 12;
		}

		// Token: 0x06001B97 RID: 7063 RVA: 0x0023A68C File Offset: 0x0023888C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)481542031;
			short num2 = num;
			num = (short)1764802447;
			switch (num2 == num)
			{
			}
			num = (short)1320026113;
			if (num != 0)
			{
			}
			num = (short)1722810368;
			short num3 = num;
			num = (short)325451776;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0023A740 File Offset: 0x00238940
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)1370619905;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EA;
				case 1:
					goto IL_1D;
				case 2:
				{
					num = (short)787059549;
					short num3 = num;
					num = (short)180327261;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
					{
						num = (short)1452539904;
						short num4 = num;
						num = (short)1719533568;
						if (num != 0)
						{
						}
						num = (short)1039794176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_39;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_39:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_112;
					}
					num = (short)375455746;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EA:
			num = (short)393019393;
			if (num != 0)
			{
			}
			IL_112:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8cﺐﶒ랖힘ﶞ쒠톢", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Number;
			base.Id = 10413;
			base.DataTransferOrder = 12;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclContactPhoneCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0023A894 File Offset: 0x00238A94
		public bool HasDiffs
		{
			get
			{
				short num = (short)460980225;
				if (num != 0)
				{
				}
				num = (short)389396455;
				short num2 = num;
				num = (short)2040182759;
				switch (num2 == num)
				{
				}
				num = (short)879362048;
				short num3 = num;
				num = (short)177274880;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000DA8 RID: 3496
		private global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset phoneCallListRecset;
	}
}
