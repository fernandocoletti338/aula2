﻿using RevisandoEntity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Controller
{
    // deixar public
    public class CervejaController
    {
        //iniciamos nossa base de dados na controller
        CervejaContextDB contextDB = new CervejaContextDB();
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDB.Cervejas.Add(item);
                contextDB.SaveChanges();
            }
        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDB.Cervejas.Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}

