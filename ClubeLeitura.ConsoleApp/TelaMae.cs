using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    public abstract class TelaMae
    {

        public abstract void Inserir();
        public virtual void Editar() { }
        public virtual void Excluir() { }
        public abstract bool Visualizar(string tipo);
        public virtual void MostrarTitulo(string titulo) { }

    }
}
