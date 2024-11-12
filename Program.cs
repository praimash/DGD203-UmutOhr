using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace car;
class car
{
    private int oil = 100;
    private int speed;
    private bool engineOn = false;

    public void startEngine()
    {
        if(!engineOn)
        {
            engineOn = true;
            Console.WriteLine("Engine is started!");
        }
        else
        {
            Console.WriteLine("Engine is already started.");
        }
    }
    public void stopEngine()
    {
        if (engineOn)
        {
            engineOn = false;
            Console.WriteLine("Engine is stoped!");
        }
        else
        {
            Console.WriteLine("Engine is already stoped.");
        }
    }

    public void getFast()
    {
        if (engineOn)
        speed += 10;
        Console.WriteLine("Car's speed increased, current speed:" + speed + "km/h");
    }
    public void brake()
    {
        if (engineOn&&speed>0) 
        speed -= 10;
        Console.WriteLine("Car's speed decreased, current speed:" + speed + "km/h");
    }
    public void showStuation()
    {
        Console.WriteLine(" current speed:" + speed + "km/h \n And oil level is %" + oil);
    }
    public void changeOil(int amount)
    {
        oil += amount;
        if (oil > 100) oil = 100;
        if (oil < 0) oil = 0;
        Console.WriteLine("Oil level has changed , new oil level is %" + oil);
    }
    public void controlOil()
    {
        if (oil == 100)
        {
            Console.WriteLine("-Oil level is FULL.-");
        }
        else if (oil < 100 & oil > 20)
        {
            Console.WriteLine("-Car oil level is between optimum range, the oil level is %" + oil+"-");
        }
        else if (oil == 0)
        {
            Console.WriteLine("-Ran out of oil, please change oil.- ");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car();
            mycar.controlOil();
            mycar.startEngine();
            mycar.changeOil(-40);
            mycar.controlOil();
            mycar.changeOil(-60);
            mycar.controlOil();
            mycar.getFast();
            mycar.showStuation();
            mycar.getFast();
            mycar.showStuation();
            mycar.brake();
        }
    }

}
        
    
    
            
    
        

    
