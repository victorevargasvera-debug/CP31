using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000095 RID: 149
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ModelTierEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x000653E8 File Offset: 0x000635E8
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00065498 File Offset: 0x00063698
		public string ModelNumber
		{
			get
			{
				short num = (short)1858338817;
				if (num != 0)
				{
				}
				num = (short)1454436163;
				short num2 = num;
				num = (short)209121091;
				switch (num2 == num)
				{
				}
				num = (short)1446051840;
				short num3 = num;
				num = (short)1985937408;
				if (num != 0)
				{
				}
				return this.modelNumber;
			}
			set
			{
				short num = (short)1657630733;
				short num2 = num;
				num = (short)1266511885;
				switch (num2 == num)
				{
				}
				num = (short)1628307457;
				if (num != 0)
				{
				}
				num = (short)854130688;
				short num3 = num;
				num = (short)1555628032;
				if (num != 0)
				{
				}
				this.modelNumber = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x00065548 File Offset: 0x00063748
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x000655F8 File Offset: 0x000637F8
		public bool SupportLanguagePack
		{
			get
			{
				short num = (short)1212940289;
				if (num != 0)
				{
				}
				num = (short)2065857093;
				short num2 = num;
				num = (short)1727035973;
				switch (num2 == num)
				{
				}
				num = (short)353959936;
				short num3 = num;
				num = (short)1958281216;
				if (num != 0)
				{
				}
				return this.supportLanguagePack;
			}
			set
			{
				short num = (short)694584054;
				short num2 = num;
				num = (short)2026668790;
				switch (num2 == num)
				{
				}
				num = (short)957808641;
				if (num != 0)
				{
				}
				num = (short)496304128;
				short num3 = num;
				num = (short)182452224;
				if (num != 0)
				{
				}
				this.supportLanguagePack = value;
			}
		}

		// Token: 0x04000103 RID: 259
		[global::System.Runtime.Serialization.DataMember]
		private string modelNumber;

		// Token: 0x04000104 RID: 260
		[global::System.Runtime.Serialization.DataMember]
		private bool supportLanguagePack;
	}
}
