using System;
using System.Windows;
using System.Windows.Controls;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUtility;

namespace AcpUI.UndoRedo
{
	// Token: 0x02000058 RID: 88
	internal class a : global::AcpCommonLib.UndoRedo.UndoableTask
	{
		// Token: 0x060004DA RID: 1242 RVA: 0x0005DF04 File Offset: 0x0005C104
		protected a()
		{
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0005DF18 File Offset: 0x0005C118
		internal a(global::System.Windows.Controls.Expander A_0)
		{
			this.a = A_0;
			base.Description = global::AcpCommonResources.AcpResources.Select_Expander.AcpStringFormat(new object[]
			{
				A_0.Header
			});
			base.Seamless = true;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0005DF58 File Offset: 0x0005C158
		public override void Do()
		{
			short num = (short)124443325;
			short num2 = num;
			num = (short)947641021;
			switch (num2 == num)
			{
			}
			num = (short)1438777344;
			if (num != 0)
			{
			}
			num = (short)768475136;
			short num3 = num;
			num = (short)940507137;
			if (num != 0)
			{
			}
			this.a.Visibility = global::System.Windows.Visibility.Visible;
			this.a.IsExpanded = true;
			this.a.Focus();
			base.Do();
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0005E02C File Offset: 0x0005C22C
		public override void Undo()
		{
			short num = (short)1772903964;
			short num2 = num;
			num = (short)1994350108;
			switch (num2 == num)
			{
			}
			num = (short)2081882112;
			if (num != 0)
			{
			}
			num = (short)1473839104;
			short num3 = num;
			num = (short)1968570369;
			if (num != 0)
			{
			}
			this.a.IsExpanded = false;
			this.a.Visibility = global::System.Windows.Visibility.Collapsed;
			base.Undo();
		}

		// Token: 0x040002B1 RID: 689
		private global::System.Windows.Controls.Expander a;
	}
}
