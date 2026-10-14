using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200021C RID: 540
	[global::System.Serializable]
	public sealed class UclContactQCIICallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x00003E65 File Offset: 0x00002065
		public UclContactQCIICallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.qCIICallListRecset;
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x0023A944 File Offset: 0x00238B44
		public global::SpecialFeatures.Ucl.Contact.QCIICallListRecset QCIICallListRecset
		{
			get
			{
				short num = (short)934346753;
				if (num != 0)
				{
				}
				num = (short)167878576;
				short num2 = num;
				num = (short)1666293680;
				switch (num2 == num)
				{
				}
				num = (short)939982848;
				short num3 = num;
				num = (short)1134166016;
				if (num != 0)
				{
				}
				return this.qCIICallListRecset;
			}
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x0023A9F4 File Offset: 0x00238BF4
		public override void PopulateReferences()
		{
			short num = (short)1584872157;
			short num2 = num;
			num = (short)1784953565;
			switch (num2 == num)
			{
			}
			num = (short)758185984;
			if (num != 0)
			{
			}
			num = (short)816840704;
			short num3 = num;
			num = (short)1130823681;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0023AAA0 File Offset: 0x00238CA0
		public override void DropReferences()
		{
			short num = (short)504884882;
			short num2 = num;
			num = (short)670166674;
			switch (num2 == num)
			{
			}
			num = (short)625672193;
			if (num != 0)
			{
			}
			num = (short)255262720;
			short num3 = num;
			num = (short)820248576;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x0023AB48 File Offset: 0x00238D48
		public override void SetupDependencies()
		{
			short num = (short)1348589662;
			short num2 = num;
			num = (short)1033623646;
			switch (num2 == num)
			{
			}
			num = (short)732692481;
			if (num != 0)
			{
			}
			num = (short)1767702528;
			short num3 = num;
			num = (short)789250048;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x0023ABF0 File Offset: 0x00238DF0
		public override void SetConstraints()
		{
			short num = (short)1935667932;
			short num2 = num;
			num = (short)571667164;
			switch (num2 == num)
			{
			}
			num = (short)1062928385;
			if (num != 0)
			{
			}
			num = (short)1350172672;
			short num3 = num;
			num = (short)630456320;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x0023AC98 File Offset: 0x00238E98
		public override void Init()
		{
			int a_ = 15;
			short num = (short)728615472;
			short num2 = num;
			num = (short)667470384;
			switch (num2 == num)
			{
			}
			num = (short)387645441;
			if (num != 0)
			{
			}
			num = (short)769720320;
			short num3 = num;
			num = (short)1075904512;
			if (num != 0)
			{
			}
			this.qCIICallListRecset = new global::SpecialFeatures.Ucl.Contact.QCIICallListRecset();
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎑힓\udf95톗몙\udf9bﾝ첟캡蒣솧\ud9a9\ud8ab", a_);
			base.UIName = global::CommonResources.AppResources.QCII_Call_List;
			base.Id = 10409;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0023AD88 File Offset: 0x00238F88
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)958915918;
			short num2 = num;
			num = (short)1926948174;
			switch (num2 == num)
			{
			}
			num = (short)2099904512;
			if (num != 0)
			{
			}
			num = (short)674824192;
			short num3 = num;
			num = (short)330891265;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0023AE3C File Offset: 0x0023903C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1757282305;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_112;
				case 1:
					goto IL_1F;
				case 2:
				{
					num = (short)109360363;
					short num3 = num;
					num = (short)1553839339;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F;
					default:
					{
						num = (short)1901395968;
						short num4 = num;
						num = (short)838860801;
						if (num != 0)
						{
						}
						num = (short)894828544;
						if (num != 0)
						{
						}
						num = (short)1171980288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_3B;
				IL_1F:
				switch (0)
				{
				case 0:
					IL_3B:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_114;
					}
					num = (short)2002255874;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_112:
			IL_114:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얓햕톗펙벛\udd9d솟캡좣蚥쎩\udfab\udaad", a_);
			base.UIName = global::CommonResources.AppResources.QCII_Call_List;
			base.Id = 10409;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclContactQCIICallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000DA9 RID: 3497
		private global::SpecialFeatures.Ucl.Contact.QCIICallListRecset qCIICallListRecset;
	}
}
