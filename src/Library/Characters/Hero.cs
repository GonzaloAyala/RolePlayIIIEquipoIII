using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Hero 
    {
        public int PV = 0;

        public void WinPV()
        {
            this.PV = this.PV +1;
        }

        public int getPV()
        {
            return this.PV;
        }
    }
}