using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Microsoft.Expression.Media.Effects
{
	// Token: 0x0200002C RID: 44
	public abstract class TransitionEffect : global::System.Windows.Media.Effects.ShaderEffect
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00008DDD File Offset: 0x00006FDD
		public new global::Microsoft.Expression.Media.Effects.TransitionEffect CloneCurrentValue()
		{
			return (global::Microsoft.Expression.Media.Effects.TransitionEffect)base.CloneCurrentValue();
		}

		// Token: 0x0600018F RID: 399
		protected abstract global::Microsoft.Expression.Media.Effects.TransitionEffect DeepCopy();

		// Token: 0x06000190 RID: 400 RVA: 0x00008DEA File Offset: 0x00006FEA
		protected TransitionEffect()
		{
			base.UpdateShaderValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.InputProperty);
			base.UpdateShaderValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.OldImageProperty);
			base.UpdateShaderValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.ProgressProperty);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00008E13 File Offset: 0x00007013
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00008E25 File Offset: 0x00007025
		public global::System.Windows.Media.Brush Input
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.InputProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.InputProperty, value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00008E33 File Offset: 0x00007033
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00008E45 File Offset: 0x00007045
		public global::System.Windows.Media.Brush OldImage
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.OldImageProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.OldImageProperty, value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00008E53 File Offset: 0x00007053
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00008E65 File Offset: 0x00007065
		public double Progress
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.ProgressProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Expression.Media.Effects.TransitionEffect.ProgressProperty, value);
			}
		}

		// Token: 0x04000085 RID: 133
		public static readonly global::System.Windows.DependencyProperty InputProperty = global::System.Windows.Media.Effects.ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(global::Microsoft.Expression.Media.Effects.TransitionEffect), 0, global::System.Windows.Media.Effects.SamplingMode.NearestNeighbor);

		// Token: 0x04000086 RID: 134
		public static readonly global::System.Windows.DependencyProperty OldImageProperty = global::System.Windows.Media.Effects.ShaderEffect.RegisterPixelShaderSamplerProperty("OldImage", typeof(global::Microsoft.Expression.Media.Effects.TransitionEffect), 1, global::System.Windows.Media.Effects.SamplingMode.NearestNeighbor);

		// Token: 0x04000087 RID: 135
		public static readonly global::System.Windows.DependencyProperty ProgressProperty = global::System.Windows.DependencyProperty.Register("Progress", typeof(double), typeof(global::Microsoft.Expression.Media.Effects.TransitionEffect), new global::System.Windows.PropertyMetadata(0.0, global::System.Windows.Media.Effects.ShaderEffect.PixelShaderConstantCallback(0)));
	}
}
