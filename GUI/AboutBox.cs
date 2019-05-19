using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace HMonZ.GUI {
  public partial class AboutBox : Form {
    public AboutBox() {
      InitializeComponent();
      this.Font = SystemFonts.MessageBoxFont;
      this.label3.Text = "Version " + 
        System.Windows.Forms.Application.ProductVersion;

      projectLinkLabel.Links.Remove(projectLinkLabel.Links[0]);
      projectLinkLabel.Links.Add(0, projectLinkLabel.Text.Length,
        "http://openhardwaremonitor.org");

      licenseLinkLabel.Links.Remove(licenseLinkLabel.Links[0]);
      licenseLinkLabel.Links.Add(0, licenseLinkLabel.Text.Length,
        "License.html");
    }

    private void linkLabel_LinkClicked(object sender, 
      LinkLabelLinkClickedEventArgs e) {
      try {
        Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()));
      } catch { }
    }

  }
}
