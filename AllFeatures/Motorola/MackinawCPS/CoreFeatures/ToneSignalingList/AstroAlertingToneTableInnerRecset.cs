using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001BD RID: 445
	[global::System.Serializable]
	public class AstroAlertingToneTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060051F9 RID: 20985 RVA: 0x004A81B8 File Offset: 0x004A63B8
		public AstroAlertingToneTableInnerRecset() : base(global::CommonResources.AcgResources.ID_TONESIGNALINGTABLE, global::CommonResources.AcgResources.ID_TONEALIAS)
		{
			this.SetValues();
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x004A81DC File Offset: 0x004A63DC
		public AstroAlertingToneTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x060051FB RID: 20987 RVA: 0x004A8208 File Offset: 0x004A6408
		public override int MaxPool
		{
			get
			{
				short num = (short)1527930545;
				short num2 = num;
				num = (short)119234225;
				switch (num2 == num)
				{
				}
				num = (short)2129854464;
				short num3 = num;
				num = (short)229638144;
				if (num != 0)
				{
				}
				num = (short)306708481;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x004A82B8 File Offset: 0x004A64B8
		// (set) Token: 0x060051FD RID: 20989 RVA: 0x004A8378 File Offset: 0x004A6578
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax != -1)
				{
					num = (short)2103405511;
					short num2 = num;
					num = (short)1207266247;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1761345537;
						if (num != 0)
						{
						}
						num = (short)933756928;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)37552128;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset._Max;
			}
			set
			{
				short num = (short)675414550;
				short num2 = num;
				num = (short)1337917974;
				switch (num2 == num)
				{
				}
				num = (short)762183681;
				if (num != 0)
				{
				}
				num = (short)1495465984;
				if (num != 0)
				{
				}
				num = (short)1477246976;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x004A8428 File Offset: 0x004A6628
		public override int Min
		{
			get
			{
				short num = (short)429217218;
				short num2 = num;
				num = (short)386946498;
				switch (num2 == num)
				{
				}
				num = (short)1619263489;
				if (num != 0)
				{
				}
				num = (short)805896192;
				if (num != 0)
				{
				}
				num = (short)974651392;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset._Min;
			}
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x060051FF RID: 20991 RVA: 0x004A84D4 File Offset: 0x004A66D4
		// (set) Token: 0x06005200 RID: 20992 RVA: 0x004A8588 File Offset: 0x004A6788
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1324082466;
				short num2 = num;
				num = (short)911664418;
				switch (num2 == num)
				{
				}
				num = (short)809566209;
				if (num != 0)
				{
				}
				num = (short)2071855104;
				if (num != 0)
				{
				}
				num = (short)1998782464;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1887594242;
				short num2 = num;
				num = (short)1407739650;
				switch (num2 == num)
				{
				}
				num = (short)801636352;
				if (num != 0)
				{
				}
				num = (short)419037185;
				if (num != 0)
				{
				}
				num = (short)14876672;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x06005201 RID: 20993 RVA: 0x004A8638 File Offset: 0x004A6838
		public bool HasDiffs
		{
			get
			{
				short num = (short)1792950863;
				short num2 = num;
				num = (short)1580548687;
				switch (num2 == num)
				{
				}
				num = (short)902955008;
				if (num != 0)
				{
				}
				num = (short)1815740417;
				if (num != 0)
				{
				}
				num = (short)202440704;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x004A86E8 File Offset: 0x004A68E8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)759493125;
			short num2 = num;
			num = (short)1397289477;
			switch (num2 == num)
			{
			}
			num = (short)953417728;
			if (num != 0)
			{
			}
			num = (short)1687355393;
			if (num != 0)
			{
			}
			num = (short)124518400;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner(this);
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x004A8798 File Offset: 0x004A6998
		internal void SetValues()
		{
			short num = (short)1170382836;
			short num2 = num;
			num = (short)418684916;
			switch (num2 == num)
			{
			}
			num = (short)2096168961;
			if (num != 0)
			{
			}
			num = (short)1464401920;
			if (num != 0)
			{
			}
			num = (short)1233321984;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_TONEALIAS;
			base.DataTransferOrder = 1000;
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x004A8870 File Offset: 0x004A6A70
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)2016411649;
			if (num != 0)
			{
			}
			num = (short)330691299;
			short num2 = num;
			num = (short)477164259;
			switch (num2 == num)
			{
			}
			num = (short)2004680704;
			if (num != 0)
			{
			}
			num = (short)1327104000;
			short num3 = num;
			base.OnFinishedAddRecord();
			this.c(record);
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x004A8928 File Offset: 0x004A6B28
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)829358081;
			if (num != 0)
			{
			}
			num = (short)244471865;
			short num2 = num;
			num = (short)1053120569;
			switch (num2 == num)
			{
			}
			num = (short)1403650048;
			if (num != 0)
			{
			}
			num = (short)1699807232;
			short num3 = num;
			base.OnFinishedRemoveRecord();
			this.b(record);
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x004A89E0 File Offset: 0x004A6BE0
		protected override void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode record, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			short num = (short)1829663039;
			short num2 = num;
			num = (short)1044410687;
			switch (num2 == num)
			{
			}
			num = (short)957349889;
			if (num != 0)
			{
			}
			num = (short)242810880;
			if (num != 0)
			{
			}
			num = (short)1511063552;
			short num3 = num;
			base.OnFinishedMoveRecord();
			this.a(record, targetRecord);
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x004A8A9C File Offset: 0x004A6C9C
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1076892379;
			short num2 = num;
			num = (short)200151771;
			switch (num2 == num)
			{
			}
			num = (short)481886208;
			if (num != 0)
			{
			}
			num = (short)26345473;
			if (num != 0)
			{
			}
			num = (short)1588396032;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x004A8B4C File Offset: 0x004A6D4C
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1302162751;
			short num2 = num;
			num = (short)1965255999;
			switch (num2 == num)
			{
			}
			num = (short)2081292289;
			if (num != 0)
			{
			}
			num = (short)47710208;
			if (num != 0)
			{
			}
			num = (short)1782120448;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x004A8C00 File Offset: 0x004A6E00
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			short num = (short)284295169;
			if (num != 0)
			{
			}
			num = (short)777348794;
			short num2 = num;
			num = (short)2140038842;
			switch (num2 == num)
			{
			}
			num = (short)912785408;
			if (num != 0)
			{
			}
			num = (short)622919680;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x004A8CB0 File Offset: 0x004A6EB0
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1768161286;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num = (short)1192034309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset).GetEnumerator();
					num = (short)1969750018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)738721795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_2FE;
				case 3:
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						num = (short)912850948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					num = (short)865730560;
					short num3 = num;
					num = (short)804716544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_2D0;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				num = (short)926482433;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.UnpackOperation)
				{
					break;
				}
				num = (short)465895425;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_2D0:
			return;
			IL_2FE:
			try
			{
				num = (short)1430192134;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner astroAlertingToneTableInner;
						if (astroAlertingToneTableInner != null)
						{
							num = (short)922615813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)894828547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner astroAlertingToneTableInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner;
						num = (short)150536192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_17D;
					case 3:
						num = (short)525336578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner astroAlertingToneTableInner;
						astroAlertingToneTableInner.AstroAlertingToneTableInnerSection.CalculateApplicability();
						num = (short)177405956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					}
					IL_CF:
					num = (short)1579417601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CD:
					goto IL_CF;
				}
				IL_17D:
				return;
			}
			finally
			{
				num = (short)287899650;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)130915054;
					short num4 = num;
					num = (short)2012977902;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_238;
					default:
					{
						num = (short)729808896;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_236;
						case 1:
							enumerator.Dispose();
							num = (short)872939520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1FF;
							}
							continue;
						}
						IL_1FF:
						if (enumerator == null)
						{
							goto IL_238;
						}
						num = (short)288292865;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_236:
				IL_238:;
			}
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x004A8FD0 File Offset: 0x004A71D0
		// Note: this type is marked as 'beforefieldinit'.
		static AstroAlertingToneTableInnerRecset()
		{
			short num = (short)2096590406;
			short num2 = num;
			num = (short)18837062;
			switch (num2 == num)
			{
			}
			num = (short)373293057;
			if (num != 0)
			{
			}
			num = (short)848887808;
			if (num != 0)
			{
			}
			num = (short)1415708672;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerRecset._Min = 1;
		}

		// Token: 0x04001F22 RID: 7970
		public static int _MaxPool;

		// Token: 0x04001F23 RID: 7971
		public static int _Max;

		// Token: 0x04001F24 RID: 7972
		public int _DynMax;

		// Token: 0x04001F25 RID: 7973
		public static int _Min;

		// Token: 0x04001F26 RID: 7974
		public static int _DefaultRecordCount;
	}
}
