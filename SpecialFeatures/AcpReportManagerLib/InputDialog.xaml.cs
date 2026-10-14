using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x02000240 RID: 576
	public partial class InputDialog : Window
	{
		// Token: 0x06001CD3 RID: 7379 RVA: 0x00003FAF File Offset: 0x000021AF
		internal InputDialog()
		{
			this.InitializeComponent();
			this.Page = 0;
			Utility.SetDirection(this);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00281408 File Offset: 0x0027F608
		internal void OnClick(object sender, RoutedEventArgs e)
		{
			short num = (short)479199232;
			short num2 = num;
			num = (short)2030097864;
			short num3 = num;
			num = (short)1125504456;
			switch (num3 == num)
			{
			}
			num = (short)1987444736;
			if (num != 0)
			{
			}
			num = (short)1455816705;
			if (num != 0)
			{
			}
			this.click = true;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x002814BC File Offset: 0x0027F6BC
		internal void OnClosed(object sender, EventArgs e)
		{
			short num = (short)964427776;
			short num2 = num;
			num = (short)2065279793;
			short num3 = num;
			num = (short)1445047089;
			switch (num3 == num)
			{
			}
			num = (short)78970880;
			if (num != 0)
			{
			}
			num = (short)12976129;
			if (num != 0)
			{
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x00281568 File Offset: 0x0027F768
		// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x0028161C File Offset: 0x0027F81C
		internal int Page
		{
			get
			{
				short num = (short)908525568;
				short num2 = num;
				num = (short)339856442;
				short num3 = num;
				num = (short)142068794;
				switch (num3 == num)
				{
				}
				num = (short)1511063553;
				if (num != 0)
				{
				}
				num = (short)1938096128;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1062338560;
				short num2 = num;
				num = (short)458378662;
				short num3 = num;
				num = (short)1526287782;
				switch (num3 == num)
				{
				}
				num = (short)95813633;
				if (num != 0)
				{
				}
				num = (short)697892864;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x04000E4B RID: 3659
		public bool click;

		// Token: 0x04000E4C RID: 3660
		private int a;
	}
}
