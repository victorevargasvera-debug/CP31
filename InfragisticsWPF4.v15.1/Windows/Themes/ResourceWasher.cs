using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200022E RID: 558
	public class ResourceWasher : global::System.Windows.ResourceDictionary, global::System.ComponentModel.ISupportInitialize
	{
		// Token: 0x0600150D RID: 5389 RVA: 0x0004C226 File Offset: 0x0004A426
		public ResourceWasher()
		{
			this._originalDictioanries = new global::System.Collections.Generic.Dictionary<global::System.Windows.ResourceDictionary, global::System.Windows.ResourceDictionary>();
			this._originalToCloneTable = new global::System.Collections.Generic.Dictionary<object, object>();
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0004C256 File Offset: 0x0004A456
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Media.Brush))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Media.Pen))]
		public static bool GetIsExcludedFromWash(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Themes.ResourceWasher.IsExcludedFromWashProperty);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0004C268 File Offset: 0x0004A468
		public static void SetIsExcludedFromWash(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Themes.ResourceWasher.IsExcludedFromWashProperty, value);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0004C27B File Offset: 0x0004A47B
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Media.Pen))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::System.Windows.Media.Brush))]
		public static string GetWashGroup(global::System.Windows.DependencyObject d)
		{
			return (string)d.GetValue(global::Infragistics.Windows.Themes.ResourceWasher.WashGroupProperty);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0004C28D File Offset: 0x0004A48D
		public static void SetWashGroup(global::System.Windows.DependencyObject d, string value)
		{
			d.SetValue(global::Infragistics.Windows.Themes.ResourceWasher.WashGroupProperty, value);
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0004C29B File Offset: 0x0004A49B
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x0004C2A3 File Offset: 0x0004A4A3
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0004C2C1 File Offset: 0x0004A4C1
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0004C2C9 File Offset: 0x0004A4C9
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

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0004C2E7 File Offset: 0x0004A4E7
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x0004C2EF File Offset: 0x0004A4EF
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

		// Token: 0x06001518 RID: 5400 RVA: 0x0004C32A File Offset: 0x0004A52A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWashColor()
		{
			return this._washColor != global::System.Windows.Media.Colors.Transparent;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0004C33C File Offset: 0x0004A53C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWashColor()
		{
			this._washColor = global::System.Windows.Media.Colors.Transparent;
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0004C349 File Offset: 0x0004A549
		// (set) Token: 0x0600151B RID: 5403 RVA: 0x0004C354 File Offset: 0x0004A554
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0004C3AA File Offset: 0x0004A5AA
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x0004C3B4 File Offset: 0x0004A5B4
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

		// Token: 0x0600151E RID: 5406 RVA: 0x0004C41B File Offset: 0x0004A61B
		private void OnWashGroupsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnCriteriaChanged();
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0004C423 File Offset: 0x0004A623
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeWashGroups()
		{
			return this._washGroups != null && this._washGroups.Count > 0;
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0004C43D File Offset: 0x0004A63D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetWashGroups()
		{
			if (this._washGroups != null)
			{
				this._washGroups.Clear();
			}
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0004C452 File Offset: 0x0004A652
		public new void BeginInit()
		{
			this._isInitializing = true;
			base.BeginInit();
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0004C461 File Offset: 0x0004A661
		public new void EndInit()
		{
			this._isInitializing = false;
			if (this._autoWash)
			{
				this.WashResources();
			}
			base.EndInit();
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0004C480 File Offset: 0x0004A680
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

		// Token: 0x06001524 RID: 5412 RVA: 0x0004C570 File Offset: 0x0004A770
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
								global::Infragistics.Windows.Themes.ResourceWasher.AddToDictionary(resourceDictionary2, dictionaryEntry.Key, dictionaryEntry.Value);
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
								object value2;
								try
								{
									value2 = value.Value;
								}
								catch (global::System.Exception)
								{
									continue;
								}
								if (value2 is global::Infragistics.Windows.Themes.IResourceWasherTarget)
								{
									this.InitializeResourceTarget(value2 as global::Infragistics.Windows.Themes.IResourceWasherTarget, flag);
								}
								global::System.Windows.Media.Brush brush4 = value2 as global::System.Windows.Media.Brush;
								if (brush4 != null)
								{
									object obj3;
									if (this._originalToCloneTable.TryGetValue(brush4, out obj3))
									{
										brush4 = (global::System.Windows.Media.Brush)obj3;
									}
									global::System.Windows.Setter setter2 = new global::System.Windows.Setter();
									setter2.Property = value.Property;
									setter2.Value = this.WashBrushHelper(brush4, value2);
									style2.Setters.Add(setter2);
								}
								else if (value2 is global::System.Windows.Style)
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
				global::Infragistics.Windows.Themes.ResourceWasher.AddToDictionary(target, dictionaryEntry.Key, obj2);
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

		// Token: 0x06001525 RID: 5413 RVA: 0x0004CBFC File Offset: 0x0004ADFC
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

		// Token: 0x06001526 RID: 5414 RVA: 0x0004CCE4 File Offset: 0x0004AEE4
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
				resourceDictionary.MergedDictionaries.Insert(0, value as global::System.Windows.ResourceDictionary);
				value = resourceDictionary;
			}
			return value;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0004CD70 File Offset: 0x0004AF70
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

		// Token: 0x06001528 RID: 5416 RVA: 0x0004CDD8 File Offset: 0x0004AFD8
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

		// Token: 0x06001529 RID: 5417 RVA: 0x0004CE44 File Offset: 0x0004B044
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

		// Token: 0x0600152A RID: 5418 RVA: 0x0004CF20 File Offset: 0x0004B120
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

		// Token: 0x0600152B RID: 5419 RVA: 0x0004CFCE File Offset: 0x0004B1CE
		internal void VerifyThemeAccess()
		{
			if (this._themeWashInitialized)
			{
				return;
			}
			this.WashResources();
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0004CFDF File Offset: 0x0004B1DF
		private static void AddToDictionary(global::System.Windows.ResourceDictionary originalDictionary, object key, object value)
		{
			originalDictionary.Add(key, value);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0004CFEC File Offset: 0x0004B1EC
		private static int AdjustColorComponentValue(int startValue, int baseValue)
		{
			int num = startValue * baseValue / 255;
			return num + startValue * (255 - (255 - startValue) * (255 - baseValue) / 255 - num) / 255;
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0004D02C File Offset: 0x0004B22C
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

		// Token: 0x0600152F RID: 5423 RVA: 0x0004D0F0 File Offset: 0x0004B2F0
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

		// Token: 0x06001530 RID: 5424 RVA: 0x0004D150 File Offset: 0x0004B350
		private global::System.Windows.Media.Color GetWashColor(global::Infragistics.Windows.Themes.WashGroup group)
		{
			if (group != null && group.WashColor != null)
			{
				return group.WashColor.Value;
			}
			return this.WashColor;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0004D188 File Offset: 0x0004B388
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

		// Token: 0x06001532 RID: 5426 RVA: 0x0004D1C5 File Offset: 0x0004B3C5
		private void OnCriteriaChanged()
		{
			if (this._isInitializing || !this._autoWash)
			{
				this._themeWashInitialized = false;
				return;
			}
			this.WashResources();
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0004D1E8 File Offset: 0x0004B3E8
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

		// Token: 0x06001534 RID: 5428 RVA: 0x0004D263 File Offset: 0x0004B463
		private void VerifyCanBeModified()
		{
			global::Infragistics.Windows.Utilities.VerifyCanBeModified(this);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0004D26C File Offset: 0x0004B46C
		private global::System.Windows.Media.Color WashColorHelper(global::System.Windows.Media.Color startColor, global::Infragistics.Windows.Themes.WashGroup group)
		{
			global::System.Windows.Media.Color washColor = this.GetWashColor(group);
			return this.PerformColorWash(startColor, washColor, group);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0004D28C File Offset: 0x0004B48C
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

		// Token: 0x06001537 RID: 5431 RVA: 0x0004D2D4 File Offset: 0x0004B4D4
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

		// Token: 0x06001538 RID: 5432 RVA: 0x0004D370 File Offset: 0x0004B570
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

		// Token: 0x06001539 RID: 5433 RVA: 0x0004D3E3 File Offset: 0x0004B5E3
		private global::System.Windows.Media.Brush CloneBrush(global::System.Windows.Media.Brush sourceBrush)
		{
			return this.CloneBrush(sourceBrush, false, null);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0004D3EE File Offset: 0x0004B5EE
		private global::System.Windows.Media.Brush CloneBrush(global::System.Windows.Media.Brush sourceBrush, bool washColor, global::Infragistics.Windows.Themes.WashGroup group)
		{
			return sourceBrush.Clone();
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0004D3F6 File Offset: 0x0004B5F6
		private void CopyBrush(global::System.Windows.Media.Brush sourceBrush, global::System.Windows.Media.Brush destinationBrush)
		{
			this.CopyBrush(sourceBrush, destinationBrush, false, null);
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0004D404 File Offset: 0x0004B604
		private void CopyBrush(global::System.Windows.Media.Brush sourceBrush, global::System.Windows.Media.Brush destinationBrush, bool washColor, global::Infragistics.Windows.Themes.WashGroup group)
		{
			global::System.Windows.Media.SolidColorBrush solidColorBrush = sourceBrush as global::System.Windows.Media.SolidColorBrush;
			global::Infragistics.Windows.Themes.ResourceWasher.SetWashGroup(destinationBrush, global::Infragistics.Windows.Themes.ResourceWasher.GetWashGroup(sourceBrush));
			global::Infragistics.Windows.Themes.ResourceWasher.SetIsExcludedFromWash(destinationBrush, global::Infragistics.Windows.Themes.ResourceWasher.GetIsExcludedFromWash(sourceBrush));
			destinationBrush.Opacity = sourceBrush.Opacity;
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

		// Token: 0x0600153D RID: 5437 RVA: 0x0004D59D File Offset: 0x0004B79D
		void global::System.ComponentModel.ISupportInitialize.BeginInit()
		{
			this.BeginInit();
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0004D5A5 File Offset: 0x0004B7A5
		void global::System.ComponentModel.ISupportInitialize.EndInit()
		{
			this.EndInit();
		}

		// Token: 0x04000B31 RID: 2865
		private bool _autoWash = true;

		// Token: 0x04000B32 RID: 2866
		private bool _themeWashInitialized;

		// Token: 0x04000B33 RID: 2867
		private bool _isInitializing;

		// Token: 0x04000B34 RID: 2868
		private global::System.Windows.ResourceDictionary _sourceDictionary;

		// Token: 0x04000B35 RID: 2869
		private global::System.Windows.ResourceDictionary _clonedDictionary;

		// Token: 0x04000B36 RID: 2870
		private global::System.Windows.Media.Color _washColor = global::System.Windows.Media.Colors.Transparent;

		// Token: 0x04000B37 RID: 2871
		private global::Infragistics.Windows.Themes.WashMode _washMode;

		// Token: 0x04000B38 RID: 2872
		private global::Infragistics.Windows.Themes.WashGroupCollection _washGroups;

		// Token: 0x04000B39 RID: 2873
		private float _hue;

		// Token: 0x04000B3A RID: 2874
		private float _saturation;

		// Token: 0x04000B3B RID: 2875
		private global::System.Collections.Generic.Dictionary<global::System.Windows.ResourceDictionary, global::System.Windows.ResourceDictionary> _originalDictioanries;

		// Token: 0x04000B3C RID: 2876
		private global::System.Collections.Generic.Dictionary<object, object> _originalToCloneTable;

		// Token: 0x04000B3D RID: 2877
		public static readonly global::System.Windows.DependencyProperty IsExcludedFromWashProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsExcludedFromWash", typeof(bool), typeof(global::Infragistics.Windows.Themes.ResourceWasher), new global::System.Windows.FrameworkPropertyMetadata(false));

		// Token: 0x04000B3E RID: 2878
		public static readonly global::System.Windows.DependencyProperty WashGroupProperty = global::System.Windows.DependencyProperty.RegisterAttached("WashGroup", typeof(string), typeof(global::Infragistics.Windows.Themes.ResourceWasher), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
