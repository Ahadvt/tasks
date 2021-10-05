using System;

namespace MachineGun
{
    public class Gun
    {
        private int _bullet=1;
        private int _gunmagazine = 30;
        private string _auto = "auto";
        private string _manual = "manual";
        

        
        public void UsingGun(string UserRequest)
        {
            
            if (UserRequest == _auto)
            {
                    Console.WriteLine("you chosed auto mode all of the bullet shuted");
                _gunmagazine--;

                return;

            }else if(UserRequest == _manual)
            {
                _gunmagazine--;

            }

            else
            {
                Console.WriteLine("there are only 2 methods 'manual or auto'");
            }
            
            
              
            
             
        }
             
        


    }
}