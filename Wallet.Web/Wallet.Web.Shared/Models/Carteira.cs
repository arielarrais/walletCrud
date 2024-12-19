using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wallet.Web.Shared.Models
{
    public class Carteira
    {
        [Key]
        public int Id { get; set; }
        public string? Id_Ativo { get; set; }

        public string? Nome { get; set; }
    }
}
