using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001FE RID: 510
	public class ResourceWasher : global::System.Windows.ResourceDictionary, global::System.ComponentModel.ISupportInitialize
	{
		// Token: 0x06001330 RID: 4912 RVA: 0x00046516 File Offset: 0x00044716
		public ResourceWasher()
		{
			this._originalDictioanries = new global::System.Collections.Generic.Dictionary<global::System.Windows.ResourceDictionary, global::System.Windows.ResourceDictionary>();
			this._originalToCloneTable = new global::System.Collections.Generic.Dictionary<object, object>();
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00046546 File Offset: 0x00044746
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Media.Pen))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Media.Brush))]
		public static bool GetIsExcludedFromWash(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Themes.ResourceWasher.IsExcludedFromWashProperty);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x00046558 File Offset: 0x00044758
		public static void SetIsExcludedFromWash(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Themes.ResourceWasher.IsExcludedFromWashProperty, value);
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0004656B File Offset: 0x0004476B
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Media.Brush))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Media.Pen))]
		public static string GetWashGroup(global::System.Windows.DependencyObject d)
		{
			return (string)d.GetValue(global::Infragistics.Windows.Themes.ResourceWasher.WashGroupProperty);
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0004657D File Offset: 0x0004477D
		public static void SetWashGroup(global::System.Windows.DependencyObject d, string value)
		{
			d.SetValue(global::Infragistics.Windows.Themes.ResourceWasher.WashGroupProperty, value);
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0004658B File Offset: 0x0004478B
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x00046593 File Offset: 0x00044793
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AutoWash
		{
			get
			{
				return this._autoWash;
			}
			set
			{
				if (value != this._autoWash)
				{
					this.VerifyCanBeModified();
					this._autoWash = value;
					this.OnCriteriaChanged();
				}
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x000465B1 File Offset: 0x000447B1
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x000465B9 File Offset: 0x000447B9
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.ResourceDictionary SourceDictionary
		{
			get
			{
				return this._sourceDictionary;
			}
			set
			{
				if (value != this._sourceDictionary)
				{
					this.VerifyCanBeModified();
					this._sourceDictionary = value;
					this.OnCriteriaChanged();
				}
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x000465D7 File Offset: 0x000447D7
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x000465DF File Offset: 0x000447DF
		public global::System.Windows.Media.Color WashColor
		{
			get
			{
				return this._washColor;
			}
			set
			{
				if (value != this._washColor)
				{
					this.VerifyCanBeModified();
					this._washColor = value;
					this._hue = global::Infragistics.Windows.Themes.ResourceWasher.GetHue(value);
					this._saturation = global::Infragistics.Windows.Themes.ResourceWasher.GetSaturation(value);
					this.OnCriteriaChanged();
				}
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x0004661A File Offset: 0x0004481A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWashColor()
		{
			return this._washColor != global::System.Windows.Media.Colors.Transparent;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0004662C File Offset: 0x0004482C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWashColor()
		{
			this._washColor = global::System.Windows.Media.Colors.Transparent;
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x00046639 File Offset: 0x00044839
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x00046644 File Offset: 0x00044844
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.Themes.WashMode.SoftLightBlend)]
		public global::Infragistics.Windows.Themes.WashMode WashMode
		{
			get
			{
				return this._washMode;
			}
			set
			{
				if (value != this._washMode)
				{
					this.VerifyCanBeModified();
					if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Themes.WashMode), value))
					{
						throw new global::System.ComponentModel.InvalidEnumArgumentException("WashMode", (int)value, typeof(global::Infragistics.Windows.Themes.WashMode));
					}
					this._washMode = value;
					this.OnCriteriaChanged();
				}
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x0004669A File Offset: 0x0004489A
		// (set) Token: 0x06001340 RID: 4928 RVA: 0x000466A4 File Offset: 0x000448A4
		public global::Infragistics.Windows.Themes.WashGroupCollection WashGroups
		{
			get
			{
				return this._washGroups;
			}
			set
			{
				if (this._washGroups != value)
				{
					this.VerifyCanBeModified();
					if (this._washGroups != null)
					{
						this._washGroups.CollectionChanged -= this.OnWashGroupsCollectionChanged;
					}
					this._washGroups = value;
					if (this._washGroups != null)
					{
						this._washGroups.CollectionChanged += this.OnWashGroupsCollectionChanged;
					}
					this.OnCriteriaChanged();
				}
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0004670B File Offset: 0x0004490B
		private void OnWashGroupsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnCriteriaChanged();
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00046713 File Offset: 0x00044913
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWashGroups()
		{
			return this._washGroups != null && this._washGroups.Count > 0;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0004672D File Offset: 0x0004492D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWashGroups()
		{
			if (this._washGroups != null)
			{
				this._washGroups.Clear();
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00046742 File Offset: 0x00044942
		public new void BeginInit()
		{
			this._isInitializing = true;
			base.BeginInit();
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00046751 File Offset: 0x00044951
		public new void EndInit()
		{
			this._isInitializing = false;
			if (this._autoWash)
			{
				this.WashResources();
			}
			base.EndInit();
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00046770 File Offset: 0x00044970
		public void WashResources()
		{
			this._themeWashInitialized = true;
			if (this._clonedDictionary != null)
			{
				if (base.MergedDictionaries.Contains(this._clonedDictionary))
				{
					base.MergedDictionaries.Remove(this._clonedDictionary);
				}
				this._clonedDictionary.Clear();
				this._clonedDictionary.MergedDictionaries.Clear();
			}
			else
			{
				this._clonedDictionary = new global::System.Windows.ResourceDictionary();
			}
			if (this._sourceDictionary == null)
			{
				return;
			}
			if (this._washColor == global::System.Windows.Media.Colors.Transparent && this._originalDictioanries.Count == 0 && (this._washGroups == null || this._washGroups.Count == 0))
			{
				this._clonedDictionary.MergedDictionaries.Add(global::Infragistics.Windows.Themes.ThemeManager.Clone(this._sourceDictionary));
			}
			else
			{
				global::System.Collections.Generic.Dictionary<global::System.Windows.Style, global::System.Windows.Style> clonedStyles = new global::System.Collections.Generic.Dictionary<global::System.Windows.Style, global::System.Windows.Style>();
				this.WashResourcesHelper(this._sourceDictionary, this._clonedDictionary, clonedStyles);
			}
			base.MergedDictionaries.Add(this._clonedDictionary);
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00046860 File Offset: 0x00044A60
		private void WashResourcesHelper(global::System.Windows.ResourceDictionary source, global::System.Windows.ResourceDictionary target, global::System.Collections.Generic.Dictionary<global::System.Windows.Style, global::System.Windows.Style> clonedStyles)
		{
			target.MergedDictionaries.Clear();
			foreach (global::System.Windows.ResourceDictionary source2 in source.MergedDictionaries)
			{
				global::System.Windows.ResourceDictionary resourceDictionary = new global::System.Windows.ResourceDictionary();
				this.WashResourcesHelper(source2, resourceDictionary, clonedStyles);
				target.MergedDictionaries.Add(resourceDictionary);
			}
			bool flag = false;
			global::System.Windows.ResourceDictionary resourceDictionary2 = null;
			if (!this._originalDictioanries.ContainsKey(source))
			{
				resourceDictionary2 = new global::System.Windows.ResourceDictionary();
				this._originalDictioanries.Add(source, resourceDictionary2);
				flag = true;
			}
			else
			{
				resourceDictionary2 = this._originalDictioanries[source];
			}
			global::System.Collections.Generic.Dictionary<object, global::System.Windows.Media.Brush> dictionary = new global::System.Collections.Generic.Dictionary<object, global::System.Windows.Media.Brush>();
			global::System.Collections.Generic.Dictionary<object, global::System.Windows.Media.Pen> dictionary2 = new global::System.Collections.Generic.Dictionary<object, global::System.Windows.Media.Pen>();
			foreach (object obj in source)
			{
				global::System.Collections.DictionaryEntry dictionaryEntry = (global::System.Collections.DictionaryEntry)obj;
				if (flag)
				{
					global::System.Windows.Media.Brush brush = dictionaryEntry.Value as global::System.Windows.Media.Brush;
					if (brush != null)
					{
						brush = this.CloneBrush(brush);
						if (brush.CanFreeze)
						{
							brush.Freeze();
						}
						resourceDictionary2.Add(dictionaryEntry.Key, brush);
						this._originalToCloneTable[dictionaryEntry.Value] = brush;
					}
					else
					{
						global::System.Windows.Media.Pen pen = dictionaryEntry.Value as global::System.Windows.Media.Pen;
						if (pen != null)
						{
							string washGroup = global::Infragistics.Windows.Themes.ResourceWasher.GetWashGroup(pen);
							pen = pen.Clone();
							global::Infragistics.Windows.Themes.ResourceWasher.SetWashGroup(pen, washGroup);
							if (pen.CanFreeze)
							{
								pen.Freeze();
							}
							resourceDictionary2.Add(dictionaryEntry.Key, pen);
						}
						else
						{
							global::System.Collections.Generic.IList<global::System.Windows.Media.Brush> list = dictionaryEntry.Value as global::System.Collections.Generic.IList<global::System.Windows.Media.Brush>;
							if (list != null && !list.IsReadOnly)
							{
								global::System.Collections.Generic.List<global::System.Windows.Media.Brush> list2 = new global::System.Collections.Generic.List<global::System.Windows.Media.Brush>();
								foreach (global::System.Windows.Media.Brush sourceBrush in list)
								{
									global::System.Windows.Media.Brush brush2 = this.CloneBrush(sourceBrush);
									if (brush2.CanFreeze)
									{
										brush2.Freeze();
									}
									list2.Add(brush2);
								}
								resourceDictionary2.Add(dictionaryEntry.Key, list2);
							}
							else
							{
								resourceDictionary2.Add(dictionaryEntry.Key, dictionaryEntry.Value);
							}
						}
					}
				}
				object obj2 = dictionaryEntry.Value;
				global::System.Windows.Media.Brush brush3 = obj2 as global::System.Windows.Media.Brush;
				if (brush3 != null)
				{
					brush3 = (global::System.Windows.Media.Brush)resourceDictionary2[dictionaryEntry.Key];
					brush3 = (obj2 = this.WashBrushHelper(brush3, obj2));
					dictionary.Add(dictionaryEntry.Key, brush3);
				}
				else
				{
					global::System.Windows.Media.Pen pen2 = obj2 as global::System.Windows.Media.Pen;
					if (pen2 != null)
					{
						pen2 = (global::System.Windows.Media.Pen)resourceDictionary2[dictionaryEntry.Key];
						pen2 = (obj2 = this.WashPenHelper(pen2, obj2));
						dictionary2.Add(dictionaryEntry.Key, pen2);
					}
					else
					{
						global::System.Windows.Style style = obj2 as global::System.Windows.Style;
						if (style != null)
						{
							style = (global::System.Windows.Style)resourceDictionary2[dictionaryEntry.Key];
							global::System.Windows.Style style2;
							if (!clonedStyles.TryGetValue(style, out style2))
							{
								style2 = new global::System.Windows.Style(style.TargetType);
								style2.BasedOn = style;
								clonedStyles[style] = style2;
							}
							global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, global::System.Windows.Setter> dictionary3 = new global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, global::System.Windows.Setter>();
							while (style != null)
							{
								for (int i = style.Setters.Count - 1; i >= 0; i--)
								{
									global::System.Windows.Setter setter = style.Setters[i] as global::System.Windows.Setter;
									if (setter != null && setter.Property != null && !dictionary3.ContainsKey(setter.Property))
									{
										dictionary3[setter.Property] = setter;
									}
								}
								style = style.BasedOn;
							}
							foreach (global::System.Collections.Generic.KeyValuePair<global::System.Windows.DependencyProperty, global::System.Windows.Setter> keyValuePair in dictionary3)
							{
								global::System.Windows.Setter value = keyValuePair.Value;
								if (value.Value is global::Infragistics.Windows.Themes.IResourceWasherTarget)
								{
									this.InitializeResourceTarget(value.Value as global::Infragistics.Windows.Themes.IResourceWasherTarget, flag);
								}
								global::System.Windows.Media.Brush brush4 = value.Value as global::System.Windows.Media.Brush;
								if (brush4 != null)
								{
									object obj3;
									if (this._originalToCloneTable.TryGetValue(brush4, out obj3))
									{
										brush4 = (global::System.Windows.Media.Brush)obj3;
									}
									global::System.Windows.Setter setter2 = new global::System.Windows.Setter();
									setter2.Property = value.Property;
									setter2.Value = this.WashBrushHelper(brush4, value.Value);
									style2.Setters.Add(setter2);
								}
								else if (value.Value is global::System.Windows.Style)
								{
									global::System.Windows.Style style3 = value.Value as global::System.Windows.Style;
									global::System.Windows.Style style4;
									if (!clonedStyles.TryGetValue(style3, out style4))
									{
										style4 = new global::System.Windows.Style(style3.TargetType);
										style4.BasedOn = style3;
										clonedStyles[style3] = style4;
									}
									global::System.Windows.Setter item = new global::System.Windows.Setter(value.Property, style4);
									style2.Setters.Add(item);
								}
							}
							obj2 = style2;
						}
						else if (obj2 is global::System.Collections.Generic.IList<global::System.Windows.Media.Brush>)
						{
							global::System.Collections.Generic.IList<global::System.Windows.Media.Brush> list3 = obj2 as global::System.Collections.Generic.IList<global::System.Windows.Media.Brush>;
							if (!list3.IsReadOnly)
							{
								global::System.Collections.Generic.IList<global::System.Windows.Media.Brush> list4 = (global::System.Collections.Generic.IList<global::System.Windows.Media.Brush>)resourceDictionary2[dictionaryEntry.Key];
								int j = 0;
								int num = global::System.Math.Min(list3.Count, list4.Count);
								while (j < num)
								{
									list3[j] = this.WashBrushHelper(list4[j], list3[j]);
									j++;
								}
							}
						}
					}
				}
				target.Add(dictionaryEntry.Key, obj2);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Windows.Media.Brush> keyValuePair2 in dictionary)
			{
				global::System.Windows.Media.Brush brush5 = (global::System.Windows.Media.Brush)source[keyValuePair2.Key];
				if (!brush5.IsFrozen)
				{
					this.CopyBrush(keyValuePair2.Value, brush5);
				}
			}
			foreach (global::System.Collections.Generic.KeyValuePair<object, global::System.Windows.Media.Pen> keyValuePair3 in dictionary2)
			{
				global::System.Windows.Media.Pen pen3 = (global::System.Windows.Media.Pen)source[keyValuePair3.Key];
				if (!pen3.IsFrozen)
				{
					pen3.Brush = keyValuePair3.Value.Brush;
				}
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00046EDC File Offset: 0x000450DC
		protected virtual global::System.Windows.Media.Color PerformColorWash(global::System.Windows.Media.Color startColor, global::System.Windows.Media.Color washColor, global::Infragistics.Windows.Themes.WashGroup group)
		{
			if (washColor == global::System.Windows.Media.Colors.Transparent)
			{
				return startColor;
			}
			global::Infragistics.Windows.Themes.WashMode washMode;
			if (group != null && group.WashMode != null)
			{
				washMode = group.WashMode.Value;
			}
			else
			{
				washMode = this._washMode;
			}
			if (washMode == global::Infragistics.Windows.Themes.WashMode.SoftLightBlend)
			{
				int num = global::Infragistics.Windows.Themes.ResourceWasher.AdjustColorComponentValue((int)startColor.R, (int)washColor.R);
				int num2 = global::Infragistics.Windows.Themes.ResourceWasher.AdjustColorComponentValue((int)startColor.G, (int)washColor.G);
				int num3 = global::Infragistics.Windows.Themes.ResourceWasher.AdjustColorComponentValue((int)startColor.B, (int)washColor.B);
				return global::System.Windows.Media.Color.FromArgb(startColor.A, (byte)(num & 255), (byte)(num2 & 255), (byte)(num3 & 255));
			}
			float hue;
			float saturation;
			if (group != null)
			{
				hue = group.Hue;
				saturation = group.Saturation;
			}
			else
			{
				hue = this._hue;
				saturation = this._saturation;
			}
			return global::Infragistics.Windows.Themes.ResourceWasher.ColorFromHLS(startColor.A, hue, global::Infragistics.Windows.Themes.ResourceWasher.GetBrightness(startColor), saturation);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00046FC4 File Offset: 0x000451C4
		internal object CreateWashedResource(object value)
		{
			if (value is global::System.Windows.Media.Brush)
			{
				return this.WashBrushHelper(value as global::System.Windows.Media.Brush, null);
			}
			if (value is global::System.Windows.Media.Pen)
			{
				return this.WashPenHelper(value as global::System.Windows.Media.Pen, null);
			}
			if (value is global::System.Windows.Media.Color)
			{
				return this.WashColorHelper((global::System.Windows.Media.Color)value, null);
			}
			if (value is global::System.Windows.ResourceDictionary)
			{
				global::System.Windows.ResourceDictionary resourceDictionary = new global::System.Windows.ResourceDictionary();
				this.WashResourcesHelper(value as global::System.Windows.ResourceDictionary, resourceDictionary, new global::System.Collections.Generic.Dictionary<global::System.Windows.Style, global::System.Windows.Style>());
				value = resourceDictionary;
			}
			return value;
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0004703C File Offset: 0x0004523C
		internal static void ForceAutoWashResources(global::System.Windows.ResourceDictionary rd)
		{
			global::Infragistics.Windows.Themes.ResourceWasher resourceWasher = rd as global::Infragistics.Windows.Themes.ResourceWasher;
			if (resourceWasher != null)
			{
				if (!resourceWasher.AutoWash)
				{
					resourceWasher.WashResources();
					return;
				}
			}
			else
			{
				foreach (global::System.Windows.ResourceDictionary rd2 in rd.MergedDictionaries)
				{
					global::Infragistics.Windows.Themes.ResourceWasher.ForceAutoWashResources(rd2);
				}
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000470A4 File Offset: 0x000452A4
		internal static float GetBrightness(global::System.Windows.Media.Color color)
		{
			float num = (float)color.R / 255f;
			float num2 = (float)color.G / 255f;
			float num3 = (float)color.B / 255f;
			float num4 = (num > num2) ? num : num2;
			if (num3 > num4)
			{
				num4 = num3;
			}
			float num5 = (num < num2) ? num : num2;
			if (num3 < num5)
			{
				num5 = num3;
			}
			float num6 = num4 + num5;
			return num6 / 2f;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00047110 File Offset: 0x00045310
		internal static float GetHue(global::System.Windows.Media.Color color)
		{
			float num = (float)color.R / 255f;
			float num2 = (float)color.G / 255f;
			float num3 = (float)color.B / 255f;
			if (num == num2 && num == num3)
			{
				return 0f;
			}
			float num4 = (num > num2) ? num : num2;
			if (num3 > num4)
			{
				num4 = num3;
			}
			float num5 = (num < num2) ? num : num2;
			if (num3 < num5)
			{
				num5 = num3;
			}
			float num6 = num4 - num5;
			float num7 = 0f;
			if (num == num4)
			{
				num7 = (num2 - num3) / num6 * 60f;
			}
			else if (num2 == num4)
			{
				num7 = (num3 - num) / num6 * 60f;
				num7 += 120f;
			}
			else if (num3 == num4)
			{
				num7 = (num - num2) / num6 * 60f;
				num7 += 240f;
			}
			if (num7 < 0f)
			{
				num7 += 360f;
			}
			return num7;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000471EC File Offset: 0x000453EC
		internal static float GetSaturation(global::System.Windows.Media.Color color)
		{
			float num = (float)color.R / 255f;
			float num2 = (float)color.G / 255f;
			float num3 = (float)color.B / 255f;
			float num4 = (num > num2) ? num : num2;
			if (num3 > num4)
			{
				num4 = num3;
			}
			float num5 = (num < num2) ? num : num2;
			if (num3 < num5)
			{
				num5 = num3;
			}
			double num6 = (double)(num4 - num5);
			if (num6 == 0.0)
			{
				return 0f;
			}
			double num7 = (double)(num4 + num5);
			double num8 = num7 / 2.0;
			if (num8 > 0.5)
			{
				return (float)(num6 / (2.0 - num7));
			}
			return (float)(num6 / num7);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0004729A File Offset: 0x0004549A
		internal void VerifyThemeAccess()
		{
			if (this._themeWashInitialized)
			{
				return;
			}
			this.WashResources();
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x000472AC File Offset: 0x000454AC
		private static int AdjustColorComponentValue(int startValue, int baseValue)
		{
			int num = startValue * baseValue / 255;
			return num + startValue * (255 - (255 - startValue) * (255 - baseValue) / 255 - num) / 255;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000472EC File Offset: 0x000454EC
		private static global::System.Windows.Media.Color ColorFromHLS(byte alpha, float hue, float luminance, float saturation)
		{
			int num3;
			int num2;
			int num;
			if ((double)saturation == 0.0)
			{
				num = (num2 = (num3 = (int)((double)luminance * 255.0)));
			}
			else
			{
				float num4;
				if (luminance <= 0.5f)
				{
					num4 = luminance + luminance * saturation;
				}
				else
				{
					num4 = luminance + saturation - luminance * saturation;
				}
				float rm = 2f * luminance - num4;
				num2 = (int)global::Infragistics.Windows.Themes.ResourceWasher.ToRGBHelper(rm, num4, hue + 120f);
				num = (int)global::Infragistics.Windows.Themes.ResourceWasher.ToRGBHelper(rm, num4, hue);
				num3 = (int)global::Infragistics.Windows.Themes.ResourceWasher.ToRGBHelper(rm, num4, hue - 120f);
			}
			num2 = global::System.Math.Max(0, global::System.Math.Min(255, num2));
			num = global::System.Math.Max(0, global::System.Math.Min(255, num));
			num3 = global::System.Math.Max(0, global::System.Math.Min(255, num3));
			return global::System.Windows.Media.Color.FromArgb(alpha, (byte)num2, (byte)num, (byte)num3);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000473B0 File Offset: 0x000455B0
		private global::Infragistics.Windows.Themes.WashGroup GetGroupFromName(string groupName)
		{
			if (groupName == null || groupName.Length == 0 || this._washGroups == null)
			{
				return null;
			}
			int count = this._washGroups.Count;
			if (count == 0)
			{
				return null;
			}
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Themes.WashGroup washGroup = this._washGroups[i];
				if (washGroup.Name == groupName)
				{
					return washGroup;
				}
			}
			return null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00047410 File Offset: 0x00045610
		private global::System.Windows.Media.Color GetWashColor(global::Infragistics.Windows.Themes.WashGroup group)
		{
			if (group != null && group.WashColor != null)
			{
				return group.WashColor.Value;
			}
			return this.WashColor;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00047448 File Offset: 0x00045648
		private void InitializeResourceTarget(global::Infragistics.Windows.Themes.IResourceWasherTarget target, bool storeValues)
		{
			global::System.Windows.DependencyObject dependencyObject = target as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				if (dependencyObject is global::System.Windows.Freezable && ((global::System.Windows.Freezable)dependencyObject).IsFrozen)
				{
					return;
				}
				if (global::Infragistics.Windows.Themes.ResourceWasher.GetIsExcludedFromWash(dependencyObject))
				{
					return;
				}
			}
			target.ResourceWasher = this;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00047485 File Offset: 0x00045685
		private void OnCriteriaChanged()
		{
			if (this._isInitializing || !this._autoWash)
			{
				this._themeWashInitialized = false;
				return;
			}
			this.WashResources();
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000474A8 File Offset: 0x000456A8
		private static float ToRGBHelper(float rm1, float rm2, float rh)
		{
			if (rh > 360f)
			{
				rh -= 360f;
			}
			else if (rh < 0f)
			{
				rh += 360f;
			}
			if (rh < 60f)
			{
				rm1 += (rm2 - rm1) * rh / 60f;
			}
			else if (rh < 180f)
			{
				rm1 = rm2;
			}
			else if (rh < 240f)
			{
				rm1 += (rm2 - rm1) * (240f - rh) / 60f;
			}
			return rm1 * 255f;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00047523 File Offset: 0x00045723
		private void VerifyCanBeModified()
		{
			global::Infragistics.Windows.Utilities.VerifyCanBeModified(this);
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0004752C File Offset: 0x0004572C
		private global::System.Windows.Media.Color WashColorHelper(global::System.Windows.Media.Color startColor, global::Infragistics.Windows.Themes.WashGroup group)
		{
			global::System.Windows.Media.Color washColor = this.GetWashColor(group);
			return this.PerformColorWash(startColor, washColor, group);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0004754C File Offset: 0x0004574C
		private global::System.Windows.Media.Brush WashBrushHelper(global::System.Windows.Media.Brush sourceBrush, object sourceObject)
		{
			if (global::Infragistics.Windows.Themes.ResourceWasher.GetIsExcludedFromWash(sourceBrush))
			{
				return sourceBrush;
			}
			string washGroup = global::Infragistics.Windows.Themes.ResourceWasher.GetWashGroup(sourceBrush);
			global::Infragistics.Windows.Themes.WashGroup groupFromName = this.GetGroupFromName(washGroup);
			global::System.Windows.Media.Brush brush = this.WashBrushHelper(sourceBrush, groupFromName);
			global::System.Windows.Freezable freezable = sourceObject as global::System.Windows.Freezable;
			if (freezable != null && freezable.IsFrozen)
			{
				brush.Freeze();
			}
			return brush;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00047594 File Offset: 0x00045794
		private global::System.Windows.Media.Brush WashBrushHelper(global::System.Windows.Media.Brush sourceBrush, global::Infragistics.Windows.Themes.WashGroup group)
		{
			global::System.Windows.Media.Color washColor = this.GetWashColor(group);
			if (washColor == global::System.Windows.Media.Colors.Transparent)
			{
				return sourceBrush;
			}
			global::System.Windows.Media.Brush brush = sourceBrush.Clone();
			global::System.Windows.Media.SolidColorBrush solidColorBrush = brush as global::System.Windows.Media.SolidColorBrush;
			if (solidColorBrush != null)
			{
				solidColorBrush.Color = this.WashColorHelper(solidColorBrush.Color, group);
				return solidColorBrush;
			}
			global::System.Windows.Media.GradientBrush gradientBrush = brush as global::System.Windows.Media.GradientBrush;
			if (gradientBrush != null)
			{
				global::System.Windows.Media.GradientStopCollection gradientStops = gradientBrush.GradientStops;
				int count = gradientStops.Count;
				for (int i = 0; i < count; i++)
				{
					global::System.Windows.Media.GradientStop gradientStop = gradientStops[i];
					gradientStop.Color = this.WashColorHelper(gradientStop.Color, group);
				}
				return gradientBrush;
			}
			return brush;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00047630 File Offset: 0x00045830
		private global::System.Windows.Media.Pen WashPenHelper(global::System.Windows.Media.Pen sourcePen, object sourceObject)
		{
			if (global::Infragistics.Windows.Themes.ResourceWasher.GetIsExcludedFromWash(sourcePen))
			{
				return sourcePen;
			}
			string washGroup = global::Infragistics.Windows.Themes.ResourceWasher.GetWashGroup(sourcePen);
			global::Infragistics.Windows.Themes.WashGroup groupFromName = this.GetGroupFromName(washGroup);
			global::System.Windows.Media.Color washColor = this.GetWashColor(groupFromName);
			if (washColor == global::System.Windows.Media.Colors.Transparent)
			{
				return sourcePen;
			}
			global::System.Windows.Media.Pen pen = sourcePen.Clone();
			pen.Brush = this.WashBrushHelper(sourcePen.Brush, groupFromName);
			global::System.Windows.Freezable freezable = sourceObject as global::System.Windows.Freezable;
			if (freezable != null && freezable.IsFrozen)
			{
				pen.Freeze();
			}
			return pen;
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000476A3 File Offset: 0x000458A3
		private global::System.Windows.Media.Brush CloneBrush(global::System.Windows.Media.Brush sourceBrush)
		{
			return this.CloneBrush(sourceBrush, false, null);
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000476AE File Offset: 0x000458AE
		private global::System.Windows.Media.Brush CloneBrush(global::System.Windows.Media.Brush sourceBrush, bool washColor, global::Infragistics.Windows.Themes.WashGroup group)
		{
			return sourceBrush.Clone();
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000476B6 File Offset: 0x000458B6
		private void CopyBrush(global::System.Windows.Media.Brush sourceBrush, global::System.Windows.Media.Brush destinationBrush)
		{
			this.CopyBrush(sourceBrush, destinationBrush, false, null);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000476C4 File Offset: 0x000458C4
		private void CopyBrush(global::System.Windows.Media.Brush sourceBrush, global::System.Windows.Media.Brush destinationBrush, bool washColor, global::Infragistics.Windows.Themes.WashGroup group)
		{
			global::System.Windows.Media.SolidColorBrush solidColorBrush = sourceBrush as global::System.Windows.Media.SolidColorBrush;
			global::Infragistics.Windows.Themes.ResourceWasher.SetWashGroup(destinationBrush, global::Infragistics.Windows.Themes.ResourceWasher.GetWashGroup(sourceBrush));
			global::Infragistics.Windows.Themes.ResourceWasher.SetIsExcludedFromWash(destinationBrush, global::Infragistics.Windows.Themes.ResourceWasher.GetIsExcludedFromWash(sourceBrush));
			if (solidColorBrush == null)
			{
				global::System.Windows.Media.GradientBrush gradientBrush = sourceBrush as global::System.Windows.Media.GradientBrush;
				if (gradientBrush != null)
				{
					global::System.Windows.Media.GradientBrush gradientBrush2 = destinationBrush as global::System.Windows.Media.GradientBrush;
					if (gradientBrush2 != null)
					{
						gradientBrush2.GradientStops.Clear();
						global::System.Windows.Media.GradientStopCollection gradientStops = gradientBrush.GradientStops;
						int count = gradientStops.Count;
						for (int i = 0; i < count; i++)
						{
							global::System.Windows.Media.GradientStop gradientStop = gradientStops[i];
							global::System.Windows.Media.GradientStop gradientStop2 = new global::System.Windows.Media.GradientStop();
							if (washColor)
							{
								gradientStop2.Color = this.WashColorHelper(gradientStop.Color, group);
							}
							else
							{
								gradientStop2.Color = gradientStop.Color;
							}
							gradientStop2.Offset = gradientStop.Offset;
							gradientBrush2.GradientStops.Add(gradientStop2);
						}
						if (gradientBrush is global::System.Windows.Media.LinearGradientBrush && destinationBrush is global::System.Windows.Media.LinearGradientBrush)
						{
							global::System.Windows.Media.LinearGradientBrush linearGradientBrush = (global::System.Windows.Media.LinearGradientBrush)gradientBrush;
							global::System.Windows.Media.LinearGradientBrush linearGradientBrush2 = (global::System.Windows.Media.LinearGradientBrush)destinationBrush;
							linearGradientBrush2.StartPoint = linearGradientBrush.StartPoint;
							linearGradientBrush2.EndPoint = linearGradientBrush.EndPoint;
							return;
						}
						if (gradientBrush is global::System.Windows.Media.RadialGradientBrush && destinationBrush is global::System.Windows.Media.RadialGradientBrush)
						{
							global::System.Windows.Media.RadialGradientBrush radialGradientBrush = (global::System.Windows.Media.RadialGradientBrush)gradientBrush;
							global::System.Windows.Media.RadialGradientBrush radialGradientBrush2 = (global::System.Windows.Media.RadialGradientBrush)destinationBrush;
							radialGradientBrush2.Center = radialGradientBrush.Center;
							radialGradientBrush2.RadiusX = radialGradientBrush.RadiusX;
							radialGradientBrush2.RadiusY = radialGradientBrush.RadiusY;
							radialGradientBrush2.GradientOrigin = radialGradientBrush.GradientOrigin;
						}
					}
				}
				return;
			}
			global::System.Windows.Media.SolidColorBrush solidColorBrush2 = destinationBrush as global::System.Windows.Media.SolidColorBrush;
			if (washColor)
			{
				solidColorBrush2.Color = this.WashColorHelper(solidColorBrush.Color, group);
				return;
			}
			solidColorBrush2.Color = solidColorBrush.Color;
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00047851 File Offset: 0x00045A51
		void global::System.ComponentModel.ISupportInitialize.BeginInit()
		{
			this.BeginInit();
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00047859 File Offset: 0x00045A59
		void global::System.ComponentModel.ISupportInitialize.EndInit()
		{
			this.EndInit();
		}

		// Token: 0x040009E6 RID: 2534
		private bool _autoWash = true;

		// Token: 0x040009E7 RID: 2535
		private bool _themeWashInitialized;

		// Token: 0x040009E8 RID: 2536
		private bool _isInitializing;

		// Token: 0x040009E9 RID: 2537
		private global::System.Windows.ResourceDictionary _sourceDictionary;

		// Token: 0x040009EA RID: 2538
		private global::System.Windows.ResourceDictionary _clonedDictionary;

		// Token: 0x040009EB RID: 2539
		private global::System.Windows.Media.Color _washColor = global::System.Windows.Media.Colors.Transparent;

		// Token: 0x040009EC RID: 2540
		private global::Infragistics.Windows.Themes.WashMode _washMode;

		// Token: 0x040009ED RID: 2541
		private global::Infragistics.Windows.Themes.WashGroupCollection _washGroups;

		// Token: 0x040009EE RID: 2542
		private float _hue;

		// Token: 0x040009EF RID: 2543
		private float _saturation;

		// Token: 0x040009F0 RID: 2544
		private global::System.Collections.Generic.Dictionary<global::System.Windows.ResourceDictionary, global::System.Windows.ResourceDictionary> _originalDictioanries;

		// Token: 0x040009F1 RID: 2545
		private global::System.Collections.Generic.Dictionary<object, object> _originalToCloneTable;

		// Token: 0x040009F2 RID: 2546
		public static readonly global::System.Windows.DependencyProperty IsExcludedFromWashProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsExcludedFromWash", typeof(bool), typeof(global::Infragistics.Windows.Themes.ResourceWasher), new global::System.Windows.FrameworkPropertyMetadata(false));

		// Token: 0x040009F3 RID: 2547
		public static readonly global::System.Windows.DependencyProperty WashGroupProperty = global::System.Windows.DependencyProperty.RegisterAttached("WashGroup", typeof(string), typeof(global::Infragistics.Windows.Themes.ResourceWasher), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
