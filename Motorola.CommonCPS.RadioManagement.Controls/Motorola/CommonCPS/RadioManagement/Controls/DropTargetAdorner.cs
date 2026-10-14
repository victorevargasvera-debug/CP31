using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Documents;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200004D RID: 77
	public class DropTargetAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00012178 File Offset: 0x00010378
		public DropTargetAdorner(global::System.Windows.UIElement adornedElement) : base(adornedElement)
		{
			this.adornerLayer = global::System.Windows.Documents.AdornerLayer.GetAdornerLayer(adornedElement);
			this.adornerLayer.Add(this);
			base.IsHitTestVisible = false;
			base.AllowDrop = false;
			base.SnapsToDevicePixels = true;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000121BC File Offset: 0x000103BC
		public void Detatch()
		{
			short num = (short)1953898820;
			short num2 = num;
			num = (short)1490035012;
			switch (num2 == num)
			{
			}
			num = (short)1383923712;
			short num3 = num;
			num = (short)418316289;
			if (num != 0)
			{
			}
			num = (short)1680211968;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.Helpers.InterceptMouse.UninstallMouseHook();
			this.adornerLayer.Remove(this);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00012278 File Offset: 0x00010478
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00012328 File Offset: 0x00010528
		public global::Motorola.CommonCPS.RadioManagement.Controls.DropInfo DropInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1389660447;
				short num2 = num;
				num = (short)145197343;
				switch (num2 == num)
				{
				}
				num = (short)944701440;
				short num3 = num;
				num = (short)1887109120;
				if (num != 0)
				{
				}
				num = (short)679280641;
				if (num != 0)
				{
				}
				return this.<DropInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)829980383;
				short num2 = num;
				num = (short)1459125983;
				switch (num2 == num)
				{
				}
				num = (short)133365760;
				short num3 = num;
				num = (short)1956249601;
				if (num != 0)
				{
				}
				num = (short)1780350976;
				if (num != 0)
				{
				}
				this.<DropInfo>k__BackingField = value;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000123D8 File Offset: 0x000105D8
		internal static global::Motorola.CommonCPS.RadioManagement.Controls.DropTargetAdorner a(global::System.Type A_0, global::System.Windows.UIElement A_1)
		{
			int a_ = 19;
			if (!typeof(global::Motorola.CommonCPS.RadioManagement.Controls.DropTargetAdorner).IsAssignableFrom(A_0))
			{
				short num = (short)614040360;
				short num2 = num;
				num = (short)1976075048;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)26279936;
					if (num != 0)
					{
					}
					num = (short)1111556097;
					if (num != 0)
					{
					}
					num = (short)1447428096;
					short num3 = num;
					throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﾪ얬쪮醰솲킴욶첸\udeba캼쮾꓀Ꟃꛆ귈꓊뿌ꇎ듐ꇒ듖뗘뫚껜곞쇠蟢諤苦髨쯪菬胮藰폲釴鋶诸鋺诼髾℀攂眄栆搈⬊䤌紎縐挒䄔瘖欘簚砜欞怠䜢䨤唦䜨个弬Į", a_));
				}
				}
			}
			global::System.Reflection.ConstructorInfo constructor = A_0.GetConstructor(new global::System.Type[]
			{
				typeof(global::System.Windows.UIElement)
			});
			object[] parameters = new global::System.Windows.UIElement[]
			{
				A_1
			};
			return (global::Motorola.CommonCPS.RadioManagement.Controls.DropTargetAdorner)constructor.Invoke(parameters);
		}

		// Token: 0x04000037 RID: 55
		private readonly global::System.Windows.Documents.AdornerLayer adornerLayer;
	}
}
