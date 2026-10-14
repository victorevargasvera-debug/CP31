using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000104 RID: 260
	public class RMLinkFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060007B5 RID: 1973 RVA: 0x0007D2E0 File Offset: 0x0007B4E0
		public RMLinkFieldEditor()
		{
			this.InitializeComponent();
			base.SetDefaultBindings();
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060007B6 RID: 1974 RVA: 0x0007D300 File Offset: 0x0007B500
		// (remove) Token: 0x060007B7 RID: 1975 RVA: 0x0007D3B8 File Offset: 0x0007B5B8
		public event global::System.Windows.RoutedEventHandler RelocateRequested
		{
			add
			{
				short num = (short)1059192832;
				short num2 = num;
				num = (short)729024580;
				short num3 = num;
				num = (short)845613124;
				switch (num3 == num)
				{
				}
				num = (short)1891565569;
				if (num != 0)
				{
				}
				num = (short)2117402624;
				if (num != 0)
				{
				}
				base.AddHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor.RelocateRequestedEvent, value);
			}
			remove
			{
				short num = (short)168296448;
				short num2 = num;
				num = (short)307557016;
				short num3 = num;
				num = (short)1925378712;
				switch (num3 == num)
				{
				}
				num = (short)1982136321;
				if (num != 0)
				{
				}
				num = (short)4849664;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor.RelocateRequestedEvent, value);
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0007D46C File Offset: 0x0007B66C
		private void btnRelocate_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1951268864;
			short num2 = num;
			num = (short)1848065980;
			short num3 = num;
			num = (short)2036809660;
			switch (num3 == num)
			{
			}
			num = (short)1248133121;
			if (num != 0)
			{
			}
			num = (short)292159488;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField collectionField = (global::Motorola.CommonCPS.RadioManagement.UIModels.CollectionField)base.DataContext;
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor.RelocateRequestedEvent, collectionField.SetCategory));
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0007D538 File Offset: 0x0007B738
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)1313698849;
			short num2 = num;
			num = (short)1318745121;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)498991105;
				if (num != 0)
				{
				}
				num = (short)183173120;
				if (num != 0)
				{
				}
				num = (short)823525376;
				short num3 = num;
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("讣잧\udea9쎫\udcad\udfaf\udeb1햳颵﮷햹톻펽꾿곁蟃雅鯇黋꿍듏믑믓鯕맗듙뷛망藟迡臣裥鳧쓩꿫臭黯蛱蛳駵铷觹쟻鷽濿漁球椅昇漉戋稍㼏朑朓猕樗礙猛瀝吟倡䬣䨥嬧ԩ䨫䜭唯帱倳匵尷匹䠻儽㈿ㅁ歃㑅╇♉╋⁍㭏㑑㵓㍕㑗㹙㥛㩝य़ᙡୣᑥ䙧ቩ൫ͭᱯ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0007D618 File Offset: 0x0007B818
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1776418816;
			short num2 = num;
			num = (short)824049665;
			if (num != 0)
			{
			}
			num = (short)1479790770;
			short num3 = num;
			num = (short)470732978;
			switch (num3 == num)
			{
			}
			num = (short)411107328;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0007D6CC File Offset: 0x0007B8CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1364983808;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					goto IL_E6;
				case 2:
				{
					num = (short)1324875777;
					if (num != 0)
					{
					}
					num = (short)1552023552;
					short num3 = num;
					num = (short)246677507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (connectionId != 2)
					{
						goto IL_12C;
					}
					goto IL_147;
				case 4:
					num = (short)34275329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				if (connectionId != 1)
				{
					num = (short)75563010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)820635687;
				short num4 = num;
				num = (short)45082663;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_AD;
				}
				IL_12C:
				num = (short)335609860;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AD:
			num = (short)1674182656;
			if (num != 0)
			{
			}
			this.tblLabel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock)target;
			return;
			IL_E6:
			this._contentLoaded = true;
			return;
			IL_147:
			this.btnRelocate = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0007D834 File Offset: 0x0007BA34
		// Note: this type is marked as 'beforefieldinit'.
		static RMLinkFieldEditor()
		{
			int a_ = 5;
			short num = (short)1355415552;
			short num2 = num;
			num = (short)152988587;
			short num3 = num;
			num = (short)2074897323;
			switch (num3 == num)
			{
			}
			num = (short)667615233;
			if (num != 0)
			{
			}
			num = (short)73072640;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor.RelocateRequestedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾜爵춠첢욤욦\udda8캪ﾬ쪮산욲킴쒶춸\udeba\ud9bc", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkFieldEditor));
		}

		// Token: 0x04000380 RID: 896
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBlock tblLabel;

		// Token: 0x04000381 RID: 897
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnRelocate;

		// Token: 0x04000382 RID: 898
		private bool _contentLoaded;
	}
}
