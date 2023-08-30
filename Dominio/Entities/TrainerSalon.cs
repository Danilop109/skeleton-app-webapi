using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class TrainerSalon : BaseEntity
    {
        public string NombreTrainer { get; set; }
        public int IdPersonaFk { get; set; }
        public Persona Perosna { get; set; }
        public int IdSalonFk { get; set; }
        public Salon Salon { get; set; }
        
    }
