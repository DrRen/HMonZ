

namespace HMonZ.Hardware {

  internal interface IGroup {

    IHardware[] Hardware { get; }

    string GetReport();

    void Close();
  }

}
