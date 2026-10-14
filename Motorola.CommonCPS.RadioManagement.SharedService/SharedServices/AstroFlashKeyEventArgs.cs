using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000078 RID: 120
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroFlashKeyEventArgs : global::System.EventArgs
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x0005E844 File Offset: 0x0005CA44
		public AstroFlashKeyEventArgs(string OldModelNumber, byte[] OldFlashCode)
		{
			if (this.keyInfo == null)
			{
				this.keyInfo = new global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo();
			}
			this.keyInfo.OldModelNumber = OldModelNumber;
			this.keyInfo.OldFlashCode = OldFlashCode;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0005E888 File Offset: 0x0005CA88
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0005E93C File Offset: 0x0005CB3C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo KeyInfo
		{
			get
			{
				short num = (short)777846784;
				short num2 = num;
				num = (short)780809284;
				short num3 = num;
				num = (short)2048275524;
				switch (num3 == num)
				{
				}
				num = (short)211353601;
				if (num != 0)
				{
				}
				num = (short)32112640;
				if (num != 0)
				{
				}
				return this.keyInfo;
			}
			set
			{
				short num = (short)894435328;
				short num2 = num;
				num = (short)1333665302;
				short num3 = num;
				num = (short)1319902742;
				switch (num3 == num)
				{
				}
				num = (short)336658432;
				if (num != 0)
				{
				}
				num = (short)1699217409;
				if (num != 0)
				{
				}
				this.keyInfo = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0005E9EC File Offset: 0x0005CBEC
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
		[global::System.Runtime.Serialization.DataMember]
		public bool IsValid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1280376832;
				short num2 = num;
				num = (short)836113333;
				short num3 = num;
				num = (short)1343099829;
				switch (num3 == num)
				{
				}
				num = (short)725352448;
				if (num != 0)
				{
				}
				num = (short)760938497;
				if (num != 0)
				{
				}
				return this.<IsValid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)165347328;
				short num2 = num;
				num = (short)902849872;
				short num3 = num;
				num = (short)1157981520;
				switch (num3 == num)
				{
				}
				num = (short)2130378753;
				if (num != 0)
				{
				}
				num = (short)721289216;
				if (num != 0)
				{
				}
				this.<IsValid>k__BackingField = value;
			}
		}

		// Token: 0x040000AF RID: 175
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.FlashKeyInfo keyInfo;
	}
}
