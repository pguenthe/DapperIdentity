using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityExample1.Models
{
    public class Info
    {
        private int userId;
        private string movie;
        private string color;
        private string song;

        public int UserId { get => userId; set => userId = value; }
        public string Movie { get => movie; set => movie = value; }
        public string Color { get => color; set => color = value; }
        public string Song { get => song; set => song = value; }
    }
}
