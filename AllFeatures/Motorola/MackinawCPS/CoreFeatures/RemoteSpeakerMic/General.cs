using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic
{
	// Token: 0x020002D8 RID: 728
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060077F0 RID: 30704 RVA: 0x006CE5B0 File Offset: 0x006CC7B0
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x006CE5F0 File Offset: 0x006CC7F0
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x006CE608 File Offset: 0x006CC808
		public override void Init()
		{
			int a_ = 19;
			short num = (short)201850880;
			short num2 = num;
			num = (short)2071519240;
			short num3 = num;
			num = (short)602660872;
			switch (num3 == num)
			{
			}
			num = (short)1293877249;
			if (num != 0)
			{
			}
			num = (short)798490624;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏓돕뛗뿙껛뿝賟", a_);
			base.Id = 10079;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x006CE6EC File Offset: 0x006CC8EC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)1070530560;
			short num2 = num;
			num = (short)1099368594;
			short num3 = num;
			num = (short)835782802;
			switch (num3 == num)
			{
			}
			num = (short)724041728;
			if (num != 0)
			{
			}
			num = (short)736493569;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賊꣌ꇎ듐ꇒ듔믖", a_);
			base.Id = 10079;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x006CE7D0 File Offset: 0x006CC9D0
		public override void PopulateReferences()
		{
			short num = (short)932315136;
			short num2 = num;
			num = (short)874382171;
			short num3 = num;
			num = (short)1697383259;
			switch (num3 == num)
			{
			}
			num = (short)771096576;
			if (num != 0)
			{
			}
			num = (short)1144061953;
			if (num != 0)
			{
			}
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x006CE87C File Offset: 0x006CCA7C
		public override void DropReferences()
		{
			short num = (short)2019688448;
			short num2 = num;
			num = (short)991821825;
			if (num != 0)
			{
			}
			num = (short)658232219;
			short num3 = num;
			num = (short)502256539;
			switch (num3 == num)
			{
			}
			num = (short)1428357120;
			if (num != 0)
			{
			}
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x006CE924 File Offset: 0x006CCB24
		public override void SetConstraints()
		{
			short num = (short)761790464;
			short num2 = num;
			num = (short)1405473881;
			short num3 = num;
			num = (short)2025772121;
			switch (num3 == num)
			{
			}
			num = (short)1269956609;
			if (num != 0)
			{
			}
			num = (short)712835072;
			if (num != 0)
			{
			}
		}

		// Token: 0x060077F7 RID: 30711 RVA: 0x006CE9CC File Offset: 0x006CCBCC
		public override void SetupDependencies()
		{
			short num = (short)1521680384;
			short num2 = num;
			num = (short)195239394;
			short num3 = num;
			num = (short)647306722;
			switch (num3 == num)
			{
			}
			num = (short)376766464;
			if (num != 0)
			{
			}
			num = (short)528875521;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x060077F8 RID: 30712 RVA: 0x006CEA78 File Offset: 0x006CCC78
		public bool HasDiffs
		{
			get
			{
				short num = (short)933429248;
				short num2 = num;
				num = (short)1617887233;
				if (num != 0)
				{
				}
				num = (short)2113205197;
				short num3 = num;
				num = (short)2099508173;
				switch (num3 == num)
				{
				}
				num = (short)62849024;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x006CEB24 File Offset: 0x006CCD24
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num2 = (short)2015100930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					return result;
				case 2:
					goto IL_5B;
				case 3:
				{
					num2 = (short)1099355342;
					short num3 = num2;
					num2 = (short)543937742;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5B;
					default:
						num2 = (short)1310326784;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1452212225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)283836419;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_5B:
				num2 = (short)1959526401;
				if (num2 != 0)
				{
				}
				num2 = (short)795738112;
				short num4 = num2;
				num2 = (short)1172307972;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)2063007744;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040032B1 RID: 12977
		private global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset innerRecset;
	}
}
