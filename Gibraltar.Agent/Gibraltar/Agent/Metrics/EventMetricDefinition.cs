using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Gibraltar.Agent.Metrics.Internal;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x02000020 RID: 32
	public sealed class EventMetricDefinition : global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition, global::System.IComparable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.IEquatable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.IComparable<global::Gibraltar.Agent.Metrics.EventMetricDefinition>, global::System.IEquatable<global::Gibraltar.Agent.Metrics.EventMetricDefinition>
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x00006044 File Offset: 0x00004244
		public EventMetricDefinition(string metricsSystem, string categoryName, string counterName) : this(new global::Gibraltar.Monitor.EventMetricDefinition(metricsSystem, categoryName, counterName))
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00006054 File Offset: 0x00004254
		internal EventMetricDefinition(global::Gibraltar.Monitor.EventMetricDefinition metricDefinition)
		{
			this.m_WrappedDefinition = metricDefinition;
			this.m_Metrics = new global::Gibraltar.Agent.Metrics.EventMetricCollection(this);
			this.m_MetricValues = new global::Gibraltar.Agent.Metrics.EventMetricValueDefinitionCollection(this);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000607C File Offset: 0x0000427C
		public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition AddValue(string name, global::System.Type type, global::Gibraltar.Agent.Metrics.SummaryFunction summaryFunction, string unitCaption, string caption, string description)
		{
			return this.ValueCollection.Add(name, type, summaryFunction, unitCaption, caption, description);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000060A4 File Offset: 0x000042A4
		internal static global::Gibraltar.Agent.Metrics.EventMetricDefinition[] RegisterAll(object metricData)
		{
			global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.EventMetricDefinition> list = new global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.EventMetricDefinition>();
			if (metricData != null)
			{
				global::System.Type type = (metricData as global::System.Type) ?? metricData.GetType();
				global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type[]> obj = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_InheritanceMap;
				global::System.Type[] array;
				bool flag;
				lock (obj)
				{
					flag = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_InheritanceMap.TryGetValue(type, out array);
				}
				if (flag)
				{
					foreach (global::System.Type metricDataObjectType in array)
					{
						global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition;
						try
						{
							eventMetricDefinition = global::Gibraltar.Agent.Metrics.EventMetricDefinition.RegisterType(metricDataObjectType);
						}
						catch
						{
							eventMetricDefinition = null;
						}
						if (eventMetricDefinition != null)
						{
							list.Add(eventMetricDefinition);
						}
					}
				}
				else
				{
					global::System.Collections.Generic.List<global::System.Type> list2 = new global::System.Collections.Generic.List<global::System.Type>();
					if (type.IsDefined(typeof(global::Gibraltar.Agent.Metrics.EventMetricAttribute), false))
					{
						global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition;
						try
						{
							list2.Add(type);
							eventMetricDefinition = global::Gibraltar.Agent.Metrics.EventMetricDefinition.RegisterType(type);
						}
						catch
						{
							eventMetricDefinition = null;
						}
						if (eventMetricDefinition != null)
						{
							list.Add(eventMetricDefinition);
						}
					}
					foreach (global::System.Type type2 in type.GetInterfaces())
					{
						if (type2.IsDefined(typeof(global::Gibraltar.Agent.Metrics.EventMetricAttribute), false))
						{
							global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition;
							try
							{
								list2.Add(type2);
								eventMetricDefinition = global::Gibraltar.Agent.Metrics.EventMetricDefinition.RegisterType(type2);
							}
							catch
							{
								eventMetricDefinition = null;
							}
							if (eventMetricDefinition != null)
							{
								list.Add(eventMetricDefinition);
							}
						}
					}
					global::System.Type type3 = type.IsInterface ? null : type.BaseType;
					while (type3 != null && type3 != typeof(object) && !type3.IsInterface)
					{
						if (type3.IsDefined(typeof(global::Gibraltar.Agent.Metrics.EventMetricAttribute), false))
						{
							global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition;
							try
							{
								list2.Add(type3);
								eventMetricDefinition = global::Gibraltar.Agent.Metrics.EventMetricDefinition.RegisterType(type3);
							}
							catch
							{
								eventMetricDefinition = null;
							}
							if (eventMetricDefinition != null)
							{
								list.Add(eventMetricDefinition);
							}
						}
						type3 = type3.BaseType;
					}
					obj = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_InheritanceMap;
					lock (obj)
					{
						global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_InheritanceMap[type] = list2.ToArray();
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00006314 File Offset: 0x00004514
		private static global::System.Type GetTypeOfMember(global::System.Reflection.MemberInfo member)
		{
			global::System.Type result;
			if (member.MemberType == global::System.Reflection.MemberTypes.Method)
			{
				result = ((global::System.Reflection.MethodInfo)member).ReturnType;
			}
			else if (member.MemberType == global::System.Reflection.MemberTypes.Property)
			{
				global::System.Reflection.PropertyInfo propertyInfo = (global::System.Reflection.PropertyInfo)member;
				if (propertyInfo.CanRead)
				{
					result = propertyInfo.PropertyType;
				}
				else
				{
					result = null;
				}
			}
			else if (member.MemberType == global::System.Reflection.MemberTypes.Field)
			{
				result = ((global::System.Reflection.FieldInfo)member).FieldType;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00006394 File Offset: 0x00004594
		internal static global::Gibraltar.Agent.Metrics.EventMetricDefinition RegisterType(global::System.Type metricDataObjectType)
		{
			object obj = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_DictionaryLock;
			global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition;
			lock (obj)
			{
				if (!global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_DefinitionMap.TryGetValue(metricDataObjectType, out eventMetricDefinition))
				{
					global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_DefinitionMap[metricDataObjectType] = null;
					if (!metricDataObjectType.IsDefined(typeof(global::Gibraltar.Agent.Metrics.EventMetricAttribute), false))
					{
						throw new global::System.ArgumentException("The specified Type does not have an EventMetric attribute, so it can't be used to define an event metric.", "metricDataObjectType");
					}
					global::Gibraltar.Agent.Metrics.EventMetricAttribute eventMetricAttribute = global::System.Attribute.GetCustomAttribute(metricDataObjectType, typeof(global::Gibraltar.Agent.Metrics.EventMetricAttribute)) as global::Gibraltar.Agent.Metrics.EventMetricAttribute;
					if (eventMetricAttribute == null)
					{
						throw new global::System.ArgumentException("The specified Type does not have a usable EventMetric attribute, so it can't be used to define an event metric.", "metricDataObjectType");
					}
					string metricsSystem = eventMetricAttribute.MetricsSystem;
					if (string.IsNullOrEmpty(metricsSystem))
					{
						throw new global::System.ArgumentException("The specified Type's EventMetric has an empty metric namespace which is not allowed, so no metric can be defined.");
					}
					string metricCategoryName = eventMetricAttribute.MetricCategoryName;
					if (string.IsNullOrEmpty(metricCategoryName))
					{
						throw new global::System.ArgumentException("The specified Type's EventMetric has an empty metric category name which is not allowed, so no metric can be defined.");
					}
					string counterName = eventMetricAttribute.CounterName;
					if (string.IsNullOrEmpty(counterName))
					{
						throw new global::System.ArgumentException("The specified Type's EventMetric has an empty metric counter name which is not allowed, so no metric can be defined.");
					}
					object @lock = global::Gibraltar.Agent.Log.MetricDefinitions.Lock;
					lock (@lock)
					{
						global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
						if (global::Gibraltar.Agent.Log.MetricDefinitions.TryGetValue(metricsSystem, metricCategoryName, counterName, out metricDefinition))
						{
							eventMetricDefinition = (metricDefinition as global::Gibraltar.Agent.Metrics.EventMetricDefinition);
							if (eventMetricDefinition == null)
							{
								throw new global::System.ArgumentException("The specified Type's EventMetric attribute's 3-part Key is already used for a metric definition which is not an event metric.");
							}
						}
						else
						{
							eventMetricDefinition = new global::Gibraltar.Agent.Metrics.EventMetricDefinition(metricsSystem, metricCategoryName, counterName);
							eventMetricDefinition.BoundType = metricDataObjectType;
							eventMetricDefinition.Caption = eventMetricAttribute.Caption;
							eventMetricDefinition.Description = eventMetricAttribute.Description;
							foreach (global::System.Reflection.MemberInfo memberInfo in metricDataObjectType.FindMembers(global::System.Reflection.MemberTypes.Field | global::System.Reflection.MemberTypes.Method | global::System.Reflection.MemberTypes.Property, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, global::System.Type.FilterName, "*"))
							{
								if (memberInfo.IsDefined(typeof(global::Gibraltar.Agent.Metrics.EventMetricInstanceNameAttribute), false))
								{
									if (eventMetricDefinition.NameBound)
									{
										global::System.Diagnostics.Trace.TraceWarning("There is more than one member on the type {0} with the EventMetricInstanceName attribute.  The member {1} will be used because it was found first.", new object[]
										{
											metricDataObjectType.FullName,
											eventMetricDefinition.NameMemberName
										});
									}
									else
									{
										eventMetricDefinition.NameBound = true;
										eventMetricDefinition.NameMemberType = memberInfo.MemberType;
										eventMetricDefinition.NameMemberName = memberInfo.Name;
									}
								}
								if (memberInfo.IsDefined(typeof(global::Gibraltar.Agent.Metrics.EventMetricValueAttribute), false))
								{
									global::System.Type typeOfMember = global::Gibraltar.Agent.Metrics.EventMetricDefinition.GetTypeOfMember(memberInfo);
									object[] customAttributes = memberInfo.GetCustomAttributes(typeof(global::Gibraltar.Agent.Metrics.EventMetricValueAttribute), false);
									for (int j = 0; j < customAttributes.Length; j++)
									{
										global::Gibraltar.Agent.Metrics.EventMetricValueAttribute eventMetricValueAttribute = customAttributes[j] as global::Gibraltar.Agent.Metrics.EventMetricValueAttribute;
										if (eventMetricValueAttribute != null)
										{
											if (string.IsNullOrEmpty(eventMetricValueAttribute.Name))
											{
												eventMetricValueAttribute.SetName(memberInfo.Name);
											}
											if (eventMetricDefinition.ValueCollection.ContainsKey(eventMetricValueAttribute.Name))
											{
												global::System.Diagnostics.Trace.TraceWarning("Unable to add member {1} as event value column {2} because event metric definition {0} already has another value with the same name.  Make sure each value has a unique name.", new object[]
												{
													eventMetricDefinition.Key,
													memberInfo.Name,
													eventMetricValueAttribute.Name
												});
											}
											else if (typeOfMember == null)
											{
												global::System.Diagnostics.Trace.TraceWarning("Unable to add property {1} to event metric definition {0} as event value column {2} because the property isn't readable.", new object[]
												{
													eventMetricDefinition.Key,
													memberInfo.Name,
													eventMetricValueAttribute.Name
												});
											}
											else if (typeOfMember == typeof(void))
											{
												global::System.Diagnostics.Trace.TraceWarning("Unable to add method {1} to event metric definition {0} as event value column {2} because its return value is void", new object[]
												{
													eventMetricDefinition.Key,
													memberInfo.Name,
													eventMetricValueAttribute.Name
												});
											}
											else
											{
												global::Gibraltar.Agent.Metrics.EventMetricValueDefinition eventMetricValueDefinition = eventMetricDefinition.ValueCollection.Add(eventMetricValueAttribute.Name, typeOfMember);
												eventMetricValueDefinition.Bound = true;
												eventMetricValueDefinition.MemberType = memberInfo.MemberType;
												eventMetricValueDefinition.MemberName = memberInfo.Name;
												eventMetricValueDefinition.UnitCaption = eventMetricValueAttribute.UnitCaption;
												eventMetricValueDefinition.SummaryFunction = eventMetricValueAttribute.SummaryFunction;
												eventMetricValueDefinition.Caption = eventMetricValueAttribute.Caption;
												eventMetricValueDefinition.Description = eventMetricValueAttribute.Description;
												if (eventMetricDefinition.DefaultValue == null && eventMetricValueAttribute.IsDefaultValue)
												{
													eventMetricDefinition.DefaultValue = eventMetricValueDefinition;
												}
											}
										}
									}
								}
							}
							eventMetricDefinition.IsBound = true;
							eventMetricDefinition.WrappedDefinition.SetReadOnly();
							global::Gibraltar.Agent.Log.MetricDefinitions.Add(eventMetricDefinition);
						}
					}
					global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_DefinitionMap[metricDataObjectType] = eventMetricDefinition;
				}
			}
			return eventMetricDefinition;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000067D4 File Offset: 0x000049D4
		public static void Register(ref global::Gibraltar.Agent.Metrics.EventMetricDefinition newDefinition)
		{
			global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition = newDefinition;
			if (eventMetricDefinition == null)
			{
				throw new global::System.ArgumentNullException("newDefinition", "A null definition can not be registered nor used to look up a registered event metric definition.");
			}
			global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition2 = eventMetricDefinition.Register();
			if (eventMetricDefinition2 == null || !eventMetricDefinition2.IsReadOnly)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Unknown error registering new event metric definition: metrics system ({0}), category name ({1}), counter name ({2})", new object[]
				{
					eventMetricDefinition.MetricsSystem,
					eventMetricDefinition.CategoryName,
					eventMetricDefinition.CounterName
				}));
			}
			newDefinition = eventMetricDefinition2;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00006850 File Offset: 0x00004A50
		public static void Register(ref global::Gibraltar.Agent.Metrics.EventMetricDefinition newDefinition, string defaultValue)
		{
			global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition = newDefinition;
			if (eventMetricDefinition == null)
			{
				throw new global::System.ArgumentNullException("newDefinition", "A null definition can not be registered nor used to look up a registered event metric definition.");
			}
			if (string.IsNullOrEmpty(defaultValue))
			{
				throw new global::System.ArgumentNullException("defaultValue", "The specified defaultValue name must be a legal value column name and thus may not be null or empty.");
			}
			object @lock = eventMetricDefinition.Lock;
			lock (@lock)
			{
				global::Gibraltar.Agent.Metrics.EventMetricValueDefinition defaultValue2;
				try
				{
					defaultValue2 = eventMetricDefinition.ValueCollection[defaultValue];
				}
				catch (global::System.Collections.Generic.KeyNotFoundException innerException)
				{
					throw new global::System.Collections.Generic.KeyNotFoundException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The specified defaultValue column name ({0}) was not found in the definition.", new object[]
					{
						defaultValue
					}), innerException);
				}
				eventMetricDefinition.DefaultValue = defaultValue2;
				global::Gibraltar.Agent.Metrics.EventMetricDefinition.Register(ref eventMetricDefinition);
			}
			newDefinition = eventMetricDefinition;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000690C File Offset: 0x00004B0C
		public static void Register(ref global::Gibraltar.Agent.Metrics.EventMetricDefinition newDefinition, global::Gibraltar.Agent.Metrics.EventMetricValueDefinition defaultValue)
		{
			global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition = newDefinition;
			if (eventMetricDefinition == null)
			{
				throw new global::System.ArgumentNullException("newDefinition", "A null definition can not be registered nor used to look up a registered event metric definition.");
			}
			object @lock = eventMetricDefinition.Lock;
			lock (@lock)
			{
				if (defaultValue != null && (defaultValue.Definition != eventMetricDefinition || !eventMetricDefinition.ValueCollection.Contains(defaultValue)))
				{
					throw new global::System.Collections.Generic.KeyNotFoundException("The event metric value column definition specified is not associated with the specified event metric definition.");
				}
				eventMetricDefinition.DefaultValue = defaultValue;
				global::Gibraltar.Agent.Metrics.EventMetricDefinition.Register(ref eventMetricDefinition);
			}
			newDefinition = eventMetricDefinition;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000699C File Offset: 0x00004B9C
		internal global::Gibraltar.Agent.Metrics.EventMetricDefinition Register()
		{
			object @lock = this.Lock;
			global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition;
			lock (@lock)
			{
				object lock2 = global::Gibraltar.Agent.Log.MetricDefinitions.Lock;
				lock (lock2)
				{
					global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
					if (!global::Gibraltar.Agent.Log.MetricDefinitions.TryGetValue(this.MetricsSystem, this.CategoryName, this.CounterName, out metricDefinition))
					{
						this.m_WrappedDefinition.SetReadOnly();
						eventMetricDefinition = this;
						global::Gibraltar.Agent.Log.MetricDefinitions.Add(this);
					}
					else
					{
						eventMetricDefinition = (metricDefinition as global::Gibraltar.Agent.Metrics.EventMetricDefinition);
					}
				}
				if (eventMetricDefinition == null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "There is already a metric definition for the same metrics system ({0}), category name ({1}), and counter name ({2}), but it is not an event metric.", new object[]
					{
						this.MetricsSystem,
						this.CategoryName,
						this.CounterName
					}));
				}
				if (this != eventMetricDefinition)
				{
					global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection values = eventMetricDefinition.WrappedDefinition.Values;
					foreach (global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition in this.WrappedDefinition.Values)
					{
						global::Gibraltar.Monitor.EventMetricValueDefinition eventMetricValueDefinition2 = (global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition;
						global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition3;
						if (!values.TryGetValue(eventMetricValueDefinition2.Name, out eventMetricValueDefinition3))
						{
							throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "There is already an event metric definition for the same metrics system ({0}), category name ({1}), and counter name ({2}), but it is not compatible; it does not define value column \"{3}\".", new object[]
							{
								this.MetricsSystem,
								this.CategoryName,
								this.CounterName,
								eventMetricValueDefinition2.Name
							}));
						}
						if (eventMetricValueDefinition2.SerializedType != ((global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition3).SerializedType)
						{
							throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "There is already an event metric definition for the same metrics system ({0}), category name ({1}), and counter name ({2}), but it is not compatible; it defines value column \"{3}\" with type {4} rather than type {5}.", new object[]
							{
								this.MetricsSystem,
								this.CategoryName,
								this.CounterName,
								eventMetricValueDefinition2.Name,
								eventMetricValueDefinition3.Type.Name,
								eventMetricValueDefinition2.Type.Name
							}));
						}
					}
				}
			}
			return eventMetricDefinition;
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00006BD4 File Offset: 0x00004DD4
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00006BE4 File Offset: 0x00004DE4
		public bool IsBound
		{
			get
			{
				return this.m_WrappedDefinition.IsBound;
			}
			internal set
			{
				this.m_WrappedDefinition.IsBound = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00006BF4 File Offset: 0x00004DF4
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00006C04 File Offset: 0x00004E04
		public global::System.Type BoundType
		{
			get
			{
				return this.m_WrappedDefinition.BoundType;
			}
			internal set
			{
				this.m_WrappedDefinition.BoundType = value;
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00006C14 File Offset: 0x00004E14
		public int CompareTo(global::Gibraltar.Agent.Metrics.EventMetricDefinition other)
		{
			return this.WrappedDefinition.CompareTo(other.WrappedDefinition);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00006C28 File Offset: 0x00004E28
		public bool Equals(global::Gibraltar.Agent.Metrics.EventMetricDefinition other)
		{
			return this.WrappedDefinition.Equals(other.WrappedDefinition);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00006C3C File Offset: 0x00004E3C
		internal global::Gibraltar.Agent.Metrics.EventMetricCollection Metrics
		{
			get
			{
				return this.m_Metrics;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00006C44 File Offset: 0x00004E44
		internal global::Gibraltar.Agent.Metrics.EventMetricValueDefinitionCollection ValueCollection
		{
			get
			{
				return this.m_MetricValues;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00006C4C File Offset: 0x00004E4C
		public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition[] ValueDefinitions
		{
			get
			{
				return this.m_MetricValues.ToArray();
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00006C5C File Offset: 0x00004E5C
		public static bool IsNumericValueType(global::System.Type type)
		{
			return global::Gibraltar.Monitor.EventMetricDefinition.IsTrendableValueType(type);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00006C64 File Offset: 0x00004E64
		public static bool IsSupportedValueType(global::System.Type type)
		{
			return global::Gibraltar.Monitor.EventMetricDefinition.IsSupportedValueType(type);
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00006C6C File Offset: 0x00004E6C
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition DefaultValue
		{
			get
			{
				object @lock = this.Lock;
				global::Gibraltar.Agent.Metrics.EventMetricValueDefinition result;
				lock (@lock)
				{
					result = this.m_MetricValues.Externalize((global::Gibraltar.Monitor.EventMetricValueDefinition)this.m_WrappedDefinition.DefaultValue);
				}
				return result;
			}
			set
			{
				object @lock = this.Lock;
				lock (@lock)
				{
					this.m_WrappedDefinition.DefaultValue = ((value == null) ? null : value.WrappedValueDefinition);
				}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00006D14 File Offset: 0x00004F14
		internal void WriteSample(string instanceName, object userDataObject)
		{
			if (userDataObject == null)
			{
				throw new global::System.ArgumentNullException("userDataObject");
			}
			bool flag = true;
			if (!this.IsReadOnly)
			{
				global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition = this.Register();
				if (eventMetricDefinition == null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Unknown error registering event metric definition: metrics system ({0}), category name ({1}), counter name ({2}).", new object[]
					{
						this.MetricsSystem,
						this.CategoryName,
						this.CounterName
					}));
				}
				if (this != eventMetricDefinition)
				{
					flag = false;
					eventMetricDefinition.WriteSample(instanceName, userDataObject);
				}
			}
			if (flag)
			{
				if (!this.IsBound)
				{
					throw new global::System.ArgumentException("This event metric definition is not bound to sample automatically from a user data object.  CreateSample() and SetValue() must be used to specify the data values directly.");
				}
				global::System.Type type = userDataObject.GetType();
				if (!this.BoundType.IsAssignableFrom(type))
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The provided user data object type ({0}) is not assignable to this event metric's bound type ({1}) and can not be sampled automatically for this metric definition.", new object[]
					{
						type,
						this.BoundType
					}));
				}
				global::Gibraltar.Agent.Metrics.EventMetric.Register(this, instanceName).WriteSample(userDataObject);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00006E00 File Offset: 0x00005000
		public void WriteSample(object metricData, string fallbackInstanceName)
		{
			if (metricData == null)
			{
				throw new global::System.ArgumentNullException("metricData");
			}
			bool flag = true;
			if (!this.IsReadOnly)
			{
				global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition = this.Register();
				if (eventMetricDefinition == null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Unknown error registering event metric definition: metrics system ({0}), category name ({1}), counter name ({2}).", new object[]
					{
						this.MetricsSystem,
						this.CategoryName,
						this.CounterName
					}));
				}
				if (this != eventMetricDefinition)
				{
					flag = false;
					eventMetricDefinition.WriteSample(metricData, fallbackInstanceName);
				}
			}
			if (flag)
			{
				if (!this.IsBound)
				{
					throw new global::System.ArgumentException("This event metric definition is not bound to sample automatically from a user data object.  CreateSample() and SetValue() must be used to specify the data values directly.");
				}
				global::System.Type type = metricData.GetType();
				if (!this.BoundType.IsAssignableFrom(type))
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The provided user data object type ({0}) is not assignable to this event metric's bound type ({1}) and can not be sampled automatically for this metric definition.", new object[]
					{
						type,
						this.BoundType
					}));
				}
				string text = fallbackInstanceName;
				if (this.NameBound)
				{
					text = (this.InvokeInstanceNameBinding(metricData) ?? fallbackInstanceName);
				}
				if (string.IsNullOrEmpty(text))
				{
					text = null;
				}
				this.WriteSample(text, metricData);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00006F14 File Offset: 0x00005114
		public void WriteSample(object metricData)
		{
			this.WriteSample(metricData, null);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00006F20 File Offset: 0x00005120
		internal string InvokeInstanceNameBinding(object metricData)
		{
			global::System.Type type = metricData.GetType();
			if (!this.BoundType.IsAssignableFrom(type))
			{
				return null;
			}
			global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> binding = new global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes>(this.NameMemberName, this.NameMemberType);
			global::System.Reflection.BindingFlags bindingFlags = this.GetBindingFlags(binding);
			string text;
			if (bindingFlags != global::System.Reflection.BindingFlags.Default)
			{
				try
				{
					object obj = type.InvokeMember(this.NameMemberName, bindingFlags, null, metricData, null, global::System.Globalization.CultureInfo.InvariantCulture);
					if (obj == null || obj.GetType() == typeof(string))
					{
						text = (obj as string);
					}
					else
					{
						text = obj.ToString();
					}
					if (text == null)
					{
						text = string.Empty;
					}
					return text;
				}
				catch
				{
					return null;
				}
			}
			text = null;
			return text;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00006FE0 File Offset: 0x000051E0
		internal global::System.Reflection.BindingFlags GetBindingFlags(global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> binding)
		{
			if (binding == null || this.BoundType == null)
			{
				return global::System.Reflection.BindingFlags.Default;
			}
			global::System.Reflection.BindingFlags bindingFlags = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.ExactBinding;
			global::System.Reflection.MemberTypes value = binding.Value;
			if (value != global::System.Reflection.MemberTypes.Field)
			{
				if (value != global::System.Reflection.MemberTypes.Method)
				{
					if (value != global::System.Reflection.MemberTypes.Property)
					{
						global::System.Diagnostics.Trace.TraceWarning("Loupe data binding error:\r\nUnrecognized member type (0x{0:X}: {0:F}) for {2} member name \"{1}\".\r\nEvent metric definition:  metrics system ({3}), category name ({4}), counter name ({5}).\r\n", new object[]
						{
							binding.Value,
							binding.Name ?? "(null)",
							this.BoundType.Name,
							this.MetricsSystem,
							this.CategoryName,
							this.CounterName
						});
						bindingFlags = global::System.Reflection.BindingFlags.Default;
					}
					else
					{
						bindingFlags |= global::System.Reflection.BindingFlags.GetProperty;
					}
				}
				else
				{
					bindingFlags |= global::System.Reflection.BindingFlags.InvokeMethod;
				}
			}
			else
			{
				bindingFlags |= global::System.Reflection.BindingFlags.GetField;
			}
			return bindingFlags;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000070B4 File Offset: 0x000052B4
		public static void Write(object metricData, string fallbackInstanceName)
		{
			foreach (global::Gibraltar.Agent.Metrics.EventMetricDefinition eventMetricDefinition in global::Gibraltar.Agent.Metrics.EventMetricDefinition.RegisterAll(metricData))
			{
				try
				{
					eventMetricDefinition.WriteSample(metricData, fallbackInstanceName);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00007104 File Offset: 0x00005304
		public static void Write(object metricData)
		{
			global::Gibraltar.Agent.Metrics.EventMetricDefinition.Write(metricData, null);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00007110 File Offset: 0x00005310
		internal object Lock
		{
			get
			{
				return this.m_WrappedDefinition.Lock;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00007120 File Offset: 0x00005320
		internal global::Gibraltar.Monitor.EventMetricDefinition WrappedDefinition
		{
			get
			{
				return this.m_WrappedDefinition;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00007128 File Offset: 0x00005328
		global::Gibraltar.Monitor.MetricDefinition global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition.WrappedDefinition
		{
			get
			{
				return this.m_WrappedDefinition;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00007130 File Offset: 0x00005330
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00007140 File Offset: 0x00005340
		internal bool NameBound
		{
			get
			{
				return this.m_WrappedDefinition.NameBound;
			}
			set
			{
				this.m_WrappedDefinition.NameBound = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00007150 File Offset: 0x00005350
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00007160 File Offset: 0x00005360
		internal string NameMemberName
		{
			get
			{
				return this.m_WrappedDefinition.NameMemberName;
			}
			set
			{
				this.m_WrappedDefinition.NameMemberName = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00007170 File Offset: 0x00005370
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00007180 File Offset: 0x00005380
		internal global::System.Reflection.MemberTypes NameMemberType
		{
			get
			{
				return this.m_WrappedDefinition.NameMemberType;
			}
			set
			{
				this.m_WrappedDefinition.NameMemberType = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00007190 File Offset: 0x00005390
		public global::System.Guid Id
		{
			get
			{
				return this.m_WrappedDefinition.Id;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000071A0 File Offset: 0x000053A0
		public string Key
		{
			get
			{
				return this.m_WrappedDefinition.Name;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000071B0 File Offset: 0x000053B0
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000071C0 File Offset: 0x000053C0
		public string Caption
		{
			get
			{
				return this.m_WrappedDefinition.Caption;
			}
			set
			{
				this.m_WrappedDefinition.Caption = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000071D0 File Offset: 0x000053D0
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x000071E0 File Offset: 0x000053E0
		public string Description
		{
			get
			{
				return this.m_WrappedDefinition.Description;
			}
			set
			{
				this.m_WrappedDefinition.Description = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000071F0 File Offset: 0x000053F0
		public global::Gibraltar.Agent.Metrics.SamplingInterval Interval
		{
			get
			{
				return (global::Gibraltar.Agent.Metrics.SamplingInterval)this.m_WrappedDefinition.Interval;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00007200 File Offset: 0x00005400
		public string MetricsSystem
		{
			get
			{
				return this.m_WrappedDefinition.MetricTypeName;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x00007210 File Offset: 0x00005410
		public string CategoryName
		{
			get
			{
				return this.m_WrappedDefinition.CategoryName;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00007220 File Offset: 0x00005420
		public string CounterName
		{
			get
			{
				return this.m_WrappedDefinition.CounterName;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00007230 File Offset: 0x00005430
		global::Loupe.Extensibility.Data.SampleType global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition.SampleType
		{
			get
			{
				return this.m_WrappedDefinition.SampleType;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00007240 File Offset: 0x00005440
		public bool IsReadOnly
		{
			get
			{
				return this.m_WrappedDefinition.IsReadOnly;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00007250 File Offset: 0x00005450
		int global::System.IComparable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>.CompareTo(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition other)
		{
			return this.WrappedDefinition.CompareTo(other.WrappedDefinition);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00007264 File Offset: 0x00005464
		bool global::System.IEquatable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>.Equals(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition other)
		{
			return this.WrappedDefinition.Equals(other.WrappedDefinition);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007278 File Offset: 0x00005478
		public static bool ContainsKey(global::System.Guid id)
		{
			return global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_Definitions.ContainsKey(id);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007288 File Offset: 0x00005488
		public static bool ContainsKey(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				throw new global::System.ArgumentNullException("key");
			}
			return global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_Definitions.ContainsKey(key.Trim());
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000072B0 File Offset: 0x000054B0
		public static bool ContainsKey(string metricsSystem, string categoryName, string counterName)
		{
			return global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_Definitions.ContainsKey(metricsSystem, categoryName, counterName);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000072C0 File Offset: 0x000054C0
		public static bool TryGetValue(global::System.Guid id, out global::Gibraltar.Agent.Metrics.EventMetricDefinition value)
		{
			global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
			bool flag = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_Definitions.TryGetValue(id, out metricDefinition);
			value = (flag ? (metricDefinition as global::Gibraltar.Agent.Metrics.EventMetricDefinition) : null);
			if (flag && value == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The metric definition found by Id ({0}) is not an event metric definition.", new object[]
				{
					id
				}));
			}
			return flag;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00007328 File Offset: 0x00005528
		public static bool TryGetValue(string key, out global::Gibraltar.Agent.Metrics.EventMetricDefinition value)
		{
			if (string.IsNullOrEmpty(key))
			{
				throw new global::System.ArgumentNullException("key");
			}
			global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
			bool flag = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_Definitions.TryGetValue(key.Trim(), out metricDefinition);
			value = (flag ? (metricDefinition as global::Gibraltar.Agent.Metrics.EventMetricDefinition) : null);
			if (flag && value == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The metric definition found by Key \"{0}\" is not an event metric definition.", new object[]
				{
					key
				}));
			}
			return flag;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000073A4 File Offset: 0x000055A4
		public static bool TryGetValue(string metricsSystem, string categoryName, string counterName, out global::Gibraltar.Agent.Metrics.EventMetricDefinition value)
		{
			global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
			bool flag = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_Definitions.TryGetValue(metricsSystem, categoryName, counterName, out metricDefinition);
			value = (flag ? (metricDefinition as global::Gibraltar.Agent.Metrics.EventMetricDefinition) : null);
			if (flag && value == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The metric definition found by metrics system ({0}) category name ({1}) counter name ({2}) is not an event metric definition.", new object[]
				{
					metricsSystem,
					categoryName,
					counterName
				}));
			}
			return flag;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007410 File Offset: 0x00005610
		public static bool TryGetValue(global::System.Type metricDataObjectType, out global::Gibraltar.Agent.Metrics.EventMetricDefinition value)
		{
			if (metricDataObjectType == null)
			{
				value = null;
				throw new global::System.ArgumentNullException("metricDataObjectType");
			}
			object obj = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_DictionaryLock;
			bool flag;
			lock (obj)
			{
				flag = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_DefinitionMap.TryGetValue(metricDataObjectType, out value);
			}
			if (!flag || value == null)
			{
				global::Gibraltar.Agent.Metrics.EventMetricAttribute eventMetricAttribute = null;
				if (metricDataObjectType.IsDefined(typeof(global::Gibraltar.Agent.Metrics.EventMetricAttribute), false))
				{
					eventMetricAttribute = (global::System.Attribute.GetCustomAttribute(metricDataObjectType, typeof(global::Gibraltar.Agent.Metrics.EventMetricAttribute)) as global::Gibraltar.Agent.Metrics.EventMetricAttribute);
				}
				if (eventMetricAttribute != null)
				{
					string metricsSystem = eventMetricAttribute.MetricsSystem;
					string metricCategoryName = eventMetricAttribute.MetricCategoryName;
					string counterName = eventMetricAttribute.CounterName;
					global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
					flag = global::Gibraltar.Agent.Metrics.EventMetricDefinition.s_Definitions.TryGetValue(metricsSystem, metricCategoryName, counterName, out metricDefinition);
					value = (flag ? (metricDefinition as global::Gibraltar.Agent.Metrics.EventMetricDefinition) : null);
					if (flag && value == null)
					{
						throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The metric definition registered for metrics system ({0}) category name ({1}) counter name ({2}) specified in EventMetric attribute on {3} is not an event metric definition.", new object[]
						{
							metricsSystem,
							metricCategoryName,
							counterName,
							metricDataObjectType.Name
						}));
					}
				}
				else
				{
					flag = false;
					value = null;
				}
			}
			return flag;
		}

		// Token: 0x04000068 RID: 104
		private readonly global::Gibraltar.Monitor.EventMetricDefinition m_WrappedDefinition;

		// Token: 0x04000069 RID: 105
		private readonly global::Gibraltar.Agent.Metrics.EventMetricCollection m_Metrics;

		// Token: 0x0400006A RID: 106
		private readonly global::Gibraltar.Agent.Metrics.EventMetricValueDefinitionCollection m_MetricValues;

		// Token: 0x0400006B RID: 107
		private static readonly global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection s_Definitions = global::Gibraltar.Agent.Log.MetricDefinitions;

		// Token: 0x0400006C RID: 108
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type[]> s_InheritanceMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type[]>();

		// Token: 0x0400006D RID: 109
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::Gibraltar.Agent.Metrics.EventMetricDefinition> s_DefinitionMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Gibraltar.Agent.Metrics.EventMetricDefinition>();

		// Token: 0x0400006E RID: 110
		private static readonly object s_DictionaryLock = new object();
	}
}
