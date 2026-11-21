namespace ClinicReception;

// HR export: working hours are whole hours only
public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public int Room { get; set; }
    public int StartHour { get; set; }
    public int EndHour { get; set; }
}