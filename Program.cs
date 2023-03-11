// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;


public class DoorMachine
{
    public enum DoorState { Terkunci, Terbuka };
    public enum Trigger { KunciPintu, BukaPintu };

    class Door
    {

        public DoorState currentState = DoorState.Terkunci;

        public class Transition
        {
            public DoorState stateAwal;
            public DoorState stateAkhir;
            public Trigger trigger;


            public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }

            Transition[] transitions =
            {
                new Transition(DoorState.Terkunci,DoorState.Terkunci,Trigger.KunciPintu),
                new Transition(DoorState.Terkunci,DoorState.Terbuka,Trigger.BukaPintu),
                new Transition(DoorState.Terbuka,DoorState.Terbuka,Trigger.BukaPintu),
                new Transition(DoorState.Terbuka,DoorState.Terkunci,Trigger.KunciPintu)
            };

            private DoorState GetStateBerikutnya(DoorState stateAwal, Trigger trigger)
            {
                DoorState stateAkhir = stateAwal;
                for (int i = 0; i < transitions.Length; i++)
                {
                    Transition perubahan = transitions[i];
                    if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                    {
                        stateAkhir = perubahan.stateAkhir;
                    }
                }
                return stateAkhir;
            }
            public void ActivateTrigger(Trigger trigger, DoorState currentState)
            {
                currentState = GetStateBerikutnya(currentState, trigger);
                Console.WriteLine("State sekarang adalah:" + currentState);
            }
            public static void Main(string[] args)
            {
                Door objDoor = new Door();
                Console.WriteLine(objDoor.currentState);
            }

        }

    }
}

