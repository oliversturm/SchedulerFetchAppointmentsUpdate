namespace SchedulerFetchAppointmentsUpdate
{
  partial class Form1
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
      DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
      DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
      this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
      this.schedulerDataStorage1 = new DevExpress.XtraScheduler.SchedulerDataStorage(this.components);
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      this.SuspendLayout();
      // 
      // schedulerControl1
      // 
      this.schedulerControl1.DataStorage = this.schedulerDataStorage1;
      this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
      this.schedulerControl1.Name = "schedulerControl1";
      this.schedulerControl1.Size = new System.Drawing.Size(1008, 476);
      this.schedulerControl1.Start = new System.DateTime(2019, 6, 17, 0, 0, 0, 0);
      this.schedulerControl1.TabIndex = 0;
      this.schedulerControl1.Text = "schedulerControl1";
      this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
      this.schedulerControl1.Views.FullWeekView.Enabled = true;
      this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
      this.schedulerControl1.Views.WeekView.Enabled = false;
      this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
      this.schedulerControl1.InitNewAppointment += new DevExpress.XtraScheduler.AppointmentEventHandler(this.SchedulerControl1_InitNewAppointment);
      // 
      // schedulerDataStorage1
      // 
      // 
      // 
      // 
      this.schedulerDataStorage1.AppointmentDependencies.AutoReload = false;
      // 
      // 
      // 
      this.schedulerDataStorage1.Appointments.DataSource = this.bindingSource1;
      this.schedulerDataStorage1.Appointments.Mappings.AppointmentId = "Id";
      this.schedulerDataStorage1.Appointments.Mappings.End = "End";
      this.schedulerDataStorage1.Appointments.Mappings.Start = "Start";
      this.schedulerDataStorage1.Appointments.Mappings.Subject = "Name";
      this.schedulerDataStorage1.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.SchedulerDataStorage1_AppointmentsInserted);
      this.schedulerDataStorage1.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.SchedulerDataStorage1_AppointmentsChanged);
      this.schedulerDataStorage1.FetchAppointments += new DevExpress.XtraScheduler.FetchAppointmentsEventHandler(this.SchedulerDataStorage1_FetchAppointments);
      this.schedulerDataStorage1.CreateSourceObject += new System.EventHandler<DevExpress.XtraScheduler.CreateSourceObjectEventArgs>(this.SchedulerDataStorage1_CreateSourceObject);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 476);
      this.Controls.Add(this.schedulerControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.schedulerDataStorage1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
    private DevExpress.XtraScheduler.SchedulerDataStorage schedulerDataStorage1;
    private System.Windows.Forms.BindingSource bindingSource1;
  }
}

