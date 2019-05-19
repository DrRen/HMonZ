


using System.Management.Instrumentation;
using HMonZ.Hardware;

namespace HMonZ.WMI {
  [InstrumentationClass(InstrumentationType.Instance)]
  public class Hardware : IWmiObject {
    #region WMI Exposed
    
    public string HardwareType { get; private set; }
    public string Identifier { get; private set; }
    public string Name { get; private set; }
    public string Parent { get; private set; }

    #endregion

    public Hardware(IHardware hardware) {
      Name = hardware.Name;
      Identifier = hardware.Identifier.ToString();
      HardwareType = hardware.HardwareType.ToString();
      Parent = (hardware.Parent != null)
        ? hardware.Parent.Identifier.ToString()
        : "";
    }

    public void Update() { }
  }
}
