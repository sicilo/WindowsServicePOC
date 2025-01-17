﻿namespace ComputerBattery
{
    partial class ComputerBatteryService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eventLog = new System.Diagnostics.EventLog();
            this.ComputerBatteryTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
            // 
            // ComputerBatteryTimer
            // 
            this.ComputerBatteryTimer.Enabled = true;
            this.ComputerBatteryTimer.Interval = 300000;
            this.ComputerBatteryTimer.Tick += new System.EventHandler(this.ComputerBaterryElapsed);
            // 
            // ComputerBatteryService
            // 
            this.ServiceName = "ComputerBattery";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog;
        private System.Windows.Forms.Timer ComputerBatteryTimer;
    }
}
