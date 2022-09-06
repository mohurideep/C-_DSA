
using System;
using System.Collections;
using System.Collections.Generic;

// List<FlyingMachine> machines = new List<FlyingMachine>();
//         machines.Add(new FlyingMachine());
//         machines.Add(new Jet());
//         machines.Add(new Helicopter());
//         machines.Add(new Jet());

//         new MakeThingsFly().letTheMachinesFly(machines);


class MakeThingsFly {
    public void letTheMachinesFly(List<FlyingMachine> flyingMachines) {
        foreach (FlyingMachine flyingMachine in flyingMachines) {
            flyingMachine.Fly();
        }
    }
}
    class FlyingMachine{
        public virtual void Fly(){
            Console.WriteLine("No Implementation");
        }
    }
    class Jet : FlyingMachine{
        public override void Fly(){
            Console.WriteLine("Start, taxi, fly");
        }
        public void bombardment() {
        Console.WriteLine("Fire missile");
        }
    }
    class Helicopter : FlyingMachine{
        public override void Fly(){
        Console.WriteLine("Start vertically, hover, fly");
        }
    }
