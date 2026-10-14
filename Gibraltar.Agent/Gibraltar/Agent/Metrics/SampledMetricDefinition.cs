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
	// Token: 0x0200002A RID: 42
	public sealed class SampledMetricDefinition : global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition, global::System.IComparable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.IEquatable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.IComparable<global::Gibraltar.Agent.Metrics.SampledMetricDefinition>, global::System.IEquatable<global::Gibraltar.Agent.Metrics.SampledMetricDefinition>
	{
		// Token: 0x0600025E RID: 606 RVA: 0x00008564 File Offset: 0x00006764
		private static global::System.Collections.Generic.Dictionary<global::System.Type, bool> InitTypeSupportedDictionary()
		{
			global::System.Collections.Generic.Dictionary<global::System.Type, bool> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, bool>(global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_SupportedDataTypes.Length);
			foreach (global::System.Type key in global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_SupportedDataTypes)
			{
				dictionary[key] = true;
			}
			return dictionary;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000085AC File Offset: 0x000067AC
		internal SampledMetricDefinition(string metricsSystem, string categoryName, string counterName, global::Gibraltar.Agent.Metrics.SamplingType samplingType, string unitCaption, string metricCaption, string description) : this(new global::Gibraltar.Monitor.CustomSampledMetricDefinition(metricsSystem, categoryName, counterName, (global::Gibraltar.Monitor.MetricSampleType)samplingType, unitCaption, description))
		{
			this.m_WrappedDefinition.Caption = metricCaption;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000085E0 File Offset: 0x000067E0
		internal SampledMetricDefinition(global::Gibraltar.Monitor.CustomSampledMetricDefinition metricDefinition)
		{
			this.m_WrappedDefinition = metricDefinition;
			this.m_Metrics = new global::Gibraltar.Agent.Metrics.Internal.SampledMetricCollection(this);
			global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_Definitions.Internalize(this);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00008608 File Offset: 0x00006808
		public static global::Gibraltar.Agent.Metrics.SampledMetricDefinition Register(string metricsSystem, string categoryName, string counterName, global::Gibraltar.Agent.Metrics.SamplingType samplingType, string unitCaption, string metricCaption, string description)
		{
			object @lock = global::Gibraltar.Agent.Log.MetricDefinitions.Lock;
			bool flag;
			global::Gibraltar.Agent.Metrics.SampledMetricDefinition sampledMetricDefinition;
			lock (@lock)
			{
				global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
				if (!global::Gibraltar.Agent.Log.MetricDefinitions.TryGetValue(metricsSystem, categoryName, counterName, out metricDefinition))
				{
					flag = true;
					sampledMetricDefinition = new global::Gibraltar.Agent.Metrics.SampledMetricDefinition(metricsSystem, categoryName, counterName, samplingType, unitCaption, metricCaption, description);
				}
				else
				{
					flag = false;
					sampledMetricDefinition = (metricDefinition as global::Gibraltar.Agent.Metrics.SampledMetricDefinition);
				}
			}
			if (sampledMetricDefinition == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "There is already a metric definition for the same metrics system ({0}), category name ({1}), and counter name ({2}), but it is not a sampled metric.", new object[]
				{
					metricsSystem,
					categoryName,
					counterName
				}));
			}
			if (!flag && sampledMetricDefinition.SamplingType != samplingType)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "There is already a sampled metric definition for the same metrics system ({0}), category name ({1}), and counter name ({2}), but it is not compatible; it defines sampling type as {3} rather than {4}.", new object[]
				{
					metricsSystem,
					categoryName,
					counterName,
					sampledMetricDefinition.SamplingType,
					samplingType
				}));
			}
			return sampledMetricDefinition;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000086F4 File Offset: 0x000068F4
		internal static global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] RegisterAll(object userInstanceObject)
		{
			global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetricDefinition> list = new global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetricDefinition>();
			if (userInstanceObject != null)
			{
				global::System.Type type = (userInstanceObject as global::System.Type) ?? userInstanceObject.GetType();
				global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type[]> obj = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_InheritanceMap;
				global::System.Type[] array;
				bool flag;
				lock (obj)
				{
					flag = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_InheritanceMap.TryGetValue(type, out array);
				}
				if (flag)
				{
					foreach (global::System.Type userObjectType in array)
					{
						global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] array3;
						try
						{
							array3 = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RegisterGroup(userObjectType, null);
						}
						catch
						{
							array3 = null;
						}
						if (array3 != null)
						{
							list.AddRange(array3);
						}
					}
				}
				else
				{
					global::System.Collections.Generic.List<global::System.Type> list2 = new global::System.Collections.Generic.List<global::System.Type>();
					if (type.IsDefined(typeof(global::Gibraltar.Agent.Metrics.SampledMetricAttribute), false))
					{
						global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] array3;
						try
						{
							list2.Add(type);
							array3 = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RegisterGroup(type, null);
						}
						catch
						{
							array3 = null;
						}
						if (array3 != null)
						{
							list.AddRange(array3);
						}
					}
					foreach (global::System.Type type2 in type.GetInterfaces())
					{
						if (type2.IsDefined(typeof(global::Gibraltar.Agent.Metrics.SampledMetricAttribute), false))
						{
							global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] array3;
							try
							{
								list2.Add(type2);
								array3 = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RegisterGroup(type2, null);
							}
							catch
							{
								array3 = null;
							}
							if (array3 != null)
							{
								list.AddRange(array3);
							}
						}
					}
					global::System.Type baseType = type.BaseType;
					while (baseType != null && baseType != typeof(object) && !baseType.IsInterface)
					{
						if (baseType.IsDefined(typeof(global::Gibraltar.Agent.Metrics.SampledMetricAttribute), false))
						{
							global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] array3;
							try
							{
								list2.Add(baseType);
								array3 = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RegisterGroup(baseType, null);
							}
							catch
							{
								array3 = null;
							}
							if (array3 != null)
							{
								list.AddRange(array3);
							}
						}
						baseType = baseType.BaseType;
					}
					obj = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_InheritanceMap;
					lock (obj)
					{
						global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_InheritanceMap[type] = list2.ToArray();
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00008954 File Offset: 0x00006B54
		internal static global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] RegisterType(global::System.Type userObjectType)
		{
			if (userObjectType == null)
			{
				throw new global::System.ArgumentNullException("userObjectType", "A valid Type must be provided.");
			}
			return global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RegisterGroup(userObjectType, string.Empty);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00008978 File Offset: 0x00006B78
		internal static global::Gibraltar.Agent.Metrics.SampledMetricDefinition Register(global::System.Type userObjectType, string counterName)
		{
			if (userObjectType == null)
			{
				throw new global::System.ArgumentNullException("userObjectType", "A valid Type must be provided.");
			}
			if (string.IsNullOrEmpty(counterName))
			{
				throw new global::System.ArgumentNullException("counterName", "A valid counter name must be specified to select a single sampled metric definition, or use the overload without a counterName parameter.");
			}
			global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] array = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RegisterGroup(userObjectType, counterName);
			if (array.Length == 0)
			{
				return null;
			}
			return array[0];
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000089D4 File Offset: 0x00006BD4
		internal static global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] RegisterGroup(global::System.Type userObjectType, string counterName)
		{
			if (userObjectType == null)
			{
				return new global::Gibraltar.Agent.Metrics.SampledMetricDefinition[0];
			}
			object obj = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_DictionaryLock;
			global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetricDefinition> list;
			lock (obj)
			{
				if (!global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_DefinitionsMap.TryGetValue(userObjectType, out list) || list == null)
				{
					list = new global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetricDefinition>();
					if (!userObjectType.IsDefined(typeof(global::Gibraltar.Agent.Metrics.SampledMetricAttribute), false))
					{
						if (counterName == null)
						{
							return list.ToArray();
						}
						throw new global::System.ArgumentException("The specified Type does not have a SampledMetric attribute, so it can't be used to define sampled metrics.", "userObjectType");
					}
					else
					{
						global::Gibraltar.Agent.Metrics.SampledMetricAttribute sampledMetricAttribute = global::System.Attribute.GetCustomAttribute(userObjectType, typeof(global::Gibraltar.Agent.Metrics.SampledMetricAttribute)) as global::Gibraltar.Agent.Metrics.SampledMetricAttribute;
						if (sampledMetricAttribute == null)
						{
							if (counterName == null)
							{
								return list.ToArray();
							}
							throw new global::System.ArgumentException("The specified Type does not have a usable SampledMetric attribute, so it can't be used to define sampled metrics.", "userObjectType");
						}
						else
						{
							string metricsSystem = sampledMetricAttribute.MetricsSystem;
							if (string.IsNullOrEmpty(metricsSystem))
							{
								if (counterName == null)
								{
									return list.ToArray();
								}
								throw new global::System.ArgumentException("The specified Type's SampledMetric attribute has an empty metric namespace which is not allowed, so no metrics can be defined under it.");
							}
							else
							{
								string metricCategoryName = sampledMetricAttribute.MetricCategoryName;
								if (string.IsNullOrEmpty(metricCategoryName))
								{
									if (counterName == null)
									{
										return list.ToArray();
									}
									throw new global::System.ArgumentException("The specified Type's SampledMetric attribute has an empty metric category name which is not allowed, so no metrics can be defined under it.");
								}
								else
								{
									global::System.Reflection.MemberInfo[] array = userObjectType.FindMembers(global::System.Reflection.MemberTypes.Field | global::System.Reflection.MemberTypes.Method | global::System.Reflection.MemberTypes.Property, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, global::System.Type.FilterName, "*");
									global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> nameValuePair = null;
									global::System.Collections.Generic.Dictionary<string, global::System.Reflection.MemberInfo> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Reflection.MemberInfo>();
									foreach (global::System.Reflection.MemberInfo memberInfo in array)
									{
										if (memberInfo.IsDefined(typeof(global::Gibraltar.Agent.Metrics.SampledMetricInstanceNameAttribute), false))
										{
											if (nameValuePair != null)
											{
												global::System.Diagnostics.Trace.TraceWarning("There is more than one member on the type {0} with the SampledMetricName attribute.  The member {1} will be used because it was found first.", new object[]
												{
													userObjectType.FullName,
													nameValuePair.Name
												});
											}
											else
											{
												nameValuePair = new global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes>(memberInfo.Name, memberInfo.MemberType);
											}
										}
										if (memberInfo.IsDefined(typeof(global::Gibraltar.Agent.Metrics.SampledMetricDivisorAttribute), false))
										{
											object[] customAttributes = memberInfo.GetCustomAttributes(typeof(global::Gibraltar.Agent.Metrics.SampledMetricDivisorAttribute), false);
											for (int j = 0; j < customAttributes.Length; j++)
											{
												global::Gibraltar.Agent.Metrics.SampledMetricDivisorAttribute sampledMetricDivisorAttribute = customAttributes[j] as global::Gibraltar.Agent.Metrics.SampledMetricDivisorAttribute;
												if (sampledMetricDivisorAttribute != null)
												{
													string counterName2 = sampledMetricDivisorAttribute.CounterName;
													global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
													if (string.IsNullOrEmpty(counterName2))
													{
														global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage warning:\r\nSampledMetricDivisor attribute on {0} member {1} has an invalid counter name ({2}) and will have no effect.\r\n", new object[]
														{
															userObjectType,
															memberInfo.Name,
															(counterName2 == null) ? "null" : "\"\""
														});
													}
													else if (global::Gibraltar.Agent.Log.MetricDefinitions.TryGetValue(metricsSystem, metricCategoryName, counterName2, out metricDefinition))
													{
														global::Gibraltar.Agent.Metrics.SampledMetricDefinition sampledMetricDefinition = metricDefinition as global::Gibraltar.Agent.Metrics.SampledMetricDefinition;
														if (sampledMetricDefinition == null)
														{
															global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage warning:\r\nUnable to add {0} member {1} as divisor for sampled metric counter {2}:\r\nA metric definition already exists with the same namespace ({3}), category ({4}),\r\nand counter name ({2}), but it is not a sampled metric!\r\nMake sure each metric definition uses a unique name.\r\n", new object[]
															{
																userObjectType,
																memberInfo.Name,
																counterName2,
																metricsSystem,
																metricCategoryName
															});
														}
														else if (!sampledMetricDefinition.IsBound || sampledMetricDefinition.BoundType != userObjectType)
														{
															global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage warning:\r\nUnable to add {0} member {1} as divisor for sampled metric counter {2}:\r\nA metric definition already exists with the same namespace ({3}), category ({4}),\r\nand counter name ({2}), but is was not defined from this type ({0}).\r\nMake sure each metric definition uses a unique name.\r\n", new object[]
															{
																userObjectType,
																memberInfo.Name,
																counterName2,
																metricsSystem,
																metricCategoryName
															});
														}
														else if (!global::Gibraltar.Agent.Metrics.SampledMetricDefinition.BindingMatchesMember(sampledMetricDefinition.DivisorBinding, memberInfo))
														{
															global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nUnable to add {0} member {1} as divisor for sampled metric counter {2}:\r\nA metric definition already exists with the same namespace ({3}), category ({4}),\r\nand counter name ({2}), but its divisor was not bound to this member ({1}).\r\nMake sure each metric definition uses a unique name.\r\n", new object[]
															{
																userObjectType,
																memberInfo.Name,
																counterName2,
																metricsSystem,
																metricCategoryName
															});
														}
														dictionary[counterName2] = memberInfo;
													}
													else if (dictionary.ContainsKey(counterName2))
													{
														global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nSampledMetricDivisor attribute on {0} member {1} specifies a counter name ({2})\r\nwhich has already been specified on member {3}.  Only the first occurrence will be used.\r\n", new object[]
														{
															userObjectType,
															memberInfo.Name,
															counterName2,
															dictionary[counterName2].Name
														});
													}
													else
													{
														dictionary[counterName2] = memberInfo;
													}
												}
											}
										}
									}
									foreach (global::System.Reflection.MemberInfo memberInfo2 in array)
									{
										if (memberInfo2.IsDefined(typeof(global::Gibraltar.Agent.Metrics.SampledMetricValueAttribute), false))
										{
											global::System.Type typeOfMember = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.GetTypeOfMember(memberInfo2);
											object[] customAttributes = memberInfo2.GetCustomAttributes(typeof(global::Gibraltar.Agent.Metrics.SampledMetricValueAttribute), false);
											for (int j = 0; j < customAttributes.Length; j++)
											{
												global::Gibraltar.Agent.Metrics.SampledMetricValueAttribute sampledMetricValueAttribute = customAttributes[j] as global::Gibraltar.Agent.Metrics.SampledMetricValueAttribute;
												if (sampledMetricValueAttribute != null)
												{
													string counterName3 = sampledMetricValueAttribute.CounterName;
													if (string.IsNullOrEmpty(counterName3))
													{
														sampledMetricValueAttribute.SetCounterName(memberInfo2.Name);
														counterName3 = sampledMetricValueAttribute.CounterName;
													}
													global::Gibraltar.Agent.Metrics.SamplingType samplingType = sampledMetricValueAttribute.SamplingType;
													object @lock = global::Gibraltar.Agent.Log.MetricDefinitions.Lock;
													lock (@lock)
													{
														global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition2;
														if (global::Gibraltar.Agent.Log.MetricDefinitions.TryGetValue(metricsSystem, metricCategoryName, counterName3, out metricDefinition2))
														{
															global::Gibraltar.Agent.Metrics.SampledMetricDefinition sampledMetricDefinition2 = metricDefinition2 as global::Gibraltar.Agent.Metrics.SampledMetricDefinition;
															if (sampledMetricDefinition2 == null)
															{
																global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nUnable to add {0} member {1} as sampled metric counter {2}:\r\nA metric definition already exists with the same namespace ({3}), category ({4}),\r\nand counter name ({2}), but is not a sampled metric.\r\nMake sure each metric definition uses a unique name.\r\n", new object[]
																{
																	userObjectType,
																	memberInfo2.Name,
																	counterName3,
																	metricsSystem,
																	metricCategoryName
																});
															}
															else if (!sampledMetricDefinition2.IsBound || sampledMetricDefinition2.BoundType != userObjectType)
															{
																global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nUnable to add {0} member {1} as sampled metric counter {2}:\r\nA metric definition already exists with the same namespace ({3}), category ({4}),\r\nand counter name ({2}), but is was not defined from this type ({0}).\r\nMake sure each metric definition uses a unique name.\r\n", new object[]
																{
																	userObjectType,
																	memberInfo2.Name,
																	counterName3,
																	metricsSystem,
																	metricCategoryName
																});
															}
															else if (!global::Gibraltar.Agent.Metrics.SampledMetricDefinition.BindingMatchesMember(sampledMetricDefinition2.DataBinding, memberInfo2))
															{
																global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nUnable to add {0} member {1} as sampled metric counter {2}:\r\nA metric definition already exists with the same namespace ({3}), category ({4}),\r\nand counter name ({2}), but is was not bound to this member ({1}).\r\nMake sure each metric definition uses a unique name.\r\n", new object[]
																{
																	userObjectType,
																	memberInfo2.Name,
																	counterName3,
																	metricsSystem,
																	metricCategoryName
																});
															}
															else
															{
																list.Add(sampledMetricDefinition2);
															}
														}
														else if (typeOfMember == null)
														{
															global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nUnable to add {0} member {1} as sampled metric counter {2}:\r\nThe property is has no get accessor and can not be read.\r\n", new object[]
															{
																userObjectType,
																memberInfo2.Name,
																counterName3
															});
														}
														else if (typeOfMember == typeof(void))
														{
															global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nUnable to add {0} member {1} as sampled metric counter {2}:\r\nThe method's return value is void.\r\n", new object[]
															{
																userObjectType,
																memberInfo2.Name,
																counterName3
															});
														}
														else if (!global::Gibraltar.Agent.Metrics.SampledMetricDefinition.IsValidDataType(typeOfMember))
														{
															global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nUnable to add {0} member {1} as sampled metric counter {2}:\r\nThe member's Type ({3}) is not supported for sampled metrics.\r\n", new object[]
															{
																userObjectType,
																memberInfo2.Name,
																counterName3,
																typeOfMember.Name
															});
														}
														else
														{
															global::System.Reflection.MemberInfo memberInfo3;
															if (dictionary.TryGetValue(counterName3, out memberInfo3))
															{
																if (!global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RequiresDivisor(samplingType))
																{
																	global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage warning:\r\nSampledMetricDivisor attribute on {0} member {4} specifies counter name ({2}),\r\nbut SampledMetricValue attribute on member {1} designates sampling type as {3} which does not use a divisor.\r\n", new object[]
																	{
																		userObjectType,
																		memberInfo2.Name,
																		counterName3,
																		samplingType,
																		memberInfo3.Name
																	});
																	memberInfo3 = null;
																}
															}
															else
															{
																memberInfo3 = null;
																if (global::Gibraltar.Agent.Metrics.SampledMetricDefinition.RequiresDivisor(samplingType))
																{
																	global::System.Diagnostics.Trace.TraceWarning("Sampled metric attribute usage error:\r\nSampledMetricValue attribute on {0} member {1} designates sampling type as {3} which requires a divisor,\r\nbut no corresponding SampledMetricDivisor attribute was found for its counter name ({2}).\r\n", new object[]
																	{
																		userObjectType,
																		memberInfo2.Name,
																		counterName3,
																		samplingType
																	});
																}
															}
															global::Gibraltar.Agent.Metrics.SampledMetricDefinition sampledMetricDefinition3 = new global::Gibraltar.Agent.Metrics.SampledMetricDefinition(metricsSystem, metricCategoryName, counterName3, samplingType, sampledMetricValueAttribute.UnitCaption, sampledMetricValueAttribute.Caption, sampledMetricValueAttribute.Description)
															{
																BoundType = userObjectType,
																IsBound = true
															};
															sampledMetricDefinition3.SetDataBinding(memberInfo2);
															if (memberInfo3 != null)
															{
																sampledMetricDefinition3.SetDivisorBinding(memberInfo3);
															}
															if (nameValuePair != null)
															{
																sampledMetricDefinition3.NameMemberType = nameValuePair.Value;
																sampledMetricDefinition3.NameMemberName = nameValuePair.Name;
																sampledMetricDefinition3.NameBound = true;
															}
															list.Add(sampledMetricDefinition3);
														}
													}
												}
											}
										}
									}
									global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_DefinitionsMap[userObjectType] = list;
								}
							}
						}
					}
				}
			}
			if (!string.IsNullOrEmpty(counterName))
			{
				global::Gibraltar.Agent.Metrics.SampledMetricDefinition[] array3 = list.ToArray();
				list = new global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetricDefinition>();
				foreach (global::Gibraltar.Agent.Metrics.SampledMetricDefinition sampledMetricDefinition4 in array3)
				{
					if (sampledMetricDefinition4.CounterName == counterName)
					{
						list.Add(sampledMetricDefinition4);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000091B8 File Offset: 0x000073B8
		public static bool IsValidDataType(global::System.Type userDataType)
		{
			return global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_DataTypeSupported.ContainsKey(userDataType);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000091C8 File Offset: 0x000073C8
		public static bool RequiresDivisor(global::Gibraltar.Agent.Metrics.SamplingType samplingType)
		{
			switch (samplingType)
			{
			case global::Gibraltar.Agent.Metrics.SamplingType.RawFraction:
			case global::Gibraltar.Agent.Metrics.SamplingType.IncrementalFraction:
			case global::Gibraltar.Agent.Metrics.SamplingType.TotalFraction:
				return true;
			}
			return false;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00009204 File Offset: 0x00007404
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

		// Token: 0x06000269 RID: 617 RVA: 0x00009284 File Offset: 0x00007484
		private static bool BindingMatchesMember(global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> binding, global::System.Reflection.MemberInfo member)
		{
			return binding != null && member != null && binding.Value == member.MemberType && binding.Name == member.Name;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000092B8 File Offset: 0x000074B8
		public global::Gibraltar.Agent.Metrics.SamplingType SamplingType
		{
			get
			{
				return (global::Gibraltar.Agent.Metrics.SamplingType)this.m_WrappedDefinition.MetricSampleType;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000092C8 File Offset: 0x000074C8
		public bool RequiresMultipleSamples
		{
			get
			{
				return this.m_WrappedDefinition.RequiresMultipleSamples;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000092D8 File Offset: 0x000074D8
		// (set) Token: 0x0600026D RID: 621 RVA: 0x000092E8 File Offset: 0x000074E8
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000092F8 File Offset: 0x000074F8
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00009308 File Offset: 0x00007508
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

		// Token: 0x06000270 RID: 624 RVA: 0x00009318 File Offset: 0x00007518
		public int CompareTo(global::Gibraltar.Agent.Metrics.SampledMetricDefinition other)
		{
			return this.WrappedDefinition.CompareTo(other.WrappedDefinition);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000932C File Offset: 0x0000752C
		public bool Equals(global::Gibraltar.Agent.Metrics.SampledMetricDefinition other)
		{
			return this.WrappedDefinition.Equals(other.WrappedDefinition);
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00009340 File Offset: 0x00007540
		internal global::Gibraltar.Agent.Metrics.Internal.SampledMetricCollection Metrics
		{
			get
			{
				return this.m_Metrics;
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00009348 File Offset: 0x00007548
		public void WriteSample(string instanceName, double rawValue)
		{
			this.m_WrappedDefinition.WriteSample(instanceName, rawValue);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00009358 File Offset: 0x00007558
		public void WriteSample(string instanceName, double rawValue, global::System.DateTimeOffset rawTimestamp)
		{
			this.m_WrappedDefinition.WriteSample(instanceName, rawValue, rawTimestamp);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00009368 File Offset: 0x00007568
		public void WriteSample(string instanceName, double rawValue, double baseValue)
		{
			this.m_WrappedDefinition.WriteSample(instanceName, rawValue, baseValue);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00009378 File Offset: 0x00007578
		public void WriteSample(string instanceName, double rawValue, double baseValue, global::System.DateTimeOffset rawTimestamp)
		{
			this.m_WrappedDefinition.WriteSample(instanceName, rawValue, baseValue, rawTimestamp);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000938C File Offset: 0x0000758C
		internal void WriteSample(string instanceName, object metricData)
		{
			if (metricData == null)
			{
				throw new global::System.ArgumentNullException("metricData");
			}
			if (!this.IsBound)
			{
				throw new global::System.ArgumentException("This sampled metric definition is not bound to sample automatically from a user data object.  A different overload must be used to specify the data value(s) directly.");
			}
			global::System.Type type = metricData.GetType();
			if (!this.BoundType.IsAssignableFrom(type))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The provided user data object type ({0}) is not assignable to this sampled metric's bound type ({1}) and can not be sampled automatically for this metric definition.", new object[]
				{
					type,
					this.BoundType
				}));
			}
			global::Gibraltar.Agent.Metrics.SampledMetric.Register(this, instanceName).WriteSample(metricData);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00009414 File Offset: 0x00007614
		public void WriteSample(object metricData, string fallbackInstanceName)
		{
			if (metricData == null)
			{
				throw new global::System.ArgumentNullException("metricData");
			}
			if (!this.IsBound)
			{
				throw new global::System.ArgumentException("This sampled metric definition is not bound to sample automatically from a user data object.  A different overload must be used to specify the data value(s) directly.");
			}
			global::System.Type type = metricData.GetType();
			if (!this.BoundType.IsAssignableFrom(type))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The provided user data object type ({0}) is not assignable to this sampled metric's bound type ({1}) and can not be sampled automatically for this metric definition.", new object[]
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

		// Token: 0x06000279 RID: 633 RVA: 0x000094C0 File Offset: 0x000076C0
		public void WriteSample(object metricData)
		{
			this.WriteSample(metricData, null);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000094CC File Offset: 0x000076CC
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

		// Token: 0x0600027B RID: 635 RVA: 0x0000958C File Offset: 0x0000778C
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
						global::System.Diagnostics.Trace.TraceWarning("Loupe data binding error:\r\nUnrecognized member type (0x{0:X}: {0:F}) for {2} member name \"{1}\".\r\nUsing default metric instance for sampling: metric namespace ({3}), category ({4}), counter name ({5}).\r\n", new object[]
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

		// Token: 0x0600027C RID: 636 RVA: 0x00009660 File Offset: 0x00007860
		public static void Write(object metricData, string fallbackInstanceName)
		{
			global::Gibraltar.Agent.Metrics.SampledMetric.Write(metricData, fallbackInstanceName);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000966C File Offset: 0x0000786C
		public static void Write(object metricData)
		{
			global::Gibraltar.Agent.Metrics.SampledMetric.Write(metricData, string.Empty);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000967C File Offset: 0x0000787C
		internal static bool SampledMetricTypeRequiresMultipleSamples(global::Gibraltar.Agent.Metrics.SamplingType samplingType)
		{
			return samplingType > global::Gibraltar.Agent.Metrics.SamplingType.RawFraction;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600027F RID: 639 RVA: 0x000096A0 File Offset: 0x000078A0
		// (set) Token: 0x06000280 RID: 640 RVA: 0x000096B0 File Offset: 0x000078B0
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000281 RID: 641 RVA: 0x000096C0 File Offset: 0x000078C0
		// (set) Token: 0x06000282 RID: 642 RVA: 0x000096D0 File Offset: 0x000078D0
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000283 RID: 643 RVA: 0x000096E0 File Offset: 0x000078E0
		// (set) Token: 0x06000284 RID: 644 RVA: 0x000096F0 File Offset: 0x000078F0
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00009700 File Offset: 0x00007900
		internal object Lock
		{
			get
			{
				return this.m_WrappedDefinition.Lock;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00009710 File Offset: 0x00007910
		internal global::Gibraltar.Monitor.CustomSampledMetricDefinition WrappedDefinition
		{
			get
			{
				return this.m_WrappedDefinition;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00009718 File Offset: 0x00007918
		global::Gibraltar.Monitor.MetricDefinition global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition.WrappedDefinition
		{
			get
			{
				return this.m_WrappedDefinition;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00009720 File Offset: 0x00007920
		private void SetDataBinding(global::System.Reflection.MemberInfo member)
		{
			this.DataBinding = new global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes>(member.Name, member.MemberType);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000973C File Offset: 0x0000793C
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00009744 File Offset: 0x00007944
		internal global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> DataBinding { get; private set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00009750 File Offset: 0x00007950
		internal bool DataBound
		{
			get
			{
				return this.DataBinding != null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000975C File Offset: 0x0000795C
		internal global::System.Reflection.MemberTypes DataMemberType
		{
			get
			{
				if (!this.DataBound)
				{
					return (global::System.Reflection.MemberTypes)0;
				}
				return this.DataBinding.Value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00009778 File Offset: 0x00007978
		internal string DataMemberName
		{
			get
			{
				if (!this.DataBound)
				{
					return null;
				}
				return this.DataBinding.Name;
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00009794 File Offset: 0x00007994
		private void SetDivisorBinding(global::System.Reflection.MemberInfo member)
		{
			this.DivisorBinding = new global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes>(member.Name, member.MemberType);
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600028F RID: 655 RVA: 0x000097B0 File Offset: 0x000079B0
		// (set) Token: 0x06000290 RID: 656 RVA: 0x000097B8 File Offset: 0x000079B8
		internal global::Gibraltar.NameValuePair<global::System.Reflection.MemberTypes> DivisorBinding { get; private set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000097C4 File Offset: 0x000079C4
		internal bool DivisorBound
		{
			get
			{
				return this.DivisorBinding != null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000097D0 File Offset: 0x000079D0
		internal global::System.Reflection.MemberTypes DivisorMemberType
		{
			get
			{
				if (!this.DivisorBound)
				{
					return (global::System.Reflection.MemberTypes)0;
				}
				return this.DivisorBinding.Value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000097EC File Offset: 0x000079EC
		internal string DivisorMemberName
		{
			get
			{
				if (!this.DivisorBound)
				{
					return null;
				}
				return this.DivisorBinding.Name;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00009808 File Offset: 0x00007A08
		public global::System.Guid Id
		{
			get
			{
				return this.m_WrappedDefinition.Id;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00009818 File Offset: 0x00007A18
		public string Key
		{
			get
			{
				return this.m_WrappedDefinition.Name;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00009828 File Offset: 0x00007A28
		public string Caption
		{
			get
			{
				return this.m_WrappedDefinition.Caption;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00009838 File Offset: 0x00007A38
		public string Description
		{
			get
			{
				return this.m_WrappedDefinition.Description;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00009848 File Offset: 0x00007A48
		public global::Gibraltar.Agent.Metrics.SamplingInterval Interval
		{
			get
			{
				return (global::Gibraltar.Agent.Metrics.SamplingInterval)this.m_WrappedDefinition.Interval;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00009858 File Offset: 0x00007A58
		public string UnitCaption
		{
			get
			{
				return this.m_WrappedDefinition.UnitCaption;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00009868 File Offset: 0x00007A68
		public string MetricsSystem
		{
			get
			{
				return this.m_WrappedDefinition.MetricTypeName;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00009878 File Offset: 0x00007A78
		public string CategoryName
		{
			get
			{
				return this.m_WrappedDefinition.CategoryName;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00009888 File Offset: 0x00007A88
		public string CounterName
		{
			get
			{
				return this.m_WrappedDefinition.CounterName;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00009898 File Offset: 0x00007A98
		global::Loupe.Extensibility.Data.SampleType global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition.SampleType
		{
			get
			{
				return this.m_WrappedDefinition.SampleType;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600029E RID: 670 RVA: 0x000098A8 File Offset: 0x00007AA8
		public bool IsReadOnly
		{
			get
			{
				return this.m_WrappedDefinition.IsReadOnly;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000098B8 File Offset: 0x00007AB8
		int global::System.IComparable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>.CompareTo(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition other)
		{
			return this.WrappedDefinition.CompareTo(other.WrappedDefinition);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000098CC File Offset: 0x00007ACC
		bool global::System.IEquatable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>.Equals(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition other)
		{
			return this.WrappedDefinition.Equals(other.WrappedDefinition);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000098E0 File Offset: 0x00007AE0
		public static bool ContainsKey(global::System.Guid id)
		{
			return global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_Definitions.ContainsKey(id);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000098F0 File Offset: 0x00007AF0
		public static bool ContainsKey(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				throw new global::System.ArgumentNullException("key");
			}
			return global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_Definitions.ContainsKey(key.Trim());
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00009918 File Offset: 0x00007B18
		public static bool ContainsKey(string metricsSystem, string categoryName, string counterName)
		{
			return global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_Definitions.ContainsKey(metricsSystem, categoryName, counterName);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00009928 File Offset: 0x00007B28
		public static bool TryGetValue(global::System.Guid id, out global::Gibraltar.Agent.Metrics.SampledMetricDefinition value)
		{
			global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
			bool flag = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_Definitions.TryGetValue(id, out metricDefinition);
			value = (flag ? (metricDefinition as global::Gibraltar.Agent.Metrics.SampledMetricDefinition) : null);
			if (flag && value == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The metric definition found by Id ({0}) is not a sampled metric definition.", new object[]
				{
					id
				}));
			}
			return flag;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00009990 File Offset: 0x00007B90
		public static bool TryGetValue(string key, out global::Gibraltar.Agent.Metrics.SampledMetricDefinition value)
		{
			if (string.IsNullOrEmpty(key))
			{
				throw new global::System.ArgumentNullException("key");
			}
			global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
			bool flag = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_Definitions.TryGetValue(key.Trim(), out metricDefinition);
			value = (flag ? (metricDefinition as global::Gibraltar.Agent.Metrics.SampledMetricDefinition) : null);
			if (flag && value == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The metric definition found by Key \"{0}\" is not a sampled metric definition.", new object[]
				{
					key
				}));
			}
			return flag;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00009A0C File Offset: 0x00007C0C
		public static bool TryGetValue(string metricsSystem, string categoryName, string counterName, out global::Gibraltar.Agent.Metrics.SampledMetricDefinition value)
		{
			global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
			bool flag = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_Definitions.TryGetValue(metricsSystem, categoryName, counterName, out metricDefinition);
			value = (flag ? (metricDefinition as global::Gibraltar.Agent.Metrics.SampledMetricDefinition) : null);
			if (flag && value == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The metric definition found by metrics system ({0}) category name ({1}) counter name ({2}) is not a sampled metric definition.", new object[]
				{
					metricsSystem,
					categoryName,
					counterName
				}));
			}
			return flag;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00009A78 File Offset: 0x00007C78
		public static bool TryGetValue(global::System.Type userObjectType, string counterName, out global::Gibraltar.Agent.Metrics.SampledMetricDefinition value)
		{
			value = null;
			if (userObjectType == null)
			{
				throw new global::System.ArgumentNullException("userObjectType");
			}
			if (counterName == null)
			{
				throw new global::System.ArgumentNullException("counterName");
			}
			counterName = counterName.Trim();
			if (string.IsNullOrEmpty(counterName))
			{
				throw new global::System.ArgumentNullException("The specified counter name is empty which is not allowed, so no metrics can be found for it.");
			}
			bool flag = false;
			object obj = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_DictionaryLock;
			lock (obj)
			{
				global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetricDefinition> list;
				if (global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_DefinitionsMap.TryGetValue(userObjectType, out list) && list != null && list.Count > 0)
				{
					foreach (global::Gibraltar.Agent.Metrics.SampledMetricDefinition sampledMetricDefinition in list.ToArray())
					{
						if (sampledMetricDefinition.CounterName == counterName)
						{
							value = sampledMetricDefinition;
							flag = true;
							break;
						}
					}
				}
			}
			if (!flag)
			{
				global::Gibraltar.Agent.Metrics.SampledMetricAttribute sampledMetricAttribute = null;
				if (userObjectType.IsDefined(typeof(global::Gibraltar.Agent.Metrics.SampledMetricAttribute), false))
				{
					sampledMetricAttribute = (global::System.Attribute.GetCustomAttribute(userObjectType, typeof(global::Gibraltar.Agent.Metrics.SampledMetricAttribute)) as global::Gibraltar.Agent.Metrics.SampledMetricAttribute);
				}
				if (sampledMetricAttribute != null)
				{
					string metricsSystem = sampledMetricAttribute.MetricsSystem;
					string metricCategoryName = sampledMetricAttribute.MetricCategoryName;
					global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition;
					flag = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.s_Definitions.TryGetValue(metricsSystem, metricCategoryName, counterName, out metricDefinition);
					value = (flag ? (metricDefinition as global::Gibraltar.Agent.Metrics.SampledMetricDefinition) : null);
					if (flag && value == null)
					{
						throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The metric definition registered for metrics system ({0}) and category name ({1}) from SampledMetric attribute on {3}, and specified counter name ({2}) is not a sampled metric definition.", new object[]
						{
							metricsSystem,
							metricCategoryName,
							counterName,
							userObjectType.Name
						}));
					}
				}
			}
			return flag;
		}

		// Token: 0x0400008B RID: 139
		private readonly global::Gibraltar.Monitor.CustomSampledMetricDefinition m_WrappedDefinition;

		// Token: 0x0400008C RID: 140
		private readonly global::Gibraltar.Agent.Metrics.Internal.SampledMetricCollection m_Metrics;

		// Token: 0x0400008D RID: 141
		private static readonly global::System.Type[] s_SupportedDataTypes = new global::System.Type[]
		{
			typeof(double),
			typeof(float),
			typeof(decimal),
			typeof(long),
			typeof(ulong),
			typeof(int),
			typeof(uint),
			typeof(short),
			typeof(ushort),
			typeof(global::System.DateTime),
			typeof(global::System.DateTimeOffset),
			typeof(global::System.TimeSpan)
		};

		// Token: 0x0400008E RID: 142
		private static readonly global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection s_Definitions = global::Gibraltar.Agent.Log.MetricDefinitions;

		// Token: 0x0400008F RID: 143
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, bool> s_DataTypeSupported = global::Gibraltar.Agent.Metrics.SampledMetricDefinition.InitTypeSupportedDictionary();

		// Token: 0x04000090 RID: 144
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type[]> s_InheritanceMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Type[]>();

		// Token: 0x04000091 RID: 145
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetricDefinition>> s_DefinitionsMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.SampledMetricDefinition>>();

		// Token: 0x04000092 RID: 146
		private static readonly object s_DictionaryLock = new object();
	}
}
