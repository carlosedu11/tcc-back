using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Api_Tcc.Models;


namespace RpgApi.Models
{
    public class UsuarioDetalhe
    {        
        public int Id { get; set; } 
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] Foto { get; set; }
        public DateTime? DataAcesso { get; set; } //using System;

        [NotMapped] // using System.ComponentModel.DataAnnotations.Schema
        public string PasswordString { get; set; }
        public List<Usuario> Usuarios { get; set; }//using System.Collections.Generic;
        public string Perfil { get; set; }
        public string Email { get; set; }

        [NotMapped]
        public string Token {get; set; }


    }
}