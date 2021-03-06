﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackovid
{
    public class Noticia
    {
        private string cod_noticia;
        private string manchete;
        private string descrição;
        private List<Indice> indices;
        private string fonte;

        public string Cod_noticia { get => cod_noticia; set => cod_noticia = value; }
        public string Manchete { get => manchete; set => manchete = value; }
        public string Descrição { get => descrição; set => descrição = value; }
        public List<Indice> Indices { get => indices; set => indices = value; }
        public string Fonte { get => fonte; set => fonte = value; }
    }
}
