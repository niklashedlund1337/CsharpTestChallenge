namespace DataAPI.Models;

public class Employee
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Office { get; set; }
    public string? Manager { get; set; }
    public string? OrgUnit { get; set; }
    public string? MainText { get; set; }
    public string? Github { get; set; }
    public string? Twitter { get; set; }
    public string? StackOverflow { get; set; }
    public string? LinkedIn { get; set; }
    public string? ImagePortraitUrl { get; set; }
    public string? ImageWallOfLeetUrl { get; set; }
    public bool Highlighted { get; set; }
    public bool Published { get; set; }
}