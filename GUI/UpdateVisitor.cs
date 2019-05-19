

using System;
using System.Collections.Generic;
using HMonZ.Hardware;

namespace HMonZ.GUI {
  public class UpdateVisitor : IVisitor {
    public void VisitComputer(IComputer computer) {
      computer.Traverse(this);
    }

    public void VisitHardware(IHardware hardware) {
      hardware.Update();
      foreach (IHardware subHardware in hardware.SubHardware)
        subHardware.Accept(this);
    }

    public void VisitSensor(ISensor sensor) { }

    public void VisitParameter(IParameter parameter) { }
  }
}
