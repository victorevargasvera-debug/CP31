using System;
using System.Windows;

namespace Microsoft.Expression.Interactivity.Layout
{
	// Token: 0x0200001B RID: 27
	public sealed class FluidMoveSetTagBehavior : global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x000066FC File Offset: 0x000048FC
		internal override void UpdateLayoutTransitionCore(global::System.Windows.FrameworkElement child, global::System.Windows.FrameworkElement root, object tag, global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData newTagData)
		{
			global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData tagData;
			if (!global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagDictionary.TryGetValue(tag, out tagData))
			{
				tagData = new global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagData();
				global::Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase.TagDictionary.Add(tag, tagData);
			}
			tagData.ParentRect = newTagData.ParentRect;
			tagData.AppRect = newTagData.AppRect;
			tagData.Parent = newTagData.Parent;
			tagData.Child = newTagData.Child;
			tagData.Timestamp = newTagData.Timestamp;
		}
	}
}
