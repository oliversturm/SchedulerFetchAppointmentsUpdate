using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SchedulerFetchAppointmentsUpdate
{
  public partial class Form1 : DevExpress.XtraEditors.XtraForm
  {
    public Form1()
    {
      InitializeComponent();
    }

    List<Event> allEvents;

    void CreateSampleData()
    {
      allEvents = new List<Event>();
      var now = DateTime.Now;
      for (int i = -182; i < 183; i++)
      {
        allEvents.Add(new Event
        {
          Id = i,
          Name = $"Event {i}",
          Start = now.AddDays(i),
          End = now.AddDays(i).AddMinutes(30)
        });
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      CreateSampleData();
    }

    private void SchedulerDataStorage1_FetchAppointments(object sender, FetchAppointmentsEventArgs e)
    {
      Console.WriteLine($"FetchAppointments  {e.Interval}");
      if (allEvents != null)
      {
        var events = allEvents.Where(ev => ev.Start < e.Interval.End && ev.End > e.Interval.Start).ToList();
        Console.WriteLine($"Returning {events.Count()} appointments");
        bindingSource1.DataSource = events;
      }
    }

    string IdList(IList objects) => objects.Cast<IPersistentObject>().Aggregate(
        new StringBuilder(),
        (r, v) => r.Append($"{v.Id} ")).ToString();

    private void SchedulerDataStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
    {
      // Geaenderte Appointments werden direkt im gebundenen Objekt aktualisiert.
      // Da dieses Objekt in der Beispielimplementation dasselbe ist, das auch 
      // in der "Master-Liste" steht, schlaegt die Aenderung dahin durch.
      // Sollte ich die Aenderung in einer Datenbank persistieren wollen,
      // muesste dieser Vorgang jetzt oder zu einem spaeteren Zeitpunkt
      // explizit angestossen werden.
      var appointmentIds = IdList(e.Objects);
      Console.WriteLine($"Appointments changed: [{appointmentIds}]");
    }

    private void SchedulerDataStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
    {
      // In e.Objects finden sich die neu angelegten Appointments. Diese
      // koennen extern persistiert werden. Die Objekte sind gleichzeitig
      // bereits in der Liste abgebildet, die derzeit an den Scheduler gebunden
      // ist (also in diesem Beispiel die temporaere Collection).

      // Es ist moeglich, an dieser Stelle eine Id fuer das neue Appointment
      // zu setzen (da der Ansatz in InitNewAppointment nicht korrekt
      // funktioniert). Diese Aenderung wird auch im neuen persistenten
      // Objekt abgebildet.
      ((Appointment) e.Objects[0]).SetId(allEvents.Count() + 1);

      Console.WriteLine("Appointments inserted");
    }

    private void SchedulerDataStorage1_CreateSourceObject(object sender, CreateSourceObjectEventArgs e)
    {
      // Das Resultat hier sollte ein neues leeres Objekt vom eigenen 
      // persistenten Typ sein.
      e.SourceObject = new Event();
    }

    private void SchedulerControl1_InitNewAppointment(object sender, AppointmentEventArgs e)
    {
      Console.WriteLine("InitNewAppointment");

      // Optional: setzen einer Id. Leider wird diese Id aktuell nicht korrekt
      // in das neue persistente Objekt uebertragen, aber dies wird in Zukunft
      // korrigiert.
      e.Appointment.SetId(allEvents.Count() + 1);
    }

  }
}
