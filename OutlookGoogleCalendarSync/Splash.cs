﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutlookGoogleCalendarSync {
    public partial class Splash : Form {
        public Splash() {
            InitializeComponent();
            lVersion.Text = "v" + Application.ProductVersion;
            String completedSyncs = XMLManager.ImportElement("CompletedSyncs", Program.SettingsFile) ?? "0";
            if (completedSyncs == "0")
                lSyncCount.Visible = false;
            else {
                lSyncCount.Text = lSyncCount.Text.Replace("{syncs}", String.Format("{0:n0}", completedSyncs));
                lSyncCount.Left = (panel1.Width - (lSyncCount.Width)) / 2;
            }
        }

    }
}
