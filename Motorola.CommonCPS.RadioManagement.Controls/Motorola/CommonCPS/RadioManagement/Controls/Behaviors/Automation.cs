using System;
using System.Windows;
using System.Windows.Automation;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls.Behaviors
{
	// Token: 0x02000139 RID: 313
	public static class Automation
	{
		// Token: 0x06000984 RID: 2436 RVA: 0x0009D810 File Offset: 0x0009BA10
		public static bool GetAutomatedRecordPresenters(global::System.Windows.DependencyObject dependencyObject)
		{
			short num = (short)1781363217;
			short num2 = num;
			num = (short)374108689;
			switch (num2 == num)
			{
			}
			num = (short)432275456;
			if (num != 0)
			{
			}
			num = (short)655556608;
			short num3 = num;
			num = (short)2055995393;
			if (num != 0)
			{
			}
			return (bool)dependencyObject.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.Automation.AutomatedRecordPresentersProperty);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0009D8CC File Offset: 0x0009BACC
		public static void SetAutomatedRecordPresenters(global::System.Windows.DependencyObject dependencyObject, bool value)
		{
			short num = (short)82033929;
			short num2 = num;
			num = (short)2033761545;
			switch (num2 == num)
			{
			}
			num = (short)1737555969;
			if (num != 0)
			{
			}
			num = (short)890503168;
			short num3 = num;
			num = (short)124059648;
			if (num != 0)
			{
			}
			dependencyObject.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.Automation.AutomatedRecordPresentersProperty, value);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0009D988 File Offset: 0x0009BB88
		private static void OnAutomatedRecordPresentersChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter;
			short num;
			for (;;)
			{
				dataRecordPresenter = (A_0 as global::Infragistics.Windows.DataPresenter.DataRecordPresenter);
				if (dataRecordPresenter != null)
				{
					goto IL_AB;
				}
				num = (short)1523056640;
				short num2 = num;
				num = (short)477495297;
				if (num != 0)
				{
				}
				num = (short)372542820;
				short num3 = num;
				num = (short)2063961444;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_95;
				}
			}
			IL_95:
			num = (short)1269235712;
			if (num != 0)
			{
			}
			return;
			IL_AB:
			dataRecordPresenter.DataContextChanged += global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.Automation.a;
			global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.Automation.a(dataRecordPresenter);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0009DA58 File Offset: 0x0009BC58
		private static void a(global::System.Windows.FrameworkElement A_0)
		{
			int a_ = 12;
			short num = (short)532217864;
			int num2 = (int)((global::System.IntPtr)num);
			object value;
			for (;;)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
				bool flag;
				object obj;
				switch (num2)
				{
				case 0:
				{
					global::Infragistics.Windows.DataPresenter.CellCollection cells = dataRecord.Cells;
					if (cells == null)
					{
						goto IL_2A3;
					}
					flag = (cells.Count > 0);
					goto IL_23F;
				}
				case 1:
					num = (short)404094988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (dataRecord == null)
					{
						return;
					}
					num = (short)1649316329;
					short num3 = num;
					num = (short)1311216105;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A3;
					default:
						num = (short)473300993;
						if (num != 0)
						{
						}
						num = (short)709492736;
						if (num != 0)
						{
						}
						num = (short)433651722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_25D;
				case 4:
					flag = false;
					goto IL_23F;
				case 5:
					return;
				case 6:
					num = (short)890175488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					obj = A_0.DataContext;
					goto IL_9C;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 9:
					if (dataRecord.DataItemIndex >= 0)
					{
						num = (short)691994630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 10:
					num = (short)2054094857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (value == null)
					{
						num = (short)201129984;
						short num4 = num;
						num = (short)1702232069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BE;
				case 12:
					obj = null;
					goto IL_9C;
				}
				IL_62:
				if (A_0 == null)
				{
					num = (short)139460609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)361234439;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9C:
				dataRecord = (obj as global::Infragistics.Windows.DataPresenter.DataRecord);
				num = (short)938541058;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23F:
				if (!flag)
				{
					num = (short)1258160131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				A_0.SetValue(global::System.Windows.Automation.AutomationProperties.AutomationIdProperty, string.Format(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펥\udca7얩솫쾭쒯\udbb1\udbb3\ud8b5\udeb9얽뿁", a_), dataRecord.DataItemIndex + 1));
				value = dataRecord.Cells[0].Value;
				num = (short)1521549323;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A3:
				num = (short)1504575492;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_25D:
			return;
			IL_2BE:
			A_0.SetValue(global::System.Windows.Automation.AutomationProperties.NameProperty, value.ToString());
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0009DD34 File Offset: 0x0009BF34
		private static void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)343474176;
			short num2 = num;
			num = (short)557243999;
			short num3 = num;
			num = (short)1603853919;
			switch (num3 == num)
			{
			}
			num = (short)1397882881;
			if (num != 0)
			{
			}
			num = (short)996999168;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.Automation.a(A_0 as global::System.Windows.FrameworkElement);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0009DDE8 File Offset: 0x0009BFE8
		// Note: this type is marked as 'beforefieldinit'.
		static Automation()
		{
			int a_ = 8;
			short num = (short)1374814208;
			short num2 = num;
			num = (short)1326315265;
			short num3 = num;
			num = (short)1898968833;
			switch (num3 == num)
			{
			}
			num = (short)1313865729;
			if (num != 0)
			{
			}
			num = (short)1509163008;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.Automation.AutomatedRecordPresentersProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("힡킣즥얧쮩\ud8ab쮭풯톳햵ힷ좹\ud8bb늿ꟁ럃ꏅꛇ뻉꧋볍ꏏ", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.Automation), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.Automation.OnAutomatedRecordPresentersChanged)));
		}

		// Token: 0x04000460 RID: 1120
		public static readonly global::System.Windows.DependencyProperty AutomatedRecordPresentersProperty;
	}
}
