﻿

using System.Collections.Generic;
using HMonZ.Collections;

namespace HMonZ.Hardware.HDD {  

  [NamePrefix(""), RequireSmart(0xAA), RequireSmart(0xAB), RequireSmart(0xAC), 
   RequireSmart(0xAD), RequireSmart(0xAE), RequireSmart(0xCA)]
  internal class SSDMicron : AbstractHarddrive {

    private static readonly IEnumerable<SmartAttribute> smartAttributes =
      new List<SmartAttribute> {
      
      new SmartAttribute(0x01, SmartNames.ReadErrorRate, RawToInt),
      new SmartAttribute(0x05, SmartNames.ReallocatedSectorsCount, RawToInt),
      new SmartAttribute(0x09, SmartNames.PowerOnHours, RawToInt),
      new SmartAttribute(0x0C, SmartNames.PowerCycleCount, RawToInt),
      new SmartAttribute(0xAA, SmartNames.NewFailingBlockCount, RawToInt),
      new SmartAttribute(0xAB, SmartNames.ProgramFailCount, RawToInt),
      new SmartAttribute(0xAC, SmartNames.EraseFailCount, RawToInt),
      new SmartAttribute(0xAD, SmartNames.WearLevelingCount, RawToInt),
      new SmartAttribute(0xAE, SmartNames.UnexpectedPowerLossCount, RawToInt),
      new SmartAttribute(0xB5, SmartNames.Non4kAlignedAccess, 
        (byte[] raw, byte value, IReadOnlyArray<IParameter> p) 
          => { return 6e4f * ((raw[5] << 8) | raw[4]); }),
      new SmartAttribute(0xB7, SmartNames.SataDownshiftErrorCount, RawToInt),
      new SmartAttribute(0xBB, SmartNames.ReportedUncorrectableErrors, RawToInt),
      new SmartAttribute(0xBC, SmartNames.CommandTimeout, RawToInt),
      new SmartAttribute(0xBD, SmartNames.FactoryBadBlockCount, RawToInt),
      new SmartAttribute(0xC4, SmartNames.ReallocationEventCount, RawToInt),
      new SmartAttribute(0xC5, SmartNames.CurrentPendingSectorCount),
      new SmartAttribute(0xC6, SmartNames.OffLineUncorrectableErrorCount, RawToInt),
      new SmartAttribute(0xC7, SmartNames.UltraDmaCrcErrorCount, RawToInt),
      new SmartAttribute(0xCA, SmartNames.RemainingLife, 
        (byte[] raw, byte value, IReadOnlyArray<IParameter> p) 
          => { return 100 - RawToInt(raw, value, p); }, 
        SensorType.Level, 0, SmartNames.RemainingLife),
      new SmartAttribute(0xCE, SmartNames.WriteErrorRate,
         (byte[] raw, byte value, IReadOnlyArray<IParameter> p)
           => { return 6e4f * ((raw[1] << 8) | raw[0]); }),
    };

    public SSDMicron(ISmart smart, string name, string firmwareRevision, 
      int index, ISettings settings)
      : base(smart, name, firmwareRevision, index, smartAttributes, settings) {}
  }
}
