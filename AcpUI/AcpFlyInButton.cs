using System;
using System.Windows;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000016 RID: 22
	public class AcpFlyInButton : global::AcpUI.AcpButton
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00017D18 File Offset: 0x00015F18
		// (set) Token: 0x06000124 RID: 292 RVA: 0x00017DD0 File Offset: 0x00015FD0
		public bool ShowDiffIcon
		{
			get
			{
				short num = (short)1294832333;
				short num2 = num;
				num = (short)1805226701;
				switch (num2 == num)
				{
				}
				num = (short)946012160;
				if (num != 0)
				{
				}
				num = (short)293208065;
				if (num != 0)
				{
				}
				num = (short)322961408;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpFlyInButton.ShowDiffIconProperty);
			}
			set
			{
				short num = (short)2128956030;
				short num2 = num;
				num = (short)1926843006;
				switch (num2 == num)
				{
				}
				num = (short)1023475712;
				if (num != 0)
				{
				}
				num = (short)1736572929;
				if (num != 0)
				{
				}
				num = (short)1366884352;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpFlyInButton.ShowDiffIconProperty, value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00017E8C File Offset: 0x0001608C
		// (set) Token: 0x06000126 RID: 294 RVA: 0x00017F44 File Offset: 0x00016144
		public bool ShowInvalidRecIcon
		{
			get
			{
				short num = (short)365573115;
				short num2 = num;
				num = (short)841888763;
				switch (num2 == num)
				{
				}
				num = (short)334692352;
				if (num != 0)
				{
				}
				num = (short)1291386881;
				if (num != 0)
				{
				}
				num = (short)1519517696;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpFlyInButton.ShowInvalidRecIconProperty);
			}
			set
			{
				short num = (short)678528026;
				short num2 = num;
				num = (short)1306231834;
				switch (num2 == num)
				{
				}
				num = (short)403374080;
				if (num != 0)
				{
				}
				num = (short)155320321;
				if (num != 0)
				{
				}
				num = (short)620888064;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpFlyInButton.ShowInvalidRecIconProperty, value);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00018000 File Offset: 0x00016200
		// Note: this type is marked as 'beforefieldinit'.
		static AcpFlyInButton()
		{
			int a_ = 4;
			short num = (short)1299683790;
			short num2 = num;
			num = (short)1699584462;
			switch (num2 == num)
			{
			}
			num = (short)270336001;
			if (num != 0)
			{
			}
			num = (short)1153368064;
			if (num != 0)
			{
			}
			num = (short)1130889216;
			short num3 = num;
			global::AcpUI.AcpFlyInButton.ShowDiffIconProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("즙힟춣삥캧쾫솭\udeaf", a_), typeof(bool), typeof(global::AcpUI.AcpFlyInButton), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpFlyInButton.ShowInvalidRecIconProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("즙힟쪣킥즧용얫쪭ힱힳﾵ\udbb7햹튻", a_), typeof(bool), typeof(global::AcpUI.AcpFlyInButton), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x04000134 RID: 308
		public static readonly global::System.Windows.DependencyProperty ShowDiffIconProperty;

		// Token: 0x04000135 RID: 309
		public static readonly global::System.Windows.DependencyProperty ShowInvalidRecIconProperty;
	}
}
