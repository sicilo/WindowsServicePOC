namespace ComputerBattery
{
    partial class ProjectInstaller
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
            this.ComputerBatteryProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.ComputerBatteryInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // ComputerBatteryProcessInstaller
            // 
            this.ComputerBatteryProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.ComputerBatteryProcessInstaller.Password = null;
            this.ComputerBatteryProcessInstaller.Username = null;
            // 
            // ComputerBatteryInstaller
            // 
            this.ComputerBatteryInstaller.Description = "Monitor de estado de batería de la computadora";
            this.ComputerBatteryInstaller.DisplayName = "Computer Battery";
            this.ComputerBatteryInstaller.ServiceName = "ComputerBattery";
            this.ComputerBatteryInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ComputerBatteryProcessInstaller,
            this.ComputerBatteryInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ComputerBatteryProcessInstaller;
        private System.ServiceProcess.ServiceInstaller ComputerBatteryInstaller;
    }
}