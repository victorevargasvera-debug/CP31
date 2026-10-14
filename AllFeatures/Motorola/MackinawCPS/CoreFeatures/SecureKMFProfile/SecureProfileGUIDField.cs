using System;
using System.Diagnostics;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib.UndoRedo;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000F9 RID: 249
	[global::System.Diagnostics.DebuggerDisplay("Name={UIName}, UIValue={UIValue}")]
	[global::System.Serializable]
	internal class SecureProfileGUIDField<TUIType> : global::AcpBusinessLayer.AcpFieldX<string, TUIType> where TUIType : global::System.IComparable
	{
		// Token: 0x06002555 RID: 9557 RVA: 0x00247698 File Offset: 0x00245898
		protected SecureProfileGUIDField()
		{
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x002476AC File Offset: 0x002458AC
		public SecureProfileGUIDField(string value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(value, converter, parent, name, uiLabel)
		{
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x002476C8 File Offset: 0x002458C8
		public SecureProfileGUIDField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(converter, parent, name, uiLabel)
		{
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x002476E0 File Offset: 0x002458E0
		public override void ResetToDefault()
		{
			short num = (short)1097865213;
			short num2 = num;
			num = (short)1524963325;
			switch (num2 == num)
			{
			}
			num = (short)1438187520;
			short num3 = num;
			num = (short)1980956673;
			if (num != 0)
			{
			}
			num = (short)1953759232;
			if (num != 0)
			{
			}
			this.DefaultValue = global::AllFeatures.CodeplugGuid.NewGuid();
			base.ResetToDefault();
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00247798 File Offset: 0x00245998
		public override void ResetToDefaultWithUndo()
		{
			short num = (short)1007778235;
			short num2 = num;
			num = (short)967145915;
			switch (num2 == num)
			{
			}
			num = (short)1029570560;
			short num3 = num;
			num = (short)265420800;
			if (num != 0)
			{
			}
			num = (short)222035969;
			if (num != 0)
			{
			}
			this.DefaultValue = global::AllFeatures.CodeplugGuid.NewGuid();
			base.ResetToDefaultWithUndo();
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00247854 File Offset: 0x00245A54
		public override void ResetToDefaultWithUndo(global::AcpCommonLib.UndoRedo.ContainerTask taskContainer)
		{
			short num = (short)1703368086;
			short num2 = num;
			num = (short)809129366;
			switch (num2 == num)
			{
			}
			num = (short)834011136;
			short num3 = num;
			num = (short)83099648;
			if (num != 0)
			{
			}
			num = (short)666370049;
			if (num != 0)
			{
			}
			this.DefaultValue = global::AllFeatures.CodeplugGuid.NewGuid();
			base.ResetToDefaultWithUndo(taskContainer);
		}
	}
}
