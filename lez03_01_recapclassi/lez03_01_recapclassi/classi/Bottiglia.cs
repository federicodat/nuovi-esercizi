using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lez03_01_recapclassi.classi
{
    internal class Bottiglia
    {
        private string? materiale;
        private string? colore;
        private float diametro =0;
        private float altezza=0;
        private string? contenuto;

        public void SetAltezza(float varAltezza)
        {
            this.altezza = varAltezza;
            if (varAltezza > 0)
                this.altezza = varAltezza;
        }


        //-- per recuperare dati
        public float GetAltezza()
        {
            return this.altezza;
        }

        public float CalcolaVolume()
        {
            float raggio = diametro / 2;
            float area=(float)Math.PI*(raggio*raggio);
            //float volume =area*altezza;
            //return volume;
            return area * altezza; 
        }

        public void DettaglioGeometria()
        {
            console.Writeline(
                $"la bottiglia ha questi dati:\n +" +
                $"altezza : {GetAltezza()} \n +
                $"volume : {Getca}



                )
            float area = (float)Math.PI * (raggio * raggio);
            //float volume =area*altezza;
            //return volume;
            return area * altezza;
        }


        //----------
    }
}
