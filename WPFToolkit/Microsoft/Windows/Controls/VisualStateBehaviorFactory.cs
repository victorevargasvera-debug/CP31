using System;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200002B RID: 43
	internal class VisualStateBehaviorFactory : global::Microsoft.Windows.Controls.TypeHandlerFactory<global::Microsoft.Windows.Controls.VisualStateBehavior>
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000098B2 File Offset: 0x00007AB2
		internal static global::Microsoft.Windows.Controls.VisualStateBehaviorFactory Instance
		{
			get
			{
				if (global::Microsoft.Windows.Controls.VisualStateBehaviorFactory._instance == null)
				{
					global::Microsoft.Windows.Controls.VisualStateBehaviorFactory._instance = new global::Microsoft.Windows.Controls.VisualStateBehaviorFactory();
				}
				return global::Microsoft.Windows.Controls.VisualStateBehaviorFactory._instance;
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000098CA File Offset: 0x00007ACA
		private VisualStateBehaviorFactory()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000098D4 File Offset: 0x00007AD4
		internal static void AttachBehavior(global::System.Windows.Controls.Control control)
		{
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(control, global::Microsoft.Windows.Controls.VisualStateBehavior.VisualStateBehaviorProperty).BaseValueSource == global::System.Windows.BaseValueSource.Default)
			{
				if (!global::Microsoft.Windows.Controls.VisualStateBehaviorFactory._registeredKnownTypes)
				{
					global::Microsoft.Windows.Controls.VisualStateBehaviorFactory._registeredKnownTypes = true;
					global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.RegisterControlBehavior(new global::Microsoft.Windows.Controls.ButtonBaseBehavior());
					global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.RegisterControlBehavior(new global::Microsoft.Windows.Controls.ToggleButtonBehavior());
					global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.RegisterControlBehavior(new global::Microsoft.Windows.Controls.ListBoxItemBehavior());
					global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.RegisterControlBehavior(new global::Microsoft.Windows.Controls.TextBoxBaseBehavior());
					global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.RegisterControlBehavior(new global::Microsoft.Windows.Controls.ProgressBarBehavior());
				}
				global::Microsoft.Windows.Controls.VisualStateBehavior handler = global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.Instance.GetHandler(control.GetType());
				if (handler != null)
				{
					global::Microsoft.Windows.Controls.VisualStateBehavior.SetVisualStateBehavior(control, handler);
				}
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00009951 File Offset: 0x00007B51
		internal static void RegisterControlBehavior(global::Microsoft.Windows.Controls.VisualStateBehavior behavior)
		{
			global::Microsoft.Windows.Controls.VisualStateBehaviorFactory.Instance.RegisterHandler(behavior);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000995E File Offset: 0x00007B5E
		protected override global::System.Type GetBaseType(global::Microsoft.Windows.Controls.VisualStateBehavior behavior)
		{
			return behavior.TargetType;
		}

		// Token: 0x04000093 RID: 147
		[global::System.ThreadStatic]
		private static global::Microsoft.Windows.Controls.VisualStateBehaviorFactory _instance;

		// Token: 0x04000094 RID: 148
		[global::System.ThreadStatic]
		private static bool _registeredKnownTypes;
	}
}
