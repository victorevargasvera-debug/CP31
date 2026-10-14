using System;
using System.Windows;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000033 RID: 51
	public class AcpTextBoxCustomDecHex : global::AcpUI.AcpTextBoxDecHex
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00034320 File Offset: 0x00032520
		public AcpTextBoxCustomDecHex()
		{
			base.Loaded += this.AcpTextBoxCustomDecHex_Loaded;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00034348 File Offset: 0x00032548
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x000343F8 File Offset: 0x000325F8
		public string CustomValueMaskType
		{
			get
			{
				short num = (short)1219175374;
				short num2 = num;
				num = (short)304817102;
				switch (num2 == num)
				{
				}
				num = (short)596049920;
				short num3 = num;
				num = (short)718995457;
				if (num != 0)
				{
				}
				num = (short)1476460544;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)779822268;
				short num2 = num;
				num = (short)898245820;
				switch (num2 == num)
				{
				}
				num = (short)1337589760;
				short num3 = num;
				num = (short)357367809;
				if (num != 0)
				{
				}
				num = (short)379715584;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000344A8 File Offset: 0x000326A8
		private void AcpTextBoxCustomDecHex_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)2031067300;
			short num2 = num;
			num = (short)1754570916;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1547829248;
				if (num != 0)
				{
				}
				num = (short)994967553;
				if (num != 0)
				{
				}
				num = (short)1216086016;
				short num3 = num;
				if (!global::AcpUI.AcpTextBox.DisableMask)
				{
					this.a.MaskType = global::AcpUI.Common.Utility.c("\udca6쪨쎪첬\uddae记芲薴趶覸隺蒼", a_) + this.CustomValueMaskType + global::AcpUI.Common.Utility.c("\udaa6", a_);
					this.b.MaskType = global::AcpUI.Common.Utility.c("\udca6쪨쎪첬\uddae记讲辴螶钸芺\udcbc銾Ꟁ苂臆", a_) + this.CustomValueMaskType + global::AcpUI.Common.Utility.c("\udaa6", a_);
					return;
				}
				break;
			}
			}
			this.a.MaskType = null;
			this.b.MaskType = null;
		}

		// Token: 0x040001E2 RID: 482
		private new string a;
	}
}
