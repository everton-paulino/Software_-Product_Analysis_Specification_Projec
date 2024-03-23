using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software__Product_Analysis_Specification__Projec
{
    [BsonIgnoreExtraElements]
    public class Lista
    {   
        public Lista()
        {
            Key = Guid.NewGuid().ToString();
            CriadoEm = DateTime.Now;
            AtualizadoEm = DateTime.Now;
            EstaAtivo = true;
        }
            public string Key { get; set; }
            public DateTime CriadoEm { get; set; }
            public DateTime AtualizadoEm { get; set; }
            public bool EstaAtivo { get; set; }
            public string NomeFuncionario{ get; set; }
            public string CPFFuncionario { get; set; }
            public string Ocupacao { get; set; }
            public string RazaoSocial{ get; set; }
            public string InicioCurso { get; set; }
            public string FimCurso { get; set; }
            public string TemadoCurso { get; set; }
            public string NomeInstrutor { get; set; }
            public string DocumentoInstrutor { get; set; }
            public string TipoDocumentoInstrutor { get; set; }
    }
}
