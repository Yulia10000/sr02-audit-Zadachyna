namespace ClinicReception;

public class Appointment
{
    public int Id;
    public int PatientId;
    public int DoctorId;
    public string VisitType;    // CONS, FUP, PROC, VACC
    public DateTime Start;
    public int Minutes;
    public bool Urgent;
    public AppointmentStatus Status;
    public decimal Fee;
}