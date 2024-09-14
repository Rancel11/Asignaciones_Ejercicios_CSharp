using System;

class AlarmClock
{
 
    public event EventHandler OnAlarmRing;

    private DateTime alarmTime;

    
    public AlarmClock(DateTime time)
    {
        alarmTime = time;
    }

    
    public void CheckAlarm()
    {
        if (DateTime.Now >= alarmTime)
        {
           
            if (OnAlarmRing != null)
            {
                OnAlarmRing(this, EventArgs.Empty);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese la hora de la alarma (hh:mm:ss):");
        string Ingresar = Console.ReadLine();
        DateTime alarmTime;

        
        if (DateTime.TryParse(Ingresar, out alarmTime))
        {
            AlarmClock alarm = new AlarmClock(alarmTime);

            
            alarm.OnAlarmRing += (sender, e) =>
            {
                Console.WriteLine("¡La alarma ha sonado!");
            };

            Console.WriteLine("Alarma configurada para: " + alarmTime);

            
            while (true)
            {
                alarm.CheckAlarm();
            }
        }
        else
        {
            Console.WriteLine("Formato de hora inválido.");
        }
    }
}
