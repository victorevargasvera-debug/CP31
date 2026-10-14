using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200021E RID: 542
	[global::System.Serializable]
	public sealed class UclContactTrunkingT2CallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001BB0 RID: 7088 RVA: 0x00003E9B File Offset: 0x0000209B
		internal UclContactTrunkingT2CallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.trunkingT2CallListRecset;
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001BB1 RID: 7089 RVA: 0x0023B680 File Offset: 0x00239880
		internal global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset TrunkingT2CallListRecset
		{
			get
			{
				short num = (short)1611529111;
				short num2 = num;
				num = (short)1042283415;
				switch (num2 == num)
				{
				}
				num = (short)1419968513;
				if (num != 0)
				{
				}
				num = (short)670302208;
				short num3 = num;
				num = (short)822738944;
				if (num != 0)
				{
				}
				return this.trunkingT2CallListRecset;
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0023B730 File Offset: 0x00239930
		public override void PopulateReferences()
		{
			short num = (short)1354498049;
			if (num != 0)
			{
			}
			num = (short)572228426;
			short num2 = num;
			num = (short)1172996938;
			switch (num2 == num)
			{
			}
			num = (short)552534016;
			short num3 = num;
			num = (short)203292672;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0023B7D8 File Offset: 0x002399D8
		public override void DropReferences()
		{
			short num = (short)1053723632;
			short num2 = num;
			num = (short)90868720;
			switch (num2 == num)
			{
			}
			num = (short)1369833472;
			if (num != 0)
			{
			}
			num = (short)2063138816;
			short num3 = num;
			num = (short)26148865;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0023B880 File Offset: 0x00239A80
		public override void SetupDependencies()
		{
			short num = (short)709752342;
			short num2 = num;
			num = (short)901314070;
			switch (num2 == num)
			{
			}
			num = (short)959971328;
			if (num != 0)
			{
			}
			num = (short)154927104;
			short num3 = num;
			num = (short)2104360961;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x0023B928 File Offset: 0x00239B28
		public override void SetConstraints()
		{
			short num = (short)593486407;
			short num2 = num;
			num = (short)75489863;
			switch (num2 == num)
			{
			}
			num = (short)570359809;
			if (num != 0)
			{
			}
			num = (short)95813632;
			short num3 = num;
			num = (short)1866727424;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x0023B9D4 File Offset: 0x00239BD4
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1610871243;
			short num2 = num;
			num = (short)1572598219;
			switch (num2 == num)
			{
			}
			num = (short)1600520193;
			if (num != 0)
			{
			}
			num = (short)1586233344;
			short num3 = num;
			num = (short)1221328896;
			if (num != 0)
			{
			}
			this.trunkingT2CallListRecset = new global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset();
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슕鍊뺝蒣\udaa7\udfa9슫얭\ud9af\udcb1펳隵ﺹ", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_ID;
			base.Id = 10411;
			base.DataTransferOrder = 15;
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x0023BAC8 File Offset: 0x00239CC8
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1159397377;
			if (num != 0)
			{
			}
			num = (short)1963074195;
			short num2 = num;
			num = (short)1447568019;
			switch (num2 == num)
			{
			}
			num = (short)774701056;
			short num3 = num;
			num = (short)174587904;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x0023BB78 File Offset: 0x00239D78
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)504037377;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_115;
				case 1:
					goto IL_1E;
				case 2:
				{
					num = (short)603387094;
					short num3 = num;
					num = (short)86045910;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
					{
						num = (short)1030029312;
						short num4 = num;
						num = (short)1459224576;
						if (num != 0)
						{
						}
						num = (short)729808897;
						if (num != 0)
						{
						}
						num = (short)587333632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_3A;
				IL_1E:
				switch (0)
				{
				case 0:
					IL_3A:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_117;
					}
					num = (short)2094006274;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_115:
			IL_117:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude89ﺍ늑\udd93\udf95뢗캙캟즡춣좥쾧誩", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_ID;
			base.Id = 10411;
			base.DataTransferOrder = 15;
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclContactTrunkingT2CallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0023BCD0 File Offset: 0x00239ED0
		public bool HasDiffs
		{
			get
			{
				short num = (short)532070832;
				short num2 = num;
				num = (short)2013446576;
				switch (num2 == num)
				{
				}
				num = (short)1668546561;
				if (num != 0)
				{
				}
				num = (short)2031550464;
				short num3 = num;
				num = (short)1167982592;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000DAB RID: 3499
		private global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
	}
}
