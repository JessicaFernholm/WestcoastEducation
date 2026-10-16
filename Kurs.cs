namespace WestcoastEducation;

public enum Kurstyp { Klassrum, Distans }

public class Kurs

{
    public required string Namn { get; set; }
    public Kurstyp Typ { get; set; }
    public int Längd { get; set; }
}
