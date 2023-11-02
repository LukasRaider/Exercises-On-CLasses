using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date;

class Date {
    private int day;
    private int month;
    private int year;

    private bool RightDay(int day)
    {
        return day >= 1 && day <= 31;
    }
    private bool RightMonth(int month)
    {
        return month >= 1 && month <= 12;
    }
    private bool RightYear(int year)
    {
        return year >= 1900 && year <= 9999;
    }
    
    public Date(int day, int month, int year) {
        if (RightDay(day) && RightMonth(month) && RightYear(year))
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        else
        {
            Console.WriteLine("Wrong set date.");
        }
    }
    public int getDay() { return day; }
    public int getMonth() { return month; }
    public int getYear() { return year; }
    public void setDay(int day) {  this.day = day; }
    public void setMonth(int month) {  this.month = month; }
    public void setYear(int year) {  this.year = year; }
    public void setDate(int day, int month, int year) { }
    public string toString() { return ($"{day:D2}/{month:D2}/{year:D4}"); }
}

class TestDate {

    public static void Mainx()
    {
        Date d1 = new Date(2,6,1999);
        Console.WriteLine(d1.toString());
        Date d2 = new Date(21, 110, 2003);
        Console.WriteLine(d2.toString());
        d2.setDay(33);
        Console.WriteLine(d2.toString());
    }
}