using System;
using System.Diagnostics;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001C8 RID: 456
	internal sealed class PerfCounterMetricDefinition : global::Gibraltar.Monitor.SampledMetricDefinition, global::System.IComparable<global::Gibraltar.Monitor.PerfCounterMetricDefinition>, global::System.IEquatable<global::Gibraltar.Monitor.PerfCounterMetricDefinition>
	{
		// Token: 0x060015A9 RID: 5545 RVA: 0x00041340 File Offset: 0x0003F540
		public PerfCounterMetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, global::System.Diagnostics.PerformanceCounter newPerformanceCounter) : base(definitions, new global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket(newPerformanceCounter))
		{
			this.m_RequiresMultipleSamples = global::Gibraltar.Monitor.PerfCounterMetricDefinition.CounterRequiresMultipleSamples(newPerformanceCounter.CounterType);
			this.CalculateIsPercentage();
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00041368 File Offset: 0x0003F568
		internal PerfCounterMetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket packet) : base(definitions, packet)
		{
			this.m_RequiresMultipleSamples = global::Gibraltar.Monitor.PerfCounterMetricDefinition.CounterRequiresMultipleSamples(packet.CounterType);
			this.CalculateIsPercentage();
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0004138C File Offset: 0x0003F58C
		public int CompareTo(global::Gibraltar.Monitor.PerfCounterMetricDefinition other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00041398 File Offset: 0x0003F598
		public bool Equals(global::Gibraltar.Monitor.PerfCounterMetricDefinition other)
		{
			return base.Equals(other);
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x000413A4 File Offset: 0x0003F5A4
		public new global::Gibraltar.Monitor.PerfCounterMetricCollection Metrics
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetricCollection)base.Metrics;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x000413B4 File Offset: 0x0003F5B4
		public global::System.Diagnostics.PerformanceCounterType CounterType
		{
			get
			{
				return ((global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket)base.Packet).CounterType;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x000413C8 File Offset: 0x0003F5C8
		public bool RequiresMultipleSamples
		{
			get
			{
				return this.m_RequiresMultipleSamples;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x000413D0 File Offset: 0x0003F5D0
		public bool IsPercentage
		{
			get
			{
				return this.m_IsPercentage;
			}
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000413D8 File Offset: 0x0003F5D8
		internal static string GetKey(global::System.Diagnostics.PerformanceCounter newPerfCounter)
		{
			return global::Gibraltar.Monitor.MetricDefinition.GetKey(global::Gibraltar.Monitor.PerfCounterMetricDefinition.PerfCounterMetricType, newPerfCounter.CategoryName, newPerfCounter.CounterName);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000413F0 File Offset: 0x0003F5F0
		internal static bool CounterRequiresMultipleSamples(global::System.Diagnostics.PerformanceCounterType counterType)
		{
			if (counterType <= global::System.Diagnostics.PerformanceCounterType.NumberOfItemsHEX64)
			{
				if (counterType != global::System.Diagnostics.PerformanceCounterType.NumberOfItemsHEX32 && counterType != global::System.Diagnostics.PerformanceCounterType.NumberOfItemsHEX64)
				{
					goto IL_49;
				}
			}
			else if (counterType != global::System.Diagnostics.PerformanceCounterType.NumberOfItems32 && counterType != global::System.Diagnostics.PerformanceCounterType.NumberOfItems64 && counterType != global::System.Diagnostics.PerformanceCounterType.RawFraction)
			{
				goto IL_49;
			}
			return false;
			IL_49:
			return true;
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00041450 File Offset: 0x0003F650
		internal new global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket Packet
		{
			get
			{
				return (global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket)base.Packet;
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x00041460 File Offset: 0x0003F660
		protected override global::Gibraltar.Monitor.MetricCollection OnMetricDictionaryCreate()
		{
			return new global::Gibraltar.Monitor.PerfCounterMetricCollection(this);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00041468 File Offset: 0x0003F668
		private void CalculateIsPercentage()
		{
			global::System.Diagnostics.PerformanceCounterType counterType = this.CounterType;
			if (counterType <= global::System.Diagnostics.PerformanceCounterType.SampleFraction)
			{
				if (counterType <= global::System.Diagnostics.PerformanceCounterType.CounterTimer)
				{
					if (counterType != global::System.Diagnostics.PerformanceCounterType.RawFraction && counterType != global::System.Diagnostics.PerformanceCounterType.CounterTimer)
					{
						goto IL_B8;
					}
				}
				else if (counterType != global::System.Diagnostics.PerformanceCounterType.Timer100Ns && counterType != (global::System.Diagnostics.PerformanceCounterType)542573824 && counterType != global::System.Diagnostics.PerformanceCounterType.SampleFraction)
				{
					goto IL_B8;
				}
			}
			else if (counterType <= global::System.Diagnostics.PerformanceCounterType.CounterMultiTimer)
			{
				if (counterType != global::System.Diagnostics.PerformanceCounterType.CounterTimerInverse && counterType != global::System.Diagnostics.PerformanceCounterType.Timer100NsInverse && counterType != global::System.Diagnostics.PerformanceCounterType.CounterMultiTimer)
				{
					goto IL_B8;
				}
			}
			else if (counterType != global::System.Diagnostics.PerformanceCounterType.CounterMultiTimer100Ns && counterType != global::System.Diagnostics.PerformanceCounterType.CounterMultiTimerInverse && counterType != global::System.Diagnostics.PerformanceCounterType.CounterMultiTimer100NsInverse)
			{
				goto IL_B8;
			}
			this.m_IsPercentage = true;
			return;
			IL_B8:
			this.m_IsPercentage = false;
		}

		// Token: 0x04000708 RID: 1800
		public static string PerfCounterMetricType = "PerfCounter";

		// Token: 0x04000709 RID: 1801
		private readonly bool m_RequiresMultipleSamples;

		// Token: 0x0400070A RID: 1802
		private bool m_IsPercentage;
	}
}
