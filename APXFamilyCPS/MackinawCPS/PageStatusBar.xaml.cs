using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using AcpCommonLib;
using AcpUI.Common;
using CommonResources;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200003A RID: 58
	public partial class PageStatusBar : Page, INotifyPropertyChanged
	{
		// Token: 0x06000169 RID: 361 RVA: 0x0004794C File Offset: 0x00045B4C
		public PageStatusBar()
		{
			this.InitializeComponent();
			AcpUI.Common.Utility.SetDirection(this);
			this.Status = AppResources.READY_ID;
			base.DataContext = this;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00047980 File Offset: 0x00045B80
		internal void UpdateProgress(double progress)
		{
			short num = (short)1746860978;
			short num2 = num;
			num = (short)1317534642;
			switch (num2 == num)
			{
			}
			num = (short)821624832;
			if (num != 0)
			{
			}
			num = (short)1737359361;
			if (num != 0)
			{
			}
			num = (short)1202520064;
			short num3 = num;
			Duration duration = new Duration(TimeSpan.FromSeconds(5.0));
			DoubleAnimation animation = new DoubleAnimation(100.0, duration);
			this.ProgBar.BeginAnimation(RangeBase.ValueProperty, animation);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00047A60 File Offset: 0x00045C60
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00047B0C File Offset: 0x00045D0C
		public string Status
		{
			get
			{
				short num = (short)759634562;
				short num2 = num;
				num = (short)1372330626;
				switch (num2 == num)
				{
				}
				num = (short)225574913;
				if (num != 0)
				{
				}
				num = (short)1030619136;
				if (num != 0)
				{
				}
				num = (short)257622016;
				short num3 = num;
				return this.status;
			}
			set
			{
				int a_ = 18;
				short num = (short)985860283;
				short num2 = num;
				num = (short)1164445883;
				switch (num2 == num)
				{
				}
				num = (short)963248128;
				if (num != 0)
				{
				}
				num = (short)155320321;
				if (num != 0)
				{
				}
				num = (short)1537605632;
				short num3 = num;
				this.status = value;
				this.OnPropertyChanged(FixedLengthStream.b("ꇱ胳韵賷迹迻", a_));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00047BD8 File Offset: 0x00045DD8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00047C88 File Offset: 0x00045E88
		public string RadioModel
		{
			get
			{
				short num = (short)666748610;
				short num2 = num;
				num = (short)1207355074;
				switch (num2 == num)
				{
				}
				num = (short)103809025;
				if (num != 0)
				{
				}
				num = (short)71237632;
				if (num != 0)
				{
				}
				num = (short)2031812608;
				short num3 = num;
				return this.model;
			}
			set
			{
				int a_ = 2;
				short num = (short)2097020929;
				if (num != 0)
				{
				}
				num = (short)565443597;
				short num2 = num;
				num = (short)1554578445;
				switch (num2 == num)
				{
				}
				num = (short)588775424;
				if (num != 0)
				{
				}
				num = (short)1409089536;
				short num3 = num;
				this.model = value;
				this.OnPropertyChanged(FixedLengthStream.b("냡藣若臧藩ꇫ臭铯韱飳", a_));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00047D54 File Offset: 0x00045F54
		// (set) Token: 0x06000170 RID: 368 RVA: 0x00047E04 File Offset: 0x00046004
		public string SerialNum
		{
			get
			{
				short num = (short)1465378153;
				short num2 = num;
				num = (short)641852777;
				switch (num2 == num)
				{
				}
				num = (short)914227201;
				if (num != 0)
				{
				}
				num = (short)2134704128;
				if (num != 0)
				{
				}
				num = (short)1589641216;
				short num3 = num;
				return this.sn;
			}
			set
			{
				int a_ = 3;
				short num = (short)790571883;
				short num2 = num;
				num = (short)482093931;
				switch (num2 == num)
				{
				}
				num = (short)1683619841;
				if (num != 0)
				{
				}
				num = (short)1588068352;
				if (num != 0)
				{
				}
				num = (short)744620032;
				short num3 = num;
				this.sn = value;
				this.OnPropertyChanged(FixedLengthStream.b("냢胤闦胨諪臬ꇮ蓰黲", a_));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00047ED4 File Offset: 0x000460D4
		public string CPSVersion
		{
			get
			{
				short num = (short)1375067099;
				short num2 = num;
				num = (short)755162075;
				switch (num2 == num)
				{
				}
				num = (short)1259732993;
				if (num != 0)
				{
				}
				num = (short)1522204672;
				if (num != 0)
				{
				}
				num = (short)2012020736;
				short num3 = num;
				return AppInfoManager.AppVersion;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00047F80 File Offset: 0x00046180
		public void OnPropertyChanged(string propertyName)
		{
			short num = (short)2130575362;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				num = (short)945382396;
				short num3 = num;
				num = (short)1966892028;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)106102784;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1989017600;
						short num4 = num;
						num = (short)491257857;
						if (num != 0)
						{
						}
						this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
						num = (short)173342721;
						num2 = (int)((IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					IL_7B:
					if (this.PropertyChanged == null)
					{
						return;
					}
					num = (short)701235200;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000173 RID: 371 RVA: 0x000480A8 File Offset: 0x000462A8
		// (remove) Token: 0x06000174 RID: 372 RVA: 0x000481E4 File Offset: 0x000463E4
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				PropertyChangedEventHandler propertyChangedEventHandler;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						num2 = (short)697565185;
						if (num2 != 0)
						{
						}
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1301413889;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_86;
					case 1:
						return;
					case 2:
						goto IL_84;
					}
					goto IL_1C;
				}
				IL_84:
				IL_86:
				num2 = (short)1462894592;
				short num3 = num2;
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				goto IL_CD;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)54639355;
				short num4 = num2;
				num2 = (short)826456827;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_CD:
					num2 = (short)850001920;
					int num = (int)((IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)1629880320;
					if (num2 != 0)
					{
					}
					num2 = (short)72876034;
					int num = (int)((IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			[CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				PropertyChangedEventHandler propertyChangedEventHandler;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				for (;;)
				{
					IL_0A:
					num = (short)641662977;
					if (num != 0)
					{
					}
					int num2;
					switch (num2)
					{
					case 0:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)447807489;
							num2 = (int)((IntPtr)num);
							continue;
						}
						goto IL_D8;
					case 1:
						return;
					case 2:
						goto IL_AD;
					}
					goto IL_43;
				}
				IL_AD:
				num = (short)154075136;
				short num3 = num;
				IL_D8:
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
				goto IL_F5;
				IL_43:
				propertyChangedEventHandler = this.PropertyChanged;
				num = (short)1769046052;
				short num4 = num;
				num = (short)383090724;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_F5:
					num = (short)1881341952;
					int num2 = (int)((IntPtr)num);
					goto IL_0A;
				}
				default:
				{
					num = (short)1862008832;
					if (num != 0)
					{
					}
					num = (short)1975255042;
					int num2 = (int)((IntPtr)num);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x04000120 RID: 288
		private string status;

		// Token: 0x04000121 RID: 289
		private string model;

		// Token: 0x04000122 RID: 290
		private string sn;

		// Token: 0x0400012A RID: 298
		[NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
