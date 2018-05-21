using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_InoDa
{
    public partial class Cliente
    {
        public Cliente(string nome, string nif, string morada, string contacto)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            NIF = nif ?? throw new ArgumentNullException(nameof(nif));
            Morada = morada ?? throw new ArgumentNullException(nameof(morada));
            Contacto = contacto ?? throw new ArgumentNullException(nameof(contacto));
        }
    }
}
