using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp.ModuloRevista
{
    public abstract class RepositorioMae
    {
        public abstract void Inserir();

        public virtual void Editar() { }

        public virtual void Excluir() { }

        public abstract void SelecionarTodos();

        public abstract void ObterPosicaoVazia();

        public abstract void ObterQuantidade();






    }
}
