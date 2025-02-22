﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concretes
{
    public class Ticket : IEntity
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public int SalonId { get; set; }

        public int Quantity { get; set; }

        public bool Status { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public DateTime EventStartedDate { get; set; }

        public DateTime EventFinishedDate { get; set; }

        public virtual  Category Category { get; set; }

        public virtual Salon Salon { get; set; }

        public virtual ICollection<TicketFile> TicketFiles { get; set; }
    }
}
