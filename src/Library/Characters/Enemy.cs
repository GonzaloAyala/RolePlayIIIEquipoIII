using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Enemy  
    {
        public int PV = 1;

        public void Dead()
        {
            this.PV = 0;
        }
    }
}