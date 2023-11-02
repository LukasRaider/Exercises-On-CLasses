using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamp;

public class Lamp { 
    private static bool lampa;
    // upravit negacemi 
    public Lamp()
    {
        lampa = false;
    }

    public string getStat() {
        if (lampa == true)
        {
            return "On";
        }
        else
        {
            return "Off";
        }
        
    }
    public void setStatOn()
    {
        lampa = true;
    }
    public void setStatOff()
    {
        lampa = false;
    }
   
}


public class TestLamp {
    public static void Mainx()
    {
        Lamp l1 = new Lamp();
        
        Console.WriteLine($"Lampa je {l1.getStat()}");
        l1.setStatOn();
        Console.WriteLine($"Lampa je {l1.getStat()}");
        Lamp l2 = new Lamp();
        l2.setStatOn();
        Console.WriteLine($"Lampa je {l2.getStat()}");
        l2.setStatOff();
        Console.WriteLine($"Lampa je {l2.getStat()}");
    }
}
