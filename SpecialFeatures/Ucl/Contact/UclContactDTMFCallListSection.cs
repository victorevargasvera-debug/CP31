using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000216 RID: 534
	[global::System.Serializable]
	public sealed class UclContactDTMFCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001B49 RID: 6985 RVA: 0x00003E14 File Offset: 0x00002014
		public UclContactDTMFCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.dTMFCallListRecset;
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x00233D48 File Offset: 0x00231F48
		public global::SpecialFeatures.Ucl.Contact.DTMFCallListRecset DTMFCallListRecset
		{
			get
			{
				short num = (short)1962700570;
				short num2 = num;
				num = (short)603877146;
				switch (num2 == num)
				{
				}
				num = (short)116981761;
				if (num != 0)
				{
				}
				num = (short)220069888;
				if (num != 0)
				{
				}
				num = (short)99942400;
				short num3 = num;
				return this.dTMFCallListRecset;
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00233DF8 File Offset: 0x00231FF8
		public override void PopulateReferences()
		{
			short num = (short)1426980864;
			short num2 = num;
			num = (short)44243213;
			short num3 = num;
			num = (short)1251678477;
			switch (num3 == num)
			{
			}
			num = (short)131399681;
			if (num != 0)
			{
			}
			num = (short)1549795328;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00233EA4 File Offset: 0x002320A4
		public override void DropReferences()
		{
			short num = (short)86900736;
			short num2 = num;
			num = (short)1852413005;
			short num3 = num;
			num = (short)1977455693;
			switch (num3 == num)
			{
			}
			num = (short)2130575361;
			if (num != 0)
			{
			}
			num = (short)729939968;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00233F4C File Offset: 0x0023214C
		public override void SetupDependencies()
		{
			short num = (short)1766785024;
			short num2 = num;
			num = (short)956243306;
			short num3 = num;
			num = (short)162733418;
			switch (num3 == num)
			{
			}
			num = (short)2146304001;
			if (num != 0)
			{
			}
			num = (short)220528640;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00233FF4 File Offset: 0x002321F4
		public override void SetConstraints()
		{
			short num = (short)727121920;
			short num2 = num;
			num = (short)32167383;
			short num3 = num;
			num = (short)1545655767;
			switch (num3 == num)
			{
			}
			num = (short)572325889;
			if (num != 0)
			{
			}
			num = (short)421855232;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x0023409C File Offset: 0x0023229C
		public override void Init()
		{
			int a_ = 14;
			short num = (short)601751552;
			short num2 = num;
			num = (short)142017891;
			short num3 = num;
			num = (short)910099811;
			switch (num3 == num)
			{
			}
			num = (short)1320615937;
			if (num != 0)
			{
			}
			num = (short)772210688;
			if (num != 0)
			{
			}
			this.dTMFCallListRecset = new global::SpecialFeatures.Ucl.Contact.DTMFCallListRecset();
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햐잒\ud894톖릘\ud89aﲜ춠莢캦\udaa8\udfaa", a_);
			base.UIName = global::CommonResources.AppResources.DTMF_Call_List;
			base.Id = 10407;
			base.DataTransferOrder = 9;
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x0023418C File Offset: 0x0023238C
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1544486912;
			short num2 = num;
			num = (short)861750826;
			short num3 = num;
			num = (short)1544373802;
			switch (num3 == num)
			{
			}
			num = (short)781778945;
			if (num != 0)
			{
			}
			num = (short)893911040;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00234240 File Offset: 0x00232440
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)245956609;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)399966209;
					if (num != 0)
					{
					}
					num = (short)670629888;
					short num3 = num;
					num = (short)280363010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					goto IL_10D;
				}
				IL_3A:
				num = (short)1972164883;
				short num4 = num;
				num = (short)1337579795;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_10F;
				default:
					num = (short)446496768;
					if (num != 0)
					{
					}
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_10F;
					}
					num = (short)2033975296;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10D:
			IL_10F:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎆\udd88욊쮌꾎튐璉ﮖ릘힚햠", a_);
			base.UIName = global::CommonResources.AppResources.DTMF_Call_List;
			base.Id = 10407;
			base.DataTransferOrder = 9;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclContactDTMFCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000CCD RID: 3277
		private global::SpecialFeatures.Ucl.Contact.DTMFCallListRecset dTMFCallListRecset;
	}
}
