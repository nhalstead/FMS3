using System;
using System.Threading;
using FMS3.Utilities;

namespace MonoBrick.FiveOne; 

public static class tester {
    public static void main(/* String[] args */) { 
        Logger.Info("Five one test!");
        Brick a = new Brick("COM5", debug:true);
        a.MotorA.On(100);
        a.MotorB.On(100);
        Logger.Debug("sleeping!");
        Thread.Sleep(1000);
        a.logRepl();
        Thread.Sleep(9000);
    
    }
}