using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;

namespace AcpUI.Common
{
	// Token: 0x020000AF RID: 175
	public class AcpThemeBase : global::System.Windows.FrameworkElement, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00083174 File Offset: 0x00081374
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x00083224 File Offset: 0x00081424
		public string ThemeName
		{
			get
			{
				short num = (short)1686503424;
				short num2 = num;
				num = (short)956623266;
				short num3 = num;
				num = (short)634448290;
				switch (num3 == num)
				{
				}
				num = (short)591003648;
				if (num != 0)
				{
				}
				num = (short)1765343233;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)161218560;
				short num2 = num;
				num = (short)1024983041;
				if (num != 0)
				{
				}
				num = (short)1288454355;
				short num3 = num;
				num = (short)2088911059;
				switch (num3 == num)
				{
				}
				num = (short)1668022272;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000694 RID: 1684 RVA: 0x000832D4 File Offset: 0x000814D4
		// (remove) Token: 0x06000695 RID: 1685 RVA: 0x0008340C File Offset: 0x0008160C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)663595719;
				short num2 = num;
				num = (short)54766279;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_AB:
					num = (short)1142292480;
					short num3 = num;
					goto IL_D7;
				}
				default:
					num = (short)265420801;
					if (num != 0)
					{
					}
					num = (short)1742471168;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_90;
					}
					break;
				}
				int num4;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
				for (;;)
				{
					IL_7E:
					switch (num4)
					{
					case 0:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)275251202;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					case 1:
						goto IL_AB;
					case 2:
						return;
					}
					goto IL_90;
				}
				return;
				IL_90:
				propertyChangedEventHandler = this.b;
				num = (short)934150145;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7E;
				IL_D7:
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.b, value2, propertyChangedEventHandler2);
				num = (short)777846784;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_7E;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1061696011;
				short num2 = num;
				num = (short)458043915;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_AA:
					num = (short)1704984576;
					short num3 = num;
					goto IL_D4;
				}
				default:
					num = (short)345964544;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				int num4;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
				for (;;)
				{
					IL_55:
					switch (num4)
					{
					case 0:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)1757413378;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					case 1:
						goto IL_AA;
					case 2:
						return;
					}
					goto IL_67;
				}
				return;
				IL_67:
				propertyChangedEventHandler = this.b;
				num = (short)1279000577;
				if (num != 0)
				{
				}
				num = (short)1011023873;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_55;
				IL_D4:
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.b, value2, propertyChangedEventHandler2);
				num = (short)1728905216;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00083540 File Offset: 0x00081740
		public void FirePropertyChanged(string name)
		{
			short num = (short)1494856390;
			short num2 = num;
			num = (short)1654043334;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A1:
				if (this.b == null)
				{
					return;
				}
				num = (short)1084030976;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)814153729;
				if (num != 0)
				{
				}
				num = (short)1399062528;
				if (num != 0)
				{
				}
				num = (short)131727361;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)644808704;
					short num4 = num;
					this.b(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
					num = (short)1816723458;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A1;
					}
					continue;
				case 2:
					return;
				}
				goto IL_A1;
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00083660 File Offset: 0x00081860
		public AcpThemeBase()
		{
			base.Loaded += this.AcpThemeBase_Loaded;
			base.Unloaded += this.AcpThemeBase_Unloaded;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00083698 File Offset: 0x00081898
		private void AcpThemeBase_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1212678144;
			short num2 = num;
			num = (short)223281153;
			if (num != 0)
			{
			}
			num = (short)2141652712;
			short num3 = num;
			num = (short)86443752;
			switch (num3 == num)
			{
			}
			num = (short)293994496;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.ThemeChangedEvent -= this.ThemeChangedEvent;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00083754 File Offset: 0x00081954
		private void AcpThemeBase_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)691273728;
			short num2 = num;
			num = (short)1143851385;
			short num3 = num;
			num = (short)83806585;
			switch (num3 == num)
			{
			}
			num = (short)1266810881;
			if (num != 0)
			{
			}
			num = (short)889323520;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.ThemeChangedEvent += this.ThemeChangedEvent;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0008380C File Offset: 0x00081A0C
		private void ThemeChangedEvent(object A_0, global::AcpUI.Common.ThemeChangedEventArgs A_1)
		{
			int a_ = 15;
			short num = (short)1150746624;
			short num2 = num;
			num = (short)863961089;
			if (num != 0)
			{
			}
			num = (short)1032405675;
			short num3 = num;
			num = (short)1228620459;
			switch (num3 == num)
			{
			}
			num = (short)926023680;
			if (num != 0)
			{
			}
			this.a = A_1.ThemeName;
			this.FirePropertyChanged(global::AcpUI.Common.Utility.c("쾦첨욪좬킰\udeb2킴", a_));
		}

		// Token: 0x04000341 RID: 833
		private string a;

		// Token: 0x04000342 RID: 834
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler b;
	}
}
