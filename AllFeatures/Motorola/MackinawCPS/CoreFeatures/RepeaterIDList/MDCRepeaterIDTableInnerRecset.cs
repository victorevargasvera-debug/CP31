using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x0200051B RID: 1307
	[global::System.Serializable]
	public class MDCRepeaterIDTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B136 RID: 45366 RVA: 0x00A4453C File Offset: 0x00A4273C
		public MDCRepeaterIDTableInnerRecset() : base(global::CommonResources.AcgResources.ID_MDCREPEATERIDTABLE)
		{
			this.SetValues();
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x00A4455C File Offset: 0x00A4275C
		public MDCRepeaterIDTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170058F7 RID: 22775
		// (get) Token: 0x0600B138 RID: 45368 RVA: 0x00A44588 File Offset: 0x00A42788
		public override int MaxPool
		{
			get
			{
				short num = (short)654906431;
				short num2 = num;
				num = (short)1526404159;
				switch (num2 == num)
				{
				}
				num = (short)657784833;
				if (num != 0)
				{
				}
				num = (short)102301696;
				if (num != 0)
				{
				}
				num = (short)819265536;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x170058F8 RID: 22776
		// (get) Token: 0x0600B139 RID: 45369 RVA: 0x00A44638 File Offset: 0x00A42838
		// (set) Token: 0x0600B13A RID: 45370 RVA: 0x00A446F8 File Offset: 0x00A428F8
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax == -1)
				{
					num = (short)961336723;
					short num2 = num;
					num = (short)1381553555;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1127874561;
						if (num != 0)
						{
						}
						num = (short)1563099136;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset._Max;
					}
				}
				num = (short)1858076672;
				short num3 = num;
				return this._DynMax;
			}
			set
			{
				short num = (short)215450775;
				short num2 = num;
				num = (short)2010547351;
				switch (num2 == num)
				{
				}
				num = (short)2083717121;
				if (num != 0)
				{
				}
				num = (short)45350912;
				if (num != 0)
				{
				}
				num = (short)1675886592;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170058F9 RID: 22777
		// (get) Token: 0x0600B13B RID: 45371 RVA: 0x00A447AC File Offset: 0x00A429AC
		public override int Min
		{
			get
			{
				short num = (short)1121670927;
				short num2 = num;
				num = (short)758470415;
				switch (num2 == num)
				{
				}
				num = (short)1895432193;
				if (num != 0)
				{
				}
				num = (short)1688010752;
				if (num != 0)
				{
				}
				num = (short)602537984;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset._Min;
			}
		}

		// Token: 0x170058FA RID: 22778
		// (get) Token: 0x0600B13C RID: 45372 RVA: 0x00A4485C File Offset: 0x00A42A5C
		// (set) Token: 0x0600B13D RID: 45373 RVA: 0x00A4490C File Offset: 0x00A42B0C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1525350401;
				if (num != 0)
				{
				}
				num = (short)1750559450;
				short num2 = num;
				num = (short)242838234;
				switch (num2 == num)
				{
				}
				num = (short)1612382208;
				if (num != 0)
				{
				}
				num = (short)1147404288;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)774832129;
				if (num != 0)
				{
				}
				num = (short)990983129;
				short num2 = num;
				num = (short)1446786009;
				switch (num2 == num)
				{
				}
				num = (short)1623195648;
				if (num != 0)
				{
				}
				num = (short)1350696960;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170058FB RID: 22779
		// (get) Token: 0x0600B13E RID: 45374 RVA: 0x00A449BC File Offset: 0x00A42BBC
		public bool HasDiffs
		{
			get
			{
				short num = (short)577034981;
				short num2 = num;
				num = (short)1133370085;
				switch (num2 == num)
				{
				}
				num = (short)1864957953;
				if (num != 0)
				{
				}
				num = (short)1751515136;
				if (num != 0)
				{
				}
				num = (short)638451712;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x00A44A70 File Offset: 0x00A42C70
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1906086347;
			short num2 = num;
			num = (short)1501401547;
			switch (num2 == num)
			{
			}
			num = (short)699006977;
			if (num != 0)
			{
			}
			num = (short)981532672;
			if (num != 0)
			{
			}
			num = (short)1158152192;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInner(this);
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x00A44B20 File Offset: 0x00A42D20
		internal void SetValues()
		{
			short num = (short)825163777;
			if (num != 0)
			{
			}
			num = (short)1142883355;
			short num2 = num;
			num = (short)1164444699;
			switch (num2 == num)
			{
			}
			num = (short)577437696;
			if (num != 0)
			{
			}
			num = (short)331612160;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_MDCREPEATERIDTABLE;
			base.DataTransferOrder = 33;
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x00A44BE8 File Offset: 0x00A42DE8
		// Note: this type is marked as 'beforefieldinit'.
		static MDCRepeaterIDTableInnerRecset()
		{
			short num = (short)657302899;
			short num2 = num;
			num = (short)1156359539;
			switch (num2 == num)
			{
			}
			num = (short)2109800449;
			if (num != 0)
			{
			}
			num = (short)2055471104;
			if (num != 0)
			{
			}
			num = (short)2013724672;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerRecset._Min = 1;
		}

		// Token: 0x040053F9 RID: 21497
		public static int _MaxPool;

		// Token: 0x040053FA RID: 21498
		public static int _Max;

		// Token: 0x040053FB RID: 21499
		public int _DynMax;

		// Token: 0x040053FC RID: 21500
		public static int _Min;

		// Token: 0x040053FD RID: 21501
		public static int _DefaultRecordCount;
	}
}
