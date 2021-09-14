using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace examen1.Models
{
    public class Gasto
    {

        public int GastoId{ get; set; }


        [DisplayName("Gasto")]
        public string Nombre { get; set; }







    }
}
