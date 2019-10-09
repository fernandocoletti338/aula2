using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalagoCelulares.Model;

namespace CatalagoCelulares.Controller
{
    // deixar publico
    public class CelularesController
    {
        CelularesContextDB contexDB = new CelularesContextDB();
        /// <summary>
        /// metod que retorna lista de celulares ativos apenas
        /// </summary>
        /// <returns>querylist de celulares filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulars()
        {
            return contexDB.Celulares.Where(x => x.Ativo == true);
        }
        /// <summary>
        ///  metodo que atualiza um registro valido do nosso sistema
        /// </summary>
        /// <param name="item">item que vamos atualizar</param>
        /// <returns>retorna verdadiro caso um item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = contexDB.Celulares.FirstOrDefault(x => x.Id == item.Id);

            if (celular == null)
                return false;

            else celular = item;
            celular.DataAlteracao = DateTime.Now;

            contexDB.SaveChanges();
            return true;
        }
        /// <summary>
        /// metodo q valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">nosso novo celular</param>
        /// <returns></returns>
        public bool InserirCelular (Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))
                return false;

            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;

            if (item.Preco <= 0)
                return false;

            contexDB.Celulares.Add(item);
            contexDB.SaveChanges();


            return true;
            
        }
        /// <summary>
        /// metodo utilizado para aoenas desativar o itn=m dentro dentro de nosso sistema 
        /// </summary>
        /// <param name="Id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso!</returns>

        public bool RemoverCelular(int Id)
        {
            var celular = contexDB.Celulares.FirstOrDefault(x => x.Id == Id);

            if (celular == null)
                return false;

            celular.Ativo = false;

            contexDB.SaveChanges();

            return true;
        }
    }
}
