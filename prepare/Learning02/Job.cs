using System;

public class Job{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // "Job Title (Company) StartYear-EndYear"

    public void DisplayJobDetails(){
        Console.WriteLine(_jobTitle + " " + " (" + _company + ") " + _startYear + "-" + _endYear);
    }
}