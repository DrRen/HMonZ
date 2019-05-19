

using System;
using System.Collections.Generic;
using HMonZ.Hardware;

namespace HMonZ.GUI {
  public class TypeNode : Node {

    private SensorType sensorType;

    public TypeNode(SensorType sensorType) : base() {
      this.sensorType = sensorType;

      switch (sensorType) {
        case SensorType.Voltage: 
          this.Image = Utilities.EmbeddedResources.GetImage("voltage.png");
          this.Text = "Напряжения";
          break;
        case SensorType.Clock:
          this.Image = Utilities.EmbeddedResources.GetImage("clock.png");
          this.Text = "Частоты";
          break;
        case SensorType.Load:
          this.Image = Utilities.EmbeddedResources.GetImage("load.png");
          this.Text = "Нагрузка";
          break;
        case SensorType.Temperature:
          this.Image = Utilities.EmbeddedResources.GetImage("temperature.png");
          this.Text = "Температуры";
          break;
        case SensorType.Fan:
          this.Image = Utilities.EmbeddedResources.GetImage("fan.png");
          this.Text = "Вентеляторы";
          break;
        case SensorType.Flow:
          this.Image = Utilities.EmbeddedResources.GetImage("flow.png");
          this.Text = "Поток";
          break;
        case SensorType.Control:
          this.Image = Utilities.EmbeddedResources.GetImage("control.png");
          this.Text = "Контроллеры";
          break;
        case SensorType.Level:
          this.Image = Utilities.EmbeddedResources.GetImage("level.png");
          this.Text = "Уровни";
          break;
        case SensorType.Power:
          this.Image = Utilities.EmbeddedResources.GetImage("power.png");
          this.Text = "Мощность";
          break;
        case SensorType.Data:
          this.Image = Utilities.EmbeddedResources.GetImage("data.png");
          this.Text = "Данные";
          break;
        case SensorType.SmallData :
          this.Image = Utilities.EmbeddedResources.GetImage("data.png");
          this.Text = "Данные";
          break;
        case SensorType.Factor:
          this.Image = Utilities.EmbeddedResources.GetImage("factor.png");
          this.Text = "Факторы";
          break;
      }

      NodeAdded += new NodeEventHandler(TypeNode_NodeAdded);
      NodeRemoved += new NodeEventHandler(TypeNode_NodeRemoved);
    }

    private void TypeNode_NodeRemoved(Node node) {
      node.IsVisibleChanged -= new NodeEventHandler(node_IsVisibleChanged);
      node_IsVisibleChanged(null);
    }    

    private void TypeNode_NodeAdded(Node node) {
      node.IsVisibleChanged += new NodeEventHandler(node_IsVisibleChanged);
      node_IsVisibleChanged(null);
    }

    private void node_IsVisibleChanged(Node node) {      
      foreach (Node n in Nodes)
        if (n.IsVisible) {
          this.IsVisible = true;
          return;
        }
      this.IsVisible = false;
    }

    public SensorType SensorType {
      get { return sensorType; }
    }
  }
}
