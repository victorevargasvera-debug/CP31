using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x02000519 RID: 1305
	[global::System.Serializable]
	public class MDCRepeaterIDList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B129 RID: 45353 RVA: 0x00A43D18 File Offset: 0x00A41F18
		public MDCRepeaterIDList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x00A43D58 File Offset: 0x00A41F58
		protected MDCRepeaterIDList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x00A43D70 File Offset: 0x00A41F70
		public override void Init()
		{
			int a_ = 1;
			short num = (short)261465129;
			short num2 = num;
			num = (short)709469225;
			switch (num2 == num)
			{
			}
			num = (short)1788280833;
			if (num != 0)
			{
			}
			num = (short)753270784;
			if (num != 0)
			{
			}
			num = (short)105971712;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迁胃藅飉꧋뻍뗏돑ꃓ돕꫗龎闛髝샟껡跣闥鳧", a_);
			base.Id = 10077;
			base.UIName = global::CommonResources.AcgResources.ID_MDCREPEATERIDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x00A43E54 File Offset: 0x00A42054
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)1310295094;
			short num2 = num;
			num = (short)2000585782;
			switch (num2 == num)
			{
			}
			num = (short)976879616;
			if (num != 0)
			{
			}
			num = (short)1614610433;
			if (num != 0)
			{
			}
			num = (short)1968373760;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觃苅诇黋ꯍꃏ럑뗓ꋕ뷗꣙ﳛ韝ꓟ싡꣣迥鯧黩", a_);
			base.Id = 10077;
			base.UIName = global::CommonResources.AcgResources.ID_MDCREPEATERIDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x00A43F38 File Offset: 0x00A42138
		public override void PopulateReferences()
		{
			short num = (short)2006946447;
			short num2 = num;
			num = (short)1978372751;
			switch (num2 == num)
			{
			}
			num = (short)2038890496;
			if (num != 0)
			{
			}
			num = (short)1040711681;
			if (num != 0)
			{
			}
			num = (short)2017722368;
			short num3 = num;
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x00A43FE4 File Offset: 0x00A421E4
		public override void DropReferences()
		{
			short num = (short)563949791;
			short num2 = num;
			num = (short)1163079903;
			switch (num2 == num)
			{
			}
			num = (short)1490681856;
			if (num != 0)
			{
			}
			num = (short)581304321;
			if (num != 0)
			{
			}
			num = (short)2106851328;
			short num3 = num;
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x00A4408C File Offset: 0x00A4228C
		public override void SetConstraints()
		{
			short num = (short)1460359615;
			short num2 = num;
			num = (short)506220991;
			switch (num2 == num)
			{
			}
			num = (short)193921025;
			if (num != 0)
			{
			}
			num = (short)845873152;
			if (num != 0)
			{
			}
			num = (short)464715776;
			short num3 = num;
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x00A44134 File Offset: 0x00A42334
		public override void SetupDependencies()
		{
			short num = (short)1629945857;
			if (num != 0)
			{
			}
			num = (short)1155372780;
			short num2 = num;
			num = (short)1132631788;
			switch (num2 == num)
			{
			}
			num = (short)1778319360;
			if (num != 0)
			{
			}
			num = (short)1813970944;
			short num3 = num;
		}

		// Token: 0x170058F5 RID: 22773
		// (get) Token: 0x0600B131 RID: 45361 RVA: 0x00A441DC File Offset: 0x00A423DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)2127246096;
				short num2 = num;
				num = (short)1002976016;
				switch (num2 == num)
				{
				}
				num = (short)297271297;
				if (num != 0)
				{
				}
				num = (short)67043328;
				if (num != 0)
				{
				}
				num = (short)21889024;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x00A4428C File Offset: 0x00A4248C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)362084440;
					short num3 = num2;
					num2 = (short)81197144;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_149;
					default:
						num2 = (short)2016280576;
						if (num2 != 0)
						{
						}
						num2 = (short)740098049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					num2 = (short)1892810755;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_149;
					}
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)758448129;
						if (num2 != 0)
						{
						}
						num2 = (short)425263106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_149:
				num2 = (short)2059075584;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1108344832;
			short num4 = num2;
			num2 = (short)557711364;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040053F8 RID: 21496
		private global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset innerRecset;
	}
}
