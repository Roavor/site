using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLibrary
{
    public enum EngineState
    { engineAlive,engineDead}
    public abstract class Car
    {
        public string PetName { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        protected EngineState engState= EngineState.engineAlive;
        public EngineState EngineState
        {
            get { return engState; }
        }
        public abstract void TurboBoost();
        public Car() { }
        public Car(string name,int maxSpeed,int currSpeed)
        {
            PetName = name;
            MaxSpeed = maxSpeed;
            CurrentSpeed = currSpeed;
        }

    }
    public class SportCar : Car
    {
        public SportCar() { }
        public SportCar (string name, int maxSpeed, int currSpeed): base( name,  maxSpeed, currSpeed)
        { }
        public override void TurboBoost()
        {
            MessageBox.Show("Ramming speed!","Faster is better...");
        }
    }
    public class MiniVan:Car
    {
        public MiniVan() { }
        public MiniVan(string name, int maxSpeed, int currSpeed):base ( name,  maxSpeed,  currSpeed)
        { }
        public override void TurboBoost()
        {
            engState = EngineState.engineDead;
            MessageBox.Show("Your engine block  expleded");
        }
    }
}
