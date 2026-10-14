using System;
using System.Windows;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x0200002E RID: 46
	public class AcpTableTextBoxCustomDecHex : global::AcpUI.AcpTableTextBoxDecHex
	{
		// Token: 0x0600028B RID: 651 RVA: 0x0002F3A0 File Offset: 0x0002D5A0
		public AcpTableTextBoxCustomDecHex()
		{
			base.Loaded += this.AcpTextBoxCustomDecHex_Loaded;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0002F3C8 File Offset: 0x0002D5C8
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0002F478 File Offset: 0x0002D678
		public string CustomValueMaskType
		{
			get
			{
				short num = (short)2098681523;
				short num2 = num;
				num = (short)1019041459;
				switch (num2 == num)
				{
				}
				num = (short)735248384;
				short num3 = num;
				num = (short)1220345857;
				if (num != 0)
				{
				}
				num = (short)1626406912;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1595000488;
				short num2 = num;
				num = (short)2096809640;
				switch (num2 == num)
				{
				}
				num = (short)1901789184;
				short num3 = num;
				num = (short)1260978177;
				if (num != 0)
				{
				}
				num = (short)701300736;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0002F528 File Offset: 0x0002D728
		private void AcpTextBoxCustomDecHex_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 10;
			short num = (short)1309081600;
			short num2 = num;
			if (global::AcpUI.AcpTextBox.DisableMask)
			{
				for (;;)
				{
					num = (short)1832910849;
					if (num != 0)
					{
					}
					num = (short)142079825;
					short num3 = num;
					num = (short)2129131345;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9C;
					}
				}
				IL_9C:
				num = (short)1704787968;
				if (num != 0)
				{
				}
				base.AcpTextBoxMemberDec.MaskType = null;
				base.AcpTextBoxMemberHex.MaskType = null;
				return;
			}
			base.AcpTextBoxMemberDec.MaskType = global::AcpUI.Common.Utility.c("\udb9f송첣장\udaa7邩鶫麭誯花馳辵", a_) + this.CustomValueMaskType + global::AcpUI.Common.Utility.c("\udd9f", a_);
			base.AcpTextBoxMemberHex.MaskType = global::AcpUI.Common.Utility.c("\udb9f송첣장\udaa7邩钫钭肯龱足ힵ閷\udcb9ﶻ鎽蚿", a_) + this.CustomValueMaskType + global::AcpUI.Common.Utility.c("\udd9f", a_);
		}

		// Token: 0x040001BD RID: 445
		private string a;
	}
}
