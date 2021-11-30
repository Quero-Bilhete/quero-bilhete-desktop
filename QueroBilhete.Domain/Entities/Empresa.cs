﻿using System.ComponentModel.DataAnnotations.Schema;

namespace QueroBilhete.Domain.Entities
{
    [Table(name: "EMPRESA")]
    public class Empresa : Entity
    {
        [Column("UID")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string UId { get; set; }

        [Column("RAZAO_SOCIAL")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, TamanhoColunaGrid = 250)]
        public string RazaoSocial { get; set; }

        [Column("CNPJ")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Cnpj { get; set; }

        [Column("IE")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string InscricaoEstadual { get; set; }

        [Column("IM")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string InscricaoMunicipal { get; set; }

        [Column("TELEFONE")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Telefone { get; set; }

        [Column("CELULAR")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Celular { get; set; }

        [Column("EMAIL")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Email { get; set; }

        [Column("SITE")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Site { get; set; }

        [Column("LOGO")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Logo { get; set; }

        [Column("CEP")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Cep { get; set; }

        [Column("ESTADO")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Estado { get; set; }

        [Column("CIDADE")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true)]
        public string Cidade { get; set; }

        [Column("BAIRRO")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Bairro { get; set; }

        [Column("RUA")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public string Rua { get; set; }

        [Column("NUMERO")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false)]
        public int? Numero { get; set; }

        [Column("TIPO_REGIME_ID")]
        [OpcoesBase(UsarNoBancoDeDados = true, UsarParaBuscar = true, UsarNaGrid = false, ChaveEstrangeira = "TIPO_REGIME_EMPRESA")]
        public int TipoRegime { get; set; }
    }
}
