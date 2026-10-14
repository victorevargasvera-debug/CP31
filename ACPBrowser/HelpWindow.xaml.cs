using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using CefSharp.Wpf;

namespace ACPBrowser
{
	// Token: 0x02000008 RID: 8
	public partial class HelpWindow : Window
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00003558 File Offset: 0x00001758
		static HelpWindow()
		{
			short num = (short)1840578560;
			short num2 = num;
			num = (short)1526414872;
			short num3 = num;
			num = (short)295386648;
			switch (num3 == num)
			{
			}
			num = (short)1685127168;
			if (num != 0)
			{
			}
			num = (short)1617756161;
			if (num != 0)
			{
			}
			Utility.b();
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003604 File Offset: 0x00001804
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000036B4 File Offset: 0x000018B4
		public bool IsClosed
		{
			[CompilerGenerated]
			get
			{
				short num = (short)662634496;
				short num2 = num;
				num = (short)1540294899;
				short num3 = num;
				num = (short)121964787;
				switch (num3 == num)
				{
				}
				num = (short)453640193;
				if (num != 0)
				{
				}
				num = (short)1780023296;
				if (num != 0)
				{
				}
				return this.a;
			}
			[CompilerGenerated]
			private set
			{
				short num = (short)655949824;
				short num2 = num;
				num = (short)1584248335;
				short num3 = num;
				num = (short)811185679;
				switch (num3 == num)
				{
				}
				num = (short)1193869312;
				if (num != 0)
				{
				}
				num = (short)1737293825;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003764 File Offset: 0x00001964
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003814 File Offset: 0x00001A14
		internal bool IsWindowBeingDisplayed
		{
			[CompilerGenerated]
			get
			{
				short num = (short)54984704;
				short num2 = num;
				num = (short)710171440;
				short num3 = num;
				num = (short)1503025968;
				switch (num3 == num)
				{
				}
				num = (short)319684608;
				if (num != 0)
				{
				}
				num = (short)1088028673;
				if (num != 0)
				{
				}
				return this.b;
			}
			[CompilerGenerated]
			private set
			{
				short num = (short)736886784;
				short num2 = num;
				num = (short)396105052;
				short num3 = num;
				num = (short)1576998236;
				switch (num3 == num)
				{
				}
				num = (short)205127681;
				if (num != 0)
				{
				}
				num = (short)490668032;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000038C0 File Offset: 0x00001AC0
		public HelpWindow()
		{
			this.InitializeComponent();
			this.IsWindowBeingDisplayed = false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000038E0 File Offset: 0x00001AE0
		private void a(object A_0, EventArgs A_1)
		{
			short num = (short)2115305472;
			short num2 = num;
			num = (short)602358191;
			short num3 = num;
			num = (short)1958166959;
			switch (num3 == num)
			{
			}
			num = (short)844431360;
			if (num != 0)
			{
			}
			num = (short)1818427393;
			if (num != 0)
			{
			}
			this.IsClosed = true;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003990 File Offset: 0x00001B90
		internal void a(string A_0)
		{
			short num = (short)739704832;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1140064256;
					short num3 = num;
					this.f.Load(A_0);
					num = (short)848625665;
					num2 = (int)((IntPtr)num);
					continue;
				}
				}
				IL_32:
				num = (short)1265373374;
				short num4 = num;
				num = (short)440471742;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)424935424;
					if (num != 0)
					{
					}
					num = (short)1670578177;
					if (num != 0)
					{
					}
					if (this.f.IsLoading)
					{
						return;
					}
					num = (short)1792868354;
					num2 = (int)((IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003AB8 File Offset: 0x00001CB8
		internal void b()
		{
			short num = (short)895746048;
			short num2 = num;
			num = (short)621747806;
			short num3 = num;
			num = (short)1457659486;
			switch (num3 == num)
			{
			}
			num = (short)1723072513;
			if (num != 0)
			{
			}
			num = (short)1567424512;
			if (num != 0)
			{
			}
			this.IsClosed = true;
			this.IsWindowBeingDisplayed = false;
			base.Close();
		}

		// Token: 0x0400000C RID: 12
		[CompilerGenerated]
		private bool a;

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		private bool b;
	}
}
