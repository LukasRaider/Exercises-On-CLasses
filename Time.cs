using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time;


class Time {
    private int hour;
    private int minute;
    private int second;

    private bool RightHour(int hour)
    { 
        return hour >= 0 && hour <=23;
    }
    private bool RightMinute(int minute)
    {
        return minute >= 0 && minute <= 59;
    }
    private bool RightSecond(int second)
    {
        return second >= 0 && second <= 59;
    }
    public Time(int hour, int minute, int second) { 
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }
    public int GetHour() {return hour;}
    public int GetMinute() { return minute;}
    public int GetSecond() { return second;}
    public void SetHour(int hour) { this.hour = hour;}
    public void SetMinute(int minute) {  this.minute = minute;}
    public void SetSecond(int second) {  this.second = second;}
    public void setTime(int hour,int minute, int second) {}
    public string toString() {
        return ($"{hour:D2}:{minute:D2}:{second:D2}");
    }
    /*public Time nextSecond() {
        return (hour,minute,second + 1);
    }
    public Time previousMinute() {
        return (hour, minute,second - 1);
    }
    */
}

class TestTime {
    public static void Mainx()
    {
        Time t1 = new Time(20,20,20);
        Console.WriteLine(t1.toString());
    }
}
